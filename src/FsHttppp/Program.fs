// Learn more about F# at http://fsharp.org

open System
open FsHttp

[<EntryPoint>]
let main argv =
    http {
        POST "https://regres.in/api/users"
        CacheControl "no-cache"

        body
        json """
            "name": "morpheus",
            "job": "leader"
        """
    } |> ignore
    0 // return an integer exit code

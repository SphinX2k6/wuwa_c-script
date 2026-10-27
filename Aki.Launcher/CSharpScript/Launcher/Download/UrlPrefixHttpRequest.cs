using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Launcher.Download
{
	// Token: 0x02000201 RID: 513
	[NullableContext(1)]
	[Nullable(0)]
	public class UrlPrefixHttpRequest
	{
		// Token: 0x06000D33 RID: 3379 RVA: 0x0004FF7C File Offset: 0x0004E17C
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static UniTask<IResponse> httpRequest(string url)
		{
			UrlPrefixHttpRequest.<httpRequest>d__1 <httpRequest>d__;
			<httpRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<IResponse>.Create();
			<httpRequest>d__.url = url;
			<httpRequest>d__.<>1__state = -1;
			<httpRequest>d__.<>t__builder.Start<UrlPrefixHttpRequest.<httpRequest>d__1>(ref <httpRequest>d__);
			return <httpRequest>d__.<>t__builder.Task;
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x0004FFC0 File Offset: 0x0004E1C0
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public static UniTask<IResponse> HttpRequest(string url)
		{
			UrlPrefixHttpRequest.<HttpRequest>d__2 <HttpRequest>d__;
			<HttpRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<IResponse>.Create();
			<HttpRequest>d__.url = url;
			<HttpRequest>d__.<>1__state = -1;
			<HttpRequest>d__.<>t__builder.Start<UrlPrefixHttpRequest.<HttpRequest>d__2>(ref <HttpRequest>d__);
			return <HttpRequest>d__.<>t__builder.Task;
		}

		// Token: 0x04000848 RID: 2120
		private const float TimeOut = 3f;
	}
}

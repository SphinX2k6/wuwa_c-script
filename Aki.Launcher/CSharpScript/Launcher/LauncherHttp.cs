using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.NetworkDetection;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher
{
	// Token: 0x0200005E RID: 94
	[NullableContext(1)]
	[Nullable(0)]
	public static class LauncherHttp
	{
		// Token: 0x06000296 RID: 662 RVA: 0x0000D6D8 File Offset: 0x0000B8D8
		public static void Get(string url, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Dictionary<string, string> header = null, [Nullable(new byte[]
		{
			2,
			1
		})] Action<bool, int, string> responseCallBack = null, int? timeoutSecs = null)
		{
			LauncherHttp.<>c__DisplayClass1_0 CS$<>8__locals1 = new LauncherHttp.<>c__DisplayClass1_0();
			CS$<>8__locals1.responseCallBack = responseCallBack;
			TMap<string, string> tmap;
			if (header != null)
			{
				tmap = new TMap<string, string>();
				using (Dictionary<string, string>.Enumerator enumerator = header.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<string, string> keyValuePair = enumerator.Current;
						tmap.Add(keyValuePair.Key, keyValuePair.Value);
					}
					goto IL_5A;
				}
			}
			tmap = UKuroHttp.GetDefaultHeader();
			IL_5A:
			if (CS$<>8__locals1.responseCallBack == null)
			{
				UKuroHttp.Get(url, tmap, null, (float)timeoutSecs.GetValueOrDefault());
				return;
			}
			UKuroHttp.Get(url, tmap, DelegateUtils.ToManualReleaseDelegate<FHttpResponseHandle>(new Action<bool, int, string>(CS$<>8__locals1.<Get>g__ResponseInternal|0)), (float)timeoutSecs.GetValueOrDefault());
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0000D78C File Offset: 0x0000B98C
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static UniTask<IHttpPostResult> GetAsync(string url, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Dictionary<string, string> header = null, int? timeoutSecs = null)
		{
			LauncherHttp.<GetAsync>d__2 <GetAsync>d__;
			<GetAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<IHttpPostResult>.Create();
			<GetAsync>d__.url = url;
			<GetAsync>d__.header = header;
			<GetAsync>d__.timeoutSecs = timeoutSecs;
			<GetAsync>d__.<>1__state = -1;
			<GetAsync>d__.<>t__builder.Start<LauncherHttp.<GetAsync>d__2>(ref <GetAsync>d__);
			return <GetAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0000D7E0 File Offset: 0x0000B9E0
		public static void Post(string url, string content, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Dictionary<string, string> header = null, [Nullable(new byte[]
		{
			2,
			1
		})] Action<bool, int, string> responseCallBack = null, int? inTimeoutSecs = null)
		{
			LauncherHttp.<>c__DisplayClass3_0 CS$<>8__locals1 = new LauncherHttp.<>c__DisplayClass3_0();
			CS$<>8__locals1.responseCallBack = responseCallBack;
			TMap<string, string> tmap;
			if (header != null)
			{
				tmap = new TMap<string, string>();
				using (Dictionary<string, string>.Enumerator enumerator = header.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<string, string> keyValuePair = enumerator.Current;
						tmap.Add(keyValuePair.Key, keyValuePair.Value);
					}
					goto IL_5A;
				}
			}
			tmap = UKuroHttp.GetDefaultHeader();
			IL_5A:
			if (CS$<>8__locals1.responseCallBack == null)
			{
				UKuroHttp.Post(url, tmap, content, null, (float)inTimeoutSecs.GetValueOrDefault());
				return;
			}
			UKuroHttp.Post(url, tmap, content, DelegateUtils.ToManualReleaseDelegate<FHttpResponseHandle>(new Action<bool, int, string>(CS$<>8__locals1.<Post>g__ResponseInternal|0)), (float)inTimeoutSecs.GetValueOrDefault());
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0000D894 File Offset: 0x0000BA94
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static UniTask<IHttpPostResult> PostAsync(string url, string content, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Dictionary<string, string> header = null, int? inTimeoutSecs = null)
		{
			LauncherHttp.<PostAsync>d__4 <PostAsync>d__;
			<PostAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<IHttpPostResult>.Create();
			<PostAsync>d__.url = url;
			<PostAsync>d__.content = content;
			<PostAsync>d__.header = header;
			<PostAsync>d__.inTimeoutSecs = inTimeoutSecs;
			<PostAsync>d__.<>1__state = -1;
			<PostAsync>d__.<>t__builder.Start<LauncherHttp.<PostAsync>d__4>(ref <PostAsync>d__);
			return <PostAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0000D8EF File Offset: 0x0000BAEF
		public static void SetHttpThreadActiveMinimumSleepTimeInSeconds(float httpThreadActiveMinimumSleepTimeInSeconds)
		{
			UKuroStaticLibrary.SetHttpThreadActiveMinimumSleepTimeInSeconds(httpThreadActiveMinimumSleepTimeInSeconds);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000D8F7 File Offset: 0x0000BAF7
		public static void SetHttpThreadIdleMinimumSleepTimeInSeconds(float httpThreadIdleMinimumSleepTimeInSeconds)
		{
			UKuroStaticLibrary.SetHttpThreadIdleMinimumSleepTimeInSeconds(httpThreadIdleMinimumSleepTimeInSeconds);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0000D900 File Offset: 0x0000BB00
		public static bool IsConnectionInvalid(IHttpPostResult responseData)
		{
			bool flag = !responseData.Success && responseData.Code == 0;
			bool flag2 = responseData.Success && responseData.Code >= 400;
			return flag || flag2;
		}

		// Token: 0x04000195 RID: 405
		private const int BAD_REQUEST = 400;
	}
}

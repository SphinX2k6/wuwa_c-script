using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020000B0 RID: 176
[NullableContext(1)]
[Nullable(0)]
public class Http
{
	// Token: 0x06000548 RID: 1352 RVA: 0x0001C29C File Offset: 0x0001A49C
	public static void Get(string url, [Nullable(new byte[]
	{
		2,
		1,
		1
	})] Dictionary<string, string> header = null, [Nullable(new byte[]
	{
		2,
		1
	})] Action<bool, int, string> responseCallBack = null, float? timeoutSecs = null)
	{
		TMap<string, string> tmap = null;
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
				goto IL_5C;
			}
		}
		tmap = UKuroHttp.GetDefaultHeader();
		IL_5C:
		if (responseCallBack == null)
		{
			UKuroHttp.Get(url, tmap, null, timeoutSecs.GetValueOrDefault());
			return;
		}
		Action<bool, int, string> responseInternal = null;
		responseInternal = delegate(bool success, int code, string data)
		{
			responseCallBack(success, code, data);
			DelegateUtils.ReleaseManualReleaseDelegate(responseInternal);
		};
		UKuroHttp.Get(url, tmap, DelegateUtils.ToManualReleaseDelegate<FHttpResponseHandle>(responseInternal), timeoutSecs.GetValueOrDefault());
	}

	// Token: 0x06000549 RID: 1353 RVA: 0x0001C364 File Offset: 0x0001A564
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public static UniTask<HttpResponseData> GetAsync(string url, [Nullable(new byte[]
	{
		2,
		1,
		1
	})] Dictionary<string, string> header = null, float? timeoutSecs = null)
	{
		Http.<GetAsync>d__1 <GetAsync>d__;
		<GetAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<HttpResponseData>.Create();
		<GetAsync>d__.url = url;
		<GetAsync>d__.header = header;
		<GetAsync>d__.timeoutSecs = timeoutSecs;
		<GetAsync>d__.<>1__state = -1;
		<GetAsync>d__.<>t__builder.Start<Http.<GetAsync>d__1>(ref <GetAsync>d__);
		return <GetAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600054A RID: 1354 RVA: 0x0001C3B8 File Offset: 0x0001A5B8
	public static void Post(string url, string content, [Nullable(new byte[]
	{
		2,
		1,
		1
	})] Dictionary<string, string> header = null, [Nullable(new byte[]
	{
		2,
		1
	})] Action<bool, int, string> responseCallBack = null)
	{
		TMap<string, string> tmap = null;
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
				goto IL_5C;
			}
		}
		tmap = UKuroHttp.GetDefaultHeader();
		IL_5C:
		if (responseCallBack == null)
		{
			UKuroHttp.Post(url, tmap, content, null, 0f);
			return;
		}
		Action<bool, int, string> responseInternal = null;
		responseInternal = delegate(bool success, int code, string data)
		{
			responseCallBack(success, code, data);
			DelegateUtils.ReleaseManualReleaseDelegate(responseInternal);
		};
		UKuroHttp.Post(url, tmap, content, DelegateUtils.ToManualReleaseDelegate<FHttpResponseHandle>(responseInternal), 0f);
	}

	// Token: 0x0600054B RID: 1355 RVA: 0x0001C47C File Offset: 0x0001A67C
	public static void SetHttpThreadActiveMinimumSleepTimeInSeconds(float httpThreadActiveMinimumSleepTimeInSeconds)
	{
		UKuroStaticLibrary.SetHttpThreadActiveMinimumSleepTimeInSeconds(httpThreadActiveMinimumSleepTimeInSeconds);
	}

	// Token: 0x0600054C RID: 1356 RVA: 0x0001C484 File Offset: 0x0001A684
	public static void SetHttpThreadIdleMinimumSleepTimeInSeconds(float httpThreadIdleMinimumSleepTimeInSeconds)
	{
		UKuroStaticLibrary.SetHttpThreadIdleMinimumSleepTimeInSeconds(httpThreadIdleMinimumSleepTimeInSeconds);
	}

	// Token: 0x0600054D RID: 1357 RVA: 0x0001C48C File Offset: 0x0001A68C
	public static bool IsConnectionInvalid(HttpResponseData responseData)
	{
		bool flag = !responseData.Success && responseData.Code == 0;
		bool flag2 = responseData.Success && responseData.Code >= 400;
		return flag || flag2;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Download
{
	// Token: 0x020001FE RID: 510
	[NullableContext(1)]
	[Nullable(0)]
	public class UrlPrefixDownload
	{
		// Token: 0x06000D20 RID: 3360 RVA: 0x0004FBAA File Offset: 0x0004DDAA
		public void CancelDownload()
		{
			if (this.IsComplete)
			{
				return;
			}
			if (this.Proxy != null)
			{
				this.Proxy.Cancel();
			}
			this.DownloadCanceled = true;
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x0004FBD0 File Offset: 0x0004DDD0
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public UniTask<IEvaluateResult> StartEvaluatePrefix(List<RequestFileInfo> infos, bool bNewDownloaderProxy = false, [Nullable(2)] TProgressType progress = null)
		{
			UrlPrefixDownload.<StartEvaluatePrefix>d__10 <StartEvaluatePrefix>d__;
			<StartEvaluatePrefix>d__.<>t__builder = AsyncUniTaskMethodBuilder<IEvaluateResult>.Create();
			<StartEvaluatePrefix>d__.<>4__this = this;
			<StartEvaluatePrefix>d__.infos = infos;
			<StartEvaluatePrefix>d__.bNewDownloaderProxy = bNewDownloaderProxy;
			<StartEvaluatePrefix>d__.progress = progress;
			<StartEvaluatePrefix>d__.<>1__state = -1;
			<StartEvaluatePrefix>d__.<>t__builder.Start<UrlPrefixDownload.<StartEvaluatePrefix>d__10>(ref <StartEvaluatePrefix>d__);
			return <StartEvaluatePrefix>d__.<>t__builder.Task;
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x0004FC2C File Offset: 0x0004DE2C
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public UniTask<IDownloadResult> RequestFiles(List<RequestFileInfo> infos, bool bRestUrl, int tryCount, [Nullable(2)] TProgressType progress = null, bool bNeedEvaluate = false)
		{
			UrlPrefixDownload.<RequestFiles>d__11 <RequestFiles>d__;
			<RequestFiles>d__.<>t__builder = AsyncUniTaskMethodBuilder<IDownloadResult>.Create();
			<RequestFiles>d__.<>4__this = this;
			<RequestFiles>d__.infos = infos;
			<RequestFiles>d__.bRestUrl = bRestUrl;
			<RequestFiles>d__.tryCount = tryCount;
			<RequestFiles>d__.progress = progress;
			<RequestFiles>d__.bNeedEvaluate = bNeedEvaluate;
			<RequestFiles>d__.<>1__state = -1;
			<RequestFiles>d__.<>t__builder.Start<UrlPrefixDownload.<RequestFiles>d__11>(ref <RequestFiles>d__);
			return <RequestFiles>d__.<>t__builder.Task;
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x0004FC9C File Offset: 0x0004DE9C
		[return: Nullable(0)]
		public UniTask<bool> RequestFilesWithPrefix(List<RequestFileInfo> infos, List<string> prefixList, int tryCount, [Nullable(2)] TProgressType progress = null)
		{
			UrlPrefixDownload.<RequestFilesWithPrefix>d__12 <RequestFilesWithPrefix>d__;
			<RequestFilesWithPrefix>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestFilesWithPrefix>d__.<>4__this = this;
			<RequestFilesWithPrefix>d__.infos = infos;
			<RequestFilesWithPrefix>d__.prefixList = prefixList;
			<RequestFilesWithPrefix>d__.tryCount = tryCount;
			<RequestFilesWithPrefix>d__.progress = progress;
			<RequestFilesWithPrefix>d__.<>1__state = -1;
			<RequestFilesWithPrefix>d__.<>t__builder.Start<UrlPrefixDownload.<RequestFilesWithPrefix>d__12>(ref <RequestFilesWithPrefix>d__);
			return <RequestFilesWithPrefix>d__.<>t__builder.Task;
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x0004FD00 File Offset: 0x0004DF00
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<IEvaluateResult> EvaluatePrefixList(List<UrlPrefixInfo> prefixInfoList, List<RequestFileInfo> fileInfos, int urlIndex = 0, int fileIndex = 0)
		{
			UrlPrefixDownload.<EvaluatePrefixList>d__15 <EvaluatePrefixList>d__;
			<EvaluatePrefixList>d__.<>t__builder = AsyncUniTaskMethodBuilder<IEvaluateResult>.Create();
			<EvaluatePrefixList>d__.<>4__this = this;
			<EvaluatePrefixList>d__.prefixInfoList = prefixInfoList;
			<EvaluatePrefixList>d__.fileInfos = fileInfos;
			<EvaluatePrefixList>d__.urlIndex = urlIndex;
			<EvaluatePrefixList>d__.fileIndex = fileIndex;
			<EvaluatePrefixList>d__.<>1__state = -1;
			<EvaluatePrefixList>d__.<>t__builder.Start<UrlPrefixDownload.<EvaluatePrefixList>d__15>(ref <EvaluatePrefixList>d__);
			return <EvaluatePrefixList>d__.<>t__builder.Task;
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x0004FD64 File Offset: 0x0004DF64
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<IDownloadResult> UsePrefixListToDownloadFiles(List<string> urlPrefixList, List<RequestFileInfo> fileInfos, int tryDownloadCount, int urlIndex = 0, int fileIndex = 0)
		{
			UrlPrefixDownload.<UsePrefixListToDownloadFiles>d__16 <UsePrefixListToDownloadFiles>d__;
			<UsePrefixListToDownloadFiles>d__.<>t__builder = AsyncUniTaskMethodBuilder<IDownloadResult>.Create();
			<UsePrefixListToDownloadFiles>d__.<>4__this = this;
			<UsePrefixListToDownloadFiles>d__.urlPrefixList = urlPrefixList;
			<UsePrefixListToDownloadFiles>d__.fileInfos = fileInfos;
			<UsePrefixListToDownloadFiles>d__.tryDownloadCount = tryDownloadCount;
			<UsePrefixListToDownloadFiles>d__.urlIndex = urlIndex;
			<UsePrefixListToDownloadFiles>d__.fileIndex = fileIndex;
			<UsePrefixListToDownloadFiles>d__.<>1__state = -1;
			<UsePrefixListToDownloadFiles>d__.<>t__builder.Start<UrlPrefixDownload.<UsePrefixListToDownloadFiles>d__16>(ref <UsePrefixListToDownloadFiles>d__);
			return <UsePrefixListToDownloadFiles>d__.<>t__builder.Task;
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x0004FDD4 File Offset: 0x0004DFD4
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<IPrefixDownloadResult> UsePrefixToDownloadFiles(string urlPrefix, int urlIndex, List<RequestFileInfo> fileInfos, int fileIndex, int tryDownloadCount, float tryDownloadTime = -1f, bool bLimitTime = false, long downloadedSize = 0L)
		{
			UrlPrefixDownload.<UsePrefixToDownloadFiles>d__17 <UsePrefixToDownloadFiles>d__;
			<UsePrefixToDownloadFiles>d__.<>t__builder = AsyncUniTaskMethodBuilder<IPrefixDownloadResult>.Create();
			<UsePrefixToDownloadFiles>d__.<>4__this = this;
			<UsePrefixToDownloadFiles>d__.urlPrefix = urlPrefix;
			<UsePrefixToDownloadFiles>d__.urlIndex = urlIndex;
			<UsePrefixToDownloadFiles>d__.fileInfos = fileInfos;
			<UsePrefixToDownloadFiles>d__.fileIndex = fileIndex;
			<UsePrefixToDownloadFiles>d__.tryDownloadCount = tryDownloadCount;
			<UsePrefixToDownloadFiles>d__.tryDownloadTime = tryDownloadTime;
			<UsePrefixToDownloadFiles>d__.bLimitTime = bLimitTime;
			<UsePrefixToDownloadFiles>d__.downloadedSize = downloadedSize;
			<UsePrefixToDownloadFiles>d__.<>1__state = -1;
			<UsePrefixToDownloadFiles>d__.<>t__builder.Start<UrlPrefixDownload.<UsePrefixToDownloadFiles>d__17>(ref <UsePrefixToDownloadFiles>d__);
			return <UsePrefixToDownloadFiles>d__.<>t__builder.Task;
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x0004FE5C File Offset: 0x0004E05C
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<IPrefixDownloadResult> UsePrefixToDownloadFile(string urlPrefix, int urlIndex, RequestFileInfo fileInfo, int tryDownloadCount, float tryDownloadTime, bool bLimitTime, long downloadedSize = 0L)
		{
			UrlPrefixDownload.<UsePrefixToDownloadFile>d__18 <UsePrefixToDownloadFile>d__;
			<UsePrefixToDownloadFile>d__.<>t__builder = AsyncUniTaskMethodBuilder<IPrefixDownloadResult>.Create();
			<UsePrefixToDownloadFile>d__.<>4__this = this;
			<UsePrefixToDownloadFile>d__.urlPrefix = urlPrefix;
			<UsePrefixToDownloadFile>d__.urlIndex = urlIndex;
			<UsePrefixToDownloadFile>d__.fileInfo = fileInfo;
			<UsePrefixToDownloadFile>d__.tryDownloadCount = tryDownloadCount;
			<UsePrefixToDownloadFile>d__.tryDownloadTime = tryDownloadTime;
			<UsePrefixToDownloadFile>d__.bLimitTime = bLimitTime;
			<UsePrefixToDownloadFile>d__.downloadedSize = downloadedSize;
			<UsePrefixToDownloadFile>d__.<>1__state = -1;
			<UsePrefixToDownloadFile>d__.<>t__builder.Start<UrlPrefixDownload.<UsePrefixToDownloadFile>d__18>(ref <UsePrefixToDownloadFile>d__);
			return <UsePrefixToDownloadFile>d__.<>t__builder.Task;
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x0004FEDC File Offset: 0x0004E0DC
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<IPrefixDownloadResult> DownloadFile(string urlAddress, int urlIndex, bool bLimitTime, RequestFileInfo info, float time)
		{
			UrlPrefixDownload.<DownloadFile>d__19 <DownloadFile>d__;
			<DownloadFile>d__.<>t__builder = AsyncUniTaskMethodBuilder<IPrefixDownloadResult>.Create();
			<DownloadFile>d__.<>4__this = this;
			<DownloadFile>d__.urlAddress = urlAddress;
			<DownloadFile>d__.urlIndex = urlIndex;
			<DownloadFile>d__.bLimitTime = bLimitTime;
			<DownloadFile>d__.info = info;
			<DownloadFile>d__.time = time;
			<DownloadFile>d__.<>1__state = -1;
			<DownloadFile>d__.<>t__builder.Start<UrlPrefixDownload.<DownloadFile>d__19>(ref <DownloadFile>d__);
			return <DownloadFile>d__.<>t__builder.Task;
		}

		// Token: 0x0400083D RID: 2109
		public const string DOWNLOAD_SUFFIX = ".download";

		// Token: 0x0400083E RID: 2110
		private const float TIME_OUT = 3f;

		// Token: 0x0400083F RID: 2111
		private const long BigIntZero = 0L;

		// Token: 0x04000840 RID: 2112
		private const long BigIntKb = 1024L;

		// Token: 0x04000841 RID: 2113
		private const long KB_PER_MB = 1024L;

		// Token: 0x04000842 RID: 2114
		[Nullable(2)]
		private UDownloaderProxy Proxy;

		// Token: 0x04000843 RID: 2115
		private bool DownloadCanceled;

		// Token: 0x04000844 RID: 2116
		private bool IsComplete;

		// Token: 0x04000845 RID: 2117
		[Nullable(2)]
		private TProgressType ProgressCb;

		// Token: 0x02000442 RID: 1090
		[NullableContext(0)]
		private class EvaluatePrefixListPayload
		{
			// Token: 0x04001572 RID: 5490
			public bool IsComplete;

			// Token: 0x04001573 RID: 5491
			public int Point;

			// Token: 0x04001574 RID: 5492
			public long DownloadSize;

			// Token: 0x04001575 RID: 5493
			public int Speed;
		}

		// Token: 0x02000443 RID: 1091
		[NullableContext(0)]
		private class EvaluatePrefixListPayload2
		{
			// Token: 0x04001576 RID: 5494
			public bool IsComplete;

			// Token: 0x04001577 RID: 5495
			public float RemainTime;

			// Token: 0x04001578 RID: 5496
			public long DownloadSize;
		}
	}
}

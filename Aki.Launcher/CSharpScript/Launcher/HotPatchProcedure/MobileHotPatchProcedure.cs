using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Download;
using CSharpScript.Launcher.Ui.HotFix;
using CSharpScript.Launcher.Update;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.HotPatchProcedure
{
	// Token: 0x020001DB RID: 475
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class MobileHotPatchProcedure : BaseHotPatchProcedure
	{
		// Token: 0x06000CB6 RID: 3254 RVA: 0x0004F165 File Offset: 0x0004D365
		[NullableContext(1)]
		public MobileHotPatchProcedure(AppPathMisc pathMisc, HotFixManager viewMgr) : base(pathMisc, viewMgr)
		{
			this.IsAllowCellDownload = false;
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x0004F17D File Offset: 0x0004D37D
		[Nullable(1)]
		protected UKuroNetworkChange NetworkListener
		{
			[NullableContext(1)]
			get
			{
				if (this.NetworkListenerInternal == null)
				{
					this.NetworkListenerInternal = new UKuroNetworkChange();
				}
				return this.NetworkListenerInternal;
			}
		}

		// Token: 0x06000CB8 RID: 3256 RVA: 0x0004F198 File Offset: 0x0004D398
		[NullableContext(0)]
		public override UniTask<bool> UpdateResource(bool bUseBgDownload, [Nullable(1)] params ResourceUpdate[] updates)
		{
			MobileHotPatchProcedure.<UpdateResource>d__15 <UpdateResource>d__;
			<UpdateResource>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<UpdateResource>d__.<>4__this = this;
			<UpdateResource>d__.bUseBgDownload = bUseBgDownload;
			<UpdateResource>d__.updates = updates;
			<UpdateResource>d__.<>1__state = -1;
			<UpdateResource>d__.<>t__builder.Start<MobileHotPatchProcedure.<UpdateResource>d__15>(ref <UpdateResource>d__);
			return <UpdateResource>d__.<>t__builder.Task;
		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x0004F1EC File Offset: 0x0004D3EC
		[NullableContext(0)]
		protected override UniTask<bool> DownloadFiles(bool bUseBgDownload, [Nullable(1)] params ResourceUpdate[] updates)
		{
			MobileHotPatchProcedure.<DownloadFiles>d__16 <DownloadFiles>d__;
			<DownloadFiles>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<DownloadFiles>d__.<>4__this = this;
			<DownloadFiles>d__.bUseBgDownload = bUseBgDownload;
			<DownloadFiles>d__.updates = updates;
			<DownloadFiles>d__.<>1__state = -1;
			<DownloadFiles>d__.<>t__builder.Start<MobileHotPatchProcedure.<DownloadFiles>d__16>(ref <DownloadFiles>d__);
			return <DownloadFiles>d__.<>t__builder.Task;
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x0004F240 File Offset: 0x0004D440
		[NullableContext(0)]
		private UniTask<bool> DownloadRestrictByNetwork([Nullable(new byte[]
		{
			1,
			0,
			1
		})] Func<bool, UniTask<IDownloadResult>> downloadFunc, [Nullable(new byte[]
		{
			1,
			1,
			0
		})] Func<string, UniTask<bool>> showFailedDialog)
		{
			MobileHotPatchProcedure.<DownloadRestrictByNetwork>d__17 <DownloadRestrictByNetwork>d__;
			<DownloadRestrictByNetwork>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<DownloadRestrictByNetwork>d__.<>4__this = this;
			<DownloadRestrictByNetwork>d__.downloadFunc = downloadFunc;
			<DownloadRestrictByNetwork>d__.showFailedDialog = showFailedDialog;
			<DownloadRestrictByNetwork>d__.<>1__state = -1;
			<DownloadRestrictByNetwork>d__.<>t__builder.Start<MobileHotPatchProcedure.<DownloadRestrictByNetwork>d__17>(ref <DownloadRestrictByNetwork>d__);
			return <DownloadRestrictByNetwork>d__.<>t__builder.Task;
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x0004F294 File Offset: 0x0004D494
		[NullableContext(1)]
		[return: TupleElementNames(new string[]
		{
			"state",
			"httpCode"
		})]
		[return: Nullable(0)]
		private UniTask<ValueTuple<int, int>> BackgroundDownload(UKuroBgPrefixDownload bgDownloader, TArray<string> prefixList, TArray<FKuroRequestDownloadInfo> requestInfos, Action<int, long> cb, bool retry = false)
		{
			UniTaskCompletionSource<ValueTuple<int, int>> tcs = new UniTaskCompletionSource<ValueTuple<int, int>>();
			bgDownloader.ProgressDelegateNew.Clear();
			bgDownloader.AllCompleteDelegate.Clear();
			bgDownloader.ProgressDelegateNew.Add(cb);
			bgDownloader.AllCompleteDelegate.Add(delegate(int state, int httpCode)
			{
				tcs.TrySetResult(new ValueTuple<int, int>(state, httpCode));
			});
			if (!retry)
			{
				LauncherLog.Instance.Info("----->> ts start bg download.", default(ReadOnlySpan<ValueTuple<string, object>>));
				bgDownloader.Start(".download", prefixList, requestInfos, 3, 3f, BaseConfigController.Instance.IsUseNewHttpApi(), this.IsAllowCellDownload);
			}
			else
			{
				LauncherLog.Instance.Info("----->> ts continue bg download.", default(ReadOnlySpan<ValueTuple<string, object>>));
				bgDownloader.Continue(this.IsAllowCellDownload);
			}
			return tcs.Task;
		}

		// Token: 0x04000815 RID: 2069
		protected long? UpdateSize;

		// Token: 0x04000816 RID: 2070
		private long? DownSize;

		// Token: 0x04000817 RID: 2071
		private long? NeedSpace;

		// Token: 0x04000818 RID: 2072
		private bool IsAllowCellDownload;

		// Token: 0x04000819 RID: 2073
		private UrlPrefixDownload PrefixDownloader;

		// Token: 0x0400081A RID: 2074
		private UKuroBgPrefixDownload BgDownloader;

		// Token: 0x0400081B RID: 2075
		private UKuroNetworkChange NetworkListenerInternal;

		// Token: 0x0400081C RID: 2076
		private ENetworkType LastNetworkType = ENetworkType.None;

		// Token: 0x0400081D RID: 2077
		private bool CanceledByNetworkChange;

		// Token: 0x0400081E RID: 2078
		private bool UserAnsweredDialog;

		// Token: 0x0400081F RID: 2079
		private Action<bool> DialogCb;

		// Token: 0x04000820 RID: 2080
		private Action<byte> OnChangeNetworkType;
	}
}

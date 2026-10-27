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
	// Token: 0x020001D7 RID: 471
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class MobileHotPatchProcedure : BaseHotPatchProcedure
	{
		// Token: 0x06000C7F RID: 3199 RVA: 0x0004C951 File Offset: 0x0004AB51
		[NullableContext(1)]
		public MobileHotPatchProcedure(AppPathMisc pathMisc, HotFixManager viewMgr) : base(pathMisc, viewMgr)
		{
			this.IsAllowCellDownload = false;
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000C80 RID: 3200 RVA: 0x0004C969 File Offset: 0x0004AB69
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

		// Token: 0x06000C81 RID: 3201 RVA: 0x0004C984 File Offset: 0x0004AB84
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

		// Token: 0x06000C82 RID: 3202 RVA: 0x0004C9D8 File Offset: 0x0004ABD8
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

		// Token: 0x06000C83 RID: 3203 RVA: 0x0004CA2C File Offset: 0x0004AC2C
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

		// Token: 0x06000C84 RID: 3204 RVA: 0x0004CA80 File Offset: 0x0004AC80
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

		// Token: 0x040007D8 RID: 2008
		protected long? UpdateSize;

		// Token: 0x040007D9 RID: 2009
		private long? DownSize;

		// Token: 0x040007DA RID: 2010
		private long? NeedSpace;

		// Token: 0x040007DB RID: 2011
		private bool IsAllowCellDownload;

		// Token: 0x040007DC RID: 2012
		private UrlPrefixDownload PrefixDownloader;

		// Token: 0x040007DD RID: 2013
		private UKuroBgPrefixDownload BgDownloader;

		// Token: 0x040007DE RID: 2014
		private UKuroNetworkChange NetworkListenerInternal;

		// Token: 0x040007DF RID: 2015
		private ENetworkType LastNetworkType = ENetworkType.None;

		// Token: 0x040007E0 RID: 2016
		private bool CanceledByNetworkChange;

		// Token: 0x040007E1 RID: 2017
		private bool UserAnsweredDialog;

		// Token: 0x040007E2 RID: 2018
		private Action<bool> DialogCb;

		// Token: 0x040007E3 RID: 2019
		private Action<byte> OnChangeNetworkType;
	}
}

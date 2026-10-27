using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Download;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Updater
{
	// Token: 0x020000A9 RID: 169
	[NullableContext(1)]
	[Nullable(0)]
	public class ResourceDiffUpdater
	{
		// Token: 0x060005CA RID: 1482 RVA: 0x00033680 File Offset: 0x00031880
		public ResourceDiffUpdater(string name, int priority, List<ResPackageInfo> resPackageInfos)
		{
			this.Name = name;
			this.Priority = priority;
			this.ResPackageInfos = resPackageInfos;
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x000336C0 File Offset: 0x000318C0
		public UniTask Init()
		{
			ResourceDiffUpdater.<Init>d__9 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<ResourceDiffUpdater.<Init>d__9>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00033704 File Offset: 0x00031904
		protected virtual void CreateDiffUpdater()
		{
			UrlPrefixDownload downloader = new UrlPrefixDownload();
			this.ViewInfoInternal = new ResourceUpdateViewAgent();
			ResourceDiffUpdateUiEvent resourceDiffUpdateUiEvent = new ResourceDiffUpdateUiEvent();
			resourceDiffUpdateUiEvent.InitEvent(this.ViewInfoInternal);
			UpdateReportEvent reportEvent = new UpdateReportEvent(this.Name);
			this.DiffUpdater = new DiffUpdate(this.ResPackageInfos, downloader, resourceDiffUpdateUiEvent, reportEvent, true, EUpdateType.IndependentLang);
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00033758 File Offset: 0x00031958
		protected virtual UniTask AnalysisManifests()
		{
			ResourceDiffUpdater.<AnalysisManifests>d__11 <AnalysisManifests>d__;
			<AnalysisManifests>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AnalysisManifests>d__.<>4__this = this;
			<AnalysisManifests>d__.<>1__state = -1;
			<AnalysisManifests>d__.<>t__builder.Start<ResourceDiffUpdater.<AnalysisManifests>d__11>(ref <AnalysisManifests>d__);
			return <AnalysisManifests>d__.<>t__builder.Task;
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x0003379B File Offset: 0x0003199B
		protected virtual List<ResPackageInfo> EnumeratePacksWithActiveTierChild()
		{
			return ResPackageInfo.EnumerateWithTierChild(this.ResPackageInfos, RemoteInfo.Instance.ActiveTier);
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x000337B4 File Offset: 0x000319B4
		public virtual void CalculateSizeInfo()
		{
			if (this.UpdateStatus == EResDownloadStatus.Downloading)
			{
				return;
			}
			ValueTuple<long, long, long, long, long> valueTuple = this.DiffUpdater.CalcNeedSizeInfo(RemoteInfo.Instance.ActiveTier);
			long item = valueTuple.Item1;
			long item2 = valueTuple.Item2;
			long item3 = valueTuple.Item3;
			long item4 = valueTuple.Item4;
			long num = 0L;
			foreach (ResPackageInfo resPackageInfo in this.EnumeratePacksWithActiveTierChild())
			{
				num += resPackageInfo.CalculateSavedSizeAndTotalSize().Item2;
			}
			if (item3 == item4)
			{
				this.UpdateStatus = EResDownloadStatus.Down;
			}
			else if (item2 < item)
			{
				this.ViewInfoInternal.NotEnoughSpace = true;
				this.UpdateStatus = EResDownloadStatus.NoSpace;
			}
			else
			{
				this.ViewInfoInternal.NotEnoughSpace = false;
				this.UpdateStatus = EResDownloadStatus.None;
			}
			this.ViewInfoInternal.UpdatePatchProgress(0L, item3, item4, 0L);
			this.ViewInfoInternal.TotalSize = num;
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x000338A8 File Offset: 0x00031AA8
		public virtual UniTask UpdateResourceProcedure()
		{
			ResourceDiffUpdater.<UpdateResourceProcedure>d__14 <UpdateResourceProcedure>d__;
			<UpdateResourceProcedure>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateResourceProcedure>d__.<>4__this = this;
			<UpdateResourceProcedure>d__.<>1__state = -1;
			<UpdateResourceProcedure>d__.<>t__builder.Start<ResourceDiffUpdater.<UpdateResourceProcedure>d__14>(ref <UpdateResourceProcedure>d__);
			return <UpdateResourceProcedure>d__.<>t__builder.Task;
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x000338EC File Offset: 0x00031AEC
		public virtual void Stop()
		{
			LauncherLog instance = LauncherLog.Instance;
			string message = "ResourceDiffUpdater Stop";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Updater", this.Name);
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.UpdateStatus = EResDownloadStatus.Stop;
			if (this.DiffUpdater != null)
			{
				this.DiffUpdater.Stop();
			}
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x0003393C File Offset: 0x00031B3C
		public virtual bool IsCompleteDownloaded()
		{
			using (List<ResPackageInfo>.Enumerator enumerator = this.EnumeratePacksWithActiveTierChild().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!enumerator.Current.IsCompleteDownload())
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x00033998 File Offset: 0x00031B98
		public double SpendTime
		{
			get
			{
				return this.SpendTimeInternal;
			}
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x000339A0 File Offset: 0x00031BA0
		public virtual void Clear()
		{
			this.UpdateStatus = EResDownloadStatus.Cancel;
			this.Stop();
			foreach (ResPackageInfo resPackageInfo in this.EnumeratePacksWithActiveTierChild())
			{
				resPackageInfo.DeleteLocalFiles();
			}
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00033A00 File Offset: 0x00031C00
		public void AddOnDownloadFinish(Action<EResDownloadStatus> callback)
		{
			this.OnDownloadFinish.Add(callback);
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00033A10 File Offset: 0x00031C10
		public void RemoveOnDownload(Action<EResDownloadStatus> callback)
		{
			int num = this.OnDownloadFinish.IndexOf(callback);
			if (num != -1)
			{
				this.OnDownloadFinish.RemoveAt(num);
			}
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00033A3C File Offset: 0x00031C3C
		protected unsafe void InvokeDownloadFinishCallback()
		{
			LauncherLog instance = LauncherLog.Instance;
			string message = "ResourceDiffUpdater InvokeDownloadFinishCallback";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Updater", this.Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Status", this.UpdateStatus);
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			foreach (Action<EResDownloadStatus> action in this.OnDownloadFinish)
			{
				action(this.UpdateStatus);
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060005D8 RID: 1496 RVA: 0x00033AF0 File Offset: 0x00031CF0
		[Nullable(2)]
		public virtual ResourceUpdateViewAgent ViewInfo
		{
			[NullableContext(2)]
			get
			{
				return this.ViewInfoInternal;
			}
		}

		// Token: 0x0400039B RID: 923
		public string Name = "";

		// Token: 0x0400039C RID: 924
		public int Priority;

		// Token: 0x0400039D RID: 925
		public EResDownloadStatus UpdateStatus;

		// Token: 0x0400039E RID: 926
		protected double SpendTimeInternal;

		// Token: 0x0400039F RID: 927
		protected List<ResPackageInfo> ResPackageInfos = new List<ResPackageInfo>();

		// Token: 0x040003A0 RID: 928
		[Nullable(2)]
		protected DiffUpdate DiffUpdater;

		// Token: 0x040003A1 RID: 929
		[Nullable(2)]
		protected ResourceUpdateViewAgent ViewInfoInternal;

		// Token: 0x040003A2 RID: 930
		protected List<Action<EResDownloadStatus>> OnDownloadFinish = new List<Action<EResDownloadStatus>>();
	}
}

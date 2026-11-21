using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Download;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Updater
{
	// Token: 0x020000AC RID: 172
	[NullableContext(1)]
	[Nullable(0)]
	public class ResourceDiffUpdater
	{
		// Token: 0x060005E2 RID: 1506 RVA: 0x00034D10 File Offset: 0x00032F10
		public ResourceDiffUpdater(string name, int priority, List<ResPackageInfo> resPackageInfos)
		{
			this.Name = name;
			this.Priority = priority;
			this.ResPackageInfos = resPackageInfos;
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00034D50 File Offset: 0x00032F50
		public UniTask Init()
		{
			ResourceDiffUpdater.<Init>d__9 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<ResourceDiffUpdater.<Init>d__9>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00034D94 File Offset: 0x00032F94
		protected virtual void CreateDiffUpdater()
		{
			UrlPrefixDownload downloader = new UrlPrefixDownload();
			this.ViewInfoInternal = new ResourceUpdateViewAgent();
			ResourceDiffUpdateUiEvent resourceDiffUpdateUiEvent = new ResourceDiffUpdateUiEvent();
			resourceDiffUpdateUiEvent.InitEvent(this.ViewInfoInternal);
			UpdateReportEvent reportEvent = new UpdateReportEvent(this.Name);
			this.DiffUpdater = new DiffUpdate(this.ResPackageInfos, downloader, resourceDiffUpdateUiEvent, reportEvent, true, EUpdateType.IndependentLang);
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00034DE8 File Offset: 0x00032FE8
		protected virtual UniTask AnalysisManifests()
		{
			ResourceDiffUpdater.<AnalysisManifests>d__11 <AnalysisManifests>d__;
			<AnalysisManifests>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AnalysisManifests>d__.<>4__this = this;
			<AnalysisManifests>d__.<>1__state = -1;
			<AnalysisManifests>d__.<>t__builder.Start<ResourceDiffUpdater.<AnalysisManifests>d__11>(ref <AnalysisManifests>d__);
			return <AnalysisManifests>d__.<>t__builder.Task;
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00034E2B File Offset: 0x0003302B
		protected virtual List<ResPackageInfo> EnumeratePacksWithActiveTierChild()
		{
			return ResPackageInfo.EnumerateWithTierChild(this.ResPackageInfos, RemoteInfo.Instance.ActiveTier);
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00034E44 File Offset: 0x00033044
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

		// Token: 0x060005E8 RID: 1512 RVA: 0x00034F38 File Offset: 0x00033138
		public virtual UniTask UpdateResourceProcedure()
		{
			ResourceDiffUpdater.<UpdateResourceProcedure>d__14 <UpdateResourceProcedure>d__;
			<UpdateResourceProcedure>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateResourceProcedure>d__.<>4__this = this;
			<UpdateResourceProcedure>d__.<>1__state = -1;
			<UpdateResourceProcedure>d__.<>t__builder.Start<ResourceDiffUpdater.<UpdateResourceProcedure>d__14>(ref <UpdateResourceProcedure>d__);
			return <UpdateResourceProcedure>d__.<>t__builder.Task;
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00034F7C File Offset: 0x0003317C
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

		// Token: 0x060005EA RID: 1514 RVA: 0x00034FCC File Offset: 0x000331CC
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

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x00035028 File Offset: 0x00033228
		public double SpendTime
		{
			get
			{
				return this.SpendTimeInternal;
			}
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00035030 File Offset: 0x00033230
		public virtual void Clear()
		{
			this.UpdateStatus = EResDownloadStatus.Cancel;
			this.Stop();
			foreach (ResPackageInfo resPackageInfo in this.EnumeratePacksWithActiveTierChild())
			{
				resPackageInfo.DeleteLocalFiles();
			}
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00035090 File Offset: 0x00033290
		public void AddOnDownloadFinish(Action<EResDownloadStatus> callback)
		{
			this.OnDownloadFinish.Add(callback);
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x000350A0 File Offset: 0x000332A0
		public void RemoveOnDownload(Action<EResDownloadStatus> callback)
		{
			int num = this.OnDownloadFinish.IndexOf(callback);
			if (num != -1)
			{
				this.OnDownloadFinish.RemoveAt(num);
			}
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x000350CC File Offset: 0x000332CC
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

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060005F0 RID: 1520 RVA: 0x00035180 File Offset: 0x00033380
		[Nullable(2)]
		public virtual ResourceUpdateViewAgent ViewInfo
		{
			[NullableContext(2)]
			get
			{
				return this.ViewInfoInternal;
			}
		}

		// Token: 0x040003C9 RID: 969
		public string Name = "";

		// Token: 0x040003CA RID: 970
		public int Priority;

		// Token: 0x040003CB RID: 971
		public EResDownloadStatus UpdateStatus;

		// Token: 0x040003CC RID: 972
		protected double SpendTimeInternal;

		// Token: 0x040003CD RID: 973
		protected List<ResPackageInfo> ResPackageInfos = new List<ResPackageInfo>();

		// Token: 0x040003CE RID: 974
		[Nullable(2)]
		protected DiffUpdate DiffUpdater;

		// Token: 0x040003CF RID: 975
		[Nullable(2)]
		protected ResourceUpdateViewAgent ViewInfoInternal;

		// Token: 0x040003D0 RID: 976
		protected List<Action<EResDownloadStatus>> OnDownloadFinish = new List<Action<EResDownloadStatus>>();
	}
}

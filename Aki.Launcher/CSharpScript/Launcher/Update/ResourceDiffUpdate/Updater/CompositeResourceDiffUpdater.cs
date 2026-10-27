using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Updater
{
	// Token: 0x020000A5 RID: 165
	[NullableContext(1)]
	[Nullable(0)]
	public class CompositeResourceDiffUpdater : ResourceDiffUpdater
	{
		// Token: 0x060005A8 RID: 1448 RVA: 0x00032F60 File Offset: 0x00031160
		public CompositeResourceDiffUpdater(string name, int priority) : base(name, priority, new List<ResPackageInfo>())
		{
			this.ViewInfoInternal = new ResourceUpdateViewAgent();
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00032F85 File Offset: 0x00031185
		public void AddChild(ResourceDiffUpdater child)
		{
			this.Children.Add(child);
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00032F93 File Offset: 0x00031193
		public IReadOnlyList<ResourceDiffUpdater> GetChildren()
		{
			return this.Children;
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00032F9C File Offset: 0x0003119C
		public List<VideoResourceDiffUpdater> GetVideoUpdaters()
		{
			List<VideoResourceDiffUpdater> list = new List<VideoResourceDiffUpdater>();
			foreach (ResourceDiffUpdater resourceDiffUpdater in this.Children)
			{
				VideoResourceDiffUpdater videoResourceDiffUpdater = resourceDiffUpdater as VideoResourceDiffUpdater;
				if (videoResourceDiffUpdater != null)
				{
					list.Add(videoResourceDiffUpdater);
				}
			}
			return list;
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00033000 File Offset: 0x00031200
		public new UniTask Init()
		{
			CompositeResourceDiffUpdater.<Init>d__5 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<CompositeResourceDiffUpdater.<Init>d__5>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00033044 File Offset: 0x00031244
		protected override UniTask AnalysisManifests()
		{
			CompositeResourceDiffUpdater.<AnalysisManifests>d__6 <AnalysisManifests>d__;
			<AnalysisManifests>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AnalysisManifests>d__.<>1__state = -1;
			<AnalysisManifests>d__.<>t__builder.Start<CompositeResourceDiffUpdater.<AnalysisManifests>d__6>(ref <AnalysisManifests>d__);
			return <AnalysisManifests>d__.<>t__builder.Task;
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00033080 File Offset: 0x00031280
		public override void CalculateSizeInfo()
		{
			foreach (ResourceDiffUpdater resourceDiffUpdater in this.Children)
			{
				resourceDiffUpdater.CalculateSizeInfo();
			}
			this.SyncFromChildren();
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x000330D8 File Offset: 0x000312D8
		public override UniTask UpdateResourceProcedure()
		{
			CompositeResourceDiffUpdater.<UpdateResourceProcedure>d__8 <UpdateResourceProcedure>d__;
			<UpdateResourceProcedure>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateResourceProcedure>d__.<>4__this = this;
			<UpdateResourceProcedure>d__.<>1__state = -1;
			<UpdateResourceProcedure>d__.<>t__builder.Start<CompositeResourceDiffUpdater.<UpdateResourceProcedure>d__8>(ref <UpdateResourceProcedure>d__);
			return <UpdateResourceProcedure>d__.<>t__builder.Task;
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x0003311C File Offset: 0x0003131C
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private static UniTask<Exception> WrapTask(UniTask task)
		{
			CompositeResourceDiffUpdater.<WrapTask>d__9 <WrapTask>d__;
			<WrapTask>d__.<>t__builder = AsyncUniTaskMethodBuilder<Exception>.Create();
			<WrapTask>d__.task = task;
			<WrapTask>d__.<>1__state = -1;
			<WrapTask>d__.<>t__builder.Start<CompositeResourceDiffUpdater.<WrapTask>d__9>(ref <WrapTask>d__);
			return <WrapTask>d__.<>t__builder.Task;
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00033160 File Offset: 0x00031360
		public override void Stop()
		{
			LauncherLog instance = LauncherLog.Instance;
			string message = "CompositeResourceDiffUpdater Stop";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Updater", this.Name);
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			foreach (ResourceDiffUpdater resourceDiffUpdater in this.Children)
			{
				resourceDiffUpdater.Stop();
			}
			this.UpdateStatus = EResDownloadStatus.Stop;
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x000331E0 File Offset: 0x000313E0
		public override void Clear()
		{
			this.UpdateStatus = EResDownloadStatus.Cancel;
			foreach (ResourceDiffUpdater resourceDiffUpdater in this.Children)
			{
				resourceDiffUpdater.Clear();
			}
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00033238 File Offset: 0x00031438
		public override bool IsCompleteDownloaded()
		{
			using (List<ResourceDiffUpdater>.Enumerator enumerator = this.Children.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!enumerator.Current.IsCompleteDownloaded())
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060005B4 RID: 1460 RVA: 0x00033294 File Offset: 0x00031494
		public new double SpendTime
		{
			get
			{
				if (this.Children.Count == 0)
				{
					return 0.0;
				}
				double num = 0.0;
				foreach (ResourceDiffUpdater resourceDiffUpdater in this.Children)
				{
					if (resourceDiffUpdater.SpendTime > num)
					{
						num = resourceDiffUpdater.SpendTime;
					}
				}
				return num;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x00033314 File Offset: 0x00031514
		[Nullable(2)]
		public override ResourceUpdateViewAgent ViewInfo
		{
			[NullableContext(2)]
			get
			{
				this.SyncFromChildren();
				return this.ViewInfoInternal;
			}
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00033324 File Offset: 0x00031524
		private void SyncFromChildren()
		{
			long num = 0L;
			long num2 = 0L;
			long num3 = 0L;
			long num4 = 0L;
			long num5 = 0L;
			long num6 = 0L;
			bool flag = false;
			string text = "";
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = true;
			foreach (ResourceDiffUpdater resourceDiffUpdater in this.Children)
			{
				ResourceUpdateViewAgent viewInfo = resourceDiffUpdater.ViewInfo;
				if (viewInfo != null)
				{
					num += viewInfo.ReceiveSize;
					num2 += viewInfo.CurProgress;
					num3 += viewInfo.TotalProgress;
					num4 += viewInfo.TotalSize;
					num5 += viewInfo.DownloadSpeed;
					if (viewInfo.DownloadSpeedMax > num6)
					{
						num6 = viewInfo.DownloadSpeedMax;
					}
					flag = (flag || viewInfo.NotEnoughSpace);
					if (viewInfo.DownloadSpeed > 0L && text == "")
					{
						text = viewInfo.FileName;
					}
					if (resourceDiffUpdater.UpdateStatus == EResDownloadStatus.Failed)
					{
						flag2 = true;
					}
					if (resourceDiffUpdater.UpdateStatus == EResDownloadStatus.NoSpace)
					{
						flag3 = true;
					}
					if (resourceDiffUpdater.UpdateStatus != EResDownloadStatus.Down)
					{
						flag4 = false;
					}
				}
			}
			this.ViewInfoInternal.ReceiveSize = num;
			this.ViewInfoInternal.CurProgress = num2;
			this.ViewInfoInternal.TotalProgress = num3;
			this.ViewInfoInternal.TotalSize = num4;
			this.ViewInfoInternal.DownloadSpeed = num5;
			this.ViewInfoInternal.DownloadSpeedMax = num6;
			this.ViewInfoInternal.NotEnoughSpace = flag;
			this.ViewInfoInternal.FileName = text;
			if (this.UpdateStatus != EResDownloadStatus.Stop && this.UpdateStatus != EResDownloadStatus.Cancel)
			{
				if (flag2)
				{
					this.UpdateStatus = EResDownloadStatus.Failed;
					return;
				}
				if (flag3)
				{
					this.UpdateStatus = EResDownloadStatus.NoSpace;
					return;
				}
				if (flag4 && this.Children.Count > 0)
				{
					this.UpdateStatus = EResDownloadStatus.Down;
				}
			}
		}

		// Token: 0x04000385 RID: 901
		private readonly List<ResourceDiffUpdater> Children = new List<ResourceDiffUpdater>();
	}
}

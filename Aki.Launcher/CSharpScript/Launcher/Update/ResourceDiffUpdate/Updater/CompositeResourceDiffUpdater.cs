using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Updater
{
	// Token: 0x020000A8 RID: 168
	[NullableContext(1)]
	[Nullable(0)]
	public class CompositeResourceDiffUpdater : ResourceDiffUpdater
	{
		// Token: 0x060005C0 RID: 1472 RVA: 0x000345F0 File Offset: 0x000327F0
		public CompositeResourceDiffUpdater(string name, int priority) : base(name, priority, new List<ResPackageInfo>())
		{
			this.ViewInfoInternal = new ResourceUpdateViewAgent();
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00034615 File Offset: 0x00032815
		public void AddChild(ResourceDiffUpdater child)
		{
			this.Children.Add(child);
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00034623 File Offset: 0x00032823
		public IReadOnlyList<ResourceDiffUpdater> GetChildren()
		{
			return this.Children;
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x0003462C File Offset: 0x0003282C
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

		// Token: 0x060005C4 RID: 1476 RVA: 0x00034690 File Offset: 0x00032890
		public new UniTask Init()
		{
			CompositeResourceDiffUpdater.<Init>d__5 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<CompositeResourceDiffUpdater.<Init>d__5>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x000346D4 File Offset: 0x000328D4
		protected override UniTask AnalysisManifests()
		{
			CompositeResourceDiffUpdater.<AnalysisManifests>d__6 <AnalysisManifests>d__;
			<AnalysisManifests>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AnalysisManifests>d__.<>1__state = -1;
			<AnalysisManifests>d__.<>t__builder.Start<CompositeResourceDiffUpdater.<AnalysisManifests>d__6>(ref <AnalysisManifests>d__);
			return <AnalysisManifests>d__.<>t__builder.Task;
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00034710 File Offset: 0x00032910
		public override void CalculateSizeInfo()
		{
			foreach (ResourceDiffUpdater resourceDiffUpdater in this.Children)
			{
				resourceDiffUpdater.CalculateSizeInfo();
			}
			this.SyncFromChildren();
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00034768 File Offset: 0x00032968
		public override UniTask UpdateResourceProcedure()
		{
			CompositeResourceDiffUpdater.<UpdateResourceProcedure>d__8 <UpdateResourceProcedure>d__;
			<UpdateResourceProcedure>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateResourceProcedure>d__.<>4__this = this;
			<UpdateResourceProcedure>d__.<>1__state = -1;
			<UpdateResourceProcedure>d__.<>t__builder.Start<CompositeResourceDiffUpdater.<UpdateResourceProcedure>d__8>(ref <UpdateResourceProcedure>d__);
			return <UpdateResourceProcedure>d__.<>t__builder.Task;
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x000347AC File Offset: 0x000329AC
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

		// Token: 0x060005C9 RID: 1481 RVA: 0x000347F0 File Offset: 0x000329F0
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

		// Token: 0x060005CA RID: 1482 RVA: 0x00034870 File Offset: 0x00032A70
		public override void Clear()
		{
			this.UpdateStatus = EResDownloadStatus.Cancel;
			foreach (ResourceDiffUpdater resourceDiffUpdater in this.Children)
			{
				resourceDiffUpdater.Clear();
			}
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x000348C8 File Offset: 0x00032AC8
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

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060005CC RID: 1484 RVA: 0x00034924 File Offset: 0x00032B24
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

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060005CD RID: 1485 RVA: 0x000349A4 File Offset: 0x00032BA4
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

		// Token: 0x060005CE RID: 1486 RVA: 0x000349B4 File Offset: 0x00032BB4
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

		// Token: 0x040003B3 RID: 947
		private readonly List<ResourceDiffUpdater> Children = new List<ResourceDiffUpdater>();
	}
}

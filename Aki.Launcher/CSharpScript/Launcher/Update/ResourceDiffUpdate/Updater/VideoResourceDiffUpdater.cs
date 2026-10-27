using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.DiffPatch.Data;
using CSharpScript.Launcher.DiffPatch.Update;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Updater
{
	// Token: 0x020000AA RID: 170
	[NullableContext(1)]
	[Nullable(0)]
	public class VideoResourceDiffUpdater : ResourceDiffUpdater
	{
		// Token: 0x060005D9 RID: 1497 RVA: 0x00033AF8 File Offset: 0x00031CF8
		public VideoResourceDiffUpdater(string name, int priority, EVideoResSizeType videoResType) : base(name, priority, new List<ResPackageInfo>())
		{
			this.VideoResType = videoResType;
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00033B2C File Offset: 0x00031D2C
		public void SetDownloadVideos(List<int> videoIds, int gender)
		{
			this.VideoIds = videoIds;
			if (gender != -1)
			{
				this.Gender = gender;
			}
			List<string> list;
			if (this.VideoResType == EVideoResSizeType.Custom)
			{
				list = VideoResUpdate.Instance.GetVideoResPakByVideoIds(videoIds, null);
				list = ResourceDiffUpdaterManager.Instance.VideoModule.FilterVideoPacksByGender(list, gender);
			}
			else
			{
				list = new List<string>(VideoResUpdate.Instance.GetVideoResPak(this.VideoResType));
			}
			this.VideoPacks = new List<string>();
			foreach (string text in list)
			{
				if (VideoResUpdate.Instance.VideoMap.ContainsKey(text))
				{
					this.VideoPacks.Add(text);
				}
			}
			List<VideoResourceInfo> list2 = new List<VideoResourceInfo>();
			foreach (string key in this.VideoPacks)
			{
				list2.Add(VideoResUpdate.Instance.VideoMap[key]);
			}
			this.ResPackageInfos = new List<ResPackageInfo>
			{
				new VideoResPackageInfo(list2)
			};
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00033C6C File Offset: 0x00031E6C
		public override UniTask UpdateResourceProcedure()
		{
			VideoResourceDiffUpdater.<UpdateResourceProcedure>d__6 <UpdateResourceProcedure>d__;
			<UpdateResourceProcedure>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateResourceProcedure>d__.<>4__this = this;
			<UpdateResourceProcedure>d__.<>1__state = -1;
			<UpdateResourceProcedure>d__.<>t__builder.Start<VideoResourceDiffUpdater.<UpdateResourceProcedure>d__6>(ref <UpdateResourceProcedure>d__);
			return <UpdateResourceProcedure>d__.<>t__builder.Task;
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00033CB0 File Offset: 0x00031EB0
		protected override UniTask AnalysisManifests()
		{
			VideoResourceDiffUpdater.<AnalysisManifests>d__7 <AnalysisManifests>d__;
			<AnalysisManifests>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AnalysisManifests>d__.<>4__this = this;
			<AnalysisManifests>d__.<>1__state = -1;
			<AnalysisManifests>d__.<>t__builder.Start<VideoResourceDiffUpdater.<AnalysisManifests>d__7>(ref <AnalysisManifests>d__);
			return <AnalysisManifests>d__.<>t__builder.Task;
		}

		// Token: 0x040003A3 RID: 931
		public List<int> VideoIds = new List<int>();

		// Token: 0x040003A4 RID: 932
		public int Gender = -1;

		// Token: 0x040003A5 RID: 933
		public readonly EVideoResSizeType VideoResType;

		// Token: 0x040003A6 RID: 934
		private List<string> VideoPacks = new List<string>();
	}
}

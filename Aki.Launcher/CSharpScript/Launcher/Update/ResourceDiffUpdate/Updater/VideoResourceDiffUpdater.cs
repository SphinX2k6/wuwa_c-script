using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.DiffPatch.Data;
using CSharpScript.Launcher.DiffPatch.Update;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Updater
{
	// Token: 0x020000AD RID: 173
	[NullableContext(1)]
	[Nullable(0)]
	public class VideoResourceDiffUpdater : ResourceDiffUpdater
	{
		// Token: 0x060005F1 RID: 1521 RVA: 0x00035188 File Offset: 0x00033388
		public VideoResourceDiffUpdater(string name, int priority, EVideoResSizeType videoResType) : base(name, priority, new List<ResPackageInfo>())
		{
			this.VideoResType = videoResType;
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x000351BC File Offset: 0x000333BC
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

		// Token: 0x060005F3 RID: 1523 RVA: 0x000352FC File Offset: 0x000334FC
		public override UniTask UpdateResourceProcedure()
		{
			VideoResourceDiffUpdater.<UpdateResourceProcedure>d__6 <UpdateResourceProcedure>d__;
			<UpdateResourceProcedure>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateResourceProcedure>d__.<>4__this = this;
			<UpdateResourceProcedure>d__.<>1__state = -1;
			<UpdateResourceProcedure>d__.<>t__builder.Start<VideoResourceDiffUpdater.<UpdateResourceProcedure>d__6>(ref <UpdateResourceProcedure>d__);
			return <UpdateResourceProcedure>d__.<>t__builder.Task;
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00035340 File Offset: 0x00033540
		protected override UniTask AnalysisManifests()
		{
			VideoResourceDiffUpdater.<AnalysisManifests>d__7 <AnalysisManifests>d__;
			<AnalysisManifests>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AnalysisManifests>d__.<>4__this = this;
			<AnalysisManifests>d__.<>1__state = -1;
			<AnalysisManifests>d__.<>t__builder.Start<VideoResourceDiffUpdater.<AnalysisManifests>d__7>(ref <AnalysisManifests>d__);
			return <AnalysisManifests>d__.<>t__builder.Task;
		}

		// Token: 0x040003D1 RID: 977
		public List<int> VideoIds = new List<int>();

		// Token: 0x040003D2 RID: 978
		public int Gender = -1;

		// Token: 0x040003D3 RID: 979
		public readonly EVideoResSizeType VideoResType;

		// Token: 0x040003D4 RID: 980
		private List<string> VideoPacks = new List<string>();
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Util;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x02000238 RID: 568
	public class VideoResPackageInfo : ResPackageInfo
	{
		// Token: 0x06000E63 RID: 3683 RVA: 0x000558B4 File Offset: 0x00053AB4
		[NullableContext(1)]
		public VideoResPackageInfo(List<VideoResourceInfo> videoInfos) : base(BaseConfigController.Instance.GetResUri(), new VideoVersionInfo(videoInfos.Count > 0), false)
		{
			this.videoInfos = videoInfos;
			this.totalFileCount = videoInfos.Count * 2;
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x000558EA File Offset: 0x00053AEA
		public bool IsVideoPackage()
		{
			return true;
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x000558F0 File Offset: 0x00053AF0
		[return: TupleElementNames(new string[]
		{
			"requireFiles",
			"localSavedSize",
			"totalDownloadSize",
			"totalNeedSpace",
			"totalDownloadAndPatch",
			"allResSize",
			"allFileExpectSize",
			"allFileSavedSize",
			"allFileCount",
			null,
			null
		})]
		[return: Nullable(new byte[]
		{
			0,
			1,
			1,
			0
		})]
		public override ValueTuple<List<RequireFileInfo>, long, long, long, long, long, long, ValueTuple<long, int>> AnalyzeRequireFiles(bool bForceDownload = false, ETier _tier = ETier.None)
		{
			List<RequireFileInfo> list = new List<RequireFileInfo>();
			long num = 0L;
			long num2 = 0L;
			foreach (VideoResourceInfo singleInfo in this.videoInfos)
			{
				ValueTuple<List<LocalFileInfo>, List<RequireFileInfo>, long, long> valueTuple = VideoResUpdate.Instance.AnalyzeSingle(singleInfo);
				List<RequireFileInfo> item = valueTuple.Item2;
				long item2 = valueTuple.Item3;
				long item3 = valueTuple.Item4;
				list.AddRange(item);
				num += item2;
				num2 += item3;
			}
			long num3 = num - num2;
			this.SpaceModel.DownloadSize = num;
			this.SpaceModel.SavedSize = num2;
			this.SpaceModel.PatchPeak = 0L;
			this.SpaceModel.PatchNetDelta = 0L;
			this.SpaceModel.CopySize = 0L;
			return new ValueTuple<List<RequireFileInfo>, long, long, long, long, long, long, ValueTuple<long, int>>(list, num2, num3, num3, num, num, num, new ValueTuple<long, int>(num2, this.totalFileCount));
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x000559DC File Offset: 0x00053BDC
		public override void UpdateRecord()
		{
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x000559DE File Offset: 0x00053BDE
		public override bool NeedPatch()
		{
			return false;
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x000559E1 File Offset: 0x00053BE1
		[return: Nullable(new byte[]
		{
			0,
			1,
			1,
			1,
			0,
			1,
			1
		})]
		public override ValueTuple<List<string>, List<ValueTuple<string, string, int>>> GetMountInfos()
		{
			return new ValueTuple<List<string>, List<ValueTuple<string, string, int>>>(new List<string>(), new List<ValueTuple<string, string, int>>());
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x000559F2 File Offset: 0x00053BF2
		public override void CollectAllFiles()
		{
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x000559F4 File Offset: 0x00053BF4
		public override bool IsCompleteUpdate()
		{
			foreach (VideoResourceInfo singleInfo in this.videoInfos)
			{
				ValueTuple<List<LocalFileInfo>, List<RequireFileInfo>, long, long> valueTuple = VideoResUpdate.Instance.AnalyzeSingle(singleInfo);
				long item = valueTuple.Item3;
				long item2 = valueTuple.Item4;
				if (item != item2)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x00055A68 File Offset: 0x00053C68
		public override ValueTuple<long, long> CalculateSavedSizeAndTotalSize()
		{
			long num = 0L;
			long num2 = 0L;
			foreach (VideoResourceInfo singleInfo in this.videoInfos)
			{
				ValueTuple<List<LocalFileInfo>, List<RequireFileInfo>, long, long> valueTuple = VideoResUpdate.Instance.AnalyzeSingle(singleInfo);
				long item = valueTuple.Item3;
				long item2 = valueTuple.Item4;
				num2 += item;
				num += item2;
			}
			return new ValueTuple<long, long>(num, num2);
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x00055AE8 File Offset: 0x00053CE8
		public override bool IsCompleteDownload()
		{
			return this.IsCompleteUpdate();
		}

		// Token: 0x04000925 RID: 2341
		[Nullable(1)]
		private readonly List<VideoResourceInfo> videoInfos;

		// Token: 0x04000926 RID: 2342
		private readonly int totalFileCount;
	}
}

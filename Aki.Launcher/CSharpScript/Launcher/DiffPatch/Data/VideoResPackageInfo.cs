using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Util;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x0200023D RID: 573
	public class VideoResPackageInfo : ResPackageInfo
	{
		// Token: 0x06000EA4 RID: 3748 RVA: 0x000583BC File Offset: 0x000565BC
		[NullableContext(1)]
		public VideoResPackageInfo(List<VideoResourceInfo> videoInfos) : base(BaseConfigController.Instance.GetResUri(), new VideoVersionInfo(videoInfos.Count > 0), false)
		{
			this.videoInfos = videoInfos;
			this.totalFileCount = videoInfos.Count * 2;
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x000583F2 File Offset: 0x000565F2
		public bool IsVideoPackage()
		{
			return true;
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x000583F8 File Offset: 0x000565F8
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

		// Token: 0x06000EA7 RID: 3751 RVA: 0x000584E4 File Offset: 0x000566E4
		public override void UpdateRecord()
		{
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x000584E6 File Offset: 0x000566E6
		public override bool NeedPatch()
		{
			return false;
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x000584E9 File Offset: 0x000566E9
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

		// Token: 0x06000EAA RID: 3754 RVA: 0x000584FA File Offset: 0x000566FA
		public override void CollectAllFiles()
		{
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x000584FC File Offset: 0x000566FC
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

		// Token: 0x06000EAC RID: 3756 RVA: 0x00058570 File Offset: 0x00056770
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

		// Token: 0x06000EAD RID: 3757 RVA: 0x000585F0 File Offset: 0x000567F0
		public override bool IsCompleteDownload()
		{
			return this.IsCompleteUpdate();
		}

		// Token: 0x04000967 RID: 2407
		[Nullable(1)]
		private readonly List<VideoResourceInfo> videoInfos;

		// Token: 0x04000968 RID: 2408
		private readonly int totalFileCount;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002804 RID: 10244
[NullableContext(1)]
[Nullable(0)]
public class RoleDevPhantomSuitItemData
{
	// Token: 0x06015049 RID: 86089 RVA: 0x00552AB2 File Offset: 0x00550CB2
	[NullableContext(2)]
	public void Init(int fetterGroupId, int roleId, VisionFetterRecommendInfo visionFetterRecommendInfo)
	{
		this.SuitIdInternal = fetterGroupId;
		this.RoleIdInternal = roleId;
		this.VisionFetterRecommendInfoInternal = visionFetterRecommendInfo;
	}

	// Token: 0x17001BB0 RID: 7088
	// (get) Token: 0x0601504A RID: 86090 RVA: 0x00552AC9 File Offset: 0x00550CC9
	public int SuitId
	{
		get
		{
			return this.SuitIdInternal;
		}
	}

	// Token: 0x17001BB1 RID: 7089
	// (get) Token: 0x0601504B RID: 86091 RVA: 0x00552AD1 File Offset: 0x00550CD1
	public int RoleId
	{
		get
		{
			return this.RoleIdInternal;
		}
	}

	// Token: 0x17001BB2 RID: 7090
	// (get) Token: 0x0601504C RID: 86092 RVA: 0x00552AD9 File Offset: 0x00550CD9
	public List<int> RecommendGroupIds
	{
		get
		{
			VisionFetterRecommendInfo visionFetterRecommendInfoInternal = this.VisionFetterRecommendInfoInternal;
			return ((visionFetterRecommendInfoInternal != null) ? visionFetterRecommendInfoInternal.BuildFetterList() : null) ?? new List<int>();
		}
	}

	// Token: 0x17001BB3 RID: 7091
	// (get) Token: 0x0601504D RID: 86093 RVA: 0x00552AF6 File Offset: 0x00550CF6
	public int UseRate
	{
		get
		{
			VisionFetterRecommendInfo visionFetterRecommendInfoInternal = this.VisionFetterRecommendInfoInternal;
			if (visionFetterRecommendInfoInternal == null)
			{
				return 0;
			}
			return visionFetterRecommendInfoInternal.GetUsage();
		}
	}

	// Token: 0x17001BB4 RID: 7092
	// (get) Token: 0x0601504E RID: 86094 RVA: 0x00552B09 File Offset: 0x00550D09
	public string UseRateText
	{
		get
		{
			VisionFetterRecommendInfo visionFetterRecommendInfoInternal = this.VisionFetterRecommendInfoInternal;
			return ((visionFetterRecommendInfoInternal != null) ? visionFetterRecommendInfoInternal.GetUsageText() : null) ?? "";
		}
	}

	// Token: 0x17001BB5 RID: 7093
	// (get) Token: 0x0601504F RID: 86095 RVA: 0x00552B28 File Offset: 0x00550D28
	public PhantomFetterGroup? FetterGroupConfig
	{
		get
		{
			PhantomBattleConfig instance = PhantomBattleConfig.Instance;
			if (instance == null)
			{
				return null;
			}
			return new PhantomFetterGroup?(instance.GetFetterGroupById(this.SuitIdInternal));
		}
	}

	// Token: 0x17001BB6 RID: 7094
	// (get) Token: 0x06015050 RID: 86096 RVA: 0x00552B58 File Offset: 0x00550D58
	public string SuitName
	{
		get
		{
			PhantomFetterGroup? phantomFetterGroup;
			return ((this.FetterGroupConfig != null) ? phantomFetterGroup.GetValueOrDefault().FetterGroupName : null) ?? "";
		}
	}

	// Token: 0x17001BB7 RID: 7095
	// (get) Token: 0x06015051 RID: 86097 RVA: 0x00552B90 File Offset: 0x00550D90
	public bool HasElementIcon
	{
		get
		{
			PhantomFetterGroup? phantomFetterGroup;
			return !string.IsNullOrEmpty((this.FetterGroupConfig != null) ? phantomFetterGroup.GetValueOrDefault().FetterElementPath : null);
		}
	}

	// Token: 0x17001BB8 RID: 7096
	// (get) Token: 0x06015052 RID: 86098 RVA: 0x00552BC8 File Offset: 0x00550DC8
	[Nullable(2)]
	public string ElementColor
	{
		[NullableContext(2)]
		get
		{
			if (this.FetterGroupConfig == null)
			{
				return null;
			}
			PhantomFetterGroup? phantomFetterGroup;
			return phantomFetterGroup.GetValueOrDefault().FetterElementColor;
		}
	}

	// Token: 0x17001BB9 RID: 7097
	// (get) Token: 0x06015053 RID: 86099 RVA: 0x00552BF8 File Offset: 0x00550DF8
	[Nullable(2)]
	public string ElementIconPath
	{
		[NullableContext(2)]
		get
		{
			if (this.FetterGroupConfig == null)
			{
				return null;
			}
			PhantomFetterGroup? phantomFetterGroup;
			return phantomFetterGroup.GetValueOrDefault().FetterElementPath;
		}
	}

	// Token: 0x17001BBA RID: 7098
	// (get) Token: 0x06015054 RID: 86100 RVA: 0x00552C28 File Offset: 0x00550E28
	public List<int> DungeonIdList
	{
		get
		{
			RoleDevConfig instance = RoleDevConfig.Instance;
			RoleDevPhantomJumpGroup? roleDevPhantomJumpGroup = (instance != null) ? instance.GetPhantomJumpGroupConfig(this.SuitIdInternal) : null;
			if (roleDevPhantomJumpGroup == null)
			{
				return new List<int>();
			}
			int[] array = roleDevPhantomJumpGroup.Value.PhantomJumpId();
			if (array == null)
			{
				return new List<int>();
			}
			return new List<int>(array);
		}
	}

	// Token: 0x04009E01 RID: 40449
	private int SuitIdInternal;

	// Token: 0x04009E02 RID: 40450
	private int RoleIdInternal;

	// Token: 0x04009E03 RID: 40451
	[Nullable(2)]
	private VisionFetterRecommendInfo VisionFetterRecommendInfoInternal;
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001D7F RID: 7551
[NullableContext(1)]
[Nullable(0)]
public class RoleDevPhantomSuitItemData
{
	// Token: 0x06012A49 RID: 76361 RVA: 0x0057D886 File Offset: 0x0057BA86
	[NullableContext(2)]
	public void Init(int fetterGroupId, int roleId, VisionFetterRecommendInfo visionFetterRecommendInfo)
	{
		this.SuitIdInternal = fetterGroupId;
		this.RoleIdInternal = roleId;
		this.VisionFetterRecommendInfoInternal = visionFetterRecommendInfo;
	}

	// Token: 0x17001C08 RID: 7176
	// (get) Token: 0x06012A4A RID: 76362 RVA: 0x0057D89D File Offset: 0x0057BA9D
	public int SuitId
	{
		get
		{
			return this.SuitIdInternal;
		}
	}

	// Token: 0x17001C09 RID: 7177
	// (get) Token: 0x06012A4B RID: 76363 RVA: 0x0057D8A5 File Offset: 0x0057BAA5
	public int RoleId
	{
		get
		{
			return this.RoleIdInternal;
		}
	}

	// Token: 0x17001C0A RID: 7178
	// (get) Token: 0x06012A4C RID: 76364 RVA: 0x0057D8AD File Offset: 0x0057BAAD
	public List<int> RecommendGroupIds
	{
		get
		{
			VisionFetterRecommendInfo visionFetterRecommendInfoInternal = this.VisionFetterRecommendInfoInternal;
			return ((visionFetterRecommendInfoInternal != null) ? visionFetterRecommendInfoInternal.BuildFetterList() : null) ?? new List<int>();
		}
	}

	// Token: 0x17001C0B RID: 7179
	// (get) Token: 0x06012A4D RID: 76365 RVA: 0x0057D8CA File Offset: 0x0057BACA
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

	// Token: 0x17001C0C RID: 7180
	// (get) Token: 0x06012A4E RID: 76366 RVA: 0x0057D8DD File Offset: 0x0057BADD
	public string UseRateText
	{
		get
		{
			VisionFetterRecommendInfo visionFetterRecommendInfoInternal = this.VisionFetterRecommendInfoInternal;
			return ((visionFetterRecommendInfoInternal != null) ? visionFetterRecommendInfoInternal.GetUsageText() : null) ?? "";
		}
	}

	// Token: 0x17001C0D RID: 7181
	// (get) Token: 0x06012A4F RID: 76367 RVA: 0x0057D8FC File Offset: 0x0057BAFC
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

	// Token: 0x17001C0E RID: 7182
	// (get) Token: 0x06012A50 RID: 76368 RVA: 0x0057D92C File Offset: 0x0057BB2C
	public string SuitName
	{
		get
		{
			PhantomFetterGroup? phantomFetterGroup;
			return ((this.FetterGroupConfig != null) ? phantomFetterGroup.GetValueOrDefault().FetterGroupName : null) ?? "";
		}
	}

	// Token: 0x17001C0F RID: 7183
	// (get) Token: 0x06012A51 RID: 76369 RVA: 0x0057D964 File Offset: 0x0057BB64
	public bool HasElementIcon
	{
		get
		{
			PhantomFetterGroup? phantomFetterGroup;
			return !string.IsNullOrEmpty((this.FetterGroupConfig != null) ? phantomFetterGroup.GetValueOrDefault().FetterElementPath : null);
		}
	}

	// Token: 0x17001C10 RID: 7184
	// (get) Token: 0x06012A52 RID: 76370 RVA: 0x0057D99C File Offset: 0x0057BB9C
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

	// Token: 0x17001C11 RID: 7185
	// (get) Token: 0x06012A53 RID: 76371 RVA: 0x0057D9CC File Offset: 0x0057BBCC
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

	// Token: 0x17001C12 RID: 7186
	// (get) Token: 0x06012A54 RID: 76372 RVA: 0x0057D9FC File Offset: 0x0057BBFC
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

	// Token: 0x0400A1EA RID: 41450
	private int SuitIdInternal;

	// Token: 0x0400A1EB RID: 41451
	private int RoleIdInternal;

	// Token: 0x0400A1EC RID: 41452
	[Nullable(2)]
	private VisionFetterRecommendInfo VisionFetterRecommendInfoInternal;
}

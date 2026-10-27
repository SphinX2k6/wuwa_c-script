using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200244F RID: 9295
[NullableContext(1)]
[Nullable(0)]
public class VisionAttrRecommendInfo
{
	// Token: 0x06012A49 RID: 76361 RVA: 0x0049969C File Offset: 0x0049789C
	public VisionAttrRecommendInfo()
	{
		this.MainAttrRecommendInfo = new List<AttrRecommendInfo>();
		this.SubAttrRecommendInfo = new List<AttrRecommendInfo>();
		this.OfficialMainAttrRecommendInfo = new List<AttrRecommendInfo>();
		this.OfficialSubAttrRecommendInfo = new List<AttrRecommendInfo>();
		this.UsageMainAttrRecommendInfo = new List<AttrRecommendInfo>();
		this.UsageSubAttrRecommendInfo = new List<AttrRecommendInfo>();
	}

	// Token: 0x06012A4A RID: 76362 RVA: 0x004996F1 File Offset: 0x004978F1
	public List<AttrRecommendInfo> GetMainAttrRecommendInfo()
	{
		return this.MainAttrRecommendInfo;
	}

	// Token: 0x06012A4B RID: 76363 RVA: 0x004996F9 File Offset: 0x004978F9
	public List<AttrRecommendInfo> GetSubAttrRecommendInfo()
	{
		return this.SubAttrRecommendInfo;
	}

	// Token: 0x06012A4C RID: 76364 RVA: 0x00499701 File Offset: 0x00497901
	public List<AttrRecommendInfo> GetOfficialMainAttrRecommendInfo()
	{
		return this.OfficialMainAttrRecommendInfo;
	}

	// Token: 0x06012A4D RID: 76365 RVA: 0x00499709 File Offset: 0x00497909
	public List<AttrRecommendInfo> GetOfficialSubAttrRecommendInfo()
	{
		return this.OfficialSubAttrRecommendInfo;
	}

	// Token: 0x06012A4E RID: 76366 RVA: 0x00499711 File Offset: 0x00497911
	public List<AttrRecommendInfo> GetUsageMainAttrRecommendInfo()
	{
		return this.UsageMainAttrRecommendInfo;
	}

	// Token: 0x06012A4F RID: 76367 RVA: 0x00499719 File Offset: 0x00497919
	public List<AttrRecommendInfo> GetUsageSubAttrRecommendInfo()
	{
		return this.UsageSubAttrRecommendInfo;
	}

	// Token: 0x06012A50 RID: 76368 RVA: 0x00499724 File Offset: 0x00497924
	public void BuildPlanLists()
	{
		this.OfficialMainAttrRecommendInfo.Clear();
		this.OfficialSubAttrRecommendInfo.Clear();
		this.UsageMainAttrRecommendInfo.Clear();
		this.UsageSubAttrRecommendInfo.Clear();
		foreach (AttrRecommendInfo attrRecommendInfo in this.MainAttrRecommendInfo)
		{
			if (attrRecommendInfo.GetUsage() == 0)
			{
				this.OfficialMainAttrRecommendInfo.Add(attrRecommendInfo);
			}
			else
			{
				this.UsageMainAttrRecommendInfo.Add(attrRecommendInfo);
			}
		}
		foreach (AttrRecommendInfo attrRecommendInfo2 in this.SubAttrRecommendInfo)
		{
			if (attrRecommendInfo2.GetUsage() == 0)
			{
				this.OfficialSubAttrRecommendInfo.Add(attrRecommendInfo2);
			}
			else
			{
				this.UsageSubAttrRecommendInfo.Add(attrRecommendInfo2);
			}
		}
	}

	// Token: 0x04008C74 RID: 35956
	private readonly List<AttrRecommendInfo> MainAttrRecommendInfo;

	// Token: 0x04008C75 RID: 35957
	private readonly List<AttrRecommendInfo> SubAttrRecommendInfo;

	// Token: 0x04008C76 RID: 35958
	private readonly List<AttrRecommendInfo> OfficialMainAttrRecommendInfo;

	// Token: 0x04008C77 RID: 35959
	private readonly List<AttrRecommendInfo> OfficialSubAttrRecommendInfo;

	// Token: 0x04008C78 RID: 35960
	private readonly List<AttrRecommendInfo> UsageMainAttrRecommendInfo;

	// Token: 0x04008C79 RID: 35961
	private readonly List<AttrRecommendInfo> UsageSubAttrRecommendInfo;
}

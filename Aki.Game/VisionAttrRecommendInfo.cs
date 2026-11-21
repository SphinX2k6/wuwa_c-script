using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001934 RID: 6452
[NullableContext(1)]
[Nullable(0)]
public class VisionAttrRecommendInfo
{
	// Token: 0x0600FF00 RID: 65280 RVA: 0x004A6CA4 File Offset: 0x004A4EA4
	public VisionAttrRecommendInfo()
	{
		this.MainAttrRecommendInfo = new List<AttrRecommendInfo>();
		this.SubAttrRecommendInfo = new List<AttrRecommendInfo>();
		this.OfficialMainAttrRecommendInfo = new List<AttrRecommendInfo>();
		this.OfficialSubAttrRecommendInfo = new List<AttrRecommendInfo>();
		this.UsageMainAttrRecommendInfo = new List<AttrRecommendInfo>();
		this.UsageSubAttrRecommendInfo = new List<AttrRecommendInfo>();
	}

	// Token: 0x0600FF01 RID: 65281 RVA: 0x004A6CF9 File Offset: 0x004A4EF9
	public List<AttrRecommendInfo> GetMainAttrRecommendInfo()
	{
		return this.MainAttrRecommendInfo;
	}

	// Token: 0x0600FF02 RID: 65282 RVA: 0x004A6D01 File Offset: 0x004A4F01
	public List<AttrRecommendInfo> GetSubAttrRecommendInfo()
	{
		return this.SubAttrRecommendInfo;
	}

	// Token: 0x0600FF03 RID: 65283 RVA: 0x004A6D09 File Offset: 0x004A4F09
	public List<AttrRecommendInfo> GetOfficialMainAttrRecommendInfo()
	{
		return this.OfficialMainAttrRecommendInfo;
	}

	// Token: 0x0600FF04 RID: 65284 RVA: 0x004A6D11 File Offset: 0x004A4F11
	public List<AttrRecommendInfo> GetOfficialSubAttrRecommendInfo()
	{
		return this.OfficialSubAttrRecommendInfo;
	}

	// Token: 0x0600FF05 RID: 65285 RVA: 0x004A6D19 File Offset: 0x004A4F19
	public List<AttrRecommendInfo> GetUsageMainAttrRecommendInfo()
	{
		return this.UsageMainAttrRecommendInfo;
	}

	// Token: 0x0600FF06 RID: 65286 RVA: 0x004A6D21 File Offset: 0x004A4F21
	public List<AttrRecommendInfo> GetUsageSubAttrRecommendInfo()
	{
		return this.UsageSubAttrRecommendInfo;
	}

	// Token: 0x0600FF07 RID: 65287 RVA: 0x004A6D2C File Offset: 0x004A4F2C
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

	// Token: 0x04008DBB RID: 36283
	private readonly List<AttrRecommendInfo> MainAttrRecommendInfo;

	// Token: 0x04008DBC RID: 36284
	private readonly List<AttrRecommendInfo> SubAttrRecommendInfo;

	// Token: 0x04008DBD RID: 36285
	private readonly List<AttrRecommendInfo> OfficialMainAttrRecommendInfo;

	// Token: 0x04008DBE RID: 36286
	private readonly List<AttrRecommendInfo> OfficialSubAttrRecommendInfo;

	// Token: 0x04008DBF RID: 36287
	private readonly List<AttrRecommendInfo> UsageMainAttrRecommendInfo;

	// Token: 0x04008DC0 RID: 36288
	private readonly List<AttrRecommendInfo> UsageSubAttrRecommendInfo;
}

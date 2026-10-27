using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x02001CA7 RID: 7335
[NullableContext(1)]
[Nullable(0)]
public class ProtoGachaPoolInfo
{
	// Token: 0x0600DD78 RID: 56696 RVA: 0x0033CB48 File Offset: 0x0033AD48
	public ProtoGachaPoolInfo(GachaPoolInfo poolInfo)
	{
		this.Id = poolInfo.Id;
		this.BeginTime = (double)MathUtils.Instance.LongToNumber(poolInfo.BeginTime);
		this.EndTime = (double)MathUtils.Instance.LongToNumber(poolInfo.EndTime);
		this.Title = poolInfo.Title;
		this.Description = poolInfo.SummaryDescribe;
		this.UiType = poolInfo.UIType;
		this.ThemeColor = poolInfo.ThemeColor;
		this.ShowIdList = poolInfo.ShowIdList.ToArray<int>();
		this.UpList = poolInfo.UpList.ToArray<int>();
		this.PreviewIdList = poolInfo.PreviewIdList.ToArray<int>();
		this.ComplianceDetail = poolInfo.ComplianceDetail;
		GachaPool? gachaPoolConfig = GachaConfig.Instance.GetGachaPoolConfig(this.Id);
		if (gachaPoolConfig != null)
		{
			this.Sort = gachaPoolConfig.Value.Sort;
		}
	}

	// Token: 0x0400659D RID: 26013
	public int Id;

	// Token: 0x0400659E RID: 26014
	public double BeginTime;

	// Token: 0x0400659F RID: 26015
	public double EndTime;

	// Token: 0x040065A0 RID: 26016
	public int Sort;

	// Token: 0x040065A1 RID: 26017
	public string Title = "";

	// Token: 0x040065A2 RID: 26018
	public string Description = "";

	// Token: 0x040065A3 RID: 26019
	public int UiType;

	// Token: 0x040065A4 RID: 26020
	public string ThemeColor = "";

	// Token: 0x040065A5 RID: 26021
	public int[] ShowIdList = Array.Empty<int>();

	// Token: 0x040065A6 RID: 26022
	public int[] UpList = Array.Empty<int>();

	// Token: 0x040065A7 RID: 26023
	public int[] PreviewIdList = Array.Empty<int>();

	// Token: 0x040065A8 RID: 26024
	public string ComplianceDetail = "";
}

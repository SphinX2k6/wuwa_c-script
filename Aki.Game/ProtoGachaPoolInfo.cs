using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x02001166 RID: 4454
[NullableContext(1)]
[Nullable(0)]
public class ProtoGachaPoolInfo
{
	// Token: 0x0600B18E RID: 45454 RVA: 0x00347F94 File Offset: 0x00346194
	public ProtoGachaPoolInfo(GachaPoolInfo poolInfo)
	{
		this.Id = poolInfo.Id;
		this.BeginTime = (double)MathUtils.Instance.LongToNumber(poolInfo.BeginTime);
		this.EndTime = (double)MathUtils.Instance.LongToNumber(poolInfo.EndTime);
		this.Title = poolInfo.Title;
		this.Description = poolInfo.SummaryDescribe;
		this.UiType = poolInfo.UIType;
		this.ThemeColor = poolInfo.ThemeColor;
		int[] array = new int[poolInfo.ShowIdList.Count];
		poolInfo.ShowIdList.CopyTo(array, 0);
		this.ShowIdList = array;
		int[] array2 = new int[poolInfo.UpList.Count];
		poolInfo.UpList.CopyTo(array2, 0);
		this.UpList = array2;
		int[] array3 = new int[poolInfo.PreviewIdList.Count];
		poolInfo.PreviewIdList.CopyTo(array3, 0);
		this.PreviewIdList = array3;
		this.ComplianceDetail = poolInfo.ComplianceDetail;
		GachaPool? gachaPoolConfig = GachaConfig.Instance.GetGachaPoolConfig(this.Id);
		if (gachaPoolConfig != null)
		{
			this.Sort = gachaPoolConfig.Value.Sort;
		}
	}

	// Token: 0x0400666E RID: 26222
	public int Id;

	// Token: 0x0400666F RID: 26223
	public double BeginTime;

	// Token: 0x04006670 RID: 26224
	public double EndTime;

	// Token: 0x04006671 RID: 26225
	public int Sort;

	// Token: 0x04006672 RID: 26226
	public string Title = "";

	// Token: 0x04006673 RID: 26227
	public string Description = "";

	// Token: 0x04006674 RID: 26228
	public int UiType;

	// Token: 0x04006675 RID: 26229
	public string ThemeColor = "";

	// Token: 0x04006676 RID: 26230
	public int[] ShowIdList = Array.Empty<int>();

	// Token: 0x04006677 RID: 26231
	public int[] UpList = Array.Empty<int>();

	// Token: 0x04006678 RID: 26232
	public int[] PreviewIdList = Array.Empty<int>();

	// Token: 0x04006679 RID: 26233
	public string ComplianceDetail = "";
}

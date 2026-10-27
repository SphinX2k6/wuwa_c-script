using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002450 RID: 9296
[NullableContext(1)]
[Nullable(0)]
public class AttrRecommendInfo
{
	// Token: 0x06012A51 RID: 76369 RVA: 0x0049981C File Offset: 0x00497A1C
	public int GetAttrId()
	{
		return this.AttrId;
	}

	// Token: 0x06012A52 RID: 76370 RVA: 0x00499824 File Offset: 0x00497A24
	public int GetUsage()
	{
		return this.Usage;
	}

	// Token: 0x06012A53 RID: 76371 RVA: 0x0049982C File Offset: 0x00497A2C
	public string GetUsageText()
	{
		double num = (double)(this.Usage - this.Usage % 10) / 100.0;
		if (this.Usage != 0)
		{
			return num.ToString("F1") + "%";
		}
		return "";
	}

	// Token: 0x06012A54 RID: 76372 RVA: 0x00499879 File Offset: 0x00497A79
	public int GetAddType()
	{
		return this.AddType;
	}

	// Token: 0x06012A55 RID: 76373 RVA: 0x00499881 File Offset: 0x00497A81
	public void Phrase(PhantomAttrRecommendInfo data)
	{
		this.AttrId = data.AttrType;
		this.Usage = data.Usage;
		this.AddType = data.AddType;
	}

	// Token: 0x04008C7A RID: 35962
	private int AttrId;

	// Token: 0x04008C7B RID: 35963
	private int Usage;

	// Token: 0x04008C7C RID: 35964
	private int AddType;
}

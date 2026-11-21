using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001935 RID: 6453
[NullableContext(1)]
[Nullable(0)]
public class AttrRecommendInfo
{
	// Token: 0x0600FF08 RID: 65288 RVA: 0x004A6E24 File Offset: 0x004A5024
	public int GetAttrId()
	{
		return this.AttrId;
	}

	// Token: 0x0600FF09 RID: 65289 RVA: 0x004A6E2C File Offset: 0x004A502C
	public int GetUsage()
	{
		return this.Usage;
	}

	// Token: 0x0600FF0A RID: 65290 RVA: 0x004A6E34 File Offset: 0x004A5034
	public string GetUsageText()
	{
		double num = (double)(this.Usage - this.Usage % 10) / 100.0;
		if (this.Usage != 0)
		{
			return num.ToString("F1") + "%";
		}
		return "";
	}

	// Token: 0x0600FF0B RID: 65291 RVA: 0x004A6E81 File Offset: 0x004A5081
	public int GetAddType()
	{
		return this.AddType;
	}

	// Token: 0x0600FF0C RID: 65292 RVA: 0x004A6E89 File Offset: 0x004A5089
	public void Phrase(PhantomAttrRecommendInfo data)
	{
		this.AttrId = data.AttrType;
		this.Usage = data.Usage;
		this.AddType = data.AddType;
	}

	// Token: 0x04008DC1 RID: 36289
	private int AttrId;

	// Token: 0x04008DC2 RID: 36290
	private int Usage;

	// Token: 0x04008DC3 RID: 36291
	private int AddType;
}

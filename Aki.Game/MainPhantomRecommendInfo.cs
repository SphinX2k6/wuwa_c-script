using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002451 RID: 9297
[NullableContext(1)]
[Nullable(0)]
public class MainPhantomRecommendInfo
{
	// Token: 0x06012A57 RID: 76375 RVA: 0x004998AF File Offset: 0x00497AAF
	public int GetUsage()
	{
		return this.Usage;
	}

	// Token: 0x06012A58 RID: 76376 RVA: 0x004998B8 File Offset: 0x00497AB8
	public string GetUsageText()
	{
		double num = (double)(this.Usage - this.Usage % 10) / 100.0;
		if (this.Usage != 0)
		{
			return num.ToString("F1") + "%";
		}
		return "";
	}

	// Token: 0x06012A59 RID: 76377 RVA: 0x00499905 File Offset: 0x00497B05
	public int GetMonsterId()
	{
		return this.MonsterId;
	}

	// Token: 0x06012A5A RID: 76378 RVA: 0x0049990D File Offset: 0x00497B0D
	public int GetFetterGroupId()
	{
		return this.FetterGroupId;
	}

	// Token: 0x06012A5B RID: 76379 RVA: 0x00499915 File Offset: 0x00497B15
	public void Phrase(Aki.Protocol.MainPhantomRecommendInfo data)
	{
		this.Usage = data.Usage;
		this.MonsterId = data.MonsterId;
		this.FetterGroupId = data.FetterGroupId;
	}

	// Token: 0x04008C7D RID: 35965
	private int Usage;

	// Token: 0x04008C7E RID: 35966
	private int MonsterId;

	// Token: 0x04008C7F RID: 35967
	private int FetterGroupId;
}

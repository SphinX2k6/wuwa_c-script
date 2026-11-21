using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001936 RID: 6454
[NullableContext(1)]
[Nullable(0)]
public class MainPhantomRecommendInfo
{
	// Token: 0x0600FF0E RID: 65294 RVA: 0x004A6EB7 File Offset: 0x004A50B7
	public int GetUsage()
	{
		return this.Usage;
	}

	// Token: 0x0600FF0F RID: 65295 RVA: 0x004A6EC0 File Offset: 0x004A50C0
	public string GetUsageText()
	{
		double num = (double)(this.Usage - this.Usage % 10) / 100.0;
		if (this.Usage != 0)
		{
			return num.ToString("F1") + "%";
		}
		return "";
	}

	// Token: 0x0600FF10 RID: 65296 RVA: 0x004A6F0D File Offset: 0x004A510D
	public int GetMonsterId()
	{
		return this.MonsterId;
	}

	// Token: 0x0600FF11 RID: 65297 RVA: 0x004A6F15 File Offset: 0x004A5115
	public int GetFetterGroupId()
	{
		return this.FetterGroupId;
	}

	// Token: 0x0600FF12 RID: 65298 RVA: 0x004A6F1D File Offset: 0x004A511D
	public void Phrase(Aki.Protocol.MainPhantomRecommendInfo data)
	{
		this.Usage = data.Usage;
		this.MonsterId = data.MonsterId;
		this.FetterGroupId = data.FetterGroupId;
	}

	// Token: 0x04008DC4 RID: 36292
	private int Usage;

	// Token: 0x04008DC5 RID: 36293
	private int MonsterId;

	// Token: 0x04008DC6 RID: 36294
	private int FetterGroupId;
}

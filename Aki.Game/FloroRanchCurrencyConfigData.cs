using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000FB1 RID: 4017
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchCurrencyConfigData
{
	// Token: 0x0600A0D7 RID: 41175 RVA: 0x002F73DF File Offset: 0x002F55DF
	public FloroRanchCurrencyConfigData(FloroRanchCurrency config)
	{
		this.Config = config;
	}

	// Token: 0x0600A0D8 RID: 41176 RVA: 0x002F73F0 File Offset: 0x002F55F0
	public string GetName()
	{
		return this.Config.Name;
	}

	// Token: 0x0600A0D9 RID: 41177 RVA: 0x002F740C File Offset: 0x002F560C
	public string GetDesc()
	{
		return this.Config.Desc;
	}

	// Token: 0x0600A0DA RID: 41178 RVA: 0x002F7428 File Offset: 0x002F5628
	public string GetIcon()
	{
		return this.Config.Icon;
	}

	// Token: 0x0600A0DB RID: 41179 RVA: 0x002F7444 File Offset: 0x002F5644
	public string GetSmallIcon()
	{
		return this.Config.SmallIcon;
	}

	// Token: 0x0600A0DC RID: 41180 RVA: 0x002F7460 File Offset: 0x002F5660
	public FloroRanchRarityData GetQualityData()
	{
		int rarityId = this.Config.RarityId;
		return FloroRanchModel.Instance.GetFloroRanchRarity(rarityId);
	}

	// Token: 0x04005ECE RID: 24270
	private readonly FloroRanchCurrency Config;
}

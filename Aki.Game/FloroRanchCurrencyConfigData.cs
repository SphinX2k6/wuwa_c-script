using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001AF2 RID: 6898
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchCurrencyConfigData
{
	// Token: 0x0600CCC6 RID: 52422 RVA: 0x002EC2F3 File Offset: 0x002EA4F3
	public FloroRanchCurrencyConfigData(FloroRanchCurrency config)
	{
		this.Config = config;
	}

	// Token: 0x0600CCC7 RID: 52423 RVA: 0x002EC304 File Offset: 0x002EA504
	public string GetName()
	{
		return this.Config.Name;
	}

	// Token: 0x0600CCC8 RID: 52424 RVA: 0x002EC320 File Offset: 0x002EA520
	public string GetDesc()
	{
		return this.Config.Desc;
	}

	// Token: 0x0600CCC9 RID: 52425 RVA: 0x002EC33C File Offset: 0x002EA53C
	public string GetIcon()
	{
		return this.Config.Icon;
	}

	// Token: 0x0600CCCA RID: 52426 RVA: 0x002EC358 File Offset: 0x002EA558
	public string GetSmallIcon()
	{
		return this.Config.SmallIcon;
	}

	// Token: 0x0600CCCB RID: 52427 RVA: 0x002EC374 File Offset: 0x002EA574
	public FloroRanchRarityData GetQualityData()
	{
		int rarityId = this.Config.RarityId;
		return FloroRanchModel.Instance.GetFloroRanchRarity(rarityId);
	}

	// Token: 0x04005DFF RID: 24063
	private readonly FloroRanchCurrency Config;
}

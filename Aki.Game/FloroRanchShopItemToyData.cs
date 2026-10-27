using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001AFE RID: 6910
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchShopItemToyData : FloroRanchShopItemDataBase
{
	// Token: 0x0600CD1B RID: 52507 RVA: 0x002ECAAE File Offset: 0x002EACAE
	public FloroRanchShopItemToyData(FloroRanchShopItem data) : base(data)
	{
		this.ConfigData = FloroRanchModel.Instance.GetFloroRanchToyData(this.Id);
	}

	// Token: 0x0600CD1C RID: 52508 RVA: 0x002ECACD File Offset: 0x002EACCD
	public override string GetName()
	{
		return this.ConfigData.GetName();
	}

	// Token: 0x170010F8 RID: 4344
	// (get) Token: 0x0600CD1D RID: 52509 RVA: 0x002ECADA File Offset: 0x002EACDA
	public override string Desc
	{
		get
		{
			return this.ConfigData.Desc;
		}
	}

	// Token: 0x0600CD1E RID: 52510 RVA: 0x002ECAE7 File Offset: 0x002EACE7
	public override string GetIcon()
	{
		return this.ConfigData.GetIcon();
	}

	// Token: 0x0600CD1F RID: 52511 RVA: 0x002ECAF4 File Offset: 0x002EACF4
	public override FloroRanchRarityData GetQualityData()
	{
		return this.ConfigData.GetToyQualityData();
	}

	// Token: 0x0600CD20 RID: 52512 RVA: 0x002ECB01 File Offset: 0x002EAD01
	public override int GetRace()
	{
		return 0;
	}

	// Token: 0x0600CD21 RID: 52513 RVA: 0x002ECB04 File Offset: 0x002EAD04
	public override int GetEarnCount()
	{
		return 0;
	}

	// Token: 0x0600CD22 RID: 52514 RVA: 0x002ECB07 File Offset: 0x002EAD07
	[NullableContext(2)]
	public override FloroRanchRaceData GetToyRaceData()
	{
		return this.ConfigData.GetToyRaceData();
	}

	// Token: 0x04005E1C RID: 24092
	public FloroRanchToyData ConfigData;
}

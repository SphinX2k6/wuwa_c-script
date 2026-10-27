using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001AFD RID: 6909
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchShopItemCardGroupData : FloroRanchShopItemDataBase
{
	// Token: 0x0600CD14 RID: 52500 RVA: 0x002ECA4B File Offset: 0x002EAC4B
	public FloroRanchShopItemCardGroupData(FloroRanchShopItem data) : base(data)
	{
		this.ConfigData = FloroRanchModel.Instance.GetFloroRanchCardGroup(this.Id);
	}

	// Token: 0x0600CD15 RID: 52501 RVA: 0x002ECA6A File Offset: 0x002EAC6A
	public override string GetName()
	{
		return this.ConfigData.GetName();
	}

	// Token: 0x170010F7 RID: 4343
	// (get) Token: 0x0600CD16 RID: 52502 RVA: 0x002ECA77 File Offset: 0x002EAC77
	public override string Desc
	{
		get
		{
			return this.ConfigData.Desc;
		}
	}

	// Token: 0x0600CD17 RID: 52503 RVA: 0x002ECA84 File Offset: 0x002EAC84
	public override string GetIcon()
	{
		return this.ConfigData.GetIcon();
	}

	// Token: 0x0600CD18 RID: 52504 RVA: 0x002ECA91 File Offset: 0x002EAC91
	public override FloroRanchRarityData GetQualityData()
	{
		return this.ConfigData.GetQualityData();
	}

	// Token: 0x0600CD19 RID: 52505 RVA: 0x002ECA9E File Offset: 0x002EAC9E
	public override int GetRace()
	{
		return this.ConfigData.GetRaceId();
	}

	// Token: 0x0600CD1A RID: 52506 RVA: 0x002ECAAB File Offset: 0x002EACAB
	public override int GetEarnCount()
	{
		return 0;
	}

	// Token: 0x04005E1B RID: 24091
	public FloroRanchCardGroupData ConfigData;
}

using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001AFC RID: 6908
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchShopItemCardData : FloroRanchShopItemDataBase
{
	// Token: 0x0600CD0C RID: 52492 RVA: 0x002EC9D1 File Offset: 0x002EABD1
	public FloroRanchShopItemCardData(FloroRanchShopItem data) : base(data)
	{
		this.ConfigData = FloroRanchModel.Instance.GetFloroRanchCardData(this.Id);
	}

	// Token: 0x0600CD0D RID: 52493 RVA: 0x002EC9F0 File Offset: 0x002EABF0
	public override string GetName()
	{
		return this.ConfigData.GetName();
	}

	// Token: 0x170010F6 RID: 4342
	// (get) Token: 0x0600CD0E RID: 52494 RVA: 0x002EC9FD File Offset: 0x002EABFD
	public override string Desc
	{
		get
		{
			return this.ConfigData.Desc;
		}
	}

	// Token: 0x0600CD0F RID: 52495 RVA: 0x002ECA0A File Offset: 0x002EAC0A
	public override string GetIcon()
	{
		return this.ConfigData.GetIcon();
	}

	// Token: 0x0600CD10 RID: 52496 RVA: 0x002ECA17 File Offset: 0x002EAC17
	public override FloroRanchRarityData GetQualityData()
	{
		return this.ConfigData.GetCardQualityData();
	}

	// Token: 0x0600CD11 RID: 52497 RVA: 0x002ECA24 File Offset: 0x002EAC24
	public override int GetRace()
	{
		return this.ConfigData.GetRace();
	}

	// Token: 0x0600CD12 RID: 52498 RVA: 0x002ECA31 File Offset: 0x002EAC31
	public override int GetEarnCount()
	{
		return this.ConfigData.GetCardSalary();
	}

	// Token: 0x0600CD13 RID: 52499 RVA: 0x002ECA3E File Offset: 0x002EAC3E
	public override bool GetIsSpecialPhantom()
	{
		return this.ConfigData.IsSpecialPhantom;
	}

	// Token: 0x04005E1A RID: 24090
	public FloroRanchCardData ConfigData;
}

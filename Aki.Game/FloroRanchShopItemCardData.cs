using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000FBB RID: 4027
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchShopItemCardData : FloroRanchShopItemDataBase
{
	// Token: 0x0600A11D RID: 41245 RVA: 0x002F7ABD File Offset: 0x002F5CBD
	public FloroRanchShopItemCardData(FloroRanchShopItem data) : base(data)
	{
		this.ConfigData = FloroRanchModel.Instance.GetFloroRanchCardData(this.Id);
	}

	// Token: 0x0600A11E RID: 41246 RVA: 0x002F7ADC File Offset: 0x002F5CDC
	public override string GetName()
	{
		return this.ConfigData.GetName();
	}

	// Token: 0x1700111B RID: 4379
	// (get) Token: 0x0600A11F RID: 41247 RVA: 0x002F7AE9 File Offset: 0x002F5CE9
	public override string Desc
	{
		get
		{
			return this.ConfigData.Desc;
		}
	}

	// Token: 0x0600A120 RID: 41248 RVA: 0x002F7AF6 File Offset: 0x002F5CF6
	public override string GetIcon()
	{
		return this.ConfigData.GetIcon();
	}

	// Token: 0x0600A121 RID: 41249 RVA: 0x002F7B03 File Offset: 0x002F5D03
	public override FloroRanchRarityData GetQualityData()
	{
		return this.ConfigData.GetCardQualityData();
	}

	// Token: 0x0600A122 RID: 41250 RVA: 0x002F7B10 File Offset: 0x002F5D10
	public override int GetRace()
	{
		return this.ConfigData.GetRace();
	}

	// Token: 0x0600A123 RID: 41251 RVA: 0x002F7B1D File Offset: 0x002F5D1D
	public override int GetEarnCount()
	{
		return this.ConfigData.GetCardSalary();
	}

	// Token: 0x0600A124 RID: 41252 RVA: 0x002F7B2A File Offset: 0x002F5D2A
	public override bool GetIsSpecialPhantom()
	{
		return this.ConfigData.IsSpecialPhantom;
	}

	// Token: 0x04005EE9 RID: 24297
	public FloroRanchCardData ConfigData;
}

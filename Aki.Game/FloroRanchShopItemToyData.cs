using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000FBD RID: 4029
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchShopItemToyData : FloroRanchShopItemDataBase
{
	// Token: 0x0600A12C RID: 41260 RVA: 0x002F7B9A File Offset: 0x002F5D9A
	public FloroRanchShopItemToyData(FloroRanchShopItem data) : base(data)
	{
		this.ConfigData = FloroRanchModel.Instance.GetFloroRanchToyData(this.Id);
	}

	// Token: 0x0600A12D RID: 41261 RVA: 0x002F7BB9 File Offset: 0x002F5DB9
	public override string GetName()
	{
		return this.ConfigData.GetName();
	}

	// Token: 0x1700111D RID: 4381
	// (get) Token: 0x0600A12E RID: 41262 RVA: 0x002F7BC6 File Offset: 0x002F5DC6
	public override string Desc
	{
		get
		{
			return this.ConfigData.Desc;
		}
	}

	// Token: 0x0600A12F RID: 41263 RVA: 0x002F7BD3 File Offset: 0x002F5DD3
	public override string GetIcon()
	{
		return this.ConfigData.GetIcon();
	}

	// Token: 0x0600A130 RID: 41264 RVA: 0x002F7BE0 File Offset: 0x002F5DE0
	public override FloroRanchRarityData GetQualityData()
	{
		return this.ConfigData.GetToyQualityData();
	}

	// Token: 0x0600A131 RID: 41265 RVA: 0x002F7BED File Offset: 0x002F5DED
	public override int GetRace()
	{
		return 0;
	}

	// Token: 0x0600A132 RID: 41266 RVA: 0x002F7BF0 File Offset: 0x002F5DF0
	public override int GetEarnCount()
	{
		return 0;
	}

	// Token: 0x0600A133 RID: 41267 RVA: 0x002F7BF3 File Offset: 0x002F5DF3
	[NullableContext(2)]
	public override FloroRanchRaceData GetToyRaceData()
	{
		return this.ConfigData.GetToyRaceData();
	}

	// Token: 0x04005EEB RID: 24299
	public FloroRanchToyData ConfigData;
}

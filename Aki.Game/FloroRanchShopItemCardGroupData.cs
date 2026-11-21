using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000FBC RID: 4028
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchShopItemCardGroupData : FloroRanchShopItemDataBase
{
	// Token: 0x0600A125 RID: 41253 RVA: 0x002F7B37 File Offset: 0x002F5D37
	public FloroRanchShopItemCardGroupData(FloroRanchShopItem data) : base(data)
	{
		this.ConfigData = FloroRanchModel.Instance.GetFloroRanchCardGroup(this.Id);
	}

	// Token: 0x0600A126 RID: 41254 RVA: 0x002F7B56 File Offset: 0x002F5D56
	public override string GetName()
	{
		return this.ConfigData.GetName();
	}

	// Token: 0x1700111C RID: 4380
	// (get) Token: 0x0600A127 RID: 41255 RVA: 0x002F7B63 File Offset: 0x002F5D63
	public override string Desc
	{
		get
		{
			return this.ConfigData.Desc;
		}
	}

	// Token: 0x0600A128 RID: 41256 RVA: 0x002F7B70 File Offset: 0x002F5D70
	public override string GetIcon()
	{
		return this.ConfigData.GetIcon();
	}

	// Token: 0x0600A129 RID: 41257 RVA: 0x002F7B7D File Offset: 0x002F5D7D
	public override FloroRanchRarityData GetQualityData()
	{
		return this.ConfigData.GetQualityData();
	}

	// Token: 0x0600A12A RID: 41258 RVA: 0x002F7B8A File Offset: 0x002F5D8A
	public override int GetRace()
	{
		return this.ConfigData.GetRaceId();
	}

	// Token: 0x0600A12B RID: 41259 RVA: 0x002F7B97 File Offset: 0x002F5D97
	public override int GetEarnCount()
	{
		return 0;
	}

	// Token: 0x04005EEA RID: 24298
	public FloroRanchCardGroupData ConfigData;
}

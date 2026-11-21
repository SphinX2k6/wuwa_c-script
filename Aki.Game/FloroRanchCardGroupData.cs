using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000FB0 RID: 4016
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchCardGroupData
{
	// Token: 0x0600A0D1 RID: 41169 RVA: 0x002F732F File Offset: 0x002F552F
	public FloroRanchCardGroupData(FloroRanchCardGroup config)
	{
		this.Config = config;
	}

	// Token: 0x0600A0D2 RID: 41170 RVA: 0x002F7340 File Offset: 0x002F5540
	public string GetName()
	{
		return this.Config.Name;
	}

	// Token: 0x17001107 RID: 4359
	// (get) Token: 0x0600A0D3 RID: 41171 RVA: 0x002F735C File Offset: 0x002F555C
	public string Desc
	{
		get
		{
			return ConfigMultiTextLang.GetLocalTextNew(this.Config.Desc, null);
		}
	}

	// Token: 0x0600A0D4 RID: 41172 RVA: 0x002F7380 File Offset: 0x002F5580
	public string GetIcon()
	{
		return this.Config.Icon;
	}

	// Token: 0x0600A0D5 RID: 41173 RVA: 0x002F739C File Offset: 0x002F559C
	public FloroRanchRarityData GetQualityData()
	{
		int rarityId = this.Config.RarityId;
		return FloroRanchModel.Instance.GetFloroRanchRarity(rarityId);
	}

	// Token: 0x0600A0D6 RID: 41174 RVA: 0x002F73C4 File Offset: 0x002F55C4
	public int GetRaceId()
	{
		return this.Config.Race;
	}

	// Token: 0x04005ECD RID: 24269
	private readonly FloroRanchCardGroup Config;
}

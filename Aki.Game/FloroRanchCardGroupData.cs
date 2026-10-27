using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001AF1 RID: 6897
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchCardGroupData
{
	// Token: 0x0600CCC0 RID: 52416 RVA: 0x002EC243 File Offset: 0x002EA443
	public FloroRanchCardGroupData(FloroRanchCardGroup config)
	{
		this.Config = config;
	}

	// Token: 0x0600CCC1 RID: 52417 RVA: 0x002EC254 File Offset: 0x002EA454
	public string GetName()
	{
		return this.Config.Name;
	}

	// Token: 0x170010E2 RID: 4322
	// (get) Token: 0x0600CCC2 RID: 52418 RVA: 0x002EC270 File Offset: 0x002EA470
	public string Desc
	{
		get
		{
			return ConfigMultiTextLang.GetLocalTextNew(this.Config.Desc, null);
		}
	}

	// Token: 0x0600CCC3 RID: 52419 RVA: 0x002EC294 File Offset: 0x002EA494
	public string GetIcon()
	{
		return this.Config.Icon;
	}

	// Token: 0x0600CCC4 RID: 52420 RVA: 0x002EC2B0 File Offset: 0x002EA4B0
	public FloroRanchRarityData GetQualityData()
	{
		int rarityId = this.Config.RarityId;
		return FloroRanchModel.Instance.GetFloroRanchRarity(rarityId);
	}

	// Token: 0x0600CCC5 RID: 52421 RVA: 0x002EC2D8 File Offset: 0x002EA4D8
	public int GetRaceId()
	{
		return this.Config.Race;
	}

	// Token: 0x04005DFE RID: 24062
	private readonly FloroRanchCardGroup Config;
}

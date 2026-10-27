using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001B0A RID: 6922
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchToyData : IFloroRanchCardOrToyData
{
	// Token: 0x0600CD75 RID: 52597 RVA: 0x002ED19B File Offset: 0x002EB39B
	public FloroRanchToyData(FloroRanchToy config)
	{
		this.Config = config;
		this.TagData.SetTagId(this.Config.Tag);
	}

	// Token: 0x1700112C RID: 4396
	// (get) Token: 0x0600CD76 RID: 52598 RVA: 0x002ED1CB File Offset: 0x002EB3CB
	public int Id
	{
		get
		{
			return this.Config.Id;
		}
	}

	// Token: 0x0600CD77 RID: 52599 RVA: 0x002ED1D8 File Offset: 0x002EB3D8
	public int GetToyType()
	{
		return this.Config.Type;
	}

	// Token: 0x0600CD78 RID: 52600 RVA: 0x002ED1E5 File Offset: 0x002EB3E5
	public string GetName()
	{
		return this.Config.Name;
	}

	// Token: 0x1700112D RID: 4397
	// (get) Token: 0x0600CD79 RID: 52601 RVA: 0x002ED1F2 File Offset: 0x002EB3F2
	public string Name
	{
		get
		{
			return ConfigMultiTextLang.GetLocalTextNew(this.Config.Name, null);
		}
	}

	// Token: 0x0600CD7A RID: 52602 RVA: 0x002ED208 File Offset: 0x002EB408
	public FloroRanchRarityData GetToyQualityData()
	{
		int rarityId = this.Config.RarityId;
		return FloroRanchModel.Instance.GetFloroRanchRarity(rarityId);
	}

	// Token: 0x0600CD7B RID: 52603 RVA: 0x002ED22C File Offset: 0x002EB42C
	public int GetDeleteEarn()
	{
		return this.Config.Remove;
	}

	// Token: 0x0600CD7C RID: 52604 RVA: 0x002ED239 File Offset: 0x002EB439
	public string GetIcon()
	{
		return this.Config.Icon;
	}

	// Token: 0x0600CD7D RID: 52605 RVA: 0x002ED246 File Offset: 0x002EB446
	public bool GetIsUnique()
	{
		return this.Config.Unique;
	}

	// Token: 0x1700112E RID: 4398
	// (get) Token: 0x0600CD7E RID: 52606 RVA: 0x002ED253 File Offset: 0x002EB453
	public string Desc
	{
		get
		{
			return this.TagData.Desc;
		}
	}

	// Token: 0x0600CD7F RID: 52607 RVA: 0x002ED260 File Offset: 0x002EB460
	public int GetRarity()
	{
		return this.Config.RarityId;
	}

	// Token: 0x1700112F RID: 4399
	// (get) Token: 0x0600CD80 RID: 52608 RVA: 0x002ED26D File Offset: 0x002EB46D
	public bool IsAdaptAllRace
	{
		get
		{
			return this.Config.RaceLength == 0;
		}
	}

	// Token: 0x0600CD81 RID: 52609 RVA: 0x002ED280 File Offset: 0x002EB480
	public unsafe int GetRace()
	{
		if (this.Config.RaceLength == 0)
		{
			return -1;
		}
		return *this.Config.GetRaceBytes()[0];
	}

	// Token: 0x0600CD82 RID: 52610 RVA: 0x002ED2B4 File Offset: 0x002EB4B4
	[NullableContext(2)]
	public FloroRanchRaceData GetToyRaceData()
	{
		int race = this.GetRace();
		if (race == -1)
		{
			return null;
		}
		return FloroRanchModel.Instance.GetFloroRanchRaceData(race);
	}

	// Token: 0x17001130 RID: 4400
	// (get) Token: 0x0600CD83 RID: 52611 RVA: 0x002ED2D9 File Offset: 0x002EB4D9
	public int InitLevel
	{
		get
		{
			return this.Config.Level;
		}
	}

	// Token: 0x0600CD84 RID: 52612 RVA: 0x002ED2E6 File Offset: 0x002EB4E6
	public bool CheckCanSell()
	{
		return this.GetDeleteEarn() != -1;
	}

	// Token: 0x04005E43 RID: 24131
	private FloroRanchToy Config;

	// Token: 0x04005E44 RID: 24132
	public FloroRanchTagData TagData = new FloroRanchTagData();
}

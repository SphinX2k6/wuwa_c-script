using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000FC9 RID: 4041
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchToyData : IFloroRanchCardOrToyData
{
	// Token: 0x0600A186 RID: 41350 RVA: 0x002F8287 File Offset: 0x002F6487
	public FloroRanchToyData(FloroRanchToy config)
	{
		this.Config = config;
		this.TagData.SetTagId(this.Config.Tag);
	}

	// Token: 0x17001151 RID: 4433
	// (get) Token: 0x0600A187 RID: 41351 RVA: 0x002F82B7 File Offset: 0x002F64B7
	public int Id
	{
		get
		{
			return this.Config.Id;
		}
	}

	// Token: 0x0600A188 RID: 41352 RVA: 0x002F82C4 File Offset: 0x002F64C4
	public int GetToyType()
	{
		return this.Config.Type;
	}

	// Token: 0x0600A189 RID: 41353 RVA: 0x002F82D1 File Offset: 0x002F64D1
	public string GetName()
	{
		return this.Config.Name;
	}

	// Token: 0x17001152 RID: 4434
	// (get) Token: 0x0600A18A RID: 41354 RVA: 0x002F82DE File Offset: 0x002F64DE
	public string Name
	{
		get
		{
			return ConfigMultiTextLang.GetLocalTextNew(this.Config.Name, null);
		}
	}

	// Token: 0x0600A18B RID: 41355 RVA: 0x002F82F4 File Offset: 0x002F64F4
	public FloroRanchRarityData GetToyQualityData()
	{
		int rarityId = this.Config.RarityId;
		return FloroRanchModel.Instance.GetFloroRanchRarity(rarityId);
	}

	// Token: 0x0600A18C RID: 41356 RVA: 0x002F8318 File Offset: 0x002F6518
	public int GetDeleteEarn()
	{
		return this.Config.Remove;
	}

	// Token: 0x0600A18D RID: 41357 RVA: 0x002F8325 File Offset: 0x002F6525
	public string GetIcon()
	{
		return this.Config.Icon;
	}

	// Token: 0x0600A18E RID: 41358 RVA: 0x002F8332 File Offset: 0x002F6532
	public bool GetIsUnique()
	{
		return this.Config.Unique;
	}

	// Token: 0x17001153 RID: 4435
	// (get) Token: 0x0600A18F RID: 41359 RVA: 0x002F833F File Offset: 0x002F653F
	public string Desc
	{
		get
		{
			return this.TagData.Desc;
		}
	}

	// Token: 0x0600A190 RID: 41360 RVA: 0x002F834C File Offset: 0x002F654C
	public int GetRarity()
	{
		return this.Config.RarityId;
	}

	// Token: 0x17001154 RID: 4436
	// (get) Token: 0x0600A191 RID: 41361 RVA: 0x002F8359 File Offset: 0x002F6559
	public bool IsAdaptAllRace
	{
		get
		{
			return this.Config.RaceLength == 0;
		}
	}

	// Token: 0x0600A192 RID: 41362 RVA: 0x002F836C File Offset: 0x002F656C
	public unsafe int GetRace()
	{
		if (this.Config.RaceLength == 0)
		{
			return -1;
		}
		return *this.Config.GetRaceBytes()[0];
	}

	// Token: 0x0600A193 RID: 41363 RVA: 0x002F83A0 File Offset: 0x002F65A0
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

	// Token: 0x17001155 RID: 4437
	// (get) Token: 0x0600A194 RID: 41364 RVA: 0x002F83C5 File Offset: 0x002F65C5
	public int InitLevel
	{
		get
		{
			return this.Config.Level;
		}
	}

	// Token: 0x0600A195 RID: 41365 RVA: 0x002F83D2 File Offset: 0x002F65D2
	public bool CheckCanSell()
	{
		return this.GetDeleteEarn() != -1;
	}

	// Token: 0x04005F12 RID: 24338
	private FloroRanchToy Config;

	// Token: 0x04005F13 RID: 24339
	public FloroRanchTagData TagData = new FloroRanchTagData();
}

using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000FAF RID: 4015
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchCardData : IFloroRanchCardOrToyData
{
	// Token: 0x0600A0BC RID: 41148 RVA: 0x002F70BB File Offset: 0x002F52BB
	public FloroRanchCardData(FloroRanchCard config)
	{
		this.Config = config;
		this.TagData.SetTagId(this.Config.Tag);
	}

	// Token: 0x17001101 RID: 4353
	// (get) Token: 0x0600A0BD RID: 41149 RVA: 0x002F70EC File Offset: 0x002F52EC
	public int Id
	{
		get
		{
			return this.Config.Id;
		}
	}

	// Token: 0x0600A0BE RID: 41150 RVA: 0x002F7108 File Offset: 0x002F5308
	public string GetName()
	{
		return this.Config.Name;
	}

	// Token: 0x17001102 RID: 4354
	// (get) Token: 0x0600A0BF RID: 41151 RVA: 0x002F7124 File Offset: 0x002F5324
	public string Name
	{
		get
		{
			return ConfigMultiTextLang.GetLocalTextNew(this.Config.Name, null);
		}
	}

	// Token: 0x17001103 RID: 4355
	// (get) Token: 0x0600A0C0 RID: 41152 RVA: 0x002F7145 File Offset: 0x002F5345
	public string Desc
	{
		get
		{
			return this.TagData.Desc;
		}
	}

	// Token: 0x0600A0C1 RID: 41153 RVA: 0x002F7154 File Offset: 0x002F5354
	public FloroRanchRarityData GetCardQualityData()
	{
		int rarityId = this.Config.RarityId;
		return FloroRanchModel.Instance.GetFloroRanchRarity(rarityId);
	}

	// Token: 0x0600A0C2 RID: 41154 RVA: 0x002F717C File Offset: 0x002F537C
	public int GetDeleteCost()
	{
		return this.Config.Cost;
	}

	// Token: 0x0600A0C3 RID: 41155 RVA: 0x002F7198 File Offset: 0x002F5398
	public string GetIcon()
	{
		return this.Config.Icon;
	}

	// Token: 0x0600A0C4 RID: 41156 RVA: 0x002F71B4 File Offset: 0x002F53B4
	public string GetRaceName()
	{
		int race = this.Config.Race;
		return FloroRanchModel.Instance.GetFloroRanchRaceData(race).GetRaceName();
	}

	// Token: 0x0600A0C5 RID: 41157 RVA: 0x002F71E0 File Offset: 0x002F53E0
	public int GetBasicSalary()
	{
		return this.Config.Salary;
	}

	// Token: 0x0600A0C6 RID: 41158 RVA: 0x002F71FC File Offset: 0x002F53FC
	public int GetRace()
	{
		return this.Config.Race;
	}

	// Token: 0x0600A0C7 RID: 41159 RVA: 0x002F7218 File Offset: 0x002F5418
	public int GetRarity()
	{
		return this.Config.RarityId;
	}

	// Token: 0x0600A0C8 RID: 41160 RVA: 0x002F7234 File Offset: 0x002F5434
	public int GetCardSalary()
	{
		return this.Config.Salary;
	}

	// Token: 0x0600A0C9 RID: 41161 RVA: 0x002F7250 File Offset: 0x002F5450
	public string GetSpineAtlas()
	{
		return this.Config.Spine;
	}

	// Token: 0x0600A0CA RID: 41162 RVA: 0x002F726C File Offset: 0x002F546C
	public string GetSpineData()
	{
		return this.Config.SpineSkeletonData;
	}

	// Token: 0x0600A0CB RID: 41163 RVA: 0x002F7288 File Offset: 0x002F5488
	public int GetEvolveItemOffsetY()
	{
		return this.Config.EvolveItemOffsetY;
	}

	// Token: 0x0600A0CC RID: 41164 RVA: 0x002F72A4 File Offset: 0x002F54A4
	public EFloroRanchCardDirection GetCardDefaultDirection()
	{
		return (EFloroRanchCardDirection)this.Config.Towards;
	}

	// Token: 0x0600A0CD RID: 41165 RVA: 0x002F72C0 File Offset: 0x002F54C0
	public EFloroRanchSpecialEffectType GetCardSpecialEffect()
	{
		return (EFloroRanchSpecialEffectType)this.Config.SpeicalEffectshow;
	}

	// Token: 0x17001104 RID: 4356
	// (get) Token: 0x0600A0CE RID: 41166 RVA: 0x002F72DC File Offset: 0x002F54DC
	public bool IsShowInHandBook
	{
		get
		{
			return this.Config.Illustration;
		}
	}

	// Token: 0x17001105 RID: 4357
	// (get) Token: 0x0600A0CF RID: 41167 RVA: 0x002F72F8 File Offset: 0x002F54F8
	public bool IsSpecialPhantom
	{
		get
		{
			return this.Config.IsSpecial;
		}
	}

	// Token: 0x17001106 RID: 4358
	// (get) Token: 0x0600A0D0 RID: 41168 RVA: 0x002F7314 File Offset: 0x002F5514
	public string Video
	{
		get
		{
			return this.Config.Video;
		}
	}

	// Token: 0x04005ECB RID: 24267
	private readonly FloroRanchCard Config;

	// Token: 0x04005ECC RID: 24268
	public FloroRanchTagData TagData = new FloroRanchTagData();
}

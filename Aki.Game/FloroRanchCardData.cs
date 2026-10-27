using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001AF0 RID: 6896
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchCardData : IFloroRanchCardOrToyData
{
	// Token: 0x0600CCAB RID: 52395 RVA: 0x002EBFCF File Offset: 0x002EA1CF
	public FloroRanchCardData(FloroRanchCard config)
	{
		this.Config = config;
		this.TagData.SetTagId(this.Config.Tag);
	}

	// Token: 0x170010DC RID: 4316
	// (get) Token: 0x0600CCAC RID: 52396 RVA: 0x002EC000 File Offset: 0x002EA200
	public int Id
	{
		get
		{
			return this.Config.Id;
		}
	}

	// Token: 0x0600CCAD RID: 52397 RVA: 0x002EC01C File Offset: 0x002EA21C
	public string GetName()
	{
		return this.Config.Name;
	}

	// Token: 0x170010DD RID: 4317
	// (get) Token: 0x0600CCAE RID: 52398 RVA: 0x002EC038 File Offset: 0x002EA238
	public string Name
	{
		get
		{
			return ConfigMultiTextLang.GetLocalTextNew(this.Config.Name, null);
		}
	}

	// Token: 0x170010DE RID: 4318
	// (get) Token: 0x0600CCAF RID: 52399 RVA: 0x002EC059 File Offset: 0x002EA259
	public string Desc
	{
		get
		{
			return this.TagData.Desc;
		}
	}

	// Token: 0x0600CCB0 RID: 52400 RVA: 0x002EC068 File Offset: 0x002EA268
	public FloroRanchRarityData GetCardQualityData()
	{
		int rarityId = this.Config.RarityId;
		return FloroRanchModel.Instance.GetFloroRanchRarity(rarityId);
	}

	// Token: 0x0600CCB1 RID: 52401 RVA: 0x002EC090 File Offset: 0x002EA290
	public int GetDeleteCost()
	{
		return this.Config.Cost;
	}

	// Token: 0x0600CCB2 RID: 52402 RVA: 0x002EC0AC File Offset: 0x002EA2AC
	public string GetIcon()
	{
		return this.Config.Icon;
	}

	// Token: 0x0600CCB3 RID: 52403 RVA: 0x002EC0C8 File Offset: 0x002EA2C8
	public string GetRaceName()
	{
		int race = this.Config.Race;
		return FloroRanchModel.Instance.GetFloroRanchRaceData(race).GetRaceName();
	}

	// Token: 0x0600CCB4 RID: 52404 RVA: 0x002EC0F4 File Offset: 0x002EA2F4
	public int GetBasicSalary()
	{
		return this.Config.Salary;
	}

	// Token: 0x0600CCB5 RID: 52405 RVA: 0x002EC110 File Offset: 0x002EA310
	public int GetRace()
	{
		return this.Config.Race;
	}

	// Token: 0x0600CCB6 RID: 52406 RVA: 0x002EC12C File Offset: 0x002EA32C
	public int GetRarity()
	{
		return this.Config.RarityId;
	}

	// Token: 0x0600CCB7 RID: 52407 RVA: 0x002EC148 File Offset: 0x002EA348
	public int GetCardSalary()
	{
		return this.Config.Salary;
	}

	// Token: 0x0600CCB8 RID: 52408 RVA: 0x002EC164 File Offset: 0x002EA364
	public string GetSpineAtlas()
	{
		return this.Config.Spine;
	}

	// Token: 0x0600CCB9 RID: 52409 RVA: 0x002EC180 File Offset: 0x002EA380
	public string GetSpineData()
	{
		return this.Config.SpineSkeletonData;
	}

	// Token: 0x0600CCBA RID: 52410 RVA: 0x002EC19C File Offset: 0x002EA39C
	public int GetEvolveItemOffsetY()
	{
		return this.Config.EvolveItemOffsetY;
	}

	// Token: 0x0600CCBB RID: 52411 RVA: 0x002EC1B8 File Offset: 0x002EA3B8
	public EFloroRanchCardDirection GetCardDefaultDirection()
	{
		return (EFloroRanchCardDirection)this.Config.Towards;
	}

	// Token: 0x0600CCBC RID: 52412 RVA: 0x002EC1D4 File Offset: 0x002EA3D4
	public EFloroRanchSpecialEffectType GetCardSpecialEffect()
	{
		return (EFloroRanchSpecialEffectType)this.Config.SpeicalEffectshow;
	}

	// Token: 0x170010DF RID: 4319
	// (get) Token: 0x0600CCBD RID: 52413 RVA: 0x002EC1F0 File Offset: 0x002EA3F0
	public bool IsShowInHandBook
	{
		get
		{
			return this.Config.Illustration;
		}
	}

	// Token: 0x170010E0 RID: 4320
	// (get) Token: 0x0600CCBE RID: 52414 RVA: 0x002EC20C File Offset: 0x002EA40C
	public bool IsSpecialPhantom
	{
		get
		{
			return this.Config.IsSpecial;
		}
	}

	// Token: 0x170010E1 RID: 4321
	// (get) Token: 0x0600CCBF RID: 52415 RVA: 0x002EC228 File Offset: 0x002EA428
	public string Video
	{
		get
		{
			return this.Config.Video;
		}
	}

	// Token: 0x04005DFC RID: 24060
	private readonly FloroRanchCard Config;

	// Token: 0x04005DFD RID: 24061
	public FloroRanchTagData TagData = new FloroRanchTagData();
}

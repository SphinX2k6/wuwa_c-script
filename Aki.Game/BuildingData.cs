using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020007AC RID: 1964
[NullableContext(1)]
[Nullable(0)]
public class BuildingData
{
	// Token: 0x17000BA2 RID: 2978
	// (get) Token: 0x060059E1 RID: 23009 RVA: 0x001D314A File Offset: 0x001D134A
	public bool IsBuild
	{
		get
		{
			return this.Level > 0;
		}
	}

	// Token: 0x060059E2 RID: 23010 RVA: 0x001D3155 File Offset: 0x001D1355
	public BuildingData(int id)
	{
		this.Id = id;
	}

	// Token: 0x060059E3 RID: 23011 RVA: 0x001D3164 File Offset: 0x001D1364
	public string GetBuildingName()
	{
		return ConfigMultiTextLang.GetLocalTextNew(BuildingConfig.Instance.GetBuildingById(this.Id).Name, null) ?? "";
	}

	// Token: 0x060059E4 RID: 23012 RVA: 0x001D3198 File Offset: 0x001D1398
	public int GetConsumeCount()
	{
		Building buildingById = BuildingConfig.Instance.GetBuildingById(this.Id);
		if (this.Level == 0)
		{
			return buildingById.UnLockPrice;
		}
		return BuildingConfig.Instance.GetBuildingUpGradeCurveByGroupIdAndLevel(buildingById.UpGradeCurve, this.Level).UpGradePrice;
	}

	// Token: 0x060059E5 RID: 23013 RVA: 0x001D31E5 File Offset: 0x001D13E5
	private IAdditionData CreateAdditionData(string textId, string valueText)
	{
		return new AdditionData(textId, valueText);
	}

	// Token: 0x060059E6 RID: 23014 RVA: 0x001D31F0 File Offset: 0x001D13F0
	public List<IAdditionData> GetAdditionDataList(int level)
	{
		int level2 = MathUtils.Instance.Clamp(level, 1, this.LevelMax);
		List<IAdditionData> list = new List<IAdditionData>();
		Building buildingById = BuildingConfig.Instance.GetBuildingById(this.Id);
		BuildingUpGradeCurve buildingUpGradeCurveByGroupIdAndLevel = BuildingConfig.Instance.GetBuildingUpGradeCurveByGroupIdAndLevel(buildingById.UpGradeCurve, level2);
		if (buildingUpGradeCurveByGroupIdAndLevel.GoldAddition != 0)
		{
			string valueText = (buildingUpGradeCurveByGroupIdAndLevel.GoldAddition / 10).ToString() + "%";
			list.Add(this.CreateAdditionData("Moonfiesta_UP1", valueText));
		}
		if (buildingUpGradeCurveByGroupIdAndLevel.GoldAdditionFix != 0)
		{
			list.Add(this.CreateAdditionData("Moonfiesta_UP7", buildingUpGradeCurveByGroupIdAndLevel.GoldAdditionFix.ToString()));
		}
		if (buildingUpGradeCurveByGroupIdAndLevel.WishAdditionFix != 0)
		{
			list.Add(this.CreateAdditionData("Moonfiesta_UP2", buildingUpGradeCurveByGroupIdAndLevel.WishAdditionFix.ToString()));
		}
		if (buildingUpGradeCurveByGroupIdAndLevel.EnergyAddition != 0)
		{
			string valueText2 = (buildingUpGradeCurveByGroupIdAndLevel.EnergyAddition / 10).ToString() + "%";
			list.Add(this.CreateAdditionData("Moonfiesta_UP3", valueText2));
		}
		if (buildingUpGradeCurveByGroupIdAndLevel.IdeaRatioAddition != 0)
		{
			string valueText3 = (buildingUpGradeCurveByGroupIdAndLevel.IdeaRatioAddition / 10).ToString() + "%";
			list.Add(this.CreateAdditionData("Moonfiesta_UP4", valueText3));
		}
		if (buildingUpGradeCurveByGroupIdAndLevel.SuccessAddition != 0)
		{
			string valueText4 = (buildingUpGradeCurveByGroupIdAndLevel.SuccessAddition / 10).ToString() + "%";
			list.Add(this.CreateAdditionData("Moonfiesta_UP5", valueText4));
		}
		if (buildingUpGradeCurveByGroupIdAndLevel.HeatAddition != 0)
		{
			list.Add(this.CreateAdditionData("Moonfiesta_UP6", buildingUpGradeCurveByGroupIdAndLevel.HeatAddition.ToString()));
		}
		return list;
	}

	// Token: 0x060059E7 RID: 23015 RVA: 0x001D33A8 File Offset: 0x001D15A8
	public string GetLevelUpIncreaseDesc()
	{
		List<IAdditionData> additionDataList = this.GetAdditionDataList(this.Level);
		if (additionDataList.Count < 1)
		{
			return string.Empty;
		}
		IAdditionData additionData = additionDataList[0];
		return ConfigMultiTextLang.GetLocalTextNew(additionData.TextId, null) + " " + additionData.ValueText;
	}

	// Token: 0x060059E8 RID: 23016 RVA: 0x001D33F8 File Offset: 0x001D15F8
	public int GetAssociateRoleId()
	{
		return BuildingConfig.Instance.GetBuildingById(this.Id).AssociateRole;
	}

	// Token: 0x17000BA3 RID: 2979
	// (get) Token: 0x060059E9 RID: 23017 RVA: 0x001D3420 File Offset: 0x001D1620
	public bool IsCanLevelUp
	{
		get
		{
			int consumeCount = this.GetConsumeCount();
			int coinItemId = BusinessConfig.Instance.GetCoinItemId();
			return InventoryModel.Instance.GetItemCountByConfigId(coinItemId, 0) >= consumeCount;
		}
	}

	// Token: 0x17000BA4 RID: 2980
	// (get) Token: 0x060059EA RID: 23018 RVA: 0x001D3454 File Offset: 0x001D1654
	public int LevelMax
	{
		get
		{
			Building buildingById = BuildingConfig.Instance.GetBuildingById(this.Id);
			IReadOnlyList<BuildingUpGradeCurve> buildingUpGradeCurveByGroupId = BuildingConfig.Instance.GetBuildingUpGradeCurveByGroupId(buildingById.UpGradeCurve);
			return buildingUpGradeCurveByGroupId[buildingUpGradeCurveByGroupId.Count - 1].Level;
		}
	}

	// Token: 0x17000BA5 RID: 2981
	// (get) Token: 0x060059EB RID: 23019 RVA: 0x001D3498 File Offset: 0x001D1698
	public bool IsMax
	{
		get
		{
			return this.Level >= this.LevelMax;
		}
	}

	// Token: 0x17000BA6 RID: 2982
	// (get) Token: 0x060059EC RID: 23020 RVA: 0x001D34AB File Offset: 0x001D16AB
	public bool IsAvailableLevelUp
	{
		get
		{
			return this.IsBuild && !this.IsMax;
		}
	}

	// Token: 0x04003CBE RID: 15550
	public int Level;

	// Token: 0x04003CBF RID: 15551
	public bool IsUnlock;

	// Token: 0x04003CC0 RID: 15552
	public readonly int Id;
}

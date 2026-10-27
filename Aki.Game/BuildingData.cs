using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020012F8 RID: 4856
[NullableContext(1)]
[Nullable(0)]
public class BuildingData
{
	// Token: 0x17000B82 RID: 2946
	// (get) Token: 0x06008646 RID: 34374 RVA: 0x001CA2DE File Offset: 0x001C84DE
	public bool IsBuild
	{
		get
		{
			return this.Level > 0;
		}
	}

	// Token: 0x06008647 RID: 34375 RVA: 0x001CA2E9 File Offset: 0x001C84E9
	public BuildingData(int id)
	{
		this.Id = id;
	}

	// Token: 0x06008648 RID: 34376 RVA: 0x001CA2F8 File Offset: 0x001C84F8
	public string GetBuildingName()
	{
		return ConfigMultiTextLang.GetLocalTextNew(BuildingConfig.Instance.GetBuildingById(this.Id).Name, null) ?? "";
	}

	// Token: 0x06008649 RID: 34377 RVA: 0x001CA32C File Offset: 0x001C852C
	public int GetConsumeCount()
	{
		Building buildingById = BuildingConfig.Instance.GetBuildingById(this.Id);
		if (this.Level == 0)
		{
			return buildingById.UnLockPrice;
		}
		return BuildingConfig.Instance.GetBuildingUpGradeCurveByGroupIdAndLevel(buildingById.UpGradeCurve, this.Level).UpGradePrice;
	}

	// Token: 0x0600864A RID: 34378 RVA: 0x001CA379 File Offset: 0x001C8579
	private IAdditionData CreateAdditionData(string textId, string valueText)
	{
		return new AdditionData(textId, valueText);
	}

	// Token: 0x0600864B RID: 34379 RVA: 0x001CA384 File Offset: 0x001C8584
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

	// Token: 0x0600864C RID: 34380 RVA: 0x001CA53C File Offset: 0x001C873C
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

	// Token: 0x0600864D RID: 34381 RVA: 0x001CA58C File Offset: 0x001C878C
	public int GetAssociateRoleId()
	{
		return BuildingConfig.Instance.GetBuildingById(this.Id).AssociateRole;
	}

	// Token: 0x17000B83 RID: 2947
	// (get) Token: 0x0600864E RID: 34382 RVA: 0x001CA5B4 File Offset: 0x001C87B4
	public bool IsCanLevelUp
	{
		get
		{
			int consumeCount = this.GetConsumeCount();
			int coinItemId = BusinessConfig.Instance.GetCoinItemId();
			return InventoryModel.Instance.GetItemCountByConfigId(coinItemId, 0) >= consumeCount;
		}
	}

	// Token: 0x17000B84 RID: 2948
	// (get) Token: 0x0600864F RID: 34383 RVA: 0x001CA5E8 File Offset: 0x001C87E8
	public int LevelMax
	{
		get
		{
			Building buildingById = BuildingConfig.Instance.GetBuildingById(this.Id);
			IReadOnlyList<BuildingUpGradeCurve> buildingUpGradeCurveByGroupId = BuildingConfig.Instance.GetBuildingUpGradeCurveByGroupId(buildingById.UpGradeCurve);
			return buildingUpGradeCurveByGroupId[buildingUpGradeCurveByGroupId.Count - 1].Level;
		}
	}

	// Token: 0x17000B85 RID: 2949
	// (get) Token: 0x06008650 RID: 34384 RVA: 0x001CA62C File Offset: 0x001C882C
	public bool IsMax
	{
		get
		{
			return this.Level >= this.LevelMax;
		}
	}

	// Token: 0x17000B86 RID: 2950
	// (get) Token: 0x06008651 RID: 34385 RVA: 0x001CA63F File Offset: 0x001C883F
	public bool IsAvailableLevelUp
	{
		get
		{
			return this.IsBuild && !this.IsMax;
		}
	}

	// Token: 0x04003C26 RID: 15398
	public int Level;

	// Token: 0x04003C27 RID: 15399
	public bool IsUnlock;

	// Token: 0x04003C28 RID: 15400
	public readonly int Id;
}

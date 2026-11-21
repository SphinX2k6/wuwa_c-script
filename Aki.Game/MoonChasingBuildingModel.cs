using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot;

// Token: 0x020007AD RID: 1965
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class MoonChasingBuildingModel : ModelBase
{
	// Token: 0x060059ED RID: 23021 RVA: 0x001D34C0 File Offset: 0x001D16C0
	protected override bool OnInit()
	{
		IReadOnlyList<Building> buildingAll = BuildingConfig.Instance.GetBuildingAll();
		if (buildingAll != null)
		{
			for (int i = 0; i < buildingAll.Count; i++)
			{
				Building building = buildingAll[i];
				BuildingData value = new BuildingData(building.Id);
				this.BuildingDataMap[building.Id] = value;
			}
		}
		return true;
	}

	// Token: 0x060059EE RID: 23022 RVA: 0x001D3518 File Offset: 0x001D1718
	public void SetAllBuildingData(IReadOnlyList<BuildingInfo> dataList)
	{
		for (int i = 0; i < dataList.Count; i++)
		{
			this.SetBuildingData(dataList[i]);
		}
		EventSystem.Instance.Emit(EEventName.TrackMoonHandbookUpdate);
	}

	// Token: 0x060059EF RID: 23023 RVA: 0x001D3553 File Offset: 0x001D1753
	public void SetBuildingData(BuildingInfo data)
	{
		BuildingData buildingData = this.BuildingDataMap[data.BuildingId];
		buildingData.IsUnlock = data.IsUnlock;
		buildingData.Level = data.Level;
		EventSystem.Instance.Emit(EEventName.MoonChasingRefreshBuildingRedDot);
	}

	// Token: 0x060059F0 RID: 23024 RVA: 0x001D358D File Offset: 0x001D178D
	public void ConditionUnlockBuildingData(BuildingInfo data)
	{
		this.SetBuildingData(data);
	}

	// Token: 0x060059F1 RID: 23025 RVA: 0x001D3596 File Offset: 0x001D1796
	public void LevelUpBuildingData(BuildingInfo data, int lastPopularity, int curPopularity)
	{
		this.SetBuildingData(data);
		this.InitPopularityData(lastPopularity, curPopularity, true);
	}

	// Token: 0x060059F2 RID: 23026 RVA: 0x001D35A8 File Offset: 0x001D17A8
	public BuildingData GetBuildingDataById(int id)
	{
		return this.BuildingDataMap[id];
	}

	// Token: 0x060059F3 RID: 23027 RVA: 0x001D35B6 File Offset: 0x001D17B6
	public void UnlockBuildingData(int buildingId, int lastPopularity, int curPopularity)
	{
		BuildingData buildingData = this.BuildingDataMap[buildingId];
		buildingData.IsUnlock = true;
		buildingData.Level = 1;
		this.InitPopularityData(lastPopularity, curPopularity, false);
		EventSystem.Instance.Emit(EEventName.TrackMoonHandbookUpdate);
	}

	// Token: 0x060059F4 RID: 23028 RVA: 0x001D35EA File Offset: 0x001D17EA
	public int GetBuildingDataSize()
	{
		return this.BuildingDataMap.Count;
	}

	// Token: 0x060059F5 RID: 23029 RVA: 0x001D35F8 File Offset: 0x001D17F8
	public List<BuildingData> GetAllBuildingData()
	{
		List<BuildingData> list = new List<BuildingData>();
		foreach (BuildingData item in this.BuildingDataMap.Values)
		{
			list.Add(item);
		}
		return list;
	}

	// Token: 0x060059F6 RID: 23030 RVA: 0x001D3658 File Offset: 0x001D1858
	public int GetBuiltBuildingCount()
	{
		int num = 0;
		using (Dictionary<int, BuildingData>.ValueCollection.Enumerator enumerator = this.BuildingDataMap.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.IsBuild)
				{
					num++;
				}
			}
		}
		return num;
	}

	// Token: 0x060059F7 RID: 23031 RVA: 0x001D36B8 File Offset: 0x001D18B8
	public void InitPopularityData(int lastPopularity, int curPopularity, bool isLevelUp)
	{
		Popularity popularityConfigByValue = MoonChasingBusinessModel.Instance.GetPopularityConfigByValue(curPopularity);
		int playerRoleId = MoonChasingBusinessModel.Instance.GetPlayerRoleId();
		bool flag = PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male;
		string title = isLevelUp ? "Moonfiesta_Title4" : "Moonfiesta_Title3";
		string dialogName = flag ? (popularityConfigByValue.NpcDialog ?? "") : (popularityConfigByValue.NpcDialogGirl ?? "");
		MoonChasingPopularityUpData popularityUpData = new MoonChasingPopularityUpData(playerRoleId, lastPopularity, curPopularity, dialogName, title);
		this.SetPopularityUpData(popularityUpData);
	}

	// Token: 0x060059F8 RID: 23032 RVA: 0x001D372E File Offset: 0x001D192E
	[NullableContext(2)]
	public void SetPopularityUpData(MoonChasingPopularityUpData popularityUpData)
	{
		this.PopularityUpData = popularityUpData;
	}

	// Token: 0x060059F9 RID: 23033 RVA: 0x001D3737 File Offset: 0x001D1937
	[NullableContext(2)]
	public MoonChasingPopularityUpData GetPopularityUpData()
	{
		return this.PopularityUpData;
	}

	// Token: 0x060059FA RID: 23034 RVA: 0x001D3740 File Offset: 0x001D1940
	public bool CheckAllBuildingRedDotState()
	{
		foreach (BuildingData buildingData in this.BuildingDataMap.Values)
		{
			if (this.CheckBuildingRedDotState(buildingData))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060059FB RID: 23035 RVA: 0x001D37A4 File Offset: 0x001D19A4
	[NullableContext(2)]
	public BuildingData GetFirstUnLockBuildingData()
	{
		foreach (BuildingData buildingData in this.BuildingDataMap.Values)
		{
			if (buildingData.IsUnlock && buildingData.Level == 0 && buildingData.IsCanLevelUp)
			{
				return buildingData;
			}
		}
		return null;
	}

	// Token: 0x060059FC RID: 23036 RVA: 0x001D3814 File Offset: 0x001D1A14
	public int? GetFirstCanLevelUpBuildingId()
	{
		foreach (BuildingData buildingData in this.BuildingDataMap.Values)
		{
			if (buildingData.IsAvailableLevelUp && this.CheckBuildingRedDotState(buildingData))
			{
				return new int?(buildingData.Id);
			}
		}
		return null;
	}

	// Token: 0x060059FD RID: 23037 RVA: 0x001D3890 File Offset: 0x001D1A90
	public bool CheckBuildingRedDotState(BuildingData buildingData)
	{
		int coinValue = MoonChasingModel.Instance.GetCoinValue();
		return buildingData.IsUnlock && !buildingData.IsMax && coinValue >= buildingData.GetConsumeCount();
	}

	// Token: 0x060059FE RID: 23038 RVA: 0x001D38C8 File Offset: 0x001D1AC8
	public List<Building> GetBuildingConfigListBySort()
	{
		IReadOnlyList<Building> buildingAll = BuildingConfig.Instance.GetBuildingAll();
		List<Building> list = new List<Building>();
		if (buildingAll != null)
		{
			for (int i = 0; i < buildingAll.Count; i++)
			{
				list.Add(buildingAll[i]);
			}
		}
		list.Sort(delegate(Building aConfig, Building bConfig)
		{
			if (aConfig.Sort >= bConfig.Sort)
			{
				return 1;
			}
			return -1;
		});
		return list;
	}

	// Token: 0x060059FF RID: 23039 RVA: 0x001D3930 File Offset: 0x001D1B30
	public bool CheckPlotInfoValid(PlotResultInfo plotResult)
	{
		IReadOnlyList<Building> buildingAll = BuildingConfig.Instance.GetBuildingAll();
		if (buildingAll != null)
		{
			for (int i = 0; i < buildingAll.Count; i++)
			{
				Building building = buildingAll[i];
				if ((building.FlowListName ?? "") == (plotResult.FlowListName ?? "") && building.FlowId == plotResult.FlowId.GetValueOrDefault(-1) && building.StateId == plotResult.StateId.GetValueOrDefault(-1))
				{
					return true;
				}
			}
		}
		string a = ConfigCommonParamById.GetStringConfig("MoonChasingBuildLastFlowName") ?? "";
		int valueOrDefault = ConfigCommonParamById.GetIntConfig("MoonChasingBuildLastFlowIdF").GetValueOrDefault();
		int valueOrDefault2 = ConfigCommonParamById.GetIntConfig("MoonChasingBuildLastFlowIdC").GetValueOrDefault();
		return a == (plotResult.FlowListName ?? "") && valueOrDefault == plotResult.FlowId.GetValueOrDefault(-1) && valueOrDefault2 == plotResult.StateId.GetValueOrDefault(-1);
	}

	// Token: 0x06005A00 RID: 23040 RVA: 0x001D3A2C File Offset: 0x001D1C2C
	public int GetBuildingIdByRoleId(int roleId)
	{
		IReadOnlyList<Building> buildingAll = BuildingConfig.Instance.GetBuildingAll();
		if (buildingAll != null)
		{
			for (int i = 0; i < buildingAll.Count; i++)
			{
				Building building = buildingAll[i];
				if (building.AssociateRole == roleId)
				{
					return building.Id;
				}
			}
		}
		return -1;
	}

	// Token: 0x17000BA7 RID: 2983
	// (get) Token: 0x06005A01 RID: 23041 RVA: 0x001D3A73 File Offset: 0x001D1C73
	public static MoonChasingBuildingModel Instance
	{
		get
		{
			return MoonChasingBuildingModel._Instance;
		}
	}

	// Token: 0x06005A02 RID: 23042 RVA: 0x001D3A7A File Offset: 0x001D1C7A
	public static MoonChasingBuildingModel GetOrCreateInstance()
	{
		if (MoonChasingBuildingModel._Instance == null)
		{
			MoonChasingBuildingModel.CreateInstance();
		}
		return MoonChasingBuildingModel._Instance;
	}

	// Token: 0x06005A03 RID: 23043 RVA: 0x001D3A8E File Offset: 0x001D1C8E
	public static bool CreateInstance()
	{
		if (MoonChasingBuildingModel._Instance != null)
		{
			return true;
		}
		MoonChasingBuildingModel._Instance = new MoonChasingBuildingModel();
		return true;
	}

	// Token: 0x06005A04 RID: 23044 RVA: 0x001D3AA4 File Offset: 0x001D1CA4
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06005A05 RID: 23045 RVA: 0x001D3AA6 File Offset: 0x001D1CA6
	public static void ResetStaticDefaultValue()
	{
		MoonChasingBuildingModel._Instance = null;
	}

	// Token: 0x06005A06 RID: 23046 RVA: 0x001D3AAE File Offset: 0x001D1CAE
	static MoonChasingBuildingModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MoonChasingBuildingModel.CreateStaticDefaultValue), new Action(MoonChasingBuildingModel.ResetStaticDefaultValue));
	}

	// Token: 0x04003CC1 RID: 15553
	private readonly Dictionary<int, BuildingData> BuildingDataMap = new Dictionary<int, BuildingData>();

	// Token: 0x04003CC2 RID: 15554
	[Nullable(2)]
	private MoonChasingPopularityUpData PopularityUpData;

	// Token: 0x04003CC3 RID: 15555
	[Nullable(2)]
	private static MoonChasingBuildingModel _Instance;
}

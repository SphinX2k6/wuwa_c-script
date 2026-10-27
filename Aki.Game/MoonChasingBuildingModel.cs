using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot;

// Token: 0x020012F9 RID: 4857
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class MoonChasingBuildingModel : ModelBase
{
	// Token: 0x06008652 RID: 34386 RVA: 0x001CA654 File Offset: 0x001C8854
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

	// Token: 0x06008653 RID: 34387 RVA: 0x001CA6AC File Offset: 0x001C88AC
	public void SetAllBuildingData(IReadOnlyList<BuildingInfo> dataList)
	{
		for (int i = 0; i < dataList.Count; i++)
		{
			this.SetBuildingData(dataList[i]);
		}
		EventSystem.Instance.Emit(EEventName.TrackMoonHandbookUpdate);
	}

	// Token: 0x06008654 RID: 34388 RVA: 0x001CA6E7 File Offset: 0x001C88E7
	public void SetBuildingData(BuildingInfo data)
	{
		BuildingData buildingData = this.BuildingDataMap[data.BuildingId];
		buildingData.IsUnlock = data.IsUnlock;
		buildingData.Level = data.Level;
		EventSystem.Instance.Emit(EEventName.MoonChasingRefreshBuildingRedDot);
	}

	// Token: 0x06008655 RID: 34389 RVA: 0x001CA721 File Offset: 0x001C8921
	public void ConditionUnlockBuildingData(BuildingInfo data)
	{
		this.SetBuildingData(data);
	}

	// Token: 0x06008656 RID: 34390 RVA: 0x001CA72A File Offset: 0x001C892A
	public void LevelUpBuildingData(BuildingInfo data, int lastPopularity, int curPopularity)
	{
		this.SetBuildingData(data);
		this.InitPopularityData(lastPopularity, curPopularity, true);
	}

	// Token: 0x06008657 RID: 34391 RVA: 0x001CA73C File Offset: 0x001C893C
	public BuildingData GetBuildingDataById(int id)
	{
		return this.BuildingDataMap[id];
	}

	// Token: 0x06008658 RID: 34392 RVA: 0x001CA74A File Offset: 0x001C894A
	public void UnlockBuildingData(int buildingId, int lastPopularity, int curPopularity)
	{
		BuildingData buildingData = this.BuildingDataMap[buildingId];
		buildingData.IsUnlock = true;
		buildingData.Level = 1;
		this.InitPopularityData(lastPopularity, curPopularity, false);
		EventSystem.Instance.Emit(EEventName.TrackMoonHandbookUpdate);
	}

	// Token: 0x06008659 RID: 34393 RVA: 0x001CA77E File Offset: 0x001C897E
	public int GetBuildingDataSize()
	{
		return this.BuildingDataMap.Count;
	}

	// Token: 0x0600865A RID: 34394 RVA: 0x001CA78C File Offset: 0x001C898C
	public List<BuildingData> GetAllBuildingData()
	{
		List<BuildingData> list = new List<BuildingData>();
		foreach (BuildingData item in this.BuildingDataMap.Values)
		{
			list.Add(item);
		}
		return list;
	}

	// Token: 0x0600865B RID: 34395 RVA: 0x001CA7EC File Offset: 0x001C89EC
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

	// Token: 0x0600865C RID: 34396 RVA: 0x001CA84C File Offset: 0x001C8A4C
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

	// Token: 0x0600865D RID: 34397 RVA: 0x001CA8C2 File Offset: 0x001C8AC2
	[NullableContext(2)]
	public void SetPopularityUpData(MoonChasingPopularityUpData popularityUpData)
	{
		this.PopularityUpData = popularityUpData;
	}

	// Token: 0x0600865E RID: 34398 RVA: 0x001CA8CB File Offset: 0x001C8ACB
	[NullableContext(2)]
	public MoonChasingPopularityUpData GetPopularityUpData()
	{
		return this.PopularityUpData;
	}

	// Token: 0x0600865F RID: 34399 RVA: 0x001CA8D4 File Offset: 0x001C8AD4
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

	// Token: 0x06008660 RID: 34400 RVA: 0x001CA938 File Offset: 0x001C8B38
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

	// Token: 0x06008661 RID: 34401 RVA: 0x001CA9A8 File Offset: 0x001C8BA8
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

	// Token: 0x06008662 RID: 34402 RVA: 0x001CAA24 File Offset: 0x001C8C24
	public bool CheckBuildingRedDotState(BuildingData buildingData)
	{
		int coinValue = MoonChasingModel.Instance.GetCoinValue();
		return buildingData.IsUnlock && !buildingData.IsMax && coinValue >= buildingData.GetConsumeCount();
	}

	// Token: 0x06008663 RID: 34403 RVA: 0x001CAA5C File Offset: 0x001C8C5C
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

	// Token: 0x06008664 RID: 34404 RVA: 0x001CAAC4 File Offset: 0x001C8CC4
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

	// Token: 0x06008665 RID: 34405 RVA: 0x001CABC0 File Offset: 0x001C8DC0
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

	// Token: 0x17000B87 RID: 2951
	// (get) Token: 0x06008666 RID: 34406 RVA: 0x001CAC07 File Offset: 0x001C8E07
	public static MoonChasingBuildingModel Instance
	{
		get
		{
			return MoonChasingBuildingModel._Instance;
		}
	}

	// Token: 0x06008667 RID: 34407 RVA: 0x001CAC0E File Offset: 0x001C8E0E
	public static MoonChasingBuildingModel GetOrCreateInstance()
	{
		if (MoonChasingBuildingModel._Instance == null)
		{
			MoonChasingBuildingModel.CreateInstance();
		}
		return MoonChasingBuildingModel._Instance;
	}

	// Token: 0x06008668 RID: 34408 RVA: 0x001CAC22 File Offset: 0x001C8E22
	public static bool CreateInstance()
	{
		if (MoonChasingBuildingModel._Instance != null)
		{
			return true;
		}
		MoonChasingBuildingModel._Instance = new MoonChasingBuildingModel();
		return true;
	}

	// Token: 0x06008669 RID: 34409 RVA: 0x001CAC38 File Offset: 0x001C8E38
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600866A RID: 34410 RVA: 0x001CAC3A File Offset: 0x001C8E3A
	public static void ResetStaticDefaultValue()
	{
		MoonChasingBuildingModel._Instance = null;
	}

	// Token: 0x0600866B RID: 34411 RVA: 0x001CAC42 File Offset: 0x001C8E42
	static MoonChasingBuildingModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MoonChasingBuildingModel.CreateStaticDefaultValue), new Action(MoonChasingBuildingModel.ResetStaticDefaultValue));
	}

	// Token: 0x04003C29 RID: 15401
	private readonly Dictionary<int, BuildingData> BuildingDataMap = new Dictionary<int, BuildingData>();

	// Token: 0x04003C2A RID: 15402
	[Nullable(2)]
	private MoonChasingPopularityUpData PopularityUpData;

	// Token: 0x04003C2B RID: 15403
	[Nullable(2)]
	private static MoonChasingBuildingModel _Instance;
}

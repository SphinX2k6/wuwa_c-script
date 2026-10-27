using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.TowerDefenseEvent.Model;
using UnrealEngine;

// Token: 0x0200171E RID: 5918
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class BuildingGridModel : ModelBase
{
	// Token: 0x0600AAE3 RID: 43747 RVA: 0x0026676C File Offset: 0x0026496C
	public BuildingGridModel()
	{
		this.CellModelPool = new Pool<BuildingGridCellModel>(100, () => new BuildingGridCellModel(), null);
		this.TempGridCellVector = default(FKuroBuildingGridCellVector);
	}

	// Token: 0x0600AAE4 RID: 43748 RVA: 0x002667C4 File Offset: 0x002649C4
	public bool UpdateGridCell(GridCellUpdateNotify data)
	{
		LevelGridPbData levelGridData = data.LevelGridData;
		GridPlacementPbInfo gridPlacementPbInfo = (levelGridData != null) ? levelGridData.GridPlacementPbInfo : null;
		if (gridPlacementPbInfo == null)
		{
			return false;
		}
		string actorGuid = gridPlacementPbInfo.ActorGuid;
		int x = gridPlacementPbInfo.X;
		int y = gridPlacementPbInfo.Y;
		AKuroBuildingGrid akuroBuildingGrid = UKuroBuildingGridSubsystem.K2_FindBuildingGrid(GlobalData.World, actorGuid);
		if (akuroBuildingGrid == null)
		{
			return false;
		}
		this.TempGridCellVector.X = x;
		this.TempGridCellVector.Y = y;
		int num = 0;
		if (!akuroBuildingGrid.GetCellIndex(this.TempGridCellVector, ref num))
		{
			return false;
		}
		int key = num;
		Dictionary<int, BuildingGridCellModel> dictionary;
		if (!this.GridCellModels.TryGetValue(actorGuid, out dictionary))
		{
			if (!data.IsAdd)
			{
				return false;
			}
			dictionary = new Dictionary<int, BuildingGridCellModel>();
			this.GridCellModels[actorGuid] = dictionary;
		}
		BuildingGridCellModel buildingGridCellModel;
		if (!dictionary.TryGetValue(key, out buildingGridCellModel))
		{
			if (!data.IsAdd)
			{
				return false;
			}
			buildingGridCellModel = this.CellModelPool.Get();
			if (buildingGridCellModel == null)
			{
				buildingGridCellModel = this.CellModelPool.Create();
			}
			dictionary[key] = buildingGridCellModel;
		}
		if (!data.IsAdd)
		{
			dictionary.Remove(key);
			if (dictionary.Count == 0)
			{
				this.GridCellModels.Remove(actorGuid);
			}
			this.CellModelPool.Put(buildingGridCellModel);
			return true;
		}
		buildingGridCellModel.GridId = actorGuid;
		buildingGridCellModel.X = x;
		buildingGridCellModel.Y = y;
		buildingGridCellModel.CreatureId = 0L;
		LevelGridPbData levelGridData2 = data.LevelGridData;
		if (((levelGridData2 != null) ? levelGridData2.PollutedGridPbData : null) != null)
		{
			buildingGridCellModel.CreatureId = -1L;
		}
		else
		{
			LevelGridPbData levelGridData3 = data.LevelGridData;
			if (((levelGridData3 != null) ? levelGridData3.EntityGridPbData : null) != null)
			{
				buildingGridCellModel.CreatureId = data.LevelGridData.EntityGridPbData.Id;
			}
		}
		return true;
	}

	// Token: 0x0600AAE5 RID: 43749 RVA: 0x00266958 File Offset: 0x00264B58
	public int IsCellPolluted(string gridId, int index)
	{
		Dictionary<int, BuildingGridCellModel> dictionary;
		if (!this.GridCellModels.TryGetValue(gridId, out dictionary))
		{
			return -1;
		}
		BuildingGridCellModel buildingGridCellModel;
		if (!dictionary.TryGetValue(index, out buildingGridCellModel))
		{
			return -1;
		}
		ITowerDefenseEventCombatInfo entity = TowerDefenseEventModel.Instance.GetEntity(buildingGridCellModel.CreatureId);
		ITowerDefenseEventSpecialCellInfo towerDefenseEventSpecialCellInfo = entity as ITowerDefenseEventSpecialCellInfo;
		if (towerDefenseEventSpecialCellInfo != null && towerDefenseEventSpecialCellInfo.CellType == 2)
		{
			TowerDefenseEventEntityModel towerDefenseEventEntityModel = entity as TowerDefenseEventEntityModel;
			return (int)((towerDefenseEventEntityModel != null) ? towerDefenseEventEntityModel.Uid : -1L);
		}
		return -1;
	}

	// Token: 0x0600AAE6 RID: 43750 RVA: 0x002669C0 File Offset: 0x00264BC0
	protected override bool OnLeaveLevel()
	{
		foreach (Dictionary<int, BuildingGridCellModel> dictionary in this.GridCellModels.Values)
		{
			foreach (BuildingGridCellModel value in dictionary.Values)
			{
				this.CellModelPool.Put(value);
			}
			dictionary.Clear();
		}
		this.GridCellModels.Clear();
		this.CellModelPool.Clear();
		return base.OnLeaveLevel();
	}

	// Token: 0x17000E0B RID: 3595
	// (get) Token: 0x0600AAE7 RID: 43751 RVA: 0x00266A7C File Offset: 0x00264C7C
	public static BuildingGridModel Instance
	{
		get
		{
			return BuildingGridModel._Instance;
		}
	}

	// Token: 0x0600AAE8 RID: 43752 RVA: 0x00266A83 File Offset: 0x00264C83
	public static BuildingGridModel GetOrCreateInstance()
	{
		if (BuildingGridModel._Instance == null)
		{
			BuildingGridModel.CreateInstance();
		}
		return BuildingGridModel._Instance;
	}

	// Token: 0x0600AAE9 RID: 43753 RVA: 0x00266A97 File Offset: 0x00264C97
	public static bool CreateInstance()
	{
		if (BuildingGridModel._Instance != null)
		{
			return true;
		}
		BuildingGridModel._Instance = new BuildingGridModel();
		return true;
	}

	// Token: 0x0600AAEA RID: 43754 RVA: 0x00266AAD File Offset: 0x00264CAD
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600AAEB RID: 43755 RVA: 0x00266AAF File Offset: 0x00264CAF
	public static void ResetStaticDefaultValue()
	{
		BuildingGridModel._Instance = null;
	}

	// Token: 0x0600AAEC RID: 43756 RVA: 0x00266AB7 File Offset: 0x00264CB7
	static BuildingGridModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BuildingGridModel.CreateStaticDefaultValue), new Action(BuildingGridModel.ResetStaticDefaultValue));
	}

	// Token: 0x04004D8A RID: 19850
	private Pool<BuildingGridCellModel> CellModelPool;

	// Token: 0x04004D8B RID: 19851
	private FKuroBuildingGridCellVector TempGridCellVector;

	// Token: 0x04004D8C RID: 19852
	private readonly Dictionary<string, Dictionary<int, BuildingGridCellModel>> GridCellModels = new Dictionary<string, Dictionary<int, BuildingGridCellModel>>();

	// Token: 0x04004D8D RID: 19853
	[Nullable(2)]
	private static BuildingGridModel _Instance;
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.TowerDefenseEvent.Model;
using UnrealEngine;

// Token: 0x02000BD6 RID: 3030
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class BuildingGridModel : ModelBase
{
	// Token: 0x06007EC5 RID: 32453 RVA: 0x00270B44 File Offset: 0x0026ED44
	public BuildingGridModel()
	{
		this.CellModelPool = new Pool<BuildingGridCellModel>(100, () => new BuildingGridCellModel(), null);
		this.TempGridCellVector = default(FKuroBuildingGridCellVector);
	}

	// Token: 0x06007EC6 RID: 32454 RVA: 0x00270B9C File Offset: 0x0026ED9C
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

	// Token: 0x06007EC7 RID: 32455 RVA: 0x00270D30 File Offset: 0x0026EF30
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

	// Token: 0x06007EC8 RID: 32456 RVA: 0x00270D98 File Offset: 0x0026EF98
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

	// Token: 0x17000E2C RID: 3628
	// (get) Token: 0x06007EC9 RID: 32457 RVA: 0x00270E54 File Offset: 0x0026F054
	public static BuildingGridModel Instance
	{
		get
		{
			return BuildingGridModel._Instance;
		}
	}

	// Token: 0x06007ECA RID: 32458 RVA: 0x00270E5B File Offset: 0x0026F05B
	public static BuildingGridModel GetOrCreateInstance()
	{
		if (BuildingGridModel._Instance == null)
		{
			BuildingGridModel.CreateInstance();
		}
		return BuildingGridModel._Instance;
	}

	// Token: 0x06007ECB RID: 32459 RVA: 0x00270E6F File Offset: 0x0026F06F
	public static bool CreateInstance()
	{
		if (BuildingGridModel._Instance != null)
		{
			return true;
		}
		BuildingGridModel._Instance = new BuildingGridModel();
		return true;
	}

	// Token: 0x06007ECC RID: 32460 RVA: 0x00270E85 File Offset: 0x0026F085
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06007ECD RID: 32461 RVA: 0x00270E87 File Offset: 0x0026F087
	public static void ResetStaticDefaultValue()
	{
		BuildingGridModel._Instance = null;
	}

	// Token: 0x06007ECE RID: 32462 RVA: 0x00270E8F File Offset: 0x0026F08F
	static BuildingGridModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BuildingGridModel.CreateStaticDefaultValue), new Action(BuildingGridModel.ResetStaticDefaultValue));
	}

	// Token: 0x04004E31 RID: 20017
	private Pool<BuildingGridCellModel> CellModelPool;

	// Token: 0x04004E32 RID: 20018
	private FKuroBuildingGridCellVector TempGridCellVector;

	// Token: 0x04004E33 RID: 20019
	private readonly Dictionary<string, Dictionary<int, BuildingGridCellModel>> GridCellModels = new Dictionary<string, Dictionary<int, BuildingGridCellModel>>();

	// Token: 0x04004E34 RID: 20020
	[Nullable(2)]
	private static BuildingGridModel _Instance;
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x02000BD4 RID: 3028
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class BuildingGridController : ControllerBase
{
	// Token: 0x06007EB7 RID: 32439 RVA: 0x002709BD File Offset: 0x0026EBBD
	protected override bool OnInit()
	{
		Net instance = Net.Instance;
		ENotifyMessageId id = ENotifyMessageId.GridCellUpdateNotify;
		Action<IMessage, Net.CallbackStatus> callback;
		if ((callback = BuildingGridController.<>O.<0>__OnGridCellUpdateNotify) == null)
		{
			callback = (BuildingGridController.<>O.<0>__OnGridCellUpdateNotify = new Action<IMessage, Net.CallbackStatus>(BuildingGridController.OnGridCellUpdateNotify));
		}
		instance.Register(id, callback);
		return true;
	}

	// Token: 0x06007EB8 RID: 32440 RVA: 0x002709EB File Offset: 0x0026EBEB
	protected override bool OnClear()
	{
		Net.Instance.UnRegister(ENotifyMessageId.GridCellUpdateNotify);
		return true;
	}

	// Token: 0x06007EB9 RID: 32441 RVA: 0x00270A00 File Offset: 0x0026EC00
	[NullableContext(2)]
	private static void OnGridCellUpdateNotify(IMessage msg, Net.CallbackStatus _)
	{
		GridCellUpdateNotify gridCellUpdateNotify = (GridCellUpdateNotify)msg;
		if (gridCellUpdateNotify != null)
		{
			BuildingGridModel.Instance.UpdateGridCell(gridCellUpdateNotify);
		}
	}

	// Token: 0x06007EBA RID: 32442 RVA: 0x00270A24 File Offset: 0x0026EC24
	private static void ForEachGridCell(global::Vector position, int radius, bool useDirMask, int dirMask, Action<string, FKuroBuildingGridCellVector, int> callback)
	{
		FKuroBuildingGridIntersectingCellDelegate fkuroBuildingGridIntersectingCellDelegate = new FKuroBuildingGridIntersectingCellDelegate();
		fkuroBuildingGridIntersectingCellDelegate.Bind(callback);
		UObject world = GlobalData.World;
		FVectorDouble fvectorDouble = position.ToUeVector(false);
		double num = (double)radius;
		UKuroBuildingGridSubsystem.K2_ForEachIntersectingCell(world, fvectorDouble, num, useDirMask, dirMask, fkuroBuildingGridIntersectingCellDelegate);
	}

	// Token: 0x06007EBB RID: 32443 RVA: 0x00270A5C File Offset: 0x0026EC5C
	public void LandFireGrids(global::Vector position, int radius, bool clearCell, Action<string, FKuroBuildingGridCellVector> callback)
	{
		BuildingGridController.ForEachGridCell(position, radius, true, 1, delegate(string gridId, FKuroBuildingGridCellVector coords, int cellIndex)
		{
			if (clearCell && BuildingGridModel.Instance.IsCellPolluted(gridId, cellIndex) > 0)
			{
				return;
			}
			callback(gridId, coords);
		});
	}

	// Token: 0x06007EBC RID: 32444 RVA: 0x00270A94 File Offset: 0x0026EC94
	public List<GridPlacementPbInfo> PolluteGrids(global::Vector position, int radius)
	{
		List<GridPlacementPbInfo> gridCells = new List<GridPlacementPbInfo>();
		BuildingGridController.ForEachGridCell(position, radius, true, 7, delegate(string gridId, FKuroBuildingGridCellVector coords, int cellIndex)
		{
			if (BuildingGridModel.Instance.IsCellPolluted(gridId, cellIndex) > 0)
			{
				return;
			}
			GridPlacementPbInfo gridPlacementPbInfo = GridPlacementPbInfo.Create();
			gridPlacementPbInfo.ActorGuid = gridId;
			gridPlacementPbInfo.X = coords.X;
			gridPlacementPbInfo.Y = coords.Y;
			gridPlacementPbInfo.Direction = GridPbDirection.GridForward;
			gridCells.Add(gridPlacementPbInfo);
		});
		return gridCells;
	}

	// Token: 0x17000E2B RID: 3627
	// (get) Token: 0x06007EBD RID: 32445 RVA: 0x00270ACD File Offset: 0x0026ECCD
	public static BuildingGridController Instance
	{
		get
		{
			return BuildingGridController._Instance;
		}
	}

	// Token: 0x06007EBE RID: 32446 RVA: 0x00270AD4 File Offset: 0x0026ECD4
	public static BuildingGridController GetOrCreateInstance()
	{
		if (BuildingGridController._Instance == null)
		{
			BuildingGridController.CreateInstance();
		}
		return BuildingGridController._Instance;
	}

	// Token: 0x06007EBF RID: 32447 RVA: 0x00270AE8 File Offset: 0x0026ECE8
	public static bool CreateInstance()
	{
		if (BuildingGridController._Instance != null)
		{
			return true;
		}
		BuildingGridController._Instance = new BuildingGridController();
		return true;
	}

	// Token: 0x06007EC0 RID: 32448 RVA: 0x00270AFE File Offset: 0x0026ECFE
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06007EC1 RID: 32449 RVA: 0x00270B00 File Offset: 0x0026ED00
	public static void ResetStaticDefaultValue()
	{
		BuildingGridController._Instance = null;
	}

	// Token: 0x06007EC2 RID: 32450 RVA: 0x00270B08 File Offset: 0x0026ED08
	static BuildingGridController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BuildingGridController.CreateStaticDefaultValue), new Action(BuildingGridController.ResetStaticDefaultValue));
	}

	// Token: 0x04004E2C RID: 20012
	[Nullable(2)]
	private static BuildingGridController _Instance;

	// Token: 0x02006EA0 RID: 28320
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x040242BE RID: 148158
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <0>__OnGridCellUpdateNotify;
	}
}

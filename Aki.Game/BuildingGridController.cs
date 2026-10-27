using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x0200171C RID: 5916
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class BuildingGridController : ControllerBase
{
	// Token: 0x0600AAD4 RID: 43732 RVA: 0x0026646D File Offset: 0x0026466D
	protected override bool OnInit()
	{
		Net.Instance.Register(ENotifyMessageId.GridCellUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnGridCellUpdateNotify));
		return true;
	}

	// Token: 0x0600AAD5 RID: 43733 RVA: 0x0026648C File Offset: 0x0026468C
	protected override bool OnClear()
	{
		Net.Instance.UnRegister(ENotifyMessageId.GridCellUpdateNotify);
		return true;
	}

	// Token: 0x0600AAD6 RID: 43734 RVA: 0x002664A0 File Offset: 0x002646A0
	[NullableContext(2)]
	private void OnGridCellUpdateNotify(IMessage msg, Net.CallbackStatus _)
	{
		GridCellUpdateNotify gridCellUpdateNotify = (GridCellUpdateNotify)msg;
		if (gridCellUpdateNotify != null)
		{
			BuildingGridModel.Instance.UpdateGridCell(gridCellUpdateNotify);
		}
	}

	// Token: 0x0600AAD7 RID: 43735 RVA: 0x002664C4 File Offset: 0x002646C4
	private void ForEachGridCell(global::Vector position, int radius, bool useDirMask, int dirMask, Action<string, FKuroBuildingGridCellVector, int> callback)
	{
		if (BuildingGridController.ForEachIntersectingCellMethod == null)
		{
			return;
		}
		ParameterInfo[] parameters = BuildingGridController.ForEachIntersectingCellMethod.GetParameters();
		if (parameters.Length == 0)
		{
			return;
		}
		ParameterInfo[] array = parameters;
		Type parameterType = array[array.Length - 1].ParameterType;
		MethodInfo method = typeof(DelegateUtils).GetMethod("ToManualReleaseDelegate");
		MethodInfo methodInfo = (method != null) ? method.MakeGenericMethod(new Type[]
		{
			parameterType
		}) : null;
		if (methodInfo == null)
		{
			return;
		}
		object obj = methodInfo.Invoke(null, new object[]
		{
			callback
		});
		try
		{
			object[] array2 = new object[]
			{
				GlobalData.World,
				position.ToUeVector(false),
				radius,
				useDirMask,
				dirMask,
				obj
			};
			BuildingGridController.CoerceArgsToParameterTypes(array2, parameters);
			BuildingGridController.ForEachIntersectingCellMethod.Invoke(null, array2);
		}
		finally
		{
			DelegateUtils.ReleaseManualReleaseDelegate(callback);
		}
	}

	// Token: 0x0600AAD8 RID: 43736 RVA: 0x002665B4 File Offset: 0x002647B4
	private static void CoerceArgsToParameterTypes([Nullable(new byte[]
	{
		1,
		2
	})] object[] args, ParameterInfo[] parameters)
	{
		int num = Math.Min(args.Length, parameters.Length);
		for (int i = 0; i < num; i++)
		{
			object obj = args[i];
			if (obj != null)
			{
				Type type = parameters[i].ParameterType;
				if (type.IsByRef)
				{
					type = type.GetElementType();
				}
				if (!(obj.GetType() == type) && obj is IConvertible && (type == typeof(double) || type == typeof(float) || type == typeof(int) || type == typeof(long)))
				{
					args[i] = Convert.ChangeType(obj, type);
				}
			}
		}
	}

	// Token: 0x0600AAD9 RID: 43737 RVA: 0x0026666C File Offset: 0x0026486C
	public void LandFireGrids(global::Vector position, int radius, bool clearCell, Action<string, FKuroBuildingGridCellVector> callback)
	{
		this.ForEachGridCell(position, radius, true, 1, delegate(string gridId, FKuroBuildingGridCellVector coords, int cellIndex)
		{
			if (clearCell && BuildingGridModel.Instance.IsCellPolluted(gridId, cellIndex) > 0)
			{
				return;
			}
			callback(gridId, coords);
		});
	}

	// Token: 0x0600AADA RID: 43738 RVA: 0x002666A4 File Offset: 0x002648A4
	public List<GridPlacementPbInfo> PolluteGrids(global::Vector position, int radius)
	{
		List<GridPlacementPbInfo> gridCells = new List<GridPlacementPbInfo>();
		this.ForEachGridCell(position, radius, true, 7, delegate(string gridId, FKuroBuildingGridCellVector coords, int cellIndex)
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

	// Token: 0x17000E0A RID: 3594
	// (get) Token: 0x0600AADB RID: 43739 RVA: 0x002666DE File Offset: 0x002648DE
	public static BuildingGridController Instance
	{
		get
		{
			return BuildingGridController._Instance;
		}
	}

	// Token: 0x0600AADC RID: 43740 RVA: 0x002666E5 File Offset: 0x002648E5
	public static BuildingGridController GetOrCreateInstance()
	{
		if (BuildingGridController._Instance == null)
		{
			BuildingGridController.CreateInstance();
		}
		return BuildingGridController._Instance;
	}

	// Token: 0x0600AADD RID: 43741 RVA: 0x002666F9 File Offset: 0x002648F9
	public static bool CreateInstance()
	{
		if (BuildingGridController._Instance != null)
		{
			return true;
		}
		BuildingGridController._Instance = new BuildingGridController();
		return true;
	}

	// Token: 0x0600AADE RID: 43742 RVA: 0x0026670F File Offset: 0x0026490F
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600AADF RID: 43743 RVA: 0x00266711 File Offset: 0x00264911
	public static void ResetStaticDefaultValue()
	{
		BuildingGridController._Instance = null;
	}

	// Token: 0x0600AAE0 RID: 43744 RVA: 0x00266719 File Offset: 0x00264919
	static BuildingGridController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BuildingGridController.CreateStaticDefaultValue), new Action(BuildingGridController.ResetStaticDefaultValue));
	}

	// Token: 0x04004D84 RID: 19844
	[Nullable(2)]
	[StaticVariableRuleIgnore]
	private static readonly MethodInfo ForEachIntersectingCellMethod = typeof(UKuroBuildingGridSubsystem).GetMethod("K2_ForEachIntersectingCell");

	// Token: 0x04004D85 RID: 19845
	[Nullable(2)]
	private static BuildingGridController _Instance;
}

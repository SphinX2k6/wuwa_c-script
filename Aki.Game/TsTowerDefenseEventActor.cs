using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.TowerDefenseEvent;
using CSharpScript.Game.Module.TowerDefenseEvent.Model;
using CSharpScript.Game.Module.TrapDefense;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002BC4 RID: 11204
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Module/TowerDefenseEvent/Item/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/TowerDefenseEvent/Item/TsTowerDefenseEventActor.TsTowerDefenseEventActor_C")]
public class TsTowerDefenseEventActor : AKuroGridLevelActor, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601744B RID: 95307 RVA: 0x005E8B77 File Offset: 0x005E6D77
	static TsTowerDefenseEventActor()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsTowerDefenseEventActor.CreateStaticDefaultValue), new Action(TsTowerDefenseEventActor.ResetStaticDefaultValue));
	}

	// Token: 0x0601744C RID: 95308 RVA: 0x005E8B98 File Offset: 0x005E6D98
	public static void CreateStaticDefaultValue()
	{
		TsTowerDefenseEventActor.UpdateBuildStateStat = Stat.Create("TsTowerDefenseEventActor.UpdateBuildState", "", "");
		TsTowerDefenseEventActor.NormalLayer = FNameUtil.GetCheckDynamicFName("NormalLayer");
		TsTowerDefenseEventActor.Preview = FNameUtil.GetCheckDynamicFName("Preview");
		TsTowerDefenseEventActor.Idle = FNameUtil.GetCheckDynamicFName("Idle");
		TsTowerDefenseEventActor.Hidden = FNameUtil.GetCheckDynamicFName("Hidden");
		TsTowerDefenseEventActor.MaterialLayer = FNameUtil.GetCheckDynamicFName("MaterialLayer");
		TsTowerDefenseEventActor.Normal = FNameUtil.GetCheckDynamicFName("Normal");
		TsTowerDefenseEventActor.HaveMoney = FNameUtil.GetCheckDynamicFName("HaveMoney");
		TsTowerDefenseEventActor.NoMoney = FNameUtil.GetCheckDynamicFName("NoMoney");
		TsTowerDefenseEventActor.PreviewRemove = FNameUtil.GetCheckDynamicFName("PreviewRemove");
		TsTowerDefenseEventActor.RangeLayer = FNameUtil.GetCheckDynamicFName("RangeLayer");
		TsTowerDefenseEventActor.Attack = FNameUtil.GetCheckDynamicFName("Attack");
		TsTowerDefenseEventActor.HaveMoneyRange = FNameUtil.GetCheckDynamicFName("HaveMoneyRange");
		TsTowerDefenseEventActor.NoMoneyRange = FNameUtil.GetCheckDynamicFName("NoMoneyRange");
		TsTowerDefenseEventActor.GridSizeTemp = Vector2D.Create(0.0, 0.0);
		TsTowerDefenseEventActor.AllTrapActors = new Dictionary<int, TsTowerDefenseEventActor>();
	}

	// Token: 0x0601744D RID: 95309 RVA: 0x005E8CA8 File Offset: 0x005E6EA8
	public static void ResetStaticDefaultValue()
	{
		TsTowerDefenseEventActor.UpdateBuildStateStat = null;
		TsTowerDefenseEventActor.NormalLayer = null;
		TsTowerDefenseEventActor.Preview = null;
		TsTowerDefenseEventActor.Idle = null;
		TsTowerDefenseEventActor.Hidden = null;
		TsTowerDefenseEventActor.MaterialLayer = null;
		TsTowerDefenseEventActor.Normal = null;
		TsTowerDefenseEventActor.HaveMoney = null;
		TsTowerDefenseEventActor.NoMoney = null;
		TsTowerDefenseEventActor.PreviewRemove = null;
		TsTowerDefenseEventActor.RangeLayer = null;
		TsTowerDefenseEventActor.Attack = null;
		TsTowerDefenseEventActor.HaveMoneyRange = null;
		TsTowerDefenseEventActor.NoMoneyRange = null;
		TsTowerDefenseEventActor.GridSizeTemp = null;
		TsTowerDefenseEventActor.AllTrapActors = null;
	}

	// Token: 0x17001F63 RID: 8035
	// (get) Token: 0x0601744E RID: 95310 RVA: 0x005E8D56 File Offset: 0x005E6F56
	public bool IsVisible
	{
		get
		{
			return this.IsVisibleInternal;
		}
	}

	// Token: 0x0601744F RID: 95311 RVA: 0x005E8D5E File Offset: 0x005E6F5E
	[NullableContext(2)]
	public ITowerDefenseEventTrapBaseInfo GetTapModel()
	{
		return this.TrapData;
	}

	// Token: 0x06017450 RID: 95312 RVA: 0x005E8D68 File Offset: 0x005E6F68
	[NullableContext(2)]
	public string Init([Nullable(1)] ITowerDefenseEventTrapBaseInfo trapModel, AKuroBuildingGrid grid = null)
	{
		this.TrapData = trapModel;
		this.UpdateGridLevel();
		ITowerDefenseEventTrapInfo towerDefenseEventTrapInfo = trapModel as ITowerDefenseEventTrapInfo;
		AKuroBuildingGrid akuroBuildingGrid = base.OccupiedGrid.Get();
		bool flag = akuroBuildingGrid != null && akuroBuildingGrid.IsValid();
		if (flag && (!trapModel.IsValid() || !this.TrapSize.Equals(trapModel.GridSize, 9.999999747378752E-05) || base.OccupiedGrid.Get() != grid || (towerDefenseEventTrapInfo != null && !this.Coords.Equals(towerDefenseEventTrapInfo.Coords, 9.999999747378752E-05))))
		{
			AKuroBuildingGrid akuroBuildingGrid2 = base.OccupiedGrid.Get();
			if (akuroBuildingGrid2 != null)
			{
				akuroBuildingGrid2.UnoccupyTarget(this);
			}
			flag = false;
		}
		if (!trapModel.IsValid())
		{
			this.Hide();
		}
		else
		{
			if (!flag && grid != null && towerDefenseEventTrapInfo != null)
			{
				TsTowerDefenseEventActor.BuildingGridCellVectorTemp.X = (int)towerDefenseEventTrapInfo.Coords.X;
				TsTowerDefenseEventActor.BuildingGridCellVectorTemp.Y = (int)towerDefenseEventTrapInfo.Coords.Y;
				float num = (float)trapModel.Degree;
				if (!grid.OccupyTarget(TsTowerDefenseEventActor.BuildingGridCellVectorTemp, this, num))
				{
					return "占用格子失败";
				}
				this.Coords.Set(towerDefenseEventTrapInfo.Coords.X, towerDefenseEventTrapInfo.Coords.Y);
			}
			this.Built();
			TsTowerDefenseEventActor.AllTrapActors[(int)trapModel.Uid] = this;
		}
		return null;
	}

	// Token: 0x06017451 RID: 95313 RVA: 0x005E8EB8 File Offset: 0x005E70B8
	public void Destroy(string reason)
	{
		AKuroBuildingGrid akuroBuildingGrid = base.OccupiedGrid.Get();
		if (akuroBuildingGrid != null && akuroBuildingGrid.IsValid())
		{
			base.OccupiedGrid.Get().UnoccupyTarget(this);
		}
		ITowerDefenseEventTrapBaseInfo trapData = this.TrapData;
		if (trapData != null && trapData.IsValid())
		{
			TsTowerDefenseEventActor.AllTrapActors.Remove((int)this.TrapData.Uid);
		}
		this.TrapData = null;
		this.UpdateGridLevel();
		this.Coords.Set(0.0, 0.0);
		ActorSystem instance = ActorSystem.Instance;
		TClearFunction clearFunc;
		if ((clearFunc = TsTowerDefenseEventActor.<>O.<0>__ClearPooledActor) == null)
		{
			clearFunc = (TsTowerDefenseEventActor.<>O.<0>__ClearPooledActor = new TClearFunction(TsTowerDefenseEventActor.ClearPooledActor));
		}
		instance.Put(reason, this, clearFunc);
	}

	// Token: 0x06017452 RID: 95314 RVA: 0x005E8F74 File Offset: 0x005E7174
	private static void ClearPooledActor(AActor actor)
	{
		UKuroActorManager.ClearAcquiredComponents(actor);
		UKuroActorManager.ResetDelegates(actor);
		actor.K2_DetachFromActor(EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative);
		actor.SetActorHiddenInGame(true);
		TArray<UActorComponent> tarray = actor.K2_GetComponentsByClass(UActorComponent.StaticClass());
		int num = tarray.Num();
		for (int i = 0; i < num; i++)
		{
			if (!tarray.Get(i).IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Log;
				ELogAuthor author = ELogAuthor.FJH;
				string message = "ActorPoolGuard.CleanActorBeforeEnPool: component is invalid";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("actor", actor.GetName());
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			else
			{
				UKuroActorManager.UnregisterComponent(tarray.Get(i));
			}
		}
		actor.SetActorTickEnabled(false);
		actor.SetActorEnableCollision(false);
	}

	// Token: 0x06017453 RID: 95315 RVA: 0x005E9018 File Offset: 0x005E7218
	private void UpdateGridLevel()
	{
		string text = "";
		float num = 0f;
		float num2 = 0f;
		if (this.TrapData != null)
		{
			text = (this.TrapData.PrefabPath ?? "");
			num = (float)((int)this.TrapData.GridSize.X);
			num2 = (float)((int)this.TrapData.GridSize.Y);
		}
		if (this.PrefabPath == text && this.TrapSize.X == (double)num && this.TrapSize.Y == (double)num2)
		{
			return;
		}
		this.PrefabPath = text;
		this.TrapSize.Set((double)num, (double)num2);
		TsTowerDefenseEventActor.BuildingGridCellVectorTemp.X = (int)num;
		TsTowerDefenseEventActor.BuildingGridCellVectorTemp.Y = (int)num2;
		FSoftObjectPath fsoftObjectPath = UKismetSystemLibrary.MakeSoftObjectPath(text);
		TSoftObjectPtr<UObject> tsoftObjectPtr = UKismetSystemLibrary.Conv_SoftObjPathToSoftObjRef(fsoftObjectPath);
		base.Initialize(tsoftObjectPtr.As<UWorld>(), TsTowerDefenseEventActor.BuildingGridCellVectorTemp);
	}

	// Token: 0x06017454 RID: 95316 RVA: 0x005E90F8 File Offset: 0x005E72F8
	public ETowerDefenseEventBuildState UpdateBuildState(AKuroBuildingGrid grid, Vector2D coords, float degree, Vector location, Rotator rotation, OutPollutedNum outPollutedNum)
	{
		this.UpdateBuildPosition(location, rotation);
		ETowerDefenseEventBuildState etowerDefenseEventBuildState = ETowerDefenseEventBuildState.Invalid;
		if (TowerDefenseEventModel.Instance.ValidateBuildTrap(this.TrapData))
		{
			int pollutedCellNum = this.GetPollutedCellNum(grid, coords, degree);
			outPollutedNum.PollutedNum = pollutedCellNum;
			if (pollutedCellNum > 0)
			{
				etowerDefenseEventBuildState = ETowerDefenseEventBuildState.Polluted;
				if (TrapDefenseModel.Instance.BattleData.GetCurrentPurificationItemCount() >= pollutedCellNum)
				{
					etowerDefenseEventBuildState |= ETowerDefenseEventBuildState.Valid;
				}
			}
			else
			{
				etowerDefenseEventBuildState = ETowerDefenseEventBuildState.Valid;
			}
		}
		bool flag = (etowerDefenseEventBuildState & ETowerDefenseEventBuildState.Valid) == ETowerDefenseEventBuildState.Valid;
		FName materialState = flag ? TsTowerDefenseEventActor.HaveMoney : TsTowerDefenseEventActor.NoMoney;
		this.SetMaterialState(materialState);
		this.SetNormalState(TsTowerDefenseEventActor.Preview);
		FName rangeState = flag ? TsTowerDefenseEventActor.HaveMoneyRange : TsTowerDefenseEventActor.NoMoneyRange;
		this.SetRangeState(rangeState);
		return etowerDefenseEventBuildState;
	}

	// Token: 0x06017455 RID: 95317 RVA: 0x005E9194 File Offset: 0x005E7394
	private void UpdateBuildPosition(Vector location, Rotator rotation)
	{
		if (this.TrapData == null)
		{
			return;
		}
		bool flag = false;
		bool flag2 = false;
		if (this.IsVisibleInternal)
		{
			flag = !this.TrapData.Position.Equals(location, 9.999999747378752E-05);
			flag2 = !this.TrapData.Rotation.Equals(rotation, 0.0001f);
			if (!flag && !flag2)
			{
				return;
			}
		}
		if (!this.IsVisibleInternal)
		{
			base.D_K2_SetActorLocationAndRotation(location.ToUeVector(false), rotation.ToUeRotator(), false, ref WorldGlobal.SweepHitResult, false);
			return;
		}
		if (flag)
		{
			ULTweener positionTweener = this.PositionTweener;
			if (positionTweener != null)
			{
				positionTweener.Kill(false);
			}
			Vector commonTempVector = MathUtils.Instance.CommonTempVector;
			WorldController.Instance.ToWorldRelativeLocation(location, commonTempVector);
			this.PositionTweener = ULTweenBPLibrary.WorldPositionTo(base.RootComponent, commonTempVector.ToUeVectorOld(), 0.1f, 0f, LTweenEase.OutCubic);
		}
		if (flag2)
		{
			ULTweener rotationTweener = this.RotationTweener;
			if (rotationTweener != null)
			{
				rotationTweener.Kill(false);
			}
			this.RotationTweener = ULTweenBPLibrary.WorldRotatorTo(base.RootComponent, rotation.ToUeRotator(), true, 0.1f, 0f, LTweenEase.OutCubic);
		}
	}

	// Token: 0x06017456 RID: 95318 RVA: 0x005E92A0 File Offset: 0x005E74A0
	private int GetPollutedCellNum(AKuroBuildingGrid grid, Vector2D coords, float degree)
	{
		string buildingGridGuidString = grid.GetBuildingGridGuidString();
		Vector2D gridSizeTemp = TsTowerDefenseEventActor.GridSizeTemp;
		this.UpdateSizeByDegree(gridSizeTemp, degree);
		FKuroBuildingGridCellVector buildingGridCellVectorTemp = TsTowerDefenseEventActor.BuildingGridCellVectorTemp;
		HashSet<int> hashSet = new HashSet<int>();
		int num = (int)gridSizeTemp.Y;
		int num2 = (int)gridSizeTemp.X;
		for (int i = 0; i < num; i++)
		{
			for (int j = 0; j < num2; j++)
			{
				buildingGridCellVectorTemp.X = (int)coords.X + j;
				buildingGridCellVectorTemp.Y = (int)coords.Y + i;
				int index = 0;
				if (grid.GetCellIndex(buildingGridCellVectorTemp, ref index))
				{
					int num3 = BuildingGridModel.Instance.IsCellPolluted(buildingGridGuidString, index);
					if (num3 > 0)
					{
						hashSet.Add(num3);
					}
				}
			}
		}
		return hashSet.Count;
	}

	// Token: 0x06017457 RID: 95319 RVA: 0x005E9358 File Offset: 0x005E7558
	private void UpdateSizeByDegree(Vector2D outGridSize, float degree)
	{
		Vector2D gridSize = this.TrapData.GridSize;
		if ((degree > 45f && degree < 135f) || (degree > -135f && degree < -45f))
		{
			outGridSize.X = gridSize.Y;
			outGridSize.Y = gridSize.X;
			return;
		}
		outGridSize.X = gridSize.X;
		outGridSize.Y = gridSize.Y;
	}

	// Token: 0x06017458 RID: 95320 RVA: 0x005E93C2 File Offset: 0x005E75C2
	public void PrepareRemove()
	{
		this.IsPreRemove = true;
		if (base.IsLevelShown())
		{
			this.SetMaterialState(TsTowerDefenseEventActor.PreviewRemove);
		}
	}

	// Token: 0x06017459 RID: 95321 RVA: 0x005E93E0 File Offset: 0x005E75E0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void OnLevelShown()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnLevelShown"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601745A RID: 95322 RVA: 0x005E9450 File Offset: 0x005E7650
	protected override void OnLevelShown_Implementation()
	{
		base.OnLevelShown_Implementation();
		if (this.IsPreRemove)
		{
			this.PrepareRemove();
		}
	}

	// Token: 0x0601745B RID: 95323 RVA: 0x005E9466 File Offset: 0x005E7666
	public void ResetRemove()
	{
		this.IsPreRemove = false;
		this.SetMaterialState(TsTowerDefenseEventActor.Normal);
	}

	// Token: 0x0601745C RID: 95324 RVA: 0x005E947A File Offset: 0x005E767A
	public void Hide()
	{
		this.SetRangeState(TsTowerDefenseEventActor.Attack);
		this.SetMaterialState(TsTowerDefenseEventActor.Normal);
		this.SetNormalState(TsTowerDefenseEventActor.Hidden);
	}

	// Token: 0x0601745D RID: 95325 RVA: 0x005E949D File Offset: 0x005E769D
	private void Built()
	{
		this.SetMaterialState(TsTowerDefenseEventActor.Normal);
		this.SetNormalState(TsTowerDefenseEventActor.Idle);
		this.UpdateRangeState();
	}

	// Token: 0x0601745E RID: 95326 RVA: 0x005E94BC File Offset: 0x005E76BC
	private void SetNormalState(FName state)
	{
		this.CurrentLayerStates[TsTowerDefenseEventActor.NormalLayer] = state;
		base.SetLayerState(TsTowerDefenseEventActor.NormalLayer, state, 1f);
		this.IsVisibleInternal = (state != TsTowerDefenseEventActor.Hidden);
		if (!this.IsVisibleInternal)
		{
			ULTweener positionTweener = this.PositionTweener;
			if (positionTweener != null)
			{
				positionTweener.Kill(false);
			}
			this.PositionTweener = null;
			ULTweener rotationTweener = this.RotationTweener;
			if (rotationTweener != null)
			{
				rotationTweener.Kill(false);
			}
			this.RotationTweener = null;
		}
	}

	// Token: 0x0601745F RID: 95327 RVA: 0x005E9538 File Offset: 0x005E7738
	private void SetMaterialState(FName state)
	{
		if (this.CurrentLayerStates.ContainsKey(TsTowerDefenseEventActor.MaterialLayer) && this.CurrentLayerStates[TsTowerDefenseEventActor.MaterialLayer] == state)
		{
			return;
		}
		this.CurrentLayerStates[TsTowerDefenseEventActor.MaterialLayer] = state;
		base.SetLayerState(TsTowerDefenseEventActor.MaterialLayer, state, 1f);
	}

	// Token: 0x06017460 RID: 95328 RVA: 0x005E9594 File Offset: 0x005E7794
	private void UpdateRangeState()
	{
		ITowerDefenseEventTrapBaseInfo trapData = this.TrapData;
		if (trapData == null || !trapData.IsValid())
		{
			return;
		}
		FName rangeState = TowerDefenseEventController.Instance.IsFighting() ? TsTowerDefenseEventActor.Attack : TsTowerDefenseEventActor.HaveMoneyRange;
		this.SetRangeState(rangeState);
	}

	// Token: 0x06017461 RID: 95329 RVA: 0x005E95DC File Offset: 0x005E77DC
	private void SetRangeState(FName state)
	{
		if (this.CurrentLayerStates.ContainsKey(TsTowerDefenseEventActor.RangeLayer) && this.CurrentLayerStates[TsTowerDefenseEventActor.RangeLayer] == state)
		{
			return;
		}
		this.CurrentLayerStates[TsTowerDefenseEventActor.RangeLayer] = state;
		base.SetLayerState(TsTowerDefenseEventActor.RangeLayer, state, 1f);
	}

	// Token: 0x06017462 RID: 95330 RVA: 0x005E9638 File Offset: 0x005E7838
	[NullableContext(2)]
	public static TsTowerDefenseEventActor GetTrapActor(int uid)
	{
		TsTowerDefenseEventActor result;
		if (!TsTowerDefenseEventActor.AllTrapActors.TryGetValue(uid, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x06017463 RID: 95331 RVA: 0x005E9658 File Offset: 0x005E7858
	public static void UpdateTrapRangeState()
	{
		foreach (TsTowerDefenseEventActor tsTowerDefenseEventActor in TsTowerDefenseEventActor.AllTrapActors.Values)
		{
			tsTowerDefenseEventActor.UpdateRangeState();
		}
	}

	// Token: 0x06017464 RID: 95332 RVA: 0x005E96AC File Offset: 0x005E78AC
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTowerDefenseEventActor._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/TowerDefenseEvent/Item/TsTowerDefenseEventActor.TsTowerDefenseEventActor_C");
		}
		return TsTowerDefenseEventActor._ClassPtr;
	}

	// Token: 0x06017465 RID: 95333 RVA: 0x005E96D0 File Offset: 0x005E78D0
	public TsTowerDefenseEventActor() : this(BuiltinUtils.AllocNativeUObject(TsTowerDefenseEventActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06017466 RID: 95334 RVA: 0x005E96F8 File Offset: 0x005E78F8
	public TsTowerDefenseEventActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTowerDefenseEventActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06017467 RID: 95335 RVA: 0x005E972C File Offset: 0x005E792C
	protected TsTowerDefenseEventActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06017468 RID: 95336 RVA: 0x005E9790 File Offset: 0x005E7990
	protected virtual void __CPPCALL_OnLevelShown_Implementation()
	{
		this.OnLevelShown_Implementation();
	}

	// Token: 0x0400ADFD RID: 44541
	private static Stat UpdateBuildStateStat;

	// Token: 0x0400ADFE RID: 44542
	private static FName NormalLayer;

	// Token: 0x0400ADFF RID: 44543
	private static FName Preview;

	// Token: 0x0400AE00 RID: 44544
	private static FName Idle;

	// Token: 0x0400AE01 RID: 44545
	private static FName Hidden;

	// Token: 0x0400AE02 RID: 44546
	private static FName MaterialLayer;

	// Token: 0x0400AE03 RID: 44547
	private static FName Normal;

	// Token: 0x0400AE04 RID: 44548
	private static FName HaveMoney;

	// Token: 0x0400AE05 RID: 44549
	private static FName NoMoney;

	// Token: 0x0400AE06 RID: 44550
	private static FName PreviewRemove;

	// Token: 0x0400AE07 RID: 44551
	private static FName RangeLayer;

	// Token: 0x0400AE08 RID: 44552
	private static FName Attack;

	// Token: 0x0400AE09 RID: 44553
	private static FName HaveMoneyRange;

	// Token: 0x0400AE0A RID: 44554
	private static FName NoMoneyRange;

	// Token: 0x0400AE0B RID: 44555
	[StaticVariableRuleIgnore]
	private static FKuroBuildingGridCellVector BuildingGridCellVectorTemp;

	// Token: 0x0400AE0C RID: 44556
	private static Vector2D GridSizeTemp;

	// Token: 0x0400AE0D RID: 44557
	private static Dictionary<int, TsTowerDefenseEventActor> AllTrapActors;

	// Token: 0x0400AE0E RID: 44558
	[Nullable(2)]
	private ITowerDefenseEventTrapBaseInfo TrapData;

	// Token: 0x0400AE0F RID: 44559
	private string PrefabPath = "";

	// Token: 0x0400AE10 RID: 44560
	private readonly Vector2D TrapSize = Vector2D.Create(0.0, 0.0);

	// Token: 0x0400AE11 RID: 44561
	private readonly Vector2D Coords = Vector2D.Create(0.0, 0.0);

	// Token: 0x0400AE12 RID: 44562
	private readonly Dictionary<FName, FName> CurrentLayerStates = new Dictionary<FName, FName>();

	// Token: 0x0400AE13 RID: 44563
	private bool IsVisibleInternal;

	// Token: 0x0400AE14 RID: 44564
	private bool IsPreRemove;

	// Token: 0x0400AE15 RID: 44565
	[Nullable(2)]
	private ULTweener PositionTweener;

	// Token: 0x0400AE16 RID: 44566
	[Nullable(2)]
	private ULTweener RotationTweener;

	// Token: 0x0400AE17 RID: 44567
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/TowerDefenseEvent/Item/TsTowerDefenseEventActor.TsTowerDefenseEventActor_C";

	// Token: 0x0400AE18 RID: 44568
	private static IntPtr _ClassPtr;

	// Token: 0x0400AE19 RID: 44569
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x02009183 RID: 37251
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402F180 RID: 192896
		[Nullable(0)]
		public static TClearFunction <0>__ClearPooledActor;
	}
}

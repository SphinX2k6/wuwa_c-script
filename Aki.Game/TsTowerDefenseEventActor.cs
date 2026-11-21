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

// Token: 0x0200213F RID: 8511
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Module/TowerDefenseEvent/Item/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/TowerDefenseEvent/Item/TsTowerDefenseEventActor.TsTowerDefenseEventActor_C")]
public class TsTowerDefenseEventActor : AKuroGridLevelActor, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x06014E7C RID: 85628 RVA: 0x00615727 File Offset: 0x00613927
	static TsTowerDefenseEventActor()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsTowerDefenseEventActor.CreateStaticDefaultValue), new Action(TsTowerDefenseEventActor.ResetStaticDefaultValue));
	}

	// Token: 0x06014E7D RID: 85629 RVA: 0x00615748 File Offset: 0x00613948
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

	// Token: 0x06014E7E RID: 85630 RVA: 0x00615858 File Offset: 0x00613A58
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

	// Token: 0x17001FBB RID: 8123
	// (get) Token: 0x06014E7F RID: 85631 RVA: 0x00615906 File Offset: 0x00613B06
	public bool IsVisible
	{
		get
		{
			return this.IsVisibleInternal;
		}
	}

	// Token: 0x06014E80 RID: 85632 RVA: 0x0061590E File Offset: 0x00613B0E
	[NullableContext(2)]
	public ITowerDefenseEventTrapBaseInfo GetTapModel()
	{
		return this.TrapData;
	}

	// Token: 0x06014E81 RID: 85633 RVA: 0x00615918 File Offset: 0x00613B18
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

	// Token: 0x06014E82 RID: 85634 RVA: 0x00615A68 File Offset: 0x00613C68
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

	// Token: 0x06014E83 RID: 85635 RVA: 0x00615B24 File Offset: 0x00613D24
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

	// Token: 0x06014E84 RID: 85636 RVA: 0x00615BC8 File Offset: 0x00613DC8
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

	// Token: 0x06014E85 RID: 85637 RVA: 0x00615CA8 File Offset: 0x00613EA8
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

	// Token: 0x06014E86 RID: 85638 RVA: 0x00615D44 File Offset: 0x00613F44
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

	// Token: 0x06014E87 RID: 85639 RVA: 0x00615E50 File Offset: 0x00614050
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

	// Token: 0x06014E88 RID: 85640 RVA: 0x00615F08 File Offset: 0x00614108
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

	// Token: 0x06014E89 RID: 85641 RVA: 0x00615F72 File Offset: 0x00614172
	public void PrepareRemove()
	{
		this.IsPreRemove = true;
		if (base.IsLevelShown())
		{
			this.SetMaterialState(TsTowerDefenseEventActor.PreviewRemove);
		}
	}

	// Token: 0x06014E8A RID: 85642 RVA: 0x00615F90 File Offset: 0x00614190
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void OnLevelShown()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsTowerDefenseEventActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnLevelShown"), TsTowerDefenseEventActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.OnLevelShown_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06014E8B RID: 85643 RVA: 0x00615FE9 File Offset: 0x006141E9
	protected override void OnLevelShown_Implementation()
	{
		base.OnLevelShown_Implementation();
		if (this.IsPreRemove)
		{
			this.PrepareRemove();
		}
	}

	// Token: 0x06014E8C RID: 85644 RVA: 0x00615FFF File Offset: 0x006141FF
	public void ResetRemove()
	{
		this.IsPreRemove = false;
		this.SetMaterialState(TsTowerDefenseEventActor.Normal);
	}

	// Token: 0x06014E8D RID: 85645 RVA: 0x00616013 File Offset: 0x00614213
	public void Hide()
	{
		this.SetRangeState(TsTowerDefenseEventActor.Attack);
		this.SetMaterialState(TsTowerDefenseEventActor.Normal);
		this.SetNormalState(TsTowerDefenseEventActor.Hidden);
	}

	// Token: 0x06014E8E RID: 85646 RVA: 0x00616036 File Offset: 0x00614236
	private void Built()
	{
		this.SetMaterialState(TsTowerDefenseEventActor.Normal);
		this.SetNormalState(TsTowerDefenseEventActor.Idle);
		this.UpdateRangeState();
	}

	// Token: 0x06014E8F RID: 85647 RVA: 0x00616054 File Offset: 0x00614254
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

	// Token: 0x06014E90 RID: 85648 RVA: 0x006160D0 File Offset: 0x006142D0
	private void SetMaterialState(FName state)
	{
		if (this.CurrentLayerStates.ContainsKey(TsTowerDefenseEventActor.MaterialLayer) && this.CurrentLayerStates[TsTowerDefenseEventActor.MaterialLayer] == state)
		{
			return;
		}
		this.CurrentLayerStates[TsTowerDefenseEventActor.MaterialLayer] = state;
		base.SetLayerState(TsTowerDefenseEventActor.MaterialLayer, state, 1f);
	}

	// Token: 0x06014E91 RID: 85649 RVA: 0x0061612C File Offset: 0x0061432C
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

	// Token: 0x06014E92 RID: 85650 RVA: 0x00616174 File Offset: 0x00614374
	private void SetRangeState(FName state)
	{
		if (this.CurrentLayerStates.ContainsKey(TsTowerDefenseEventActor.RangeLayer) && this.CurrentLayerStates[TsTowerDefenseEventActor.RangeLayer] == state)
		{
			return;
		}
		this.CurrentLayerStates[TsTowerDefenseEventActor.RangeLayer] = state;
		base.SetLayerState(TsTowerDefenseEventActor.RangeLayer, state, 1f);
	}

	// Token: 0x06014E93 RID: 85651 RVA: 0x006161D0 File Offset: 0x006143D0
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

	// Token: 0x06014E94 RID: 85652 RVA: 0x006161F0 File Offset: 0x006143F0
	public static void UpdateTrapRangeState()
	{
		foreach (TsTowerDefenseEventActor tsTowerDefenseEventActor in TsTowerDefenseEventActor.AllTrapActors.Values)
		{
			tsTowerDefenseEventActor.UpdateRangeState();
		}
	}

	// Token: 0x06014E95 RID: 85653 RVA: 0x00616244 File Offset: 0x00614444
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTowerDefenseEventActor._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/TowerDefenseEvent/Item/TsTowerDefenseEventActor.TsTowerDefenseEventActor_C");
		}
		return TsTowerDefenseEventActor._ClassPtr;
	}

	// Token: 0x06014E96 RID: 85654 RVA: 0x00616268 File Offset: 0x00614468
	public TsTowerDefenseEventActor() : this(BuiltinUtils.AllocNativeUObject(TsTowerDefenseEventActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06014E97 RID: 85655 RVA: 0x00616290 File Offset: 0x00614490
	public TsTowerDefenseEventActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTowerDefenseEventActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06014E98 RID: 85656 RVA: 0x006162C4 File Offset: 0x006144C4
	protected TsTowerDefenseEventActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06014E99 RID: 85657 RVA: 0x00616328 File Offset: 0x00614528
	protected virtual void __CPPCALL_OnLevelShown_Implementation()
	{
		this.OnLevelShown_Implementation();
	}

	// Token: 0x0400B202 RID: 45570
	private static Stat UpdateBuildStateStat;

	// Token: 0x0400B203 RID: 45571
	private static FName NormalLayer;

	// Token: 0x0400B204 RID: 45572
	private static FName Preview;

	// Token: 0x0400B205 RID: 45573
	private static FName Idle;

	// Token: 0x0400B206 RID: 45574
	private static FName Hidden;

	// Token: 0x0400B207 RID: 45575
	private static FName MaterialLayer;

	// Token: 0x0400B208 RID: 45576
	private static FName Normal;

	// Token: 0x0400B209 RID: 45577
	private static FName HaveMoney;

	// Token: 0x0400B20A RID: 45578
	private static FName NoMoney;

	// Token: 0x0400B20B RID: 45579
	private static FName PreviewRemove;

	// Token: 0x0400B20C RID: 45580
	private static FName RangeLayer;

	// Token: 0x0400B20D RID: 45581
	private static FName Attack;

	// Token: 0x0400B20E RID: 45582
	private static FName HaveMoneyRange;

	// Token: 0x0400B20F RID: 45583
	private static FName NoMoneyRange;

	// Token: 0x0400B210 RID: 45584
	[StaticVariableRuleIgnore]
	private static FKuroBuildingGridCellVector BuildingGridCellVectorTemp;

	// Token: 0x0400B211 RID: 45585
	private static Vector2D GridSizeTemp;

	// Token: 0x0400B212 RID: 45586
	private static Dictionary<int, TsTowerDefenseEventActor> AllTrapActors;

	// Token: 0x0400B213 RID: 45587
	[Nullable(2)]
	private ITowerDefenseEventTrapBaseInfo TrapData;

	// Token: 0x0400B214 RID: 45588
	private string PrefabPath = "";

	// Token: 0x0400B215 RID: 45589
	private readonly Vector2D TrapSize = Vector2D.Create(0.0, 0.0);

	// Token: 0x0400B216 RID: 45590
	private readonly Vector2D Coords = Vector2D.Create(0.0, 0.0);

	// Token: 0x0400B217 RID: 45591
	private readonly Dictionary<FName, FName> CurrentLayerStates = new Dictionary<FName, FName>();

	// Token: 0x0400B218 RID: 45592
	private bool IsVisibleInternal;

	// Token: 0x0400B219 RID: 45593
	private bool IsPreRemove;

	// Token: 0x0400B21A RID: 45594
	[Nullable(2)]
	private ULTweener PositionTweener;

	// Token: 0x0400B21B RID: 45595
	[Nullable(2)]
	private ULTweener RotationTweener;

	// Token: 0x0400B21C RID: 45596
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/TowerDefenseEvent/Item/TsTowerDefenseEventActor.TsTowerDefenseEventActor_C";

	// Token: 0x0400B21D RID: 45597
	private static IntPtr _ClassPtr;

	// Token: 0x0400B21E RID: 45598
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x020083C7 RID: 33735
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402A886 RID: 174214
		[Nullable(0)]
		public static TClearFunction <0>__ClearPooledActor;
	}
}

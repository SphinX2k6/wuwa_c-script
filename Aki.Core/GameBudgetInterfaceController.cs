using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.GameBudgetAllocator;
using CSharpScript.Typing;
using UnrealEngine;

// Token: 0x020000AD RID: 173
[NullableContext(1)]
[Nullable(0)]
public class GameBudgetInterfaceController : Singleton
{
	// Token: 0x170000C7 RID: 199
	// (get) Token: 0x06000552 RID: 1362 RVA: 0x0001BDDA File Offset: 0x00019FDA
	[Nullable(2)]
	public AActor CenterRole
	{
		[NullableContext(2)]
		get
		{
			return this.CenterRoleInternal;
		}
	}

	// Token: 0x170000C8 RID: 200
	// (get) Token: 0x06000553 RID: 1363 RVA: 0x0001BDE2 File Offset: 0x00019FE2
	public EGameBudgetAllocatorGlobalMode CurrentGlobalMode
	{
		get
		{
			return this.CurrentGlobalModeInternal;
		}
	}

	// Token: 0x06000554 RID: 1364 RVA: 0x0001BDEC File Offset: 0x00019FEC
	protected override bool OnInit()
	{
		Action<Action<bool>> subscribeBattleStateChangedHook = GameBudgetInterfaceController.SubscribeBattleStateChangedHook;
		if (subscribeBattleStateChangedHook != null)
		{
			subscribeBattleStateChangedHook(new Action<bool>(this.BattleStateChanged));
		}
		this.NoneMode = new GameBudgetModeBase("EGameBudgetMode.None", EGameBudgetMode.None);
		this.CurrentModel = this.NoneMode;
		this.EnterGameBudgetMode(this.CurrentModel);
		return base.OnInit();
	}

	// Token: 0x06000555 RID: 1365 RVA: 0x0001BE44 File Offset: 0x0001A044
	private void EnterGameBudgetMode(GameBudgetModeBase model)
	{
		if (PerfSight.Instance.IsEnable)
		{
			FKuroPerfSightHelper.BeginExtTag(model.GameBudgetModeName);
		}
		model.OnEnterMode();
	}

	// Token: 0x06000556 RID: 1366 RVA: 0x0001BE63 File Offset: 0x0001A063
	private void ExitGameBudgetMode(GameBudgetModeBase model)
	{
		if (PerfSight.Instance.IsEnable)
		{
			FKuroPerfSightHelper.EndExtTag(model.GameBudgetModeName);
		}
		model.OnExitMode();
	}

	// Token: 0x06000557 RID: 1367 RVA: 0x0001BE82 File Offset: 0x0001A082
	protected override bool OnClear()
	{
		Action<Action<bool>> unsubscribeBattleStateChangedHook = GameBudgetInterfaceController.UnsubscribeBattleStateChangedHook;
		if (unsubscribeBattleStateChangedHook != null)
		{
			unsubscribeBattleStateChangedHook(new Action<bool>(this.BattleStateChanged));
		}
		this.SequenceCamera = null;
		this.ExitGameBudgetMode(this.CurrentModel);
		return base.OnClear();
	}

	// Token: 0x06000558 RID: 1368 RVA: 0x0001BEB9 File Offset: 0x0001A0B9
	public void InitializeEnvironment(UWorld world)
	{
		UKuroGameBudgetAllocatorCSharpInterface.InitializeEnvironment(world, true);
		UKuroGameBudgetAllocatorCSharpInterface.SetUpdateCompensateEnable(false);
		if (this.CacheUpdateMinUpdateFifoBudgetTime != null)
		{
			UKuroGameBudgetAllocatorCSharpInterface.UpdateMinUpdateFIFOBudgetTime(this.CacheUpdateMinUpdateFifoBudgetTime.Value);
		}
		this.GameBudgetTimeEstimation.Initialize();
	}

	// Token: 0x06000559 RID: 1369 RVA: 0x0001BEF0 File Offset: 0x0001A0F0
	public static bool IsEnvironmentValid()
	{
		return UKuroGameBudgetAllocatorCSharpInterface.IsEnvironmentValid();
	}

	// Token: 0x0600055A RID: 1370 RVA: 0x0001BEF7 File Offset: 0x0001A0F7
	public void SetMaximumFrameRate(int fps)
	{
		UKuroGameBudgetAllocatorCSharpInterface.SetMaximumFrameRate((uint)((fps > 0) ? fps : 0));
		this.GameBudgetTimeEstimation.SetMaximumFrameRate(fps);
	}

	// Token: 0x170000C9 RID: 201
	// (get) Token: 0x0600055B RID: 1371 RVA: 0x0001BF12 File Offset: 0x0001A112
	public float? MinUpdateFifoBudgetTime
	{
		get
		{
			return this.CacheUpdateMinUpdateFifoBudgetTime;
		}
	}

	// Token: 0x0600055C RID: 1372 RVA: 0x0001BF1A File Offset: 0x0001A11A
	public static void UpdateMinUpdateFifoBudgetTime(float time)
	{
		GameBudgetInterfaceController.Instance.CacheUpdateMinUpdateFifoBudgetTime = new float?(time);
		if (GameBudgetInterfaceController.IsEnvironmentValid())
		{
			UKuroGameBudgetAllocatorCSharpInterface.UpdateMinUpdateFIFOBudgetTime(time);
		}
	}

	// Token: 0x0600055D RID: 1373 RVA: 0x0001BF39 File Offset: 0x0001A139
	public static void UpdateBudgetTime(float delta)
	{
		GameBudgetInterfaceController.Instance.GameBudgetTimeEstimation.UpdateBudgetTime(delta);
	}

	// Token: 0x0600055E RID: 1374 RVA: 0x0001BF4C File Offset: 0x0001A14C
	public uint RegisterTick(FName groupTag, ESignificanceGroup significanceGroup, IGameBudgetManagedObject obj, [Nullable(2)] AActor actor, bool afterTick = true, bool onEnabledChange = true, bool wasRecentlyRenderedOnScreenChange = true, bool locationProxyFunction = true)
	{
		uint result;
		if (this.ObjectTokenDic.TryGetValue(obj, out result))
		{
			Log.Instance.Warn(ELogModule.Game, ELogAuthor.WY, "Object has already added!", default(ReadOnlySpan<ValueTuple<string, object>>));
			return result;
		}
		GCHandle gchandle = obj.GetGCHandle();
		if (!gchandle.IsAllocated)
		{
			return 0U;
		}
		IntPtr actorPtr = IntPtr.Zero;
		if (actor != null)
		{
			actorPtr = actor.NativePtr;
		}
		uint num = FKuroGameBudgetAllocatorCSharpInterface.RegisterFunction(GCHandle.ToIntPtr(gchandle), groupTag, significanceGroup, actorPtr, afterTick && obj.HasScheduledAfterTick, onEnabledChange && obj.HasOnEnabledChange, wasRecentlyRenderedOnScreenChange && obj.HasOnWasRecentlyRenderedOnScreenChange, locationProxyFunction && obj.HasLocationProxyFunction);
		this.ObjectTokenDic[obj] = num;
		return num;
	}

	// Token: 0x0600055F RID: 1375 RVA: 0x0001C000 File Offset: 0x0001A200
	public void UnregisterTick(IGameBudgetManagedObject obj)
	{
		uint token;
		if (this.ObjectTokenDic.TryGetValue(obj, out token))
		{
			this.ObjectTokenDic.Remove(obj);
			UKuroGameBudgetAllocatorCSharpInterface.UnregisterFunction(token);
			return;
		}
		Log.Instance.Warn(ELogModule.Game, ELogAuthor.WY, "Not found error!", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x06000560 RID: 1376 RVA: 0x0001C04D File Offset: 0x0001A24D
	public void UpdateRegisterActor(FName groupName, uint token, AActor actor)
	{
		UKuroGameBudgetAllocatorCSharpInterface.UpdateActor(groupName, token, actor);
	}

	// Token: 0x06000561 RID: 1377 RVA: 0x0001C058 File Offset: 0x0001A258
	public void RegisterOnceTaskDefaultGroup(FName groupId, int priority, int maxWaitFrame)
	{
		UKuroGameBudgetAllocatorCSharpInterface.RegisterOnceTaskDefaultGroup(groupId, priority, maxWaitFrame);
	}

	// Token: 0x06000562 RID: 1378 RVA: 0x0001C064 File Offset: 0x0001A264
	public void RegisterOnceTaskCustomGroup(IGameBudgetOnceTaskGroup groupObject)
	{
		this.OnceTaskGroupDic.Add(groupObject.GroupId, groupObject);
		FName groupId = groupObject.GroupId;
		UKuroGameBudgetAllocatorCSharpInterface.RegisterOnceTaskCustomGroup(groupId, groupObject.Priority);
	}

	// Token: 0x06000563 RID: 1379 RVA: 0x0001C098 File Offset: 0x0001A298
	[NullableContext(2)]
	public IGameBudgetOnceTaskGroup GetOnceTaskGroupById(FName GroupId)
	{
		IGameBudgetOnceTaskGroup result;
		if (this.OnceTaskGroupDic.TryGetValue(GroupId, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x06000564 RID: 1380 RVA: 0x0001C0B8 File Offset: 0x0001A2B8
	[NullableContext(2)]
	public Vector GetCenterOffset()
	{
		return this.CenterOffsetInternal;
	}

	// Token: 0x06000565 RID: 1381 RVA: 0x0001C0C0 File Offset: 0x0001A2C0
	public void SetUseBoundsCalculateDistance(FName groupName, uint token, bool useBoundsCalculateDistance)
	{
		UKuroGameBudgetAllocatorCSharpInterface.SetUseBoundsCalculateDistance(groupName, token, useBoundsCalculateDistance);
	}

	// Token: 0x06000566 RID: 1382 RVA: 0x0001C0CB File Offset: 0x0001A2CB
	public void SetUsePerformanceActorCalculateBounds(FName groupName, uint token, bool usePerformanceActorCalculateBounds)
	{
		UKuroGameBudgetAllocatorCSharpInterface.SetUsePerformanceActorCalculateBounds(groupName, token, usePerformanceActorCalculateBounds);
	}

	// Token: 0x06000567 RID: 1383 RVA: 0x0001C0D8 File Offset: 0x0001A2D8
	public unsafe void SetConstantTick(FName groupName, uint token, bool value, string reason, bool reduceWhenInvisible = true)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Game;
		ELogAuthor author = ELogAuthor.WLJ;
		string message = "[GameBudget]设置对象恒定高频Tick";
		<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("GroupName", groupName);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Token", token);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Value", value);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Reason", reason);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("ReduceWhenInvisible", reduceWhenInvisible);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
		UKuroGameBudgetAllocatorCSharpInterface.SetConstantTick(groupName, token, value, reduceWhenInvisible);
	}

	// Token: 0x06000568 RID: 1384 RVA: 0x0001C1A1 File Offset: 0x0001A3A1
	public void SetPerformanceLimitMode(bool isPerformanceLimitMode)
	{
		this.IsPerformanceLimitMode = isPerformanceLimitMode;
		this.RefreshGlobalMode();
	}

	// Token: 0x06000569 RID: 1385 RVA: 0x0001C1B0 File Offset: 0x0001A3B0
	public void SetPlotMode(bool isInPlot)
	{
		this.IsInPlot = isInPlot;
		this.RefreshGlobalMode();
	}

	// Token: 0x0600056A RID: 1386 RVA: 0x0001C1C0 File Offset: 0x0001A3C0
	public void TryUpdateCenterRoleOffset(Entity entity)
	{
		Func<Entity, FVectorDouble?> centerRoleOffsetHook = GameBudgetInterfaceController.CenterRoleOffsetHook;
		FVectorDouble? fvectorDouble = (centerRoleOffsetHook != null) ? centerRoleOffsetHook(entity) : null;
		if (fvectorDouble != null)
		{
			this.SetCenterActorLocationOffset(fvectorDouble.Value);
		}
	}

	// Token: 0x0600056B RID: 1387 RVA: 0x0001C200 File Offset: 0x0001A400
	private void BattleStateChanged(bool isInFight)
	{
		this.IsInFight = isInFight;
		if (this.IsInFight && this.IsInPlot)
		{
			this.IsInPlot = false;
			Log.Instance.Error(ELogModule.Game, ELogAuthor.WLJ, "[GameBudget]进入战斗时时间预算管理仍然处于剧情模式", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		this.RefreshGlobalMode();
	}

	// Token: 0x0600056C RID: 1388 RVA: 0x0001C250 File Offset: 0x0001A450
	private unsafe void RefreshGlobalMode()
	{
		EGameBudgetAllocatorGlobalMode egameBudgetAllocatorGlobalMode = this.IsInPlot ? EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Cutscene : ((this.IsInFight && !this.IsPerformanceLimitMode) ? EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Fighting : EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal);
		this.CurrentGlobalModeInternal = egameBudgetAllocatorGlobalMode;
		UKuroGameBudgetAllocatorCSharpInterface.SetGlobalMode(egameBudgetAllocatorGlobalMode);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Game;
		ELogAuthor author = ELogAuthor.WLJ;
		string message = "[GameBudget]RefreshGlobalMode";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("IsInPlot", this.IsInPlot);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("IsInFight", this.IsInFight);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("IsPerformanceLimitMode", this.IsPerformanceLimitMode);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
	}

	// Token: 0x170000CA RID: 202
	// (get) Token: 0x0600056D RID: 1389 RVA: 0x0001C313 File Offset: 0x0001A513
	public EGameBudgetMode BudgetMode
	{
		get
		{
			return this.CurrentModel.Mode;
		}
	}

	// Token: 0x0600056E RID: 1390 RVA: 0x0001C320 File Offset: 0x0001A520
	private unsafe void SetModel(GameBudgetModeBase model)
	{
		if (this.CurrentModel != model)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Game;
			ELogAuthor author = ELogAuthor.WLJ;
			string message = "[GameBudget]时间预算管理模式更改";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("NewModel", model);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("OldModel", this.CurrentModel);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.ExitGameBudgetMode(this.CurrentModel);
			this.CurrentModel = model;
			this.EnterGameBudgetMode(model);
		}
	}

	// Token: 0x0600056F RID: 1391 RVA: 0x0001C3A8 File Offset: 0x0001A5A8
	public void OnBudgetModelChange(GameBudgetModeBase newModel)
	{
		this.SetModel(newModel);
	}

	// Token: 0x06000570 RID: 1392 RVA: 0x0001C3B1 File Offset: 0x0001A5B1
	[NullableContext(2)]
	public void OnChangeCenterRole(AActor centerActor, FVectorDouble? offset)
	{
		if (centerActor != null)
		{
			this.SetCenterRole(centerActor);
		}
		if (offset != null)
		{
			this.SetCenterActorLocationOffset(offset.Value);
		}
	}

	// Token: 0x06000571 RID: 1393 RVA: 0x0001C3D3 File Offset: 0x0001A5D3
	public void SetCenterActorLocationOffset(FVectorDouble offset)
	{
		this.CenterOffsetInternal = Vector.Create(offset);
		UKuroGameBudgetAllocatorCSharpInterface.SetCenterActorLocationOffset(offset);
	}

	// Token: 0x06000572 RID: 1394 RVA: 0x0001C3ED File Offset: 0x0001A5ED
	[NullableContext(2)]
	public void SetCenterRole(AActor roleActor)
	{
		if (roleActor == null)
		{
			return;
		}
		if (this.CenterRoleInternal != roleActor)
		{
			UKuroGameBudgetAllocatorCSharpInterface.SetCenterActor(roleActor);
			this.CenterRoleInternal = roleActor;
			this.SetCenterActorLocationOffset(Vector.ZeroVectorDouble);
		}
	}

	// Token: 0x170000CB RID: 203
	// (get) Token: 0x06000573 RID: 1395 RVA: 0x0001C414 File Offset: 0x0001A614
	public static GameBudgetInterfaceController Instance
	{
		get
		{
			if (GameBudgetInterfaceController._instance == null)
			{
				GameBudgetInterfaceController._instance = new GameBudgetInterfaceController();
				GameBudgetInterfaceController._instance.OnInit();
			}
			return GameBudgetInterfaceController._instance;
		}
	}

	// Token: 0x06000574 RID: 1396 RVA: 0x0001C437 File Offset: 0x0001A637
	public static void CreateStaticDefaultValue()
	{
		GameBudgetInterfaceController.OnCreateStaticDefaultValue();
	}

	// Token: 0x06000575 RID: 1397 RVA: 0x0001C43E File Offset: 0x0001A63E
	public static void ResetStaticDefaultValue()
	{
		GameBudgetInterfaceController instance = GameBudgetInterfaceController._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		GameBudgetInterfaceController._instance = null;
		GameBudgetInterfaceController.OnResetStaticDefaultValue();
	}

	// Token: 0x06000576 RID: 1398 RVA: 0x0001C45C File Offset: 0x0001A65C
	private static void OnCreateStaticDefaultValue()
	{
	}

	// Token: 0x06000577 RID: 1399 RVA: 0x0001C45E File Offset: 0x0001A65E
	private static void OnResetStaticDefaultValue()
	{
		GameBudgetInterfaceController.SubscribeBattleStateChangedHook = null;
		GameBudgetInterfaceController.UnsubscribeBattleStateChangedHook = null;
		GameBudgetInterfaceController.CenterRoleOffsetHook = null;
	}

	// Token: 0x06000578 RID: 1400 RVA: 0x0001C472 File Offset: 0x0001A672
	static GameBudgetInterfaceController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GameBudgetInterfaceController.CreateStaticDefaultValue), new Action(GameBudgetInterfaceController.ResetStaticDefaultValue));
	}

	// Token: 0x0400044D RID: 1101
	public static Action<Action<bool>> SubscribeBattleStateChangedHook;

	// Token: 0x0400044E RID: 1102
	public static Action<Action<bool>> UnsubscribeBattleStateChangedHook;

	// Token: 0x0400044F RID: 1103
	public static Func<Entity, FVectorDouble?> CenterRoleOffsetHook;

	// Token: 0x04000450 RID: 1104
	[StaticVariableRuleIgnore]
	public static readonly bool IsOpen = true;

	// Token: 0x04000451 RID: 1105
	private readonly Dictionary<IGameBudgetManagedObject, uint> ObjectTokenDic = new Dictionary<IGameBudgetManagedObject, uint>();

	// Token: 0x04000452 RID: 1106
	private readonly Dictionary<FName, IGameBudgetOnceTaskGroup> OnceTaskGroupDic = new Dictionary<FName, IGameBudgetOnceTaskGroup>();

	// Token: 0x04000453 RID: 1107
	public readonly FName TsGlobalFifoTaskGroupName = new FName("TsGlobalFifoTaskGroup");

	// Token: 0x04000454 RID: 1108
	public readonly ESignificanceGroup TsGlobalFifoTaskSignificanceGroup = ESignificanceGroup.Middle;

	// Token: 0x04000455 RID: 1109
	[Nullable(2)]
	private AActor CenterRoleInternal;

	// Token: 0x04000456 RID: 1110
	private float? CacheUpdateMinUpdateFifoBudgetTime;

	// Token: 0x04000457 RID: 1111
	public bool IsInPlot;

	// Token: 0x04000458 RID: 1112
	public bool IsInFight;

	// Token: 0x04000459 RID: 1113
	private bool IsPerformanceLimitMode;

	// Token: 0x0400045A RID: 1114
	private EGameBudgetAllocatorGlobalMode CurrentGlobalModeInternal;

	// Token: 0x0400045B RID: 1115
	private IGameBudgetTimeEstimation GameBudgetTimeEstimation = new GameBudgetTimeEstimationFramesOffset();

	// Token: 0x0400045C RID: 1116
	[Nullable(2)]
	private Vector CenterOffsetInternal;

	// Token: 0x0400045D RID: 1117
	private GameBudgetModeBase CurrentModel;

	// Token: 0x0400045E RID: 1118
	[Nullable(2)]
	public AActor SequenceCamera;

	// Token: 0x0400045F RID: 1119
	private GameBudgetModeBase NoneMode;

	// Token: 0x04000460 RID: 1120
	[Nullable(2)]
	private static GameBudgetInterfaceController _instance;
}

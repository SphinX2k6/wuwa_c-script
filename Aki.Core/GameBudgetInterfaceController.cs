using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.GameBudgetAllocator;
using CSharpScript.Typing;
using UnrealEngine;

// Token: 0x020000AB RID: 171
[NullableContext(1)]
[Nullable(0)]
public class GameBudgetInterfaceController : Singleton
{
	// Token: 0x170000B5 RID: 181
	// (get) Token: 0x06000511 RID: 1297 RVA: 0x0001B6F2 File Offset: 0x000198F2
	[Nullable(2)]
	public AActor CenterRole
	{
		[NullableContext(2)]
		get
		{
			return this.CenterRoleInternal;
		}
	}

	// Token: 0x170000B6 RID: 182
	// (get) Token: 0x06000512 RID: 1298 RVA: 0x0001B6FA File Offset: 0x000198FA
	public EGameBudgetAllocatorGlobalMode CurrentGlobalMode
	{
		get
		{
			return this.CurrentGlobalModeInternal;
		}
	}

	// Token: 0x06000513 RID: 1299 RVA: 0x0001B704 File Offset: 0x00019904
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

	// Token: 0x06000514 RID: 1300 RVA: 0x0001B75C File Offset: 0x0001995C
	private void EnterGameBudgetMode(GameBudgetModeBase model)
	{
		if (PerfSight.Instance.IsEnable)
		{
			FKuroPerfSightHelper.BeginExtTag(model.GameBudgetModeName);
		}
		model.OnEnterMode();
	}

	// Token: 0x06000515 RID: 1301 RVA: 0x0001B77B File Offset: 0x0001997B
	private void ExitGameBudgetMode(GameBudgetModeBase model)
	{
		if (PerfSight.Instance.IsEnable)
		{
			FKuroPerfSightHelper.EndExtTag(model.GameBudgetModeName);
		}
		model.OnExitMode();
	}

	// Token: 0x06000516 RID: 1302 RVA: 0x0001B79A File Offset: 0x0001999A
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

	// Token: 0x06000517 RID: 1303 RVA: 0x0001B7D1 File Offset: 0x000199D1
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

	// Token: 0x06000518 RID: 1304 RVA: 0x0001B808 File Offset: 0x00019A08
	public static bool IsEnvironmentValid()
	{
		return UKuroGameBudgetAllocatorCSharpInterface.IsEnvironmentValid();
	}

	// Token: 0x06000519 RID: 1305 RVA: 0x0001B80F File Offset: 0x00019A0F
	public void SetMaximumFrameRate(int fps)
	{
		UKuroGameBudgetAllocatorCSharpInterface.SetMaximumFrameRate((uint)((fps > 0) ? fps : 0));
		this.GameBudgetTimeEstimation.SetMaximumFrameRate(fps);
	}

	// Token: 0x170000B7 RID: 183
	// (get) Token: 0x0600051A RID: 1306 RVA: 0x0001B82A File Offset: 0x00019A2A
	public float? MinUpdateFifoBudgetTime
	{
		get
		{
			return this.CacheUpdateMinUpdateFifoBudgetTime;
		}
	}

	// Token: 0x0600051B RID: 1307 RVA: 0x0001B832 File Offset: 0x00019A32
	public static void UpdateMinUpdateFifoBudgetTime(float time)
	{
		GameBudgetInterfaceController.Instance.CacheUpdateMinUpdateFifoBudgetTime = new float?(time);
		if (GameBudgetInterfaceController.IsEnvironmentValid())
		{
			UKuroGameBudgetAllocatorCSharpInterface.UpdateMinUpdateFIFOBudgetTime(time);
		}
	}

	// Token: 0x0600051C RID: 1308 RVA: 0x0001B851 File Offset: 0x00019A51
	public static void UpdateBudgetTime(float delta)
	{
		GameBudgetInterfaceController.Instance.GameBudgetTimeEstimation.UpdateBudgetTime(delta);
	}

	// Token: 0x0600051D RID: 1309 RVA: 0x0001B864 File Offset: 0x00019A64
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

	// Token: 0x0600051E RID: 1310 RVA: 0x0001B918 File Offset: 0x00019B18
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

	// Token: 0x0600051F RID: 1311 RVA: 0x0001B965 File Offset: 0x00019B65
	public void UpdateRegisterActor(FName groupName, uint token, AActor actor)
	{
		UKuroGameBudgetAllocatorCSharpInterface.UpdateActor(groupName, token, actor);
	}

	// Token: 0x06000520 RID: 1312 RVA: 0x0001B970 File Offset: 0x00019B70
	public void RegisterOnceTaskDefaultGroup(FName groupId, int priority, int maxWaitFrame)
	{
		UKuroGameBudgetAllocatorCSharpInterface.RegisterOnceTaskDefaultGroup(groupId, priority, maxWaitFrame);
	}

	// Token: 0x06000521 RID: 1313 RVA: 0x0001B97C File Offset: 0x00019B7C
	public void RegisterOnceTaskCustomGroup(IGameBudgetOnceTaskGroup groupObject)
	{
		this.OnceTaskGroupDic.Add(groupObject.GroupId, groupObject);
		FName groupId = groupObject.GroupId;
		UKuroGameBudgetAllocatorCSharpInterface.RegisterOnceTaskCustomGroup(groupId, groupObject.Priority);
	}

	// Token: 0x06000522 RID: 1314 RVA: 0x0001B9B0 File Offset: 0x00019BB0
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

	// Token: 0x06000523 RID: 1315 RVA: 0x0001B9D0 File Offset: 0x00019BD0
	[NullableContext(2)]
	public Vector GetCenterOffset()
	{
		return this.CenterOffsetInternal;
	}

	// Token: 0x06000524 RID: 1316 RVA: 0x0001B9D8 File Offset: 0x00019BD8
	public void SetUseBoundsCalculateDistance(FName groupName, uint token, bool useBoundsCalculateDistance)
	{
		UKuroGameBudgetAllocatorCSharpInterface.SetUseBoundsCalculateDistance(groupName, token, useBoundsCalculateDistance);
	}

	// Token: 0x06000525 RID: 1317 RVA: 0x0001B9E3 File Offset: 0x00019BE3
	public void SetUsePerformanceActorCalculateBounds(FName groupName, uint token, bool usePerformanceActorCalculateBounds)
	{
		UKuroGameBudgetAllocatorCSharpInterface.SetUsePerformanceActorCalculateBounds(groupName, token, usePerformanceActorCalculateBounds);
	}

	// Token: 0x06000526 RID: 1318 RVA: 0x0001B9F0 File Offset: 0x00019BF0
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

	// Token: 0x06000527 RID: 1319 RVA: 0x0001BAB9 File Offset: 0x00019CB9
	public void SetPerformanceLimitMode(bool isPerformanceLimitMode)
	{
		this.IsPerformanceLimitMode = isPerformanceLimitMode;
		this.RefreshGlobalMode();
	}

	// Token: 0x06000528 RID: 1320 RVA: 0x0001BAC8 File Offset: 0x00019CC8
	public void SetPlotMode(bool isInPlot)
	{
		this.IsInPlot = isInPlot;
		this.RefreshGlobalMode();
	}

	// Token: 0x06000529 RID: 1321 RVA: 0x0001BAD8 File Offset: 0x00019CD8
	public void TryUpdateCenterRoleOffset(Entity entity)
	{
		Func<Entity, FVectorDouble?> centerRoleOffsetHook = GameBudgetInterfaceController.CenterRoleOffsetHook;
		FVectorDouble? fvectorDouble = (centerRoleOffsetHook != null) ? centerRoleOffsetHook(entity) : null;
		if (fvectorDouble != null)
		{
			this.SetCenterActorLocationOffset(fvectorDouble.Value);
		}
	}

	// Token: 0x0600052A RID: 1322 RVA: 0x0001BB18 File Offset: 0x00019D18
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

	// Token: 0x0600052B RID: 1323 RVA: 0x0001BB68 File Offset: 0x00019D68
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

	// Token: 0x170000B8 RID: 184
	// (get) Token: 0x0600052C RID: 1324 RVA: 0x0001BC2B File Offset: 0x00019E2B
	public EGameBudgetMode BudgetMode
	{
		get
		{
			return this.CurrentModel.Mode;
		}
	}

	// Token: 0x0600052D RID: 1325 RVA: 0x0001BC38 File Offset: 0x00019E38
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

	// Token: 0x0600052E RID: 1326 RVA: 0x0001BCC0 File Offset: 0x00019EC0
	public void OnBudgetModelChange(GameBudgetModeBase newModel)
	{
		this.SetModel(newModel);
	}

	// Token: 0x0600052F RID: 1327 RVA: 0x0001BCC9 File Offset: 0x00019EC9
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

	// Token: 0x06000530 RID: 1328 RVA: 0x0001BCEB File Offset: 0x00019EEB
	public void SetCenterActorLocationOffset(FVectorDouble offset)
	{
		this.CenterOffsetInternal = Vector.Create(offset);
		UKuroGameBudgetAllocatorCSharpInterface.SetCenterActorLocationOffset(offset);
	}

	// Token: 0x06000531 RID: 1329 RVA: 0x0001BD05 File Offset: 0x00019F05
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

	// Token: 0x170000B9 RID: 185
	// (get) Token: 0x06000532 RID: 1330 RVA: 0x0001BD2C File Offset: 0x00019F2C
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

	// Token: 0x06000533 RID: 1331 RVA: 0x0001BD4F File Offset: 0x00019F4F
	public static void CreateStaticDefaultValue()
	{
		GameBudgetInterfaceController.OnCreateStaticDefaultValue();
	}

	// Token: 0x06000534 RID: 1332 RVA: 0x0001BD56 File Offset: 0x00019F56
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

	// Token: 0x06000535 RID: 1333 RVA: 0x0001BD74 File Offset: 0x00019F74
	private static void OnCreateStaticDefaultValue()
	{
	}

	// Token: 0x06000536 RID: 1334 RVA: 0x0001BD76 File Offset: 0x00019F76
	private static void OnResetStaticDefaultValue()
	{
		GameBudgetInterfaceController.SubscribeBattleStateChangedHook = null;
		GameBudgetInterfaceController.UnsubscribeBattleStateChangedHook = null;
		GameBudgetInterfaceController.CenterRoleOffsetHook = null;
	}

	// Token: 0x06000537 RID: 1335 RVA: 0x0001BD8A File Offset: 0x00019F8A
	static GameBudgetInterfaceController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GameBudgetInterfaceController.CreateStaticDefaultValue), new Action(GameBudgetInterfaceController.ResetStaticDefaultValue));
	}

	// Token: 0x0400043F RID: 1087
	public static Action<Action<bool>> SubscribeBattleStateChangedHook;

	// Token: 0x04000440 RID: 1088
	public static Action<Action<bool>> UnsubscribeBattleStateChangedHook;

	// Token: 0x04000441 RID: 1089
	public static Func<Entity, FVectorDouble?> CenterRoleOffsetHook;

	// Token: 0x04000442 RID: 1090
	[StaticVariableRuleIgnore]
	public static readonly bool IsOpen = true;

	// Token: 0x04000443 RID: 1091
	private readonly Dictionary<IGameBudgetManagedObject, uint> ObjectTokenDic = new Dictionary<IGameBudgetManagedObject, uint>();

	// Token: 0x04000444 RID: 1092
	private readonly Dictionary<FName, IGameBudgetOnceTaskGroup> OnceTaskGroupDic = new Dictionary<FName, IGameBudgetOnceTaskGroup>();

	// Token: 0x04000445 RID: 1093
	public readonly FName TsGlobalFifoTaskGroupName = new FName("TsGlobalFifoTaskGroup");

	// Token: 0x04000446 RID: 1094
	public readonly ESignificanceGroup TsGlobalFifoTaskSignificanceGroup = ESignificanceGroup.Middle;

	// Token: 0x04000447 RID: 1095
	[Nullable(2)]
	private AActor CenterRoleInternal;

	// Token: 0x04000448 RID: 1096
	private float? CacheUpdateMinUpdateFifoBudgetTime;

	// Token: 0x04000449 RID: 1097
	public bool IsInPlot;

	// Token: 0x0400044A RID: 1098
	public bool IsInFight;

	// Token: 0x0400044B RID: 1099
	private bool IsPerformanceLimitMode;

	// Token: 0x0400044C RID: 1100
	private EGameBudgetAllocatorGlobalMode CurrentGlobalModeInternal;

	// Token: 0x0400044D RID: 1101
	private IGameBudgetTimeEstimation GameBudgetTimeEstimation = new GameBudgetTimeEstimationFramesOffset();

	// Token: 0x0400044E RID: 1102
	[Nullable(2)]
	private Vector CenterOffsetInternal;

	// Token: 0x0400044F RID: 1103
	private GameBudgetModeBase CurrentModel;

	// Token: 0x04000450 RID: 1104
	[Nullable(2)]
	public AActor SequenceCamera;

	// Token: 0x04000451 RID: 1105
	private GameBudgetModeBase NoneMode;

	// Token: 0x04000452 RID: 1106
	[Nullable(2)]
	private static GameBudgetInterfaceController _instance;
}

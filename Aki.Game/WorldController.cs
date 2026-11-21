using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using Aki.Protocol.Summon;
using AkiClient.Game.Aki.Render.RuntimeBP.GI;
using CSharpScript.Core.Common;
using CSharpScript.Core.GameBudgetAllocator;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.Teleport;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow;
using CSharpScript.Game.NewWorld.SceneItem;
using CSharpScript.Game.Perception;
using CSharpScript.Game.Ui;
using CSharpScript.Game.World.Controller;
using CSharpScript.Launcher.Platform;
using CSharpScript.Typing;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x02002A61 RID: 10849
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class WorldController : ControllerBase
{
	// Token: 0x0601B80F RID: 112655 RVA: 0x00879424 File Offset: 0x00877624
	protected override bool OnInit()
	{
		WorldModel.Instance.CurrentSchedulerDelta = 0.0;
		if (GameBudgetInterfaceController.IsOpen)
		{
			int frameRate = GameSettingsDeviceRender.Instance.FrameRate;
			GameBudgetInterfaceController.Instance.SetMaximumFrameRate(frameRate);
		}
		PerformanceController.Instance.IsOpenCatchWorldEntity = false;
		EventSystem.Instance.Add<int>(EEventName.SettingFrameRateChanged, new Action<int>(this.OnSettingFrameRateChanged));
		EventSystem.Instance.Add(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
		LoadModeManager.Instance.LoadModeApplied += this.OnLoadModeApplied;
		EventSystem.Instance.Add(EEventName.OnUpdateSceneTeam, new Action(this.OnFormationChange));
		EventSystem.Instance.Add(EEventName.OnLeaveOnlineWorld, new Action(this.OnLeaveOnlineWorld));
		EventSystem.Instance.Add(EEventName.ChangePerformanceLimitMode, new Action<bool, bool>(this.OnPerformanceLimitModeChanged));
		EventSystem.Instance.Add<bool>(EEventName.TeleportStart, new Action<bool>(this.OnTeleportStart));
		EventSystem.Instance.Add<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete));
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
		Net.Instance.Register(ENotifyMessageId.FuncOpenConfirmNotify, new Action<IMessage, Net.CallbackStatus>(this.OnFuncOpenConfirmNotify));
		this.DoTickHandle = TickSystem.Instance.Add(new Action<float>(this.DoTick), "WorldController", ETickingGroup.TG_DuringPhysics, false, 0, false);
		this.DoTickFrameEndHandle = TickSystem.Instance.Add(new Action<float>(this.DoTickFrameEnd), "WorldController", ETickingGroup.TG_PostUpdateWork, true, 0, false);
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "wo.ParallelOffset 1", null);
		this.MemoryGcCheckTimerId = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnMemoryGcCheck), 1800000f, 1f, null, "WorldController.OnInit.MemoryGcCheck", false);
		this.VoxelCheckTimerId = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnPlayerVoxelEnvCheck), 5000f, 1f, null, null, true);
		return true;
	}

	// Token: 0x0601B810 RID: 112656 RVA: 0x00879630 File Offset: 0x00877830
	protected override bool OnClear()
	{
		EventSystem.Instance.Remove(EEventName.SettingFrameRateChanged, new Action<int>(this.OnSettingFrameRateChanged));
		EventSystem.Instance.Remove(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
		LoadModeManager.Instance.LoadModeApplied -= this.OnLoadModeApplied;
		this.LoopMapStreamingBudgetEnabled = false;
		EventSystem.Instance.Remove(EEventName.OnUpdateSceneTeam, new Action(this.OnFormationChange));
		EventSystem.Instance.Remove(EEventName.OnLeaveOnlineWorld, new Action(this.OnLeaveOnlineWorld));
		EventSystem.Instance.Remove(EEventName.ChangePerformanceLimitMode, new Action<bool, bool>(this.OnPerformanceLimitModeChanged));
		EventSystem.Instance.Remove(EEventName.TeleportStart, new Action<bool>(this.OnTeleportStart));
		EventSystem.Instance.Remove(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete));
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		Net.Instance.UnRegister(ENotifyMessageId.FuncOpenConfirmNotify);
		WorldModel.Instance.ControlPlayerLastLocation = null;
		if (this.VoxelCheckTimerId != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.VoxelCheckTimerId);
			this.VoxelCheckTimerId = null;
		}
		if (this.DoTickHandle != null)
		{
			TickSystem.Instance.Remove(this.DoTickHandle.Id);
			this.DoTickHandle = null;
		}
		if (this.DoTickFrameEndHandle != null)
		{
			TickSystem.Instance.Remove(this.DoTickFrameEndHandle.Id);
			this.DoTickFrameEndHandle = null;
		}
		return true;
	}

	// Token: 0x0601B811 RID: 112657 RVA: 0x008797C8 File Offset: 0x008779C8
	[NullableContext(2)]
	private unsafe void OnFuncOpenConfirmNotify(IMessage msg, Net.CallbackStatus status)
	{
		FuncOpenConfirmNotify funcOpenConfirmNotify = (FuncOpenConfirmNotify)msg;
		fixed (byte* pinnableReference = funcOpenConfirmNotify.FuncInfo.Span.GetPinnableReference())
		{
			byte* data = pinnableReference;
			UFuncOpenBlueprintFunctionLibrary.TryOpen(new FArrayBuffer
			{
				Data = (void*)data,
				Length = (ulong)((long)funcOpenConfirmNotify.FuncInfo.Length)
			});
		}
	}

	// Token: 0x0601B812 RID: 112658 RVA: 0x00879820 File Offset: 0x00877A20
	private void OnMemoryGcCheck(float delta)
	{
		if (this.GlobalIsInFight)
		{
			TimerSystem.GameplayTimeInstance.Pause(this.MemoryGcCheckTimerId, null);
			this.ShouldGcWhenBattleFinished = true;
			return;
		}
		this.ManuallyGarbageCollection(EGarbageCollectionReason.OnTimerFinish);
		this.ShouldGcWhenBattleFinished = false;
	}

	// Token: 0x0601B813 RID: 112659 RVA: 0x00879852 File Offset: 0x00877A52
	private void OnTeleportStart(bool b)
	{
		if (this.IsPerformanceLimitMode)
		{
			this.OnPerformanceLimitModeChanged(true, true);
		}
	}

	// Token: 0x0601B814 RID: 112660 RVA: 0x00879864 File Offset: 0x00877A64
	[NullableContext(2)]
	private void OnTeleportComplete(TeleportContext teleportContext)
	{
		if (this.IsPerformanceLimitMode)
		{
			this.OnPerformanceLimitModeChanged(true, false);
		}
	}

	// Token: 0x0601B815 RID: 112661 RVA: 0x00879876 File Offset: 0x00877A76
	private void OnWorldDone()
	{
		WorldModel.Instance.CurEnvironmentInfo.ServerCaveMode = EActorCavernMode.ActorCavernMode_None;
	}

	// Token: 0x0601B816 RID: 112662 RVA: 0x00879888 File Offset: 0x00877A88
	private void OnPerformanceLimitModeChanged(bool isPerformanceLimitMode, bool forceDisable)
	{
		this.IsPerformanceLimitMode = isPerformanceLimitMode;
		GameBudgetInterfaceController.Instance.SetPerformanceLimitMode(isPerformanceLimitMode && !forceDisable);
		BP_GlobalGI_C bp_GlobalGI_C = UKuroGISystem.GetKuroGISystem(GlobalData.World.GetWorld()).GetKuroGlobalGIActor() as BP_GlobalGI_C;
		if (isPerformanceLimitMode && !forceDisable)
		{
			bp_GlobalGI_C.EnableImposterUpdate = false;
			return;
		}
		bp_GlobalGI_C.EnableImposterUpdate = true;
	}

	// Token: 0x0601B817 RID: 112663 RVA: 0x008798E0 File Offset: 0x00877AE0
	private void OnBattleStateChanged(bool bStart)
	{
		this.GlobalIsInFight = bStart;
		if (bStart)
		{
			GameSettingsDeviceRender.Instance.TryReduceCsmUpdateFrequency("Battle");
		}
		else
		{
			GameSettingsDeviceRender.Instance.TryRestoreCsmUpdateFrequency("Battle");
		}
		this.UpdateWPLoadingStreamingCells();
		if (!bStart && this.ShouldGcWhenBattleFinished)
		{
			this.ManuallyGarbageCollection(EGarbageCollectionReason.OnTimerFinishAndWaitForBattle);
			this.ShouldGcWhenBattleFinished = false;
			TimerSystem.GameplayTimeInstance.Resume(this.MemoryGcCheckTimerId);
		}
		UKuroStaticLibrary.SetGameThreadAffinity(bStart);
	}

	// Token: 0x0601B818 RID: 112664 RVA: 0x00879950 File Offset: 0x00877B50
	private void OnPlayerVoxelEnvCheck(float delta)
	{
		WorldModel instance = WorldModel.Instance;
		if (instance == null)
		{
			return;
		}
		instance.CurEnvironmentInfo.RequestUpdateVoxelEnv();
	}

	// Token: 0x0601B819 RID: 112665 RVA: 0x00879972 File Offset: 0x00877B72
	public void SetLoopMapStreamingBudgetEnabled(bool enabled)
	{
		this.LoopMapStreamingBudgetEnabled = enabled;
		this.UpdateWPLoadingStreamingCells();
	}

	// Token: 0x0601B81A RID: 112666 RVA: 0x00879981 File Offset: 0x00877B81
	private void OnLoadModeApplied(ELoadMode mode)
	{
		this.UpdateWPLoadingStreamingCells();
	}

	// Token: 0x0601B81B RID: 112667 RVA: 0x0087998C File Offset: 0x00877B8C
	private void UpdateWPLoadingStreamingCells()
	{
		ELoadMode loadMode = LoadModeManager.Instance.GetLoadMode();
		UWorld world = GlobalData.World;
		if (loadMode == ELoadMode.None || loadMode == ELoadMode.Loading || (world == null || !world.IsValid()))
		{
			return;
		}
		int value = (loadMode == ELoadMode.InGameLoading) ? 8 : 4;
		if (this.LoopMapStreamingBudgetEnabled)
		{
			value = 16;
		}
		if ((loadMode == ELoadMode.InGame || loadMode == ELoadMode.ForceInGame) && this.GlobalIsInFight)
		{
			value = 1;
		}
		UObject worldContextObject = world;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 1);
		defaultInterpolatedStringHandler.AppendLiteral("wp.Runtime.MaxLoadingStreamingCells ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(value);
		UKismetSystemLibrary.ExecuteConsoleCommand(worldContextObject, defaultInterpolatedStringHandler.ToStringAndClear(), null);
	}

	// Token: 0x0601B81C RID: 112668 RVA: 0x00879A20 File Offset: 0x00877C20
	public void ForceGarbageCollection(bool bFullPurge)
	{
		double milliseconds = KuroTime.GetMilliseconds64();
		UKuroStaticLibrary.ForceGarbageCollection(bFullPurge);
		double num = KuroTime.GetMilliseconds64() - milliseconds;
		if (PerfSight.Instance.IsEnable)
		{
			FKuroPerfSightHelper.PostValueFloat1("CustomPerformance", "ForceGarbageCollection", (float)num);
		}
	}

	// Token: 0x0601B81D RID: 112669 RVA: 0x00879A60 File Offset: 0x00877C60
	public void ManuallyGarbageCollection(EGarbageCollectionReason reason)
	{
		if (this.DeviceShouldGc == EShouldGc.NotDecided)
		{
			this.DeviceShouldGc = EShouldGc.ShouldGc;
			if (Platform.Instance.IsAndroidPlatform())
			{
				string deviceCPU = UKuroStaticLibrary.GetDeviceCPU();
				if (deviceCPU.Contains("SDM660"))
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.World;
					ELogAuthor author = ELogAuthor.MZJ;
					string message = "Disable ManuallyGarbageCollection";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("cpu", deviceCPU);
					instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					this.DeviceShouldGc = EShouldGc.ShouldNotGc;
				}
			}
		}
		if (this.DeviceShouldGc != EShouldGc.ShouldGc)
		{
			return;
		}
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.World;
		ELogAuthor author2 = ELogAuthor.WY;
		string message2 = "ManuallyGarbageCollection";
		ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Reason: ", reason);
		instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		EventSystem.Instance.Emit(EEventName.TestManuallyGarbageCollection);
		double milliseconds = KuroTime.GetMilliseconds64();
		if (reason == EGarbageCollectionReason.CloseUiView)
		{
			GC.Collect(0);
		}
		else
		{
			GC.Collect(GC.MaxGeneration);
		}
		double num = KuroTime.GetMilliseconds64() - milliseconds;
		if (PerfSight.Instance.IsEnable)
		{
			FKuroPerfSightHelper.PostValueFloat1("CustomPerformance", "ManuallyGarbageCollection", (float)num);
		}
	}

	// Token: 0x0601B81E RID: 112670 RVA: 0x00879B54 File Offset: 0x00877D54
	public void ManuallyClearStreamingPool()
	{
		if (Info.Instance.PlatformType == ESourcePlatformType.IOS)
		{
			Log.Instance.Info(ELogModule.World, ELogAuthor.WLJ, "ManuallyClearStreamingPool In IOS", default(ReadOnlySpan<ValueTuple<string, object>>));
			UObject world = GlobalData.World;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.Streaming.PoolSize ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(90);
			UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			UObject world2 = GlobalData.World;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.Streaming.PoolSizeForMeshes ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(90);
			UKismetSystemLibrary.ExecuteConsoleCommand(world2, defaultInterpolatedStringHandler.ToStringAndClear(), null);
		}
		EventSystem.Instance.Emit(EEventName.OnManuallyClearStreamingPool);
	}

	// Token: 0x0601B81F RID: 112671 RVA: 0x00879BFC File Offset: 0x00877DFC
	public void ManuallyResetStreamingPool()
	{
		if (Info.Instance.PlatformType == ESourcePlatformType.IOS)
		{
			Log.Instance.Info(ELogModule.World, ELogAuthor.WLJ, "ManuallyResetStreamingPool In IOS", default(ReadOnlySpan<ValueTuple<string, object>>));
			UObject world = GlobalData.World;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.Streaming.PoolSize ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(250);
			UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			UObject world2 = GlobalData.World;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.Streaming.PoolSizeForMeshes ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(250);
			UKismetSystemLibrary.ExecuteConsoleCommand(world2, defaultInterpolatedStringHandler.ToStringAndClear(), null);
		}
		EventSystem.Instance.Emit(EEventName.OnManuallyResetStreamingPool);
	}

	// Token: 0x0601B820 RID: 112672 RVA: 0x00879CB0 File Offset: 0x00877EB0
	private void OnSettingFrameRateChanged(int frameRate)
	{
		if (GameBudgetInterfaceController.IsOpen)
		{
			GameBudgetInterfaceController.Instance.SetMaximumFrameRate(frameRate);
			return;
		}
		WorldModel instance = WorldModel.Instance;
		if (((instance != null) ? instance.TickIntervalSchedulers : null) != null)
		{
			foreach (TickIntervalSchedulerBase tickIntervalSchedulerBase in WorldModel.Instance.TickIntervalSchedulers)
			{
				tickIntervalSchedulerBase.ChangeTickFramePeriodByFrameRate((double)frameRate);
			}
		}
	}

	// Token: 0x0601B821 RID: 112673 RVA: 0x00879D2C File Offset: 0x00877F2C
	private void DoTick(float deltaTime)
	{
		if (!GameBudgetInterfaceController.IsOpen)
		{
			WorldModel instance = WorldModel.Instance;
			if (Time.Instance.DeltaTime <= 25f && Time.Instance.DeltaTime >= 20f)
			{
				instance.ChangeSchedulerLastType = 0L;
			}
			else if (Time.Instance.DeltaTime > 25f && instance.CurrentSchedulerDelta > 0.0)
			{
				if (instance.ChangeSchedulerLastType != 1L)
				{
					instance.ChangeSchedulerLastType = 1L;
					instance.ChangeSchedulerDeltaFrameCount = 0L;
				}
				else
				{
					WorldModel worldModel = instance;
					long num = worldModel.ChangeSchedulerDeltaFrameCount + 1L;
					worldModel.ChangeSchedulerDeltaFrameCount = num;
					if (num >= 5L)
					{
						instance.CurrentSchedulerDelta -= 1.0;
						instance.ChangeSchedulerDeltaFrameCount = 0L;
						foreach (TickIntervalSchedulerBase tickIntervalSchedulerBase in WorldModel.Instance.TickIntervalSchedulers)
						{
							tickIntervalSchedulerBase.SetCountDelta(instance.CurrentSchedulerDelta);
						}
						Log instance2 = Log.Instance;
						ELogModule module = ELogModule.World;
						ELogAuthor author = ELogAuthor.LCZ;
						string message = "Decrease max tick count";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Delta", instance.CurrentSchedulerDelta);
						instance2.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					}
				}
			}
			else if (Time.Instance.DeltaTime < 20f && instance.CurrentSchedulerDelta < 0.0)
			{
				if (instance.ChangeSchedulerLastType != 2L)
				{
					instance.ChangeSchedulerLastType = 2L;
					instance.ChangeSchedulerDeltaFrameCount = 0L;
				}
				else
				{
					WorldModel worldModel2 = instance;
					long num = worldModel2.ChangeSchedulerDeltaFrameCount + 1L;
					worldModel2.ChangeSchedulerDeltaFrameCount = num;
					if (num >= 10L)
					{
						instance.CurrentSchedulerDelta += 1.0;
						instance.ChangeSchedulerDeltaFrameCount = 0L;
						foreach (TickIntervalSchedulerBase tickIntervalSchedulerBase2 in WorldModel.Instance.TickIntervalSchedulers)
						{
							tickIntervalSchedulerBase2.SetCountDelta(instance.CurrentSchedulerDelta);
						}
						Log instance3 = Log.Instance;
						ELogModule module2 = ELogModule.World;
						ELogAuthor author2 = ELogAuthor.LCZ;
						string message2 = "Increase max tick count";
						ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Delta", instance.CurrentSchedulerDelta);
						instance3.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					}
				}
			}
			foreach (TickIntervalSchedulerBase tickIntervalSchedulerBase3 in WorldModel.Instance.TickIntervalSchedulers)
			{
				tickIntervalSchedulerBase3.Schedule();
			}
		}
		if (this.UpdateRemoveInterval())
		{
			this.CurrentFrameInterval = 0;
			this.UpdateDestroyPendingNum();
			int destroyPendingNum = this.DestroyPendingNum;
			while (destroyPendingNum-- > 0)
			{
				this.CheckDestroyEntity();
				this.CheckDestroyActor();
			}
		}
	}

	// Token: 0x0601B822 RID: 112674 RVA: 0x00879FEC File Offset: 0x008781EC
	private void UpdateDestroyPendingNum()
	{
		int num = Info.Instance.IsLowMemoryDevice ? 50 : 100;
		if (CreatureModel.Instance.PendingRemoveEntitySize() > num)
		{
			this.DestroyPendingNum++;
		}
		else
		{
			this.DestroyPendingNum--;
		}
		if (this.DestroyPendingNum < 1)
		{
			this.DestroyPendingNum = 1;
		}
	}

	// Token: 0x0601B823 RID: 112675 RVA: 0x0087A048 File Offset: 0x00878248
	private bool UpdateRemoveInterval()
	{
		this.CurrentFrameInterval++;
		if (!Info.Instance.IsLowMemoryDevice && CreatureModel.Instance.PendingRemoveEntitySize() < 100 && (PlayerVelocityController.Instance.IsHighSpeedMode() || PlayerSoarMonitorController.Instance.IsPlayerSoar))
		{
			this.RemoveInterval = 10;
		}
		else
		{
			this.RemoveInterval = 0;
		}
		return this.CurrentFrameInterval >= this.RemoveInterval;
	}

	// Token: 0x0601B824 RID: 112676 RVA: 0x0087A0B8 File Offset: 0x008782B8
	private void DoTickFrameEnd(float deltaTime)
	{
		if (!this.EnableWorldOriginTickCheck)
		{
			return;
		}
		if (Global.BaseCharacter != null)
		{
			FVectorDouble fvectorDouble = Global.BaseCharacter.D_K2_GetActorLocation();
			this.FixWorldOriginTickCheck(fvectorDouble);
		}
	}

	// Token: 0x0601B825 RID: 112677 RVA: 0x0087A0E8 File Offset: 0x008782E8
	private void CheckDestroyEntity()
	{
		CreatureModel instance = CreatureModel.Instance;
		if (instance.PendingRemoveEntitySize() == 0)
		{
			return;
		}
		if (!instance.PeekPendingRemoveEntity().AllowDestroy)
		{
			return;
		}
		this.DestroyEntity(instance.PopPendingRemoveEntity());
	}

	// Token: 0x0601B826 RID: 112678 RVA: 0x0087A120 File Offset: 0x00878320
	[NullableContext(2)]
	private unsafe void DestroyEntity(EntityHandle handle)
	{
		if (handle == null)
		{
			Log.Instance.Error(ELogModule.Entity, ELogAuthor.LFJW, "[WorldController.DestroyEntity] handle参数无效", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (!handle.Valid)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "[WorldController.DestroyEntity] 重复删除Entity";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CreatureDataId", handle.CreatureDataId);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		bool flag = AttachToActorController.Instance.DetachActorsBeforeDestroyEntity(handle);
		BaseActorComponent component = handle.Entity.GetComponent<BaseActorComponent>();
		AActor actor = (component != null) ? component.Owner : null;
		long creatureDataId = handle.Entity.GetComponent<CreatureDataComponent>().GetCreatureDataId();
		bool flag2 = WorldEntityHelper.Instance.Destroy(handle);
		bool flag3 = AttachToActorController.Instance.DetachActorsAfterDestroyEntity(handle.Id);
		if (flag2)
		{
			WorldModel.Instance.AddDestroyActor(creatureDataId, handle.Id, actor);
		}
		else
		{
			this.DestroyEntityActor(creatureDataId, handle.Id, actor, false);
		}
		if (CreatureController.Instance.CheckEnableEntityLog(new OneOf<EEntityType, EntityHandle>?(handle)))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Entity;
			ELogAuthor author2 = ELogAuthor.LFJW;
			string message2 = "[实体生命周期:删除实体] DestroyEntity结束";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CreatureDataId", creatureDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EntityId", handle.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("EntitySystem.DestroyEntity结果", flag2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("BeforDetachActors", flag);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("AfterDetachActors", flag3);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
		}
	}

	// Token: 0x0601B827 RID: 112679 RVA: 0x0087A2D4 File Offset: 0x008784D4
	private void CheckDestroyActor()
	{
		WorldModel instance = WorldModel.Instance;
		if (instance.DestroyActorQueue.Size == 0)
		{
			return;
		}
		ValueTuple<long, int, AActor>? valueTuple = instance.PopDestroyActor();
		UWorld world = GlobalData.World;
		if (world == null || !world.IsValid())
		{
			return;
		}
		WorldModel.Instance.RemoveIgnore(valueTuple.Value.Item3);
		this.DestroyEntityActor(valueTuple.Value.Item1, valueTuple.Value.Item2, valueTuple.Value.Item3, true);
	}

	// Token: 0x0601B828 RID: 112680 RVA: 0x0087A358 File Offset: 0x00878558
	public void DoLeaveLevel()
	{
		UWorld world = GlobalData.World;
		if (world == null || !world.IsValid())
		{
			return;
		}
		CreatureModel instance = CreatureModel.Instance;
		while (instance.PendingRemoveEntitySize() > 0)
		{
			this.DestroyEntity(instance.PopPendingRemoveEntity());
		}
		WorldModel instance2 = WorldModel.Instance;
		while (instance2.DestroyActorQueue.Size != 0)
		{
			ValueTuple<long, int, AActor>? valueTuple = instance2.PopDestroyActor();
			this.DestroyEntityActor(valueTuple.Value.Item1, valueTuple.Value.Item2, valueTuple.Value.Item3, true);
		}
		instance2.ClearIgnore();
	}

	// Token: 0x0601B829 RID: 112681 RVA: 0x0087A3E7 File Offset: 0x008785E7
	public void SetActorDataByCreature(CreatureDataComponent creatureData, [Nullable(2)] AActor actor)
	{
		this.SetEntityRole(creatureData);
		this.SetActorGravityDirection(creatureData, actor);
		this.SetActorLocationAndRotation(creatureData, actor);
		this.SetActorTags(creatureData, actor);
	}

	// Token: 0x0601B82A RID: 112682 RVA: 0x0087A408 File Offset: 0x00878608
	private void SetEntityRole(CreatureDataComponent creatureData)
	{
		Entity entity = creatureData.Entity;
		EEntityType entityType = creatureData.GetEntityType();
		if ((entityType == EEntityType.Monster || entityType == EEntityType.Vehicle) && entity.GetComponent<FollowShooterComponent>() == null)
		{
			return;
		}
		bool flag = creatureData.GetPlayerId() == CreatureModel.Instance.GetPlayerId() || entityType == EEntityType.Npc;
		SceneItemMovementSyncComponent component = entity.GetComponent<SceneItemMovementSyncComponent>();
		bool value = (component != null) ? component.HasMoveAuthority() : flag;
		entity.GetComponent<BaseActorComponent>().SetAutonomous(flag, new bool?(value));
	}

	// Token: 0x0601B82B RID: 112683 RVA: 0x0087A478 File Offset: 0x00878678
	public void SetActorGravityDirection(CreatureDataComponent creatureData, [Nullable(2)] AActor actor)
	{
		if (actor == null)
		{
			return;
		}
		Aki.Protocol.Vector initGravityDirection = creatureData.GetInitGravityDirection();
		if (initGravityDirection != null)
		{
			EntityHandle entityByActor = ActorUtils.GetEntityByActor(actor, true);
			WorldEntity worldEntity = (entityByActor != null) ? entityByActor.Entity : null;
			VehicleGravityComponent vehicleGravityComponent = (worldEntity != null) ? worldEntity.GetComponent<VehicleGravityComponent>() : null;
			if (vehicleGravityComponent != null)
			{
				vehicleGravityComponent.SetGravityDirectForVehicle(0, initGravityDirection, false, -1f, false);
				return;
			}
			BaseGravityComponent baseGravityComponent = (worldEntity != null) ? worldEntity.GetComponent<BaseGravityComponent>() : null;
			if (baseGravityComponent == null)
			{
				return;
			}
			baseGravityComponent.SetGravityByPriority(0, initGravityDirection, true, -1f, false);
		}
	}

	// Token: 0x0601B82C RID: 112684 RVA: 0x0087A4E8 File Offset: 0x008786E8
	public void SetActorLocationAndRotation(CreatureDataComponent creatureData, [Nullable(2)] AActor actor)
	{
		if (actor == null)
		{
			return;
		}
		FVectorDouble location = creatureData.GetLocation();
		FRotator rotation = creatureData.GetRotation();
		actor.D_K2_SetActorLocationAndRotation(location, rotation, false, ref WorldGlobal.SweepHitResult, true);
		FVector fvector = UKismetMathLibrary.Conv_VectorDoubleToVector(location);
		EntityHandle entityByActor = ActorUtils.GetEntityByActor(actor, true);
		bool flag;
		if (entityByActor == null)
		{
			flag = (null != null);
		}
		else
		{
			WorldEntity entity = entityByActor.Entity;
			if (entity == null)
			{
				flag = (null != null);
			}
			else
			{
				CharacterMoveComponent component = entity.GetComponent<CharacterMoveComponent>();
				flag = (((component != null) ? component.CharacterMovement : null) != null);
			}
		}
		if (flag)
		{
			FVector zeroVector = global::Vector.ZeroVector;
			FVector zeroVector2 = global::Vector.ZeroVector;
			ActorUtils.GetEntityByActor(actor, true).Entity.GetComponent<CharacterMoveComponent>().CharacterMovement.AddReplayData(ref fvector, ref rotation, ref zeroVector, ref zeroVector2, 0, 0f);
		}
	}

	// Token: 0x0601B82D RID: 112685 RVA: 0x0087A584 File Offset: 0x00878784
	private void SetActorTags(CreatureDataComponent creatureData, [Nullable(2)] AActor actor)
	{
		if (actor == null)
		{
			return;
		}
		List<string> publicTags = creatureData.GetPublicTags();
		if (publicTags != null)
		{
			foreach (string key in publicTags)
			{
				FName? dynamicFName = FNameUtil.GetDynamicFName(key);
				actor.Tags.Add(dynamicFName.Value);
			}
		}
	}

	// Token: 0x0601B82E RID: 112686 RVA: 0x0087A5F0 File Offset: 0x008787F0
	[NullableContext(2)]
	public unsafe bool DestroyEntityActor(long creatureDataId, int entityId, AActor actor, bool useActorSystem = true)
	{
		bool flag = this.DestroyActor(actor, creatureDataId, entityId, useActorSystem);
		if (CreatureModel.Instance.EnableEntityLog)
		{
			bool flag2 = AttachToActorController.Instance.CheckAttachError(entityId);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "[实体生命周期:删除实体] 删除实体Actor";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CreatureDataId", creatureDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EntityId", entityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Result", flag);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("AttachSuccess", flag2);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}
		return flag;
	}

	// Token: 0x0601B82F RID: 112687 RVA: 0x0087A6BC File Offset: 0x008788BC
	[NullableContext(2)]
	public bool DestroyActor(AActor actor, long creatureDataId, int entityId, bool useActorSystem = true)
	{
		AActor actor2 = actor;
		if (actor2 == null || !actor2.IsValid())
		{
			return false;
		}
		UWorld world = actor.GetWorld();
		if (world == null || !world.IsValid())
		{
			return false;
		}
		AController acontroller = null;
		APawn apawn = actor as APawn;
		if (apawn != null)
		{
			acontroller = apawn.Controller;
		}
		this.DestroyActorList.Clear();
		this.GetAttachedActors(actor, this.DestroyActorList, true);
		for (;;)
		{
			AActor destroyActor;
			if (!this.DestroyActorList.TryPop(out destroyActor))
			{
				break;
			}
			AActor destroyActor2 = destroyActor;
			if (destroyActor2 != null && destroyActor2.IsValid())
			{
				UWorld world2 = destroyActor.GetWorld();
				if (world2 != null && world2.IsValid() && destroyActor != acontroller)
				{
					AttachToActorModel.Instance.GetEntityIdByActor(destroyActor);
				}
			}
		}
		if (useActorSystem)
		{
			ActorSystem instance = ActorSystem.Instance;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 1);
			defaultInterpolatedStringHandler.AppendLiteral("WorldController.DestroyActor ");
			defaultInterpolatedStringHandler.AppendFormatted<long>(creatureDataId);
			instance.Put(defaultInterpolatedStringHandler.ToStringAndClear(), actor, null);
		}
		else
		{
			actor.K2_DestroyActor();
		}
		return true;
	}

	// Token: 0x0601B830 RID: 112688 RVA: 0x0087A810 File Offset: 0x00878A10
	private void GetAttachedActors([Nullable(2)] AActor actor, List<AActor> outActors, bool ignore)
	{
		if (actor == null || !actor.IsValid())
		{
			return;
		}
		if (!ignore)
		{
			outActors.Add(actor);
		}
		TArray<AActor> tarray = new TArray<AActor>();
		actor.GetAttachedActors(ref tarray, true);
		for (int i = 0; i < tarray.Num(); i++)
		{
			this.GetAttachedActors(tarray.Get(i), outActors, false);
		}
	}

	// Token: 0x0601B831 RID: 112689 RVA: 0x0087A868 File Offset: 0x00878A68
	public FName? EnvironmentInfoUpdate(FVectorDouble location, bool isRole, bool isTeleport = false)
	{
		if (!WorldModel.Instance.IsEnableEnvironmentDetecting || !isRole)
		{
			return null;
		}
		if (!GameModeModel.Instance.UseWorldPartition)
		{
			return null;
		}
		UWorld world = GlobalData.World;
		if (world == null || !world.IsValid())
		{
			return null;
		}
		FKuroVoxelInfo fkuroVoxelInfo = new FKuroVoxelInfo();
		int num = 0;
		VoxelUtils.TryGetVoxelInfo(world, location, ref fkuroVoxelInfo, ref num, -1f);
		FKuroVoxelInfo info = fkuroVoxelInfo;
		bool flag = WorldModel.Instance.HandleEnvironmentUpdate(info);
		if (isTeleport || flag)
		{
			return this.ApplyEnvironmentInfo(world, location, isTeleport);
		}
		return null;
	}

	// Token: 0x0601B832 RID: 112690 RVA: 0x0087A90C File Offset: 0x00878B0C
	public void ChangeCaveOrRoomDatalayer(UObject world, FName? dataLayer, FName? subDataLayer, bool isEnter)
	{
		if (isEnter)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.SetWorldPartitionDataLayerState(world, dataLayer ?? FName.NAME_None, true);
			UKuroRenderingRuntimeBPPluginBPLibrary.SetWorldPartitionDataLayerState(world, subDataLayer ?? FName.NAME_None, false);
			return;
		}
		UKuroRenderingRuntimeBPPluginBPLibrary.SetWorldPartitionDataLayerState(world, dataLayer ?? FName.NAME_None, false);
		UKuroRenderingRuntimeBPPluginBPLibrary.SetWorldPartitionDataLayerState(world, subDataLayer ?? FName.NAME_None, true);
	}

	// Token: 0x0601B833 RID: 112691 RVA: 0x0087A9A0 File Offset: 0x00878BA0
	private unsafe FName? ApplyEnvironmentInfo(UObject world, FVectorDouble location, bool isTeleport)
	{
		EStreamingHandleType estreamingHandleType = WorldModel.Instance.ApplyEnvironmentUpdate();
		if (estreamingHandleType == EStreamingHandleType.DoNothing)
		{
			return null;
		}
		FName value = FNameUtil.GetDynamicFName(WorldModel.Instance.CurEnvironmentInfo.DataLayerType.ToEnumString()).Value;
		FName value2 = FNameUtil.GetDynamicFName(WorldModel.Instance.CurEnvironmentInfo.SubDataLayerType.ToEnumString()).Value;
		EventSystem.Instance.Emit<EStreamingHandleType>(EEventName.OnEncloseSpaceTypeChange, estreamingHandleType);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.LevelEvent;
		ELogAuthor author = ELogAuthor.XY;
		string message = "[WorldController]Streaming:体素参数";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("DataLayer", value);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SubDatalayer", value2);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		switch (estreamingHandleType)
		{
		case EStreamingHandleType.EnterEncloseSpace:
			this.ChangeCaveOrRoomDatalayer(world, new FName?(value), new FName?(value2), true);
			Log.Instance.Info(ELogModule.LevelEvent, ELogAuthor.YZH, "[WorldController]Streaming:进入封闭空间", default(ReadOnlySpan<ValueTuple<string, object>>));
			UKuroGameBudgetAllocatorCSharpInterface.SetGlobalCavernMode(EActorCavernMode.ActorCavernMode_IntermediateZone);
			return new FName?(value);
		case EStreamingHandleType.ExitEncloseSpace:
			UKuroRenderingRuntimeBPPluginBPLibrary.SetIsUsingInCaveOrIndoorShadow(world, false, 20000f, 8000f);
			UKuroGameBudgetAllocatorCSharpInterface.SetGlobalCavernMode(EActorCavernMode.ActorCavernMode_IntermediateZone);
			EventSystem.Instance.Emit<bool>(EEventName.OnOverlapEncloseSpace, false);
			Log.Instance.Info(ELogModule.LevelEvent, ELogAuthor.YZH, "[WorldController]Streaming:退出封闭空间", default(ReadOnlySpan<ValueTuple<string, object>>));
			break;
		case EStreamingHandleType.FinishEnterEncloseSpace:
			UKuroRenderingRuntimeBPPluginBPLibrary.SetIsUsingInCaveOrIndoorShadow(world, true, 20000f, 8000f);
			Log.Instance.Info(ELogModule.LevelEvent, ELogAuthor.YZH, "[WorldController]Streaming:完成进入封闭空间", default(ReadOnlySpan<ValueTuple<string, object>>));
			UKuroGameBudgetAllocatorCSharpInterface.SetGlobalCavernMode(EActorCavernMode.ActorCavernMode_Inside);
			EventSystem.Instance.Emit<bool>(EEventName.OnOverlapEncloseSpace, true);
			break;
		case EStreamingHandleType.FinishExitEncloseSpace:
			UKuroGameBudgetAllocatorCSharpInterface.SetGlobalCavernMode(EActorCavernMode.ActorCavernMode_Outside);
			this.ChangeCaveOrRoomDatalayer(world, new FName?(value), new FName?(value2), false);
			Log.Instance.Info(ELogModule.LevelEvent, ELogAuthor.YZH, "[WorldController]Streaming:完成退出封闭空间", default(ReadOnlySpan<ValueTuple<string, object>>));
			break;
		case EStreamingHandleType.ImmediateEnter:
			this.ChangeCaveOrRoomDatalayer(world, new FName?(value), new FName?(value2), true);
			UKuroRenderingRuntimeBPPluginBPLibrary.SetIsUsingInCaveOrIndoorShadow(world, true, 20000f, 8000f);
			EventSystem.Instance.Emit<bool>(EEventName.OnOverlapEncloseSpace, true);
			UKuroGameBudgetAllocatorCSharpInterface.SetGlobalCavernMode(EActorCavernMode.ActorCavernMode_Inside);
			if (!isTeleport)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.LevelEvent;
				ELogAuthor author2 = ELogAuthor.YZH;
				string message2 = "[WorldController]Streaming:非传送下,无过渡区域进入封闭空间";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Location", location);
				instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.RequestToNearestTeleport();
			}
			else
			{
				Log.Instance.Info(ELogModule.LevelEvent, ELogAuthor.YZH, "[WorldController]Streaming:进入封闭空间[传送]", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return new FName?(value);
		case EStreamingHandleType.ImmediateExit:
			this.ChangeCaveOrRoomDatalayer(world, new FName?(value), new FName?(value2), false);
			EventSystem.Instance.Emit<bool>(EEventName.OnOverlapEncloseSpace, false);
			UKuroGameBudgetAllocatorCSharpInterface.SetGlobalCavernMode(EActorCavernMode.ActorCavernMode_Outside);
			if (!isTeleport)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.LevelEvent;
				ELogAuthor author3 = ELogAuthor.YZH;
				string message3 = "[WorldController]Streaming:非传送下,无过渡区域退出封闭空间";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Location", location);
				instance3.Warn(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				this.RequestToNearestTeleport();
			}
			else
			{
				Log.Instance.Info(ELogModule.LevelEvent, ELogAuthor.YZH, "[WorldController]Streaming:退出封闭空间[传送]", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			UKuroRenderingRuntimeBPPluginBPLibrary.SetIsUsingInCaveOrIndoorShadow(world, false, 20000f, 8000f);
			break;
		}
		return null;
	}

	// Token: 0x0601B834 RID: 112692 RVA: 0x0087ACD0 File Offset: 0x00878ED0
	public bool IsEncloseSpace(int pbDataId, FVectorDouble location, EEntityType entityType, EntityConfigType entityConfigType, bool isSummonsAndCtrlByMe = false)
	{
		if (!GameModeModel.Instance.UseWorldPartition || pbDataId == 0)
		{
			return false;
		}
		UWorld world = GlobalData.World;
		if (world == null || !world.IsValid())
		{
			return false;
		}
		if (entityType == EEntityType.Player || entityType == EEntityType.Vision || isSummonsAndCtrlByMe)
		{
			return false;
		}
		EntityVoxelInfo? entityVoxelInfo = null;
		if (entityConfigType == EntityConfigType.Level)
		{
			entityVoxelInfo = ConfigEntityVoxelInfoByMapIdAndEntityId.GetConfig(GameModeModel.Instance.MapId, pbDataId, true);
		}
		if (entityVoxelInfo == null)
		{
			int num = 0;
			byte envType = VoxelUtils.GetVoxelInfo(world, location, ref num, -1f).EnvType;
			return envType <= 1 || (envType != byte.MaxValue && false);
		}
		int envType2 = entityVoxelInfo.Value.EnvType;
		return envType2 <= 1 || (envType2 != 255 && false);
	}

	// Token: 0x0601B835 RID: 112693 RVA: 0x0087AD91 File Offset: 0x00878F91
	public void RequestToNearestTeleport()
	{
		Net.Instance.Call(ERequestMessageId.UnOpenedAreaPullbackRequest, UnOpenedAreaPullbackRequest.Create(), delegate(IMessage msg, Net.CallbackStatus _)
		{
			UnOpenedAreaPullbackResponse unOpenedAreaPullbackResponse = (UnOpenedAreaPullbackResponse)msg;
			if (unOpenedAreaPullbackResponse.ErrorCode == Aki.Protocol.ErrorCode.ErrPlayerIsTeleportCanNotDoTeleport)
			{
				return;
			}
			if (unOpenedAreaPullbackResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(unOpenedAreaPullbackResponse.ErrorCode, 23277, null, true, true);
			}
		}, 0);
	}

	// Token: 0x0601B836 RID: 112694 RVA: 0x0087ADC7 File Offset: 0x00878FC7
	private void OnLeaveOnlineWorld()
	{
		UKuroGameBudgetAllocatorCSharpInterface.ClearAssistantActors();
	}

	// Token: 0x0601B837 RID: 112695 RVA: 0x0087ADD0 File Offset: 0x00878FD0
	private void OnFormationChange()
	{
		if (!GameModeModel.Instance.IsMulti)
		{
			return;
		}
		UKuroGameBudgetAllocatorCSharpInterface.ClearAssistantActors();
		foreach (SceneTeamItem sceneTeamItem in SceneTeamModel.Instance.GetTeamItems(false))
		{
			if (!sceneTeamItem.IsMyRole())
			{
				EntityHandle entityHandle = sceneTeamItem.EntityHandle;
				TsBaseCharacter tsBaseCharacter;
				if (entityHandle == null)
				{
					tsBaseCharacter = null;
				}
				else
				{
					WorldEntity entity = entityHandle.Entity;
					if (entity == null)
					{
						tsBaseCharacter = null;
					}
					else
					{
						CharacterActorComponent component = entity.GetComponent<CharacterActorComponent>();
						tsBaseCharacter = ((component != null) ? component.Actor : null);
					}
				}
				TsBaseCharacter tsBaseCharacter2 = tsBaseCharacter;
				if (tsBaseCharacter2 != null)
				{
					UKuroGameBudgetAllocatorCSharpInterface.AddAssistantActor(tsBaseCharacter2);
				}
			}
		}
	}

	// Token: 0x0601B838 RID: 112696 RVA: 0x0087AE70 File Offset: 0x00879070
	public unsafe void GetEntitiesInRangeWithLocation(FVectorDouble location, float distance, EEntityTypeQuery entityType, ICollection<EntityHandle> result, bool bResetArray)
	{
		if (bResetArray)
		{
			result.Clear();
		}
		CharacterModel instance = CharacterModel.Instance;
		for (int i = 0; i < 9; i++)
		{
			if ((entityType & (EEntityTypeQuery)(1 << i)) != (EEntityTypeQuery)0)
			{
				IntPtr[] array = Array.Empty<IntPtr>();
				FKuroGameBudgetAllocatorCSharpInterface.GetEntitiesInRangeWithLocation(location, distance, EntityHelperConstants.GlobalEntityTypeQueryName[i], ref array);
				Span<IntPtr> span = array.AsSpan<IntPtr>();
				for (int j = 0; j < span.Length; j++)
				{
					IntPtr intPtr = *span[j];
					if (intPtr != IntPtr.Zero)
					{
						Entity entity = GCHandle.FromIntPtr(intPtr).Target as Entity;
						if (entity != null)
						{
							EntityHandle handleByEntity = instance.GetHandleByEntity(entity);
							if (handleByEntity != null)
							{
								result.Add(handleByEntity);
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0601B839 RID: 112697 RVA: 0x0087AF2C File Offset: 0x0087912C
	public void GetEntitiesInRange(float distance, EEntityTypeQuery entityType, ICollection<EntityHandle> result, bool bResetArray, bool bContainPlayer)
	{
		if (bResetArray)
		{
			result.Clear();
		}
		List<Entity> list = new List<Entity>();
		uint num = 0U;
		EPerceptionEntityType[] globalEntityTypePerceptionType = CreatureModel.globalEntityTypePerceptionType;
		for (int i = 0; i < 9; i++)
		{
			if ((entityType & (EEntityTypeQuery)(1 << i)) != (EEntityTypeQuery)0 && i < globalEntityTypePerceptionType.Length)
			{
				EPerceptionEntityType eperceptionEntityType = globalEntityTypePerceptionType[i];
				if (eperceptionEntityType != EPerceptionEntityType.Player)
				{
					num |= (uint)eperceptionEntityType;
				}
			}
		}
		if ((entityType & EEntityTypeQuery.Team) > (EEntityTypeQuery)0 && bContainPlayer)
		{
			List<Entity> list2 = new List<Entity>();
			IntPtr[] array = Array.Empty<IntPtr>();
			FKuroGameBudgetAllocatorCSharpInterface.GetAllPlayerEntities(ref array);
			foreach (IntPtr intPtr in array)
			{
				if (intPtr != IntPtr.Zero)
				{
					Entity entity = GCHandle.FromIntPtr(intPtr).Target as Entity;
					if (entity != null)
					{
						list2.Add(entity);
					}
				}
			}
			foreach (Entity entity2 in list2)
			{
				EntityHandle handleByEntity = CharacterModel.Instance.GetHandleByEntity(entity2);
				if (handleByEntity != null)
				{
					result.Add(handleByEntity);
				}
			}
		}
		IntPtr[] array2 = Array.Empty<IntPtr>();
		FKuroPerceptionCSharpInterface.GetEntitiesInPlayerPerceptionRange(distance, num, ref array2);
		foreach (IntPtr intPtr2 in array2)
		{
			if (intPtr2 != IntPtr.Zero)
			{
				Entity entity3 = GCHandle.FromIntPtr(intPtr2).Target as Entity;
				if (entity3 != null)
				{
					list.Add(entity3);
				}
			}
		}
		foreach (Entity entity4 in list)
		{
			EntityHandle handleByEntity2 = CharacterModel.Instance.GetHandleByEntity(entity4);
			if (handleByEntity2 != null)
			{
				result.Add(handleByEntity2);
			}
		}
	}

	// Token: 0x0601B83A RID: 112698 RVA: 0x0087B0EC File Offset: 0x008792EC
	public int GetCustomEntityId(int ownerEntityId, int pos)
	{
		Entity entity = EntitySystem.Instance.Get(ownerEntityId);
		if (entity != null)
		{
			EntityHandle summonedEntity = PhantomUtil.GetSummonedEntity(entity, ESummonType.ConcomitantCustom, pos);
			if (summonedEntity != null)
			{
				return summonedEntity.Id;
			}
		}
		else
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.YZ;
			string message = "无法找到伴生物拥有者实体";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ownerEntityId", ownerEntityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return 0;
	}

	// Token: 0x0601B83B RID: 112699 RVA: 0x0087B148 File Offset: 0x00879348
	public unsafe void ChangeCustomEntityState(int ownerEntityId, int pos, int skillId, int tagId)
	{
		Entity entity = EntitySystem.Instance.Get(ownerEntityId);
		if (entity == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.LYY;
			string message = "无法找到伴生物拥有者实体";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ownerEntityId", ownerEntityId);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		EntityHandle summonedEntity = PhantomUtil.GetSummonedEntity(entity, ESummonType.ConcomitantCustom, pos);
		if (summonedEntity == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Battle;
			ELogAuthor author2 = ELogAuthor.LYY;
			string message2 = "无法找到伴生物";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ownerEntityId", ownerEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("pos", pos);
			instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		BaseSkillComponent component = entity.GetComponent<BaseSkillComponent>();
		long? num;
		if (component == null)
		{
			num = null;
		}
		else
		{
			global::Skill skill = component.GetSkill(skillId);
			num = ((skill != null) ? skill.CombatMessageId : null);
		}
		long? preMessageId = num;
		ChangeSummonEntityStateRequest changeSummonEntityStateRequest = new ChangeSummonEntityStateRequest();
		changeSummonEntityStateRequest.SummonEntityId = summonedEntity.CreatureDataId;
		changeSummonEntityStateRequest.TagId = tagId;
		CombatNet.Instance.Call(ERequestMessageId.ChangeSummonEntityStateRequest, entity, changeSummonEntityStateRequest, delegate(IMessage msg)
		{
			ChangeSummonEntityStateResponse changeSummonEntityStateResponse = (ChangeSummonEntityStateResponse)msg;
			if (changeSummonEntityStateResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.SceneTeam;
				ELogAuthor author3 = ELogAuthor.LYY;
				string message3 = "请求切换机关伴生物状态失败";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("ErrorCode", changeSummonEntityStateResponse.ErrorCode);
				instance3.Warn(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}
		}, preMessageId, null, null, null);
	}

	// Token: 0x0601B83C RID: 112700 RVA: 0x0087B298 File Offset: 0x00879498
	public UniTask StartWorldOriginInUiMode()
	{
		WorldController.<StartWorldOriginInUiMode>d__87 <StartWorldOriginInUiMode>d__;
		<StartWorldOriginInUiMode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<StartWorldOriginInUiMode>d__.<>4__this = this;
		<StartWorldOriginInUiMode>d__.<>1__state = -1;
		<StartWorldOriginInUiMode>d__.<>t__builder.Start<WorldController.<StartWorldOriginInUiMode>d__87>(ref <StartWorldOriginInUiMode>d__);
		return <StartWorldOriginInUiMode>d__.<>t__builder.Task;
	}

	// Token: 0x0601B83D RID: 112701 RVA: 0x0087B2DC File Offset: 0x008794DC
	public UniTask EndWorldOriginInUiMode()
	{
		WorldController.<EndWorldOriginInUiMode>d__88 <EndWorldOriginInUiMode>d__;
		<EndWorldOriginInUiMode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<EndWorldOriginInUiMode>d__.<>4__this = this;
		<EndWorldOriginInUiMode>d__.<>1__state = -1;
		<EndWorldOriginInUiMode>d__.<>t__builder.Start<WorldController.<EndWorldOriginInUiMode>d__88>(ref <EndWorldOriginInUiMode>d__);
		return <EndWorldOriginInUiMode>d__.<>t__builder.Task;
	}

	// Token: 0x0601B83E RID: 112702 RVA: 0x0087B31F File Offset: 0x0087951F
	public bool GetIsWorldOriginInUiMode()
	{
		return this.IsWorldOriginInUiMode;
	}

	// Token: 0x0601B83F RID: 112703 RVA: 0x0087B328 File Offset: 0x00879528
	public void StartWorldOriginInLoadingMode(string reason)
	{
		if (!this.IsWorldOriginInLoadingMode)
		{
			this.IsWorldOriginInLoadingMode = true;
			return;
		}
		Log.Instance.Error(ELogModule.World, ELogAuthor.ZWY, "IsWorldOriginInLoadingMode 开关不成对", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x0601B840 RID: 112704 RVA: 0x0087B364 File Offset: 0x00879564
	public void EndWorldOriginInLoadingMode(string reason, in FVectorDouble origin)
	{
		if (this.IsWorldOriginInLoadingMode)
		{
			if (this.IsWorldOriginInUiMode)
			{
				this.CacheWorldOrigin.DeepCopy(origin);
			}
			else
			{
				this.FixWorldOrigin(reason, origin);
			}
			this.IsWorldOriginInLoadingMode = false;
			return;
		}
		Log.Instance.Error(ELogModule.World, ELogAuthor.ZWY, "IsWorldOriginInLoadingMode 开关不成对", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x0601B841 RID: 112705 RVA: 0x0087B3BC File Offset: 0x008795BC
	public void SetEnableWorldOriginTickCheck(string reason, bool enableCheck)
	{
		if (this.EnableWorldOriginTickCheck == enableCheck)
		{
			Log.Instance.Warn(ELogModule.World, ELogAuthor.ZWY, "SetEnableWorldOriginTickCheck 调用不成对", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.EnableWorldOriginTickCheck = enableCheck;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.World;
		ELogAuthor author = ELogAuthor.ZWY;
		string message = "SetEnableWorldOriginTickCheck";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("reason", reason);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0601B842 RID: 112706 RVA: 0x0087B420 File Offset: 0x00879620
	public void SetEnableWorldOrigin(bool enableWorldOrigin)
	{
		this.EnableWorldOrigin = enableWorldOrigin;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.World;
		ELogAuthor author = ELogAuthor.ZWY;
		string message = "EnableWorldOrigin";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EnableWorldOrigin", enableWorldOrigin);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0601B843 RID: 112707 RVA: 0x0087B460 File Offset: 0x00879660
	public unsafe void SetEnableWorldOriginForPlot(bool enable, string reason)
	{
		FVectorDouble fvectorDouble = enable ? Global.BaseCharacter.D_K2_GetActorLocation() : FVectorDouble.ZeroVector;
		if (enable)
		{
			this.SetEnableWorldOrigin(true);
		}
		if (this.IsWorldOriginInUiMode)
		{
			this.CacheWorldOrigin.DeepCopy(fvectorDouble);
		}
		else
		{
			this.FixWorldOrigin(reason, fvectorDouble);
		}
		if (!enable)
		{
			this.SetEnableWorldOrigin(false);
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.World;
		ELogAuthor author = ELogAuthor.HYF;
		string message = "剧情临时世界偏移";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("enable", enable);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("reason", reason);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
	}

	// Token: 0x0601B844 RID: 112708 RVA: 0x0087B50E File Offset: 0x0087970E
	public void FixWorldOriginTickCheck(in FVectorDouble origin)
	{
		if (this.IsAllWorldOriginConditionEnable() && this.IsCheckFixWorldOriginPass(origin))
		{
			this.FixWorldOrigin("Tick", origin);
		}
	}

	// Token: 0x0601B845 RID: 112709 RVA: 0x0087B52D File Offset: 0x0087972D
	public bool FixWorldOriginGm(in FVectorDouble origin)
	{
		if (this.IsAllWorldOriginConditionEnable())
		{
			this.FixWorldOrigin("GM", origin);
			return true;
		}
		return false;
	}

	// Token: 0x0601B846 RID: 112710 RVA: 0x0087B548 File Offset: 0x00879748
	private bool IsWorldOriginFinish()
	{
		if (GlobalData.World == null)
		{
			Log.Instance.Info(ELogModule.World, ELogAuthor.ZWY, "IsWorldOriginFinish false No World", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		if (UKuroRenderingRuntimeBPPluginBPLibrary.IsWorldOriginFinish(GlobalData.World))
		{
			return true;
		}
		Log.Instance.Info(ELogModule.World, ELogAuthor.ZWY, "IsWorldOriginFinish false", default(ReadOnlySpan<ValueTuple<string, object>>));
		return false;
	}

	// Token: 0x0601B847 RID: 112711 RVA: 0x0087B5A5 File Offset: 0x008797A5
	private bool IsAllWorldOriginConditionEnable()
	{
		return !this.IsWorldOriginInUiMode && !this.IsWorldOriginInLoadingMode;
	}

	// Token: 0x0601B848 RID: 112712 RVA: 0x0087B5BC File Offset: 0x008797BC
	private bool IsCheckFixWorldOriginPass(in FVectorDouble origin)
	{
		this.CheckRateInternal++;
		if (this.CheckRateInternal < this.CheckRateMax)
		{
			return false;
		}
		this.CheckRateInternal = 0;
		if (Math.Abs(origin.X - this.WorldOriginValue.X) < (double)this.OriginNeedChangeMax && Math.Abs(origin.Y - this.WorldOriginValue.Y) < (double)this.OriginNeedChangeMax && Math.Abs(origin.Z - this.WorldOriginValue.Z) < (double)this.OriginNeedChangeMax)
		{
			return false;
		}
		if (this.LastSetWorldOriginFrame == Time.Instance.Frame)
		{
			return false;
		}
		if (PlotModel.Instance.IsInPlot)
		{
			return false;
		}
		if (!UiManager.Instance.IsViewOpen(EUiViewName.BattleView))
		{
			return false;
		}
		if (FormationDataController.Instance.GlobalIsInFight)
		{
			return false;
		}
		int entityIdNoBlueprint = Global.BaseCharacter.GetEntityIdNoBlueprint();
		Entity entity = EntitySystem.Instance.Get(entityIdNoBlueprint);
		BaseTagComponent baseTagComponent = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
		return baseTagComponent != null && !baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中"]) && !baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.控物.控物中"]) && !baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.攀爬"]);
	}

	// Token: 0x0601B849 RID: 112713 RVA: 0x0087B708 File Offset: 0x00879908
	public unsafe void SetEnableZAxisOffset(bool enable, string reason)
	{
		if (this.EnableZAxisOffset == enable)
		{
			return;
		}
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		if (baseCharacter != null)
		{
			this.EnableZAxisOffset = enable;
			FVectorDouble fvectorDouble = baseCharacter.D_K2_GetActorLocation();
			this.FixWorldOrigin(reason, fvectorDouble);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.World;
			ELogAuthor author = ELogAuthor.LC;
			string message = "SetEnableZAxisOffset";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("enable", enable);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("reason", reason);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
	}

	// Token: 0x0601B84A RID: 112714 RVA: 0x0087B798 File Offset: 0x00879998
	private unsafe void FixWorldOrigin(string reason, in FVectorDouble origin)
	{
		if (this.LastSetWorldOriginFrame != Time.Instance.Frame)
		{
			this.LastWorldOriginValue.DeepCopy(this.WorldOriginValue);
			this.LastSetWorldOriginFrame = Time.Instance.Frame;
		}
		FVectorDouble fvectorDouble = new FVectorDouble();
		fvectorDouble.X = Math.Truncate(origin.X);
		fvectorDouble.Y = Math.Truncate(origin.Y);
		fvectorDouble.Z = (this.EnableZAxisOffset ? Math.Truncate(origin.Z) : 0.0);
		this.WorldOriginValue.X = fvectorDouble.X;
		this.WorldOriginValue.Y = fvectorDouble.Y;
		this.WorldOriginValue.Z = fvectorDouble.Z;
		if (!this.EnableWorldOrigin)
		{
			Log.Instance.Info(ELogModule.World, ELogAuthor.ZWY, "SetWorldOriginIgnore", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		UKuroRenderingRuntimeBPPluginBPLibrary.SetWorldOrigin(GlobalData.World, fvectorDouble);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.World;
		ELogAuthor author = ELogAuthor.ZWY;
		string message = "SetWorldOrigin";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Origin", fvectorDouble);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("reason", reason);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		TimerSystem.GameplayTimeInstance.Next(delegate(float _)
		{
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Shadow.ForceUpdateCSMOnce 1", null);
		}, null, null);
	}

	// Token: 0x0601B84B RID: 112715 RVA: 0x0087B910 File Offset: 0x00879B10
	public void ToWorldRelativeLocation(IVector location, IVector outRelative)
	{
		if (!this.EnableWorldOrigin)
		{
			outRelative.X = location.X;
			outRelative.Y = location.Y;
			outRelative.Z = location.Z;
			return;
		}
		outRelative.X = location.X - this.WorldOriginValue.X;
		outRelative.Y = location.Y - this.WorldOriginValue.Y;
		outRelative.Z = location.Z - this.WorldOriginValue.Z;
	}

	// Token: 0x17002C88 RID: 11400
	// (get) Token: 0x0601B84C RID: 112716 RVA: 0x0087B992 File Offset: 0x00879B92
	public static WorldController Instance
	{
		get
		{
			return WorldController._Instance;
		}
	}

	// Token: 0x0601B84D RID: 112717 RVA: 0x0087B999 File Offset: 0x00879B99
	public static WorldController GetOrCreateInstance()
	{
		if (WorldController._Instance == null)
		{
			WorldController.CreateInstance();
		}
		return WorldController._Instance;
	}

	// Token: 0x0601B84E RID: 112718 RVA: 0x0087B9AD File Offset: 0x00879BAD
	public static bool CreateInstance()
	{
		if (WorldController._Instance != null)
		{
			return true;
		}
		WorldController._Instance = new WorldController();
		return true;
	}

	// Token: 0x0601B84F RID: 112719 RVA: 0x0087B9C3 File Offset: 0x00879BC3
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601B850 RID: 112720 RVA: 0x0087B9C5 File Offset: 0x00879BC5
	public static void ResetStaticDefaultValue()
	{
		WorldController._Instance = null;
	}

	// Token: 0x0601B851 RID: 112721 RVA: 0x0087B9CD File Offset: 0x00879BCD
	static WorldController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WorldController.CreateStaticDefaultValue), new Action(WorldController.ResetStaticDefaultValue));
	}

	// Token: 0x0400EDB6 RID: 60854
	private const int DELTA_TIME_LIMIT_LOW = 20;

	// Token: 0x0400EDB7 RID: 60855
	private const int DELTA_TIME_LIMIT_HIGH = 25;

	// Token: 0x0400EDB8 RID: 60856
	private const int MIN_DELTA = 0;

	// Token: 0x0400EDB9 RID: 60857
	private const int MAX_DELTA = 0;

	// Token: 0x0400EDBA RID: 60858
	private const int SCHEDULER_MINUS_FRAME_COUNT = 5;

	// Token: 0x0400EDBB RID: 60859
	private const int DEFAULT_ENVIRONMENTTYPE = 255;

	// Token: 0x0400EDBC RID: 60860
	private const int IOS_STREAMING_POOL_SIZE = 250;

	// Token: 0x0400EDBD RID: 60861
	private const int IOS_STREAMING_POOL_SIZE_FOR_MESHES = 250;

	// Token: 0x0400EDBE RID: 60862
	private const int IOS_STREAMING_POOL_SIZE_IN_LOADING = 90;

	// Token: 0x0400EDBF RID: 60863
	private const int IOS_STREAMING_POOL_SIZE_FOR_MESHES_IN_LOADING = 90;

	// Token: 0x0400EDC0 RID: 60864
	private const int HIGH_SPEED_REMOVE_INTERVAL = 10;

	// Token: 0x0400EDC1 RID: 60865
	private const int MAX_PENDING_REMOVE_COUNT = 100;

	// Token: 0x0400EDC2 RID: 60866
	private const int LOW_MEMORY_PENDING_REMOVE_COUNT = 50;

	// Token: 0x0400EDC3 RID: 60867
	private bool GlobalIsInFight;

	// Token: 0x0400EDC4 RID: 60868
	private bool LoopMapStreamingBudgetEnabled;

	// Token: 0x0400EDC5 RID: 60869
	[Nullable(2)]
	private TimerHandle MemoryGcCheckTimerId;

	// Token: 0x0400EDC6 RID: 60870
	[Nullable(2)]
	private TimerHandle VoxelCheckTimerId;

	// Token: 0x0400EDC7 RID: 60871
	private bool ShouldGcWhenBattleFinished;

	// Token: 0x0400EDC8 RID: 60872
	private EShouldGc DeviceShouldGc;

	// Token: 0x0400EDC9 RID: 60873
	private bool IsPerformanceLimitMode;

	// Token: 0x0400EDCA RID: 60874
	private int RemoveInterval;

	// Token: 0x0400EDCB RID: 60875
	private int CurrentFrameInterval;

	// Token: 0x0400EDCC RID: 60876
	private int DestroyPendingNum = 1;

	// Token: 0x0400EDCD RID: 60877
	[Nullable(2)]
	private Ticker DoTickHandle;

	// Token: 0x0400EDCE RID: 60878
	[Nullable(2)]
	private Ticker DoTickFrameEndHandle;

	// Token: 0x0400EDCF RID: 60879
	private bool EnableZAxisOffset = true;

	// Token: 0x0400EDD0 RID: 60880
	private readonly List<AActor> DestroyActorList = new List<AActor>();

	// Token: 0x0400EDD1 RID: 60881
	private readonly global::Vector WorldOriginValue = global::Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x0400EDD2 RID: 60882
	private readonly global::Vector LastWorldOriginValue = global::Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x0400EDD3 RID: 60883
	private int LastSetWorldOriginFrame;

	// Token: 0x0400EDD4 RID: 60884
	public bool EnableWorldOrigin = true;

	// Token: 0x0400EDD5 RID: 60885
	public bool EnableWorldOriginLoadingCheck = true;

	// Token: 0x0400EDD6 RID: 60886
	public bool EnableWorldOriginTickCheck = true;

	// Token: 0x0400EDD7 RID: 60887
	public int OriginNeedChangeMax = 250000;

	// Token: 0x0400EDD8 RID: 60888
	public int CheckRateMax = 30;

	// Token: 0x0400EDD9 RID: 60889
	private int CheckRateInternal;

	// Token: 0x0400EDDA RID: 60890
	private bool IsWorldOriginInUiMode;

	// Token: 0x0400EDDB RID: 60891
	private bool IsWorldOriginInLoadingMode;

	// Token: 0x0400EDDC RID: 60892
	private readonly global::Vector CacheWorldOrigin = global::Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x0400EDDD RID: 60893
	[Nullable(2)]
	private TimerHandle CheckWorldOriginFinishTimer;

	// Token: 0x0400EDDE RID: 60894
	private int CheckWorldOriginFinishTimerNum;

	// Token: 0x0400EDDF RID: 60895
	private readonly int CheckWorldOriginFinishTimerNumMax = 10;

	// Token: 0x0400EDE0 RID: 60896
	[Nullable(2)]
	private static WorldController _Instance;
}

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

// Token: 0x020034ED RID: 13549
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class WorldController : ControllerBase
{
	// Token: 0x0601DB01 RID: 121601 RVA: 0x008510D4 File Offset: 0x0084F2D4
	protected override bool OnInit()
	{
		WorldModel.Instance.CurrentSchedulerDelta = 0.0;
		if (GameBudgetInterfaceController.IsOpen)
		{
			int frameRate = GameSettingsDeviceRender.Instance.FrameRate;
			GameBudgetInterfaceController.Instance.SetMaximumFrameRate(frameRate);
		}
		PerformanceController.Instance.IsOpenCatchWorldEntity = !Info.Instance.IsBuildShipping;
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

	// Token: 0x0601DB02 RID: 121602 RVA: 0x008512EC File Offset: 0x0084F4EC
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

	// Token: 0x0601DB03 RID: 121603 RVA: 0x00851484 File Offset: 0x0084F684
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

	// Token: 0x0601DB04 RID: 121604 RVA: 0x008514DC File Offset: 0x0084F6DC
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

	// Token: 0x0601DB05 RID: 121605 RVA: 0x0085150E File Offset: 0x0084F70E
	private void OnTeleportStart(bool b)
	{
		if (this.IsPerformanceLimitMode)
		{
			this.OnPerformanceLimitModeChanged(true, true);
		}
	}

	// Token: 0x0601DB06 RID: 121606 RVA: 0x00851520 File Offset: 0x0084F720
	[NullableContext(2)]
	private void OnTeleportComplete(TeleportContext teleportContext)
	{
		if (this.IsPerformanceLimitMode)
		{
			this.OnPerformanceLimitModeChanged(true, false);
		}
	}

	// Token: 0x0601DB07 RID: 121607 RVA: 0x00851532 File Offset: 0x0084F732
	private void OnWorldDone()
	{
		WorldModel.Instance.CurEnvironmentInfo.ServerCaveMode = EActorCavernMode.ActorCavernMode_None;
	}

	// Token: 0x0601DB08 RID: 121608 RVA: 0x00851544 File Offset: 0x0084F744
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

	// Token: 0x0601DB09 RID: 121609 RVA: 0x0085159C File Offset: 0x0084F79C
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

	// Token: 0x0601DB0A RID: 121610 RVA: 0x0085160C File Offset: 0x0084F80C
	private void OnPlayerVoxelEnvCheck(float delta)
	{
		WorldModel instance = WorldModel.Instance;
		if (instance == null)
		{
			return;
		}
		instance.CurEnvironmentInfo.RequestUpdateVoxelEnv();
	}

	// Token: 0x0601DB0B RID: 121611 RVA: 0x0085162E File Offset: 0x0084F82E
	public void SetLoopMapStreamingBudgetEnabled(bool enabled)
	{
		this.LoopMapStreamingBudgetEnabled = enabled;
		this.UpdateWPLoadingStreamingCells();
	}

	// Token: 0x0601DB0C RID: 121612 RVA: 0x0085163D File Offset: 0x0084F83D
	private void OnLoadModeApplied(ELoadMode mode)
	{
		this.UpdateWPLoadingStreamingCells();
	}

	// Token: 0x0601DB0D RID: 121613 RVA: 0x00851648 File Offset: 0x0084F848
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

	// Token: 0x0601DB0E RID: 121614 RVA: 0x008516DC File Offset: 0x0084F8DC
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

	// Token: 0x0601DB0F RID: 121615 RVA: 0x0085171C File Offset: 0x0084F91C
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
		double num = KuroTime.GetMilliseconds64() - milliseconds;
		if (PerfSight.Instance.IsEnable)
		{
			FKuroPerfSightHelper.PostValueFloat1("CustomPerformance", "ManuallyGarbageCollection", (float)num);
		}
	}

	// Token: 0x0601DB10 RID: 121616 RVA: 0x008517FC File Offset: 0x0084F9FC
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

	// Token: 0x0601DB11 RID: 121617 RVA: 0x008518A4 File Offset: 0x0084FAA4
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

	// Token: 0x0601DB12 RID: 121618 RVA: 0x00851958 File Offset: 0x0084FB58
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

	// Token: 0x0601DB13 RID: 121619 RVA: 0x008519D4 File Offset: 0x0084FBD4
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

	// Token: 0x0601DB14 RID: 121620 RVA: 0x00851C94 File Offset: 0x0084FE94
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

	// Token: 0x0601DB15 RID: 121621 RVA: 0x00851CF0 File Offset: 0x0084FEF0
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

	// Token: 0x0601DB16 RID: 121622 RVA: 0x00851D60 File Offset: 0x0084FF60
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

	// Token: 0x0601DB17 RID: 121623 RVA: 0x00851D90 File Offset: 0x0084FF90
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

	// Token: 0x0601DB18 RID: 121624 RVA: 0x00851DC8 File Offset: 0x0084FFC8
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

	// Token: 0x0601DB19 RID: 121625 RVA: 0x00851F7C File Offset: 0x0085017C
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

	// Token: 0x0601DB1A RID: 121626 RVA: 0x00852000 File Offset: 0x00850200
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

	// Token: 0x0601DB1B RID: 121627 RVA: 0x0085208F File Offset: 0x0085028F
	public void SetActorDataByCreature(CreatureDataComponent creatureData, [Nullable(2)] AActor actor)
	{
		this.SetEntityRole(creatureData);
		this.SetActorGravityDirection(creatureData, actor);
		this.SetActorLocationAndRotation(creatureData, actor);
		this.SetActorTags(creatureData, actor);
	}

	// Token: 0x0601DB1C RID: 121628 RVA: 0x008520B0 File Offset: 0x008502B0
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

	// Token: 0x0601DB1D RID: 121629 RVA: 0x00852120 File Offset: 0x00850320
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

	// Token: 0x0601DB1E RID: 121630 RVA: 0x00852190 File Offset: 0x00850390
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

	// Token: 0x0601DB1F RID: 121631 RVA: 0x0085222C File Offset: 0x0085042C
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

	// Token: 0x0601DB20 RID: 121632 RVA: 0x00852298 File Offset: 0x00850498
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

	// Token: 0x0601DB21 RID: 121633 RVA: 0x00852364 File Offset: 0x00850564
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

	// Token: 0x0601DB22 RID: 121634 RVA: 0x008524B8 File Offset: 0x008506B8
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

	// Token: 0x0601DB23 RID: 121635 RVA: 0x00852510 File Offset: 0x00850710
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

	// Token: 0x0601DB24 RID: 121636 RVA: 0x008525B4 File Offset: 0x008507B4
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

	// Token: 0x0601DB25 RID: 121637 RVA: 0x00852648 File Offset: 0x00850848
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

	// Token: 0x0601DB26 RID: 121638 RVA: 0x00852978 File Offset: 0x00850B78
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

	// Token: 0x0601DB27 RID: 121639 RVA: 0x00852A39 File Offset: 0x00850C39
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(unOpenedAreaPullbackResponse.ErrorCode, 16235, null, true, true);
			}
		}, 0);
	}

	// Token: 0x0601DB28 RID: 121640 RVA: 0x00852A6F File Offset: 0x00850C6F
	private void OnLeaveOnlineWorld()
	{
		UKuroGameBudgetAllocatorCSharpInterface.ClearAssistantActors();
	}

	// Token: 0x0601DB29 RID: 121641 RVA: 0x00852A78 File Offset: 0x00850C78
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

	// Token: 0x0601DB2A RID: 121642 RVA: 0x00852B18 File Offset: 0x00850D18
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

	// Token: 0x0601DB2B RID: 121643 RVA: 0x00852BD4 File Offset: 0x00850DD4
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

	// Token: 0x0601DB2C RID: 121644 RVA: 0x00852D94 File Offset: 0x00850F94
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

	// Token: 0x0601DB2D RID: 121645 RVA: 0x00852DF0 File Offset: 0x00850FF0
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

	// Token: 0x0601DB2E RID: 121646 RVA: 0x00852F40 File Offset: 0x00851140
	public UniTask StartWorldOriginInUiMode()
	{
		WorldController.<StartWorldOriginInUiMode>d__87 <StartWorldOriginInUiMode>d__;
		<StartWorldOriginInUiMode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<StartWorldOriginInUiMode>d__.<>4__this = this;
		<StartWorldOriginInUiMode>d__.<>1__state = -1;
		<StartWorldOriginInUiMode>d__.<>t__builder.Start<WorldController.<StartWorldOriginInUiMode>d__87>(ref <StartWorldOriginInUiMode>d__);
		return <StartWorldOriginInUiMode>d__.<>t__builder.Task;
	}

	// Token: 0x0601DB2F RID: 121647 RVA: 0x00852F84 File Offset: 0x00851184
	public UniTask EndWorldOriginInUiMode()
	{
		WorldController.<EndWorldOriginInUiMode>d__88 <EndWorldOriginInUiMode>d__;
		<EndWorldOriginInUiMode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<EndWorldOriginInUiMode>d__.<>4__this = this;
		<EndWorldOriginInUiMode>d__.<>1__state = -1;
		<EndWorldOriginInUiMode>d__.<>t__builder.Start<WorldController.<EndWorldOriginInUiMode>d__88>(ref <EndWorldOriginInUiMode>d__);
		return <EndWorldOriginInUiMode>d__.<>t__builder.Task;
	}

	// Token: 0x0601DB30 RID: 121648 RVA: 0x00852FC7 File Offset: 0x008511C7
	public bool GetIsWorldOriginInUiMode()
	{
		return this.IsWorldOriginInUiMode;
	}

	// Token: 0x0601DB31 RID: 121649 RVA: 0x00852FD0 File Offset: 0x008511D0
	public void StartWorldOriginInLoadingMode(string reason)
	{
		if (!this.IsWorldOriginInLoadingMode)
		{
			this.IsWorldOriginInLoadingMode = true;
			return;
		}
		Log.Instance.Error(ELogModule.World, ELogAuthor.ZWY, "IsWorldOriginInLoadingMode 开关不成对", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x0601DB32 RID: 121650 RVA: 0x0085300C File Offset: 0x0085120C
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

	// Token: 0x0601DB33 RID: 121651 RVA: 0x00853064 File Offset: 0x00851264
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

	// Token: 0x0601DB34 RID: 121652 RVA: 0x008530C8 File Offset: 0x008512C8
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

	// Token: 0x0601DB35 RID: 121653 RVA: 0x00853108 File Offset: 0x00851308
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

	// Token: 0x0601DB36 RID: 121654 RVA: 0x008531B6 File Offset: 0x008513B6
	public void FixWorldOriginTickCheck(in FVectorDouble origin)
	{
		if (this.IsAllWorldOriginConditionEnable() && this.IsCheckFixWorldOriginPass(origin))
		{
			this.FixWorldOrigin("Tick", origin);
		}
	}

	// Token: 0x0601DB37 RID: 121655 RVA: 0x008531D5 File Offset: 0x008513D5
	public bool FixWorldOriginGm(in FVectorDouble origin)
	{
		if (this.IsAllWorldOriginConditionEnable())
		{
			this.FixWorldOrigin("GM", origin);
			return true;
		}
		return false;
	}

	// Token: 0x0601DB38 RID: 121656 RVA: 0x008531F0 File Offset: 0x008513F0
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

	// Token: 0x0601DB39 RID: 121657 RVA: 0x0085324D File Offset: 0x0085144D
	private bool IsAllWorldOriginConditionEnable()
	{
		return !this.IsWorldOriginInUiMode && !this.IsWorldOriginInLoadingMode;
	}

	// Token: 0x0601DB3A RID: 121658 RVA: 0x00853264 File Offset: 0x00851464
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

	// Token: 0x0601DB3B RID: 121659 RVA: 0x008533B0 File Offset: 0x008515B0
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

	// Token: 0x0601DB3C RID: 121660 RVA: 0x00853440 File Offset: 0x00851640
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

	// Token: 0x0601DB3D RID: 121661 RVA: 0x008535B8 File Offset: 0x008517B8
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

	// Token: 0x170028F0 RID: 10480
	// (get) Token: 0x0601DB3E RID: 121662 RVA: 0x0085363A File Offset: 0x0085183A
	public static WorldController Instance
	{
		get
		{
			return WorldController._Instance;
		}
	}

	// Token: 0x0601DB3F RID: 121663 RVA: 0x00853641 File Offset: 0x00851841
	public static WorldController GetOrCreateInstance()
	{
		if (WorldController._Instance == null)
		{
			WorldController.CreateInstance();
		}
		return WorldController._Instance;
	}

	// Token: 0x0601DB40 RID: 121664 RVA: 0x00853655 File Offset: 0x00851855
	public static bool CreateInstance()
	{
		if (WorldController._Instance != null)
		{
			return true;
		}
		WorldController._Instance = new WorldController();
		return true;
	}

	// Token: 0x0601DB41 RID: 121665 RVA: 0x0085366B File Offset: 0x0085186B
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601DB42 RID: 121666 RVA: 0x0085366D File Offset: 0x0085186D
	public static void ResetStaticDefaultValue()
	{
		WorldController._Instance = null;
	}

	// Token: 0x0601DB43 RID: 121667 RVA: 0x00853675 File Offset: 0x00851875
	static WorldController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WorldController.CreateStaticDefaultValue), new Action(WorldController.ResetStaticDefaultValue));
	}

	// Token: 0x0400E8FF RID: 59647
	private const int DELTA_TIME_LIMIT_LOW = 20;

	// Token: 0x0400E900 RID: 59648
	private const int DELTA_TIME_LIMIT_HIGH = 25;

	// Token: 0x0400E901 RID: 59649
	private const int MIN_DELTA = 0;

	// Token: 0x0400E902 RID: 59650
	private const int MAX_DELTA = 0;

	// Token: 0x0400E903 RID: 59651
	private const int SCHEDULER_MINUS_FRAME_COUNT = 5;

	// Token: 0x0400E904 RID: 59652
	private const int DEFAULT_ENVIRONMENTTYPE = 255;

	// Token: 0x0400E905 RID: 59653
	private const int IOS_STREAMING_POOL_SIZE = 250;

	// Token: 0x0400E906 RID: 59654
	private const int IOS_STREAMING_POOL_SIZE_FOR_MESHES = 250;

	// Token: 0x0400E907 RID: 59655
	private const int IOS_STREAMING_POOL_SIZE_IN_LOADING = 90;

	// Token: 0x0400E908 RID: 59656
	private const int IOS_STREAMING_POOL_SIZE_FOR_MESHES_IN_LOADING = 90;

	// Token: 0x0400E909 RID: 59657
	private const int HIGH_SPEED_REMOVE_INTERVAL = 10;

	// Token: 0x0400E90A RID: 59658
	private const int MAX_PENDING_REMOVE_COUNT = 100;

	// Token: 0x0400E90B RID: 59659
	private const int LOW_MEMORY_PENDING_REMOVE_COUNT = 50;

	// Token: 0x0400E90C RID: 59660
	private bool GlobalIsInFight;

	// Token: 0x0400E90D RID: 59661
	private bool LoopMapStreamingBudgetEnabled;

	// Token: 0x0400E90E RID: 59662
	[Nullable(2)]
	private TimerHandle MemoryGcCheckTimerId;

	// Token: 0x0400E90F RID: 59663
	[Nullable(2)]
	private TimerHandle VoxelCheckTimerId;

	// Token: 0x0400E910 RID: 59664
	private bool ShouldGcWhenBattleFinished;

	// Token: 0x0400E911 RID: 59665
	private EShouldGc DeviceShouldGc;

	// Token: 0x0400E912 RID: 59666
	private bool IsPerformanceLimitMode;

	// Token: 0x0400E913 RID: 59667
	private int RemoveInterval;

	// Token: 0x0400E914 RID: 59668
	private int CurrentFrameInterval;

	// Token: 0x0400E915 RID: 59669
	private int DestroyPendingNum = 1;

	// Token: 0x0400E916 RID: 59670
	[Nullable(2)]
	private Ticker DoTickHandle;

	// Token: 0x0400E917 RID: 59671
	[Nullable(2)]
	private Ticker DoTickFrameEndHandle;

	// Token: 0x0400E918 RID: 59672
	private bool EnableZAxisOffset = true;

	// Token: 0x0400E919 RID: 59673
	private readonly List<AActor> DestroyActorList = new List<AActor>();

	// Token: 0x0400E91A RID: 59674
	private readonly global::Vector WorldOriginValue = global::Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x0400E91B RID: 59675
	private readonly global::Vector LastWorldOriginValue = global::Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x0400E91C RID: 59676
	private int LastSetWorldOriginFrame;

	// Token: 0x0400E91D RID: 59677
	public bool EnableWorldOrigin = true;

	// Token: 0x0400E91E RID: 59678
	public bool EnableWorldOriginLoadingCheck = true;

	// Token: 0x0400E91F RID: 59679
	public bool EnableWorldOriginTickCheck = true;

	// Token: 0x0400E920 RID: 59680
	public int OriginNeedChangeMax = 250000;

	// Token: 0x0400E921 RID: 59681
	public int CheckRateMax = 30;

	// Token: 0x0400E922 RID: 59682
	private int CheckRateInternal;

	// Token: 0x0400E923 RID: 59683
	private bool IsWorldOriginInUiMode;

	// Token: 0x0400E924 RID: 59684
	private bool IsWorldOriginInLoadingMode;

	// Token: 0x0400E925 RID: 59685
	private readonly global::Vector CacheWorldOrigin = global::Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x0400E926 RID: 59686
	[Nullable(2)]
	private TimerHandle CheckWorldOriginFinishTimer;

	// Token: 0x0400E927 RID: 59687
	private int CheckWorldOriginFinishTimerNum;

	// Token: 0x0400E928 RID: 59688
	private readonly int CheckWorldOriginFinishTimerNumMax = 10;

	// Token: 0x0400E929 RID: 59689
	[Nullable(2)]
	private static WorldController _Instance;
}

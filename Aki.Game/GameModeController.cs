using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Render.RuntimeBP.RenderData;
using CSharpScript.Core.Common;
using CSharpScript.Core.Framework;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Manager;
using CSharpScript.Game.Module.CombatMessage;
using CSharpScript.Game.Module.DataLayerSwitch;
using CSharpScript.Game.Module.DeadRevive;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Render;
using CSharpScript.Game.World.Controller;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Typing;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x020034DB RID: 13531
[NullableContext(1)]
[Nullable(0)]
[TickController(0)]
public class GameModeController : ControllerBase
{
	// Token: 0x0601D9D4 RID: 121300 RVA: 0x00848708 File Offset: 0x00846908
	public void AddWorldDoneBlocker(Func<UniTask> blocker, int timeout = 60000)
	{
		if (this.IsWorldDoneBlockersExecuted)
		{
			Log.Instance.Warn(ELogModule.GameMode, ELogAuthor.CH, "'WorldDoneBlockers 已经执行完毕，新注册的 Blocker 将不会被执行！请检查调用时机", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.WorldDoneBlockers.Add(new ValueTuple<Func<UniTask>, int>(blocker, timeout));
	}

	// Token: 0x0601D9D5 RID: 121301 RVA: 0x0084874C File Offset: 0x0084694C
	private UniTask ExecuteWorldDoneBlockers()
	{
		GameModeController.<ExecuteWorldDoneBlockers>d__14 <ExecuteWorldDoneBlockers>d__;
		<ExecuteWorldDoneBlockers>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ExecuteWorldDoneBlockers>d__.<>4__this = this;
		<ExecuteWorldDoneBlockers>d__.<>1__state = -1;
		<ExecuteWorldDoneBlockers>d__.<>t__builder.Start<GameModeController.<ExecuteWorldDoneBlockers>d__14>(ref <ExecuteWorldDoneBlockers>d__);
		return <ExecuteWorldDoneBlockers>d__.<>t__builder.Task;
	}

	// Token: 0x0601D9D6 RID: 121302 RVA: 0x00848790 File Offset: 0x00846990
	private UniTask ExecuteBlockerWithTimeout(Func<UniTask> blocker, int timeout, int index)
	{
		GameModeController.<ExecuteBlockerWithTimeout>d__15 <ExecuteBlockerWithTimeout>d__;
		<ExecuteBlockerWithTimeout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ExecuteBlockerWithTimeout>d__.<>4__this = this;
		<ExecuteBlockerWithTimeout>d__.blocker = blocker;
		<ExecuteBlockerWithTimeout>d__.timeout = timeout;
		<ExecuteBlockerWithTimeout>d__.index = index;
		<ExecuteBlockerWithTimeout>d__.<>1__state = -1;
		<ExecuteBlockerWithTimeout>d__.<>t__builder.Start<GameModeController.<ExecuteBlockerWithTimeout>d__15>(ref <ExecuteBlockerWithTimeout>d__);
		return <ExecuteBlockerWithTimeout>d__.<>t__builder.Task;
	}

	// Token: 0x0601D9D7 RID: 121303 RVA: 0x008487EC File Offset: 0x008469EC
	private UniTask ExecuteBlockerWithErrorHandler(Func<UniTask> blocker, int index)
	{
		GameModeController.<ExecuteBlockerWithErrorHandler>d__16 <ExecuteBlockerWithErrorHandler>d__;
		<ExecuteBlockerWithErrorHandler>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ExecuteBlockerWithErrorHandler>d__.blocker = blocker;
		<ExecuteBlockerWithErrorHandler>d__.index = index;
		<ExecuteBlockerWithErrorHandler>d__.<>1__state = -1;
		<ExecuteBlockerWithErrorHandler>d__.<>t__builder.Start<GameModeController.<ExecuteBlockerWithErrorHandler>d__16>(ref <ExecuteBlockerWithErrorHandler>d__);
		return <ExecuteBlockerWithErrorHandler>d__.<>t__builder.Task;
	}

	// Token: 0x0601D9D8 RID: 121304 RVA: 0x00848838 File Offset: 0x00846A38
	protected override bool OnInit()
	{
		if (Info.Instance.IsMobilePlatform() || Info.Instance.IsGamepadPlatform())
		{
			Application.Instance.AddApplicationHandler(EApplicationLifetimeDelegate.ApplicationWillDeactivateDelegate, new Action(this.ApplicationHasDeactivated));
			Application.Instance.AddApplicationHandler(EApplicationLifetimeDelegate.ApplicationHasReactivatedDelegate, new Action(this.ApplicationHasReactivated));
		}
		if (Info.Instance.IsPlayInEditor)
		{
			Log.Instance.Info(ELogModule.World, ELogAuthor.WLJ, "Disable UseSeparatedBody In Editor", default(ReadOnlySpan<ValueTuple<string, object>>));
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "Kuro.Collision.UseSeparatedBody 0", null);
			Log.Instance.Info(ELogModule.World, ELogAuthor.WLJ, "Disable FastGeo In Editor", default(ReadOnlySpan<ValueTuple<string, object>>));
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "Wp.Runtime.UseNoTransformerPackages 1", null);
		}
		EventSystem.Instance.Add(EEventName.ClearWorld, new Action(this.OnClearWorld));
		EventSystem.Instance.Add(EEventName.SlowStreamingBySoar, new Action<bool>(this.OnSlowStreamingBySoar));
		if (UKuroStaticLibrary.IsWithEditor())
		{
			this.InitDataReport();
		}
		return true;
	}

	// Token: 0x0601D9D9 RID: 121305 RVA: 0x00848935 File Offset: 0x00846B35
	protected override bool OnLeaveLevel()
	{
		return true;
	}

	// Token: 0x0601D9DA RID: 121306 RVA: 0x00848938 File Offset: 0x00846B38
	private void ApplicationHasDeactivated()
	{
		if (!Net.Instance.IsServerConnected())
		{
			return;
		}
		TimeStopPush timeStopPush = TimeStopPush.Create();
		timeStopPush.TimeDilation = 0f;
		Net.Instance.Send(EPushMessageId.TimeStopPush, timeStopPush);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.GameMode;
		ELogAuthor author = ELogAuthor.XWX;
		string message = "ApplicationHasDeactivated 发生时停协议";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TimeDilation", Time.Instance.TimeDilation);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0601D9DB RID: 121307 RVA: 0x008489A8 File Offset: 0x00846BA8
	private void ApplicationHasReactivated()
	{
		if (!Net.Instance.IsServerConnected())
		{
			return;
		}
		TimeStopPush timeStopPush = TimeStopPush.Create();
		timeStopPush.TimeDilation = Time.Instance.TimeDilation;
		Net.Instance.Send(EPushMessageId.TimeStopPush, timeStopPush);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.GameMode;
		ELogAuthor author = ELogAuthor.XWX;
		string message = "ApplicationHasReactivated 发生时停协议";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TimeDilation", Time.Instance.TimeDilation);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0601D9DC RID: 121308 RVA: 0x00848A20 File Offset: 0x00846C20
	protected override bool OnClear()
	{
		if (Info.Instance.IsMobilePlatform() || Info.Instance.IsGamepadPlatform())
		{
			Application.Instance.RemoveApplicationHandler(EApplicationLifetimeDelegate.ApplicationWillDeactivateDelegate, new Action(this.ApplicationHasDeactivated));
			Application.Instance.RemoveApplicationHandler(EApplicationLifetimeDelegate.ApplicationHasReactivatedDelegate, new Action(this.ApplicationHasReactivated));
		}
		EventSystem.Instance.Remove(EEventName.ClearWorld, new Action(this.OnClearWorld));
		EventSystem.Instance.Remove(EEventName.SlowStreamingBySoar, new Action<bool>(this.OnSlowStreamingBySoar));
		this.ResetRenderAssetsQuery(null, null, false);
		return true;
	}

	// Token: 0x0601D9DD RID: 121309 RVA: 0x00848AB5 File Offset: 0x00846CB5
	private void OnClearWorld()
	{
		GameModeModel.Instance.RenderAssetDone = false;
	}

	// Token: 0x0601D9DE RID: 121310 RVA: 0x00848AC4 File Offset: 0x00846CC4
	private void ForceLowMemDeviceStreamingLowIfSanWangFengInstance(bool isSet)
	{
		if (!UKuroStaticLibrary.IsLowMemoryDevice())
		{
			return;
		}
		if (isSet)
		{
			this.HasOverrideQuality = true;
			this.LastGameQualityLevel = UKismetSystemLibrary.GetConsoleVariableIntValue("sg.KuroRenderQuality");
			if (this.LastGameQualityLevel > 1)
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "sg.KuroRenderQuality 1", null);
			}
			if (!GameSettingsDeviceRender.Instance.IsTargetBaseProfile("IPad", false))
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Streaming.RuntimeLODBiasDeviceMappingIndices 274432", null);
			}
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.DepthOfFieldQuality 0", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.ScreenSizeCullRatioFactor 85.0", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.StaticMeshLODDistanceScale 2.5", null);
			return;
		}
		if (this.HasOverrideQuality)
		{
			this.HasOverrideQuality = false;
			UObject world = GlobalData.World;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
			defaultInterpolatedStringHandler.AppendLiteral("sg.KuroRenderQuality $");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.LastGameQualityLevel);
			UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Streaming.RuntimeLODBiasDeviceMappingIndices 274960", null);
		}
	}

	// Token: 0x0601D9DF RID: 121311 RVA: 0x00848BB8 File Offset: 0x00846DB8
	public bool SetGameModeData(int id, SceneMode sceneMode)
	{
		GameModeModel instance = GameModeModel.Instance;
		InstanceDungeon? config = ConfigInstanceDungeonById.GetConfig(id, true);
		if (config == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.World;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "[GameModeController.InitGameModeData] 不存在副本表id:";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		AkiMapSource? akiMapSourceConfig = WorldMapConfig.Instance.GetAkiMapSourceConfig(config.Value.MapConfigId);
		if (akiMapSourceConfig == null)
		{
			Log instance3 = Log.Instance;
			ELogModule module2 = ELogModule.World;
			ELogAuthor author2 = ELogAuthor.LFJW;
			string message2 = "[WorldGlobal.LoadMapFromInstanceDungeon] 不存在Id";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("MapConfigId", config.Value.MapConfigId);
			instance3.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return false;
		}
		instance.HasGameModeData = true;
		instance.MapPath = akiMapSourceConfig.Value.MapPath.ToString();
		instance.IsMulti = (sceneMode == SceneMode.Multi);
		instance.Mode = new SceneMode?(sceneMode);
		instance.InstanceType = (InstanceType)config.Value.InstType;
		instance.MapConfig = akiMapSourceConfig.Value;
		instance.MapId = config.Value.MapConfigId;
		instance.LoadMapMode = (ELoadMapMode)akiMapSourceConfig.Value.LoadMapMode;
		instance.SetInstanceDungeon(id);
		if (!Info.Instance.IsBuildDevelopmentOrDebug)
		{
			CreatureModel.Instance.EnableEntityLog = (instance.InstanceType != InstanceType.BigWorldInstance);
		}
		EventSystem.Instance.Emit(EEventName.OnSetGameModeDataDone);
		return true;
	}

	// Token: 0x0601D9E0 RID: 121312 RVA: 0x00848D2C File Offset: 0x00846F2C
	public bool CheckIsSameMapTravel(int targetDungeonId)
	{
		InstanceDungeon? config = ConfigInstanceDungeonById.GetConfig(targetDungeonId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.World;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "[GameModeController.CheckIsSameMapTravel] 不存在副本表id:";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", targetDungeonId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		AkiMapSource? akiMapSourceConfig = WorldMapConfig.Instance.GetAkiMapSourceConfig(config.Value.MapConfigId);
		if (akiMapSourceConfig == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.World;
			ELogAuthor author2 = ELogAuthor.LFJW;
			string message2 = "[GameModeController.CheckIsSameMapTravel] 不存在Id";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("MapConfigId", config.Value.MapConfigId);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return false;
		}
		return GameModeModel.Instance.MapPath == akiMapSourceConfig.Value.MapPath;
	}

	// Token: 0x0601D9E1 RID: 121313 RVA: 0x00848DF8 File Offset: 0x00846FF8
	public UniTask Load(SceneInformation sceneInformation)
	{
		GameModeController.<Load>d__26 <Load>d__;
		<Load>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Load>d__.<>4__this = this;
		<Load>d__.sceneInformation = sceneInformation;
		<Load>d__.<>1__state = -1;
		<Load>d__.<>t__builder.Start<GameModeController.<Load>d__26>(ref <Load>d__);
		return <Load>d__.<>t__builder.Task;
	}

	// Token: 0x0601D9E2 RID: 121314 RVA: 0x00848E44 File Offset: 0x00847044
	private void CreateStat(string name)
	{
		Stat.CreateNoFlameGraph(name, "", "");
		if (Info.Instance.IsPlayInEditor)
		{
			float platformTimeInSeconds = UKuroStaticLibrary.GetPlatformTimeInSeconds();
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GameMode;
			ELogAuthor author = ELogAuthor.BLZ;
			string message = "[LoadPhase] " + name;
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("time", platformTimeInSeconds);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
	}

	// Token: 0x0601D9E3 RID: 121315 RVA: 0x00848EA8 File Offset: 0x008470A8
	public UniTask Change(ChangeSceneModeNotify data)
	{
		GameModeController.<Change>d__28 <Change>d__;
		<Change>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Change>d__.<>4__this = this;
		<Change>d__.data = data;
		<Change>d__.<>1__state = -1;
		<Change>d__.<>t__builder.Start<GameModeController.<Change>d__28>(ref <Change>d__);
		return <Change>d__.<>t__builder.Task;
	}

	// Token: 0x0601D9E4 RID: 121316 RVA: 0x00848EF4 File Offset: 0x008470F4
	private void RegisterDataLayerChange()
	{
		if (GameModeModel.Instance.UseWorldPartition)
		{
			UDataLayerSubsystem udataLayerSubsystem = UKuroRenderingRuntimeBPPluginBPLibrary.GetSubsystem(GlobalData.World, UDataLayerSubsystem.StaticClass()) as UDataLayerSubsystem;
			if (udataLayerSubsystem != null)
			{
				if (!GameModeModel.Instance.HasDataLayer(WorldDefine.SpecificVolumeDatalayer1.ToString()))
				{
					RenderModuleController.Instance.SetWorldPartitionDataLayerState(WorldDefine.SpecificVolumeDatalayer1.ToString(), false, false);
				}
				if (!GameModeModel.Instance.HasDataLayer(WorldDefine.SpecificVolumeDatalayer2.ToString()))
				{
					RenderModuleController.Instance.SetWorldPartitionDataLayerState(WorldDefine.SpecificVolumeDatalayer2.ToString(), false, false);
				}
				udataLayerSubsystem.OnGlobalDataLayerActivationStateChanged.Add(new Action<FName, bool>(this.OnDatalayerChange));
				Log.Instance.Info(ELogModule.GameMode, ELogAuthor.HWK, "注册DataLayer变化监听", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GameMode;
			ELogAuthor author = ELogAuthor.HWK;
			string message = "注册DataLayer变化监听失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("DatalayerSubSystem", udataLayerSubsystem);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
	}

	// Token: 0x0601D9E5 RID: 121317 RVA: 0x00848FFC File Offset: 0x008471FC
	private void OnDatalayerChange(FName datalayerLabel, bool bIsActive)
	{
		if (bIsActive && datalayerLabel != FName.NAME_None && (datalayerLabel == WorldDefine.SpecificVolumeDatalayer1 || datalayerLabel == WorldDefine.SpecificVolumeDatalayer2) && !GameModeModel.Instance.HasDataLayer(datalayerLabel.ToString()))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GameMode;
			ELogAuthor author = ELogAuthor.HWK;
			string message = "DataLayer在业务端未激活";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Datalayer", datalayerLabel);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			RenderModuleController.Instance.SetWorldPartitionDataLayerState(datalayerLabel.ToString(), false, false);
		}
	}

	// Token: 0x0601D9E6 RID: 121318 RVA: 0x00849094 File Offset: 0x00847294
	public void PreventEntityFalling()
	{
		DeadReviveModel.Instance.SetSkipFallInjure(ESkipFallInjureReason.GameMode, true);
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity != null && getCurrentEntity.Valid)
		{
			CharacterActorComponent component = getCurrentEntity.Entity.GetComponent<CharacterActorComponent>();
			if (component != null && component.Valid)
			{
				TsBaseCharacter actor = component.Actor;
				if (actor != null && actor.IsValid())
				{
					UCharacterMovementComponent characterMovement = component.Actor.CharacterMovement;
					if (characterMovement != null && characterMovement.IsValid())
					{
						component.Actor.KuroSetMovementMode(new SetMovementModeInfo
						{
							Mode = EMovementMode.MOVE_None,
							Context = "[GameModeController.PreventEntityFalling]"
						});
					}
				}
			}
		}
	}

	// Token: 0x0601D9E7 RID: 121319 RVA: 0x0084912C File Offset: 0x0084732C
	public void EnableEntityFalling()
	{
		DeadReviveModel.Instance.SetSkipFallInjure(ESkipFallInjureReason.GameMode, false);
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity != null && getCurrentEntity.Valid)
		{
			CharacterActorComponent component = getCurrentEntity.Entity.GetComponent<CharacterActorComponent>();
			if (component != null && component.Valid)
			{
				TsBaseCharacter actor = component.Actor;
				if (actor != null && actor.IsValid())
				{
					UCharacterMovementComponent characterMovement = component.Actor.CharacterMovement;
					if (characterMovement != null && characterMovement.IsValid())
					{
						component.Actor.KuroSetMovementMode(new SetMovementModeInfo
						{
							Mode = component.Actor.CharacterMovement.DefaultLandMovementMode,
							Context = "[GameModeController.EnableEntityFalling]"
						});
					}
				}
			}
		}
	}

	// Token: 0x0601D9E8 RID: 121320 RVA: 0x008491D8 File Offset: 0x008473D8
	public void PrintWorldPartitionDebugInfo(UWorldPartitionStreamingSourceComponent streamingSourceComponent, [Nullable(2)] TArray<FName> inDataLayerLabels, bool bUseGridLoadingRange, float radius, bool bRequirePhysics)
	{
		if (streamingSourceComponent == null)
		{
			Log.Instance.Error(ELogModule.GameMode, ELogAuthor.HWK, "WorldPartitionStreamingSourceComponent不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (!(UKuroRenderingRuntimeBPPluginBPLibrary.GetSubsystem(GlobalData.World, UWorldPartitionSubsystem.StaticClass()) is UWorldPartitionSubsystem))
		{
			Log.Instance.Error(ELogModule.GameMode, ELogAuthor.HWK, "WorldPartitionSubsystem不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		streamingSourceComponent.LogStreamingStuckInfo2(inDataLayerLabels ?? new TArray<FName>(), bUseGridLoadingRange, radius, bRequirePhysics);
	}

	// Token: 0x0601D9E9 RID: 121321 RVA: 0x00849251 File Offset: 0x00847451
	[NullableContext(2)]
	public void SwitchDataLayer([Nullable(1)] IList<string> unloadDataLayers, [Nullable(1)] IList<string> activateDataLayers, Action<bool> callback = null, string sequencePath = null, string sequenceMarkBeforeModifyMaterial = null, string materialDataForLoadedLayers = null, string materialDataForUnloadLayers = null)
	{
		this.AwaitSwitchDataLayer(unloadDataLayers, activateDataLayers, callback, sequencePath, sequenceMarkBeforeModifyMaterial, materialDataForLoadedLayers, materialDataForUnloadLayers);
	}

	// Token: 0x0601D9EA RID: 121322 RVA: 0x00849268 File Offset: 0x00847468
	private void OnInterruptDataLayerSwitchTask()
	{
		Log.Instance.Info(ELogModule.GameMode, ELogAuthor.ZYL, "GameMode:Task被打断,触发OnInterrupt收尾", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.InterruptDataLayerSwitch();
	}

	// Token: 0x0601D9EB RID: 121323 RVA: 0x00849298 File Offset: 0x00847498
	public void InterruptDataLayerSwitch()
	{
		Log.Instance.Info(ELogModule.GameMode, ELogAuthor.ZYL, "GameMode:打断DataLayer切换(InterruptDataLayerSwitch)", default(ReadOnlySpan<ValueTuple<string, object>>));
		GameModeModel instance = GameModeModel.Instance;
		if (instance == null)
		{
			return;
		}
		instance.SwitchDataLayerContext.AbortDataLayerSwitch();
	}

	// Token: 0x0601D9EC RID: 121324 RVA: 0x008492D8 File Offset: 0x008474D8
	[NullableContext(2)]
	public UniTask AwaitSwitchDataLayer([Nullable(1)] IList<string> unloadDataLayers, [Nullable(1)] IList<string> activateDataLayers, Action<bool> callback = null, string sequencePath = null, string sequenceMarkBeforeModifyMaterial = null, string materialDataForLoadedLayers = null, string materialDataForUnloadLayers = null)
	{
		GameModeController.<AwaitSwitchDataLayer>d__37 <AwaitSwitchDataLayer>d__;
		<AwaitSwitchDataLayer>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<AwaitSwitchDataLayer>d__.<>4__this = this;
		<AwaitSwitchDataLayer>d__.unloadDataLayers = unloadDataLayers;
		<AwaitSwitchDataLayer>d__.activateDataLayers = activateDataLayers;
		<AwaitSwitchDataLayer>d__.callback = callback;
		<AwaitSwitchDataLayer>d__.sequencePath = sequencePath;
		<AwaitSwitchDataLayer>d__.sequenceMarkBeforeModifyMaterial = sequenceMarkBeforeModifyMaterial;
		<AwaitSwitchDataLayer>d__.materialDataForLoadedLayers = materialDataForLoadedLayers;
		<AwaitSwitchDataLayer>d__.materialDataForUnloadLayers = materialDataForUnloadLayers;
		<AwaitSwitchDataLayer>d__.<>1__state = -1;
		<AwaitSwitchDataLayer>d__.<>t__builder.Start<GameModeController.<AwaitSwitchDataLayer>d__37>(ref <AwaitSwitchDataLayer>d__);
		return <AwaitSwitchDataLayer>d__.<>t__builder.Task;
	}

	// Token: 0x0601D9ED RID: 121325 RVA: 0x00849358 File Offset: 0x00847558
	[NullableContext(2)]
	[return: Nullable(1)]
	private AsyncTask CreateSwitchDataLayerTask([Nullable(1)] IList<string> unloadDataLayers, [Nullable(1)] IList<string> activateDataLayers, Action<bool> callback = null, string sequencePath = null, string sequenceMarkBeforeModifyMaterial = null, string materialDataForLoadedLayers = null, string materialDataForUnloadLayers = null)
	{
		GameModeController.<>c__DisplayClass38_0 CS$<>8__locals1 = new GameModeController.<>c__DisplayClass38_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.unloadDataLayers = unloadDataLayers;
		CS$<>8__locals1.activateDataLayers = activateDataLayers;
		CS$<>8__locals1.callback = callback;
		CS$<>8__locals1.sequencePath = sequencePath;
		CS$<>8__locals1.sequenceMarkBeforeModifyMaterial = sequenceMarkBeforeModifyMaterial;
		CS$<>8__locals1.materialDataForLoadedLayers = materialDataForLoadedLayers;
		CS$<>8__locals1.materialDataForUnloadLayers = materialDataForUnloadLayers;
		if (!StringUtils.IsBlank(CS$<>8__locals1.materialDataForLoadedLayers) || !StringUtils.IsBlank(CS$<>8__locals1.materialDataForUnloadLayers))
		{
			Log.Instance.Info(ELogModule.GameMode, ELogAuthor.ZYL, "GameMode:选择材质过渡切换模式", default(ReadOnlySpan<ValueTuple<string, object>>));
			CS$<>8__locals1.runner = (() => CS$<>8__locals1.<>4__this.RunMaterialSwitchTask(CS$<>8__locals1.unloadDataLayers, CS$<>8__locals1.activateDataLayers, CS$<>8__locals1.callback, CS$<>8__locals1.sequencePath, CS$<>8__locals1.sequenceMarkBeforeModifyMaterial, CS$<>8__locals1.materialDataForLoadedLayers, CS$<>8__locals1.materialDataForUnloadLayers));
		}
		else if (!StringUtils.IsBlank(CS$<>8__locals1.sequencePath))
		{
			Log.Instance.Info(ELogModule.GameMode, ELogAuthor.ZYL, "GameMode:选择序列切换模式", default(ReadOnlySpan<ValueTuple<string, object>>));
			CS$<>8__locals1.runner = (() => CS$<>8__locals1.<>4__this.RunLevelSeqSwitchTask(CS$<>8__locals1.unloadDataLayers, CS$<>8__locals1.activateDataLayers, CS$<>8__locals1.sequencePath, CS$<>8__locals1.callback));
		}
		else
		{
			Log.Instance.Info(ELogModule.GameMode, ELogAuthor.ZYL, "GameMode:选择普通切换模式", default(ReadOnlySpan<ValueTuple<string, object>>));
			CS$<>8__locals1.runner = (() => CS$<>8__locals1.<>4__this.RunNormalSwitchTask(CS$<>8__locals1.unloadDataLayers, CS$<>8__locals1.activateDataLayers, CS$<>8__locals1.callback));
		}
		return new AsyncTask("SwitchDataLayer", delegate()
		{
			GameModeController.<>c__DisplayClass38_0.<<CreateSwitchDataLayerTask>b__3>d <<CreateSwitchDataLayerTask>b__3>d;
			<<CreateSwitchDataLayerTask>b__3>d.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<<CreateSwitchDataLayerTask>b__3>d.<>4__this = CS$<>8__locals1;
			<<CreateSwitchDataLayerTask>b__3>d.<>1__state = -1;
			<<CreateSwitchDataLayerTask>b__3>d.<>t__builder.Start<GameModeController.<>c__DisplayClass38_0.<<CreateSwitchDataLayerTask>b__3>d>(ref <<CreateSwitchDataLayerTask>b__3>d);
			return <<CreateSwitchDataLayerTask>b__3>d.<>t__builder.Task;
		}, null, null, new TaskInterruptOptions(ETaskPriority.Normal, true, new Action(this.OnInterruptDataLayerSwitchTask)));
	}

	// Token: 0x0601D9EE RID: 121326 RVA: 0x00849488 File Offset: 0x00847688
	private void PrepareSwitchDataLayer()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.GameMode;
		ELogAuthor author = ELogAuthor.ZYL;
		string message = "GameMode:准备切换DataLayer";
		string item = "InstId";
		InstanceDungeon? instanceDungeon = GameModeModel.Instance.InstanceDungeon;
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (instanceDungeon != null) ? instanceDungeon.GetValueOrDefault().Id : 0);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		instanceDungeon = GameModeModel.Instance.InstanceDungeon;
		bool flag = (((instanceDungeon != null) ? new int?(instanceDungeon.GetValueOrDefault().Id) : null) ?? 0) == 0;
		if (flag)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.GameMode;
			ELogAuthor author2 = ELogAuthor.ZYL;
			string message2 = "切换DataLayer:InstId为0或空";
			string item2 = "InstId";
			instanceDungeon = GameModeModel.Instance.InstanceDungeon;
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>(item2, (instanceDungeon != null) ? new int?(instanceDungeon.GetValueOrDefault().Id) : null);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		}
		DataLayerSwitchContext switchDataLayerContext = GameModeModel.Instance.SwitchDataLayerContext;
		switchDataLayerContext.ResetDataLayerSwitchAbort();
		instanceDungeon = GameModeModel.Instance.InstanceDungeon;
		switchDataLayerContext.BeginDataLayerSwitch((instanceDungeon != null) ? instanceDungeon.GetValueOrDefault().Id : 0);
	}

	// Token: 0x0601D9EF RID: 121327 RVA: 0x008495D4 File Offset: 0x008477D4
	private bool CheckAndTryFakeSwitchDataLayer(IList<string> unloadDataLayers, IList<string> activateDataLayers, [Nullable(2)] Action<bool> callback = null)
	{
		AutoRunModel instance = AutoRunModel.Instance;
		if (instance != null && instance.IsInLogicTreeGmMode())
		{
			this.FakeSwitchDataLayerInternal(unloadDataLayers, activateDataLayers, GameModeModel.Instance.SwitchDataLayerContext.CurrentSwitchInstId, callback);
			return true;
		}
		return false;
	}

	// Token: 0x0601D9F0 RID: 121328 RVA: 0x00849604 File Offset: 0x00847804
	private UniTask RunNormalSwitchTask(IList<string> unloadDataLayers, IList<string> activateDataLayers, [Nullable(2)] Action<bool> callback = null)
	{
		GameModeController.<RunNormalSwitchTask>d__41 <RunNormalSwitchTask>d__;
		<RunNormalSwitchTask>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RunNormalSwitchTask>d__.<>4__this = this;
		<RunNormalSwitchTask>d__.unloadDataLayers = unloadDataLayers;
		<RunNormalSwitchTask>d__.activateDataLayers = activateDataLayers;
		<RunNormalSwitchTask>d__.callback = callback;
		<RunNormalSwitchTask>d__.<>1__state = -1;
		<RunNormalSwitchTask>d__.<>t__builder.Start<GameModeController.<RunNormalSwitchTask>d__41>(ref <RunNormalSwitchTask>d__);
		return <RunNormalSwitchTask>d__.<>t__builder.Task;
	}

	// Token: 0x0601D9F1 RID: 121329 RVA: 0x00849660 File Offset: 0x00847860
	private UniTask RunLevelSeqSwitchTask(IList<string> unloadDataLayers, IList<string> activateDataLayers, string sequencePath, [Nullable(2)] Action<bool> callback = null)
	{
		GameModeController.<RunLevelSeqSwitchTask>d__42 <RunLevelSeqSwitchTask>d__;
		<RunLevelSeqSwitchTask>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RunLevelSeqSwitchTask>d__.<>4__this = this;
		<RunLevelSeqSwitchTask>d__.unloadDataLayers = unloadDataLayers;
		<RunLevelSeqSwitchTask>d__.activateDataLayers = activateDataLayers;
		<RunLevelSeqSwitchTask>d__.sequencePath = sequencePath;
		<RunLevelSeqSwitchTask>d__.callback = callback;
		<RunLevelSeqSwitchTask>d__.<>1__state = -1;
		<RunLevelSeqSwitchTask>d__.<>t__builder.Start<GameModeController.<RunLevelSeqSwitchTask>d__42>(ref <RunLevelSeqSwitchTask>d__);
		return <RunLevelSeqSwitchTask>d__.<>t__builder.Task;
	}

	// Token: 0x0601D9F2 RID: 121330 RVA: 0x008496C4 File Offset: 0x008478C4
	[NullableContext(2)]
	private UniTask RunMaterialSwitchTask([Nullable(1)] IList<string> unloadDataLayers, [Nullable(1)] IList<string> activateDataLayers, Action<bool> callback = null, string sequencePath = null, string sequenceMarkBeforeModifyMaterial = null, string materialDataForLoadedLayers = null, string materialDataForUnloadLayers = null)
	{
		GameModeController.<RunMaterialSwitchTask>d__43 <RunMaterialSwitchTask>d__;
		<RunMaterialSwitchTask>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RunMaterialSwitchTask>d__.<>4__this = this;
		<RunMaterialSwitchTask>d__.unloadDataLayers = unloadDataLayers;
		<RunMaterialSwitchTask>d__.activateDataLayers = activateDataLayers;
		<RunMaterialSwitchTask>d__.callback = callback;
		<RunMaterialSwitchTask>d__.sequencePath = sequencePath;
		<RunMaterialSwitchTask>d__.sequenceMarkBeforeModifyMaterial = sequenceMarkBeforeModifyMaterial;
		<RunMaterialSwitchTask>d__.materialDataForLoadedLayers = materialDataForLoadedLayers;
		<RunMaterialSwitchTask>d__.materialDataForUnloadLayers = materialDataForUnloadLayers;
		<RunMaterialSwitchTask>d__.<>1__state = -1;
		<RunMaterialSwitchTask>d__.<>t__builder.Start<GameModeController.<RunMaterialSwitchTask>d__43>(ref <RunMaterialSwitchTask>d__);
		return <RunMaterialSwitchTask>d__.<>t__builder.Task;
	}

	// Token: 0x0601D9F3 RID: 121331 RVA: 0x00849744 File Offset: 0x00847944
	private UniTask NormalSwitchDataLayerInternal(IList<string> unloadDataLayers, IList<string> activateDataLayers, bool bEnterLoadingMode = true, bool bWaitingRenderAssetDone = true)
	{
		GameModeController.<NormalSwitchDataLayerInternal>d__44 <NormalSwitchDataLayerInternal>d__;
		<NormalSwitchDataLayerInternal>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<NormalSwitchDataLayerInternal>d__.<>4__this = this;
		<NormalSwitchDataLayerInternal>d__.unloadDataLayers = unloadDataLayers;
		<NormalSwitchDataLayerInternal>d__.activateDataLayers = activateDataLayers;
		<NormalSwitchDataLayerInternal>d__.bEnterLoadingMode = bEnterLoadingMode;
		<NormalSwitchDataLayerInternal>d__.bWaitingRenderAssetDone = bWaitingRenderAssetDone;
		<NormalSwitchDataLayerInternal>d__.<>1__state = -1;
		<NormalSwitchDataLayerInternal>d__.<>t__builder.Start<GameModeController.<NormalSwitchDataLayerInternal>d__44>(ref <NormalSwitchDataLayerInternal>d__);
		return <NormalSwitchDataLayerInternal>d__.<>t__builder.Task;
	}

	// Token: 0x0601D9F4 RID: 121332 RVA: 0x008497A8 File Offset: 0x008479A8
	private unsafe void FakeSwitchDataLayerInternal(IList<string> unloadDataLayers, IList<string> activateDataLayers, int instId, [Nullable(2)] Action<bool> callback = null)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.GameMode;
		ELogAuthor author = ELogAuthor.CJH;
		string message = "伪切换DataLayer:(开始)";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("卸载的DataLayer", (unloadDataLayers != null && unloadDataLayers.Count > 0) ? string.Join(",", unloadDataLayers) : "");
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("加载的DataLayer", (activateDataLayers != null && activateDataLayers.Count > 0) ? string.Join(",", activateDataLayers) : "");
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		Log.Instance.Info(ELogModule.GameMode, ELogAuthor.ZYL, "伪切换DataLayer:更新缓存的DataLayer变更信息", default(ReadOnlySpan<ValueTuple<string, object>>));
		AutoRunModel.Instance.UpdateCachedDataLayerInfo(activateDataLayers, unloadDataLayers, null);
		Log.Instance.Info(ELogModule.GameMode, ELogAuthor.ZYL, "伪切换DataLayer:通知服务器切换完成", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.ChangeDataLayerFinishRequest(instId);
		Log.Instance.Info(ELogModule.GameMode, ELogAuthor.CJH, "伪切换DataLayer:(完成)", default(ReadOnlySpan<ValueTuple<string, object>>));
		GameModeModel instance2 = GameModeModel.Instance;
		if (instance2 != null)
		{
			instance2.SwitchDataLayerContext.FinishDataLayerSwitch();
		}
		if (callback != null)
		{
			callback(true);
		}
	}

	// Token: 0x0601D9F5 RID: 121333 RVA: 0x008498D3 File Offset: 0x00847AD3
	public bool IsInInstance()
	{
		return GameModeModel.Instance.InstanceType >= InstanceType.NormalInstance;
	}

	// Token: 0x0601D9F6 RID: 121334 RVA: 0x008498E8 File Offset: 0x00847AE8
	public bool CanLoadEntity()
	{
		GameModeModel instance = GameModeModel.Instance;
		return instance.WorldDone && !instance.IsTeleport && !instance.ChangeModeState;
	}

	// Token: 0x0601D9F7 RID: 121335 RVA: 0x00849916 File Offset: 0x00847B16
	public void BeforeLoadMap()
	{
		GameModeModel.Instance.BeginLoadMapPromise.SetResult(true);
	}

	// Token: 0x0601D9F8 RID: 121336 RVA: 0x00849928 File Offset: 0x00847B28
	public void InitAllPlayerStarts()
	{
		TArray<AActor> tarray = new TArray<AActor>();
		UGameplayStatics.GetAllActorsOfClass(GlobalData.World, APlayerStart.StaticClass(), ref tarray);
		GameModeModel.Instance.ClearPlayerStart();
		if (tarray.Num() > 0)
		{
			for (int i = 0; i < tarray.Num(); i++)
			{
				GameModeModel.Instance.AddPlayerStart(tarray.Get(i) as APlayerStart);
			}
		}
	}

	// Token: 0x0601D9F9 RID: 121337 RVA: 0x0084998B File Offset: 0x00847B8B
	public void AfterLoadMap()
	{
		this.InitAllPlayerStarts();
		GameModeModel.Instance.OpenLevelPromise.SetResult(true);
	}

	// Token: 0x0601D9FA RID: 121338 RVA: 0x008499A4 File Offset: 0x00847BA4
	protected override void OnTick(float delta)
	{
		if (GameModeModel.Instance.IsMulti || CombatMessageModel.Instance.AnyEntityInFight)
		{
			Heartbeat.Instance.SetHeartBeatMode(HeartbeatDefine.EHeartBeatType.BattleHeartBeat);
		}
		else
		{
			Heartbeat.Instance.SetHeartBeatMode(HeartbeatDefine.EHeartBeatType.NormalHeartBeat);
		}
		if (!GameModeModel.Instance.UseWorldPartition)
		{
			return;
		}
		if (!GameModeModel.Instance.WorldDone)
		{
			return;
		}
		if (GameModeModel.Instance.IsTeleport)
		{
			return;
		}
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		if (baseCharacter == null || !baseCharacter.IsValid())
		{
			return;
		}
		FTransformDouble ftransformDouble = Global.BaseCharacter.D_GetTransform();
		GameModeModel.Instance.UpdateBornLocation(ftransformDouble.GetLocation());
	}

	// Token: 0x0601D9FB RID: 121339 RVA: 0x00849A3C File Offset: 0x00847C3C
	public new void AfterTick(float delta)
	{
		ITimeDilationData cacheTimeDilationValue = GameModeModel.Instance.GetCacheTimeDilationValue();
		if (cacheTimeDilationValue != null)
		{
			this.BroadcastTimeDilation(cacheTimeDilationValue.TimeDilation);
		}
	}

	// Token: 0x0601D9FC RID: 121340 RVA: 0x00849A63 File Offset: 0x00847C63
	private void OnSlowStreamingBySoar(bool bSlow)
	{
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, bSlow ? "wp.Runtime.EnableGridBlackList true" : "wp.Runtime.EnableGridBlackList false", null);
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, bSlow ? "r.CLV.Freeze 1" : "r.CLV.Freeze 0", null);
	}

	// Token: 0x0601D9FD RID: 121341 RVA: 0x00849A9C File Offset: 0x00847C9C
	public unsafe void PrintLoadDetail(FVectorDouble bornLocation)
	{
		LogProfiler loadWorldProfiler = GameModeModel.Instance.LoadWorldProfiler;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.World;
		ELogAuthor author = ELogAuthor.LFJW;
		string message = "加载详情";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("MapPath", GameModeModel.Instance.MapPath);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("耗时", loadWorldProfiler.ToString());
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		List<ValueTuple<string, int>> resourcesLoadTime = PreloadModelNew.Instance.ResourcesLoadTime;
		resourcesLoadTime.Sort(([Nullable(new byte[]
		{
			0,
			1
		})] ValueTuple<string, int> a, [Nullable(new byte[]
		{
			0,
			1
		})] ValueTuple<string, int> b) => b.Item2.CompareTo(a.Item2));
		if (UKuroStaticLibrary.IsWithEditor())
		{
			float piestartTimeInSeconds = UKuroStaticLibrary.GetPIEStartTimeInSeconds();
			float platformTimeInSeconds = UKuroStaticLibrary.GetPlatformTimeInSeconds();
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.GameMode;
			ELogAuthor author2 = ELogAuthor.BLZ;
			string message2 = "[LoadPhase] LoadingTime Start";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("time", piestartTimeInSeconds);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.GameMode;
			ELogAuthor author3 = ELogAuthor.BLZ;
			string message3 = "[LoadPhase] LoadingTime End";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("time", platformTimeInSeconds);
			instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			string commandLine = UKismetSystemLibrary.GetCommandLine();
			string value = GameModeController.<PrintLoadDetail>g__GetCmdValue|54_1(commandLine, "-KuroPipelineTag=");
			string[] array = GameModeController.<PrintLoadDetail>g__GetCmdValue|54_1(commandLine, "-KuroTsSilentLoginTestFile=").Replace('/', '\\').Split('\\', StringSplitOptions.None);
			string value2 = array[array.Length - 1];
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary["Version"] = BaseConfigController.Instance.GetVersionString();
			dictionary["LoadingTime"] = platformTimeInSeconds - piestartTimeInSeconds;
			dictionary["MapPath"] = GameModeModel.Instance.MapPath;
			dictionary["BornLocation"] = bornLocation.ToString();
			dictionary["TestName"] = value2;
			dictionary["PipelineTag"] = value;
			string text = Json.Stringify<Dictionary<string, object>>(dictionary, null);
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.GameMode;
			ELogAuthor author4 = ELogAuthor.HMH;
			string message4 = "UE_TraceProfile_Event";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("value", text);
			instance4.Info(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			if (FThinkingAnalyticsForCSharp.Track("UE_TraceProfile_Event", text, 21))
			{
				TimerSystem.Instance.Next(delegate(float _)
				{
					FThinkingAnalyticsForCSharp.Flush(21);
				}, null, null);
			}
			else
			{
				Log.Instance.Warn(ELogModule.GameMode, ELogAuthor.HMH, "TraceProfile report fail", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		}
		if (!PreloadModelNew.Instance.LoadAssetOneByOneState)
		{
			return;
		}
		int num = 0;
		while (num < 20 && num < resourcesLoadTime.Count)
		{
			ValueTuple<string, int> valueTuple4 = resourcesLoadTime[num];
			int item = valueTuple4.Item2;
			string item2;
			if (item < 1000)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(item);
				defaultInterpolatedStringHandler.AppendLiteral(" ms");
				item2 = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(item / 1000);
				defaultInterpolatedStringHandler.AppendLiteral(" s");
				item2 = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			Log instance5 = Log.Instance;
			ELogModule module5 = ELogModule.World;
			ELogAuthor author5 = ELogAuthor.LFJW;
			string message5 = "资源耗时Top20";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("耗时", item2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("资源路径", valueTuple4.Item1);
			instance5.Info(module5, author5, message5, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			num++;
		}
		PreloadModelNew.Instance.ClearResourcesLoadTime();
	}

	// Token: 0x0601D9FE RID: 121342 RVA: 0x00849DF4 File Offset: 0x00847FF4
	private void InitDataReport()
	{
		EntryJson entryJson = BaseConfigModel.Instance.EntryJson;
		ITDConfig itdconfig = (entryJson != null) ? entryJson.TDCfg : null;
		string serverUrl = ((itdconfig != null) ? itdconfig.URL : null) ?? "https://cn-datareceiver.aki-game.com";
		string appId = ((itdconfig != null) ? itdconfig.AppID : null) ?? "0d45e80772374d95a961daf5316265e3";
		if (itdconfig == null)
		{
			Log.Instance.Warn(ELogModule.GameMode, ELogAuthor.HMH, "Thinking Analytics init fail, TDCfg is empty", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		int maxNumInBatch = 1000;
		if (UThinkingAnalytics.HasInstanceInitialized(21))
		{
			return;
		}
		FCreateInstanceParam fcreateInstanceParam = new FCreateInstanceParam(21, serverUrl, appId, UThinkingAnalytics.GetMachineID(), "", "GameController", "", maxNumInBatch, TAMode.NORMAL, UnrealEngine.ESaveMode.None_Save, 0f, true, false, false, true, 1f, 1000, 10000f, true, 10f, true, true);
		if (!UThinkingAnalytics.CreateSimpleInstance(fcreateInstanceParam))
		{
			Log.Instance.Warn(ELogModule.GameMode, ELogAuthor.HMH, "Thinking Analytics instance create fail", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
	}

	// Token: 0x0601D9FF RID: 121343 RVA: 0x00849EDC File Offset: 0x008480DC
	public unsafe bool SetGamePaused(bool bPaused, string reason, float unPausedTimeDilation = 1f)
	{
		Time.Instance.OriginTimeDilation = unPausedTimeDilation;
		HashSet<string> gamePausedReasons = GameModeModel.Instance.GamePausedReasons;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.GameMode;
		ELogAuthor author = ELogAuthor.XWX;
		string message = "时停:调用真时停";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("bPaused", bPaused);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("reason", reason);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("unPausedTimeDilation", unPausedTimeDilation);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		if (GameModeModel.Instance.ForceDisableGamePaused)
		{
			Log.Instance.Info(ELogModule.GameMode, ELogAuthor.XWX, "时停:缓存真时停:由于强制设置时停", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (!bPaused)
			{
				if (gamePausedReasons.Contains(reason))
				{
					gamePausedReasons.Remove(reason);
				}
				return false;
			}
			if (!gamePausedReasons.Contains(reason))
			{
				gamePausedReasons.Add(reason);
			}
		}
		UKuroGameBudgetSubSystem ukuroGameBudgetSubSystem = USubsystemBlueprintLibrary.GetWorldSubsystem(GlobalData.World, UKuroGameBudgetSubSystem.StaticClass()) as UKuroGameBudgetSubSystem;
		if (bPaused)
		{
			if (gamePausedReasons.Contains(reason))
			{
				Log.Instance.Info(ELogModule.GameMode, ELogAuthor.XWX, "时停:已存在该时停", default(ReadOnlySpan<ValueTuple<string, object>>));
				return true;
			}
			gamePausedReasons.Add(reason);
			TickSystem.Instance.IsPaused = true;
			EventSystem.Instance.Emit<bool>(EEventName.TsSyncTickPauseState, TickSystem.Instance.IsSetPaused);
			UKuroGameBudgetAllocatorCSharpInterface.SetPauseFrame((ulong)UKismetSystemLibrary.GetFrameCount());
			this.SetTimeDilation(0f, ETimeDilationType.Pause);
			Time.Instance.LastPauseTimeFrame = Time.Instance.Frame;
			Log.Instance.Info(ELogModule.GameMode, ELogAuthor.XWX, "时停:执行真时停", default(ReadOnlySpan<ValueTuple<string, object>>));
			EventSystem.Instance.Emit<bool>(EEventName.OnSetGamePaused, true);
			if (ukuroGameBudgetSubSystem != null)
			{
				ukuroGameBudgetSubSystem.SetGamePaused(bPaused);
			}
			return UGameplayStatics.SetGamePaused(GlobalData.World, true);
		}
		else
		{
			if (gamePausedReasons.Contains(reason))
			{
				gamePausedReasons.Remove(reason);
			}
			if (gamePausedReasons.Count == 0)
			{
				TickSystem.Instance.IsPaused = false;
				EventSystem.Instance.Emit<bool>(EEventName.TsSyncTickPauseState, TickSystem.Instance.IsSetPaused);
				this.SetTimeDilation(unPausedTimeDilation, ETimeDilationType.Pause);
				Time.Instance.LastResumeTimeFrame = Time.Instance.Frame;
				Log.Instance.Info(ELogModule.GameMode, ELogAuthor.XWX, "时停:解除真时停", default(ReadOnlySpan<ValueTuple<string, object>>));
				EventSystem.Instance.Emit<bool>(EEventName.OnSetGamePaused, false);
				if (ukuroGameBudgetSubSystem != null)
				{
					ukuroGameBudgetSubSystem.SetGamePaused(bPaused);
				}
				return UGameplayStatics.SetGamePaused(GlobalData.World, false);
			}
			return true;
		}
	}

	// Token: 0x0601DA00 RID: 121344 RVA: 0x0084A148 File Offset: 0x00848348
	public void CheckAndUpdateGamePaused()
	{
		HashSet<string> gamePausedReasons = GameModeModel.Instance.GamePausedReasons;
		Log.Instance.Info(ELogModule.GameMode, ELogAuthor.JYS, "时停:调用真时停检查", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (gamePausedReasons.Count == 0)
		{
			TickSystem.Instance.IsPaused = false;
			EventSystem.Instance.Emit<bool>(EEventName.TsSyncTickPauseState, TickSystem.Instance.IsSetPaused);
			this.SetTimeDilation(1f, ETimeDilationType.Pause);
			Time.Instance.LastResumeTimeFrame = Time.Instance.Frame;
			Log.Instance.Info(ELogModule.GameMode, ELogAuthor.XWX, "时停:gamePausedReasons = 0,解除真时停", default(ReadOnlySpan<ValueTuple<string, object>>));
			EventSystem.Instance.Emit<bool>(EEventName.OnSetGamePaused, false);
			UGameplayStatics.SetGamePaused(GlobalData.World, false);
		}
	}

	// Token: 0x0601DA01 RID: 121345 RVA: 0x0084A200 File Offset: 0x00848400
	public void ForceDisableGamePaused(bool value)
	{
		if (value)
		{
			GameModeModel.Instance.ForceDisableGamePaused = true;
			TickSystem.Instance.IsPaused = false;
			EventSystem.Instance.Emit<bool>(EEventName.TsSyncTickPauseState, TickSystem.Instance.IsSetPaused);
			this.SetTimeDilation(1f, ETimeDilationType.Teleport);
			Time.Instance.LastResumeTimeFrame = Time.Instance.Frame;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GameMode;
			ELogAuthor author = ELogAuthor.XWX;
			string message = "时停:强制解除真时停";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("timeDilation", Time.Instance.OriginTimeDilation);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			EventSystem.Instance.Emit<bool>(EEventName.OnSetGamePaused, false);
			UGameplayStatics.SetGamePaused(GlobalData.World, false);
			return;
		}
		GameModeModel.Instance.ForceDisableGamePaused = false;
		if (GameModeModel.Instance.GamePausedReasons.Count > 0)
		{
			TickSystem.Instance.IsPaused = true;
			EventSystem.Instance.Emit<bool>(EEventName.TsSyncTickPauseState, TickSystem.Instance.IsSetPaused);
			UKuroGameBudgetAllocatorCSharpInterface.SetPauseFrame((ulong)UKismetSystemLibrary.GetFrameCount());
			this.SetTimeDilation(1f, ETimeDilationType.Teleport);
			Time.Instance.LastPauseTimeFrame = Time.Instance.Frame;
			Log.Instance.Info(ELogModule.GameMode, ELogAuthor.XWX, "时停:恢复强制解除, Set中存在reason, 执行真时停", default(ReadOnlySpan<ValueTuple<string, object>>));
			EventSystem.Instance.Emit<bool>(EEventName.OnSetGamePaused, true);
			UGameplayStatics.SetGamePaused(GlobalData.World, true);
			return;
		}
		this.SetTimeDilation(1f, ETimeDilationType.Teleport);
		GameModeController.Instance.CheckAndUpdateGamePaused();
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.GameMode;
		ELogAuthor author2 = ELogAuthor.XWX;
		string message2 = "时停:恢复强制解除, Set中不存在reason, 不执行真时停";
		ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("timeDilation", Time.Instance.OriginTimeDilation);
		instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
	}

	// Token: 0x0601DA02 RID: 121346 RVA: 0x0084A3AC File Offset: 0x008485AC
	public unsafe void SetTimeDilation(float timeDilation, ETimeDilationType timeDilationType = ETimeDilationType.Default)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.GameMode;
		ELogAuthor author = ELogAuthor.XWX;
		string message = "时停:调用假时停";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("timeDilation", timeDilation);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("timeDilationType", timeDilationType);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		Dictionary<ETimeDilationType, float> timeDilationMap = GameModeModel.Instance.TimeDilationMap;
		if (timeDilation == 1f)
		{
			timeDilationMap.Remove(timeDilationType);
		}
		else
		{
			timeDilationMap[timeDilationType] = timeDilation;
		}
		if (GameModeModel.Instance.ForceDisableGamePaused)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.GameMode;
			ELogAuthor author2 = ELogAuthor.JYS;
			string message2 = "时停:由于在传送过程中，不执行假时停，只保存";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("timeDilation", timeDilation);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("timeDilationType", timeDilationType);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return;
		}
		float num = 1f;
		float num2 = 1f;
		foreach (KeyValuePair<ETimeDilationType, float> keyValuePair in timeDilationMap)
		{
			num *= keyValuePair.Value;
			if ((keyValuePair.Key & ETimeDilationType.PhantomBattleArena) == ETimeDilationType.Default)
			{
				num2 *= keyValuePair.Value;
			}
		}
		if ((double)num < 1E-08)
		{
			num = 0f;
		}
		if ((double)num2 < 1E-08)
		{
			num2 = 0f;
		}
		if ((timeDilationType & ETimeDilationType.PhantomBattleArena) == ETimeDilationType.Default)
		{
			Time.Instance.OriginTimeDilation = num2;
		}
		Log instance3 = Log.Instance;
		ELogModule module3 = ELogModule.GameMode;
		ELogAuthor author3 = ELogAuthor.XWX;
		string message3 = "时停:假时停计算后的值";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("finalDilation", num);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("finalDilationWithoutPause", num2);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("Time.OriginTimeDilation", Time.Instance.OriginTimeDilation);
		instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
		if (TickSystem.Instance.IsSetPaused && !TickSystem.Instance.IsPaused)
		{
			GameModeModel.Instance.SetCacheTimeDilationValue(num);
			return;
		}
		this.BroadcastTimeDilation(num);
	}

	// Token: 0x0601DA03 RID: 121347 RVA: 0x0084A5F0 File Offset: 0x008487F0
	private void BroadcastTimeDilation(float finalDilation)
	{
		GameModeModel.Instance.ClearCacheTimeDilationValue();
		Time.Instance.SetTimeDilation(finalDilation);
		TimeOfDayController.Instance.ChangeTimeScale(finalDilation);
		CharacterController.Instance.SetTimeDilation(finalDilation);
		FormationDataController.Instance.SetTimeDilation(finalDilation);
		BulletController.Instance.SetTimeDilation(finalDilation);
		CameraController.Instance.SetTimeDilation(finalDilation, "MainCamera");
		ComponentForceTickController.Instance.SetTimeDilation(finalDilation);
		EffectEnvironment.Instance.GlobalTimeScale = finalDilation;
		TimeStopPush timeStopPush = TimeStopPush.Create();
		timeStopPush.TimeDilation = finalDilation;
		Net.Instance.Send(EPushMessageId.TimeStopPush, timeStopPush);
		if (finalDilation == 0f)
		{
			EventSystem.Instance.Emit<int>(EEventName.PauseGame, 1);
		}
		if (finalDilation == 1f)
		{
			EventSystem.Instance.Emit<int>(EEventName.PauseGame, 0);
		}
		EventSystem.Instance.Emit(EEventName.TriggerUiTimeDilation);
	}

	// Token: 0x0601DA04 RID: 121348 RVA: 0x0084A6C0 File Offset: 0x008488C0
	[NullableContext(2)]
	public void FixBornLocation(global::Vector target = null)
	{
		if (Global.BaseCharacter == null)
		{
			return;
		}
		CharacterActorComponent characterActorComponent = Global.BaseCharacter.CharacterActorComponent;
		RoleDriveVehicleComponent roleDriveVehicleComponent = (characterActorComponent != null) ? characterActorComponent.Entity.GetComponent<RoleDriveVehicleComponent>() : null;
		if (roleDriveVehicleComponent != null && roleDriveVehicleComponent.IsOnVehicle)
		{
			return;
		}
		if (target != null)
		{
			Global.BaseCharacter.CharacterActorComponent.TeleportAndFindStandLocation(target, true);
		}
		else
		{
			Global.BaseCharacter.CharacterActorComponent.FixBornLocation("主控玩家.修正地面", true, null, false, false, true);
		}
		Global.BaseCharacter.KuroSetMovementMode(new SetMovementModeInfo
		{
			Mode = EMovementMode.MOVE_Walking,
			Context = "[GameModeController.FixBornLocation]"
		});
		Entity entity = Global.BaseCharacter.CharacterActorComponent.Entity;
		CharacterAnimationComponent component = entity.GetComponent<CharacterAnimationComponent>();
		if (component != null)
		{
			UAnimInstance mainAnimInstance = component.MainAnimInstance;
			if (mainAnimInstance != null)
			{
				mainAnimInstance.SyncAnimStates(null);
			}
		}
		CharacterMoveComponent component2 = entity.GetComponent<CharacterMoveComponent>();
		if (component2 != null)
		{
			component2.StopAllAddMove();
		}
		CharacterUnifiedStateComponent component3 = entity.GetComponent<CharacterUnifiedStateComponent>();
		if (component3 == null)
		{
			return;
		}
		component3.ResetCharState();
	}

	// Token: 0x0601DA05 RID: 121349 RVA: 0x0084A79C File Offset: 0x0084899C
	public void LoadDataLayers(SceneInformation sceneInformation)
	{
		RenderModuleController.Instance.SetWorldPartitionDataLayerState("DatalayerRuntime_HideInLowMemDevice", !UKuroStaticLibrary.IsLowMemoryDevice(), false);
		if (((sceneInformation != null) ? sceneInformation.DataLayers : null) == null)
		{
			return;
		}
		List<string> list = new List<string>(GameModeModel.Instance.GetAllDataLayers());
		foreach (int num in sceneInformation.DataLayers)
		{
			DataLayerConfig? config = ConfigDataLayerConfigById.GetConfig(num, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.GameMode;
				ELogAuthor author = ELogAuthor.LFJW;
				string message = "加载场景:加载DataLayer失败,不存在的配置Id";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("DataLayerId", num);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			else
			{
				string dataLayer = config.Value.DataLayer;
				if (GameModeModel.Instance.HasDataLayer(dataLayer))
				{
					list.Remove(dataLayer);
				}
				else
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.GameMode;
					ELogAuthor author2 = ELogAuthor.LFJW;
					string message2 = "加载场景:加载DataLayer";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("DataLayer", dataLayer);
					instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					GameModeController.Instance.ActivateDataLayer(dataLayer);
				}
			}
		}
		foreach (string dataLayerPath in list)
		{
			GameModeController.Instance.UnloadDataLayer(dataLayerPath);
		}
	}

	// Token: 0x0601DA06 RID: 121350 RVA: 0x0084A904 File Offset: 0x00848B04
	private void ActivateDataLayer(string dataLayerPath)
	{
		GameModeModel.Instance.AddDataLayer(dataLayerPath);
		RenderModuleController.Instance.SetWorldPartitionDataLayerState(dataLayerPath, true, false);
	}

	// Token: 0x0601DA07 RID: 121351 RVA: 0x0084A91F File Offset: 0x00848B1F
	private void UnloadDataLayer(string dataLayerPath)
	{
		GameModeModel.Instance.RemoveDataLayer(dataLayerPath);
		RenderModuleController.Instance.SetWorldPartitionDataLayerState(dataLayerPath, false, false);
	}

	// Token: 0x0601DA08 RID: 121352 RVA: 0x0084A93C File Offset: 0x00848B3C
	private void ChangeDataLayerFinishRequest(int instId)
	{
		ChangeDataLayerFinishRequest changeDataLayerFinishRequest = Aki.Protocol.ChangeDataLayerFinishRequest.Create();
		changeDataLayerFinishRequest.InstId = instId;
		Net.Instance.Call(ERequestMessageId.ChangeDataLayerFinishRequest, changeDataLayerFinishRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ChangeDataLayerFinishResponse changeDataLayerFinishResponse = (ChangeDataLayerFinishResponse)msg;
			if (changeDataLayerFinishResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(changeDataLayerFinishResponse.ErrorCode, 27963, null, true, true);
			}
		}, 0);
	}

	// Token: 0x0601DA09 RID: 121353 RVA: 0x0084A988 File Offset: 0x00848B88
	public unsafe void ApplyMaterialParameterCollection(IDictionary<int, int> protoAreaMpc)
	{
		GameModeModel.Instance.MaterialParameterCollectionMap.Clear();
		foreach (KeyValuePair<int, int> keyValuePair in protoAreaMpc)
		{
			int key = keyValuePair.Key;
			string mpcData = ConfigAreaMpcById.GetConfig(keyValuePair.Value, true).Value.MpcData;
			if (string.IsNullOrEmpty(mpcData) || mpcData == "None" || mpcData == "Empty")
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.GameMode;
				ELogAuthor author = ELogAuthor.CJH;
				string message = "加载场景: 未配置对应区域的MPCData";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("AreaId", key);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("MpcData", mpcData);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			else
			{
				GameModeModel.Instance.MaterialParameterCollectionMap[mpcData] = false;
			}
		}
		if (GameModeModel.Instance.MaterialParameterCollectionMap.Count == 0)
		{
			GameModeModel.Instance.ApplyMaterialParameterCollectionPromise.SetResult(true);
			return;
		}
		using (Dictionary<string, bool>.KeyCollection.Enumerator enumerator2 = GameModeModel.Instance.MaterialParameterCollectionMap.Keys.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				string inPath = enumerator2.Current;
				ResourceSystem.Instance.LoadAsync<ItemMaterialControllerMPCData_C>(inPath, delegate([Nullable(2)] ItemMaterialControllerMPCData_C data, string _)
				{
					if (data == null || !data.IsValid())
					{
						Log.Instance.Error(ELogModule.GameMode, ELogAuthor.CJH, "加载场景: MPCData无效", default(ReadOnlySpan<ValueTuple<string, object>>));
						GameModeModel.Instance.MaterialParameterCollectionMap[inPath] = true;
						GameModeController.Instance.CheckMaterialParameterCollectionLoaded();
						return;
					}
					RenderModuleModel.Instance.UpdateItemMaterialParameterCollection(data);
					GameModeModel.Instance.MaterialParameterCollectionMap[inPath] = true;
					GameModeController.Instance.CheckMaterialParameterCollectionLoaded();
				}, 100, "js_undefined");
			}
		}
	}

	// Token: 0x0601DA0A RID: 121354 RVA: 0x0084AB34 File Offset: 0x00848D34
	private void CheckMaterialParameterCollectionLoaded()
	{
		bool flag = true;
		foreach (bool flag2 in GameModeModel.Instance.MaterialParameterCollectionMap.Values)
		{
			flag = (flag2 && flag);
		}
		if (flag)
		{
			GameModeModel.Instance.ApplyMaterialParameterCollectionPromise.SetResult(true);
		}
	}

	// Token: 0x0601DA0B RID: 121355 RVA: 0x0084ABA0 File Offset: 0x00848DA0
	public UniTask SwitchStreamingSource(AActor actor, bool waitForStreaming, bool bLockMovementDuringStreaming, EMovementLockMode? movementLockModeAfterStreaming)
	{
		GameModeController.<SwitchStreamingSource>d__68 <SwitchStreamingSource>d__;
		<SwitchStreamingSource>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SwitchStreamingSource>d__.<>4__this = this;
		<SwitchStreamingSource>d__.actor = actor;
		<SwitchStreamingSource>d__.waitForStreaming = waitForStreaming;
		<SwitchStreamingSource>d__.bLockMovementDuringStreaming = bLockMovementDuringStreaming;
		<SwitchStreamingSource>d__.movementLockModeAfterStreaming = movementLockModeAfterStreaming;
		<SwitchStreamingSource>d__.<>1__state = -1;
		<SwitchStreamingSource>d__.<>t__builder.Start<GameModeController.<SwitchStreamingSource>d__68>(ref <SwitchStreamingSource>d__);
		return <SwitchStreamingSource>d__.<>t__builder.Task;
	}

	// Token: 0x0601DA0C RID: 121356 RVA: 0x0084AC04 File Offset: 0x00848E04
	public UniTask ResetStreamingSourceAttachment()
	{
		GameModeController.<ResetStreamingSourceAttachment>d__69 <ResetStreamingSourceAttachment>d__;
		<ResetStreamingSourceAttachment>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ResetStreamingSourceAttachment>d__.<>4__this = this;
		<ResetStreamingSourceAttachment>d__.<>1__state = -1;
		<ResetStreamingSourceAttachment>d__.<>t__builder.Start<GameModeController.<ResetStreamingSourceAttachment>d__69>(ref <ResetStreamingSourceAttachment>d__);
		return <ResetStreamingSourceAttachment>d__.<>t__builder.Task;
	}

	// Token: 0x0601DA0D RID: 121357 RVA: 0x0084AC48 File Offset: 0x00848E48
	private UniTask CheckWorldPartitionStreamingCompleted(CustomPromise<bool> voxelPromise, CustomPromise<bool> streamingPromise, [Nullable(2)] Func<bool> abortCheckCondition = null)
	{
		GameModeController.<CheckWorldPartitionStreamingCompleted>d__70 <CheckWorldPartitionStreamingCompleted>d__;
		<CheckWorldPartitionStreamingCompleted>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckWorldPartitionStreamingCompleted>d__.<>4__this = this;
		<CheckWorldPartitionStreamingCompleted>d__.voxelPromise = voxelPromise;
		<CheckWorldPartitionStreamingCompleted>d__.streamingPromise = streamingPromise;
		<CheckWorldPartitionStreamingCompleted>d__.abortCheckCondition = abortCheckCondition;
		<CheckWorldPartitionStreamingCompleted>d__.<>1__state = -1;
		<CheckWorldPartitionStreamingCompleted>d__.<>t__builder.Start<GameModeController.<CheckWorldPartitionStreamingCompleted>d__70>(ref <CheckWorldPartitionStreamingCompleted>d__);
		return <CheckWorldPartitionStreamingCompleted>d__.<>t__builder.Task;
	}

	// Token: 0x0601DA0E RID: 121358 RVA: 0x0084ACA4 File Offset: 0x00848EA4
	[NullableContext(2)]
	[return: Nullable(1)]
	private unsafe TimerHandle CheckTargetStreamingCompleted([Nullable(1)] UWorldPartitionStreamingSourceComponent streamingSourceComponent, [Nullable(new byte[]
	{
		0,
		1,
		1
	})] OneOf<CustomPromise<bool>, GameModePromise> completedPromise, TArray<FName> dataLayerLabels = null, Action<double> progressUpdated = null, bool checkPhysics = false, Func<bool> abortCheckCondition = null)
	{
		TArray<FName> targetGrids = streamingSourceComponent.TargetGrids;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.World;
		ELogAuthor author = ELogAuthor.XY;
		string message = "[CheckTargetStreamingCompleted] 检测参数";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("dataLayers", (dataLayerLabels != null && dataLayerLabels.Num() > 0) ? dataLayerLabels.Get(0).ToString() : null);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("targetGrids", (targetGrids != null && targetGrids.Num() > 0) ? targetGrids.Get(0).ToString() : null);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		bool isCheckingPhysics = false;
		int streamingStuckLogInternal = 0;
		TimerHandle timerId = null;
		timerId = TimerSystem.Instance.Forever(delegate(float _)
		{
			Func<bool> abortCheckCondition2 = abortCheckCondition;
			if (abortCheckCondition2 != null && abortCheckCondition2())
			{
				Log.Instance.Info(ELogModule.World, ELogAuthor.CK, "检查加载场景提前结束", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			else
			{
				if (!isCheckingPhysics)
				{
					bool flag = streamingSourceComponent.IsStreamingCompletedForLayers2(dataLayerLabels ?? new TArray<FName>(), false, 7000f, true, ref this.cellProgress, false);
					Action<double> progressUpdated2 = progressUpdated;
					if (progressUpdated2 != null)
					{
						progressUpdated2((double)this.cellProgress);
					}
					if (!flag)
					{
						base.<CheckTargetStreamingCompleted>g__TimerStreamingStuckLog|1(isCheckingPhysics);
						return;
					}
					isCheckingPhysics = checkPhysics;
					if (isCheckingPhysics)
					{
						Log.Instance.Info(ELogModule.GameMode, ELogAuthor.XY, "加载场景:检测场景物理体(开始)", default(ReadOnlySpan<ValueTuple<string, object>>));
					}
				}
				if (isCheckingPhysics)
				{
					if (!streamingSourceComponent.IsStreamingCompletedForLayers2(dataLayerLabels ?? new TArray<FName>(), false, 7000f, false, ref this.cellProgress, true))
					{
						base.<CheckTargetStreamingCompleted>g__TimerStreamingStuckLog|1(isCheckingPhysics);
						return;
					}
					Log.Instance.Info(ELogModule.GameMode, ELogAuthor.XY, "加载场景:检测场景物理体(结束)", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
			}
			TimerSystem.Instance.Remove(timerId);
			if (completedPromise.IsT1)
			{
				completedPromise.AsT1.SetResult(true);
				return;
			}
			if (completedPromise.IsT2)
			{
				completedPromise.AsT2.SetResult(true);
			}
		}, 100f, 1f, null, null, true);
		return timerId;
	}

	// Token: 0x0601DA0F RID: 121359 RVA: 0x0084ADE4 File Offset: 0x00848FE4
	public void InitStreamingSources()
	{
		GameModeModel instance = GameModeModel.Instance;
		if (!GlobalData.World.GetWorld().K2_GetWorldSettings().bEnableWorldPartition || instance.BornLocation == null)
		{
			return;
		}
		instance.InitStreamingSources();
	}

	// Token: 0x0601DA10 RID: 121360 RVA: 0x0084AE24 File Offset: 0x00849024
	public UniTask CheckVoxelStreamingCompleted(float relativeProgress, int maxProgress)
	{
		GameModeController.<CheckVoxelStreamingCompleted>d__73 <CheckVoxelStreamingCompleted>d__;
		<CheckVoxelStreamingCompleted>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckVoxelStreamingCompleted>d__.<>4__this = this;
		<CheckVoxelStreamingCompleted>d__.relativeProgress = relativeProgress;
		<CheckVoxelStreamingCompleted>d__.maxProgress = maxProgress;
		<CheckVoxelStreamingCompleted>d__.<>1__state = -1;
		<CheckVoxelStreamingCompleted>d__.<>t__builder.Start<GameModeController.<CheckVoxelStreamingCompleted>d__73>(ref <CheckVoxelStreamingCompleted>d__);
		return <CheckVoxelStreamingCompleted>d__.<>t__builder.Task;
	}

	// Token: 0x0601DA11 RID: 121361 RVA: 0x0084AE78 File Offset: 0x00849078
	public void AppendAllBaseDatalayers(TArray<FName> dataLayerLabels)
	{
		foreach (FName value in WorldDefine.allBaseDataLayers)
		{
			dataLayerLabels.Add(value);
		}
	}

	// Token: 0x0601DA12 RID: 121362 RVA: 0x0084AEA8 File Offset: 0x008490A8
	public UniTask CheckStreamingCompleted(float relativeProgress, int maxProgress)
	{
		GameModeController.<CheckStreamingCompleted>d__75 <CheckStreamingCompleted>d__;
		<CheckStreamingCompleted>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckStreamingCompleted>d__.<>4__this = this;
		<CheckStreamingCompleted>d__.relativeProgress = relativeProgress;
		<CheckStreamingCompleted>d__.maxProgress = maxProgress;
		<CheckStreamingCompleted>d__.<>1__state = -1;
		<CheckStreamingCompleted>d__.<>t__builder.Start<GameModeController.<CheckStreamingCompleted>d__75>(ref <CheckStreamingCompleted>d__);
		return <CheckStreamingCompleted>d__.<>t__builder.Task;
	}

	// Token: 0x0601DA13 RID: 121363 RVA: 0x0084AEFC File Offset: 0x008490FC
	public void AddOrRemoveRenderAssetsQueryViewInfo(FVectorDouble viewOrigin, float duration)
	{
		if (!GlobalData.World.GetWorld().K2_GetWorldSettings().bEnableWorldPartition)
		{
			return;
		}
		UWorldPartitionSubsystem uworldPartitionSubsystem = UKuroRenderingRuntimeBPPluginBPLibrary.GetSubsystem(GlobalData.World, UWorldPartitionSubsystem.StaticClass()) as UWorldPartitionSubsystem;
		if (uworldPartitionSubsystem == null || !uworldPartitionSubsystem.IsValid())
		{
			return;
		}
		uworldPartitionSubsystem.D_AddOrRemoveRenderAssetsQueryViewInfo(viewOrigin, duration, 1.2f);
	}

	// Token: 0x0601DA14 RID: 121364 RVA: 0x0084AF5C File Offset: 0x0084915C
	[NullableContext(2)]
	private void ResetRenderAssetsQuery(UWorldPartitionSubsystem worldPartitionSubsystem = null, FWorldPartitionStreamingQuerySource querySource = null, bool raiseError = false)
	{
		GameModeModel instance = GameModeModel.Instance;
		TimerHandle checkRenderAssetsStreamingCompletedTimerId = instance.CheckRenderAssetsStreamingCompletedTimerId;
		if (checkRenderAssetsStreamingCompletedTimerId != null && checkRenderAssetsStreamingCompletedTimerId.Valid())
		{
			TimerSystem.Instance.Remove(instance.CheckRenderAssetsStreamingCompletedTimerId);
			instance.CheckRenderAssetsStreamingCompletedTimerId = null;
			if (worldPartitionSubsystem == null)
			{
				worldPartitionSubsystem = (UKuroRenderingRuntimeBPPluginBPLibrary.GetSubsystem(GlobalData.World, UWorldPartitionSubsystem.StaticClass()) as UWorldPartitionSubsystem);
			}
			if (querySource == null)
			{
				querySource = new FWorldPartitionStreamingQuerySource();
			}
			worldPartitionSubsystem.IsRenderAssetsStreamingCompleted(querySource, false, false, true);
			if (raiseError)
			{
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.World;
				ELogAuthor author = ELogAuthor.XY;
				string message = "检查渲染资源(异常结束)";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("是否超时", false);
				instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}
	}

	// Token: 0x0601DA15 RID: 121365 RVA: 0x0084B008 File Offset: 0x00849208
	[return: Nullable(0)]
	public UniTask<bool> CheckRenderAssetsStreamingCompleted(FVectorDouble viewOrigin, string reason, Func<bool> abortCheckCondition = null)
	{
		GameModeController.<CheckRenderAssetsStreamingCompleted>d__78 <CheckRenderAssetsStreamingCompleted>d__;
		<CheckRenderAssetsStreamingCompleted>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<CheckRenderAssetsStreamingCompleted>d__.<>4__this = this;
		<CheckRenderAssetsStreamingCompleted>d__.viewOrigin = viewOrigin;
		<CheckRenderAssetsStreamingCompleted>d__.reason = reason;
		<CheckRenderAssetsStreamingCompleted>d__.abortCheckCondition = abortCheckCondition;
		<CheckRenderAssetsStreamingCompleted>d__.<>1__state = -1;
		<CheckRenderAssetsStreamingCompleted>d__.<>t__builder.Start<GameModeController.<CheckRenderAssetsStreamingCompleted>d__78>(ref <CheckRenderAssetsStreamingCompleted>d__);
		return <CheckRenderAssetsStreamingCompleted>d__.<>t__builder.Task;
	}

	// Token: 0x0601DA16 RID: 121366 RVA: 0x0084B064 File Offset: 0x00849264
	public void CheckPreload(Action<bool> commonCallback, [Nullable(2)] Action<bool> callback = null)
	{
		PreloadControllerNew.Instance.DoPreload(delegate(bool commonResult)
		{
			Action<bool> commonCallback2 = commonCallback;
			if (commonCallback2 == null)
			{
				return;
			}
			commonCallback2(commonResult);
		}).ContinueWith(delegate(bool result)
		{
			GameModeModel.Instance.PreloadPromise.SetResult(result);
			Action<bool> callback2 = callback;
			if (callback2 == null)
			{
				return;
			}
			callback2(result);
		});
	}

	// Token: 0x0601DA17 RID: 121367 RVA: 0x0084B0B0 File Offset: 0x008492B0
	[NullableContext(0)]
	public UniTask<bool> OpenLoading()
	{
		GameModeController.<OpenLoading>d__80 <OpenLoading>d__;
		<OpenLoading>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OpenLoading>d__.<>1__state = -1;
		<OpenLoading>d__.<>t__builder.Start<GameModeController.<OpenLoading>d__80>(ref <OpenLoading>d__);
		return <OpenLoading>d__.<>t__builder.Task;
	}

	// Token: 0x0601DA18 RID: 121368 RVA: 0x0084B0EB File Offset: 0x008492EB
	[NullableContext(2)]
	public void SetTravelMp4(bool play, string path = null)
	{
		if (play && string.IsNullOrEmpty(path))
		{
			return;
		}
		GameModeModel.Instance.PlayTravelMp4 = play;
		GameModeModel.Instance.TravelMp4Path = path;
	}

	// Token: 0x0601DA19 RID: 121369 RVA: 0x0084B110 File Offset: 0x00849310
	public void ChangeGameMode()
	{
		Log.Instance.Info(ELogModule.World, ELogAuthor.LFJW, "[Game.ChangeMode] ChangeMode", default(ReadOnlySpan<ValueTuple<string, object>>));
		try
		{
			ControllerManager.Instance.ChangeMode();
		}
		catch (Exception ex)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Game;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "[Game.ChangeMode] 调用ControllerManager.ChangeMode异常。";
			Exception error = ex;
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("error", ex.Message);
			instance.ErrorWithStack(module, author, message, error, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		try
		{
			ModelManager.Instance.ChangeMode();
		}
		catch (Exception ex2)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Game;
			ELogAuthor author2 = ELogAuthor.LFJW;
			string message2 = "[Game.ChangeMode] 调用ModelManager.ChangeMode异常。";
			Exception error2 = ex2;
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("error", ex2.Message);
			instance2.ErrorWithStack(module2, author2, message2, error2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		}
	}

	// Token: 0x0601DA1A RID: 121370 RVA: 0x0084B1D0 File Offset: 0x008493D0
	public void UpdateFoliageDataLayer()
	{
		AWorldSettings aworldSettings = GlobalData.World.GetWorld().K2_GetWorldSettings();
		if (aworldSettings == null || !aworldSettings.bEnableWorldPartition)
		{
			return;
		}
		EGameQualitySettingLevel gameQualitySettingLevel = GameSettingsDeviceRender.Instance.GameQualitySettingLevel;
		UKuroRenderingRuntimeBPPluginBPLibrary.UpdateFoliageDataLayer(GlobalData.World, (int)((gameQualitySettingLevel < EGameQualitySettingLevel.VeryLow) ? EGameQualitySettingLevel.Low : gameQualitySettingLevel));
	}

	// Token: 0x0601DA1B RID: 121371 RVA: 0x0084B21C File Offset: 0x0084941C
	public unsafe void UpdateStreamingQualityLevel()
	{
		AWorldSettings aworldSettings = GlobalData.World.GetWorld().K2_GetWorldSettings();
		DeviceRenderFeature? currentDeviceRenderFeature;
		if (aworldSettings == null || !aworldSettings.bEnableWorldPartition)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.World;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "UpdateStreamingQualityLevel";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("bEnableWorldPartition", false);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item = "streamLevel";
			currentDeviceRenderFeature = GameSettingsDeviceRender.Instance.GetCurrentDeviceRenderFeature();
			ptr = new ValueTuple<string, object>(item, (currentDeviceRenderFeature != null) ? new int?(currentDeviceRenderFeature.GetValueOrDefault().StreamLevel) : null);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		currentDeviceRenderFeature = GameSettingsDeviceRender.Instance.GetCurrentDeviceRenderFeature();
		int num = (currentDeviceRenderFeature != null) ? currentDeviceRenderFeature.GetValueOrDefault().StreamLevel : 0;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(44, 1);
		defaultInterpolatedStringHandler.AppendLiteral("wp.Runtime.ModifyQualityLevelStreamingValue ");
		defaultInterpolatedStringHandler.AppendFormatted<double>((num == 0) ? 0.8 : 1.0);
		string text = defaultInterpolatedStringHandler.ToStringAndClear();
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 1);
		defaultInterpolatedStringHandler.AppendLiteral("wp.Runtime.CurStreamingQualityLevel ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(num);
		string text2 = defaultInterpolatedStringHandler.ToStringAndClear();
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, text, null);
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, text2, null);
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.World;
		ELogAuthor author2 = ELogAuthor.LFJW;
		string message2 = "UpdateStreamingQualityLevel";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("bEnableWorldPartition", true);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("modifyQualityLevelStreamingValue", text);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("curStreamingQualityLevel", text2);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("streamLevel", num);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
	}

	// Token: 0x170028E4 RID: 10468
	// (get) Token: 0x0601DA1C RID: 121372 RVA: 0x0084B40D File Offset: 0x0084960D
	public static GameModeController Instance
	{
		get
		{
			return GameModeController._Instance;
		}
	}

	// Token: 0x0601DA1D RID: 121373 RVA: 0x0084B414 File Offset: 0x00849614
	public static GameModeController GetOrCreateInstance()
	{
		if (GameModeController._Instance == null)
		{
			GameModeController.CreateInstance();
		}
		return GameModeController._Instance;
	}

	// Token: 0x0601DA1E RID: 121374 RVA: 0x0084B428 File Offset: 0x00849628
	public static bool CreateInstance()
	{
		if (GameModeController._Instance != null)
		{
			return true;
		}
		GameModeController._Instance = new GameModeController();
		return true;
	}

	// Token: 0x0601DA1F RID: 121375 RVA: 0x0084B43E File Offset: 0x0084963E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601DA20 RID: 121376 RVA: 0x0084B440 File Offset: 0x00849640
	public static void ResetStaticDefaultValue()
	{
		GameModeController._Instance = null;
	}

	// Token: 0x0601DA21 RID: 121377 RVA: 0x0084B448 File Offset: 0x00849648
	static GameModeController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GameModeController.CreateStaticDefaultValue), new Action(GameModeController.ResetStaticDefaultValue));
	}

	// Token: 0x0601DA23 RID: 121379 RVA: 0x0084B48C File Offset: 0x0084968C
	[CompilerGenerated]
	internal static string <PrintLoadDetail>g__GetCmdValue|54_1(string commandLine, string startStr)
	{
		int num = commandLine.IndexOf(startStr);
		if (num != -1)
		{
			int num2 = commandLine.IndexOf(' ', num + startStr.Length);
			return commandLine.Substring(num + startStr.Length, (num2 == -1) ? (commandLine.Length - num - startStr.Length) : (num2 - num - startStr.Length));
		}
		return "";
	}

	// Token: 0x0400E874 RID: 59508
	public const int TOP_CONSUMING_COUNT = 20;

	// Token: 0x0400E875 RID: 59509
	private const int ONE_SECOND = 1000;

	// Token: 0x0400E876 RID: 59510
	private const int GAME_MODE_CTRL_THINKING_INDEX = 21;

	// Token: 0x0400E877 RID: 59511
	private const int SANWANGFENG_INSTANCEID = 1550;

	// Token: 0x0400E878 RID: 59512
	public const int LOG_STREAMING_STUCK_INTERVAL = 60000;

	// Token: 0x0400E879 RID: 59513
	private const int RENDER_ASSET_ABORT_CHECK_DISTANCE_SQUARE = 10000;

	// Token: 0x0400E87A RID: 59514
	private float cellProgress;

	// Token: 0x0400E87B RID: 59515
	private bool HasOverrideQuality;

	// Token: 0x0400E87C RID: 59516
	private int LastGameQualityLevel = -1;

	// Token: 0x0400E87D RID: 59517
	private readonly global::Vector TmpLocation = global::Vector.Create();

	// Token: 0x0400E87E RID: 59518
	private const int DEFAULT_BLOCKER_TIMEOUT = 60000;

	// Token: 0x0400E87F RID: 59519
	[TupleElementNames(new string[]
	{
		"blocker",
		"timeout"
	})]
	[Nullable(new byte[]
	{
		1,
		0,
		1
	})]
	private readonly List<ValueTuple<Func<UniTask>, int>> WorldDoneBlockers = new List<ValueTuple<Func<UniTask>, int>>();

	// Token: 0x0400E880 RID: 59520
	private bool IsWorldDoneBlockersExecuted;

	// Token: 0x0400E881 RID: 59521
	[Nullable(2)]
	private static GameModeController _Instance;
}

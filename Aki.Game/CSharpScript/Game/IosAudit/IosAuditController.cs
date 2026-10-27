using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Render.RuntimeBP.RenderData;
using CSharpScript.Core.Common;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.DataLayerSwitch;
using CSharpScript.Game.Module.DeadRevive;
using CSharpScript.Game.Render;
using CSharpScript.Game.World.Controller;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Typing;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using UnrealEngine;
using UnrealEngine.Extension;

namespace CSharpScript.Game.IosAudit
{
	// Token: 0x02006FC5 RID: 28613
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class IosAuditController : ControllerBase
	{
		// Token: 0x0604592B RID: 284971 RVA: 0x011457DC File Offset: 0x011439DC
		[NullableContext(0)]
		private UniTask RunAfter(UniTask<bool> promise, [Nullable(2)] Action<bool> after)
		{
			IosAuditController.<RunAfter>d__12 <RunAfter>d__;
			<RunAfter>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunAfter>d__.promise = promise;
			<RunAfter>d__.after = after;
			<RunAfter>d__.<>1__state = -1;
			<RunAfter>d__.<>t__builder.Start<IosAuditController.<RunAfter>d__12>(ref <RunAfter>d__);
			return <RunAfter>d__.<>t__builder.Task;
		}

		// Token: 0x0604592C RID: 284972 RVA: 0x01145828 File Offset: 0x01143A28
		[NullableContext(0)]
		private UniTask<bool> RunLoadGroupAsync([TupleElementNames(new string[]
		{
			"Name",
			"Before",
			"Handle",
			"After"
		})] [Nullable(new byte[]
		{
			1,
			0,
			1,
			2,
			1,
			0,
			2
		})] List<ValueTuple<string, Func<bool>, Func<UniTask<bool>>, Action<bool>>> handles)
		{
			IosAuditController.<RunLoadGroupAsync>d__13 <RunLoadGroupAsync>d__;
			<RunLoadGroupAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RunLoadGroupAsync>d__.<>4__this = this;
			<RunLoadGroupAsync>d__.handles = handles;
			<RunLoadGroupAsync>d__.<>1__state = -1;
			<RunLoadGroupAsync>d__.<>t__builder.Start<IosAuditController.<RunLoadGroupAsync>d__13>(ref <RunLoadGroupAsync>d__);
			return <RunLoadGroupAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604592D RID: 284973 RVA: 0x01145874 File Offset: 0x01143A74
		[return: Nullable(0)]
		private UniTask<bool> WatchOneControllerPreload(string name, CustomPromise<bool> promise)
		{
			IosAuditController.<WatchOneControllerPreload>d__14 <WatchOneControllerPreload>d__;
			<WatchOneControllerPreload>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<WatchOneControllerPreload>d__.name = name;
			<WatchOneControllerPreload>d__.promise = promise;
			<WatchOneControllerPreload>d__.<>1__state = -1;
			<WatchOneControllerPreload>d__.<>t__builder.Start<IosAuditController.<WatchOneControllerPreload>d__14>(ref <WatchOneControllerPreload>d__);
			return <WatchOneControllerPreload>d__.<>t__builder.Task;
		}

		// Token: 0x0604592E RID: 284974 RVA: 0x011458BF File Offset: 0x01143ABF
		public void Start(SceneInformation sceneInformation)
		{
			this.StartAsync(sceneInformation).Forget();
		}

		// Token: 0x0604592F RID: 284975 RVA: 0x011458D0 File Offset: 0x01143AD0
		public UniTask StartAsync(SceneInformation sceneInformation)
		{
			IosAuditController.<StartAsync>d__16 <StartAsync>d__;
			<StartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<StartAsync>d__.<>4__this = this;
			<StartAsync>d__.sceneInformation = sceneInformation;
			<StartAsync>d__.<>1__state = -1;
			<StartAsync>d__.<>t__builder.Start<IosAuditController.<StartAsync>d__16>(ref <StartAsync>d__);
			return <StartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06045930 RID: 284976 RVA: 0x0114591C File Offset: 0x01143B1C
		private UniTask ExecuteWorldDoneBlockers()
		{
			IosAuditController.<ExecuteWorldDoneBlockers>d__17 <ExecuteWorldDoneBlockers>d__;
			<ExecuteWorldDoneBlockers>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteWorldDoneBlockers>d__.<>4__this = this;
			<ExecuteWorldDoneBlockers>d__.<>1__state = -1;
			<ExecuteWorldDoneBlockers>d__.<>t__builder.Start<IosAuditController.<ExecuteWorldDoneBlockers>d__17>(ref <ExecuteWorldDoneBlockers>d__);
			return <ExecuteWorldDoneBlockers>d__.<>t__builder.Task;
		}

		// Token: 0x06045931 RID: 284977 RVA: 0x01145960 File Offset: 0x01143B60
		private UniTask RunWorldDoneBlockerAsync([TupleElementNames(new string[]
		{
			"Blocker",
			"Timeout"
		})] [Nullable(new byte[]
		{
			0,
			1
		})] ValueTuple<Func<UniTask>, int> info, int index)
		{
			IosAuditController.<RunWorldDoneBlockerAsync>d__18 <RunWorldDoneBlockerAsync>d__;
			<RunWorldDoneBlockerAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunWorldDoneBlockerAsync>d__.<>4__this = this;
			<RunWorldDoneBlockerAsync>d__.info = info;
			<RunWorldDoneBlockerAsync>d__.index = index;
			<RunWorldDoneBlockerAsync>d__.<>1__state = -1;
			<RunWorldDoneBlockerAsync>d__.<>t__builder.Start<IosAuditController.<RunWorldDoneBlockerAsync>d__18>(ref <RunWorldDoneBlockerAsync>d__);
			return <RunWorldDoneBlockerAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06045932 RID: 284978 RVA: 0x011459B4 File Offset: 0x01143BB4
		private UniTask RunBlockerWithCatch(Func<UniTask> blocker, int index)
		{
			IosAuditController.<RunBlockerWithCatch>d__19 <RunBlockerWithCatch>d__;
			<RunBlockerWithCatch>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunBlockerWithCatch>d__.blocker = blocker;
			<RunBlockerWithCatch>d__.index = index;
			<RunBlockerWithCatch>d__.<>1__state = -1;
			<RunBlockerWithCatch>d__.<>t__builder.Start<IosAuditController.<RunBlockerWithCatch>d__19>(ref <RunBlockerWithCatch>d__);
			return <RunBlockerWithCatch>d__.<>t__builder.Task;
		}

		// Token: 0x06045933 RID: 284979 RVA: 0x011459FF File Offset: 0x01143BFF
		protected override bool OnLeaveLevel()
		{
			UHoldPreloadObject holdPreloadObject = this.HoldPreloadObject;
			if (holdPreloadObject != null)
			{
				holdPreloadObject.Clear();
			}
			this.HoldPreloadObject = null;
			return true;
		}

		// Token: 0x06045934 RID: 284980 RVA: 0x01145A1C File Offset: 0x01143C1C
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
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 1);
				defaultInterpolatedStringHandler.AppendLiteral("sg.KuroRenderQuality ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.LastGameQualityLevel);
				UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Streaming.RuntimeLODBiasDeviceMappingIndices 274960", null);
			}
		}

		// Token: 0x06045935 RID: 284981 RVA: 0x01145B10 File Offset: 0x01143D10
		[NullableContext(0)]
		public UniTask<bool> PreloadIosAudit()
		{
			IosAuditController.<PreloadIosAudit>d__22 <PreloadIosAudit>d__;
			<PreloadIosAudit>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PreloadIosAudit>d__.<>4__this = this;
			<PreloadIosAudit>d__.<>1__state = -1;
			<PreloadIosAudit>d__.<>t__builder.Start<IosAuditController.<PreloadIosAudit>d__22>(ref <PreloadIosAudit>d__);
			return <PreloadIosAudit>d__.<>t__builder.Task;
		}

		// Token: 0x06045936 RID: 284982 RVA: 0x01145B54 File Offset: 0x01143D54
		public UniTask Load(SceneInformation sceneInformation)
		{
			IosAuditController.<Load>d__23 <Load>d__;
			<Load>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Load>d__.<>4__this = this;
			<Load>d__.sceneInformation = sceneInformation;
			<Load>d__.<>1__state = -1;
			<Load>d__.<>t__builder.Start<IosAuditController.<Load>d__23>(ref <Load>d__);
			return <Load>d__.<>t__builder.Task;
		}

		// Token: 0x06045937 RID: 284983 RVA: 0x01145B9F File Offset: 0x01143D9F
		private void CreateStat(string name)
		{
			Stat.CreateNoFlameGraph(name, "", "");
		}

		// Token: 0x06045938 RID: 284984 RVA: 0x01145BB4 File Offset: 0x01143DB4
		public void RegisterDataLayerChange()
		{
			GameModeModel instance = GameModeModel.Instance;
			if (instance != null && instance.UseWorldPartition)
			{
				UDataLayerSubsystem udataLayerSubsystem = (UDataLayerSubsystem)UKuroRenderingRuntimeBPPluginBPLibrary.GetSubsystem(GlobalData.World, UDataLayerSubsystem.StaticClass());
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
					Log.Instance.Info(ELogModule.IosAudit, ELogAuthor.HWK, "注册DataLayer变化监听", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.IosAudit;
				ELogAuthor author = ELogAuthor.HWK;
				string message = "注册DataLayer变化监听失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("DatalayerSubSystem", udataLayerSubsystem);
				instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x06045939 RID: 284985 RVA: 0x01145CC8 File Offset: 0x01143EC8
		private void OnDatalayerChange(FName datalayerLabel, bool bIsActive)
		{
			if (bIsActive && datalayerLabel != null && (datalayerLabel == WorldDefine.SpecificVolumeDatalayer1 || datalayerLabel == WorldDefine.SpecificVolumeDatalayer2) && !GameModeModel.Instance.HasDataLayer(datalayerLabel.ToString()))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.IosAudit;
				ELogAuthor author = ELogAuthor.HWK;
				string message = "DataLayer在业务端未激活";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Datalayer", datalayerLabel);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				RenderModuleController.Instance.SetWorldPartitionDataLayerState(datalayerLabel.ToString(), false, false);
			}
		}

		// Token: 0x0604593A RID: 284986 RVA: 0x01145D64 File Offset: 0x01143F64
		public void PreventEntityFalling()
		{
			DeadReviveModel.Instance.SetSkipFallInjure(ESkipFallInjureReason.IosAudit, true);
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
								Context = "[IosAuditController.PreventEntityFalling]"
							});
						}
					}
				}
			}
		}

		// Token: 0x0604593B RID: 284987 RVA: 0x01145DFC File Offset: 0x01143FFC
		public void EnableEntityFalling()
		{
			DeadReviveModel.Instance.SetSkipFallInjure(ESkipFallInjureReason.IosAudit, false);
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
								Context = "[IosAuditController.EnableEntityFalling]"
							});
						}
					}
				}
			}
		}

		// Token: 0x0604593C RID: 284988 RVA: 0x01145EA8 File Offset: 0x011440A8
		public void PrintWorldPartitionDebugInfo(UWorldPartitionStreamingSourceComponent streamingSourceComponent, [Nullable(2)] TArray<FName> inDataLayerLabels, bool bUseGridLoadingRange, float radius, bool bRequirePhysics)
		{
			if (streamingSourceComponent == null)
			{
				Log.Instance.Error(ELogModule.IosAudit, ELogAuthor.HWK, "WorldPartitionStreamingSourceComponent不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if ((UWorldPartitionSubsystem)UKuroRenderingRuntimeBPPluginBPLibrary.GetSubsystem(GlobalData.World, UWorldPartitionSubsystem.StaticClass()) == null)
			{
				Log.Instance.Error(ELogModule.IosAudit, ELogAuthor.HWK, "WorldPartitionSubsystem不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			streamingSourceComponent.LogStreamingStuckInfo2(inDataLayerLabels, bUseGridLoadingRange, radius, bRequirePhysics);
		}

		// Token: 0x0604593D RID: 284989 RVA: 0x01145F1E File Offset: 0x0114411E
		[NullableContext(2)]
		public void SwitchDataLayer([Nullable(1)] string[] unloadDataLayers, [Nullable(1)] string[] activateDataLayers, Action<bool> callback = null, string sequencePath = null, string sequenceMarkBeforeModifyMaterial = null, string materialDataForLoadedLayers = null, string materialDataForUnloadLayers = null)
		{
			this.AwaitSwitchDataLayer(unloadDataLayers, activateDataLayers, callback, sequencePath, sequenceMarkBeforeModifyMaterial, materialDataForLoadedLayers, materialDataForUnloadLayers).Forget();
		}

		// Token: 0x0604593E RID: 284990 RVA: 0x01145F38 File Offset: 0x01144138
		private static void OnInterruptDataLayerSwitchTask()
		{
			Log.Instance.Info(ELogModule.IosAudit, ELogAuthor.ZYL, "IosAudit:Task被打断,触发OnInterrupt收尾", default(ReadOnlySpan<ValueTuple<string, object>>));
			IosAuditController.InterruptDataLayerSwitch();
		}

		// Token: 0x0604593F RID: 284991 RVA: 0x01145F6C File Offset: 0x0114416C
		public static void InterruptDataLayerSwitch()
		{
			Log.Instance.Info(ELogModule.IosAudit, ELogAuthor.ZYL, "IosAudit:打断DataLayer切换(InterruptDataLayerSwitch)", default(ReadOnlySpan<ValueTuple<string, object>>));
			GameModeModel instance = GameModeModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.SwitchDataLayerContext.AbortDataLayerSwitch();
		}

		// Token: 0x06045940 RID: 284992 RVA: 0x01145FAC File Offset: 0x011441AC
		[NullableContext(2)]
		public UniTask AwaitSwitchDataLayer([Nullable(1)] string[] unloadDataLayers, [Nullable(1)] string[] activateDataLayers, Action<bool> callback = null, string sequencePath = null, string sequenceMarkBeforeModifyMaterial = null, string materialDataForLoadedLayers = null, string materialDataForUnloadLayers = null)
		{
			IosAuditController.<AwaitSwitchDataLayer>d__33 <AwaitSwitchDataLayer>d__;
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
			<AwaitSwitchDataLayer>d__.<>t__builder.Start<IosAuditController.<AwaitSwitchDataLayer>d__33>(ref <AwaitSwitchDataLayer>d__);
			return <AwaitSwitchDataLayer>d__.<>t__builder.Task;
		}

		// Token: 0x06045941 RID: 284993 RVA: 0x0114602C File Offset: 0x0114422C
		[NullableContext(2)]
		[return: Nullable(1)]
		private AsyncTask CreateSwitchDataLayerTask([Nullable(1)] string[] unloadDataLayers, [Nullable(1)] string[] activateDataLayers, Action<bool> callback = null, string sequencePath = null, string sequenceMarkBeforeModifyMaterial = null, string materialDataForLoadedLayers = null, string materialDataForUnloadLayers = null)
		{
			IosAuditController.<>c__DisplayClass34_0 CS$<>8__locals1 = new IosAuditController.<>c__DisplayClass34_0();
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
				Log.Instance.Info(ELogModule.IosAudit, ELogAuthor.ZYL, "IosAudit:选择材质过渡切换模式", default(ReadOnlySpan<ValueTuple<string, object>>));
				CS$<>8__locals1.runner = (() => CS$<>8__locals1.<>4__this.RunMaterialSwitchTask(CS$<>8__locals1.unloadDataLayers, CS$<>8__locals1.activateDataLayers, CS$<>8__locals1.callback, CS$<>8__locals1.sequencePath, CS$<>8__locals1.sequenceMarkBeforeModifyMaterial, CS$<>8__locals1.materialDataForLoadedLayers, CS$<>8__locals1.materialDataForUnloadLayers));
			}
			else if (!StringUtils.IsBlank(CS$<>8__locals1.sequencePath))
			{
				Log.Instance.Info(ELogModule.IosAudit, ELogAuthor.ZYL, "IosAudit:选择序列切换模式", default(ReadOnlySpan<ValueTuple<string, object>>));
				CS$<>8__locals1.runner = (() => CS$<>8__locals1.<>4__this.RunLevelSeqSwitchTask(CS$<>8__locals1.unloadDataLayers, CS$<>8__locals1.activateDataLayers, CS$<>8__locals1.sequencePath, CS$<>8__locals1.callback));
			}
			else
			{
				Log.Instance.Info(ELogModule.IosAudit, ELogAuthor.ZYL, "IosAudit:选择普通切换模式", default(ReadOnlySpan<ValueTuple<string, object>>));
				CS$<>8__locals1.runner = (() => CS$<>8__locals1.<>4__this.RunNormalSwitchTask(CS$<>8__locals1.unloadDataLayers, CS$<>8__locals1.activateDataLayers, CS$<>8__locals1.callback));
			}
			string name = "SwitchDataLayer";
			Func<UniTask<bool>> runHandle = delegate()
			{
				IosAuditController.<>c__DisplayClass34_0.<<CreateSwitchDataLayerTask>b__3>d <<CreateSwitchDataLayerTask>b__3>d;
				<<CreateSwitchDataLayerTask>b__3>d.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
				<<CreateSwitchDataLayerTask>b__3>d.<>4__this = CS$<>8__locals1;
				<<CreateSwitchDataLayerTask>b__3>d.<>1__state = -1;
				<<CreateSwitchDataLayerTask>b__3>d.<>t__builder.Start<IosAuditController.<>c__DisplayClass34_0.<<CreateSwitchDataLayerTask>b__3>d>(ref <<CreateSwitchDataLayerTask>b__3>d);
				return <<CreateSwitchDataLayerTask>b__3>d.<>t__builder.Task;
			};
			Func<bool> initHandle = null;
			Action<bool> finishedCallback = null;
			ETaskPriority priority = ETaskPriority.Normal;
			bool interruptible = true;
			Action onInterrupt;
			if ((onInterrupt = IosAuditController.<>O.<0>__OnInterruptDataLayerSwitchTask) == null)
			{
				onInterrupt = (IosAuditController.<>O.<0>__OnInterruptDataLayerSwitchTask = new Action(IosAuditController.OnInterruptDataLayerSwitchTask));
			}
			return new AsyncTask(name, runHandle, initHandle, finishedCallback, new TaskInterruptOptions(priority, interruptible, onInterrupt));
		}

		// Token: 0x06045942 RID: 284994 RVA: 0x01146174 File Offset: 0x01144374
		private void PrepareSwitchDataLayer()
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.IosAudit;
			ELogAuthor author = ELogAuthor.ZYL;
			string message = "IosAudit:准备切换DataLayer";
			string item = "InstId";
			InstanceDungeon? instanceDungeon = GameModeModel.Instance.InstanceDungeon;
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (instanceDungeon != null) ? instanceDungeon.GetValueOrDefault().Id : 0);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			instanceDungeon = GameModeModel.Instance.InstanceDungeon;
			bool flag = (((instanceDungeon != null) ? new int?(instanceDungeon.GetValueOrDefault().Id) : null) ?? 0) == 0;
			if (flag)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.IosAudit;
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

		// Token: 0x06045943 RID: 284995 RVA: 0x011462C6 File Offset: 0x011444C6
		private bool CheckAndTryFakeSwitchDataLayer(string[] unloadDataLayers, string[] activateDataLayers, [Nullable(2)] Action<bool> callback = null)
		{
			AutoRunModel instance = AutoRunModel.Instance;
			if (instance != null && instance.IsInLogicTreeGmMode())
			{
				this.FakeSwitchDataLayerInternal(unloadDataLayers, activateDataLayers, GameModeModel.Instance.SwitchDataLayerContext.CurrentSwitchInstId, callback);
				return true;
			}
			return false;
		}

		// Token: 0x06045944 RID: 284996 RVA: 0x011462F8 File Offset: 0x011444F8
		private UniTask RunNormalSwitchTask(string[] unloadDataLayers, string[] activateDataLayers, [Nullable(2)] Action<bool> callback = null)
		{
			IosAuditController.<RunNormalSwitchTask>d__37 <RunNormalSwitchTask>d__;
			<RunNormalSwitchTask>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunNormalSwitchTask>d__.<>4__this = this;
			<RunNormalSwitchTask>d__.unloadDataLayers = unloadDataLayers;
			<RunNormalSwitchTask>d__.activateDataLayers = activateDataLayers;
			<RunNormalSwitchTask>d__.callback = callback;
			<RunNormalSwitchTask>d__.<>1__state = -1;
			<RunNormalSwitchTask>d__.<>t__builder.Start<IosAuditController.<RunNormalSwitchTask>d__37>(ref <RunNormalSwitchTask>d__);
			return <RunNormalSwitchTask>d__.<>t__builder.Task;
		}

		// Token: 0x06045945 RID: 284997 RVA: 0x01146354 File Offset: 0x01144554
		private UniTask RunLevelSeqSwitchTask(string[] unloadDataLayers, string[] activateDataLayers, string sequencePath, [Nullable(2)] Action<bool> callback = null)
		{
			IosAuditController.<RunLevelSeqSwitchTask>d__38 <RunLevelSeqSwitchTask>d__;
			<RunLevelSeqSwitchTask>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunLevelSeqSwitchTask>d__.<>4__this = this;
			<RunLevelSeqSwitchTask>d__.unloadDataLayers = unloadDataLayers;
			<RunLevelSeqSwitchTask>d__.activateDataLayers = activateDataLayers;
			<RunLevelSeqSwitchTask>d__.sequencePath = sequencePath;
			<RunLevelSeqSwitchTask>d__.callback = callback;
			<RunLevelSeqSwitchTask>d__.<>1__state = -1;
			<RunLevelSeqSwitchTask>d__.<>t__builder.Start<IosAuditController.<RunLevelSeqSwitchTask>d__38>(ref <RunLevelSeqSwitchTask>d__);
			return <RunLevelSeqSwitchTask>d__.<>t__builder.Task;
		}

		// Token: 0x06045946 RID: 284998 RVA: 0x011463B8 File Offset: 0x011445B8
		[NullableContext(2)]
		private UniTask RunMaterialSwitchTask([Nullable(1)] string[] unloadDataLayers, [Nullable(1)] string[] activateDataLayers, Action<bool> callback = null, string sequencePath = null, string sequenceMarkBeforeModifyMaterial = null, string materialDataForLoadedLayers = null, string materialDataForUnloadLayers = null)
		{
			IosAuditController.<RunMaterialSwitchTask>d__39 <RunMaterialSwitchTask>d__;
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
			<RunMaterialSwitchTask>d__.<>t__builder.Start<IosAuditController.<RunMaterialSwitchTask>d__39>(ref <RunMaterialSwitchTask>d__);
			return <RunMaterialSwitchTask>d__.<>t__builder.Task;
		}

		// Token: 0x06045947 RID: 284999 RVA: 0x01146438 File Offset: 0x01144638
		private UniTask NormalSwitchDataLayerInternal(string[] unloadDataLayers, string[] activateDataLayers, bool bEnterLoadingMode = true, bool bWaitingRenderAssetDone = true)
		{
			IosAuditController.<NormalSwitchDataLayerInternal>d__40 <NormalSwitchDataLayerInternal>d__;
			<NormalSwitchDataLayerInternal>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NormalSwitchDataLayerInternal>d__.<>4__this = this;
			<NormalSwitchDataLayerInternal>d__.unloadDataLayers = unloadDataLayers;
			<NormalSwitchDataLayerInternal>d__.activateDataLayers = activateDataLayers;
			<NormalSwitchDataLayerInternal>d__.bEnterLoadingMode = bEnterLoadingMode;
			<NormalSwitchDataLayerInternal>d__.bWaitingRenderAssetDone = bWaitingRenderAssetDone;
			<NormalSwitchDataLayerInternal>d__.<>1__state = -1;
			<NormalSwitchDataLayerInternal>d__.<>t__builder.Start<IosAuditController.<NormalSwitchDataLayerInternal>d__40>(ref <NormalSwitchDataLayerInternal>d__);
			return <NormalSwitchDataLayerInternal>d__.<>t__builder.Task;
		}

		// Token: 0x06045948 RID: 285000 RVA: 0x0114649C File Offset: 0x0114469C
		private unsafe void FakeSwitchDataLayerInternal(string[] unloadDataLayers, string[] activateDataLayers, int instId, [Nullable(2)] Action<bool> callback = null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.IosAudit;
			ELogAuthor author = ELogAuthor.CJH;
			string message = "伪切换DataLayer:(开始)";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("卸载的DataLayer", string.Join(",", unloadDataLayers ?? Array.Empty<string>()));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("加载的DataLayer", string.Join(",", activateDataLayers ?? Array.Empty<string>()));
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			Log.Instance.Info(ELogModule.IosAudit, ELogAuthor.ZYL, "伪切换DataLayer:更新缓存的DataLayer变更信息", default(ReadOnlySpan<ValueTuple<string, object>>));
			AutoRunModel instance2 = AutoRunModel.Instance;
			if (instance2 != null)
			{
				instance2.UpdateCachedDataLayerInfo(activateDataLayers, unloadDataLayers, null);
			}
			Log.Instance.Info(ELogModule.IosAudit, ELogAuthor.ZYL, "伪切换DataLayer:通知服务器切换完成", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.ChangeDataLayerFinishRequest(instId);
			Log.Instance.Info(ELogModule.IosAudit, ELogAuthor.CJH, "伪切换DataLayer:(完成)", default(ReadOnlySpan<ValueTuple<string, object>>));
			GameModeModel instance3 = GameModeModel.Instance;
			if (instance3 != null)
			{
				instance3.SwitchDataLayerContext.FinishDataLayerSwitch();
			}
			if (callback != null)
			{
				callback(true);
			}
		}

		// Token: 0x06045949 RID: 285001 RVA: 0x011465C5 File Offset: 0x011447C5
		public bool IsInInstance()
		{
			return GameModeModel.Instance.InstanceType >= InstanceType.NormalInstance;
		}

		// Token: 0x0604594A RID: 285002 RVA: 0x011465D8 File Offset: 0x011447D8
		public bool CanLoadEntity()
		{
			GameModeModel instance = GameModeModel.Instance;
			return instance.WorldDone && !instance.IsTeleport && !instance.ChangeModeState;
		}

		// Token: 0x0604594B RID: 285003 RVA: 0x01146608 File Offset: 0x01144808
		public void InitAllPlayerStarts()
		{
			TArray<AActor> tarray = new TArray<AActor>();
			UGameplayStatics.GetAllActorsOfClass(GlobalData.World, APlayerStart.StaticClass(), ref tarray);
			GameModeModel.Instance.ClearPlayerStart();
			if (tarray.Num() > 0)
			{
				for (int i = 0; i < tarray.Num(); i++)
				{
					GameModeModel.Instance.AddPlayerStart((APlayerStart)tarray.Get(i));
				}
			}
		}

		// Token: 0x0604594C RID: 285004 RVA: 0x0114666C File Offset: 0x0114486C
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
			})] ValueTuple<string, int> b) => b.Item2 - a.Item2);
			if (UKuroStaticLibrary.IsWithEditor())
			{
				float piestartTimeInSeconds = UKuroStaticLibrary.GetPIEStartTimeInSeconds();
				float platformTimeInSeconds = UKuroStaticLibrary.GetPlatformTimeInSeconds();
				string commandLine = UKismetSystemLibrary.GetCommandLine();
				string value = IosAuditController.<PrintLoadDetail>g__GetCmdValue|45_1(commandLine, "-KuroPipelineTag=");
				string[] array = IosAuditController.<PrintLoadDetail>g__GetCmdValue|45_1(commandLine, "-KuroTsSilentLoginTestFile=").Replace("/", "\\").Split("\\", StringSplitOptions.None);
				string value2 = array[array.Length - 1];
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				dictionary["Version"] = BaseConfigController.Instance.GetVersionString();
				dictionary["LoadingTime"] = (platformTimeInSeconds - piestartTimeInSeconds).ToString();
				dictionary["MapPath"] = GameModeModel.Instance.MapPath;
				dictionary["BornLocation"] = bornLocation.ToString();
				dictionary["TestName"] = value2;
				dictionary["PipelineTag"] = value;
				string text = Json.Stringify<Dictionary<string, string>>(dictionary, null);
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.IosAudit;
				ELogAuthor author2 = ELogAuthor.HMH;
				string message2 = "UE_TraceProfile_Event";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("value", text);
				instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				if (FThinkingAnalyticsForCSharp.Track("UE_TraceProfile_Event", text, 21))
				{
					TimerSystem.Instance.Next(delegate(float _)
					{
						FThinkingAnalyticsForCSharp.Flush(21);
					}, null, null);
				}
				else
				{
					Log.Instance.Warn(ELogModule.IosAudit, ELogAuthor.HMH, "TraceProfile report fail", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
			}
			if (!PreloadModelNew.Instance.LoadAssetOneByOneState)
			{
				return;
			}
			int num = 0;
			while (num < 20 && num < resourcesLoadTime.Count)
			{
				ValueTuple<string, int> valueTuple2 = resourcesLoadTime[num];
				int item = valueTuple2.Item2;
				string text2;
				if (item >= 1000)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
					defaultInterpolatedStringHandler.AppendFormatted<float>((float)item / 1000f);
					defaultInterpolatedStringHandler.AppendLiteral(" s");
					text2 = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				else
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
					defaultInterpolatedStringHandler.AppendFormatted<int>(item);
					defaultInterpolatedStringHandler.AppendLiteral(" ms");
					text2 = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				string item2 = text2;
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.World;
				ELogAuthor author3 = ELogAuthor.LFJW;
				string message3 = "资源耗时Top20";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("耗时", item2);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("资源路径", valueTuple2.Item1);
				instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				num++;
			}
			PreloadModelNew.Instance.ClearResourcesLoadTime();
		}

		// Token: 0x0604594D RID: 285005 RVA: 0x0114697C File Offset: 0x01144B7C
		public unsafe void SetTimeDilation(float timeDilation, ETimeDilationType timeDilationType = ETimeDilationType.Default)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.IosAudit;
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
				ELogModule module2 = ELogModule.IosAudit;
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
				bool key = keyValuePair.Key != ETimeDilationType.Default;
				float value = keyValuePair.Value;
				num *= value;
				if (((key ? 1 : 0) & 3) == 0)
				{
					num2 *= value;
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
			ELogModule module3 = ELogModule.IosAudit;
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

		// Token: 0x0604594E RID: 285006 RVA: 0x01146BC8 File Offset: 0x01144DC8
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

		// Token: 0x0604594F RID: 285007 RVA: 0x01146C98 File Offset: 0x01144E98
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
				Context = "[IosAuditController.FixBornLocation]"
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

		// Token: 0x06045950 RID: 285008 RVA: 0x01146D74 File Offset: 0x01144F74
		public unsafe void LoadDataLayers(SceneInformation sceneInformation)
		{
			bool flag = UKuroStaticLibrary.IsLowMemoryDevice();
			if (Info.Instance.PlatformType == ESourcePlatformType.Android)
			{
				int physicalGBRam = GameSettingsDeviceRender.Instance.PhysicalGBRam;
				bool flag2 = physicalGBRam <= 6;
				flag = (flag || flag2);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.IosAudit;
				ELogAuthor author = ELogAuthor.RY;
				string message = "判断Android低内存";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PhysicalMemory", flag2);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("totalMemoryGB", physicalGBRam);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			RenderModuleController.Instance.SetWorldPartitionDataLayerState("DatalayerRuntime_HideInLowMemDevice", !flag, false);
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
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.IosAudit;
					ELogAuthor author2 = ELogAuthor.LFJW;
					string message2 = "加载场景:加载DataLayer失败,不存在的配置Id";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("DataLayerId:", num);
					instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					string dataLayer = config.Value.DataLayer;
					if (GameModeModel.Instance.HasDataLayer(dataLayer))
					{
						int num2 = list.IndexOf(dataLayer);
						if (num2 >= 0)
						{
							list.RemoveAt(num2);
						}
					}
					else
					{
						Log instance3 = Log.Instance;
						ELogModule module3 = ELogModule.IosAudit;
						ELogAuthor author3 = ELogAuthor.LFJW;
						string message3 = "加载场景:加载DataLayer";
						ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("DataLayer", dataLayer);
						instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
						this.ActivateDataLayer(dataLayer);
					}
				}
			}
			foreach (string dataLayerPath in list)
			{
				this.UnloadDataLayer(dataLayerPath);
			}
		}

		// Token: 0x06045951 RID: 285009 RVA: 0x01146F78 File Offset: 0x01145178
		private void ActivateDataLayer(string dataLayerPath)
		{
			GameModeModel.Instance.AddDataLayer(dataLayerPath);
			RenderModuleController.Instance.SetWorldPartitionDataLayerState(dataLayerPath, true, false);
		}

		// Token: 0x06045952 RID: 285010 RVA: 0x01146F93 File Offset: 0x01145193
		private void UnloadDataLayer(string dataLayerPath)
		{
			GameModeModel.Instance.RemoveDataLayer(dataLayerPath);
			RenderModuleController.Instance.SetWorldPartitionDataLayerState(dataLayerPath, false, false);
		}

		// Token: 0x06045953 RID: 285011 RVA: 0x01146FB0 File Offset: 0x011451B0
		private void ChangeDataLayerFinishRequest(int instId)
		{
			ChangeDataLayerFinishRequest changeDataLayerFinishRequest = Aki.Protocol.ChangeDataLayerFinishRequest.Create();
			changeDataLayerFinishRequest.InstId = instId;
			Net.Instance.Call(ERequestMessageId.ChangeDataLayerFinishRequest, changeDataLayerFinishRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				ChangeDataLayerFinishResponse changeDataLayerFinishResponse = (ChangeDataLayerFinishResponse)msg;
				if (changeDataLayerFinishResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(changeDataLayerFinishResponse.ErrorCode, EResponseMessageId.ChangeDataLayerFinishResponse, null, true, true);
				}
			}, 0);
		}

		// Token: 0x06045954 RID: 285012 RVA: 0x01146FFC File Offset: 0x011451FC
		public unsafe void ApplyMaterialParameterCollection(IDictionary<int, int> protoAreaMpc)
		{
			GameModeModel.Instance.MaterialParameterCollectionMap.Clear();
			foreach (KeyValuePair<int, int> keyValuePair in protoAreaMpc)
			{
				int key = keyValuePair.Key;
				string mpcData = ConfigAreaMpcById.GetConfig(keyValuePair.Value, true).Value.MpcData;
				if (StringUtils.IsBlank(mpcData) || mpcData == "None" || mpcData == "Empty")
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.IosAudit;
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
							Log.Instance.Error(ELogModule.IosAudit, ELogAuthor.CJH, "加载场景: MPCData无效", default(ReadOnlySpan<ValueTuple<string, object>>));
							GameModeModel.Instance.MaterialParameterCollectionMap[inPath] = true;
							this.CheckMaterialParameterCollectionLoaded();
							return;
						}
						RenderModuleModel.Instance.UpdateItemMaterialParameterCollection(data);
						GameModeModel.Instance.MaterialParameterCollectionMap[inPath] = true;
						this.CheckMaterialParameterCollectionLoaded();
					}, 100, "js_undefined");
				}
			}
		}

		// Token: 0x06045955 RID: 285013 RVA: 0x011471B4 File Offset: 0x011453B4
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

		// Token: 0x06045956 RID: 285014 RVA: 0x01147220 File Offset: 0x01145420
		public UniTask SwitchStreamingSource(AActor actor, bool waitForStreaming, bool bLockMovementDuringStreaming, EMovementLockMode? movementLockModeAfterStreaming)
		{
			IosAuditController.<SwitchStreamingSource>d__55 <SwitchStreamingSource>d__;
			<SwitchStreamingSource>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SwitchStreamingSource>d__.<>4__this = this;
			<SwitchStreamingSource>d__.actor = actor;
			<SwitchStreamingSource>d__.waitForStreaming = waitForStreaming;
			<SwitchStreamingSource>d__.bLockMovementDuringStreaming = bLockMovementDuringStreaming;
			<SwitchStreamingSource>d__.movementLockModeAfterStreaming = movementLockModeAfterStreaming;
			<SwitchStreamingSource>d__.<>1__state = -1;
			<SwitchStreamingSource>d__.<>t__builder.Start<IosAuditController.<SwitchStreamingSource>d__55>(ref <SwitchStreamingSource>d__);
			return <SwitchStreamingSource>d__.<>t__builder.Task;
		}

		// Token: 0x06045957 RID: 285015 RVA: 0x01147284 File Offset: 0x01145484
		private UniTask CheckWorldPartitionStreamingCompleted(CustomPromise<bool> voxelPromise, CustomPromise<bool> streamingPromise, [Nullable(2)] Func<bool> abortCheckCondition = null)
		{
			IosAuditController.<CheckWorldPartitionStreamingCompleted>d__56 <CheckWorldPartitionStreamingCompleted>d__;
			<CheckWorldPartitionStreamingCompleted>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CheckWorldPartitionStreamingCompleted>d__.<>4__this = this;
			<CheckWorldPartitionStreamingCompleted>d__.voxelPromise = voxelPromise;
			<CheckWorldPartitionStreamingCompleted>d__.streamingPromise = streamingPromise;
			<CheckWorldPartitionStreamingCompleted>d__.abortCheckCondition = abortCheckCondition;
			<CheckWorldPartitionStreamingCompleted>d__.<>1__state = -1;
			<CheckWorldPartitionStreamingCompleted>d__.<>t__builder.Start<IosAuditController.<CheckWorldPartitionStreamingCompleted>d__56>(ref <CheckWorldPartitionStreamingCompleted>d__);
			return <CheckWorldPartitionStreamingCompleted>d__.<>t__builder.Task;
		}

		// Token: 0x06045958 RID: 285016 RVA: 0x011472E0 File Offset: 0x011454E0
		[NullableContext(2)]
		[return: Nullable(1)]
		private unsafe TimerHandle CheckTargetStreamingCompleted([Nullable(1)] UWorldPartitionStreamingSourceComponent streamingSourceComponent, [Nullable(new byte[]
		{
			0,
			1,
			1
		})] OneOf<CustomPromise<bool>, GameModePromise> completedPromise, TArray<FName> dataLayerLabels = null, Action<float> progressUpdated = null, bool checkPhysics = false, Func<bool> abortCheckCondition = null)
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
						bool flag = streamingSourceComponent.IsStreamingCompletedForLayers2(dataLayerLabels, false, 7000f, true, ref this.cellProgress, false);
						if (progressUpdated != null)
						{
							progressUpdated(this.cellProgress);
						}
						if (!flag)
						{
							base.<CheckTargetStreamingCompleted>g__TimerStreamingStuckLog|1(isCheckingPhysics);
							return;
						}
						isCheckingPhysics = checkPhysics;
						if (isCheckingPhysics)
						{
							Log.Instance.Info(ELogModule.IosAudit, ELogAuthor.XY, "加载场景:检测场景物理体(开始)", default(ReadOnlySpan<ValueTuple<string, object>>));
						}
					}
					if (isCheckingPhysics)
					{
						if (!streamingSourceComponent.IsStreamingCompletedForLayers2(dataLayerLabels, false, 7000f, false, ref this.cellProgress, true))
						{
							base.<CheckTargetStreamingCompleted>g__TimerStreamingStuckLog|1(isCheckingPhysics);
							return;
						}
						Log.Instance.Info(ELogModule.IosAudit, ELogAuthor.XY, "加载场景:检测场景物理体(结束)", default(ReadOnlySpan<ValueTuple<string, object>>));
					}
				}
				if (timerId != null)
				{
					TimerSystem.Instance.Remove(timerId);
				}
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

		// Token: 0x06045959 RID: 285017 RVA: 0x01147420 File Offset: 0x01145620
		public void InitStreamingSources()
		{
			GameModeModel instance = GameModeModel.Instance;
			if (!GlobalData.World.GetWorld().K2_GetWorldSettings().bEnableWorldPartition || instance.BornLocation == null)
			{
				return;
			}
			instance.InitStreamingSources();
		}

		// Token: 0x0604595A RID: 285018 RVA: 0x01147460 File Offset: 0x01145660
		public UniTask CheckVoxelStreamingCompleted(float relativeProgress, int maxProgress)
		{
			IosAuditController.<CheckVoxelStreamingCompleted>d__59 <CheckVoxelStreamingCompleted>d__;
			<CheckVoxelStreamingCompleted>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CheckVoxelStreamingCompleted>d__.<>4__this = this;
			<CheckVoxelStreamingCompleted>d__.relativeProgress = relativeProgress;
			<CheckVoxelStreamingCompleted>d__.maxProgress = maxProgress;
			<CheckVoxelStreamingCompleted>d__.<>1__state = -1;
			<CheckVoxelStreamingCompleted>d__.<>t__builder.Start<IosAuditController.<CheckVoxelStreamingCompleted>d__59>(ref <CheckVoxelStreamingCompleted>d__);
			return <CheckVoxelStreamingCompleted>d__.<>t__builder.Task;
		}

		// Token: 0x0604595B RID: 285019 RVA: 0x011474B4 File Offset: 0x011456B4
		public void AppendAllBaseDatalayers(TArray<FName> dataLayerLabels)
		{
			foreach (FName value in WorldDefine.allBaseDataLayers)
			{
				dataLayerLabels.Add(value);
			}
		}

		// Token: 0x0604595C RID: 285020 RVA: 0x011474E4 File Offset: 0x011456E4
		public UniTask CheckStreamingCompleted(float relativeProgress, int maxProgress)
		{
			IosAuditController.<CheckStreamingCompleted>d__61 <CheckStreamingCompleted>d__;
			<CheckStreamingCompleted>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CheckStreamingCompleted>d__.<>4__this = this;
			<CheckStreamingCompleted>d__.relativeProgress = relativeProgress;
			<CheckStreamingCompleted>d__.maxProgress = maxProgress;
			<CheckStreamingCompleted>d__.<>1__state = -1;
			<CheckStreamingCompleted>d__.<>t__builder.Start<IosAuditController.<CheckStreamingCompleted>d__61>(ref <CheckStreamingCompleted>d__);
			return <CheckStreamingCompleted>d__.<>t__builder.Task;
		}

		// Token: 0x0604595D RID: 285021 RVA: 0x01147538 File Offset: 0x01145738
		public void AddOrRemoveRenderAssetsQueryViewInfo(FVectorDouble viewOrigin, float duration)
		{
			if (!GlobalData.World.GetWorld().K2_GetWorldSettings().bEnableWorldPartition)
			{
				return;
			}
			UWorldPartitionSubsystem uworldPartitionSubsystem = (UWorldPartitionSubsystem)UKuroRenderingRuntimeBPPluginBPLibrary.GetSubsystem(GlobalData.World, UWorldPartitionSubsystem.StaticClass());
			if (uworldPartitionSubsystem == null || !uworldPartitionSubsystem.IsValid())
			{
				return;
			}
			uworldPartitionSubsystem.D_AddOrRemoveRenderAssetsQueryViewInfo(viewOrigin, duration, 1.2f);
		}

		// Token: 0x0604595E RID: 285022 RVA: 0x01147598 File Offset: 0x01145798
		[NullableContext(2)]
		private void ResetRenderAssetsQuery(UWorldPartitionSubsystem worldPartitionSubsystem = null, FWorldPartitionStreamingQuerySource querySource = null, bool? raiseError = null)
		{
			GameModeModel instance = GameModeModel.Instance;
			TimerHandle checkRenderAssetsStreamingCompletedTimerId = instance.CheckRenderAssetsStreamingCompletedTimerId;
			if (checkRenderAssetsStreamingCompletedTimerId != null && checkRenderAssetsStreamingCompletedTimerId.Valid())
			{
				TimerSystem.Instance.Remove(instance.CheckRenderAssetsStreamingCompletedTimerId);
				instance.CheckRenderAssetsStreamingCompletedTimerId = null;
				if (worldPartitionSubsystem == null)
				{
					worldPartitionSubsystem = (UWorldPartitionSubsystem)UKuroRenderingRuntimeBPPluginBPLibrary.GetSubsystem(GlobalData.World, UWorldPartitionSubsystem.StaticClass());
				}
				if (querySource == null)
				{
					querySource = new FWorldPartitionStreamingQuerySource();
				}
				worldPartitionSubsystem.IsRenderAssetsStreamingCompleted(querySource, false, false, true);
				if (raiseError.GetValueOrDefault())
				{
					Log instance2 = Log.Instance;
					ELogModule module = ELogModule.World;
					ELogAuthor author = ELogAuthor.XY;
					string message = "检查渲染资源(异常结束)";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("是否超时:", false);
					instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
			}
		}

		// Token: 0x0604595F RID: 285023 RVA: 0x0114764C File Offset: 0x0114584C
		[NullableContext(0)]
		public UniTask<bool> CheckRenderAssetsStreamingCompleted(FVectorDouble viewOrigin, [Nullable(1)] string reason, [Nullable(2)] Func<bool> abortCheckCondition = null)
		{
			IosAuditController.<CheckRenderAssetsStreamingCompleted>d__64 <CheckRenderAssetsStreamingCompleted>d__;
			<CheckRenderAssetsStreamingCompleted>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CheckRenderAssetsStreamingCompleted>d__.<>4__this = this;
			<CheckRenderAssetsStreamingCompleted>d__.viewOrigin = viewOrigin;
			<CheckRenderAssetsStreamingCompleted>d__.reason = reason;
			<CheckRenderAssetsStreamingCompleted>d__.abortCheckCondition = abortCheckCondition;
			<CheckRenderAssetsStreamingCompleted>d__.<>1__state = -1;
			<CheckRenderAssetsStreamingCompleted>d__.<>t__builder.Start<IosAuditController.<CheckRenderAssetsStreamingCompleted>d__64>(ref <CheckRenderAssetsStreamingCompleted>d__);
			return <CheckRenderAssetsStreamingCompleted>d__.<>t__builder.Task;
		}

		// Token: 0x06045960 RID: 285024 RVA: 0x011476A8 File Offset: 0x011458A8
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

		// Token: 0x06045961 RID: 285025 RVA: 0x011476F4 File Offset: 0x011458F4
		[NullableContext(0)]
		public UniTask<bool> OpenLoading()
		{
			IosAuditController.<OpenLoading>d__66 <OpenLoading>d__;
			<OpenLoading>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenLoading>d__.<>1__state = -1;
			<OpenLoading>d__.<>t__builder.Start<IosAuditController.<OpenLoading>d__66>(ref <OpenLoading>d__);
			return <OpenLoading>d__.<>t__builder.Task;
		}

		// Token: 0x06045962 RID: 285026 RVA: 0x0114772F File Offset: 0x0114592F
		[NullableContext(2)]
		public void SetTravelMp4(bool play, string path = null)
		{
			if (play && path == null)
			{
				return;
			}
			GameModeModel.Instance.PlayTravelMp4 = play;
			GameModeModel.Instance.TravelMp4Path = path;
		}

		// Token: 0x06045963 RID: 285027 RVA: 0x01147750 File Offset: 0x01145950
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
			defaultInterpolatedStringHandler.AppendFormatted<float>((num == 0) ? 0.8f : 1f);
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

		// Token: 0x06045964 RID: 285028 RVA: 0x0114793C File Offset: 0x01145B3C
		private void LoadAssetAsyncInternal(string path, ResourceSystem.EResourceLoadPriority priority, [Nullable(new byte[]
		{
			1,
			1,
			2
		})] Action<bool, string, UObject> loadCallback)
		{
			if (!string.IsNullOrEmpty(path))
			{
				ResourceSystem.Instance.LoadAsync<UObject>(path, delegate([Nullable(2)] UObject assetObject, string assetPath)
				{
					if (assetObject == null || !assetObject.IsValid())
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.Preload;
						ELogAuthor author = ELogAuthor.YZ;
						string message = "[IosAudit][预加载] 预加载资源失败";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Path", assetPath);
						instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						Action<bool, string, UObject> loadCallback3 = loadCallback;
						if (loadCallback3 != null)
						{
							loadCallback3(false, path, null);
						}
						if (!Info.Instance.IsBuildShipping)
						{
							ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PreloadFailConfirm);
							confirmBoxDataNew.SetTitle("[IosAudit][预加载] 预加载资源失败");
							confirmBoxDataNew.TextArgs = new string[]
							{
								assetPath ?? ""
							};
							ConfirmBoxController.Instance.ShowNetWorkConfirmBoxView(confirmBoxDataNew, null);
						}
						return;
					}
					this.HoldPreloadObject.AddCommonAsset(assetObject);
					Action<bool, string, UObject> loadCallback4 = loadCallback;
					if (loadCallback4 == null)
					{
						return;
					}
					loadCallback4(true, path, assetObject);
				}, priority, "js_undefined");
				return;
			}
			Log.Instance.Error(ELogModule.Preload, ELogAuthor.YZ, "[预加载] path路径为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			Action<bool, string, UObject> loadCallback2 = loadCallback;
			if (loadCallback2 == null)
			{
				return;
			}
			loadCallback2(false, path, null);
		}

		// Token: 0x17009B8E RID: 39822
		// (get) Token: 0x06045965 RID: 285029 RVA: 0x011479C8 File Offset: 0x01145BC8
		public static IosAuditController Instance
		{
			get
			{
				return IosAuditController._Instance;
			}
		}

		// Token: 0x06045966 RID: 285030 RVA: 0x011479CF File Offset: 0x01145BCF
		public static IosAuditController GetOrCreateInstance()
		{
			if (IosAuditController._Instance == null)
			{
				IosAuditController.CreateInstance();
			}
			return IosAuditController._Instance;
		}

		// Token: 0x06045967 RID: 285031 RVA: 0x011479E3 File Offset: 0x01145BE3
		public static bool CreateInstance()
		{
			if (IosAuditController._Instance != null)
			{
				return true;
			}
			IosAuditController._Instance = new IosAuditController();
			return true;
		}

		// Token: 0x06045968 RID: 285032 RVA: 0x011479F9 File Offset: 0x01145BF9
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06045969 RID: 285033 RVA: 0x011479FB File Offset: 0x01145BFB
		public static void ResetStaticDefaultValue()
		{
			IosAuditController._Instance = null;
		}

		// Token: 0x0604596A RID: 285034 RVA: 0x01147A03 File Offset: 0x01145C03
		static IosAuditController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(IosAuditController.CreateStaticDefaultValue), new Action(IosAuditController.ResetStaticDefaultValue));
		}

		// Token: 0x0604596C RID: 285036 RVA: 0x01147A48 File Offset: 0x01145C48
		[CompilerGenerated]
		internal static string <PrintLoadDetail>g__GetCmdValue|45_1(string cmd, string startStr)
		{
			int num = cmd.IndexOf(startStr, StringComparison.Ordinal);
			if (num != -1)
			{
				int num2 = cmd.IndexOf(' ', num + startStr.Length);
				return cmd.Substring(num + startStr.Length, (num2 == -1) ? (cmd.Length - (num + startStr.Length)) : (num2 - (num + startStr.Length)));
			}
			return "";
		}

		// Token: 0x040244EC RID: 148716
		private const int ONE_SECOND = 1000;

		// Token: 0x040244ED RID: 148717
		private const int GAME_MODE_CTRL_THINKING_INDEX = 21;

		// Token: 0x040244EE RID: 148718
		private const int SANWANGFENG_INSTANCEID = 1550;

		// Token: 0x040244EF RID: 148719
		private const int RENDER_ASSET_ABORT_CHECK_DISTANCE_SQUARE = 10000;

		// Token: 0x040244F0 RID: 148720
		public const int LOG_STREAMING_STUCK_INTERVAL = 60000;

		// Token: 0x040244F1 RID: 148721
		private float cellProgress;

		// Token: 0x040244F2 RID: 148722
		[TupleElementNames(new string[]
		{
			"Blocker",
			"Timeout"
		})]
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		private readonly List<ValueTuple<Func<UniTask>, int>> WorldDoneBlockers = new List<ValueTuple<Func<UniTask>, int>>();

		// Token: 0x040244F3 RID: 148723
		protected bool IsWorldDoneBlockersExecuted;

		// Token: 0x040244F4 RID: 148724
		[Nullable(2)]
		private UHoldPreloadObject HoldPreloadObject;

		// Token: 0x040244F5 RID: 148725
		private bool HasOverrideQuality;

		// Token: 0x040244F6 RID: 148726
		private int LastGameQualityLevel = -1;

		// Token: 0x040244F7 RID: 148727
		private readonly global::Vector TmpLocation = global::Vector.Create();

		// Token: 0x040244F8 RID: 148728
		[Nullable(2)]
		private static IosAuditController _Instance;

		// Token: 0x0200CDDE RID: 52702
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403E023 RID: 253987
			[Nullable(0)]
			public static Action <0>__OnInterruptDataLayerSwitchTask;
		}
	}
}

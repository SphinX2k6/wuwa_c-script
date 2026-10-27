using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Aki.Protocol;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.SeamlessTravel;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using UnrealEngine;

namespace CSharpScript.Game.Module.Teleport
{
	// Token: 0x02004B69 RID: 19305
	[TickController(0)]
	public class TeleportController : ControllerBase
	{
		// Token: 0x06031FA7 RID: 204711 RVA: 0x00B9968C File Offset: 0x00B9788C
		public UniTask<bool> TeleportPlayer([Nullable(1)] ITeleportContext param)
		{
			TeleportController.<TeleportPlayer>d__3 <TeleportPlayer>d__;
			<TeleportPlayer>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<TeleportPlayer>d__.<>4__this = this;
			<TeleportPlayer>d__.param = param;
			<TeleportPlayer>d__.<>1__state = -1;
			<TeleportPlayer>d__.<>t__builder.Start<TeleportController.<TeleportPlayer>d__3>(ref <TeleportPlayer>d__);
			return <TeleportPlayer>d__.<>t__builder.Task;
		}

		// Token: 0x06031FA8 RID: 204712 RVA: 0x00B996D8 File Offset: 0x00B978D8
		public UniTask<bool> TeleportPlayerInVehicle([Nullable(1)] ITeleportContext param)
		{
			TeleportController.<TeleportPlayerInVehicle>d__4 <TeleportPlayerInVehicle>d__;
			<TeleportPlayerInVehicle>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<TeleportPlayerInVehicle>d__.<>4__this = this;
			<TeleportPlayerInVehicle>d__.param = param;
			<TeleportPlayerInVehicle>d__.<>1__state = -1;
			<TeleportPlayerInVehicle>d__.<>t__builder.Start<TeleportController.<TeleportPlayerInVehicle>d__4>(ref <TeleportPlayerInVehicle>d__);
			return <TeleportPlayerInVehicle>d__.<>t__builder.Task;
		}

		// Token: 0x06031FA9 RID: 204713 RVA: 0x00B99724 File Offset: 0x00B97924
		private UniTask<bool> TeleportPlayerInternal([Nullable(1)] TeleportContext teleportContext, bool isInVehicle)
		{
			TeleportController.<TeleportPlayerInternal>d__5 <TeleportPlayerInternal>d__;
			<TeleportPlayerInternal>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<TeleportPlayerInternal>d__.<>4__this = this;
			<TeleportPlayerInternal>d__.teleportContext = teleportContext;
			<TeleportPlayerInternal>d__.isInVehicle = isInVehicle;
			<TeleportPlayerInternal>d__.<>1__state = -1;
			<TeleportPlayerInternal>d__.<>t__builder.Start<TeleportController.<TeleportPlayerInternal>d__5>(ref <TeleportPlayerInternal>d__);
			return <TeleportPlayerInternal>d__.<>t__builder.Task;
		}

		// Token: 0x06031FAA RID: 204714 RVA: 0x00B99778 File Offset: 0x00B97978
		public UniTask<bool> TeleportElevatorAndPlayerSeparately([Nullable(1)] ITeleportContext param)
		{
			TeleportController.<TeleportElevatorAndPlayerSeparately>d__6 <TeleportElevatorAndPlayerSeparately>d__;
			<TeleportElevatorAndPlayerSeparately>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<TeleportElevatorAndPlayerSeparately>d__.param = param;
			<TeleportElevatorAndPlayerSeparately>d__.<>1__state = -1;
			<TeleportElevatorAndPlayerSeparately>d__.<>t__builder.Start<TeleportController.<TeleportElevatorAndPlayerSeparately>d__6>(ref <TeleportElevatorAndPlayerSeparately>d__);
			return <TeleportElevatorAndPlayerSeparately>d__.<>t__builder.Task;
		}

		// Token: 0x06031FAB RID: 204715 RVA: 0x00B997BC File Offset: 0x00B979BC
		public bool QueryCanTeleportNoLoading(FVectorDouble targetPosition)
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (baseCharacter == null || !baseCharacter.IsValid())
			{
				Log.Instance.Warn(ELogModule.Teleport, ELogAuthor.CK, "查询是否可以无加载传送: 失败, 找不到当前玩家", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			if (!GameModeModel.Instance.UseWorldPartition)
			{
				return true;
			}
			UWorldPartitionSubsystem uworldPartitionSubsystem = UKuroRenderingRuntimeBPPluginBPLibrary.GetSubsystem(GlobalData.World, UWorldPartitionSubsystem.StaticClass()) as UWorldPartitionSubsystem;
			FWorldPartitionStreamingQuerySource fworldPartitionStreamingQuerySource = new FWorldPartitionStreamingQuerySource();
			fworldPartitionStreamingQuerySource.Location = targetPosition.ToVector();
			fworldPartitionStreamingQuerySource.bUseGridLoadingRange = false;
			fworldPartitionStreamingQuerySource.Radius = 3000f;
			TArray<FWorldPartitionStreamingQuerySource> tarray = new TArray<FWorldPartitionStreamingQuerySource>();
			tarray.Add(fworldPartitionStreamingQuerySource);
			int num = 0;
			int num2 = 0;
			return uworldPartitionSubsystem.IsStreamingCompleted(EWorldPartitionRuntimeCellState.Activated, tarray, false, ref num, ref num2, true, false);
		}

		// Token: 0x06031FAC RID: 204716 RVA: 0x00B99870 File Offset: 0x00B97A70
		private bool CheckNeedFakeTeleport(TeleportReason? serverReason)
		{
			return ((serverReason.GetValueOrDefault() == TeleportReason.Action || serverReason.GetValueOrDefault() == TeleportReason.FlowAction || serverReason.GetValueOrDefault() == TeleportReason.Fall) && AutoRunModel.Instance.IsInLogicTreeGmMode()) || (serverReason.GetValueOrDefault() == TeleportReason.Gm && PlotModel.Instance.IsInHighLevelPlot());
		}

		// Token: 0x06031FAD RID: 204717 RVA: 0x00B998C4 File Offset: 0x00B97AC4
		protected override bool OnInit()
		{
			Net.Instance.Register(ENotifyMessageId.TeleportNotify, new Action<IMessage, Net.CallbackStatus>(this.OnTeleportNotify));
			Net.Instance.Register(ENotifyMessageId.TeleportVehicleNotify, new Action<IMessage, Net.CallbackStatus>(this.OnTeleportVehicleNotify));
			Net.Instance.Register(ENotifyMessageId.TeleportFlowNotify, new Action<IMessage, Net.CallbackStatus>(this.OnTeleportFlowNotify));
			return true;
		}

		// Token: 0x06031FAE RID: 204718 RVA: 0x00B99926 File Offset: 0x00B97B26
		protected override bool OnClear()
		{
			Net.Instance.UnRegister(ENotifyMessageId.TeleportNotify);
			Net.Instance.UnRegister(ENotifyMessageId.TeleportVehicleNotify);
			Net.Instance.UnRegister(ENotifyMessageId.TeleportFlowNotify);
			return true;
		}

		// Token: 0x06031FAF RID: 204719 RVA: 0x00B9995C File Offset: 0x00B97B5C
		protected override void OnTick(float delta)
		{
			TeleportContext teleportContext = TeleportModel.Instance.TeleportContext;
			if (teleportContext != null && teleportContext.Seamless.GetValueOrDefault())
			{
				SeamlessTravelTreadmill treadmill = teleportContext.Treadmill;
				if (treadmill != null)
				{
					treadmill.Tick(delta);
				}
				SeamlessTravelPostProcess postProcess = teleportContext.PostProcess;
				if (postProcess != null)
				{
					postProcess.Tick(delta);
				}
				SeamlessTravelKeepMovementMode keepMovementMode = teleportContext.KeepMovementMode;
				if (keepMovementMode != null)
				{
					keepMovementMode.Tick(delta);
				}
			}
			if (!TeleportModel.Instance.IsTeleport)
			{
				this.HandleCacheServerTeleportNotify();
			}
		}

		// Token: 0x06031FB0 RID: 204720 RVA: 0x00B999CC File Offset: 0x00B97BCC
		private void HandleCacheServerTeleportNotify()
		{
			if (this.TeleportPlayerNotifyCache != null)
			{
				this.OnTeleportNotify(this.TeleportPlayerNotifyCache, null);
				return;
			}
			if (this.TeleportVehicleNotifyCache != null)
			{
				this.OnTeleportVehicleNotify(this.TeleportVehicleNotifyCache, null);
			}
		}

		// Token: 0x06031FB1 RID: 204721 RVA: 0x00B999FC File Offset: 0x00B97BFC
		public UniTask<bool> TeleportToPositionNoLoading(FVectorDouble targetPosition, FRotator? targetRotation, [Nullable(1)] string reason, bool bNeedRestoreCamera = true)
		{
			TeleportController.<TeleportToPositionNoLoading>d__13 <TeleportToPositionNoLoading>d__;
			<TeleportToPositionNoLoading>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<TeleportToPositionNoLoading>d__.<>4__this = this;
			<TeleportToPositionNoLoading>d__.targetPosition = targetPosition;
			<TeleportToPositionNoLoading>d__.targetRotation = targetRotation;
			<TeleportToPositionNoLoading>d__.reason = reason;
			<TeleportToPositionNoLoading>d__.bNeedRestoreCamera = bNeedRestoreCamera;
			<TeleportToPositionNoLoading>d__.<>1__state = -1;
			<TeleportToPositionNoLoading>d__.<>t__builder.Start<TeleportController.<TeleportToPositionNoLoading>d__13>(ref <TeleportToPositionNoLoading>d__);
			return <TeleportToPositionNoLoading>d__.<>t__builder.Task;
		}

		// Token: 0x06031FB2 RID: 204722 RVA: 0x00B99A60 File Offset: 0x00B97C60
		[NullableContext(2)]
		private unsafe void OnTeleportNotify(IMessage msg, Net.CallbackStatus status)
		{
			TeleportNotify teleportNotify = (TeleportNotify)msg;
			FVectorDouble targetPosition = (teleportNotify.Position != null) ? global::Vector.Create(teleportNotify.Position).ToUeVector(false) : global::Vector.ZeroVectorDouble;
			FRotator frotator = (teleportNotify.Rotation != null) ? global::Rotator.Create(teleportNotify.Rotation.Y, teleportNotify.Rotation.Z, teleportNotify.Rotation.X).ToUeRotator() : global::Rotator.ZeroRotator;
			global::Vector targetGravityDirect = (teleportNotify.GravityDirection != null) ? global::Vector.Create(teleportNotify.GravityDirection) : global::Vector.DownVectorProxy;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Teleport;
			ELogAuthor author = ELogAuthor.CK;
			string message = "传送: 收到传送协议";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Context", JsonSerializer.Serialize<GameCtxPb>(teleportNotify.GameCtx, null));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Pos", teleportNotify.Position);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Rot", teleportNotify.Rotation);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Gravity", teleportNotify.GravityDirection);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("Reason", teleportNotify.Reason);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
			if (TeleportModel.Instance.IsTeleport)
			{
				this.TeleportPlayerNotifyCache = teleportNotify;
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Teleport;
				ELogAuthor author2 = ELogAuthor.CK;
				string message2 = "传送: 传送中再次收到传送协议, 缓存";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SeverTeleportReason", teleportNotify.Reason);
				instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.TeleportPlayerNotifyCache = null;
			ITeleportContextParam teleportContextParam = new ITeleportContextParam();
			teleportContextParam.ClientReason = "OnTeleportNotify";
			teleportContextParam.TargetPosition = targetPosition;
			teleportContextParam.TargetRotation = frotator;
			teleportContextParam.TargetGravityDirect = targetGravityDirect;
			teleportContextParam.TeleportMode = new ETeleportMode?(ETeleportMode.Loading);
			teleportContextParam.ServerReason = new TeleportReason?(teleportNotify.Reason);
			teleportContextParam.TransitionConfigId = new int?(teleportNotify.TransferEffectId);
			teleportContextParam.Option = teleportNotify.TransitionOption;
			teleportContextParam.DisableAutoFade = new bool?(teleportNotify.DisableAutoFadeInScreen);
			GameCtxPb gameCtx = teleportNotify.GameCtx;
			int? teleportCfgId;
			if (gameCtx == null)
			{
				teleportCfgId = null;
			}
			else
			{
				TransferCtxPb transferCtxPb = gameCtx.TransferCtxPb;
				teleportCfgId = ((transferCtxPb != null) ? new int?(transferCtxPb.TeleportId) : null);
			}
			teleportContextParam.TeleportCfgId = teleportCfgId;
			teleportContextParam.GameCtx = teleportNotify.GameCtx;
			this.TeleportPlayer(teleportContextParam);
		}

		// Token: 0x06031FB3 RID: 204723 RVA: 0x00B99CC0 File Offset: 0x00B97EC0
		[NullableContext(2)]
		private void OnTeleportFlowNotify(IMessage __msg, Net.CallbackStatus status)
		{
			TeleportFlowNotify message = (TeleportFlowNotify)__msg;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Teleport;
			ELogAuthor author = ELogAuthor.JYS;
			string message4 = "收到上线播放CG请求";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Name", message.FlowName);
			instance.Info(module, author, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			LevelLoadingController.Instance.OpenLoading<ELoadingPerform>(ELoadingReason.LoadingTeleport, ELoadingPerform.FadeLoading, null, null, Array.Empty<object>());
			GameModeModel.Instance.PlayTravelMp4 = true;
			LevelLoadingController.Instance.WaitOpenLoading<ELoadingPerform>(ELoadingReason.CG, ELoadingPerform.CG, null, new object[]
			{
				message.FlowName,
				new Action(delegate()
				{
					TeleportFlowEndRequest teleportFlowEndRequest = TeleportFlowEndRequest.Create();
					teleportFlowEndRequest.FlowName = message.FlowName;
					if (string.IsNullOrEmpty(message.FlowName))
					{
						Log instance2 = Log.Instance;
						ELogModule module2 = ELogModule.Teleport;
						ELogAuthor author2 = ELogAuthor.JYS;
						string message2 = "收到的CG名称不存在";
						ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Name", message.FlowName);
						instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					}
					Net.Instance.Call(ERequestMessageId.TeleportFlowEndRequest, teleportFlowEndRequest, delegate(IMessage msg, Net.CallbackStatus callbackStatus)
					{
						TeleportFlowEndResponse teleportFlowEndResponse = (TeleportFlowEndResponse)msg;
						if (teleportFlowEndResponse == null || teleportFlowEndResponse.Code != ErrorCode.Success)
						{
							Log instance3 = Log.Instance;
							ELogModule module3 = ELogModule.Teleport;
							ELogAuthor author3 = ELogAuthor.JYS;
							string message3 = "播放CG完成请求失败";
							ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("ErrorCode", teleportFlowEndResponse.Code);
							instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
						}
						TeleportContext teleportContext = TeleportModel.Instance.TeleportContext;
						if (teleportContext != null)
						{
							GameModePromise cgTeleportCompleted = teleportContext.CgTeleportCompleted;
							if (cgTeleportCompleted != null)
							{
								cgTeleportCompleted.SetResult(true);
							}
						}
						GameModePromise videoStartPromise = GameModeModel.Instance.VideoStartPromise;
						if (videoStartPromise != null)
						{
							videoStartPromise.SetResult(true);
						}
						LevelLoadingController.Instance.CloseLoading(ELoadingReason.CG, null, null, null);
						LevelLoadingController.Instance.CloseLoading(ELoadingReason.LoadingTeleport, null, null, null);
					}, 0);
				}),
				false
			});
		}

		// Token: 0x06031FB4 RID: 204724 RVA: 0x00B99D6C File Offset: 0x00B97F6C
		[NullableContext(2)]
		private unsafe void OnTeleportVehicleNotify(IMessage msg, Net.CallbackStatus status)
		{
			TeleportVehicleNotify teleportVehicleNotify = (TeleportVehicleNotify)msg;
			if (teleportVehicleNotify.Location == null)
			{
				Log.Instance.Error(ELogModule.Teleport, ELogAuthor.YSQ, "传送载具：目标位置错误", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			long creatureDataId = MathUtils.Instance.LongToNumber(teleportVehicleNotify.Vehicle);
			bool flag = teleportVehicleNotify.PsgPlayerIds.Count > 0;
			FVectorDouble fvectorDouble = new FVectorDouble((double)teleportVehicleNotify.Location.X, (double)teleportVehicleNotify.Location.Y, (double)teleportVehicleNotify.Location.Z);
			Aki.Protocol.Rotator rotation = teleportVehicleNotify.Rotation;
			float pitch = (rotation != null) ? rotation.Pitch : 0f;
			Aki.Protocol.Rotator rotation2 = teleportVehicleNotify.Rotation;
			float yaw = (rotation2 != null) ? rotation2.Yaw : 0f;
			Aki.Protocol.Rotator rotation3 = teleportVehicleNotify.Rotation;
			global::Rotator rotator = global::Rotator.Create(pitch, yaw, (rotation3 != null) ? rotation3.Roll : 0f);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Teleport;
			ELogAuthor author = ELogAuthor.CK;
			string message = "OnTeleportVehicleNotify";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Position", fvectorDouble);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Rotation", rotator);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Reason", teleportVehicleNotify.Reason);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			if (!flag)
			{
				this.SetEntityLocation(creatureDataId, fvectorDouble, rotator, global::Vector.DownVectorProxy);
				return;
			}
			if (TeleportModel.Instance.IsTeleport)
			{
				this.TeleportVehicleNotifyCache = teleportVehicleNotify;
				return;
			}
			if (!this.IsPlayerInVehicle())
			{
				this.TeleportVehicleNotifyCache = teleportVehicleNotify;
				return;
			}
			this.TeleportVehicleNotifyCache = null;
			TeleportController.Instance.TeleportPlayerInVehicle(new ITeleportContextParam
			{
				ClientReason = "OnTeleportVehicleNotify",
				TargetPosition = fvectorDouble,
				TargetRotation = rotator.ToUeRotator(),
				TeleportMode = new ETeleportMode?(teleportVehicleNotify.NoLoading ? ETeleportMode.Auto : ETeleportMode.Loading),
				ServerReason = new TeleportReason?(teleportVehicleNotify.Reason),
				Option = teleportVehicleNotify.TransitionOption
			});
		}

		// Token: 0x06031FB5 RID: 204725 RVA: 0x00B99F60 File Offset: 0x00B98160
		private bool IsPlayerInVehicle()
		{
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			BaseActorComponent baseActorComponent;
			if (getCurrentEntity == null)
			{
				baseActorComponent = null;
			}
			else
			{
				WorldEntity entity = getCurrentEntity.Entity;
				baseActorComponent = ((entity != null) ? entity.GetComponent<BaseActorComponent>() : null);
			}
			BaseActorComponent baseActorComponent2 = baseActorComponent;
			return baseActorComponent2 != null && baseActorComponent2.Entity.CheckGetComponent<CharacterDriveVehicleComponent>().VehicleEntity != null;
		}

		// Token: 0x06031FB6 RID: 204726 RVA: 0x00B99FAC File Offset: 0x00B981AC
		[NullableContext(1)]
		private unsafe void SetEntityLocation(long creatureDataId, IVector targetPosition, global::Rotator targetRotation, IVector targetGravityDirection)
		{
			EntityHandle entity = CreatureModel.Instance.GetEntity(creatureDataId);
			if (entity == null || !entity.Valid)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Teleport;
				ELogAuthor author = ELogAuthor.LYY;
				string message = "传送载具：实体已无效";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CreatureDataId", creatureDataId);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			BaseActorComponent actorComponent = CharacterController.Instance.GetActorComponent(entity);
			actorComponent.SetActorRotation(targetRotation.ToUeRotator(), "ResetLocationForZRangeNotify", true);
			BaseGravityComponent component = entity.Entity.GetComponent<BaseGravityComponent>();
			if (component != null)
			{
				component.SetGravityByPriority(0, targetGravityDirection, true, -1f, true);
			}
			global::Vector vector = global::Vector.Create(targetPosition);
			CharacterActorComponent component2 = entity.Entity.GetComponent<CharacterActorComponent>();
			if (component2 != null)
			{
				component2.FixBornLocation("ResetLocationForZRangeNotify", true, vector, false, true, true);
			}
			else
			{
				actorComponent.SetActorLocation(vector.ToUeVector(false), "ResetLocationForZRangeNotify", false);
			}
			BaseMoveComponent moveComp = actorComponent.MoveComp;
			if (moveComp != null)
			{
				moveComp.SetForceSpeed(global::Vector.ZeroVectorProxy);
			}
			BaseMovementSyncComponent component3 = entity.Entity.GetComponent<BaseMovementSyncComponent>();
			if (component3 != null)
			{
				component3.ClearReplaySamples();
			}
			EventSystem.Instance.EmitWithTarget(entity.Entity, EEventName.TeleportChangeLocation);
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Teleport;
			ELogAuthor author2 = ELogAuthor.CK;
			string message2 = "传送载具：设置载具实体位置";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CreatureDataId", entity.CreatureDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PbDataId", entity.PbDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("EntityId", entity.Entity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Location", vector.ToString());
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}

		// Token: 0x06031FB7 RID: 204727 RVA: 0x00B9A174 File Offset: 0x00B98374
		protected override bool OnLeaveLevel()
		{
			TeleportContext teleportContext = TeleportModel.Instance.TeleportContext;
			if (teleportContext == null)
			{
				return true;
			}
			if (teleportContext.CheckStreamingCompletedTimerId != null)
			{
				if (TimerSystem.GameplayTimeInstance.Has(teleportContext.CheckStreamingCompletedTimerId))
				{
					TimerSystem.GameplayTimeInstance.Remove(teleportContext.CheckStreamingCompletedTimerId);
				}
				teleportContext.CheckStreamingCompletedTimerId = null;
			}
			GameModePromise voxelStreamingCompleted = teleportContext.VoxelStreamingCompleted;
			if (voxelStreamingCompleted != null)
			{
				voxelStreamingCompleted.SetResult(true);
			}
			GameModePromise streamingCompleted = teleportContext.StreamingCompleted;
			if (streamingCompleted != null)
			{
				streamingCompleted.SetResult(true);
			}
			return true;
		}

		// Token: 0x17007BDC RID: 31708
		// (get) Token: 0x06031FB8 RID: 204728 RVA: 0x00B9A1E8 File Offset: 0x00B983E8
		[Nullable(1)]
		public static TeleportController Instance
		{
			[NullableContext(1)]
			get
			{
				return TeleportController._Instance;
			}
		}

		// Token: 0x06031FB9 RID: 204729 RVA: 0x00B9A1EF File Offset: 0x00B983EF
		[NullableContext(1)]
		public static TeleportController GetOrCreateInstance()
		{
			if (TeleportController._Instance == null)
			{
				TeleportController.CreateInstance();
			}
			return TeleportController._Instance;
		}

		// Token: 0x06031FBA RID: 204730 RVA: 0x00B9A203 File Offset: 0x00B98403
		public static bool CreateInstance()
		{
			if (TeleportController._Instance != null)
			{
				return true;
			}
			TeleportController._Instance = new TeleportController();
			return true;
		}

		// Token: 0x06031FBB RID: 204731 RVA: 0x00B9A219 File Offset: 0x00B98419
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06031FBC RID: 204732 RVA: 0x00B9A21B File Offset: 0x00B9841B
		public static void ResetStaticDefaultValue()
		{
			TeleportController._Instance = null;
		}

		// Token: 0x06031FBD RID: 204733 RVA: 0x00B9A223 File Offset: 0x00B98423
		static TeleportController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TeleportController.CreateStaticDefaultValue), new Action(TeleportController.ResetStaticDefaultValue));
		}

		// Token: 0x0401AA47 RID: 109127
		private const int STREAMING_SOURCE_RADIUS_TELEPORT_NO_LOADING = 3000;

		// Token: 0x0401AA48 RID: 109128
		[Nullable(2)]
		private TeleportNotify TeleportPlayerNotifyCache;

		// Token: 0x0401AA49 RID: 109129
		[Nullable(2)]
		private TeleportVehicleNotify TeleportVehicleNotifyCache;

		// Token: 0x0401AA4A RID: 109130
		[Nullable(2)]
		private static TeleportController _Instance;
	}
}

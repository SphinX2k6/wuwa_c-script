using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.DeadRevive;
using CSharpScript.Game.Module.QuickTimeAction;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Teleport
{
	// Token: 0x02003B14 RID: 15124
	public class TeleportCore : TeleportContextHolder
	{
		// Token: 0x06026D59 RID: 159065 RVA: 0x00ADE6D2 File Offset: 0x00ADC8D2
		[NullableContext(1)]
		public TeleportCore(TeleportContext context) : base(context)
		{
		}

		// Token: 0x06026D5A RID: 159066 RVA: 0x00ADE6DC File Offset: 0x00ADC8DC
		public UniTask<bool> TeleportPlayerNoLoading(bool isInVehicle)
		{
			TeleportCore.<TeleportPlayerNoLoading>d__2 <TeleportPlayerNoLoading>d__;
			<TeleportPlayerNoLoading>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<TeleportPlayerNoLoading>d__.<>4__this = this;
			<TeleportPlayerNoLoading>d__.isInVehicle = isInVehicle;
			<TeleportPlayerNoLoading>d__.<>1__state = -1;
			<TeleportPlayerNoLoading>d__.<>t__builder.Start<TeleportCore.<TeleportPlayerNoLoading>d__2>(ref <TeleportPlayerNoLoading>d__);
			return <TeleportPlayerNoLoading>d__.<>t__builder.Task;
		}

		// Token: 0x06026D5B RID: 159067 RVA: 0x00ADE728 File Offset: 0x00ADC928
		public UniTask<bool> TeleportPlayerWithLoading(bool isInVehicle)
		{
			TeleportCore.<TeleportPlayerWithLoading>d__3 <TeleportPlayerWithLoading>d__;
			<TeleportPlayerWithLoading>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<TeleportPlayerWithLoading>d__.<>4__this = this;
			<TeleportPlayerWithLoading>d__.isInVehicle = isInVehicle;
			<TeleportPlayerWithLoading>d__.<>1__state = -1;
			<TeleportPlayerWithLoading>d__.<>t__builder.Start<TeleportCore.<TeleportPlayerWithLoading>d__3>(ref <TeleportPlayerWithLoading>d__);
			return <TeleportPlayerWithLoading>d__.<>t__builder.Task;
		}

		// Token: 0x06026D5C RID: 159068 RVA: 0x00ADE774 File Offset: 0x00ADC974
		public UniTask<bool> TeleportElevatorAndPlayerSeparately()
		{
			TeleportCore.<TeleportElevatorAndPlayerSeparately>d__4 <TeleportElevatorAndPlayerSeparately>d__;
			<TeleportElevatorAndPlayerSeparately>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<TeleportElevatorAndPlayerSeparately>d__.<>4__this = this;
			<TeleportElevatorAndPlayerSeparately>d__.<>1__state = -1;
			<TeleportElevatorAndPlayerSeparately>d__.<>t__builder.Start<TeleportCore.<TeleportElevatorAndPlayerSeparately>d__4>(ref <TeleportElevatorAndPlayerSeparately>d__);
			return <TeleportElevatorAndPlayerSeparately>d__.<>t__builder.Task;
		}

		// Token: 0x06026D5D RID: 159069 RVA: 0x00ADE7B8 File Offset: 0x00ADC9B8
		public UniTask<bool> FakeTeleportPlayerWithLoading()
		{
			TeleportCore.<FakeTeleportPlayerWithLoading>d__5 <FakeTeleportPlayerWithLoading>d__;
			<FakeTeleportPlayerWithLoading>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<FakeTeleportPlayerWithLoading>d__.<>4__this = this;
			<FakeTeleportPlayerWithLoading>d__.<>1__state = -1;
			<FakeTeleportPlayerWithLoading>d__.<>t__builder.Start<TeleportCore.<FakeTeleportPlayerWithLoading>d__5>(ref <FakeTeleportPlayerWithLoading>d__);
			return <FakeTeleportPlayerWithLoading>d__.<>t__builder.Task;
		}

		// Token: 0x06026D5E RID: 159070 RVA: 0x00ADE7FC File Offset: 0x00ADC9FC
		[NullableContext(2)]
		private void RecordStartAndTargetTransformData(bool isInVehicle, BaseActorComponent actorComp)
		{
			TeleportModel instance = TeleportModel.Instance;
			if (actorComp != null && actorComp.Valid)
			{
				instance.StartPosition.DeepCopy(actorComp.ActorLocationProxy);
				instance.StartRotation.DeepCopy(actorComp.ActorRotationProxy);
				instance.StartGravityDirect.DeepCopy(actorComp.ActorGravityDirectProxy);
			}
			else
			{
				Log.Instance.Info(ELogModule.Teleport, ELogAuthor.CK, "传送: RecordStartAndTargetTransformData时BaseActorComponent还未加载完毕", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			FVectorDouble targetPosition = this.TeleportContext.TargetPosition;
			IVector targetGravityDirect = this.TeleportContext.TargetGravityDirect;
			IRotator targetRotation = this.TeleportContext.TargetRotation;
			instance.TargetPosition.DeepCopy(targetPosition);
			if (targetGravityDirect != null)
			{
				instance.TargetGravityDirect.DeepCopy(targetGravityDirect);
			}
			else
			{
				instance.TargetGravityDirect.DeepCopy(instance.StartGravityDirect);
			}
			if (!instance.TargetGravityDirect.Normalize(9.99999993922529E-09))
			{
				instance.TargetGravityDirect.DeepCopy(global::Vector.DownVectorProxy);
			}
			if (MathUtils.Instance.IsNearlyEqual(instance.TargetGravityDirect.Z, -1.0, null) && instance.TargetGravityDirect.Inequality(global::Vector.DownVectorProxy))
			{
				instance.TargetGravityDirect.DeepCopy(global::Vector.DownVectorProxy);
			}
			if (targetRotation != null)
			{
				instance.TargetRotation.DeepCopy(targetRotation);
			}
			else if (actorComp != null && actorComp.Valid)
			{
				Quat.FindBetween(actorComp.ActorGravityDirectProxy, instance.TargetGravityDirect, MathUtils.Instance.CommonTempQuat);
				Quat quat = Quat.Create(0.0, 0.0, 0.0, 1.0);
				MathUtils.Instance.CommonTempQuat.Multiply(actorComp.ActorRotationProxy.Quaternion(null), quat);
				quat.Rotator(instance.TargetRotation);
			}
			else
			{
				instance.TargetRotation.Reset();
			}
			if (!isInVehicle)
			{
				global::Vector up = instance.TargetGravityDirect.Multiply(-1.0, global::Vector.Create());
				instance.TargetRotation.Quaternion(null).GetForwardVector(MathUtils.Instance.CommonTempVector);
				MathUtils.Instance.LookRotationUpFirst(MathUtils.Instance.CommonTempVector, up, instance.TargetRotation);
			}
		}

		// Token: 0x06026D5F RID: 159071 RVA: 0x00ADEA28 File Offset: 0x00ADCC28
		private UniTask HandleStreamingLogic(bool shouldCollectGarbage)
		{
			TeleportCore.<HandleStreamingLogic>d__7 <HandleStreamingLogic>d__;
			<HandleStreamingLogic>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HandleStreamingLogic>d__.<>4__this = this;
			<HandleStreamingLogic>d__.shouldCollectGarbage = shouldCollectGarbage;
			<HandleStreamingLogic>d__.<>1__state = -1;
			<HandleStreamingLogic>d__.<>t__builder.Start<TeleportCore.<HandleStreamingLogic>d__7>(ref <HandleStreamingLogic>d__);
			return <HandleStreamingLogic>d__.<>t__builder.Task;
		}

		// Token: 0x06026D60 RID: 159072 RVA: 0x00ADEA74 File Offset: 0x00ADCC74
		[NullableContext(2)]
		private void EmitTeleportStartEvent(Entity entity)
		{
			Log.Instance.Info(ELogModule.Teleport, ELogAuthor.CK, "传送: 发送传送开始事件 开始执行 EmitTeleportStartEvent", default(ReadOnlySpan<ValueTuple<string, object>>));
			try
			{
				TeleportCore.<EmitTeleportStartEvent>g__EmitTeleportStartEventWithoutLog|8_0(entity);
				Log.Instance.Info(ELogModule.Teleport, ELogAuthor.CK, "传送: 发送传送开始事件 执行完成 EmitTeleportStartEvent", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			catch (Exception ex)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Teleport;
				ELogAuthor author = ELogAuthor.CK;
				string message = "传送: 发送传送开始事件 执行异常";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("error", ex.Message);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				throw;
			}
		}

		// Token: 0x06026D61 RID: 159073 RVA: 0x00ADEB0C File Offset: 0x00ADCD0C
		[NullableContext(2)]
		private void EmitTeleportOpenLoadingEndEvent(Entity entity)
		{
			Log.Instance.Info(ELogModule.Teleport, ELogAuthor.CK, "传送: 发送Loading打开完成事件 开始执行 EmitTeleportOpenLoadingEndEvent", default(ReadOnlySpan<ValueTuple<string, object>>));
			try
			{
				TeleportCore.<EmitTeleportOpenLoadingEndEvent>g__EmitTeleportOpenLoadingEndEventWithoutLog|9_0(entity);
				Log.Instance.Info(ELogModule.Teleport, ELogAuthor.CK, "传送: 发送Loading打开完成事件 执行完成 EmitTeleportOpenLoadingEndEvent", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			catch (Exception ex)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Teleport;
				ELogAuthor author = ELogAuthor.CK;
				string message = "传送: 发送Loading打开完成事件 执行异常";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("error", ex.Message);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				throw;
			}
		}

		// Token: 0x06026D62 RID: 159074 RVA: 0x00ADEBA4 File Offset: 0x00ADCDA4
		private void EmitFixBornLocationEvent()
		{
			Log.Instance.Info(ELogModule.Teleport, ELogAuthor.CK, "传送: 发送修正出生位置事件 开始执行 EmitFixBornLocationEvent", default(ReadOnlySpan<ValueTuple<string, object>>));
			try
			{
				TeleportCore.<EmitFixBornLocationEvent>g__EmitFixBornLocationEventWithoutLog|10_0();
				Log.Instance.Info(ELogModule.Teleport, ELogAuthor.CK, "传送: 发送修正出生位置事件 执行完成 EmitFixBornLocationEvent", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			catch (Exception ex)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Teleport;
				ELogAuthor author = ELogAuthor.CK;
				string message = "传送: 发送修正出生位置事件 执行异常";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("error", ex.Message);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				throw;
			}
		}

		// Token: 0x06026D63 RID: 159075 RVA: 0x00ADEC38 File Offset: 0x00ADCE38
		private void EmitTeleportCompleteEvent()
		{
			Log.Instance.Info(ELogModule.Teleport, ELogAuthor.CK, "传送: 发送传送完成事件 开始执行 EmitTeleportCompleteEvent", default(ReadOnlySpan<ValueTuple<string, object>>));
			try
			{
				this.<EmitTeleportCompleteEvent>g__EmitTeleportCompleteEventWithoutLog|11_0();
				Log.Instance.Info(ELogModule.Teleport, ELogAuthor.CK, "传送: 发送传送完成事件 执行完成 EmitTeleportCompleteEvent", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			catch (Exception ex)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Teleport;
				ELogAuthor author = ELogAuthor.CK;
				string message = "传送: 发送传送完成事件 执行异常";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("error", ex.Message);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				throw;
			}
		}

		// Token: 0x06026D64 RID: 159076 RVA: 0x00ADECD0 File Offset: 0x00ADCED0
		[NullableContext(2)]
		private void EmitTeleportChangeLocationEvent(Entity entity)
		{
			Log.Instance.Info(ELogModule.Teleport, ELogAuthor.CK, "传送: 发送传送位置变更事件 开始执行 EmitTeleportChangeLocationEvent", default(ReadOnlySpan<ValueTuple<string, object>>));
			try
			{
				TeleportCore.<EmitTeleportChangeLocationEvent>g__EmitTeleportChangeLocationEventWithoutLog|12_0(entity);
				Log.Instance.Info(ELogModule.Teleport, ELogAuthor.CK, "传送: 发送传送位置变更事件 执行完成 EmitTeleportChangeLocationEvent", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			catch (Exception ex)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Teleport;
				ELogAuthor author = ELogAuthor.CK;
				string message = "传送: 发送传送位置变更事件 执行异常";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("error", ex.Message);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				throw;
			}
		}

		// Token: 0x06026D65 RID: 159077 RVA: 0x00ADED68 File Offset: 0x00ADCF68
		private unsafe void HandleCharacterInput()
		{
			TeleportModel instance = TeleportModel.Instance;
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			CharacterActorComponent characterActorComponent = (getCurrentEntity != null) ? getCurrentEntity.Entity.GetComponent<CharacterActorComponent>() : null;
			if (characterActorComponent == null)
			{
				Log.Instance.Error(ELogModule.Teleport, ELogAuthor.CK, "传送: HandleCharacterInput失败, 找不到当前编队实体的CharacterActorComponent", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			characterActorComponent.SetInputRotator(instance.TargetRotation);
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.Teleport;
			ELogAuthor author = ELogAuthor.CK;
			string message = "传送: 设置输入Rotator";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("当前Rotator", characterActorComponent.InputRotatorProxy);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("目标Rotator", instance.TargetRotation);
			instance2.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x06026D66 RID: 159078 RVA: 0x00ADEE28 File Offset: 0x00ADD028
		private unsafe void HandleCharacterTransform()
		{
			TeleportModel instance = TeleportModel.Instance;
			TeleportContext teleportContext = instance.TeleportContext;
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			CharacterActorComponent characterActorComponent = (getCurrentEntity != null) ? getCurrentEntity.Entity.GetComponent<CharacterActorComponent>() : null;
			if (characterActorComponent == null)
			{
				Log.Instance.Error(ELogModule.Teleport, ELogAuthor.CK, "传送: HandleCharacterTransform失败, 找不到当前编队实体的CharacterActorComponent", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			object obj;
			if (getCurrentEntity == null)
			{
				obj = null;
			}
			else
			{
				WorldEntity entity = getCurrentEntity.Entity;
				obj = ((entity != null) ? entity.GetComponent<CharacterAnimationComponent>() : null);
			}
			object obj2 = obj;
			if (obj2 != null)
			{
				obj2.StopModelBuffer();
			}
			if (getCurrentEntity != null)
			{
				WorldEntity entity2 = getCurrentEntity.Entity;
				if (entity2 != null)
				{
					CharacterDriveVehicleComponent component = entity2.GetComponent<CharacterDriveVehicleComponent>();
					if (component != null)
					{
						component.TryLeaveVehicleWhenTeleport();
					}
				}
			}
			characterActorComponent.SetActorRotation(instance.TargetRotation.ToUeRotator(), "TeleportController", false);
			object obj3;
			if (getCurrentEntity == null)
			{
				obj3 = null;
			}
			else
			{
				WorldEntity entity3 = getCurrentEntity.Entity;
				obj3 = ((entity3 != null) ? entity3.GetComponent<BaseGravityComponent>() : null);
			}
			object obj4 = obj3;
			if (obj4 != null)
			{
				obj4.SetGravityByPriority(0, instance.TargetGravityDirect, true, -1f, true);
			}
			characterActorComponent.TeleportAndFindStandLocation(instance.TargetPosition, true);
			if (teleportContext.KeepSpeedRelativeRotation.GetValueOrDefault())
			{
				global::Vector vector = global::Vector.Create();
				instance.StartRotation.Quaternion(null).Inverse(MathUtils.Instance.CommonTempQuat);
				MathUtils.Instance.CommonTempQuat.RotateVector(characterActorComponent.ActorVelocityProxy, vector);
				global::Vector vector2 = global::Vector.Create();
				instance.TargetRotation.Quaternion(null).RotateVector(vector, vector2);
				BaseMoveComponent moveComp = characterActorComponent.MoveComp;
				if (moveComp != null)
				{
					moveComp.SetForceSpeed(vector2);
				}
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.Teleport;
				ELogAuthor author = ELogAuthor.CK;
				string message = "传送: 设置玩家位置(保持相对速度)";
				<>y__InlineArray8<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray8<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("当前位置", instance.StartPosition);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("当前旋转", instance.StartRotation);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("当前重力", instance.StartGravityDirect);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("当前速度", characterActorComponent.ActorVelocityProxy);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("目标位置", instance.TargetPosition);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("目标旋转", instance.TargetRotation);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("目标重力", instance.TargetGravityDirect);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 7) = new ValueTuple<string, object>("目标速度", vector2);
				instance2.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 8));
			}
			else
			{
				Log instance3 = Log.Instance;
				ELogModule module2 = ELogModule.Teleport;
				ELogAuthor author2 = ELogAuthor.CK;
				string message2 = "传送: 设置玩家位置";
				<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray6<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("当前位置", instance.StartPosition);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("当前旋转", instance.StartRotation);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("当前重力", instance.StartGravityDirect);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("目标位置", instance.TargetPosition);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 4) = new ValueTuple<string, object>("目标旋转", instance.TargetRotation);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 5) = new ValueTuple<string, object>("目标重力", instance.TargetGravityDirect);
				instance3.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 6));
			}
			this.EmitTeleportChangeLocationEvent(getCurrentEntity.Entity);
			RoleTriggerController.Instance.UpdateTransform("");
		}

		// Token: 0x06026D67 RID: 159079 RVA: 0x00ADF198 File Offset: 0x00ADD398
		private unsafe void HandleVehicleTransform()
		{
			TeleportModel instance = TeleportModel.Instance;
			TeleportContext teleportContext = instance.TeleportContext;
			Entity driveVehicleEntityByPlayer = this.GetDriveVehicleEntityByPlayer();
			if (driveVehicleEntityByPlayer == null || !driveVehicleEntityByPlayer.Valid)
			{
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.Teleport;
				ELogAuthor author = ELogAuthor.CK;
				string message = "传送载具: 实体已无效";
				string item = "CreatureDataId";
				long? num;
				if (driveVehicleEntityByPlayer == null)
				{
					num = null;
				}
				else
				{
					CreatureDataComponent creatureDataComponent = driveVehicleEntityByPlayer.CheckGetComponent<CreatureDataComponent>();
					num = ((creatureDataComponent != null) ? new long?(creatureDataComponent.GetCreatureDataId()) : null);
				}
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, num);
				instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			VehicleActorComponent component = driveVehicleEntityByPlayer.GetComponent<VehicleActorComponent>();
			Log instance3 = Log.Instance;
			ELogModule module2 = ELogModule.Teleport;
			ELogAuthor author2 = ELogAuthor.CK;
			string message2 = "传送: 设置载具位置";
			<>y__InlineArray8<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray8<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("当前位置", instance.StartPosition);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("当前旋转", instance.StartRotation);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("当前重力", instance.StartGravityDirect);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("当前速度", component.ActorVelocityProxy);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("目标位置", instance.TargetPosition);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("目标旋转", instance.TargetRotation);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("目标重力", instance.TargetGravityDirect);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 7);
			string item2 = "目标速度";
			object item3;
			if (teleportContext.TargetSpeed == null)
			{
				IVector zeroVectorProxy = global::Vector.ZeroVectorProxy;
				item3 = zeroVectorProxy;
			}
			else
			{
				item3 = teleportContext.TargetSpeed;
			}
			ptr = new ValueTuple<string, object>(item2, item3);
			instance3.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 8));
			component.SetActorRotation(instance.TargetRotation.ToUeRotator(), "Teleport.HandleVehicleTransform", false);
			VehicleGravityComponent component2 = driveVehicleEntityByPlayer.GetComponent<VehicleGravityComponent>();
			if (component2 != null)
			{
				component2.SetGravityByPriority(0, instance.TargetGravityDirect, true, -1f, true);
			}
			global::Vector vector = global::Vector.Create(instance.TargetPosition);
			component.SetActorLocation(vector.ToUeVector(false), "Teleport.HandleVehicleTransform", false);
			VehicleMoveComponent vehicleMoveComp = component.VehicleMoveComp;
			if (vehicleMoveComp != null)
			{
				vehicleMoveComp.SetForceSpeed(teleportContext.TargetSpeed ?? global::Vector.ZeroVectorProxy);
			}
			MotorcycleSplineMoveComponent component3 = driveVehicleEntityByPlayer.GetComponent<MotorcycleSplineMoveComponent>();
			if (component3 != null)
			{
				component3.ForceClearUpdate();
			}
			BaseMovementSyncComponent component4 = driveVehicleEntityByPlayer.GetComponent<BaseMovementSyncComponent>();
			if (component4 != null)
			{
				component4.ClearReplaySamples();
			}
			this.EmitTeleportChangeLocationEvent(driveVehicleEntityByPlayer);
			RoleTriggerController.Instance.UpdateTransform("");
		}

		// Token: 0x06026D68 RID: 159080 RVA: 0x00ADF404 File Offset: 0x00ADD604
		[NullableContext(2)]
		private Entity GetDriveVehicleEntityByPlayer()
		{
			TeleportContext teleportContext = TeleportModel.Instance.TeleportContext;
			if (teleportContext.TeleportEntity != null)
			{
				return teleportContext.TeleportEntity;
			}
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			WorldEntity worldEntity = (getCurrentEntity != null) ? getCurrentEntity.Entity : null;
			if (worldEntity == null)
			{
				return null;
			}
			BaseActorComponent baseActorComponent = (worldEntity != null) ? worldEntity.GetComponent<BaseActorComponent>() : null;
			if (baseActorComponent == null)
			{
				return null;
			}
			Entity entity = baseActorComponent.Entity;
			Entity entity2;
			if (entity == null)
			{
				entity2 = null;
			}
			else
			{
				CharacterDriveVehicleComponent component = entity.GetComponent<CharacterDriveVehicleComponent>();
				entity2 = ((component != null) ? component.VehicleEntity : null);
			}
			Entity entity3 = entity2;
			teleportContext.TeleportEntity = entity3;
			return entity3;
		}

		// Token: 0x06026D69 RID: 159081 RVA: 0x00ADF480 File Offset: 0x00ADD680
		private unsafe void HandleCameraTransform()
		{
			TeleportModel instance = TeleportModel.Instance;
			TeleportContext teleportContext = instance.TeleportContext;
			global::Rotator cameraRotation = CameraController.Instance.MainModel.FightCamera.LogicComponent.CameraRotation;
			if (teleportContext.KeepCameraRelativeRotation.GetValueOrDefault())
			{
				Quat quat = Quat.Create(0.0, 0.0, 0.0, 1.0);
				instance.StartRotation.Quaternion(null).Inverse(MathUtils.Instance.CommonTempQuat);
				MathUtils.Instance.CommonTempQuat.Multiply(cameraRotation.Quaternion(null), quat);
				Quat quat2 = Quat.Create(0.0, 0.0, 0.0, 1.0);
				instance.TargetRotation.Quaternion(null).Multiply(quat, quat2);
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.Teleport;
				ELogAuthor author = ELogAuthor.CK;
				string message = "传送: 镜头调整(保持相对旋转)";
				<>y__InlineArray7<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray7<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("角色当前旋转", instance.StartRotation);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("角色目标旋转", instance.TargetRotation);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("相机当前旋转", cameraRotation);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("相机目标旋转", quat2.Rotator(null));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("相机相对角色旋转", quat.Rotator(null));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("bRestoreAdjust", false);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("bTeleport", true);
				instance2.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 7));
				CameraController.Instance.MainModel.FightCamera.LogicComponent.SetRotation(quat2.Rotator(null).ToUeRotator());
				CameraController.Instance.MainModel.FightCamera.LogicComponent.ResetFightCameraLogic(false, true);
				return;
			}
			Log instance3 = Log.Instance;
			ELogModule module2 = ELogModule.Teleport;
			ELogAuthor author2 = ELogAuthor.CK;
			string message2 = "传送: 镜头调整";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("相机当前旋转", cameraRotation);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("相机目标旋转", CameraUtility.GetCameraDefaultFocusUeRotator());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("bRestoreAdjust", teleportContext.NeedRestoreCamera);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("bTeleport", false);
			instance3.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
			CameraController.Instance.MainModel.FightCamera.LogicComponent.SetRotation(CameraUtility.GetCameraDefaultFocusUeRotator());
			CameraController.Instance.MainModel.FightCamera.LogicComponent.ResetFightCameraLogic(teleportContext.NeedRestoreCamera.GetValueOrDefault(), false);
		}

		// Token: 0x06026D6A RID: 159082 RVA: 0x00ADF780 File Offset: 0x00ADD980
		private void HandleVehicleCameraTransform()
		{
			CameraController.Instance.MainModel.FightCamera.LogicComponent.SetRotation(TeleportModel.Instance.TargetRotation.ToUeRotator());
			CameraController.Instance.MainModel.FightCamera.LogicComponent.ResetFightCameraLogic(this.TeleportContext.NeedRestoreCamera.GetValueOrDefault(), false);
		}

		// Token: 0x06026D6B RID: 159083 RVA: 0x00ADF7E4 File Offset: 0x00ADD9E4
		private UniTask CheckLiveLocationStreamingCompleted()
		{
			TeleportCore.<CheckLiveLocationStreamingCompleted>d__19 <CheckLiveLocationStreamingCompleted>d__;
			<CheckLiveLocationStreamingCompleted>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CheckLiveLocationStreamingCompleted>d__.<>4__this = this;
			<CheckLiveLocationStreamingCompleted>d__.<>1__state = -1;
			<CheckLiveLocationStreamingCompleted>d__.<>t__builder.Start<TeleportCore.<CheckLiveLocationStreamingCompleted>d__19>(ref <CheckLiveLocationStreamingCompleted>d__);
			return <CheckLiveLocationStreamingCompleted>d__.<>t__builder.Task;
		}

		// Token: 0x06026D6C RID: 159084 RVA: 0x00ADF828 File Offset: 0x00ADDA28
		private UniTask WaitServerResponse()
		{
			TeleportCore.<WaitServerResponse>d__20 <WaitServerResponse>d__;
			<WaitServerResponse>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitServerResponse>d__.<>4__this = this;
			<WaitServerResponse>d__.<>1__state = -1;
			<WaitServerResponse>d__.<>t__builder.Start<TeleportCore.<WaitServerResponse>d__20>(ref <WaitServerResponse>d__);
			return <WaitServerResponse>d__.<>t__builder.Task;
		}

		// Token: 0x06026D6D RID: 159085 RVA: 0x00ADF86B File Offset: 0x00ADDA6B
		private void CreateEntityFromPending()
		{
			GameModeModel.Instance.LoadingPhase = ELoadingPhase.CreateEntityStart;
			CreatureController.Instance.CreateEntityFromPending(EAddEntityType.Normal);
			GameModeModel.Instance.LoadingPhase = ELoadingPhase.CreateEntityEnd;
		}

		// Token: 0x06026D6E RID: 159086 RVA: 0x00ADF890 File Offset: 0x00ADDA90
		private UniTask PreAwakeEntitiesFromPending()
		{
			TeleportCore.<PreAwakeEntitiesFromPending>d__22 <PreAwakeEntitiesFromPending>d__;
			<PreAwakeEntitiesFromPending>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreAwakeEntitiesFromPending>d__.<>1__state = -1;
			<PreAwakeEntitiesFromPending>d__.<>t__builder.Start<TeleportCore.<PreAwakeEntitiesFromPending>d__22>(ref <PreAwakeEntitiesFromPending>d__);
			return <PreAwakeEntitiesFromPending>d__.<>t__builder.Task;
		}

		// Token: 0x06026D6F RID: 159087 RVA: 0x00ADF8CC File Offset: 0x00ADDACC
		private UniTask WaitRenderAssetsStreamingCompleted()
		{
			TeleportCore.<WaitRenderAssetsStreamingCompleted>d__23 <WaitRenderAssetsStreamingCompleted>d__;
			<WaitRenderAssetsStreamingCompleted>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitRenderAssetsStreamingCompleted>d__.<>4__this = this;
			<WaitRenderAssetsStreamingCompleted>d__.<>1__state = -1;
			<WaitRenderAssetsStreamingCompleted>d__.<>t__builder.Start<TeleportCore.<WaitRenderAssetsStreamingCompleted>d__23>(ref <WaitRenderAssetsStreamingCompleted>d__);
			return <WaitRenderAssetsStreamingCompleted>d__.<>t__builder.Task;
		}

		// Token: 0x06026D70 RID: 159088 RVA: 0x00ADF910 File Offset: 0x00ADDB10
		private UniTask WaitTeamLoaded()
		{
			TeleportCore.<WaitTeamLoaded>d__24 <WaitTeamLoaded>d__;
			<WaitTeamLoaded>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitTeamLoaded>d__.<>1__state = -1;
			<WaitTeamLoaded>d__.<>t__builder.Start<TeleportCore.<WaitTeamLoaded>d__24>(ref <WaitTeamLoaded>d__);
			return <WaitTeamLoaded>d__.<>t__builder.Task;
		}

		// Token: 0x06026D71 RID: 159089 RVA: 0x00ADF94C File Offset: 0x00ADDB4C
		private UniTask HandleTakeVehicleDuringTeleport()
		{
			TeleportCore.<HandleTakeVehicleDuringTeleport>d__25 <HandleTakeVehicleDuringTeleport>d__;
			<HandleTakeVehicleDuringTeleport>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HandleTakeVehicleDuringTeleport>d__.<>4__this = this;
			<HandleTakeVehicleDuringTeleport>d__.<>1__state = -1;
			<HandleTakeVehicleDuringTeleport>d__.<>t__builder.Start<TeleportCore.<HandleTakeVehicleDuringTeleport>d__25>(ref <HandleTakeVehicleDuringTeleport>d__);
			return <HandleTakeVehicleDuringTeleport>d__.<>t__builder.Task;
		}

		// Token: 0x06026D72 RID: 159090 RVA: 0x00ADF990 File Offset: 0x00ADDB90
		private UniTask WaitRollbackCompleted()
		{
			TeleportCore.<WaitRollbackCompleted>d__26 <WaitRollbackCompleted>d__;
			<WaitRollbackCompleted>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitRollbackCompleted>d__.<>4__this = this;
			<WaitRollbackCompleted>d__.<>1__state = -1;
			<WaitRollbackCompleted>d__.<>t__builder.Start<TeleportCore.<WaitRollbackCompleted>d__26>(ref <WaitRollbackCompleted>d__);
			return <WaitRollbackCompleted>d__.<>t__builder.Task;
		}

		// Token: 0x06026D73 RID: 159091 RVA: 0x00ADF9D4 File Offset: 0x00ADDBD4
		private void HandleTimeDilationBeforeTeleport()
		{
			Log.Instance.Info(ELogModule.Teleport, ELogAuthor.CK, "传送: 传送前解除时停 开始执行 HandleTimeDilationBeforeTeleport", default(ReadOnlySpan<ValueTuple<string, object>>));
			try
			{
				TeleportCore.<HandleTimeDilationBeforeTeleport>g__HandleTimeDilationBeforeTeleportWithoutLog|27_0();
				Log.Instance.Info(ELogModule.Teleport, ELogAuthor.CK, "传送: 传送前解除时停 执行完成 HandleTimeDilationBeforeTeleport", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			catch (Exception ex)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Teleport;
				ELogAuthor author = ELogAuthor.CK;
				string message = "传送: 传送前解除时停 执行异常";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("error", ex.Message);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				throw;
			}
		}

		// Token: 0x06026D74 RID: 159092 RVA: 0x00ADFA68 File Offset: 0x00ADDC68
		private void HandleTimeDilationAfterTeleport()
		{
			Log.Instance.Info(ELogModule.Teleport, ELogAuthor.CK, "传送: 传送后恢复时停 开始执行 HandleTimeDilationAfterTeleport", default(ReadOnlySpan<ValueTuple<string, object>>));
			try
			{
				TeleportCore.<HandleTimeDilationAfterTeleport>g__HandleTimeDilationAfterTeleportWithoutLog|28_0();
				Log.Instance.Info(ELogModule.Teleport, ELogAuthor.CK, "传送: 传送后恢复时停 执行完成 HandleTimeDilationAfterTeleport", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			catch (Exception ex)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Teleport;
				ELogAuthor author = ELogAuthor.CK;
				string message = "传送: 传送后恢复时停 执行异常";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("error", ex.Message);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				throw;
			}
		}

		// Token: 0x06026D75 RID: 159093 RVA: 0x00ADFAFC File Offset: 0x00ADDCFC
		private void HandleTeleportStartProcess(bool renderAssetDone)
		{
			GameModeModel.Instance.SetBornInfo(this.TeleportContext.TargetPosition, this.TeleportContext.TargetRotation);
			GameModeModel.Instance.IsTeleport = true;
			GameModeModel.Instance.LoadingPhase = ELoadingPhase.Start;
			GameModeModel.Instance.RenderAssetDone = renderAssetDone;
			WorldController.Instance.SetEnableWorldOriginTickCheck(this.TeleportContext.ClientReason, false);
			WorldController.Instance.StartWorldOriginInLoadingMode("Teleport");
			CharacterModel.Instance.ExitAllSelfCenteredMode();
			DeadReviveModel.Instance.SetSkipFallInjure(ESkipFallInjureReason.Teleport, true);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Teleport;
			ELogAuthor author = ELogAuthor.CK;
			string message = "传送: 慢放解除";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Reason", this.TeleportContext.ClientReason);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x06026D76 RID: 159094 RVA: 0x00ADFBC0 File Offset: 0x00ADDDC0
		private void HandleTeleportEndProcess()
		{
			RoleAudioController.Instance.SetUpdateAudioDynamicTrace(true);
			GameModeModel.Instance.IsTeleport = false;
			GameModeModel.Instance.LoadingPhase = ELoadingPhase.Finished;
			WorldController.Instance.SetEnableWorldOriginTickCheck(this.TeleportContext.ClientReason, true);
			WorldController instance = WorldController.Instance;
			string reason = "Teleport";
			FVectorDouble targetPosition = this.TeleportContext.TargetPosition;
			instance.EndWorldOriginInLoadingMode(reason, targetPosition);
			DeadReviveModel.Instance.SetSkipFallInjure(ESkipFallInjureReason.Teleport, false);
			this.EmitTeleportCompleteEvent();
			EventSystem.Instance.Emit(EEventName.RestartHangingPreloadTask);
		}

		// Token: 0x06026D77 RID: 159095 RVA: 0x00ADFC44 File Offset: 0x00ADDE44
		[CompilerGenerated]
		private UniTask<bool> <FakeTeleportPlayerWithLoading>g__FakeTeleportPlayerWithLoadingWithoutLog|5_0()
		{
			TeleportCore.<<FakeTeleportPlayerWithLoading>g__FakeTeleportPlayerWithLoadingWithoutLog|5_0>d <<FakeTeleportPlayerWithLoading>g__FakeTeleportPlayerWithLoadingWithoutLog|5_0>d;
			<<FakeTeleportPlayerWithLoading>g__FakeTeleportPlayerWithLoadingWithoutLog|5_0>d.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<<FakeTeleportPlayerWithLoading>g__FakeTeleportPlayerWithLoadingWithoutLog|5_0>d.<>4__this = this;
			<<FakeTeleportPlayerWithLoading>g__FakeTeleportPlayerWithLoadingWithoutLog|5_0>d.<>1__state = -1;
			<<FakeTeleportPlayerWithLoading>g__FakeTeleportPlayerWithLoadingWithoutLog|5_0>d.<>t__builder.Start<TeleportCore.<<FakeTeleportPlayerWithLoading>g__FakeTeleportPlayerWithLoadingWithoutLog|5_0>d>(ref <<FakeTeleportPlayerWithLoading>g__FakeTeleportPlayerWithLoadingWithoutLog|5_0>d);
			return <<FakeTeleportPlayerWithLoading>g__FakeTeleportPlayerWithLoadingWithoutLog|5_0>d.<>t__builder.Task;
		}

		// Token: 0x06026D78 RID: 159096 RVA: 0x00ADFC87 File Offset: 0x00ADDE87
		[NullableContext(2)]
		[CompilerGenerated]
		internal static void <EmitTeleportStartEvent>g__EmitTeleportStartEventWithoutLog|8_0(Entity entity)
		{
			EventSystem.Instance.Emit<bool>(EEventName.TeleportStart, true);
			if (entity != null)
			{
				EventSystem.Instance.EmitWithTarget<bool>(entity, EEventName.TeleportStartEntity, true);
			}
		}

		// Token: 0x06026D79 RID: 159097 RVA: 0x00ADFCAF File Offset: 0x00ADDEAF
		[NullableContext(2)]
		[CompilerGenerated]
		internal static void <EmitTeleportOpenLoadingEndEvent>g__EmitTeleportOpenLoadingEndEventWithoutLog|9_0(Entity entity)
		{
			EventSystem.Instance.Emit(EEventName.TeleportOpenLoadingEnd);
			if (entity != null)
			{
				EventSystem.Instance.EmitWithTarget(entity, EEventName.TeleportOpenLoadingEnd);
			}
		}

		// Token: 0x06026D7A RID: 159098 RVA: 0x00ADFCD5 File Offset: 0x00ADDED5
		[CompilerGenerated]
		internal static void <EmitFixBornLocationEvent>g__EmitFixBornLocationEventWithoutLog|10_0()
		{
			EventSystem.Instance.Emit(EEventName.FixBornLocation);
		}

		// Token: 0x06026D7B RID: 159099 RVA: 0x00ADFCE7 File Offset: 0x00ADDEE7
		[CompilerGenerated]
		private void <EmitTeleportCompleteEvent>g__EmitTeleportCompleteEventWithoutLog|11_0()
		{
			EventSystem.Instance.Emit<TeleportContext>(EEventName.TeleportComplete, this.TeleportContext);
		}

		// Token: 0x06026D7C RID: 159100 RVA: 0x00ADFCFF File Offset: 0x00ADDEFF
		[NullableContext(2)]
		[CompilerGenerated]
		internal static void <EmitTeleportChangeLocationEvent>g__EmitTeleportChangeLocationEventWithoutLog|12_0(Entity entity)
		{
			if (entity != null)
			{
				EventSystem.Instance.EmitWithTarget(entity, EEventName.TeleportChangeLocation);
			}
		}

		// Token: 0x06026D7D RID: 159101 RVA: 0x00ADFD18 File Offset: 0x00ADDF18
		[CompilerGenerated]
		private UniTask <CheckLiveLocationStreamingCompleted>g__CheckLiveLocationStreamingCompletedWithoutLog|19_0()
		{
			TeleportCore.<<CheckLiveLocationStreamingCompleted>g__CheckLiveLocationStreamingCompletedWithoutLog|19_0>d <<CheckLiveLocationStreamingCompleted>g__CheckLiveLocationStreamingCompletedWithoutLog|19_0>d;
			<<CheckLiveLocationStreamingCompleted>g__CheckLiveLocationStreamingCompletedWithoutLog|19_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<CheckLiveLocationStreamingCompleted>g__CheckLiveLocationStreamingCompletedWithoutLog|19_0>d.<>4__this = this;
			<<CheckLiveLocationStreamingCompleted>g__CheckLiveLocationStreamingCompletedWithoutLog|19_0>d.<>1__state = -1;
			<<CheckLiveLocationStreamingCompleted>g__CheckLiveLocationStreamingCompletedWithoutLog|19_0>d.<>t__builder.Start<TeleportCore.<<CheckLiveLocationStreamingCompleted>g__CheckLiveLocationStreamingCompletedWithoutLog|19_0>d>(ref <<CheckLiveLocationStreamingCompleted>g__CheckLiveLocationStreamingCompletedWithoutLog|19_0>d);
			return <<CheckLiveLocationStreamingCompleted>g__CheckLiveLocationStreamingCompletedWithoutLog|19_0>d.<>t__builder.Task;
		}

		// Token: 0x06026D7E RID: 159102 RVA: 0x00ADFD5C File Offset: 0x00ADDF5C
		[CompilerGenerated]
		private UniTask <WaitServerResponse>g__WaitServerResponseWithoutLog|20_0()
		{
			TeleportCore.<<WaitServerResponse>g__WaitServerResponseWithoutLog|20_0>d <<WaitServerResponse>g__WaitServerResponseWithoutLog|20_0>d;
			<<WaitServerResponse>g__WaitServerResponseWithoutLog|20_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<WaitServerResponse>g__WaitServerResponseWithoutLog|20_0>d.<>4__this = this;
			<<WaitServerResponse>g__WaitServerResponseWithoutLog|20_0>d.<>1__state = -1;
			<<WaitServerResponse>g__WaitServerResponseWithoutLog|20_0>d.<>t__builder.Start<TeleportCore.<<WaitServerResponse>g__WaitServerResponseWithoutLog|20_0>d>(ref <<WaitServerResponse>g__WaitServerResponseWithoutLog|20_0>d);
			return <<WaitServerResponse>g__WaitServerResponseWithoutLog|20_0>d.<>t__builder.Task;
		}

		// Token: 0x06026D80 RID: 159104 RVA: 0x00ADFDB4 File Offset: 0x00ADDFB4
		[CompilerGenerated]
		internal static UniTask <PreAwakeEntitiesFromPending>g__PreAwakeEntitiesFromPendingWithoutLog|22_0()
		{
			TeleportCore.<<PreAwakeEntitiesFromPending>g__PreAwakeEntitiesFromPendingWithoutLog|22_0>d <<PreAwakeEntitiesFromPending>g__PreAwakeEntitiesFromPendingWithoutLog|22_0>d;
			<<PreAwakeEntitiesFromPending>g__PreAwakeEntitiesFromPendingWithoutLog|22_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<PreAwakeEntitiesFromPending>g__PreAwakeEntitiesFromPendingWithoutLog|22_0>d.<>1__state = -1;
			<<PreAwakeEntitiesFromPending>g__PreAwakeEntitiesFromPendingWithoutLog|22_0>d.<>t__builder.Start<TeleportCore.<<PreAwakeEntitiesFromPending>g__PreAwakeEntitiesFromPendingWithoutLog|22_0>d>(ref <<PreAwakeEntitiesFromPending>g__PreAwakeEntitiesFromPendingWithoutLog|22_0>d);
			return <<PreAwakeEntitiesFromPending>g__PreAwakeEntitiesFromPendingWithoutLog|22_0>d.<>t__builder.Task;
		}

		// Token: 0x06026D81 RID: 159105 RVA: 0x00ADFDF0 File Offset: 0x00ADDFF0
		[CompilerGenerated]
		private UniTask <WaitRenderAssetsStreamingCompleted>g__WaitRenderAssetsStreamingCompletedWithoutLog|23_0()
		{
			TeleportCore.<<WaitRenderAssetsStreamingCompleted>g__WaitRenderAssetsStreamingCompletedWithoutLog|23_0>d <<WaitRenderAssetsStreamingCompleted>g__WaitRenderAssetsStreamingCompletedWithoutLog|23_0>d;
			<<WaitRenderAssetsStreamingCompleted>g__WaitRenderAssetsStreamingCompletedWithoutLog|23_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<WaitRenderAssetsStreamingCompleted>g__WaitRenderAssetsStreamingCompletedWithoutLog|23_0>d.<>4__this = this;
			<<WaitRenderAssetsStreamingCompleted>g__WaitRenderAssetsStreamingCompletedWithoutLog|23_0>d.<>1__state = -1;
			<<WaitRenderAssetsStreamingCompleted>g__WaitRenderAssetsStreamingCompletedWithoutLog|23_0>d.<>t__builder.Start<TeleportCore.<<WaitRenderAssetsStreamingCompleted>g__WaitRenderAssetsStreamingCompletedWithoutLog|23_0>d>(ref <<WaitRenderAssetsStreamingCompleted>g__WaitRenderAssetsStreamingCompletedWithoutLog|23_0>d);
			return <<WaitRenderAssetsStreamingCompleted>g__WaitRenderAssetsStreamingCompletedWithoutLog|23_0>d.<>t__builder.Task;
		}

		// Token: 0x06026D82 RID: 159106 RVA: 0x00ADFE34 File Offset: 0x00ADE034
		[CompilerGenerated]
		internal static UniTask <WaitTeamLoaded>g__WaitTeamLoadedWithoutLog|24_0()
		{
			TeleportCore.<<WaitTeamLoaded>g__WaitTeamLoadedWithoutLog|24_0>d <<WaitTeamLoaded>g__WaitTeamLoadedWithoutLog|24_0>d;
			<<WaitTeamLoaded>g__WaitTeamLoadedWithoutLog|24_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<WaitTeamLoaded>g__WaitTeamLoadedWithoutLog|24_0>d.<>1__state = -1;
			<<WaitTeamLoaded>g__WaitTeamLoadedWithoutLog|24_0>d.<>t__builder.Start<TeleportCore.<<WaitTeamLoaded>g__WaitTeamLoadedWithoutLog|24_0>d>(ref <<WaitTeamLoaded>g__WaitTeamLoadedWithoutLog|24_0>d);
			return <<WaitTeamLoaded>g__WaitTeamLoadedWithoutLog|24_0>d.<>t__builder.Task;
		}

		// Token: 0x06026D83 RID: 159107 RVA: 0x00ADFE70 File Offset: 0x00ADE070
		[CompilerGenerated]
		private UniTask <HandleTakeVehicleDuringTeleport>g__HandleTakeVehicleDuringTeleportWithoutLog|25_0()
		{
			TeleportCore.<<HandleTakeVehicleDuringTeleport>g__HandleTakeVehicleDuringTeleportWithoutLog|25_0>d <<HandleTakeVehicleDuringTeleport>g__HandleTakeVehicleDuringTeleportWithoutLog|25_0>d;
			<<HandleTakeVehicleDuringTeleport>g__HandleTakeVehicleDuringTeleportWithoutLog|25_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<HandleTakeVehicleDuringTeleport>g__HandleTakeVehicleDuringTeleportWithoutLog|25_0>d.<>4__this = this;
			<<HandleTakeVehicleDuringTeleport>g__HandleTakeVehicleDuringTeleportWithoutLog|25_0>d.<>1__state = -1;
			<<HandleTakeVehicleDuringTeleport>g__HandleTakeVehicleDuringTeleportWithoutLog|25_0>d.<>t__builder.Start<TeleportCore.<<HandleTakeVehicleDuringTeleport>g__HandleTakeVehicleDuringTeleportWithoutLog|25_0>d>(ref <<HandleTakeVehicleDuringTeleport>g__HandleTakeVehicleDuringTeleportWithoutLog|25_0>d);
			return <<HandleTakeVehicleDuringTeleport>g__HandleTakeVehicleDuringTeleportWithoutLog|25_0>d.<>t__builder.Task;
		}

		// Token: 0x06026D84 RID: 159108 RVA: 0x00ADFEB4 File Offset: 0x00ADE0B4
		[CompilerGenerated]
		private UniTask <WaitRollbackCompleted>g__WaitRollbackCompletedWithoutLog|26_0()
		{
			TeleportCore.<<WaitRollbackCompleted>g__WaitRollbackCompletedWithoutLog|26_0>d <<WaitRollbackCompleted>g__WaitRollbackCompletedWithoutLog|26_0>d;
			<<WaitRollbackCompleted>g__WaitRollbackCompletedWithoutLog|26_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<WaitRollbackCompleted>g__WaitRollbackCompletedWithoutLog|26_0>d.<>4__this = this;
			<<WaitRollbackCompleted>g__WaitRollbackCompletedWithoutLog|26_0>d.<>1__state = -1;
			<<WaitRollbackCompleted>g__WaitRollbackCompletedWithoutLog|26_0>d.<>t__builder.Start<TeleportCore.<<WaitRollbackCompleted>g__WaitRollbackCompletedWithoutLog|26_0>d>(ref <<WaitRollbackCompleted>g__WaitRollbackCompletedWithoutLog|26_0>d);
			return <<WaitRollbackCompleted>g__WaitRollbackCompletedWithoutLog|26_0>d.<>t__builder.Task;
		}

		// Token: 0x06026D86 RID: 159110 RVA: 0x00ADFF0F File Offset: 0x00ADE10F
		[CompilerGenerated]
		internal static void <HandleTimeDilationBeforeTeleport>g__HandleTimeDilationBeforeTeleportWithoutLog|27_0()
		{
			GameModeController.Instance.ForceDisableGamePaused(true);
		}

		// Token: 0x06026D87 RID: 159111 RVA: 0x00ADFF1C File Offset: 0x00ADE11C
		[CompilerGenerated]
		internal static void <HandleTimeDilationAfterTeleport>g__HandleTimeDilationAfterTeleportWithoutLog|28_0()
		{
			GameModeController.Instance.ForceDisableGamePaused(false);
			CommonQteController.Instance.RecoverTimeDilationAfterTeleport();
			QtaController.Instance.RecoverTimeDilationAfterTeleport();
		}

		// Token: 0x040153A3 RID: 86947
		private const int DELAYCLOSETIME = 1500;
	}
}

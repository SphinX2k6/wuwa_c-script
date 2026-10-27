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
	// Token: 0x02004B6A RID: 19306
	[NullableContext(2)]
	[Nullable(0)]
	public class TeleportCore : TeleportContextHolder
	{
		// Token: 0x06031FBF RID: 204735 RVA: 0x00B9A24A File Offset: 0x00B9844A
		[NullableContext(1)]
		public TeleportCore(TeleportContext context) : base(context)
		{
		}

		// Token: 0x06031FC0 RID: 204736 RVA: 0x00B9A254 File Offset: 0x00B98454
		[NullableContext(0)]
		public UniTask<bool> TeleportPlayerNoLoading(bool isInVehicle)
		{
			TeleportCore.<TeleportPlayerNoLoading>d__4 <TeleportPlayerNoLoading>d__;
			<TeleportPlayerNoLoading>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<TeleportPlayerNoLoading>d__.<>4__this = this;
			<TeleportPlayerNoLoading>d__.isInVehicle = isInVehicle;
			<TeleportPlayerNoLoading>d__.<>1__state = -1;
			<TeleportPlayerNoLoading>d__.<>t__builder.Start<TeleportCore.<TeleportPlayerNoLoading>d__4>(ref <TeleportPlayerNoLoading>d__);
			return <TeleportPlayerNoLoading>d__.<>t__builder.Task;
		}

		// Token: 0x06031FC1 RID: 204737 RVA: 0x00B9A2A0 File Offset: 0x00B984A0
		[NullableContext(0)]
		public UniTask<bool> TeleportPlayerWithLoading(bool isInVehicle)
		{
			TeleportCore.<TeleportPlayerWithLoading>d__5 <TeleportPlayerWithLoading>d__;
			<TeleportPlayerWithLoading>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<TeleportPlayerWithLoading>d__.<>4__this = this;
			<TeleportPlayerWithLoading>d__.isInVehicle = isInVehicle;
			<TeleportPlayerWithLoading>d__.<>1__state = -1;
			<TeleportPlayerWithLoading>d__.<>t__builder.Start<TeleportCore.<TeleportPlayerWithLoading>d__5>(ref <TeleportPlayerWithLoading>d__);
			return <TeleportPlayerWithLoading>d__.<>t__builder.Task;
		}

		// Token: 0x06031FC2 RID: 204738 RVA: 0x00B9A2EC File Offset: 0x00B984EC
		[NullableContext(0)]
		public UniTask<bool> TeleportElevatorAndPlayerSeparately()
		{
			TeleportCore.<TeleportElevatorAndPlayerSeparately>d__6 <TeleportElevatorAndPlayerSeparately>d__;
			<TeleportElevatorAndPlayerSeparately>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<TeleportElevatorAndPlayerSeparately>d__.<>4__this = this;
			<TeleportElevatorAndPlayerSeparately>d__.<>1__state = -1;
			<TeleportElevatorAndPlayerSeparately>d__.<>t__builder.Start<TeleportCore.<TeleportElevatorAndPlayerSeparately>d__6>(ref <TeleportElevatorAndPlayerSeparately>d__);
			return <TeleportElevatorAndPlayerSeparately>d__.<>t__builder.Task;
		}

		// Token: 0x06031FC3 RID: 204739 RVA: 0x00B9A32F File Offset: 0x00B9852F
		[NullableContext(1)]
		private void OnChangeRole(EntityHandle newHandle, [Nullable(2)] EntityHandle oldHandle)
		{
			this.OnChangeRole();
		}

		// Token: 0x06031FC4 RID: 204740 RVA: 0x00B9A337 File Offset: 0x00B98537
		private void OnChangeRole()
		{
			this.HandleCharacterTeleportLock(true);
		}

		// Token: 0x06031FC5 RID: 204741 RVA: 0x00B9A340 File Offset: 0x00B98540
		[NullableContext(0)]
		public UniTask<bool> FakeTeleportPlayerWithLoading()
		{
			TeleportCore.<FakeTeleportPlayerWithLoading>d__9 <FakeTeleportPlayerWithLoading>d__;
			<FakeTeleportPlayerWithLoading>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<FakeTeleportPlayerWithLoading>d__.<>4__this = this;
			<FakeTeleportPlayerWithLoading>d__.<>1__state = -1;
			<FakeTeleportPlayerWithLoading>d__.<>t__builder.Start<TeleportCore.<FakeTeleportPlayerWithLoading>d__9>(ref <FakeTeleportPlayerWithLoading>d__);
			return <FakeTeleportPlayerWithLoading>d__.<>t__builder.Task;
		}

		// Token: 0x06031FC6 RID: 204742 RVA: 0x00B9A384 File Offset: 0x00B98584
		private void SetMotionBlurEnabled(bool enable)
		{
			if (enable)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Teleport;
				ELogAuthor author = ELogAuthor.CK;
				string message = "传送: 开启运动模糊";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MotionBlurValue", this.MotionBlurCache);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				UObject world = GlobalData.World;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
				defaultInterpolatedStringHandler.AppendLiteral("r.MotionBlur.Amount ");
				defaultInterpolatedStringHandler.AppendFormatted<float>(this.MotionBlurCache);
				UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
				return;
			}
			this.MotionBlurCache = UKismetSystemLibrary.GetConsoleVariableFloatValue("r.MotionBlur.Amount");
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Teleport;
			ELogAuthor author2 = ELogAuthor.CK;
			string message2 = "传送: 关闭运动模糊";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("MotionBlurValue", this.MotionBlurCache);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.InvalidSeveralFrameOcculusion 30", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.MotionBlur.Amount 0", null);
		}

		// Token: 0x06031FC7 RID: 204743 RVA: 0x00B9A464 File Offset: 0x00B98664
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

		// Token: 0x06031FC8 RID: 204744 RVA: 0x00B9A690 File Offset: 0x00B98890
		private UniTask HandleStreamingLogic(bool shouldCollectGarbage)
		{
			TeleportCore.<HandleStreamingLogic>d__12 <HandleStreamingLogic>d__;
			<HandleStreamingLogic>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HandleStreamingLogic>d__.<>4__this = this;
			<HandleStreamingLogic>d__.shouldCollectGarbage = shouldCollectGarbage;
			<HandleStreamingLogic>d__.<>1__state = -1;
			<HandleStreamingLogic>d__.<>t__builder.Start<TeleportCore.<HandleStreamingLogic>d__12>(ref <HandleStreamingLogic>d__);
			return <HandleStreamingLogic>d__.<>t__builder.Task;
		}

		// Token: 0x06031FC9 RID: 204745 RVA: 0x00B9A6DC File Offset: 0x00B988DC
		private void EmitTeleportStartEvent(Entity entity)
		{
			Log.Instance.Info(ELogModule.Teleport, ELogAuthor.CK, "传送: 发送传送开始事件 开始执行 EmitTeleportStartEvent", default(ReadOnlySpan<ValueTuple<string, object>>));
			try
			{
				TeleportCore.<EmitTeleportStartEvent>g__EmitTeleportStartEventWithoutLog|13_0(entity);
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

		// Token: 0x06031FCA RID: 204746 RVA: 0x00B9A774 File Offset: 0x00B98974
		private void EmitTeleportOpenLoadingEndEvent(Entity entity)
		{
			Log.Instance.Info(ELogModule.Teleport, ELogAuthor.CK, "传送: 发送Loading打开完成事件 开始执行 EmitTeleportOpenLoadingEndEvent", default(ReadOnlySpan<ValueTuple<string, object>>));
			try
			{
				TeleportCore.<EmitTeleportOpenLoadingEndEvent>g__EmitTeleportOpenLoadingEndEventWithoutLog|14_0(entity);
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

		// Token: 0x06031FCB RID: 204747 RVA: 0x00B9A80C File Offset: 0x00B98A0C
		private void EmitFixBornLocationEvent()
		{
			Log.Instance.Info(ELogModule.Teleport, ELogAuthor.CK, "传送: 发送修正出生位置事件 开始执行 EmitFixBornLocationEvent", default(ReadOnlySpan<ValueTuple<string, object>>));
			try
			{
				TeleportCore.<EmitFixBornLocationEvent>g__EmitFixBornLocationEventWithoutLog|15_0();
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

		// Token: 0x06031FCC RID: 204748 RVA: 0x00B9A8A0 File Offset: 0x00B98AA0
		private void EmitTeleportCompleteEvent()
		{
			Log.Instance.Info(ELogModule.Teleport, ELogAuthor.CK, "传送: 发送传送完成事件 开始执行 EmitTeleportCompleteEvent", default(ReadOnlySpan<ValueTuple<string, object>>));
			try
			{
				this.<EmitTeleportCompleteEvent>g__EmitTeleportCompleteEventWithoutLog|16_0();
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

		// Token: 0x06031FCD RID: 204749 RVA: 0x00B9A938 File Offset: 0x00B98B38
		private void EmitTeleportChangeLocationEvent(Entity entity)
		{
			Log.Instance.Info(ELogModule.Teleport, ELogAuthor.CK, "传送: 发送传送位置变更事件 开始执行 EmitTeleportChangeLocationEvent", default(ReadOnlySpan<ValueTuple<string, object>>));
			try
			{
				TeleportCore.<EmitTeleportChangeLocationEvent>g__EmitTeleportChangeLocationEventWithoutLog|17_0(entity);
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

		// Token: 0x06031FCE RID: 204750 RVA: 0x00B9A9D0 File Offset: 0x00B98BD0
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

		// Token: 0x06031FCF RID: 204751 RVA: 0x00B9AA90 File Offset: 0x00B98C90
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

		// Token: 0x06031FD0 RID: 204752 RVA: 0x00B9AE00 File Offset: 0x00B99000
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

		// Token: 0x06031FD1 RID: 204753 RVA: 0x00B9B06C File Offset: 0x00B9926C
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

		// Token: 0x06031FD2 RID: 204754 RVA: 0x00B9B0E8 File Offset: 0x00B992E8
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

		// Token: 0x06031FD3 RID: 204755 RVA: 0x00B9B3E8 File Offset: 0x00B995E8
		private void HandleVehicleCameraTransform()
		{
			CameraController.Instance.MainModel.FightCamera.LogicComponent.SetRotation(TeleportModel.Instance.TargetRotation.ToUeRotator());
			CameraController.Instance.MainModel.FightCamera.LogicComponent.ResetFightCameraLogic(this.TeleportContext.NeedRestoreCamera.GetValueOrDefault(), false);
		}

		// Token: 0x06031FD4 RID: 204756 RVA: 0x00B9B44C File Offset: 0x00B9964C
		private void HandleCharacterTeleportLock(bool freezeMove)
		{
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			EntityHandle frozenEntityHandle = this.FrozenEntityHandle;
			if (frozenEntityHandle != null && frozenEntityHandle.Valid)
			{
				int id = this.FrozenEntityHandle.Id;
				int? num = (getCurrentEntity != null) ? new int?(getCurrentEntity.Id) : null;
				if (!(id == num.GetValueOrDefault() & num != null))
				{
					WorldEntity entity = this.FrozenEntityHandle.Entity;
					UeMovementTickManageComponent ueMovementTickManageComponent = (entity != null) ? entity.GetComponent<UeMovementTickManageComponent>() : null;
					if (ueMovementTickManageComponent != null)
					{
						ueMovementTickManageComponent.TeleportLock = false;
					}
				}
			}
			this.FrozenEntityHandle = null;
			if (getCurrentEntity != null && getCurrentEntity.Valid)
			{
				WorldEntity entity2 = getCurrentEntity.Entity;
				UeMovementTickManageComponent ueMovementTickManageComponent2 = (entity2 != null) ? entity2.GetComponent<UeMovementTickManageComponent>() : null;
				if (ueMovementTickManageComponent2 != null)
				{
					ueMovementTickManageComponent2.TeleportLock = freezeMove;
				}
				this.FrozenEntityHandle = (freezeMove ? getCurrentEntity : null);
			}
		}

		// Token: 0x06031FD5 RID: 204757 RVA: 0x00B9B514 File Offset: 0x00B99714
		private UniTask CheckLiveLocationStreamingCompleted()
		{
			TeleportCore.<CheckLiveLocationStreamingCompleted>d__25 <CheckLiveLocationStreamingCompleted>d__;
			<CheckLiveLocationStreamingCompleted>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CheckLiveLocationStreamingCompleted>d__.<>4__this = this;
			<CheckLiveLocationStreamingCompleted>d__.<>1__state = -1;
			<CheckLiveLocationStreamingCompleted>d__.<>t__builder.Start<TeleportCore.<CheckLiveLocationStreamingCompleted>d__25>(ref <CheckLiveLocationStreamingCompleted>d__);
			return <CheckLiveLocationStreamingCompleted>d__.<>t__builder.Task;
		}

		// Token: 0x06031FD6 RID: 204758 RVA: 0x00B9B558 File Offset: 0x00B99758
		private UniTask WaitServerResponse()
		{
			TeleportCore.<WaitServerResponse>d__26 <WaitServerResponse>d__;
			<WaitServerResponse>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitServerResponse>d__.<>4__this = this;
			<WaitServerResponse>d__.<>1__state = -1;
			<WaitServerResponse>d__.<>t__builder.Start<TeleportCore.<WaitServerResponse>d__26>(ref <WaitServerResponse>d__);
			return <WaitServerResponse>d__.<>t__builder.Task;
		}

		// Token: 0x06031FD7 RID: 204759 RVA: 0x00B9B59B File Offset: 0x00B9979B
		private void CreateEntityFromPending()
		{
			GameModeModel.Instance.LoadingPhase = ELoadingPhase.CreateEntityStart;
			CreatureController.Instance.CreateEntityFromPending(EAddEntityType.Normal);
			GameModeModel.Instance.LoadingPhase = ELoadingPhase.CreateEntityEnd;
		}

		// Token: 0x06031FD8 RID: 204760 RVA: 0x00B9B5C0 File Offset: 0x00B997C0
		private UniTask PreAwakeEntitiesFromPending()
		{
			TeleportCore.<PreAwakeEntitiesFromPending>d__28 <PreAwakeEntitiesFromPending>d__;
			<PreAwakeEntitiesFromPending>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreAwakeEntitiesFromPending>d__.<>1__state = -1;
			<PreAwakeEntitiesFromPending>d__.<>t__builder.Start<TeleportCore.<PreAwakeEntitiesFromPending>d__28>(ref <PreAwakeEntitiesFromPending>d__);
			return <PreAwakeEntitiesFromPending>d__.<>t__builder.Task;
		}

		// Token: 0x06031FD9 RID: 204761 RVA: 0x00B9B5FC File Offset: 0x00B997FC
		private UniTask WaitRenderAssetsStreamingCompleted()
		{
			TeleportCore.<WaitRenderAssetsStreamingCompleted>d__29 <WaitRenderAssetsStreamingCompleted>d__;
			<WaitRenderAssetsStreamingCompleted>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitRenderAssetsStreamingCompleted>d__.<>4__this = this;
			<WaitRenderAssetsStreamingCompleted>d__.<>1__state = -1;
			<WaitRenderAssetsStreamingCompleted>d__.<>t__builder.Start<TeleportCore.<WaitRenderAssetsStreamingCompleted>d__29>(ref <WaitRenderAssetsStreamingCompleted>d__);
			return <WaitRenderAssetsStreamingCompleted>d__.<>t__builder.Task;
		}

		// Token: 0x06031FDA RID: 204762 RVA: 0x00B9B640 File Offset: 0x00B99840
		private UniTask WaitTeamLoaded()
		{
			TeleportCore.<WaitTeamLoaded>d__30 <WaitTeamLoaded>d__;
			<WaitTeamLoaded>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitTeamLoaded>d__.<>1__state = -1;
			<WaitTeamLoaded>d__.<>t__builder.Start<TeleportCore.<WaitTeamLoaded>d__30>(ref <WaitTeamLoaded>d__);
			return <WaitTeamLoaded>d__.<>t__builder.Task;
		}

		// Token: 0x06031FDB RID: 204763 RVA: 0x00B9B67C File Offset: 0x00B9987C
		private UniTask HandleTakeVehicleDuringTeleport()
		{
			TeleportCore.<HandleTakeVehicleDuringTeleport>d__31 <HandleTakeVehicleDuringTeleport>d__;
			<HandleTakeVehicleDuringTeleport>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HandleTakeVehicleDuringTeleport>d__.<>4__this = this;
			<HandleTakeVehicleDuringTeleport>d__.<>1__state = -1;
			<HandleTakeVehicleDuringTeleport>d__.<>t__builder.Start<TeleportCore.<HandleTakeVehicleDuringTeleport>d__31>(ref <HandleTakeVehicleDuringTeleport>d__);
			return <HandleTakeVehicleDuringTeleport>d__.<>t__builder.Task;
		}

		// Token: 0x06031FDC RID: 204764 RVA: 0x00B9B6C0 File Offset: 0x00B998C0
		private UniTask WaitRollbackCompleted()
		{
			TeleportCore.<WaitRollbackCompleted>d__32 <WaitRollbackCompleted>d__;
			<WaitRollbackCompleted>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitRollbackCompleted>d__.<>4__this = this;
			<WaitRollbackCompleted>d__.<>1__state = -1;
			<WaitRollbackCompleted>d__.<>t__builder.Start<TeleportCore.<WaitRollbackCompleted>d__32>(ref <WaitRollbackCompleted>d__);
			return <WaitRollbackCompleted>d__.<>t__builder.Task;
		}

		// Token: 0x06031FDD RID: 204765 RVA: 0x00B9B704 File Offset: 0x00B99904
		private void HandleTimeDilationBeforeTeleport()
		{
			Log.Instance.Info(ELogModule.Teleport, ELogAuthor.CK, "传送: 传送前解除时停 开始执行 HandleTimeDilationBeforeTeleport", default(ReadOnlySpan<ValueTuple<string, object>>));
			try
			{
				TeleportCore.<HandleTimeDilationBeforeTeleport>g__HandleTimeDilationBeforeTeleportWithoutLog|33_0();
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

		// Token: 0x06031FDE RID: 204766 RVA: 0x00B9B798 File Offset: 0x00B99998
		private void HandleTimeDilationAfterTeleport()
		{
			Log.Instance.Info(ELogModule.Teleport, ELogAuthor.CK, "传送: 传送后恢复时停 开始执行 HandleTimeDilationAfterTeleport", default(ReadOnlySpan<ValueTuple<string, object>>));
			try
			{
				TeleportCore.<HandleTimeDilationAfterTeleport>g__HandleTimeDilationAfterTeleportWithoutLog|34_0();
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

		// Token: 0x06031FDF RID: 204767 RVA: 0x00B9B82C File Offset: 0x00B99A2C
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

		// Token: 0x06031FE0 RID: 204768 RVA: 0x00B9B8F0 File Offset: 0x00B99AF0
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

		// Token: 0x06031FE1 RID: 204769 RVA: 0x00B9B974 File Offset: 0x00B99B74
		[NullableContext(0)]
		[CompilerGenerated]
		private UniTask<bool> <FakeTeleportPlayerWithLoading>g__FakeTeleportPlayerWithLoadingWithoutLog|9_0()
		{
			TeleportCore.<<FakeTeleportPlayerWithLoading>g__FakeTeleportPlayerWithLoadingWithoutLog|9_0>d <<FakeTeleportPlayerWithLoading>g__FakeTeleportPlayerWithLoadingWithoutLog|9_0>d;
			<<FakeTeleportPlayerWithLoading>g__FakeTeleportPlayerWithLoadingWithoutLog|9_0>d.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<<FakeTeleportPlayerWithLoading>g__FakeTeleportPlayerWithLoadingWithoutLog|9_0>d.<>4__this = this;
			<<FakeTeleportPlayerWithLoading>g__FakeTeleportPlayerWithLoadingWithoutLog|9_0>d.<>1__state = -1;
			<<FakeTeleportPlayerWithLoading>g__FakeTeleportPlayerWithLoadingWithoutLog|9_0>d.<>t__builder.Start<TeleportCore.<<FakeTeleportPlayerWithLoading>g__FakeTeleportPlayerWithLoadingWithoutLog|9_0>d>(ref <<FakeTeleportPlayerWithLoading>g__FakeTeleportPlayerWithLoadingWithoutLog|9_0>d);
			return <<FakeTeleportPlayerWithLoading>g__FakeTeleportPlayerWithLoadingWithoutLog|9_0>d.<>t__builder.Task;
		}

		// Token: 0x06031FE2 RID: 204770 RVA: 0x00B9B9B7 File Offset: 0x00B99BB7
		[CompilerGenerated]
		internal static void <EmitTeleportStartEvent>g__EmitTeleportStartEventWithoutLog|13_0(Entity entity)
		{
			EventSystem.Instance.Emit<bool>(EEventName.TeleportStart, true);
			if (entity != null)
			{
				EventSystem.Instance.EmitWithTarget<bool>(entity, EEventName.TeleportStartEntity, true);
			}
		}

		// Token: 0x06031FE3 RID: 204771 RVA: 0x00B9B9DF File Offset: 0x00B99BDF
		[CompilerGenerated]
		internal static void <EmitTeleportOpenLoadingEndEvent>g__EmitTeleportOpenLoadingEndEventWithoutLog|14_0(Entity entity)
		{
			EventSystem.Instance.Emit(EEventName.TeleportOpenLoadingEnd);
			if (entity != null)
			{
				EventSystem.Instance.EmitWithTarget(entity, EEventName.TeleportOpenLoadingEnd);
			}
		}

		// Token: 0x06031FE4 RID: 204772 RVA: 0x00B9BA05 File Offset: 0x00B99C05
		[CompilerGenerated]
		internal static void <EmitFixBornLocationEvent>g__EmitFixBornLocationEventWithoutLog|15_0()
		{
			EventSystem.Instance.Emit(EEventName.FixBornLocation);
		}

		// Token: 0x06031FE5 RID: 204773 RVA: 0x00B9BA17 File Offset: 0x00B99C17
		[CompilerGenerated]
		private void <EmitTeleportCompleteEvent>g__EmitTeleportCompleteEventWithoutLog|16_0()
		{
			EventSystem.Instance.Emit<TeleportContext>(EEventName.TeleportComplete, this.TeleportContext);
		}

		// Token: 0x06031FE6 RID: 204774 RVA: 0x00B9BA2F File Offset: 0x00B99C2F
		[CompilerGenerated]
		internal static void <EmitTeleportChangeLocationEvent>g__EmitTeleportChangeLocationEventWithoutLog|17_0(Entity entity)
		{
			if (entity != null)
			{
				EventSystem.Instance.EmitWithTarget(entity, EEventName.TeleportChangeLocation);
			}
		}

		// Token: 0x06031FE7 RID: 204775 RVA: 0x00B9BA48 File Offset: 0x00B99C48
		[CompilerGenerated]
		private UniTask <CheckLiveLocationStreamingCompleted>g__CheckLiveLocationStreamingCompletedWithoutLog|25_0()
		{
			TeleportCore.<<CheckLiveLocationStreamingCompleted>g__CheckLiveLocationStreamingCompletedWithoutLog|25_0>d <<CheckLiveLocationStreamingCompleted>g__CheckLiveLocationStreamingCompletedWithoutLog|25_0>d;
			<<CheckLiveLocationStreamingCompleted>g__CheckLiveLocationStreamingCompletedWithoutLog|25_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<CheckLiveLocationStreamingCompleted>g__CheckLiveLocationStreamingCompletedWithoutLog|25_0>d.<>4__this = this;
			<<CheckLiveLocationStreamingCompleted>g__CheckLiveLocationStreamingCompletedWithoutLog|25_0>d.<>1__state = -1;
			<<CheckLiveLocationStreamingCompleted>g__CheckLiveLocationStreamingCompletedWithoutLog|25_0>d.<>t__builder.Start<TeleportCore.<<CheckLiveLocationStreamingCompleted>g__CheckLiveLocationStreamingCompletedWithoutLog|25_0>d>(ref <<CheckLiveLocationStreamingCompleted>g__CheckLiveLocationStreamingCompletedWithoutLog|25_0>d);
			return <<CheckLiveLocationStreamingCompleted>g__CheckLiveLocationStreamingCompletedWithoutLog|25_0>d.<>t__builder.Task;
		}

		// Token: 0x06031FE8 RID: 204776 RVA: 0x00B9BA8C File Offset: 0x00B99C8C
		[CompilerGenerated]
		private UniTask <WaitServerResponse>g__WaitServerResponseWithoutLog|26_0()
		{
			TeleportCore.<<WaitServerResponse>g__WaitServerResponseWithoutLog|26_0>d <<WaitServerResponse>g__WaitServerResponseWithoutLog|26_0>d;
			<<WaitServerResponse>g__WaitServerResponseWithoutLog|26_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<WaitServerResponse>g__WaitServerResponseWithoutLog|26_0>d.<>4__this = this;
			<<WaitServerResponse>g__WaitServerResponseWithoutLog|26_0>d.<>1__state = -1;
			<<WaitServerResponse>g__WaitServerResponseWithoutLog|26_0>d.<>t__builder.Start<TeleportCore.<<WaitServerResponse>g__WaitServerResponseWithoutLog|26_0>d>(ref <<WaitServerResponse>g__WaitServerResponseWithoutLog|26_0>d);
			return <<WaitServerResponse>g__WaitServerResponseWithoutLog|26_0>d.<>t__builder.Task;
		}

		// Token: 0x06031FEA RID: 204778 RVA: 0x00B9BAE4 File Offset: 0x00B99CE4
		[CompilerGenerated]
		internal static UniTask <PreAwakeEntitiesFromPending>g__PreAwakeEntitiesFromPendingWithoutLog|28_0()
		{
			TeleportCore.<<PreAwakeEntitiesFromPending>g__PreAwakeEntitiesFromPendingWithoutLog|28_0>d <<PreAwakeEntitiesFromPending>g__PreAwakeEntitiesFromPendingWithoutLog|28_0>d;
			<<PreAwakeEntitiesFromPending>g__PreAwakeEntitiesFromPendingWithoutLog|28_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<PreAwakeEntitiesFromPending>g__PreAwakeEntitiesFromPendingWithoutLog|28_0>d.<>1__state = -1;
			<<PreAwakeEntitiesFromPending>g__PreAwakeEntitiesFromPendingWithoutLog|28_0>d.<>t__builder.Start<TeleportCore.<<PreAwakeEntitiesFromPending>g__PreAwakeEntitiesFromPendingWithoutLog|28_0>d>(ref <<PreAwakeEntitiesFromPending>g__PreAwakeEntitiesFromPendingWithoutLog|28_0>d);
			return <<PreAwakeEntitiesFromPending>g__PreAwakeEntitiesFromPendingWithoutLog|28_0>d.<>t__builder.Task;
		}

		// Token: 0x06031FEB RID: 204779 RVA: 0x00B9BB20 File Offset: 0x00B99D20
		[CompilerGenerated]
		private UniTask <WaitRenderAssetsStreamingCompleted>g__WaitRenderAssetsStreamingCompletedWithoutLog|29_0()
		{
			TeleportCore.<<WaitRenderAssetsStreamingCompleted>g__WaitRenderAssetsStreamingCompletedWithoutLog|29_0>d <<WaitRenderAssetsStreamingCompleted>g__WaitRenderAssetsStreamingCompletedWithoutLog|29_0>d;
			<<WaitRenderAssetsStreamingCompleted>g__WaitRenderAssetsStreamingCompletedWithoutLog|29_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<WaitRenderAssetsStreamingCompleted>g__WaitRenderAssetsStreamingCompletedWithoutLog|29_0>d.<>4__this = this;
			<<WaitRenderAssetsStreamingCompleted>g__WaitRenderAssetsStreamingCompletedWithoutLog|29_0>d.<>1__state = -1;
			<<WaitRenderAssetsStreamingCompleted>g__WaitRenderAssetsStreamingCompletedWithoutLog|29_0>d.<>t__builder.Start<TeleportCore.<<WaitRenderAssetsStreamingCompleted>g__WaitRenderAssetsStreamingCompletedWithoutLog|29_0>d>(ref <<WaitRenderAssetsStreamingCompleted>g__WaitRenderAssetsStreamingCompletedWithoutLog|29_0>d);
			return <<WaitRenderAssetsStreamingCompleted>g__WaitRenderAssetsStreamingCompletedWithoutLog|29_0>d.<>t__builder.Task;
		}

		// Token: 0x06031FEC RID: 204780 RVA: 0x00B9BB64 File Offset: 0x00B99D64
		[CompilerGenerated]
		internal static UniTask <WaitTeamLoaded>g__WaitTeamLoadedWithoutLog|30_0()
		{
			TeleportCore.<<WaitTeamLoaded>g__WaitTeamLoadedWithoutLog|30_0>d <<WaitTeamLoaded>g__WaitTeamLoadedWithoutLog|30_0>d;
			<<WaitTeamLoaded>g__WaitTeamLoadedWithoutLog|30_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<WaitTeamLoaded>g__WaitTeamLoadedWithoutLog|30_0>d.<>1__state = -1;
			<<WaitTeamLoaded>g__WaitTeamLoadedWithoutLog|30_0>d.<>t__builder.Start<TeleportCore.<<WaitTeamLoaded>g__WaitTeamLoadedWithoutLog|30_0>d>(ref <<WaitTeamLoaded>g__WaitTeamLoadedWithoutLog|30_0>d);
			return <<WaitTeamLoaded>g__WaitTeamLoadedWithoutLog|30_0>d.<>t__builder.Task;
		}

		// Token: 0x06031FED RID: 204781 RVA: 0x00B9BBA0 File Offset: 0x00B99DA0
		[CompilerGenerated]
		private UniTask <HandleTakeVehicleDuringTeleport>g__HandleTakeVehicleDuringTeleportWithoutLog|31_0()
		{
			TeleportCore.<<HandleTakeVehicleDuringTeleport>g__HandleTakeVehicleDuringTeleportWithoutLog|31_0>d <<HandleTakeVehicleDuringTeleport>g__HandleTakeVehicleDuringTeleportWithoutLog|31_0>d;
			<<HandleTakeVehicleDuringTeleport>g__HandleTakeVehicleDuringTeleportWithoutLog|31_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<HandleTakeVehicleDuringTeleport>g__HandleTakeVehicleDuringTeleportWithoutLog|31_0>d.<>4__this = this;
			<<HandleTakeVehicleDuringTeleport>g__HandleTakeVehicleDuringTeleportWithoutLog|31_0>d.<>1__state = -1;
			<<HandleTakeVehicleDuringTeleport>g__HandleTakeVehicleDuringTeleportWithoutLog|31_0>d.<>t__builder.Start<TeleportCore.<<HandleTakeVehicleDuringTeleport>g__HandleTakeVehicleDuringTeleportWithoutLog|31_0>d>(ref <<HandleTakeVehicleDuringTeleport>g__HandleTakeVehicleDuringTeleportWithoutLog|31_0>d);
			return <<HandleTakeVehicleDuringTeleport>g__HandleTakeVehicleDuringTeleportWithoutLog|31_0>d.<>t__builder.Task;
		}

		// Token: 0x06031FEE RID: 204782 RVA: 0x00B9BBE4 File Offset: 0x00B99DE4
		[CompilerGenerated]
		private UniTask <WaitRollbackCompleted>g__WaitRollbackCompletedWithoutLog|32_0()
		{
			TeleportCore.<<WaitRollbackCompleted>g__WaitRollbackCompletedWithoutLog|32_0>d <<WaitRollbackCompleted>g__WaitRollbackCompletedWithoutLog|32_0>d;
			<<WaitRollbackCompleted>g__WaitRollbackCompletedWithoutLog|32_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<WaitRollbackCompleted>g__WaitRollbackCompletedWithoutLog|32_0>d.<>4__this = this;
			<<WaitRollbackCompleted>g__WaitRollbackCompletedWithoutLog|32_0>d.<>1__state = -1;
			<<WaitRollbackCompleted>g__WaitRollbackCompletedWithoutLog|32_0>d.<>t__builder.Start<TeleportCore.<<WaitRollbackCompleted>g__WaitRollbackCompletedWithoutLog|32_0>d>(ref <<WaitRollbackCompleted>g__WaitRollbackCompletedWithoutLog|32_0>d);
			return <<WaitRollbackCompleted>g__WaitRollbackCompletedWithoutLog|32_0>d.<>t__builder.Task;
		}

		// Token: 0x06031FF0 RID: 204784 RVA: 0x00B9BC3F File Offset: 0x00B99E3F
		[CompilerGenerated]
		internal static void <HandleTimeDilationBeforeTeleport>g__HandleTimeDilationBeforeTeleportWithoutLog|33_0()
		{
			GameModeController.Instance.ForceDisableGamePaused(true);
		}

		// Token: 0x06031FF1 RID: 204785 RVA: 0x00B9BC4C File Offset: 0x00B99E4C
		[CompilerGenerated]
		internal static void <HandleTimeDilationAfterTeleport>g__HandleTimeDilationAfterTeleportWithoutLog|34_0()
		{
			GameModeController.Instance.ForceDisableGamePaused(false);
			CommonQteController.Instance.RecoverTimeDilationAfterTeleport();
			QtaController.Instance.RecoverTimeDilationAfterTeleport();
		}

		// Token: 0x0401AA4B RID: 109131
		private const int DELAYCLOSETIME = 1500;

		// Token: 0x0401AA4C RID: 109132
		private float MotionBlurCache;

		// Token: 0x0401AA4D RID: 109133
		private EntityHandle FrozenEntityHandle;
	}
}

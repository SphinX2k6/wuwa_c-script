using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000133 RID: 307
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateEnterVehicleFixOffset.TsAnimNotifyStateEnterVehicleFixOffset_C")]
public class TsAnimNotifyStateEnterVehicleFixOffset : TsAnimNotifyStateBase, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x060012D4 RID: 4820 RVA: 0x00069BFC File Offset: 0x00067DFC
	static TsAnimNotifyStateEnterVehicleFixOffset()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsAnimNotifyStateEnterVehicleFixOffset.CreateStaticDefaultValue), new Action(TsAnimNotifyStateEnterVehicleFixOffset.ResetStaticDefaultValue));
	}

	// Token: 0x060012D5 RID: 4821 RVA: 0x00069CB6 File Offset: 0x00067EB6
	public static void CreateStaticDefaultValue()
	{
		TsAnimNotifyStateEnterVehicleFixOffset.IsInit = false;
		TsAnimNotifyStateEnterVehicleFixOffset.CachedMap = new Dictionary<AActor, FixOffsetParams>();
	}

	// Token: 0x060012D6 RID: 4822 RVA: 0x00069CC8 File Offset: 0x00067EC8
	public static void ResetStaticDefaultValue()
	{
		TsAnimNotifyStateEnterVehicleFixOffset.IsInit = false;
		TsAnimNotifyStateEnterVehicleFixOffset.CachedMap = null;
	}

	// Token: 0x060012D7 RID: 4823 RVA: 0x00069CD8 File Offset: 0x00067ED8
	[UFunction(EFunctionFlags.FUNC_None)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor aactor = (meshComp != null) ? meshComp.GetOwner() : null;
		if (!(aactor is TsBaseCharacter))
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = (aactor as TsBaseCharacter).CharacterActorComponent;
		if (characterActorComponent == null || !characterActorComponent.Valid)
		{
			return false;
		}
		Entity entity = characterActorComponent.Entity;
		CommonNpcPerformComponent.EEnterVehicleDirection? enterVehicleDirection = NpcVehicleRiderController.Instance.GetEnterVehicleDirection(entity.Id);
		if (enterVehicleDirection == null)
		{
			return false;
		}
		CommonNpcPerformComponent component = entity.GetComponent<CommonNpcPerformComponent>();
		CommonNpcPerformComponent.EnterVehiclePerformMontage enterVehiclePerformMontage = (component != null) ? component.EnterVehiclePerformMap.GetValueOrDefault(enterVehicleDirection.Value) : null;
		if (enterVehiclePerformMontage == null)
		{
			return false;
		}
		CharacterDriveVehicleComponent component2 = entity.GetComponent<CharacterDriveVehicleComponent>();
		CharacterActorComponent characterActorComponent2;
		if (component2 == null)
		{
			characterActorComponent2 = null;
		}
		else
		{
			Entity vehicleEntity = component2.VehicleEntity;
			characterActorComponent2 = ((vehicleEntity != null) ? vehicleEntity.GetComponent<CharacterActorComponent>() : null);
		}
		CharacterActorComponent characterActorComponent3 = characterActorComponent2;
		if (characterActorComponent3 == null || !characterActorComponent3.Valid)
		{
			return false;
		}
		TsAnimNotifyStateEnterVehicleFixOffset.Initialize();
		Quat actorQuatProxy = characterActorComponent3.ActorQuatProxy;
		Vector tmpVector = TsAnimNotifyStateEnterVehicleFixOffset.TmpVector2;
		Vector vector = tmpVector;
		FVectorDouble socketLocation = characterActorComponent3.GetSocketLocation(CharacterNameDefines.Instance.ROOT);
		vector.FromUeVector(socketLocation);
		Vector tmpVector2 = TsAnimNotifyStateEnterVehicleFixOffset.TmpVector1;
		actorQuatProxy.RotateVector(enterVehiclePerformMontage.Offset, tmpVector2);
		tmpVector2.AdditionEqual(tmpVector);
		Quat inQ = enterVehiclePerformMontage.IdealRotationOffset.Quaternion(TsAnimNotifyStateEnterVehicleFixOffset.TmpQuat1);
		Quat tmpQuat = TsAnimNotifyStateEnterVehicleFixOffset.TmpQuat2;
		actorQuatProxy.Multiply(inQ, tmpQuat);
		FixOffsetParams fixOffsetParams = new FixOffsetParams();
		fixOffsetParams.TotalDuration = totalDuration;
		float currentTimeLength = base.GetCurrentTimeLength();
		EnterVehicleStartTransform enterVehicleStartTransform = NpcVehicleRiderController.Instance.GetEnterVehicleStartTransform(entity.Id);
		Vector tmpVector3 = TsAnimNotifyStateEnterVehicleFixOffset.TmpVector3;
		if (enterVehicleStartTransform != null)
		{
			tmpVector3.DeepCopy(enterVehicleStartTransform.RootPos);
		}
		else
		{
			Vector vector2 = tmpVector3;
			socketLocation = characterActorComponent.GetSocketLocation(CharacterNameDefines.Instance.ROOT);
			vector2.FromUeVector(socketLocation);
		}
		tmpVector2.Subtraction(tmpVector3, fixOffsetParams.DeltaPos);
		float yaw = tmpQuat.Rotator(TsAnimNotifyStateEnterVehicleFixOffset.TmpRotator1).Yaw;
		float num = (enterVehicleStartTransform != null) ? enterVehicleStartTransform.Yaw : characterActorComponent.ActorRotationProxy.Yaw;
		fixOffsetParams.DeltaYaw = MathUtils.Instance.WrapAngle(yaw - num);
		CharacterAnimationComponent component3 = entity.GetComponent<CharacterAnimationComponent>();
		UAnimInstance uanimInstance = (component3 != null) ? component3.MainAnimInstance : null;
		if (uanimInstance != null)
		{
			float endDelta = totalDuration - currentTimeLength;
			TsAnimNotifyStateEnterVehicleFixOffset.InitChannel(fixOffsetParams.ChX, uanimInstance, CharacterNameDefines.Instance.ROOT_X, endDelta, (float)fixOffsetParams.DeltaPos.X);
			TsAnimNotifyStateEnterVehicleFixOffset.InitChannel(fixOffsetParams.ChY, uanimInstance, CharacterNameDefines.Instance.ROOT_Y, endDelta, (float)fixOffsetParams.DeltaPos.Y);
			TsAnimNotifyStateEnterVehicleFixOffset.InitChannel(fixOffsetParams.ChZ, uanimInstance, CharacterNameDefines.Instance.ROOT_Z, endDelta, (float)fixOffsetParams.DeltaPos.Z);
			TsAnimNotifyStateEnterVehicleFixOffset.InitChannel(fixOffsetParams.ChLook, uanimInstance, CharacterNameDefines.Instance.ROOT_LOOK, endDelta, fixOffsetParams.DeltaYaw);
		}
		TsAnimNotifyStateEnterVehicleFixOffset.CachedMap.Add(aactor, fixOffsetParams);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.NPC;
		ELogAuthor author = ELogAuthor.LJM;
		string message = "[EnterVehicleFixOffset] Begin";
		<>y__InlineArray8<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray8<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", entity.Id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Direction", enterVehicleDirection);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("TotalDuration", TsAnimNotifyStateEnterVehicleFixOffset.FmtNum((double)totalDuration));
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("载具Pos", TsAnimNotifyStateEnterVehicleFixOffset.FmtVec(tmpVector));
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("载具Rot", TsAnimNotifyStateEnterVehicleFixOffset.FmtRot(characterActorComponent3.ActorRotationProxy));
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("配置Offset", TsAnimNotifyStateEnterVehicleFixOffset.FmtVec(enterVehiclePerformMontage.Offset));
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("配置IdealRot", TsAnimNotifyStateEnterVehicleFixOffset.FmtRot(enterVehiclePerformMontage.IdealRotationOffset));
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 7) = new ValueTuple<string, object>("理想起点Pos", TsAnimNotifyStateEnterVehicleFixOffset.FmtVec(tmpVector2));
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 8));
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.NPC;
		ELogAuthor author2 = ELogAuthor.LJM;
		string message2 = "[EnterVehicleFixOffset] Begin";
		<>y__InlineArray13<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray13<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray13<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("EntityId", entity.Id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray13<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("运行时Pos", TsAnimNotifyStateEnterVehicleFixOffset.FmtVec(characterActorComponent.ActorLocationProxy));
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray13<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("基线RootPos", TsAnimNotifyStateEnterVehicleFixOffset.FmtVec(tmpVector3));
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray13<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("用缓存", (enterVehicleStartTransform != null) ? 1 : 0);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray13<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 4) = new ValueTuple<string, object>("startTime", TsAnimNotifyStateEnterVehicleFixOffset.FmtNum((double)currentTimeLength));
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray13<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 5) = new ValueTuple<string, object>("载具RootPos", TsAnimNotifyStateEnterVehicleFixOffset.FmtVec(tmpVector));
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray13<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 6) = new ValueTuple<string, object>("运行时Rot", TsAnimNotifyStateEnterVehicleFixOffset.FmtRot(characterActorComponent.ActorRotationProxy));
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray13<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 7) = new ValueTuple<string, object>("位置偏差DeltaPos", TsAnimNotifyStateEnterVehicleFixOffset.FmtVec(fixOffsetParams.DeltaPos));
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray13<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 8) = new ValueTuple<string, object>("旋转偏差DeltaYaw", TsAnimNotifyStateEnterVehicleFixOffset.FmtNum((double)fixOffsetParams.DeltaYaw));
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray13<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 9) = new ValueTuple<string, object>("通道X.Range", TsAnimNotifyStateEnterVehicleFixOffset.FmtNum((double)fixOffsetParams.ChX.Range));
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray13<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 10) = new ValueTuple<string, object>("通道Y.Range", TsAnimNotifyStateEnterVehicleFixOffset.FmtNum((double)fixOffsetParams.ChY.Range));
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray13<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 11) = new ValueTuple<string, object>("通道Z.Range", TsAnimNotifyStateEnterVehicleFixOffset.FmtNum((double)fixOffsetParams.ChZ.Range));
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray13<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 12) = new ValueTuple<string, object>("通道Look.Range", TsAnimNotifyStateEnterVehicleFixOffset.FmtNum((double)fixOffsetParams.ChLook.Range));
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray13<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 13));
		return true;
	}

	// Token: 0x060012D8 RID: 4824 RVA: 0x0006A2A4 File Offset: 0x000684A4
	[UFunction(EFunctionFlags.FUNC_None)]
	public override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		AActor aactor = (meshComp != null) ? meshComp.GetOwner() : null;
		if (!(aactor is TsBaseCharacter))
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = (aactor as TsBaseCharacter).CharacterActorComponent;
		if (characterActorComponent == null || !characterActorComponent.Valid)
		{
			return false;
		}
		Dictionary<AActor, FixOffsetParams> cachedMap = TsAnimNotifyStateEnterVehicleFixOffset.CachedMap;
		FixOffsetParams @params;
		if (cachedMap == null || !cachedMap.TryGetValue(aactor, out @params))
		{
			return false;
		}
		TsAnimNotifyStateEnterVehicleFixOffset.ApplyIncrement(characterActorComponent, @params, base.GetCurrentTimeLength(), false);
		return true;
	}

	// Token: 0x060012D9 RID: 4825 RVA: 0x0006A314 File Offset: 0x00068514
	[UFunction(EFunctionFlags.FUNC_None)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor aactor = (meshComp != null) ? meshComp.GetOwner() : null;
		if (!(aactor is TsBaseCharacter))
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = (aactor as TsBaseCharacter).CharacterActorComponent;
		if (characterActorComponent != null && characterActorComponent.Valid)
		{
			Dictionary<AActor, FixOffsetParams> cachedMap = TsAnimNotifyStateEnterVehicleFixOffset.CachedMap;
			FixOffsetParams fixOffsetParams;
			if (cachedMap != null && cachedMap.TryGetValue(aactor, out fixOffsetParams))
			{
				TsAnimNotifyStateEnterVehicleFixOffset.ApplyIncrement(characterActorComponent, fixOffsetParams, base.GetCurrentTimeLength(), true);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.NPC;
				ELogAuthor author = ELogAuthor.LJM;
				string message = "[EnterVehicleFixOffset] 累加校验";
				<>y__InlineArray10<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray10<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", characterActorComponent.Entity.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("累加位移X", TsAnimNotifyStateEnterVehicleFixOffset.FmtNum((double)fixOffsetParams.AppliedX));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("预期偏差X", TsAnimNotifyStateEnterVehicleFixOffset.FmtNum(fixOffsetParams.DeltaPos.X));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("误差X", TsAnimNotifyStateEnterVehicleFixOffset.FmtNum((double)fixOffsetParams.AppliedX - fixOffsetParams.DeltaPos.X));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("累加位移Y", TsAnimNotifyStateEnterVehicleFixOffset.FmtNum((double)fixOffsetParams.AppliedY));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("预期偏差Y", TsAnimNotifyStateEnterVehicleFixOffset.FmtNum(fixOffsetParams.DeltaPos.Y));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("误差Y", TsAnimNotifyStateEnterVehicleFixOffset.FmtNum((double)fixOffsetParams.AppliedY - fixOffsetParams.DeltaPos.Y));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 7) = new ValueTuple<string, object>("累加位移Z", TsAnimNotifyStateEnterVehicleFixOffset.FmtNum((double)fixOffsetParams.AppliedZ));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 8) = new ValueTuple<string, object>("预期偏差Z", TsAnimNotifyStateEnterVehicleFixOffset.FmtNum(fixOffsetParams.DeltaPos.Z));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 9) = new ValueTuple<string, object>("误差Z", TsAnimNotifyStateEnterVehicleFixOffset.FmtNum((double)fixOffsetParams.AppliedZ - fixOffsetParams.DeltaPos.Z));
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 10));
			}
		}
		Dictionary<AActor, FixOffsetParams> cachedMap2 = TsAnimNotifyStateEnterVehicleFixOffset.CachedMap;
		if (cachedMap2 != null)
		{
			cachedMap2.Remove(aactor);
		}
		if (characterActorComponent != null && characterActorComponent.Valid)
		{
			NpcVehicleRiderController.Instance.ClearEnterVehicleStartTransform(characterActorComponent.Entity.Id);
		}
		return true;
	}

	// Token: 0x060012DA RID: 4826 RVA: 0x0006A569 File Offset: 0x00068769
	[UFunction(EFunctionFlags.FUNC_None)]
	public override string GetNotifyName()
	{
		return "进入载具修正初始位置旋转偏差";
	}

	// Token: 0x060012DB RID: 4827 RVA: 0x0006A570 File Offset: 0x00068770
	private static void InitChannel(CurveChannel channel, UAnimInstance mainAnim, FName curveName, float endDelta, float target)
	{
		float mainAnimsCurveValueWithDelta = mainAnim.GetMainAnimsCurveValueWithDelta(curveName, 0f, false, false);
		channel.Range = mainAnim.GetMainAnimsCurveValueWithDelta(curveName, endDelta, false, false) - mainAnimsCurveValueWithDelta;
		channel.PrevValue = mainAnimsCurveValueWithDelta;
		channel.Acc = 0f;
		channel.AddRate = (MathUtils.Instance.IsNearlyZero((double)channel.Range, null) ? 0f : (target / channel.Range));
	}

	// Token: 0x060012DC RID: 4828 RVA: 0x0006A5E4 File Offset: 0x000687E4
	private static float StepApplied(CurveChannel channel, [Nullable(2)] UAnimInstance mainAnim, FName curveName, float target, float currentTime, float totalDuration, bool forceFull)
	{
		if (forceFull)
		{
			float result = target - channel.Acc;
			channel.Acc = target;
			return result;
		}
		float num;
		if (mainAnim != null && !MathUtils.Instance.IsNearlyZero((double)channel.Range, null))
		{
			float mainAnimsCurveValueWithDelta = mainAnim.GetMainAnimsCurveValueWithDelta(curveName, 0f, false, false);
			num = channel.AddRate * (mainAnimsCurveValueWithDelta - channel.PrevValue);
			channel.PrevValue = mainAnimsCurveValueWithDelta;
		}
		else
		{
			num = ((totalDuration > 0f) ? (target * MathUtils.Instance.Clamp(currentTime / totalDuration, 0f, 1f)) : target) - channel.Acc;
		}
		channel.Acc += num;
		return num;
	}

	// Token: 0x060012DD RID: 4829 RVA: 0x0006A690 File Offset: 0x00068890
	private static void ApplyIncrement(CharacterActorComponent actorComp, FixOffsetParams @params, float currentTime, bool forceFull)
	{
		CharacterAnimationComponent component = actorComp.Entity.GetComponent<CharacterAnimationComponent>();
		UAnimInstance mainAnim = (component != null) ? component.MainAnimInstance : null;
		float num = TsAnimNotifyStateEnterVehicleFixOffset.StepApplied(@params.ChX, mainAnim, CharacterNameDefines.Instance.ROOT_X, (float)@params.DeltaPos.X, currentTime, @params.TotalDuration, forceFull);
		float num2 = TsAnimNotifyStateEnterVehicleFixOffset.StepApplied(@params.ChY, mainAnim, CharacterNameDefines.Instance.ROOT_Y, (float)@params.DeltaPos.Y, currentTime, @params.TotalDuration, forceFull);
		float num3 = TsAnimNotifyStateEnterVehicleFixOffset.StepApplied(@params.ChZ, mainAnim, CharacterNameDefines.Instance.ROOT_Z, (float)@params.DeltaPos.Z, currentTime, @params.TotalDuration, forceFull);
		float num4 = TsAnimNotifyStateEnterVehicleFixOffset.StepApplied(@params.ChLook, mainAnim, CharacterNameDefines.Instance.ROOT_LOOK, @params.DeltaYaw, currentTime, @params.TotalDuration, forceFull);
		if (MathUtils.Instance.IsNearlyZero((double)num, null) && MathUtils.Instance.IsNearlyZero((double)num2, null) && MathUtils.Instance.IsNearlyZero((double)num3, null) && MathUtils.Instance.IsNearlyZero((double)num4, null))
		{
			return;
		}
		actorComp.SetForbidSettingLocAndRot(false, EForbidSettingLocAndRotReason.RideVehicle);
		if (!MathUtils.Instance.IsNearlyZero((double)num, null) || !MathUtils.Instance.IsNearlyZero((double)num2, null) || !MathUtils.Instance.IsNearlyZero((double)num3, null))
		{
			Vector tmpVector = TsAnimNotifyStateEnterVehicleFixOffset.TmpVector1;
			tmpVector.Set((double)num, (double)num2, (double)num3);
			actorComp.AddActorWorldOffset(tmpVector.ToUeVector(false), "TsAnimNotifyStateEnterVehicleFixOffset", false);
			@params.AppliedX += num;
			@params.AppliedY += num2;
			@params.AppliedZ += num3;
		}
		if (!MathUtils.Instance.IsNearlyZero((double)num4, null))
		{
			Rotator tmpRotator = TsAnimNotifyStateEnterVehicleFixOffset.TmpRotator1;
			tmpRotator.Set(0f, num4, 0f);
			actorComp.AddActorLocalRotation(tmpRotator.ToUeRotator(), "TsAnimNotifyStateEnterVehicleFixOffset", false);
		}
		actorComp.SetForbidSettingLocAndRot(true, EForbidSettingLocAndRotReason.RideVehicle);
	}

	// Token: 0x060012DE RID: 4830 RVA: 0x0006A8AE File Offset: 0x00068AAE
	private static string FmtNum(double value)
	{
		return value.ToString("F2");
	}

	// Token: 0x060012DF RID: 4831 RVA: 0x0006A8BC File Offset: 0x00068ABC
	private static string FmtVec(Vector v)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 3);
		defaultInterpolatedStringHandler.AppendLiteral("(");
		defaultInterpolatedStringHandler.AppendFormatted<double>(v.X, "F2");
		defaultInterpolatedStringHandler.AppendLiteral(", ");
		defaultInterpolatedStringHandler.AppendFormatted<double>(v.Y, "F2");
		defaultInterpolatedStringHandler.AppendLiteral(", ");
		defaultInterpolatedStringHandler.AppendFormatted<double>(v.Z, "F2");
		defaultInterpolatedStringHandler.AppendLiteral(")");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x060012E0 RID: 4832 RVA: 0x0006A940 File Offset: 0x00068B40
	private static string FmtRot(Rotator r)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 3);
		defaultInterpolatedStringHandler.AppendLiteral("(P:");
		defaultInterpolatedStringHandler.AppendFormatted<float>(r.Pitch, "F2");
		defaultInterpolatedStringHandler.AppendLiteral(", Y:");
		defaultInterpolatedStringHandler.AppendFormatted<float>(r.Yaw, "F2");
		defaultInterpolatedStringHandler.AppendLiteral(", R:");
		defaultInterpolatedStringHandler.AppendFormatted<float>(r.Roll, "F2");
		defaultInterpolatedStringHandler.AppendLiteral(")");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x060012E1 RID: 4833 RVA: 0x0006A9C4 File Offset: 0x00068BC4
	private static void Initialize()
	{
		if (TsAnimNotifyStateEnterVehicleFixOffset.IsInit)
		{
			return;
		}
		TsAnimNotifyStateEnterVehicleFixOffset.CachedMap = new Dictionary<AActor, FixOffsetParams>();
		TsAnimNotifyStateEnterVehicleFixOffset.IsInit = true;
	}

	// Token: 0x060012E2 RID: 4834 RVA: 0x0006A9DE File Offset: 0x00068BDE
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateEnterVehicleFixOffset._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateEnterVehicleFixOffset.TsAnimNotifyStateEnterVehicleFixOffset_C");
		}
		return TsAnimNotifyStateEnterVehicleFixOffset._ClassPtr;
	}

	// Token: 0x060012E3 RID: 4835 RVA: 0x0006AA04 File Offset: 0x00068C04
	public TsAnimNotifyStateEnterVehicleFixOffset() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateEnterVehicleFixOffset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060012E4 RID: 4836 RVA: 0x0006AA2C File Offset: 0x00068C2C
	public TsAnimNotifyStateEnterVehicleFixOffset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateEnterVehicleFixOffset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060012E5 RID: 4837 RVA: 0x0006AA5F File Offset: 0x00068C5F
	protected TsAnimNotifyStateEnterVehicleFixOffset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060012E6 RID: 4838 RVA: 0x0006AA68 File Offset: 0x00068C68
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060012E7 RID: 4839 RVA: 0x0006AAA4 File Offset: 0x00068CA4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x060012E8 RID: 4840 RVA: 0x0006AAE0 File Offset: 0x00068CE0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060012E9 RID: 4841 RVA: 0x0006AB13 File Offset: 0x00068D13
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName());
	}

	// Token: 0x04000DEF RID: 3567
	private const bool EnableDebugLog = false;

	// Token: 0x04000DF0 RID: 3568
	private static bool IsInit = false;

	// Token: 0x04000DF1 RID: 3569
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<AActor, FixOffsetParams> CachedMap = null;

	// Token: 0x04000DF2 RID: 3570
	[StaticVariableRuleIgnore]
	private static readonly Quat TmpQuat1 = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x04000DF3 RID: 3571
	[StaticVariableRuleIgnore]
	private static readonly Quat TmpQuat2 = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x04000DF4 RID: 3572
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector1 = Vector.Create();

	// Token: 0x04000DF5 RID: 3573
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector2 = Vector.Create();

	// Token: 0x04000DF6 RID: 3574
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector3 = Vector.Create();

	// Token: 0x04000DF7 RID: 3575
	[StaticVariableRuleIgnore]
	private static readonly Rotator TmpRotator1 = Rotator.Create();

	// Token: 0x04000DF8 RID: 3576
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateEnterVehicleFixOffset.TsAnimNotifyStateEnterVehicleFixOffset_C";

	// Token: 0x04000DF9 RID: 3577
	private static IntPtr _ClassPtr;

	// Token: 0x04000DFA RID: 3578
	private static IntPtr _ClassDefaultObjectPtr;
}

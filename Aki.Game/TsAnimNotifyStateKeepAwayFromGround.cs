using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000146 RID: 326
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateKeepAwayFromGround.TsAnimNotifyStateKeepAwayFromGround_C")]
public class TsAnimNotifyStateKeepAwayFromGround : TsAnimNotifyStateBase, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x06001449 RID: 5193 RVA: 0x0007363D File Offset: 0x0007183D
	static TsAnimNotifyStateKeepAwayFromGround()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsAnimNotifyStateKeepAwayFromGround.CreateStaticDefaultValue), new Action(TsAnimNotifyStateKeepAwayFromGround.ResetStaticDefaultValue));
	}

	// Token: 0x0600144A RID: 5194 RVA: 0x0007365C File Offset: 0x0007185C
	public static void CreateStaticDefaultValue()
	{
		TsAnimNotifyStateKeepAwayFromGround.paramsMap = new Dictionary<int, KeepAwayFromGroundParam>();
	}

	// Token: 0x0600144B RID: 5195 RVA: 0x00073668 File Offset: 0x00071868
	public static void ResetStaticDefaultValue()
	{
		TsAnimNotifyStateKeepAwayFromGround.paramsMap = null;
	}

	// Token: 0x17000355 RID: 853
	// (get) Token: 0x0600144C RID: 5196 RVA: 0x00073670 File Offset: 0x00071870
	// (set) Token: 0x0600144D RID: 5197 RVA: 0x00073680 File Offset: 0x00071880
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 距离水平面最小高度
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateKeepAwayFromGround.__PropertyOffset_距离水平面最小高度);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateKeepAwayFromGround.__PropertyOffset_距离水平面最小高度) = value;
		}
	}

	// Token: 0x17000356 RID: 854
	// (get) Token: 0x0600144E RID: 5198 RVA: 0x00073691 File Offset: 0x00071891
	// (set) Token: 0x0600144F RID: 5199 RVA: 0x000736A1 File Offset: 0x000718A1
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 距离水平面最大高度
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateKeepAwayFromGround.__PropertyOffset_距离水平面最大高度);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateKeepAwayFromGround.__PropertyOffset_距离水平面最大高度) = value;
		}
	}

	// Token: 0x17000357 RID: 855
	// (get) Token: 0x06001450 RID: 5200 RVA: 0x000736B2 File Offset: 0x000718B2
	// (set) Token: 0x06001451 RID: 5201 RVA: 0x000736C6 File Offset: 0x000718C6
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UCurveFloat MoveCurve
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateKeepAwayFromGround.__PropertyOffset_MoveCurve);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateKeepAwayFromGround.__PropertyOffset_MoveCurve, value);
		}
	}

	// Token: 0x17000358 RID: 856
	// (get) Token: 0x06001452 RID: 5202 RVA: 0x000736DB File Offset: 0x000718DB
	// (set) Token: 0x06001453 RID: 5203 RVA: 0x000736EB File Offset: 0x000718EB
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MaxSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateKeepAwayFromGround.__PropertyOffset_MaxSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateKeepAwayFromGround.__PropertyOffset_MaxSpeed) = value;
		}
	}

	// Token: 0x17000359 RID: 857
	// (get) Token: 0x06001454 RID: 5204 RVA: 0x000736FC File Offset: 0x000718FC
	// (set) Token: 0x06001455 RID: 5205 RVA: 0x0007370C File Offset: 0x0007190C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 不使用默认插值曲线
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateKeepAwayFromGround.__PropertyOffset_不使用默认插值曲线) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateKeepAwayFromGround.__PropertyOffset_不使用默认插值曲线) = (value ? 1 : 0);
		}
	}

	// Token: 0x06001456 RID: 5206 RVA: 0x00073720 File Offset: 0x00071920
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateKeepAwayFromGround) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateKeepAwayFromGround.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyBegin_Implementation(meshComp, animation, totalDuration);
		}
		UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		ptr->TotalDuration = totalDuration;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06001457 RID: 5207 RVA: 0x000737E0 File Offset: 0x000719E0
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		this.TsMinHeight = this.距离水平面最小高度;
		this.TsMaxHeight = this.距离水平面最大高度;
		this.TsIgnoreInterpolation = this.不使用默认插值曲线;
		this.TsMaxSpeed = this.MaxSpeed;
		this.TsTmpVector = Vector.Create();
		if (this.TsMaxHeight > 0f && this.TsMaxHeight < this.TsMinHeight)
		{
			Log.Instance.Error(ELogModule.Test, ELogAuthor.HXY, "Z轴帧事件参数错误", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		if (this.TsMaxSpeed <= 0f)
		{
			return false;
		}
		int id = ((TsBaseCharacter)owner).CharacterActorComponent.Entity.Id;
		KeepAwayFromGroundParam keepAwayFromGroundParam = null;
		if (!TsAnimNotifyStateKeepAwayFromGround.paramsMap.TryGetValue(id, out keepAwayFromGroundParam))
		{
			keepAwayFromGroundParam = new KeepAwayFromGroundParam();
			TsAnimNotifyStateKeepAwayFromGround.paramsMap[id] = keepAwayFromGroundParam;
		}
		keepAwayFromGroundParam.NowTime = 0f;
		keepAwayFromGroundParam.TotalTime = totalDuration;
		return true;
	}

	// Token: 0x06001458 RID: 5208 RVA: 0x000738D0 File Offset: 0x00071AD0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateKeepAwayFromGround) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyTick"), TsAnimNotifyStateKeepAwayFromGround.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyTick_Implementation(meshComp, animation, frameDeltaTime);
		}
		UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		ptr->FrameDeltaTime = frameDeltaTime;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06001459 RID: 5209 RVA: 0x00073990 File Offset: 0x00071B90
	protected virtual bool K2_NotifyTick_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		if ((double)frameDeltaTime < 0.0001)
		{
			return false;
		}
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
		int id = characterActorComponent.Entity.Id;
		KeepAwayFromGroundParam keepAwayFromGroundParam = null;
		if (!TsAnimNotifyStateKeepAwayFromGround.paramsMap.TryGetValue(id, out keepAwayFromGroundParam))
		{
			return false;
		}
		this.MoveToTarget(frameDeltaTime, keepAwayFromGroundParam, characterActorComponent);
		keepAwayFromGroundParam.NowTime += frameDeltaTime;
		return true;
	}

	// Token: 0x0600145A RID: 5210 RVA: 0x000739FC File Offset: 0x00071BFC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateKeepAwayFromGround) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateKeepAwayFromGround.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyEnd_Implementation(meshComp, animation);
		}
		UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0600145B RID: 5211 RVA: 0x00073AB4 File Offset: 0x00071CB4
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		int id = ((TsBaseCharacter)owner).CharacterActorComponent.Entity.Id;
		TsAnimNotifyStateKeepAwayFromGround.paramsMap.Remove(id);
		return true;
	}

	// Token: 0x0600145C RID: 5212 RVA: 0x00073AF8 File Offset: 0x00071CF8
	[NullableContext(1)]
	private float GetRate(float delta, KeepAwayFromGroundParam param)
	{
		double num = 1.0;
		float num2 = param.NowTime + delta;
		if (param.TotalTime <= num2)
		{
			return 1f;
		}
		if (this.MoveCurve != null)
		{
			float floatValue = this.MoveCurve.GetFloatValue(param.NowTime / param.TotalTime);
			float floatValue2 = this.MoveCurve.GetFloatValue(num2 / param.TotalTime);
			if (floatValue >= 1f)
			{
				return 0f;
			}
			num = (double)((floatValue2 - floatValue) / (1f - floatValue));
		}
		else if (!this.TsIgnoreInterpolation)
		{
			double cubicValue = MathUtils.Instance.GetCubicValue((double)(param.NowTime / param.TotalTime));
			double cubicValue2 = MathUtils.Instance.GetCubicValue((double)(num2 / param.TotalTime));
			if (cubicValue >= 1.0)
			{
				return 0f;
			}
			num = (cubicValue2 - cubicValue) / (1.0 - cubicValue);
		}
		return (float)num;
	}

	// Token: 0x0600145D RID: 5213 RVA: 0x00073BD8 File Offset: 0x00071DD8
	[NullableContext(1)]
	private void MoveToTarget(float frameDeltaTime, KeepAwayFromGroundParam param, CharacterActorComponent actorComp)
	{
		BaseMoveComponent component = actorComp.Entity.GetComponent<CharacterMoveComponent>();
		float heightDetect = (this.TsMaxHeight <= 0f) ? this.TsMinHeight : this.TsMaxHeight;
		float heightAboveGround = component.GetHeightAboveGround(heightDetect);
		if (heightAboveGround < this.TsMinHeight)
		{
			this.TsTmpVector.Set(0.0, 0.0, (double)(this.TsMinHeight - heightAboveGround));
			float rate = this.GetRate(frameDeltaTime, param);
			if (rate <= 0f)
			{
				return;
			}
			this.TsTmpVector.Z = Math.Min(this.TsTmpVector.Z * (double)rate, (double)(this.TsMaxSpeed * frameDeltaTime));
		}
		else
		{
			if (this.TsMaxHeight <= 0f || heightAboveGround < this.TsMaxHeight || actorComp.ActorLocationProxy.Z <= actorComp.LastActorLocation.Z)
			{
				return;
			}
			this.TsTmpVector.Set(0.0, 0.0, actorComp.LastActorLocation.Z - actorComp.ActorLocationProxy.Z);
		}
		actorComp.AddActorWorldOffset(this.TsTmpVector.ToUeVector(false), "TsAnimNotifyStateKeepAwayFromGround.AddActorWorldOffset", true);
	}

	// Token: 0x0600145E RID: 5214 RVA: 0x00073CFC File Offset: 0x00071EFC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateKeepAwayFromGround) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateKeepAwayFromGround.StaticClass(), out intPtr, out num))
		{
			return this.GetNotifyName_Implementation();
		}
		UAnimNotifyState.__GetNotifyName_FunctionParams* ptr = stackalloc UAnimNotifyState.__GetNotifyName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UAnimNotifyState.__GetNotifyName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x0600145F RID: 5215 RVA: 0x00073D8C File Offset: 0x00071F8C
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "角色和地面保持一定距离";
	}

	// Token: 0x06001460 RID: 5216 RVA: 0x00073D93 File Offset: 0x00071F93
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateKeepAwayFromGround._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateKeepAwayFromGround.TsAnimNotifyStateKeepAwayFromGround_C");
		}
		return TsAnimNotifyStateKeepAwayFromGround._ClassPtr;
	}

	// Token: 0x06001461 RID: 5217 RVA: 0x00073DB8 File Offset: 0x00071FB8
	public TsAnimNotifyStateKeepAwayFromGround() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateKeepAwayFromGround.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001462 RID: 5218 RVA: 0x00073DE0 File Offset: 0x00071FE0
	[NullableContext(1)]
	public TsAnimNotifyStateKeepAwayFromGround(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateKeepAwayFromGround.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001463 RID: 5219 RVA: 0x00073E13 File Offset: 0x00072013
	protected TsAnimNotifyStateKeepAwayFromGround(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001464 RID: 5220 RVA: 0x00073E1C File Offset: 0x0007201C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001465 RID: 5221 RVA: 0x00073E58 File Offset: 0x00072058
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x06001466 RID: 5222 RVA: 0x00073E94 File Offset: 0x00072094
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001467 RID: 5223 RVA: 0x00073EC7 File Offset: 0x000720C7
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000E91 RID: 3729
	[Nullable(1)]
	private static Dictionary<int, KeepAwayFromGroundParam> paramsMap;

	// Token: 0x04000E92 RID: 3730
	private float TsMinHeight;

	// Token: 0x04000E93 RID: 3731
	private float TsMaxHeight;

	// Token: 0x04000E94 RID: 3732
	private float TsMaxSpeed;

	// Token: 0x04000E95 RID: 3733
	[Nullable(1)]
	private Vector TsTmpVector;

	// Token: 0x04000E96 RID: 3734
	private bool TsIgnoreInterpolation;

	// Token: 0x04000E97 RID: 3735
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateKeepAwayFromGround.TsAnimNotifyStateKeepAwayFromGround_C";

	// Token: 0x04000E98 RID: 3736
	private static IntPtr _ClassPtr;

	// Token: 0x04000E99 RID: 3737
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000E9A RID: 3738
	private static int __PropertyOffset_距离水平面最小高度;

	// Token: 0x04000E9B RID: 3739
	private static int __PropertyOffset_距离水平面最大高度;

	// Token: 0x04000E9C RID: 3740
	private static int __PropertyOffset_MoveCurve;

	// Token: 0x04000E9D RID: 3741
	private static int __PropertyOffset_MaxSpeed;

	// Token: 0x04000E9E RID: 3742
	private static int __PropertyOffset_不使用默认插值曲线;
}

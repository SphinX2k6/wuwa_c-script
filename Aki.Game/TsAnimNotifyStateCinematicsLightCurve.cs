using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200011E RID: 286
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCinematicsLightCurve.TsAnimNotifyStateCinematicsLightCurve_C")]
public class TsAnimNotifyStateCinematicsLightCurve : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170002C1 RID: 705
	// (get) Token: 0x06001124 RID: 4388 RVA: 0x000621C8 File Offset: 0x000603C8
	// (set) Token: 0x06001125 RID: 4389 RVA: 0x00062201 File Offset: 0x00060401
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveFloat LightYaw
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveFloat result;
			if ((result = this._LightYaw) == null)
			{
				result = (this._LightYaw = new FKuroCurveFloat(base.NativePtr + (IntPtr)TsAnimNotifyStateCinematicsLightCurve.__PropertyOffset_LightYaw, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)TsAnimNotifyStateCinematicsLightCurve.__PropertyOffset_LightYaw, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x170002C2 RID: 706
	// (get) Token: 0x06001126 RID: 4390 RVA: 0x0006222C File Offset: 0x0006042C
	// (set) Token: 0x06001127 RID: 4391 RVA: 0x00062265 File Offset: 0x00060465
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveFloat LightPitch
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveFloat result;
			if ((result = this._LightPitch) == null)
			{
				result = (this._LightPitch = new FKuroCurveFloat(base.NativePtr + (IntPtr)TsAnimNotifyStateCinematicsLightCurve.__PropertyOffset_LightPitch, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)TsAnimNotifyStateCinematicsLightCurve.__PropertyOffset_LightPitch, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x170002C3 RID: 707
	// (get) Token: 0x06001128 RID: 4392 RVA: 0x00062290 File Offset: 0x00060490
	// (set) Token: 0x06001129 RID: 4393 RVA: 0x000622C9 File Offset: 0x000604C9
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveFloat FaceLightYaw
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveFloat result;
			if ((result = this._FaceLightYaw) == null)
			{
				result = (this._FaceLightYaw = new FKuroCurveFloat(base.NativePtr + (IntPtr)TsAnimNotifyStateCinematicsLightCurve.__PropertyOffset_FaceLightYaw, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)TsAnimNotifyStateCinematicsLightCurve.__PropertyOffset_FaceLightYaw, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x0600112A RID: 4394 RVA: 0x000622F4 File Offset: 0x000604F4
	private void ApplyLightDirection(USkeletalMeshComponent meshComp)
	{
		float currentTimeLength = base.GetCurrentTimeLength();
		FKuroCurveFloat fkuroCurveFloat = this.LightYaw;
		float value_Float = UKuroCurveLibrary.GetValue_Float(fkuroCurveFloat, currentTimeLength);
		fkuroCurveFloat = this.LightPitch;
		float value_Float2 = UKuroCurveLibrary.GetValue_Float(fkuroCurveFloat, currentTimeLength);
		fkuroCurveFloat = this.FaceLightYaw;
		float value_Float3 = UKuroCurveLibrary.GetValue_Float(fkuroCurveFloat, currentTimeLength);
		FRotator frotator = meshComp.K2_GetComponentRotation();
		float value = value_Float + frotator.Yaw;
		meshComp.SetCustomPrimitiveDataFloat(TsAnimNotifyStateCinematicsLightCurve.SLOT_LIGHT_YAW, value);
		meshComp.SetCustomPrimitiveDataFloat(TsAnimNotifyStateCinematicsLightCurve.SLOT_LIGHT_PITCH, value_Float2);
		meshComp.SetCustomPrimitiveDataFloat(TsAnimNotifyStateCinematicsLightCurve.SLOT_RECEIVE_ROLE_LIGHT, 1f);
		if (value_Float3 > 0f)
		{
			meshComp.SetCustomPrimitiveDataFloat(TsAnimNotifyStateCinematicsLightCurve.SLOT_FACE_LIGHT_ENABLE, 1f);
			meshComp.SetCustomPrimitiveDataFloat(TsAnimNotifyStateCinematicsLightCurve.SLOT_FACE_LIGHT_YAW, value_Float3);
			return;
		}
		meshComp.SetCustomPrimitiveDataFloat(TsAnimNotifyStateCinematicsLightCurve.SLOT_FACE_LIGHT_ENABLE, 0f);
	}

	// Token: 0x0600112B RID: 4395 RVA: 0x000623A8 File Offset: 0x000605A8
	private void RevertLightDirection(USkeletalMeshComponent meshComp)
	{
		meshComp.SetCustomPrimitiveDataFloat(TsAnimNotifyStateCinematicsLightCurve.SLOT_LIGHT_YAW, 0f);
		meshComp.SetCustomPrimitiveDataFloat(TsAnimNotifyStateCinematicsLightCurve.SLOT_LIGHT_PITCH, 0f);
		meshComp.SetCustomPrimitiveDataFloat(TsAnimNotifyStateCinematicsLightCurve.SLOT_FACE_LIGHT_YAW, 0f);
		meshComp.SetCustomPrimitiveDataFloat(TsAnimNotifyStateCinematicsLightCurve.SLOT_RECEIVE_ROLE_LIGHT, 0f);
		meshComp.SetCustomPrimitiveDataFloat(TsAnimNotifyStateCinematicsLightCurve.SLOT_FACE_LIGHT_ENABLE, 0f);
	}

	// Token: 0x0600112C RID: 4396 RVA: 0x00062408 File Offset: 0x00060608
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateCinematicsLightCurve) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateCinematicsLightCurve.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600112D RID: 4397 RVA: 0x000624C6 File Offset: 0x000606C6
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		if (meshComp == null || !meshComp.IsValid())
		{
			return false;
		}
		this.ApplyLightDirection(meshComp);
		return true;
	}

	// Token: 0x0600112E RID: 4398 RVA: 0x000624E4 File Offset: 0x000606E4
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateCinematicsLightCurve) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyTick"), TsAnimNotifyStateCinematicsLightCurve.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600112F RID: 4399 RVA: 0x000625A2 File Offset: 0x000607A2
	[NullableContext(2)]
	protected virtual bool K2_NotifyTick_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		if (meshComp == null || !meshComp.IsValid())
		{
			return false;
		}
		this.ApplyLightDirection(meshComp);
		return true;
	}

	// Token: 0x06001130 RID: 4400 RVA: 0x000625C0 File Offset: 0x000607C0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateCinematicsLightCurve) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateCinematicsLightCurve.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001131 RID: 4401 RVA: 0x00062676 File Offset: 0x00060876
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		if (meshComp == null || !meshComp.IsValid())
		{
			return false;
		}
		this.RevertLightDirection(meshComp);
		return true;
	}

	// Token: 0x06001132 RID: 4402 RVA: 0x00062694 File Offset: 0x00060894
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateCinematicsLightCurve) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateCinematicsLightCurve.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001133 RID: 4403 RVA: 0x00062724 File Offset: 0x00060924
	protected override string GetNotifyName_Implementation()
	{
		return "演出灯光曲线通知状态";
	}

	// Token: 0x06001134 RID: 4404 RVA: 0x0006272B File Offset: 0x0006092B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateCinematicsLightCurve._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCinematicsLightCurve.TsAnimNotifyStateCinematicsLightCurve_C");
		}
		return TsAnimNotifyStateCinematicsLightCurve._ClassPtr;
	}

	// Token: 0x06001135 RID: 4405 RVA: 0x00062750 File Offset: 0x00060950
	public TsAnimNotifyStateCinematicsLightCurve() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateCinematicsLightCurve.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001136 RID: 4406 RVA: 0x00062778 File Offset: 0x00060978
	public TsAnimNotifyStateCinematicsLightCurve(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateCinematicsLightCurve.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001137 RID: 4407 RVA: 0x000627AB File Offset: 0x000609AB
	protected TsAnimNotifyStateCinematicsLightCurve(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001138 RID: 4408 RVA: 0x000627B4 File Offset: 0x000609B4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001139 RID: 4409 RVA: 0x000627F0 File Offset: 0x000609F0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x0600113A RID: 4410 RVA: 0x0006282C File Offset: 0x00060A2C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600113B RID: 4411 RVA: 0x0006285F File Offset: 0x00060A5F
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000CF0 RID: 3312
	[StaticVariableRuleIgnore]
	private static readonly int SLOT_LIGHT_YAW = 0;

	// Token: 0x04000CF1 RID: 3313
	[StaticVariableRuleIgnore]
	private static readonly int SLOT_LIGHT_PITCH = 22;

	// Token: 0x04000CF2 RID: 3314
	[StaticVariableRuleIgnore]
	private static readonly int SLOT_FACE_LIGHT_YAW = 11;

	// Token: 0x04000CF3 RID: 3315
	[StaticVariableRuleIgnore]
	private static readonly int SLOT_RECEIVE_ROLE_LIGHT = 1;

	// Token: 0x04000CF4 RID: 3316
	[StaticVariableRuleIgnore]
	private static readonly int SLOT_FACE_LIGHT_ENABLE = 12;

	// Token: 0x04000CF5 RID: 3317
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCinematicsLightCurve.TsAnimNotifyStateCinematicsLightCurve_C";

	// Token: 0x04000CF6 RID: 3318
	private static IntPtr _ClassPtr;

	// Token: 0x04000CF7 RID: 3319
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000CF8 RID: 3320
	private static int __PropertyOffset_LightYaw;

	// Token: 0x04000CF9 RID: 3321
	[Nullable(2)]
	private FKuroCurveFloat _LightYaw;

	// Token: 0x04000CFA RID: 3322
	private static int __PropertyOffset_LightPitch;

	// Token: 0x04000CFB RID: 3323
	[Nullable(2)]
	private FKuroCurveFloat _LightPitch;

	// Token: 0x04000CFC RID: 3324
	private static int __PropertyOffset_FaceLightYaw;

	// Token: 0x04000CFD RID: 3325
	[Nullable(2)]
	private FKuroCurveFloat _FaceLightYaw;
}

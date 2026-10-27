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
	// Token: 0x170002BE RID: 702
	// (get) Token: 0x0600111E RID: 4382 RVA: 0x00060C98 File Offset: 0x0005EE98
	// (set) Token: 0x0600111F RID: 4383 RVA: 0x00060CD1 File Offset: 0x0005EED1
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

	// Token: 0x170002BF RID: 703
	// (get) Token: 0x06001120 RID: 4384 RVA: 0x00060CFC File Offset: 0x0005EEFC
	// (set) Token: 0x06001121 RID: 4385 RVA: 0x00060D35 File Offset: 0x0005EF35
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

	// Token: 0x170002C0 RID: 704
	// (get) Token: 0x06001122 RID: 4386 RVA: 0x00060D60 File Offset: 0x0005EF60
	// (set) Token: 0x06001123 RID: 4387 RVA: 0x00060D99 File Offset: 0x0005EF99
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

	// Token: 0x06001124 RID: 4388 RVA: 0x00060DC4 File Offset: 0x0005EFC4
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

	// Token: 0x06001125 RID: 4389 RVA: 0x00060E78 File Offset: 0x0005F078
	private void RevertLightDirection(USkeletalMeshComponent meshComp)
	{
		meshComp.SetCustomPrimitiveDataFloat(TsAnimNotifyStateCinematicsLightCurve.SLOT_LIGHT_YAW, 0f);
		meshComp.SetCustomPrimitiveDataFloat(TsAnimNotifyStateCinematicsLightCurve.SLOT_LIGHT_PITCH, 0f);
		meshComp.SetCustomPrimitiveDataFloat(TsAnimNotifyStateCinematicsLightCurve.SLOT_FACE_LIGHT_YAW, 0f);
		meshComp.SetCustomPrimitiveDataFloat(TsAnimNotifyStateCinematicsLightCurve.SLOT_RECEIVE_ROLE_LIGHT, 0f);
		meshComp.SetCustomPrimitiveDataFloat(TsAnimNotifyStateCinematicsLightCurve.SLOT_FACE_LIGHT_ENABLE, 0f);
	}

	// Token: 0x06001126 RID: 4390 RVA: 0x00060ED8 File Offset: 0x0005F0D8
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyBegin"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
			ptr2->TotalDuration = totalDuration;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x06001127 RID: 4391 RVA: 0x00060F7E File Offset: 0x0005F17E
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

	// Token: 0x06001128 RID: 4392 RVA: 0x00060F9C File Offset: 0x0005F19C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyTick"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
			ptr2->FrameDeltaTime = frameDeltaTime;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x06001129 RID: 4393 RVA: 0x00061042 File Offset: 0x0005F242
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

	// Token: 0x0600112A RID: 4394 RVA: 0x00061060 File Offset: 0x0005F260
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyEnd"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0600112B RID: 4395 RVA: 0x000610FF File Offset: 0x0005F2FF
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

	// Token: 0x0600112C RID: 4396 RVA: 0x0006111C File Offset: 0x0005F31C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetNotifyName"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UAnimNotifyState.__GetNotifyName_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UAnimNotifyState.__GetNotifyName_FunctionParams*)ptr + 15L / (long)sizeof(UAnimNotifyState.__GetNotifyName_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		string result = FString.ToString((void*)(&ptr2->__Result));
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return result;
	}

	// Token: 0x0600112D RID: 4397 RVA: 0x00061197 File Offset: 0x0005F397
	protected override string GetNotifyName_Implementation()
	{
		return "演出灯光曲线通知状态";
	}

	// Token: 0x0600112E RID: 4398 RVA: 0x0006119E File Offset: 0x0005F39E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateCinematicsLightCurve._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCinematicsLightCurve.TsAnimNotifyStateCinematicsLightCurve_C");
		}
		return TsAnimNotifyStateCinematicsLightCurve._ClassPtr;
	}

	// Token: 0x0600112F RID: 4399 RVA: 0x000611C4 File Offset: 0x0005F3C4
	public TsAnimNotifyStateCinematicsLightCurve() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateCinematicsLightCurve.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001130 RID: 4400 RVA: 0x000611EC File Offset: 0x0005F3EC
	public TsAnimNotifyStateCinematicsLightCurve(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateCinematicsLightCurve.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001131 RID: 4401 RVA: 0x0006121F File Offset: 0x0005F41F
	protected TsAnimNotifyStateCinematicsLightCurve(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001132 RID: 4402 RVA: 0x00061228 File Offset: 0x0005F428
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001133 RID: 4403 RVA: 0x00061264 File Offset: 0x0005F464
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x06001134 RID: 4404 RVA: 0x000612A0 File Offset: 0x0005F4A0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001135 RID: 4405 RVA: 0x000612D3 File Offset: 0x0005F4D3
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000CE8 RID: 3304
	[StaticVariableRuleIgnore]
	private static readonly int SLOT_LIGHT_YAW = 0;

	// Token: 0x04000CE9 RID: 3305
	[StaticVariableRuleIgnore]
	private static readonly int SLOT_LIGHT_PITCH = 22;

	// Token: 0x04000CEA RID: 3306
	[StaticVariableRuleIgnore]
	private static readonly int SLOT_FACE_LIGHT_YAW = 11;

	// Token: 0x04000CEB RID: 3307
	[StaticVariableRuleIgnore]
	private static readonly int SLOT_RECEIVE_ROLE_LIGHT = 1;

	// Token: 0x04000CEC RID: 3308
	[StaticVariableRuleIgnore]
	private static readonly int SLOT_FACE_LIGHT_ENABLE = 12;

	// Token: 0x04000CED RID: 3309
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCinematicsLightCurve.TsAnimNotifyStateCinematicsLightCurve_C";

	// Token: 0x04000CEE RID: 3310
	private static IntPtr _ClassPtr;

	// Token: 0x04000CEF RID: 3311
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000CF0 RID: 3312
	private static int __PropertyOffset_LightYaw;

	// Token: 0x04000CF1 RID: 3313
	[Nullable(2)]
	private FKuroCurveFloat _LightYaw;

	// Token: 0x04000CF2 RID: 3314
	private static int __PropertyOffset_LightPitch;

	// Token: 0x04000CF3 RID: 3315
	[Nullable(2)]
	private FKuroCurveFloat _LightPitch;

	// Token: 0x04000CF4 RID: 3316
	private static int __PropertyOffset_FaceLightYaw;

	// Token: 0x04000CF5 RID: 3317
	[Nullable(2)]
	private FKuroCurveFloat _FaceLightYaw;
}

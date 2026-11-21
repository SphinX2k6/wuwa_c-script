using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200011A RID: 282
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCameraStateChange.TsAnimNotifyStateCameraStateChange_C")]
public class TsAnimNotifyStateCameraStateChange : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170002B8 RID: 696
	// (get) Token: 0x060010DB RID: 4315 RVA: 0x00060DC3 File Offset: 0x0005EFC3
	// (set) Token: 0x060010DC RID: 4316 RVA: 0x00060DD3 File Offset: 0x0005EFD3
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 是否为单客户端
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateCameraStateChange.__PropertyOffset_是否为单客户端) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateCameraStateChange.__PropertyOffset_是否为单客户端) = (value ? 1 : 0);
		}
	}

	// Token: 0x170002B9 RID: 697
	// (get) Token: 0x060010DD RID: 4317 RVA: 0x00060DE4 File Offset: 0x0005EFE4
	// (set) Token: 0x060010DE RID: 4318 RVA: 0x00060DF4 File Offset: 0x0005EFF4
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 是否跟随
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateCameraStateChange.__PropertyOffset_是否跟随) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateCameraStateChange.__PropertyOffset_是否跟随) = (value ? 1 : 0);
		}
	}

	// Token: 0x170002BA RID: 698
	// (get) Token: 0x060010DF RID: 4319 RVA: 0x00060E05 File Offset: 0x0005F005
	// (set) Token: 0x060010E0 RID: 4320 RVA: 0x00060E15 File Offset: 0x0005F015
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 切人时恢复跟随
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateCameraStateChange.__PropertyOffset_切人时恢复跟随) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateCameraStateChange.__PropertyOffset_切人时恢复跟随) = (value ? 1 : 0);
		}
	}

	// Token: 0x060010E1 RID: 4321 RVA: 0x00060E28 File Offset: 0x0005F028
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateCameraStateChange) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateCameraStateChange.StaticClass(), out intPtr, out num))
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

	// Token: 0x060010E2 RID: 4322 RVA: 0x00060EE8 File Offset: 0x0005F0E8
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		if (!this.是否为单客户端 || (owner is TsBaseCharacter && Global.BaseCharacter == owner))
		{
			CameraController.Instance.MainModel.FightCamera.LogicComponent.IsFollowing = this.是否跟随;
			CameraController.Instance.MainModel.FightCamera.LogicComponent.RestoreFollowingOnChangeRole = this.切人时恢复跟随;
			return true;
		}
		return false;
	}

	// Token: 0x060010E3 RID: 4323 RVA: 0x00060F58 File Offset: 0x0005F158
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateCameraStateChange) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateCameraStateChange.StaticClass(), out intPtr, out num))
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

	// Token: 0x060010E4 RID: 4324 RVA: 0x00061010 File Offset: 0x0005F210
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (!this.是否为单客户端 || (owner is TsBaseCharacter && Global.BaseCharacter == owner))
		{
			CameraController.Instance.MainModel.FightCamera.LogicComponent.IsFollowing = true;
			return true;
		}
		return false;
	}

	// Token: 0x060010E5 RID: 4325 RVA: 0x0006105C File Offset: 0x0005F25C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateCameraStateChange) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateCameraStateChange.StaticClass(), out intPtr, out num))
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

	// Token: 0x060010E6 RID: 4326 RVA: 0x000610EC File Offset: 0x0005F2EC
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "相机是否跟随角色移动";
	}

	// Token: 0x060010E7 RID: 4327 RVA: 0x000610F3 File Offset: 0x0005F2F3
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateCameraStateChange._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCameraStateChange.TsAnimNotifyStateCameraStateChange_C");
		}
		return TsAnimNotifyStateCameraStateChange._ClassPtr;
	}

	// Token: 0x060010E8 RID: 4328 RVA: 0x00061118 File Offset: 0x0005F318
	public TsAnimNotifyStateCameraStateChange() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateCameraStateChange.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060010E9 RID: 4329 RVA: 0x00061140 File Offset: 0x0005F340
	[NullableContext(1)]
	public TsAnimNotifyStateCameraStateChange(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateCameraStateChange.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060010EA RID: 4330 RVA: 0x00061173 File Offset: 0x0005F373
	protected TsAnimNotifyStateCameraStateChange(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060010EB RID: 4331 RVA: 0x0006117C File Offset: 0x0005F37C
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060010EC RID: 4332 RVA: 0x000611B8 File Offset: 0x0005F3B8
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060010ED RID: 4333 RVA: 0x000611EB File Offset: 0x0005F3EB
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000CD6 RID: 3286
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCameraStateChange.TsAnimNotifyStateCameraStateChange_C";

	// Token: 0x04000CD7 RID: 3287
	private static IntPtr _ClassPtr;

	// Token: 0x04000CD8 RID: 3288
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000CD9 RID: 3289
	private static int __PropertyOffset_是否为单客户端;

	// Token: 0x04000CDA RID: 3290
	private static int __PropertyOffset_是否跟随;

	// Token: 0x04000CDB RID: 3291
	private static int __PropertyOffset_切人时恢复跟随;
}

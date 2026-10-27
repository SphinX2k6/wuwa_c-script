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
	// Token: 0x170002B5 RID: 693
	// (get) Token: 0x060010D5 RID: 4309 RVA: 0x0005F9A3 File Offset: 0x0005DBA3
	// (set) Token: 0x060010D6 RID: 4310 RVA: 0x0005F9B3 File Offset: 0x0005DBB3
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

	// Token: 0x170002B6 RID: 694
	// (get) Token: 0x060010D7 RID: 4311 RVA: 0x0005F9C4 File Offset: 0x0005DBC4
	// (set) Token: 0x060010D8 RID: 4312 RVA: 0x0005F9D4 File Offset: 0x0005DBD4
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

	// Token: 0x170002B7 RID: 695
	// (get) Token: 0x060010D9 RID: 4313 RVA: 0x0005F9E5 File Offset: 0x0005DBE5
	// (set) Token: 0x060010DA RID: 4314 RVA: 0x0005F9F5 File Offset: 0x0005DBF5
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

	// Token: 0x060010DB RID: 4315 RVA: 0x0005FA08 File Offset: 0x0005DC08
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

	// Token: 0x060010DC RID: 4316 RVA: 0x0005FAB0 File Offset: 0x0005DCB0
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

	// Token: 0x060010DD RID: 4317 RVA: 0x0005FB20 File Offset: 0x0005DD20
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

	// Token: 0x060010DE RID: 4318 RVA: 0x0005FBC0 File Offset: 0x0005DDC0
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

	// Token: 0x060010DF RID: 4319 RVA: 0x0005FC0C File Offset: 0x0005DE0C
	[NullableContext(1)]
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

	// Token: 0x060010E0 RID: 4320 RVA: 0x0005FC87 File Offset: 0x0005DE87
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "相机是否跟随角色移动";
	}

	// Token: 0x060010E1 RID: 4321 RVA: 0x0005FC8E File Offset: 0x0005DE8E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateCameraStateChange._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCameraStateChange.TsAnimNotifyStateCameraStateChange_C");
		}
		return TsAnimNotifyStateCameraStateChange._ClassPtr;
	}

	// Token: 0x060010E2 RID: 4322 RVA: 0x0005FCB4 File Offset: 0x0005DEB4
	public TsAnimNotifyStateCameraStateChange() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateCameraStateChange.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060010E3 RID: 4323 RVA: 0x0005FCDC File Offset: 0x0005DEDC
	[NullableContext(1)]
	public TsAnimNotifyStateCameraStateChange(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateCameraStateChange.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060010E4 RID: 4324 RVA: 0x0005FD0F File Offset: 0x0005DF0F
	protected TsAnimNotifyStateCameraStateChange(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060010E5 RID: 4325 RVA: 0x0005FD18 File Offset: 0x0005DF18
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060010E6 RID: 4326 RVA: 0x0005FD54 File Offset: 0x0005DF54
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060010E7 RID: 4327 RVA: 0x0005FD87 File Offset: 0x0005DF87
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000CCE RID: 3278
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCameraStateChange.TsAnimNotifyStateCameraStateChange_C";

	// Token: 0x04000CCF RID: 3279
	private static IntPtr _ClassPtr;

	// Token: 0x04000CD0 RID: 3280
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000CD1 RID: 3281
	private static int __PropertyOffset_是否为单客户端;

	// Token: 0x04000CD2 RID: 3282
	private static int __PropertyOffset_是否跟随;

	// Token: 0x04000CD3 RID: 3283
	private static int __PropertyOffset_切人时恢复跟随;
}

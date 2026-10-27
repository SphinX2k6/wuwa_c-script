using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001AF RID: 431
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyDisableAllRoleWithoutControl.TsAnimNotifyDisableAllRoleWithoutControl_C")]
public class TsAnimNotifyDisableAllRoleWithoutControl : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000467 RID: 1127
	// (get) Token: 0x06001B39 RID: 6969 RVA: 0x0008CB4F File Offset: 0x0008AD4F
	// (set) Token: 0x06001B3A RID: 6970 RVA: 0x0008CB5F File Offset: 0x0008AD5F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 是否播放特效
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyDisableAllRoleWithoutControl.__PropertyOffset_是否播放特效) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyDisableAllRoleWithoutControl.__PropertyOffset_是否播放特效) = (value ? 1 : 0);
		}
	}

	// Token: 0x06001B3B RID: 6971 RVA: 0x0008CB70 File Offset: 0x0008AD70
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_Notify"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotify.__K2_Notify_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L);
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

	// Token: 0x06001B3C RID: 6972 RVA: 0x0008CC10 File Offset: 0x0008AE10
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
		if (characterActorComponent == null || !characterActorComponent.Valid || !characterActorComponent.IsAutonomousProxy)
		{
			return false;
		}
		SceneTeamController.Instance.DisableAllRoleWithoutControl(null, null, this.是否播放特效);
		return true;
	}

	// Token: 0x06001B3D RID: 6973 RVA: 0x0008CC70 File Offset: 0x0008AE70
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetNotifyName"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UAnimNotify.__GetNotifyName_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UAnimNotify.__GetNotifyName_FunctionParams*)ptr + 15L / (long)sizeof(UAnimNotify.__GetNotifyName_FunctionParams) & -16L);
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

	// Token: 0x06001B3E RID: 6974 RVA: 0x0008CCEB File Offset: 0x0008AEEB
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "下场所有前台不受控角色（开启特效时有延迟）";
	}

	// Token: 0x06001B3F RID: 6975 RVA: 0x0008CCF2 File Offset: 0x0008AEF2
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyDisableAllRoleWithoutControl._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyDisableAllRoleWithoutControl.TsAnimNotifyDisableAllRoleWithoutControl_C");
		}
		return TsAnimNotifyDisableAllRoleWithoutControl._ClassPtr;
	}

	// Token: 0x06001B40 RID: 6976 RVA: 0x0008CD18 File Offset: 0x0008AF18
	public TsAnimNotifyDisableAllRoleWithoutControl() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyDisableAllRoleWithoutControl.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001B41 RID: 6977 RVA: 0x0008CD40 File Offset: 0x0008AF40
	[NullableContext(1)]
	public TsAnimNotifyDisableAllRoleWithoutControl(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyDisableAllRoleWithoutControl.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001B42 RID: 6978 RVA: 0x0008CD73 File Offset: 0x0008AF73
	protected TsAnimNotifyDisableAllRoleWithoutControl(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001B43 RID: 6979 RVA: 0x0008CD7C File Offset: 0x0008AF7C
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001B44 RID: 6980 RVA: 0x0008CDAF File Offset: 0x0008AFAF
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001174 RID: 4468
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyDisableAllRoleWithoutControl.TsAnimNotifyDisableAllRoleWithoutControl_C";

	// Token: 0x04001175 RID: 4469
	private static IntPtr _ClassPtr;

	// Token: 0x04001176 RID: 4470
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001177 RID: 4471
	private static int __PropertyOffset_是否播放特效;
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001B3 RID: 435
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyDisableAllRoleWithoutControl.TsAnimNotifyDisableAllRoleWithoutControl_C")]
public class TsAnimNotifyDisableAllRoleWithoutControl : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000489 RID: 1161
	// (get) Token: 0x06001BD6 RID: 7126 RVA: 0x000933D3 File Offset: 0x000915D3
	// (set) Token: 0x06001BD7 RID: 7127 RVA: 0x000933E3 File Offset: 0x000915E3
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

	// Token: 0x06001BD8 RID: 7128 RVA: 0x000933F4 File Offset: 0x000915F4
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyDisableAllRoleWithoutControl) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyDisableAllRoleWithoutControl.StaticClass(), out intPtr, out num))
		{
			return this.K2_Notify_Implementation(meshComp, animation);
		}
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr = stackalloc UKuroAnimNotify.__K2_Notify_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06001BD9 RID: 7129 RVA: 0x000934AC File Offset: 0x000916AC
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

	// Token: 0x06001BDA RID: 7130 RVA: 0x0009350C File Offset: 0x0009170C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyDisableAllRoleWithoutControl) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyDisableAllRoleWithoutControl.StaticClass(), out intPtr, out num))
		{
			return this.GetNotifyName_Implementation();
		}
		UAnimNotify.__GetNotifyName_FunctionParams* ptr = stackalloc UAnimNotify.__GetNotifyName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UAnimNotify.__GetNotifyName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x06001BDB RID: 7131 RVA: 0x0009359C File Offset: 0x0009179C
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "下场所有前台不受控角色（开启特效时有延迟）";
	}

	// Token: 0x06001BDC RID: 7132 RVA: 0x000935A3 File Offset: 0x000917A3
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyDisableAllRoleWithoutControl._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyDisableAllRoleWithoutControl.TsAnimNotifyDisableAllRoleWithoutControl_C");
		}
		return TsAnimNotifyDisableAllRoleWithoutControl._ClassPtr;
	}

	// Token: 0x06001BDD RID: 7133 RVA: 0x000935C8 File Offset: 0x000917C8
	public TsAnimNotifyDisableAllRoleWithoutControl() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyDisableAllRoleWithoutControl.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001BDE RID: 7134 RVA: 0x000935F0 File Offset: 0x000917F0
	[NullableContext(1)]
	public TsAnimNotifyDisableAllRoleWithoutControl(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyDisableAllRoleWithoutControl.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001BDF RID: 7135 RVA: 0x00093623 File Offset: 0x00091823
	protected TsAnimNotifyDisableAllRoleWithoutControl(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001BE0 RID: 7136 RVA: 0x0009362C File Offset: 0x0009182C
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001BE1 RID: 7137 RVA: 0x0009365F File Offset: 0x0009185F
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040011B7 RID: 4535
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyDisableAllRoleWithoutControl.TsAnimNotifyDisableAllRoleWithoutControl_C";

	// Token: 0x040011B8 RID: 4536
	private static IntPtr _ClassPtr;

	// Token: 0x040011B9 RID: 4537
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040011BA RID: 4538
	private static int __PropertyOffset_是否播放特效;
}

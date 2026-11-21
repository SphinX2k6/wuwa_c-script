using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001D8 RID: 472
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySendGamePlayEventToRole.TsAnimNotifySendGamePlayEventToRole_C")]
public class TsAnimNotifySendGamePlayEventToRole : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004D0 RID: 1232
	// (get) Token: 0x06001DCE RID: 7630 RVA: 0x0009A7FF File Offset: 0x000989FF
	// (set) Token: 0x06001DCF RID: 7631 RVA: 0x0009A813 File Offset: 0x00098A13
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FGameplayTag 事件Tag
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifySendGamePlayEventToRole.__PropertyOffset_事件Tag);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifySendGamePlayEventToRole.__PropertyOffset_事件Tag) = value;
		}
	}

	// Token: 0x06001DD0 RID: 7632 RVA: 0x0009A828 File Offset: 0x00098A28
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifySendGamePlayEventToRole) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifySendGamePlayEventToRole.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001DD1 RID: 7633 RVA: 0x0009A8E0 File Offset: 0x00098AE0
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		SceneTeamModel instance = SceneTeamModel.Instance;
		WorldEntity worldEntity;
		if (instance == null)
		{
			worldEntity = null;
		}
		else
		{
			EntityHandle getCurrentEntity = instance.GetCurrentEntity;
			worldEntity = ((getCurrentEntity != null) ? getCurrentEntity.Entity : null);
		}
		WorldEntity worldEntity2 = worldEntity;
		if (worldEntity2 == null)
		{
			return false;
		}
		BaseAbilityComponent component = worldEntity2.GetComponent<BaseAbilityComponent>();
		if (component == null || !component.Valid)
		{
			return false;
		}
		component.SendGameplayEventToActor(this.事件Tag, null);
		return true;
	}

	// Token: 0x06001DD2 RID: 7634 RVA: 0x0009A938 File Offset: 0x00098B38
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifySendGamePlayEventToRole) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifySendGamePlayEventToRole.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001DD3 RID: 7635 RVA: 0x0009A9C8 File Offset: 0x00098BC8
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "发送动画通知广播给主控角色";
	}

	// Token: 0x06001DD4 RID: 7636 RVA: 0x0009A9CF File Offset: 0x00098BCF
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifySendGamePlayEventToRole._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySendGamePlayEventToRole.TsAnimNotifySendGamePlayEventToRole_C");
		}
		return TsAnimNotifySendGamePlayEventToRole._ClassPtr;
	}

	// Token: 0x06001DD5 RID: 7637 RVA: 0x0009A9F4 File Offset: 0x00098BF4
	public TsAnimNotifySendGamePlayEventToRole() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySendGamePlayEventToRole.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001DD6 RID: 7638 RVA: 0x0009AA1C File Offset: 0x00098C1C
	[NullableContext(1)]
	public TsAnimNotifySendGamePlayEventToRole(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySendGamePlayEventToRole.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001DD7 RID: 7639 RVA: 0x0009AA4F File Offset: 0x00098C4F
	protected TsAnimNotifySendGamePlayEventToRole(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001DD8 RID: 7640 RVA: 0x0009AA58 File Offset: 0x00098C58
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001DD9 RID: 7641 RVA: 0x0009AA8B File Offset: 0x00098C8B
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001279 RID: 4729
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySendGamePlayEventToRole.TsAnimNotifySendGamePlayEventToRole_C";

	// Token: 0x0400127A RID: 4730
	private static IntPtr _ClassPtr;

	// Token: 0x0400127B RID: 4731
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400127C RID: 4732
	private static int __PropertyOffset_事件Tag;
}

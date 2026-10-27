using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001D4 RID: 468
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySendGamePlayEventToRole.TsAnimNotifySendGamePlayEventToRole_C")]
public class TsAnimNotifySendGamePlayEventToRole : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004AE RID: 1198
	// (get) Token: 0x06001D31 RID: 7473 RVA: 0x000939E7 File Offset: 0x00091BE7
	// (set) Token: 0x06001D32 RID: 7474 RVA: 0x000939FB File Offset: 0x00091BFB
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

	// Token: 0x06001D33 RID: 7475 RVA: 0x00093A10 File Offset: 0x00091C10
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

	// Token: 0x06001D34 RID: 7476 RVA: 0x00093AB0 File Offset: 0x00091CB0
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

	// Token: 0x06001D35 RID: 7477 RVA: 0x00093B08 File Offset: 0x00091D08
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

	// Token: 0x06001D36 RID: 7478 RVA: 0x00093B83 File Offset: 0x00091D83
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "发送动画通知广播给主控角色";
	}

	// Token: 0x06001D37 RID: 7479 RVA: 0x00093B8A File Offset: 0x00091D8A
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifySendGamePlayEventToRole._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySendGamePlayEventToRole.TsAnimNotifySendGamePlayEventToRole_C");
		}
		return TsAnimNotifySendGamePlayEventToRole._ClassPtr;
	}

	// Token: 0x06001D38 RID: 7480 RVA: 0x00093BB0 File Offset: 0x00091DB0
	public TsAnimNotifySendGamePlayEventToRole() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySendGamePlayEventToRole.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001D39 RID: 7481 RVA: 0x00093BD8 File Offset: 0x00091DD8
	[NullableContext(1)]
	public TsAnimNotifySendGamePlayEventToRole(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySendGamePlayEventToRole.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001D3A RID: 7482 RVA: 0x00093C0B File Offset: 0x00091E0B
	protected TsAnimNotifySendGamePlayEventToRole(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001D3B RID: 7483 RVA: 0x00093C14 File Offset: 0x00091E14
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001D3C RID: 7484 RVA: 0x00093C47 File Offset: 0x00091E47
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001236 RID: 4662
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySendGamePlayEventToRole.TsAnimNotifySendGamePlayEventToRole_C";

	// Token: 0x04001237 RID: 4663
	private static IntPtr _ClassPtr;

	// Token: 0x04001238 RID: 4664
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001239 RID: 4665
	private static int __PropertyOffset_事件Tag;
}

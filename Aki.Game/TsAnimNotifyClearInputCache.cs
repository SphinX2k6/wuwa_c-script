using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001A8 RID: 424
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyClearInputCache.TsAnimNotifyClearInputCache_C")]
public class TsAnimNotifyClearInputCache : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000459 RID: 1113
	// (get) Token: 0x06001AD7 RID: 6871 RVA: 0x0008B6E3 File Offset: 0x000898E3
	// (set) Token: 0x06001AD8 RID: 6872 RVA: 0x0008B6F3 File Offset: 0x000898F3
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EInputAction InputAction
	{
		get
		{
			return (EInputAction)(*(base.NativePtr + (IntPtr)TsAnimNotifyClearInputCache.__PropertyOffset_InputAction));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyClearInputCache.__PropertyOffset_InputAction) = (byte)value;
		}
	}

	// Token: 0x1700045A RID: 1114
	// (get) Token: 0x06001AD9 RID: 6873 RVA: 0x0008B704 File Offset: 0x00089904
	// (set) Token: 0x06001ADA RID: 6874 RVA: 0x0008B714 File Offset: 0x00089914
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EInputState InputState
	{
		get
		{
			return (EInputState)(*(base.NativePtr + (IntPtr)TsAnimNotifyClearInputCache.__PropertyOffset_InputState));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyClearInputCache.__PropertyOffset_InputState) = (byte)value;
		}
	}

	// Token: 0x06001ADB RID: 6875 RVA: 0x0008B728 File Offset: 0x00089928
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

	// Token: 0x06001ADC RID: 6876 RVA: 0x0008B7C8 File Offset: 0x000899C8
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			CharacterInputComponent component = tsBaseCharacter.CharacterActorComponent.Entity.GetComponent<CharacterInputComponent>();
			if (component != null)
			{
				component.ClearInputCache((int)this.InputAction, this.InputState);
			}
		}
		return true;
	}

	// Token: 0x06001ADD RID: 6877 RVA: 0x0008B80C File Offset: 0x00089A0C
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

	// Token: 0x06001ADE RID: 6878 RVA: 0x0008B887 File Offset: 0x00089A87
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "清除角色所有输入缓存";
	}

	// Token: 0x06001ADF RID: 6879 RVA: 0x0008B88E File Offset: 0x00089A8E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyClearInputCache._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyClearInputCache.TsAnimNotifyClearInputCache_C");
		}
		return TsAnimNotifyClearInputCache._ClassPtr;
	}

	// Token: 0x06001AE0 RID: 6880 RVA: 0x0008B8B4 File Offset: 0x00089AB4
	public TsAnimNotifyClearInputCache() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyClearInputCache.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001AE1 RID: 6881 RVA: 0x0008B8DC File Offset: 0x00089ADC
	[NullableContext(1)]
	public TsAnimNotifyClearInputCache(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyClearInputCache.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001AE2 RID: 6882 RVA: 0x0008B90F File Offset: 0x00089B0F
	protected TsAnimNotifyClearInputCache(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001AE3 RID: 6883 RVA: 0x0008B918 File Offset: 0x00089B18
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001AE4 RID: 6884 RVA: 0x0008B94B File Offset: 0x00089B4B
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001150 RID: 4432
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyClearInputCache.TsAnimNotifyClearInputCache_C";

	// Token: 0x04001151 RID: 4433
	private static IntPtr _ClassPtr;

	// Token: 0x04001152 RID: 4434
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001153 RID: 4435
	private static int __PropertyOffset_InputAction;

	// Token: 0x04001154 RID: 4436
	private static int __PropertyOffset_InputState;
}

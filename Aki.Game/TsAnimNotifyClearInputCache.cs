using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001AC RID: 428
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyClearInputCache.TsAnimNotifyClearInputCache_C")]
public class TsAnimNotifyClearInputCache : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700047B RID: 1147
	// (get) Token: 0x06001B74 RID: 7028 RVA: 0x00091E33 File Offset: 0x00090033
	// (set) Token: 0x06001B75 RID: 7029 RVA: 0x00091E43 File Offset: 0x00090043
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

	// Token: 0x1700047C RID: 1148
	// (get) Token: 0x06001B76 RID: 7030 RVA: 0x00091E54 File Offset: 0x00090054
	// (set) Token: 0x06001B77 RID: 7031 RVA: 0x00091E64 File Offset: 0x00090064
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

	// Token: 0x06001B78 RID: 7032 RVA: 0x00091E78 File Offset: 0x00090078
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyClearInputCache) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyClearInputCache.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001B79 RID: 7033 RVA: 0x00091F30 File Offset: 0x00090130
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

	// Token: 0x06001B7A RID: 7034 RVA: 0x00091F74 File Offset: 0x00090174
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyClearInputCache) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyClearInputCache.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001B7B RID: 7035 RVA: 0x00092004 File Offset: 0x00090204
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "清除角色所有输入缓存";
	}

	// Token: 0x06001B7C RID: 7036 RVA: 0x0009200B File Offset: 0x0009020B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyClearInputCache._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyClearInputCache.TsAnimNotifyClearInputCache_C");
		}
		return TsAnimNotifyClearInputCache._ClassPtr;
	}

	// Token: 0x06001B7D RID: 7037 RVA: 0x00092030 File Offset: 0x00090230
	public TsAnimNotifyClearInputCache() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyClearInputCache.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001B7E RID: 7038 RVA: 0x00092058 File Offset: 0x00090258
	[NullableContext(1)]
	public TsAnimNotifyClearInputCache(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyClearInputCache.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001B7F RID: 7039 RVA: 0x0009208B File Offset: 0x0009028B
	protected TsAnimNotifyClearInputCache(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001B80 RID: 7040 RVA: 0x00092094 File Offset: 0x00090294
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001B81 RID: 7041 RVA: 0x000920C7 File Offset: 0x000902C7
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001193 RID: 4499
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyClearInputCache.TsAnimNotifyClearInputCache_C";

	// Token: 0x04001194 RID: 4500
	private static IntPtr _ClassPtr;

	// Token: 0x04001195 RID: 4501
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001196 RID: 4502
	private static int __PropertyOffset_InputAction;

	// Token: 0x04001197 RID: 4503
	private static int __PropertyOffset_InputState;
}

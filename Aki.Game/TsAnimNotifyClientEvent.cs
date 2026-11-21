using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001AD RID: 429
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyClientEvent.TsAnimNotifyClientEvent_C")]
public class TsAnimNotifyClientEvent : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700047D RID: 1149
	// (get) Token: 0x06001B82 RID: 7042 RVA: 0x000920DB File Offset: 0x000902DB
	// (set) Token: 0x06001B83 RID: 7043 RVA: 0x000920EF File Offset: 0x000902EF
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FGameplayTag GameplayTag
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyClientEvent.__PropertyOffset_GameplayTag);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyClientEvent.__PropertyOffset_GameplayTag) = value;
		}
	}

	// Token: 0x06001B84 RID: 7044 RVA: 0x00092104 File Offset: 0x00090304
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyClientEvent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyClientEvent.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001B85 RID: 7045 RVA: 0x000921BC File Offset: 0x000903BC
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		FGameplayTag gameplayTag = this.GameplayTag;
		EventSystem.Instance.Emit<FGameplayTag>(EEventName.CheckClientEvent, this.GameplayTag);
		return true;
	}

	// Token: 0x06001B86 RID: 7046 RVA: 0x000921E8 File Offset: 0x000903E8
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyClientEvent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyClientEvent.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001B87 RID: 7047 RVA: 0x00092278 File Offset: 0x00090478
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "客户端全局自定义事件";
	}

	// Token: 0x06001B88 RID: 7048 RVA: 0x0009227F File Offset: 0x0009047F
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyClientEvent._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyClientEvent.TsAnimNotifyClientEvent_C");
		}
		return TsAnimNotifyClientEvent._ClassPtr;
	}

	// Token: 0x06001B89 RID: 7049 RVA: 0x000922A4 File Offset: 0x000904A4
	public TsAnimNotifyClientEvent() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyClientEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001B8A RID: 7050 RVA: 0x000922CC File Offset: 0x000904CC
	[NullableContext(1)]
	public TsAnimNotifyClientEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyClientEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001B8B RID: 7051 RVA: 0x000922FF File Offset: 0x000904FF
	protected TsAnimNotifyClientEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001B8C RID: 7052 RVA: 0x00092308 File Offset: 0x00090508
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001B8D RID: 7053 RVA: 0x0009233B File Offset: 0x0009053B
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001198 RID: 4504
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyClientEvent.TsAnimNotifyClientEvent_C";

	// Token: 0x04001199 RID: 4505
	private static IntPtr _ClassPtr;

	// Token: 0x0400119A RID: 4506
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400119B RID: 4507
	private static int __PropertyOffset_GameplayTag;
}

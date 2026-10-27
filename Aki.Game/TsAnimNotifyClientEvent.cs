using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001A9 RID: 425
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyClientEvent.TsAnimNotifyClientEvent_C")]
public class TsAnimNotifyClientEvent : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700045B RID: 1115
	// (get) Token: 0x06001AE5 RID: 6885 RVA: 0x0008B95F File Offset: 0x00089B5F
	// (set) Token: 0x06001AE6 RID: 6886 RVA: 0x0008B973 File Offset: 0x00089B73
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

	// Token: 0x06001AE7 RID: 6887 RVA: 0x0008B988 File Offset: 0x00089B88
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

	// Token: 0x06001AE8 RID: 6888 RVA: 0x0008BA28 File Offset: 0x00089C28
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		FGameplayTag gameplayTag = this.GameplayTag;
		EventSystem.Instance.Emit<FGameplayTag>(EEventName.CheckClientEvent, this.GameplayTag);
		return true;
	}

	// Token: 0x06001AE9 RID: 6889 RVA: 0x0008BA54 File Offset: 0x00089C54
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

	// Token: 0x06001AEA RID: 6890 RVA: 0x0008BACF File Offset: 0x00089CCF
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "客户端全局自定义事件";
	}

	// Token: 0x06001AEB RID: 6891 RVA: 0x0008BAD6 File Offset: 0x00089CD6
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyClientEvent._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyClientEvent.TsAnimNotifyClientEvent_C");
		}
		return TsAnimNotifyClientEvent._ClassPtr;
	}

	// Token: 0x06001AEC RID: 6892 RVA: 0x0008BAFC File Offset: 0x00089CFC
	public TsAnimNotifyClientEvent() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyClientEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001AED RID: 6893 RVA: 0x0008BB24 File Offset: 0x00089D24
	[NullableContext(1)]
	public TsAnimNotifyClientEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyClientEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001AEE RID: 6894 RVA: 0x0008BB57 File Offset: 0x00089D57
	protected TsAnimNotifyClientEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001AEF RID: 6895 RVA: 0x0008BB60 File Offset: 0x00089D60
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001AF0 RID: 6896 RVA: 0x0008BB93 File Offset: 0x00089D93
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001155 RID: 4437
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyClientEvent.TsAnimNotifyClientEvent_C";

	// Token: 0x04001156 RID: 4438
	private static IntPtr _ClassPtr;

	// Token: 0x04001157 RID: 4439
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001158 RID: 4440
	private static int __PropertyOffset_GameplayTag;
}

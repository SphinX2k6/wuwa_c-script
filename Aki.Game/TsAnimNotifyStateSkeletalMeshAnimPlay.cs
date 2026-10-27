using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000173 RID: 371
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSkeletalMeshAnimPlay.TsAnimNotifyStateSkeletalMeshAnimPlay_C")]
public class TsAnimNotifyStateSkeletalMeshAnimPlay : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170003D2 RID: 978
	// (get) Token: 0x06001770 RID: 6000 RVA: 0x0007E36B File Offset: 0x0007C56B
	// (set) Token: 0x06001771 RID: 6001 RVA: 0x0007E37F File Offset: 0x0007C57F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName Tag
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateSkeletalMeshAnimPlay.__PropertyOffset_Tag);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateSkeletalMeshAnimPlay.__PropertyOffset_Tag) = value;
		}
	}

	// Token: 0x170003D3 RID: 979
	// (get) Token: 0x06001772 RID: 6002 RVA: 0x0007E394 File Offset: 0x0007C594
	// (set) Token: 0x06001773 RID: 6003 RVA: 0x0007E3A8 File Offset: 0x0007C5A8
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UAnimMontage 动画资产
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UAnimMontage>(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateSkeletalMeshAnimPlay.__PropertyOffset_动画资产);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateSkeletalMeshAnimPlay.__PropertyOffset_动画资产, value);
		}
	}

	// Token: 0x06001774 RID: 6004 RVA: 0x0007E3C0 File Offset: 0x0007C5C0
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

	// Token: 0x06001775 RID: 6005 RVA: 0x0007E468 File Offset: 0x0007C668
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		TArray<UActorComponent> componentsByTag = meshComp.GetOwner().GetComponentsByTag(USkeletalMeshComponent.StaticClass(), this.Tag);
		if (componentsByTag.Num() == 0)
		{
			return false;
		}
		USkeletalMeshComponent uskeletalMeshComponent = componentsByTag.Get(0) as USkeletalMeshComponent;
		if (uskeletalMeshComponent != null && uskeletalMeshComponent.IsValid())
		{
			uskeletalMeshComponent.SetHiddenInGame(false, false);
			uskeletalMeshComponent.PlayAnimation(this.动画资产, false);
			return true;
		}
		return false;
	}

	// Token: 0x06001776 RID: 6006 RVA: 0x0007E4CC File Offset: 0x0007C6CC
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

	// Token: 0x06001777 RID: 6007 RVA: 0x0007E56C File Offset: 0x0007C76C
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TArray<UActorComponent> componentsByTag = meshComp.GetOwner().GetComponentsByTag(USkeletalMeshComponent.StaticClass(), this.Tag);
		if (componentsByTag.Num() == 0)
		{
			return false;
		}
		USkeletalMeshComponent uskeletalMeshComponent = componentsByTag.Get(0) as USkeletalMeshComponent;
		if (uskeletalMeshComponent != null && uskeletalMeshComponent.IsValid())
		{
			uskeletalMeshComponent.SetHiddenInGame(true, false);
			uskeletalMeshComponent.Stop();
			return true;
		}
		return false;
	}

	// Token: 0x06001778 RID: 6008 RVA: 0x0007E5C8 File Offset: 0x0007C7C8
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

	// Token: 0x06001779 RID: 6009 RVA: 0x0007E643 File Offset: 0x0007C843
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "临时播放特定Mesh的动画";
	}

	// Token: 0x0600177A RID: 6010 RVA: 0x0007E64A File Offset: 0x0007C84A
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateSkeletalMeshAnimPlay._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSkeletalMeshAnimPlay.TsAnimNotifyStateSkeletalMeshAnimPlay_C");
		}
		return TsAnimNotifyStateSkeletalMeshAnimPlay._ClassPtr;
	}

	// Token: 0x0600177B RID: 6011 RVA: 0x0007E670 File Offset: 0x0007C870
	public TsAnimNotifyStateSkeletalMeshAnimPlay() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSkeletalMeshAnimPlay.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600177C RID: 6012 RVA: 0x0007E698 File Offset: 0x0007C898
	[NullableContext(1)]
	public TsAnimNotifyStateSkeletalMeshAnimPlay(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSkeletalMeshAnimPlay.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600177D RID: 6013 RVA: 0x0007E6CB File Offset: 0x0007C8CB
	protected TsAnimNotifyStateSkeletalMeshAnimPlay(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600177E RID: 6014 RVA: 0x0007E6D4 File Offset: 0x0007C8D4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600177F RID: 6015 RVA: 0x0007E710 File Offset: 0x0007C910
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001780 RID: 6016 RVA: 0x0007E743 File Offset: 0x0007C943
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000FEA RID: 4074
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSkeletalMeshAnimPlay.TsAnimNotifyStateSkeletalMeshAnimPlay_C";

	// Token: 0x04000FEB RID: 4075
	private static IntPtr _ClassPtr;

	// Token: 0x04000FEC RID: 4076
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000FED RID: 4077
	private static int __PropertyOffset_Tag;

	// Token: 0x04000FEE RID: 4078
	private static int __PropertyOffset_动画资产;
}

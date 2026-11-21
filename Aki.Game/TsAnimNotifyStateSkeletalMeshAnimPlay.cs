using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000177 RID: 375
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSkeletalMeshAnimPlay.TsAnimNotifyStateSkeletalMeshAnimPlay_C")]
public class TsAnimNotifyStateSkeletalMeshAnimPlay : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170003F4 RID: 1012
	// (get) Token: 0x0600180D RID: 6157 RVA: 0x00084057 File Offset: 0x00082257
	// (set) Token: 0x0600180E RID: 6158 RVA: 0x0008406B File Offset: 0x0008226B
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

	// Token: 0x170003F5 RID: 1013
	// (get) Token: 0x0600180F RID: 6159 RVA: 0x00084080 File Offset: 0x00082280
	// (set) Token: 0x06001810 RID: 6160 RVA: 0x00084094 File Offset: 0x00082294
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

	// Token: 0x06001811 RID: 6161 RVA: 0x000840AC File Offset: 0x000822AC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSkeletalMeshAnimPlay) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateSkeletalMeshAnimPlay.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyBegin_Implementation(meshComp, animation, totalDuration);
		}
		UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		ptr->TotalDuration = totalDuration;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06001812 RID: 6162 RVA: 0x0008416C File Offset: 0x0008236C
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

	// Token: 0x06001813 RID: 6163 RVA: 0x000841D0 File Offset: 0x000823D0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSkeletalMeshAnimPlay) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateSkeletalMeshAnimPlay.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyEnd_Implementation(meshComp, animation);
		}
		UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06001814 RID: 6164 RVA: 0x00084288 File Offset: 0x00082488
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

	// Token: 0x06001815 RID: 6165 RVA: 0x000842E4 File Offset: 0x000824E4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSkeletalMeshAnimPlay) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateSkeletalMeshAnimPlay.StaticClass(), out intPtr, out num))
		{
			return this.GetNotifyName_Implementation();
		}
		UAnimNotifyState.__GetNotifyName_FunctionParams* ptr = stackalloc UAnimNotifyState.__GetNotifyName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UAnimNotifyState.__GetNotifyName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x06001816 RID: 6166 RVA: 0x00084374 File Offset: 0x00082574
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "临时播放特定Mesh的动画";
	}

	// Token: 0x06001817 RID: 6167 RVA: 0x0008437B File Offset: 0x0008257B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateSkeletalMeshAnimPlay._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSkeletalMeshAnimPlay.TsAnimNotifyStateSkeletalMeshAnimPlay_C");
		}
		return TsAnimNotifyStateSkeletalMeshAnimPlay._ClassPtr;
	}

	// Token: 0x06001818 RID: 6168 RVA: 0x000843A0 File Offset: 0x000825A0
	public TsAnimNotifyStateSkeletalMeshAnimPlay() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSkeletalMeshAnimPlay.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001819 RID: 6169 RVA: 0x000843C8 File Offset: 0x000825C8
	[NullableContext(1)]
	public TsAnimNotifyStateSkeletalMeshAnimPlay(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSkeletalMeshAnimPlay.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600181A RID: 6170 RVA: 0x000843FB File Offset: 0x000825FB
	protected TsAnimNotifyStateSkeletalMeshAnimPlay(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600181B RID: 6171 RVA: 0x00084404 File Offset: 0x00082604
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600181C RID: 6172 RVA: 0x00084440 File Offset: 0x00082640
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600181D RID: 6173 RVA: 0x00084473 File Offset: 0x00082673
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400102D RID: 4141
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSkeletalMeshAnimPlay.TsAnimNotifyStateSkeletalMeshAnimPlay_C";

	// Token: 0x0400102E RID: 4142
	private static IntPtr _ClassPtr;

	// Token: 0x0400102F RID: 4143
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001030 RID: 4144
	private static int __PropertyOffset_Tag;

	// Token: 0x04001031 RID: 4145
	private static int __PropertyOffset_动画资产;
}

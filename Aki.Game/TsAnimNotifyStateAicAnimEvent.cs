using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.AI.AIFunctionCommon;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200010A RID: 266
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAicAnimEvent.TsAnimNotifyStateAicAnimEvent_C")]
public class TsAnimNotifyStateAicAnimEvent : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000282 RID: 642
	// (get) Token: 0x06000F94 RID: 3988 RVA: 0x0005B007 File Offset: 0x00059207
	// (set) Token: 0x06000F95 RID: 3989 RVA: 0x0005B017 File Offset: 0x00059217
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool bCallBegin
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateAicAnimEvent.__PropertyOffset_bCallBegin) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateAicAnimEvent.__PropertyOffset_bCallBegin) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000283 RID: 643
	// (get) Token: 0x06000F96 RID: 3990 RVA: 0x0005B028 File Offset: 0x00059228
	// (set) Token: 0x06000F97 RID: 3991 RVA: 0x0005B038 File Offset: 0x00059238
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool bCallEnd
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateAicAnimEvent.__PropertyOffset_bCallEnd) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateAicAnimEvent.__PropertyOffset_bCallEnd) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000284 RID: 644
	// (get) Token: 0x06000F98 RID: 3992 RVA: 0x0005B049 File Offset: 0x00059249
	// (set) Token: 0x06000F99 RID: 3993 RVA: 0x0005B05D File Offset: 0x0005925D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName Name
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateAicAnimEvent.__PropertyOffset_Name);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateAicAnimEvent.__PropertyOffset_Name) = value;
		}
	}

	// Token: 0x06000F9A RID: 3994 RVA: 0x0005B074 File Offset: 0x00059274
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateAicAnimEvent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateAicAnimEvent.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000F9B RID: 3995 RVA: 0x0005B134 File Offset: 0x00059334
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		if (this.bCallBegin && owner is TsBaseCharacter)
		{
			AController controller = (owner as TsBaseCharacter).GetController();
			if (controller is AIC_AICommon_C)
			{
				(controller as AIC_AICommon_C).AicTriggerEvent(this.Name);
			}
		}
		return true;
	}

	// Token: 0x06000F9C RID: 3996 RVA: 0x0005B180 File Offset: 0x00059380
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateAicAnimEvent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateAicAnimEvent.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000F9D RID: 3997 RVA: 0x0005B238 File Offset: 0x00059438
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (this.bCallEnd && owner is TsBaseCharacter)
		{
			AController controller = (owner as TsBaseCharacter).GetController();
			if (controller is AIC_AICommon_C)
			{
				(controller as AIC_AICommon_C).AicTriggerEvent(this.Name);
			}
		}
		return true;
	}

	// Token: 0x06000F9E RID: 3998 RVA: 0x0005B284 File Offset: 0x00059484
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateAicAnimEvent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateAicAnimEvent.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000F9F RID: 3999 RVA: 0x0005B314 File Offset: 0x00059514
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "AIC动画通知事件";
	}

	// Token: 0x06000FA0 RID: 4000 RVA: 0x0005B31B File Offset: 0x0005951B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateAicAnimEvent._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAicAnimEvent.TsAnimNotifyStateAicAnimEvent_C");
		}
		return TsAnimNotifyStateAicAnimEvent._ClassPtr;
	}

	// Token: 0x06000FA1 RID: 4001 RVA: 0x0005B340 File Offset: 0x00059540
	public TsAnimNotifyStateAicAnimEvent() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAicAnimEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000FA2 RID: 4002 RVA: 0x0005B368 File Offset: 0x00059568
	[NullableContext(1)]
	public TsAnimNotifyStateAicAnimEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAicAnimEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000FA3 RID: 4003 RVA: 0x0005B39B File Offset: 0x0005959B
	protected TsAnimNotifyStateAicAnimEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000FA4 RID: 4004 RVA: 0x0005B3A4 File Offset: 0x000595A4
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06000FA5 RID: 4005 RVA: 0x0005B3E0 File Offset: 0x000595E0
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000FA6 RID: 4006 RVA: 0x0005B413 File Offset: 0x00059613
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000C35 RID: 3125
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAicAnimEvent.TsAnimNotifyStateAicAnimEvent_C";

	// Token: 0x04000C36 RID: 3126
	private static IntPtr _ClassPtr;

	// Token: 0x04000C37 RID: 3127
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000C38 RID: 3128
	private static int __PropertyOffset_bCallBegin;

	// Token: 0x04000C39 RID: 3129
	private static int __PropertyOffset_bCallEnd;

	// Token: 0x04000C3A RID: 3130
	private static int __PropertyOffset_Name;
}

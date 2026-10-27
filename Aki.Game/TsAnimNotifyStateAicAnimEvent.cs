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
	// Token: 0x1700027F RID: 639
	// (get) Token: 0x06000F8E RID: 3982 RVA: 0x00059F47 File Offset: 0x00058147
	// (set) Token: 0x06000F8F RID: 3983 RVA: 0x00059F57 File Offset: 0x00058157
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

	// Token: 0x17000280 RID: 640
	// (get) Token: 0x06000F90 RID: 3984 RVA: 0x00059F68 File Offset: 0x00058168
	// (set) Token: 0x06000F91 RID: 3985 RVA: 0x00059F78 File Offset: 0x00058178
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

	// Token: 0x17000281 RID: 641
	// (get) Token: 0x06000F92 RID: 3986 RVA: 0x00059F89 File Offset: 0x00058189
	// (set) Token: 0x06000F93 RID: 3987 RVA: 0x00059F9D File Offset: 0x0005819D
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

	// Token: 0x06000F94 RID: 3988 RVA: 0x00059FB4 File Offset: 0x000581B4
	[NullableContext(2)]
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

	// Token: 0x06000F95 RID: 3989 RVA: 0x0005A05C File Offset: 0x0005825C
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

	// Token: 0x06000F96 RID: 3990 RVA: 0x0005A0A8 File Offset: 0x000582A8
	[NullableContext(2)]
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

	// Token: 0x06000F97 RID: 3991 RVA: 0x0005A148 File Offset: 0x00058348
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

	// Token: 0x06000F98 RID: 3992 RVA: 0x0005A194 File Offset: 0x00058394
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

	// Token: 0x06000F99 RID: 3993 RVA: 0x0005A20F File Offset: 0x0005840F
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "AIC动画通知事件";
	}

	// Token: 0x06000F9A RID: 3994 RVA: 0x0005A216 File Offset: 0x00058416
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateAicAnimEvent._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAicAnimEvent.TsAnimNotifyStateAicAnimEvent_C");
		}
		return TsAnimNotifyStateAicAnimEvent._ClassPtr;
	}

	// Token: 0x06000F9B RID: 3995 RVA: 0x0005A23C File Offset: 0x0005843C
	public TsAnimNotifyStateAicAnimEvent() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAicAnimEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000F9C RID: 3996 RVA: 0x0005A264 File Offset: 0x00058464
	[NullableContext(1)]
	public TsAnimNotifyStateAicAnimEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAicAnimEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000F9D RID: 3997 RVA: 0x0005A297 File Offset: 0x00058497
	protected TsAnimNotifyStateAicAnimEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000F9E RID: 3998 RVA: 0x0005A2A0 File Offset: 0x000584A0
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06000F9F RID: 3999 RVA: 0x0005A2DC File Offset: 0x000584DC
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000FA0 RID: 4000 RVA: 0x0005A30F File Offset: 0x0005850F
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000C2D RID: 3117
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAicAnimEvent.TsAnimNotifyStateAicAnimEvent_C";

	// Token: 0x04000C2E RID: 3118
	private static IntPtr _ClassPtr;

	// Token: 0x04000C2F RID: 3119
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000C30 RID: 3120
	private static int __PropertyOffset_bCallBegin;

	// Token: 0x04000C31 RID: 3121
	private static int __PropertyOffset_bCallEnd;

	// Token: 0x04000C32 RID: 3122
	private static int __PropertyOffset_Name;
}

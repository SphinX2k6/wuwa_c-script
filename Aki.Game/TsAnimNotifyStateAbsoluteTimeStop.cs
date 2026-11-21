using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000101 RID: 257
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAbsoluteTimeStop.TsAnimNotifyStateAbsoluteTimeStop_C")]
public class TsAnimNotifyStateAbsoluteTimeStop : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000270 RID: 624
	// (get) Token: 0x06000EFF RID: 3839 RVA: 0x000580D1 File Offset: 0x000562D1
	// (set) Token: 0x06000F00 RID: 3840 RVA: 0x000580E1 File Offset: 0x000562E1
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 副本计时停止
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateAbsoluteTimeStop.__PropertyOffset_副本计时停止) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateAbsoluteTimeStop.__PropertyOffset_副本计时停止) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000271 RID: 625
	// (get) Token: 0x06000F01 RID: 3841 RVA: 0x000580F2 File Offset: 0x000562F2
	// (set) Token: 0x06000F02 RID: 3842 RVA: 0x00058102 File Offset: 0x00056302
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 角色战斗机制停止
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateAbsoluteTimeStop.__PropertyOffset_角色战斗机制停止) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateAbsoluteTimeStop.__PropertyOffset_角色战斗机制停止) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000272 RID: 626
	// (get) Token: 0x06000F03 RID: 3843 RVA: 0x00058113 File Offset: 0x00056313
	// (set) Token: 0x06000F04 RID: 3844 RVA: 0x00058123 File Offset: 0x00056323
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 怪物战斗机制停止
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateAbsoluteTimeStop.__PropertyOffset_怪物战斗机制停止) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateAbsoluteTimeStop.__PropertyOffset_怪物战斗机制停止) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000273 RID: 627
	// (get) Token: 0x06000F05 RID: 3845 RVA: 0x00058134 File Offset: 0x00056334
	// (set) Token: 0x06000F06 RID: 3846 RVA: 0x00058144 File Offset: 0x00056344
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 是否冻结移动效果
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateAbsoluteTimeStop.__PropertyOffset_是否冻结移动效果) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateAbsoluteTimeStop.__PropertyOffset_是否冻结移动效果) = (value ? 1 : 0);
		}
	}

	// Token: 0x06000F07 RID: 3847 RVA: 0x00058158 File Offset: 0x00056358
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateAbsoluteTimeStop) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateAbsoluteTimeStop.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000F08 RID: 3848 RVA: 0x00058218 File Offset: 0x00056418
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		base.bRestartWithReplay = true;
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		SkillUtils.BeginAbsoluteTimeStop(tsBaseCharacter.EntityId, totalDuration, this.是否冻结移动效果, 0f);
		return true;
	}

	// Token: 0x06000F09 RID: 3849 RVA: 0x00058258 File Offset: 0x00056458
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateAbsoluteTimeStop) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateAbsoluteTimeStop.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000F0A RID: 3850 RVA: 0x00058310 File Offset: 0x00056510
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = ((meshComp != null) ? meshComp.GetOwner() : null) as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		SkillUtils.EndAbsoluteTimeStop(tsBaseCharacter.EntityId);
		return true;
	}

	// Token: 0x06000F0B RID: 3851 RVA: 0x00058340 File Offset: 0x00056540
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateAbsoluteTimeStop) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateAbsoluteTimeStop.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000F0C RID: 3852 RVA: 0x000583D0 File Offset: 0x000565D0
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "动画和子弹冻结";
	}

	// Token: 0x06000F0D RID: 3853 RVA: 0x000583D7 File Offset: 0x000565D7
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateAbsoluteTimeStop._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAbsoluteTimeStop.TsAnimNotifyStateAbsoluteTimeStop_C");
		}
		return TsAnimNotifyStateAbsoluteTimeStop._ClassPtr;
	}

	// Token: 0x06000F0E RID: 3854 RVA: 0x000583FC File Offset: 0x000565FC
	public TsAnimNotifyStateAbsoluteTimeStop() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAbsoluteTimeStop.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000F0F RID: 3855 RVA: 0x00058424 File Offset: 0x00056624
	[NullableContext(1)]
	public TsAnimNotifyStateAbsoluteTimeStop(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAbsoluteTimeStop.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000F10 RID: 3856 RVA: 0x00058457 File Offset: 0x00056657
	protected TsAnimNotifyStateAbsoluteTimeStop(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000F11 RID: 3857 RVA: 0x00058460 File Offset: 0x00056660
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06000F12 RID: 3858 RVA: 0x0005849C File Offset: 0x0005669C
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000F13 RID: 3859 RVA: 0x000584CF File Offset: 0x000566CF
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000BF6 RID: 3062
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAbsoluteTimeStop.TsAnimNotifyStateAbsoluteTimeStop_C";

	// Token: 0x04000BF7 RID: 3063
	private static IntPtr _ClassPtr;

	// Token: 0x04000BF8 RID: 3064
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000BF9 RID: 3065
	private static int __PropertyOffset_副本计时停止;

	// Token: 0x04000BFA RID: 3066
	private static int __PropertyOffset_角色战斗机制停止;

	// Token: 0x04000BFB RID: 3067
	private static int __PropertyOffset_怪物战斗机制停止;

	// Token: 0x04000BFC RID: 3068
	private static int __PropertyOffset_是否冻结移动效果;
}

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
	// Token: 0x1700026D RID: 621
	// (get) Token: 0x06000EF9 RID: 3833 RVA: 0x00057201 File Offset: 0x00055401
	// (set) Token: 0x06000EFA RID: 3834 RVA: 0x00057211 File Offset: 0x00055411
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

	// Token: 0x1700026E RID: 622
	// (get) Token: 0x06000EFB RID: 3835 RVA: 0x00057222 File Offset: 0x00055422
	// (set) Token: 0x06000EFC RID: 3836 RVA: 0x00057232 File Offset: 0x00055432
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

	// Token: 0x1700026F RID: 623
	// (get) Token: 0x06000EFD RID: 3837 RVA: 0x00057243 File Offset: 0x00055443
	// (set) Token: 0x06000EFE RID: 3838 RVA: 0x00057253 File Offset: 0x00055453
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

	// Token: 0x17000270 RID: 624
	// (get) Token: 0x06000EFF RID: 3839 RVA: 0x00057264 File Offset: 0x00055464
	// (set) Token: 0x06000F00 RID: 3840 RVA: 0x00057274 File Offset: 0x00055474
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

	// Token: 0x06000F01 RID: 3841 RVA: 0x00057288 File Offset: 0x00055488
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

	// Token: 0x06000F02 RID: 3842 RVA: 0x00057330 File Offset: 0x00055530
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

	// Token: 0x06000F03 RID: 3843 RVA: 0x00057370 File Offset: 0x00055570
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

	// Token: 0x06000F04 RID: 3844 RVA: 0x00057410 File Offset: 0x00055610
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

	// Token: 0x06000F05 RID: 3845 RVA: 0x00057440 File Offset: 0x00055640
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

	// Token: 0x06000F06 RID: 3846 RVA: 0x000574BB File Offset: 0x000556BB
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "动画和子弹冻结";
	}

	// Token: 0x06000F07 RID: 3847 RVA: 0x000574C2 File Offset: 0x000556C2
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateAbsoluteTimeStop._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAbsoluteTimeStop.TsAnimNotifyStateAbsoluteTimeStop_C");
		}
		return TsAnimNotifyStateAbsoluteTimeStop._ClassPtr;
	}

	// Token: 0x06000F08 RID: 3848 RVA: 0x000574E8 File Offset: 0x000556E8
	public TsAnimNotifyStateAbsoluteTimeStop() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAbsoluteTimeStop.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000F09 RID: 3849 RVA: 0x00057510 File Offset: 0x00055710
	[NullableContext(1)]
	public TsAnimNotifyStateAbsoluteTimeStop(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAbsoluteTimeStop.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000F0A RID: 3850 RVA: 0x00057543 File Offset: 0x00055743
	protected TsAnimNotifyStateAbsoluteTimeStop(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000F0B RID: 3851 RVA: 0x0005754C File Offset: 0x0005574C
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06000F0C RID: 3852 RVA: 0x00057588 File Offset: 0x00055788
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000F0D RID: 3853 RVA: 0x000575BB File Offset: 0x000557BB
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000BEE RID: 3054
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAbsoluteTimeStop.TsAnimNotifyStateAbsoluteTimeStop_C";

	// Token: 0x04000BEF RID: 3055
	private static IntPtr _ClassPtr;

	// Token: 0x04000BF0 RID: 3056
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000BF1 RID: 3057
	private static int __PropertyOffset_副本计时停止;

	// Token: 0x04000BF2 RID: 3058
	private static int __PropertyOffset_角色战斗机制停止;

	// Token: 0x04000BF3 RID: 3059
	private static int __PropertyOffset_怪物战斗机制停止;

	// Token: 0x04000BF4 RID: 3060
	private static int __PropertyOffset_是否冻结移动效果;
}

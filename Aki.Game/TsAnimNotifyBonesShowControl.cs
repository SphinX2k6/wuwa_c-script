using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000197 RID: 407
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBonesShowControl.TsAnimNotifyBonesShowControl_C")]
public class TsAnimNotifyBonesShowControl : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000434 RID: 1076
	// (get) Token: 0x060019E7 RID: 6631 RVA: 0x000885EB File Offset: 0x000867EB
	// (set) Token: 0x060019E8 RID: 6632 RVA: 0x000885FF File Offset: 0x000867FF
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName BoneName
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyBonesShowControl.__PropertyOffset_BoneName);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyBonesShowControl.__PropertyOffset_BoneName) = value;
		}
	}

	// Token: 0x17000435 RID: 1077
	// (get) Token: 0x060019E9 RID: 6633 RVA: 0x00088614 File Offset: 0x00086814
	// (set) Token: 0x060019EA RID: 6634 RVA: 0x00088624 File Offset: 0x00086824
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool Show
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyBonesShowControl.__PropertyOffset_Show) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyBonesShowControl.__PropertyOffset_Show) = (value ? 1 : 0);
		}
	}

	// Token: 0x060019EB RID: 6635 RVA: 0x00088638 File Offset: 0x00086838
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

	// Token: 0x060019EC RID: 6636 RVA: 0x000886D7 File Offset: 0x000868D7
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		if (meshComp.IsBoneHiddenByName(this.BoneName) == this.Show)
		{
			if (this.Show)
			{
				meshComp.UnHideBoneByName(this.BoneName);
			}
			else
			{
				meshComp.HideBoneByName(this.BoneName, EPhysBodyOp.PBO_None);
			}
		}
		return true;
	}

	// Token: 0x060019ED RID: 6637 RVA: 0x00088714 File Offset: 0x00086914
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

	// Token: 0x060019EE RID: 6638 RVA: 0x0008878F File Offset: 0x0008698F
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "控制骨骼显隐";
	}

	// Token: 0x060019EF RID: 6639 RVA: 0x00088796 File Offset: 0x00086996
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyBonesShowControl._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBonesShowControl.TsAnimNotifyBonesShowControl_C");
		}
		return TsAnimNotifyBonesShowControl._ClassPtr;
	}

	// Token: 0x060019F0 RID: 6640 RVA: 0x000887BC File Offset: 0x000869BC
	public TsAnimNotifyBonesShowControl() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyBonesShowControl.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060019F1 RID: 6641 RVA: 0x000887E4 File Offset: 0x000869E4
	[NullableContext(1)]
	public TsAnimNotifyBonesShowControl(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyBonesShowControl.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060019F2 RID: 6642 RVA: 0x00088817 File Offset: 0x00086A17
	protected TsAnimNotifyBonesShowControl(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060019F3 RID: 6643 RVA: 0x00088820 File Offset: 0x00086A20
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060019F4 RID: 6644 RVA: 0x00088853 File Offset: 0x00086A53
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040010F0 RID: 4336
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBonesShowControl.TsAnimNotifyBonesShowControl_C";

	// Token: 0x040010F1 RID: 4337
	private static IntPtr _ClassPtr;

	// Token: 0x040010F2 RID: 4338
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040010F3 RID: 4339
	private static int __PropertyOffset_BoneName;

	// Token: 0x040010F4 RID: 4340
	private static int __PropertyOffset_Show;
}

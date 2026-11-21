using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200019B RID: 411
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBonesShowControl.TsAnimNotifyBonesShowControl_C")]
public class TsAnimNotifyBonesShowControl : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000456 RID: 1110
	// (get) Token: 0x06001A84 RID: 6788 RVA: 0x0008EAA7 File Offset: 0x0008CCA7
	// (set) Token: 0x06001A85 RID: 6789 RVA: 0x0008EABB File Offset: 0x0008CCBB
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

	// Token: 0x17000457 RID: 1111
	// (get) Token: 0x06001A86 RID: 6790 RVA: 0x0008EAD0 File Offset: 0x0008CCD0
	// (set) Token: 0x06001A87 RID: 6791 RVA: 0x0008EAE0 File Offset: 0x0008CCE0
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

	// Token: 0x06001A88 RID: 6792 RVA: 0x0008EAF4 File Offset: 0x0008CCF4
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyBonesShowControl) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyBonesShowControl.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001A89 RID: 6793 RVA: 0x0008EBAA File Offset: 0x0008CDAA
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

	// Token: 0x06001A8A RID: 6794 RVA: 0x0008EBE4 File Offset: 0x0008CDE4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyBonesShowControl) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyBonesShowControl.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001A8B RID: 6795 RVA: 0x0008EC74 File Offset: 0x0008CE74
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "控制骨骼显隐";
	}

	// Token: 0x06001A8C RID: 6796 RVA: 0x0008EC7B File Offset: 0x0008CE7B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyBonesShowControl._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBonesShowControl.TsAnimNotifyBonesShowControl_C");
		}
		return TsAnimNotifyBonesShowControl._ClassPtr;
	}

	// Token: 0x06001A8D RID: 6797 RVA: 0x0008ECA0 File Offset: 0x0008CEA0
	public TsAnimNotifyBonesShowControl() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyBonesShowControl.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001A8E RID: 6798 RVA: 0x0008ECC8 File Offset: 0x0008CEC8
	[NullableContext(1)]
	public TsAnimNotifyBonesShowControl(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyBonesShowControl.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001A8F RID: 6799 RVA: 0x0008ECFB File Offset: 0x0008CEFB
	protected TsAnimNotifyBonesShowControl(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001A90 RID: 6800 RVA: 0x0008ED04 File Offset: 0x0008CF04
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001A91 RID: 6801 RVA: 0x0008ED37 File Offset: 0x0008CF37
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001133 RID: 4403
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBonesShowControl.TsAnimNotifyBonesShowControl_C";

	// Token: 0x04001134 RID: 4404
	private static IntPtr _ClassPtr;

	// Token: 0x04001135 RID: 4405
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001136 RID: 4406
	private static int __PropertyOffset_BoneName;

	// Token: 0x04001137 RID: 4407
	private static int __PropertyOffset_Show;
}

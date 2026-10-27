using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000194 RID: 404
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBattleMessageBox.TsAnimNotifyBattleMessageBox_C")]
public class TsAnimNotifyBattleMessageBox : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700042F RID: 1071
	// (get) Token: 0x060019BF RID: 6591 RVA: 0x00087DBB File Offset: 0x00085FBB
	// (set) Token: 0x060019C0 RID: 6592 RVA: 0x00087DCB File Offset: 0x00085FCB
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int BoardId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyBattleMessageBox.__PropertyOffset_BoardId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyBattleMessageBox.__PropertyOffset_BoardId) = value;
		}
	}

	// Token: 0x060019C1 RID: 6593 RVA: 0x00087DDC File Offset: 0x00085FDC
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

	// Token: 0x060019C2 RID: 6594 RVA: 0x00087E7B File Offset: 0x0008607B
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		if (this.BoardId > 0)
		{
			SoundAreaPlayTipsController.Instance.OpenSoundAreaPlayTips(this.BoardId);
		}
		return true;
	}

	// Token: 0x060019C3 RID: 6595 RVA: 0x00087E98 File Offset: 0x00086098
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

	// Token: 0x060019C4 RID: 6596 RVA: 0x00087F13 File Offset: 0x00086113
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "战斗弹窗";
	}

	// Token: 0x060019C5 RID: 6597 RVA: 0x00087F1A File Offset: 0x0008611A
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyBattleMessageBox._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBattleMessageBox.TsAnimNotifyBattleMessageBox_C");
		}
		return TsAnimNotifyBattleMessageBox._ClassPtr;
	}

	// Token: 0x060019C6 RID: 6598 RVA: 0x00087F40 File Offset: 0x00086140
	public TsAnimNotifyBattleMessageBox() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyBattleMessageBox.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060019C7 RID: 6599 RVA: 0x00087F68 File Offset: 0x00086168
	[NullableContext(1)]
	public TsAnimNotifyBattleMessageBox(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyBattleMessageBox.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060019C8 RID: 6600 RVA: 0x00087F9B File Offset: 0x0008619B
	protected TsAnimNotifyBattleMessageBox(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060019C9 RID: 6601 RVA: 0x00087FA4 File Offset: 0x000861A4
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060019CA RID: 6602 RVA: 0x00087FD7 File Offset: 0x000861D7
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040010E2 RID: 4322
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBattleMessageBox.TsAnimNotifyBattleMessageBox_C";

	// Token: 0x040010E3 RID: 4323
	private static IntPtr _ClassPtr;

	// Token: 0x040010E4 RID: 4324
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040010E5 RID: 4325
	private static int __PropertyOffset_BoardId;
}

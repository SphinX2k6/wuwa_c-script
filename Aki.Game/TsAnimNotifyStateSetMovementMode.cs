using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000168 RID: 360
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetMovementMode.TsAnimNotifyStateSetMovementMode_C")]
public class TsAnimNotifyStateSetMovementMode : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170003B7 RID: 951
	// (get) Token: 0x060016AF RID: 5807 RVA: 0x0007B503 File Offset: 0x00079703
	// (set) Token: 0x060016B0 RID: 5808 RVA: 0x0007B517 File Offset: 0x00079717
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe TEnumAsByte<EMovementMode> EnterMode
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateSetMovementMode.__PropertyOffset_EnterMode);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateSetMovementMode.__PropertyOffset_EnterMode) = value;
		}
	}

	// Token: 0x170003B8 RID: 952
	// (get) Token: 0x060016B1 RID: 5809 RVA: 0x0007B52C File Offset: 0x0007972C
	// (set) Token: 0x060016B2 RID: 5810 RVA: 0x0007B53C File Offset: 0x0007973C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float EnterCustomMode
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateSetMovementMode.__PropertyOffset_EnterCustomMode);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateSetMovementMode.__PropertyOffset_EnterCustomMode) = value;
		}
	}

	// Token: 0x170003B9 RID: 953
	// (get) Token: 0x060016B3 RID: 5811 RVA: 0x0007B54D File Offset: 0x0007974D
	// (set) Token: 0x060016B4 RID: 5812 RVA: 0x0007B561 File Offset: 0x00079761
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe TEnumAsByte<EMovementMode> LeaveMode
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateSetMovementMode.__PropertyOffset_LeaveMode);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateSetMovementMode.__PropertyOffset_LeaveMode) = value;
		}
	}

	// Token: 0x170003BA RID: 954
	// (get) Token: 0x060016B5 RID: 5813 RVA: 0x0007B576 File Offset: 0x00079776
	// (set) Token: 0x060016B6 RID: 5814 RVA: 0x0007B586 File Offset: 0x00079786
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int LeaveCustomMode
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateSetMovementMode.__PropertyOffset_LeaveCustomMode);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateSetMovementMode.__PropertyOffset_LeaveCustomMode) = value;
		}
	}

	// Token: 0x060016B7 RID: 5815 RVA: 0x0007B598 File Offset: 0x00079798
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

	// Token: 0x060016B8 RID: 5816 RVA: 0x0007B640 File Offset: 0x00079840
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		ACharacter acharacter = meshComp.GetOwner() as ACharacter;
		if (acharacter == null)
		{
			return false;
		}
		acharacter.CharacterMovement.SetMovementMode(this.EnterMode, (byte)this.EnterCustomMode);
		return true;
	}

	// Token: 0x060016B9 RID: 5817 RVA: 0x0007B67C File Offset: 0x0007987C
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

	// Token: 0x060016BA RID: 5818 RVA: 0x0007B71C File Offset: 0x0007991C
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		ACharacter acharacter = meshComp.GetOwner() as ACharacter;
		if (acharacter == null)
		{
			return false;
		}
		if (acharacter.CharacterMovement.MovementMode != this.EnterMode || (this.EnterMode == EMovementMode.MOVE_Custom && (int)acharacter.CharacterMovement.CustomMovementMode != this.LeaveCustomMode))
		{
			return false;
		}
		acharacter.CharacterMovement.SetMovementMode(this.LeaveMode, (byte)this.LeaveCustomMode);
		return true;
	}

	// Token: 0x060016BB RID: 5819 RVA: 0x0007B798 File Offset: 0x00079998
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

	// Token: 0x060016BC RID: 5820 RVA: 0x0007B813 File Offset: 0x00079A13
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "设置移动模式";
	}

	// Token: 0x060016BD RID: 5821 RVA: 0x0007B81A File Offset: 0x00079A1A
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateSetMovementMode._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetMovementMode.TsAnimNotifyStateSetMovementMode_C");
		}
		return TsAnimNotifyStateSetMovementMode._ClassPtr;
	}

	// Token: 0x060016BE RID: 5822 RVA: 0x0007B840 File Offset: 0x00079A40
	public TsAnimNotifyStateSetMovementMode() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSetMovementMode.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060016BF RID: 5823 RVA: 0x0007B868 File Offset: 0x00079A68
	[NullableContext(1)]
	public TsAnimNotifyStateSetMovementMode(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSetMovementMode.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060016C0 RID: 5824 RVA: 0x0007B89B File Offset: 0x00079A9B
	protected TsAnimNotifyStateSetMovementMode(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060016C1 RID: 5825 RVA: 0x0007B8A4 File Offset: 0x00079AA4
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060016C2 RID: 5826 RVA: 0x0007B8E0 File Offset: 0x00079AE0
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060016C3 RID: 5827 RVA: 0x0007B913 File Offset: 0x00079B13
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000FA8 RID: 4008
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetMovementMode.TsAnimNotifyStateSetMovementMode_C";

	// Token: 0x04000FA9 RID: 4009
	private static IntPtr _ClassPtr;

	// Token: 0x04000FAA RID: 4010
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000FAB RID: 4011
	private static int __PropertyOffset_EnterMode;

	// Token: 0x04000FAC RID: 4012
	private static int __PropertyOffset_EnterCustomMode;

	// Token: 0x04000FAD RID: 4013
	private static int __PropertyOffset_LeaveMode;

	// Token: 0x04000FAE RID: 4014
	private static int __PropertyOffset_LeaveCustomMode;
}

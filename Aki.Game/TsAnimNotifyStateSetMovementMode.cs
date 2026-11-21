using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200016C RID: 364
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetMovementMode.TsAnimNotifyStateSetMovementMode_C")]
public class TsAnimNotifyStateSetMovementMode : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170003D9 RID: 985
	// (get) Token: 0x0600174C RID: 5964 RVA: 0x00080F63 File Offset: 0x0007F163
	// (set) Token: 0x0600174D RID: 5965 RVA: 0x00080F77 File Offset: 0x0007F177
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

	// Token: 0x170003DA RID: 986
	// (get) Token: 0x0600174E RID: 5966 RVA: 0x00080F8C File Offset: 0x0007F18C
	// (set) Token: 0x0600174F RID: 5967 RVA: 0x00080F9C File Offset: 0x0007F19C
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

	// Token: 0x170003DB RID: 987
	// (get) Token: 0x06001750 RID: 5968 RVA: 0x00080FAD File Offset: 0x0007F1AD
	// (set) Token: 0x06001751 RID: 5969 RVA: 0x00080FC1 File Offset: 0x0007F1C1
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

	// Token: 0x170003DC RID: 988
	// (get) Token: 0x06001752 RID: 5970 RVA: 0x00080FD6 File Offset: 0x0007F1D6
	// (set) Token: 0x06001753 RID: 5971 RVA: 0x00080FE6 File Offset: 0x0007F1E6
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

	// Token: 0x06001754 RID: 5972 RVA: 0x00080FF8 File Offset: 0x0007F1F8
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSetMovementMode) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateSetMovementMode.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001755 RID: 5973 RVA: 0x000810B8 File Offset: 0x0007F2B8
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

	// Token: 0x06001756 RID: 5974 RVA: 0x000810F4 File Offset: 0x0007F2F4
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSetMovementMode) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateSetMovementMode.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001757 RID: 5975 RVA: 0x000811AC File Offset: 0x0007F3AC
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

	// Token: 0x06001758 RID: 5976 RVA: 0x00081228 File Offset: 0x0007F428
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSetMovementMode) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateSetMovementMode.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001759 RID: 5977 RVA: 0x000812B8 File Offset: 0x0007F4B8
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "设置移动模式";
	}

	// Token: 0x0600175A RID: 5978 RVA: 0x000812BF File Offset: 0x0007F4BF
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateSetMovementMode._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetMovementMode.TsAnimNotifyStateSetMovementMode_C");
		}
		return TsAnimNotifyStateSetMovementMode._ClassPtr;
	}

	// Token: 0x0600175B RID: 5979 RVA: 0x000812E4 File Offset: 0x0007F4E4
	public TsAnimNotifyStateSetMovementMode() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSetMovementMode.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600175C RID: 5980 RVA: 0x0008130C File Offset: 0x0007F50C
	[NullableContext(1)]
	public TsAnimNotifyStateSetMovementMode(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSetMovementMode.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600175D RID: 5981 RVA: 0x0008133F File Offset: 0x0007F53F
	protected TsAnimNotifyStateSetMovementMode(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600175E RID: 5982 RVA: 0x00081348 File Offset: 0x0007F548
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600175F RID: 5983 RVA: 0x00081384 File Offset: 0x0007F584
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001760 RID: 5984 RVA: 0x000813B7 File Offset: 0x0007F5B7
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000FEB RID: 4075
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetMovementMode.TsAnimNotifyStateSetMovementMode_C";

	// Token: 0x04000FEC RID: 4076
	private static IntPtr _ClassPtr;

	// Token: 0x04000FED RID: 4077
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000FEE RID: 4078
	private static int __PropertyOffset_EnterMode;

	// Token: 0x04000FEF RID: 4079
	private static int __PropertyOffset_EnterCustomMode;

	// Token: 0x04000FF0 RID: 4080
	private static int __PropertyOffset_LeaveMode;

	// Token: 0x04000FF1 RID: 4081
	private static int __PropertyOffset_LeaveCustomMode;
}

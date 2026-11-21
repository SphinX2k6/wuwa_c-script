using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000137 RID: 311
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateGoThrough.TsAnimNotifyStateGoThrough_C")]
public class TsAnimNotifyStateGoThrough : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000324 RID: 804
	// (get) Token: 0x06001310 RID: 4880 RVA: 0x0006CE7B File Offset: 0x0006B07B
	// (set) Token: 0x06001311 RID: 4881 RVA: 0x0006CE8B File Offset: 0x0006B08B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int FirstGoThroughPriority
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateGoThrough.__PropertyOffset_FirstGoThroughPriority);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateGoThrough.__PropertyOffset_FirstGoThroughPriority) = value;
		}
	}

	// Token: 0x17000325 RID: 805
	// (get) Token: 0x06001312 RID: 4882 RVA: 0x0006CE9C File Offset: 0x0006B09C
	// (set) Token: 0x06001313 RID: 4883 RVA: 0x0006CEAC File Offset: 0x0006B0AC
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int SecondHitPriority
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateGoThrough.__PropertyOffset_SecondHitPriority);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateGoThrough.__PropertyOffset_SecondHitPriority) = value;
		}
	}

	// Token: 0x06001314 RID: 4884 RVA: 0x0006CEC0 File Offset: 0x0006B0C0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateGoThrough) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateGoThrough.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001315 RID: 4885 RVA: 0x0006CF80 File Offset: 0x0006B180
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			UCharacterMovementComponent characterMovement = tsBaseCharacter.CharacterMovement;
			if (characterMovement != null)
			{
				if (this.FirstGoThroughPriority > 0)
				{
					characterMovement.GoThroughPriority = this.FirstGoThroughPriority;
				}
				characterMovement.GoThroughLower = true;
			}
			this.LeftTime = Math.Max(totalDuration * 0.5f, totalDuration - 0.1f);
			return true;
		}
		return false;
	}

	// Token: 0x06001316 RID: 4886 RVA: 0x0006CFE0 File Offset: 0x0006B1E0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateGoThrough) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyTick"), TsAnimNotifyStateGoThrough.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyTick_Implementation(meshComp, animation, frameDeltaTime);
		}
		UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		ptr->FrameDeltaTime = frameDeltaTime;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06001317 RID: 4887 RVA: 0x0006D0A0 File Offset: 0x0006B2A0
	[NullableContext(2)]
	protected virtual bool K2_NotifyTick_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		if (this.LeftTime > 0f)
		{
			this.LeftTime -= frameDeltaTime;
		}
		if (this.LeftTime <= 0f && !this.IsEnd)
		{
			TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
			if (tsBaseCharacter != null)
			{
				tsBaseCharacter.CharacterMovement.GoThroughLower = false;
				if (this.SecondHitPriority > 0)
				{
					tsBaseCharacter.CharacterMovement.HitPriority = this.SecondHitPriority;
				}
			}
		}
		return true;
	}

	// Token: 0x06001318 RID: 4888 RVA: 0x0006D114 File Offset: 0x0006B314
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateGoThrough) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateGoThrough.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001319 RID: 4889 RVA: 0x0006D1CC File Offset: 0x0006B3CC
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			this.IsEnd = true;
			UCharacterMovementComponent characterMovement = tsBaseCharacter.CharacterMovement;
			if (characterMovement != null)
			{
				characterMovement.GoThroughLower = false;
				Entity entityNoBlueprint = tsBaseCharacter.GetEntityNoBlueprint();
				if (entityNoBlueprint != null)
				{
					BaseMoveComponent component = entityNoBlueprint.GetComponent<BaseMoveComponent>();
					if (component != null)
					{
						component.ResetHitPriorityAndGoThrough();
					}
				}
			}
			return true;
		}
		return false;
	}

	// Token: 0x0600131A RID: 4890 RVA: 0x0006D220 File Offset: 0x0006B420
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateGoThrough) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateGoThrough.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600131B RID: 4891 RVA: 0x0006D2B0 File Offset: 0x0006B4B0
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "移动时设置穿人优先级";
	}

	// Token: 0x0600131C RID: 4892 RVA: 0x0006D2B7 File Offset: 0x0006B4B7
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateGoThrough._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateGoThrough.TsAnimNotifyStateGoThrough_C");
		}
		return TsAnimNotifyStateGoThrough._ClassPtr;
	}

	// Token: 0x0600131D RID: 4893 RVA: 0x0006D2DC File Offset: 0x0006B4DC
	public TsAnimNotifyStateGoThrough() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateGoThrough.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600131E RID: 4894 RVA: 0x0006D304 File Offset: 0x0006B504
	[NullableContext(1)]
	public TsAnimNotifyStateGoThrough(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateGoThrough.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600131F RID: 4895 RVA: 0x0006D337 File Offset: 0x0006B537
	protected TsAnimNotifyStateGoThrough(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001320 RID: 4896 RVA: 0x0006D340 File Offset: 0x0006B540
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001321 RID: 4897 RVA: 0x0006D37C File Offset: 0x0006B57C
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x06001322 RID: 4898 RVA: 0x0006D3B8 File Offset: 0x0006B5B8
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001323 RID: 4899 RVA: 0x0006D3EB File Offset: 0x0006B5EB
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000E12 RID: 3602
	private float LeftTime;

	// Token: 0x04000E13 RID: 3603
	private bool IsEnd;

	// Token: 0x04000E14 RID: 3604
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateGoThrough.TsAnimNotifyStateGoThrough_C";

	// Token: 0x04000E15 RID: 3605
	private static IntPtr _ClassPtr;

	// Token: 0x04000E16 RID: 3606
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000E17 RID: 3607
	private static int __PropertyOffset_FirstGoThroughPriority;

	// Token: 0x04000E18 RID: 3608
	private static int __PropertyOffset_SecondHitPriority;
}

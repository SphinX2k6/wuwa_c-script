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
	// Token: 0x17000321 RID: 801
	// (get) Token: 0x0600130A RID: 4874 RVA: 0x0006B43F File Offset: 0x0006963F
	// (set) Token: 0x0600130B RID: 4875 RVA: 0x0006B44F File Offset: 0x0006964F
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

	// Token: 0x17000322 RID: 802
	// (get) Token: 0x0600130C RID: 4876 RVA: 0x0006B460 File Offset: 0x00069660
	// (set) Token: 0x0600130D RID: 4877 RVA: 0x0006B470 File Offset: 0x00069670
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

	// Token: 0x0600130E RID: 4878 RVA: 0x0006B484 File Offset: 0x00069684
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

	// Token: 0x0600130F RID: 4879 RVA: 0x0006B52C File Offset: 0x0006972C
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

	// Token: 0x06001310 RID: 4880 RVA: 0x0006B58C File Offset: 0x0006978C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyTick"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
			ptr2->FrameDeltaTime = frameDeltaTime;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x06001311 RID: 4881 RVA: 0x0006B634 File Offset: 0x00069834
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

	// Token: 0x06001312 RID: 4882 RVA: 0x0006B6A8 File Offset: 0x000698A8
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

	// Token: 0x06001313 RID: 4883 RVA: 0x0006B748 File Offset: 0x00069948
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

	// Token: 0x06001314 RID: 4884 RVA: 0x0006B79C File Offset: 0x0006999C
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

	// Token: 0x06001315 RID: 4885 RVA: 0x0006B817 File Offset: 0x00069A17
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "移动时设置穿人优先级";
	}

	// Token: 0x06001316 RID: 4886 RVA: 0x0006B81E File Offset: 0x00069A1E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateGoThrough._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateGoThrough.TsAnimNotifyStateGoThrough_C");
		}
		return TsAnimNotifyStateGoThrough._ClassPtr;
	}

	// Token: 0x06001317 RID: 4887 RVA: 0x0006B844 File Offset: 0x00069A44
	public TsAnimNotifyStateGoThrough() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateGoThrough.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001318 RID: 4888 RVA: 0x0006B86C File Offset: 0x00069A6C
	[NullableContext(1)]
	public TsAnimNotifyStateGoThrough(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateGoThrough.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001319 RID: 4889 RVA: 0x0006B89F File Offset: 0x00069A9F
	protected TsAnimNotifyStateGoThrough(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600131A RID: 4890 RVA: 0x0006B8A8 File Offset: 0x00069AA8
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600131B RID: 4891 RVA: 0x0006B8E4 File Offset: 0x00069AE4
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x0600131C RID: 4892 RVA: 0x0006B920 File Offset: 0x00069B20
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600131D RID: 4893 RVA: 0x0006B953 File Offset: 0x00069B53
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000E0A RID: 3594
	private float LeftTime;

	// Token: 0x04000E0B RID: 3595
	private bool IsEnd;

	// Token: 0x04000E0C RID: 3596
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateGoThrough.TsAnimNotifyStateGoThrough_C";

	// Token: 0x04000E0D RID: 3597
	private static IntPtr _ClassPtr;

	// Token: 0x04000E0E RID: 3598
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000E0F RID: 3599
	private static int __PropertyOffset_FirstGoThroughPriority;

	// Token: 0x04000E10 RID: 3600
	private static int __PropertyOffset_SecondHitPriority;
}

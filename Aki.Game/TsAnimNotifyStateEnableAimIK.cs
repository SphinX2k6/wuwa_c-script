using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Monster.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200012E RID: 302
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateEnableAimIK.TsAnimNotifyStateEnableAimIK_C")]
public class TsAnimNotifyStateEnableAimIK : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000317 RID: 791
	// (get) Token: 0x060012A2 RID: 4770 RVA: 0x00068EE7 File Offset: 0x000670E7
	// (set) Token: 0x060012A3 RID: 4771 RVA: 0x00068EF7 File Offset: 0x000670F7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool SkeletonChange
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateEnableAimIK.__PropertyOffset_SkeletonChange) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateEnableAimIK.__PropertyOffset_SkeletonChange) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000318 RID: 792
	// (get) Token: 0x060012A4 RID: 4772 RVA: 0x00068F08 File Offset: 0x00067108
	// (set) Token: 0x060012A5 RID: 4773 RVA: 0x00068F1C File Offset: 0x0006711C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName SightBoneName
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateEnableAimIK.__PropertyOffset_SightBoneName);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateEnableAimIK.__PropertyOffset_SightBoneName) = value;
		}
	}

	// Token: 0x17000319 RID: 793
	// (get) Token: 0x060012A6 RID: 4774 RVA: 0x00068F31 File Offset: 0x00067131
	// (set) Token: 0x060012A7 RID: 4775 RVA: 0x00068F45 File Offset: 0x00067145
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName BeginBoneName
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateEnableAimIK.__PropertyOffset_BeginBoneName);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateEnableAimIK.__PropertyOffset_BeginBoneName) = value;
		}
	}

	// Token: 0x1700031A RID: 794
	// (get) Token: 0x060012A8 RID: 4776 RVA: 0x00068F5A File Offset: 0x0006715A
	// (set) Token: 0x060012A9 RID: 4777 RVA: 0x00068F6E File Offset: 0x0006716E
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName EndBoneName
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateEnableAimIK.__PropertyOffset_EndBoneName);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateEnableAimIK.__PropertyOffset_EndBoneName) = value;
		}
	}

	// Token: 0x1700031B RID: 795
	// (get) Token: 0x060012AA RID: 4778 RVA: 0x00068F83 File Offset: 0x00067183
	// (set) Token: 0x060012AB RID: 4779 RVA: 0x00068F93 File Offset: 0x00067193
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float AssistLimit
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateEnableAimIK.__PropertyOffset_AssistLimit);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateEnableAimIK.__PropertyOffset_AssistLimit) = value;
		}
	}

	// Token: 0x060012AC RID: 4780 RVA: 0x00068FA4 File Offset: 0x000671A4
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

	// Token: 0x060012AD RID: 4781 RVA: 0x0006904C File Offset: 0x0006724C
	[NullableContext(2)]
	protected unsafe virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		if (owner is TsBaseCharacter)
		{
			CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
			Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
			if (entity != null)
			{
				UAnimInstance mainAnimInstance = entity.GetComponent<CharacterAnimationComponent>().MainAnimInstance;
				if (UKuroStaticLibrary.IsObjectClassByName(mainAnimInstance, CharacterNameDefines.Instance.ABP_MONSTERCOMMON))
				{
					ABP_MonsterCommon_C abp_MonsterCommon_C = mainAnimInstance as ABP_MonsterCommon_C;
					this.OldSightBoneName = new FName?(abp_MonsterCommon_C.Sight_Bone_Name);
					this.OldBeginBoneName = new FName?(abp_MonsterCommon_C.Begin_Bone_Name);
					this.OldEndBoneName = new FName?(abp_MonsterCommon_C.End_Bone_Name);
					this.OldCameraMode = abp_MonsterCommon_C.SightLockMode;
					this.OldAssistLimit = abp_MonsterCommon_C.Assist_Limit;
					abp_MonsterCommon_C.Sight_Bone_Name = this.SightBoneName;
					abp_MonsterCommon_C.Begin_Bone_Name = this.BeginBoneName;
					abp_MonsterCommon_C.End_Bone_Name = this.EndBoneName;
					abp_MonsterCommon_C.SightLockMode = SightLockMode.Shooting;
					abp_MonsterCommon_C.Assist_Limit = this.AssistLimit;
					if (this.SkeletonChange)
					{
						abp_MonsterCommon_C.Increment++;
					}
					return true;
				}
			}
			else
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Test;
				ELogAuthor author = ELogAuthor.LJM;
				string message = "No Entity for TsBaseCharacter ";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Name", owner);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("location", owner.D_K2_GetActorLocation());
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}
		return false;
	}

	// Token: 0x060012AE RID: 4782 RVA: 0x000691B8 File Offset: 0x000673B8
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

	// Token: 0x060012AF RID: 4783 RVA: 0x00069258 File Offset: 0x00067458
	[NullableContext(2)]
	protected unsafe virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (owner is TsBaseCharacter)
		{
			CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
			Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
			if (entity != null)
			{
				UAnimInstance mainAnimInstance = entity.GetComponent<CharacterAnimationComponent>().MainAnimInstance;
				if (UKuroStaticLibrary.IsObjectClassByName(mainAnimInstance, CharacterNameDefines.Instance.ABP_MONSTERCOMMON))
				{
					ABP_MonsterCommon_C abp_MonsterCommon_C = mainAnimInstance as ABP_MonsterCommon_C;
					abp_MonsterCommon_C.Sight_Bone_Name = this.OldSightBoneName.Value;
					abp_MonsterCommon_C.Begin_Bone_Name = this.OldBeginBoneName.Value;
					abp_MonsterCommon_C.End_Bone_Name = this.OldEndBoneName.Value;
					abp_MonsterCommon_C.SightLockMode = this.OldCameraMode;
					abp_MonsterCommon_C.Assist_Limit = this.OldAssistLimit;
					return true;
				}
			}
			else
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Test;
				ELogAuthor author = ELogAuthor.LJM;
				string message = "No Entity for TsBaseCharacter";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Name", owner);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("location", owner.D_K2_GetActorLocation());
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}
		return false;
	}

	// Token: 0x060012B0 RID: 4784 RVA: 0x00069364 File Offset: 0x00067564
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

	// Token: 0x060012B1 RID: 4785 RVA: 0x000693DF File Offset: 0x000675DF
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "瞄准动作IK";
	}

	// Token: 0x060012B2 RID: 4786 RVA: 0x000693E6 File Offset: 0x000675E6
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateEnableAimIK._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateEnableAimIK.TsAnimNotifyStateEnableAimIK_C");
		}
		return TsAnimNotifyStateEnableAimIK._ClassPtr;
	}

	// Token: 0x060012B3 RID: 4787 RVA: 0x0006940C File Offset: 0x0006760C
	public TsAnimNotifyStateEnableAimIK() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateEnableAimIK.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060012B4 RID: 4788 RVA: 0x00069434 File Offset: 0x00067634
	[NullableContext(1)]
	public TsAnimNotifyStateEnableAimIK(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateEnableAimIK.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060012B5 RID: 4789 RVA: 0x00069467 File Offset: 0x00067667
	protected TsAnimNotifyStateEnableAimIK(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060012B6 RID: 4790 RVA: 0x00069470 File Offset: 0x00067670
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060012B7 RID: 4791 RVA: 0x000694AC File Offset: 0x000676AC
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060012B8 RID: 4792 RVA: 0x000694DF File Offset: 0x000676DF
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000DCD RID: 3533
	private FName? OldSightBoneName;

	// Token: 0x04000DCE RID: 3534
	private FName? OldBeginBoneName;

	// Token: 0x04000DCF RID: 3535
	private FName? OldEndBoneName;

	// Token: 0x04000DD0 RID: 3536
	private SightLockMode OldCameraMode;

	// Token: 0x04000DD1 RID: 3537
	private float OldAssistLimit;

	// Token: 0x04000DD2 RID: 3538
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateEnableAimIK.TsAnimNotifyStateEnableAimIK_C";

	// Token: 0x04000DD3 RID: 3539
	private static IntPtr _ClassPtr;

	// Token: 0x04000DD4 RID: 3540
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000DD5 RID: 3541
	private static int __PropertyOffset_SkeletonChange;

	// Token: 0x04000DD6 RID: 3542
	private static int __PropertyOffset_SightBoneName;

	// Token: 0x04000DD7 RID: 3543
	private static int __PropertyOffset_BeginBoneName;

	// Token: 0x04000DD8 RID: 3544
	private static int __PropertyOffset_EndBoneName;

	// Token: 0x04000DD9 RID: 3545
	private static int __PropertyOffset_AssistLimit;
}

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
	// Token: 0x1700031A RID: 794
	// (get) Token: 0x060012A8 RID: 4776 RVA: 0x0006A7F7 File Offset: 0x000689F7
	// (set) Token: 0x060012A9 RID: 4777 RVA: 0x0006A807 File Offset: 0x00068A07
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

	// Token: 0x1700031B RID: 795
	// (get) Token: 0x060012AA RID: 4778 RVA: 0x0006A818 File Offset: 0x00068A18
	// (set) Token: 0x060012AB RID: 4779 RVA: 0x0006A82C File Offset: 0x00068A2C
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

	// Token: 0x1700031C RID: 796
	// (get) Token: 0x060012AC RID: 4780 RVA: 0x0006A841 File Offset: 0x00068A41
	// (set) Token: 0x060012AD RID: 4781 RVA: 0x0006A855 File Offset: 0x00068A55
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

	// Token: 0x1700031D RID: 797
	// (get) Token: 0x060012AE RID: 4782 RVA: 0x0006A86A File Offset: 0x00068A6A
	// (set) Token: 0x060012AF RID: 4783 RVA: 0x0006A87E File Offset: 0x00068A7E
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

	// Token: 0x1700031E RID: 798
	// (get) Token: 0x060012B0 RID: 4784 RVA: 0x0006A893 File Offset: 0x00068A93
	// (set) Token: 0x060012B1 RID: 4785 RVA: 0x0006A8A3 File Offset: 0x00068AA3
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

	// Token: 0x060012B2 RID: 4786 RVA: 0x0006A8B4 File Offset: 0x00068AB4
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateEnableAimIK) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateEnableAimIK.StaticClass(), out intPtr, out num))
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

	// Token: 0x060012B3 RID: 4787 RVA: 0x0006A974 File Offset: 0x00068B74
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

	// Token: 0x060012B4 RID: 4788 RVA: 0x0006AAE0 File Offset: 0x00068CE0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateEnableAimIK) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateEnableAimIK.StaticClass(), out intPtr, out num))
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

	// Token: 0x060012B5 RID: 4789 RVA: 0x0006AB98 File Offset: 0x00068D98
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

	// Token: 0x060012B6 RID: 4790 RVA: 0x0006ACA4 File Offset: 0x00068EA4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateEnableAimIK) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateEnableAimIK.StaticClass(), out intPtr, out num))
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

	// Token: 0x060012B7 RID: 4791 RVA: 0x0006AD34 File Offset: 0x00068F34
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "瞄准动作IK";
	}

	// Token: 0x060012B8 RID: 4792 RVA: 0x0006AD3B File Offset: 0x00068F3B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateEnableAimIK._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateEnableAimIK.TsAnimNotifyStateEnableAimIK_C");
		}
		return TsAnimNotifyStateEnableAimIK._ClassPtr;
	}

	// Token: 0x060012B9 RID: 4793 RVA: 0x0006AD60 File Offset: 0x00068F60
	public TsAnimNotifyStateEnableAimIK() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateEnableAimIK.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060012BA RID: 4794 RVA: 0x0006AD88 File Offset: 0x00068F88
	[NullableContext(1)]
	public TsAnimNotifyStateEnableAimIK(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateEnableAimIK.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060012BB RID: 4795 RVA: 0x0006ADBB File Offset: 0x00068FBB
	protected TsAnimNotifyStateEnableAimIK(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060012BC RID: 4796 RVA: 0x0006ADC4 File Offset: 0x00068FC4
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060012BD RID: 4797 RVA: 0x0006AE00 File Offset: 0x00069000
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060012BE RID: 4798 RVA: 0x0006AE33 File Offset: 0x00069033
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000DD5 RID: 3541
	private FName? OldSightBoneName;

	// Token: 0x04000DD6 RID: 3542
	private FName? OldBeginBoneName;

	// Token: 0x04000DD7 RID: 3543
	private FName? OldEndBoneName;

	// Token: 0x04000DD8 RID: 3544
	private SightLockMode OldCameraMode;

	// Token: 0x04000DD9 RID: 3545
	private float OldAssistLimit;

	// Token: 0x04000DDA RID: 3546
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateEnableAimIK.TsAnimNotifyStateEnableAimIK_C";

	// Token: 0x04000DDB RID: 3547
	private static IntPtr _ClassPtr;

	// Token: 0x04000DDC RID: 3548
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000DDD RID: 3549
	private static int __PropertyOffset_SkeletonChange;

	// Token: 0x04000DDE RID: 3550
	private static int __PropertyOffset_SightBoneName;

	// Token: 0x04000DDF RID: 3551
	private static int __PropertyOffset_BeginBoneName;

	// Token: 0x04000DE0 RID: 3552
	private static int __PropertyOffset_EndBoneName;

	// Token: 0x04000DE1 RID: 3553
	private static int __PropertyOffset_AssistLimit;
}

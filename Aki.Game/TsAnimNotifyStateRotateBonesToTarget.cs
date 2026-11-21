using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000160 RID: 352
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRotateBonesToTarget.TsAnimNotifyStateRotateBonesToTarget_C")]
public class TsAnimNotifyStateRotateBonesToTarget : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170003B5 RID: 949
	// (get) Token: 0x06001666 RID: 5734 RVA: 0x0007D180 File Offset: 0x0007B380
	// (set) Token: 0x06001667 RID: 5735 RVA: 0x0007D1B9 File Offset: 0x0007B3B9
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<string> BoneNames
	{
		get
		{
			base.FastCheckIsValid();
			TArray<string> result;
			if ((result = this._BoneNames) == null)
			{
				result = (this._BoneNames = new TArray<string>(base.NativePtr + (IntPtr)TsAnimNotifyStateRotateBonesToTarget.__PropertyOffset_BoneNames, this));
			}
			return result;
		}
		set
		{
			this.BoneNames.CopyAssign(value);
		}
	}

	// Token: 0x170003B6 RID: 950
	// (get) Token: 0x06001668 RID: 5736 RVA: 0x0007D1C7 File Offset: 0x0007B3C7
	// (set) Token: 0x06001669 RID: 5737 RVA: 0x0007D1D7 File Offset: 0x0007B3D7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float StartLerpTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateRotateBonesToTarget.__PropertyOffset_StartLerpTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateRotateBonesToTarget.__PropertyOffset_StartLerpTime) = value;
		}
	}

	// Token: 0x170003B7 RID: 951
	// (get) Token: 0x0600166A RID: 5738 RVA: 0x0007D1E8 File Offset: 0x0007B3E8
	// (set) Token: 0x0600166B RID: 5739 RVA: 0x0007D1F8 File Offset: 0x0007B3F8
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float EndLerpTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateRotateBonesToTarget.__PropertyOffset_EndLerpTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateRotateBonesToTarget.__PropertyOffset_EndLerpTime) = value;
		}
	}

	// Token: 0x170003B8 RID: 952
	// (get) Token: 0x0600166C RID: 5740 RVA: 0x0007D209 File Offset: 0x0007B409
	// (set) Token: 0x0600166D RID: 5741 RVA: 0x0007D21D File Offset: 0x0007B41D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector DefaultOffset
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateRotateBonesToTarget.__PropertyOffset_DefaultOffset);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateRotateBonesToTarget.__PropertyOffset_DefaultOffset) = value;
		}
	}

	// Token: 0x170003B9 RID: 953
	// (get) Token: 0x0600166E RID: 5742 RVA: 0x0007D232 File Offset: 0x0007B432
	// (set) Token: 0x0600166F RID: 5743 RVA: 0x0007D242 File Offset: 0x0007B442
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float LerpSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateRotateBonesToTarget.__PropertyOffset_LerpSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateRotateBonesToTarget.__PropertyOffset_LerpSpeed) = value;
		}
	}

	// Token: 0x170003BA RID: 954
	// (get) Token: 0x06001670 RID: 5744 RVA: 0x0007D253 File Offset: 0x0007B453
	// (set) Token: 0x06001671 RID: 5745 RVA: 0x0007D263 File Offset: 0x0007B463
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float TargetUpdateThreshold
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateRotateBonesToTarget.__PropertyOffset_TargetUpdateThreshold);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateRotateBonesToTarget.__PropertyOffset_TargetUpdateThreshold) = value;
		}
	}

	// Token: 0x170003BB RID: 955
	// (get) Token: 0x06001672 RID: 5746 RVA: 0x0007D274 File Offset: 0x0007B474
	// (set) Token: 0x06001673 RID: 5747 RVA: 0x0007D284 File Offset: 0x0007B484
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool PauseRotate
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateRotateBonesToTarget.__PropertyOffset_PauseRotate) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateRotateBonesToTarget.__PropertyOffset_PauseRotate) = (value ? 1 : 0);
		}
	}

	// Token: 0x06001674 RID: 5748 RVA: 0x0007D295 File Offset: 0x0007B495
	private void Init()
	{
		if (this.HandleMap != null)
		{
			return;
		}
		this.HandleMap = new Dictionary<TsBaseCharacter, long>();
		this.PauseHandleMap = new Dictionary<TsBaseCharacter, long>();
	}

	// Token: 0x06001675 RID: 5749 RVA: 0x0007D2B8 File Offset: 0x0007B4B8
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateRotateBonesToTarget) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateRotateBonesToTarget.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001676 RID: 5750 RVA: 0x0007D378 File Offset: 0x0007B578
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		this.Init();
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (((tsBaseCharacter != null) ? tsBaseCharacter.CharacterActorComponent : null) == null)
		{
			return false;
		}
		Entity entityNoBlueprint = tsBaseCharacter.GetEntityNoBlueprint();
		RotateBonesToTargetManager rotateBonesToTargetManager;
		if (entityNoBlueprint == null)
		{
			rotateBonesToTargetManager = null;
		}
		else
		{
			CharacterAnimationComponent component = entityNoBlueprint.GetComponent<CharacterAnimationComponent>();
			rotateBonesToTargetManager = ((component != null) ? component.RotateBonesToTargetMgr : null);
		}
		RotateBonesToTargetManager rotateBonesToTargetManager2 = rotateBonesToTargetManager;
		if (rotateBonesToTargetManager2 == null)
		{
			return false;
		}
		if (this.PauseRotate)
		{
			long handle;
			if (this.PauseHandleMap.TryGetValue(tsBaseCharacter, out handle))
			{
				rotateBonesToTargetManager2.ClearPause(handle, 0.1f);
			}
			this.PauseHandleMap[tsBaseCharacter] = rotateBonesToTargetManager2.PauseByNames(this.BoneNames, this.StartLerpTime);
		}
		else
		{
			long handle2;
			if (this.HandleMap.TryGetValue(tsBaseCharacter, out handle2))
			{
				rotateBonesToTargetManager2.StopBoneToTarget(handle2, 0.1f);
			}
			TsAnimNotifyStateRotateBonesToTarget.tmpVector = this.DefaultOffset;
			TsAnimNotifyStateRotateBonesToTarget.tmpVector.Z = TsAnimNotifyStateRotateBonesToTarget.tmpVector.Z + tsBaseCharacter.CharacterActorComponent.DefaultHalfHeight;
			rotateBonesToTargetManager2.SetDefaultTarget(TsAnimNotifyStateRotateBonesToTarget.tmpVector, this.LerpSpeed, this.TargetUpdateThreshold);
			this.HandleMap[tsBaseCharacter] = rotateBonesToTargetManager2.SetBoneToTarget(this.BoneNames, this.StartLerpTime);
		}
		return true;
	}

	// Token: 0x06001677 RID: 5751 RVA: 0x0007D488 File Offset: 0x0007B688
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateRotateBonesToTarget) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateRotateBonesToTarget.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001678 RID: 5752 RVA: 0x0007D540 File Offset: 0x0007B740
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (((tsBaseCharacter != null) ? tsBaseCharacter.CharacterActorComponent : null) == null)
		{
			return false;
		}
		Entity entityNoBlueprint = tsBaseCharacter.GetEntityNoBlueprint();
		RotateBonesToTargetManager rotateBonesToTargetManager;
		if (entityNoBlueprint == null)
		{
			rotateBonesToTargetManager = null;
		}
		else
		{
			CharacterAnimationComponent component = entityNoBlueprint.GetComponent<CharacterAnimationComponent>();
			rotateBonesToTargetManager = ((component != null) ? component.RotateBonesToTargetMgr : null);
		}
		RotateBonesToTargetManager rotateBonesToTargetManager2 = rotateBonesToTargetManager;
		if (rotateBonesToTargetManager2 == null)
		{
			return false;
		}
		long handle;
		if (this.HandleMap.TryGetValue(tsBaseCharacter, out handle))
		{
			rotateBonesToTargetManager2.StopBoneToTarget(handle, this.EndLerpTime);
			this.HandleMap.Remove(tsBaseCharacter);
		}
		long handle2;
		if (this.PauseHandleMap.TryGetValue(tsBaseCharacter, out handle2))
		{
			rotateBonesToTargetManager2.ClearPause(handle2, this.EndLerpTime);
			this.PauseHandleMap.Remove(tsBaseCharacter);
		}
		return true;
	}

	// Token: 0x06001679 RID: 5753 RVA: 0x0007D5E4 File Offset: 0x0007B7E4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateRotateBonesToTarget) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateRotateBonesToTarget.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600167A RID: 5754 RVA: 0x0007D674 File Offset: 0x0007B874
	protected override string GetNotifyName_Implementation()
	{
		return "控制多根骨骼朝向目标";
	}

	// Token: 0x0600167B RID: 5755 RVA: 0x0007D67B File Offset: 0x0007B87B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateRotateBonesToTarget._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRotateBonesToTarget.TsAnimNotifyStateRotateBonesToTarget_C");
		}
		return TsAnimNotifyStateRotateBonesToTarget._ClassPtr;
	}

	// Token: 0x0600167C RID: 5756 RVA: 0x0007D6A0 File Offset: 0x0007B8A0
	public TsAnimNotifyStateRotateBonesToTarget() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateRotateBonesToTarget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600167D RID: 5757 RVA: 0x0007D6C8 File Offset: 0x0007B8C8
	public TsAnimNotifyStateRotateBonesToTarget(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateRotateBonesToTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600167E RID: 5758 RVA: 0x0007D6FB File Offset: 0x0007B8FB
	protected TsAnimNotifyStateRotateBonesToTarget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600167F RID: 5759 RVA: 0x0007D71C File Offset: 0x0007B91C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001680 RID: 5760 RVA: 0x0007D758 File Offset: 0x0007B958
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001681 RID: 5761 RVA: 0x0007D78B File Offset: 0x0007B98B
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000F90 RID: 3984
	[StaticVariableRuleIgnore]
	private static FVector tmpVector;

	// Token: 0x04000F91 RID: 3985
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<TsBaseCharacter, long> HandleMap = new Dictionary<TsBaseCharacter, long>();

	// Token: 0x04000F92 RID: 3986
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<TsBaseCharacter, long> PauseHandleMap = new Dictionary<TsBaseCharacter, long>();

	// Token: 0x04000F93 RID: 3987
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRotateBonesToTarget.TsAnimNotifyStateRotateBonesToTarget_C";

	// Token: 0x04000F94 RID: 3988
	private static IntPtr _ClassPtr;

	// Token: 0x04000F95 RID: 3989
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000F96 RID: 3990
	private static int __PropertyOffset_BoneNames;

	// Token: 0x04000F97 RID: 3991
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<string> _BoneNames;

	// Token: 0x04000F98 RID: 3992
	private static int __PropertyOffset_StartLerpTime;

	// Token: 0x04000F99 RID: 3993
	private static int __PropertyOffset_EndLerpTime;

	// Token: 0x04000F9A RID: 3994
	private static int __PropertyOffset_DefaultOffset;

	// Token: 0x04000F9B RID: 3995
	private static int __PropertyOffset_LerpSpeed;

	// Token: 0x04000F9C RID: 3996
	private static int __PropertyOffset_TargetUpdateThreshold;

	// Token: 0x04000F9D RID: 3997
	private static int __PropertyOffset_PauseRotate;
}

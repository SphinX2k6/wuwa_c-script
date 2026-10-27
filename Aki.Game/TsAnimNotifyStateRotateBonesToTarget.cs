using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200015C RID: 348
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRotateBonesToTarget.TsAnimNotifyStateRotateBonesToTarget_C")]
public class TsAnimNotifyStateRotateBonesToTarget : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000393 RID: 915
	// (get) Token: 0x060015C9 RID: 5577 RVA: 0x00077A40 File Offset: 0x00075C40
	// (set) Token: 0x060015CA RID: 5578 RVA: 0x00077A79 File Offset: 0x00075C79
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

	// Token: 0x17000394 RID: 916
	// (get) Token: 0x060015CB RID: 5579 RVA: 0x00077A87 File Offset: 0x00075C87
	// (set) Token: 0x060015CC RID: 5580 RVA: 0x00077A97 File Offset: 0x00075C97
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

	// Token: 0x17000395 RID: 917
	// (get) Token: 0x060015CD RID: 5581 RVA: 0x00077AA8 File Offset: 0x00075CA8
	// (set) Token: 0x060015CE RID: 5582 RVA: 0x00077AB8 File Offset: 0x00075CB8
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

	// Token: 0x17000396 RID: 918
	// (get) Token: 0x060015CF RID: 5583 RVA: 0x00077AC9 File Offset: 0x00075CC9
	// (set) Token: 0x060015D0 RID: 5584 RVA: 0x00077ADD File Offset: 0x00075CDD
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

	// Token: 0x17000397 RID: 919
	// (get) Token: 0x060015D1 RID: 5585 RVA: 0x00077AF2 File Offset: 0x00075CF2
	// (set) Token: 0x060015D2 RID: 5586 RVA: 0x00077B02 File Offset: 0x00075D02
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

	// Token: 0x17000398 RID: 920
	// (get) Token: 0x060015D3 RID: 5587 RVA: 0x00077B13 File Offset: 0x00075D13
	// (set) Token: 0x060015D4 RID: 5588 RVA: 0x00077B23 File Offset: 0x00075D23
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

	// Token: 0x17000399 RID: 921
	// (get) Token: 0x060015D5 RID: 5589 RVA: 0x00077B34 File Offset: 0x00075D34
	// (set) Token: 0x060015D6 RID: 5590 RVA: 0x00077B44 File Offset: 0x00075D44
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

	// Token: 0x060015D7 RID: 5591 RVA: 0x00077B55 File Offset: 0x00075D55
	private void Init()
	{
		if (this.HandleMap != null)
		{
			return;
		}
		this.HandleMap = new Dictionary<TsBaseCharacter, long>();
		this.PauseHandleMap = new Dictionary<TsBaseCharacter, long>();
	}

	// Token: 0x060015D8 RID: 5592 RVA: 0x00077B78 File Offset: 0x00075D78
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

	// Token: 0x060015D9 RID: 5593 RVA: 0x00077C20 File Offset: 0x00075E20
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

	// Token: 0x060015DA RID: 5594 RVA: 0x00077D30 File Offset: 0x00075F30
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

	// Token: 0x060015DB RID: 5595 RVA: 0x00077DD0 File Offset: 0x00075FD0
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

	// Token: 0x060015DC RID: 5596 RVA: 0x00077E74 File Offset: 0x00076074
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

	// Token: 0x060015DD RID: 5597 RVA: 0x00077EEF File Offset: 0x000760EF
	protected override string GetNotifyName_Implementation()
	{
		return "控制多根骨骼朝向目标";
	}

	// Token: 0x060015DE RID: 5598 RVA: 0x00077EF6 File Offset: 0x000760F6
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateRotateBonesToTarget._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRotateBonesToTarget.TsAnimNotifyStateRotateBonesToTarget_C");
		}
		return TsAnimNotifyStateRotateBonesToTarget._ClassPtr;
	}

	// Token: 0x060015DF RID: 5599 RVA: 0x00077F1C File Offset: 0x0007611C
	public TsAnimNotifyStateRotateBonesToTarget() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateRotateBonesToTarget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060015E0 RID: 5600 RVA: 0x00077F44 File Offset: 0x00076144
	public TsAnimNotifyStateRotateBonesToTarget(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateRotateBonesToTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060015E1 RID: 5601 RVA: 0x00077F77 File Offset: 0x00076177
	protected TsAnimNotifyStateRotateBonesToTarget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060015E2 RID: 5602 RVA: 0x00077F98 File Offset: 0x00076198
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060015E3 RID: 5603 RVA: 0x00077FD4 File Offset: 0x000761D4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060015E4 RID: 5604 RVA: 0x00078007 File Offset: 0x00076207
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000F4D RID: 3917
	[StaticVariableRuleIgnore]
	private static FVector tmpVector;

	// Token: 0x04000F4E RID: 3918
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<TsBaseCharacter, long> HandleMap = new Dictionary<TsBaseCharacter, long>();

	// Token: 0x04000F4F RID: 3919
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<TsBaseCharacter, long> PauseHandleMap = new Dictionary<TsBaseCharacter, long>();

	// Token: 0x04000F50 RID: 3920
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRotateBonesToTarget.TsAnimNotifyStateRotateBonesToTarget_C";

	// Token: 0x04000F51 RID: 3921
	private static IntPtr _ClassPtr;

	// Token: 0x04000F52 RID: 3922
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000F53 RID: 3923
	private static int __PropertyOffset_BoneNames;

	// Token: 0x04000F54 RID: 3924
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<string> _BoneNames;

	// Token: 0x04000F55 RID: 3925
	private static int __PropertyOffset_StartLerpTime;

	// Token: 0x04000F56 RID: 3926
	private static int __PropertyOffset_EndLerpTime;

	// Token: 0x04000F57 RID: 3927
	private static int __PropertyOffset_DefaultOffset;

	// Token: 0x04000F58 RID: 3928
	private static int __PropertyOffset_LerpSpeed;

	// Token: 0x04000F59 RID: 3929
	private static int __PropertyOffset_TargetUpdateThreshold;

	// Token: 0x04000F5A RID: 3930
	private static int __PropertyOffset_PauseRotate;
}

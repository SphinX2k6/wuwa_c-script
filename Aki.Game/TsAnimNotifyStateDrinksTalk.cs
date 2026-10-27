using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Sequence.Seq_BP.BPGobletLiquid;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200012B RID: 299
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateDrinksTalk.TsAnimNotifyStateDrinksTalk_C")]
public class TsAnimNotifyStateDrinksTalk : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000303 RID: 771
	// (get) Token: 0x06001251 RID: 4689 RVA: 0x00067D3F File Offset: 0x00065F3F
	// (set) Token: 0x06001252 RID: 4690 RVA: 0x00067D4F File Offset: 0x00065F4F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool bIsTick
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateDrinksTalk.__PropertyOffset_bIsTick) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateDrinksTalk.__PropertyOffset_bIsTick) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000304 RID: 772
	// (get) Token: 0x06001253 RID: 4691 RVA: 0x00067D60 File Offset: 0x00065F60
	// (set) Token: 0x06001254 RID: 4692 RVA: 0x00067D70 File Offset: 0x00065F70
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool bUseSocketPosition
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateDrinksTalk.__PropertyOffset_bUseSocketPosition) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateDrinksTalk.__PropertyOffset_bUseSocketPosition) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000305 RID: 773
	// (get) Token: 0x06001255 RID: 4693 RVA: 0x00067D81 File Offset: 0x00065F81
	// (set) Token: 0x06001256 RID: 4694 RVA: 0x00067D91 File Offset: 0x00065F91
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float AttachTimeLength
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateDrinksTalk.__PropertyOffset_AttachTimeLength);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateDrinksTalk.__PropertyOffset_AttachTimeLength) = value;
		}
	}

	// Token: 0x17000306 RID: 774
	// (get) Token: 0x06001257 RID: 4695 RVA: 0x00067DA2 File Offset: 0x00065FA2
	// (set) Token: 0x06001258 RID: 4696 RVA: 0x00067DB6 File Offset: 0x00065FB6
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName ActorTag
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateDrinksTalk.__PropertyOffset_ActorTag);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateDrinksTalk.__PropertyOffset_ActorTag) = value;
		}
	}

	// Token: 0x17000307 RID: 775
	// (get) Token: 0x06001259 RID: 4697 RVA: 0x00067DCB File Offset: 0x00065FCB
	// (set) Token: 0x0600125A RID: 4698 RVA: 0x00067DDF File Offset: 0x00065FDF
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName AttachSocketName
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateDrinksTalk.__PropertyOffset_AttachSocketName);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateDrinksTalk.__PropertyOffset_AttachSocketName) = value;
		}
	}

	// Token: 0x17000308 RID: 776
	// (get) Token: 0x0600125B RID: 4699 RVA: 0x00067DF4 File Offset: 0x00065FF4
	// (set) Token: 0x0600125C RID: 4700 RVA: 0x00067E04 File Offset: 0x00066004
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool bIsPlayAnimSeq
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateDrinksTalk.__PropertyOffset_bIsPlayAnimSeq) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateDrinksTalk.__PropertyOffset_bIsPlayAnimSeq) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000309 RID: 777
	// (get) Token: 0x0600125D RID: 4701 RVA: 0x00067E15 File Offset: 0x00066015
	// (set) Token: 0x0600125E RID: 4702 RVA: 0x00067E29 File Offset: 0x00066029
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName BatchSocketName
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateDrinksTalk.__PropertyOffset_BatchSocketName);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateDrinksTalk.__PropertyOffset_BatchSocketName) = value;
		}
	}

	// Token: 0x1700030A RID: 778
	// (get) Token: 0x0600125F RID: 4703 RVA: 0x00067E3E File Offset: 0x0006603E
	// (set) Token: 0x06001260 RID: 4704 RVA: 0x00067E52 File Offset: 0x00066052
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UAnimSequence AnimSeq
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UAnimSequence>(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateDrinksTalk.__PropertyOffset_AnimSeq);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateDrinksTalk.__PropertyOffset_AnimSeq, value);
		}
	}

	// Token: 0x1700030B RID: 779
	// (get) Token: 0x06001261 RID: 4705 RVA: 0x00067E68 File Offset: 0x00066068
	// (set) Token: 0x06001262 RID: 4706 RVA: 0x00067EA1 File Offset: 0x000660A1
	[Nullable(1)]
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveFloat HighCurve
	{
		[NullableContext(1)]
		get
		{
			base.FastCheckIsValid();
			FKuroCurveFloat result;
			if ((result = this._HighCurve) == null)
			{
				result = (this._HighCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)TsAnimNotifyStateDrinksTalk.__PropertyOffset_HighCurve, this));
			}
			return result;
		}
		[NullableContext(1)]
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)TsAnimNotifyStateDrinksTalk.__PropertyOffset_HighCurve, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x1700030C RID: 780
	// (get) Token: 0x06001263 RID: 4707 RVA: 0x00067EC9 File Offset: 0x000660C9
	// (set) Token: 0x06001264 RID: 4708 RVA: 0x00067EDD File Offset: 0x000660DD
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UMaterialParameterCollection MPCObject
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateDrinksTalk.__PropertyOffset_MPCObject);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateDrinksTalk.__PropertyOffset_MPCObject, value);
		}
	}

	// Token: 0x1700030D RID: 781
	// (get) Token: 0x06001265 RID: 4709 RVA: 0x00067EF2 File Offset: 0x000660F2
	// (set) Token: 0x06001266 RID: 4710 RVA: 0x00067F02 File Offset: 0x00066102
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsAttach
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateDrinksTalk.__PropertyOffset_IsAttach) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateDrinksTalk.__PropertyOffset_IsAttach) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700030E RID: 782
	// (get) Token: 0x06001267 RID: 4711 RVA: 0x00067F13 File Offset: 0x00066113
	// (set) Token: 0x06001268 RID: 4712 RVA: 0x00067F27 File Offset: 0x00066127
	[UProperty(EPropertyFlags.CPF_None)]
	protected unsafe BP_Prop_GobletLiquid_C CupActor
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<BP_Prop_GobletLiquid_C>(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateDrinksTalk.__PropertyOffset_CupActor);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateDrinksTalk.__PropertyOffset_CupActor, value);
		}
	}

	// Token: 0x06001269 RID: 4713 RVA: 0x00067F3C File Offset: 0x0006613C
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

	// Token: 0x0600126A RID: 4714 RVA: 0x00067FE4 File Offset: 0x000661E4
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		this.IsAttach = false;
		this.CupActor = (UKuroCollectActorComponent.GetActorWithTag(this.ActorTag, ECollectActorType.Default) as BP_Prop_GobletLiquid_C);
		if (this.CupActor == null)
		{
			return false;
		}
		this.ActorLocation = Vector.Create();
		this.ActorRotation = Rotator.Create();
		Vector actorLocation = this.ActorLocation;
		FVectorDouble fvectorDouble = this.CupActor.D_K2_GetActorLocation();
		actorLocation.FromUeVector(fvectorDouble);
		Rotator actorRotation = this.ActorRotation;
		FRotator frotator = this.CupActor.K2_GetActorRotation();
		actorRotation.FromUeRotator(frotator);
		this.CupActor.IsTick = this.bIsTick;
		this.CupActor.UseLiquidSocketPosition = this.bUseSocketPosition;
		this.CupActor.BatchSocketName = this.BatchSocketName;
		if (this.AnimSeq == null || !this.AnimSeq.IsValid() || !this.bUseSocketPosition || !this.bIsPlayAnimSeq)
		{
			return false;
		}
		this.CupActor.UpdateGobletLiguid();
		this.CupActor.Liquid.SetAnimationMode(EAnimationMode.AnimationSingleNode);
		this.CupActor.Liquid.PlayAnimation(this.AnimSeq, false);
		return true;
	}

	// Token: 0x0600126B RID: 4715 RVA: 0x000680F0 File Offset: 0x000662F0
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

	// Token: 0x0600126C RID: 4716 RVA: 0x00068198 File Offset: 0x00066398
	protected virtual bool K2_NotifyTick_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		if (this.CupActor == null || !this.CupActor.IsValid())
		{
			return false;
		}
		if (!this.IsAttach && base.CurrentTimeLength >= this.AttachTimeLength)
		{
			this.CupActor.K2_AttachToComponent(meshComp, this.bUseSocketPosition ? FNameUtil.GetCheckDynamicFName("Root") : this.AttachSocketName, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, true, true);
			this.IsAttach = true;
		}
		FKuroCurveFloat highCurve = this.HighCurve;
		float value_Float = UKuroCurveLibrary.GetValue_Float(highCurve, base.CurrentTimeLength);
		this.CupActor.Water_HighProcess = value_Float;
		return true;
	}

	// Token: 0x0600126D RID: 4717 RVA: 0x00068228 File Offset: 0x00066428
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

	// Token: 0x0600126E RID: 4718 RVA: 0x000682C8 File Offset: 0x000664C8
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		if (this.CupActor == null || !this.CupActor.IsValid())
		{
			return false;
		}
		this.CupActor.K2_DetachFromActor(EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
		FHitResult fhitResult = new FHitResult();
		this.CupActor.D_K2_SetActorLocation(this.ActorLocation.ToUeVector(false), false, ref fhitResult, false);
		this.CupActor.K2_SetActorRotation(this.ActorRotation.ToUeRotator(), false);
		this.CupActor.SetActorHiddenInGame(false);
		this.CupActor.UpdateGobletLiguid();
		float playLength = animation.GetPlayLength();
		FKuroCurveFloat highCurve = this.HighCurve;
		float value_Float = UKuroCurveLibrary.GetValue_Float(highCurve, playLength);
		this.CupActor.Water_HighProcess = value_Float;
		FIntVector worldOriginLocation = UGameplayStatics.GetWorldOriginLocation(this.CupActor.Liquid);
		FVectorDouble b = UKismetMathLibrary.Conv_VectorToVectorDouble(UKismetMathLibrary.Conv_IntVectorToVector(worldOriginLocation));
		FVector inVec = UKismetMathLibrary.Conv_VectorDoubleToVector(UKismetMathLibrary.D_Subtract_VectorVector(this.CupActor.Liquid.D_K2_GetComponentLocation(), b));
		UObject liquid = this.CupActor.Liquid;
		UMaterialParameterCollection mpcobject = this.MPCObject;
		FName value = FNameUtil.GetDynamicFName("WaterCenterPosition").Value;
		FLinearColor flinearColor = UKismetMathLibrary.Conv_VectorToLinearColor(inVec);
		UKismetMaterialLibrary.SetVectorParameterValue(liquid, mpcobject, value, flinearColor);
		USkeletalMeshComponent liquid2 = this.CupActor.Liquid;
		if (liquid2 != null)
		{
			liquid2.Stop();
		}
		USkeletalMeshComponent liquid3 = this.CupActor.Liquid;
		if (liquid3 != null)
		{
			liquid3.SetAnimation(null);
		}
		this.CupActor.IsTick = false;
		return true;
	}

	// Token: 0x0600126F RID: 4719 RVA: 0x0006841C File Offset: 0x0006661C
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

	// Token: 0x06001270 RID: 4720 RVA: 0x00068497 File Offset: 0x00066697
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "春节活动饮料对话状态";
	}

	// Token: 0x06001271 RID: 4721 RVA: 0x0006849E File Offset: 0x0006669E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateDrinksTalk._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateDrinksTalk.TsAnimNotifyStateDrinksTalk_C");
		}
		return TsAnimNotifyStateDrinksTalk._ClassPtr;
	}

	// Token: 0x06001272 RID: 4722 RVA: 0x000684C4 File Offset: 0x000666C4
	public TsAnimNotifyStateDrinksTalk() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateDrinksTalk.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001273 RID: 4723 RVA: 0x000684EC File Offset: 0x000666EC
	[NullableContext(1)]
	public TsAnimNotifyStateDrinksTalk(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateDrinksTalk.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001274 RID: 4724 RVA: 0x0006851F File Offset: 0x0006671F
	protected TsAnimNotifyStateDrinksTalk(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001275 RID: 4725 RVA: 0x00068540 File Offset: 0x00066740
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001276 RID: 4726 RVA: 0x0006857C File Offset: 0x0006677C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x06001277 RID: 4727 RVA: 0x000685B8 File Offset: 0x000667B8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001278 RID: 4728 RVA: 0x000685EB File Offset: 0x000667EB
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000DA9 RID: 3497
	[Nullable(1)]
	protected Vector ActorLocation = Vector.Create();

	// Token: 0x04000DAA RID: 3498
	[Nullable(1)]
	protected Rotator ActorRotation = Rotator.Create();

	// Token: 0x04000DAB RID: 3499
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateDrinksTalk.TsAnimNotifyStateDrinksTalk_C";

	// Token: 0x04000DAC RID: 3500
	private static IntPtr _ClassPtr;

	// Token: 0x04000DAD RID: 3501
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000DAE RID: 3502
	private static int __PropertyOffset_bIsTick;

	// Token: 0x04000DAF RID: 3503
	private static int __PropertyOffset_bUseSocketPosition;

	// Token: 0x04000DB0 RID: 3504
	private static int __PropertyOffset_AttachTimeLength;

	// Token: 0x04000DB1 RID: 3505
	private static int __PropertyOffset_ActorTag;

	// Token: 0x04000DB2 RID: 3506
	private static int __PropertyOffset_AttachSocketName;

	// Token: 0x04000DB3 RID: 3507
	private static int __PropertyOffset_bIsPlayAnimSeq;

	// Token: 0x04000DB4 RID: 3508
	private static int __PropertyOffset_BatchSocketName;

	// Token: 0x04000DB5 RID: 3509
	private static int __PropertyOffset_AnimSeq;

	// Token: 0x04000DB6 RID: 3510
	private static int __PropertyOffset_HighCurve;

	// Token: 0x04000DB7 RID: 3511
	private FKuroCurveFloat _HighCurve;

	// Token: 0x04000DB8 RID: 3512
	private static int __PropertyOffset_MPCObject;

	// Token: 0x04000DB9 RID: 3513
	private static int __PropertyOffset_IsAttach;

	// Token: 0x04000DBA RID: 3514
	private static int __PropertyOffset_CupActor;
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000173 RID: 371
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateShowUiCalabashEffect.TsAnimNotifyStateShowUiCalabashEffect_C")]
public class TsAnimNotifyStateShowUiCalabashEffect : UKuroEffectMakerANS, IUnrealUObject, IUnrealObject
{
	// Token: 0x170003EA RID: 1002
	// (get) Token: 0x060017BE RID: 6078 RVA: 0x00082ADF File Offset: 0x00080CDF
	// (set) Token: 0x060017BF RID: 6079 RVA: 0x00082AEF File Offset: 0x00080CEF
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool PlayOnEnd
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateShowUiCalabashEffect.__PropertyOffset_PlayOnEnd) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateShowUiCalabashEffect.__PropertyOffset_PlayOnEnd) = (value ? 1 : 0);
		}
	}

	// Token: 0x170003EB RID: 1003
	// (get) Token: 0x060017C0 RID: 6080 RVA: 0x00082B00 File Offset: 0x00080D00
	// (set) Token: 0x060017C1 RID: 6081 RVA: 0x00082B14 File Offset: 0x00080D14
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName EffectSlotName
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateShowUiCalabashEffect.__PropertyOffset_EffectSlotName);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateShowUiCalabashEffect.__PropertyOffset_EffectSlotName) = value;
		}
	}

	// Token: 0x060017C2 RID: 6082 RVA: 0x00082B29 File Offset: 0x00080D29
	private void Init()
	{
		if (this.IsInited)
		{
			return;
		}
		this.ParamsMap = new Dictionary<USkeletalMeshComponent, AnimNotifyStateUiEffectParams>();
		this.IsInited = true;
	}

	// Token: 0x060017C3 RID: 6083 RVA: 0x00082B48 File Offset: 0x00080D48
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateShowUiCalabashEffect) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateShowUiCalabashEffect.StaticClass(), out intPtr, out num))
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

	// Token: 0x060017C4 RID: 6084 RVA: 0x00082C08 File Offset: 0x00080E08
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		if (!meshComp.IsVisible())
		{
			return false;
		}
		this.Init();
		AActor owner = meshComp.GetOwner();
		if (owner is TsUiSceneRoleActor)
		{
			if ((owner as TsUiSceneRoleActor).Model == null)
			{
				return false;
			}
			UiRoleHuluComponent uiRoleHuluComponent = (owner as TsUiSceneRoleActor).Model.CheckGetComponent<UiRoleHuluComponent>();
			if (uiRoleHuluComponent == null)
			{
				return false;
			}
			UiModelBase model = uiRoleHuluComponent.GetHuluHandle().Model;
			if (model == null)
			{
				return false;
			}
			UiHuluSkinDataComponent uiHuluSkinDataComponent = model.CheckGetComponent<UiHuluSkinDataComponent>();
			if (uiHuluSkinDataComponent == null)
			{
				return false;
			}
			UiModelBase model2 = (owner as TsUiSceneRoleActor).Model;
			UiModelAnsControllerComponent uiModelAnsControllerComponent = (model2 != null) ? model2.CheckGetComponent<UiModelAnsControllerComponent>() : null;
			if (uiModelAnsControllerComponent == null)
			{
				return false;
			}
			AActor owner2 = meshComp.GetOwner();
			SkeletalMeshEffectContext skeletalMeshEffectContext = new SkeletalMeshEffectContext(null, null, false);
			skeletalMeshEffectContext.SkeletalMeshComp = meshComp;
			skeletalMeshEffectContext.SourceObject = owner2;
			skeletalMeshEffectContext.CreateFromType = EEffectCreateFromType.An;
			skeletalMeshEffectContext.AnsSlotName = new FName?(this.EffectSlotName);
			FVectorDouble fvectorDouble = UKismetMathLibrary.Conv_VectorToVectorDouble(base.Location);
			string effectPath = uiHuluSkinDataComponent.EffectPath;
			FName socketName = base.SocketName;
			bool attached = base.Attached;
			bool attachLocationOnly = base.AttachLocationOnly;
			FVectorDouble location = fvectorDouble;
			FRotator rotation = base.Rotation;
			FVector scale = base.Scale;
			UiEffectAnsContext uiEffectAnsContext = new UiEffectAnsContext(effectPath, meshComp, socketName, attached, attachLocationOnly, location, rotation, new FVectorDouble(ref scale), this.PlayOnEnd, true, skeletalMeshEffectContext, TsAnimNotifyStateShowUiCalabashEffect.NameNone, delegate(USkeletalMeshComponent mesh, int handle)
			{
				if (!EffectSystem.Instance.IsValid(handle))
				{
					return;
				}
				AnimNotifyStateUiEffectParams animNotifyStateUiEffectParams;
				if (!this.ParamsMap.TryGetValue(mesh, out animNotifyStateUiEffectParams))
				{
					return;
				}
				animNotifyStateUiEffectParams.EffectHandle = new int?(handle);
			});
			uiModelAnsControllerComponent.AddAns(uiEffectAnsContext);
			this.ParamsMap[meshComp] = new AnimNotifyStateUiEffectParams(null, uiEffectAnsContext, false);
		}
		return false;
	}

	// Token: 0x060017C5 RID: 6085 RVA: 0x00082D64 File Offset: 0x00080F64
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateShowUiCalabashEffect) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyTick"), TsAnimNotifyStateShowUiCalabashEffect.StaticClass(), out intPtr, out num))
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

	// Token: 0x060017C6 RID: 6086 RVA: 0x00082E24 File Offset: 0x00081024
	[NullableContext(2)]
	protected virtual bool K2_NotifyTick_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		AnimNotifyStateUiEffectParams animNotifyStateUiEffectParams;
		if (!this.ParamsMap.TryGetValue(meshComp, out animNotifyStateUiEffectParams))
		{
			return false;
		}
		int? effectHandle = animNotifyStateUiEffectParams.EffectHandle;
		if (effectHandle == null || !EffectSystem.Instance.IsValid(effectHandle.Value))
		{
			return false;
		}
		if (base.Attached && base.AttachLocationOnly && base.SocketName != TsAnimNotifyStateShowUiCalabashEffect.NameNone)
		{
			OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(effectHandle.Value);
			FTransformDouble ftransformDouble = meshComp.D_GetSocketTransform(base.SocketName, ERelativeTransformSpace.RTS_World);
			FVectorDouble fvectorDouble = UKismetMathLibrary.Conv_VectorToVectorDouble(base.Location);
			FHitResult fhitResult = new FHitResult();
			FVectorDouble fvectorDouble2 = ftransformDouble.TransformPosition(fvectorDouble);
			effectActor.D_K2_SetActorLocation(fvectorDouble2, false, ref fhitResult, false);
		}
		return true;
	}

	// Token: 0x060017C7 RID: 6087 RVA: 0x00082ED4 File Offset: 0x000810D4
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateShowUiCalabashEffect) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateShowUiCalabashEffect.StaticClass(), out intPtr, out num))
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

	// Token: 0x060017C8 RID: 6088 RVA: 0x00082F8C File Offset: 0x0008118C
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsUiSceneRoleActor))
		{
			return false;
		}
		if (!this.ParamsMap.ContainsKey(meshComp))
		{
			Log.Instance.Error(ELogModule.RenderEffect, ELogAuthor.LZK, "AnimNotifyStateEffect未成对，UiEffectAnsContext为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		AnimNotifyStateUiEffectParams animNotifyStateUiEffectParams = this.ParamsMap[meshComp];
		if (animNotifyStateUiEffectParams == null || animNotifyStateUiEffectParams.UiEffectAnsContext == null)
		{
			Log.Instance.Error(ELogModule.RenderEffect, ELogAuthor.LZK, "AnimNotifyStateEffect未成对，UiEffectAnsContext为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		if ((owner as TsUiSceneRoleActor).Model != null)
		{
			(owner as TsUiSceneRoleActor).Model.CheckGetComponent<UiModelAnsControllerComponent>().ReduceAns(animNotifyStateUiEffectParams.UiEffectAnsContext);
			this.ParamsMap.Remove(meshComp);
			return true;
		}
		return false;
	}

	// Token: 0x060017C9 RID: 6089 RVA: 0x00083048 File Offset: 0x00081248
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateShowUiCalabashEffect) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateShowUiCalabashEffect.StaticClass(), out intPtr, out num))
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

	// Token: 0x060017CA RID: 6090 RVA: 0x000830D8 File Offset: 0x000812D8
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "Ui界面葫芦显示特效";
	}

	// Token: 0x060017CB RID: 6091 RVA: 0x000830DF File Offset: 0x000812DF
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateShowUiCalabashEffect._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateShowUiCalabashEffect.TsAnimNotifyStateShowUiCalabashEffect_C");
		}
		return TsAnimNotifyStateShowUiCalabashEffect._ClassPtr;
	}

	// Token: 0x060017CC RID: 6092 RVA: 0x00083104 File Offset: 0x00081304
	public TsAnimNotifyStateShowUiCalabashEffect() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateShowUiCalabashEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060017CD RID: 6093 RVA: 0x0008312C File Offset: 0x0008132C
	[NullableContext(1)]
	public TsAnimNotifyStateShowUiCalabashEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateShowUiCalabashEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060017CE RID: 6094 RVA: 0x0008315F File Offset: 0x0008135F
	protected TsAnimNotifyStateShowUiCalabashEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060017CF RID: 6095 RVA: 0x00083174 File Offset: 0x00081374
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060017D0 RID: 6096 RVA: 0x000831B0 File Offset: 0x000813B0
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x060017D1 RID: 6097 RVA: 0x000831EC File Offset: 0x000813EC
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060017D2 RID: 6098 RVA: 0x0008321F File Offset: 0x0008141F
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001012 RID: 4114
	[Nullable(1)]
	private Dictionary<USkeletalMeshComponent, AnimNotifyStateUiEffectParams> ParamsMap = new Dictionary<USkeletalMeshComponent, AnimNotifyStateUiEffectParams>();

	// Token: 0x04001013 RID: 4115
	private bool IsInited;

	// Token: 0x04001014 RID: 4116
	[StaticVariableRuleIgnore]
	private static readonly FName NameNone = new FName("None");

	// Token: 0x04001015 RID: 4117
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateShowUiCalabashEffect.TsAnimNotifyStateShowUiCalabashEffect_C";

	// Token: 0x04001016 RID: 4118
	private static IntPtr _ClassPtr;

	// Token: 0x04001017 RID: 4119
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001018 RID: 4120
	private static int __PropertyOffset_PlayOnEnd;

	// Token: 0x04001019 RID: 4121
	private static int __PropertyOffset_EffectSlotName;
}

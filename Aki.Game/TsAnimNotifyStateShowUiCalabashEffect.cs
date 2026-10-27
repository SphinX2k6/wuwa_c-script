using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200016F RID: 367
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateShowUiCalabashEffect.TsAnimNotifyStateShowUiCalabashEffect_C")]
public class TsAnimNotifyStateShowUiCalabashEffect : UKuroEffectMakerANS, IUnrealUObject, IUnrealObject
{
	// Token: 0x170003C8 RID: 968
	// (get) Token: 0x06001721 RID: 5921 RVA: 0x0007CEF7 File Offset: 0x0007B0F7
	// (set) Token: 0x06001722 RID: 5922 RVA: 0x0007CF07 File Offset: 0x0007B107
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

	// Token: 0x170003C9 RID: 969
	// (get) Token: 0x06001723 RID: 5923 RVA: 0x0007CF18 File Offset: 0x0007B118
	// (set) Token: 0x06001724 RID: 5924 RVA: 0x0007CF2C File Offset: 0x0007B12C
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

	// Token: 0x06001725 RID: 5925 RVA: 0x0007CF41 File Offset: 0x0007B141
	private void Init()
	{
		if (this.IsInited)
		{
			return;
		}
		this.ParamsMap = new Dictionary<USkeletalMeshComponent, AnimNotifyStateUiEffectParams>();
		this.IsInited = true;
	}

	// Token: 0x06001726 RID: 5926 RVA: 0x0007CF60 File Offset: 0x0007B160
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

	// Token: 0x06001727 RID: 5927 RVA: 0x0007D008 File Offset: 0x0007B208
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
				if (!this.ParamsMap.ContainsKey(mesh))
				{
					return;
				}
				this.ParamsMap[mesh].EffectHandle = new int?(handle);
			});
			uiModelAnsControllerComponent.AddAns<UiEffectAnsContext>("UiEffectAnsContext", uiEffectAnsContext);
			this.ParamsMap[meshComp] = new AnimNotifyStateUiEffectParams(null, uiEffectAnsContext, false);
		}
		return false;
	}

	// Token: 0x06001728 RID: 5928 RVA: 0x0007D16C File Offset: 0x0007B36C
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

	// Token: 0x06001729 RID: 5929 RVA: 0x0007D214 File Offset: 0x0007B414
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

	// Token: 0x0600172A RID: 5930 RVA: 0x0007D2C4 File Offset: 0x0007B4C4
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

	// Token: 0x0600172B RID: 5931 RVA: 0x0007D364 File Offset: 0x0007B564
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
			(owner as TsUiSceneRoleActor).Model.CheckGetComponent<UiModelAnsControllerComponent>().ReduceAns<UiEffectAnsContext>("UiEffectAnsContext", animNotifyStateUiEffectParams.UiEffectAnsContext);
			this.ParamsMap.Remove(meshComp);
			return true;
		}
		return false;
	}

	// Token: 0x0600172C RID: 5932 RVA: 0x0007D424 File Offset: 0x0007B624
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

	// Token: 0x0600172D RID: 5933 RVA: 0x0007D49F File Offset: 0x0007B69F
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "Ui界面葫芦显示特效";
	}

	// Token: 0x0600172E RID: 5934 RVA: 0x0007D4A6 File Offset: 0x0007B6A6
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateShowUiCalabashEffect._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateShowUiCalabashEffect.TsAnimNotifyStateShowUiCalabashEffect_C");
		}
		return TsAnimNotifyStateShowUiCalabashEffect._ClassPtr;
	}

	// Token: 0x0600172F RID: 5935 RVA: 0x0007D4CC File Offset: 0x0007B6CC
	public TsAnimNotifyStateShowUiCalabashEffect() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateShowUiCalabashEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001730 RID: 5936 RVA: 0x0007D4F4 File Offset: 0x0007B6F4
	[NullableContext(1)]
	public TsAnimNotifyStateShowUiCalabashEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateShowUiCalabashEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001731 RID: 5937 RVA: 0x0007D527 File Offset: 0x0007B727
	protected TsAnimNotifyStateShowUiCalabashEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001732 RID: 5938 RVA: 0x0007D53C File Offset: 0x0007B73C
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001733 RID: 5939 RVA: 0x0007D578 File Offset: 0x0007B778
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x06001734 RID: 5940 RVA: 0x0007D5B4 File Offset: 0x0007B7B4
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001735 RID: 5941 RVA: 0x0007D5E7 File Offset: 0x0007B7E7
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000FCF RID: 4047
	[Nullable(1)]
	private Dictionary<USkeletalMeshComponent, AnimNotifyStateUiEffectParams> ParamsMap = new Dictionary<USkeletalMeshComponent, AnimNotifyStateUiEffectParams>();

	// Token: 0x04000FD0 RID: 4048
	private bool IsInited;

	// Token: 0x04000FD1 RID: 4049
	[StaticVariableRuleIgnore]
	private static readonly FName NameNone = new FName("None");

	// Token: 0x04000FD2 RID: 4050
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateShowUiCalabashEffect.TsAnimNotifyStateShowUiCalabashEffect_C";

	// Token: 0x04000FD3 RID: 4051
	private static IntPtr _ClassPtr;

	// Token: 0x04000FD4 RID: 4052
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000FD5 RID: 4053
	private static int __PropertyOffset_PlayOnEnd;

	// Token: 0x04000FD6 RID: 4054
	private static int __PropertyOffset_EffectSlotName;
}

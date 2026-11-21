using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Data.Fight.Enum;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.Enum;
using AkiClient.Game.Aki.Render.RuntimeBP.GI;
using AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interaction;
using AkiClient.Game.Aki.Render.RuntimeBP.StateMachineEffect;
using AkiClient.Game.Aki.Scene.Assets.Levels.LiNaXiTa.QiQiu.ZhuCheng.SkinMesh.SK_Sev_Mon_01AL.CommonAnim.Montage;
using CSharpScript.Core.Common;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.LevelGamePlay.Common;
using CSharpScript.Game.Module.MechanismTimeline;
using CSharpScript.Game.Render;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002A05 RID: 10757
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Render/Scene/Item/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Scene/Item/SceneInteractionActor.SceneInteractionActor_C")]
public class SceneInteractionActor : AKuroSceneInteractionActor, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002C17 RID: 11287
	// (get) Token: 0x0601B04C RID: 110668 RVA: 0x00848DF2 File Offset: 0x00846FF2
	// (set) Token: 0x0601B04D RID: 110669 RVA: 0x00848E02 File Offset: 0x00847002
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int MaxPendingStateCount
	{
		get
		{
			return *(base.NativePtr + (IntPtr)SceneInteractionActor.__PropertyOffset_MaxPendingStateCount);
		}
		set
		{
			*(base.NativePtr + (IntPtr)SceneInteractionActor.__PropertyOffset_MaxPendingStateCount) = value;
		}
	}

	// Token: 0x17002C18 RID: 11288
	// (get) Token: 0x0601B04E RID: 110670 RVA: 0x00848E14 File Offset: 0x00847014
	[Nullable(new byte[]
	{
		1,
		2
	})]
	[UProperty(EPropertyFlags.CPF_None)]
	public TMap<EKuroSceneInteractionState, SSceneInteractionitem> States
	{
		[return: Nullable(new byte[]
		{
			1,
			2
		})]
		get
		{
			base.FastCheckIsValid();
			TMap<EKuroSceneInteractionState, SSceneInteractionitem> result;
			if ((result = this._States) == null)
			{
				result = (this._States = new TMap<EKuroSceneInteractionState, SSceneInteractionitem>(base.NativePtr + (IntPtr)SceneInteractionActor.__PropertyOffset_States, this));
			}
			return result;
		}
	}

	// Token: 0x17002C19 RID: 11289
	// (get) Token: 0x0601B04F RID: 110671 RVA: 0x00848E50 File Offset: 0x00847050
	[Nullable(new byte[]
	{
		1,
		2
	})]
	[UProperty(EPropertyFlags.CPF_None)]
	public TMap<ESceneInteractionEffect, SScenePropertyEffect> Effects
	{
		[return: Nullable(new byte[]
		{
			1,
			2
		})]
		get
		{
			base.FastCheckIsValid();
			TMap<ESceneInteractionEffect, SScenePropertyEffect> result;
			if ((result = this._Effects) == null)
			{
				result = (this._Effects = new TMap<ESceneInteractionEffect, SScenePropertyEffect>(base.NativePtr + (IntPtr)SceneInteractionActor.__PropertyOffset_Effects, this));
			}
			return result;
		}
	}

	// Token: 0x17002C1A RID: 11290
	// (get) Token: 0x0601B050 RID: 110672 RVA: 0x00848E8C File Offset: 0x0084708C
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<BP_EffectActor_C> EffectsInheritTimeDilation
	{
		get
		{
			base.FastCheckIsValid();
			TArray<BP_EffectActor_C> result;
			if ((result = this._EffectsInheritTimeDilation) == null)
			{
				result = (this._EffectsInheritTimeDilation = new TArray<BP_EffectActor_C>(base.NativePtr + (IntPtr)SceneInteractionActor.__PropertyOffset_EffectsInheritTimeDilation, this));
			}
			return result;
		}
	}

	// Token: 0x17002C1B RID: 11291
	// (get) Token: 0x0601B051 RID: 110673 RVA: 0x00848EC8 File Offset: 0x008470C8
	[Nullable(new byte[]
	{
		1,
		2
	})]
	[UProperty(EPropertyFlags.CPF_None)]
	public TMap<ESceneInteractionEffect, BP_EffectActor_C> EndEffects
	{
		[return: Nullable(new byte[]
		{
			1,
			2
		})]
		get
		{
			base.FastCheckIsValid();
			TMap<ESceneInteractionEffect, BP_EffectActor_C> result;
			if ((result = this._EndEffects) == null)
			{
				result = (this._EndEffects = new TMap<ESceneInteractionEffect, BP_EffectActor_C>(base.NativePtr + (IntPtr)SceneInteractionActor.__PropertyOffset_EndEffects, this));
			}
			return result;
		}
	}

	// Token: 0x17002C1C RID: 11292
	// (get) Token: 0x0601B052 RID: 110674 RVA: 0x00848F04 File Offset: 0x00847104
	[UProperty(EPropertyFlags.CPF_None)]
	public TMap<string, AActor> ReferenceActors
	{
		get
		{
			base.FastCheckIsValid();
			TMap<string, AActor> result;
			if ((result = this._ReferenceActors) == null)
			{
				result = (this._ReferenceActors = new TMap<string, AActor>(base.NativePtr + (IntPtr)SceneInteractionActor.__PropertyOffset_ReferenceActors, this));
			}
			return result;
		}
	}

	// Token: 0x17002C1D RID: 11293
	// (get) Token: 0x0601B053 RID: 110675 RVA: 0x00848F40 File Offset: 0x00847140
	[UProperty(EPropertyFlags.CPF_None)]
	public TMap<FGameplayTag, SSceneInteractionTags> TagsAndCorrespondingEffects
	{
		get
		{
			base.FastCheckIsValid();
			TMap<FGameplayTag, SSceneInteractionTags> result;
			if ((result = this._TagsAndCorrespondingEffects) == null)
			{
				result = (this._TagsAndCorrespondingEffects = new TMap<FGameplayTag, SSceneInteractionTags>(base.NativePtr + (IntPtr)SceneInteractionActor.__PropertyOffset_TagsAndCorrespondingEffects, this));
			}
			return result;
		}
	}

	// Token: 0x17002C1E RID: 11294
	// (get) Token: 0x0601B054 RID: 110676 RVA: 0x00848F7C File Offset: 0x0084717C
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<AActor> CollisionActors
	{
		get
		{
			base.FastCheckIsValid();
			TArray<AActor> result;
			if ((result = this._CollisionActors) == null)
			{
				result = (this._CollisionActors = new TArray<AActor>(base.NativePtr + (IntPtr)SceneInteractionActor.__PropertyOffset_CollisionActors, this));
			}
			return result;
		}
	}

	// Token: 0x17002C1F RID: 11295
	// (get) Token: 0x0601B055 RID: 110677 RVA: 0x00848FB8 File Offset: 0x008471B8
	[UProperty(EPropertyFlags.CPF_None)]
	public TMap<AActor, FGameplayTag> PartCollisionActorsAndCorrespondingTags
	{
		get
		{
			base.FastCheckIsValid();
			TMap<AActor, FGameplayTag> result;
			if ((result = this._PartCollisionActorsAndCorrespondingTags) == null)
			{
				result = (this._PartCollisionActorsAndCorrespondingTags = new TMap<AActor, FGameplayTag>(base.NativePtr + (IntPtr)SceneInteractionActor.__PropertyOffset_PartCollisionActorsAndCorrespondingTags, this));
			}
			return result;
		}
	}

	// Token: 0x17002C20 RID: 11296
	// (get) Token: 0x0601B056 RID: 110678 RVA: 0x00848FF4 File Offset: 0x008471F4
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<AActor> InteractionEffectHookActors
	{
		get
		{
			base.FastCheckIsValid();
			TArray<AActor> result;
			if ((result = this._InteractionEffectHookActors) == null)
			{
				result = (this._InteractionEffectHookActors = new TArray<AActor>(base.NativePtr + (IntPtr)SceneInteractionActor.__PropertyOffset_InteractionEffectHookActors, this));
			}
			return result;
		}
	}

	// Token: 0x17002C21 RID: 11297
	// (get) Token: 0x0601B057 RID: 110679 RVA: 0x0084902D File Offset: 0x0084722D
	// (set) Token: 0x0601B058 RID: 110680 RVA: 0x00849041 File Offset: 0x00847241
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe TsBaseCharacter CharacterForOrgan
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + SceneInteractionActor.__PropertyOffset_CharacterForOrgan);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SceneInteractionActor.__PropertyOffset_CharacterForOrgan, value);
		}
	}

	// Token: 0x17002C22 RID: 11298
	// (get) Token: 0x0601B059 RID: 110681 RVA: 0x00849058 File Offset: 0x00847258
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<AActor> ActorsForProjection
	{
		get
		{
			base.FastCheckIsValid();
			TArray<AActor> result;
			if ((result = this._ActorsForProjection) == null)
			{
				result = (this._ActorsForProjection = new TArray<AActor>(base.NativePtr + (IntPtr)SceneInteractionActor.__PropertyOffset_ActorsForProjection, this));
			}
			return result;
		}
	}

	// Token: 0x17002C23 RID: 11299
	// (get) Token: 0x0601B05A RID: 110682 RVA: 0x00849091 File Offset: 0x00847291
	// (set) Token: 0x0601B05B RID: 110683 RVA: 0x008490A5 File Offset: 0x008472A5
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UMaterialInstance MaterialForProjection
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + SceneInteractionActor.__PropertyOffset_MaterialForProjection);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SceneInteractionActor.__PropertyOffset_MaterialForProjection, value);
		}
	}

	// Token: 0x17002C24 RID: 11300
	// (get) Token: 0x0601B05C RID: 110684 RVA: 0x008490BC File Offset: 0x008472BC
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<AActor> ReceivingDecalsActors
	{
		get
		{
			base.FastCheckIsValid();
			TArray<AActor> result;
			if ((result = this._ReceivingDecalsActors) == null)
			{
				result = (this._ReceivingDecalsActors = new TArray<AActor>(base.NativePtr + (IntPtr)SceneInteractionActor.__PropertyOffset_ReceivingDecalsActors, this));
			}
			return result;
		}
	}

	// Token: 0x17002C25 RID: 11301
	// (get) Token: 0x0601B05D RID: 110685 RVA: 0x008490F8 File Offset: 0x008472F8
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<UStaticMesh> StaticMeshList
	{
		get
		{
			base.FastCheckIsValid();
			TArray<UStaticMesh> result;
			if ((result = this._StaticMeshList) == null)
			{
				result = (this._StaticMeshList = new TArray<UStaticMesh>(base.NativePtr + (IntPtr)SceneInteractionActor.__PropertyOffset_StaticMeshList, this));
			}
			return result;
		}
	}

	// Token: 0x17002C26 RID: 11302
	// (get) Token: 0x0601B05E RID: 110686 RVA: 0x00849131 File Offset: 0x00847331
	// (set) Token: 0x0601B05F RID: 110687 RVA: 0x00849141 File Offset: 0x00847341
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe BPELevelPrefabDestructibleOverlapSource RangeOtherActorVelocitySource
	{
		get
		{
			return (BPELevelPrefabDestructibleOverlapSource)(*(base.NativePtr + (IntPtr)SceneInteractionActor.__PropertyOffset_RangeOtherActorVelocitySource));
		}
		set
		{
			*(base.NativePtr + (IntPtr)SceneInteractionActor.__PropertyOffset_RangeOtherActorVelocitySource) = (byte)value;
		}
	}

	// Token: 0x17002C27 RID: 11303
	// (get) Token: 0x0601B060 RID: 110688 RVA: 0x00849154 File Offset: 0x00847354
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<ASkeletalMeshActor> SkeletalMeshActors
	{
		get
		{
			base.FastCheckIsValid();
			TArray<ASkeletalMeshActor> result;
			if ((result = this._SkeletalMeshActors) == null)
			{
				result = (this._SkeletalMeshActors = new TArray<ASkeletalMeshActor>(base.NativePtr + (IntPtr)SceneInteractionActor.__PropertyOffset_SkeletalMeshActors, this));
			}
			return result;
		}
	}

	// Token: 0x17002C28 RID: 11304
	// (get) Token: 0x0601B061 RID: 110689 RVA: 0x00849190 File Offset: 0x00847390
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<ASkeletalMeshActor> AllSkeletalMeshActors
	{
		get
		{
			base.FastCheckIsValid();
			TArray<ASkeletalMeshActor> result;
			if ((result = this._AllSkeletalMeshActors) == null)
			{
				result = (this._AllSkeletalMeshActors = new TArray<ASkeletalMeshActor>(base.NativePtr + (IntPtr)SceneInteractionActor.__PropertyOffset_AllSkeletalMeshActors, this));
			}
			return result;
		}
	}

	// Token: 0x17002C29 RID: 11305
	// (get) Token: 0x0601B062 RID: 110690 RVA: 0x008491C9 File Offset: 0x008473C9
	// (set) Token: 0x0601B063 RID: 110691 RVA: 0x008491DD File Offset: 0x008473DD
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe BP_InteractionMaterialController_C InteractionMaterialController
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<BP_InteractionMaterialController_C>(base.NativePtr / (IntPtr)sizeof(void*) + SceneInteractionActor.__PropertyOffset_InteractionMaterialController);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SceneInteractionActor.__PropertyOffset_InteractionMaterialController, value);
		}
	}

	// Token: 0x17002C2A RID: 11306
	// (get) Token: 0x0601B064 RID: 110692 RVA: 0x008491F2 File Offset: 0x008473F2
	private HashSet<AKuroDestructibleActor> SkeletalMeshDestructibleActors
	{
		get
		{
			if (this.SkeletalMeshDestructibleActorsInternal == null)
			{
				this.SkeletalMeshDestructibleActorsInternal = new HashSet<AKuroDestructibleActor>();
			}
			return this.SkeletalMeshDestructibleActorsInternal;
		}
	}

	// Token: 0x17002C2B RID: 11307
	// (get) Token: 0x0601B065 RID: 110693 RVA: 0x0084920D File Offset: 0x0084740D
	// (set) Token: 0x0601B066 RID: 110694 RVA: 0x00849221 File Offset: 0x00847421
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe AActor OverrideEffectActor
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + SceneInteractionActor.__PropertyOffset_OverrideEffectActor);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SceneInteractionActor.__PropertyOffset_OverrideEffectActor, value);
		}
	}

	// Token: 0x0601B067 RID: 110695 RVA: 0x00849238 File Offset: 0x00847438
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetOverrideSeqBindActor(AActor actorToBind, [Nullable(2)] string bindingName = null)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetOverrideSeqBindActor"), SceneInteractionActor.StaticClass(), out intPtr, out num))
		{
			this.SetOverrideSeqBindActor_Implementation(actorToBind, bindingName);
			return;
		}
		SceneInteractionActor.__SetOverrideSeqBindActor_FunctionParams* ptr = stackalloc SceneInteractionActor.__SetOverrideSeqBindActor_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(SceneInteractionActor.__SetOverrideSeqBindActor_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->actorToBind) = ((actorToBind != null) ? actorToBind.NativePtr : ((IntPtr)0));
		FString.CopyFrom((void*)(&ptr->bindingName), bindingName);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601B068 RID: 110696 RVA: 0x008492E0 File Offset: 0x008474E0
	protected unsafe void SetOverrideSeqBindActor_Implementation(AActor actorToBind, [Nullable(2)] string bindingName = null)
	{
		if (this.OverrideSeqBindActors == null)
		{
			this.OverrideSeqBindActors = new Dictionary<string, AActor>();
		}
		if (actorToBind == null || !actorToBind.IsValid())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Interaction;
			ELogAuthor author = ELogAuthor.ZYL;
			string message = "[SetOverrideSeqBindActor] 传入的Actor无效";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PbDataId", this.PbDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("LevelName", this.LevelName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("BindingName", bindingName);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return;
		}
		string key = bindingName ?? UKismetSystemLibrary.GetDisplayName(actorToBind);
		string.IsNullOrEmpty(bindingName);
		if (this.OverrideSeqBindActors.ContainsKey(key) && this.OverrideSeqBindActors[key] == actorToBind)
		{
			return;
		}
		this.OverrideSeqBindActors[key] = actorToBind;
	}

	// Token: 0x0601B069 RID: 110697 RVA: 0x008493D0 File Offset: 0x008475D0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void UnsetOverrideSeqBindActor(AActor actorToUnbind, [Nullable(2)] string bindingName = null)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("UnsetOverrideSeqBindActor"), SceneInteractionActor.StaticClass(), out intPtr, out num))
		{
			this.UnsetOverrideSeqBindActor_Implementation(actorToUnbind, bindingName);
			return;
		}
		SceneInteractionActor.__UnsetOverrideSeqBindActor_FunctionParams* ptr = stackalloc SceneInteractionActor.__UnsetOverrideSeqBindActor_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(SceneInteractionActor.__UnsetOverrideSeqBindActor_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->actorToUnbind) = ((actorToUnbind != null) ? actorToUnbind.NativePtr : ((IntPtr)0));
		FString.CopyFrom((void*)(&ptr->bindingName), bindingName);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601B06A RID: 110698 RVA: 0x00849478 File Offset: 0x00847678
	protected void UnsetOverrideSeqBindActor_Implementation(AActor actorToUnbind, [Nullable(2)] string bindingName = null)
	{
		if (this.OverrideSeqBindActors == null)
		{
			return;
		}
		string key = bindingName ?? UKismetSystemLibrary.GetDisplayName(actorToUnbind);
		string.IsNullOrEmpty(bindingName);
		if (!this.OverrideSeqBindActors.ContainsKey(key))
		{
			return;
		}
		if (this.OverrideSeqBindActors[key] != actorToUnbind)
		{
			return;
		}
		this.OverrideSeqBindActors.Remove(key);
	}

	// Token: 0x17002C2C RID: 11308
	// (get) Token: 0x0601B06B RID: 110699 RVA: 0x008494D0 File Offset: 0x008476D0
	[Nullable(2)]
	public BP_BasePlatform_C BasePlatform
	{
		[NullableContext(2)]
		get
		{
			if (this.BasePlatformInternal == null)
			{
				AActor attachParentActor = base.GetAttachParentActor();
				if (attachParentActor == null)
				{
					return null;
				}
				this.BasePlatformInternal = (ActorSystem.Instance.Get(BP_BasePlatform_C.StaticClass(), base.D_GetTransform(), attachParentActor, true) as BP_BasePlatform_C);
				AttachToActorController.Instance.AttachToActor(this.BasePlatformInternal, attachParentActor, EDetachType.EntityDestroy, "SceneInteractionActor.BasePlatform", null, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, false, true, false, false, false);
				AActor aactor = null;
				if (this.CollisionActors.Num() > 0)
				{
					aactor = this.CollisionActors.Get(0);
				}
				if (aactor == null)
				{
					aactor = attachParentActor;
				}
				FVector fvector = new FVector();
				FVectorDouble fvectorDouble = new FVectorDouble();
				aactor.D_GetActorBounds(true, ref fvectorDouble, ref fvector, true);
				FVector fvector2 = fvector;
				float num = Math.Max(fvector2.X, Math.Max(fvector2.Y, fvector2.Z));
				num += 50f;
				this.BasePlatformInternal.LeaveSphereRadius = num;
				this.BasePlatformInternal.LeaveSphereCenter = new FVector(0f, 0f, 0f);
			}
			return this.BasePlatformInternal;
		}
	}

	// Token: 0x0601B06C RID: 110700 RVA: 0x008495DC File Offset: 0x008477DC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void ReceiveBeginPlay()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveBeginPlay"), SceneInteractionActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ReceiveBeginPlay_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B06D RID: 110701 RVA: 0x00849638 File Offset: 0x00847838
	protected virtual void ReceiveBeginPlay_Implementation()
	{
		this.PlayingTagAkEventHandle = new Dictionary<FGameplayTag, int>();
	}

	// Token: 0x0601B06E RID: 110702 RVA: 0x00849650 File Offset: 0x00847850
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveEndPlay"), SceneInteractionActor.StaticClass(), out intPtr, out num))
		{
			this.ReceiveEndPlay_Implementation(EndPlayReason);
			return;
		}
		AActor.__ReceiveEndPlay_FunctionParams* ptr = stackalloc AActor.__ReceiveEndPlay_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AActor.__ReceiveEndPlay_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(byte*)(&ptr->EndPlayReason) = (byte)EndPlayReason;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601B06F RID: 110703 RVA: 0x008496E0 File Offset: 0x008478E0
	protected virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
	{
		if (this.BasePlatformInternal != null)
		{
			ActorSystem.Instance.Put("SceneInteractionActor.ReceiveEndPlay1", this.BasePlatformInternal, null);
		}
		if (this.GlobalGi != null)
		{
			ActorSystem.Instance.Put("SceneInteractionActor.ReceiveEndPlay2", this.GlobalGi, null);
		}
		this.StopCurrentStateAkEvent("清除状态及tag相关音效");
		if (this.PlayingTagAkEventHandle != null && this.PlayingTagAkEventHandle.Count > 0)
		{
			foreach (int handle in this.PlayingTagAkEventHandle.Values)
			{
				AudioSystem.Instance.ExecuteAction(handle, EAudioActionType.Stop, null);
			}
			this.PlayingTagAkEventHandle.Clear();
		}
		this.RemoveDebugTicker();
		this.RemovePendingStateEffectTick();
		this.RemovePendingCrossStateEffectTick();
		this.RemovePendingTagEffectTick();
	}

	// Token: 0x0601B070 RID: 110704 RVA: 0x008497C8 File Offset: 0x008479C8
	private void RemoveDebugTicker()
	{
		if (this.DebugTickId != -1)
		{
			TickSystem.Instance.Remove(this.DebugTickId);
			this.DebugTickId = -1;
		}
	}

	// Token: 0x0601B071 RID: 110705 RVA: 0x008497EC File Offset: 0x008479EC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void AddNewState()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("AddNewState"), SceneInteractionActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.AddNewState_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B072 RID: 110706 RVA: 0x00849845 File Offset: 0x00847A45
	protected void AddNewState_Implementation()
	{
		this.States.Add((EKuroSceneInteractionState)this.States.Num(), null);
	}

	// Token: 0x0601B073 RID: 110707 RVA: 0x00849860 File Offset: 0x00847A60
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void AddNewEffect()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("AddNewEffect"), SceneInteractionActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.AddNewEffect_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B074 RID: 110708 RVA: 0x008498B9 File Offset: 0x00847AB9
	protected void AddNewEffect_Implementation()
	{
		this.Effects.Add((ESceneInteractionEffect)this.Effects.Num(), null);
	}

	// Token: 0x0601B075 RID: 110709 RVA: 0x008498D4 File Offset: 0x00847AD4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void AddNewEndEffect()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("AddNewEndEffect"), SceneInteractionActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.AddNewEndEffect_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B076 RID: 110710 RVA: 0x0084992D File Offset: 0x00847B2D
	protected void AddNewEndEffect_Implementation()
	{
		this.EndEffects.Add((ESceneInteractionEffect)this.EndEffects.Num(), null);
	}

	// Token: 0x0601B077 RID: 110711 RVA: 0x00849948 File Offset: 0x00847B48
	public void ChangeDirection(bool bPlayBack)
	{
		if ((bPlayBack && !this.IsPlayBack) || (!bPlayBack && this.IsPlayBack))
		{
			if (this.ActiveSequencePlayer != null)
			{
				this.ActiveSequencePlayer.ChangePlaybackDirection();
			}
			if (this.CurrentState.AnimMontage.Montage != null && this.CurrentState.AnimMontage.SkeletalMesh != null)
			{
				this.CurrentState.AnimMontage.SkeletalMesh.SkeletalMeshComponent.SetPlayRate(-this.CurrentState.AnimMontage.SkeletalMesh.SkeletalMeshComponent.GetPlayRate());
			}
			this.IsPlayBack = !this.IsPlayBack;
		}
	}

	// Token: 0x0601B078 RID: 110712 RVA: 0x008499E9 File Offset: 0x00847BE9
	public void PlayStateBpMaterialRuntimeParUpdate(SSceneInteractionitem state)
	{
		if (state.BP_MaterialRuntimeParUpdate != null)
		{
			state.BP_MaterialRuntimeParUpdate.IsPlay = true;
			state.BP_MaterialRuntimeParUpdate.Set_Initialize();
		}
	}

	// Token: 0x0601B079 RID: 110713 RVA: 0x00849A0C File Offset: 0x00847C0C
	public void PlayIndependentEffect(ESceneInteractionEffect effectKey)
	{
		SScenePropertyEffect valueOrDefault = this.Effects.GetValueOrDefault(effectKey);
		if (valueOrDefault == null)
		{
			return;
		}
		if (valueOrDefault.Effect != null)
		{
			this.PlayEffect(valueOrDefault.Effect, "[SceneInteractionActor.PlayIndependentEffect]");
		}
		if (valueOrDefault.Material != null)
		{
			for (int i = 0; i < valueOrDefault.Material.Actors.Num(); i++)
			{
				if (valueOrDefault.Material.Actors.Get(i) != null && valueOrDefault.Material.Data != null)
				{
					valueOrDefault.Material.TailIndex = (float)ItemMaterialManager.Instance.AddMaterialData(valueOrDefault.Material.Actors.Get(i), valueOrDefault.Material.Data);
				}
			}
			this.Effects[effectKey] = valueOrDefault;
		}
	}

	// Token: 0x0601B07A RID: 110714 RVA: 0x00849AD4 File Offset: 0x00847CD4
	public void EndIndependentEffect(ESceneInteractionEffect effectKey)
	{
		SScenePropertyEffect valueOrDefault = this.Effects.GetValueOrDefault(effectKey);
		if (valueOrDefault == null)
		{
			return;
		}
		if (valueOrDefault.Effect != null)
		{
			this.StopEffect(valueOrDefault.Effect, "[SceneInteractionActor.EndIndependentEffect]", false);
		}
		if (ItemMaterialManager.Instance.AllActorControllerInfoMap != null)
		{
			for (int i = 0; i < valueOrDefault.Material.Actors.Num(); i++)
			{
				int handle = (int)valueOrDefault.Material.TailIndex - i;
				ItemMaterialManager.Instance.DisableActorData(handle);
			}
		}
	}

	// Token: 0x0601B07B RID: 110715 RVA: 0x00849B54 File Offset: 0x00847D54
	public void PlayIndependentEndEffect(ESceneInteractionEffect effectKey)
	{
		BP_EffectActor_C valueOrDefault = this.EndEffects.GetValueOrDefault(effectKey);
		if (valueOrDefault == null)
		{
			return;
		}
		this.PlayEffect(valueOrDefault, "[SceneInteractionActor.PlayIndependentEndEffect]");
	}

	// Token: 0x0601B07C RID: 110716 RVA: 0x00849B80 File Offset: 0x00847D80
	public void Update(float deltaSeconds)
	{
		if (deltaSeconds > 0f && this.SkeletalMontageConfigMap != null)
		{
			foreach (KeyValuePair<ASkeletalMeshActor, SkeletalMontageConfig> keyValuePair in this.SkeletalMontageConfigMap)
			{
				ASkeletalMeshActor key = keyValuePair.Key;
				SkeletalMontageConfig value = keyValuePair.Value;
				if (value.IsPendingApplyProps())
				{
					value.PendingFrameCount--;
					if (value.PendingFrameCount <= 0 && key.SkeletalMeshComponent != null)
					{
						key.SkeletalMeshComponent.SetHiddenInGame(value.PendingCompHiddenInGame, false);
						key.SkeletalMeshComponent.VisibilityBasedAnimTickOption = value.PendingCompVisibilityBasedAnimTickOption;
					}
				}
			}
		}
		if (this.InTransition || this.InWaitingForPlayableFinished)
		{
			if (!this.CheckPlaying(deltaSeconds, this.CurrentState))
			{
				this.DoSwitchState(false);
				return;
			}
		}
		else if (this.NextState != null || this.PendingStates.First != null)
		{
			SSceneInteractionitem currentState = this.CurrentState;
			this.DoSwitchState(currentState != null && currentState.WaitForPlayableFinished);
		}
	}

	// Token: 0x0601B07D RID: 110717 RVA: 0x00849C90 File Offset: 0x00847E90
	public void SetTimeDilation(float customTimeDilation)
	{
		if (base.CustomTimeDilation != customTimeDilation)
		{
			base.CustomTimeDilation = customTimeDilation;
			this.UpdateTimeDilation();
		}
	}

	// Token: 0x0601B07E RID: 110718 RVA: 0x00849CA8 File Offset: 0x00847EA8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected virtual void UpdateTimeDilation()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("UpdateTimeDilation"), SceneInteractionActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.UpdateTimeDilation_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B07F RID: 110719 RVA: 0x00849D04 File Offset: 0x00847F04
	protected void UpdateTimeDilation_Implementation()
	{
		if (this.CurrentState == null)
		{
			return;
		}
		float customTimeDilation = base.CustomTimeDilation;
		SSceneInteractionMontage animMontage = this.CurrentState.AnimMontage;
		if (animMontage.SkeletalMesh != null)
		{
			USkeletalMeshComponent skeletalMeshComponent = animMontage.SkeletalMesh.SkeletalMeshComponent;
			if (skeletalMeshComponent.GetAnimationMode() == EAnimationMode.AnimationBlueprint)
			{
				UAnimInstance animInstance = skeletalMeshComponent.GetAnimInstance();
				if (animInstance != null)
				{
					ABP_LevelPrefabDaiyu_C abp_LevelPrefabDaiyu_C = animInstance as ABP_LevelPrefabDaiyu_C;
					if (abp_LevelPrefabDaiyu_C != null)
					{
						abp_LevelPrefabDaiyu_C.SetPlayRate(base.CustomTimeDilation);
					}
					else
					{
						skeletalMeshComponent.SetPlayRate(animMontage.PlayRate * customTimeDilation);
					}
				}
			}
			else
			{
				skeletalMeshComponent.SetPlayRate(animMontage.PlayRate * customTimeDilation);
			}
		}
		if (this.ActiveSequenceDirectorMap != null && this.DirectorConfigMap != null)
		{
			foreach (ALevelSequenceActor alevelSequenceActor in this.ActiveSequenceDirectorMap.Values)
			{
				ULevelSequencePlayer sequencePlayer = alevelSequenceActor.SequencePlayer;
				SequenceDirectorConfig sequenceDirectorConfig;
				if (this.DirectorConfigMap.TryGetValue(alevelSequenceActor, out sequenceDirectorConfig) && sequencePlayer != null && sequencePlayer.IsValid())
				{
					sequencePlayer.SetPlayRate(sequenceDirectorConfig.PlayRate * customTimeDilation);
				}
			}
		}
		if (this.ActiveEffectInfoMap != null && this.ActiveEffectInfoMap.Count > 0)
		{
			foreach (EffectInfo effectInfo in this.ActiveEffectInfoMap.Values)
			{
				if (effectInfo.IsInheritTimeDilation && EffectSystem.Instance.IsValid(effectInfo.EffectId))
				{
					EffectSystem.Instance.SetTimeScale(effectInfo.EffectId, customTimeDilation, false);
				}
			}
		}
	}

	// Token: 0x0601B080 RID: 110720 RVA: 0x00849EB8 File Offset: 0x008480B8
	public void Init(int pbDataId, int handleId, string levelName, [Nullable(2)] Action onInit, int entityId = 0)
	{
		this.PbDataId = pbDataId;
		this.HandleId = handleId;
		this.EntityId = entityId;
		this.LevelName = levelName;
		this.OnInitCallback = onInit;
		this.CurrentStateKey = new EKuroSceneInteractionState?(EKuroSceneInteractionState.Error);
		this.PendingStates.Clear();
		this.NextState = null;
		this.InTransition = false;
		this.InWaitingForPlayableFinished = false;
		this.IsUseTransitionTime = false;
		this.SwitchingStateRemainTime = 0f;
		this.CurrentState = null;
		this.IsPlayBack = false;
		this.Active = true;
		TsBaseCharacter characterForOrgan = this.CharacterForOrgan;
		if (characterForOrgan != null && characterForOrgan.IsValid())
		{
			AActor characterForOrgan2 = this.CharacterForOrgan;
			TSubclassOf<UActorComponent> @class = CharRenderingComponent.StaticClass();
			bool bManualAttachment = false;
			FTransformDouble ftransformDouble = base.D_GetTransform();
			this.CharRenderingComponent = (characterForOrgan2.D_AddComponentByClass(@class, bManualAttachment, ftransformDouble, false, default(FName)) as CharRenderingComponent);
			this.CharRenderingComponent.Init(this.CharacterForOrgan.RenderType);
			this.CharRenderingKey = 0;
		}
		this.CharRenderingComponents = new Dictionary<CharRenderingComponent, int>();
		if (this.SkeletalMeshActors != null)
		{
			for (int i = 0; i < this.SkeletalMeshActors.Num(); i++)
			{
				ASkeletalMeshActor askeletalMeshActor = this.SkeletalMeshActors.Get(i);
				if (askeletalMeshActor != null)
				{
					CharRenderingComponent charRenderingComponent = askeletalMeshActor.AddComponentByClass(CharRenderingComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName)) as CharRenderingComponent;
					this.CharRenderingComponents.Add(charRenderingComponent, i);
					charRenderingComponent.Init(ECharacterRenderingType.Monster);
					if (askeletalMeshActor.SkeletalMeshComponent != null)
					{
						charRenderingComponent.AddComponentByCase(ECharacterControllerCaseType.BodyCase0, askeletalMeshActor.SkeletalMeshComponent);
					}
				}
			}
		}
		this.OnEffectFinishCallback = delegate(int handle)
		{
			Dictionary<int, EffectInfo> activeEffectInfoMap = this.ActiveEffectInfoMap;
			if (activeEffectInfoMap == null)
			{
				return;
			}
			activeEffectInfoMap.Remove(handle);
		};
		this.OnEffectPlayingCallback = delegate(ELoadEffectResult _, int handle)
		{
			if (!this.IsValid())
			{
				return;
			}
			EffectInfo effectInfo;
			if (this.ActiveEffectInfoMap != null && this.ActiveEffectInfoMap.TryGetValue(handle, out effectInfo))
			{
				effectInfo.IsPlaying = true;
			}
			if (this.CheckAllEffectPlaying())
			{
				EventSystem.Instance.Emit<int>(EEventName.OnSceneInteractionAllEffectPlaying, this.HandleId);
			}
		};
		if (this.States != null)
		{
			for (int j = 0; j < this.States.Num(); j++)
			{
				if (this.States.IsValidIndex(j))
				{
					EKuroSceneInteractionState key = this.States.GetKey(j);
					SSceneInteractionitem valueOrDefault = this.States.GetValueOrDefault(key);
					if (!(valueOrDefault == null) && valueOrDefault.CrossStateEffects != null)
					{
						for (int k = 0; k < valueOrDefault.CrossStateEffects.Num(); k++)
						{
							SSceneInteractionCrossStateEffect ssceneInteractionCrossStateEffect = valueOrDefault.CrossStateEffects.Get(k);
							if (!(ssceneInteractionCrossStateEffect == null) && ssceneInteractionCrossStateEffect.Effect != null)
							{
								if (this.CrossStateEffectActors == null)
								{
									this.CrossStateEffectActors = new HashSet<BP_EffectActor_C>();
								}
								this.CrossStateEffectActors.Add(ssceneInteractionCrossStateEffect.Effect);
							}
						}
					}
				}
			}
		}
		if (this.ReferenceActors != null && this.ReferenceActors.Num() > 0)
		{
			this.ActorsOriginalRelTransform = new Dictionary<AActor, FTransformDouble>();
			for (int l = 0; l < this.ReferenceActors.Num(); l++)
			{
				string key2 = this.ReferenceActors.GetKey(l);
				AActor valueOrDefault2 = this.ReferenceActors.GetValueOrDefault(key2);
				if (valueOrDefault2 != null)
				{
					FTransformDouble ftransformDouble = valueOrDefault2.D_GetTransform();
					FTransformDouble ftransformDouble2 = base.D_GetTransform();
					FTransformDouble relativeTransform = ftransformDouble.GetRelativeTransform(ftransformDouble2);
					this.ActorsOriginalRelTransform[valueOrDefault2] = relativeTransform;
				}
			}
		}
		this.RevertMaterialComponentsMaps = new Dictionary<UStaticMeshComponent, Dictionary<int, UMaterialInterface>>();
		if (this.States != null)
		{
			int m = 0;
			int num = this.States.Num();
			while (m < num)
			{
				EKuroSceneInteractionState key3 = this.States.GetKey(m);
				SSceneInteractionitem valueOrDefault3 = this.States.GetValueOrDefault(key3);
				foreach (TArray<AKuroDestructibleActor> tarray in new List<TArray<AKuroDestructibleActor>>
				{
					valueOrDefault3.SkeletalMeshDestructible.PlayDestructionAllImmediately,
					valueOrDefault3.SkeletalMeshDestructible.CanPlayDestructionWhenHit
				})
				{
					int n = 0;
					int num2 = tarray.Num();
					while (n < num2)
					{
						AKuroDestructibleActor akuroDestructibleActor = tarray.Get(n);
						if (akuroDestructibleActor != null && akuroDestructibleActor.IsValid())
						{
							this.SkeletalMeshDestructibleActors.Add(akuroDestructibleActor);
						}
						n++;
					}
				}
				m++;
			}
		}
		if (this.TagsAndCorrespondingEffects != null)
		{
			int num3 = 0;
			int num4 = this.TagsAndCorrespondingEffects.Num();
			while (num3 < num4)
			{
				FGameplayTag key4 = this.TagsAndCorrespondingEffects.GetKey(num3);
				SSceneInteractionTags valueOrDefault4 = this.TagsAndCorrespondingEffects.GetValueOrDefault(key4);
				int num5 = 0;
				int num6 = valueOrDefault4.SkeletalMeshDestructibleActors.Num();
				while (num5 < num6)
				{
					AKuroDestructibleActor akuroDestructibleActor2 = valueOrDefault4.SkeletalMeshDestructibleActors.Get(num5);
					if (akuroDestructibleActor2 != null && akuroDestructibleActor2.IsValid())
					{
						this.SkeletalMeshDestructibleActors.Add(akuroDestructibleActor2);
					}
					num5++;
				}
				num3++;
			}
		}
		if (this.SkeletalMeshDestructibleActors != null && this.SkeletalMeshDestructibleActors.Count > 0)
		{
			this.SkeletalMeshDestructibleActorInitCount = 0;
			using (HashSet<AKuroDestructibleActor>.Enumerator enumerator2 = this.SkeletalMeshDestructibleActors.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					AKuroDestructibleActor akuroDestructibleActor3 = enumerator2.Current;
					akuroDestructibleActor3.TrunksInitializedDelegate.Bind(new Action(this.OnTrunksInitialized));
				}
				goto IL_4E8;
			}
		}
		Action onInitCallback = this.OnInitCallback;
		if (onInitCallback != null)
		{
			onInitCallback();
		}
		IL_4E8:
		if (!LevelPrefabConfigModel.Instance.IsCloseUroPrefab(this.LevelName))
		{
			this.ApplyAnimOptimizationParams(true);
		}
	}

	// Token: 0x0601B081 RID: 110721 RVA: 0x0084A3E4 File Offset: 0x008485E4
	public void Clear()
	{
		this.SkeletalMeshDestructibleActorsInternal = null;
		if (this.ActiveSequenceDirectorMap == null)
		{
			return;
		}
		foreach (ULevelSequence sequence in this.ActiveSequenceDirectorMap.Keys)
		{
			this.StopSequence(sequence);
		}
	}

	// Token: 0x0601B082 RID: 110722 RVA: 0x0084A44C File Offset: 0x0084864C
	private void OnTrunksInitialized()
	{
		if (this.SkeletalMeshDestructibleActors != null)
		{
			this.SkeletalMeshDestructibleActorInitCount++;
			if (this.SkeletalMeshDestructibleActorInitCount >= this.SkeletalMeshDestructibleActors.Count)
			{
				foreach (AKuroDestructibleActor akuroDestructibleActor in this.SkeletalMeshDestructibleActors)
				{
					akuroDestructibleActor.TrunksInitializedDelegate.Unbind();
				}
				Action onInitCallback = this.OnInitCallback;
				if (onInitCallback == null)
				{
					return;
				}
				onInitCallback();
			}
		}
	}

	// Token: 0x0601B083 RID: 110723 RVA: 0x0084A4DC File Offset: 0x008486DC
	[return: Nullable(2)]
	public AActor GetActorByKey(string key)
	{
		if (this.ReferenceActors == null)
		{
			return null;
		}
		AActor result;
		if (!this.ReferenceActors.TryGetValue(key, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x0601B084 RID: 110724 RVA: 0x0084A508 File Offset: 0x00848708
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public TArray<AActor> GetRefActorsByTag(FGameplayTag tag)
	{
		SSceneInteractionTags ssceneInteractionTags;
		if (this.TagsAndCorrespondingEffects == null || !this.TagsAndCorrespondingEffects.TryGetValue(tag, out ssceneInteractionTags))
		{
			return null;
		}
		if (ssceneInteractionTags == null)
		{
			return null;
		}
		return ssceneInteractionTags.Actors;
	}

	// Token: 0x0601B085 RID: 110725 RVA: 0x0084A53A File Offset: 0x0084873A
	[return: Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public TMap<string, AActor> GetAllActor()
	{
		if (this.ReferenceActors != null)
		{
			return this.ReferenceActors;
		}
		return null;
	}

	// Token: 0x0601B086 RID: 110726 RVA: 0x0084A54C File Offset: 0x0084874C
	public FTransformDouble? GetActorOriginalRelTransform(AActor actor)
	{
		if (this.ActorsOriginalRelTransform == null || (actor == null || !actor.IsValid()))
		{
			return null;
		}
		FTransformDouble value;
		if (this.ActorsOriginalRelTransform.TryGetValue(actor, out value))
		{
			return new FTransformDouble?(value);
		}
		return null;
	}

	// Token: 0x0601B087 RID: 110727 RVA: 0x0084A59C File Offset: 0x0084879C
	public EKuroSceneInteractionState GetCurrentState()
	{
		return this.CurrentStateKey.Value;
	}

	// Token: 0x0601B088 RID: 110728 RVA: 0x0084A5AC File Offset: 0x008487AC
	private void PlayEffect(BP_EffectActor_C effectActor, string reason)
	{
		if (effectActor == null || !effectActor.IsValid())
		{
			return;
		}
		TArray<BP_EffectActor_C> effectsInheritTimeDilation = this.EffectsInheritTimeDilation;
		bool isInheritTimeDilation = effectsInheritTimeDilation != null && effectsInheritTimeDilation.Contains(effectActor);
		effectActor.Play(reason);
		int num = 0;
		effectActor.GetHandle(ref num);
		int num2 = num;
		if (EffectSystem.Instance.IsValid(num2))
		{
			if (this.ActiveEffectInfoMap == null)
			{
				this.ActiveEffectInfoMap = new Dictionary<int, EffectInfo>();
			}
			EffectInfo effectInfo;
			if (!this.ActiveEffectInfoMap.TryGetValue(num2, out effectInfo))
			{
				effectInfo = new EffectInfo(effectActor, isInheritTimeDilation);
				effectInfo.EffectId = num2;
				this.ActiveEffectInfoMap.Add(num2, effectInfo);
			}
			if (EffectSystem.Instance.IsPlaying(num2))
			{
				effectInfo.IsPlaying = true;
			}
			else
			{
				effectInfo.IsPlaying = false;
				EffectSystem.Instance.DynamicRegisterSpawnCallback(num2, this.OnEffectPlayingCallback);
			}
			if (effectInfo.IsInheritTimeDilation)
			{
				EffectSystem.Instance.SetTimeScale(num2, base.CustomTimeDilation, false);
			}
			EffectSystem.Instance.AddFinishCallback(num2, this.OnEffectFinishCallback);
			if (this.OverrideEffectParmaFunc != null && effectActor == this.OverrideEffectActor)
			{
				this.OverrideEffectParmaFunc();
			}
		}
	}

	// Token: 0x0601B089 RID: 110729 RVA: 0x0084A6B8 File Offset: 0x008488B8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual bool CheckAllEffectPlaying()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("CheckAllEffectPlaying"), SceneInteractionActor.StaticClass(), out intPtr, out num))
		{
			return this.CheckAllEffectPlaying_Implementation();
		}
		SceneInteractionActor.__CheckAllEffectPlaying_FunctionParams* ptr = stackalloc SceneInteractionActor.__CheckAllEffectPlaying_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(SceneInteractionActor.__CheckAllEffectPlaying_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0601B08A RID: 110730 RVA: 0x0084A744 File Offset: 0x00848944
	protected bool CheckAllEffectPlaying_Implementation()
	{
		if (this.ActiveEffectInfoMap == null)
		{
			return false;
		}
		using (Dictionary<int, EffectInfo>.ValueCollection.Enumerator enumerator = this.ActiveEffectInfoMap.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (!enumerator.Current.IsPlaying)
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x0601B08B RID: 110731 RVA: 0x0084A7AC File Offset: 0x008489AC
	private void StopEffect(BP_EffectActor_C effectActor, string reason, bool immediately)
	{
		if (effectActor == null || !effectActor.IsValid())
		{
			return;
		}
		effectActor.Stop(reason, immediately);
	}

	// Token: 0x0601B08C RID: 110732 RVA: 0x0084A7CC File Offset: 0x008489CC
	private unsafe void PlaySequence(ALevelSequenceActor director, SSceneInteractionSequence config, TArray<AActor> bindActors, bool jumpToEnd)
	{
		if (!this.Active)
		{
			return;
		}
		ULevelSequence sequence = config.Sequence;
		if (sequence == null || !sequence.IsValid())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Interaction;
			ELogAuthor author = ELogAuthor.XDW;
			string message = "[PlaySequence] 配置的Sequence已失效(可能已被GC或所在关卡已卸载), 跳过播放";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PbDataId", this.PbDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("LevelName", this.LevelName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("HandleID", this.HandleId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return;
		}
		if (!this.IsValid())
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Interaction;
			ELogAuthor author2 = ELogAuthor.XDW;
			string message2 = "[PlaySequence] SceneInteractionActor自身已失效, 跳过播放";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("PbDataId", this.PbDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("LevelName", this.LevelName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("HandleID", this.HandleId);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			return;
		}
		if (this.DirectorConfigMap == null)
		{
			this.DirectorConfigMap = new Dictionary<ALevelSequenceActor, SequenceDirectorConfig>();
		}
		this.DirectorConfigMap[director] = new SequenceDirectorConfig(config, false, 0f, false);
		director.SetActorTickEnabled(true);
		UActorComponent uactorComponent = (director != null) ? director.GetComponentByClass(UAkComponent.StaticClass()) : null;
		if (uactorComponent != null && uactorComponent.IsValid())
		{
			uactorComponent.SetComponentTickEnabled(true);
		}
		this.GetKuroSceneInteractionActorSystem().SetSequenceWithTargetLevelActor(director, config.Sequence, this);
		for (int i = 0; i < bindActors.Num(); i++)
		{
			AActor aactor = bindActors.Get(i);
			if (aactor != null)
			{
				this.GetKuroSceneInteractionActorSystem().BindActorToLevelSequenceActor(aactor, director, UKismetSystemLibrary.GetDisplayName(aactor));
			}
		}
		if (this.OverrideSeqBindActors != null && this.OverrideSeqBindActors.Count > 0)
		{
			foreach (KeyValuePair<string, AActor> keyValuePair in this.OverrideSeqBindActors)
			{
				string key = keyValuePair.Key;
				AActor value = keyValuePair.Value;
				if (value.IsValid())
				{
					this.GetKuroSceneInteractionActorSystem().BindActorToLevelSequenceActor(value, director, key);
				}
			}
		}
		if (director.SequencePlayer != null)
		{
			MechanismTimelineModel.Instance.RegisterSequenceContext(director.SequencePlayer, new MechanismEventLevelPrefabContext(this.PbDataId, this.HandleId));
			this.IsPlayBack = false;
			if (config.IsLoop)
			{
				if (config.Reverse)
				{
					director.SequencePlayer.PlayReverseLooping(-1);
				}
				else
				{
					director.SequencePlayer.PlayLooping(-1);
				}
			}
			else if (config.Reverse)
			{
				director.SequencePlayer.PlayReverse();
			}
			else
			{
				director.SequencePlayer.Play();
			}
			if (jumpToEnd)
			{
				FFrameTime frame = config.Reverse ? director.SequencePlayer.GetStartTime().Time : director.SequencePlayer.GetEndTime().Time;
				FMovieSceneSequencePlaybackParams playbackPosition = new FMovieSceneSequencePlaybackParams
				{
					Frame = frame,
					PositionType = EMovieScenePositionType.Frame,
					UpdateMethod = EUpdatePositionMethod.Play
				};
				director.SequencePlayer.SetPlaybackPosition(playbackPosition);
			}
			director.SequencePlayer.SetPlayRate(config.PlayRate * base.CustomTimeDilation);
		}
	}

	// Token: 0x0601B08D RID: 110733 RVA: 0x0084AB2C File Offset: 0x00848D2C
	private void StopSequence(ULevelSequence sequence)
	{
		ALevelSequenceActor directorBySequence = this.GetDirectorBySequence(sequence);
		if (directorBySequence != null)
		{
			directorBySequence.SequencePlayer.Stop();
			directorBySequence.SetActorTickEnabled(false);
			UActorComponent uactorComponent = (directorBySequence != null) ? directorBySequence.GetComponentByClass(UAkComponent.StaticClass()) : null;
			if (uactorComponent != null && uactorComponent.IsValid())
			{
				uactorComponent.SetComponentTickEnabled(false);
			}
		}
	}

	// Token: 0x0601B08E RID: 110734 RVA: 0x0084AB80 File Offset: 0x00848D80
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void PlayKuroSkeletalMeshDestruction(AActor actor, bool isJumpToEnd)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("PlayKuroSkeletalMeshDestruction"), SceneInteractionActor.StaticClass(), out intPtr, out num))
		{
			this.PlayKuroSkeletalMeshDestruction_Implementation(actor, isJumpToEnd);
			return;
		}
		SceneInteractionActor.__PlayKuroSkeletalMeshDestruction_FunctionParams* ptr = stackalloc SceneInteractionActor.__PlayKuroSkeletalMeshDestruction_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(SceneInteractionActor.__PlayKuroSkeletalMeshDestruction_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->actor) = ((actor != null) ? actor.NativePtr : ((IntPtr)0));
		ptr->isJumpToEnd = isJumpToEnd;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601B08F RID: 110735 RVA: 0x0084AC24 File Offset: 0x00848E24
	protected void PlayKuroSkeletalMeshDestruction_Implementation(AActor actor, bool isJumpToEnd)
	{
		SSceneInteractionitem currentState = this.CurrentState;
		SSceneInteractionActorSkeletalMeshDestructible ssceneInteractionActorSkeletalMeshDestructible = (currentState != null) ? currentState.SkeletalMeshDestructible : null;
		if (((ssceneInteractionActorSkeletalMeshDestructible != null) ? ssceneInteractionActorSkeletalMeshDestructible.CanPlayDestructionWhenHit : null) != null)
		{
			AKuroDestructibleActor akuroDestructibleActor = actor as AKuroDestructibleActor;
			if (akuroDestructibleActor != null)
			{
				if (ssceneInteractionActorSkeletalMeshDestructible.CanPlayDestructionWhenHit.FindIndex(akuroDestructibleActor) != -1)
				{
					this.PlaySkeletalMeshDestruction(akuroDestructibleActor, isJumpToEnd, ssceneInteractionActorSkeletalMeshDestructible.HitInfo);
				}
				return;
			}
		}
	}

	// Token: 0x0601B090 RID: 110736 RVA: 0x0084AC7C File Offset: 0x00848E7C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void OverrideKuroDestructibleActorPhysicsVelocity(AKuroDestructibleActor skeletalMeshDestruction)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OverrideKuroDestructibleActorPhysicsVelocity"), SceneInteractionActor.StaticClass(), out intPtr, out num))
		{
			this.OverrideKuroDestructibleActorPhysicsVelocity_Implementation(skeletalMeshDestruction);
			return;
		}
		SceneInteractionActor.__OverrideKuroDestructibleActorPhysicsVelocity_FunctionParams* ptr = stackalloc SceneInteractionActor.__OverrideKuroDestructibleActorPhysicsVelocity_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(SceneInteractionActor.__OverrideKuroDestructibleActorPhysicsVelocity_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->skeletalMeshDestruction) = ((skeletalMeshDestruction != null) ? skeletalMeshDestruction.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601B091 RID: 110737 RVA: 0x0084AD18 File Offset: 0x00848F18
	protected void OverrideKuroDestructibleActorPhysicsVelocity_Implementation(AKuroDestructibleActor skeletalMeshDestruction)
	{
		EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(this.PbDataId);
		UKuroDestructibleDestructionAsset kuroDestructibleDestructionAsset = skeletalMeshDestruction.KuroDestructibleDestructionAsset;
		if (kuroDestructibleDestructionAsset == null || !kuroDestructibleDestructionAsset.bTrunksKeepLinearVelocity)
		{
			UKuroDestructibleDestructionAsset kuroDestructibleDestructionAsset2 = skeletalMeshDestruction.KuroDestructibleDestructionAsset;
			if (kuroDestructibleDestructionAsset2 == null || !kuroDestructibleDestructionAsset2.bTrunksKeepAngularVelocity)
			{
				return;
			}
		}
		if (entityByPbDataId != null && entityByPbDataId.Valid)
		{
			WorldEntity entity = entityByPbDataId.Entity;
			if (entity != null && entity.Valid)
			{
				BaseActorComponent baseActorComponent = entityByPbDataId.Entity.CheckGetComponent<BaseActorComponent>();
				UStaticMeshComponent proxyMeshComponent = skeletalMeshDestruction.GetProxyMeshComponent();
				if (baseActorComponent != null)
				{
					AActor owner = baseActorComponent.Owner;
					UPrimitiveComponent uprimitiveComponent = ((owner != null) ? owner.GetComponentByClass(UPrimitiveComponent.StaticClass()) : null) as UPrimitiveComponent;
					if (uprimitiveComponent != null && uprimitiveComponent.IsValid() && uprimitiveComponent.IsSimulatingPhysics(default(FName)) && proxyMeshComponent != null && proxyMeshComponent.IsValid())
					{
						UKuroDestructibleDestructionAsset kuroDestructibleDestructionAsset3 = skeletalMeshDestruction.KuroDestructibleDestructionAsset;
						if (kuroDestructibleDestructionAsset3 != null && kuroDestructibleDestructionAsset3.bTrunksKeepLinearVelocity)
						{
							proxyMeshComponent.SetPhysicsLinearVelocity(uprimitiveComponent.GetPhysicsLinearVelocity(default(FName)), false, default(FName));
						}
						UKuroDestructibleDestructionAsset kuroDestructibleDestructionAsset4 = skeletalMeshDestruction.KuroDestructibleDestructionAsset;
						if (kuroDestructibleDestructionAsset4 != null && kuroDestructibleDestructionAsset4.bTrunksKeepAngularVelocity)
						{
							proxyMeshComponent.SetPhysicsAngularVelocityInDegrees(uprimitiveComponent.GetPhysicsAngularVelocityInDegrees(default(FName)), false, default(FName));
						}
					}
				}
			}
		}
	}

	// Token: 0x0601B092 RID: 110738 RVA: 0x0084AE5C File Offset: 0x0084905C
	private unsafe void PlaySkeletalMeshDestruction(AKuroDestructibleActor skeletalMeshDestruction, bool isJumpToEnd, [Nullable(2)] SSceneInteractionDestructibleInfo skeletalMeshDestructionConfig)
	{
		if (skeletalMeshDestruction == null || !skeletalMeshDestruction.IsValid())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Interaction;
			ELogAuthor author = ELogAuthor.XDW;
			string message = "可破坏物SceneInteractionActor配置有错";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("LevelName", this.LevelName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CurrentState", this.CurrentState);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		if (isJumpToEnd)
		{
			skeletalMeshDestruction.SetActorHiddenInGame(true);
			skeletalMeshDestruction.SetActorEnableCollision(false);
			return;
		}
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.SceneGameplay;
		ELogAuthor author2 = ELogAuthor.LJM;
		string message2 = "[SceneInteractionActor]PlaySkeletalMeshDestruction";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("DestructActor:", skeletalMeshDestruction);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Location:", skeletalMeshDestruction.K2_GetActorLocation());
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
		this.OverrideKuroDestructibleActorPhysicsVelocity(skeletalMeshDestruction);
		FVectorDouble? fvectorDouble = null;
		FVectorDouble? fvectorDouble2 = null;
		float impulseStrength = 1f;
		FVectorDouble value;
		switch ((skeletalMeshDestructionConfig != null) ? skeletalMeshDestructionConfig.HitType : BPELevelPrefabDestructibleHitInfo.BPELevelPrefabDestructibleHitInfo_MAX)
		{
		case BPELevelPrefabDestructibleHitInfo.子弹_受击点和地面受击速度_:
			if (this.HitLocation != null)
			{
				fvectorDouble = this.HitLocation;
			}
			fvectorDouble2 = new FVectorDouble?(this.HitDirection);
			value = fvectorDouble2.Value;
			impulseStrength = (float)value.Size();
			break;
		case BPELevelPrefabDestructibleHitInfo.和实体Range组件Overlap的Actor的位置:
			if (this.RangeOtherActorLocation != null)
			{
				fvectorDouble = this.RangeOtherActorLocation;
			}
			break;
		case BPELevelPrefabDestructibleHitInfo.和实体Range组件Overlap的Actor的位置和Actor的速度_前提有速度_:
			if (this.RangeOtherActorLocation != null)
			{
				fvectorDouble = this.RangeOtherActorLocation;
			}
			if (this.RangeOtherActorVelocityProxy != null)
			{
				fvectorDouble2 = new FVectorDouble?(this.RangeOtherActorVelocityProxy.ToUeVector(false));
				impulseStrength = (float)this.RangeOtherActorVelocityProxy.Size();
			}
			break;
		case BPELevelPrefabDestructibleHitInfo.和实体Range组件Overlap的Actor的位置和Actor的速度_曲线_:
			if (this.RangeOtherActorLocation != null)
			{
				fvectorDouble = this.RangeOtherActorLocation;
			}
			if (this.RangeOtherActorVelocityProxy != null)
			{
				impulseStrength = LevelGamePlayUtils.GetValueInCurveFloatRange(skeletalMeshDestructionConfig.ImpulseStrengthFloatRange, (float)this.RangeOtherActorVelocityProxy.Size());
				fvectorDouble2 = new FVectorDouble?(this.RangeOtherActorVelocityProxy.ToUeVector(false));
			}
			break;
		}
		if (fvectorDouble == null)
		{
			fvectorDouble = new FVectorDouble?(this.HitLocation ?? skeletalMeshDestruction.D_K2_GetActorLocation());
		}
		if (fvectorDouble2 == null)
		{
			fvectorDouble2 = new FVectorDouble?(this.HitDirection);
			value = fvectorDouble2.Value;
			impulseStrength = (float)value.Size();
		}
		float damageAmount = 1f;
		value = fvectorDouble.Value;
		FVectorDouble value2 = fvectorDouble2.Value;
		skeletalMeshDestruction.D_ApplyDamage(damageAmount, value, value2, impulseStrength);
	}

	// Token: 0x0601B093 RID: 110739 RVA: 0x0084B0F0 File Offset: 0x008492F0
	private float? GetActiveSequencePlaybackProgress(ULevelSequence sequence)
	{
		ALevelSequenceActor directorBySequence = this.GetDirectorBySequence(sequence);
		ULevelSequencePlayer ulevelSequencePlayer = (directorBySequence != null) ? directorBySequence.SequencePlayer : null;
		if (directorBySequence == null || (ulevelSequencePlayer == null || !ulevelSequencePlayer.IsValid()))
		{
			return null;
		}
		SequenceDirectorConfig sequenceDirectorConfig;
		if (!this.DirectorConfigMap.TryGetValue(directorBySequence, out sequenceDirectorConfig))
		{
			return null;
		}
		if (sequenceDirectorConfig == null)
		{
			return null;
		}
		FFrameTime time = ulevelSequencePlayer.GetDuration().Time;
		float num = (float)time.FrameNumber.Value + time.SubFrame;
		if (num < 1f)
		{
			return null;
		}
		FFrameTime time2 = ulevelSequencePlayer.GetStartTime().Time;
		FFrameTime time3 = ulevelSequencePlayer.GetEndTime().Time;
		float num2 = (float)time2.FrameNumber.Value + time2.SubFrame;
		float num3 = (float)time3.FrameNumber.Value + time3.SubFrame;
		if (num2 > num3)
		{
			return null;
		}
		FFrameTime time4 = ulevelSequencePlayer.GetCurrentTime().Time;
		float num4 = (float)time4.FrameNumber.Value + time4.SubFrame;
		float num5;
		if (!sequenceDirectorConfig.Reverse)
		{
			num5 = num4 - num2;
		}
		else
		{
			num5 = num3 - num4;
		}
		num5 = MathUtils.Instance.Clamp(num5, num2, num3);
		return new float?(MathUtils.Instance.Clamp(num5 / num, 0f, 1f));
	}

	// Token: 0x0601B094 RID: 110740 RVA: 0x0084B25C File Offset: 0x0084945C
	private void SetActiveSequencePlaybackProgress(ULevelSequence sequence, float progress)
	{
		ALevelSequenceActor directorBySequence = this.GetDirectorBySequence(sequence);
		ULevelSequencePlayer ulevelSequencePlayer = (directorBySequence != null) ? directorBySequence.SequencePlayer : null;
		if (directorBySequence == null || (ulevelSequencePlayer == null || !ulevelSequencePlayer.IsValid()))
		{
			return;
		}
		SequenceDirectorConfig sequenceDirectorConfig;
		if (!this.DirectorConfigMap.TryGetValue(directorBySequence, out sequenceDirectorConfig))
		{
			return;
		}
		if (sequenceDirectorConfig == null)
		{
			return;
		}
		FFrameTime time = ulevelSequencePlayer.GetDuration().Time;
		float num = (float)time.FrameNumber.Value + time.SubFrame;
		float num2 = num * MathUtils.Instance.Clamp(progress, 0f, 1f);
		if (num < 1f || num2 > num)
		{
			return;
		}
		FFrameTime time2 = ulevelSequencePlayer.GetStartTime().Time;
		FFrameTime time3 = ulevelSequencePlayer.GetEndTime().Time;
		float num3 = (float)time2.FrameNumber.Value + time2.SubFrame;
		float num4 = (float)time3.FrameNumber.Value + time3.SubFrame;
		if (num3 > num4)
		{
			return;
		}
		float num5;
		if (!sequenceDirectorConfig.Reverse)
		{
			num5 = num3 + num2;
		}
		else
		{
			num5 = num4 - num2;
		}
		num5 = MathUtils.Instance.Clamp(num5, num3, num4);
		int num6 = (int)Math.Floor((double)num5);
		float subFrame = num5 - (float)num6;
		FFrameTime frame = new FFrameTime
		{
			FrameNumber = new FFrameNumber
			{
				Value = num6
			},
			SubFrame = subFrame
		};
		FFrameTime time4 = ulevelSequencePlayer.GetCurrentTime().Time;
		float num7 = (float)time4.FrameNumber.Value + time4.SubFrame;
		if (MathUtils.Instance.IsNearlyEqual((double)num7, (double)num5, new double?(0.0001)))
		{
			return;
		}
		FMovieSceneSequencePlaybackParams playbackPosition = new FMovieSceneSequencePlaybackParams
		{
			Frame = frame,
			PositionType = EMovieScenePositionType.Frame,
			UpdateMethod = EUpdatePositionMethod.Play
		};
		ulevelSequencePlayer.SetPlaybackPosition(playbackPosition);
	}

	// Token: 0x0601B095 RID: 110741 RVA: 0x0084B414 File Offset: 0x00849614
	private unsafe void SetActorCollisionProfile(TMap<AActor, FCollisionProfileName> profileMap)
	{
		if (profileMap == null)
		{
			return;
		}
		for (int i = 0; i < profileMap.Num(); i++)
		{
			AActor key = profileMap.GetKey(i);
			FCollisionProfileName valueOrDefault = profileMap.GetValueOrDefault(key);
			if (key == null || valueOrDefault == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Interaction;
				ELogAuthor author = ELogAuthor.CK;
				string message = "场景交互物状态机碰撞预设配置不合法, 检查配置";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("交互物Actor", this.LevelName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("碰撞Actor", key);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("碰撞Profile", valueOrDefault);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			}
			else
			{
				UStaticMeshComponent ustaticMeshComponent = key.GetComponentByClass(UStaticMeshComponent.StaticClass()) as UStaticMeshComponent;
				UPrimitiveComponent uprimitiveComponent;
				if (ustaticMeshComponent == null)
				{
					uprimitiveComponent = (key.GetComponentByClass(UShapeComponent.StaticClass()) as UShapeComponent);
					if (uprimitiveComponent == null)
					{
						goto IL_101;
					}
				}
				else
				{
					uprimitiveComponent = ustaticMeshComponent;
				}
				if (uprimitiveComponent.GetCollisionProfileName() == valueOrDefault.Name)
				{
					return;
				}
				uprimitiveComponent.SetCollisionProfileName(valueOrDefault.Name, true);
			}
			IL_101:;
		}
	}

	// Token: 0x0601B096 RID: 110742 RVA: 0x0084B534 File Offset: 0x00849734
	public float? GetActiveTagSequencePlaybackProgress(FGameplayTag tag)
	{
		SSceneInteractionTags ssceneInteractionTags;
		if (!this.TagsAndCorrespondingEffects.TryGetValue(tag, out ssceneInteractionTags))
		{
			return null;
		}
		SSceneInteractionSequence sequence = ssceneInteractionTags.Sequence;
		ULevelSequence ulevelSequence = (sequence != null) ? sequence.Sequence : null;
		if (ulevelSequence == null)
		{
			return null;
		}
		return this.GetActiveSequencePlaybackProgress(ulevelSequence);
	}

	// Token: 0x0601B097 RID: 110743 RVA: 0x0084B584 File Offset: 0x00849784
	public void SetActiveTagSequencePlaybackProgress(FGameplayTag tag, float progress)
	{
		SSceneInteractionTags ssceneInteractionTags;
		if (!this.TagsAndCorrespondingEffects.TryGetValue(tag, out ssceneInteractionTags))
		{
			return;
		}
		ULevelSequence ulevelSequence;
		if (ssceneInteractionTags == null)
		{
			ulevelSequence = null;
		}
		else
		{
			SSceneInteractionSequence sequence = ssceneInteractionTags.Sequence;
			ulevelSequence = ((sequence != null) ? sequence.Sequence : null);
		}
		ULevelSequence ulevelSequence2 = ulevelSequence;
		if (ulevelSequence2 == null)
		{
			return;
		}
		this.SetActiveSequencePlaybackProgress(ulevelSequence2, progress);
	}

	// Token: 0x0601B098 RID: 110744 RVA: 0x0084B5C8 File Offset: 0x008497C8
	public float? GetActiveSequenceDurationTime(ULevelSequence sequence)
	{
		ALevelSequenceActor directorBySequence = this.GetDirectorBySequence(sequence);
		ULevelSequencePlayer ulevelSequencePlayer = (directorBySequence != null) ? directorBySequence.SequencePlayer : null;
		if (directorBySequence == null || (ulevelSequencePlayer == null || !ulevelSequencePlayer.IsValid()))
		{
			return null;
		}
		SequenceDirectorConfig sequenceDirectorConfig;
		if (!this.DirectorConfigMap.TryGetValue(directorBySequence, out sequenceDirectorConfig))
		{
			return null;
		}
		if (sequenceDirectorConfig == null)
		{
			return null;
		}
		FQualifiedFrameTime duration = ulevelSequencePlayer.GetDuration();
		float num = (float)duration.Time.FrameNumber.Value + duration.Time.SubFrame;
		if (num < 1f)
		{
			return null;
		}
		float num2 = (float)duration.Rate.Denominator / (float)duration.Rate.Numerator;
		return new float?(num * num2);
	}

	// Token: 0x0601B099 RID: 110745 RVA: 0x0084B694 File Offset: 0x00849894
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual float GetActiveSequenceRemainTime(ULevelSequence sequence)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetActiveSequenceRemainTime"), SceneInteractionActor.StaticClass(), out intPtr, out num))
		{
			return this.GetActiveSequenceRemainTime_Implementation(sequence);
		}
		SceneInteractionActor.__GetActiveSequenceRemainTime_FunctionParams* ptr = stackalloc SceneInteractionActor.__GetActiveSequenceRemainTime_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(SceneInteractionActor.__GetActiveSequenceRemainTime_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->sequence) = ((sequence != null) ? sequence.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		float _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0601B09A RID: 110746 RVA: 0x0084B734 File Offset: 0x00849934
	protected float GetActiveSequenceRemainTime_Implementation(ULevelSequence sequence)
	{
		ALevelSequenceActor directorBySequence = this.GetDirectorBySequence(sequence);
		ULevelSequencePlayer ulevelSequencePlayer = (directorBySequence != null) ? directorBySequence.SequencePlayer : null;
		if (directorBySequence == null || (ulevelSequencePlayer == null || !ulevelSequencePlayer.IsValid()))
		{
			return 0f;
		}
		SequenceDirectorConfig sequenceDirectorConfig;
		if (!this.DirectorConfigMap.TryGetValue(directorBySequence, out sequenceDirectorConfig))
		{
			return 0f;
		}
		float num;
		float num2;
		if (!ulevelSequencePlayer.IsReversed())
		{
			FQualifiedFrameTime endTime = ulevelSequencePlayer.GetEndTime();
			FQualifiedFrameTime currentTime = ulevelSequencePlayer.GetCurrentTime();
			num = (float)endTime.Time.FrameNumber.Value + endTime.Time.SubFrame - (float)currentTime.Time.FrameNumber.Value - currentTime.Time.SubFrame;
			num2 = (float)currentTime.Rate.Denominator / (float)currentTime.Rate.Numerator;
		}
		else
		{
			FQualifiedFrameTime startTime = ulevelSequencePlayer.GetStartTime();
			FQualifiedFrameTime currentTime2 = ulevelSequencePlayer.GetCurrentTime();
			num = (float)currentTime2.Time.FrameNumber.Value + currentTime2.Time.SubFrame - (float)startTime.Time.FrameNumber.Value - startTime.Time.SubFrame;
			num2 = (float)currentTime2.Rate.Denominator / (float)currentTime2.Rate.Numerator;
		}
		if (num < 1f)
		{
			return 0f;
		}
		return num * num2;
	}

	// Token: 0x0601B09B RID: 110747 RVA: 0x0084B88C File Offset: 0x00849A8C
	public float? GetActiveTagSequenceDurationTime(FGameplayTag tag)
	{
		SSceneInteractionTags ssceneInteractionTags;
		if (!this.TagsAndCorrespondingEffects.TryGetValue(tag, out ssceneInteractionTags))
		{
			return null;
		}
		ULevelSequence ulevelSequence;
		if (ssceneInteractionTags == null)
		{
			ulevelSequence = null;
		}
		else
		{
			SSceneInteractionSequence sequence = ssceneInteractionTags.Sequence;
			ulevelSequence = ((sequence != null) ? sequence.Sequence : null);
		}
		ULevelSequence ulevelSequence2 = ulevelSequence;
		if (ulevelSequence2 == null)
		{
			return null;
		}
		return this.GetActiveSequenceDurationTime(ulevelSequence2);
	}

	// Token: 0x0601B09C RID: 110748 RVA: 0x0084B8E0 File Offset: 0x00849AE0
	public void SetActiveSequenceDurationTime(ULevelSequence sequence, float durationSecond)
	{
		ALevelSequenceActor directorBySequence = this.GetDirectorBySequence(sequence);
		ULevelSequencePlayer ulevelSequencePlayer = (directorBySequence != null) ? directorBySequence.SequencePlayer : null;
		if (directorBySequence == null || (ulevelSequencePlayer == null || !ulevelSequencePlayer.IsValid()))
		{
			return;
		}
		SequenceDirectorConfig sequenceDirectorConfig;
		if (!this.DirectorConfigMap.TryGetValue(directorBySequence, out sequenceDirectorConfig))
		{
			return;
		}
		if (sequenceDirectorConfig == null)
		{
			return;
		}
		FQualifiedFrameTime duration = ulevelSequencePlayer.GetDuration();
		float num = (float)duration.Time.FrameNumber.Value + duration.Time.SubFrame;
		if (num < 1f)
		{
			return;
		}
		float num2 = (float)duration.Rate.Denominator / (float)duration.Rate.Numerator;
		float num3 = num * num2 / durationSecond;
		if (num3 == 0f || !float.IsFinite(num3) || float.IsNaN(num3) || MathUtils.Instance.IsNearlyZero((double)num3, null))
		{
			return;
		}
		sequenceDirectorConfig.PlayRateOverride = num3;
		ulevelSequencePlayer.SetPlayRate(num3 * base.CustomTimeDilation);
	}

	// Token: 0x0601B09D RID: 110749 RVA: 0x0084B9CC File Offset: 0x00849BCC
	public void SetActiveTagSequenceDurationTime(FGameplayTag tag, float durationSecond)
	{
		SSceneInteractionTags ssceneInteractionTags;
		if (!this.TagsAndCorrespondingEffects.TryGetValue(tag, out ssceneInteractionTags))
		{
			return;
		}
		ULevelSequence ulevelSequence;
		if (ssceneInteractionTags == null)
		{
			ulevelSequence = null;
		}
		else
		{
			SSceneInteractionSequence sequence = ssceneInteractionTags.Sequence;
			ulevelSequence = ((sequence != null) ? sequence.Sequence : null);
		}
		ULevelSequence ulevelSequence2 = ulevelSequence;
		if (ulevelSequence2 == null)
		{
			return;
		}
		this.SetActiveSequenceDurationTime(ulevelSequence2, durationSecond);
	}

	// Token: 0x0601B09E RID: 110750 RVA: 0x0084BA10 File Offset: 0x00849C10
	private void PauseActiveSequence(ULevelSequence sequence)
	{
		ALevelSequenceActor directorBySequence = this.GetDirectorBySequence(sequence);
		ULevelSequencePlayer ulevelSequencePlayer = (directorBySequence != null) ? directorBySequence.SequencePlayer : null;
		if (directorBySequence == null || (ulevelSequencePlayer == null || !ulevelSequencePlayer.IsValid()))
		{
			return;
		}
		if (ulevelSequencePlayer.IsPaused())
		{
			return;
		}
		ulevelSequencePlayer.Pause();
	}

	// Token: 0x0601B09F RID: 110751 RVA: 0x0084BA58 File Offset: 0x00849C58
	public void PauseActiveTagSequence(FGameplayTag tag)
	{
		SSceneInteractionTags ssceneInteractionTags;
		if (!this.TagsAndCorrespondingEffects.TryGetValue(tag, out ssceneInteractionTags))
		{
			return;
		}
		ULevelSequence ulevelSequence;
		if (ssceneInteractionTags == null)
		{
			ulevelSequence = null;
		}
		else
		{
			SSceneInteractionSequence sequence = ssceneInteractionTags.Sequence;
			ulevelSequence = ((sequence != null) ? sequence.Sequence : null);
		}
		ULevelSequence ulevelSequence2 = ulevelSequence;
		if (ulevelSequence2 == null)
		{
			return;
		}
		this.PauseActiveSequence(ulevelSequence2);
	}

	// Token: 0x0601B0A0 RID: 110752 RVA: 0x0084BA9C File Offset: 0x00849C9C
	private void ResumeActiveSequence(ULevelSequence sequence, bool bReverseFromConfig = false)
	{
		ALevelSequenceActor directorBySequence = this.GetDirectorBySequence(sequence);
		ULevelSequencePlayer ulevelSequencePlayer = (directorBySequence != null) ? directorBySequence.SequencePlayer : null;
		if (directorBySequence == null || (ulevelSequencePlayer == null || !ulevelSequencePlayer.IsValid()))
		{
			return;
		}
		SequenceDirectorConfig sequenceDirectorConfig;
		if (!this.DirectorConfigMap.TryGetValue(directorBySequence, out sequenceDirectorConfig))
		{
			return;
		}
		if (sequenceDirectorConfig == null)
		{
			return;
		}
		if (ulevelSequencePlayer.IsPlaying())
		{
			ulevelSequencePlayer.Pause();
		}
		sequenceDirectorConfig.ReverseOverride = (bReverseFromConfig ? (!sequenceDirectorConfig.UeConfig.Reverse) : sequenceDirectorConfig.UeConfig.Reverse);
		if (sequenceDirectorConfig.Reverse)
		{
			if (sequenceDirectorConfig.IsLoop)
			{
				ulevelSequencePlayer.PlayReverseLooping(-1);
				return;
			}
			ulevelSequencePlayer.PlayReverse();
			return;
		}
		else
		{
			if (sequenceDirectorConfig.IsLoop)
			{
				ulevelSequencePlayer.PlayLooping(-1);
				return;
			}
			ulevelSequencePlayer.Play();
			return;
		}
	}

	// Token: 0x0601B0A1 RID: 110753 RVA: 0x0084BB50 File Offset: 0x00849D50
	public void ResumeActiveTagSequence(FGameplayTag tag, bool bReverseFromConfig = false)
	{
		SSceneInteractionTags ssceneInteractionTags;
		if (!this.TagsAndCorrespondingEffects.TryGetValue(tag, out ssceneInteractionTags))
		{
			return;
		}
		ULevelSequence ulevelSequence;
		if (ssceneInteractionTags == null)
		{
			ulevelSequence = null;
		}
		else
		{
			SSceneInteractionSequence sequence = ssceneInteractionTags.Sequence;
			ulevelSequence = ((sequence != null) ? sequence.Sequence : null);
		}
		ULevelSequence ulevelSequence2 = ulevelSequence;
		if (ulevelSequence2 == null)
		{
			return;
		}
		this.ResumeActiveSequence(ulevelSequence2, bReverseFromConfig);
	}

	// Token: 0x0601B0A2 RID: 110754 RVA: 0x0084BB94 File Offset: 0x00849D94
	public bool? GetIsActiveSequencePlayReverseFromConfig(ULevelSequence sequence)
	{
		ALevelSequenceActor directorBySequence = this.GetDirectorBySequence(sequence);
		ULevelSequencePlayer ulevelSequencePlayer = (directorBySequence != null) ? directorBySequence.SequencePlayer : null;
		if (directorBySequence == null || (ulevelSequencePlayer == null || !ulevelSequencePlayer.IsValid()))
		{
			return null;
		}
		SequenceDirectorConfig sequenceDirectorConfig;
		if (!this.DirectorConfigMap.TryGetValue(directorBySequence, out sequenceDirectorConfig))
		{
			return null;
		}
		if (sequenceDirectorConfig == null)
		{
			return null;
		}
		return new bool?(sequenceDirectorConfig.Reverse != sequenceDirectorConfig.UeConfig.Reverse);
	}

	// Token: 0x0601B0A3 RID: 110755 RVA: 0x0084BC18 File Offset: 0x00849E18
	public bool? GetIsActiveTagSequencePlayReverseFromConfig(FGameplayTag tag)
	{
		SSceneInteractionTags ssceneInteractionTags;
		if (!this.TagsAndCorrespondingEffects.TryGetValue(tag, out ssceneInteractionTags))
		{
			return null;
		}
		ULevelSequence ulevelSequence;
		if (ssceneInteractionTags == null)
		{
			ulevelSequence = null;
		}
		else
		{
			SSceneInteractionSequence sequence = ssceneInteractionTags.Sequence;
			ulevelSequence = ((sequence != null) ? sequence.Sequence : null);
		}
		ULevelSequence ulevelSequence2 = ulevelSequence;
		if (ulevelSequence2 == null)
		{
			return null;
		}
		return this.GetIsActiveSequencePlayReverseFromConfig(ulevelSequence2);
	}

	// Token: 0x0601B0A4 RID: 110756 RVA: 0x0084BC6C File Offset: 0x00849E6C
	private void PlayActiveSequenceTo(ULevelSequence sequence, float progress, bool bReverseFromConfig = false)
	{
		ALevelSequenceActor directorBySequence = this.GetDirectorBySequence(sequence);
		ULevelSequencePlayer ulevelSequencePlayer = (directorBySequence != null) ? directorBySequence.SequencePlayer : null;
		if (directorBySequence == null || (ulevelSequencePlayer == null || !ulevelSequencePlayer.IsValid()))
		{
			return;
		}
		SequenceDirectorConfig sequenceDirectorConfig;
		if (!this.DirectorConfigMap.TryGetValue(directorBySequence, out sequenceDirectorConfig))
		{
			return;
		}
		if (sequenceDirectorConfig == null)
		{
			return;
		}
		FFrameTime time = ulevelSequencePlayer.GetDuration().Time;
		float num = (float)time.FrameNumber.Value + time.SubFrame;
		float num2 = num * MathUtils.Instance.Clamp(progress, 0f, 1f);
		if (num < 1f || num2 > num)
		{
			return;
		}
		FFrameTime time2 = ulevelSequencePlayer.GetStartTime().Time;
		FFrameTime time3 = ulevelSequencePlayer.GetEndTime().Time;
		float num3 = (float)time2.FrameNumber.Value + time2.SubFrame;
		float num4 = (float)time3.FrameNumber.Value + time3.SubFrame;
		if (num3 > num4)
		{
			return;
		}
		sequenceDirectorConfig.ReverseOverride = (bReverseFromConfig ? (!sequenceDirectorConfig.UeConfig.Reverse) : sequenceDirectorConfig.UeConfig.Reverse);
		float num5;
		if (!sequenceDirectorConfig.Reverse)
		{
			num5 = num3 + num2;
		}
		else
		{
			num5 = num4 - num2;
		}
		num5 = MathUtils.Instance.Clamp(num5, num3, num4);
		int num6 = (int)Math.Floor((double)num5);
		float subFrame = num5 - (float)num6;
		FFrameTime frame = new FFrameTime
		{
			FrameNumber = new FFrameNumber
			{
				Value = num6
			},
			SubFrame = subFrame
		};
		FFrameTime time4 = ulevelSequencePlayer.GetCurrentTime().Time;
		float num7 = (float)time4.FrameNumber.Value + time4.SubFrame;
		if (MathUtils.Instance.IsNearlyEqual((double)num7, (double)num5, new double?(0.0001)))
		{
			return;
		}
		FMovieSceneSequencePlaybackParams inPlaybackParams = new FMovieSceneSequencePlaybackParams
		{
			Frame = frame,
			PositionType = EMovieScenePositionType.Frame,
			UpdateMethod = EUpdatePositionMethod.Play
		};
		ulevelSequencePlayer.PlayTo_Circle(inPlaybackParams, false, !sequenceDirectorConfig.Reverse);
	}

	// Token: 0x0601B0A5 RID: 110757 RVA: 0x0084BE50 File Offset: 0x0084A050
	public void PlayActiveTagSequenceTo(FGameplayTag tag, float progress, bool bReverseFromConfig = false)
	{
		SSceneInteractionTags ssceneInteractionTags;
		if (!this.TagsAndCorrespondingEffects.TryGetValue(tag, out ssceneInteractionTags))
		{
			return;
		}
		ULevelSequence ulevelSequence;
		if (ssceneInteractionTags == null)
		{
			ulevelSequence = null;
		}
		else
		{
			SSceneInteractionSequence sequence = ssceneInteractionTags.Sequence;
			ulevelSequence = ((sequence != null) ? sequence.Sequence : null);
		}
		ULevelSequence ulevelSequence2 = ulevelSequence;
		if (ulevelSequence2 == null)
		{
			return;
		}
		this.PlayActiveSequenceTo(ulevelSequence2, progress, bReverseFromConfig);
	}

	// Token: 0x0601B0A6 RID: 110758 RVA: 0x0084BE94 File Offset: 0x0084A094
	public void PlayState(SSceneInteractionitem state, [Nullable(2)] SSceneInteractionitem lastState, bool jumpToEnd, EKuroSceneInteractionState targetState)
	{
		if (state != null)
		{
			this.PlayStateSequence(state, jumpToEnd);
			this.PlayStateMontage(state, lastState);
			this.PlayStateEffect(state);
			this.PlayStateMaterialController(state, jumpToEnd);
			this.PlayStateCharMaterialControllerNew(state);
			this.PlayStateCrossStateEffects(state);
			this.PostStateAkEvent(state, jumpToEnd);
			this.SetStateActorShow(state);
			this.SetStateActorHide(state);
			this.PlayStateBasedEffect(state, targetState);
			this.PlayStateSkeletalMeshDestruction(state, jumpToEnd);
			this.PlayStateBpMaterialRuntimeParUpdate(state);
			this.SetStateActorCollisionProfile(state, lastState);
			this.CurrentState = state;
			this.IsAbpAnimPlayEnd = false;
		}
	}

	// Token: 0x0601B0A7 RID: 110759 RVA: 0x0084BF1C File Offset: 0x0084A11C
	private void PlayStateSequence(SSceneInteractionitem state, bool jumpToEnd)
	{
		if (state.Sequence.Sequence == null)
		{
			return;
		}
		ULevelSequencePlayer activeSequencePlayer = this.ActiveSequencePlayer;
		ULevelSequence ulevelSequence = ((activeSequencePlayer != null) ? activeSequencePlayer.Sequence : null) as ULevelSequence;
		if (ulevelSequence != null && ulevelSequence != state.Sequence.Sequence)
		{
			this.StopSequence(ulevelSequence);
		}
		ALevelSequenceActor alevelSequenceActor = this.CreateDirectorBySequence(state.Sequence.Sequence);
		if (alevelSequenceActor != null)
		{
			this.ActiveSequencePlayer = alevelSequenceActor.SequencePlayer;
			this.PlaySequence(alevelSequenceActor, state.Sequence, state.Actors, jumpToEnd);
		}
	}

	// Token: 0x0601B0A8 RID: 110760 RVA: 0x0084BF9C File Offset: 0x0084A19C
	private void PlayStateMontage(SSceneInteractionitem state, [Nullable(2)] SSceneInteractionitem lastState)
	{
		if (state.AnimMontage.SkeletalMesh == null || state.AnimMontage.Montage == null)
		{
			return;
		}
		if (((lastState != null) ? lastState.AnimMontage.Montage : null) != null && lastState.AnimMontage.Montage == state.AnimMontage.Montage)
		{
			return;
		}
		if (this.SkeletalMontageConfigMap == null)
		{
			this.SkeletalMontageConfigMap = new Dictionary<ASkeletalMeshActor, SkeletalMontageConfig>();
		}
		SkeletalMontageConfig skeletalMontageConfig;
		if (!this.SkeletalMontageConfigMap.TryGetValue(state.AnimMontage.SkeletalMesh, out skeletalMontageConfig))
		{
			skeletalMontageConfig = new SkeletalMontageConfig(state.AnimMontage, 0, false, EVisibilityBasedAnimTickOption.OnlyTickPoseWhenRendered);
			this.SkeletalMontageConfigMap[state.AnimMontage.SkeletalMesh] = skeletalMontageConfig;
		}
		USkeletalMeshComponent skeletalMeshComponent = state.AnimMontage.SkeletalMesh.SkeletalMeshComponent;
		if (lastState == null || state.AnimMontage.SkeletalMesh.bHidden || skeletalMeshComponent.bHiddenInGame)
		{
			if (!skeletalMontageConfig.IsPendingApplyProps())
			{
				skeletalMontageConfig.PendingCompHiddenInGame = skeletalMeshComponent.bHiddenInGame;
				skeletalMontageConfig.PendingCompVisibilityBasedAnimTickOption = skeletalMeshComponent.VisibilityBasedAnimTickOption;
			}
			skeletalMontageConfig.PendingFrameCount = 2;
			skeletalMeshComponent.VisibilityBasedAnimTickOption = EVisibilityBasedAnimTickOption.AlwaysTickPoseAndRefreshBones;
			skeletalMeshComponent.SetHiddenInGame(true, false);
		}
		if (!(skeletalMeshComponent.GetAnimationMode() == EAnimationMode.AnimationBlueprint))
		{
			skeletalMeshComponent.PlayAnimation(state.AnimMontage.Montage, state.AnimMontage.Loop);
			skeletalMeshComponent.SetPlayRate(state.AnimMontage.PlayRate * base.CustomTimeDilation);
			return;
		}
		UAnimInstance animInstance = skeletalMeshComponent.GetAnimInstance();
		if (animInstance == null)
		{
			skeletalMeshComponent.PlayAnimation(state.AnimMontage.Montage, state.AnimMontage.Loop);
			skeletalMeshComponent.SetPlayRate(state.AnimMontage.PlayRate * base.CustomTimeDilation);
			return;
		}
		ABP_LevelPrefabDaiyu_C abp_LevelPrefabDaiyu_C = animInstance as ABP_LevelPrefabDaiyu_C;
		if (abp_LevelPrefabDaiyu_C != null)
		{
			abp_LevelPrefabDaiyu_C.SetState(state.Name);
			abp_LevelPrefabDaiyu_C.SetPlayRate(base.CustomTimeDilation);
			return;
		}
		animInstance.Montage_Play(state.AnimMontage.Montage, state.AnimMontage.PlayRate * base.CustomTimeDilation, EMontagePlayReturnType.MontageLength, 0f, true);
	}

	// Token: 0x0601B0A9 RID: 110761 RVA: 0x0084C188 File Offset: 0x0084A388
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void ApplyAnimOptimizationParams(bool bUseDistanceMap = true)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ApplyAnimOptimizationParams"), SceneInteractionActor.StaticClass(), out intPtr, out num))
		{
			this.ApplyAnimOptimizationParams_Implementation(bUseDistanceMap);
			return;
		}
		SceneInteractionActor.__ApplyAnimOptimizationParams_FunctionParams* ptr = stackalloc SceneInteractionActor.__ApplyAnimOptimizationParams_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(SceneInteractionActor.__ApplyAnimOptimizationParams_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->bUseDistanceMap = bUseDistanceMap;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601B0AA RID: 110762 RVA: 0x0084C214 File Offset: 0x0084A414
	protected void ApplyAnimOptimizationParams_Implementation(bool bUseDistanceMap = true)
	{
		if (this.AllSkeletalMeshActors == null)
		{
			return;
		}
		bool flag = Info.Instance.IsMobilePlatform();
		FAnimUpdateRateParameters fanimUpdateRateParameters = new FAnimUpdateRateParameters();
		for (int i = 0; i < this.AllSkeletalMeshActors.Num(); i++)
		{
			ASkeletalMeshActor askeletalMeshActor = this.AllSkeletalMeshActors.Get(i);
			if (askeletalMeshActor == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Interaction;
				ELogAuthor author = ELogAuthor.CH;
				string message = "AllSkeletalMeshActors中有空的值，请找对应策划进行修改";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("LevelName", this.LevelName);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			else
			{
				USkeletalMeshComponent skeletalMeshComponent = askeletalMeshActor.SkeletalMeshComponent;
				if (skeletalMeshComponent != null)
				{
					int num = skeletalMeshComponent.LODInfo.Num();
					if (bUseDistanceMap)
					{
						fanimUpdateRateParameters.bShouldUseDistanceMap = true;
						fanimUpdateRateParameters.BaseVisibleDistanceThresholds.Empty(true);
						fanimUpdateRateParameters.BaseVisibleDistanceThresholds.Add((float)(flag ? 500 : 800));
						fanimUpdateRateParameters.BaseVisibleDistanceThresholds.Add((float)(flag ? 1000 : 1500));
						fanimUpdateRateParameters.BaseVisibleDistanceThresholds.Add((float)(flag ? 1500 : 4000));
						fanimUpdateRateParameters.BaseVisibleDistanceThresholds.Add((float)(flag ? 2000 : 5000));
						fanimUpdateRateParameters.BaseVisibleDistanceThresholds.Add((float)(flag ? 3000 : 8000));
					}
					else
					{
						fanimUpdateRateParameters.bShouldUseLodMap = true;
						fanimUpdateRateParameters.LODToFrameSkipMap.Empty(0);
						for (int j = 0; j < num; j++)
						{
							int value = (j < 2) ? 0 : (j - 1);
							fanimUpdateRateParameters.LODToFrameSkipMap.Add(j, value);
						}
					}
					fanimUpdateRateParameters.BaseNonRenderedUpdateRate = (flag ? 15 : 8);
					fanimUpdateRateParameters.MaxEvalRateForInterpolation = 8;
					skeletalMeshComponent.SetAnimUpdateRateParameters(ref fanimUpdateRateParameters);
					skeletalMeshComponent.bEnableUpdateRateOptimizations = true;
					skeletalMeshComponent.VisibilityBasedAnimTickOption = EVisibilityBasedAnimTickOption.OnlyTickPoseWhenRendered;
					skeletalMeshComponent.bUpdateOverlapsOnAnimationFinalize = false;
				}
			}
		}
	}

	// Token: 0x0601B0AB RID: 110763 RVA: 0x0084C3D8 File Offset: 0x0084A5D8
	private void PlayStateEffect(SSceneInteractionitem state)
	{
		if (state.Effects == null)
		{
			return;
		}
		for (int i = 0; i < state.Effects.Num(); i++)
		{
			this.PendingStateEffects.Add(state.Effects.Get(i));
		}
		Ticker ticker = TickSystem.Instance.Add(delegate(float delay)
		{
			if (this.IsValid())
			{
				this.PendingPlayStateEffect();
			}
		}, "SceneInteractionActor.PendingStateEffectTick", ETickingGroup.TG_PrePhysics, true, 0, false);
		if (ticker != null)
		{
			this.PendingStateEffectTickId = ticker.Id;
		}
	}

	// Token: 0x0601B0AC RID: 110764 RVA: 0x0084C44C File Offset: 0x0084A64C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected virtual void PendingPlayStateEffect()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("PendingPlayStateEffect"), SceneInteractionActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.PendingPlayStateEffect_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B0AD RID: 110765 RVA: 0x0084C4A8 File Offset: 0x0084A6A8
	protected void PendingPlayStateEffect_Implementation()
	{
		if (this.PendingStateEffects.Count == 0)
		{
			this.RemovePendingStateEffectTick();
			if (this.CheckAllEffectPlaying())
			{
				EventSystem.Instance.Emit<int>(EEventName.OnSceneInteractionAllEffectPlaying, this.HandleId);
			}
			return;
		}
		BP_EffectActor_C bp_EffectActor_C = this.PendingStateEffects[0];
		this.PendingStateEffects.RemoveAt(0);
		if (bp_EffectActor_C != null)
		{
			this.PlayEffect(bp_EffectActor_C, "[SceneInteractionActor.PendingPlayStateEffect]");
		}
	}

	// Token: 0x0601B0AE RID: 110766 RVA: 0x0084C510 File Offset: 0x0084A710
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected virtual void RemovePendingStateEffectTick()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("RemovePendingStateEffectTick"), SceneInteractionActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.RemovePendingStateEffectTick_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B0AF RID: 110767 RVA: 0x0084C569 File Offset: 0x0084A769
	protected void RemovePendingStateEffectTick_Implementation()
	{
		if (this.PendingStateEffectTickId != -1)
		{
			TickSystem.Instance.Remove(this.PendingStateEffectTickId);
			this.PendingStateEffectTickId = -1;
		}
	}

	// Token: 0x0601B0B0 RID: 110768 RVA: 0x0084C58C File Offset: 0x0084A78C
	private void PlayStateMaterialController(SSceneInteractionitem state, bool jumpToEnd)
	{
		TArray<SSceneInteractionMaterialController> materialControllers = state.MaterialControllers;
		if (materialControllers == null)
		{
			return;
		}
		for (int i = 0; i < materialControllers.Num(); i++)
		{
			if (materialControllers.Get(i).Materials != null)
			{
				UMaterialInstance materials = materialControllers.Get(i).Materials;
				TArray<AActor> actors = materialControllers.Get(i).Actors;
				for (int j = 0; j < actors.Num(); j++)
				{
					TArray<UActorComponent> tarray = actors.Get(j).K2_GetComponentsByClass(UStaticMeshComponent.StaticClass());
					for (int k = 0; k < tarray.Num(); k++)
					{
						UStaticMeshComponent ustaticMeshComponent = tarray.Get(k) as UStaticMeshComponent;
						if (!materialControllers.Get(i).IsRevertMaterial)
						{
							if (this.RevertMaterialComponentsMaps == null)
							{
								this.RevertMaterialComponentsMaps = new Dictionary<UStaticMeshComponent, Dictionary<int, UMaterialInterface>>();
							}
							if (!this.RevertMaterialComponentsMaps.ContainsKey(ustaticMeshComponent))
							{
								this.RevertMaterialComponentsMaps[ustaticMeshComponent] = new Dictionary<int, UMaterialInterface>();
							}
						}
						int numMaterials = ustaticMeshComponent.GetNumMaterials();
						TArray<UMaterialInterface> materials2 = ustaticMeshComponent.GetMaterials();
						for (int l = 0; l < numMaterials; l++)
						{
							if (!materialControllers.Get(i).IsRevertMaterial && this.RevertMaterialComponentsMaps != null)
							{
								this.RevertMaterialComponentsMaps[ustaticMeshComponent][l] = materials2.Get(l);
							}
							ustaticMeshComponent.SetMaterial(l, materials);
						}
					}
				}
			}
			SSceneInteractionMaterialController ssceneInteractionMaterialController = materialControllers.Get(i);
			for (int m = 0; m < ssceneInteractionMaterialController.Actors.Num(); m++)
			{
				if (ssceneInteractionMaterialController.Actors.Get(m) != null && ssceneInteractionMaterialController.Data != null)
				{
					ssceneInteractionMaterialController.TailIndex = (float)ItemMaterialManager.Instance.AddMaterialData(ssceneInteractionMaterialController.Actors.Get(m), ssceneInteractionMaterialController.Data);
					materialControllers.Set(i, ssceneInteractionMaterialController);
					ItemMaterialActorController itemMaterialActorController;
					if (ItemMaterialManager.Instance.AllActorControllerInfoMap != null && ItemMaterialManager.Instance.AllActorControllerInfoMap.TryGetValue((int)ssceneInteractionMaterialController.TailIndex, out itemMaterialActorController))
					{
						EffectLifeTimeController effectLifeTimeController = (itemMaterialActorController != null) ? itemMaterialActorController.GetLifeTimeController() : null;
						if (jumpToEnd)
						{
							if (effectLifeTimeController != null)
							{
								effectLifeTimeController.JumpToEnd();
							}
							if (itemMaterialActorController != null)
							{
								itemMaterialActorController.UpdateParameters(true);
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0601B0B1 RID: 110769 RVA: 0x0084C7AC File Offset: 0x0084A9AC
	private void PlayStateCharMaterialControllerNew(SSceneInteractionitem state)
	{
		PD_CharacterControllerDataGroup_C characterDataGroupForOrgan = state.CharacterDataGroupForOrgan;
		if (characterDataGroupForOrgan == null || !characterDataGroupForOrgan.IsValid())
		{
			return;
		}
		if (this.CharRenderingComponents != null)
		{
			List<CharRenderingComponent> list = new List<CharRenderingComponent>(this.CharRenderingComponents.Keys);
			int count = list.Count;
			for (int i = 0; i < count; i++)
			{
				int value = list[i].AddMaterialControllerDataGroup(state.CharacterDataGroupForOrgan);
				this.CharRenderingComponents[list[i]] = value;
			}
		}
	}

	// Token: 0x0601B0B2 RID: 110770 RVA: 0x0084C824 File Offset: 0x0084AA24
	private void PlayTagCharMaterialControllerNew(SSceneInteractionTags interactionTags)
	{
		PD_CharacterControllerDataGroup_C characterDataGroupForOrgan = interactionTags.CharacterDataGroupForOrgan;
		if (characterDataGroupForOrgan == null || !characterDataGroupForOrgan.IsValid())
		{
			return;
		}
		if (this.CharRenderingComponents != null)
		{
			List<CharRenderingComponent> list = new List<CharRenderingComponent>(this.CharRenderingComponents.Keys);
			int count = list.Count;
			for (int i = 0; i < count; i++)
			{
				int num = list[i].AddMaterialControllerDataGroup(characterDataGroupForOrgan);
				this.CharRenderingComponents[list[i]] = num;
				if (this.TagCharDaHandleList == null)
				{
					this.TagCharDaHandleList = new List<int>();
				}
				this.TagCharDaHandleList.Add(num);
			}
		}
	}

	// Token: 0x0601B0B3 RID: 110771 RVA: 0x0084C8BC File Offset: 0x0084AABC
	private void PlayStateCrossStateEffects(SSceneInteractionitem state)
	{
		if (state.CrossStateEffects == null)
		{
			return;
		}
		HashSet<BP_EffectActor_C> hashSet = new HashSet<BP_EffectActor_C>();
		for (int i = 0; i < state.CrossStateEffects.Num(); i++)
		{
			SSceneInteractionCrossStateEffect ssceneInteractionCrossStateEffect = state.CrossStateEffects.Get(i);
			if (!(ssceneInteractionCrossStateEffect == null))
			{
				BP_EffectActor_C effect = ssceneInteractionCrossStateEffect.Effect;
				if (effect != null && effect.IsValid())
				{
					BP_EffectActor_C effect2 = ssceneInteractionCrossStateEffect.Effect;
					hashSet.Add(effect2);
					int num = 0;
					effect2.GetHandle(ref num);
					int num2 = num;
					if (!EffectSystem.Instance.IsValid(num2))
					{
						this.PendingCrossStateEffects[effect2] = ssceneInteractionCrossStateEffect.EffectExtraState;
					}
					else
					{
						int effectExtraState = ssceneInteractionCrossStateEffect.EffectExtraState;
						EffectSystem.Instance.SetEffectExtraState(num2, effectExtraState);
					}
				}
			}
		}
		if (this.CrossStateEffectActors != null)
		{
			foreach (BP_EffectActor_C bp_EffectActor_C in this.CrossStateEffectActors)
			{
				if (!hashSet.Contains(bp_EffectActor_C))
				{
					if (this.PendingCrossStateEffects.ContainsKey(bp_EffectActor_C))
					{
						this.PendingCrossStateEffects.Remove(bp_EffectActor_C);
					}
					this.StopEffect(bp_EffectActor_C, "[SceneInteractionActor.PlayStateCrossStateEffects]", false);
				}
			}
		}
		if (this.PendingCrossStateEffects.Count > 0 && this.PendingCrossStateEffectTickId == -1)
		{
			Ticker ticker = TickSystem.Instance.Add(delegate(float delayTime)
			{
				if (this.IsValid())
				{
					this.PendingPlayCrossStateEffect();
				}
			}, "SceneInteractionActor.PendingCrossStateEffectTick", ETickingGroup.TG_PrePhysics, true, 0, false);
			if (ticker != null)
			{
				this.PendingCrossStateEffectTickId = ticker.Id;
			}
		}
	}

	// Token: 0x0601B0B4 RID: 110772 RVA: 0x0084CA40 File Offset: 0x0084AC40
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected virtual void PendingPlayCrossStateEffect()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("PendingPlayCrossStateEffect"), SceneInteractionActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.PendingPlayCrossStateEffect_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B0B5 RID: 110773 RVA: 0x0084CA9C File Offset: 0x0084AC9C
	protected void PendingPlayCrossStateEffect_Implementation()
	{
		if (this.PendingCrossStateEffects.Count == 0)
		{
			this.RemovePendingCrossStateEffectTick();
			if (this.CheckAllEffectPlaying())
			{
				EventSystem.Instance.Emit<int>(EEventName.OnSceneInteractionAllEffectPlaying, this.HandleId);
			}
			return;
		}
		Dictionary<BP_EffectActor_C, int>.Enumerator enumerator = this.PendingCrossStateEffects.GetEnumerator();
		if (enumerator.MoveNext())
		{
			KeyValuePair<BP_EffectActor_C, int> keyValuePair = enumerator.Current;
			BP_EffectActor_C key = keyValuePair.Key;
			int value = keyValuePair.Value;
			this.PendingCrossStateEffects.Remove(key);
			this.PlayEffect(key, "[SceneInteractionActor.PendingPlayCrossStateEffect]");
			int num = 0;
			key.GetHandle(ref num);
			int effectId = num;
			EffectSystem.Instance.SetEffectExtraState(effectId, value);
		}
	}

	// Token: 0x0601B0B6 RID: 110774 RVA: 0x0084CB40 File Offset: 0x0084AD40
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected virtual void RemovePendingCrossStateEffectTick()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("RemovePendingCrossStateEffectTick"), SceneInteractionActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.RemovePendingCrossStateEffectTick_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B0B7 RID: 110775 RVA: 0x0084CB99 File Offset: 0x0084AD99
	protected void RemovePendingCrossStateEffectTick_Implementation()
	{
		if (this.PendingCrossStateEffectTickId != -1)
		{
			TickSystem.Instance.Remove(this.PendingCrossStateEffectTickId);
			this.PendingCrossStateEffectTickId = -1;
		}
	}

	// Token: 0x0601B0B8 RID: 110776 RVA: 0x0084CBBC File Offset: 0x0084ADBC
	private void PlayStateSkeletalMeshDestruction(SSceneInteractionitem state, bool isJumpToEnd)
	{
		int num = state.SkeletalMeshDestructible.PlayDestructionAllImmediately.Num();
		if (num <= 0)
		{
			return;
		}
		for (int i = 0; i < num; i++)
		{
			AKuroDestructibleActor skeletalMeshDestruction = state.SkeletalMeshDestructible.PlayDestructionAllImmediately.Get(i);
			this.PlaySkeletalMeshDestruction(skeletalMeshDestruction, isJumpToEnd, state.SkeletalMeshDestructible.HitInfo);
		}
	}

	// Token: 0x0601B0B9 RID: 110777 RVA: 0x0084CC10 File Offset: 0x0084AE10
	private void PlayTagSkeletalMeshDestruction(SSceneInteractionTags interactionTags, bool isJumpToEnd)
	{
		TArray<AKuroDestructibleActor> skeletalMeshDestructibleActors = interactionTags.SkeletalMeshDestructibleActors;
		if (skeletalMeshDestructibleActors == null)
		{
			return;
		}
		int i = 0;
		int num = skeletalMeshDestructibleActors.Num();
		while (i < num)
		{
			AKuroDestructibleActor skeletalMeshDestruction = skeletalMeshDestructibleActors.Get(i);
			this.PlaySkeletalMeshDestruction(skeletalMeshDestruction, isJumpToEnd, interactionTags.HitInfo);
			i++;
		}
	}

	// Token: 0x0601B0BA RID: 110778 RVA: 0x0084CC54 File Offset: 0x0084AE54
	private void PlayTagSequence(SSceneInteractionTags interactionTags, bool jumpToEnd)
	{
		SSceneInteractionSequence sequence = interactionTags.Sequence;
		if (sequence == null)
		{
			return;
		}
		ULevelSequence sequence2 = sequence.Sequence;
		if (sequence2 == null)
		{
			return;
		}
		ALevelSequenceActor alevelSequenceActor = this.CreateDirectorBySequence(sequence2);
		if (alevelSequenceActor != null)
		{
			this.PlaySequence(alevelSequenceActor, sequence, interactionTags.Actors, jumpToEnd);
		}
	}

	// Token: 0x0601B0BB RID: 110779 RVA: 0x0084CC98 File Offset: 0x0084AE98
	private void StopTagSequence(SSceneInteractionTags interactionTags)
	{
		SSceneInteractionSequence sequence = interactionTags.Sequence;
		ULevelSequence ulevelSequence = (sequence != null) ? sequence.Sequence : null;
		if (ulevelSequence == null)
		{
			return;
		}
		this.StopSequence(ulevelSequence);
	}

	// Token: 0x0601B0BC RID: 110780 RVA: 0x0084CCC4 File Offset: 0x0084AEC4
	public void PlayTagEffect(FGameplayTag tag, SSceneInteractionTags interactionTags)
	{
		TArray<BP_EffectActor_C> effects = interactionTags.Effects;
		if (effects == null)
		{
			return;
		}
		List<BP_EffectActor_C> list = new List<BP_EffectActor_C>();
		int num = effects.Num();
		for (int i = 0; i < num; i++)
		{
			list.Add(effects.Get(i));
		}
		this.PendingTagEffects[tag] = list;
		if (this.PendingTagEffectTickId != -1 && TickSystem.Instance.Has(this.PendingTagEffectTickId))
		{
			TickSystem.Instance.Remove(this.PendingTagEffectTickId);
			this.PendingTagEffectTickId = -1;
		}
		Ticker ticker = TickSystem.Instance.Add(delegate(float _)
		{
			if (this.IsValid())
			{
				this.PendingPlayTagEffect();
			}
		}, "SceneInteractionActor.PendingTagEffectTick", ETickingGroup.TG_PrePhysics, true, 0, false);
		if (ticker != null)
		{
			this.PendingTagEffectTickId = ticker.Id;
		}
	}

	// Token: 0x0601B0BD RID: 110781 RVA: 0x0084CD78 File Offset: 0x0084AF78
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected virtual void PendingPlayTagEffect()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("PendingPlayTagEffect"), SceneInteractionActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.PendingPlayTagEffect_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B0BE RID: 110782 RVA: 0x0084CDD4 File Offset: 0x0084AFD4
	protected void PendingPlayTagEffect_Implementation()
	{
		if (this.PendingTagEffects.Count == 0)
		{
			this.RemovePendingTagEffectTick();
			if (this.CheckAllEffectPlaying() && this.IsValid())
			{
				EventSystem.Instance.Emit<int>(EEventName.OnSceneInteractionAllEffectPlaying, this.HandleId);
			}
			return;
		}
		List<FGameplayTag> list = new List<FGameplayTag>();
		List<BP_EffectActor_C> list2 = null;
		foreach (KeyValuePair<FGameplayTag, List<BP_EffectActor_C>> keyValuePair in this.PendingTagEffects)
		{
			FGameplayTag key = keyValuePair.Key;
			List<BP_EffectActor_C> value = keyValuePair.Value;
			if (value.Count != 0)
			{
				list2 = value;
				break;
			}
			list.Add(key);
		}
		foreach (FGameplayTag key2 in list)
		{
			this.PendingTagEffects.Remove(key2);
		}
		if (list2 == null || list2.Count == 0)
		{
			this.RemovePendingTagEffectTick();
			return;
		}
		BP_EffectActor_C bp_EffectActor_C = list2[0];
		list2.RemoveAt(0);
		if (bp_EffectActor_C != null)
		{
			this.PlayEffect(bp_EffectActor_C, "[SceneInteractionActor.PendingPlayTagEffect]");
		}
	}

	// Token: 0x0601B0BF RID: 110783 RVA: 0x0084CF04 File Offset: 0x0084B104
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected virtual void RemovePendingTagEffectTick()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("RemovePendingTagEffectTick"), SceneInteractionActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.RemovePendingTagEffectTick_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B0C0 RID: 110784 RVA: 0x0084CF5D File Offset: 0x0084B15D
	protected void RemovePendingTagEffectTick_Implementation()
	{
		if (this.PendingTagEffectTickId != -1)
		{
			TickSystem.Instance.Remove(this.PendingTagEffectTickId);
			this.PendingTagEffectTickId = -1;
		}
	}

	// Token: 0x0601B0C1 RID: 110785 RVA: 0x0084CF80 File Offset: 0x0084B180
	[NullableContext(2)]
	public void StopTagEffect(FGameplayTag tag, SSceneInteractionTags interactionTags)
	{
		this.PendingTagEffects.Remove(tag);
		TArray<BP_EffectActor_C> tarray = (interactionTags != null) ? interactionTags.Effects : null;
		if (tarray != null)
		{
			int num = tarray.Num();
			for (int i = 0; i < num; i++)
			{
				this.StopEffect(tarray.Get(i), "[SceneInteractionActor.StopTagEffect]", false);
			}
		}
		TArray<BP_EffectActor_C> tarray2 = (interactionTags != null) ? interactionTags.EndEffects : null;
		if (tarray2 != null)
		{
			int num2 = tarray2.Num();
			for (int j = 0; j < num2; j++)
			{
				this.PlayEffect(tarray2.Get(j), "[SceneInteractionActor.StopTagEffect:PlayingEndEffects]");
			}
		}
	}

	// Token: 0x0601B0C2 RID: 110786 RVA: 0x0084D00C File Offset: 0x0084B20C
	public void PlayTagMaterialController(SSceneInteractionTags interactionTags)
	{
		TArray<SSceneInteractionMaterialController> materialControllers = interactionTags.MaterialControllers;
		if (materialControllers == null)
		{
			return;
		}
		int num = materialControllers.Num();
		for (int i = 0; i < num; i++)
		{
			SSceneInteractionMaterialController ssceneInteractionMaterialController = materialControllers.Get(i);
			UMaterialInstance materials = ssceneInteractionMaterialController.Materials;
			TArray<AActor> actors = ssceneInteractionMaterialController.Actors;
			int num2 = actors.Num();
			if (materials != null)
			{
				for (int j = 0; j < num2; j++)
				{
					AActor aactor = actors.Get(j);
					TArray<AActor> tarray = new TArray<AActor>();
					aactor.GetAttachedActors(ref tarray, true);
					for (int k = 0; k < tarray.Num(); k++)
					{
						TArray<UActorComponent> tarray2 = tarray.Get(k).K2_GetComponentsByClass(UStaticMeshComponent.StaticClass());
						int num3 = tarray2.Num();
						for (int l = 0; l < num3; l++)
						{
							UStaticMeshComponent ustaticMeshComponent = tarray2.Get(l) as UStaticMeshComponent;
							if (!ssceneInteractionMaterialController.IsRevertMaterial)
							{
								if (this.RevertMaterialComponentsMaps == null)
								{
									this.RevertMaterialComponentsMaps = new Dictionary<UStaticMeshComponent, Dictionary<int, UMaterialInterface>>();
								}
								if (!this.RevertMaterialComponentsMaps.ContainsKey(ustaticMeshComponent))
								{
									this.RevertMaterialComponentsMaps[ustaticMeshComponent] = new Dictionary<int, UMaterialInterface>();
								}
							}
							int numMaterials = ustaticMeshComponent.GetNumMaterials();
							TArray<UMaterialInterface> materials2 = ustaticMeshComponent.GetMaterials();
							for (int m = 0; m < numMaterials; m++)
							{
								if (!ssceneInteractionMaterialController.IsRevertMaterial && this.RevertMaterialComponentsMaps != null)
								{
									this.RevertMaterialComponentsMaps[ustaticMeshComponent][m] = materials2.Get(m);
								}
								ustaticMeshComponent.SetMaterial(m, materials);
							}
						}
					}
					TArray<UActorComponent> tarray3 = aactor.K2_GetComponentsByClass(UStaticMeshComponent.StaticClass());
					int num4 = tarray3.Num();
					for (int n = 0; n < num4; n++)
					{
						UStaticMeshComponent ustaticMeshComponent2 = tarray3.Get(n) as UStaticMeshComponent;
						if (!ssceneInteractionMaterialController.IsRevertMaterial)
						{
							if (this.RevertMaterialComponentsMaps == null)
							{
								this.RevertMaterialComponentsMaps = new Dictionary<UStaticMeshComponent, Dictionary<int, UMaterialInterface>>();
							}
							if (!this.RevertMaterialComponentsMaps.ContainsKey(ustaticMeshComponent2))
							{
								this.RevertMaterialComponentsMaps[ustaticMeshComponent2] = new Dictionary<int, UMaterialInterface>();
							}
						}
						int numMaterials2 = ustaticMeshComponent2.GetNumMaterials();
						TArray<UMaterialInterface> materials3 = ustaticMeshComponent2.GetMaterials();
						for (int num5 = 0; num5 < numMaterials2; num5++)
						{
							if (!ssceneInteractionMaterialController.IsRevertMaterial && this.RevertMaterialComponentsMaps != null)
							{
								this.RevertMaterialComponentsMaps[ustaticMeshComponent2][num5] = materials3.Get(num5);
							}
							ustaticMeshComponent2.SetMaterial(num5, materials);
						}
					}
				}
			}
			for (int num6 = 0; num6 < num2; num6++)
			{
				AActor aactor2 = actors.Get(num6);
				ItemMaterialControllerActorData data = ssceneInteractionMaterialController.Data;
				if (aactor2 != null && data != null)
				{
					ssceneInteractionMaterialController.TailIndex = (float)ItemMaterialManager.Instance.AddMaterialData(aactor2, data);
					materialControllers.Set(i, ssceneInteractionMaterialController);
				}
			}
		}
	}

	// Token: 0x0601B0C3 RID: 110787 RVA: 0x0084D2BC File Offset: 0x0084B4BC
	public void StopTagMaterialController(SSceneInteractionTags interactionTags)
	{
		TArray<SSceneInteractionMaterialController> materialControllers = interactionTags.MaterialControllers;
		if (materialControllers == null)
		{
			return;
		}
		int num = materialControllers.Num();
		for (int i = 0; i < num; i++)
		{
			SSceneInteractionMaterialController ssceneInteractionMaterialController = materialControllers.Get(i);
			if (ssceneInteractionMaterialController.IsRevertMaterial)
			{
				if (ssceneInteractionMaterialController.Materials != null)
				{
					TArray<AActor> actors = ssceneInteractionMaterialController.Actors;
					int num2 = actors.Num();
					for (int j = 0; j < num2; j++)
					{
						TArray<UActorComponent> tarray = actors.Get(j).K2_GetComponentsByClass(UStaticMeshComponent.StaticClass());
						int num3 = tarray.Num();
						for (int k = 0; k < num3; k++)
						{
							UStaticMeshComponent ustaticMeshComponent = tarray.Get(k) as UStaticMeshComponent;
							int numMaterials = ustaticMeshComponent.GetNumMaterials();
							for (int l = 0; l < numMaterials; l++)
							{
								UMaterialInterface material = null;
								Dictionary<int, UMaterialInterface> dictionary;
								if (this.RevertMaterialComponentsMaps != null && this.RevertMaterialComponentsMaps.TryGetValue(ustaticMeshComponent, out dictionary) && dictionary != null)
								{
									dictionary.TryGetValue(l, out material);
								}
								ustaticMeshComponent.SetMaterial(l, material);
							}
						}
					}
				}
				if (this.CurrentState != null)
				{
					this.PlayStateMaterialController(this.CurrentState, true);
				}
			}
			if (ssceneInteractionMaterialController.Actors != null)
			{
				int num4 = ssceneInteractionMaterialController.Actors.Num();
				for (int m = 0; m < num4; m++)
				{
					int num5 = (int)ssceneInteractionMaterialController.TailIndex - m;
					if (ItemMaterialManager.Instance.AllActorControllerInfoMap != null && ItemMaterialManager.Instance.AllActorControllerInfoMap.ContainsKey(num5))
					{
						ItemMaterialManager.Instance.DisableActorData(num5);
					}
				}
			}
		}
	}

	// Token: 0x0601B0C4 RID: 110788 RVA: 0x0084D444 File Offset: 0x0084B644
	private void PostTagAkEvent(FGameplayTag tag, SSceneInteractionTags interactionTags, bool jumpToEnd)
	{
		if (this.PlayingTagAkEventHandle == null)
		{
			this.PlayingTagAkEventHandle = new Dictionary<FGameplayTag, int>();
		}
		SSceneInteractionAudio akEvent = interactionTags.AkEvent;
		UAkAudioEvent akEvent2 = akEvent.AkEvent;
		if (akEvent2 == null)
		{
			return;
		}
		if (!akEvent2.IsInfinite && jumpToEnd)
		{
			return;
		}
		if (akEvent.AutoMerge)
		{
			this.PostAutoMergeEvent(akEvent2.GetName(), (float)tag.TagId(), akEvent.IsFollow);
			return;
		}
		this.PostTagEvent(akEvent2.GetName(), tag, akEvent.IsFollow);
	}

	// Token: 0x0601B0C5 RID: 110789 RVA: 0x0084D4BC File Offset: 0x0084B6BC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void PostAutoMergeEvent(string eventName, float tagId, bool follow)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("PostAutoMergeEvent"), SceneInteractionActor.StaticClass(), out intPtr, out num))
		{
			this.PostAutoMergeEvent_Implementation(eventName, tagId, follow);
			return;
		}
		SceneInteractionActor.__PostAutoMergeEvent_FunctionParams* ptr = stackalloc SceneInteractionActor.__PostAutoMergeEvent_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(SceneInteractionActor.__PostAutoMergeEvent_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		FString.CopyFrom((void*)(&ptr->eventName), eventName);
		ptr->tagId = tagId;
		ptr->follow = follow;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601B0C6 RID: 110790 RVA: 0x0084D560 File Offset: 0x0084B760
	protected void PostAutoMergeEvent_Implementation(string eventName, float tagId, bool follow)
	{
		if (this.AkEventPostHandle.ContainsKey((int)tagId))
		{
			return;
		}
		int num = EffectAudioController.Instance.AddPlayEffectAudio(eventName, follow ? this : base.D_GetTransform(), null, null, delegate
		{
			this.AkEventPostHandle.Remove((int)tagId);
		}, new bool?(!follow));
		if (num != 0)
		{
			this.AkEventPostHandle[(int)tagId] = num;
		}
	}

	// Token: 0x0601B0C7 RID: 110791 RVA: 0x0084D5FC File Offset: 0x0084B7FC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void PostTagEvent(string eventName, FGameplayTag tag, bool follow)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("PostTagEvent"), SceneInteractionActor.StaticClass(), out intPtr, out num))
		{
			this.PostTagEvent_Implementation(eventName, tag, follow);
			return;
		}
		SceneInteractionActor.__PostTagEvent_FunctionParams* ptr = stackalloc SceneInteractionActor.__PostTagEvent_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(SceneInteractionActor.__PostTagEvent_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		FString.CopyFrom((void*)(&ptr->eventName), eventName);
		ptr->tag = tag;
		ptr->follow = follow;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601B0C8 RID: 110792 RVA: 0x0084D6A0 File Offset: 0x0084B8A0
	protected void PostTagEvent_Implementation(string eventName, FGameplayTag tag, bool follow)
	{
		if (this.PlayingTagAkEventHandle == null || this.PlayingTagAkEventHandle.ContainsKey(tag))
		{
			return;
		}
		int num = follow ? AudioSystem.Instance.PostEvent(eventName, this, null) : AudioSystem.Instance.PostEvent(eventName, new FTransformDouble?(base.D_GetTransform()), null);
		if (num != 0)
		{
			this.PlayingTagAkEventHandle[tag] = num;
		}
	}

	// Token: 0x0601B0C9 RID: 110793 RVA: 0x0084D710 File Offset: 0x0084B910
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void StopTagAkEvent(FGameplayTag tag)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("StopTagAkEvent"), SceneInteractionActor.StaticClass(), out intPtr, out num))
		{
			this.StopTagAkEvent_Implementation(tag);
			return;
		}
		SceneInteractionActor.__StopTagAkEvent_FunctionParams* ptr = stackalloc SceneInteractionActor.__StopTagAkEvent_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(SceneInteractionActor.__StopTagAkEvent_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->tag = tag;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601B0CA RID: 110794 RVA: 0x0084D79C File Offset: 0x0084B99C
	protected void StopTagAkEvent_Implementation(FGameplayTag tag)
	{
		SSceneInteractionTags interactionTags;
		if (this.TagsAndCorrespondingEffects.TryGetValue(tag, out interactionTags))
		{
			this.StopTagAkEventNoBlueprint(tag, interactionTags);
		}
	}

	// Token: 0x0601B0CB RID: 110795 RVA: 0x0084D7C4 File Offset: 0x0084B9C4
	private void StopTagAkEventNoBlueprint(FGameplayTag tag, SSceneInteractionTags interactionTags)
	{
		if (this.PlayingTagAkEventHandle == null)
		{
			return;
		}
		SSceneInteractionAudio akEvent = interactionTags.AkEvent;
		if (akEvent.AkEvent == null)
		{
			return;
		}
		if (akEvent.AutoMerge)
		{
			int uid;
			if (!this.AkEventPostHandle.TryGetValue(tag.TagId(), out uid))
			{
				return;
			}
			EffectAudioController.Instance.OnStopEffectAudio(uid, "SceneInteractionActor.StopTagAkEvent", false);
			this.AkEventPostHandle.Remove(tag.TagId());
			return;
		}
		else
		{
			int handle;
			if (!this.PlayingTagAkEventHandle.TryGetValue(tag, out handle))
			{
				return;
			}
			AudioSystem.Instance.ExecuteAction(handle, EAudioActionType.Stop, null);
			this.PlayingTagAkEventHandle.Remove(tag);
			return;
		}
	}

	// Token: 0x0601B0CC RID: 110796 RVA: 0x0084D860 File Offset: 0x0084BA60
	private void PlayStateBasedEffect(SSceneInteractionitem state, EKuroSceneInteractionState targetState)
	{
		TArray<SStateBasedEffect> stateBasedEffect = state.StateBasedEffect;
		for (int i = 0; i < stateBasedEffect.Num(); i++)
		{
			BP_StateMachineEffectBase_C stateBasedEffect2 = stateBasedEffect.GetRef_Unsafe(i).StateBasedEffect;
			if (stateBasedEffect2 != null && stateBasedEffect2.IsValid())
			{
				if (targetState == EKuroSceneInteractionState.State1)
				{
					stateBasedEffect2.SetState(EEffectState.State1);
				}
				else if (targetState == EKuroSceneInteractionState.State2)
				{
					stateBasedEffect2.SetState(EEffectState.State2);
				}
				else if (targetState == EKuroSceneInteractionState.State3)
				{
					stateBasedEffect2.SetState(EEffectState.State3);
				}
				else if (targetState == EKuroSceneInteractionState.State4)
				{
					stateBasedEffect2.SetState(EEffectState.State4);
				}
				else if (targetState == EKuroSceneInteractionState.State5)
				{
					stateBasedEffect2.SetState(EEffectState.State5);
				}
			}
		}
	}

	// Token: 0x0601B0CD RID: 110797 RVA: 0x0084D8DC File Offset: 0x0084BADC
	private void PostStateAkEvent(SSceneInteractionitem state, bool jumpToEnd)
	{
		SSceneInteractionAudio akEvent = state.AkEvent;
		UAkAudioEvent akEvent2 = akEvent.AkEvent;
		if (akEvent2 == null)
		{
			return;
		}
		if (!akEvent2.IsInfinite && jumpToEnd)
		{
			return;
		}
		this.StopCurrentStateAkEvent("PostStateAkEvent");
		int num;
		if (akEvent.AutoMerge)
		{
			num = EffectAudioController.Instance.AddPlayEffectAudio(akEvent2.GetName(), akEvent.IsFollow ? this : base.D_GetTransform(), null, null, delegate
			{
				this.CurrentStateAkEventHandle = 0f;
			}, new bool?(!akEvent.IsFollow));
		}
		else
		{
			string name = akEvent2.GetName();
			num = (akEvent.IsFollow ? AudioSystem.Instance.PostEvent(name, this, null) : AudioSystem.Instance.PostEvent(name, new FTransformDouble?(base.D_GetTransform()), null));
		}
		if (num != 0)
		{
			this.MergeCurrentStateAkEvent = akEvent.AutoMerge;
			this.CurrentStateAkEventHandle = (float)num;
		}
	}

	// Token: 0x0601B0CE RID: 110798 RVA: 0x0084D9E0 File Offset: 0x0084BBE0
	private void SetStateActorHide(SSceneInteractionitem state)
	{
		TArray<AActor> hideActors = state.HideActors;
		int i = 0;
		int num = hideActors.Num();
		while (i < num)
		{
			AActor aactor = hideActors.Get(i);
			if (aactor != null)
			{
				aactor.SetActorHiddenInGame(true);
				aactor.SetActorEnableCollision(false);
			}
			BP_EffectActor_C bp_EffectActor_C = aactor as BP_EffectActor_C;
			if (bp_EffectActor_C != null)
			{
				this.PendingStateEffects.Remove(bp_EffectActor_C);
				foreach (List<BP_EffectActor_C> list in this.PendingTagEffects.Values)
				{
					list.Remove(bp_EffectActor_C);
				}
				this.PendingCrossStateEffects.Remove(bp_EffectActor_C);
			}
			i++;
		}
	}

	// Token: 0x0601B0CF RID: 110799 RVA: 0x0084DA9C File Offset: 0x0084BC9C
	private void SetStateActorShow(SSceneInteractionitem state)
	{
		TArray<AActor> actors = state.Actors;
		if (actors == null)
		{
			return;
		}
		int i = 0;
		int num = actors.Num();
		while (i < num)
		{
			AActor aactor = actors.Get(i);
			if (aactor != null)
			{
				aactor.SetActorHiddenInGame(false);
				aactor.SetActorEnableCollision(true);
			}
			i++;
		}
	}

	// Token: 0x0601B0D0 RID: 110800 RVA: 0x0084DAE0 File Offset: 0x0084BCE0
	private void SetStateActorCollisionProfile(SSceneInteractionitem state, [Nullable(2)] SSceneInteractionitem lastState)
	{
		if (lastState != null)
		{
			TMap<AActor, FCollisionProfileName> exitStateActorCollisionProfile = lastState.ExitStateActorCollisionProfile;
			this.SetActorCollisionProfile(exitStateActorCollisionProfile);
		}
		TMap<AActor, FCollisionProfileName> enterStateActorCollisionProfile = state.EnterStateActorCollisionProfile;
		this.SetActorCollisionProfile(enterStateActorCollisionProfile);
	}

	// Token: 0x0601B0D1 RID: 110801 RVA: 0x0084DB14 File Offset: 0x0084BD14
	[NullableContext(2)]
	public void MakeActorProjection(FTransformDouble transform, ItemMaterialControllerActorData data = null)
	{
		if (this.IsProjecting)
		{
			Log.Instance.Error(ELogModule.RenderEffect, ELogAuthor.CH, "当前已经在投影中，重复调用投影接口", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		TArray<AActor> actorsForProjection = this.ActorsForProjection;
		AActor projectionRootActor = this.ProjectionRootActor;
		if (projectionRootActor == null || !projectionRootActor.IsValid())
		{
			UObject world = GlobalData.World;
			TSubclassOf<AActor> actorClass = AStaticMeshActor.StaticClass();
			FTransformDouble ftransformDouble = base.D_GetTransform();
			this.ProjectionRootActor = UKuroActorManager.D_SpawnActor(world, actorClass, ftransformDouble, ESpawnActorCollisionHandlingMethod.Undefined, null, null, false);
			this.ProjectionRootActor.RootComponent.SetMobility(EComponentMobility.Movable);
		}
		if (actorsForProjection.Num() == 0)
		{
			return;
		}
		this.IsProjecting = true;
		for (int i = 0; i < actorsForProjection.Num(); i++)
		{
			AActor aactor = UKuroStaticLibrary.SpawnActorFromAnother(actorsForProjection.Get(i), null);
			if (aactor != null && aactor.IsValid())
			{
				aactor.K2_AttachToActor(this.ProjectionRootActor, null, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, true, true);
				if (this.MaterialForProjection != null)
				{
					TArray<AActor> tarray = new TArray<AActor>();
					aactor.GetAttachedActors(ref tarray, true);
					for (int j = 0; j < tarray.Num(); j++)
					{
						TArray<UActorComponent> tarray2 = tarray.Get(j).K2_GetComponentsByClass(UStaticMeshComponent.StaticClass());
						for (int k = 0; k < tarray2.Num(); k++)
						{
							UStaticMeshComponent ustaticMeshComponent = tarray2.Get(k) as UStaticMeshComponent;
							int numMaterials = ustaticMeshComponent.GetNumMaterials();
							for (int l = 0; l < numMaterials; l++)
							{
								ustaticMeshComponent.SetMaterial(l, this.MaterialForProjection);
							}
						}
					}
					TArray<UActorComponent> tarray3 = aactor.K2_GetComponentsByClass(UStaticMeshComponent.StaticClass());
					for (int m = 0; m < tarray3.Num(); m++)
					{
						UStaticMeshComponent ustaticMeshComponent2 = tarray3.Get(m) as UStaticMeshComponent;
						int numMaterials2 = ustaticMeshComponent2.GetNumMaterials();
						for (int n = 0; n < numMaterials2; n++)
						{
							ustaticMeshComponent2.SetMaterial(n, this.MaterialForProjection);
						}
					}
				}
				if (data != null)
				{
					this.AddMatrialDataForChildrenActor(aactor, data);
				}
			}
		}
		this.ProjectionRootActor.D_K2_SetActorTransform(transform, false, null, false);
	}

	// Token: 0x0601B0D2 RID: 110802 RVA: 0x0084DD1C File Offset: 0x0084BF1C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void UpdateProjectionActorTransform(FTransformDouble transform)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("UpdateProjectionActorTransform"), SceneInteractionActor.StaticClass(), out intPtr, out num))
		{
			this.UpdateProjectionActorTransform_Implementation(transform);
			return;
		}
		SceneInteractionActor.__UpdateProjectionActorTransform_FunctionParams* ptr = stackalloc SceneInteractionActor.__UpdateProjectionActorTransform_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(SceneInteractionActor.__UpdateProjectionActorTransform_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->transform = transform;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601B0D3 RID: 110803 RVA: 0x0084DDA8 File Offset: 0x0084BFA8
	protected void UpdateProjectionActorTransform_Implementation(FTransformDouble transform)
	{
		if (!this.IsProjecting)
		{
			this.MakeActorProjection(transform, null);
			return;
		}
		AActor projectionRootActor = this.ProjectionRootActor;
		if (projectionRootActor == null || !projectionRootActor.IsValid())
		{
			Log.Instance.Error(ELogModule.RenderEffect, ELogAuthor.CH, "找不到投影的Root Actor", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.ProjectionRootActor.D_K2_SetActorTransform(transform, false, null, false);
	}

	// Token: 0x0601B0D4 RID: 110804 RVA: 0x0084DE0C File Offset: 0x0084C00C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void AddMatrialDataForChildrenActor(AActor actor, ItemMaterialControllerActorData materialData)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("AddMatrialDataForChildrenActor"), SceneInteractionActor.StaticClass(), out intPtr, out num))
		{
			this.AddMatrialDataForChildrenActor_Implementation(actor, materialData);
			return;
		}
		SceneInteractionActor.__AddMatrialDataForChildrenActor_FunctionParams* ptr = stackalloc SceneInteractionActor.__AddMatrialDataForChildrenActor_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(SceneInteractionActor.__AddMatrialDataForChildrenActor_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->actor) = ((actor != null) ? actor.NativePtr : ((IntPtr)0));
		*(&ptr->materialData) = ((materialData != null) ? materialData.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601B0D5 RID: 110805 RVA: 0x0084DEBC File Offset: 0x0084C0BC
	protected void AddMatrialDataForChildrenActor_Implementation(AActor actor, ItemMaterialControllerActorData materialData)
	{
		if (!actor.IsValid())
		{
			return;
		}
		TArray<AActor> tarray = new TArray<AActor>();
		actor.GetAttachedActors(ref tarray, true);
		for (int i = 0; i < tarray.Num(); i++)
		{
			AActor aactor = tarray.Get(i);
			if (aactor.IsValid())
			{
				ItemMaterialManager.Instance.AddMaterialData(aactor, materialData);
			}
		}
		ItemMaterialManager.Instance.AddMaterialData(actor, materialData);
	}

	// Token: 0x0601B0D6 RID: 110806 RVA: 0x0084DF1C File Offset: 0x0084C11C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void RemoveActorProjection()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("RemoveActorProjection"), SceneInteractionActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.RemoveActorProjection_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B0D7 RID: 110807 RVA: 0x0084DF78 File Offset: 0x0084C178
	protected void RemoveActorProjection_Implementation()
	{
		if (!this.IsProjecting)
		{
			return;
		}
		AActor projectionRootActor = this.ProjectionRootActor;
		if (projectionRootActor == null || !projectionRootActor.IsValid())
		{
			Log.Instance.Error(ELogModule.RenderEffect, ELogAuthor.CH, "找不到投影的Root Actor", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.IsProjecting = false;
		this.DestroyActor(this.ProjectionRootActor);
	}

	// Token: 0x0601B0D8 RID: 110808 RVA: 0x0084DFD8 File Offset: 0x0084C1D8
	private void DestroyActor(AActor actor)
	{
		TArray<AActor> tarray = new TArray<AActor>();
		actor.GetAttachedActors(ref tarray, true);
		for (int i = 0; i < tarray.Num(); i++)
		{
			this.DestroyActor(tarray.Get(i));
		}
		BP_EffectActor_C bp_EffectActor_C = actor as BP_EffectActor_C;
		if (bp_EffectActor_C != null)
		{
			bp_EffectActor_C.StopEffect();
			bp_EffectActor_C.RemoveHandle();
		}
		actor.K2_DestroyActor();
	}

	// Token: 0x0601B0D9 RID: 110809 RVA: 0x0084E030 File Offset: 0x0084C230
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void DestroySelf()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("DestroySelf"), SceneInteractionActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.DestroySelf_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B0DA RID: 110810 RVA: 0x0084E089 File Offset: 0x0084C289
	protected void DestroySelf_Implementation()
	{
		this.SkeletalMeshDestructibleActorsInternal = null;
		this.DestroyActor(this);
	}

	// Token: 0x0601B0DB RID: 110811 RVA: 0x0084E09C File Offset: 0x0084C29C
	public void SetTagActorHide(SSceneInteractionTags interactionTags)
	{
		TArray<AActor> hideActors = interactionTags.HideActors;
		if (hideActors == null)
		{
			return;
		}
		int i = 0;
		int num = hideActors.Num();
		while (i < num)
		{
			AActor aactor = hideActors.Get(i);
			if (aactor != null)
			{
				aactor.SetActorHiddenInGame(true);
				aactor.SetActorEnableCollision(false);
			}
			BP_EffectActor_C bp_EffectActor_C = aactor as BP_EffectActor_C;
			if (bp_EffectActor_C != null)
			{
				if (this.PendingStateEffects.Contains(bp_EffectActor_C))
				{
					this.PendingStateEffects.Remove(bp_EffectActor_C);
				}
				foreach (List<BP_EffectActor_C> list in this.PendingTagEffects.Values)
				{
					if (list.Contains(bp_EffectActor_C))
					{
						list.Remove(bp_EffectActor_C);
					}
				}
				if (this.PendingCrossStateEffects.ContainsKey(bp_EffectActor_C))
				{
					this.PendingCrossStateEffects.Remove(bp_EffectActor_C);
				}
			}
			i++;
		}
	}

	// Token: 0x0601B0DC RID: 110812 RVA: 0x0084E18C File Offset: 0x0084C38C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ResetTagActorHide(FGameplayTag tag)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ResetTagActorHide"), SceneInteractionActor.StaticClass(), out intPtr, out num))
		{
			this.ResetTagActorHide_Implementation(tag);
			return;
		}
		SceneInteractionActor.__ResetTagActorHide_FunctionParams* ptr = stackalloc SceneInteractionActor.__ResetTagActorHide_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(SceneInteractionActor.__ResetTagActorHide_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->tag = tag;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601B0DD RID: 110813 RVA: 0x0084E218 File Offset: 0x0084C418
	protected void ResetTagActorHide_Implementation(FGameplayTag tag)
	{
		SSceneInteractionTags interactionTags;
		if (this.TagsAndCorrespondingEffects != null && this.TagsAndCorrespondingEffects.TryGetValue(tag, out interactionTags))
		{
			this.ResetTagActorHideNoBlueprint(interactionTags);
		}
	}

	// Token: 0x0601B0DE RID: 110814 RVA: 0x0084E244 File Offset: 0x0084C444
	private void ResetTagActorHideNoBlueprint(SSceneInteractionTags interactionTags)
	{
		TArray<AActor> hideActors = interactionTags.HideActors;
		if (hideActors == null)
		{
			return;
		}
		int i = 0;
		int num = hideActors.Num();
		while (i < num)
		{
			AActor aactor = hideActors.Get(i);
			if (aactor != null)
			{
				aactor.SetActorHiddenInGame(false);
				aactor.SetActorEnableCollision(true);
			}
			i++;
		}
	}

	// Token: 0x0601B0DF RID: 110815 RVA: 0x0084E288 File Offset: 0x0084C488
	public void SetTagActorShow(SSceneInteractionTags interactionTags)
	{
		TArray<AActor> actors = interactionTags.Actors;
		if (actors == null)
		{
			return;
		}
		int i = 0;
		int num = actors.Num();
		while (i < num)
		{
			AActor aactor = actors.Get(i);
			if (aactor != null)
			{
				aactor.SetActorHiddenInGame(false);
				aactor.SetActorEnableCollision(true);
			}
			i++;
		}
	}

	// Token: 0x0601B0E0 RID: 110816 RVA: 0x0084E2CC File Offset: 0x0084C4CC
	public void ResetTagActorShow(SSceneInteractionTags interactionTags)
	{
		TArray<AActor> actors = interactionTags.Actors;
		if (actors == null)
		{
			return;
		}
		int i = 0;
		int num = actors.Num();
		while (i < num)
		{
			AActor aactor = actors.Get(i);
			if (aactor != null)
			{
				aactor.SetActorHiddenInGame(true);
				aactor.SetActorEnableCollision(false);
			}
			i++;
		}
	}

	// Token: 0x0601B0E1 RID: 110817 RVA: 0x0084E310 File Offset: 0x0084C510
	public void SetTagStaticMehActorCollisionProfile(SSceneInteractionTags interactionTags)
	{
		TMap<AActor, FCollisionProfileName> addTagActorCollisionProfile = interactionTags.AddTagActorCollisionProfile;
		if (addTagActorCollisionProfile != null)
		{
			this.SetActorCollisionProfile(addTagActorCollisionProfile);
		}
	}

	// Token: 0x0601B0E2 RID: 110818 RVA: 0x0084E330 File Offset: 0x0084C530
	public void ResetTagStaticMehActorCollisionProfile(SSceneInteractionTags interactionTags)
	{
		TMap<AActor, FCollisionProfileName> removeTagActorCollisionProfile = interactionTags.RemoveTagActorCollisionProfile;
		if (removeTagActorCollisionProfile != null)
		{
			this.SetActorCollisionProfile(removeTagActorCollisionProfile);
		}
	}

	// Token: 0x0601B0E3 RID: 110819 RVA: 0x0084E350 File Offset: 0x0084C550
	private void EmitStateReached(EKuroSceneInteractionState? stateKey)
	{
		if (stateKey == null)
		{
			return;
		}
		CreatureModel instance = CreatureModel.Instance;
		EntityHandle entityHandle = (instance != null) ? instance.GetEntityById(this.EntityId) : null;
		bool flag;
		if (entityHandle == null)
		{
			flag = true;
		}
		else
		{
			WorldEntity entity = entityHandle.Entity;
			flag = !((entity != null) ? new bool?(entity.Valid) : null).GetValueOrDefault();
		}
		if (flag)
		{
			return;
		}
		EventSystem.Instance.EmitWithTarget<int, EKuroSceneInteractionState>(entityHandle.Entity, EEventName.OnSceneInteractionStateReached, this.HandleId, stateKey.Value);
	}

	// Token: 0x0601B0E4 RID: 110820 RVA: 0x0084E3D8 File Offset: 0x0084C5D8
	private void DoSwitchState(bool bWaitForCurrentFinished)
	{
		if (this.InDoSwitchState)
		{
			return;
		}
		EKuroSceneInteractionState? stateKey = null;
		bool flag = false;
		this.InDoSwitchState = true;
		try
		{
			if (this.NextState == null)
			{
				LinkedListNode<SceneInteractionActor.PendingState> first = this.PendingStates.First;
				SceneInteractionActor.PendingState pendingState = (first != null) ? first.Value : null;
				if (pendingState == null)
				{
					return;
				}
				this.PendingStates.RemoveFirst();
				EKuroSceneInteractionState targetState = pendingState.TargetState;
				EKuroSceneInteractionState? currentStateKey = this.CurrentStateKey;
				if (targetState == currentStateKey.GetValueOrDefault() & currentStateKey != null)
				{
					return;
				}
				this.NextState = pendingState;
			}
			SceneInteractionActor.PendingState nextState = this.NextState;
			SSceneInteractionitem valueOrDefault = this.States.GetValueOrDefault(nextState.TargetState);
			this.TransitionStateJumpToEnd = (nextState.JumpToEnd && !valueOrDefault.NeedExpressionAnyway);
			if (bWaitForCurrentFinished)
			{
				bool flag2 = false;
				ULevelSequencePlayer activeSequencePlayer = this.ActiveSequencePlayer;
				ULevelSequence ulevelSequence = ((activeSequencePlayer != null) ? activeSequencePlayer.Sequence : null) as ULevelSequence;
				if (activeSequencePlayer != null && ulevelSequence != null && activeSequencePlayer.IsPlaying())
				{
					if (activeSequencePlayer.IsReversed())
					{
						activeSequencePlayer.PlayReverseLooping(0);
					}
					else
					{
						activeSequencePlayer.PlayLooping(0);
					}
					flag2 = true;
				}
				if (this.CurrentState != null)
				{
					ASkeletalMeshActor skeletalMesh = this.CurrentState.AnimMontage.SkeletalMesh;
					USkeletalMeshComponent uskeletalMeshComponent = (skeletalMesh != null) ? skeletalMesh.SkeletalMeshComponent : null;
					if (uskeletalMeshComponent != null)
					{
						UAnimInstance animInstance = uskeletalMeshComponent.GetAnimInstance();
						UAnimMontage montage = this.CurrentState.AnimMontage.Montage;
						if (montage != null && animInstance != null && animInstance.Montage_IsPlaying(montage))
						{
							UAnimSingleNodeInstance uanimSingleNodeInstance = animInstance as UAnimSingleNodeInstance;
							if (uanimSingleNodeInstance != null)
							{
								uanimSingleNodeInstance.SetLooping(false);
								flag2 = true;
								goto IL_18A;
							}
						}
						if (animInstance is ABP_LevelPrefabDaiyu_C)
						{
							flag2 = true;
						}
					}
				}
				IL_18A:
				if (flag2)
				{
					this.InWaitingForPlayableFinished = true;
					return;
				}
			}
			this.InWaitingForPlayableFinished = false;
			EKuroSceneInteractionState ekuroSceneInteractionState = nextState.TargetState;
			EKuroSceneInteractionState ekuroSceneInteractionState2;
			if (nextState.NeedTransition && !this.InTransition && this.CurrentState != null && this.CurrentState.TransitionMap.TryGetValue(nextState.TargetState, out ekuroSceneInteractionState2) && this.States.GetValueOrDefault(ekuroSceneInteractionState2) != null)
			{
				ekuroSceneInteractionState = ekuroSceneInteractionState2;
			}
			SSceneInteractionitem valueOrDefault2 = this.States.GetValueOrDefault(ekuroSceneInteractionState);
			bool flag3 = ekuroSceneInteractionState != nextState.TargetState;
			if (this.CurrentState != null)
			{
				this.StopState(this.CurrentState, valueOrDefault2);
				if (this.NextState != nextState)
				{
					flag = (this.NextState != null);
					return;
				}
			}
			this.CurrentStateKey = new EKuroSceneInteractionState?(ekuroSceneInteractionState);
			this.PlayState(valueOrDefault2, this.CurrentState, this.TransitionStateJumpToEnd, ekuroSceneInteractionState);
			if (this.NextState != nextState)
			{
				flag = (this.NextState != null);
				return;
			}
			this.InTransition = flag3;
			this.SwitchingStateRemainTime = (flag3 ? valueOrDefault2.TransitionTime : 0f);
			this.IsUseTransitionTime = (flag3 && !this.CheckActivePlayable());
			if (!flag3)
			{
				this.NextState = null;
			}
			stateKey = new EKuroSceneInteractionState?(ekuroSceneInteractionState);
		}
		finally
		{
			this.InDoSwitchState = false;
		}
		if (flag)
		{
			SSceneInteractionitem currentState = this.CurrentState;
			this.DoSwitchState(currentState != null && currentState.WaitForPlayableFinished);
			return;
		}
		if (stateKey != null)
		{
			this.EmitStateReached(stateKey);
		}
	}

	// Token: 0x0601B0E5 RID: 110821 RVA: 0x0084E704 File Offset: 0x0084C904
	public unsafe void SetState(EKuroSceneInteractionState state, bool needTransition, bool jumpToEnd)
	{
		if (this.MaxPendingStateCount == 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderScene;
			ELogAuthor author = ELogAuthor.ZYL;
			string message = "场景交互物目标状态队列容量配置不合法";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Actor", this.LevelName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("MaxPendingStateCount", this.MaxPendingStateCount);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		if (this.States == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.RenderScene;
			ELogAuthor author2 = ELogAuthor.ZYL;
			string message2 = "状态为Undefined";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Actor", this.LevelName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("HandleID", this.HandleId);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
		}
		SSceneInteractionitem valueOrDefault = this.States.GetValueOrDefault(state);
		if (valueOrDefault == null)
		{
			if (state != EKuroSceneInteractionState.ConcealedState)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.RenderScene;
				ELogAuthor author3 = ELogAuthor.MY;
				string message3 = "状态未配置";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("未配置状态", state + 1);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("Actor", this.LevelName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("HandleID", this.HandleId);
				instance3.Warn(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
			}
			return;
		}
		int num = this.PendingStates.Count + ((this.NextState != null) ? 1 : 0);
		SSceneInteractionitem currentState = this.CurrentState;
		bool flag = currentState != null && currentState.WaitForPlayableFinished && this.InWaitingForPlayableFinished;
		EKuroSceneInteractionState? currentStateKey = this.CurrentStateKey;
		if ((state == currentStateKey.GetValueOrDefault() & currentStateKey != null) && (num == 0 || valueOrDefault.IsForceSetState))
		{
			return;
		}
		if (valueOrDefault.IsForceSetState)
		{
			if (flag)
			{
				return;
			}
			this.PendingStates.Clear();
			this.InTransition = false;
			this.NextState = new SceneInteractionActor.PendingState(state, needTransition, jumpToEnd);
			SSceneInteractionitem currentState2 = this.CurrentState;
			this.DoSwitchState(currentState2 != null && currentState2.WaitForPlayableFinished);
			return;
		}
		else if (this.MaxPendingStateCount > 0 && num >= this.MaxPendingStateCount)
		{
			if (flag)
			{
				return;
			}
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.RenderScene;
			ELogAuthor author4 = ELogAuthor.MY;
			string message4 = "场景交互物目标状态队列已满，丢弃新目标";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("Actor", this.LevelName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("HandleID", this.HandleId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 2) = new ValueTuple<string, object>("MaxPendingStateCount", this.MaxPendingStateCount);
			instance4.Warn(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 3));
			return;
		}
		else
		{
			this.PendingStates.AddLast(new SceneInteractionActor.PendingState(state, needTransition, jumpToEnd));
			if (this.NextState != null || this.PendingStates.Count > 1)
			{
				return;
			}
			SSceneInteractionitem currentState3 = this.CurrentState;
			this.DoSwitchState(currentState3 != null && currentState3.WaitForPlayableFinished);
			return;
		}
	}

	// Token: 0x0601B0E6 RID: 110822 RVA: 0x0084EA10 File Offset: 0x0084CC10
	public void StopState(SSceneInteractionitem stateToStop, [Nullable(2)] SSceneInteractionitem stateToPlay)
	{
		if (stateToStop == null)
		{
			return;
		}
		this.RemovePendingStateEffectTick();
		this.PendingStateEffects.Clear();
		ULevelSequencePlayer activeSequencePlayer = this.ActiveSequencePlayer;
		ULevelSequence ulevelSequence = ((activeSequencePlayer != null) ? activeSequencePlayer.Sequence : null) as ULevelSequence;
		if (ulevelSequence != null && ulevelSequence == stateToStop.Sequence.Sequence && stateToStop.Sequence.Sequence != ((stateToPlay != null) ? stateToPlay.Sequence.Sequence : null))
		{
			this.StopSequence(ulevelSequence);
		}
		for (int i = 0; i < stateToStop.HideActors.Num(); i++)
		{
			AActor aactor = stateToStop.HideActors.Get(i);
			if (aactor != null)
			{
				aactor.SetActorHiddenInGame(false);
				aactor.SetActorEnableCollision(true);
			}
		}
		for (int j = 0; j < stateToStop.Effects.Num(); j++)
		{
			BP_EffectActor_C bp_EffectActor_C = stateToStop.Effects.Get(j);
			if (bp_EffectActor_C != null)
			{
				bp_EffectActor_C.Stop("[SceneInteractionActor.StopState]", false);
			}
		}
		TArray<SSceneInteractionMaterialController> materialControllers = stateToStop.MaterialControllers;
		if (ItemMaterialManager.Instance.AllActorControllerInfoMap != null && materialControllers != null)
		{
			for (int k = 0; k < materialControllers.Num(); k++)
			{
				if (materialControllers.Get(k).IsRevertMaterial && materialControllers.Get(k).Materials != null)
				{
					TArray<AActor> actors = materialControllers.Get(k).Actors;
					for (int l = 0; l < actors.Num(); l++)
					{
						TArray<UActorComponent> tarray = actors.Get(l).K2_GetComponentsByClass(UStaticMeshComponent.StaticClass());
						for (int m = 0; m < tarray.Num(); m++)
						{
							UStaticMeshComponent ustaticMeshComponent = tarray.Get(m) as UStaticMeshComponent;
							int numMaterials = ustaticMeshComponent.GetNumMaterials();
							for (int n = 0; n < numMaterials; n++)
							{
								UMaterialInterface material = null;
								Dictionary<int, UMaterialInterface> dictionary;
								if (this.RevertMaterialComponentsMaps != null && this.RevertMaterialComponentsMaps.TryGetValue(ustaticMeshComponent, out dictionary) && dictionary != null)
								{
									dictionary.TryGetValue(n, out material);
								}
								ustaticMeshComponent.SetMaterial(n, material);
							}
						}
					}
				}
			}
			if (ItemMaterialManager.Instance.AllActorControllerInfoMap != null)
			{
				for (int num = 0; num < materialControllers.Num(); num++)
				{
					for (int num2 = 0; num2 < materialControllers.Get(num).Actors.Num(); num2++)
					{
						int num3 = (int)stateToStop.MaterialControllers.Get(num).TailIndex - num2;
						if (ItemMaterialManager.Instance.AllActorControllerInfoMap.ContainsKey(num3))
						{
							ItemMaterialManager.Instance.DisableActorData(num3);
						}
					}
				}
			}
		}
		if (this.CharRenderingComponents != null)
		{
			List<CharRenderingComponent> list = new List<CharRenderingComponent>(this.CharRenderingComponents.Keys);
			int count = list.Count;
			for (int num4 = 0; num4 < count; num4++)
			{
				int num5;
				if (this.CharRenderingComponents.TryGetValue(list[num4], out num5) && num5 != 0 && (this.TagCharDaHandleList == null || !this.TagCharDaHandleList.Contains(num5)))
				{
					list[num4].RemoveMaterialControllerDataGroupWithEnding(num5);
				}
			}
		}
		this.StopCurrentStateAkEvent("停止状态Ak事件");
	}

	// Token: 0x0601B0E7 RID: 110823 RVA: 0x0084ED08 File Offset: 0x0084CF08
	public void StopCurrentStateAkEvent(string context)
	{
		float currentStateAkEventHandle = this.CurrentStateAkEventHandle;
		if (this.MergeCurrentStateAkEvent)
		{
			EffectAudioController.Instance.OnStopEffectAudio((int)this.CurrentStateAkEventHandle, "SceneInteractionActor." + context, false);
			this.CurrentStateAkEventHandle = 0f;
			return;
		}
		AudioSystem.Instance.ExecuteAction((int)this.CurrentStateAkEventHandle, EAudioActionType.Stop, null);
		this.CurrentStateAkEventHandle = 0f;
	}

	// Token: 0x0601B0E8 RID: 110824 RVA: 0x0084ED73 File Offset: 0x0084CF73
	public void OnAnimPlayEnd(string animName)
	{
		this.IsAbpAnimPlayEnd = true;
	}

	// Token: 0x0601B0E9 RID: 110825 RVA: 0x0084ED7C File Offset: 0x0084CF7C
	private bool CheckActivePlayable()
	{
		bool flag = false;
		if (this.ActiveSequencePlayer != null)
		{
			flag = (flag || this.ActiveSequencePlayer.IsPlaying());
		}
		SSceneInteractionitem currentState = this.CurrentState;
		SSceneInteractionMontage ssceneInteractionMontage = (currentState != null) ? currentState.AnimMontage : null;
		if (((ssceneInteractionMontage != null) ? ssceneInteractionMontage.SkeletalMesh : null) != null)
		{
			ASkeletalMeshActor skeletalMesh = ssceneInteractionMontage.SkeletalMesh;
			USkeletalMeshComponent uskeletalMeshComponent = (skeletalMesh != null) ? skeletalMesh.SkeletalMeshComponent : null;
			if (uskeletalMeshComponent != null)
			{
				UAnimInstance animInstance = uskeletalMeshComponent.GetAnimInstance();
				if (animInstance != null)
				{
					UAnimMontage montage = ssceneInteractionMontage.Montage;
					if (animInstance is ABP_LevelPrefabDaiyu_C)
					{
						flag = (flag || !this.IsAbpAnimPlayEnd);
					}
					else if (montage != null)
					{
						flag = (flag || animInstance.Montage_IsPlaying(montage));
					}
				}
			}
		}
		return flag;
	}

	// Token: 0x0601B0EA RID: 110826 RVA: 0x0084EE1C File Offset: 0x0084D01C
	private bool CheckPlaying(float deltaSeconds, SSceneInteractionitem state)
	{
		if (this.CheckActivePlayable())
		{
			return true;
		}
		if (!this.IsUseTransitionTime || this.SwitchingStateRemainTime == 0f)
		{
			return false;
		}
		this.SwitchingStateRemainTime -= deltaSeconds;
		return this.SwitchingStateRemainTime >= 0f;
	}

	// Token: 0x0601B0EB RID: 110827 RVA: 0x0084EE68 File Offset: 0x0084D068
	private UKuroSceneInteractionActorSystem GetKuroSceneInteractionActorSystem()
	{
		if (this.KuroSceneInteractionActorSystem == null)
		{
			this.KuroSceneInteractionActorSystem = (UKuroRenderingRuntimeBPPluginBPLibrary.GetSubsystem(GlobalData.World, UKuroSceneInteractionActorSystem.StaticClass()) as UKuroSceneInteractionActorSystem);
		}
		return this.KuroSceneInteractionActorSystem;
	}

	// Token: 0x0601B0EC RID: 110828 RVA: 0x0084EE98 File Offset: 0x0084D098
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	[return: Nullable(2)]
	protected unsafe virtual ALevelSequenceActor GetDirectorBySequence(ULevelSequence sequence)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetDirectorBySequence"), SceneInteractionActor.StaticClass(), out intPtr, out num))
		{
			return this.GetDirectorBySequence_Implementation(sequence);
		}
		SceneInteractionActor.__GetDirectorBySequence_FunctionParams* ptr = stackalloc SceneInteractionActor.__GetDirectorBySequence_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(SceneInteractionActor.__GetDirectorBySequence_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->sequence) = ((sequence != null) ? sequence.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		ALevelSequenceActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ALevelSequenceActor>(ptr->__Result);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return orCreateUObjectByNativePointer;
	}

	// Token: 0x0601B0ED RID: 110829 RVA: 0x0084EF40 File Offset: 0x0084D140
	[return: Nullable(2)]
	protected ALevelSequenceActor GetDirectorBySequence_Implementation(ULevelSequence sequence)
	{
		ALevelSequenceActor result;
		if (this.ActiveSequenceDirectorMap != null && this.ActiveSequenceDirectorMap.TryGetValue(sequence, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x0601B0EE RID: 110830 RVA: 0x0084EF68 File Offset: 0x0084D168
	[return: Nullable(2)]
	private unsafe ALevelSequenceActor CreateDirectorBySequence(ULevelSequence sequence)
	{
		if (this.ActiveSequenceDirectorMap == null)
		{
			this.ActiveSequenceDirectorMap = new Dictionary<ULevelSequence, ALevelSequenceActor>();
		}
		if (this.GetDirectorBySequence(sequence) != null)
		{
			this.StopSequence(sequence);
		}
		ALevelSequenceActor newDirector = ActorSystem.Instance.Get(ALevelSequenceActor.StaticClass(), base.D_GetTransform(), null, false) as ALevelSequenceActor;
		ALevelSequenceActor newDirector2 = newDirector;
		ULevelSequencePlayer ulevelSequencePlayer = (newDirector2 != null) ? newDirector2.SequencePlayer : null;
		if (ulevelSequencePlayer == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderScene;
			ELogAuthor author = ELogAuthor.ZYL;
			string message = "LevelSequenceActor.SequencePlayer invalid";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Actor", this.LevelName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("HandleID", this.HandleId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return null;
		}
		newDirector.bOverrideInstanceData = true;
		(newDirector.DefaultInstanceData as UDefaultLevelSequenceInstanceData).TransformOriginActor = this;
		this.ActiveSequenceDirectorMap[sequence] = newDirector;
		Action sendPlaySequenceEvent = delegate()
		{
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(this.PbDataId);
			bool flag;
			if (entityByPbDataId == null)
			{
				flag = true;
			}
			else
			{
				WorldEntity entity = entityByPbDataId.Entity;
				flag = !((entity != null) ? new bool?(entity.Valid) : null).GetValueOrDefault();
			}
			if (flag || newDirector.SequencePlayer == null)
			{
				return;
			}
			EventSystem.Instance.EmitWithTarget<int, UMovieSceneSequencePlayer>(entityByPbDataId.Entity, EEventName.OnSceneInteractionSequencePlay, this.HandleId, newDirector.SequencePlayer);
		};
		Action removeDirector = null;
		TTimerAction <>9__2;
		removeDirector = delegate()
		{
			ULevelSequencePlayer sequencePlayer = newDirector.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.OnStop.Remove(removeDirector);
				sequencePlayer.OnFinished.Remove(removeDirector);
				sequencePlayer.OnPlay.Remove(sendPlaySequenceEvent);
				sequencePlayer.OnPlayReverse.Remove(sendPlaySequenceEvent);
				EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(this.PbDataId);
				if (entityByPbDataId != null)
				{
					WorldEntity entity = entityByPbDataId.Entity;
					if (((entity != null) ? new bool?(entity.Valid) : null).GetValueOrDefault())
					{
						EventSystem.Instance.EmitWithTarget<int, UMovieSceneSequencePlayer>(entityByPbDataId.Entity, EEventName.OnSceneInteractionSequenceOver, this.HandleId, sequencePlayer);
					}
				}
				MechanismTimelineModel.Instance.UnRegisterSequenceContext(sequencePlayer);
			}
			ALevelSequenceActor alevelSequenceActor;
			if (this.ActiveSequenceDirectorMap != null && this.ActiveSequenceDirectorMap.TryGetValue(sequence, out alevelSequenceActor) && alevelSequenceActor == newDirector)
			{
				this.ActiveSequenceDirectorMap.Remove(sequence);
			}
			Dictionary<ALevelSequenceActor, SequenceDirectorConfig> directorConfigMap = this.DirectorConfigMap;
			if (directorConfigMap != null)
			{
				directorConfigMap.Remove(newDirector);
			}
			if (this.ActiveSequencePlayer == sequencePlayer)
			{
				this.ActiveSequencePlayer = null;
			}
			if (newDirector.IsValid())
			{
				TimerSystemInstance instance2 = TimerSystem.Instance;
				TTimerAction action;
				if ((action = <>9__2) == null)
				{
					action = (<>9__2 = delegate(float _)
					{
						ActorSystem.Instance.Put("SceneInteractionActor.CreateDirectorBySequence", newDirector, null);
					});
				}
				instance2.Next(action, null, null);
			}
		};
		ulevelSequencePlayer.OnPlay.Add(sendPlaySequenceEvent);
		ulevelSequencePlayer.OnPlayReverse.Add(sendPlaySequenceEvent);
		ulevelSequencePlayer.OnStop.Add(removeDirector);
		ulevelSequencePlayer.OnFinished.Add(removeDirector);
		return newDirector;
	}

	// Token: 0x0601B0EF RID: 110831 RVA: 0x0084F100 File Offset: 0x0084D300
	public void PlayExtraEffectOnTagsChange(FGameplayTag tag, bool jumpToEnd = false)
	{
		if (this.TagsAndCorrespondingEffects == null)
		{
			return;
		}
		SSceneInteractionTags ssceneInteractionTags;
		if (!this.TagsAndCorrespondingEffects.TryGetValue(tag, out ssceneInteractionTags))
		{
			return;
		}
		this.PlayTagEffect(tag, ssceneInteractionTags);
		this.PlayTagCharMaterialControllerNew(ssceneInteractionTags);
		this.PlayTagMaterialController(ssceneInteractionTags);
		this.TagsAndCorrespondingEffects[tag] = ssceneInteractionTags;
		this.PostTagAkEvent(tag, ssceneInteractionTags, jumpToEnd);
		this.SetTagActorShow(ssceneInteractionTags);
		this.SetTagActorHide(ssceneInteractionTags);
		this.PlayTagSequence(ssceneInteractionTags, jumpToEnd);
		this.PlayTagSkeletalMeshDestruction(ssceneInteractionTags, jumpToEnd);
		this.SetTagStaticMehActorCollisionProfile(ssceneInteractionTags);
	}

	// Token: 0x0601B0F0 RID: 110832 RVA: 0x0084F178 File Offset: 0x0084D378
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void StopExtraEffectOnTagsChange(FGameplayTag tag)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("StopExtraEffectOnTagsChange"), SceneInteractionActor.StaticClass(), out intPtr, out num))
		{
			this.StopExtraEffectOnTagsChange_Implementation(tag);
			return;
		}
		SceneInteractionActor.__StopExtraEffectOnTagsChange_FunctionParams* ptr = stackalloc SceneInteractionActor.__StopExtraEffectOnTagsChange_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(SceneInteractionActor.__StopExtraEffectOnTagsChange_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->tag = tag;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601B0F1 RID: 110833 RVA: 0x0084F204 File Offset: 0x0084D404
	protected void StopExtraEffectOnTagsChange_Implementation(FGameplayTag tag)
	{
		if (this.TagsAndCorrespondingEffects == null)
		{
			return;
		}
		SSceneInteractionTags ssceneInteractionTags;
		this.TagsAndCorrespondingEffects.TryGetValue(tag, out ssceneInteractionTags);
		this.StopTagEffect(tag, ssceneInteractionTags);
		if (ssceneInteractionTags == null)
		{
			return;
		}
		this.StopTagMaterialController(ssceneInteractionTags);
		this.StopTagAkEventNoBlueprint(tag, ssceneInteractionTags);
		this.ResetTagActorShow(ssceneInteractionTags);
		this.ResetTagActorHideNoBlueprint(ssceneInteractionTags);
		this.StopTagSequence(ssceneInteractionTags);
		this.ResetTagStaticMehActorCollisionProfile(ssceneInteractionTags);
	}

	// Token: 0x0601B0F2 RID: 110834 RVA: 0x0084F266 File Offset: 0x0084D466
	public void UpdateHitInfo(FVectorDouble pos, FVector dir)
	{
		this.HitLocation = new FVectorDouble?(pos);
		this.HitDirection.Set((double)dir.X, (double)dir.Y, (double)dir.Z);
	}

	// Token: 0x0601B0F3 RID: 110835 RVA: 0x0084F294 File Offset: 0x0084D494
	public void UpdateRangeOverlapInfo(bool isEnter, AActor otherActor)
	{
		if (!isEnter)
		{
			this.RangeOtherActorLocation = null;
			this.RangeOtherActorVelocityProxy = null;
			return;
		}
		if (otherActor == null || !otherActor.IsValid())
		{
			return;
		}
		this.RangeOtherActorLocation = new FVectorDouble?(otherActor.D_K2_GetActorLocation());
		EntityHandle entityByActor = ActorUtils.GetEntityByActor(otherActor, false);
		if (entityByActor != null)
		{
			BPELevelPrefabDestructibleOverlapSource rangeOtherActorVelocitySource = this.RangeOtherActorVelocitySource;
			if (rangeOtherActorVelocitySource != BPELevelPrefabDestructibleOverlapSource.角色)
			{
				if (rangeOtherActorVelocitySource != BPELevelPrefabDestructibleOverlapSource.载具)
				{
					return;
				}
				WorldEntity entity = entityByActor.Entity;
				VehicleActorComponent vehicleActorComponent = (entity != null) ? entity.GetComponent<VehicleActorComponent>() : null;
				if (vehicleActorComponent != null)
				{
					this.RangeOtherActorVelocityProxy = vehicleActorComponent.ActorVelocityProxy;
					return;
				}
			}
			else
			{
				WorldEntity entity2 = entityByActor.Entity;
				CharacterActorComponent characterActorComponent = (entity2 != null) ? entity2.GetComponent<CharacterActorComponent>() : null;
				if (characterActorComponent != null)
				{
					this.RangeOtherActorVelocityProxy = characterActorComponent.ActorVelocityProxy;
					return;
				}
			}
		}
		else
		{
			UCharacterMovementComponent ucharacterMovementComponent = otherActor.GetComponentByClass(UCharacterMovementComponent.StaticClass()) as UCharacterMovementComponent;
			if (ucharacterMovementComponent != null)
			{
				this.RangeOtherActorVelocityProxy = Vector.Create(ucharacterMovementComponent.Velocity);
			}
		}
	}

	// Token: 0x0601B0F4 RID: 110836 RVA: 0x0084F370 File Offset: 0x0084D570
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void TryStopCurrentState()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("TryStopCurrentState"), SceneInteractionActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.TryStopCurrentState_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B0F5 RID: 110837 RVA: 0x0084F3C9 File Offset: 0x0084D5C9
	protected void TryStopCurrentState_Implementation()
	{
		if (this.CurrentState != null)
		{
			this.StopState(this.CurrentState, null);
		}
	}

	// Token: 0x17002C2D RID: 11309
	// (get) Token: 0x0601B0F6 RID: 110838 RVA: 0x0084F3E6 File Offset: 0x0084D5E6
	// (set) Token: 0x0601B0F7 RID: 110839 RVA: 0x0084F3F6 File Offset: 0x0084D5F6
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 需要过渡状态
	{
		get
		{
			return *(base.NativePtr + (IntPtr)SceneInteractionActor.__PropertyOffset_需要过渡状态) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)SceneInteractionActor.__PropertyOffset_需要过渡状态) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002C2E RID: 11310
	// (get) Token: 0x0601B0F8 RID: 110840 RVA: 0x0084F407 File Offset: 0x0084D607
	// (set) Token: 0x0601B0F9 RID: 110841 RVA: 0x0084F417 File Offset: 0x0084D617
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 跳过表现过程
	{
		get
		{
			return *(base.NativePtr + (IntPtr)SceneInteractionActor.__PropertyOffset_跳过表现过程) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)SceneInteractionActor.__PropertyOffset_跳过表现过程) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002C2F RID: 11311
	// (get) Token: 0x0601B0FA RID: 110842 RVA: 0x0084F428 File Offset: 0x0084D628
	// (set) Token: 0x0601B0FB RID: 110843 RVA: 0x0084F438 File Offset: 0x0084D638
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EKuroSceneInteractionState 模拟状态
	{
		get
		{
			return (EKuroSceneInteractionState)(*(base.NativePtr + (IntPtr)SceneInteractionActor.__PropertyOffset_模拟状态));
		}
		set
		{
			*(base.NativePtr + (IntPtr)SceneInteractionActor.__PropertyOffset_模拟状态) = (byte)value;
		}
	}

	// Token: 0x17002C30 RID: 11312
	// (get) Token: 0x0601B0FC RID: 110844 RVA: 0x0084F449 File Offset: 0x0084D649
	// (set) Token: 0x0601B0FD RID: 110845 RVA: 0x0084F45D File Offset: 0x0084D65D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FGameplayTag 模拟Tag
	{
		get
		{
			return *(base.NativePtr + (IntPtr)SceneInteractionActor.__PropertyOffset_模拟Tag);
		}
		set
		{
			*(base.NativePtr + (IntPtr)SceneInteractionActor.__PropertyOffset_模拟Tag) = value;
		}
	}

	// Token: 0x0601B0FE RID: 110846 RVA: 0x0084F474 File Offset: 0x0084D674
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void 使用字段值切换状态()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("使用字段值切换状态"), SceneInteractionActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.使用字段值切换状态_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B0FF RID: 110847 RVA: 0x0084F4CD File Offset: 0x0084D6CD
	protected void 使用字段值切换状态_Implementation()
	{
		this.ChangeStateInternal(this.模拟状态);
	}

	// Token: 0x0601B100 RID: 110848 RVA: 0x0084F4DC File Offset: 0x0084D6DC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void ChangeState1()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ChangeState1"), SceneInteractionActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ChangeState1_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B101 RID: 110849 RVA: 0x0084F538 File Offset: 0x0084D738
	protected void ChangeState1_Implementation()
	{
		string sequencePath = "/Game/Aki/GamePlay/Mechanism/Test.Test";
		MechanismUtils.GetAllAnimNotifyEventsByPath(sequencePath, delegate([Nullable(new byte[]
		{
			2,
			1
		})] List<IEventData> eventData)
		{
			if (eventData != null)
			{
				foreach (IEventData eventData2 in eventData)
				{
				}
			}
		});
		MechanismUtils.GetAllAnimNotifyStateEventsByPath(sequencePath, delegate([Nullable(new byte[]
		{
			2,
			1
		})] List<IEventData> eventData)
		{
			if (eventData != null)
			{
				foreach (IEventData eventData2 in eventData)
				{
				}
			}
		});
	}

	// Token: 0x0601B102 RID: 110850 RVA: 0x0084F594 File Offset: 0x0084D794
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void ChangeState2()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ChangeState2"), SceneInteractionActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ChangeState2_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B103 RID: 110851 RVA: 0x0084F5ED File Offset: 0x0084D7ED
	protected void ChangeState2_Implementation()
	{
		this.ChangeStateInternal(EKuroSceneInteractionState.State2);
	}

	// Token: 0x0601B104 RID: 110852 RVA: 0x0084F5F8 File Offset: 0x0084D7F8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void ChangeState3()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ChangeState3"), SceneInteractionActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ChangeState3_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B105 RID: 110853 RVA: 0x0084F651 File Offset: 0x0084D851
	protected void ChangeState3_Implementation()
	{
		this.ChangeStateInternal(EKuroSceneInteractionState.State3);
	}

	// Token: 0x0601B106 RID: 110854 RVA: 0x0084F65C File Offset: 0x0084D85C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void ChangeState4()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ChangeState4"), SceneInteractionActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ChangeState4_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B107 RID: 110855 RVA: 0x0084F6B5 File Offset: 0x0084D8B5
	protected void ChangeState4_Implementation()
	{
		this.ChangeStateInternal(EKuroSceneInteractionState.State4);
	}

	// Token: 0x0601B108 RID: 110856 RVA: 0x0084F6C0 File Offset: 0x0084D8C0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void ChangeState5()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ChangeState5"), SceneInteractionActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ChangeState5_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B109 RID: 110857 RVA: 0x0084F719 File Offset: 0x0084D919
	protected void ChangeState5_Implementation()
	{
		this.ChangeStateInternal(EKuroSceneInteractionState.State5);
	}

	// Token: 0x0601B10A RID: 110858 RVA: 0x0084F724 File Offset: 0x0084D924
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void ChangeState6()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ChangeState6"), SceneInteractionActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ChangeState6_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B10B RID: 110859 RVA: 0x0084F77D File Offset: 0x0084D97D
	protected void ChangeState6_Implementation()
	{
		this.ChangeStateInternal(EKuroSceneInteractionState.State6);
	}

	// Token: 0x0601B10C RID: 110860 RVA: 0x0084F788 File Offset: 0x0084D988
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void ChangeState7()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ChangeState7"), SceneInteractionActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ChangeState7_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B10D RID: 110861 RVA: 0x0084F7E1 File Offset: 0x0084D9E1
	protected void ChangeState7_Implementation()
	{
		this.ChangeStateInternal(EKuroSceneInteractionState.State7);
	}

	// Token: 0x0601B10E RID: 110862 RVA: 0x0084F7EC File Offset: 0x0084D9EC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void ChangeState8()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ChangeState8"), SceneInteractionActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ChangeState8_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B10F RID: 110863 RVA: 0x0084F845 File Offset: 0x0084DA45
	protected void ChangeState8_Implementation()
	{
		this.ChangeStateInternal(EKuroSceneInteractionState.State8);
	}

	// Token: 0x0601B110 RID: 110864 RVA: 0x0084F850 File Offset: 0x0084DA50
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void 模拟Tag添加()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("模拟Tag添加"), SceneInteractionActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.模拟Tag添加_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B111 RID: 110865 RVA: 0x0084F8AC File Offset: 0x0084DAAC
	protected void 模拟Tag添加_Implementation()
	{
		FGameplayTag 模拟Tag = this.模拟Tag;
		this.PlayExtraEffectOnTagsChange(this.模拟Tag, this.跳过表现过程);
	}

	// Token: 0x0601B112 RID: 110866 RVA: 0x0084F8D4 File Offset: 0x0084DAD4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void 模拟Tag移除()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("模拟Tag移除"), SceneInteractionActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.模拟Tag移除_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B113 RID: 110867 RVA: 0x0084F930 File Offset: 0x0084DB30
	protected void 模拟Tag移除_Implementation()
	{
		FGameplayTag 模拟Tag = this.模拟Tag;
		this.StopExtraEffectOnTagsChange(this.模拟Tag);
		SSceneInteractionTags ssceneInteractionTags;
		if (this.TagsAndCorrespondingEffects != null && this.TagsAndCorrespondingEffects.TryGetValue(this.模拟Tag, out ssceneInteractionTags))
		{
			SSceneInteractionSequence ssceneInteractionSequence = (ssceneInteractionTags != null) ? ssceneInteractionTags.Sequence : null;
			if (ssceneInteractionSequence != null)
			{
				SSceneInteractionSequence ssceneInteractionSequence2 = new SSceneInteractionSequence
				{
					Sequence = ssceneInteractionSequence.Sequence,
					IsLoop = ssceneInteractionSequence.IsLoop,
					Reverse = !ssceneInteractionSequence.Reverse,
					PlayRate = ssceneInteractionSequence.PlayRate
				};
				ULevelSequence sequence = ssceneInteractionSequence2.Sequence;
				if (sequence != null)
				{
					ALevelSequenceActor alevelSequenceActor = this.CreateDirectorBySequence(sequence);
					if (alevelSequenceActor != null)
					{
						this.PlaySequence(alevelSequenceActor, ssceneInteractionSequence2, ssceneInteractionTags.Actors, true);
					}
				}
			}
		}
	}

	// Token: 0x0601B114 RID: 110868 RVA: 0x0084F9EC File Offset: 0x0084DBEC
	private void ChangeStateInternal(EKuroSceneInteractionState stateId)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.SceneGameplay;
		ELogAuthor author = ELogAuthor.YSQ;
		string message = "change state";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("stateId", stateId);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.Active = true;
		this.SetState(stateId, this.需要过渡状态, this.跳过表现过程);
	}

	// Token: 0x0601B115 RID: 110869 RVA: 0x0084FA40 File Offset: 0x0084DC40
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void 重置()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("重置"), SceneInteractionActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.重置_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B116 RID: 110870 RVA: 0x0084FA9C File Offset: 0x0084DC9C
	protected void 重置_Implementation()
	{
		string[] array = UKismetSystemLibrary.GetPathName(base.GetLevel()).Split('/', StringSplitOptions.None);
		string text = "";
		for (int i = 1; i < array.Length - 1; i++)
		{
			string str = array[i];
			text = text + "/" + str;
		}
		string[] array2 = array[array.Length - 1].Split(':', StringSplitOptions.None)[0].Split('.', StringSplitOptions.None);
		string str2 = array2[array2.Length - 1];
		text = text + "/" + str2;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.SceneGameplay;
		ELogAuthor author = ELogAuthor.YSQ;
		string message = "ResetState";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("levelName", text);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		TsCharacterController characterController = Global.CharacterController;
		if (characterController == null)
		{
			return;
		}
		characterController.ClientTravel(text, ETravelType.TRAVEL_Absolute, true, default(FGuid));
	}

	// Token: 0x0601B117 RID: 110871 RVA: 0x0084FB5B File Offset: 0x0084DD5B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (SceneInteractionActor._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Scene/Item/SceneInteractionActor.SceneInteractionActor_C");
		}
		return SceneInteractionActor._ClassPtr;
	}

	// Token: 0x0601B118 RID: 110872 RVA: 0x0084FB80 File Offset: 0x0084DD80
	public SceneInteractionActor() : this(BuiltinUtils.AllocNativeUObject(SceneInteractionActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601B119 RID: 110873 RVA: 0x0084FBA8 File Offset: 0x0084DDA8
	public SceneInteractionActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SceneInteractionActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601B11A RID: 110874 RVA: 0x0084FBDC File Offset: 0x0084DDDC
	protected SceneInteractionActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601B11B RID: 110875 RVA: 0x0084FC7C File Offset: 0x0084DE7C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_SetOverrideSeqBindActor_Implementation(SceneInteractionActor.__SetOverrideSeqBindActor_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->actorToBind);
		string bindingName = FString.ToString((void*)(&__Params->bindingName));
		this.SetOverrideSeqBindActor_Implementation(orCreateUObjectByNativePointer, bindingName);
	}

	// Token: 0x0601B11C RID: 110876 RVA: 0x0084FCAC File Offset: 0x0084DEAC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_UnsetOverrideSeqBindActor_Implementation(SceneInteractionActor.__UnsetOverrideSeqBindActor_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->actorToUnbind);
		string bindingName = FString.ToString((void*)(&__Params->bindingName));
		this.UnsetOverrideSeqBindActor_Implementation(orCreateUObjectByNativePointer, bindingName);
	}

	// Token: 0x0601B11D RID: 110877 RVA: 0x0084FCDA File Offset: 0x0084DEDA
	protected virtual void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		this.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601B11E RID: 110878 RVA: 0x0084FCE4 File Offset: 0x0084DEE4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveEndPlay_Implementation(AActor.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		this.ReceiveEndPlay_Implementation(endPlayReason);
	}

	// Token: 0x0601B11F RID: 110879 RVA: 0x0084FD04 File Offset: 0x0084DF04
	protected virtual void __CPPCALL_AddNewState_Implementation()
	{
		this.AddNewState_Implementation();
	}

	// Token: 0x0601B120 RID: 110880 RVA: 0x0084FD0C File Offset: 0x0084DF0C
	protected virtual void __CPPCALL_AddNewEffect_Implementation()
	{
		this.AddNewEffect_Implementation();
	}

	// Token: 0x0601B121 RID: 110881 RVA: 0x0084FD14 File Offset: 0x0084DF14
	protected virtual void __CPPCALL_AddNewEndEffect_Implementation()
	{
		this.AddNewEndEffect_Implementation();
	}

	// Token: 0x0601B122 RID: 110882 RVA: 0x0084FD1C File Offset: 0x0084DF1C
	protected virtual void __CPPCALL_UpdateTimeDilation_Implementation()
	{
		this.UpdateTimeDilation_Implementation();
	}

	// Token: 0x0601B123 RID: 110883 RVA: 0x0084FD24 File Offset: 0x0084DF24
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_CheckAllEffectPlaying_Implementation(SceneInteractionActor.__CheckAllEffectPlaying_FunctionParams* __Params)
	{
		__Params->__Result = this.CheckAllEffectPlaying_Implementation();
	}

	// Token: 0x0601B124 RID: 110884 RVA: 0x0084FD34 File Offset: 0x0084DF34
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_PlayKuroSkeletalMeshDestruction_Implementation(SceneInteractionActor.__PlayKuroSkeletalMeshDestruction_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->actor);
		this.PlayKuroSkeletalMeshDestruction_Implementation(orCreateUObjectByNativePointer, __Params->isJumpToEnd);
	}

	// Token: 0x0601B125 RID: 110885 RVA: 0x0084FD5C File Offset: 0x0084DF5C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_OverrideKuroDestructibleActorPhysicsVelocity_Implementation(SceneInteractionActor.__OverrideKuroDestructibleActorPhysicsVelocity_FunctionParams* __Params)
	{
		AKuroDestructibleActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AKuroDestructibleActor>(__Params->skeletalMeshDestruction);
		this.OverrideKuroDestructibleActorPhysicsVelocity_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601B126 RID: 110886 RVA: 0x0084FD7C File Offset: 0x0084DF7C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetActiveSequenceRemainTime_Implementation(SceneInteractionActor.__GetActiveSequenceRemainTime_FunctionParams* __Params)
	{
		ULevelSequence orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelSequence>(__Params->sequence);
		__Params->__Result = this.GetActiveSequenceRemainTime_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601B127 RID: 110887 RVA: 0x0084FDA2 File Offset: 0x0084DFA2
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ApplyAnimOptimizationParams_Implementation(SceneInteractionActor.__ApplyAnimOptimizationParams_FunctionParams* __Params)
	{
		this.ApplyAnimOptimizationParams_Implementation(__Params->bUseDistanceMap);
	}

	// Token: 0x0601B128 RID: 110888 RVA: 0x0084FDB0 File Offset: 0x0084DFB0
	protected virtual void __CPPCALL_PendingPlayStateEffect_Implementation()
	{
		this.PendingPlayStateEffect_Implementation();
	}

	// Token: 0x0601B129 RID: 110889 RVA: 0x0084FDB8 File Offset: 0x0084DFB8
	protected virtual void __CPPCALL_RemovePendingStateEffectTick_Implementation()
	{
		this.RemovePendingStateEffectTick_Implementation();
	}

	// Token: 0x0601B12A RID: 110890 RVA: 0x0084FDC0 File Offset: 0x0084DFC0
	protected virtual void __CPPCALL_PendingPlayCrossStateEffect_Implementation()
	{
		this.PendingPlayCrossStateEffect_Implementation();
	}

	// Token: 0x0601B12B RID: 110891 RVA: 0x0084FDC8 File Offset: 0x0084DFC8
	protected virtual void __CPPCALL_RemovePendingCrossStateEffectTick_Implementation()
	{
		this.RemovePendingCrossStateEffectTick_Implementation();
	}

	// Token: 0x0601B12C RID: 110892 RVA: 0x0084FDD0 File Offset: 0x0084DFD0
	protected virtual void __CPPCALL_PendingPlayTagEffect_Implementation()
	{
		this.PendingPlayTagEffect_Implementation();
	}

	// Token: 0x0601B12D RID: 110893 RVA: 0x0084FDD8 File Offset: 0x0084DFD8
	protected virtual void __CPPCALL_RemovePendingTagEffectTick_Implementation()
	{
		this.RemovePendingTagEffectTick_Implementation();
	}

	// Token: 0x0601B12E RID: 110894 RVA: 0x0084FDE0 File Offset: 0x0084DFE0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_PostAutoMergeEvent_Implementation(SceneInteractionActor.__PostAutoMergeEvent_FunctionParams* __Params)
	{
		string eventName = FString.ToString((void*)(&__Params->eventName));
		this.PostAutoMergeEvent_Implementation(eventName, __Params->tagId, __Params->follow);
	}

	// Token: 0x0601B12F RID: 110895 RVA: 0x0084FE10 File Offset: 0x0084E010
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_PostTagEvent_Implementation(SceneInteractionActor.__PostTagEvent_FunctionParams* __Params)
	{
		string eventName = FString.ToString((void*)(&__Params->eventName));
		this.PostTagEvent_Implementation(eventName, __Params->tag, __Params->follow);
	}

	// Token: 0x0601B130 RID: 110896 RVA: 0x0084FE3D File Offset: 0x0084E03D
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_StopTagAkEvent_Implementation(SceneInteractionActor.__StopTagAkEvent_FunctionParams* __Params)
	{
		this.StopTagAkEvent_Implementation(__Params->tag);
	}

	// Token: 0x0601B131 RID: 110897 RVA: 0x0084FE4B File Offset: 0x0084E04B
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_UpdateProjectionActorTransform_Implementation(SceneInteractionActor.__UpdateProjectionActorTransform_FunctionParams* __Params)
	{
		this.UpdateProjectionActorTransform_Implementation(__Params->transform);
	}

	// Token: 0x0601B132 RID: 110898 RVA: 0x0084FE5C File Offset: 0x0084E05C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_AddMatrialDataForChildrenActor_Implementation(SceneInteractionActor.__AddMatrialDataForChildrenActor_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->actor);
		ItemMaterialControllerActorData orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<ItemMaterialControllerActorData>(__Params->materialData);
		this.AddMatrialDataForChildrenActor_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601B133 RID: 110899 RVA: 0x0084FE89 File Offset: 0x0084E089
	protected virtual void __CPPCALL_RemoveActorProjection_Implementation()
	{
		this.RemoveActorProjection_Implementation();
	}

	// Token: 0x0601B134 RID: 110900 RVA: 0x0084FE91 File Offset: 0x0084E091
	protected virtual void __CPPCALL_DestroySelf_Implementation()
	{
		this.DestroySelf_Implementation();
	}

	// Token: 0x0601B135 RID: 110901 RVA: 0x0084FE99 File Offset: 0x0084E099
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ResetTagActorHide_Implementation(SceneInteractionActor.__ResetTagActorHide_FunctionParams* __Params)
	{
		this.ResetTagActorHide_Implementation(__Params->tag);
	}

	// Token: 0x0601B136 RID: 110902 RVA: 0x0084FEA8 File Offset: 0x0084E0A8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetDirectorBySequence_Implementation(SceneInteractionActor.__GetDirectorBySequence_FunctionParams* __Params)
	{
		ULevelSequence orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelSequence>(__Params->sequence);
		ref IntPtr ptr = ref *(&__Params->__Result);
		ALevelSequenceActor directorBySequence_Implementation = this.GetDirectorBySequence_Implementation(orCreateUObjectByNativePointer);
		ptr = ((directorBySequence_Implementation != null) ? directorBySequence_Implementation.NativePtr : ((IntPtr)0));
	}

	// Token: 0x0601B137 RID: 110903 RVA: 0x0084FEDD File Offset: 0x0084E0DD
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_StopExtraEffectOnTagsChange_Implementation(SceneInteractionActor.__StopExtraEffectOnTagsChange_FunctionParams* __Params)
	{
		this.StopExtraEffectOnTagsChange_Implementation(__Params->tag);
	}

	// Token: 0x0601B138 RID: 110904 RVA: 0x0084FEEB File Offset: 0x0084E0EB
	protected virtual void __CPPCALL_TryStopCurrentState_Implementation()
	{
		this.TryStopCurrentState_Implementation();
	}

	// Token: 0x0601B139 RID: 110905 RVA: 0x0084FEF3 File Offset: 0x0084E0F3
	protected virtual void __CPPCALL_使用字段值切换状态_Implementation()
	{
		this.使用字段值切换状态_Implementation();
	}

	// Token: 0x0601B13A RID: 110906 RVA: 0x0084FEFB File Offset: 0x0084E0FB
	protected virtual void __CPPCALL_ChangeState1_Implementation()
	{
		this.ChangeState1_Implementation();
	}

	// Token: 0x0601B13B RID: 110907 RVA: 0x0084FF03 File Offset: 0x0084E103
	protected virtual void __CPPCALL_ChangeState2_Implementation()
	{
		this.ChangeState2_Implementation();
	}

	// Token: 0x0601B13C RID: 110908 RVA: 0x0084FF0B File Offset: 0x0084E10B
	protected virtual void __CPPCALL_ChangeState3_Implementation()
	{
		this.ChangeState3_Implementation();
	}

	// Token: 0x0601B13D RID: 110909 RVA: 0x0084FF13 File Offset: 0x0084E113
	protected virtual void __CPPCALL_ChangeState4_Implementation()
	{
		this.ChangeState4_Implementation();
	}

	// Token: 0x0601B13E RID: 110910 RVA: 0x0084FF1B File Offset: 0x0084E11B
	protected virtual void __CPPCALL_ChangeState5_Implementation()
	{
		this.ChangeState5_Implementation();
	}

	// Token: 0x0601B13F RID: 110911 RVA: 0x0084FF23 File Offset: 0x0084E123
	protected virtual void __CPPCALL_ChangeState6_Implementation()
	{
		this.ChangeState6_Implementation();
	}

	// Token: 0x0601B140 RID: 110912 RVA: 0x0084FF2B File Offset: 0x0084E12B
	protected virtual void __CPPCALL_ChangeState7_Implementation()
	{
		this.ChangeState7_Implementation();
	}

	// Token: 0x0601B141 RID: 110913 RVA: 0x0084FF33 File Offset: 0x0084E133
	protected virtual void __CPPCALL_ChangeState8_Implementation()
	{
		this.ChangeState8_Implementation();
	}

	// Token: 0x0601B142 RID: 110914 RVA: 0x0084FF3B File Offset: 0x0084E13B
	protected virtual void __CPPCALL_模拟Tag添加_Implementation()
	{
		this.模拟Tag添加_Implementation();
	}

	// Token: 0x0601B143 RID: 110915 RVA: 0x0084FF43 File Offset: 0x0084E143
	protected virtual void __CPPCALL_模拟Tag移除_Implementation()
	{
		this.模拟Tag移除_Implementation();
	}

	// Token: 0x0601B144 RID: 110916 RVA: 0x0084FF4B File Offset: 0x0084E14B
	protected virtual void __CPPCALL_重置_Implementation()
	{
		this.重置_Implementation();
	}

	// Token: 0x0400EB10 RID: 60176
	private const float DEFAULT_DAMAGE_AMOUNT = 1f;

	// Token: 0x0400EB11 RID: 60177
	private string LevelName = string.Empty;

	// Token: 0x0400EB12 RID: 60178
	private int HandleId;

	// Token: 0x0400EB13 RID: 60179
	private int EntityId;

	// Token: 0x0400EB14 RID: 60180
	public int PbDataId;

	// Token: 0x0400EB15 RID: 60181
	[Nullable(2)]
	private Action OnInitCallback;

	// Token: 0x0400EB16 RID: 60182
	public bool Active = true;

	// Token: 0x0400EB17 RID: 60183
	[Nullable(2)]
	private ULevelSequencePlayer ActiveSequencePlayer;

	// Token: 0x0400EB18 RID: 60184
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<ULevelSequence, ALevelSequenceActor> ActiveSequenceDirectorMap;

	// Token: 0x0400EB19 RID: 60185
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<ALevelSequenceActor, SequenceDirectorConfig> DirectorConfigMap;

	// Token: 0x0400EB1A RID: 60186
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, EffectInfo> ActiveEffectInfoMap;

	// Token: 0x0400EB1B RID: 60187
	private EKuroSceneInteractionState? CurrentStateKey;

	// Token: 0x0400EB1C RID: 60188
	[Nullable(2)]
	private SSceneInteractionitem CurrentState;

	// Token: 0x0400EB1D RID: 60189
	private readonly System.Collections.Generic.LinkedList<SceneInteractionActor.PendingState> PendingStates = new System.Collections.Generic.LinkedList<SceneInteractionActor.PendingState>();

	// Token: 0x0400EB1E RID: 60190
	[Nullable(2)]
	private SceneInteractionActor.PendingState NextState;

	// Token: 0x0400EB1F RID: 60191
	private bool InDoSwitchState;

	// Token: 0x0400EB20 RID: 60192
	private bool InTransition;

	// Token: 0x0400EB21 RID: 60193
	private bool InWaitingForPlayableFinished;

	// Token: 0x0400EB22 RID: 60194
	private bool TransitionStateJumpToEnd;

	// Token: 0x0400EB23 RID: 60195
	private bool IsUseTransitionTime;

	// Token: 0x0400EB24 RID: 60196
	private float SwitchingStateRemainTime;

	// Token: 0x0400EB25 RID: 60197
	private bool IsPlayBack;

	// Token: 0x0400EB26 RID: 60198
	[Nullable(2)]
	private UKuroSceneInteractionActorSystem KuroSceneInteractionActorSystem;

	// Token: 0x0400EB27 RID: 60199
	[Nullable(2)]
	private AActor ProjectionRootActor;

	// Token: 0x0400EB28 RID: 60200
	private bool IsProjecting;

	// Token: 0x0400EB29 RID: 60201
	[Nullable(2)]
	public CharRenderingComponent CharRenderingComponent;

	// Token: 0x0400EB2A RID: 60202
	public int CharRenderingKey;

	// Token: 0x0400EB2B RID: 60203
	public FVectorDouble? HitLocation;

	// Token: 0x0400EB2C RID: 60204
	public FVectorDouble HitDirection = new FVectorDouble(0.0, 0.0, 1.0);

	// Token: 0x0400EB2D RID: 60205
	public FVectorDouble? RangeOtherActorLocation;

	// Token: 0x0400EB2E RID: 60206
	[Nullable(2)]
	public Vector RangeOtherActorVelocityProxy;

	// Token: 0x0400EB2F RID: 60207
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<CharRenderingComponent, int> CharRenderingComponents;

	// Token: 0x0400EB30 RID: 60208
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public HashSet<BP_EffectActor_C> CrossStateEffectActors;

	// Token: 0x0400EB31 RID: 60209
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<AActor, FTransformDouble> ActorsOriginalRelTransform;

	// Token: 0x0400EB32 RID: 60210
	[Nullable(2)]
	private BP_BasePlatform_C BasePlatformInternal;

	// Token: 0x0400EB33 RID: 60211
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private Dictionary<UStaticMeshComponent, Dictionary<int, UMaterialInterface>> RevertMaterialComponentsMaps;

	// Token: 0x0400EB34 RID: 60212
	private float CurrentStateAkEventHandle;

	// Token: 0x0400EB35 RID: 60213
	private bool MergeCurrentStateAkEvent;

	// Token: 0x0400EB36 RID: 60214
	[Nullable(2)]
	private Dictionary<FGameplayTag, int> PlayingTagAkEventHandle;

	// Token: 0x0400EB37 RID: 60215
	[Nullable(2)]
	private BP_GlobalGI_C GlobalGi;

	// Token: 0x0400EB38 RID: 60216
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<ASkeletalMeshActor, SkeletalMontageConfig> SkeletalMontageConfigMap;

	// Token: 0x0400EB39 RID: 60217
	private int SkeletalMeshDestructibleActorInitCount;

	// Token: 0x0400EB3A RID: 60218
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private HashSet<AKuroDestructibleActor> SkeletalMeshDestructibleActorsInternal;

	// Token: 0x0400EB3B RID: 60219
	private int DebugTickId = -1;

	// Token: 0x0400EB3C RID: 60220
	private List<BP_EffectActor_C> PendingStateEffects = new List<BP_EffectActor_C>();

	// Token: 0x0400EB3D RID: 60221
	private int PendingStateEffectTickId = -1;

	// Token: 0x0400EB3E RID: 60222
	private readonly Dictionary<FGameplayTag, List<BP_EffectActor_C>> PendingTagEffects = new Dictionary<FGameplayTag, List<BP_EffectActor_C>>();

	// Token: 0x0400EB3F RID: 60223
	private int PendingTagEffectTickId = -1;

	// Token: 0x0400EB40 RID: 60224
	private readonly Dictionary<BP_EffectActor_C, int> PendingCrossStateEffects = new Dictionary<BP_EffectActor_C, int>();

	// Token: 0x0400EB41 RID: 60225
	private int PendingCrossStateEffectTickId = -1;

	// Token: 0x0400EB42 RID: 60226
	public Dictionary<int, int> AkEventPostHandle = new Dictionary<int, int>();

	// Token: 0x0400EB43 RID: 60227
	[Nullable(2)]
	public Action OverrideEffectParmaFunc;

	// Token: 0x0400EB44 RID: 60228
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<string, AActor> OverrideSeqBindActors;

	// Token: 0x0400EB45 RID: 60229
	private bool IsAbpAnimPlayEnd;

	// Token: 0x0400EB46 RID: 60230
	[Nullable(2)]
	private List<int> TagCharDaHandleList;

	// Token: 0x0400EB47 RID: 60231
	[Nullable(2)]
	private Action<int> OnEffectFinishCallback;

	// Token: 0x0400EB48 RID: 60232
	[Nullable(2)]
	private Action<ELoadEffectResult, int> OnEffectPlayingCallback;

	// Token: 0x0400EB49 RID: 60233
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Scene/Item/SceneInteractionActor.SceneInteractionActor_C";

	// Token: 0x0400EB4A RID: 60234
	private static IntPtr _ClassPtr;

	// Token: 0x0400EB4B RID: 60235
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400EB4C RID: 60236
	private static int __PropertyOffset_MaxPendingStateCount;

	// Token: 0x0400EB4D RID: 60237
	private static int __PropertyOffset_States;

	// Token: 0x0400EB4E RID: 60238
	[Nullable(2)]
	private TMap<EKuroSceneInteractionState, SSceneInteractionitem> _States;

	// Token: 0x0400EB4F RID: 60239
	private static int __PropertyOffset_Effects;

	// Token: 0x0400EB50 RID: 60240
	[Nullable(2)]
	private TMap<ESceneInteractionEffect, SScenePropertyEffect> _Effects;

	// Token: 0x0400EB51 RID: 60241
	private static int __PropertyOffset_EffectsInheritTimeDilation;

	// Token: 0x0400EB52 RID: 60242
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<BP_EffectActor_C> _EffectsInheritTimeDilation;

	// Token: 0x0400EB53 RID: 60243
	private static int __PropertyOffset_EndEffects;

	// Token: 0x0400EB54 RID: 60244
	[Nullable(2)]
	private TMap<ESceneInteractionEffect, BP_EffectActor_C> _EndEffects;

	// Token: 0x0400EB55 RID: 60245
	private static int __PropertyOffset_ReferenceActors;

	// Token: 0x0400EB56 RID: 60246
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private TMap<string, AActor> _ReferenceActors;

	// Token: 0x0400EB57 RID: 60247
	private static int __PropertyOffset_TagsAndCorrespondingEffects;

	// Token: 0x0400EB58 RID: 60248
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TMap<FGameplayTag, SSceneInteractionTags> _TagsAndCorrespondingEffects;

	// Token: 0x0400EB59 RID: 60249
	private static int __PropertyOffset_CollisionActors;

	// Token: 0x0400EB5A RID: 60250
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<AActor> _CollisionActors;

	// Token: 0x0400EB5B RID: 60251
	private static int __PropertyOffset_PartCollisionActorsAndCorrespondingTags;

	// Token: 0x0400EB5C RID: 60252
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TMap<AActor, FGameplayTag> _PartCollisionActorsAndCorrespondingTags;

	// Token: 0x0400EB5D RID: 60253
	private static int __PropertyOffset_InteractionEffectHookActors;

	// Token: 0x0400EB5E RID: 60254
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<AActor> _InteractionEffectHookActors;

	// Token: 0x0400EB5F RID: 60255
	private static int __PropertyOffset_CharacterForOrgan;

	// Token: 0x0400EB60 RID: 60256
	private static int __PropertyOffset_ActorsForProjection;

	// Token: 0x0400EB61 RID: 60257
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<AActor> _ActorsForProjection;

	// Token: 0x0400EB62 RID: 60258
	private static int __PropertyOffset_MaterialForProjection;

	// Token: 0x0400EB63 RID: 60259
	private static int __PropertyOffset_ReceivingDecalsActors;

	// Token: 0x0400EB64 RID: 60260
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<AActor> _ReceivingDecalsActors;

	// Token: 0x0400EB65 RID: 60261
	private static int __PropertyOffset_StaticMeshList;

	// Token: 0x0400EB66 RID: 60262
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<UStaticMesh> _StaticMeshList;

	// Token: 0x0400EB67 RID: 60263
	private static int __PropertyOffset_RangeOtherActorVelocitySource;

	// Token: 0x0400EB68 RID: 60264
	private static int __PropertyOffset_SkeletalMeshActors;

	// Token: 0x0400EB69 RID: 60265
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<ASkeletalMeshActor> _SkeletalMeshActors;

	// Token: 0x0400EB6A RID: 60266
	private static int __PropertyOffset_AllSkeletalMeshActors;

	// Token: 0x0400EB6B RID: 60267
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<ASkeletalMeshActor> _AllSkeletalMeshActors;

	// Token: 0x0400EB6C RID: 60268
	private static int __PropertyOffset_InteractionMaterialController;

	// Token: 0x0400EB6D RID: 60269
	private static int __PropertyOffset_OverrideEffectActor;

	// Token: 0x0400EB6E RID: 60270
	private static int __PropertyOffset_需要过渡状态;

	// Token: 0x0400EB6F RID: 60271
	private static int __PropertyOffset_跳过表现过程;

	// Token: 0x0400EB70 RID: 60272
	private static int __PropertyOffset_模拟状态;

	// Token: 0x0400EB71 RID: 60273
	private static int __PropertyOffset_模拟Tag;

	// Token: 0x02008A31 RID: 35377
	[NullableContext(0)]
	private sealed class PendingState
	{
		// Token: 0x06042A50 RID: 272976 RVA: 0x013CA07B File Offset: 0x013C827B
		public PendingState(EKuroSceneInteractionState targetState, bool needTransition, bool jumpToEnd)
		{
		}

		// Token: 0x0402BEA7 RID: 179879
		public readonly EKuroSceneInteractionState TargetState = targetState;

		// Token: 0x0402BEA8 RID: 179880
		public readonly bool NeedTransition = needTransition;

		// Token: 0x0402BEA9 RID: 179881
		public readonly bool JumpToEnd = jumpToEnd;
	}

	// Token: 0x02008A32 RID: 35378
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetOverrideSeqBindActor_FunctionParams
	{
		// Token: 0x0402BEAA RID: 179882
		[FieldOffset(0)]
		public IntPtr actorToBind;

		// Token: 0x0402BEAB RID: 179883
		[FieldOffset(8)]
		public FString bindingName;
	}

	// Token: 0x02008A33 RID: 35379
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __UnsetOverrideSeqBindActor_FunctionParams
	{
		// Token: 0x0402BEAC RID: 179884
		[FieldOffset(0)]
		public IntPtr actorToUnbind;

		// Token: 0x0402BEAD RID: 179885
		[FieldOffset(8)]
		public FString bindingName;
	}

	// Token: 0x02008A34 RID: 35380
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __CheckAllEffectPlaying_FunctionParams
	{
		// Token: 0x0402BEAE RID: 179886
		[FieldOffset(0)]
		public bool __Result;
	}

	// Token: 0x02008A35 RID: 35381
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __PlayKuroSkeletalMeshDestruction_FunctionParams
	{
		// Token: 0x0402BEAF RID: 179887
		[FieldOffset(0)]
		public IntPtr actor;

		// Token: 0x0402BEB0 RID: 179888
		[FieldOffset(8)]
		public bool isJumpToEnd;
	}

	// Token: 0x02008A36 RID: 35382
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __OverrideKuroDestructibleActorPhysicsVelocity_FunctionParams
	{
		// Token: 0x0402BEB1 RID: 179889
		[FieldOffset(0)]
		public IntPtr skeletalMeshDestruction;
	}

	// Token: 0x02008A37 RID: 35383
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetActiveSequenceRemainTime_FunctionParams
	{
		// Token: 0x0402BEB2 RID: 179890
		[FieldOffset(0)]
		public IntPtr sequence;

		// Token: 0x0402BEB3 RID: 179891
		[FieldOffset(8)]
		public float __Result;
	}

	// Token: 0x02008A38 RID: 35384
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __ApplyAnimOptimizationParams_FunctionParams
	{
		// Token: 0x0402BEB4 RID: 179892
		[FieldOffset(0)]
		public bool bUseDistanceMap;
	}

	// Token: 0x02008A39 RID: 35385
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __PostAutoMergeEvent_FunctionParams
	{
		// Token: 0x0402BEB5 RID: 179893
		[FieldOffset(0)]
		public FString eventName;

		// Token: 0x0402BEB6 RID: 179894
		[FieldOffset(16)]
		public float tagId;

		// Token: 0x0402BEB7 RID: 179895
		[FieldOffset(20)]
		public bool follow;
	}

	// Token: 0x02008A3A RID: 35386
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __PostTagEvent_FunctionParams
	{
		// Token: 0x0402BEB8 RID: 179896
		[FieldOffset(0)]
		public FString eventName;

		// Token: 0x0402BEB9 RID: 179897
		[FieldOffset(16)]
		public FGameplayTag tag;

		// Token: 0x0402BEBA RID: 179898
		[FieldOffset(28)]
		public bool follow;
	}

	// Token: 0x02008A3B RID: 35387
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 12)]
	protected ref struct __StopTagAkEvent_FunctionParams
	{
		// Token: 0x0402BEBB RID: 179899
		[FieldOffset(0)]
		public FGameplayTag tag;
	}

	// Token: 0x02008A3C RID: 35388
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	protected ref struct __UpdateProjectionActorTransform_FunctionParams
	{
		// Token: 0x0402BEBC RID: 179900
		[FieldOffset(0)]
		public FTransformDouble transform;
	}

	// Token: 0x02008A3D RID: 35389
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __AddMatrialDataForChildrenActor_FunctionParams
	{
		// Token: 0x0402BEBD RID: 179901
		[FieldOffset(0)]
		public IntPtr actor;

		// Token: 0x0402BEBE RID: 179902
		[FieldOffset(8)]
		public IntPtr materialData;
	}

	// Token: 0x02008A3E RID: 35390
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 12)]
	protected ref struct __ResetTagActorHide_FunctionParams
	{
		// Token: 0x0402BEBF RID: 179903
		[FieldOffset(0)]
		public FGameplayTag tag;
	}

	// Token: 0x02008A3F RID: 35391
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetDirectorBySequence_FunctionParams
	{
		// Token: 0x0402BEC0 RID: 179904
		[FieldOffset(0)]
		public IntPtr sequence;

		// Token: 0x0402BEC1 RID: 179905
		[FieldOffset(8)]
		public IntPtr __Result;
	}

	// Token: 0x02008A40 RID: 35392
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 12)]
	protected ref struct __StopExtraEffectOnTagsChange_FunctionParams
	{
		// Token: 0x0402BEC2 RID: 179906
		[FieldOffset(0)]
		public FGameplayTag tag;
	}
}

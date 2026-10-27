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

// Token: 0x02003491 RID: 13457
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Render/Scene/Item/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Scene/Item/SceneInteractionActor.SceneInteractionActor_C")]
public class SceneInteractionActor : AKuroSceneInteractionActor, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700287A RID: 10362
	// (get) Token: 0x0601D346 RID: 119622 RVA: 0x00821B56 File Offset: 0x0081FD56
	// (set) Token: 0x0601D347 RID: 119623 RVA: 0x00821B6A File Offset: 0x0081FD6A
	[UProperty(EPropertyFlags.CPF_None)]
	private unsafe string LevelName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SceneInteractionActor.__PropertyOffset_LevelName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SceneInteractionActor.__PropertyOffset_LevelName)), value);
		}
	}

	// Token: 0x1700287B RID: 10363
	// (get) Token: 0x0601D348 RID: 119624 RVA: 0x00821B7F File Offset: 0x0081FD7F
	// (set) Token: 0x0601D349 RID: 119625 RVA: 0x00821B8F File Offset: 0x0081FD8F
	[UProperty(EPropertyFlags.CPF_None)]
	private unsafe int HandleId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)SceneInteractionActor.__PropertyOffset_HandleId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)SceneInteractionActor.__PropertyOffset_HandleId) = value;
		}
	}

	// Token: 0x1700287C RID: 10364
	// (get) Token: 0x0601D34A RID: 119626 RVA: 0x00821BA0 File Offset: 0x0081FDA0
	// (set) Token: 0x0601D34B RID: 119627 RVA: 0x00821BB0 File Offset: 0x0081FDB0
	[UProperty(EPropertyFlags.CPF_None)]
	private unsafe int EntityId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)SceneInteractionActor.__PropertyOffset_EntityId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)SceneInteractionActor.__PropertyOffset_EntityId) = value;
		}
	}

	// Token: 0x1700287D RID: 10365
	// (get) Token: 0x0601D34C RID: 119628 RVA: 0x00821BC4 File Offset: 0x0081FDC4
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

	// Token: 0x1700287E RID: 10366
	// (get) Token: 0x0601D34D RID: 119629 RVA: 0x00821C00 File Offset: 0x0081FE00
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

	// Token: 0x1700287F RID: 10367
	// (get) Token: 0x0601D34E RID: 119630 RVA: 0x00821C3C File Offset: 0x0081FE3C
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

	// Token: 0x17002880 RID: 10368
	// (get) Token: 0x0601D34F RID: 119631 RVA: 0x00821C78 File Offset: 0x0081FE78
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

	// Token: 0x17002881 RID: 10369
	// (get) Token: 0x0601D350 RID: 119632 RVA: 0x00821CB4 File Offset: 0x0081FEB4
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

	// Token: 0x17002882 RID: 10370
	// (get) Token: 0x0601D351 RID: 119633 RVA: 0x00821CF0 File Offset: 0x0081FEF0
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

	// Token: 0x17002883 RID: 10371
	// (get) Token: 0x0601D352 RID: 119634 RVA: 0x00821D2C File Offset: 0x0081FF2C
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

	// Token: 0x17002884 RID: 10372
	// (get) Token: 0x0601D353 RID: 119635 RVA: 0x00821D68 File Offset: 0x0081FF68
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

	// Token: 0x17002885 RID: 10373
	// (get) Token: 0x0601D354 RID: 119636 RVA: 0x00821DA4 File Offset: 0x0081FFA4
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

	// Token: 0x17002886 RID: 10374
	// (get) Token: 0x0601D355 RID: 119637 RVA: 0x00821DDD File Offset: 0x0081FFDD
	// (set) Token: 0x0601D356 RID: 119638 RVA: 0x00821DF1 File Offset: 0x0081FFF1
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

	// Token: 0x17002887 RID: 10375
	// (get) Token: 0x0601D357 RID: 119639 RVA: 0x00821E08 File Offset: 0x00820008
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

	// Token: 0x17002888 RID: 10376
	// (get) Token: 0x0601D358 RID: 119640 RVA: 0x00821E41 File Offset: 0x00820041
	// (set) Token: 0x0601D359 RID: 119641 RVA: 0x00821E55 File Offset: 0x00820055
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

	// Token: 0x17002889 RID: 10377
	// (get) Token: 0x0601D35A RID: 119642 RVA: 0x00821E6C File Offset: 0x0082006C
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

	// Token: 0x1700288A RID: 10378
	// (get) Token: 0x0601D35B RID: 119643 RVA: 0x00821EA8 File Offset: 0x008200A8
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

	// Token: 0x1700288B RID: 10379
	// (get) Token: 0x0601D35C RID: 119644 RVA: 0x00821EE1 File Offset: 0x008200E1
	// (set) Token: 0x0601D35D RID: 119645 RVA: 0x00821EF1 File Offset: 0x008200F1
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

	// Token: 0x1700288C RID: 10380
	// (get) Token: 0x0601D35E RID: 119646 RVA: 0x00821F04 File Offset: 0x00820104
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

	// Token: 0x1700288D RID: 10381
	// (get) Token: 0x0601D35F RID: 119647 RVA: 0x00821F40 File Offset: 0x00820140
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

	// Token: 0x1700288E RID: 10382
	// (get) Token: 0x0601D360 RID: 119648 RVA: 0x00821F79 File Offset: 0x00820179
	// (set) Token: 0x0601D361 RID: 119649 RVA: 0x00821F8D File Offset: 0x0082018D
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

	// Token: 0x1700288F RID: 10383
	// (get) Token: 0x0601D362 RID: 119650 RVA: 0x00821FA2 File Offset: 0x008201A2
	// (set) Token: 0x0601D363 RID: 119651 RVA: 0x00821FB6 File Offset: 0x008201B6
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	private unsafe BP_BasePlatform_C BasePlatformInternal
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<BP_BasePlatform_C>(base.NativePtr / (IntPtr)sizeof(void*) + SceneInteractionActor.__PropertyOffset_BasePlatformInternal);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SceneInteractionActor.__PropertyOffset_BasePlatformInternal, value);
		}
	}

	// Token: 0x17002890 RID: 10384
	// (get) Token: 0x0601D364 RID: 119652 RVA: 0x00821FCB File Offset: 0x008201CB
	// (set) Token: 0x0601D365 RID: 119653 RVA: 0x00821FDB File Offset: 0x008201DB
	[UProperty(EPropertyFlags.CPF_None)]
	private unsafe int CurrentStateAkEventHandle
	{
		get
		{
			return *(base.NativePtr + (IntPtr)SceneInteractionActor.__PropertyOffset_CurrentStateAkEventHandle);
		}
		set
		{
			*(base.NativePtr + (IntPtr)SceneInteractionActor.__PropertyOffset_CurrentStateAkEventHandle) = value;
		}
	}

	// Token: 0x17002891 RID: 10385
	// (get) Token: 0x0601D366 RID: 119654 RVA: 0x00821FEC File Offset: 0x008201EC
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

	// Token: 0x17002892 RID: 10386
	// (get) Token: 0x0601D367 RID: 119655 RVA: 0x00822007 File Offset: 0x00820207
	// (set) Token: 0x0601D368 RID: 119656 RVA: 0x0082201B File Offset: 0x0082021B
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

	// Token: 0x0601D369 RID: 119657 RVA: 0x00822030 File Offset: 0x00820230
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetOverrideSeqBindActor(AActor actorToBind, [Nullable(2)] string bindingName = null)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetOverrideSeqBindActor"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		SceneInteractionActor.__SetOverrideSeqBindActor_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((SceneInteractionActor.__SetOverrideSeqBindActor_FunctionParams*)ptr + 15L / (long)sizeof(SceneInteractionActor.__SetOverrideSeqBindActor_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->actorToBind) = ((actorToBind != null) ? actorToBind.NativePtr : ((IntPtr)0));
			FString.CopyFrom((void*)(&ptr2->bindingName), bindingName);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601D36A RID: 119658 RVA: 0x008220C4 File Offset: 0x008202C4
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

	// Token: 0x0601D36B RID: 119659 RVA: 0x008221B4 File Offset: 0x008203B4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void UnsetOverrideSeqBindActor(AActor actorToUnbind, [Nullable(2)] string bindingName = null)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("UnsetOverrideSeqBindActor"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		SceneInteractionActor.__UnsetOverrideSeqBindActor_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((SceneInteractionActor.__UnsetOverrideSeqBindActor_FunctionParams*)ptr + 15L / (long)sizeof(SceneInteractionActor.__UnsetOverrideSeqBindActor_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->actorToUnbind) = ((actorToUnbind != null) ? actorToUnbind.NativePtr : ((IntPtr)0));
			FString.CopyFrom((void*)(&ptr2->bindingName), bindingName);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601D36C RID: 119660 RVA: 0x00822248 File Offset: 0x00820448
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

	// Token: 0x17002893 RID: 10387
	// (get) Token: 0x0601D36D RID: 119661 RVA: 0x008222A0 File Offset: 0x008204A0
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

	// Token: 0x0601D36E RID: 119662 RVA: 0x008223AC File Offset: 0x008205AC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveBeginPlay()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveBeginPlay"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601D36F RID: 119663 RVA: 0x0082241C File Offset: 0x0082061C
	protected virtual void ReceiveBeginPlay_Implementation()
	{
		this.PlayingTagAkEventHandle = new Dictionary<FGameplayTag, int>();
		if (Info.Instance.IsPlayInEditor)
		{
			ULevel level = base.GetLevel();
			UWorld uworld = (level != null) ? level.OwningWorld : null;
			if (UKismetSystemLibrary.GetPathName((uworld != null) ? uworld.PersistentLevel : null).Contains("/Game/Aki/Scene/InteractionLevel/Prefab"))
			{
				ResourceSystem.Instance.LoadTypeAsync(EBpTypeName.BP_GlobalGI_C.ToEnumString(), delegate
				{
					this.GlobalGi = (ActorSystem.Instance.Get(BP_GlobalGI_C.StaticClass(), base.D_GetTransform(), null, true) as BP_GlobalGI_C);
					this.GlobalGi.夜晚();
				}, "js_undefined");
				Info.Instance.SetInCg(true);
				this.Init(0, -1, base.GetName(), null, 0);
				Ticker ticker = TickSystem.Instance.Add(delegate(float delayTime)
				{
					this.Update(delayTime / 1000f);
				}, "Game", ETickingGroup.TG_PrePhysics, true, 0, false);
				if (ticker != null)
				{
					this.DebugTickId = ticker.Id;
				}
			}
		}
	}

	// Token: 0x0601D370 RID: 119664 RVA: 0x008224E0 File Offset: 0x008206E0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveEndPlay"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AActor.__ReceiveEndPlay_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AActor.__ReceiveEndPlay_FunctionParams*)ptr + 15L / (long)sizeof(AActor.__ReceiveEndPlay_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(byte*)(&ptr2->EndPlayReason) = (byte)EndPlayReason;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601D371 RID: 119665 RVA: 0x0082255C File Offset: 0x0082075C
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

	// Token: 0x0601D372 RID: 119666 RVA: 0x00822644 File Offset: 0x00820844
	private void RemoveDebugTicker()
	{
		if (this.DebugTickId != -1)
		{
			TickSystem.Instance.Remove(this.DebugTickId);
			this.DebugTickId = -1;
		}
	}

	// Token: 0x0601D373 RID: 119667 RVA: 0x00822668 File Offset: 0x00820868
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void AddNewState()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("AddNewState"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601D374 RID: 119668 RVA: 0x008226D8 File Offset: 0x008208D8
	protected void AddNewState_Implementation()
	{
		this.States.Add((EKuroSceneInteractionState)this.States.Num(), null);
	}

	// Token: 0x0601D375 RID: 119669 RVA: 0x008226F4 File Offset: 0x008208F4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void AddNewEffect()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("AddNewEffect"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601D376 RID: 119670 RVA: 0x00822764 File Offset: 0x00820964
	protected void AddNewEffect_Implementation()
	{
		this.Effects.Add((ESceneInteractionEffect)this.Effects.Num(), null);
	}

	// Token: 0x0601D377 RID: 119671 RVA: 0x00822780 File Offset: 0x00820980
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void AddNewEndEffect()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("AddNewEndEffect"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601D378 RID: 119672 RVA: 0x008227F0 File Offset: 0x008209F0
	protected void AddNewEndEffect_Implementation()
	{
		this.EndEffects.Add((ESceneInteractionEffect)this.EndEffects.Num(), null);
	}

	// Token: 0x0601D379 RID: 119673 RVA: 0x0082280C File Offset: 0x00820A0C
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

	// Token: 0x0601D37A RID: 119674 RVA: 0x008228AD File Offset: 0x00820AAD
	public void PlayStateBpMaterialRuntimeParUpdate(SSceneInteractionitem state)
	{
		if (state.BP_MaterialRuntimeParUpdate != null)
		{
			state.BP_MaterialRuntimeParUpdate.IsPlay = true;
			state.BP_MaterialRuntimeParUpdate.Set_Initialize();
		}
	}

	// Token: 0x0601D37B RID: 119675 RVA: 0x008228D0 File Offset: 0x00820AD0
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

	// Token: 0x0601D37C RID: 119676 RVA: 0x00822998 File Offset: 0x00820B98
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

	// Token: 0x0601D37D RID: 119677 RVA: 0x00822A18 File Offset: 0x00820C18
	public void PlayIndependentEndEffect(ESceneInteractionEffect effectKey)
	{
		BP_EffectActor_C valueOrDefault = this.EndEffects.GetValueOrDefault(effectKey);
		if (valueOrDefault == null)
		{
			return;
		}
		this.PlayEffect(valueOrDefault, "[SceneInteractionActor.PlayIndependentEndEffect]");
	}

	// Token: 0x0601D37E RID: 119678 RVA: 0x00822A44 File Offset: 0x00820C44
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
		if ((this.InTransition || this.InWaitingForPlayableFinished) && !this.CheckPlaying(deltaSeconds, this.CurrentState))
		{
			this.DoSwitchState(false);
		}
	}

	// Token: 0x0601D37F RID: 119679 RVA: 0x00822B28 File Offset: 0x00820D28
	public void SetTimeDilation(float customTimeDilation)
	{
		if (base.CustomTimeDilation != customTimeDilation)
		{
			base.CustomTimeDilation = customTimeDilation;
			this.UpdateTimeDilation();
		}
	}

	// Token: 0x0601D380 RID: 119680 RVA: 0x00822B40 File Offset: 0x00820D40
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void UpdateTimeDilation()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("UpdateTimeDilation"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601D381 RID: 119681 RVA: 0x00822BB0 File Offset: 0x00820DB0
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

	// Token: 0x0601D382 RID: 119682 RVA: 0x00822D64 File Offset: 0x00820F64
	public void Init(int pbDataId, int handleId, string levelName, [Nullable(2)] Action onInit, int entityId = 0)
	{
		this.PbDataId = pbDataId;
		this.HandleId = handleId;
		this.EntityId = entityId;
		this.LevelName = levelName;
		this.OnInitCallback = onInit;
		this.CurrentStateKey = new EKuroSceneInteractionState?(EKuroSceneInteractionState.Error);
		this.NextState = null;
		this.CurrentState = null;
		this.InTransition = false;
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
				goto IL_4C4;
			}
		}
		Action onInitCallback = this.OnInitCallback;
		if (onInitCallback != null)
		{
			onInitCallback();
		}
		IL_4C4:
		if (!LevelPrefabConfigModel.Instance.IsCloseUroPrefab(this.LevelName))
		{
			this.ApplyAnimOptimizationParams(true);
		}
	}

	// Token: 0x0601D383 RID: 119683 RVA: 0x0082326C File Offset: 0x0082146C
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

	// Token: 0x0601D384 RID: 119684 RVA: 0x008232D4 File Offset: 0x008214D4
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

	// Token: 0x0601D385 RID: 119685 RVA: 0x00823364 File Offset: 0x00821564
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

	// Token: 0x0601D386 RID: 119686 RVA: 0x00823390 File Offset: 0x00821590
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

	// Token: 0x0601D387 RID: 119687 RVA: 0x008233C2 File Offset: 0x008215C2
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

	// Token: 0x0601D388 RID: 119688 RVA: 0x008233D4 File Offset: 0x008215D4
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

	// Token: 0x0601D389 RID: 119689 RVA: 0x00823424 File Offset: 0x00821624
	public EKuroSceneInteractionState GetCurrentState()
	{
		return this.CurrentStateKey.Value;
	}

	// Token: 0x0601D38A RID: 119690 RVA: 0x00823434 File Offset: 0x00821634
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

	// Token: 0x0601D38B RID: 119691 RVA: 0x00823540 File Offset: 0x00821740
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual bool CheckAllEffectPlaying()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("CheckAllEffectPlaying"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		SceneInteractionActor.__CheckAllEffectPlaying_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((SceneInteractionActor.__CheckAllEffectPlaying_FunctionParams*)ptr + 15L / (long)sizeof(SceneInteractionActor.__CheckAllEffectPlaying_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601D38C RID: 119692 RVA: 0x008235B8 File Offset: 0x008217B8
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

	// Token: 0x0601D38D RID: 119693 RVA: 0x00823620 File Offset: 0x00821820
	private void StopEffect(BP_EffectActor_C effectActor, string reason, bool immediately)
	{
		if (effectActor == null || !effectActor.IsValid())
		{
			return;
		}
		effectActor.Stop(reason, immediately);
	}

	// Token: 0x0601D38E RID: 119694 RVA: 0x00823640 File Offset: 0x00821840
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
				FMovieSceneSequencePlaybackParams playbackPosition = new FMovieSceneSequencePlaybackParams(config.Reverse ? director.SequencePlayer.GetStartTime().Time : director.SequencePlayer.GetEndTime().Time, 0f, "", EMovieScenePositionType.Frame, EUpdatePositionMethod.Play);
				director.SequencePlayer.SetPlaybackPosition(playbackPosition);
			}
			director.SequencePlayer.SetPlayRate(config.PlayRate * base.CustomTimeDilation);
		}
	}

	// Token: 0x0601D38F RID: 119695 RVA: 0x00823994 File Offset: 0x00821B94
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

	// Token: 0x0601D390 RID: 119696 RVA: 0x008239E8 File Offset: 0x00821BE8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void PlayKuroSkeletalMeshDestruction(AActor actor, bool isJumpToEnd)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("PlayKuroSkeletalMeshDestruction"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		SceneInteractionActor.__PlayKuroSkeletalMeshDestruction_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((SceneInteractionActor.__PlayKuroSkeletalMeshDestruction_FunctionParams*)ptr + 15L / (long)sizeof(SceneInteractionActor.__PlayKuroSkeletalMeshDestruction_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->actor) = ((actor != null) ? actor.NativePtr : ((IntPtr)0));
			ptr2->isJumpToEnd = isJumpToEnd;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601D391 RID: 119697 RVA: 0x00823A74 File Offset: 0x00821C74
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

	// Token: 0x0601D392 RID: 119698 RVA: 0x00823ACC File Offset: 0x00821CCC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void OverrideKuroDestructibleActorPhysicsVelocity(AKuroDestructibleActor skeletalMeshDestruction)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OverrideKuroDestructibleActorPhysicsVelocity"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		SceneInteractionActor.__OverrideKuroDestructibleActorPhysicsVelocity_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((SceneInteractionActor.__OverrideKuroDestructibleActorPhysicsVelocity_FunctionParams*)ptr + 15L / (long)sizeof(SceneInteractionActor.__OverrideKuroDestructibleActorPhysicsVelocity_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->skeletalMeshDestruction) = ((skeletalMeshDestruction != null) ? skeletalMeshDestruction.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601D393 RID: 119699 RVA: 0x00823B50 File Offset: 0x00821D50
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

	// Token: 0x0601D394 RID: 119700 RVA: 0x00823C94 File Offset: 0x00821E94
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

	// Token: 0x0601D395 RID: 119701 RVA: 0x00823F28 File Offset: 0x00822128
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

	// Token: 0x0601D396 RID: 119702 RVA: 0x00824094 File Offset: 0x00822294
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
		FFrameTime frame = new FFrameTime(new FFrameNumber(num6), subFrame);
		FFrameTime time4 = ulevelSequencePlayer.GetCurrentTime().Time;
		float num7 = (float)time4.FrameNumber.Value + time4.SubFrame;
		if (MathUtils.Instance.IsNearlyEqual((double)num7, (double)num5, new double?(0.0001)))
		{
			return;
		}
		FMovieSceneSequencePlaybackParams playbackPosition = new FMovieSceneSequencePlaybackParams(frame, 0f, "", EMovieScenePositionType.Frame, EUpdatePositionMethod.Play);
		ulevelSequencePlayer.SetPlaybackPosition(playbackPosition);
	}

	// Token: 0x0601D397 RID: 119703 RVA: 0x00824230 File Offset: 0x00822430
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

	// Token: 0x0601D398 RID: 119704 RVA: 0x00824350 File Offset: 0x00822550
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

	// Token: 0x0601D399 RID: 119705 RVA: 0x008243A0 File Offset: 0x008225A0
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

	// Token: 0x0601D39A RID: 119706 RVA: 0x008243E4 File Offset: 0x008225E4
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

	// Token: 0x0601D39B RID: 119707 RVA: 0x008244B0 File Offset: 0x008226B0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual float GetActiveSequenceRemainTime(ULevelSequence sequence)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetActiveSequenceRemainTime"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		SceneInteractionActor.__GetActiveSequenceRemainTime_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((SceneInteractionActor.__GetActiveSequenceRemainTime_FunctionParams*)ptr + 15L / (long)sizeof(SceneInteractionActor.__GetActiveSequenceRemainTime_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->sequence) = ((sequence != null) ? sequence.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		float _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601D39C RID: 119708 RVA: 0x0082453C File Offset: 0x0082273C
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

	// Token: 0x0601D39D RID: 119709 RVA: 0x00824694 File Offset: 0x00822894
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

	// Token: 0x0601D39E RID: 119710 RVA: 0x008246E8 File Offset: 0x008228E8
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

	// Token: 0x0601D39F RID: 119711 RVA: 0x008247D4 File Offset: 0x008229D4
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

	// Token: 0x0601D3A0 RID: 119712 RVA: 0x00824818 File Offset: 0x00822A18
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

	// Token: 0x0601D3A1 RID: 119713 RVA: 0x00824860 File Offset: 0x00822A60
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

	// Token: 0x0601D3A2 RID: 119714 RVA: 0x008248A4 File Offset: 0x00822AA4
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

	// Token: 0x0601D3A3 RID: 119715 RVA: 0x00824958 File Offset: 0x00822B58
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

	// Token: 0x0601D3A4 RID: 119716 RVA: 0x0082499C File Offset: 0x00822B9C
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

	// Token: 0x0601D3A5 RID: 119717 RVA: 0x00824A20 File Offset: 0x00822C20
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

	// Token: 0x0601D3A6 RID: 119718 RVA: 0x00824A74 File Offset: 0x00822C74
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
		FFrameTime frame = new FFrameTime(new FFrameNumber(num6), subFrame);
		FFrameTime time4 = ulevelSequencePlayer.GetCurrentTime().Time;
		float num7 = (float)time4.FrameNumber.Value + time4.SubFrame;
		if (MathUtils.Instance.IsNearlyEqual((double)num7, (double)num5, new double?(0.0001)))
		{
			return;
		}
		FMovieSceneSequencePlaybackParams inPlaybackParams = new FMovieSceneSequencePlaybackParams(frame, 0f, "", EMovieScenePositionType.Frame, EUpdatePositionMethod.Play);
		ulevelSequencePlayer.PlayTo_Circle(inPlaybackParams, false, !sequenceDirectorConfig.Reverse);
	}

	// Token: 0x0601D3A7 RID: 119719 RVA: 0x00824C40 File Offset: 0x00822E40
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

	// Token: 0x0601D3A8 RID: 119720 RVA: 0x00824C84 File Offset: 0x00822E84
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

	// Token: 0x0601D3A9 RID: 119721 RVA: 0x00824D0C File Offset: 0x00822F0C
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

	// Token: 0x0601D3AA RID: 119722 RVA: 0x00824D8C File Offset: 0x00822F8C
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

	// Token: 0x0601D3AB RID: 119723 RVA: 0x00824F78 File Offset: 0x00823178
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void ApplyAnimOptimizationParams(bool bUseDistanceMap = true)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ApplyAnimOptimizationParams"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		SceneInteractionActor.__ApplyAnimOptimizationParams_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((SceneInteractionActor.__ApplyAnimOptimizationParams_FunctionParams*)ptr + 15L / (long)sizeof(SceneInteractionActor.__ApplyAnimOptimizationParams_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->bUseDistanceMap = bUseDistanceMap;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601D3AC RID: 119724 RVA: 0x00824FF0 File Offset: 0x008231F0
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

	// Token: 0x0601D3AD RID: 119725 RVA: 0x008251B4 File Offset: 0x008233B4
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

	// Token: 0x0601D3AE RID: 119726 RVA: 0x00825228 File Offset: 0x00823428
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void PendingPlayStateEffect()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("PendingPlayStateEffect"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601D3AF RID: 119727 RVA: 0x00825298 File Offset: 0x00823498
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

	// Token: 0x0601D3B0 RID: 119728 RVA: 0x00825300 File Offset: 0x00823500
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void RemovePendingStateEffectTick()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("RemovePendingStateEffectTick"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601D3B1 RID: 119729 RVA: 0x00825370 File Offset: 0x00823570
	protected void RemovePendingStateEffectTick_Implementation()
	{
		if (this.PendingStateEffectTickId != -1)
		{
			TickSystem.Instance.Remove(this.PendingStateEffectTickId);
			this.PendingStateEffectTickId = -1;
		}
	}

	// Token: 0x0601D3B2 RID: 119730 RVA: 0x00825394 File Offset: 0x00823594
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
						if (jumpToEnd && effectLifeTimeController != null)
						{
							effectLifeTimeController.JumpToEnd();
						}
					}
				}
			}
		}
	}

	// Token: 0x0601D3B3 RID: 119731 RVA: 0x008255A4 File Offset: 0x008237A4
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

	// Token: 0x0601D3B4 RID: 119732 RVA: 0x0082561C File Offset: 0x0082381C
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

	// Token: 0x0601D3B5 RID: 119733 RVA: 0x008256B4 File Offset: 0x008238B4
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

	// Token: 0x0601D3B6 RID: 119734 RVA: 0x00825838 File Offset: 0x00823A38
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void PendingPlayCrossStateEffect()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("PendingPlayCrossStateEffect"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601D3B7 RID: 119735 RVA: 0x008258A8 File Offset: 0x00823AA8
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

	// Token: 0x0601D3B8 RID: 119736 RVA: 0x0082594C File Offset: 0x00823B4C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void RemovePendingCrossStateEffectTick()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("RemovePendingCrossStateEffectTick"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601D3B9 RID: 119737 RVA: 0x008259BC File Offset: 0x00823BBC
	protected void RemovePendingCrossStateEffectTick_Implementation()
	{
		if (this.PendingCrossStateEffectTickId != -1)
		{
			TickSystem.Instance.Remove(this.PendingCrossStateEffectTickId);
			this.PendingCrossStateEffectTickId = -1;
		}
	}

	// Token: 0x0601D3BA RID: 119738 RVA: 0x008259E0 File Offset: 0x00823BE0
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

	// Token: 0x0601D3BB RID: 119739 RVA: 0x00825A34 File Offset: 0x00823C34
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

	// Token: 0x0601D3BC RID: 119740 RVA: 0x00825A78 File Offset: 0x00823C78
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

	// Token: 0x0601D3BD RID: 119741 RVA: 0x00825ABC File Offset: 0x00823CBC
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

	// Token: 0x0601D3BE RID: 119742 RVA: 0x00825AE8 File Offset: 0x00823CE8
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

	// Token: 0x0601D3BF RID: 119743 RVA: 0x00825B9C File Offset: 0x00823D9C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void PendingPlayTagEffect()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("PendingPlayTagEffect"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601D3C0 RID: 119744 RVA: 0x00825C0C File Offset: 0x00823E0C
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

	// Token: 0x0601D3C1 RID: 119745 RVA: 0x00825D3C File Offset: 0x00823F3C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void RemovePendingTagEffectTick()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("RemovePendingTagEffectTick"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601D3C2 RID: 119746 RVA: 0x00825DAC File Offset: 0x00823FAC
	protected void RemovePendingTagEffectTick_Implementation()
	{
		if (this.PendingTagEffectTickId != -1)
		{
			TickSystem.Instance.Remove(this.PendingTagEffectTickId);
			this.PendingTagEffectTickId = -1;
		}
	}

	// Token: 0x0601D3C3 RID: 119747 RVA: 0x00825DD0 File Offset: 0x00823FD0
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

	// Token: 0x0601D3C4 RID: 119748 RVA: 0x00825E5C File Offset: 0x0082405C
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

	// Token: 0x0601D3C5 RID: 119749 RVA: 0x0082610C File Offset: 0x0082430C
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

	// Token: 0x0601D3C6 RID: 119750 RVA: 0x00826294 File Offset: 0x00824494
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

	// Token: 0x0601D3C7 RID: 119751 RVA: 0x0082630C File Offset: 0x0082450C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void PostAutoMergeEvent(string eventName, float tagId, bool follow)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("PostAutoMergeEvent"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		SceneInteractionActor.__PostAutoMergeEvent_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((SceneInteractionActor.__PostAutoMergeEvent_FunctionParams*)ptr + 15L / (long)sizeof(SceneInteractionActor.__PostAutoMergeEvent_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			FString.CopyFrom((void*)(&ptr2->eventName), eventName);
			ptr2->tagId = tagId;
			ptr2->follow = follow;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601D3C8 RID: 119752 RVA: 0x00826398 File Offset: 0x00824598
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

	// Token: 0x0601D3C9 RID: 119753 RVA: 0x00826434 File Offset: 0x00824634
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void PostTagEvent(string eventName, FGameplayTag tag, bool follow)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("PostTagEvent"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		SceneInteractionActor.__PostTagEvent_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((SceneInteractionActor.__PostTagEvent_FunctionParams*)ptr + 15L / (long)sizeof(SceneInteractionActor.__PostTagEvent_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			FString.CopyFrom((void*)(&ptr2->eventName), eventName);
			ptr2->tag = tag;
			ptr2->follow = follow;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601D3CA RID: 119754 RVA: 0x008264C0 File Offset: 0x008246C0
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

	// Token: 0x0601D3CB RID: 119755 RVA: 0x00826530 File Offset: 0x00824730
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void StopTagAkEvent(FGameplayTag tag)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("StopTagAkEvent"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		SceneInteractionActor.__StopTagAkEvent_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((SceneInteractionActor.__StopTagAkEvent_FunctionParams*)ptr + 15L / (long)sizeof(SceneInteractionActor.__StopTagAkEvent_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->tag = tag;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601D3CC RID: 119756 RVA: 0x008265A8 File Offset: 0x008247A8
	protected void StopTagAkEvent_Implementation(FGameplayTag tag)
	{
		SSceneInteractionTags interactionTags;
		if (this.TagsAndCorrespondingEffects.TryGetValue(tag, out interactionTags))
		{
			this.StopTagAkEventNoBlueprint(tag, interactionTags);
		}
	}

	// Token: 0x0601D3CD RID: 119757 RVA: 0x008265D0 File Offset: 0x008247D0
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

	// Token: 0x0601D3CE RID: 119758 RVA: 0x0082666C File Offset: 0x0082486C
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

	// Token: 0x0601D3CF RID: 119759 RVA: 0x008266E8 File Offset: 0x008248E8
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
				this.CurrentStateAkEventHandle = 0;
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
			this.CurrentStateAkEventHandle = num;
		}
	}

	// Token: 0x0601D3D0 RID: 119760 RVA: 0x008267EC File Offset: 0x008249EC
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

	// Token: 0x0601D3D1 RID: 119761 RVA: 0x008268A8 File Offset: 0x00824AA8
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

	// Token: 0x0601D3D2 RID: 119762 RVA: 0x008268EC File Offset: 0x00824AEC
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

	// Token: 0x0601D3D3 RID: 119763 RVA: 0x00826920 File Offset: 0x00824B20
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

	// Token: 0x0601D3D4 RID: 119764 RVA: 0x00826B28 File Offset: 0x00824D28
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void UpdateProjectionActorTransform(FTransformDouble transform)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("UpdateProjectionActorTransform"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		SceneInteractionActor.__UpdateProjectionActorTransform_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((SceneInteractionActor.__UpdateProjectionActorTransform_FunctionParams*)ptr + 15L / (long)sizeof(SceneInteractionActor.__UpdateProjectionActorTransform_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->transform = transform;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601D3D5 RID: 119765 RVA: 0x00826BA0 File Offset: 0x00824DA0
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

	// Token: 0x0601D3D6 RID: 119766 RVA: 0x00826C04 File Offset: 0x00824E04
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void AddMatrialDataForChildrenActor(AActor actor, ItemMaterialControllerActorData materialData)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("AddMatrialDataForChildrenActor"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		SceneInteractionActor.__AddMatrialDataForChildrenActor_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((SceneInteractionActor.__AddMatrialDataForChildrenActor_FunctionParams*)ptr + 15L / (long)sizeof(SceneInteractionActor.__AddMatrialDataForChildrenActor_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->actor) = ((actor != null) ? actor.NativePtr : ((IntPtr)0));
			*(&ptr2->materialData) = ((materialData != null) ? materialData.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601D3D7 RID: 119767 RVA: 0x00826CA0 File Offset: 0x00824EA0
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

	// Token: 0x0601D3D8 RID: 119768 RVA: 0x00826D00 File Offset: 0x00824F00
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void RemoveActorProjection()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("RemoveActorProjection"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601D3D9 RID: 119769 RVA: 0x00826D70 File Offset: 0x00824F70
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

	// Token: 0x0601D3DA RID: 119770 RVA: 0x00826DD0 File Offset: 0x00824FD0
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

	// Token: 0x0601D3DB RID: 119771 RVA: 0x00826E28 File Offset: 0x00825028
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void DestroySelf()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("DestroySelf"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601D3DC RID: 119772 RVA: 0x00826E98 File Offset: 0x00825098
	protected void DestroySelf_Implementation()
	{
		this.SkeletalMeshDestructibleActorsInternal = null;
		this.DestroyActor(this);
	}

	// Token: 0x0601D3DD RID: 119773 RVA: 0x00826EA8 File Offset: 0x008250A8
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

	// Token: 0x0601D3DE RID: 119774 RVA: 0x00826F98 File Offset: 0x00825198
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ResetTagActorHide(FGameplayTag tag)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ResetTagActorHide"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		SceneInteractionActor.__ResetTagActorHide_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((SceneInteractionActor.__ResetTagActorHide_FunctionParams*)ptr + 15L / (long)sizeof(SceneInteractionActor.__ResetTagActorHide_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->tag = tag;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601D3DF RID: 119775 RVA: 0x00827010 File Offset: 0x00825210
	protected void ResetTagActorHide_Implementation(FGameplayTag tag)
	{
		SSceneInteractionTags interactionTags;
		if (this.TagsAndCorrespondingEffects != null && this.TagsAndCorrespondingEffects.TryGetValue(tag, out interactionTags))
		{
			this.ResetTagActorHideNoBlueprint(interactionTags);
		}
	}

	// Token: 0x0601D3E0 RID: 119776 RVA: 0x0082703C File Offset: 0x0082523C
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

	// Token: 0x0601D3E1 RID: 119777 RVA: 0x00827080 File Offset: 0x00825280
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

	// Token: 0x0601D3E2 RID: 119778 RVA: 0x008270C4 File Offset: 0x008252C4
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

	// Token: 0x0601D3E3 RID: 119779 RVA: 0x00827108 File Offset: 0x00825308
	public void SetTagStaticMehActorCollisionProfile(SSceneInteractionTags interactionTags)
	{
		TMap<AActor, FCollisionProfileName> addTagActorCollisionProfile = interactionTags.AddTagActorCollisionProfile;
		if (addTagActorCollisionProfile != null)
		{
			this.SetActorCollisionProfile(addTagActorCollisionProfile);
		}
	}

	// Token: 0x0601D3E4 RID: 119780 RVA: 0x00827128 File Offset: 0x00825328
	public void ResetTagStaticMehActorCollisionProfile(SSceneInteractionTags interactionTags)
	{
		TMap<AActor, FCollisionProfileName> removeTagActorCollisionProfile = interactionTags.RemoveTagActorCollisionProfile;
		if (removeTagActorCollisionProfile != null)
		{
			this.SetActorCollisionProfile(removeTagActorCollisionProfile);
		}
	}

	// Token: 0x0601D3E5 RID: 119781 RVA: 0x00827148 File Offset: 0x00825348
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

	// Token: 0x0601D3E6 RID: 119782 RVA: 0x008271D0 File Offset: 0x008253D0
	private void DoSwitchState(bool bWaitForCurrentFinished)
	{
		if (bWaitForCurrentFinished)
		{
			bool flag = false;
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
				flag = true;
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
							flag = true;
							goto IL_C8;
						}
					}
					if (animInstance is ABP_LevelPrefabDaiyu_C)
					{
						flag = true;
					}
				}
			}
			IL_C8:
			if (flag)
			{
				this.InWaitingForPlayableFinished = true;
				return;
			}
		}
		this.InWaitingForPlayableFinished = false;
		if (this.TransitionState != null)
		{
			this.InTransition = true;
			if (this.CurrentState != null)
			{
				this.StopState(this.CurrentState, this.TransitionState);
			}
			this.CurrentStateKey = this.TransitionStateKey;
			this.PlayState(this.TransitionState, this.CurrentState, this.TransitionStateJumpToEnd, this.TransitionStateKey.Value);
			this.SwitchingStateRemainTime = this.TransitionState.TransitionTime;
			this.IsUseTransitionTime = !this.CheckActivePlayable();
			this.TransitionState = null;
			this.TransitionStateKey = null;
			this.EmitStateReached(this.CurrentStateKey);
			return;
		}
		if (this.NextState != null)
		{
			this.SwitchingStateRemainTime = 0f;
			this.InTransition = false;
			if (this.CurrentState != null)
			{
				this.StopState(this.CurrentState, this.NextState);
			}
			this.CurrentStateKey = this.NextStateKey;
			this.PlayState(this.NextState, this.CurrentState, this.TransitionStateJumpToEnd, this.NextStateKey.Value);
			this.NextState = null;
			this.NextStateKey = null;
			this.EmitStateReached(this.CurrentStateKey);
			return;
		}
		this.TransitionState = null;
		this.TransitionStateKey = null;
		this.NextState = null;
		this.NextStateKey = null;
		this.InTransition = false;
		this.SwitchingStateRemainTime = 0f;
		Log.Instance.Error(ELogModule.Level, ELogAuthor.LWH, "Nothing to Switch, should not happened!", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x0601D3E7 RID: 119783 RVA: 0x00827448 File Offset: 0x00825648
	private void DetermineState(SSceneInteractionitem targetState, EKuroSceneInteractionState targetStateKey, bool needTransition, bool jumpToEnd)
	{
		this.NextState = targetState;
		this.NextStateKey = new EKuroSceneInteractionState?(targetStateKey);
		bool transitionStateJumpToEnd = jumpToEnd && !targetState.NeedExpressionAnyway;
		EKuroSceneInteractionState ekuroSceneInteractionState;
		SSceneInteractionitem transitionState;
		if (needTransition && this.CurrentState != null && this.CurrentState.TransitionMap.TryGetValue(targetStateKey, out ekuroSceneInteractionState) && this.States.TryGetValue(ekuroSceneInteractionState, out transitionState))
		{
			this.TransitionState = transitionState;
			this.TransitionStateKey = new EKuroSceneInteractionState?(ekuroSceneInteractionState);
			this.TransitionStateJumpToEnd = transitionStateJumpToEnd;
			return;
		}
		this.TransitionStateJumpToEnd = transitionStateJumpToEnd;
		this.TransitionState = null;
		this.TransitionStateKey = null;
	}

	// Token: 0x0601D3E8 RID: 119784 RVA: 0x008274E4 File Offset: 0x008256E4
	public unsafe void SetState(EKuroSceneInteractionState state, bool needTransition, bool jumpToEnd)
	{
		if (this.States == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderScene;
			ELogAuthor author = ELogAuthor.ZYL;
			string message = "状态为Undefined";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Actor", this.LevelName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("HandleID", this.HandleId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		SSceneInteractionitem valueOrDefault = this.States.GetValueOrDefault(state);
		if (valueOrDefault == null)
		{
			if (state != EKuroSceneInteractionState.ConcealedState)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.RenderScene;
				ELogAuthor author2 = ELogAuthor.MY;
				string message2 = "状态未配置";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("未配置状态", state + 1);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Actor", this.LevelName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("HandleID", this.HandleId);
				instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			}
			return;
		}
		if (this.InTransition && !valueOrDefault.IsForceSetState)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.RenderScene;
			ELogAuthor author3 = ELogAuthor.MY;
			string message3 = "正在过渡状态, 不可设置其他状态";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("Actor", this.LevelName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("HandleID", this.HandleId);
			instance3.Warn(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
			return;
		}
		if (this.NextState != null && !valueOrDefault.IsForceSetState)
		{
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.RenderScene;
			ELogAuthor author4 = ELogAuthor.MY;
			string message4 = "正在过渡状态, 不可设置其他状态";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("Actor", this.LevelName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("HandleID", this.HandleId);
			instance4.Warn(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 2));
			return;
		}
		EKuroSceneInteractionState? currentStateKey = this.CurrentStateKey;
		if (state == currentStateKey.GetValueOrDefault() & currentStateKey != null)
		{
			return;
		}
		SSceneInteractionitem currentState = this.CurrentState;
		if (currentState != null && currentState.WaitForPlayableFinished && this.InWaitingForPlayableFinished)
		{
			return;
		}
		this.DetermineState(valueOrDefault, state, needTransition, jumpToEnd);
		SSceneInteractionitem currentState2 = this.CurrentState;
		bool bWaitForCurrentFinished = currentState2 != null && currentState2.WaitForPlayableFinished;
		this.DoSwitchState(bWaitForCurrentFinished);
	}

	// Token: 0x0601D3E9 RID: 119785 RVA: 0x0082774C File Offset: 0x0082594C
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

	// Token: 0x0601D3EA RID: 119786 RVA: 0x00827A44 File Offset: 0x00825C44
	public void StopCurrentStateAkEvent(string context)
	{
		int currentStateAkEventHandle = this.CurrentStateAkEventHandle;
		if (this.MergeCurrentStateAkEvent)
		{
			EffectAudioController.Instance.OnStopEffectAudio(this.CurrentStateAkEventHandle, "SceneInteractionActor." + context, false);
			this.CurrentStateAkEventHandle = 0;
			return;
		}
		AudioSystem.Instance.ExecuteAction(this.CurrentStateAkEventHandle, EAudioActionType.Stop, null);
		this.CurrentStateAkEventHandle = 0;
	}

	// Token: 0x0601D3EB RID: 119787 RVA: 0x00827AA5 File Offset: 0x00825CA5
	public void OnAnimPlayEnd(string animName)
	{
		this.IsAbpAnimPlayEnd = true;
	}

	// Token: 0x0601D3EC RID: 119788 RVA: 0x00827AB0 File Offset: 0x00825CB0
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

	// Token: 0x0601D3ED RID: 119789 RVA: 0x00827B50 File Offset: 0x00825D50
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

	// Token: 0x0601D3EE RID: 119790 RVA: 0x00827B9C File Offset: 0x00825D9C
	private UKuroSceneInteractionActorSystem GetKuroSceneInteractionActorSystem()
	{
		if (this.KuroSceneInteractionActorSystem == null)
		{
			this.KuroSceneInteractionActorSystem = (UKuroRenderingRuntimeBPPluginBPLibrary.GetSubsystem(GlobalData.World, UKuroSceneInteractionActorSystem.StaticClass()) as UKuroSceneInteractionActorSystem);
		}
		return this.KuroSceneInteractionActorSystem;
	}

	// Token: 0x0601D3EF RID: 119791 RVA: 0x00827BCC File Offset: 0x00825DCC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	[return: Nullable(2)]
	protected unsafe virtual ALevelSequenceActor GetDirectorBySequence(ULevelSequence sequence)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetDirectorBySequence"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		SceneInteractionActor.__GetDirectorBySequence_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((SceneInteractionActor.__GetDirectorBySequence_FunctionParams*)ptr + 15L / (long)sizeof(SceneInteractionActor.__GetDirectorBySequence_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->sequence) = ((sequence != null) ? sequence.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		ALevelSequenceActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ALevelSequenceActor>(ptr2->__Result);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return orCreateUObjectByNativePointer;
	}

	// Token: 0x0601D3F0 RID: 119792 RVA: 0x00827C5C File Offset: 0x00825E5C
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

	// Token: 0x0601D3F1 RID: 119793 RVA: 0x00827C84 File Offset: 0x00825E84
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

	// Token: 0x0601D3F2 RID: 119794 RVA: 0x00827E1C File Offset: 0x0082601C
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

	// Token: 0x0601D3F3 RID: 119795 RVA: 0x00827E94 File Offset: 0x00826094
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void StopExtraEffectOnTagsChange(FGameplayTag tag)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("StopExtraEffectOnTagsChange"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		SceneInteractionActor.__StopExtraEffectOnTagsChange_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((SceneInteractionActor.__StopExtraEffectOnTagsChange_FunctionParams*)ptr + 15L / (long)sizeof(SceneInteractionActor.__StopExtraEffectOnTagsChange_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->tag = tag;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601D3F4 RID: 119796 RVA: 0x00827F0C File Offset: 0x0082610C
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

	// Token: 0x0601D3F5 RID: 119797 RVA: 0x00827F6E File Offset: 0x0082616E
	public void UpdateHitInfo(FVectorDouble pos, FVector dir)
	{
		this.HitLocation = new FVectorDouble?(pos);
		this.HitDirection.Set((double)dir.X, (double)dir.Y, (double)dir.Z);
	}

	// Token: 0x0601D3F6 RID: 119798 RVA: 0x00827F9C File Offset: 0x0082619C
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

	// Token: 0x0601D3F7 RID: 119799 RVA: 0x00828078 File Offset: 0x00826278
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void TryStopCurrentState()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("TryStopCurrentState"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601D3F8 RID: 119800 RVA: 0x008280E8 File Offset: 0x008262E8
	protected void TryStopCurrentState_Implementation()
	{
		if (this.CurrentState != null)
		{
			this.StopState(this.CurrentState, null);
		}
	}

	// Token: 0x17002894 RID: 10388
	// (get) Token: 0x0601D3F9 RID: 119801 RVA: 0x00828105 File Offset: 0x00826305
	// (set) Token: 0x0601D3FA RID: 119802 RVA: 0x00828115 File Offset: 0x00826315
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

	// Token: 0x17002895 RID: 10389
	// (get) Token: 0x0601D3FB RID: 119803 RVA: 0x00828126 File Offset: 0x00826326
	// (set) Token: 0x0601D3FC RID: 119804 RVA: 0x00828136 File Offset: 0x00826336
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

	// Token: 0x17002896 RID: 10390
	// (get) Token: 0x0601D3FD RID: 119805 RVA: 0x00828147 File Offset: 0x00826347
	// (set) Token: 0x0601D3FE RID: 119806 RVA: 0x00828157 File Offset: 0x00826357
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

	// Token: 0x17002897 RID: 10391
	// (get) Token: 0x0601D3FF RID: 119807 RVA: 0x00828168 File Offset: 0x00826368
	// (set) Token: 0x0601D400 RID: 119808 RVA: 0x0082817C File Offset: 0x0082637C
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

	// Token: 0x0601D401 RID: 119809 RVA: 0x00828194 File Offset: 0x00826394
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void 使用字段值切换状态()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("使用字段值切换状态"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601D402 RID: 119810 RVA: 0x00828204 File Offset: 0x00826404
	protected void 使用字段值切换状态_Implementation()
	{
		this.ChangeStateInternal(this.模拟状态);
	}

	// Token: 0x0601D403 RID: 119811 RVA: 0x00828214 File Offset: 0x00826414
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ChangeState1()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ChangeState1"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601D404 RID: 119812 RVA: 0x00828284 File Offset: 0x00826484
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

	// Token: 0x0601D405 RID: 119813 RVA: 0x008282E0 File Offset: 0x008264E0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ChangeState2()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ChangeState2"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601D406 RID: 119814 RVA: 0x00828350 File Offset: 0x00826550
	protected void ChangeState2_Implementation()
	{
		this.ChangeStateInternal(EKuroSceneInteractionState.State2);
	}

	// Token: 0x0601D407 RID: 119815 RVA: 0x0082835C File Offset: 0x0082655C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ChangeState3()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ChangeState3"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601D408 RID: 119816 RVA: 0x008283CC File Offset: 0x008265CC
	protected void ChangeState3_Implementation()
	{
		this.ChangeStateInternal(EKuroSceneInteractionState.State3);
	}

	// Token: 0x0601D409 RID: 119817 RVA: 0x008283D8 File Offset: 0x008265D8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ChangeState4()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ChangeState4"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601D40A RID: 119818 RVA: 0x00828448 File Offset: 0x00826648
	protected void ChangeState4_Implementation()
	{
		this.ChangeStateInternal(EKuroSceneInteractionState.State4);
	}

	// Token: 0x0601D40B RID: 119819 RVA: 0x00828454 File Offset: 0x00826654
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ChangeState5()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ChangeState5"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601D40C RID: 119820 RVA: 0x008284C4 File Offset: 0x008266C4
	protected void ChangeState5_Implementation()
	{
		this.ChangeStateInternal(EKuroSceneInteractionState.State5);
	}

	// Token: 0x0601D40D RID: 119821 RVA: 0x008284D0 File Offset: 0x008266D0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ChangeState6()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ChangeState6"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601D40E RID: 119822 RVA: 0x00828540 File Offset: 0x00826740
	protected void ChangeState6_Implementation()
	{
		this.ChangeStateInternal(EKuroSceneInteractionState.State6);
	}

	// Token: 0x0601D40F RID: 119823 RVA: 0x0082854C File Offset: 0x0082674C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ChangeState7()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ChangeState7"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601D410 RID: 119824 RVA: 0x008285BC File Offset: 0x008267BC
	protected void ChangeState7_Implementation()
	{
		this.ChangeStateInternal(EKuroSceneInteractionState.State7);
	}

	// Token: 0x0601D411 RID: 119825 RVA: 0x008285C8 File Offset: 0x008267C8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ChangeState8()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ChangeState8"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601D412 RID: 119826 RVA: 0x00828638 File Offset: 0x00826838
	protected void ChangeState8_Implementation()
	{
		this.ChangeStateInternal(EKuroSceneInteractionState.State8);
	}

	// Token: 0x0601D413 RID: 119827 RVA: 0x00828644 File Offset: 0x00826844
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void 模拟Tag添加()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("模拟Tag添加"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601D414 RID: 119828 RVA: 0x008286B4 File Offset: 0x008268B4
	protected void 模拟Tag添加_Implementation()
	{
		FGameplayTag 模拟Tag = this.模拟Tag;
		this.PlayExtraEffectOnTagsChange(this.模拟Tag, this.跳过表现过程);
	}

	// Token: 0x0601D415 RID: 119829 RVA: 0x008286DC File Offset: 0x008268DC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void 模拟Tag移除()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("模拟Tag移除"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601D416 RID: 119830 RVA: 0x0082874C File Offset: 0x0082694C
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
				SSceneInteractionSequence ssceneInteractionSequence2 = new SSceneInteractionSequence(ssceneInteractionSequence.Sequence, ssceneInteractionSequence.IsLoop, !ssceneInteractionSequence.Reverse, ssceneInteractionSequence.PlayRate);
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

	// Token: 0x0601D417 RID: 119831 RVA: 0x008287EC File Offset: 0x008269EC
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

	// Token: 0x0601D418 RID: 119832 RVA: 0x00828840 File Offset: 0x00826A40
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void 重置()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("重置"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601D419 RID: 119833 RVA: 0x008288B0 File Offset: 0x00826AB0
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

	// Token: 0x0601D41A RID: 119834 RVA: 0x0082896F File Offset: 0x00826B6F
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (SceneInteractionActor._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Scene/Item/SceneInteractionActor.SceneInteractionActor_C");
		}
		return SceneInteractionActor._ClassPtr;
	}

	// Token: 0x0601D41B RID: 119835 RVA: 0x00828994 File Offset: 0x00826B94
	public SceneInteractionActor() : this(BuiltinUtils.AllocNativeUObject(SceneInteractionActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601D41C RID: 119836 RVA: 0x008289BC File Offset: 0x00826BBC
	public SceneInteractionActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SceneInteractionActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601D41D RID: 119837 RVA: 0x008289F0 File Offset: 0x00826BF0
	protected SceneInteractionActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601D41E RID: 119838 RVA: 0x00828A7C File Offset: 0x00826C7C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_SetOverrideSeqBindActor_Implementation(SceneInteractionActor.__SetOverrideSeqBindActor_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->actorToBind);
		string bindingName = FString.ToString((void*)(&__Params->bindingName));
		this.SetOverrideSeqBindActor_Implementation(orCreateUObjectByNativePointer, bindingName);
	}

	// Token: 0x0601D41F RID: 119839 RVA: 0x00828AAC File Offset: 0x00826CAC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_UnsetOverrideSeqBindActor_Implementation(SceneInteractionActor.__UnsetOverrideSeqBindActor_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->actorToUnbind);
		string bindingName = FString.ToString((void*)(&__Params->bindingName));
		this.UnsetOverrideSeqBindActor_Implementation(orCreateUObjectByNativePointer, bindingName);
	}

	// Token: 0x0601D420 RID: 119840 RVA: 0x00828ADA File Offset: 0x00826CDA
	protected virtual void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		this.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601D421 RID: 119841 RVA: 0x00828AE4 File Offset: 0x00826CE4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveEndPlay_Implementation(AActor.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		this.ReceiveEndPlay_Implementation(endPlayReason);
	}

	// Token: 0x0601D422 RID: 119842 RVA: 0x00828B04 File Offset: 0x00826D04
	protected virtual void __CPPCALL_AddNewState_Implementation()
	{
		this.AddNewState_Implementation();
	}

	// Token: 0x0601D423 RID: 119843 RVA: 0x00828B0C File Offset: 0x00826D0C
	protected virtual void __CPPCALL_AddNewEffect_Implementation()
	{
		this.AddNewEffect_Implementation();
	}

	// Token: 0x0601D424 RID: 119844 RVA: 0x00828B14 File Offset: 0x00826D14
	protected virtual void __CPPCALL_AddNewEndEffect_Implementation()
	{
		this.AddNewEndEffect_Implementation();
	}

	// Token: 0x0601D425 RID: 119845 RVA: 0x00828B1C File Offset: 0x00826D1C
	protected virtual void __CPPCALL_UpdateTimeDilation_Implementation()
	{
		this.UpdateTimeDilation_Implementation();
	}

	// Token: 0x0601D426 RID: 119846 RVA: 0x00828B24 File Offset: 0x00826D24
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_CheckAllEffectPlaying_Implementation(SceneInteractionActor.__CheckAllEffectPlaying_FunctionParams* __Params)
	{
		__Params->__Result = this.CheckAllEffectPlaying_Implementation();
	}

	// Token: 0x0601D427 RID: 119847 RVA: 0x00828B34 File Offset: 0x00826D34
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_PlayKuroSkeletalMeshDestruction_Implementation(SceneInteractionActor.__PlayKuroSkeletalMeshDestruction_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->actor);
		this.PlayKuroSkeletalMeshDestruction_Implementation(orCreateUObjectByNativePointer, __Params->isJumpToEnd);
	}

	// Token: 0x0601D428 RID: 119848 RVA: 0x00828B5C File Offset: 0x00826D5C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_OverrideKuroDestructibleActorPhysicsVelocity_Implementation(SceneInteractionActor.__OverrideKuroDestructibleActorPhysicsVelocity_FunctionParams* __Params)
	{
		AKuroDestructibleActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AKuroDestructibleActor>(__Params->skeletalMeshDestruction);
		this.OverrideKuroDestructibleActorPhysicsVelocity_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601D429 RID: 119849 RVA: 0x00828B7C File Offset: 0x00826D7C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetActiveSequenceRemainTime_Implementation(SceneInteractionActor.__GetActiveSequenceRemainTime_FunctionParams* __Params)
	{
		ULevelSequence orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelSequence>(__Params->sequence);
		__Params->__Result = this.GetActiveSequenceRemainTime_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601D42A RID: 119850 RVA: 0x00828BA2 File Offset: 0x00826DA2
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ApplyAnimOptimizationParams_Implementation(SceneInteractionActor.__ApplyAnimOptimizationParams_FunctionParams* __Params)
	{
		this.ApplyAnimOptimizationParams_Implementation(__Params->bUseDistanceMap);
	}

	// Token: 0x0601D42B RID: 119851 RVA: 0x00828BB0 File Offset: 0x00826DB0
	protected virtual void __CPPCALL_PendingPlayStateEffect_Implementation()
	{
		this.PendingPlayStateEffect_Implementation();
	}

	// Token: 0x0601D42C RID: 119852 RVA: 0x00828BB8 File Offset: 0x00826DB8
	protected virtual void __CPPCALL_RemovePendingStateEffectTick_Implementation()
	{
		this.RemovePendingStateEffectTick_Implementation();
	}

	// Token: 0x0601D42D RID: 119853 RVA: 0x00828BC0 File Offset: 0x00826DC0
	protected virtual void __CPPCALL_PendingPlayCrossStateEffect_Implementation()
	{
		this.PendingPlayCrossStateEffect_Implementation();
	}

	// Token: 0x0601D42E RID: 119854 RVA: 0x00828BC8 File Offset: 0x00826DC8
	protected virtual void __CPPCALL_RemovePendingCrossStateEffectTick_Implementation()
	{
		this.RemovePendingCrossStateEffectTick_Implementation();
	}

	// Token: 0x0601D42F RID: 119855 RVA: 0x00828BD0 File Offset: 0x00826DD0
	protected virtual void __CPPCALL_PendingPlayTagEffect_Implementation()
	{
		this.PendingPlayTagEffect_Implementation();
	}

	// Token: 0x0601D430 RID: 119856 RVA: 0x00828BD8 File Offset: 0x00826DD8
	protected virtual void __CPPCALL_RemovePendingTagEffectTick_Implementation()
	{
		this.RemovePendingTagEffectTick_Implementation();
	}

	// Token: 0x0601D431 RID: 119857 RVA: 0x00828BE0 File Offset: 0x00826DE0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_PostAutoMergeEvent_Implementation(SceneInteractionActor.__PostAutoMergeEvent_FunctionParams* __Params)
	{
		string eventName = FString.ToString((void*)(&__Params->eventName));
		this.PostAutoMergeEvent_Implementation(eventName, __Params->tagId, __Params->follow);
	}

	// Token: 0x0601D432 RID: 119858 RVA: 0x00828C10 File Offset: 0x00826E10
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_PostTagEvent_Implementation(SceneInteractionActor.__PostTagEvent_FunctionParams* __Params)
	{
		string eventName = FString.ToString((void*)(&__Params->eventName));
		this.PostTagEvent_Implementation(eventName, __Params->tag, __Params->follow);
	}

	// Token: 0x0601D433 RID: 119859 RVA: 0x00828C3D File Offset: 0x00826E3D
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_StopTagAkEvent_Implementation(SceneInteractionActor.__StopTagAkEvent_FunctionParams* __Params)
	{
		this.StopTagAkEvent_Implementation(__Params->tag);
	}

	// Token: 0x0601D434 RID: 119860 RVA: 0x00828C4B File Offset: 0x00826E4B
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_UpdateProjectionActorTransform_Implementation(SceneInteractionActor.__UpdateProjectionActorTransform_FunctionParams* __Params)
	{
		this.UpdateProjectionActorTransform_Implementation(__Params->transform);
	}

	// Token: 0x0601D435 RID: 119861 RVA: 0x00828C5C File Offset: 0x00826E5C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_AddMatrialDataForChildrenActor_Implementation(SceneInteractionActor.__AddMatrialDataForChildrenActor_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->actor);
		ItemMaterialControllerActorData orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<ItemMaterialControllerActorData>(__Params->materialData);
		this.AddMatrialDataForChildrenActor_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601D436 RID: 119862 RVA: 0x00828C89 File Offset: 0x00826E89
	protected virtual void __CPPCALL_RemoveActorProjection_Implementation()
	{
		this.RemoveActorProjection_Implementation();
	}

	// Token: 0x0601D437 RID: 119863 RVA: 0x00828C91 File Offset: 0x00826E91
	protected virtual void __CPPCALL_DestroySelf_Implementation()
	{
		this.DestroySelf_Implementation();
	}

	// Token: 0x0601D438 RID: 119864 RVA: 0x00828C99 File Offset: 0x00826E99
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ResetTagActorHide_Implementation(SceneInteractionActor.__ResetTagActorHide_FunctionParams* __Params)
	{
		this.ResetTagActorHide_Implementation(__Params->tag);
	}

	// Token: 0x0601D439 RID: 119865 RVA: 0x00828CA8 File Offset: 0x00826EA8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetDirectorBySequence_Implementation(SceneInteractionActor.__GetDirectorBySequence_FunctionParams* __Params)
	{
		ULevelSequence orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelSequence>(__Params->sequence);
		ref IntPtr ptr = ref *(&__Params->__Result);
		ALevelSequenceActor directorBySequence_Implementation = this.GetDirectorBySequence_Implementation(orCreateUObjectByNativePointer);
		ptr = ((directorBySequence_Implementation != null) ? directorBySequence_Implementation.NativePtr : ((IntPtr)0));
	}

	// Token: 0x0601D43A RID: 119866 RVA: 0x00828CDD File Offset: 0x00826EDD
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_StopExtraEffectOnTagsChange_Implementation(SceneInteractionActor.__StopExtraEffectOnTagsChange_FunctionParams* __Params)
	{
		this.StopExtraEffectOnTagsChange_Implementation(__Params->tag);
	}

	// Token: 0x0601D43B RID: 119867 RVA: 0x00828CEB File Offset: 0x00826EEB
	protected virtual void __CPPCALL_TryStopCurrentState_Implementation()
	{
		this.TryStopCurrentState_Implementation();
	}

	// Token: 0x0601D43C RID: 119868 RVA: 0x00828CF3 File Offset: 0x00826EF3
	protected virtual void __CPPCALL_使用字段值切换状态_Implementation()
	{
		this.使用字段值切换状态_Implementation();
	}

	// Token: 0x0601D43D RID: 119869 RVA: 0x00828CFB File Offset: 0x00826EFB
	protected virtual void __CPPCALL_ChangeState1_Implementation()
	{
		this.ChangeState1_Implementation();
	}

	// Token: 0x0601D43E RID: 119870 RVA: 0x00828D03 File Offset: 0x00826F03
	protected virtual void __CPPCALL_ChangeState2_Implementation()
	{
		this.ChangeState2_Implementation();
	}

	// Token: 0x0601D43F RID: 119871 RVA: 0x00828D0B File Offset: 0x00826F0B
	protected virtual void __CPPCALL_ChangeState3_Implementation()
	{
		this.ChangeState3_Implementation();
	}

	// Token: 0x0601D440 RID: 119872 RVA: 0x00828D13 File Offset: 0x00826F13
	protected virtual void __CPPCALL_ChangeState4_Implementation()
	{
		this.ChangeState4_Implementation();
	}

	// Token: 0x0601D441 RID: 119873 RVA: 0x00828D1B File Offset: 0x00826F1B
	protected virtual void __CPPCALL_ChangeState5_Implementation()
	{
		this.ChangeState5_Implementation();
	}

	// Token: 0x0601D442 RID: 119874 RVA: 0x00828D23 File Offset: 0x00826F23
	protected virtual void __CPPCALL_ChangeState6_Implementation()
	{
		this.ChangeState6_Implementation();
	}

	// Token: 0x0601D443 RID: 119875 RVA: 0x00828D2B File Offset: 0x00826F2B
	protected virtual void __CPPCALL_ChangeState7_Implementation()
	{
		this.ChangeState7_Implementation();
	}

	// Token: 0x0601D444 RID: 119876 RVA: 0x00828D33 File Offset: 0x00826F33
	protected virtual void __CPPCALL_ChangeState8_Implementation()
	{
		this.ChangeState8_Implementation();
	}

	// Token: 0x0601D445 RID: 119877 RVA: 0x00828D3B File Offset: 0x00826F3B
	protected virtual void __CPPCALL_模拟Tag添加_Implementation()
	{
		this.模拟Tag添加_Implementation();
	}

	// Token: 0x0601D446 RID: 119878 RVA: 0x00828D43 File Offset: 0x00826F43
	protected virtual void __CPPCALL_模拟Tag移除_Implementation()
	{
		this.模拟Tag移除_Implementation();
	}

	// Token: 0x0601D447 RID: 119879 RVA: 0x00828D4B File Offset: 0x00826F4B
	protected virtual void __CPPCALL_重置_Implementation()
	{
		this.重置_Implementation();
	}

	// Token: 0x0400E65A RID: 58970
	private const float DEFAULT_DAMAGE_AMOUNT = 1f;

	// Token: 0x0400E65B RID: 58971
	public int PbDataId;

	// Token: 0x0400E65C RID: 58972
	[Nullable(2)]
	private Action OnInitCallback;

	// Token: 0x0400E65D RID: 58973
	public bool Active = true;

	// Token: 0x0400E65E RID: 58974
	[Nullable(2)]
	private ULevelSequencePlayer ActiveSequencePlayer;

	// Token: 0x0400E65F RID: 58975
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<ULevelSequence, ALevelSequenceActor> ActiveSequenceDirectorMap;

	// Token: 0x0400E660 RID: 58976
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<ALevelSequenceActor, SequenceDirectorConfig> DirectorConfigMap;

	// Token: 0x0400E661 RID: 58977
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, EffectInfo> ActiveEffectInfoMap;

	// Token: 0x0400E662 RID: 58978
	private EKuroSceneInteractionState? CurrentStateKey;

	// Token: 0x0400E663 RID: 58979
	[Nullable(2)]
	private SSceneInteractionitem CurrentState;

	// Token: 0x0400E664 RID: 58980
	[Nullable(2)]
	private SSceneInteractionitem TransitionState;

	// Token: 0x0400E665 RID: 58981
	private EKuroSceneInteractionState? TransitionStateKey;

	// Token: 0x0400E666 RID: 58982
	[Nullable(2)]
	private SSceneInteractionitem NextState;

	// Token: 0x0400E667 RID: 58983
	private EKuroSceneInteractionState? NextStateKey;

	// Token: 0x0400E668 RID: 58984
	private bool InTransition;

	// Token: 0x0400E669 RID: 58985
	private bool InWaitingForPlayableFinished;

	// Token: 0x0400E66A RID: 58986
	private bool TransitionStateJumpToEnd;

	// Token: 0x0400E66B RID: 58987
	private bool IsUseTransitionTime;

	// Token: 0x0400E66C RID: 58988
	private float SwitchingStateRemainTime;

	// Token: 0x0400E66D RID: 58989
	private bool IsPlayBack;

	// Token: 0x0400E66E RID: 58990
	[Nullable(2)]
	private UKuroSceneInteractionActorSystem KuroSceneInteractionActorSystem;

	// Token: 0x0400E66F RID: 58991
	[Nullable(2)]
	private AActor ProjectionRootActor;

	// Token: 0x0400E670 RID: 58992
	private bool IsProjecting;

	// Token: 0x0400E671 RID: 58993
	[Nullable(2)]
	public CharRenderingComponent CharRenderingComponent;

	// Token: 0x0400E672 RID: 58994
	public int CharRenderingKey;

	// Token: 0x0400E673 RID: 58995
	public FVectorDouble? HitLocation;

	// Token: 0x0400E674 RID: 58996
	public FVectorDouble HitDirection = new FVectorDouble(0.0, 0.0, 1.0);

	// Token: 0x0400E675 RID: 58997
	public FVectorDouble? RangeOtherActorLocation;

	// Token: 0x0400E676 RID: 58998
	[Nullable(2)]
	public Vector RangeOtherActorVelocityProxy;

	// Token: 0x0400E677 RID: 58999
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<CharRenderingComponent, int> CharRenderingComponents;

	// Token: 0x0400E678 RID: 59000
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public HashSet<BP_EffectActor_C> CrossStateEffectActors;

	// Token: 0x0400E679 RID: 59001
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<AActor, FTransformDouble> ActorsOriginalRelTransform;

	// Token: 0x0400E67A RID: 59002
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private Dictionary<UStaticMeshComponent, Dictionary<int, UMaterialInterface>> RevertMaterialComponentsMaps;

	// Token: 0x0400E67B RID: 59003
	private bool MergeCurrentStateAkEvent;

	// Token: 0x0400E67C RID: 59004
	[Nullable(2)]
	private Dictionary<FGameplayTag, int> PlayingTagAkEventHandle;

	// Token: 0x0400E67D RID: 59005
	[Nullable(2)]
	private BP_GlobalGI_C GlobalGi;

	// Token: 0x0400E67E RID: 59006
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<ASkeletalMeshActor, SkeletalMontageConfig> SkeletalMontageConfigMap;

	// Token: 0x0400E67F RID: 59007
	private int SkeletalMeshDestructibleActorInitCount;

	// Token: 0x0400E680 RID: 59008
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private HashSet<AKuroDestructibleActor> SkeletalMeshDestructibleActorsInternal;

	// Token: 0x0400E681 RID: 59009
	private int DebugTickId = -1;

	// Token: 0x0400E682 RID: 59010
	private List<BP_EffectActor_C> PendingStateEffects = new List<BP_EffectActor_C>();

	// Token: 0x0400E683 RID: 59011
	private int PendingStateEffectTickId = -1;

	// Token: 0x0400E684 RID: 59012
	private readonly Dictionary<FGameplayTag, List<BP_EffectActor_C>> PendingTagEffects = new Dictionary<FGameplayTag, List<BP_EffectActor_C>>();

	// Token: 0x0400E685 RID: 59013
	private int PendingTagEffectTickId = -1;

	// Token: 0x0400E686 RID: 59014
	private readonly Dictionary<BP_EffectActor_C, int> PendingCrossStateEffects = new Dictionary<BP_EffectActor_C, int>();

	// Token: 0x0400E687 RID: 59015
	private int PendingCrossStateEffectTickId = -1;

	// Token: 0x0400E688 RID: 59016
	public Dictionary<int, int> AkEventPostHandle = new Dictionary<int, int>();

	// Token: 0x0400E689 RID: 59017
	[Nullable(2)]
	public Action OverrideEffectParmaFunc;

	// Token: 0x0400E68A RID: 59018
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<string, AActor> OverrideSeqBindActors;

	// Token: 0x0400E68B RID: 59019
	private bool IsAbpAnimPlayEnd;

	// Token: 0x0400E68C RID: 59020
	[Nullable(2)]
	private List<int> TagCharDaHandleList;

	// Token: 0x0400E68D RID: 59021
	[Nullable(2)]
	private Action<int> OnEffectFinishCallback;

	// Token: 0x0400E68E RID: 59022
	[Nullable(2)]
	private Action<ELoadEffectResult, int> OnEffectPlayingCallback;

	// Token: 0x0400E68F RID: 59023
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Scene/Item/SceneInteractionActor.SceneInteractionActor_C";

	// Token: 0x0400E690 RID: 59024
	private static IntPtr _ClassPtr;

	// Token: 0x0400E691 RID: 59025
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E692 RID: 59026
	private static int __PropertyOffset_LevelName;

	// Token: 0x0400E693 RID: 59027
	private static int __PropertyOffset_HandleId;

	// Token: 0x0400E694 RID: 59028
	private static int __PropertyOffset_EntityId;

	// Token: 0x0400E695 RID: 59029
	private static int __PropertyOffset_States;

	// Token: 0x0400E696 RID: 59030
	[Nullable(2)]
	private TMap<EKuroSceneInteractionState, SSceneInteractionitem> _States;

	// Token: 0x0400E697 RID: 59031
	private static int __PropertyOffset_Effects;

	// Token: 0x0400E698 RID: 59032
	[Nullable(2)]
	private TMap<ESceneInteractionEffect, SScenePropertyEffect> _Effects;

	// Token: 0x0400E699 RID: 59033
	private static int __PropertyOffset_EffectsInheritTimeDilation;

	// Token: 0x0400E69A RID: 59034
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<BP_EffectActor_C> _EffectsInheritTimeDilation;

	// Token: 0x0400E69B RID: 59035
	private static int __PropertyOffset_EndEffects;

	// Token: 0x0400E69C RID: 59036
	[Nullable(2)]
	private TMap<ESceneInteractionEffect, BP_EffectActor_C> _EndEffects;

	// Token: 0x0400E69D RID: 59037
	private static int __PropertyOffset_ReferenceActors;

	// Token: 0x0400E69E RID: 59038
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private TMap<string, AActor> _ReferenceActors;

	// Token: 0x0400E69F RID: 59039
	private static int __PropertyOffset_TagsAndCorrespondingEffects;

	// Token: 0x0400E6A0 RID: 59040
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TMap<FGameplayTag, SSceneInteractionTags> _TagsAndCorrespondingEffects;

	// Token: 0x0400E6A1 RID: 59041
	private static int __PropertyOffset_CollisionActors;

	// Token: 0x0400E6A2 RID: 59042
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<AActor> _CollisionActors;

	// Token: 0x0400E6A3 RID: 59043
	private static int __PropertyOffset_PartCollisionActorsAndCorrespondingTags;

	// Token: 0x0400E6A4 RID: 59044
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TMap<AActor, FGameplayTag> _PartCollisionActorsAndCorrespondingTags;

	// Token: 0x0400E6A5 RID: 59045
	private static int __PropertyOffset_InteractionEffectHookActors;

	// Token: 0x0400E6A6 RID: 59046
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<AActor> _InteractionEffectHookActors;

	// Token: 0x0400E6A7 RID: 59047
	private static int __PropertyOffset_CharacterForOrgan;

	// Token: 0x0400E6A8 RID: 59048
	private static int __PropertyOffset_ActorsForProjection;

	// Token: 0x0400E6A9 RID: 59049
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<AActor> _ActorsForProjection;

	// Token: 0x0400E6AA RID: 59050
	private static int __PropertyOffset_MaterialForProjection;

	// Token: 0x0400E6AB RID: 59051
	private static int __PropertyOffset_ReceivingDecalsActors;

	// Token: 0x0400E6AC RID: 59052
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<AActor> _ReceivingDecalsActors;

	// Token: 0x0400E6AD RID: 59053
	private static int __PropertyOffset_StaticMeshList;

	// Token: 0x0400E6AE RID: 59054
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<UStaticMesh> _StaticMeshList;

	// Token: 0x0400E6AF RID: 59055
	private static int __PropertyOffset_RangeOtherActorVelocitySource;

	// Token: 0x0400E6B0 RID: 59056
	private static int __PropertyOffset_SkeletalMeshActors;

	// Token: 0x0400E6B1 RID: 59057
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<ASkeletalMeshActor> _SkeletalMeshActors;

	// Token: 0x0400E6B2 RID: 59058
	private static int __PropertyOffset_AllSkeletalMeshActors;

	// Token: 0x0400E6B3 RID: 59059
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<ASkeletalMeshActor> _AllSkeletalMeshActors;

	// Token: 0x0400E6B4 RID: 59060
	private static int __PropertyOffset_InteractionMaterialController;

	// Token: 0x0400E6B5 RID: 59061
	private static int __PropertyOffset_BasePlatformInternal;

	// Token: 0x0400E6B6 RID: 59062
	private static int __PropertyOffset_CurrentStateAkEventHandle;

	// Token: 0x0400E6B7 RID: 59063
	private static int __PropertyOffset_OverrideEffectActor;

	// Token: 0x0400E6B8 RID: 59064
	private static int __PropertyOffset_需要过渡状态;

	// Token: 0x0400E6B9 RID: 59065
	private static int __PropertyOffset_跳过表现过程;

	// Token: 0x0400E6BA RID: 59066
	private static int __PropertyOffset_模拟状态;

	// Token: 0x0400E6BB RID: 59067
	private static int __PropertyOffset_模拟Tag;

	// Token: 0x0200980E RID: 38926
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetOverrideSeqBindActor_FunctionParams
	{
		// Token: 0x0403081A RID: 198682
		[FieldOffset(0)]
		public IntPtr actorToBind;

		// Token: 0x0403081B RID: 198683
		[FieldOffset(8)]
		public FString bindingName;
	}

	// Token: 0x0200980F RID: 38927
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __UnsetOverrideSeqBindActor_FunctionParams
	{
		// Token: 0x0403081C RID: 198684
		[FieldOffset(0)]
		public IntPtr actorToUnbind;

		// Token: 0x0403081D RID: 198685
		[FieldOffset(8)]
		public FString bindingName;
	}

	// Token: 0x02009810 RID: 38928
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __CheckAllEffectPlaying_FunctionParams
	{
		// Token: 0x0403081E RID: 198686
		[FieldOffset(0)]
		public bool __Result;
	}

	// Token: 0x02009811 RID: 38929
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __PlayKuroSkeletalMeshDestruction_FunctionParams
	{
		// Token: 0x0403081F RID: 198687
		[FieldOffset(0)]
		public IntPtr actor;

		// Token: 0x04030820 RID: 198688
		[FieldOffset(8)]
		public bool isJumpToEnd;
	}

	// Token: 0x02009812 RID: 38930
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __OverrideKuroDestructibleActorPhysicsVelocity_FunctionParams
	{
		// Token: 0x04030821 RID: 198689
		[FieldOffset(0)]
		public IntPtr skeletalMeshDestruction;
	}

	// Token: 0x02009813 RID: 38931
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetActiveSequenceRemainTime_FunctionParams
	{
		// Token: 0x04030822 RID: 198690
		[FieldOffset(0)]
		public IntPtr sequence;

		// Token: 0x04030823 RID: 198691
		[FieldOffset(8)]
		public float __Result;
	}

	// Token: 0x02009814 RID: 38932
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __ApplyAnimOptimizationParams_FunctionParams
	{
		// Token: 0x04030824 RID: 198692
		[FieldOffset(0)]
		public bool bUseDistanceMap;
	}

	// Token: 0x02009815 RID: 38933
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __PostAutoMergeEvent_FunctionParams
	{
		// Token: 0x04030825 RID: 198693
		[FieldOffset(0)]
		public FString eventName;

		// Token: 0x04030826 RID: 198694
		[FieldOffset(16)]
		public float tagId;

		// Token: 0x04030827 RID: 198695
		[FieldOffset(20)]
		public bool follow;
	}

	// Token: 0x02009816 RID: 38934
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __PostTagEvent_FunctionParams
	{
		// Token: 0x04030828 RID: 198696
		[FieldOffset(0)]
		public FString eventName;

		// Token: 0x04030829 RID: 198697
		[FieldOffset(16)]
		public FGameplayTag tag;

		// Token: 0x0403082A RID: 198698
		[FieldOffset(28)]
		public bool follow;
	}

	// Token: 0x02009817 RID: 38935
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 12)]
	protected ref struct __StopTagAkEvent_FunctionParams
	{
		// Token: 0x0403082B RID: 198699
		[FieldOffset(0)]
		public FGameplayTag tag;
	}

	// Token: 0x02009818 RID: 38936
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	protected ref struct __UpdateProjectionActorTransform_FunctionParams
	{
		// Token: 0x0403082C RID: 198700
		[FieldOffset(0)]
		public FTransformDouble transform;
	}

	// Token: 0x02009819 RID: 38937
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __AddMatrialDataForChildrenActor_FunctionParams
	{
		// Token: 0x0403082D RID: 198701
		[FieldOffset(0)]
		public IntPtr actor;

		// Token: 0x0403082E RID: 198702
		[FieldOffset(8)]
		public IntPtr materialData;
	}

	// Token: 0x0200981A RID: 38938
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 12)]
	protected ref struct __ResetTagActorHide_FunctionParams
	{
		// Token: 0x0403082F RID: 198703
		[FieldOffset(0)]
		public FGameplayTag tag;
	}

	// Token: 0x0200981B RID: 38939
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetDirectorBySequence_FunctionParams
	{
		// Token: 0x04030830 RID: 198704
		[FieldOffset(0)]
		public IntPtr sequence;

		// Token: 0x04030831 RID: 198705
		[FieldOffset(8)]
		public IntPtr __Result;
	}

	// Token: 0x0200981C RID: 38940
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 12)]
	protected ref struct __StopExtraEffectOnTagsChange_FunctionParams
	{
		// Token: 0x04030832 RID: 198706
		[FieldOffset(0)]
		public FGameplayTag tag;
	}
}

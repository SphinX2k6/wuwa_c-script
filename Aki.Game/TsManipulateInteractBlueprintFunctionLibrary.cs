using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Component;
using AkiClient.Game.Aki.Data.Gameplay.MechascoutDrag;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using CSharpScript.Game.NewWorld.SceneItem;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002E41 RID: 11841
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsManipulateInteractBlueprintFunctionLibrary.TsManipulateInteractBlueprintFunctionLibrary_C")]
public class TsManipulateInteractBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
{
	// Token: 0x060192C3 RID: 103107 RVA: 0x0067AB00 File Offset: 0x00678D00
	[NullableContext(2)]
	private static CharacterManipulateInteractComponent GetManipulateInteractComp(int entityId)
	{
		CharacterManipulateInteractComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateInteractComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return null;
		}
		return component;
	}

	// Token: 0x060192C4 RID: 103108 RVA: 0x0067AB28 File Offset: 0x00678D28
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static AkiClient.Game.Aki.Data.Gameplay.MechascoutDrag.EMechascoutDragType GetMechascoutDragInteractType(int entityId)
	{
		CharacterManipulateInteractComponent manipulateInteractComp = TsManipulateInteractBlueprintFunctionLibrary.GetManipulateInteractComp(entityId);
		if (manipulateInteractComp == null)
		{
			return AkiClient.Game.Aki.Data.Gameplay.MechascoutDrag.EMechascoutDragType.EMechascoutDragType_MAX;
		}
		SceneItemExploreInteractComponent sceneItemExploreInteractComponent = manipulateInteractComp.SelectedTargetInternal ?? manipulateInteractComp.BestTargetInternal;
		if (sceneItemExploreInteractComponent == null)
		{
			return AkiClient.Game.Aki.Data.Gameplay.MechascoutDrag.EMechascoutDragType.EMechascoutDragType_MAX;
		}
		return sceneItemExploreInteractComponent.GetUeDragType();
	}

	// Token: 0x060192C5 RID: 103109 RVA: 0x0067AB60 File Offset: 0x00678D60
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool StartMechascoutDragInteract(int entityId)
	{
		CharacterManipulateInteractComponent manipulateInteractComp = TsManipulateInteractBlueprintFunctionLibrary.GetManipulateInteractComp(entityId);
		if (manipulateInteractComp == null)
		{
			Log.Instance.Error(ELogModule.SceneItem, ELogAuthor.CH, "[StartMechascoutDragInteract] 组件无效", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		SceneItemExploreInteractComponent getCurrentTarget = manipulateInteractComp.GetCurrentTarget;
		if (getCurrentTarget == null || getCurrentTarget.Type.GetValueOrDefault() != EExploreSkillInteractType.MechascoutDrag)
		{
			Log.Instance.Error(ELogModule.SceneItem, ELogAuthor.CH, "[StartMechascoutDragInteract] 无有效交互点", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		AkiClient.Game.Aki.Data.Gameplay.MechascoutDrag.EMechascoutDragType dragType = getCurrentTarget.GetUeDragType();
		if (dragType == AkiClient.Game.Aki.Data.Gameplay.MechascoutDrag.EMechascoutDragType.EMechascoutDragType_MAX)
		{
			Log.Instance.Error(ELogModule.SceneItem, ELogAuthor.CH, "[StartMechascoutDragInteract] 无效拉拽类型", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		CharacterActorComponent component = EntitySystem.Instance.GetComponent<CharacterActorComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return false;
		}
		Vector vector = getCurrentTarget.FindNearestTriggerPoint(component.ActorLocationProxy);
		if (vector == null)
		{
			Log.Instance.Error(ELogModule.SceneItem, ELogAuthor.CH, "[StartMechascoutDragInteract] 未找到有效触发点", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		CharacterCustomActionComponent customActionComp = EntitySystem.Instance.GetComponent<CharacterCustomActionComponent>(entityId);
		CharacterCustomActionComponent customActionComp3 = customActionComp;
		if (customActionComp3 == null || !customActionComp3.Valid)
		{
			return false;
		}
		CharacterUnifiedStateComponent unifiedStateComp = EntitySystem.Instance.GetComponent<CharacterUnifiedStateComponent>(entityId);
		CharacterUnifiedStateComponent unifiedStateComp2 = unifiedStateComp;
		if (unifiedStateComp2 == null || !unifiedStateComp2.Valid)
		{
			return false;
		}
		manipulateInteractComp.StartMechascoutDragInteract();
		BattleInputModel.Instance.SetAllInputEnable(false, EBattleInputReason.MechascoutDrag);
		BaseActorComponent interactActorComp = getCurrentTarget.Entity.GetComponent<BaseActorComponent>();
		Vector vector2 = Vector.Create(vector);
		vector2.Z += (double)component.ScaledHalfHeight;
		Action <>9__1;
		customActionComp.AddCustomMoveToLocation(vector2, delegate
		{
			BaseActorComponent interactActorComp = interactActorComp;
			if (interactActorComp == null || !interactActorComp.Valid)
			{
				unifiedStateComp.SetMoveState(ECharMoveState.WalkStop);
				BattleInputModel.Instance.SetAllInputEnable(true, EBattleInputReason.MechascoutDrag);
				TsManipulateInteractBlueprintFunctionLibrary.TryBeginDragSkill(entityId, dragType);
				return;
			}
			CharacterCustomActionComponent customActionComp2 = customActionComp;
			BaseActorComponent interactActorComp2 = interactActorComp;
			double angle = 0.0;
			ECustomSetRotationType type = ECustomSetRotationType.FaceToTarget;
			Action callback;
			if ((callback = <>9__1) == null)
			{
				callback = (<>9__1 = delegate()
				{
					unifiedStateComp.SetMoveState(ECharMoveState.WalkStop);
					BattleInputModel.Instance.SetAllInputEnable(true, EBattleInputReason.MechascoutDrag);
					TsManipulateInteractBlueprintFunctionLibrary.TryBeginDragSkill(entityId, dragType);
				});
			}
			customActionComp2.AddCustomSetTurnToTarget(interactActorComp2, angle, type, callback, null);
		}, null);
		return true;
	}

	// Token: 0x060192C6 RID: 103110 RVA: 0x0067AD28 File Offset: 0x00678F28
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool AttachMechascoutInteractActorToSocket(int entityId)
	{
		CharacterManipulateInteractComponent manipulateInteractComp = TsManipulateInteractBlueprintFunctionLibrary.GetManipulateInteractComp(entityId);
		if (manipulateInteractComp == null)
		{
			Log.Instance.Error(ELogModule.SceneItem, ELogAuthor.CH, "[AttachMechascoutInteractActorToSocket] 组件无效", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		SceneItemExploreInteractComponent sceneItemExploreInteractComponent = manipulateInteractComp.SelectedTargetInternal ?? manipulateInteractComp.BestTargetInternal;
		if (sceneItemExploreInteractComponent == null || !sceneItemExploreInteractComponent.Valid)
		{
			Log.Instance.Error(ELogModule.SceneItem, ELogAuthor.CH, "[AttachMechascoutInteractActorToSocket] 无有效交互点", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		CharacterActorComponent component = EntitySystem.Instance.GetComponent<CharacterActorComponent>(entityId);
		if (component != null && component.Valid)
		{
			TsBaseCharacter actor = component.Actor;
			if (((actor != null) ? actor.Mesh : null) != null)
			{
				BaseActorComponent component2 = sceneItemExploreInteractComponent.Entity.GetComponent<BaseActorComponent>();
				AActor aactor = (component2 != null) ? component2.Owner : null;
				if (aactor == null || !aactor.IsValid())
				{
					Log.Instance.Error(ELogModule.SceneItem, ELogAuthor.CH, "[AttachMechascoutInteractActorToSocket] 目标Actor无效", default(ReadOnlySpan<ValueTuple<string, object>>));
					return false;
				}
				aactor.K2_AttachToComponent(component.Actor.Mesh, TsManipulateInteractBlueprintFunctionLibrary.MechascoutAttachSocket.Value, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, false, true);
				sceneItemExploreInteractComponent.SaveAndDisableActorCollision();
				return true;
			}
		}
		Log.Instance.Error(ELogModule.SceneItem, ELogAuthor.CH, "[AttachMechascoutInteractActorToSocket] 角色Mesh无效", default(ReadOnlySpan<ValueTuple<string, object>>));
		return false;
	}

	// Token: 0x060192C7 RID: 103111 RVA: 0x0067AE60 File Offset: 0x00679060
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool DetachMechascoutInteractActor(int entityId)
	{
		CharacterManipulateInteractComponent manipulateInteractComp = TsManipulateInteractBlueprintFunctionLibrary.GetManipulateInteractComp(entityId);
		if (manipulateInteractComp == null)
		{
			Log.Instance.Error(ELogModule.SceneItem, ELogAuthor.CH, "[DetachMechascoutInteractActor] 组件无效", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		SceneItemExploreInteractComponent sceneItemExploreInteractComponent = manipulateInteractComp.SelectedTargetInternal ?? manipulateInteractComp.BestTargetInternal;
		if (sceneItemExploreInteractComponent == null || !sceneItemExploreInteractComponent.Valid)
		{
			Log.Instance.Error(ELogModule.SceneItem, ELogAuthor.CH, "[DetachMechascoutInteractActor] 无有效交互点", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		BaseActorComponent component = sceneItemExploreInteractComponent.Entity.GetComponent<BaseActorComponent>();
		AActor aactor = (component != null) ? component.Owner : null;
		if (aactor == null || !aactor.IsValid())
		{
			Log.Instance.Error(ELogModule.SceneItem, ELogAuthor.CH, "[DetachMechascoutInteractActor] 目标Actor无效", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		aactor.K2_DetachFromActor(EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
		sceneItemExploreInteractComponent.RestoreActorCollision();
		return true;
	}

	// Token: 0x060192C8 RID: 103112 RVA: 0x0067AF2C File Offset: 0x0067912C
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool AttachMechascoutManipulateActorToSocket(int entityId)
	{
		CharacterManipulateComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateComponent>(entityId);
		if (component == null)
		{
			Log.Instance.Error(ELogModule.SceneItem, ELogAuthor.CH, "[AttachMechascoutManipulateActorToSocket] 组件无效", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		Entity holdingEntity = component.GetHoldingEntity();
		if (holdingEntity == null || !holdingEntity.Valid)
		{
			Log.Instance.Error(ELogModule.SceneItem, ELogAuthor.CH, "[AttachMechascoutManipulateActorToSocket] 无有效交互点", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		SceneItemManipulatableComponent component2 = holdingEntity.GetComponent<SceneItemManipulatableComponent>();
		if (component2 == null || !component2.Valid)
		{
			Log.Instance.Error(ELogModule.SceneItem, ELogAuthor.CH, "[AttachMechascoutManipulateActorToSocket] 控物组件无效", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		CharacterActorComponent component3 = EntitySystem.Instance.GetComponent<CharacterActorComponent>(entityId);
		if (component3 != null && component3.Valid)
		{
			TsBaseCharacter actor = component3.Actor;
			if (((actor != null) ? actor.Mesh : null) != null)
			{
				BaseActorComponent component4 = holdingEntity.GetComponent<BaseActorComponent>();
				AActor aactor = (component4 != null) ? component4.Owner : null;
				if (aactor == null || !aactor.IsValid())
				{
					Log.Instance.Error(ELogModule.SceneItem, ELogAuthor.CH, "[AttachMechascoutManipulateActorToSocket] 目标Actor无效", default(ReadOnlySpan<ValueTuple<string, object>>));
					return false;
				}
				aactor.K2_AttachToComponent(component3.Actor.Mesh, TsManipulateInteractBlueprintFunctionLibrary.MechascoutManipulateAttachSocket ?? FNameUtil.NONE, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, false, true);
				component2.SetEnableTargetLocationCalculation(false);
				SceneItemActorComponent actorComp = component2.ActorComp;
				if (actorComp != null && actorComp.Valid)
				{
					component2.ActorComp.PhysicsMode = SceneItemActorComponent.EPhysicsMode.Kinematic;
				}
				component.MarkCastOnDetach();
				return true;
			}
		}
		Log.Instance.Error(ELogModule.SceneItem, ELogAuthor.CH, "[AttachMechascoutManipulateActorToSocket] 角色Mesh无效", default(ReadOnlySpan<ValueTuple<string, object>>));
		return false;
	}

	// Token: 0x060192C9 RID: 103113 RVA: 0x0067B0D0 File Offset: 0x006792D0
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool DetachMechascoutManipulateActor(int entityId)
	{
		CharacterManipulateComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateComponent>(entityId);
		if (component == null)
		{
			Log.Instance.Error(ELogModule.SceneItem, ELogAuthor.CH, "[AttachMechascoutManipulateActorToSocket] 组件无效", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		Entity holdingEntity = component.GetHoldingEntity();
		if (holdingEntity == null || !holdingEntity.Valid)
		{
			Log.Instance.Error(ELogModule.SceneItem, ELogAuthor.CH, "[DetachMechascoutInteractActor] 无有效交互点", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		SceneItemManipulatableComponent component2 = holdingEntity.GetComponent<SceneItemManipulatableComponent>();
		if (component2 == null || !component2.Valid)
		{
			Log.Instance.Error(ELogModule.SceneItem, ELogAuthor.CH, "[DetachMechascoutManipulateActor] 控物组件无效", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		BaseActorComponent component3 = holdingEntity.GetComponent<BaseActorComponent>();
		AActor aactor = (component3 != null) ? component3.Owner : null;
		if (aactor == null || !aactor.IsValid())
		{
			Log.Instance.Error(ELogModule.SceneItem, ELogAuthor.CH, "[DetachMechascoutInteractActor] 目标Actor无效", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		aactor.K2_DetachFromActor(EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
		component2.SetEnableTargetLocationCalculation(true);
		component.TryCastOnDetach();
		return true;
	}

	// Token: 0x060192CA RID: 103114 RVA: 0x0067B1D4 File Offset: 0x006793D4
	private static void TryBeginDragSkill(int entityId, AkiClient.Game.Aki.Data.Gameplay.MechascoutDrag.EMechascoutDragType dragType)
	{
		int num;
		if (!TsManipulateInteractBlueprintFunctionLibrary.SkillIdMap.TryGetValue(dragType, out num) || num <= 0)
		{
			return;
		}
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.BeginSkill(num, new SkillParam
			{
				Reason = "[StartMechascoutDragInteract]"
			});
		}
	}

	// Token: 0x060192CB RID: 103115 RVA: 0x0067B224 File Offset: 0x00679424
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void EndMechascoutDragInteract(int entityId, AkiClient.Game.Aki.Data.Gameplay.MechascoutDrag.EMechascoutDragType dragType)
	{
		CharacterManipulateInteractComponent manipulateInteractComp = TsManipulateInteractBlueprintFunctionLibrary.GetManipulateInteractComp(entityId);
		if (manipulateInteractComp == null)
		{
			Log.Instance.Error(ELogModule.SceneItem, ELogAuthor.CH, "[EndMechascoutDragInteract] 组件无效", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		manipulateInteractComp.EndMechascoutDragInteract();
	}

	// Token: 0x060192CC RID: 103116 RVA: 0x0067B25E File Offset: 0x0067945E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsManipulateInteractBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsManipulateInteractBlueprintFunctionLibrary.TsManipulateInteractBlueprintFunctionLibrary_C");
		}
		return TsManipulateInteractBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x060192CD RID: 103117 RVA: 0x0067B284 File Offset: 0x00679484
	public TsManipulateInteractBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(TsManipulateInteractBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060192CE RID: 103118 RVA: 0x0067B2AC File Offset: 0x006794AC
	[NullableContext(1)]
	public TsManipulateInteractBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsManipulateInteractBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060192CF RID: 103119 RVA: 0x0067B2DF File Offset: 0x006794DF
	protected TsManipulateInteractBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060192D0 RID: 103120 RVA: 0x0067B2E8 File Offset: 0x006794E8
	protected unsafe static void __CPPCALL_GetMechascoutDragInteractType_Implementation(TsManipulateInteractBlueprintFunctionLibrary.__GetMechascoutDragInteractType_FunctionParams* __Params)
	{
		*(&__Params->__Result) = (byte)TsManipulateInteractBlueprintFunctionLibrary.GetMechascoutDragInteractType(__Params->entityId);
	}

	// Token: 0x060192D1 RID: 103121 RVA: 0x0067B2FD File Offset: 0x006794FD
	protected unsafe static void __CPPCALL_StartMechascoutDragInteract_Implementation(TsManipulateInteractBlueprintFunctionLibrary.__StartMechascoutDragInteract_FunctionParams* __Params)
	{
		__Params->__Result = TsManipulateInteractBlueprintFunctionLibrary.StartMechascoutDragInteract(__Params->entityId);
	}

	// Token: 0x060192D2 RID: 103122 RVA: 0x0067B310 File Offset: 0x00679510
	protected unsafe static void __CPPCALL_AttachMechascoutInteractActorToSocket_Implementation(TsManipulateInteractBlueprintFunctionLibrary.__AttachMechascoutInteractActorToSocket_FunctionParams* __Params)
	{
		__Params->__Result = TsManipulateInteractBlueprintFunctionLibrary.AttachMechascoutInteractActorToSocket(__Params->entityId);
	}

	// Token: 0x060192D3 RID: 103123 RVA: 0x0067B323 File Offset: 0x00679523
	protected unsafe static void __CPPCALL_DetachMechascoutInteractActor_Implementation(TsManipulateInteractBlueprintFunctionLibrary.__DetachMechascoutInteractActor_FunctionParams* __Params)
	{
		__Params->__Result = TsManipulateInteractBlueprintFunctionLibrary.DetachMechascoutInteractActor(__Params->entityId);
	}

	// Token: 0x060192D4 RID: 103124 RVA: 0x0067B336 File Offset: 0x00679536
	protected unsafe static void __CPPCALL_AttachMechascoutManipulateActorToSocket_Implementation(TsManipulateInteractBlueprintFunctionLibrary.__AttachMechascoutManipulateActorToSocket_FunctionParams* __Params)
	{
		__Params->__Result = TsManipulateInteractBlueprintFunctionLibrary.AttachMechascoutManipulateActorToSocket(__Params->entityId);
	}

	// Token: 0x060192D5 RID: 103125 RVA: 0x0067B349 File Offset: 0x00679549
	protected unsafe static void __CPPCALL_DetachMechascoutManipulateActor_Implementation(TsManipulateInteractBlueprintFunctionLibrary.__DetachMechascoutManipulateActor_FunctionParams* __Params)
	{
		__Params->__Result = TsManipulateInteractBlueprintFunctionLibrary.DetachMechascoutManipulateActor(__Params->entityId);
	}

	// Token: 0x060192D6 RID: 103126 RVA: 0x0067B35C File Offset: 0x0067955C
	protected unsafe static void __CPPCALL_EndMechascoutDragInteract_Implementation(TsManipulateInteractBlueprintFunctionLibrary.__EndMechascoutDragInteract_FunctionParams* __Params)
	{
		AkiClient.Game.Aki.Data.Gameplay.MechascoutDrag.EMechascoutDragType dragType = (AkiClient.Game.Aki.Data.Gameplay.MechascoutDrag.EMechascoutDragType)__Params->dragType;
		TsManipulateInteractBlueprintFunctionLibrary.EndMechascoutDragInteract(__Params->entityId, dragType);
	}

	// Token: 0x0400BB98 RID: 48024
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Dictionary<AkiClient.Game.Aki.Data.Gameplay.MechascoutDrag.EMechascoutDragType, int> SkillIdMap = new Dictionary<AkiClient.Game.Aki.Data.Gameplay.MechascoutDrag.EMechascoutDragType, int>
	{
		{
			AkiClient.Game.Aki.Data.Gameplay.MechascoutDrag.EMechascoutDragType.Instant,
			5045003
		},
		{
			AkiClient.Game.Aki.Data.Gameplay.MechascoutDrag.EMechascoutDragType.LongPress,
			5045004
		}
	};

	// Token: 0x0400BB99 RID: 48025
	[StaticVariableRuleIgnore]
	private static readonly FName? MechascoutAttachSocket = FNameUtil.GetDynamicFName("WeaponProp04");

	// Token: 0x0400BB9A RID: 48026
	[StaticVariableRuleIgnore]
	private static readonly FName? MechascoutManipulateAttachSocket = FNameUtil.GetDynamicFName("WeaponProp05");

	// Token: 0x0400BB9B RID: 48027
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsManipulateInteractBlueprintFunctionLibrary.TsManipulateInteractBlueprintFunctionLibrary_C";

	// Token: 0x0400BB9C RID: 48028
	private static IntPtr _ClassPtr;

	// Token: 0x0400BB9D RID: 48029
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x020094FF RID: 38143
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetMechascoutDragInteractType_FunctionParams
	{
		// Token: 0x0402FEA7 RID: 196263
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FEA8 RID: 196264
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FEA9 RID: 196265
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x02009500 RID: 38144
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __StartMechascoutDragInteract_FunctionParams
	{
		// Token: 0x0402FEAA RID: 196266
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FEAB RID: 196267
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FEAC RID: 196268
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02009501 RID: 38145
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __AttachMechascoutInteractActorToSocket_FunctionParams
	{
		// Token: 0x0402FEAD RID: 196269
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FEAE RID: 196270
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FEAF RID: 196271
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02009502 RID: 38146
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __DetachMechascoutInteractActor_FunctionParams
	{
		// Token: 0x0402FEB0 RID: 196272
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FEB1 RID: 196273
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FEB2 RID: 196274
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02009503 RID: 38147
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __AttachMechascoutManipulateActorToSocket_FunctionParams
	{
		// Token: 0x0402FEB3 RID: 196275
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FEB4 RID: 196276
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FEB5 RID: 196277
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02009504 RID: 38148
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __DetachMechascoutManipulateActor_FunctionParams
	{
		// Token: 0x0402FEB6 RID: 196278
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FEB7 RID: 196279
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FEB8 RID: 196280
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02009505 RID: 38149
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EndMechascoutDragInteract_FunctionParams
	{
		// Token: 0x0402FEB9 RID: 196281
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FEBA RID: 196282
		[FieldOffset(4)]
		public byte dragType;

		// Token: 0x0402FEBB RID: 196283
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}
}

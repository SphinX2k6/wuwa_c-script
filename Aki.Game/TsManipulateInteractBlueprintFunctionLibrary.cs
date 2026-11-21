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

// Token: 0x0200239D RID: 9117
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsManipulateInteractBlueprintFunctionLibrary.TsManipulateInteractBlueprintFunctionLibrary_C")]
public class TsManipulateInteractBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
{
	// Token: 0x06016B94 RID: 93076 RVA: 0x006A09D4 File Offset: 0x0069EBD4
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

	// Token: 0x06016B95 RID: 93077 RVA: 0x006A09FC File Offset: 0x0069EBFC
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

	// Token: 0x06016B96 RID: 93078 RVA: 0x006A0A34 File Offset: 0x0069EC34
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

	// Token: 0x06016B97 RID: 93079 RVA: 0x006A0BFC File Offset: 0x0069EDFC
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

	// Token: 0x06016B98 RID: 93080 RVA: 0x006A0D34 File Offset: 0x0069EF34
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

	// Token: 0x06016B99 RID: 93081 RVA: 0x006A0E00 File Offset: 0x0069F000
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

	// Token: 0x06016B9A RID: 93082 RVA: 0x006A0FA4 File Offset: 0x0069F1A4
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

	// Token: 0x06016B9B RID: 93083 RVA: 0x006A10A8 File Offset: 0x0069F2A8
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

	// Token: 0x06016B9C RID: 93084 RVA: 0x006A10F8 File Offset: 0x0069F2F8
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

	// Token: 0x06016B9D RID: 93085 RVA: 0x006A1132 File Offset: 0x0069F332
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsManipulateInteractBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsManipulateInteractBlueprintFunctionLibrary.TsManipulateInteractBlueprintFunctionLibrary_C");
		}
		return TsManipulateInteractBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x06016B9E RID: 93086 RVA: 0x006A1158 File Offset: 0x0069F358
	public TsManipulateInteractBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(TsManipulateInteractBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06016B9F RID: 93087 RVA: 0x006A1180 File Offset: 0x0069F380
	[NullableContext(1)]
	public TsManipulateInteractBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsManipulateInteractBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06016BA0 RID: 93088 RVA: 0x006A11B3 File Offset: 0x0069F3B3
	protected TsManipulateInteractBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06016BA1 RID: 93089 RVA: 0x006A11BC File Offset: 0x0069F3BC
	protected unsafe static void __CPPCALL_GetMechascoutDragInteractType_Implementation(TsManipulateInteractBlueprintFunctionLibrary.__GetMechascoutDragInteractType_FunctionParams* __Params)
	{
		*(&__Params->__Result) = (byte)TsManipulateInteractBlueprintFunctionLibrary.GetMechascoutDragInteractType(__Params->entityId);
	}

	// Token: 0x06016BA2 RID: 93090 RVA: 0x006A11D1 File Offset: 0x0069F3D1
	protected unsafe static void __CPPCALL_StartMechascoutDragInteract_Implementation(TsManipulateInteractBlueprintFunctionLibrary.__StartMechascoutDragInteract_FunctionParams* __Params)
	{
		__Params->__Result = TsManipulateInteractBlueprintFunctionLibrary.StartMechascoutDragInteract(__Params->entityId);
	}

	// Token: 0x06016BA3 RID: 93091 RVA: 0x006A11E4 File Offset: 0x0069F3E4
	protected unsafe static void __CPPCALL_AttachMechascoutInteractActorToSocket_Implementation(TsManipulateInteractBlueprintFunctionLibrary.__AttachMechascoutInteractActorToSocket_FunctionParams* __Params)
	{
		__Params->__Result = TsManipulateInteractBlueprintFunctionLibrary.AttachMechascoutInteractActorToSocket(__Params->entityId);
	}

	// Token: 0x06016BA4 RID: 93092 RVA: 0x006A11F7 File Offset: 0x0069F3F7
	protected unsafe static void __CPPCALL_DetachMechascoutInteractActor_Implementation(TsManipulateInteractBlueprintFunctionLibrary.__DetachMechascoutInteractActor_FunctionParams* __Params)
	{
		__Params->__Result = TsManipulateInteractBlueprintFunctionLibrary.DetachMechascoutInteractActor(__Params->entityId);
	}

	// Token: 0x06016BA5 RID: 93093 RVA: 0x006A120A File Offset: 0x0069F40A
	protected unsafe static void __CPPCALL_AttachMechascoutManipulateActorToSocket_Implementation(TsManipulateInteractBlueprintFunctionLibrary.__AttachMechascoutManipulateActorToSocket_FunctionParams* __Params)
	{
		__Params->__Result = TsManipulateInteractBlueprintFunctionLibrary.AttachMechascoutManipulateActorToSocket(__Params->entityId);
	}

	// Token: 0x06016BA6 RID: 93094 RVA: 0x006A121D File Offset: 0x0069F41D
	protected unsafe static void __CPPCALL_DetachMechascoutManipulateActor_Implementation(TsManipulateInteractBlueprintFunctionLibrary.__DetachMechascoutManipulateActor_FunctionParams* __Params)
	{
		__Params->__Result = TsManipulateInteractBlueprintFunctionLibrary.DetachMechascoutManipulateActor(__Params->entityId);
	}

	// Token: 0x06016BA7 RID: 93095 RVA: 0x006A1230 File Offset: 0x0069F430
	protected unsafe static void __CPPCALL_EndMechascoutDragInteract_Implementation(TsManipulateInteractBlueprintFunctionLibrary.__EndMechascoutDragInteract_FunctionParams* __Params)
	{
		AkiClient.Game.Aki.Data.Gameplay.MechascoutDrag.EMechascoutDragType dragType = (AkiClient.Game.Aki.Data.Gameplay.MechascoutDrag.EMechascoutDragType)__Params->dragType;
		TsManipulateInteractBlueprintFunctionLibrary.EndMechascoutDragInteract(__Params->entityId, dragType);
	}

	// Token: 0x0400BF26 RID: 48934
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

	// Token: 0x0400BF27 RID: 48935
	[StaticVariableRuleIgnore]
	private static readonly FName? MechascoutAttachSocket = FNameUtil.GetDynamicFName("WeaponProp04");

	// Token: 0x0400BF28 RID: 48936
	[StaticVariableRuleIgnore]
	private static readonly FName? MechascoutManipulateAttachSocket = FNameUtil.GetDynamicFName("WeaponProp05");

	// Token: 0x0400BF29 RID: 48937
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsManipulateInteractBlueprintFunctionLibrary.TsManipulateInteractBlueprintFunctionLibrary_C";

	// Token: 0x0400BF2A RID: 48938
	private static IntPtr _ClassPtr;

	// Token: 0x0400BF2B RID: 48939
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x02008727 RID: 34599
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetMechascoutDragInteractType_FunctionParams
	{
		// Token: 0x0402B535 RID: 177461
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B536 RID: 177462
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B537 RID: 177463
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x02008728 RID: 34600
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __StartMechascoutDragInteract_FunctionParams
	{
		// Token: 0x0402B538 RID: 177464
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B539 RID: 177465
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B53A RID: 177466
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02008729 RID: 34601
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __AttachMechascoutInteractActorToSocket_FunctionParams
	{
		// Token: 0x0402B53B RID: 177467
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B53C RID: 177468
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B53D RID: 177469
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x0200872A RID: 34602
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __DetachMechascoutInteractActor_FunctionParams
	{
		// Token: 0x0402B53E RID: 177470
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B53F RID: 177471
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B540 RID: 177472
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x0200872B RID: 34603
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __AttachMechascoutManipulateActorToSocket_FunctionParams
	{
		// Token: 0x0402B541 RID: 177473
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B542 RID: 177474
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B543 RID: 177475
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x0200872C RID: 34604
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __DetachMechascoutManipulateActor_FunctionParams
	{
		// Token: 0x0402B544 RID: 177476
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B545 RID: 177477
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B546 RID: 177478
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x0200872D RID: 34605
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EndMechascoutDragInteract_FunctionParams
	{
		// Token: 0x0402B547 RID: 177479
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B548 RID: 177480
		[FieldOffset(4)]
		public byte dragType;

		// Token: 0x0402B549 RID: 177481
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}
}

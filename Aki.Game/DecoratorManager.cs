using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.Protocol.Ai;
using Aki.Protocol.Debug;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Module.CombatMessage;
using CSharpScript.Game.NewWorld.Character.Common.Component;

// Token: 0x02003563 RID: 13667
public class DecoratorManager
{
	// Token: 0x0601DFE2 RID: 122850 RVA: 0x0087C6CC File Offset: 0x0087A8CC
	public static bool Init()
	{
		Action<Entity, AiInformationNotify, CombatCommon> callBack;
		if ((callBack = global::DecoratorManager.<>O.<0>__AiInformationNotify) == null)
		{
			callBack = (global::DecoratorManager.<>O.<0>__AiInformationNotify = new Action<Entity, AiInformationNotify, CombatCommon>(AiController.AiInformationNotify));
		}
		CombatNet.Listen<AiInformationNotify>(callBack, ENotifyMessageId.AiInformationNotify, true, false);
		Action<Entity, AiBlackboardCdNotify, CombatCommon> callBack2;
		if ((callBack2 = global::DecoratorManager.<>O.<1>__AiInformationS) == null)
		{
			callBack2 = (global::DecoratorManager.<>O.<1>__AiInformationS = new Action<Entity, AiBlackboardCdNotify, CombatCommon>(AiController.AiInformationS));
		}
		CombatNet.Listen<AiBlackboardCdNotify>(callBack2, ENotifyMessageId.AiBlackboardCdNotify, true, false);
		Action<Entity, NewLinkNotify, CombatCommon> callBack3;
		if ((callBack3 = global::DecoratorManager.<>O.<2>__OnNewLinkStateNotify) == null)
		{
			callBack3 = (global::DecoratorManager.<>O.<2>__OnNewLinkStateNotify = new Action<Entity, NewLinkNotify, CombatCommon>(BattleLinkController.OnNewLinkStateNotify));
		}
		CombatNet.Listen<NewLinkNotify>(callBack3, ENotifyMessageId.NewLinkNotify, false, false);
		Action<Entity, EntityIsVisibleNotify, CombatCommon> callBack4;
		if ((callBack4 = global::DecoratorManager.<>O.<3>__EntityIsVisibleNotify) == null)
		{
			callBack4 = (global::DecoratorManager.<>O.<3>__EntityIsVisibleNotify = new Action<Entity, EntityIsVisibleNotify, CombatCommon>(CombatMessageController.EntityIsVisibleNotify));
		}
		CombatNet.Listen<EntityIsVisibleNotify>(callBack4, ENotifyMessageId.EntityIsVisibleNotify, true, true);
		Action<Entity, ActorVisibleNotify, CombatCommon> callBack5;
		if ((callBack5 = global::DecoratorManager.<>O.<4>__ActorIsVisibleNotify) == null)
		{
			callBack5 = (global::DecoratorManager.<>O.<4>__ActorIsVisibleNotify = new Action<Entity, ActorVisibleNotify, CombatCommon>(CombatMessageController.ActorIsVisibleNotify));
		}
		CombatNet.Listen<ActorVisibleNotify>(callBack5, ENotifyMessageId.ActorVisibleNotify, true, true);
		Action<Entity, EntityLoadCompleteNotify, CombatCommon> callBack6;
		if ((callBack6 = global::DecoratorManager.<>O.<5>__EntityLoadCompleteNotify) == null)
		{
			callBack6 = (global::DecoratorManager.<>O.<5>__EntityLoadCompleteNotify = new Action<Entity, EntityLoadCompleteNotify, CombatCommon>(CombatMessageController.EntityLoadCompleteNotify));
		}
		CombatNet.Listen<EntityLoadCompleteNotify>(callBack6, ENotifyMessageId.EntityLoadCompleteNotify, false, false);
		Action<Entity, PlayerRebackSceneNotify, CombatCommon> callBack7;
		if ((callBack7 = global::DecoratorManager.<>O.<6>__PlayerRebackSceneNotify) == null)
		{
			callBack7 = (global::DecoratorManager.<>O.<6>__PlayerRebackSceneNotify = new Action<Entity, PlayerRebackSceneNotify, CombatCommon>(CombatMessageController.PlayerRebackSceneNotify));
		}
		CombatNet.Listen<PlayerRebackSceneNotify>(callBack7, ENotifyMessageId.PlayerRebackSceneNotify, false, false);
		Action<Entity, MaterialNotify, CombatCommon> callBack8;
		if ((callBack8 = global::DecoratorManager.<>O.<7>__MaterialNotify) == null)
		{
			callBack8 = (global::DecoratorManager.<>O.<7>__MaterialNotify = new Action<Entity, MaterialNotify, CombatCommon>(CombatMessageController.MaterialNotify));
		}
		CombatNet.Listen<MaterialNotify>(callBack8, ENotifyMessageId.MaterialNotify, true, true);
		Action<Entity, EntityStaticHookMoveNotify, CombatCommon> callBack9;
		if ((callBack9 = global::DecoratorManager.<>O.<8>__OnHookMoveNotify) == null)
		{
			callBack9 = (global::DecoratorManager.<>O.<8>__OnHookMoveNotify = new Action<Entity, EntityStaticHookMoveNotify, CombatCommon>(RoleSceneInteractController.OnHookMoveNotify));
		}
		CombatNet.Listen<EntityStaticHookMoveNotify>(callBack9, ENotifyMessageId.EntityStaticHookMoveNotify, false, false);
		Action<Entity, UseSkillNotify, CombatCommon> callBack10;
		if ((callBack10 = global::DecoratorManager.<>O.<9>__UseSkillNotify) == null)
		{
			callBack10 = (global::DecoratorManager.<>O.<9>__UseSkillNotify = new Action<Entity, UseSkillNotify, CombatCommon>(SkillMessageController.UseSkillNotify));
		}
		CombatNet.Listen<UseSkillNotify>(callBack10, ENotifyMessageId.UseSkillNotify, true, true);
		Action<Entity, SkillNotify, CombatCommon> callBack11;
		if ((callBack11 = global::DecoratorManager.<>O.<10>__SkillNotify) == null)
		{
			callBack11 = (global::DecoratorManager.<>O.<10>__SkillNotify = new Action<Entity, SkillNotify, CombatCommon>(SkillMessageController.SkillNotify));
		}
		CombatNet.Listen<SkillNotify>(callBack11, ENotifyMessageId.SkillNotify, true, true);
		Action<Entity, EndSkillNotify, CombatCommon> callBack12;
		if ((callBack12 = global::DecoratorManager.<>O.<11>__EndSkillNotify) == null)
		{
			callBack12 = (global::DecoratorManager.<>O.<11>__EndSkillNotify = new Action<Entity, EndSkillNotify, CombatCommon>(SkillMessageController.EndSkillNotify));
		}
		CombatNet.Listen<EndSkillNotify>(callBack12, ENotifyMessageId.EndSkillNotify, true, true);
		Action<Entity, CreateBulletNotify, CombatCommon> callBack13;
		if ((callBack13 = global::DecoratorManager.<>O.<12>__CreateBulletNotify) == null)
		{
			callBack13 = (global::DecoratorManager.<>O.<12>__CreateBulletNotify = new Action<Entity, CreateBulletNotify, CombatCommon>(BulletController.CreateBulletNotify));
		}
		CombatNet.Listen<CreateBulletNotify>(callBack13, ENotifyMessageId.CreateBulletNotify, true, false);
		Action<Entity, DestroyBulletNotify, CombatCommon> callBack14;
		if ((callBack14 = global::DecoratorManager.<>O.<13>__DestroyBulletNotify) == null)
		{
			callBack14 = (global::DecoratorManager.<>O.<13>__DestroyBulletNotify = new Action<Entity, DestroyBulletNotify, CombatCommon>(BulletController.DestroyBulletNotify));
		}
		CombatNet.Listen<DestroyBulletNotify>(callBack14, ENotifyMessageId.DestroyBulletNotify, true, false);
		Action<Entity, ModifyBulletParamsNotify, CombatCommon> callBack15;
		if ((callBack15 = global::DecoratorManager.<>O.<14>__ModifyBulletParamsNotify) == null)
		{
			callBack15 = (global::DecoratorManager.<>O.<14>__ModifyBulletParamsNotify = new Action<Entity, ModifyBulletParamsNotify, CombatCommon>(BulletController.ModifyBulletParamsNotify));
		}
		CombatNet.Listen<ModifyBulletParamsNotify>(callBack15, ENotifyMessageId.ModifyBulletParamsNotify, true, false);
		Action<Entity, ApplyGameplayEffectNotify, CombatCommon> callBack16;
		if ((callBack16 = global::DecoratorManager.<>O.<15>__BroadcastAddBuffNotify) == null)
		{
			callBack16 = (global::DecoratorManager.<>O.<15>__BroadcastAddBuffNotify = new Action<Entity, ApplyGameplayEffectNotify, CombatCommon>(BaseBuffComponent.BroadcastAddBuffNotify));
		}
		CombatNet.Listen<ApplyGameplayEffectNotify>(callBack16, ENotifyMessageId.ApplyGameplayEffectNotify, false, false);
		Action<Entity, ApplyBuffFailedNotify, CombatCommon> callBack17;
		if ((callBack17 = global::DecoratorManager.<>O.<16>__BroadcastAddBuffFailedNotify) == null)
		{
			callBack17 = (global::DecoratorManager.<>O.<16>__BroadcastAddBuffFailedNotify = new Action<Entity, ApplyBuffFailedNotify, CombatCommon>(BaseBuffComponent.BroadcastAddBuffFailedNotify));
		}
		CombatNet.Listen<ApplyBuffFailedNotify>(callBack17, ENotifyMessageId.ApplyBuffFailedNotify, false, false);
		Action<Entity, BuffStackCountNotify, CombatCommon> callBack18;
		if ((callBack18 = global::DecoratorManager.<>O.<17>__BroadcastBuffStackChangedNotify) == null)
		{
			callBack18 = (global::DecoratorManager.<>O.<17>__BroadcastBuffStackChangedNotify = new Action<Entity, BuffStackCountNotify, CombatCommon>(BaseBuffComponent.BroadcastBuffStackChangedNotify));
		}
		CombatNet.Listen<BuffStackCountNotify>(callBack18, ENotifyMessageId.BuffStackCountNotify, false, false);
		Action<Entity, RemoveGameplayEffectNotify, CombatCommon> callBack19;
		if ((callBack19 = global::DecoratorManager.<>O.<18>__BroadcastRemoveBuffNotify) == null)
		{
			callBack19 = (global::DecoratorManager.<>O.<18>__BroadcastRemoveBuffNotify = new Action<Entity, RemoveGameplayEffectNotify, CombatCommon>(BaseBuffComponent.BroadcastRemoveBuffNotify));
		}
		CombatNet.Listen<RemoveGameplayEffectNotify>(callBack19, ENotifyMessageId.RemoveGameplayEffectNotify, false, false);
		Action<Entity, BuffDurationNotify, CombatCommon> callBack20;
		if ((callBack20 = global::DecoratorManager.<>O.<19>__BuffDurationNotify) == null)
		{
			callBack20 = (global::DecoratorManager.<>O.<19>__BuffDurationNotify = new Action<Entity, BuffDurationNotify, CombatCommon>(BaseBuffComponent.BuffDurationNotify));
		}
		CombatNet.Listen<BuffDurationNotify>(callBack20, ENotifyMessageId.BuffDurationNotify, false, false);
		Action<Entity, ApplyBuffS2cRequestNotify, CombatCommon> callBack21;
		if ((callBack21 = global::DecoratorManager.<>O.<20>__OrderAddBuffS2cNotify) == null)
		{
			callBack21 = (global::DecoratorManager.<>O.<20>__OrderAddBuffS2cNotify = new Action<Entity, ApplyBuffS2cRequestNotify, CombatCommon>(BaseBuffComponent.OrderAddBuffS2cNotify));
		}
		CombatNet.Listen<ApplyBuffS2cRequestNotify>(callBack21, ENotifyMessageId.ApplyBuffS2cRequestNotify, false, true);
		Action<Entity, RemoveBuffS2cRequestNotify, CombatCommon> callBack22;
		if ((callBack22 = global::DecoratorManager.<>O.<21>__OrderRemoveBuffS2cNotify) == null)
		{
			callBack22 = (global::DecoratorManager.<>O.<21>__OrderRemoveBuffS2cNotify = new Action<Entity, RemoveBuffS2cRequestNotify, CombatCommon>(BaseBuffComponent.OrderRemoveBuffS2cNotify));
		}
		CombatNet.Listen<RemoveBuffS2cRequestNotify>(callBack22, ENotifyMessageId.RemoveBuffS2cRequestNotify, false, false);
		Action<Entity, RemoveBuffByIdS2cRequestNotify, CombatCommon> callBack23;
		if ((callBack23 = global::DecoratorManager.<>O.<22>__OrderRemoveBuffByIdS2cNotify) == null)
		{
			callBack23 = (global::DecoratorManager.<>O.<22>__OrderRemoveBuffByIdS2cNotify = new Action<Entity, RemoveBuffByIdS2cRequestNotify, CombatCommon>(BaseBuffComponent.OrderRemoveBuffByIdS2cNotify));
		}
		CombatNet.Listen<RemoveBuffByIdS2cRequestNotify>(callBack23, ENotifyMessageId.RemoveBuffByIdS2cRequestNotify, false, false);
		Action<Entity, RemoveBuffByServerIdS2cRequestNotify, CombatCommon> callBack24;
		if ((callBack24 = global::DecoratorManager.<>O.<23>__OrderRemoveBuffByServerIdNotify) == null)
		{
			callBack24 = (global::DecoratorManager.<>O.<23>__OrderRemoveBuffByServerIdNotify = new Action<Entity, RemoveBuffByServerIdS2cRequestNotify, CombatCommon>(BaseBuffComponent.OrderRemoveBuffByServerIdNotify));
		}
		CombatNet.Listen<RemoveBuffByServerIdS2cRequestNotify>(callBack24, ENotifyMessageId.RemoveBuffByServerIdS2cRequestNotify, false, false);
		Action<Entity, OrderApplyBuffNotify, CombatCommon> callBack25;
		if ((callBack25 = global::DecoratorManager.<>O.<24>__OrderAddBuffNotify) == null)
		{
			callBack25 = (global::DecoratorManager.<>O.<24>__OrderAddBuffNotify = new Action<Entity, OrderApplyBuffNotify, CombatCommon>(BaseBuffComponent.OrderAddBuffNotify));
		}
		CombatNet.Listen<OrderApplyBuffNotify>(callBack25, ENotifyMessageId.OrderApplyBuffNotify, false, false);
		Action<Entity, OrderRemoveBuffNotify, CombatCommon> callBack26;
		if ((callBack26 = global::DecoratorManager.<>O.<25>__OrderRemoveBuffNotify) == null)
		{
			callBack26 = (global::DecoratorManager.<>O.<25>__OrderRemoveBuffNotify = new Action<Entity, OrderRemoveBuffNotify, CombatCommon>(BaseBuffComponent.OrderRemoveBuffNotify));
		}
		CombatNet.Listen<OrderRemoveBuffNotify>(callBack26, ENotifyMessageId.OrderRemoveBuffNotify, false, false);
		Action<Entity, OrderRemoveBuffByTagsNotify, CombatCommon> callBack27;
		if ((callBack27 = global::DecoratorManager.<>O.<26>__OrderRemoveBuffByTagsNotify) == null)
		{
			callBack27 = (global::DecoratorManager.<>O.<26>__OrderRemoveBuffByTagsNotify = new Action<Entity, OrderRemoveBuffByTagsNotify, CombatCommon>(BaseBuffComponent.OrderRemoveBuffByTagsNotify));
		}
		CombatNet.Listen<OrderRemoveBuffByTagsNotify>(callBack27, ENotifyMessageId.OrderRemoveBuffByTagsNotify, false, false);
		Action<Entity, ActivateBuffNotify, CombatCommon> callBack28;
		if ((callBack28 = global::DecoratorManager.<>O.<27>__BroadcastActivateBuffNotify) == null)
		{
			callBack28 = (global::DecoratorManager.<>O.<27>__BroadcastActivateBuffNotify = new Action<Entity, ActivateBuffNotify, CombatCommon>(BaseBuffComponent.BroadcastActivateBuffNotify));
		}
		CombatNet.Listen<ActivateBuffNotify>(callBack28, ENotifyMessageId.ActivateBuffNotify, false, false);
		Action<Entity, TransformBuffStackNotify, CombatCommon> callBack29;
		if ((callBack29 = global::DecoratorManager.<>O.<28>__BroadcastTransformBuffStackNotify) == null)
		{
			callBack29 = (global::DecoratorManager.<>O.<28>__BroadcastTransformBuffStackNotify = new Action<Entity, TransformBuffStackNotify, CombatCommon>(BaseBuffComponent.BroadcastTransformBuffStackNotify));
		}
		CombatNet.Listen<TransformBuffStackNotify>(callBack29, ENotifyMessageId.TransformBuffStackNotify, false, false);
		Action<Entity, DamageExecuteNotify, CombatCommon> callBack30;
		if ((callBack30 = global::DecoratorManager.<>O.<29>__OnDamageExecuteNotify) == null)
		{
			callBack30 = (global::DecoratorManager.<>O.<29>__OnDamageExecuteNotify = new Action<Entity, DamageExecuteNotify, CombatCommon>(BaseDamageComponent.OnDamageExecuteNotify));
		}
		CombatNet.Listen<DamageExecuteNotify>(callBack30, ENotifyMessageId.DamageExecuteNotify, false, false);
		Action<Entity, GameplayCueNotify, CombatCommon> callBack31;
		if ((callBack31 = global::DecoratorManager.<>O.<30>__GameplayCueNotify) == null)
		{
			callBack31 = (global::DecoratorManager.<>O.<30>__GameplayCueNotify = new Action<Entity, GameplayCueNotify, CombatCommon>(BaseGameplayCueComponent.GameplayCueNotify));
		}
		CombatNet.Listen<GameplayCueNotify>(callBack31, ENotifyMessageId.GameplayCueNotify, true, false);
		Action<Entity, AttributeChangedNotify, CombatCommon> callBack32;
		if ((callBack32 = global::DecoratorManager.<>O.<31>__AttributeChangedNotify) == null)
		{
			callBack32 = (global::DecoratorManager.<>O.<31>__AttributeChangedNotify = new Action<Entity, AttributeChangedNotify, CombatCommon>(CharacterAttributeComponent.AttributeChangedNotify));
		}
		CombatNet.Listen<AttributeChangedNotify>(callBack32, ENotifyMessageId.AttributeChangedNotify, true, false);
		Action<Entity, RecoverPropChangedNotify, CombatCommon> callBack33;
		if ((callBack33 = global::DecoratorManager.<>O.<32>__RecoverPropChangedNotify) == null)
		{
			callBack33 = (global::DecoratorManager.<>O.<32>__RecoverPropChangedNotify = new Action<Entity, RecoverPropChangedNotify, CombatCommon>(CharacterAttributeComponent.RecoverPropChangedNotify));
		}
		CombatNet.Listen<RecoverPropChangedNotify>(callBack33, ENotifyMessageId.RecoverPropChangedNotify, true, false);
		Action<Entity, DamageRecordNotify, CombatCommon> callBack34;
		if ((callBack34 = global::DecoratorManager.<>O.<33>__OnDamageRecordNotify) == null)
		{
			callBack34 = (global::DecoratorManager.<>O.<33>__OnDamageRecordNotify = new Action<Entity, DamageRecordNotify, CombatCommon>(CharacterGasDebugComponent.OnDamageRecordNotify));
		}
		CombatNet.Listen<DamageRecordNotify>(callBack34, ENotifyMessageId.DamageRecordNotify, true, false);
		Action<Entity, PassiveSkillAddNotify, CombatCommon> callBack35;
		if ((callBack35 = global::DecoratorManager.<>O.<34>__PassiveSkillAddNotify) == null)
		{
			callBack35 = (global::DecoratorManager.<>O.<34>__PassiveSkillAddNotify = new Action<Entity, PassiveSkillAddNotify, CombatCommon>(CharacterPassiveSkillComponent.PassiveSkillAddNotify));
		}
		CombatNet.Listen<PassiveSkillAddNotify>(callBack35, ENotifyMessageId.PassiveSkillAddNotify, false, false);
		Action<Entity, PassiveSkillRemoveNotify, CombatCommon> callBack36;
		if ((callBack36 = global::DecoratorManager.<>O.<35>__PassiveSkillRemoveNotify) == null)
		{
			callBack36 = (global::DecoratorManager.<>O.<35>__PassiveSkillRemoveNotify = new Action<Entity, PassiveSkillRemoveNotify, CombatCommon>(CharacterPassiveSkillComponent.PassiveSkillRemoveNotify));
		}
		CombatNet.Listen<PassiveSkillRemoveNotify>(callBack36, ENotifyMessageId.PassiveSkillRemoveNotify, false, false);
		Action<Entity, PlayerBattleStateChangeNotify, CombatCommon> callBack37;
		if ((callBack37 = global::DecoratorManager.<>O.<36>__OnPlayerBattleStateChangeNotify) == null)
		{
			callBack37 = (global::DecoratorManager.<>O.<36>__OnPlayerBattleStateChangeNotify = new Action<Entity, PlayerBattleStateChangeNotify, CombatCommon>(CharacterUnifiedStateComponent.OnPlayerBattleStateChangeNotify));
		}
		CombatNet.Listen<PlayerBattleStateChangeNotify>(callBack37, ENotifyMessageId.PlayerBattleStateChangeNotify, false, false);
		Action<Entity, HitNotify, CombatCommon> callBack38;
		if ((callBack38 = global::DecoratorManager.<>O.<37>__HitNotify) == null)
		{
			callBack38 = (global::DecoratorManager.<>O.<37>__HitNotify = new Action<Entity, HitNotify, CombatCommon>(BaseHitComponent.HitNotify));
		}
		CombatNet.Listen<HitNotify>(callBack38, ENotifyMessageId.HitNotify, true, false);
		Action<Entity, AiHateNotify, CombatCommon> callBack39;
		if ((callBack39 = global::DecoratorManager.<>O.<38>__AiHateNotify) == null)
		{
			callBack39 = (global::DecoratorManager.<>O.<38>__AiHateNotify = new Action<Entity, AiHateNotify, CombatCommon>(CharacterAiComponent.AiHateNotify));
		}
		CombatNet.Listen<AiHateNotify>(callBack39, ENotifyMessageId.AiHateNotify, true, false);
		Action<Entity, BoneVisibleChangeNotify, CombatCommon> callBack40;
		if ((callBack40 = global::DecoratorManager.<>O.<39>__BoneVisibleChangeNotify) == null)
		{
			callBack40 = (global::DecoratorManager.<>O.<39>__BoneVisibleChangeNotify = new Action<Entity, BoneVisibleChangeNotify, CombatCommon>(CharacterAnimationComponent.BoneVisibleChangeNotify));
		}
		CombatNet.Listen<BoneVisibleChangeNotify>(callBack40, ENotifyMessageId.BoneVisibleChangeNotify, true, false);
		Action<Entity, AnimationGameplayTagNotify, CombatCommon> callBack41;
		if ((callBack41 = global::DecoratorManager.<>O.<40>__AnimationGameplayTagNotify) == null)
		{
			callBack41 = (global::DecoratorManager.<>O.<40>__AnimationGameplayTagNotify = new Action<Entity, AnimationGameplayTagNotify, CombatCommon>(CharacterAnimationSyncComponent.AnimationGameplayTagNotify));
		}
		CombatNet.Listen<AnimationGameplayTagNotify>(callBack41, ENotifyMessageId.AnimationGameplayTagNotify, true, false);
		Action<Entity, AnimationStateChangedNotify, CombatCommon> callBack42;
		if ((callBack42 = global::DecoratorManager.<>O.<41>__AnimationStateChangedNotify) == null)
		{
			callBack42 = (global::DecoratorManager.<>O.<41>__AnimationStateChangedNotify = new Action<Entity, AnimationStateChangedNotify, CombatCommon>(CharacterAnimationSyncComponent.AnimationStateChangedNotify));
		}
		CombatNet.Listen<AnimationStateChangedNotify>(callBack42, ENotifyMessageId.AnimationStateChangedNotify, true, false);
		Action<Entity, PackAnimChangedNotify, CombatCommon> callBack43;
		if ((callBack43 = global::DecoratorManager.<>O.<42>__PackAnimChangedNotify) == null)
		{
			callBack43 = (global::DecoratorManager.<>O.<42>__PackAnimChangedNotify = new Action<Entity, PackAnimChangedNotify, CombatCommon>(CharacterAnimationSyncComponent.PackAnimChangedNotify));
		}
		CombatNet.Listen<PackAnimChangedNotify>(callBack43, ENotifyMessageId.PackAnimChangedNotify, false, false);
		Action<Entity, AnimationStateInitNotify, CombatCommon> callBack44;
		if ((callBack44 = global::DecoratorManager.<>O.<43>__AnimationStateInitNotify) == null)
		{
			callBack44 = (global::DecoratorManager.<>O.<43>__AnimationStateInitNotify = new Action<Entity, AnimationStateInitNotify, CombatCommon>(CharacterAnimationSyncComponent.AnimationStateInitNotify));
		}
		CombatNet.Listen<AnimationStateInitNotify>(callBack44, ENotifyMessageId.AnimationStateInitNotify, false, false);
		Action<Entity, AddCombineEntitiesRelationNotify, CombatCommon> callBack45;
		if ((callBack45 = global::DecoratorManager.<>O.<44>__AddCombineEntitiesRelationNotify) == null)
		{
			callBack45 = (global::DecoratorManager.<>O.<44>__AddCombineEntitiesRelationNotify = new Action<Entity, AddCombineEntitiesRelationNotify, CombatCommon>(CharacterAttachComponent.AddCombineEntitiesRelationNotify));
		}
		CombatNet.Listen<AddCombineEntitiesRelationNotify>(callBack45, ENotifyMessageId.AddCombineEntitiesRelationNotify, true, false);
		Action<Entity, RemoveCombineRelationNotify, CombatCommon> callBack46;
		if ((callBack46 = global::DecoratorManager.<>O.<45>__RemoveCombineRelationNotify) == null)
		{
			callBack46 = (global::DecoratorManager.<>O.<45>__RemoveCombineRelationNotify = new Action<Entity, RemoveCombineRelationNotify, CombatCommon>(CharacterAttachComponent.RemoveCombineRelationNotify));
		}
		CombatNet.Listen<RemoveCombineRelationNotify>(callBack46, ENotifyMessageId.RemoveCombineRelationNotify, true, false);
		Action<Entity, CaughtNotify, CombatCommon> callBack47;
		if ((callBack47 = global::DecoratorManager.<>O.<46>__CaughtNotify) == null)
		{
			callBack47 = (global::DecoratorManager.<>O.<46>__CaughtNotify = new Action<Entity, CaughtNotify, CombatCommon>(CharacterCaughtNewComponent.CaughtNotify));
		}
		CombatNet.Listen<CaughtNotify>(callBack47, ENotifyMessageId.CaughtNotify, true, false);
		Action<Entity, LogicStateInitNotify, CombatCommon> callBack48;
		if ((callBack48 = global::DecoratorManager.<>O.<47>__LogicStateInitNotify) == null)
		{
			callBack48 = (global::DecoratorManager.<>O.<47>__LogicStateInitNotify = new Action<Entity, LogicStateInitNotify, CombatCommon>(CharacterLogicStateSyncComponent.LogicStateInitNotify));
		}
		CombatNet.Listen<LogicStateInitNotify>(callBack48, ENotifyMessageId.LogicStateInitNotify, true, false);
		Action<Entity, SwitchLogicStateNotify, CombatCommon> callBack49;
		if ((callBack49 = global::DecoratorManager.<>O.<48>__SwitchLogicStateNotify) == null)
		{
			callBack49 = (global::DecoratorManager.<>O.<48>__SwitchLogicStateNotify = new Action<Entity, SwitchLogicStateNotify, CombatCommon>(CharacterLogicStateSyncComponent.SwitchLogicStateNotify));
		}
		CombatNet.Listen<SwitchLogicStateNotify>(callBack49, ENotifyMessageId.SwitchLogicStateNotify, true, false);
		Action<Entity, PartUpdateNotify, CombatCommon> callBack50;
		if ((callBack50 = global::DecoratorManager.<>O.<49>__PartUpdateNotify) == null)
		{
			callBack50 = (global::DecoratorManager.<>O.<49>__PartUpdateNotify = new Action<Entity, PartUpdateNotify, CombatCommon>(CharacterPartComponent.PartUpdateNotify));
		}
		CombatNet.Listen<PartUpdateNotify>(callBack50, ENotifyMessageId.PartUpdateNotify, false, false);
		Action<Entity, PartComponentInitNotify, CombatCommon> callBack51;
		if ((callBack51 = global::DecoratorManager.<>O.<50>__PartComponentInitNotify) == null)
		{
			callBack51 = (global::DecoratorManager.<>O.<50>__PartComponentInitNotify = new Action<Entity, PartComponentInitNotify, CombatCommon>(CharacterPartComponent.PartComponentInitNotify));
		}
		CombatNet.Listen<PartComponentInitNotify>(callBack51, ENotifyMessageId.PartComponentInitNotify, false, false);
		Action<Entity, ShieldUpdateNotify, CombatCommon> callBack52;
		if ((callBack52 = global::DecoratorManager.<>O.<51>__OnShieldUpdateNotify) == null)
		{
			callBack52 = (global::DecoratorManager.<>O.<51>__OnShieldUpdateNotify = new Action<Entity, ShieldUpdateNotify, CombatCommon>(CharacterShieldComponent.OnShieldUpdateNotify));
		}
		CombatNet.Listen<ShieldUpdateNotify>(callBack52, ENotifyMessageId.ShieldUpdateNotify, false, false);
		Action<Entity, ChangeStateNotify, CombatCommon> callBack53;
		if ((callBack53 = global::DecoratorManager.<>O.<52>__ChangeStateNotify) == null)
		{
			callBack53 = (global::DecoratorManager.<>O.<52>__ChangeStateNotify = new Action<Entity, ChangeStateNotify, CombatCommon>(CharacterStateMachineNewComponent.ChangeStateNotify));
		}
		CombatNet.Listen<ChangeStateNotify>(callBack53, ENotifyMessageId.ChangeStateNotify, true, false);
		Action<Entity, ChangeStateConfirmNotify, CombatCommon> callBack54;
		if ((callBack54 = global::DecoratorManager.<>O.<53>__ChangeStateConfirmNotify) == null)
		{
			callBack54 = (global::DecoratorManager.<>O.<53>__ChangeStateConfirmNotify = new Action<Entity, ChangeStateConfirmNotify, CombatCommon>(CharacterStateMachineNewComponent.ChangeStateConfirmNotify));
		}
		CombatNet.Listen<ChangeStateConfirmNotify>(callBack54, ENotifyMessageId.ChangeStateConfirmNotify, true, false);
		Action<Entity, FsmResetNotify, CombatCommon> callBack55;
		if ((callBack55 = global::DecoratorManager.<>O.<54>__FsmResetNotify) == null)
		{
			callBack55 = (global::DecoratorManager.<>O.<54>__FsmResetNotify = new Action<Entity, FsmResetNotify, CombatCommon>(CharacterStateMachineNewComponent.FsmResetNotify));
		}
		CombatNet.Listen<FsmResetNotify>(callBack55, ENotifyMessageId.FsmResetNotify, true, false);
		Action<Entity, FsmBlackboardNotify, CombatCommon> callBack56;
		if ((callBack56 = global::DecoratorManager.<>O.<55>__FsmBlackboardNotify) == null)
		{
			callBack56 = (global::DecoratorManager.<>O.<55>__FsmBlackboardNotify = new Action<Entity, FsmBlackboardNotify, CombatCommon>(CharacterStateMachineNewComponent.FsmBlackboardNotify));
		}
		CombatNet.Listen<FsmBlackboardNotify>(callBack56, ENotifyMessageId.FsmBlackboardNotify, true, false);
		Action<Entity, FsmCustomBlackboardNotify, CombatCommon> callBack57;
		if ((callBack57 = global::DecoratorManager.<>O.<56>__FsmCustomBlackboardNotify) == null)
		{
			callBack57 = (global::DecoratorManager.<>O.<56>__FsmCustomBlackboardNotify = new Action<Entity, FsmCustomBlackboardNotify, CombatCommon>(CharacterStateMachineNewComponent.FsmCustomBlackboardNotify));
		}
		CombatNet.Listen<FsmCustomBlackboardNotify>(callBack57, ENotifyMessageId.FsmCustomBlackboardNotify, true, false);
		Action<Entity, FsmMontageDurationNotify, CombatCommon> callBack58;
		if ((callBack58 = global::DecoratorManager.<>O.<57>__FsmMontageDurationNotify) == null)
		{
			callBack58 = (global::DecoratorManager.<>O.<57>__FsmMontageDurationNotify = new Action<Entity, FsmMontageDurationNotify, CombatCommon>(CharacterStateMachineNewComponent.FsmMontageDurationNotify));
		}
		CombatNet.Listen<FsmMontageDurationNotify>(callBack58, ENotifyMessageId.FsmMontageDurationNotify, true, false);
		Action<Entity, VisionTriggerNotify, CombatCommon> callBack59;
		if ((callBack59 = global::DecoratorManager.<>O.<58>__VisionTriggerNotify) == null)
		{
			callBack59 = (global::DecoratorManager.<>O.<58>__VisionTriggerNotify = new Action<Entity, VisionTriggerNotify, CombatCommon>(CharacterVisionComponent.VisionTriggerNotify));
		}
		CombatNet.Listen<VisionTriggerNotify>(callBack59, ENotifyMessageId.VisionTriggerNotify, true, false);
		Action<Entity, DrownNotify, CombatCommon> callBack60;
		if ((callBack60 = global::DecoratorManager.<>O.<59>__DrownNotify) == null)
		{
			callBack60 = (global::DecoratorManager.<>O.<59>__DrownNotify = new Action<Entity, DrownNotify, CombatCommon>(RoleDeathComponent.DrownNotify));
		}
		CombatNet.Listen<DrownNotify>(callBack60, ENotifyMessageId.DrownNotify, true, false);
		Action<Entity, ExecuteQteNotify, CombatCommon> callBack61;
		if ((callBack61 = global::DecoratorManager.<>O.<60>__ExecuteQteNotify) == null)
		{
			callBack61 = (global::DecoratorManager.<>O.<60>__ExecuteQteNotify = new Action<Entity, ExecuteQteNotify, CombatCommon>(RoleQteComponent.ExecuteQteNotify));
		}
		CombatNet.Listen<ExecuteQteNotify>(callBack61, ENotifyMessageId.ExecuteQteNotify, true, false);
		Action<Entity, SquadPropChangedNotify, CombatCommon> callBack62;
		if ((callBack62 = global::DecoratorManager.<>O.<61>__SquadPropChangedNotify) == null)
		{
			callBack62 = (global::DecoratorManager.<>O.<61>__SquadPropChangedNotify = new Action<Entity, SquadPropChangedNotify, CombatCommon>(SquadPropComponent.SquadPropChangedNotify));
		}
		CombatNet.Listen<SquadPropChangedNotify>(callBack62, ENotifyMessageId.SquadPropChangedNotify, true, false);
		Action<Entity, MotorSummonAndRideNotify, CombatCommon> callBack63;
		if ((callBack63 = global::DecoratorManager.<>O.<62>__MotorSummonAndRideNotify) == null)
		{
			callBack63 = (global::DecoratorManager.<>O.<62>__MotorSummonAndRideNotify = new Action<Entity, MotorSummonAndRideNotify, CombatCommon>(VehicleController.MotorSummonAndRideNotify));
		}
		CombatNet.Listen<MotorSummonAndRideNotify>(callBack63, ENotifyMessageId.MotorSummonAndRideNotify, true, false);
		Action<Entity, EntityLivingStatusNotify, CombatCommon> callBack64;
		if ((callBack64 = global::DecoratorManager.<>O.<63>__ExecuteEntityLivingStatus) == null)
		{
			callBack64 = (global::DecoratorManager.<>O.<63>__ExecuteEntityLivingStatus = new Action<Entity, EntityLivingStatusNotify, CombatCommon>(BattleLogicController.ExecuteEntityLivingStatus));
		}
		CombatNet.Listen<EntityLivingStatusNotify>(callBack64, ENotifyMessageId.EntityLivingStatusNotify, true, false);
		Action<Entity, ModifyEntityCampNotify, CombatCommon> callBack65;
		if ((callBack65 = global::DecoratorManager.<>O.<64>__OnModifyEntityCampNotify) == null)
		{
			callBack65 = (global::DecoratorManager.<>O.<64>__OnModifyEntityCampNotify = new Action<Entity, ModifyEntityCampNotify, CombatCommon>(CreatureController.OnModifyEntityCampNotify));
		}
		CombatNet.Listen<ModifyEntityCampNotify>(callBack65, ENotifyMessageId.ModifyEntityCampNotify, false, false);
		Func<Entity, UseSkillNotify, CombatCommon, bool> callBack66;
		if ((callBack66 = global::DecoratorManager.<>O.<65>__PreUseSkillNotify) == null)
		{
			callBack66 = (global::DecoratorManager.<>O.<65>__PreUseSkillNotify = new Func<Entity, UseSkillNotify, CombatCommon, bool>(SkillMessageController.PreUseSkillNotify));
		}
		CombatNet.Preprocess<UseSkillNotify>(callBack66, ENotifyMessageId.UseSkillNotify);
		Func<Entity, HitNotify, CombatCommon, bool> callBack67;
		if ((callBack67 = global::DecoratorManager.<>O.<66>__PreHitNotify) == null)
		{
			callBack67 = (global::DecoratorManager.<>O.<66>__PreHitNotify = new Func<Entity, HitNotify, CombatCommon, bool>(BaseHitComponent.PreHitNotify));
		}
		CombatNet.Preprocess<HitNotify>(callBack67, ENotifyMessageId.HitNotify);
		return true;
	}

	// Token: 0x020099CA RID: 39370
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04030E51 RID: 200273
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, AiInformationNotify, CombatCommon> <0>__AiInformationNotify;

		// Token: 0x04030E52 RID: 200274
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, AiBlackboardCdNotify, CombatCommon> <1>__AiInformationS;

		// Token: 0x04030E53 RID: 200275
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, NewLinkNotify, CombatCommon> <2>__OnNewLinkStateNotify;

		// Token: 0x04030E54 RID: 200276
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, EntityIsVisibleNotify, CombatCommon> <3>__EntityIsVisibleNotify;

		// Token: 0x04030E55 RID: 200277
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, ActorVisibleNotify, CombatCommon> <4>__ActorIsVisibleNotify;

		// Token: 0x04030E56 RID: 200278
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, EntityLoadCompleteNotify, CombatCommon> <5>__EntityLoadCompleteNotify;

		// Token: 0x04030E57 RID: 200279
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, PlayerRebackSceneNotify, CombatCommon> <6>__PlayerRebackSceneNotify;

		// Token: 0x04030E58 RID: 200280
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, MaterialNotify, CombatCommon> <7>__MaterialNotify;

		// Token: 0x04030E59 RID: 200281
		[Nullable(new byte[]
		{
			0,
			2,
			2,
			2
		})]
		public static Action<Entity, EntityStaticHookMoveNotify, CombatCommon> <8>__OnHookMoveNotify;

		// Token: 0x04030E5A RID: 200282
		[Nullable(new byte[]
		{
			0,
			2,
			2,
			2
		})]
		public static Action<Entity, UseSkillNotify, CombatCommon> <9>__UseSkillNotify;

		// Token: 0x04030E5B RID: 200283
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, SkillNotify, CombatCommon> <10>__SkillNotify;

		// Token: 0x04030E5C RID: 200284
		[Nullable(new byte[]
		{
			0,
			2,
			2,
			2
		})]
		public static Action<Entity, EndSkillNotify, CombatCommon> <11>__EndSkillNotify;

		// Token: 0x04030E5D RID: 200285
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, CreateBulletNotify, CombatCommon> <12>__CreateBulletNotify;

		// Token: 0x04030E5E RID: 200286
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, DestroyBulletNotify, CombatCommon> <13>__DestroyBulletNotify;

		// Token: 0x04030E5F RID: 200287
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, ModifyBulletParamsNotify, CombatCommon> <14>__ModifyBulletParamsNotify;

		// Token: 0x04030E60 RID: 200288
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, ApplyGameplayEffectNotify, CombatCommon> <15>__BroadcastAddBuffNotify;

		// Token: 0x04030E61 RID: 200289
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, ApplyBuffFailedNotify, CombatCommon> <16>__BroadcastAddBuffFailedNotify;

		// Token: 0x04030E62 RID: 200290
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, BuffStackCountNotify, CombatCommon> <17>__BroadcastBuffStackChangedNotify;

		// Token: 0x04030E63 RID: 200291
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, RemoveGameplayEffectNotify, CombatCommon> <18>__BroadcastRemoveBuffNotify;

		// Token: 0x04030E64 RID: 200292
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, BuffDurationNotify, CombatCommon> <19>__BuffDurationNotify;

		// Token: 0x04030E65 RID: 200293
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, ApplyBuffS2cRequestNotify, CombatCommon> <20>__OrderAddBuffS2cNotify;

		// Token: 0x04030E66 RID: 200294
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, RemoveBuffS2cRequestNotify, CombatCommon> <21>__OrderRemoveBuffS2cNotify;

		// Token: 0x04030E67 RID: 200295
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, RemoveBuffByIdS2cRequestNotify, CombatCommon> <22>__OrderRemoveBuffByIdS2cNotify;

		// Token: 0x04030E68 RID: 200296
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, RemoveBuffByServerIdS2cRequestNotify, CombatCommon> <23>__OrderRemoveBuffByServerIdNotify;

		// Token: 0x04030E69 RID: 200297
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, OrderApplyBuffNotify, CombatCommon> <24>__OrderAddBuffNotify;

		// Token: 0x04030E6A RID: 200298
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, OrderRemoveBuffNotify, CombatCommon> <25>__OrderRemoveBuffNotify;

		// Token: 0x04030E6B RID: 200299
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, OrderRemoveBuffByTagsNotify, CombatCommon> <26>__OrderRemoveBuffByTagsNotify;

		// Token: 0x04030E6C RID: 200300
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, ActivateBuffNotify, CombatCommon> <27>__BroadcastActivateBuffNotify;

		// Token: 0x04030E6D RID: 200301
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, TransformBuffStackNotify, CombatCommon> <28>__BroadcastTransformBuffStackNotify;

		// Token: 0x04030E6E RID: 200302
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, DamageExecuteNotify, CombatCommon> <29>__OnDamageExecuteNotify;

		// Token: 0x04030E6F RID: 200303
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, GameplayCueNotify, CombatCommon> <30>__GameplayCueNotify;

		// Token: 0x04030E70 RID: 200304
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, AttributeChangedNotify, CombatCommon> <31>__AttributeChangedNotify;

		// Token: 0x04030E71 RID: 200305
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, RecoverPropChangedNotify, CombatCommon> <32>__RecoverPropChangedNotify;

		// Token: 0x04030E72 RID: 200306
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, DamageRecordNotify, CombatCommon> <33>__OnDamageRecordNotify;

		// Token: 0x04030E73 RID: 200307
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, PassiveSkillAddNotify, CombatCommon> <34>__PassiveSkillAddNotify;

		// Token: 0x04030E74 RID: 200308
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, PassiveSkillRemoveNotify, CombatCommon> <35>__PassiveSkillRemoveNotify;

		// Token: 0x04030E75 RID: 200309
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, PlayerBattleStateChangeNotify, CombatCommon> <36>__OnPlayerBattleStateChangeNotify;

		// Token: 0x04030E76 RID: 200310
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, HitNotify, CombatCommon> <37>__HitNotify;

		// Token: 0x04030E77 RID: 200311
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, AiHateNotify, CombatCommon> <38>__AiHateNotify;

		// Token: 0x04030E78 RID: 200312
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, BoneVisibleChangeNotify, CombatCommon> <39>__BoneVisibleChangeNotify;

		// Token: 0x04030E79 RID: 200313
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, AnimationGameplayTagNotify, CombatCommon> <40>__AnimationGameplayTagNotify;

		// Token: 0x04030E7A RID: 200314
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, AnimationStateChangedNotify, CombatCommon> <41>__AnimationStateChangedNotify;

		// Token: 0x04030E7B RID: 200315
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, PackAnimChangedNotify, CombatCommon> <42>__PackAnimChangedNotify;

		// Token: 0x04030E7C RID: 200316
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, AnimationStateInitNotify, CombatCommon> <43>__AnimationStateInitNotify;

		// Token: 0x04030E7D RID: 200317
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, AddCombineEntitiesRelationNotify, CombatCommon> <44>__AddCombineEntitiesRelationNotify;

		// Token: 0x04030E7E RID: 200318
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, RemoveCombineRelationNotify, CombatCommon> <45>__RemoveCombineRelationNotify;

		// Token: 0x04030E7F RID: 200319
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, CaughtNotify, CombatCommon> <46>__CaughtNotify;

		// Token: 0x04030E80 RID: 200320
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, LogicStateInitNotify, CombatCommon> <47>__LogicStateInitNotify;

		// Token: 0x04030E81 RID: 200321
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, SwitchLogicStateNotify, CombatCommon> <48>__SwitchLogicStateNotify;

		// Token: 0x04030E82 RID: 200322
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, PartUpdateNotify, CombatCommon> <49>__PartUpdateNotify;

		// Token: 0x04030E83 RID: 200323
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, PartComponentInitNotify, CombatCommon> <50>__PartComponentInitNotify;

		// Token: 0x04030E84 RID: 200324
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, ShieldUpdateNotify, CombatCommon> <51>__OnShieldUpdateNotify;

		// Token: 0x04030E85 RID: 200325
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, ChangeStateNotify, CombatCommon> <52>__ChangeStateNotify;

		// Token: 0x04030E86 RID: 200326
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, ChangeStateConfirmNotify, CombatCommon> <53>__ChangeStateConfirmNotify;

		// Token: 0x04030E87 RID: 200327
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, FsmResetNotify, CombatCommon> <54>__FsmResetNotify;

		// Token: 0x04030E88 RID: 200328
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, FsmBlackboardNotify, CombatCommon> <55>__FsmBlackboardNotify;

		// Token: 0x04030E89 RID: 200329
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, FsmCustomBlackboardNotify, CombatCommon> <56>__FsmCustomBlackboardNotify;

		// Token: 0x04030E8A RID: 200330
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, FsmMontageDurationNotify, CombatCommon> <57>__FsmMontageDurationNotify;

		// Token: 0x04030E8B RID: 200331
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, VisionTriggerNotify, CombatCommon> <58>__VisionTriggerNotify;

		// Token: 0x04030E8C RID: 200332
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, DrownNotify, CombatCommon> <59>__DrownNotify;

		// Token: 0x04030E8D RID: 200333
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, ExecuteQteNotify, CombatCommon> <60>__ExecuteQteNotify;

		// Token: 0x04030E8E RID: 200334
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, SquadPropChangedNotify, CombatCommon> <61>__SquadPropChangedNotify;

		// Token: 0x04030E8F RID: 200335
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, MotorSummonAndRideNotify, CombatCommon> <62>__MotorSummonAndRideNotify;

		// Token: 0x04030E90 RID: 200336
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, EntityLivingStatusNotify, CombatCommon> <63>__ExecuteEntityLivingStatus;

		// Token: 0x04030E91 RID: 200337
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, ModifyEntityCampNotify, CombatCommon> <64>__OnModifyEntityCampNotify;

		// Token: 0x04030E92 RID: 200338
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Func<Entity, UseSkillNotify, CombatCommon, bool> <65>__PreUseSkillNotify;

		// Token: 0x04030E93 RID: 200339
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Func<Entity, HitNotify, CombatCommon, bool> <66>__PreHitNotify;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.Protocol.Ai;
using Aki.Protocol.Debug;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Module.CombatMessage;
using CSharpScript.Game.NewWorld.Character.Common.Component;

// Token: 0x02002AD8 RID: 10968
public class DecoratorManager
{
	// Token: 0x0601BD0A RID: 113930 RVA: 0x008A4738 File Offset: 0x008A2938
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
		Action<Entity, DamageShowNotify, CombatCommon> callBack13;
		if ((callBack13 = global::DecoratorManager.<>O.<12>__DamageShowNotify) == null)
		{
			callBack13 = (global::DecoratorManager.<>O.<12>__DamageShowNotify = new Action<Entity, DamageShowNotify, CombatCommon>(DamageUiController.DamageShowNotify));
		}
		CombatNet.Listen<DamageShowNotify>(callBack13, ENotifyMessageId.DamageShowNotify, false, false);
		Action<Entity, CreateBulletNotify, CombatCommon> callBack14;
		if ((callBack14 = global::DecoratorManager.<>O.<13>__CreateBulletNotify) == null)
		{
			callBack14 = (global::DecoratorManager.<>O.<13>__CreateBulletNotify = new Action<Entity, CreateBulletNotify, CombatCommon>(BulletController.CreateBulletNotify));
		}
		CombatNet.Listen<CreateBulletNotify>(callBack14, ENotifyMessageId.CreateBulletNotify, true, false);
		Action<Entity, DestroyBulletNotify, CombatCommon> callBack15;
		if ((callBack15 = global::DecoratorManager.<>O.<14>__DestroyBulletNotify) == null)
		{
			callBack15 = (global::DecoratorManager.<>O.<14>__DestroyBulletNotify = new Action<Entity, DestroyBulletNotify, CombatCommon>(BulletController.DestroyBulletNotify));
		}
		CombatNet.Listen<DestroyBulletNotify>(callBack15, ENotifyMessageId.DestroyBulletNotify, true, false);
		Action<Entity, ModifyBulletParamsNotify, CombatCommon> callBack16;
		if ((callBack16 = global::DecoratorManager.<>O.<15>__ModifyBulletParamsNotify) == null)
		{
			callBack16 = (global::DecoratorManager.<>O.<15>__ModifyBulletParamsNotify = new Action<Entity, ModifyBulletParamsNotify, CombatCommon>(BulletController.ModifyBulletParamsNotify));
		}
		CombatNet.Listen<ModifyBulletParamsNotify>(callBack16, ENotifyMessageId.ModifyBulletParamsNotify, true, false);
		Action<Entity, ApplyGameplayEffectNotify, CombatCommon> callBack17;
		if ((callBack17 = global::DecoratorManager.<>O.<16>__BroadcastAddBuffNotify) == null)
		{
			callBack17 = (global::DecoratorManager.<>O.<16>__BroadcastAddBuffNotify = new Action<Entity, ApplyGameplayEffectNotify, CombatCommon>(BaseBuffComponent.BroadcastAddBuffNotify));
		}
		CombatNet.Listen<ApplyGameplayEffectNotify>(callBack17, ENotifyMessageId.ApplyGameplayEffectNotify, false, false);
		Action<Entity, ApplyBuffFailedNotify, CombatCommon> callBack18;
		if ((callBack18 = global::DecoratorManager.<>O.<17>__BroadcastAddBuffFailedNotify) == null)
		{
			callBack18 = (global::DecoratorManager.<>O.<17>__BroadcastAddBuffFailedNotify = new Action<Entity, ApplyBuffFailedNotify, CombatCommon>(BaseBuffComponent.BroadcastAddBuffFailedNotify));
		}
		CombatNet.Listen<ApplyBuffFailedNotify>(callBack18, ENotifyMessageId.ApplyBuffFailedNotify, false, false);
		Action<Entity, BuffStackCountNotify, CombatCommon> callBack19;
		if ((callBack19 = global::DecoratorManager.<>O.<18>__BroadcastBuffStackChangedNotify) == null)
		{
			callBack19 = (global::DecoratorManager.<>O.<18>__BroadcastBuffStackChangedNotify = new Action<Entity, BuffStackCountNotify, CombatCommon>(BaseBuffComponent.BroadcastBuffStackChangedNotify));
		}
		CombatNet.Listen<BuffStackCountNotify>(callBack19, ENotifyMessageId.BuffStackCountNotify, false, false);
		Action<Entity, RemoveGameplayEffectNotify, CombatCommon> callBack20;
		if ((callBack20 = global::DecoratorManager.<>O.<19>__BroadcastRemoveBuffNotify) == null)
		{
			callBack20 = (global::DecoratorManager.<>O.<19>__BroadcastRemoveBuffNotify = new Action<Entity, RemoveGameplayEffectNotify, CombatCommon>(BaseBuffComponent.BroadcastRemoveBuffNotify));
		}
		CombatNet.Listen<RemoveGameplayEffectNotify>(callBack20, ENotifyMessageId.RemoveGameplayEffectNotify, false, false);
		Action<Entity, BuffDurationNotify, CombatCommon> callBack21;
		if ((callBack21 = global::DecoratorManager.<>O.<20>__BuffDurationNotify) == null)
		{
			callBack21 = (global::DecoratorManager.<>O.<20>__BuffDurationNotify = new Action<Entity, BuffDurationNotify, CombatCommon>(BaseBuffComponent.BuffDurationNotify));
		}
		CombatNet.Listen<BuffDurationNotify>(callBack21, ENotifyMessageId.BuffDurationNotify, false, false);
		Action<Entity, ApplyBuffS2cRequestNotify, CombatCommon> callBack22;
		if ((callBack22 = global::DecoratorManager.<>O.<21>__OrderAddBuffS2cNotify) == null)
		{
			callBack22 = (global::DecoratorManager.<>O.<21>__OrderAddBuffS2cNotify = new Action<Entity, ApplyBuffS2cRequestNotify, CombatCommon>(BaseBuffComponent.OrderAddBuffS2cNotify));
		}
		CombatNet.Listen<ApplyBuffS2cRequestNotify>(callBack22, ENotifyMessageId.ApplyBuffS2cRequestNotify, false, true);
		Action<Entity, RemoveBuffS2cRequestNotify, CombatCommon> callBack23;
		if ((callBack23 = global::DecoratorManager.<>O.<22>__OrderRemoveBuffS2cNotify) == null)
		{
			callBack23 = (global::DecoratorManager.<>O.<22>__OrderRemoveBuffS2cNotify = new Action<Entity, RemoveBuffS2cRequestNotify, CombatCommon>(BaseBuffComponent.OrderRemoveBuffS2cNotify));
		}
		CombatNet.Listen<RemoveBuffS2cRequestNotify>(callBack23, ENotifyMessageId.RemoveBuffS2cRequestNotify, false, false);
		Action<Entity, RemoveBuffByIdS2cRequestNotify, CombatCommon> callBack24;
		if ((callBack24 = global::DecoratorManager.<>O.<23>__OrderRemoveBuffByIdS2cNotify) == null)
		{
			callBack24 = (global::DecoratorManager.<>O.<23>__OrderRemoveBuffByIdS2cNotify = new Action<Entity, RemoveBuffByIdS2cRequestNotify, CombatCommon>(BaseBuffComponent.OrderRemoveBuffByIdS2cNotify));
		}
		CombatNet.Listen<RemoveBuffByIdS2cRequestNotify>(callBack24, ENotifyMessageId.RemoveBuffByIdS2cRequestNotify, false, false);
		Action<Entity, RemoveBuffByServerIdS2cRequestNotify, CombatCommon> callBack25;
		if ((callBack25 = global::DecoratorManager.<>O.<24>__OrderRemoveBuffByServerIdNotify) == null)
		{
			callBack25 = (global::DecoratorManager.<>O.<24>__OrderRemoveBuffByServerIdNotify = new Action<Entity, RemoveBuffByServerIdS2cRequestNotify, CombatCommon>(BaseBuffComponent.OrderRemoveBuffByServerIdNotify));
		}
		CombatNet.Listen<RemoveBuffByServerIdS2cRequestNotify>(callBack25, ENotifyMessageId.RemoveBuffByServerIdS2cRequestNotify, false, false);
		Action<Entity, OrderApplyBuffNotify, CombatCommon> callBack26;
		if ((callBack26 = global::DecoratorManager.<>O.<25>__OrderAddBuffNotify) == null)
		{
			callBack26 = (global::DecoratorManager.<>O.<25>__OrderAddBuffNotify = new Action<Entity, OrderApplyBuffNotify, CombatCommon>(BaseBuffComponent.OrderAddBuffNotify));
		}
		CombatNet.Listen<OrderApplyBuffNotify>(callBack26, ENotifyMessageId.OrderApplyBuffNotify, false, false);
		Action<Entity, OrderRemoveBuffNotify, CombatCommon> callBack27;
		if ((callBack27 = global::DecoratorManager.<>O.<26>__OrderRemoveBuffNotify) == null)
		{
			callBack27 = (global::DecoratorManager.<>O.<26>__OrderRemoveBuffNotify = new Action<Entity, OrderRemoveBuffNotify, CombatCommon>(BaseBuffComponent.OrderRemoveBuffNotify));
		}
		CombatNet.Listen<OrderRemoveBuffNotify>(callBack27, ENotifyMessageId.OrderRemoveBuffNotify, false, false);
		Action<Entity, OrderRemoveBuffByTagsNotify, CombatCommon> callBack28;
		if ((callBack28 = global::DecoratorManager.<>O.<27>__OrderRemoveBuffByTagsNotify) == null)
		{
			callBack28 = (global::DecoratorManager.<>O.<27>__OrderRemoveBuffByTagsNotify = new Action<Entity, OrderRemoveBuffByTagsNotify, CombatCommon>(BaseBuffComponent.OrderRemoveBuffByTagsNotify));
		}
		CombatNet.Listen<OrderRemoveBuffByTagsNotify>(callBack28, ENotifyMessageId.OrderRemoveBuffByTagsNotify, false, false);
		Action<Entity, ActivateBuffNotify, CombatCommon> callBack29;
		if ((callBack29 = global::DecoratorManager.<>O.<28>__BroadcastActivateBuffNotify) == null)
		{
			callBack29 = (global::DecoratorManager.<>O.<28>__BroadcastActivateBuffNotify = new Action<Entity, ActivateBuffNotify, CombatCommon>(BaseBuffComponent.BroadcastActivateBuffNotify));
		}
		CombatNet.Listen<ActivateBuffNotify>(callBack29, ENotifyMessageId.ActivateBuffNotify, false, false);
		Action<Entity, TransformBuffStackNotify, CombatCommon> callBack30;
		if ((callBack30 = global::DecoratorManager.<>O.<29>__BroadcastTransformBuffStackNotify) == null)
		{
			callBack30 = (global::DecoratorManager.<>O.<29>__BroadcastTransformBuffStackNotify = new Action<Entity, TransformBuffStackNotify, CombatCommon>(BaseBuffComponent.BroadcastTransformBuffStackNotify));
		}
		CombatNet.Listen<TransformBuffStackNotify>(callBack30, ENotifyMessageId.TransformBuffStackNotify, false, false);
		Action<Entity, DamageExecuteNotify, CombatCommon> callBack31;
		if ((callBack31 = global::DecoratorManager.<>O.<30>__OnDamageExecuteNotify) == null)
		{
			callBack31 = (global::DecoratorManager.<>O.<30>__OnDamageExecuteNotify = new Action<Entity, DamageExecuteNotify, CombatCommon>(BaseDamageComponent.OnDamageExecuteNotify));
		}
		CombatNet.Listen<DamageExecuteNotify>(callBack31, ENotifyMessageId.DamageExecuteNotify, false, false);
		Action<Entity, GameplayCueNotify, CombatCommon> callBack32;
		if ((callBack32 = global::DecoratorManager.<>O.<31>__GameplayCueNotify) == null)
		{
			callBack32 = (global::DecoratorManager.<>O.<31>__GameplayCueNotify = new Action<Entity, GameplayCueNotify, CombatCommon>(BaseGameplayCueComponent.GameplayCueNotify));
		}
		CombatNet.Listen<GameplayCueNotify>(callBack32, ENotifyMessageId.GameplayCueNotify, true, false);
		Action<Entity, AttributeChangedNotify, CombatCommon> callBack33;
		if ((callBack33 = global::DecoratorManager.<>O.<32>__AttributeChangedNotify) == null)
		{
			callBack33 = (global::DecoratorManager.<>O.<32>__AttributeChangedNotify = new Action<Entity, AttributeChangedNotify, CombatCommon>(CharacterAttributeComponent.AttributeChangedNotify));
		}
		CombatNet.Listen<AttributeChangedNotify>(callBack33, ENotifyMessageId.AttributeChangedNotify, true, false);
		Action<Entity, RecoverPropChangedNotify, CombatCommon> callBack34;
		if ((callBack34 = global::DecoratorManager.<>O.<33>__RecoverPropChangedNotify) == null)
		{
			callBack34 = (global::DecoratorManager.<>O.<33>__RecoverPropChangedNotify = new Action<Entity, RecoverPropChangedNotify, CombatCommon>(CharacterAttributeComponent.RecoverPropChangedNotify));
		}
		CombatNet.Listen<RecoverPropChangedNotify>(callBack34, ENotifyMessageId.RecoverPropChangedNotify, true, false);
		Action<Entity, DamageRecordNotify, CombatCommon> callBack35;
		if ((callBack35 = global::DecoratorManager.<>O.<34>__OnDamageRecordNotify) == null)
		{
			callBack35 = (global::DecoratorManager.<>O.<34>__OnDamageRecordNotify = new Action<Entity, DamageRecordNotify, CombatCommon>(CharacterGasDebugComponent.OnDamageRecordNotify));
		}
		CombatNet.Listen<DamageRecordNotify>(callBack35, ENotifyMessageId.DamageRecordNotify, true, false);
		Action<Entity, PassiveSkillAddNotify, CombatCommon> callBack36;
		if ((callBack36 = global::DecoratorManager.<>O.<35>__PassiveSkillAddNotify) == null)
		{
			callBack36 = (global::DecoratorManager.<>O.<35>__PassiveSkillAddNotify = new Action<Entity, PassiveSkillAddNotify, CombatCommon>(CharacterPassiveSkillComponent.PassiveSkillAddNotify));
		}
		CombatNet.Listen<PassiveSkillAddNotify>(callBack36, ENotifyMessageId.PassiveSkillAddNotify, false, false);
		Action<Entity, PassiveSkillRemoveNotify, CombatCommon> callBack37;
		if ((callBack37 = global::DecoratorManager.<>O.<36>__PassiveSkillRemoveNotify) == null)
		{
			callBack37 = (global::DecoratorManager.<>O.<36>__PassiveSkillRemoveNotify = new Action<Entity, PassiveSkillRemoveNotify, CombatCommon>(CharacterPassiveSkillComponent.PassiveSkillRemoveNotify));
		}
		CombatNet.Listen<PassiveSkillRemoveNotify>(callBack37, ENotifyMessageId.PassiveSkillRemoveNotify, false, false);
		Action<Entity, PlayerBattleStateChangeNotify, CombatCommon> callBack38;
		if ((callBack38 = global::DecoratorManager.<>O.<37>__OnPlayerBattleStateChangeNotify) == null)
		{
			callBack38 = (global::DecoratorManager.<>O.<37>__OnPlayerBattleStateChangeNotify = new Action<Entity, PlayerBattleStateChangeNotify, CombatCommon>(CharacterUnifiedStateComponent.OnPlayerBattleStateChangeNotify));
		}
		CombatNet.Listen<PlayerBattleStateChangeNotify>(callBack38, ENotifyMessageId.PlayerBattleStateChangeNotify, false, false);
		Action<Entity, HitNotify, CombatCommon> callBack39;
		if ((callBack39 = global::DecoratorManager.<>O.<38>__HitNotify) == null)
		{
			callBack39 = (global::DecoratorManager.<>O.<38>__HitNotify = new Action<Entity, HitNotify, CombatCommon>(BaseHitComponent.HitNotify));
		}
		CombatNet.Listen<HitNotify>(callBack39, ENotifyMessageId.HitNotify, true, false);
		Action<Entity, AiHateNotify, CombatCommon> callBack40;
		if ((callBack40 = global::DecoratorManager.<>O.<39>__AiHateNotify) == null)
		{
			callBack40 = (global::DecoratorManager.<>O.<39>__AiHateNotify = new Action<Entity, AiHateNotify, CombatCommon>(CharacterAiComponent.AiHateNotify));
		}
		CombatNet.Listen<AiHateNotify>(callBack40, ENotifyMessageId.AiHateNotify, true, false);
		Action<Entity, BoneVisibleChangeNotify, CombatCommon> callBack41;
		if ((callBack41 = global::DecoratorManager.<>O.<40>__BoneVisibleChangeNotify) == null)
		{
			callBack41 = (global::DecoratorManager.<>O.<40>__BoneVisibleChangeNotify = new Action<Entity, BoneVisibleChangeNotify, CombatCommon>(CharacterAnimationComponent.BoneVisibleChangeNotify));
		}
		CombatNet.Listen<BoneVisibleChangeNotify>(callBack41, ENotifyMessageId.BoneVisibleChangeNotify, true, false);
		Action<Entity, AnimationGameplayTagNotify, CombatCommon> callBack42;
		if ((callBack42 = global::DecoratorManager.<>O.<41>__AnimationGameplayTagNotify) == null)
		{
			callBack42 = (global::DecoratorManager.<>O.<41>__AnimationGameplayTagNotify = new Action<Entity, AnimationGameplayTagNotify, CombatCommon>(CharacterAnimationSyncComponent.AnimationGameplayTagNotify));
		}
		CombatNet.Listen<AnimationGameplayTagNotify>(callBack42, ENotifyMessageId.AnimationGameplayTagNotify, true, false);
		Action<Entity, AnimationStateChangedNotify, CombatCommon> callBack43;
		if ((callBack43 = global::DecoratorManager.<>O.<42>__AnimationStateChangedNotify) == null)
		{
			callBack43 = (global::DecoratorManager.<>O.<42>__AnimationStateChangedNotify = new Action<Entity, AnimationStateChangedNotify, CombatCommon>(CharacterAnimationSyncComponent.AnimationStateChangedNotify));
		}
		CombatNet.Listen<AnimationStateChangedNotify>(callBack43, ENotifyMessageId.AnimationStateChangedNotify, true, false);
		Action<Entity, PackAnimChangedNotify, CombatCommon> callBack44;
		if ((callBack44 = global::DecoratorManager.<>O.<43>__PackAnimChangedNotify) == null)
		{
			callBack44 = (global::DecoratorManager.<>O.<43>__PackAnimChangedNotify = new Action<Entity, PackAnimChangedNotify, CombatCommon>(CharacterAnimationSyncComponent.PackAnimChangedNotify));
		}
		CombatNet.Listen<PackAnimChangedNotify>(callBack44, ENotifyMessageId.PackAnimChangedNotify, false, false);
		Action<Entity, AnimationStateInitNotify, CombatCommon> callBack45;
		if ((callBack45 = global::DecoratorManager.<>O.<44>__AnimationStateInitNotify) == null)
		{
			callBack45 = (global::DecoratorManager.<>O.<44>__AnimationStateInitNotify = new Action<Entity, AnimationStateInitNotify, CombatCommon>(CharacterAnimationSyncComponent.AnimationStateInitNotify));
		}
		CombatNet.Listen<AnimationStateInitNotify>(callBack45, ENotifyMessageId.AnimationStateInitNotify, false, false);
		Action<Entity, AddCombineEntitiesRelationNotify, CombatCommon> callBack46;
		if ((callBack46 = global::DecoratorManager.<>O.<45>__AddCombineEntitiesRelationNotify) == null)
		{
			callBack46 = (global::DecoratorManager.<>O.<45>__AddCombineEntitiesRelationNotify = new Action<Entity, AddCombineEntitiesRelationNotify, CombatCommon>(CharacterAttachComponent.AddCombineEntitiesRelationNotify));
		}
		CombatNet.Listen<AddCombineEntitiesRelationNotify>(callBack46, ENotifyMessageId.AddCombineEntitiesRelationNotify, true, false);
		Action<Entity, RemoveCombineRelationNotify, CombatCommon> callBack47;
		if ((callBack47 = global::DecoratorManager.<>O.<46>__RemoveCombineRelationNotify) == null)
		{
			callBack47 = (global::DecoratorManager.<>O.<46>__RemoveCombineRelationNotify = new Action<Entity, RemoveCombineRelationNotify, CombatCommon>(CharacterAttachComponent.RemoveCombineRelationNotify));
		}
		CombatNet.Listen<RemoveCombineRelationNotify>(callBack47, ENotifyMessageId.RemoveCombineRelationNotify, true, false);
		Action<Entity, CaughtNotify, CombatCommon> callBack48;
		if ((callBack48 = global::DecoratorManager.<>O.<47>__CaughtNotify) == null)
		{
			callBack48 = (global::DecoratorManager.<>O.<47>__CaughtNotify = new Action<Entity, CaughtNotify, CombatCommon>(CharacterCaughtNewComponent.CaughtNotify));
		}
		CombatNet.Listen<CaughtNotify>(callBack48, ENotifyMessageId.CaughtNotify, true, false);
		Action<Entity, LogicStateInitNotify, CombatCommon> callBack49;
		if ((callBack49 = global::DecoratorManager.<>O.<48>__LogicStateInitNotify) == null)
		{
			callBack49 = (global::DecoratorManager.<>O.<48>__LogicStateInitNotify = new Action<Entity, LogicStateInitNotify, CombatCommon>(CharacterLogicStateSyncComponent.LogicStateInitNotify));
		}
		CombatNet.Listen<LogicStateInitNotify>(callBack49, ENotifyMessageId.LogicStateInitNotify, true, false);
		Action<Entity, SwitchLogicStateNotify, CombatCommon> callBack50;
		if ((callBack50 = global::DecoratorManager.<>O.<49>__SwitchLogicStateNotify) == null)
		{
			callBack50 = (global::DecoratorManager.<>O.<49>__SwitchLogicStateNotify = new Action<Entity, SwitchLogicStateNotify, CombatCommon>(CharacterLogicStateSyncComponent.SwitchLogicStateNotify));
		}
		CombatNet.Listen<SwitchLogicStateNotify>(callBack50, ENotifyMessageId.SwitchLogicStateNotify, true, false);
		Action<Entity, PartUpdateNotify, CombatCommon> callBack51;
		if ((callBack51 = global::DecoratorManager.<>O.<50>__PartUpdateNotify) == null)
		{
			callBack51 = (global::DecoratorManager.<>O.<50>__PartUpdateNotify = new Action<Entity, PartUpdateNotify, CombatCommon>(CharacterPartComponent.PartUpdateNotify));
		}
		CombatNet.Listen<PartUpdateNotify>(callBack51, ENotifyMessageId.PartUpdateNotify, false, false);
		Action<Entity, PartComponentInitNotify, CombatCommon> callBack52;
		if ((callBack52 = global::DecoratorManager.<>O.<51>__PartComponentInitNotify) == null)
		{
			callBack52 = (global::DecoratorManager.<>O.<51>__PartComponentInitNotify = new Action<Entity, PartComponentInitNotify, CombatCommon>(CharacterPartComponent.PartComponentInitNotify));
		}
		CombatNet.Listen<PartComponentInitNotify>(callBack52, ENotifyMessageId.PartComponentInitNotify, false, false);
		Action<Entity, ShieldUpdateNotify, CombatCommon> callBack53;
		if ((callBack53 = global::DecoratorManager.<>O.<52>__OnShieldUpdateNotify) == null)
		{
			callBack53 = (global::DecoratorManager.<>O.<52>__OnShieldUpdateNotify = new Action<Entity, ShieldUpdateNotify, CombatCommon>(CharacterShieldComponent.OnShieldUpdateNotify));
		}
		CombatNet.Listen<ShieldUpdateNotify>(callBack53, ENotifyMessageId.ShieldUpdateNotify, false, false);
		Action<Entity, ChangeStateNotify, CombatCommon> callBack54;
		if ((callBack54 = global::DecoratorManager.<>O.<53>__ChangeStateNotify) == null)
		{
			callBack54 = (global::DecoratorManager.<>O.<53>__ChangeStateNotify = new Action<Entity, ChangeStateNotify, CombatCommon>(CharacterStateMachineNewComponent.ChangeStateNotify));
		}
		CombatNet.Listen<ChangeStateNotify>(callBack54, ENotifyMessageId.ChangeStateNotify, true, false);
		Action<Entity, ChangeStateConfirmNotify, CombatCommon> callBack55;
		if ((callBack55 = global::DecoratorManager.<>O.<54>__ChangeStateConfirmNotify) == null)
		{
			callBack55 = (global::DecoratorManager.<>O.<54>__ChangeStateConfirmNotify = new Action<Entity, ChangeStateConfirmNotify, CombatCommon>(CharacterStateMachineNewComponent.ChangeStateConfirmNotify));
		}
		CombatNet.Listen<ChangeStateConfirmNotify>(callBack55, ENotifyMessageId.ChangeStateConfirmNotify, true, false);
		Action<Entity, FsmResetNotify, CombatCommon> callBack56;
		if ((callBack56 = global::DecoratorManager.<>O.<55>__FsmResetNotify) == null)
		{
			callBack56 = (global::DecoratorManager.<>O.<55>__FsmResetNotify = new Action<Entity, FsmResetNotify, CombatCommon>(CharacterStateMachineNewComponent.FsmResetNotify));
		}
		CombatNet.Listen<FsmResetNotify>(callBack56, ENotifyMessageId.FsmResetNotify, true, false);
		Action<Entity, FsmBlackboardNotify, CombatCommon> callBack57;
		if ((callBack57 = global::DecoratorManager.<>O.<56>__FsmBlackboardNotify) == null)
		{
			callBack57 = (global::DecoratorManager.<>O.<56>__FsmBlackboardNotify = new Action<Entity, FsmBlackboardNotify, CombatCommon>(CharacterStateMachineNewComponent.FsmBlackboardNotify));
		}
		CombatNet.Listen<FsmBlackboardNotify>(callBack57, ENotifyMessageId.FsmBlackboardNotify, true, false);
		Action<Entity, FsmCustomBlackboardNotify, CombatCommon> callBack58;
		if ((callBack58 = global::DecoratorManager.<>O.<57>__FsmCustomBlackboardNotify) == null)
		{
			callBack58 = (global::DecoratorManager.<>O.<57>__FsmCustomBlackboardNotify = new Action<Entity, FsmCustomBlackboardNotify, CombatCommon>(CharacterStateMachineNewComponent.FsmCustomBlackboardNotify));
		}
		CombatNet.Listen<FsmCustomBlackboardNotify>(callBack58, ENotifyMessageId.FsmCustomBlackboardNotify, true, false);
		Action<Entity, FsmMontageDurationNotify, CombatCommon> callBack59;
		if ((callBack59 = global::DecoratorManager.<>O.<58>__FsmMontageDurationNotify) == null)
		{
			callBack59 = (global::DecoratorManager.<>O.<58>__FsmMontageDurationNotify = new Action<Entity, FsmMontageDurationNotify, CombatCommon>(CharacterStateMachineNewComponent.FsmMontageDurationNotify));
		}
		CombatNet.Listen<FsmMontageDurationNotify>(callBack59, ENotifyMessageId.FsmMontageDurationNotify, true, false);
		Action<Entity, VisionTriggerNotify, CombatCommon> callBack60;
		if ((callBack60 = global::DecoratorManager.<>O.<59>__VisionTriggerNotify) == null)
		{
			callBack60 = (global::DecoratorManager.<>O.<59>__VisionTriggerNotify = new Action<Entity, VisionTriggerNotify, CombatCommon>(CharacterVisionComponent.VisionTriggerNotify));
		}
		CombatNet.Listen<VisionTriggerNotify>(callBack60, ENotifyMessageId.VisionTriggerNotify, true, false);
		Action<Entity, DrownNotify, CombatCommon> callBack61;
		if ((callBack61 = global::DecoratorManager.<>O.<60>__DrownNotify) == null)
		{
			callBack61 = (global::DecoratorManager.<>O.<60>__DrownNotify = new Action<Entity, DrownNotify, CombatCommon>(RoleDeathComponent.DrownNotify));
		}
		CombatNet.Listen<DrownNotify>(callBack61, ENotifyMessageId.DrownNotify, true, false);
		Action<Entity, ExecuteQteNotify, CombatCommon> callBack62;
		if ((callBack62 = global::DecoratorManager.<>O.<61>__ExecuteQteNotify) == null)
		{
			callBack62 = (global::DecoratorManager.<>O.<61>__ExecuteQteNotify = new Action<Entity, ExecuteQteNotify, CombatCommon>(RoleQteComponent.ExecuteQteNotify));
		}
		CombatNet.Listen<ExecuteQteNotify>(callBack62, ENotifyMessageId.ExecuteQteNotify, true, false);
		Action<Entity, SquadPropChangedNotify, CombatCommon> callBack63;
		if ((callBack63 = global::DecoratorManager.<>O.<62>__SquadPropChangedNotify) == null)
		{
			callBack63 = (global::DecoratorManager.<>O.<62>__SquadPropChangedNotify = new Action<Entity, SquadPropChangedNotify, CombatCommon>(SquadPropComponent.SquadPropChangedNotify));
		}
		CombatNet.Listen<SquadPropChangedNotify>(callBack63, ENotifyMessageId.SquadPropChangedNotify, true, false);
		Action<Entity, MotorSummonAndRideNotify, CombatCommon> callBack64;
		if ((callBack64 = global::DecoratorManager.<>O.<63>__MotorSummonAndRideNotify) == null)
		{
			callBack64 = (global::DecoratorManager.<>O.<63>__MotorSummonAndRideNotify = new Action<Entity, MotorSummonAndRideNotify, CombatCommon>(VehicleController.MotorSummonAndRideNotify));
		}
		CombatNet.Listen<MotorSummonAndRideNotify>(callBack64, ENotifyMessageId.MotorSummonAndRideNotify, true, false);
		Action<Entity, EntityLivingStatusNotify, CombatCommon> callBack65;
		if ((callBack65 = global::DecoratorManager.<>O.<64>__ExecuteEntityLivingStatus) == null)
		{
			callBack65 = (global::DecoratorManager.<>O.<64>__ExecuteEntityLivingStatus = new Action<Entity, EntityLivingStatusNotify, CombatCommon>(BattleLogicController.ExecuteEntityLivingStatus));
		}
		CombatNet.Listen<EntityLivingStatusNotify>(callBack65, ENotifyMessageId.EntityLivingStatusNotify, true, false);
		Action<Entity, ModifyEntityCampNotify, CombatCommon> callBack66;
		if ((callBack66 = global::DecoratorManager.<>O.<65>__OnModifyEntityCampNotify) == null)
		{
			callBack66 = (global::DecoratorManager.<>O.<65>__OnModifyEntityCampNotify = new Action<Entity, ModifyEntityCampNotify, CombatCommon>(CreatureController.OnModifyEntityCampNotify));
		}
		CombatNet.Listen<ModifyEntityCampNotify>(callBack66, ENotifyMessageId.ModifyEntityCampNotify, false, false);
		Func<Entity, UseSkillNotify, CombatCommon, bool> callBack67;
		if ((callBack67 = global::DecoratorManager.<>O.<66>__PreUseSkillNotify) == null)
		{
			callBack67 = (global::DecoratorManager.<>O.<66>__PreUseSkillNotify = new Func<Entity, UseSkillNotify, CombatCommon, bool>(SkillMessageController.PreUseSkillNotify));
		}
		CombatNet.Preprocess<UseSkillNotify>(callBack67, ENotifyMessageId.UseSkillNotify);
		Func<Entity, HitNotify, CombatCommon, bool> callBack68;
		if ((callBack68 = global::DecoratorManager.<>O.<67>__PreHitNotify) == null)
		{
			callBack68 = (global::DecoratorManager.<>O.<67>__PreHitNotify = new Func<Entity, HitNotify, CombatCommon, bool>(BaseHitComponent.PreHitNotify));
		}
		CombatNet.Preprocess<HitNotify>(callBack68, ENotifyMessageId.HitNotify);
		return true;
	}

	// Token: 0x02008BE4 RID: 35812
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402C4D4 RID: 181460
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, AiInformationNotify, CombatCommon> <0>__AiInformationNotify;

		// Token: 0x0402C4D5 RID: 181461
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, AiBlackboardCdNotify, CombatCommon> <1>__AiInformationS;

		// Token: 0x0402C4D6 RID: 181462
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, NewLinkNotify, CombatCommon> <2>__OnNewLinkStateNotify;

		// Token: 0x0402C4D7 RID: 181463
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, EntityIsVisibleNotify, CombatCommon> <3>__EntityIsVisibleNotify;

		// Token: 0x0402C4D8 RID: 181464
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, ActorVisibleNotify, CombatCommon> <4>__ActorIsVisibleNotify;

		// Token: 0x0402C4D9 RID: 181465
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, EntityLoadCompleteNotify, CombatCommon> <5>__EntityLoadCompleteNotify;

		// Token: 0x0402C4DA RID: 181466
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, PlayerRebackSceneNotify, CombatCommon> <6>__PlayerRebackSceneNotify;

		// Token: 0x0402C4DB RID: 181467
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, MaterialNotify, CombatCommon> <7>__MaterialNotify;

		// Token: 0x0402C4DC RID: 181468
		[Nullable(new byte[]
		{
			0,
			2,
			2,
			2
		})]
		public static Action<Entity, EntityStaticHookMoveNotify, CombatCommon> <8>__OnHookMoveNotify;

		// Token: 0x0402C4DD RID: 181469
		[Nullable(new byte[]
		{
			0,
			2,
			2,
			2
		})]
		public static Action<Entity, UseSkillNotify, CombatCommon> <9>__UseSkillNotify;

		// Token: 0x0402C4DE RID: 181470
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, SkillNotify, CombatCommon> <10>__SkillNotify;

		// Token: 0x0402C4DF RID: 181471
		[Nullable(new byte[]
		{
			0,
			2,
			2,
			2
		})]
		public static Action<Entity, EndSkillNotify, CombatCommon> <11>__EndSkillNotify;

		// Token: 0x0402C4E0 RID: 181472
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, DamageShowNotify, CombatCommon> <12>__DamageShowNotify;

		// Token: 0x0402C4E1 RID: 181473
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, CreateBulletNotify, CombatCommon> <13>__CreateBulletNotify;

		// Token: 0x0402C4E2 RID: 181474
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, DestroyBulletNotify, CombatCommon> <14>__DestroyBulletNotify;

		// Token: 0x0402C4E3 RID: 181475
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, ModifyBulletParamsNotify, CombatCommon> <15>__ModifyBulletParamsNotify;

		// Token: 0x0402C4E4 RID: 181476
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, ApplyGameplayEffectNotify, CombatCommon> <16>__BroadcastAddBuffNotify;

		// Token: 0x0402C4E5 RID: 181477
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, ApplyBuffFailedNotify, CombatCommon> <17>__BroadcastAddBuffFailedNotify;

		// Token: 0x0402C4E6 RID: 181478
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, BuffStackCountNotify, CombatCommon> <18>__BroadcastBuffStackChangedNotify;

		// Token: 0x0402C4E7 RID: 181479
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, RemoveGameplayEffectNotify, CombatCommon> <19>__BroadcastRemoveBuffNotify;

		// Token: 0x0402C4E8 RID: 181480
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, BuffDurationNotify, CombatCommon> <20>__BuffDurationNotify;

		// Token: 0x0402C4E9 RID: 181481
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, ApplyBuffS2cRequestNotify, CombatCommon> <21>__OrderAddBuffS2cNotify;

		// Token: 0x0402C4EA RID: 181482
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, RemoveBuffS2cRequestNotify, CombatCommon> <22>__OrderRemoveBuffS2cNotify;

		// Token: 0x0402C4EB RID: 181483
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, RemoveBuffByIdS2cRequestNotify, CombatCommon> <23>__OrderRemoveBuffByIdS2cNotify;

		// Token: 0x0402C4EC RID: 181484
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, RemoveBuffByServerIdS2cRequestNotify, CombatCommon> <24>__OrderRemoveBuffByServerIdNotify;

		// Token: 0x0402C4ED RID: 181485
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, OrderApplyBuffNotify, CombatCommon> <25>__OrderAddBuffNotify;

		// Token: 0x0402C4EE RID: 181486
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, OrderRemoveBuffNotify, CombatCommon> <26>__OrderRemoveBuffNotify;

		// Token: 0x0402C4EF RID: 181487
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, OrderRemoveBuffByTagsNotify, CombatCommon> <27>__OrderRemoveBuffByTagsNotify;

		// Token: 0x0402C4F0 RID: 181488
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, ActivateBuffNotify, CombatCommon> <28>__BroadcastActivateBuffNotify;

		// Token: 0x0402C4F1 RID: 181489
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, TransformBuffStackNotify, CombatCommon> <29>__BroadcastTransformBuffStackNotify;

		// Token: 0x0402C4F2 RID: 181490
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, DamageExecuteNotify, CombatCommon> <30>__OnDamageExecuteNotify;

		// Token: 0x0402C4F3 RID: 181491
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, GameplayCueNotify, CombatCommon> <31>__GameplayCueNotify;

		// Token: 0x0402C4F4 RID: 181492
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, AttributeChangedNotify, CombatCommon> <32>__AttributeChangedNotify;

		// Token: 0x0402C4F5 RID: 181493
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, RecoverPropChangedNotify, CombatCommon> <33>__RecoverPropChangedNotify;

		// Token: 0x0402C4F6 RID: 181494
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, DamageRecordNotify, CombatCommon> <34>__OnDamageRecordNotify;

		// Token: 0x0402C4F7 RID: 181495
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, PassiveSkillAddNotify, CombatCommon> <35>__PassiveSkillAddNotify;

		// Token: 0x0402C4F8 RID: 181496
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, PassiveSkillRemoveNotify, CombatCommon> <36>__PassiveSkillRemoveNotify;

		// Token: 0x0402C4F9 RID: 181497
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, PlayerBattleStateChangeNotify, CombatCommon> <37>__OnPlayerBattleStateChangeNotify;

		// Token: 0x0402C4FA RID: 181498
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, HitNotify, CombatCommon> <38>__HitNotify;

		// Token: 0x0402C4FB RID: 181499
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, AiHateNotify, CombatCommon> <39>__AiHateNotify;

		// Token: 0x0402C4FC RID: 181500
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, BoneVisibleChangeNotify, CombatCommon> <40>__BoneVisibleChangeNotify;

		// Token: 0x0402C4FD RID: 181501
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, AnimationGameplayTagNotify, CombatCommon> <41>__AnimationGameplayTagNotify;

		// Token: 0x0402C4FE RID: 181502
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, AnimationStateChangedNotify, CombatCommon> <42>__AnimationStateChangedNotify;

		// Token: 0x0402C4FF RID: 181503
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, PackAnimChangedNotify, CombatCommon> <43>__PackAnimChangedNotify;

		// Token: 0x0402C500 RID: 181504
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, AnimationStateInitNotify, CombatCommon> <44>__AnimationStateInitNotify;

		// Token: 0x0402C501 RID: 181505
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, AddCombineEntitiesRelationNotify, CombatCommon> <45>__AddCombineEntitiesRelationNotify;

		// Token: 0x0402C502 RID: 181506
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, RemoveCombineRelationNotify, CombatCommon> <46>__RemoveCombineRelationNotify;

		// Token: 0x0402C503 RID: 181507
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, CaughtNotify, CombatCommon> <47>__CaughtNotify;

		// Token: 0x0402C504 RID: 181508
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, LogicStateInitNotify, CombatCommon> <48>__LogicStateInitNotify;

		// Token: 0x0402C505 RID: 181509
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, SwitchLogicStateNotify, CombatCommon> <49>__SwitchLogicStateNotify;

		// Token: 0x0402C506 RID: 181510
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, PartUpdateNotify, CombatCommon> <50>__PartUpdateNotify;

		// Token: 0x0402C507 RID: 181511
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, PartComponentInitNotify, CombatCommon> <51>__PartComponentInitNotify;

		// Token: 0x0402C508 RID: 181512
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, ShieldUpdateNotify, CombatCommon> <52>__OnShieldUpdateNotify;

		// Token: 0x0402C509 RID: 181513
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, ChangeStateNotify, CombatCommon> <53>__ChangeStateNotify;

		// Token: 0x0402C50A RID: 181514
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, ChangeStateConfirmNotify, CombatCommon> <54>__ChangeStateConfirmNotify;

		// Token: 0x0402C50B RID: 181515
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, FsmResetNotify, CombatCommon> <55>__FsmResetNotify;

		// Token: 0x0402C50C RID: 181516
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, FsmBlackboardNotify, CombatCommon> <56>__FsmBlackboardNotify;

		// Token: 0x0402C50D RID: 181517
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, FsmCustomBlackboardNotify, CombatCommon> <57>__FsmCustomBlackboardNotify;

		// Token: 0x0402C50E RID: 181518
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, FsmMontageDurationNotify, CombatCommon> <58>__FsmMontageDurationNotify;

		// Token: 0x0402C50F RID: 181519
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, VisionTriggerNotify, CombatCommon> <59>__VisionTriggerNotify;

		// Token: 0x0402C510 RID: 181520
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, DrownNotify, CombatCommon> <60>__DrownNotify;

		// Token: 0x0402C511 RID: 181521
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, ExecuteQteNotify, CombatCommon> <61>__ExecuteQteNotify;

		// Token: 0x0402C512 RID: 181522
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, SquadPropChangedNotify, CombatCommon> <62>__SquadPropChangedNotify;

		// Token: 0x0402C513 RID: 181523
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, MotorSummonAndRideNotify, CombatCommon> <63>__MotorSummonAndRideNotify;

		// Token: 0x0402C514 RID: 181524
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, EntityLivingStatusNotify, CombatCommon> <64>__ExecuteEntityLivingStatus;

		// Token: 0x0402C515 RID: 181525
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Action<Entity, ModifyEntityCampNotify, CombatCommon> <65>__OnModifyEntityCampNotify;

		// Token: 0x0402C516 RID: 181526
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Func<Entity, UseSkillNotify, CombatCommon, bool> <66>__PreUseSkillNotify;

		// Token: 0x0402C517 RID: 181527
		[Nullable(new byte[]
		{
			0,
			2,
			1,
			2
		})]
		public static Func<Entity, HitNotify, CombatCommon, bool> <67>__PreHitNotify;
	}
}

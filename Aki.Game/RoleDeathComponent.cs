using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.Roverlike;
using CSharpScript.Game.Module.DeadRevive;
using CSharpScript.Game.Module.Teleport;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x020027AA RID: 10154
[NullableContext(2)]
[Nullable(0)]
public class RoleDeathComponent : BaseDeathComponent
{
	// Token: 0x06019789 RID: 104329 RVA: 0x007CCD88 File Offset: 0x007CAF88
	protected override bool OnInit()
	{
		this.ActorComponent = base.Entity.GetComponent<CharacterActorComponent>();
		this.CreatureDataComponent = base.Entity.CheckGetComponent<CreatureDataComponent>();
		this.TagComponent = base.Entity.GetComponent<BaseTagComponent>();
		this.SkillComponent = base.Entity.GetComponent<CharacterSkillComponent>();
		this.BuffComponent = base.Entity.GetComponent<CharacterBuffComponent>();
		this.UnifiedStateComponent = base.Entity.GetComponent<CharacterUnifiedStateComponent>();
		this.AttributeComponent = base.Entity.GetComponent<BaseAttributeComponent>();
		this.MorphComponent = base.Entity.GetComponent<CharacterMorphComponent>();
		return true;
	}

	// Token: 0x0601978A RID: 104330 RVA: 0x007CCE20 File Offset: 0x007CB020
	protected override bool OnStart()
	{
		if (!base.OnStart())
		{
			return false;
		}
		LivingStatus? livingStatus = this.CreatureDataComponent.GetLivingStatus();
		if (livingStatus.GetValueOrDefault() == LivingStatus.Dead)
		{
			this.ExecuteDeath(null);
		}
		else if (livingStatus.GetValueOrDefault() == LivingStatus.Dying)
		{
			this.ExecuteDying(null);
		}
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.TeleportChangeLocation, new Action(this.ResetDrowning));
		return true;
	}

	// Token: 0x0601978B RID: 104331 RVA: 0x007CCE9C File Offset: 0x007CB09C
	protected override bool OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.TeleportChangeLocation, new Action(this.ResetDrowning));
		return true;
	}

	// Token: 0x0601978C RID: 104332 RVA: 0x007CCEC1 File Offset: 0x007CB0C1
	protected override bool OnClear()
	{
		this.MaterialHandles.Clear();
		this.CanResetDrowning = false;
		return true;
	}

	// Token: 0x0601978D RID: 104333 RVA: 0x007CCED8 File Offset: 0x007CB0D8
	public override bool ExecuteDeath(long? preMessageId)
	{
		if (!base.ExecuteDeath(preMessageId))
		{
			return false;
		}
		SceneTeamController.Instance.EmitEvent(base.Entity, EEventName.CharOnRoleDeadBefore);
		CharacterBuffComponent buffComponent = this.BuffComponent;
		if (buffComponent != null)
		{
			buffComponent.RemoveBuffByEffectType(EExtraEffectId.Frozen, "实体死亡移除冰冻buff");
		}
		BaseTagComponent tagComponent = this.TagComponent;
		if (tagComponent != null)
		{
			tagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.濒死"]));
		}
		CharacterSkillComponent skillComponent = this.SkillComponent;
		if (skillComponent != null)
		{
			skillComponent.StopAllSkills("RoleDeathComponent.ExecuteDeath");
		}
		this.ClearUnifiedState("RoleDeathComponent.ExecuteDeath");
		CharacterBuffComponent buffComponent2 = this.BuffComponent;
		if (buffComponent2 != null)
		{
			buffComponent2.RemoveAllDurationBuffs("实体死亡清理持续型buff", ERemoveAllBuffsReasonType.Death);
		}
		BaseAttributeComponent attributeComponent = this.AttributeComponent;
		if (attributeComponent != null)
		{
			attributeComponent.ClearSpecialEnergy();
		}
		this.PlayDeathAnimation(preMessageId);
		this.PlayDeathAudio();
		EventSystem.Instance.Emit<int>(EEventName.CharOnRoleDead, base.Entity.Id);
		EventSystem.Instance.EmitWithTarget(base.Entity, EEventName.CharOnRoleDeadTargetSelf);
		return true;
	}

	// Token: 0x0601978E RID: 104334 RVA: 0x007CCFCC File Offset: 0x007CB1CC
	public override bool ExecuteDying(long? contextId)
	{
		if (!base.ExecuteDying(contextId))
		{
			return false;
		}
		CharacterBuffComponent buffComponent = this.BuffComponent;
		if (buffComponent != null)
		{
			buffComponent.RemoveBuffByEffectType(EExtraEffectId.Frozen, "实体濒死移除冰冻buff");
		}
		CharacterSkillComponent skillComponent = this.SkillComponent;
		if (skillComponent != null)
		{
			skillComponent.StopAllSkills("RoleDeathComponent.ExecuteDying");
		}
		this.ClearUnifiedState("RoleDeathComponent.ExecuteDying");
		CharacterBuffComponent buffComponent2 = this.BuffComponent;
		if (buffComponent2 != null)
		{
			buffComponent2.RemoveAllDurationBuffs("实体濒死清理持续型buff", ERemoveAllBuffsReasonType.Dying);
		}
		EventSystem.Instance.Emit<Entity>(EEventName.OnDying, base.Entity);
		EventSystem.Instance.EmitWithTarget(base.Entity, EEventName.CharOnDying);
		return true;
	}

	// Token: 0x0601978F RID: 104335 RVA: 0x007CD064 File Offset: 0x007CB264
	[NullableContext(1)]
	protected void ClearUnifiedState(string reason = "")
	{
		CharacterUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
		if (unifiedStateComponent != null && unifiedStateComponent.Valid && base.Entity.IsInit)
		{
			this.UnifiedStateComponent.ResetCharState();
			global::ECharPositionState positionState = this.UnifiedStateComponent.PositionState;
			if (positionState != global::ECharPositionState.Climb)
			{
				if (positionState == global::ECharPositionState.Air)
				{
					global::ECharMoveState moveState = this.UnifiedStateComponent.MoveState;
					if (moveState == global::ECharMoveState.Glide)
					{
						CharacterGlideComponent component = base.Entity.GetComponent<CharacterGlideComponent>();
						if (component != null)
						{
							component.ExitGlideState(reason);
						}
					}
					else if (moveState == global::ECharMoveState.Soar)
					{
						CharacterGlideComponent component2 = base.Entity.GetComponent<CharacterGlideComponent>();
						if (component2 != null)
						{
							component2.ExitSoarState(EMovementMode.MOVE_Falling, reason);
						}
					}
				}
			}
			else
			{
				CharacterActorComponent component3 = base.Entity.GetComponent<CharacterActorComponent>();
				if (component3 != null)
				{
					component3.Actor.KuroSetMovementMode(new SetMovementModeInfo
					{
						Mode = EMovementMode.MOVE_Falling,
						CustomMode = 0,
						Context = reason
					});
				}
			}
			this.UnifiedStateComponent.ExitHitState(reason);
		}
	}

	// Token: 0x06019790 RID: 104336 RVA: 0x007CD141 File Offset: 0x007CB341
	protected void PlayDeathAudio()
	{
		if (base.Entity == null)
		{
			return;
		}
		RoleAudioController.Instance.OnPlayerDies(base.Entity);
	}

	// Token: 0x06019791 RID: 104337 RVA: 0x007CD15C File Offset: 0x007CB35C
	protected void PlayDeathAnimation(long? preMessageId)
	{
		BaseTagComponent tagComponent = this.TagComponent;
		if (tagComponent != null && tagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.溺水"]))
		{
			return;
		}
		if (!DeadReviveModel.Instance.SkipDeathAnim)
		{
			BaseTagComponent tagComponent2 = this.TagComponent;
			if (tagComponent2 == null || !tagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.不播放死亡动画"]))
			{
				BaseMontageComponent montageComponent = this.MontageComponent;
				if (montageComponent != null && montageComponent.Valid && base.Entity.IsInit && base.Entity.Active)
				{
					CharacterUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
					if (!(((unifiedStateComponent != null) ? new global::ECharPositionState?(unifiedStateComponent.PositionState) : null) != global::ECharPositionState.Water))
					{
						base.PlayDeathMontageWithType(ECharacterDeathMontageType.DieInWater, new Action<bool>(this.OnDeathEnded), preMessageId, null);
					}
					else
					{
						base.PlayDeathMontageWithType(ECharacterDeathMontageType.Die, new Action<bool>(this.OnDeathEnded), preMessageId, null);
					}
					if (RoverlikeController.Instance.CheckInRoverlike())
					{
						RoverlikeController.Instance.RoleDeathStart(base.Entity);
					}
					return;
				}
			}
		}
		this.OnDeathEnded();
	}

	// Token: 0x06019792 RID: 104338 RVA: 0x007CD280 File Offset: 0x007CB480
	protected override UAnimMontage GetDeathMontage(ECharacterDeathMontageType montageType)
	{
		UAnimMontage uanimMontage = null;
		if (this.MorphComponent != null && this.MorphComponent.IsMorphing())
		{
			string deathMontageName = base.GetDeathMontageName(montageType);
			if (deathMontageName != null)
			{
				uanimMontage = this.MorphComponent.GetMontageByName(deathMontageName);
			}
		}
		if (uanimMontage == null)
		{
			uanimMontage = base.GetDeathMontage(montageType);
		}
		return uanimMontage;
	}

	// Token: 0x06019793 RID: 104339 RVA: 0x007CD2C8 File Offset: 0x007CB4C8
	public void OnDeathEnded(bool isInterrupted)
	{
		this.OnDeathEnded();
	}

	// Token: 0x06019794 RID: 104340 RVA: 0x007CD2D0 File Offset: 0x007CB4D0
	public void OnDeathEnded()
	{
		List<EntityHandle> teamEntities = SceneTeamModel.Instance.GetTeamEntities(true);
		if (this.BuffComponent != null && this.BuffComponent.HasBuffAuthority())
		{
			this.BuffComponent.TriggerEvents(EBuffTriggerType.WhenOwnerDie, this.BuffComponent, new Partial_RequirementPayload());
			foreach (EntityHandle entityHandle in teamEntities)
			{
				if (base.Entity.Id != entityHandle.Id && entityHandle.Valid)
				{
					WorldEntity entity = entityHandle.Entity;
					RoleDeathComponent roleDeathComponent = (entity != null) ? entity.GetComponent<RoleDeathComponent>() : null;
					if (roleDeathComponent != null && !roleDeathComponent.IsDead())
					{
						CharacterBuffComponent buffComponent = roleDeathComponent.BuffComponent;
						if (buffComponent != null)
						{
							buffComponent.TriggerEvents(EBuffTriggerType.WhenCompanionDie, this.BuffComponent, new Partial_RequirementPayload());
						}
					}
				}
			}
		}
		EventSystem.Instance.EmitWithTarget(base.Entity, EEventName.CharOnRoleDeadEnd);
		if (RoverlikeController.Instance.CheckInRoverlike())
		{
			RoverlikeController.Instance.RoleDeathEnded(base.Entity);
			return;
		}
		if (!base.IsDead())
		{
			return;
		}
		SceneTeamModel.Instance.RoleDeathEnded(base.Entity.Id);
	}

	// Token: 0x06019795 RID: 104341 RVA: 0x007CD400 File Offset: 0x007CB600
	public unsafe void ExecuteRevive()
	{
		if (!this.IsDeadInternal && !this.IsDyingInternal)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.ZQR;
			string message = "实体重复复活";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityId", base.Entity.Id);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.Battle;
		ELogAuthor author2 = ELogAuthor.ZQR;
		string message2 = "[DeathComponent]执行角色复活逻辑";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Entity", base.Entity.ToString());
		ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
		string item = "PbDataId";
		Entity entity = base.Entity;
		int? num;
		if (entity == null)
		{
			num = null;
		}
		else
		{
			CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
			num = ((component != null) ? new int?(component.GetPbDataId()) : null);
		}
		ptr = new ValueTuple<string, object>(item, num);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		this.IsDeadInternal = false;
		this.IsDyingInternal = false;
		BaseTagComponent tagComponent = this.TagComponent;
		if (tagComponent != null)
		{
			tagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.濒死"]));
		}
		this.RemoveMaterials();
		EventSystem.Instance.EmitWithTarget(base.Entity, EEventName.CharOnAnyRevive);
		EventSystem.Instance.Emit<Entity>(EEventName.OnAnyRevive, base.Entity);
		CharacterActorComponent actorComponent = this.ActorComponent;
		if (actorComponent != null && actorComponent.IsAutonomousProxy)
		{
			EventSystem.Instance.EmitWithTarget(base.Entity, EEventName.CharOnRevive);
			EventSystem.Instance.Emit<Entity>(EEventName.OnRevive, base.Entity);
			CharacterUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
			if (unifiedStateComponent != null)
			{
				unifiedStateComponent.TryClearInFightTags();
			}
			CharacterUnifiedStateComponent unifiedStateComponent2 = this.UnifiedStateComponent;
			if (unifiedStateComponent2 != null)
			{
				unifiedStateComponent2.RefreshFightState(new bool?(FormationDataController.Instance.GlobalIsInFight));
			}
		}
		CharacterActorComponent actorComponent2 = this.ActorComponent;
		TsBaseCharacter 角色 = ((actorComponent2 != null) ? actorComponent2.Owner : null) as TsBaseCharacter;
		GlobalData.BpEventManager.当有角色复活时.Broadcast(角色);
	}

	// Token: 0x06019796 RID: 104342 RVA: 0x007CD5E8 File Offset: 0x007CB7E8
	public void AddMaterialHandle(int handle)
	{
		this.MaterialHandles.Add(handle);
	}

	// Token: 0x06019797 RID: 104343 RVA: 0x007CD5F8 File Offset: 0x007CB7F8
	public void RemoveMaterials()
	{
		CharacterActorComponent actorComponent = this.ActorComponent;
		CharRenderingComponent charRenderingComponent = (actorComponent != null) ? actorComponent.Actor.CharRenderingComponent : null;
		if (charRenderingComponent != null)
		{
			foreach (int handle in this.MaterialHandles)
			{
				charRenderingComponent.RemoveMaterialControllerData(handle);
			}
		}
	}

	// Token: 0x06019798 RID: 104344 RVA: 0x007CD668 File Offset: 0x007CB868
	[CombatListen(ENotifyMessageId.DrownNotify, true, false)]
	public static void DrownNotify(Entity entity, [Nullable(1)] DrownNotify data, CombatCommon combatCommon = null)
	{
		RoleDeathComponent roleDeathComponent = (entity != null) ? entity.CheckGetComponent<RoleDeathComponent>() : null;
		if (roleDeathComponent != null)
		{
			roleDeathComponent.PlayDeathMontageWithType(ECharacterDeathMontageType.DieInWater, null, null, null);
			CharacterBuffComponent buffComponent = roleDeathComponent.BuffComponent;
			if (buffComponent != null && buffComponent.HasBuffAuthority())
			{
				roleDeathComponent.BuffComponent.RemoveBuffByEffectType(EExtraEffectId.Frozen, "溺水移除冰冻buff");
			}
		}
	}

	// Token: 0x06019799 RID: 104345 RVA: 0x007CD6C8 File Offset: 0x007CB8C8
	public void Drowning()
	{
		if (!this.IsDrowning())
		{
			base.Entity.CheckGetComponent<BaseTagComponent>().AddTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.溺水"]));
			BaseAttributeComponent baseAttributeComponent = base.Entity.CheckGetComponent<BaseAttributeComponent>();
			float currentValue = baseAttributeComponent.GetCurrentValue(EAttributeType.Life);
			this.BuffComponent.AddBuff(1208L, new AddBuffParam
			{
				InstigatorId = this.BuffComponent.CreatureDataId,
				Reason = "溺水流程添加"
			});
			float currentValue2 = baseAttributeComponent.GetCurrentValue(EAttributeType.Life);
			base.PlayDeathMontageWithType(ECharacterDeathMontageType.DieInWater, new Action<bool>(this.DrowningPunishment), null, null);
			CharacterBuffComponent buffComponent = this.BuffComponent;
			if (buffComponent != null && buffComponent.HasBuffAuthority())
			{
				this.BuffComponent.RemoveBuffByEffectType(EExtraEffectId.Frozen, "溺水移除冰冻buff");
			}
			EventSystem.Instance.EmitWithTarget<bool>(base.Entity, EEventName.CharOnRoleDrownInjure, currentValue > 0f && currentValue2 <= 0f);
		}
		EventSystem.Instance.Emit<bool>(EEventName.CharOnRoleDrown, true);
		CombatNet.Instance.Send(EPushMessageId.DrownPush, base.Entity, new DrownPush(), null, null, null);
	}

	// Token: 0x0601979A RID: 104346 RVA: 0x007CD80E File Offset: 0x007CBA0E
	public bool IsDrowning()
	{
		BaseTagComponent tagComponent = this.TagComponent;
		return tagComponent != null && tagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.溺水"]);
	}

	// Token: 0x0601979B RID: 104347 RVA: 0x007CD830 File Offset: 0x007CBA30
	public void ResetDrowning()
	{
		if (this.CanResetDrowning)
		{
			this.RemoveDrowningEffect();
			this.CanResetDrowning = false;
		}
	}

	// Token: 0x0601979C RID: 104348 RVA: 0x007CD847 File Offset: 0x007CBA47
	private void RemoveDrowningEffect()
	{
		if (!base.IsDead())
		{
			this.RemoveMaterials();
		}
	}

	// Token: 0x0601979D RID: 104349 RVA: 0x007CD858 File Offset: 0x007CBA58
	public void DrowningPunishment(bool _)
	{
		this.BuffComponent.AddBuff(1105L, new AddBuffParam
		{
			InstigatorId = this.BuffComponent.CreatureDataId,
			Reason = "溺水蒙太奇后添加"
		});
		this.TagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.溺水"]));
		EventSystem.Instance.Emit<bool>(EEventName.CharOnRoleDrown, false);
		EventSystem.Instance.EmitWithTarget<bool>(base.Entity, EEventName.CharOnRoleDrown, false);
		if (!SceneTeamModel.Instance.IsAllDid())
		{
			global::Vector lastPositionOnLand = FormationDataModel.Instance.GetLastPositionOnLand();
			if (GameModeController.Instance.IsInInstance())
			{
				this.CanResetDrowning = true;
				DrownEndTeleportPush drownEndTeleportPush = new DrownEndTeleportPush();
				if (lastPositionOnLand != null)
				{
					drownEndTeleportPush.TeleportPos = new Aki.Protocol.Vector
					{
						X = (float)lastPositionOnLand.X,
						Y = (float)lastPositionOnLand.Y,
						Z = (float)lastPositionOnLand.Z
					};
				}
				CombatNet.Instance.Send(EPushMessageId.DrownEndTeleportPush, base.Entity, drownEndTeleportPush, null, null, null);
			}
			else if (lastPositionOnLand != null)
			{
				TeleportController.Instance.TeleportToPositionNoLoading(lastPositionOnLand.ToUeVector(false), null, "DrowningPunishment", true).ContinueWith(delegate(bool _)
				{
					this.RemoveDrowningEffect();
				});
			}
		}
		CharacterUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
		if (unifiedStateComponent != null)
		{
			unifiedStateComponent.ResetCharState();
		}
		RoleDeathComponent roleDeathComponent = base.Entity.CheckGetComponent<RoleDeathComponent>();
		if (roleDeathComponent.IsDead())
		{
			roleDeathComponent.OnDeathEnded();
		}
	}

	// Token: 0x0601979E RID: 104350 RVA: 0x007CD9E4 File Offset: 0x007CBBE4
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		RoleDeathComponent roleDeathComponent = (RoleDeathComponent)componentTemplate;
		if (roleDeathComponent.ActorComponent == null)
		{
			this.ActorComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComponent), "ActorComponent"))
		{
			return false;
		}
		if (roleDeathComponent.CreatureDataComponent == null)
		{
			this.CreatureDataComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComponent), "CreatureDataComponent"))
		{
			return false;
		}
		if (roleDeathComponent.TagComponent == null)
		{
			this.TagComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComponent), "TagComponent"))
		{
			return false;
		}
		if (roleDeathComponent.SkillComponent == null)
		{
			this.SkillComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SkillComponent), "SkillComponent"))
		{
			return false;
		}
		if (roleDeathComponent.BuffComponent == null)
		{
			this.BuffComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.BuffComponent), "BuffComponent"))
		{
			return false;
		}
		if (roleDeathComponent.UnifiedStateComponent == null)
		{
			this.UnifiedStateComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.UnifiedStateComponent), "UnifiedStateComponent"))
		{
			return false;
		}
		if (roleDeathComponent.AttributeComponent == null)
		{
			this.AttributeComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AttributeComponent), "AttributeComponent"))
		{
			return false;
		}
		if (roleDeathComponent.MorphComponent == null)
		{
			this.MorphComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MorphComponent), "MorphComponent"))
		{
			return false;
		}
		this.CanResetDrowning = roleDeathComponent.CanResetDrowning;
		return roleDeathComponent.MaterialHandles == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.MaterialHandles), "MaterialHandles");
	}

	// Token: 0x17002898 RID: 10392
	// (get) Token: 0x0601979F RID: 104351 RVA: 0x007CDB8A File Offset: 0x007CBD8A
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002899 RID: 10393
	// (get) Token: 0x060197A0 RID: 104352 RVA: 0x007CDB8D File Offset: 0x007CBD8D
	public override bool NeedClearInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700289A RID: 10394
	// (get) Token: 0x060197A1 RID: 104353 RVA: 0x007CDB90 File Offset: 0x007CBD90
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700289B RID: 10395
	// (get) Token: 0x060197A2 RID: 104354 RVA: 0x007CDB93 File Offset: 0x007CBD93
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400DF32 RID: 57138
	private CharacterActorComponent ActorComponent;

	// Token: 0x0400DF33 RID: 57139
	private CreatureDataComponent CreatureDataComponent;

	// Token: 0x0400DF34 RID: 57140
	private BaseTagComponent TagComponent;

	// Token: 0x0400DF35 RID: 57141
	private CharacterSkillComponent SkillComponent;

	// Token: 0x0400DF36 RID: 57142
	private CharacterBuffComponent BuffComponent;

	// Token: 0x0400DF37 RID: 57143
	private CharacterUnifiedStateComponent UnifiedStateComponent;

	// Token: 0x0400DF38 RID: 57144
	private BaseAttributeComponent AttributeComponent;

	// Token: 0x0400DF39 RID: 57145
	private CharacterMorphComponent MorphComponent;

	// Token: 0x0400DF3A RID: 57146
	private bool CanResetDrowning;

	// Token: 0x0400DF3B RID: 57147
	[Nullable(1)]
	private readonly List<int> MaterialHandles = new List<int>();
}

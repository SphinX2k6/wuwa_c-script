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

// Token: 0x0200323B RID: 12859
[NullableContext(2)]
[Nullable(0)]
public class RoleDeathComponent : BaseDeathComponent
{
	// Token: 0x0601BBED RID: 113645 RVA: 0x007A44F4 File Offset: 0x007A26F4
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

	// Token: 0x0601BBEE RID: 113646 RVA: 0x007A458C File Offset: 0x007A278C
	protected override bool OnStart()
	{
		if (!base.OnStart())
		{
			return false;
		}
		CreatureDataComponent creatureDataComponent = this.CreatureDataComponent;
		if (creatureDataComponent != null && creatureDataComponent.GetLivingStatus().GetValueOrDefault() == LivingStatus.Dead)
		{
			this.ExecuteDeath(null);
		}
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.TeleportChangeLocation, new Action(this.ResetDrowning));
		return true;
	}

	// Token: 0x0601BBEF RID: 113647 RVA: 0x007A45F5 File Offset: 0x007A27F5
	protected override bool OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.TeleportChangeLocation, new Action(this.ResetDrowning));
		return true;
	}

	// Token: 0x0601BBF0 RID: 113648 RVA: 0x007A461A File Offset: 0x007A281A
	protected override bool OnClear()
	{
		this.MaterialHandles.Clear();
		this.CanResetDrowning = false;
		return true;
	}

	// Token: 0x0601BBF1 RID: 113649 RVA: 0x007A4630 File Offset: 0x007A2830
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
							component.ExitGlideState("Death");
						}
					}
					else if (moveState == global::ECharMoveState.Soar)
					{
						CharacterGlideComponent component2 = base.Entity.GetComponent<CharacterGlideComponent>();
						if (component2 != null)
						{
							component2.ExitSoarState(EMovementMode.MOVE_Falling, "Death");
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
						Context = "[RoleDeathComponent.ExecuteDeath]"
					});
				}
			}
			this.UnifiedStateComponent.ExitHitState("角色死亡");
		}
		CharacterBuffComponent buffComponent2 = this.BuffComponent;
		if (buffComponent2 != null)
		{
			buffComponent2.RemoveAllDurationBuffs("实体死亡清理持续型buff");
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

	// Token: 0x0601BBF2 RID: 113650 RVA: 0x007A47F9 File Offset: 0x007A29F9
	protected void PlayDeathAudio()
	{
		if (base.Entity == null)
		{
			return;
		}
		RoleAudioController.Instance.OnPlayerDies(base.Entity);
	}

	// Token: 0x0601BBF3 RID: 113651 RVA: 0x007A4814 File Offset: 0x007A2A14
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

	// Token: 0x0601BBF4 RID: 113652 RVA: 0x007A4938 File Offset: 0x007A2B38
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

	// Token: 0x0601BBF5 RID: 113653 RVA: 0x007A4980 File Offset: 0x007A2B80
	public void OnDeathEnded(bool isInterrupted)
	{
		this.OnDeathEnded();
	}

	// Token: 0x0601BBF6 RID: 113654 RVA: 0x007A4988 File Offset: 0x007A2B88
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

	// Token: 0x0601BBF7 RID: 113655 RVA: 0x007A4AB8 File Offset: 0x007A2CB8
	public unsafe void ExecuteRevive()
	{
		if (!this.IsDeadInternal)
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
		BaseTagComponent tagComponent = this.TagComponent;
		if (tagComponent != null)
		{
			tagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.濒死"]));
		}
		this.RemoveMaterials();
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

	// Token: 0x0601BBF8 RID: 113656 RVA: 0x007A4C65 File Offset: 0x007A2E65
	public void AddMaterialHandle(int handle)
	{
		this.MaterialHandles.Add(handle);
	}

	// Token: 0x0601BBF9 RID: 113657 RVA: 0x007A4C74 File Offset: 0x007A2E74
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

	// Token: 0x0601BBFA RID: 113658 RVA: 0x007A4CE4 File Offset: 0x007A2EE4
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

	// Token: 0x0601BBFB RID: 113659 RVA: 0x007A4D44 File Offset: 0x007A2F44
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

	// Token: 0x0601BBFC RID: 113660 RVA: 0x007A4E8A File Offset: 0x007A308A
	public bool IsDrowning()
	{
		BaseTagComponent tagComponent = this.TagComponent;
		return tagComponent != null && tagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.溺水"]);
	}

	// Token: 0x0601BBFD RID: 113661 RVA: 0x007A4EAC File Offset: 0x007A30AC
	public void ResetDrowning()
	{
		if (this.CanResetDrowning)
		{
			this.RemoveDrowningEffect();
			this.CanResetDrowning = false;
		}
	}

	// Token: 0x0601BBFE RID: 113662 RVA: 0x007A4EC3 File Offset: 0x007A30C3
	private void RemoveDrowningEffect()
	{
		if (!base.IsDead())
		{
			this.RemoveMaterials();
		}
	}

	// Token: 0x0601BBFF RID: 113663 RVA: 0x007A4ED4 File Offset: 0x007A30D4
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

	// Token: 0x0601BC00 RID: 113664 RVA: 0x007A5060 File Offset: 0x007A3260
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		RoleDeathComponent roleDeathComponent = (RoleDeathComponent)componentTemplate;
		if (base.CanResetComponentProperty("ActorComponent"))
		{
			if (roleDeathComponent.ActorComponent == null)
			{
				this.ActorComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterActorComponent>(this.ActorComponent), "ActorComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("CreatureDataComponent"))
		{
			if (roleDeathComponent.CreatureDataComponent == null)
			{
				this.CreatureDataComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CreatureDataComponent>(this.CreatureDataComponent), "CreatureDataComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagComponent"))
		{
			if (roleDeathComponent.TagComponent == null)
			{
				this.TagComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComponent), "TagComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("SkillComponent"))
		{
			if (roleDeathComponent.SkillComponent == null)
			{
				this.SkillComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterSkillComponent>(this.SkillComponent), "SkillComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("BuffComponent"))
		{
			if (roleDeathComponent.BuffComponent == null)
			{
				this.BuffComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterBuffComponent>(this.BuffComponent), "BuffComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("UnifiedStateComponent"))
		{
			if (roleDeathComponent.UnifiedStateComponent == null)
			{
				this.UnifiedStateComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterUnifiedStateComponent>(this.UnifiedStateComponent), "UnifiedStateComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("AttributeComponent"))
		{
			if (roleDeathComponent.AttributeComponent == null)
			{
				this.AttributeComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseAttributeComponent>(this.AttributeComponent), "AttributeComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("MorphComponent"))
		{
			if (roleDeathComponent.MorphComponent == null)
			{
				this.MorphComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterMorphComponent>(this.MorphComponent), "MorphComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("CanResetDrowning"))
		{
			this.CanResetDrowning = roleDeathComponent.CanResetDrowning;
		}
		return !base.CanResetComponentProperty("MaterialHandles") || roleDeathComponent.MaterialHandles == null || base.CheckClearObject(EntityComponentSystem.ClearObject<List<int>>(this.MaterialHandles), "MaterialHandles");
	}

	// Token: 0x0400DA93 RID: 55955
	private CharacterActorComponent ActorComponent;

	// Token: 0x0400DA94 RID: 55956
	private CreatureDataComponent CreatureDataComponent;

	// Token: 0x0400DA95 RID: 55957
	private BaseTagComponent TagComponent;

	// Token: 0x0400DA96 RID: 55958
	private CharacterSkillComponent SkillComponent;

	// Token: 0x0400DA97 RID: 55959
	private CharacterBuffComponent BuffComponent;

	// Token: 0x0400DA98 RID: 55960
	private CharacterUnifiedStateComponent UnifiedStateComponent;

	// Token: 0x0400DA99 RID: 55961
	private BaseAttributeComponent AttributeComponent;

	// Token: 0x0400DA9A RID: 55962
	private CharacterMorphComponent MorphComponent;

	// Token: 0x0400DA9B RID: 55963
	private bool CanResetDrowning;

	// Token: 0x0400DA9C RID: 55964
	[Nullable(1)]
	private readonly List<int> MaterialHandles = new List<int>();
}

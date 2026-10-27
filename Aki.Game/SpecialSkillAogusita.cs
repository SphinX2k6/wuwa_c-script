using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;

// Token: 0x0200318D RID: 12685
[NullableContext(2)]
[Nullable(0)]
public class SpecialSkillAogusita : SpecialSkillBase
{
	// Token: 0x0601B4E9 RID: 111849 RVA: 0x00774737 File Offset: 0x00772937
	[NullableContext(1)]
	public SpecialSkillAogusita(CharacterSpecialSkillComponent specialSkillComponent) : base(specialSkillComponent)
	{
	}

	// Token: 0x0601B4EA RID: 111850 RVA: 0x00774760 File Offset: 0x00772960
	public override void OnStart()
	{
		Entity entity = this.SpecialSkillComponent.Entity;
		this.ActorComp = entity.GetComponent<CharacterActorComponent>();
		this.SkillComp = entity.GetComponent<BaseSkillComponent>();
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp != null && actorComp.IsRoleAndCtrlByMe)
		{
			this.InputComp = entity.GetComponent<CharacterInputComponent>();
			BaseTagComponent component = entity.GetComponent<BaseTagComponent>();
			this.HideUiListener = ((component != null) ? component.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["角色.R2T1AogusitaMd10011.战斗逻辑.大循环充能X"]), new BaseTagComponent.TTagSwitchedCallback(this.OnHideUiStateChanged), null) : null);
			EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
			EventSystem.Instance.Add<int?>(EEventName.CommonQteStart, new Action<int?>(this.OnCommonQteStart));
			EventSystem.Instance.AddWithTarget(entity, EEventName.CharOnRoleDeadTargetSelf, new Action(this.OnRoleDead));
		}
		EventSystem.Instance.AddWithTarget<int, bool>(entity, EEventName.CharBeforeSkillWithTarget, new Action<int, bool>(this.OnCharBeforeSkill));
	}

	// Token: 0x0601B4EB RID: 111851 RVA: 0x00774860 File Offset: 0x00772A60
	public override void OnEnd()
	{
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp != null && actorComp.IsRoleAndCtrlByMe && this.IsInHideUiState)
		{
			this.SetUiVisible(true);
		}
		ITagTask hideUiListener = this.HideUiListener;
		if (hideUiListener != null)
		{
			hideUiListener.EndTask();
		}
		this.HideUiListener = null;
		if (EventSystem.Instance.Has(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole)))
		{
			EventSystem.Instance.Remove<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		}
		if (EventSystem.Instance.Has(EEventName.CommonQteStart, new Action<int?>(this.OnCommonQteStart)))
		{
			EventSystem.Instance.Remove<int?>(EEventName.CommonQteStart, new Action<int?>(this.OnCommonQteStart));
		}
		if (EventSystem.Instance.HasWithTarget(this.SpecialSkillComponent.Entity, EEventName.CharOnRoleDeadTargetSelf, new Action(this.OnRoleDead)))
		{
			EventSystem.Instance.RemoveWithTarget(this.SpecialSkillComponent.Entity, EEventName.CharOnRoleDeadTargetSelf, new Action(this.OnRoleDead));
		}
		EventSystem.Instance.RemoveWithTarget<int, bool>(this.SpecialSkillComponent.Entity, EEventName.CharBeforeSkillWithTarget, new Action<int, bool>(this.OnCharBeforeSkill));
	}

	// Token: 0x0601B4EC RID: 111852 RVA: 0x00774990 File Offset: 0x00772B90
	private void OnHideUiStateChanged(int tagId, bool bTagExists)
	{
		this.IsInHideUiState = bTagExists;
		int id = this.SpecialSkillComponent.Entity.Id;
		SceneTeamModel instance = SceneTeamModel.Instance;
		int? num;
		if (instance == null)
		{
			num = null;
		}
		else
		{
			EntityHandle getCurrentEntity = instance.GetCurrentEntity;
			if (getCurrentEntity == null)
			{
				num = null;
			}
			else
			{
				WorldEntity entity = getCurrentEntity.Entity;
				num = ((entity != null) ? new int?(entity.Id) : null);
			}
		}
		int? num2 = num;
		if (id == num2.GetValueOrDefault() & num2 != null)
		{
			this.SetUiVisible(!bTagExists);
		}
	}

	// Token: 0x0601B4ED RID: 111853 RVA: 0x00774A18 File Offset: 0x00772C18
	[NullableContext(1)]
	private void OnChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
	{
		int id = this.SpecialSkillComponent.Entity.Id;
		WorldEntity entity = newEntity.Entity;
		if (entity != null && entity.Id == id)
		{
			if (this.IsInHideUiState)
			{
				this.SetUiVisible(false);
				return;
			}
		}
		else if (oldEntity != null)
		{
			WorldEntity entity2 = oldEntity.Entity;
			int? num = (entity2 != null) ? new int?(entity2.Id) : null;
			int num2 = id;
			if (num.GetValueOrDefault() == num2 & num != null)
			{
				this.SetUiVisible(true);
			}
		}
	}

	// Token: 0x0601B4EE RID: 111854 RVA: 0x00774A9D File Offset: 0x00772C9D
	private void OnRoleDead()
	{
		this.SetUiVisible(true);
	}

	// Token: 0x0601B4EF RID: 111855 RVA: 0x00774AA6 File Offset: 0x00772CA6
	private void OnCommonQteStart(int? handleId)
	{
		this.SkillComp.EndSkill(1306666, "触发通用QTE，终止奥古斯塔时停被动技能");
	}

	// Token: 0x0601B4F0 RID: 111856 RVA: 0x00774AC0 File Offset: 0x00772CC0
	private void SetUiVisible(bool visible)
	{
		if (this.IsUiVisible == visible)
		{
			return;
		}
		this.IsUiVisible = visible;
		BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.SpecialSkill, this.hideBattleUiChildren, visible, true, 0);
		CharacterInputComponent inputComp = this.InputComp;
		if (inputComp == null)
		{
			return;
		}
		inputComp.SetOnlyAllowFightInput(!visible);
	}

	// Token: 0x0601B4F1 RID: 111857 RVA: 0x00774B0C File Offset: 0x00772D0C
	private void OnCharBeforeSkill(int skillId, bool isAutonomousProxy)
	{
		if (WorldConfig.Instance.GetRoleCommonSkillRowNames().Contains(skillId.ToString()) && (long)skillId != 100003L && (long)skillId != 100004L)
		{
			this.SkillComp.EndSkill(1306666, "触发公共技能，终止奥古斯塔时停被动技能");
		}
	}

	// Token: 0x0400D576 RID: 54646
	[Nullable(1)]
	private readonly EBattleUiChild[] hideBattleUiChildren = new EBattleUiChild[]
	{
		EBattleUiChild.Common,
		EBattleUiChild.ExitButton,
		EBattleUiChild.HomeButton,
		EBattleUiChild.TopButton,
		EBattleUiChild.MiniMap,
		EBattleUiChild.Mission,
		EBattleUiChild.Chat,
		EBattleUiChild.Formation,
		EBattleUiChild.GamepadFormation,
		EBattleUiChild.InteractionHint,
		EBattleUiChild.SilentAreaView,
		EBattleUiChild.SilentAreaInfoPanel,
		EBattleUiChild.Score
	};

	// Token: 0x0400D577 RID: 54647
	private const int PASSIVE_SKILL_ID = 1306666;

	// Token: 0x0400D578 RID: 54648
	private const long JUMP_FORWARD = 100003L;

	// Token: 0x0400D579 RID: 54649
	private const long JUMP_BACKWARD = 100004L;

	// Token: 0x0400D57A RID: 54650
	private CharacterActorComponent ActorComp;

	// Token: 0x0400D57B RID: 54651
	private CharacterInputComponent InputComp;

	// Token: 0x0400D57C RID: 54652
	private BaseSkillComponent SkillComp;

	// Token: 0x0400D57D RID: 54653
	private ITagTask HideUiListener;

	// Token: 0x0400D57E RID: 54654
	private bool IsInHideUiState;

	// Token: 0x0400D57F RID: 54655
	private bool IsUiVisible = true;
}

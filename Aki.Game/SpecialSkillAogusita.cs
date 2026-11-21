using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;

// Token: 0x020026FA RID: 9978
[NullableContext(2)]
[Nullable(0)]
public class SpecialSkillAogusita : SpecialSkillBase
{
	// Token: 0x06018FEE RID: 102382 RVA: 0x0079C09B File Offset: 0x0079A29B
	[NullableContext(1)]
	public SpecialSkillAogusita(CharacterSpecialSkillComponent specialSkillComponent) : base(specialSkillComponent)
	{
	}

	// Token: 0x06018FEF RID: 102383 RVA: 0x0079C0C4 File Offset: 0x0079A2C4
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

	// Token: 0x06018FF0 RID: 102384 RVA: 0x0079C1C4 File Offset: 0x0079A3C4
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

	// Token: 0x06018FF1 RID: 102385 RVA: 0x0079C2F4 File Offset: 0x0079A4F4
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

	// Token: 0x06018FF2 RID: 102386 RVA: 0x0079C37C File Offset: 0x0079A57C
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

	// Token: 0x06018FF3 RID: 102387 RVA: 0x0079C401 File Offset: 0x0079A601
	private void OnRoleDead()
	{
		this.SetUiVisible(true);
	}

	// Token: 0x06018FF4 RID: 102388 RVA: 0x0079C40A File Offset: 0x0079A60A
	private void OnCommonQteStart(int? handleId)
	{
		this.SkillComp.EndSkill(1306666, "触发通用QTE，终止奥古斯塔时停被动技能");
	}

	// Token: 0x06018FF5 RID: 102389 RVA: 0x0079C424 File Offset: 0x0079A624
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

	// Token: 0x06018FF6 RID: 102390 RVA: 0x0079C470 File Offset: 0x0079A670
	private void OnCharBeforeSkill(int skillId, bool isAutonomousProxy)
	{
		if (WorldConfig.Instance.GetRoleCommonSkillRowNames().Contains(skillId.ToString()) && (long)skillId != 100003L && (long)skillId != 100004L)
		{
			this.SkillComp.EndSkill(1306666, "触发公共技能，终止奥古斯塔时停被动技能");
		}
	}

	// Token: 0x0400D9D9 RID: 55769
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

	// Token: 0x0400D9DA RID: 55770
	private const int PASSIVE_SKILL_ID = 1306666;

	// Token: 0x0400D9DB RID: 55771
	private const long JUMP_FORWARD = 100003L;

	// Token: 0x0400D9DC RID: 55772
	private const long JUMP_BACKWARD = 100004L;

	// Token: 0x0400D9DD RID: 55773
	private CharacterActorComponent ActorComp;

	// Token: 0x0400D9DE RID: 55774
	private CharacterInputComponent InputComp;

	// Token: 0x0400D9DF RID: 55775
	private BaseSkillComponent SkillComp;

	// Token: 0x0400D9E0 RID: 55776
	private ITagTask HideUiListener;

	// Token: 0x0400D9E1 RID: 55777
	private bool IsInHideUiState;

	// Token: 0x0400D9E2 RID: 55778
	private bool IsUiVisible = true;
}

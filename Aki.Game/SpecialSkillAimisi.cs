using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Character.Common.Component.Explore;

// Token: 0x0200318B RID: 12683
[NullableContext(1)]
[Nullable(0)]
public class SpecialSkillAimisi : SpecialSkillMorphBase
{
	// Token: 0x170025BF RID: 9663
	// (get) Token: 0x0601B4AB RID: 111787 RVA: 0x007724E5 File Offset: 0x007706E5
	protected override string MorphBuffsConfigKey
	{
		get
		{
			return "AimisiMorphBuffs";
		}
	}

	// Token: 0x170025C0 RID: 9664
	// (get) Token: 0x0601B4AC RID: 111788 RVA: 0x007724EC File Offset: 0x007706EC
	protected override string MorphCueIdConfigKey
	{
		get
		{
			return "AimisiMorphCues";
		}
	}

	// Token: 0x170025C1 RID: 9665
	// (get) Token: 0x0601B4AD RID: 111789 RVA: 0x007724F3 File Offset: 0x007706F3
	protected override string ResetMorphSkillsConfigKey
	{
		get
		{
			return "AimisiResetMorphSkills";
		}
	}

	// Token: 0x170025C2 RID: 9666
	// (get) Token: 0x0601B4AE RID: 111790 RVA: 0x007724FA File Offset: 0x007706FA
	protected override string NotResetMorphSkillsConfigKey
	{
		get
		{
			return "AimisiNotResetMorphSkills";
		}
	}

	// Token: 0x170025C3 RID: 9667
	// (get) Token: 0x0601B4AF RID: 111791 RVA: 0x00772501 File Offset: 0x00770701
	protected override string ChangeRoleResetMorphTagsConfigKey
	{
		get
		{
			return "AimisiChangeRoleResetMorphTags";
		}
	}

	// Token: 0x0601B4B0 RID: 111792 RVA: 0x00772508 File Offset: 0x00770708
	protected override string GetSubMeshConfigKey(EMorphType morphType)
	{
		if (morphType == EMorphType.默认形态)
		{
			return "AimisiMorph0SubMeshList";
		}
		if (morphType != EMorphType.变身形态)
		{
			return "";
		}
		return "AimisiMorph1SubMeshList";
	}

	// Token: 0x0601B4B1 RID: 111793 RVA: 0x00772524 File Offset: 0x00770724
	public SpecialSkillAimisi(CharacterSpecialSkillComponent specialSkillComponent) : base(specialSkillComponent)
	{
	}

	// Token: 0x0601B4B2 RID: 111794 RVA: 0x00772530 File Offset: 0x00770730
	public override void OnStart()
	{
		base.OnStart();
		this.AnimComp = this.SpecialSkillComponent.Entity.GetComponent<CharacterAnimationComponent>();
		BaseBuffComponent buffComp = this.BuffComp;
		if (buffComp != null)
		{
			buffComp.SetDeferredCueCreationEnable(true);
		}
		EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
	}

	// Token: 0x0601B4B3 RID: 111795 RVA: 0x00772588 File Offset: 0x00770788
	public override void OnEnd()
	{
		base.OnEnd();
		BaseBuffComponent buffComp = this.BuffComp;
		if (buffComp != null)
		{
			buffComp.SetDeferredCueCreationEnable(false);
		}
		if (this.IsUsingAimisExploreSkill)
		{
			this.ResetMorphExploreSkill("Aimisi实体销毁", true);
		}
		EventSystem.Instance.Remove<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
	}

	// Token: 0x0601B4B4 RID: 111796 RVA: 0x007725E0 File Offset: 0x007707E0
	private void SetMorphExploreSkill(string reason, bool skipCurrentEntityCheck = false)
	{
		CharacterExploreModel instance = CharacterExploreModel.Instance;
		if (instance == null)
		{
			return;
		}
		if (!skipCurrentEntityCheck)
		{
			int id = this.SpecialSkillComponent.Entity.Id;
			SceneTeamModel instance2 = SceneTeamModel.Instance;
			int? num;
			if (instance2 == null)
			{
				num = null;
			}
			else
			{
				EntityHandle getCurrentEntity = instance2.GetCurrentEntity;
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
			if (!(id == num2.GetValueOrDefault() & num2 != null))
			{
				return;
			}
		}
		CharacterMorphComponent morphComp = this.MorphComp;
		EMorphType? emorphType = (morphComp != null) ? new EMorphType?(morphComp.GetMorphType()) : null;
		if (emorphType != null)
		{
			EMorphType? emorphType2 = emorphType;
			EMorphType emorphType3 = EMorphType.默认形态;
			if (!(emorphType2.GetValueOrDefault() == emorphType3 & emorphType2 != null))
			{
				if (instance.CheckNeedChangeSkill(121001, EExploreSkillLayer.SpecialSkill))
				{
					RouletteController.Instance.ExploreSkillSetRequest(121001, null, true);
				}
				instance.SetExploreSkillId(121001, EExploreSkillLayer.SpecialSkill, reason);
				this.IsUsingAimisExploreSkill = true;
				return;
			}
		}
	}

	// Token: 0x0601B4B5 RID: 111797 RVA: 0x007726E0 File Offset: 0x007708E0
	private void ResetMorphExploreSkill(string reason, bool skipCurrentEntityCheck = false)
	{
		CharacterExploreModel instance = CharacterExploreModel.Instance;
		if (instance == null)
		{
			return;
		}
		if (!skipCurrentEntityCheck)
		{
			int id = this.SpecialSkillComponent.Entity.Id;
			SceneTeamModel instance2 = SceneTeamModel.Instance;
			int? num;
			if (instance2 == null)
			{
				num = null;
			}
			else
			{
				EntityHandle getCurrentEntity = instance2.GetCurrentEntity;
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
			if (!(id == num2.GetValueOrDefault() & num2 != null))
			{
				return;
			}
		}
		instance.ResetExplodeSkillId(EExploreSkillLayer.SpecialSkill, reason);
		int topLayerExplodeSkillId = instance.GetTopLayerExplodeSkillId();
		RouletteController.Instance.ExploreSkillSetRequest(topLayerExplodeSkillId, null, true);
		this.IsUsingAimisExploreSkill = false;
	}

	// Token: 0x0601B4B6 RID: 111798 RVA: 0x00772788 File Offset: 0x00770988
	private void OnChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
	{
		WorldEntity entity = newEntity.Entity;
		int? num = (entity != null) ? new int?(entity.Id) : null;
		int id = this.SpecialSkillComponent.Entity.Id;
		bool flag = num.GetValueOrDefault() == id & num != null;
		int? num2;
		if (oldEntity == null)
		{
			num2 = null;
		}
		else
		{
			WorldEntity entity2 = oldEntity.Entity;
			num2 = ((entity2 != null) ? new int?(entity2.Id) : null);
		}
		num = num2;
		id = this.SpecialSkillComponent.Entity.Id;
		if (num.GetValueOrDefault() == id & num != null)
		{
			this.ResetMorphExploreSkill("Aimisi下场", true);
			return;
		}
		if (flag)
		{
			this.SetMorphExploreSkill("Aimisi上场", true);
		}
	}

	// Token: 0x0601B4B7 RID: 111799 RVA: 0x00772848 File Offset: 0x00770A48
	protected override void OnCharacterMorphTypeChanged(Entity entity, EMorphType newMorphType, EMorphType oldMorphType)
	{
		base.RefreshNoUpdateMeshes(newMorphType);
		if (newMorphType != EMorphType.默认形态)
		{
			this.SetMorphExploreSkill("Aimisi切换到形态二", false);
			return;
		}
		this.ResetMorphExploreSkill("Aimisi恢复到形态一", false);
	}

	// Token: 0x0400D52D RID: 54573
	public const int AIMISI_MORPH_EXPLORE_SKILL_ID = 121001;

	// Token: 0x0400D52E RID: 54574
	private bool IsUsingAimisExploreSkill;
}

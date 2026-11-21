using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Character.Common.Component.Explore;

// Token: 0x020026F8 RID: 9976
[NullableContext(1)]
[Nullable(0)]
public class SpecialSkillAimisi : SpecialSkillMorphBase
{
	// Token: 0x170027B0 RID: 10160
	// (get) Token: 0x06018FB0 RID: 102320 RVA: 0x00799E49 File Offset: 0x00798049
	protected override string MorphBuffsConfigKey
	{
		get
		{
			return "AimisiMorphBuffs";
		}
	}

	// Token: 0x170027B1 RID: 10161
	// (get) Token: 0x06018FB1 RID: 102321 RVA: 0x00799E50 File Offset: 0x00798050
	protected override string MorphCueIdConfigKey
	{
		get
		{
			return "AimisiMorphCues";
		}
	}

	// Token: 0x170027B2 RID: 10162
	// (get) Token: 0x06018FB2 RID: 102322 RVA: 0x00799E57 File Offset: 0x00798057
	protected override string ResetMorphSkillsConfigKey
	{
		get
		{
			return "AimisiResetMorphSkills";
		}
	}

	// Token: 0x170027B3 RID: 10163
	// (get) Token: 0x06018FB3 RID: 102323 RVA: 0x00799E5E File Offset: 0x0079805E
	protected override string NotResetMorphSkillsConfigKey
	{
		get
		{
			return "AimisiNotResetMorphSkills";
		}
	}

	// Token: 0x170027B4 RID: 10164
	// (get) Token: 0x06018FB4 RID: 102324 RVA: 0x00799E65 File Offset: 0x00798065
	protected override string ChangeRoleResetMorphTagsConfigKey
	{
		get
		{
			return "AimisiChangeRoleResetMorphTags";
		}
	}

	// Token: 0x06018FB5 RID: 102325 RVA: 0x00799E6C File Offset: 0x0079806C
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

	// Token: 0x06018FB6 RID: 102326 RVA: 0x00799E88 File Offset: 0x00798088
	public SpecialSkillAimisi(CharacterSpecialSkillComponent specialSkillComponent) : base(specialSkillComponent)
	{
	}

	// Token: 0x06018FB7 RID: 102327 RVA: 0x00799E94 File Offset: 0x00798094
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

	// Token: 0x06018FB8 RID: 102328 RVA: 0x00799EEC File Offset: 0x007980EC
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

	// Token: 0x06018FB9 RID: 102329 RVA: 0x00799F44 File Offset: 0x00798144
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

	// Token: 0x06018FBA RID: 102330 RVA: 0x0079A044 File Offset: 0x00798244
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

	// Token: 0x06018FBB RID: 102331 RVA: 0x0079A0EC File Offset: 0x007982EC
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

	// Token: 0x06018FBC RID: 102332 RVA: 0x0079A1AC File Offset: 0x007983AC
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

	// Token: 0x0400D990 RID: 55696
	public const int AIMISI_MORPH_EXPLORE_SKILL_ID = 121001;

	// Token: 0x0400D991 RID: 55697
	private bool IsUsingAimisExploreSkill;
}

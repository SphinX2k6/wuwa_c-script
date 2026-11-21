using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Input;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Module.GameMainView.Data;
using CSharpScript.Game.Module.SkillButtonUi;
using UnrealEngine;

// Token: 0x02001184 RID: 4484
[NullableContext(2)]
[Nullable(0)]
public class KurotatoBattleSkillData : BattleSkillDataBase
{
	// Token: 0x0600B2D7 RID: 45783 RVA: 0x0034D940 File Offset: 0x0034BB40
	public KurotatoBattleSkillData(int skillId)
	{
		this.SkillId = skillId;
	}

	// Token: 0x0600B2D8 RID: 45784 RVA: 0x0034D958 File Offset: 0x0034BB58
	protected override void OnInitData()
	{
		if (this.SkillId == 0)
		{
			return;
		}
		SceneTeamModel instance = SceneTeamModel.Instance;
		this.EntityHandle = ((instance != null) ? instance.GetCurrentEntity : null);
		if (this.EntityHandle != null)
		{
			WorldEntity entity = this.EntityHandle.Entity;
			if (entity != null)
			{
				this.CharacterSkillCdComponent = entity.GetComponent<CharacterSkillCdComponent>();
				this.CharacterSkillComponent = entity.GetComponent<CharacterSkillComponent>();
			}
		}
		CharacterSkillComponent characterSkillComponent = this.CharacterSkillComponent;
		this.SkillConfig = ((characterSkillComponent != null) ? characterSkillComponent.GetSkillInfo(this.SkillId) : null);
		CharacterSkillCdComponent characterSkillCdComponent = this.CharacterSkillCdComponent;
		this.GroupSkillCdInfo = ((characterSkillCdComponent != null) ? characterSkillCdComponent.GetGroupSkillCdInfo(this.SkillId) : null);
	}

	// Token: 0x0600B2D9 RID: 45785 RVA: 0x0034D9F0 File Offset: 0x0034BBF0
	public void RefreshSkillCd()
	{
		if (this.CharacterSkillCdComponent != null)
		{
			GroupSkillCdInfo groupSkillCdInfo = this.GetGroupSkillCdInfo();
			if (groupSkillCdInfo == null || groupSkillCdInfo.RemainingCount <= 0)
			{
				this.IsEnableInternal = false;
				return;
			}
		}
		this.IsEnableInternal = true;
	}

	// Token: 0x0600B2DA RID: 45786 RVA: 0x0034DA27 File Offset: 0x0034BC27
	public override int GetSkillId()
	{
		return this.SkillId;
	}

	// Token: 0x0600B2DB RID: 45787 RVA: 0x0034DA30 File Offset: 0x0034BC30
	public override string GetSkillTexturePath()
	{
		SSkillInfo skillConfig = this.SkillConfig;
		if (skillConfig == null)
		{
			return null;
		}
		FSoftObjectPath skillIcon = skillConfig.SkillIcon;
		if (skillIcon == null)
		{
			return null;
		}
		return skillIcon.AssetPathName.ToString();
	}

	// Token: 0x0600B2DC RID: 45788 RVA: 0x0034DA67 File Offset: 0x0034BC67
	public override EInputAction GetActionType()
	{
		return EInputAction.闪避;
	}

	// Token: 0x0600B2DD RID: 45789 RVA: 0x0034DA6E File Offset: 0x0034BC6E
	public override ESkillButtonType GetButtonType()
	{
		return ESkillButtonType.闪避;
	}

	// Token: 0x0600B2DE RID: 45790 RVA: 0x0034DA71 File Offset: 0x0034BC71
	public override bool IsEnable()
	{
		return this.IsEnableInternal;
	}

	// Token: 0x0600B2DF RID: 45791 RVA: 0x0034DA79 File Offset: 0x0034BC79
	public override GroupSkillCdInfo GetGroupSkillCdInfo()
	{
		return this.GroupSkillCdInfo;
	}

	// Token: 0x0600B2E0 RID: 45792 RVA: 0x0034DA81 File Offset: 0x0034BC81
	public override bool HasCdComponent()
	{
		return true;
	}

	// Token: 0x0600B2E1 RID: 45793 RVA: 0x0034DA84 File Offset: 0x0034BC84
	public override float GetSkillRemainingCoolDown()
	{
		if (this.GroupSkillCdInfo != null)
		{
			return this.GroupSkillCdInfo.CurRemainingCd;
		}
		return 0f;
	}

	// Token: 0x0600B2E2 RID: 45794 RVA: 0x0034DA9F File Offset: 0x0034BC9F
	public override bool IsCdVisible()
	{
		return true;
	}

	// Token: 0x04006734 RID: 26420
	private bool IsEnableInternal = true;

	// Token: 0x04006735 RID: 26421
	private readonly int SkillId;

	// Token: 0x04006736 RID: 26422
	private SSkillInfo SkillConfig;

	// Token: 0x04006737 RID: 26423
	private GroupSkillCdInfo GroupSkillCdInfo;

	// Token: 0x04006738 RID: 26424
	private EntityHandle EntityHandle;

	// Token: 0x04006739 RID: 26425
	private CharacterSkillComponent CharacterSkillComponent;

	// Token: 0x0400673A RID: 26426
	private CharacterSkillCdComponent CharacterSkillCdComponent;
}

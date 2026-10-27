using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Input;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Module.GameMainView.Data;
using CSharpScript.Game.Module.SkillButtonUi;
using UnrealEngine;

// Token: 0x02001D25 RID: 7461
[NullableContext(2)]
[Nullable(0)]
public class SurvivorsRogueBattleSkillData : BattleSkillDataBase
{
	// Token: 0x0600E1E7 RID: 57831 RVA: 0x00350C68 File Offset: 0x0034EE68
	public SurvivorsRogueBattleSkillData(int skillId)
	{
		this.SkillId = skillId;
	}

	// Token: 0x0600E1E8 RID: 57832 RVA: 0x00350C88 File Offset: 0x0034EE88
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
		if (base.GetActionName() == "闪避")
		{
			this.IsCdVisibleInternal = false;
			CharacterSkillComponent characterSkillComponent = this.CharacterSkillComponent;
			this.SkillConfig = ((characterSkillComponent != null) ? characterSkillComponent.GetSkillInfo(this.SkillId) : null);
		}
		else
		{
			this.SkillButtonConfig = this.GetActiveSkillButtonConfig();
		}
		CharacterSkillCdComponent characterSkillCdComponent = this.CharacterSkillCdComponent;
		this.GroupSkillCdInfo = ((characterSkillCdComponent != null) ? characterSkillCdComponent.GetGroupSkillCdInfo(this.SkillId) : null);
	}

	// Token: 0x0600E1E9 RID: 57833 RVA: 0x00350D48 File Offset: 0x0034EF48
	private SkillGameplayButton? GetActiveSkillButtonConfig()
	{
		SurvivorsRogueConfig instance = SurvivorsRogueConfig.Instance;
		IReadOnlyList<SkillGameplayButton> readOnlyList = (instance != null) ? instance.GetSkillButtonConfigByType(2) : null;
		if (readOnlyList == null)
		{
			return null;
		}
		int curRoleId = SurvivorsRogueModel.Instance.CurRoleId;
		for (int i = 0; i < readOnlyList.Count; i++)
		{
			SkillGameplayButton value = readOnlyList[i];
			if (value.ActionName == base.GetActionName() && value.RoleId == curRoleId)
			{
				return new SkillGameplayButton?(value);
			}
		}
		return null;
	}

	// Token: 0x0600E1EA RID: 57834 RVA: 0x00350DCC File Offset: 0x0034EFCC
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

	// Token: 0x0600E1EB RID: 57835 RVA: 0x00350E03 File Offset: 0x0034F003
	public override int GetSkillId()
	{
		return this.SkillId;
	}

	// Token: 0x0600E1EC RID: 57836 RVA: 0x00350E0C File Offset: 0x0034F00C
	public override string GetSkillTexturePath()
	{
		if (base.GetActionName() == "闪避")
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
		else
		{
			if (this.SkillButtonConfig == null)
			{
				return null;
			}
			return this.SkillButtonConfig.GetValueOrDefault().SkillIcon;
		}
	}

	// Token: 0x0600E1ED RID: 57837 RVA: 0x00350E74 File Offset: 0x0034F074
	public override EInputAction GetActionType()
	{
		if (this.SkillButtonConfig != null)
		{
			return (EInputAction)((byte)this.SkillButtonConfig.Value.ButtonType);
		}
		return EInputAction.闪避;
	}

	// Token: 0x0600E1EE RID: 57838 RVA: 0x00350EB0 File Offset: 0x0034F0B0
	public override ESkillButtonType GetButtonType()
	{
		if (this.SkillButtonConfig != null)
		{
			return (ESkillButtonType)this.SkillButtonConfig.Value.ButtonType;
		}
		return ESkillButtonType.闪避;
	}

	// Token: 0x0600E1EF RID: 57839 RVA: 0x00350EDF File Offset: 0x0034F0DF
	public override bool IsEnable()
	{
		return this.IsEnableInternal;
	}

	// Token: 0x0600E1F0 RID: 57840 RVA: 0x00350EE7 File Offset: 0x0034F0E7
	public override GroupSkillCdInfo GetGroupSkillCdInfo()
	{
		return this.GroupSkillCdInfo;
	}

	// Token: 0x0600E1F1 RID: 57841 RVA: 0x00350EEF File Offset: 0x0034F0EF
	public override bool HasCdComponent()
	{
		return true;
	}

	// Token: 0x0600E1F2 RID: 57842 RVA: 0x00350EF2 File Offset: 0x0034F0F2
	public override float GetSkillRemainingCoolDown()
	{
		if (this.GroupSkillCdInfo != null)
		{
			return this.GroupSkillCdInfo.CurRemainingCd;
		}
		return 0f;
	}

	// Token: 0x0600E1F3 RID: 57843 RVA: 0x00350F0D File Offset: 0x0034F10D
	public override bool IsCdVisible()
	{
		return this.IsCdVisibleInternal;
	}

	// Token: 0x04006877 RID: 26743
	private bool IsEnableInternal = true;

	// Token: 0x04006878 RID: 26744
	private readonly int SkillId;

	// Token: 0x04006879 RID: 26745
	private SkillGameplayButton? SkillButtonConfig;

	// Token: 0x0400687A RID: 26746
	private SSkillInfo SkillConfig;

	// Token: 0x0400687B RID: 26747
	private GroupSkillCdInfo GroupSkillCdInfo;

	// Token: 0x0400687C RID: 26748
	private EntityHandle EntityHandle;

	// Token: 0x0400687D RID: 26749
	private CharacterSkillComponent CharacterSkillComponent;

	// Token: 0x0400687E RID: 26750
	private CharacterSkillCdComponent CharacterSkillCdComponent;

	// Token: 0x0400687F RID: 26751
	private bool IsCdVisibleInternal = true;
}

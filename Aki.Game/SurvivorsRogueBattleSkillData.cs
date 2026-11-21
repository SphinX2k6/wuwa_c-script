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

// Token: 0x020011E7 RID: 4583
[NullableContext(2)]
[Nullable(0)]
public class SurvivorsRogueBattleSkillData : BattleSkillDataBase
{
	// Token: 0x0600B604 RID: 46596 RVA: 0x0035C698 File Offset: 0x0035A898
	public SurvivorsRogueBattleSkillData(int skillId)
	{
		this.SkillId = skillId;
	}

	// Token: 0x0600B605 RID: 46597 RVA: 0x0035C6B8 File Offset: 0x0035A8B8
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

	// Token: 0x0600B606 RID: 46598 RVA: 0x0035C778 File Offset: 0x0035A978
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

	// Token: 0x0600B607 RID: 46599 RVA: 0x0035C7FC File Offset: 0x0035A9FC
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

	// Token: 0x0600B608 RID: 46600 RVA: 0x0035C833 File Offset: 0x0035AA33
	public override int GetSkillId()
	{
		return this.SkillId;
	}

	// Token: 0x0600B609 RID: 46601 RVA: 0x0035C83C File Offset: 0x0035AA3C
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

	// Token: 0x0600B60A RID: 46602 RVA: 0x0035C8A4 File Offset: 0x0035AAA4
	public override EInputAction GetActionType()
	{
		if (this.SkillButtonConfig != null)
		{
			return (EInputAction)((byte)this.SkillButtonConfig.Value.ButtonType);
		}
		return EInputAction.闪避;
	}

	// Token: 0x0600B60B RID: 46603 RVA: 0x0035C8E0 File Offset: 0x0035AAE0
	public override ESkillButtonType GetButtonType()
	{
		if (this.SkillButtonConfig != null)
		{
			return (ESkillButtonType)this.SkillButtonConfig.Value.ButtonType;
		}
		return ESkillButtonType.闪避;
	}

	// Token: 0x0600B60C RID: 46604 RVA: 0x0035C90F File Offset: 0x0035AB0F
	public override bool IsEnable()
	{
		return this.IsEnableInternal;
	}

	// Token: 0x0600B60D RID: 46605 RVA: 0x0035C917 File Offset: 0x0035AB17
	public override GroupSkillCdInfo GetGroupSkillCdInfo()
	{
		return this.GroupSkillCdInfo;
	}

	// Token: 0x0600B60E RID: 46606 RVA: 0x0035C91F File Offset: 0x0035AB1F
	public override bool HasCdComponent()
	{
		return true;
	}

	// Token: 0x0600B60F RID: 46607 RVA: 0x0035C922 File Offset: 0x0035AB22
	public override float GetSkillRemainingCoolDown()
	{
		if (this.GroupSkillCdInfo != null)
		{
			return this.GroupSkillCdInfo.CurRemainingCd;
		}
		return 0f;
	}

	// Token: 0x0600B610 RID: 46608 RVA: 0x0035C93D File Offset: 0x0035AB3D
	public override bool IsCdVisible()
	{
		return this.IsCdVisibleInternal;
	}

	// Token: 0x04006956 RID: 26966
	private bool IsEnableInternal = true;

	// Token: 0x04006957 RID: 26967
	private readonly int SkillId;

	// Token: 0x04006958 RID: 26968
	private SkillGameplayButton? SkillButtonConfig;

	// Token: 0x04006959 RID: 26969
	private SSkillInfo SkillConfig;

	// Token: 0x0400695A RID: 26970
	private GroupSkillCdInfo GroupSkillCdInfo;

	// Token: 0x0400695B RID: 26971
	private EntityHandle EntityHandle;

	// Token: 0x0400695C RID: 26972
	private CharacterSkillComponent CharacterSkillComponent;

	// Token: 0x0400695D RID: 26973
	private CharacterSkillCdComponent CharacterSkillCdComponent;

	// Token: 0x0400695E RID: 26974
	private bool IsCdVisibleInternal = true;
}

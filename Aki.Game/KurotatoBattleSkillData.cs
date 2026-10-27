using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Input;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Module.GameMainView.Data;
using CSharpScript.Game.Module.SkillButtonUi;
using UnrealEngine;

// Token: 0x02001CC2 RID: 7362
[NullableContext(2)]
[Nullable(0)]
public class KurotatoBattleSkillData : BattleSkillDataBase
{
	// Token: 0x0600DEBA RID: 57018 RVA: 0x00341F18 File Offset: 0x00340118
	public KurotatoBattleSkillData(int skillId)
	{
		this.SkillId = skillId;
	}

	// Token: 0x0600DEBB RID: 57019 RVA: 0x00341F30 File Offset: 0x00340130
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

	// Token: 0x0600DEBC RID: 57020 RVA: 0x00341FC8 File Offset: 0x003401C8
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

	// Token: 0x0600DEBD RID: 57021 RVA: 0x00341FFF File Offset: 0x003401FF
	public override int GetSkillId()
	{
		return this.SkillId;
	}

	// Token: 0x0600DEBE RID: 57022 RVA: 0x00342008 File Offset: 0x00340208
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

	// Token: 0x0600DEBF RID: 57023 RVA: 0x0034203F File Offset: 0x0034023F
	public override EInputAction GetActionType()
	{
		return EInputAction.闪避;
	}

	// Token: 0x0600DEC0 RID: 57024 RVA: 0x00342046 File Offset: 0x00340246
	public override ESkillButtonType GetButtonType()
	{
		return ESkillButtonType.闪避;
	}

	// Token: 0x0600DEC1 RID: 57025 RVA: 0x00342049 File Offset: 0x00340249
	public override bool IsEnable()
	{
		return this.IsEnableInternal;
	}

	// Token: 0x0600DEC2 RID: 57026 RVA: 0x00342051 File Offset: 0x00340251
	public override GroupSkillCdInfo GetGroupSkillCdInfo()
	{
		return this.GroupSkillCdInfo;
	}

	// Token: 0x0600DEC3 RID: 57027 RVA: 0x00342059 File Offset: 0x00340259
	public override bool HasCdComponent()
	{
		return true;
	}

	// Token: 0x0600DEC4 RID: 57028 RVA: 0x0034205C File Offset: 0x0034025C
	public override float GetSkillRemainingCoolDown()
	{
		if (this.GroupSkillCdInfo != null)
		{
			return this.GroupSkillCdInfo.CurRemainingCd;
		}
		return 0f;
	}

	// Token: 0x0600DEC5 RID: 57029 RVA: 0x00342077 File Offset: 0x00340277
	public override bool IsCdVisible()
	{
		return true;
	}

	// Token: 0x04006655 RID: 26197
	private bool IsEnableInternal = true;

	// Token: 0x04006656 RID: 26198
	private readonly int SkillId;

	// Token: 0x04006657 RID: 26199
	private SSkillInfo SkillConfig;

	// Token: 0x04006658 RID: 26200
	private GroupSkillCdInfo GroupSkillCdInfo;

	// Token: 0x04006659 RID: 26201
	private EntityHandle EntityHandle;

	// Token: 0x0400665A RID: 26202
	private CharacterSkillComponent CharacterSkillComponent;

	// Token: 0x0400665B RID: 26203
	private CharacterSkillCdComponent CharacterSkillCdComponent;
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Input;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Module.GameMainView.Data;
using CSharpScript.Game.Module.SkillButtonUi;

// Token: 0x02001D3F RID: 7487
[NullableContext(2)]
[Nullable(0)]
public class TrapDefenseBattleSkillData : BattleSkillDataBase
{
	// Token: 0x0600E313 RID: 58131 RVA: 0x00355ED4 File Offset: 0x003540D4
	protected override void OnInitData()
	{
		this.Config = this.GetSkillDataConfig(base.GetActionName());
		this.EntityHandle = SceneTeamModel.Instance.GetCurrentEntity;
		if (this.EntityHandle != null)
		{
			WorldEntity entity = this.EntityHandle.Entity;
			if (entity != null)
			{
				this.GameplayTagComponent = entity.GetComponent<BaseTagComponent>();
				this.CharacterSkillCdComponent = entity.GetComponent<CharacterSkillCdComponent>();
			}
		}
		if (this.Config != null)
		{
			this.InitSkill();
		}
	}

	// Token: 0x0600E314 RID: 58132 RVA: 0x00355F45 File Offset: 0x00354145
	protected virtual void InitSkill()
	{
		this.RefreshSkillTexturePath();
	}

	// Token: 0x0600E315 RID: 58133 RVA: 0x00355F50 File Offset: 0x00354150
	[NullableContext(1)]
	protected SkillGameplayButton? GetSkillDataConfig(string actionName)
	{
		IReadOnlyList<SkillGameplayButton> trapDefenseSkillButtonConfigByType = TrapDefenseConfig.Instance.GetTrapDefenseSkillButtonConfigByType(1);
		if (trapDefenseSkillButtonConfigByType != null)
		{
			for (int i = 0; i < trapDefenseSkillButtonConfigByType.Count; i++)
			{
				SkillGameplayButton value = trapDefenseSkillButtonConfigByType[i];
				if (value.ActionName == actionName)
				{
					return new SkillGameplayButton?(value);
				}
			}
		}
		return null;
	}

	// Token: 0x0600E316 RID: 58134 RVA: 0x00355FA4 File Offset: 0x003541A4
	protected virtual void RefreshSkillTexturePath()
	{
		if (this.Config == null)
		{
			return;
		}
		this.SkillTexturePath = this.Config.Value.SkillIcon;
	}

	// Token: 0x0600E317 RID: 58135 RVA: 0x00355FD8 File Offset: 0x003541D8
	public override string GetSkillTexturePath()
	{
		return this.SkillTexturePath;
	}

	// Token: 0x0600E318 RID: 58136 RVA: 0x00355FE0 File Offset: 0x003541E0
	public override void RefreshLongPressTime()
	{
		if (this.Config == null)
		{
			return;
		}
		this.LongPressTime = (float)this.Config.Value.LongPressTime / 1000f;
	}

	// Token: 0x0600E319 RID: 58137 RVA: 0x0035601B File Offset: 0x0035421B
	public override double GetLongPressTime()
	{
		return (double)this.LongPressTime;
	}

	// Token: 0x0600E31A RID: 58138 RVA: 0x00356024 File Offset: 0x00354224
	public override bool? GetIsLongPressControlCamera()
	{
		if (this.Config == null)
		{
			return new bool?(false);
		}
		return new bool?(this.Config.Value.IsLongPressControlCamera);
	}

	// Token: 0x0600E31B RID: 58139 RVA: 0x00356060 File Offset: 0x00354260
	public override EInputAction GetActionType()
	{
		if (this.Config == null)
		{
			return EInputAction.None;
		}
		return (EInputAction)((byte)this.Config.Value.ButtonType);
	}

	// Token: 0x0600E31C RID: 58140 RVA: 0x0035609C File Offset: 0x0035429C
	public override ESkillButtonType GetButtonType()
	{
		if (this.Config == null)
		{
			return ESkillButtonType.None;
		}
		return (ESkillButtonType)this.Config.Value.ButtonType;
	}

	// Token: 0x0600E31D RID: 58141 RVA: 0x003560CB File Offset: 0x003542CB
	public override bool IsEnable()
	{
		return this.IsEnableInternal;
	}

	// Token: 0x0600E31E RID: 58142 RVA: 0x003560D3 File Offset: 0x003542D3
	public void SetEnable(bool enable)
	{
		this.IsEnableInternal = enable;
	}

	// Token: 0x0600E31F RID: 58143 RVA: 0x003560DC File Offset: 0x003542DC
	public void SetVisible(bool visible)
	{
		this.IsVisibleInternal = visible;
	}

	// Token: 0x0600E320 RID: 58144 RVA: 0x003560E8 File Offset: 0x003542E8
	public virtual void RefreshSkillCd()
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

	// Token: 0x0600E321 RID: 58145 RVA: 0x0035611F File Offset: 0x0035431F
	public void SetIsBuilding(bool isBuilding)
	{
		this.IsBuilding = isBuilding;
	}

	// Token: 0x0600E322 RID: 58146 RVA: 0x00356128 File Offset: 0x00354328
	public override bool IsCdVisible()
	{
		if (this.IsBuilding)
		{
			return false;
		}
		int? followerProxyId = TowerDefensePlayerController.GetFollowerProxyId();
		if (followerProxyId == null)
		{
			return false;
		}
		TrapDefenseAuxiliary? auxiliaryById = TrapDefenseConfig.Instance.GetAuxiliaryById(followerProxyId.Value);
		return auxiliaryById != null && auxiliaryById.GetValueOrDefault().CDSkill == 1;
	}

	// Token: 0x0600E323 RID: 58147 RVA: 0x00356180 File Offset: 0x00354380
	public override string GetSkillIconName()
	{
		if (this.Config == null)
		{
			return null;
		}
		if (base.GetActionName() == "塔防射击" && !this.IsBuilding)
		{
			return null;
		}
		return this.Config.Value.Name;
	}

	// Token: 0x040068DF RID: 26847
	protected float LongPressTime;

	// Token: 0x040068E0 RID: 26848
	protected SkillGameplayButton? Config;

	// Token: 0x040068E1 RID: 26849
	protected EntityHandle EntityHandle;

	// Token: 0x040068E2 RID: 26850
	protected BaseTagComponent GameplayTagComponent;

	// Token: 0x040068E3 RID: 26851
	protected CharacterSkillCdComponent CharacterSkillCdComponent;

	// Token: 0x040068E4 RID: 26852
	protected string SkillTexturePath;

	// Token: 0x040068E5 RID: 26853
	protected bool IsEnableInternal = true;

	// Token: 0x040068E6 RID: 26854
	private bool IsBuilding;
}

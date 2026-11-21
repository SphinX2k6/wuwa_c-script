using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Input;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Module.GameMainView.Data;
using CSharpScript.Game.Module.SkillButtonUi;

// Token: 0x02001201 RID: 4609
[NullableContext(2)]
[Nullable(0)]
public class TrapDefenseBattleSkillData : BattleSkillDataBase
{
	// Token: 0x0600B730 RID: 46896 RVA: 0x00361904 File Offset: 0x0035FB04
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

	// Token: 0x0600B731 RID: 46897 RVA: 0x00361975 File Offset: 0x0035FB75
	protected virtual void InitSkill()
	{
		this.RefreshSkillTexturePath();
	}

	// Token: 0x0600B732 RID: 46898 RVA: 0x00361980 File Offset: 0x0035FB80
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

	// Token: 0x0600B733 RID: 46899 RVA: 0x003619D4 File Offset: 0x0035FBD4
	protected virtual void RefreshSkillTexturePath()
	{
		if (this.Config == null)
		{
			return;
		}
		this.SkillTexturePath = this.Config.Value.SkillIcon;
	}

	// Token: 0x0600B734 RID: 46900 RVA: 0x00361A08 File Offset: 0x0035FC08
	public override string GetSkillTexturePath()
	{
		return this.SkillTexturePath;
	}

	// Token: 0x0600B735 RID: 46901 RVA: 0x00361A10 File Offset: 0x0035FC10
	public override void RefreshLongPressTime()
	{
		if (this.Config == null)
		{
			return;
		}
		this.LongPressTime = (float)this.Config.Value.LongPressTime / 1000f;
	}

	// Token: 0x0600B736 RID: 46902 RVA: 0x00361A4B File Offset: 0x0035FC4B
	public override double GetLongPressTime()
	{
		return (double)this.LongPressTime;
	}

	// Token: 0x0600B737 RID: 46903 RVA: 0x00361A54 File Offset: 0x0035FC54
	public override bool? GetIsLongPressControlCamera()
	{
		if (this.Config == null)
		{
			return new bool?(false);
		}
		return new bool?(this.Config.Value.IsLongPressControlCamera);
	}

	// Token: 0x0600B738 RID: 46904 RVA: 0x00361A90 File Offset: 0x0035FC90
	public override EInputAction GetActionType()
	{
		if (this.Config == null)
		{
			return EInputAction.None;
		}
		return (EInputAction)((byte)this.Config.Value.ButtonType);
	}

	// Token: 0x0600B739 RID: 46905 RVA: 0x00361ACC File Offset: 0x0035FCCC
	public override ESkillButtonType GetButtonType()
	{
		if (this.Config == null)
		{
			return ESkillButtonType.None;
		}
		return (ESkillButtonType)this.Config.Value.ButtonType;
	}

	// Token: 0x0600B73A RID: 46906 RVA: 0x00361AFB File Offset: 0x0035FCFB
	public override bool IsEnable()
	{
		return this.IsEnableInternal;
	}

	// Token: 0x0600B73B RID: 46907 RVA: 0x00361B03 File Offset: 0x0035FD03
	public void SetEnable(bool enable)
	{
		this.IsEnableInternal = enable;
	}

	// Token: 0x0600B73C RID: 46908 RVA: 0x00361B0C File Offset: 0x0035FD0C
	public void SetVisible(bool visible)
	{
		this.IsVisibleInternal = visible;
	}

	// Token: 0x0600B73D RID: 46909 RVA: 0x00361B18 File Offset: 0x0035FD18
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

	// Token: 0x0600B73E RID: 46910 RVA: 0x00361B4F File Offset: 0x0035FD4F
	public void SetIsBuilding(bool isBuilding)
	{
		this.IsBuilding = isBuilding;
	}

	// Token: 0x0600B73F RID: 46911 RVA: 0x00361B58 File Offset: 0x0035FD58
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

	// Token: 0x0600B740 RID: 46912 RVA: 0x00361BB0 File Offset: 0x0035FDB0
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

	// Token: 0x040069BE RID: 27070
	protected float LongPressTime;

	// Token: 0x040069BF RID: 27071
	protected SkillGameplayButton? Config;

	// Token: 0x040069C0 RID: 27072
	protected EntityHandle EntityHandle;

	// Token: 0x040069C1 RID: 27073
	protected BaseTagComponent GameplayTagComponent;

	// Token: 0x040069C2 RID: 27074
	protected CharacterSkillCdComponent CharacterSkillCdComponent;

	// Token: 0x040069C3 RID: 27075
	protected string SkillTexturePath;

	// Token: 0x040069C4 RID: 27076
	protected bool IsEnableInternal = true;

	// Token: 0x040069C5 RID: 27077
	private bool IsBuilding;
}

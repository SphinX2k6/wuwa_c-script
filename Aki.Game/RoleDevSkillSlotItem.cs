using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001D9C RID: 7580
public class RoleDevSkillSlotItem : UiPanelBase
{
	// Token: 0x06012C29 RID: 76841 RVA: 0x0058391C File Offset: 0x00581B1C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISpriteTransition)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.OnSkillSlotClick))
		};
	}

	// Token: 0x06012C2A RID: 76842 RVA: 0x005839B0 File Offset: 0x00581BB0
	[NullableContext(2)]
	public void Refresh(ISkillSlotExtendData data)
	{
		if (data == null)
		{
			return;
		}
		this.RoleId = data.RoleId;
		this.SkillNodeId = data.SkillNodeId;
		this.CurrentLevel = data.CurrentLevel;
		this.NormalTargetLevel = data.NormalTargetLevel;
		this.PerfectTargetLevel = data.PerfectTargetLevel;
		this.IsForecastRole = (RoleDevUtils.GetRoleTypeTagByRoleId(this.RoleId) == ERoleTypeTag.Forecast);
		this.RefreshSkillIcon();
		this.RefreshSkillLevel();
		this.RefreshLockState();
		bool selfInteractive = RoleModel.Instance.GetRoleInstanceById(this.RoleId) != null;
		UUIButtonComponent button = base.GetButton(3);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(selfInteractive);
	}

	// Token: 0x06012C2B RID: 76843 RVA: 0x00583A4C File Offset: 0x00581C4C
	private void RefreshSkillIcon()
	{
		if (this.IsForecastRole)
		{
			return;
		}
		SkillTree? skillTreeNode = RoleSkillConfig.Instance.GetSkillTreeNode(this.SkillNodeId);
		if (skillTreeNode == null)
		{
			return;
		}
		UUISpriteTransition uiSpriteTransition = base.GetUiSpriteTransition(0);
		if (uiSpriteTransition == null)
		{
			return;
		}
		string text = null;
		if (skillTreeNode.Value.SkillId > 0)
		{
			Aki.Config.Skill? skillConfigById = RoleSkillConfig.Instance.GetSkillConfigById(skillTreeNode.Value.SkillId);
			if (skillConfigById != null)
			{
				text = skillConfigById.Value.Icon;
			}
		}
		else
		{
			text = skillTreeNode.Value.PropertyNodeIcon;
		}
		if (!string.IsNullOrEmpty(text))
		{
			base.SetSpriteTransitionByPath(text, uiSpriteTransition, EUISelectableSelectionState.EUISelectableSelectionState_MAX).Forget();
		}
	}

	// Token: 0x06012C2C RID: 76844 RVA: 0x00583AFC File Offset: 0x00581CFC
	private void RefreshSkillLevel()
	{
		UUIText text = base.GetText(2);
		if (text == null)
		{
			return;
		}
		if (this.IsForecastRole)
		{
			LguiUtil.Instance.SetLocalText(text, "LevelRichText", new <>z__ReadOnlyArray<object>(new object[]
			{
				1,
				10
			}));
			return;
		}
		if (this.IsPerfectPlan)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 2);
			defaultInterpolatedStringHandler.AppendLiteral("Lv.");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.CurrentLevel);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.PerfectTargetLevel);
			string text2 = defaultInterpolatedStringHandler.ToStringAndClear();
			if (this.CurrentLevel >= this.PerfectTargetLevel)
			{
				LguiUtil.Instance.SetLocalTextNew(text, "RoleProject_SkillLevel01", new object[]
				{
					text2
				});
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(text, "RoleProject_SkillLevel02", new object[]
			{
				text2
			});
			return;
		}
		else
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 2);
			defaultInterpolatedStringHandler.AppendLiteral("Lv.");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.CurrentLevel);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.NormalTargetLevel);
			string text3 = defaultInterpolatedStringHandler.ToStringAndClear();
			if (this.CurrentLevel >= this.NormalTargetLevel)
			{
				LguiUtil.Instance.SetLocalTextNew(text, "RoleProject_SkillLevel01", new object[]
				{
					text3
				});
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(text, "RoleProject_SkillLevel02", new object[]
			{
				text3
			});
			return;
		}
	}

	// Token: 0x06012C2D RID: 76845 RVA: 0x00583C64 File Offset: 0x00581E64
	private void RefreshLockState()
	{
		bool isForecastRole = this.IsForecastRole;
		UUISprite sprite = base.GetSprite(1);
		UUISpriteTransition uiSpriteTransition = base.GetUiSpriteTransition(0);
		if (sprite != null)
		{
			sprite.SetUIActive(isForecastRole);
		}
		if (uiSpriteTransition != null)
		{
			uiSpriteTransition.RootUIComp.Get().SetUIActive(!isForecastRole);
		}
		if (uiSpriteTransition != null)
		{
			UUIItem uuiitem = uiSpriteTransition.RootUIComp.Get();
			bool bUseChangeColor = isForecastRole;
			FColor? fcolor = new FColor?(uiSpriteTransition.RootUIComp.Get().changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		}
	}

	// Token: 0x06012C2E RID: 76846 RVA: 0x00583CDF File Offset: 0x00581EDF
	public void SetIsPerfectPlan(bool isPerfectPlan)
	{
		this.IsPerfectPlan = isPerfectPlan;
	}

	// Token: 0x06012C2F RID: 76847 RVA: 0x00583CE8 File Offset: 0x00581EE8
	[NullableContext(1)]
	public void SetClickCallback(Action callback)
	{
		this.ClickCallback = callback;
	}

	// Token: 0x06012C30 RID: 76848 RVA: 0x00583CF1 File Offset: 0x00581EF1
	private void OnSkillSlotClick()
	{
		Action clickCallback = this.ClickCallback;
		if (clickCallback == null)
		{
			return;
		}
		clickCallback();
	}

	// Token: 0x0400A242 RID: 41538
	private int RoleId;

	// Token: 0x0400A243 RID: 41539
	private int SkillNodeId;

	// Token: 0x0400A244 RID: 41540
	private int CurrentLevel;

	// Token: 0x0400A245 RID: 41541
	private int NormalTargetLevel;

	// Token: 0x0400A246 RID: 41542
	private int PerfectTargetLevel;

	// Token: 0x0400A247 RID: 41543
	private bool IsPerfectPlan;

	// Token: 0x0400A248 RID: 41544
	private bool IsForecastRole;

	// Token: 0x0400A249 RID: 41545
	[Nullable(2)]
	private Action ClickCallback;

	// Token: 0x020080AC RID: 32940
	private enum EComponent
	{
		// Token: 0x040299E8 RID: 170472
		SpriteSkill,
		// Token: 0x040299E9 RID: 170473
		SpriteLock,
		// Token: 0x040299EA RID: 170474
		TxtSkillNum,
		// Token: 0x040299EB RID: 170475
		BtnSkillSlot
	}
}

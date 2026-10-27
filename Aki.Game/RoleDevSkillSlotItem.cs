using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02002821 RID: 10273
public class RoleDevSkillSlotItem : UiPanelBase
{
	// Token: 0x0601522B RID: 86571 RVA: 0x00558C08 File Offset: 0x00556E08
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

	// Token: 0x0601522C RID: 86572 RVA: 0x00558C9C File Offset: 0x00556E9C
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

	// Token: 0x0601522D RID: 86573 RVA: 0x00558D38 File Offset: 0x00556F38
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

	// Token: 0x0601522E RID: 86574 RVA: 0x00558DE8 File Offset: 0x00556FE8
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

	// Token: 0x0601522F RID: 86575 RVA: 0x00558F50 File Offset: 0x00557150
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

	// Token: 0x06015230 RID: 86576 RVA: 0x00558FCB File Offset: 0x005571CB
	public void SetIsPerfectPlan(bool isPerfectPlan)
	{
		this.IsPerfectPlan = isPerfectPlan;
	}

	// Token: 0x06015231 RID: 86577 RVA: 0x00558FD4 File Offset: 0x005571D4
	[NullableContext(1)]
	public void SetClickCallback(Action callback)
	{
		this.ClickCallback = callback;
	}

	// Token: 0x06015232 RID: 86578 RVA: 0x00558FDD File Offset: 0x005571DD
	private void OnSkillSlotClick()
	{
		Action clickCallback = this.ClickCallback;
		if (clickCallback == null)
		{
			return;
		}
		clickCallback();
	}

	// Token: 0x04009E59 RID: 40537
	private int RoleId;

	// Token: 0x04009E5A RID: 40538
	private int SkillNodeId;

	// Token: 0x04009E5B RID: 40539
	private int CurrentLevel;

	// Token: 0x04009E5C RID: 40540
	private int NormalTargetLevel;

	// Token: 0x04009E5D RID: 40541
	private int PerfectTargetLevel;

	// Token: 0x04009E5E RID: 40542
	private bool IsPerfectPlan;

	// Token: 0x04009E5F RID: 40543
	private bool IsForecastRole;

	// Token: 0x04009E60 RID: 40544
	[Nullable(2)]
	private Action ClickCallback;

	// Token: 0x02008E64 RID: 36452
	private enum EComponent
	{
		// Token: 0x0402E2EC RID: 189164
		SpriteSkill,
		// Token: 0x0402E2ED RID: 189165
		SpriteLock,
		// Token: 0x0402E2EE RID: 189166
		TxtSkillNum,
		// Token: 0x0402E2EF RID: 189167
		BtnSkillSlot
	}
}

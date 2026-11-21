using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000AAF RID: 2735
[NullableContext(2)]
[Nullable(0)]
public class WheelTowerTeamSelectMainPanel : UiPanelBase
{
	// Token: 0x0600727F RID: 29311 RVA: 0x00234354 File Offset: 0x00232554
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06007280 RID: 29312 RVA: 0x00234420 File Offset: 0x00232620
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerTeamSelectMainPanel.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerTeamSelectMainPanel.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007281 RID: 29313 RVA: 0x00234463 File Offset: 0x00232663
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add<int>(EEventName.OnRoleSkillBranchChanged, new Action<int>(this.OnRoleSkillBranchChanged));
		EventSystem.Instance.Add<int>(EEventName.OnRoleSkillBranchInGamePlayChanged, new Action<int>(this.OnRoleSkillBranchChanged));
	}

	// Token: 0x06007282 RID: 29314 RVA: 0x0023449D File Offset: 0x0023269D
	protected override void OnAfterHide()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnRoleSkillBranchChanged, new Action<int>(this.OnRoleSkillBranchChanged));
		EventSystem.Instance.Remove<int>(EEventName.OnRoleSkillBranchInGamePlayChanged, new Action<int>(this.OnRoleSkillBranchChanged));
	}

	// Token: 0x06007283 RID: 29315 RVA: 0x002344D8 File Offset: 0x002326D8
	protected override void OnStart()
	{
		this.TabComponent = new GenericLayout<TeamTabItem, string>(base.GetHorizontalLayout(0), new Func<TeamTabItem>(this.CreateTab), null, false, true);
		this.TabComponent.RefreshByData(new <>z__ReadOnlyArray<string>(new string[]
		{
			"WheelBattleSelect_Role",
			"WheelBattleSelect_Team",
			"WheelBattleSelect_Template"
		}), delegate
		{
			this.OnClickTab(0);
		}, false);
		this.RoleSelectPanel.OnRoleSelect = delegate(int roleId)
		{
			Action<int> onRoleSelect = this.OnRoleSelect;
			if (onRoleSelect == null)
			{
				return;
			}
			onRoleSelect(roleId);
		};
		this.TeamSelectPanel.OnTeamSelectCallback = delegate(int teamId)
		{
			Action<int> onTeamSelect = this.OnTeamSelect;
			if (onTeamSelect == null)
			{
				return;
			}
			onTeamSelect(teamId);
		};
		this.TemplateSelectPanel.OnTemplateSelect = delegate(int roleId)
		{
			Action<int> onRoleSelect = this.OnRoleSelect;
			if (onRoleSelect == null)
			{
				return;
			}
			onRoleSelect(roleId);
		};
	}

	// Token: 0x06007284 RID: 29316 RVA: 0x00234588 File Offset: 0x00232788
	public void RefreshPanel()
	{
		GenericLayout<TeamTabItem, string> tabComponent = this.TabComponent;
		int num = (tabComponent != null) ? tabComponent.GetSelectedGridIndex() : -1;
		if (num < 0)
		{
			return;
		}
		switch (num)
		{
		case 0:
		{
			WheelTowerRoleSelectPanel roleSelectPanel = this.RoleSelectPanel;
			if (roleSelectPanel == null)
			{
				return;
			}
			roleSelectPanel.OnlyRefreshScroll();
			return;
		}
		case 1:
		{
			WheelTowerTeamSelectPanel teamSelectPanel = this.TeamSelectPanel;
			if (teamSelectPanel == null)
			{
				return;
			}
			teamSelectPanel.Refresh();
			return;
		}
		case 2:
		{
			WheelTowerTemplateSelectPanel templateSelectPanel = this.TemplateSelectPanel;
			if (templateSelectPanel == null)
			{
				return;
			}
			templateSelectPanel.OnlyRefreshScroll();
			return;
		}
		default:
			return;
		}
	}

	// Token: 0x06007285 RID: 29317 RVA: 0x002345F4 File Offset: 0x002327F4
	public UUIItem GetTabItem(int index)
	{
		GenericLayout<TeamTabItem, string> tabComponent = this.TabComponent;
		if (tabComponent == null)
		{
			return null;
		}
		return tabComponent.GetGridByDisplayIndex(index);
	}

	// Token: 0x06007286 RID: 29318 RVA: 0x00234608 File Offset: 0x00232808
	private void OnRoleSkillBranchChanged(int roleId)
	{
		GenericLayout<TeamTabItem, string> tabComponent = this.TabComponent;
		int num = (tabComponent != null) ? tabComponent.GetSelectedGridIndex() : -1;
		if (num < 0)
		{
			return;
		}
		switch (num)
		{
		case 0:
		{
			WheelTowerRoleSelectPanel roleSelectPanel = this.RoleSelectPanel;
			if (roleSelectPanel == null)
			{
				return;
			}
			roleSelectPanel.RefreshRoleSkillBranch(roleId);
			return;
		}
		case 1:
		{
			WheelTowerTeamSelectPanel teamSelectPanel = this.TeamSelectPanel;
			if (teamSelectPanel == null)
			{
				return;
			}
			teamSelectPanel.Refresh();
			return;
		}
		case 2:
		{
			WheelTowerTemplateSelectPanel templateSelectPanel = this.TemplateSelectPanel;
			if (templateSelectPanel == null)
			{
				return;
			}
			templateSelectPanel.RefreshRoleSkillBranch(roleId);
			return;
		}
		default:
			return;
		}
	}

	// Token: 0x06007287 RID: 29319 RVA: 0x00234676 File Offset: 0x00232876
	[NullableContext(1)]
	private TeamTabItem CreateTab()
	{
		TeamTabItem teamTabItem = new TeamTabItem();
		teamTabItem.SetToggleClickCallback(new Action<int>(this.OnClickTab));
		return teamTabItem;
	}

	// Token: 0x06007288 RID: 29320 RVA: 0x00234690 File Offset: 0x00232890
	private void OnClickTab(int index)
	{
		GenericLayout<TeamTabItem, string> tabComponent = this.TabComponent;
		if (tabComponent != null)
		{
			tabComponent.SelectGridProxy(index, false);
		}
		WheelTowerRoleSelectPanel roleSelectPanel = this.RoleSelectPanel;
		if (roleSelectPanel != null)
		{
			roleSelectPanel.SetUiActive(index == 0);
		}
		WheelTowerTeamSelectPanel teamSelectPanel = this.TeamSelectPanel;
		if (teamSelectPanel != null)
		{
			teamSelectPanel.SetUiActive(index == 1);
		}
		WheelTowerTemplateSelectPanel templateSelectPanel = this.TemplateSelectPanel;
		if (templateSelectPanel != null)
		{
			templateSelectPanel.SetUiActive(index == 2);
		}
		int arg = 0;
		switch (index)
		{
		case 0:
		{
			WheelTowerRoleSelectPanel roleSelectPanel2 = this.RoleSelectPanel;
			if (roleSelectPanel2 != null)
			{
				roleSelectPanel2.Refresh();
			}
			WheelTowerRoleSelectPanel roleSelectPanel3 = this.RoleSelectPanel;
			arg = ((roleSelectPanel3 != null) ? roleSelectPanel3.GetFirstRoleId() : 0);
			break;
		}
		case 1:
		{
			WheelTowerTeamSelectPanel teamSelectPanel2 = this.TeamSelectPanel;
			if (teamSelectPanel2 != null)
			{
				teamSelectPanel2.Refresh();
			}
			break;
		}
		case 2:
		{
			WheelTowerTemplateSelectPanel templateSelectPanel2 = this.TemplateSelectPanel;
			if (templateSelectPanel2 != null)
			{
				templateSelectPanel2.Refresh();
			}
			WheelTowerTemplateSelectPanel templateSelectPanel3 = this.TemplateSelectPanel;
			arg = ((templateSelectPanel3 != null) ? templateSelectPanel3.GetFirstRoleId() : 0);
			break;
		}
		}
		Action<ESelectMode, int> onSelectModeChange = this.OnSelectModeChange;
		if (onSelectModeChange == null)
		{
			return;
		}
		onSelectModeChange((ESelectMode)index, arg);
	}

	// Token: 0x04004794 RID: 18324
	public Action<ESelectMode, int> OnSelectModeChange;

	// Token: 0x04004795 RID: 18325
	public Action<int> OnRoleSelect;

	// Token: 0x04004796 RID: 18326
	public Action<int> OnTeamSelect;

	// Token: 0x04004797 RID: 18327
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<TeamTabItem, string> TabComponent;

	// Token: 0x04004798 RID: 18328
	private WheelTowerRoleSelectPanel RoleSelectPanel;

	// Token: 0x04004799 RID: 18329
	private WheelTowerTeamSelectPanel TeamSelectPanel;

	// Token: 0x0400479A RID: 18330
	private WheelTowerTemplateSelectPanel TemplateSelectPanel;
}

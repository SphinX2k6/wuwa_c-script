using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.TrapDefense;

// Token: 0x02001D48 RID: 7496
public class TrapDefenseInterfaceLogic : ITrapDefenseMachineSelectInterface
{
	// Token: 0x0600E349 RID: 58185 RVA: 0x00356629 File Offset: 0x00354829
	[NullableContext(1)]
	public TrapDefenseInterfaceLogic(TrapDefenseMainViewProxy viewProxy)
	{
		this.ViewProxy = viewProxy;
	}

	// Token: 0x0600E34A RID: 58186 RVA: 0x00356638 File Offset: 0x00354838
	[NullableContext(2)]
	public void SelectMachine(TrapDefenseBuildingDevelopItemData data)
	{
		bool flag = data != null && data.IsBuilding;
		TrapDefenseMobileSkillPanel mobileSkillPanel = this.ViewProxy.MobileSkillPanel;
		if (mobileSkillPanel != null)
		{
			mobileSkillPanel.SetIsInBuild(flag);
		}
		TrapDefenseDesktopSkillPanel desktopSkillPanel = this.ViewProxy.DesktopSkillPanel;
		if (desktopSkillPanel != null)
		{
			desktopSkillPanel.RefreshButtonByIsInBuild(flag);
		}
		this.ViewProxy.BuildTipsPanel.SetIsInSelectBuild(flag);
		this.ViewProxy.BuildTipsPanel.ResetCannotMode();
		this.ViewProxy.MachineTipsPanel.SetMachineItem(data);
		TrapDefensePsFeedbackManager.TryRefreshFeedback();
	}

	// Token: 0x0600E34B RID: 58187 RVA: 0x003566B7 File Offset: 0x003548B7
	public void SliderPointerDown()
	{
		TrapDefenseMobileSkillPanel mobileSkillPanel = this.ViewProxy.MobileSkillPanel;
		if (mobileSkillPanel == null)
		{
			return;
		}
		mobileSkillPanel.HideBattleChildViewPanel();
	}

	// Token: 0x0600E34C RID: 58188 RVA: 0x003566CE File Offset: 0x003548CE
	[NullableContext(2)]
	public void SliderValueChange(TrapDefenseBuildingDevelopItemData data)
	{
		this.ViewProxy.MachineTipsPanel.SetMachineItem(data);
	}

	// Token: 0x0600E34D RID: 58189 RVA: 0x003566E1 File Offset: 0x003548E1
	public void SliderDragEnd()
	{
		TrapDefenseMobileSkillPanel mobileSkillPanel = this.ViewProxy.MobileSkillPanel;
		if (mobileSkillPanel == null)
		{
			return;
		}
		mobileSkillPanel.ShowBattleChildViewPanel();
	}

	// Token: 0x040068F3 RID: 26867
	[Nullable(1)]
	protected TrapDefenseMainViewProxy ViewProxy;
}

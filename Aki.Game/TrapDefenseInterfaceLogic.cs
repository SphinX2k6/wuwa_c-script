using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.TrapDefense;

// Token: 0x0200120A RID: 4618
public class TrapDefenseInterfaceLogic : ITrapDefenseMachineSelectInterface
{
	// Token: 0x0600B766 RID: 46950 RVA: 0x00362059 File Offset: 0x00360259
	[NullableContext(1)]
	public TrapDefenseInterfaceLogic(TrapDefenseMainViewProxy viewProxy)
	{
		this.ViewProxy = viewProxy;
	}

	// Token: 0x0600B767 RID: 46951 RVA: 0x00362068 File Offset: 0x00360268
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

	// Token: 0x0600B768 RID: 46952 RVA: 0x003620E7 File Offset: 0x003602E7
	public void SliderPointerDown()
	{
		TrapDefenseMobileSkillPanel mobileSkillPanel = this.ViewProxy.MobileSkillPanel;
		if (mobileSkillPanel == null)
		{
			return;
		}
		mobileSkillPanel.HideBattleChildViewPanel();
	}

	// Token: 0x0600B769 RID: 46953 RVA: 0x003620FE File Offset: 0x003602FE
	[NullableContext(2)]
	public void SliderValueChange(TrapDefenseBuildingDevelopItemData data)
	{
		this.ViewProxy.MachineTipsPanel.SetMachineItem(data);
	}

	// Token: 0x0600B76A RID: 46954 RVA: 0x00362111 File Offset: 0x00360311
	public void SliderDragEnd()
	{
		TrapDefenseMobileSkillPanel mobileSkillPanel = this.ViewProxy.MobileSkillPanel;
		if (mobileSkillPanel == null)
		{
			return;
		}
		mobileSkillPanel.ShowBattleChildViewPanel();
	}

	// Token: 0x040069D2 RID: 27090
	[Nullable(1)]
	protected TrapDefenseMainViewProxy ViewProxy;
}

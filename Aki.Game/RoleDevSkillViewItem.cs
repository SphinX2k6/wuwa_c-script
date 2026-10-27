using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleDev;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002822 RID: 10274
[NullableContext(1)]
[Nullable(0)]
public class RoleDevSkillViewItem : UiPanelBase
{
	// Token: 0x06015234 RID: 86580 RVA: 0x00558FF8 File Offset: 0x005571F8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIText)),
			new ValueTuple<int, Type>(16, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.OnClickSwitchState))
		};
	}

	// Token: 0x06015235 RID: 86581 RVA: 0x005591B4 File Offset: 0x005573B4
	protected override UniTask OnBeforeStartAsync()
	{
		RoleDevSkillViewItem.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevSkillViewItem.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015236 RID: 86582 RVA: 0x005591F7 File Offset: 0x005573F7
	protected override void OnBeforeCreateImplement()
	{
		this.UiViewSequence = new UiBehaviorLevelSequence(this);
		base.AddUiBehavior(this.UiViewSequence);
	}

	// Token: 0x06015237 RID: 86583 RVA: 0x00559211 File Offset: 0x00557411
	public void Refresh(RoleDevSkillViewItemDataBase data)
	{
		this.Data = data;
		this.RefreshSkillSlots(data);
		this.HandlePerfectPlan(data);
		this.RefreshDetailItems(data);
		this.RefreshButtonStates(data);
	}

	// Token: 0x06015238 RID: 86584 RVA: 0x00559238 File Offset: 0x00557438
	private void HandlePerfectPlan(RoleDevSkillViewItemDataBase data)
	{
		bool flag = RoleDevUtils.GetRoleTypeTagByRoleId(data.RoleId) == global::ERoleTypeTag.Forecast;
		string textStringId = (data.IsPerfectPlan || data.ShouldForcePerfectPlan) ? "RoleProject_SkillUpgradePrefect" : "RoleProject_SkillUpgradeBasic";
		LguiUtil.Instance.SetLocalTextNew(base.GetText(15), textStringId, Array.Empty<object>());
		if (flag)
		{
			UUIButtonComponent button = base.GetButton(1);
			UUIText text = base.GetText(0);
			if (button != null && text != null)
			{
				button.RootUIComp.Get().SetUIActive(false);
				text.SetUIActive(false);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(15), "RoleProject_SkillUpgradePrefect", Array.Empty<object>());
			return;
		}
		RoleDevCultivateProject? cultivateProject = RoleDevUtils.GetCultivateProject(data.RoleId);
		bool flag2 = cultivateProject != null && cultivateProject.Value.PrefectSkillLevel() != null && cultivateProject.Value.PrefectSkillLevel().Length != 0;
		UUIButtonComponent button2 = base.GetButton(1);
		UUIText text2 = base.GetText(0);
		if (button2 == null || text2 == null)
		{
			return;
		}
		bool flag3 = flag2 && !data.ShouldForcePerfectPlan;
		button2.RootUIComp.Get().SetUIActive(flag3);
		text2.SetUIActive(flag3);
		if (flag3)
		{
			string textStringId2 = data.IsPerfectPlan ? "RoleProject_Button_SkillUpgradeBasic" : "RoleProject_Button_SkillUpgradePrefect";
			LguiUtil.Instance.SetLocalTextNew(text2, textStringId2, Array.Empty<object>());
		}
	}

	// Token: 0x06015239 RID: 86585 RVA: 0x00559394 File Offset: 0x00557594
	private void RefreshDetailItems(RoleDevSkillViewItemDataBase data)
	{
		List<global::IRoleDevDetailItemData> list = (RoleDevUtils.GetRoleTypeTagByRoleId(data.RoleId) == global::ERoleTypeTag.Forecast || data.IsPerfectPlan || data.ShouldForcePerfectPlan) ? data.PerfectDetailItems : data.NormalDetailItems;
		GenericLayout<RoleDevDetailItem, global::IRoleDevDetailItemData> detailVerticalLayout = this.DetailVerticalLayout;
		if (detailVerticalLayout != null)
		{
			detailVerticalLayout.RefreshByData(list, null, false);
		}
		base.GetItem(16).SetUIActive(list.Count != 0);
	}

	// Token: 0x0601523A RID: 86586 RVA: 0x00559400 File Offset: 0x00557600
	private void RefreshButtonStates(RoleDevSkillViewItemDataBase data)
	{
		base.GetVerticalLayout(12).RootUIComp.Get().SetUIActive(true);
		int num = (RoleDevUtils.GetRoleTypeTagByRoleId(data.RoleId) == global::ERoleTypeTag.Forecast) ? 1 : 0;
		bool isRoleOwned = data.IsRoleOwned;
		bool flag = num == 0 && isRoleOwned;
		base.GetItem(7).SetUIActive(flag);
		base.GetItem(11).SetUIActive(!flag);
		if (!isRoleOwned)
		{
			ButtonItem normalButtonItem = this.NormalButtonItem;
			if (normalButtonItem != null)
			{
				normalButtonItem.SetUiActive(false);
			}
			ButtonItem highLightButtonItem = this.HighLightButtonItem;
			if (highLightButtonItem != null)
			{
				highLightButtonItem.SetUiActive(false);
			}
			base.GetItem(9).SetUIActive(false);
			return;
		}
		bool uiActive;
		bool uiActive2;
		string textId;
		bool flag2;
		if (data.CurrentPlanFinished)
		{
			bool isBreakthroughLevelLow = data.IsBreakthroughLevelLow;
			uiActive = true;
			uiActive2 = false;
			textId = "RoleProject_Button02";
			flag2 = isBreakthroughLevelLow;
		}
		else
		{
			bool currentPlanMaterialEnough = data.CurrentPlanMaterialEnough;
			uiActive = !currentPlanMaterialEnough;
			uiActive2 = currentPlanMaterialEnough;
			textId = "RoleProject_Button01";
			flag2 = false;
		}
		ButtonItem normalButtonItem2 = this.NormalButtonItem;
		if (normalButtonItem2 != null)
		{
			normalButtonItem2.SetLocalTextNew(textId, Array.Empty<object>());
		}
		ButtonItem highLightButtonItem2 = this.HighLightButtonItem;
		if (highLightButtonItem2 != null)
		{
			highLightButtonItem2.SetLocalTextNew(textId, Array.Empty<object>());
		}
		ButtonItem normalButtonItem3 = this.NormalButtonItem;
		if (normalButtonItem3 != null)
		{
			normalButtonItem3.SetUiActive(uiActive);
		}
		ButtonItem highLightButtonItem3 = this.HighLightButtonItem;
		if (highLightButtonItem3 != null)
		{
			highLightButtonItem3.SetUiActive(uiActive2);
		}
		base.GetItem(9).SetUIActive(flag2);
		if (flag2)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(9), "RoleProject_Tips05", Array.Empty<object>());
		}
	}

	// Token: 0x0601523B RID: 86587 RVA: 0x00559560 File Offset: 0x00557760
	private UniTask InitializeSkillSlots()
	{
		RoleDevSkillViewItem.<InitializeSkillSlots>d__18 <InitializeSkillSlots>d__;
		<InitializeSkillSlots>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeSkillSlots>d__.<>4__this = this;
		<InitializeSkillSlots>d__.<>1__state = -1;
		<InitializeSkillSlots>d__.<>t__builder.Start<RoleDevSkillViewItem.<InitializeSkillSlots>d__18>(ref <InitializeSkillSlots>d__);
		return <InitializeSkillSlots>d__.<>t__builder.Task;
	}

	// Token: 0x0601523C RID: 86588 RVA: 0x005595A4 File Offset: 0x005577A4
	private UniTask InitializeButtons()
	{
		RoleDevSkillViewItem.<InitializeButtons>d__19 <InitializeButtons>d__;
		<InitializeButtons>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeButtons>d__.<>4__this = this;
		<InitializeButtons>d__.<>1__state = -1;
		<InitializeButtons>d__.<>t__builder.Start<RoleDevSkillViewItem.<InitializeButtons>d__19>(ref <InitializeButtons>d__);
		return <InitializeButtons>d__.<>t__builder.Task;
	}

	// Token: 0x0601523D RID: 86589 RVA: 0x005595E8 File Offset: 0x005577E8
	private void RefreshSkillSlots(RoleDevSkillViewItemDataBase data)
	{
		List<global::ISkillSlotExtendData> skillSlots = data.SkillSlots;
		for (int i = 0; i < this.SkillSlotItems.Count; i++)
		{
			RoleDevSkillSlotItem roleDevSkillSlotItem = this.SkillSlotItems[i];
			global::ISkillSlotExtendData data2 = (i < skillSlots.Count) ? skillSlots[i] : null;
			roleDevSkillSlotItem.SetIsPerfectPlan(data.IsPerfectPlan || data.ShouldForcePerfectPlan);
			roleDevSkillSlotItem.Refresh(data2);
		}
	}

	// Token: 0x0601523E RID: 86590 RVA: 0x0055964F File Offset: 0x0055784F
	private RoleDevDetailItem CreateDetailItem()
	{
		return new RoleDevDetailItem();
	}

	// Token: 0x0601523F RID: 86591 RVA: 0x00559658 File Offset: 0x00557858
	private void OnClickSwitchState()
	{
		if (this.Data != null)
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null)
			{
				uiViewSequence.StopSequenceByKey("Switch", false, true);
			}
			UiBehaviorLevelSequence uiViewSequence2 = this.UiViewSequence;
			if (uiViewSequence2 != null)
			{
				uiViewSequence2.PlaySequence("Switch", false, null);
			}
			this.Data.SwitchPlan();
			Action<RoleDevSkillViewItemDataBase> onPlanChangeCallback = this.OnPlanChangeCallback;
			if (onPlanChangeCallback != null)
			{
				onPlanChangeCallback(this.Data);
			}
			RoleDevController.Instance.LogRoleDevSubPageClick(this.Data.RoleId, ERoleDevMainPage.Skill, ERoleDevSubPageButton.SkillSwitchToPlan);
			this.Refresh(this.Data);
		}
	}

	// Token: 0x06015240 RID: 86592 RVA: 0x005596EC File Offset: 0x005578EC
	private void OnClickBtnJump(int _)
	{
		RoleDevSkillViewItemDataBase data = this.Data;
		if (data != null && data.IsRoleOwned)
		{
			RoleDevSkillMergeViewParams roleDevSkillMergeViewParams = new RoleDevSkillMergeViewParams();
			RoleDevSkillViewItemDataBase data2 = this.Data;
			roleDevSkillMergeViewParams.RoleId = ((data2 != null) ? data2.RoleId : 0);
			roleDevSkillMergeViewParams.SkillNodeIndex = RoleDevConfig.Instance.GetDefaultSkillNodeIndex();
			RoleDevSkillMergeViewParams param = roleDevSkillMergeViewParams;
			bool currentPlanFinished = this.Data.CurrentPlanFinished;
			RoleDevController.Instance.LogRoleDevSubPageClick(this.Data.RoleId, ERoleDevMainPage.Skill, currentPlanFinished ? ERoleDevSubPageButton.SkillGoToView : ERoleDevSubPageButton.SkillGoToCultivation);
			UiManager.Instance.OpenView(EUiViewName.RoleSkillMergeView, param, null);
		}
	}

	// Token: 0x06015241 RID: 86593 RVA: 0x00559778 File Offset: 0x00557978
	private void OnSkillSlotClick(int index)
	{
		RoleDevSkillViewItemDataBase data = this.Data;
		List<global::ISkillSlotExtendData> list = ((data != null) ? data.SkillSlots : null) ?? new List<global::ISkillSlotExtendData>();
		global::ISkillSlotExtendData skillSlotExtendData = (index < list.Count) ? list[index] : null;
		if (skillSlotExtendData != null)
		{
			SkillTree? skillTreeNode = RoleSkillConfig.Instance.GetSkillTreeNode(skillSlotExtendData.SkillNodeId);
			RoleDevSkillMergeViewParams roleDevSkillMergeViewParams = new RoleDevSkillMergeViewParams();
			RoleDevSkillViewItemDataBase data2 = this.Data;
			roleDevSkillMergeViewParams.RoleId = ((data2 != null) ? data2.RoleId : 0);
			roleDevSkillMergeViewParams.SkillNodeIndex = ((skillTreeNode != null) ? skillTreeNode.GetValueOrDefault().NodeIndex : RoleDevConfig.Instance.GetDefaultSkillNodeIndex());
			RoleDevSkillMergeViewParams param = roleDevSkillMergeViewParams;
			UiManager.Instance.OpenView(EUiViewName.RoleSkillMergeView, param, null);
		}
	}

	// Token: 0x04009E61 RID: 40545
	private readonly List<RoleDevSkillSlotItem> SkillSlotItems = new List<RoleDevSkillSlotItem>();

	// Token: 0x04009E62 RID: 40546
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleDevDetailItem, global::IRoleDevDetailItemData> DetailVerticalLayout;

	// Token: 0x04009E63 RID: 40547
	[Nullable(2)]
	private RoleDevSkillViewItemDataBase Data;

	// Token: 0x04009E64 RID: 40548
	[Nullable(2)]
	private ButtonItem NormalButtonItem;

	// Token: 0x04009E65 RID: 40549
	[Nullable(2)]
	private ButtonItem HighLightButtonItem;

	// Token: 0x04009E66 RID: 40550
	[Nullable(2)]
	public Action<int> OnClickToggleCallBack;

	// Token: 0x04009E67 RID: 40551
	[Nullable(2)]
	public Func<int, bool> CanClickCallBack;

	// Token: 0x04009E68 RID: 40552
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<RoleDevSkillViewItemDataBase> OnConfirmCallback;

	// Token: 0x04009E69 RID: 40553
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<RoleDevSkillViewItemDataBase> OnPlanChangeCallback;

	// Token: 0x04009E6A RID: 40554
	[Nullable(2)]
	public UiBehaviorLevelSequence UiViewSequence;

	// Token: 0x02008E65 RID: 36453
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402E2F1 RID: 189169
		TxtSwitchState,
		// Token: 0x0402E2F2 RID: 189170
		BtnSwitchState,
		// Token: 0x0402E2F3 RID: 189171
		PanelSkillSlot0,
		// Token: 0x0402E2F4 RID: 189172
		PanelSkillSlot1,
		// Token: 0x0402E2F5 RID: 189173
		PanelSkillSlot2,
		// Token: 0x0402E2F6 RID: 189174
		PanelSkillSlot3,
		// Token: 0x0402E2F7 RID: 189175
		PanelSkillSlot4,
		// Token: 0x0402E2F8 RID: 189176
		PanelItemRight,
		// Token: 0x0402E2F9 RID: 189177
		BtnItemJump,
		// Token: 0x0402E2FA RID: 189178
		PanelTxtOffset,
		// Token: 0x0402E2FB RID: 189179
		BtnItemPerfectJump,
		// Token: 0x0402E2FC RID: 189180
		PanelItemRightLine,
		// Token: 0x0402E2FD RID: 189181
		PanelItemDetailLayout,
		// Token: 0x0402E2FE RID: 189182
		PanelItemList,
		// Token: 0x0402E2FF RID: 189183
		PanelSwitch,
		// Token: 0x0402E300 RID: 189184
		TxtTitle,
		// Token: 0x0402E301 RID: 189185
		PanelItemDescription
	}
}

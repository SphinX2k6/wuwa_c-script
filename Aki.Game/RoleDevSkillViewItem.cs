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

// Token: 0x02001D9D RID: 7581
[NullableContext(1)]
[Nullable(0)]
public class RoleDevSkillViewItem : UiPanelBase
{
	// Token: 0x06012C32 RID: 76850 RVA: 0x00583D0C File Offset: 0x00581F0C
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

	// Token: 0x06012C33 RID: 76851 RVA: 0x00583EC8 File Offset: 0x005820C8
	protected override UniTask OnBeforeStartAsync()
	{
		RoleDevSkillViewItem.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevSkillViewItem.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012C34 RID: 76852 RVA: 0x00583F0B File Offset: 0x0058210B
	protected override void OnBeforeCreateImplement()
	{
		this.UiViewSequence = new UiBehaviorLevelSequence(this);
		base.AddUiBehavior(this.UiViewSequence);
	}

	// Token: 0x06012C35 RID: 76853 RVA: 0x00583F25 File Offset: 0x00582125
	public void Refresh(RoleDevSkillViewItemDataBase data)
	{
		this.Data = data;
		this.RefreshSkillSlots(data);
		this.HandlePerfectPlan(data);
		this.RefreshDetailItems(data);
		this.RefreshButtonStates(data);
	}

	// Token: 0x06012C36 RID: 76854 RVA: 0x00583F4C File Offset: 0x0058214C
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

	// Token: 0x06012C37 RID: 76855 RVA: 0x005840A8 File Offset: 0x005822A8
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

	// Token: 0x06012C38 RID: 76856 RVA: 0x00584114 File Offset: 0x00582314
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

	// Token: 0x06012C39 RID: 76857 RVA: 0x00584274 File Offset: 0x00582474
	private UniTask InitializeSkillSlots()
	{
		RoleDevSkillViewItem.<InitializeSkillSlots>d__18 <InitializeSkillSlots>d__;
		<InitializeSkillSlots>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeSkillSlots>d__.<>4__this = this;
		<InitializeSkillSlots>d__.<>1__state = -1;
		<InitializeSkillSlots>d__.<>t__builder.Start<RoleDevSkillViewItem.<InitializeSkillSlots>d__18>(ref <InitializeSkillSlots>d__);
		return <InitializeSkillSlots>d__.<>t__builder.Task;
	}

	// Token: 0x06012C3A RID: 76858 RVA: 0x005842B8 File Offset: 0x005824B8
	private UniTask InitializeButtons()
	{
		RoleDevSkillViewItem.<InitializeButtons>d__19 <InitializeButtons>d__;
		<InitializeButtons>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeButtons>d__.<>4__this = this;
		<InitializeButtons>d__.<>1__state = -1;
		<InitializeButtons>d__.<>t__builder.Start<RoleDevSkillViewItem.<InitializeButtons>d__19>(ref <InitializeButtons>d__);
		return <InitializeButtons>d__.<>t__builder.Task;
	}

	// Token: 0x06012C3B RID: 76859 RVA: 0x005842FC File Offset: 0x005824FC
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

	// Token: 0x06012C3C RID: 76860 RVA: 0x00584363 File Offset: 0x00582563
	private RoleDevDetailItem CreateDetailItem()
	{
		return new RoleDevDetailItem();
	}

	// Token: 0x06012C3D RID: 76861 RVA: 0x0058436C File Offset: 0x0058256C
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

	// Token: 0x06012C3E RID: 76862 RVA: 0x00584400 File Offset: 0x00582600
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

	// Token: 0x06012C3F RID: 76863 RVA: 0x0058448C File Offset: 0x0058268C
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

	// Token: 0x0400A24A RID: 41546
	private readonly List<RoleDevSkillSlotItem> SkillSlotItems = new List<RoleDevSkillSlotItem>();

	// Token: 0x0400A24B RID: 41547
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleDevDetailItem, global::IRoleDevDetailItemData> DetailVerticalLayout;

	// Token: 0x0400A24C RID: 41548
	[Nullable(2)]
	private RoleDevSkillViewItemDataBase Data;

	// Token: 0x0400A24D RID: 41549
	[Nullable(2)]
	private ButtonItem NormalButtonItem;

	// Token: 0x0400A24E RID: 41550
	[Nullable(2)]
	private ButtonItem HighLightButtonItem;

	// Token: 0x0400A24F RID: 41551
	[Nullable(2)]
	public Action<int> OnClickToggleCallBack;

	// Token: 0x0400A250 RID: 41552
	[Nullable(2)]
	public Func<int, bool> CanClickCallBack;

	// Token: 0x0400A251 RID: 41553
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<RoleDevSkillViewItemDataBase> OnConfirmCallback;

	// Token: 0x0400A252 RID: 41554
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<RoleDevSkillViewItemDataBase> OnPlanChangeCallback;

	// Token: 0x0400A253 RID: 41555
	[Nullable(2)]
	public UiBehaviorLevelSequence UiViewSequence;

	// Token: 0x020080AD RID: 32941
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040299ED RID: 170477
		TxtSwitchState,
		// Token: 0x040299EE RID: 170478
		BtnSwitchState,
		// Token: 0x040299EF RID: 170479
		PanelSkillSlot0,
		// Token: 0x040299F0 RID: 170480
		PanelSkillSlot1,
		// Token: 0x040299F1 RID: 170481
		PanelSkillSlot2,
		// Token: 0x040299F2 RID: 170482
		PanelSkillSlot3,
		// Token: 0x040299F3 RID: 170483
		PanelSkillSlot4,
		// Token: 0x040299F4 RID: 170484
		PanelItemRight,
		// Token: 0x040299F5 RID: 170485
		BtnItemJump,
		// Token: 0x040299F6 RID: 170486
		PanelTxtOffset,
		// Token: 0x040299F7 RID: 170487
		BtnItemPerfectJump,
		// Token: 0x040299F8 RID: 170488
		PanelItemRightLine,
		// Token: 0x040299F9 RID: 170489
		PanelItemDetailLayout,
		// Token: 0x040299FA RID: 170490
		PanelItemList,
		// Token: 0x040299FB RID: 170491
		PanelSwitch,
		// Token: 0x040299FC RID: 170492
		TxtTitle,
		// Token: 0x040299FD RID: 170493
		PanelItemDescription
	}
}

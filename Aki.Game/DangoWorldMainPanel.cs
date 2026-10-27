using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A66 RID: 6758
[NullableContext(2)]
[Nullable(0)]
public class DangoWorldMainPanel : BattleChildViewPanel
{
	// Token: 0x0600C6EF RID: 50927 RVA: 0x002D44DC File Offset: 0x002D26DC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnCloseBtnClick))
		};
	}

	// Token: 0x0600C6F0 RID: 50928 RVA: 0x002D459C File Offset: 0x002D279C
	protected override void AddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnAbyssRoleInfoUpdate, new Action(this.OnRoleChange));
		EventSystem.Instance.Add(EEventName.OnAbyssAddRole, new Action(this.OnRoleChange));
		EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.OnActivityOpen, new Action<IReadOnlySet<int>>(this.OnActivityOpen));
	}

	// Token: 0x0600C6F1 RID: 50929 RVA: 0x002D4600 File Offset: 0x002D2800
	protected override void RemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnAbyssRoleInfoUpdate, new Action(this.OnRoleChange));
		EventSystem.Instance.Remove(EEventName.OnAbyssAddRole, new Action(this.OnRoleChange));
		EventSystem.Instance.Remove<IReadOnlySet<int>>(EEventName.OnActivityOpen, new Action<IReadOnlySet<int>>(this.OnActivityOpen));
	}

	// Token: 0x0600C6F2 RID: 50930 RVA: 0x002D4661 File Offset: 0x002D2861
	[NullableContext(1)]
	private void OnActivityOpen(IReadOnlySet<int> _)
	{
		this.CurrentData = DangoAbyssModel.Instance.GetCurrentOpenAbyssActivityData();
		this.RefreshView();
	}

	// Token: 0x0600C6F3 RID: 50931 RVA: 0x002D4679 File Offset: 0x002D2879
	private void OnRoleChange()
	{
		this.RefreshRightTopPanel();
	}

	// Token: 0x0600C6F4 RID: 50932 RVA: 0x002D4684 File Offset: 0x002D2884
	protected override UniTask OnBeforeStartAsync()
	{
		DangoWorldMainPanel.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoWorldMainPanel.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C6F5 RID: 50933 RVA: 0x002D46C8 File Offset: 0x002D28C8
	protected override void OnBeforeDestroy()
	{
		this.RemoveEvents();
		DangoWorldQuestItem dangoWorldQuestItem = this.DangoWorldQuestItem;
		if (dangoWorldQuestItem != null)
		{
			dangoWorldQuestItem.Clear();
		}
		BattleUiChildViewData childViewData = BattleUiModel.Instance.ChildViewData;
		if (childViewData != null)
		{
			childViewData.SetChildVisible(EBattleUiVisibleReason.UiControl, EBattleUiChild.Mission, true, true, 0);
		}
		BattleUiChildViewData childViewData2 = BattleUiModel.Instance.ChildViewData;
		if (childViewData2 != null)
		{
			childViewData2.SetChildVisible(EBattleUiVisibleReason.UiControl, EBattleUiChild.Formation, true, true, 0);
		}
		BattleUiChildViewData childViewData3 = BattleUiModel.Instance.ChildViewData;
		if (childViewData3 != null)
		{
			childViewData3.SetChildVisible(EBattleUiVisibleReason.UiControl, EBattleUiChild.GamepadFormation, true, true, 0);
		}
		UiSequencePlayer uiSequencePlayer = this.UiSequencePlayer;
		if (uiSequencePlayer == null)
		{
			return;
		}
		uiSequencePlayer.Clear();
	}

	// Token: 0x0600C6F6 RID: 50934 RVA: 0x002D4750 File Offset: 0x002D2950
	protected override void OnBeforeShow()
	{
		this.RefreshView();
		this.RefreshRedDot();
	}

	// Token: 0x0600C6F7 RID: 50935 RVA: 0x002D4760 File Offset: 0x002D2960
	private void RefreshRedDot()
	{
		AbyssButtonItem dangoUpItem = this.DangoUpItem;
		if (dangoUpItem != null)
		{
			dangoUpItem.BindRedDot(ERedDotName.RedDotDangoDevelop, null);
		}
		AbyssButtonItem shopItem = this.ShopItem;
		if (shopItem == null)
		{
			return;
		}
		shopItem.BindRedDot(ERedDotName.RedDotDangoPayShop, null);
	}

	// Token: 0x0600C6F8 RID: 50936 RVA: 0x002D47AA File Offset: 0x002D29AA
	private void RefreshView()
	{
		DangoWorldQuestItem dangoWorldQuestItem = this.DangoWorldQuestItem;
		if (dangoWorldQuestItem != null)
		{
			dangoWorldQuestItem.Refresh();
		}
		this.RefreshRightTopPanel();
		this.RefreshBtns();
	}

	// Token: 0x0600C6F9 RID: 50937 RVA: 0x002D47C9 File Offset: 0x002D29C9
	private void RefreshRightTopPanel()
	{
		if (this.CurrentData != null)
		{
			this.RightTopPanel.Refresh(this.CurrentData);
		}
	}

	// Token: 0x0600C6FA RID: 50938 RVA: 0x002D47E4 File Offset: 0x002D29E4
	private void RefreshBtns()
	{
		if (this.CurrentData != null)
		{
			bool dangoUpAvailable = DangoAbyssModel.Instance.GetDangoUpAvailable();
			this.DangoUpItem.SetUiActive(dangoUpAvailable);
			bool shopAvailable = DangoAbyssModel.Instance.GetShopAvailable();
			this.ShopItem.SetUiActive(shopAvailable);
		}
	}

	// Token: 0x0600C6FB RID: 50939 RVA: 0x002D4827 File Offset: 0x002D2A27
	private void OnClickDangoUp()
	{
		if (!DangoAbyssModel.Instance.GetDangoUpAvailable())
		{
			return;
		}
		DangoAbyssActivityController.Instance.OpenCurrentRoleUpView();
	}

	// Token: 0x0600C6FC RID: 50940 RVA: 0x002D4840 File Offset: 0x002D2A40
	private void OnClickShop()
	{
		if (!DangoAbyssModel.Instance.GetShopAvailable())
		{
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.DangoAbyssShopView, null, null);
	}

	// Token: 0x0600C6FD RID: 50941 RVA: 0x002D4860 File Offset: 0x002D2A60
	private void OnCloseBtnClick()
	{
		if (!DangoAbyssController.Instance.OpenCurrentActivityAbyssEntrance())
		{
			InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon().Forget<bool>();
		}
	}

	// Token: 0x0600C6FE RID: 50942 RVA: 0x002D487D File Offset: 0x002D2A7D
	public override void OnTickBattleChildViewPanel(float delta)
	{
		DangoWorldQuestItem dangoWorldQuestItem = this.DangoWorldQuestItem;
		if (dangoWorldQuestItem == null)
		{
			return;
		}
		dangoWorldQuestItem.Tick();
	}

	// Token: 0x0600C6FF RID: 50943 RVA: 0x002D488F File Offset: 0x002D2A8F
	protected override void OnBeforeHide()
	{
		this.UnbindRedDot();
	}

	// Token: 0x0600C700 RID: 50944 RVA: 0x002D4897 File Offset: 0x002D2A97
	private void UnbindRedDot()
	{
		AbyssButtonItem dangoUpItem = this.DangoUpItem;
		if (dangoUpItem != null)
		{
			dangoUpItem.UnBindRedDot();
		}
		AbyssButtonItem shopItem = this.ShopItem;
		if (shopItem == null)
		{
			return;
		}
		shopItem.UnBindRedDot();
	}

	// Token: 0x0600C701 RID: 50945 RVA: 0x002D48BC File Offset: 0x002D2ABC
	[NullableContext(1)]
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length != 2)
		{
			return null;
		}
		UUIItem uuiitem = null;
		if (configParams[1] == "DangoUp")
		{
			uuiitem = base.GetItem(5);
		}
		if (configParams[1] == "DangoShop")
		{
			uuiitem = base.GetItem(4);
		}
		if (configParams[1] == "CloseBtn")
		{
			UUIButtonComponent button = base.GetButton(0);
			uuiitem = ((button != null) ? button.RootUIComp.Get() : null);
		}
		if (uuiitem == null)
		{
			return null;
		}
		return new UUIItem[]
		{
			uuiitem,
			uuiitem
		};
	}

	// Token: 0x04005BA5 RID: 23461
	private DangoAbyssActivityData CurrentData;

	// Token: 0x04005BA6 RID: 23462
	private DangoWorldMainProgressPanel RightTopPanel;

	// Token: 0x04005BA7 RID: 23463
	private AbyssButtonItem DangoUpItem;

	// Token: 0x04005BA8 RID: 23464
	private AbyssButtonItem ShopItem;

	// Token: 0x04005BA9 RID: 23465
	private DangoWorldQuestItem DangoWorldQuestItem;

	// Token: 0x04005BAA RID: 23466
	private UiSequencePlayer UiSequencePlayer;

	// Token: 0x02007FB3 RID: 32691
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04029B1E RID: 170782
		CloseBtn,
		// Token: 0x04029B1F RID: 170783
		GoalScroller,
		// Token: 0x04029B20 RID: 170784
		GoalItem,
		// Token: 0x04029B21 RID: 170785
		RightTopPanel,
		// Token: 0x04029B22 RID: 170786
		ShopItem,
		// Token: 0x04029B23 RID: 170787
		DangoUpItem
	}
}

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

// Token: 0x02000F25 RID: 3877
[NullableContext(2)]
[Nullable(0)]
public class DangoWorldMainPanel : BattleChildViewPanel
{
	// Token: 0x06009AFF RID: 39679 RVA: 0x002DF5D4 File Offset: 0x002DD7D4
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

	// Token: 0x06009B00 RID: 39680 RVA: 0x002DF694 File Offset: 0x002DD894
	protected override void AddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnAbyssRoleInfoUpdate, new Action(this.OnRoleChange));
		EventSystem.Instance.Add(EEventName.OnAbyssAddRole, new Action(this.OnRoleChange));
		EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.OnActivityOpen, new Action<IReadOnlySet<int>>(this.OnActivityOpen));
	}

	// Token: 0x06009B01 RID: 39681 RVA: 0x002DF6F8 File Offset: 0x002DD8F8
	protected override void RemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnAbyssRoleInfoUpdate, new Action(this.OnRoleChange));
		EventSystem.Instance.Remove(EEventName.OnAbyssAddRole, new Action(this.OnRoleChange));
		EventSystem.Instance.Remove<IReadOnlySet<int>>(EEventName.OnActivityOpen, new Action<IReadOnlySet<int>>(this.OnActivityOpen));
	}

	// Token: 0x06009B02 RID: 39682 RVA: 0x002DF759 File Offset: 0x002DD959
	[NullableContext(1)]
	private void OnActivityOpen(IReadOnlySet<int> _)
	{
		this.CurrentData = DangoAbyssModel.Instance.GetCurrentOpenAbyssActivityData();
		this.RefreshView();
	}

	// Token: 0x06009B03 RID: 39683 RVA: 0x002DF771 File Offset: 0x002DD971
	private void OnRoleChange()
	{
		this.RefreshRightTopPanel();
	}

	// Token: 0x06009B04 RID: 39684 RVA: 0x002DF77C File Offset: 0x002DD97C
	protected override UniTask OnBeforeStartAsync()
	{
		DangoWorldMainPanel.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoWorldMainPanel.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009B05 RID: 39685 RVA: 0x002DF7C0 File Offset: 0x002DD9C0
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

	// Token: 0x06009B06 RID: 39686 RVA: 0x002DF848 File Offset: 0x002DDA48
	protected override void OnBeforeShow()
	{
		this.RefreshView();
		this.RefreshRedDot();
	}

	// Token: 0x06009B07 RID: 39687 RVA: 0x002DF858 File Offset: 0x002DDA58
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

	// Token: 0x06009B08 RID: 39688 RVA: 0x002DF8A2 File Offset: 0x002DDAA2
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

	// Token: 0x06009B09 RID: 39689 RVA: 0x002DF8C1 File Offset: 0x002DDAC1
	private void RefreshRightTopPanel()
	{
		if (this.CurrentData != null)
		{
			this.RightTopPanel.Refresh(this.CurrentData);
		}
	}

	// Token: 0x06009B0A RID: 39690 RVA: 0x002DF8DC File Offset: 0x002DDADC
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

	// Token: 0x06009B0B RID: 39691 RVA: 0x002DF91F File Offset: 0x002DDB1F
	private void OnClickDangoUp()
	{
		if (!DangoAbyssModel.Instance.GetDangoUpAvailable())
		{
			return;
		}
		DangoAbyssActivityController.Instance.OpenCurrentRoleUpView();
	}

	// Token: 0x06009B0C RID: 39692 RVA: 0x002DF938 File Offset: 0x002DDB38
	private void OnClickShop()
	{
		if (!DangoAbyssModel.Instance.GetShopAvailable())
		{
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.DangoAbyssShopView, null, null);
	}

	// Token: 0x06009B0D RID: 39693 RVA: 0x002DF958 File Offset: 0x002DDB58
	private void OnCloseBtnClick()
	{
		if (!DangoAbyssController.Instance.OpenCurrentActivityAbyssEntrance())
		{
			InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon().Forget<bool>();
		}
	}

	// Token: 0x06009B0E RID: 39694 RVA: 0x002DF975 File Offset: 0x002DDB75
	public override void OnTickBattleChildViewPanel(float delta)
	{
		DangoWorldQuestItem dangoWorldQuestItem = this.DangoWorldQuestItem;
		if (dangoWorldQuestItem == null)
		{
			return;
		}
		dangoWorldQuestItem.Tick();
	}

	// Token: 0x06009B0F RID: 39695 RVA: 0x002DF987 File Offset: 0x002DDB87
	protected override void OnBeforeHide()
	{
		this.UnbindRedDot();
	}

	// Token: 0x06009B10 RID: 39696 RVA: 0x002DF98F File Offset: 0x002DDB8F
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

	// Token: 0x06009B11 RID: 39697 RVA: 0x002DF9B4 File Offset: 0x002DDBB4
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

	// Token: 0x04005C74 RID: 23668
	private DangoAbyssActivityData CurrentData;

	// Token: 0x04005C75 RID: 23669
	private DangoWorldMainProgressPanel RightTopPanel;

	// Token: 0x04005C76 RID: 23670
	private AbyssButtonItem DangoUpItem;

	// Token: 0x04005C77 RID: 23671
	private AbyssButtonItem ShopItem;

	// Token: 0x04005C78 RID: 23672
	private DangoWorldQuestItem DangoWorldQuestItem;

	// Token: 0x04005C79 RID: 23673
	private UiSequencePlayer UiSequencePlayer;

	// Token: 0x02007142 RID: 28994
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04024E5B RID: 151131
		CloseBtn,
		// Token: 0x04024E5C RID: 151132
		GoalScroller,
		// Token: 0x04024E5D RID: 151133
		GoalItem,
		// Token: 0x04024E5E RID: 151134
		RightTopPanel,
		// Token: 0x04024E5F RID: 151135
		ShopItem,
		// Token: 0x04024E60 RID: 151136
		DangoUpItem
	}
}

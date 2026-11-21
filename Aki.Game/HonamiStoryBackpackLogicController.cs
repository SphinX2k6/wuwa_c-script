using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x0200134E RID: 4942
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryBackpackLogicController
{
	// Token: 0x0600C336 RID: 49974 RVA: 0x0039D9DE File Offset: 0x0039BBDE
	public void Destroy()
	{
		this.DestroyTimer();
	}

	// Token: 0x0600C337 RID: 49975 RVA: 0x0039D9E8 File Offset: 0x0039BBE8
	public bool OnClickGrid(HonamiStoryItemDataBase itemData, Action cb, HonamiStoryItemGridItem uiItem)
	{
		if (this.CurClickedItemData != null && itemData != this.CurClickedItemData)
		{
			HonamiStoryItemGridItem curClickedUiItem = this.CurClickedUiItem;
			if (curClickedUiItem != null)
			{
				curClickedUiItem.CancelToggleSelect();
			}
			this.DestroyTimer();
		}
		this.CurClickedUiItem = uiItem;
		this.CurClickedItemData = itemData;
		if (this.DoubleClickedHandle != null && this.DoubleClickedHandle.Valid())
		{
			this.DestroyTimer();
			this.CurClickedUiItem = null;
			this.CurClickedItemData = null;
			return true;
		}
		int doubleClickDelay = HonamiStoryConfig.Instance.GetDoubleClickDelay();
		this.DoubleClickedHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			this.DoubleClickedHandle = null;
			this.CurClickedUiItem = null;
			this.CurClickedItemData = null;
			cb();
		}, (float)doubleClickDelay, null, null, true, 1f);
		return false;
	}

	// Token: 0x0600C338 RID: 49976 RVA: 0x0039DA9C File Offset: 0x0039BC9C
	private void DestroyTimer()
	{
		if (this.DoubleClickedHandle != null)
		{
			if (this.DoubleClickedHandle.Valid())
			{
				TimerSystem.GameplayTimeInstance.Remove(this.DoubleClickedHandle);
			}
			this.DoubleClickedHandle = null;
		}
	}

	// Token: 0x0600C339 RID: 49977 RVA: 0x0039DACB File Offset: 0x0039BCCB
	public void RegisterPanel(HonamiStoryBackpackPanelBase panel)
	{
		this.PanelBaseList.Add(panel);
	}

	// Token: 0x0600C33A RID: 49978 RVA: 0x0039DAD9 File Offset: 0x0039BCD9
	public void RegisterValuePanel(HonamiStoryBackpackValueCountItem item)
	{
		this.ValuePanel = item;
	}

	// Token: 0x0600C33B RID: 49979 RVA: 0x0039DAE2 File Offset: 0x0039BCE2
	public void RegisterTipsItem(HonamiStoryItemTipsBase tips)
	{
		this.TipsItem = tips;
	}

	// Token: 0x0600C33C RID: 49980 RVA: 0x0039DAEB File Offset: 0x0039BCEB
	[NullableContext(2)]
	public void RegisterBackpackView(HonamiStoryBackpackView view)
	{
		this.BackpackView = view;
	}

	// Token: 0x0600C33D RID: 49981 RVA: 0x0039DAF4 File Offset: 0x0039BCF4
	public bool IsBackpackView()
	{
		return this.BackpackView != null;
	}

	// Token: 0x0600C33E RID: 49982 RVA: 0x0039DB00 File Offset: 0x0039BD00
	[NullableContext(2)]
	public void SetLogicState(EHonamiStoryBackpackLogicState state, HonamiStoryItemDataBase insteadItem = null, EHonamiStoryBackpack? tipsBackpackId = null)
	{
		this.DestroyTimer();
		EHonamiStoryBackpackLogicState curState = this.CurState;
		this.CurState = state;
		this.TipsInsteadItem = insteadItem;
		this.TipsBackpackId = tipsBackpackId;
		if (state == EHonamiStoryBackpackLogicState.Normal)
		{
			this.SellItemSet.Clear();
			this.InitDataSelectState();
			if (curState == EHonamiStoryBackpackLogicState.Sell)
			{
				HonamiStoryBackpackView backpackView = this.BackpackView;
				if (backpackView != null)
				{
					backpackView.SetSellMode(false);
				}
			}
			this.HandleGamepadLogicToNormal();
		}
		else if (state == EHonamiStoryBackpackLogicState.Sell)
		{
			this.InitDataSelectState();
			HonamiStoryBackpackView backpackView2 = this.BackpackView;
			if (backpackView2 != null)
			{
				backpackView2.SetSellMode(true);
			}
			this.SellItemSet.Clear();
			this.CurValueSum = 0;
			this.ValuePanel.SetValue(0);
		}
		foreach (HonamiStoryBackpackPanelBase honamiStoryBackpackPanelBase in this.PanelBaseList)
		{
			honamiStoryBackpackPanelBase.OnBackpackLogicStateChange(state);
		}
	}

	// Token: 0x0600C33F RID: 49983 RVA: 0x0039DBE0 File Offset: 0x0039BDE0
	public EHonamiStoryBackpackLogicState GetLogicState()
	{
		return this.CurState;
	}

	// Token: 0x0600C340 RID: 49984 RVA: 0x0039DBE8 File Offset: 0x0039BDE8
	protected void InitDataSelectState()
	{
		EHonamiStoryBackpack backpackId = HonamiStoryUtil.CheckInHonamiStoryDungeon() ? EHonamiStoryBackpack.Backpack : EHonamiStoryBackpack.Inventory;
		foreach (HonamiStoryItemDataBase honamiStoryItemDataBase in HonamiStoryModel.Instance.GetBackPackData((int)backpackId, false).GetItemDataList())
		{
			honamiStoryItemDataBase.SetIsSelected(false);
		}
	}

	// Token: 0x0600C341 RID: 49985 RVA: 0x0039DC50 File Offset: 0x0039BE50
	protected void HandleGamepadLogicToNormal()
	{
		HonamiStoryGamepadLogicController gamepadLogic = HonamiStoryModel.Instance.GetGamepadLogic();
		if (gamepadLogic == null)
		{
			return;
		}
		gamepadLogic.TriggerCurItemEnterGrid();
	}

	// Token: 0x0600C342 RID: 49986 RVA: 0x0039DC68 File Offset: 0x0039BE68
	public void OnUnlockSlot(int rolePos)
	{
		foreach (HonamiStoryBackpackPanelBase honamiStoryBackpackPanelBase in this.PanelBaseList)
		{
			if (honamiStoryBackpackPanelBase.GetBackpackType() == 3)
			{
				HonamiStoryEquipBackpackPanel honamiStoryEquipBackpackPanel = honamiStoryBackpackPanelBase as HonamiStoryEquipBackpackPanel;
				if (honamiStoryEquipBackpackPanel == null)
				{
					break;
				}
				honamiStoryEquipBackpackPanel.RefreshUnlockSlot();
				break;
			}
		}
	}

	// Token: 0x0600C343 RID: 49987 RVA: 0x0039DCD0 File Offset: 0x0039BED0
	public void RefreshItemLockState(HonamiStoryItemDataBase itemData, EHonamiStoryBackpackType backpackType)
	{
		foreach (HonamiStoryBackpackPanelBase honamiStoryBackpackPanelBase in this.PanelBaseList)
		{
			if (honamiStoryBackpackPanelBase.GetBackpackType() == (int)backpackType)
			{
				honamiStoryBackpackPanelBase.RefreshSingleItem(itemData);
				break;
			}
		}
	}

	// Token: 0x0600C344 RID: 49988 RVA: 0x0039DD30 File Offset: 0x0039BF30
	public void RegisterSingleSellItem(HonamiStoryItemDataBase itemData)
	{
		bool flag = !itemData.GetIsSelected();
		itemData.SetIsSelected(flag);
		if (flag)
		{
			this.SellItemSet.Add(itemData);
			this.CurValueSum += itemData.GetSellPrice();
		}
		else
		{
			this.SellItemSet.Remove(itemData);
			this.CurValueSum -= itemData.GetSellPrice();
		}
		this.ValuePanel.SetValue(this.CurValueSum);
	}

	// Token: 0x0600C345 RID: 49989 RVA: 0x0039DDA4 File Offset: 0x0039BFA4
	public void DoSell()
	{
		if (this.SellItemSet.Count == 0)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("HonamiStory_Sell_NoItem_Tip", Array.Empty<object>());
			return;
		}
		List<IHonamiStoryItemSellInfo> list = new List<IHonamiStoryItemSellInfo>();
		foreach (HonamiStoryItemDataBase itemData in this.SellItemSet)
		{
			HonamiStoryItemSellInfo item = new HonamiStoryItemSellInfo
			{
				ItemData = itemData,
				BackpackType = EHonamiStoryBackpack.Inventory
			};
			list.Add(item);
		}
		UiManager.Instance.OpenView(EUiViewName.HonamiStorySellConfirmBoxView, new HonamiStorySellConfirmBoxOpenParam
		{
			SellItemList = list,
			SellCallback = delegate
			{
				this.SellItemSet.Clear();
				this.CurValueSum = 0;
				this.ValuePanel.SetValue(0);
				this.SetLogicState(EHonamiStoryBackpackLogicState.Normal, null, null);
				UiNavigationNewController.Instance.SetLockUseDragStateByPanelItem(this.BackpackView.GetRootItem(), false);
			}
		}, null);
	}

	// Token: 0x0600C346 RID: 49990 RVA: 0x0039DE64 File Offset: 0x0039C064
	public void DoSellToAll(bool isSelected, EHonamiStoryItemType itemType, int qualityId = 0)
	{
		List<HonamiStoryItemDataBase> list = new List<HonamiStoryItemDataBase>();
		if (!isSelected)
		{
			foreach (HonamiStoryItemDataBase honamiStoryItemDataBase in this.SellItemSet)
			{
				if (honamiStoryItemDataBase.GetItemType() == itemType && (qualityId == 0 || qualityId == honamiStoryItemDataBase.GetQuality()))
				{
					list.Add(honamiStoryItemDataBase);
					honamiStoryItemDataBase.SetIsSelected(false);
				}
			}
			using (List<HonamiStoryItemDataBase>.Enumerator enumerator2 = list.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					HonamiStoryItemDataBase honamiStoryItemDataBase2 = enumerator2.Current;
					this.SellItemSet.Remove(honamiStoryItemDataBase2);
					this.CurValueSum -= honamiStoryItemDataBase2.GetSellPrice();
				}
				goto IL_172;
			}
		}
		foreach (HonamiStoryItemDataBase honamiStoryItemDataBase3 in HonamiStoryModel.Instance.GetBackPackData(1, false).GetItemDataList())
		{
			if (honamiStoryItemDataBase3.GetItemType() == itemType && !honamiStoryItemDataBase3.IsLock() && (qualityId == 0 || qualityId == honamiStoryItemDataBase3.GetQuality()))
			{
				honamiStoryItemDataBase3.SetIsSelected(true);
				list.Add(honamiStoryItemDataBase3);
				this.SellItemSet.Add(honamiStoryItemDataBase3);
			}
		}
		this.CurValueSum = 0;
		foreach (HonamiStoryItemDataBase honamiStoryItemDataBase4 in this.SellItemSet)
		{
			this.CurValueSum += honamiStoryItemDataBase4.GetSellPrice();
		}
		IL_172:
		this.ValuePanel.SetValue(this.CurValueSum);
		foreach (HonamiStoryBackpackPanelBase honamiStoryBackpackPanelBase in this.PanelBaseList)
		{
			if (honamiStoryBackpackPanelBase.GetBackpackType() == 0)
			{
				using (List<HonamiStoryItemDataBase>.Enumerator enumerator2 = list.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						HonamiStoryItemDataBase itemData = enumerator2.Current;
						honamiStoryBackpackPanelBase.RefreshSingleItem(itemData);
					}
					break;
				}
			}
		}
	}

	// Token: 0x0600C347 RID: 49991 RVA: 0x0039E0B0 File Offset: 0x0039C2B0
	[NullableContext(0)]
	public UniTask<bool> DoTipsWithPluginsInstead(int pos, [Nullable(2)] HonamiStoryItemDataBase exchangeItem)
	{
		HonamiStoryBackpackLogicController.<DoTipsWithPluginsInstead>d__29 <DoTipsWithPluginsInstead>d__;
		<DoTipsWithPluginsInstead>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<DoTipsWithPluginsInstead>d__.<>4__this = this;
		<DoTipsWithPluginsInstead>d__.pos = pos;
		<DoTipsWithPluginsInstead>d__.exchangeItem = exchangeItem;
		<DoTipsWithPluginsInstead>d__.<>1__state = -1;
		<DoTipsWithPluginsInstead>d__.<>t__builder.Start<HonamiStoryBackpackLogicController.<DoTipsWithPluginsInstead>d__29>(ref <DoTipsWithPluginsInstead>d__);
		return <DoTipsWithPluginsInstead>d__.<>t__builder.Task;
	}

	// Token: 0x0600C348 RID: 49992 RVA: 0x0039E103 File Offset: 0x0039C303
	public HonamiStoryItemDataBase GetInsteadItem()
	{
		return this.TipsInsteadItem;
	}

	// Token: 0x0600C349 RID: 49993 RVA: 0x0039E10B File Offset: 0x0039C30B
	public bool GetTipsOpen()
	{
		return this.GetLogicState() == EHonamiStoryBackpackLogicState.Tips || this.GetLogicState() == EHonamiStoryBackpackLogicState.TipsWithPlugins;
	}

	// Token: 0x0600C34A RID: 49994 RVA: 0x0039E121 File Offset: 0x0039C321
	public void CloseTips()
	{
		this.TipsItem.OnClickedMask();
	}

	// Token: 0x0600C34B RID: 49995 RVA: 0x0039E12E File Offset: 0x0039C32E
	public void SetInteractController(HonamiStoryInteractController controller)
	{
		this.InteractController = controller;
	}

	// Token: 0x0600C34C RID: 49996 RVA: 0x0039E137 File Offset: 0x0039C337
	public HonamiStoryInteractController GetInteractController()
	{
		return this.InteractController;
	}

	// Token: 0x0600C34D RID: 49997 RVA: 0x0039E140 File Offset: 0x0039C340
	public void RefreshNeedQuickAll()
	{
		foreach (HonamiStoryBackpackPanelBase honamiStoryBackpackPanelBase in this.PanelBaseList)
		{
			if (honamiStoryBackpackPanelBase.GetBackpackType() == 3)
			{
				if (HonamiStoryUtil.IsMobileView())
				{
					HonamiStoryMobileEquipPanel honamiStoryMobileEquipPanel = honamiStoryBackpackPanelBase as HonamiStoryMobileEquipPanel;
					if (honamiStoryMobileEquipPanel == null)
					{
						break;
					}
					honamiStoryMobileEquipPanel.RefreshNeedQuickAll();
					break;
				}
				else
				{
					HonamiStoryEquipBackpackPanel honamiStoryEquipBackpackPanel = honamiStoryBackpackPanelBase as HonamiStoryEquipBackpackPanel;
					if (honamiStoryEquipBackpackPanel == null)
					{
						break;
					}
					honamiStoryEquipBackpackPanel.RefreshNeedQuickAll();
					break;
				}
			}
		}
	}

	// Token: 0x04006FA2 RID: 28578
	[Nullable(2)]
	public HonamiStoryBackpackView BackpackView;

	// Token: 0x04006FA3 RID: 28579
	[Nullable(2)]
	private TimerHandle DoubleClickedHandle;

	// Token: 0x04006FA4 RID: 28580
	[Nullable(2)]
	private HonamiStoryItemDataBase CurClickedItemData;

	// Token: 0x04006FA5 RID: 28581
	[Nullable(2)]
	private HonamiStoryItemGridItem CurClickedUiItem;

	// Token: 0x04006FA6 RID: 28582
	public List<HonamiStoryBackpackPanelBase> PanelBaseList = new List<HonamiStoryBackpackPanelBase>();

	// Token: 0x04006FA7 RID: 28583
	private EHonamiStoryBackpackLogicState CurState;

	// Token: 0x04006FA8 RID: 28584
	[Nullable(2)]
	private HonamiStoryBackpackValueCountItem ValuePanel;

	// Token: 0x04006FA9 RID: 28585
	private readonly HashSet<HonamiStoryItemDataBase> SellItemSet = new HashSet<HonamiStoryItemDataBase>();

	// Token: 0x04006FAA RID: 28586
	private int CurValueSum;

	// Token: 0x04006FAB RID: 28587
	[Nullable(2)]
	private HonamiStoryItemDataBase TipsInsteadItem;

	// Token: 0x04006FAC RID: 28588
	private EHonamiStoryBackpack? TipsBackpackId;

	// Token: 0x04006FAD RID: 28589
	[Nullable(2)]
	public HonamiStoryItemTipsBase TipsItem;

	// Token: 0x04006FAE RID: 28590
	private HonamiStoryInteractController InteractController;
}

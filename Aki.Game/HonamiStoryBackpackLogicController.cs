using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001E8C RID: 7820
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryBackpackLogicController
{
	// Token: 0x0600EF17 RID: 61207 RVA: 0x00391E22 File Offset: 0x00390022
	public void Destroy()
	{
		this.DestroyTimer();
	}

	// Token: 0x0600EF18 RID: 61208 RVA: 0x00391E2C File Offset: 0x0039002C
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

	// Token: 0x0600EF19 RID: 61209 RVA: 0x00391EE0 File Offset: 0x003900E0
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

	// Token: 0x0600EF1A RID: 61210 RVA: 0x00391F0F File Offset: 0x0039010F
	public void RegisterPanel(HonamiStoryBackpackPanelBase panel)
	{
		this.PanelBaseList.Add(panel);
	}

	// Token: 0x0600EF1B RID: 61211 RVA: 0x00391F1D File Offset: 0x0039011D
	public void RegisterValuePanel(HonamiStoryBackpackValueCountItem item)
	{
		this.ValuePanel = item;
	}

	// Token: 0x0600EF1C RID: 61212 RVA: 0x00391F26 File Offset: 0x00390126
	public void RegisterTipsItem(HonamiStoryItemTipsBase tips)
	{
		this.TipsItem = tips;
	}

	// Token: 0x0600EF1D RID: 61213 RVA: 0x00391F2F File Offset: 0x0039012F
	[NullableContext(2)]
	public void RegisterBackpackView(HonamiStoryBackpackView view)
	{
		this.BackpackView = view;
	}

	// Token: 0x0600EF1E RID: 61214 RVA: 0x00391F38 File Offset: 0x00390138
	public bool IsBackpackView()
	{
		return this.BackpackView != null;
	}

	// Token: 0x0600EF1F RID: 61215 RVA: 0x00391F44 File Offset: 0x00390144
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

	// Token: 0x0600EF20 RID: 61216 RVA: 0x00392024 File Offset: 0x00390224
	public EHonamiStoryBackpackLogicState GetLogicState()
	{
		return this.CurState;
	}

	// Token: 0x0600EF21 RID: 61217 RVA: 0x0039202C File Offset: 0x0039022C
	protected void InitDataSelectState()
	{
		EHonamiStoryBackpack backpackId = HonamiStoryUtil.CheckInHonamiStoryDungeon() ? EHonamiStoryBackpack.Backpack : EHonamiStoryBackpack.Inventory;
		foreach (HonamiStoryItemDataBase honamiStoryItemDataBase in HonamiStoryModel.Instance.GetBackPackData((int)backpackId, false).GetItemDataList())
		{
			honamiStoryItemDataBase.SetIsSelected(false);
		}
	}

	// Token: 0x0600EF22 RID: 61218 RVA: 0x00392094 File Offset: 0x00390294
	protected void HandleGamepadLogicToNormal()
	{
		HonamiStoryGamepadLogicController gamepadLogic = HonamiStoryModel.Instance.GetGamepadLogic();
		if (gamepadLogic == null)
		{
			return;
		}
		gamepadLogic.TriggerCurItemEnterGrid();
	}

	// Token: 0x0600EF23 RID: 61219 RVA: 0x003920AC File Offset: 0x003902AC
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

	// Token: 0x0600EF24 RID: 61220 RVA: 0x00392114 File Offset: 0x00390314
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

	// Token: 0x0600EF25 RID: 61221 RVA: 0x00392174 File Offset: 0x00390374
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

	// Token: 0x0600EF26 RID: 61222 RVA: 0x003921E8 File Offset: 0x003903E8
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

	// Token: 0x0600EF27 RID: 61223 RVA: 0x003922A8 File Offset: 0x003904A8
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

	// Token: 0x0600EF28 RID: 61224 RVA: 0x003924F4 File Offset: 0x003906F4
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

	// Token: 0x0600EF29 RID: 61225 RVA: 0x00392547 File Offset: 0x00390747
	public HonamiStoryItemDataBase GetInsteadItem()
	{
		return this.TipsInsteadItem;
	}

	// Token: 0x0600EF2A RID: 61226 RVA: 0x0039254F File Offset: 0x0039074F
	public bool GetTipsOpen()
	{
		return this.GetLogicState() == EHonamiStoryBackpackLogicState.Tips || this.GetLogicState() == EHonamiStoryBackpackLogicState.TipsWithPlugins;
	}

	// Token: 0x0600EF2B RID: 61227 RVA: 0x00392565 File Offset: 0x00390765
	public void CloseTips()
	{
		this.TipsItem.OnClickedMask();
	}

	// Token: 0x0600EF2C RID: 61228 RVA: 0x00392572 File Offset: 0x00390772
	public void SetInteractController(HonamiStoryInteractController controller)
	{
		this.InteractController = controller;
	}

	// Token: 0x0600EF2D RID: 61229 RVA: 0x0039257B File Offset: 0x0039077B
	public HonamiStoryInteractController GetInteractController()
	{
		return this.InteractController;
	}

	// Token: 0x0600EF2E RID: 61230 RVA: 0x00392584 File Offset: 0x00390784
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

	// Token: 0x04006EC1 RID: 28353
	[Nullable(2)]
	public HonamiStoryBackpackView BackpackView;

	// Token: 0x04006EC2 RID: 28354
	[Nullable(2)]
	private TimerHandle DoubleClickedHandle;

	// Token: 0x04006EC3 RID: 28355
	[Nullable(2)]
	private HonamiStoryItemDataBase CurClickedItemData;

	// Token: 0x04006EC4 RID: 28356
	[Nullable(2)]
	private HonamiStoryItemGridItem CurClickedUiItem;

	// Token: 0x04006EC5 RID: 28357
	public List<HonamiStoryBackpackPanelBase> PanelBaseList = new List<HonamiStoryBackpackPanelBase>();

	// Token: 0x04006EC6 RID: 28358
	private EHonamiStoryBackpackLogicState CurState;

	// Token: 0x04006EC7 RID: 28359
	[Nullable(2)]
	private HonamiStoryBackpackValueCountItem ValuePanel;

	// Token: 0x04006EC8 RID: 28360
	private readonly HashSet<HonamiStoryItemDataBase> SellItemSet = new HashSet<HonamiStoryItemDataBase>();

	// Token: 0x04006EC9 RID: 28361
	private int CurValueSum;

	// Token: 0x04006ECA RID: 28362
	[Nullable(2)]
	private HonamiStoryItemDataBase TipsInsteadItem;

	// Token: 0x04006ECB RID: 28363
	private EHonamiStoryBackpack? TipsBackpackId;

	// Token: 0x04006ECC RID: 28364
	[Nullable(2)]
	public HonamiStoryItemTipsBase TipsItem;

	// Token: 0x04006ECD RID: 28365
	private HonamiStoryInteractController InteractController;
}

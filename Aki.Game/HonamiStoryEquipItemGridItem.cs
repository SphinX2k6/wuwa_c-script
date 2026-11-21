using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001361 RID: 4961
[NullableContext(2)]
[Nullable(0)]
public class HonamiStoryEquipItemGridItem : HonamiStoryItemGridItem
{
	// Token: 0x0600C4D8 RID: 50392 RVA: 0x003A8A06 File Offset: 0x003A6C06
	public HonamiStoryEquipItemGridItem(HonamiStoryItemDataBase itemData) : base(itemData)
	{
		this.ItemData = itemData;
	}

	// Token: 0x0600C4D9 RID: 50393 RVA: 0x003A8A18 File Offset: 0x003A6C18
	protected override void RefreshLogicData()
	{
		base.SetLockItemEnable(this.ItemData.IsLock(), false);
		EHonamiStoryBackpackLogicState backpackLogicState = HonamiStoryModel.Instance.GetBackpackLogicState();
		this.SetReplaceEnable(backpackLogicState == EHonamiStoryBackpackLogicState.Instead);
	}

	// Token: 0x0600C4DA RID: 50394 RVA: 0x003A8A4C File Offset: 0x003A6C4C
	protected override void ExecuteDoubleClickLogic()
	{
		EHonamiStoryBackpack toBackpack = HonamiStoryUtil.CheckInHonamiStoryDungeon() ? EHonamiStoryBackpack.Backpack : EHonamiStoryBackpack.Inventory;
		if (!HonamiStoryModel.Instance.SetItemIntoBag(this.ItemData, EHonamiStoryBackpack.Player, toBackpack))
		{
			if (UiManager.Instance.GetViewByName(EUiViewName.HonamiStoryBackpackView) != null)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("HonamiStory_NoEnoughSpace", Array.Empty<object>());
				return;
			}
			HonamiStoryModel.Instance.SetItemIntoBag(this.ItemData, EHonamiStoryBackpack.Player, EHonamiStoryBackpack.PickUpBox);
		}
	}

	// Token: 0x0600C4DB RID: 50395 RVA: 0x003A8AB8 File Offset: 0x003A6CB8
	protected override void DoLogicStateFunc(EHonamiStoryBackpackLogicState state)
	{
		if (state == EHonamiStoryBackpackLogicState.Instead)
		{
			HonamiStoryBackpackLogicController backpackLogic = HonamiStoryModel.Instance.GetBackpackLogic();
			int position = this.ItemData.GetPosition();
			backpackLogic.DoTipsWithPluginsInstead(position, this.ItemData);
			base.CancelToggleSelect();
			return;
		}
		if (state == EHonamiStoryBackpackLogicState.Tips || state == EHonamiStoryBackpackLogicState.TipsWithPlugins)
		{
			HonamiStoryBackpackLogicController backpackLogic2 = HonamiStoryModel.Instance.GetBackpackLogic();
			HonamiStoryItemTipsBase tipsItem = backpackLogic2.TipsItem;
			HonamiStoryItemDataBase itemDataOut = tipsItem.GetItemDataOut();
			if (backpackLogic2 != null)
			{
				backpackLogic2.CloseTips();
			}
			if (this.ItemData == itemDataOut)
			{
				tipsItem.SetItemDataOut(itemDataOut);
			}
			base.OnClickedToggle(EToggleState.ETT_UnChecked);
		}
	}

	// Token: 0x0600C4DC RID: 50396 RVA: 0x003A8B38 File Offset: 0x003A6D38
	protected void SetReplaceEnable(bool isEnable)
	{
		UiPanelBase replaceItem = this.ReplaceItem;
		if (replaceItem != null)
		{
			replaceItem.SetUiActive(isEnable);
		}
		if (isEnable && this.ReplaceItem == null)
		{
			this.ReplaceItem = new UiPanelBase();
			this.ReplaceItem.CreateThenShowByResourceIdAsync("SprChange", this.RootItem, false).ContinueWith(delegate()
			{
				bool uiActive = HonamiStoryModel.Instance.GetBackpackLogicState() == EHonamiStoryBackpackLogicState.Instead;
				UiPanelBase replaceItem2 = this.ReplaceItem;
				if (replaceItem2 == null)
				{
					return;
				}
				replaceItem2.SetUiActive(uiActive);
			});
		}
	}

	// Token: 0x04007039 RID: 28729
	private UiPanelBase ReplaceItem;
}

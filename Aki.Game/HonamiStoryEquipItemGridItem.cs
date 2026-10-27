using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001E9F RID: 7839
[NullableContext(2)]
[Nullable(0)]
public class HonamiStoryEquipItemGridItem : HonamiStoryItemGridItem
{
	// Token: 0x0600F0B9 RID: 61625 RVA: 0x0039CE4A File Offset: 0x0039B04A
	public HonamiStoryEquipItemGridItem(HonamiStoryItemDataBase itemData) : base(itemData)
	{
		this.ItemData = itemData;
	}

	// Token: 0x0600F0BA RID: 61626 RVA: 0x0039CE5C File Offset: 0x0039B05C
	protected override void RefreshLogicData()
	{
		base.SetLockItemEnable(this.ItemData.IsLock(), false);
		EHonamiStoryBackpackLogicState backpackLogicState = HonamiStoryModel.Instance.GetBackpackLogicState();
		this.SetReplaceEnable(backpackLogicState == EHonamiStoryBackpackLogicState.Instead);
	}

	// Token: 0x0600F0BB RID: 61627 RVA: 0x0039CE90 File Offset: 0x0039B090
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

	// Token: 0x0600F0BC RID: 61628 RVA: 0x0039CEFC File Offset: 0x0039B0FC
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

	// Token: 0x0600F0BD RID: 61629 RVA: 0x0039CF7C File Offset: 0x0039B17C
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

	// Token: 0x04006F58 RID: 28504
	private UiPanelBase ReplaceItem;
}

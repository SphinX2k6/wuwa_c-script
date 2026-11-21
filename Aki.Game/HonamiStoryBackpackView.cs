using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200137A RID: 4986
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryBackpackView : UiViewBase
{
	// Token: 0x0600C5FC RID: 50684 RVA: 0x003AF4FC File Offset: 0x003AD6FC
	public HonamiStoryBackpackView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C5FD RID: 50685 RVA: 0x003AF51C File Offset: 0x003AD71C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickMask));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600C5FE RID: 50686 RVA: 0x003AF688 File Offset: 0x003AD888
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryBackpackView.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryBackpackView.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C5FF RID: 50687 RVA: 0x003AF6CB File Offset: 0x003AD8CB
	protected override void OnStart()
	{
		this.InitTipsItem();
	}

	// Token: 0x0600C600 RID: 50688 RVA: 0x003AF6D4 File Offset: 0x003AD8D4
	protected void InitSequenceEvents()
	{
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence != null)
		{
			uiViewSequence.AddSequenceFinishEvent("Drag_Hide", delegate(string _)
			{
				this.CaptionItem.SetCloseBtnActive(false);
			}, false);
		}
		UiBehaviorLevelSequence uiViewSequence2 = this.UiViewSequence;
		if (uiViewSequence2 == null)
		{
			return;
		}
		uiViewSequence2.AddSequenceFinishEvent("Drag_Show", delegate(string _)
		{
			this.CaptionItem.SetCloseBtnActive(true);
		}, false);
	}

	// Token: 0x0600C601 RID: 50689 RVA: 0x003AF728 File Offset: 0x003AD928
	protected override void OnBeforeDestroy()
	{
		EHonamiStoryBackpack backpackId = HonamiStoryUtil.CheckInHonamiStoryDungeon() ? EHonamiStoryBackpack.Backpack : EHonamiStoryBackpack.Inventory;
		HonamiStoryBackpackData backPackData = HonamiStoryModel.Instance.GetBackPackData((int)backpackId, true);
		if (backPackData != null)
		{
			backPackData.ClearNewInBackpack();
		}
		HonamiStoryModel.Instance.SetGamepadLogic(null);
		HonamiStoryModel.Instance.SetBackpackLogic(null);
	}

	// Token: 0x0600C602 RID: 50690 RVA: 0x003AF770 File Offset: 0x003AD970
	private UniTask InitPlayerBackpackPanel()
	{
		HonamiStoryBackpackView.<InitPlayerBackpackPanel>d__20 <InitPlayerBackpackPanel>d__;
		<InitPlayerBackpackPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitPlayerBackpackPanel>d__.<>4__this = this;
		<InitPlayerBackpackPanel>d__.<>1__state = -1;
		<InitPlayerBackpackPanel>d__.<>t__builder.Start<HonamiStoryBackpackView.<InitPlayerBackpackPanel>d__20>(ref <InitPlayerBackpackPanel>d__);
		return <InitPlayerBackpackPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600C603 RID: 50691 RVA: 0x003AF7B4 File Offset: 0x003AD9B4
	private UniTask InitBackpackPanel()
	{
		HonamiStoryBackpackView.<InitBackpackPanel>d__21 <InitBackpackPanel>d__;
		<InitBackpackPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitBackpackPanel>d__.<>4__this = this;
		<InitBackpackPanel>d__.<>1__state = -1;
		<InitBackpackPanel>d__.<>t__builder.Start<HonamiStoryBackpackView.<InitBackpackPanel>d__21>(ref <InitBackpackPanel>d__);
		return <InitBackpackPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600C604 RID: 50692 RVA: 0x003AF7F8 File Offset: 0x003AD9F8
	private UniTask InitDiscardBackpackPanel()
	{
		HonamiStoryBackpackView.<InitDiscardBackpackPanel>d__22 <InitDiscardBackpackPanel>d__;
		<InitDiscardBackpackPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitDiscardBackpackPanel>d__.<>4__this = this;
		<InitDiscardBackpackPanel>d__.<>1__state = -1;
		<InitDiscardBackpackPanel>d__.<>t__builder.Start<HonamiStoryBackpackView.<InitDiscardBackpackPanel>d__22>(ref <InitDiscardBackpackPanel>d__);
		return <InitDiscardBackpackPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600C605 RID: 50693 RVA: 0x003AF83C File Offset: 0x003ADA3C
	private UniTask InitTipsItem()
	{
		HonamiStoryBackpackView.<InitTipsItem>d__23 <InitTipsItem>d__;
		<InitTipsItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitTipsItem>d__.<>4__this = this;
		<InitTipsItem>d__.<>1__state = -1;
		<InitTipsItem>d__.<>t__builder.Start<HonamiStoryBackpackView.<InitTipsItem>d__23>(ref <InitTipsItem>d__);
		return <InitTipsItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600C606 RID: 50694 RVA: 0x003AF87F File Offset: 0x003ADA7F
	protected override void OnBeforeShow()
	{
		this.DragController.OnBeforeShow();
		HonamiStorySkillDescToggle descToggleItem = this.DescToggleItem;
		if (descToggleItem == null)
		{
			return;
		}
		descToggleItem.RefreshState();
	}

	// Token: 0x0600C607 RID: 50695 RVA: 0x003AF89C File Offset: 0x003ADA9C
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<EInputControllerMainType, EInputControllerMainType>(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
	}

	// Token: 0x0600C608 RID: 50696 RVA: 0x003AF8BA File Offset: 0x003ADABA
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
	}

	// Token: 0x0600C609 RID: 50697 RVA: 0x003AF8D8 File Offset: 0x003ADAD8
	private void ShowTips([Nullable(2)] HonamiStoryItemGridItem item, Vector2D loc, Vector2D size, EHonamiStoryBackpackType type)
	{
		if (item == null || item.GetData() == null)
		{
			return;
		}
		this.DragController.OnClickedItem(true, item.GetData().GetIncId(), item);
		HonamiStoryItemDataBase data = item.GetData();
		HonamiStoryItemTipsBase tipsItem = this.TipsItem;
		if (tipsItem == null)
		{
			return;
		}
		tipsItem.Refresh(data, type, data.GetPosition(), new Action(item.OnHideCallback), loc, size);
	}

	// Token: 0x0600C60A RID: 50698 RVA: 0x003AF938 File Offset: 0x003ADB38
	public void ShowTipsHotKeyOnly(HonamiStoryGridItemBase item)
	{
		if (HonamiStoryModel.Instance.GetGamepadLogic() != null)
		{
			HonamiStoryItemTipsHotKey tipsItemHotkey = this.TipsItemHotkey;
			if (tipsItemHotkey != null)
			{
				tipsItemHotkey.GetRootItem().SetUIParent(base.GetItem(5), false);
			}
			HonamiStoryItemTipsHotKey tipsItemHotkey2 = this.TipsItemHotkey;
			if (tipsItemHotkey2 != null)
			{
				tipsItemHotkey2.SetAutoLocation(item.GetRootItem());
			}
			HonamiStoryItemTipsHotKey tipsItemHotkey3 = this.TipsItemHotkey;
			if (tipsItemHotkey3 == null)
			{
				return;
			}
			tipsItemHotkey3.SetUiActive(true);
		}
	}

	// Token: 0x0600C60B RID: 50699 RVA: 0x003AF997 File Offset: 0x003ADB97
	public void HideAllTips()
	{
		HonamiStoryItemTipsBase tipsItem = this.TipsItem;
		if (tipsItem != null)
		{
			tipsItem.SetTipsVisible(false);
		}
		this.TipsItemDetail.SetUiActive(false);
		this.TipsAttrChange.SetUiActive(false);
		HonamiStoryItemTipsHotKey tipsItemHotkey = this.TipsItemHotkey;
		if (tipsItemHotkey == null)
		{
			return;
		}
		tipsItemHotkey.SetUiActive(false);
	}

	// Token: 0x0600C60C RID: 50700 RVA: 0x003AF9D4 File Offset: 0x003ADBD4
	[NullableContext(2)]
	private void ShowTipsDetail(HonamiStoryItemGridItem item, EHonamiStoryBackpackType type)
	{
		EHonamiStoryBackpackLogicState backpackLogicState = HonamiStoryModel.Instance.GetBackpackLogicState();
		bool flag = backpackLogicState == EHonamiStoryBackpackLogicState.Sell;
		bool flag2 = backpackLogicState == EHonamiStoryBackpackLogicState.Tips || backpackLogicState == EHonamiStoryBackpackLogicState.TipsWithPlugins;
		bool flag3 = HonamiStoryUtil.IsMobileView();
		HonamiStoryModel.Instance.GetGamepadLogic().SetCurItem(item);
		if (item == null || item.GetData() == null || flag || flag2 || flag3)
		{
			return;
		}
		HonamiStoryItemDataBase data = item.GetData();
		this.TipsItemDetail.Refresh(data, type);
		if (this.TipsItemHotkey != null && Info.Instance.IsInGamepad())
		{
			this.TipsItemDetail.AddHotKey(this.TipsItemHotkey.GetRootItem());
		}
		this.TipsItemDetail.SetAutoLocation(item.GetRootItem());
		this.TipsItemDetail.SetUiActive(true);
	}

	// Token: 0x0600C60D RID: 50701 RVA: 0x003AFA88 File Offset: 0x003ADC88
	private void HideTipsDetail()
	{
		this.TipsItemDetail.SetUiActive(false);
	}

	// Token: 0x0600C60E RID: 50702 RVA: 0x003AFA98 File Offset: 0x003ADC98
	private void ShowTipsAttrChange([Nullable(2)] HonamiStoryEquipGridItem item, HonamiStoryInteractOperateAgent operateAgent)
	{
		this.TipsItemDetail.SetUiActive(false);
		this.TipsAttrChange.SetUiActive(false);
		if (item == null || operateAgent.OperateData == null || operateAgent.OperateData.GetItemType() == EHonamiStoryItemType.Normal)
		{
			return;
		}
		HonamiStoryItemDataBase data = item.GetData();
		if (data == null)
		{
			return;
		}
		HonamiStoryEquipItemData honamiStoryEquipItemData = HonamiStoryModel.Instance.GetItemData(data.GetIncId()) as HonamiStoryEquipItemData;
		HonamiStoryEquipItemData honamiStoryEquipItemData2 = HonamiStoryModel.Instance.GetItemData(operateAgent.OperateData.GetIncId()) as HonamiStoryEquipItemData;
		if (honamiStoryEquipItemData == honamiStoryEquipItemData2)
		{
			return;
		}
		this.TipsAttrChange.SetUiActive(true);
		if (Info.Instance.IsInGamepad())
		{
			this.TipsAttrChange.Refresh(honamiStoryEquipItemData, honamiStoryEquipItemData2, delegate
			{
				this.TipsAttrChange.GetRootItem().SetUIParent(this.DragController.GetDragTipsRoot(), false);
				if (this.TipsItemHotkey != null)
				{
					this.TipsAttrChange.AddHotKey(this.TipsItemHotkey.GetRootItem());
				}
			});
			return;
		}
		this.TipsAttrChange.Refresh(honamiStoryEquipItemData, honamiStoryEquipItemData2, delegate
		{
			this.TipsAttrChange.GetRootItem().SetUIParent(this.DragController.GetDragTipsRoot(), false);
		});
	}

	// Token: 0x0600C60F RID: 50703 RVA: 0x003AFB64 File Offset: 0x003ADD64
	public void OnEnterGamepadMask()
	{
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence == null)
		{
			return;
		}
		uiViewSequence.PlaySequence("Drag_Hide", false, null);
	}

	// Token: 0x0600C610 RID: 50704 RVA: 0x003AFB90 File Offset: 0x003ADD90
	public void OnExitGamepadMask()
	{
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence == null)
		{
			return;
		}
		uiViewSequence.PlaySequence("Drag_Show", false, null);
	}

	// Token: 0x0600C611 RID: 50705 RVA: 0x003AFBBC File Offset: 0x003ADDBC
	public void OnDragBegin()
	{
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence == null)
		{
			return;
		}
		uiViewSequence.PlaySequence("Drag_Hide", false, null);
	}

	// Token: 0x0600C612 RID: 50706 RVA: 0x003AFBE8 File Offset: 0x003ADDE8
	public void OnDragEnd()
	{
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence != null)
		{
			uiViewSequence.PlaySequence("Drag_Show", false, null);
		}
		HonamiStoryItemTipsHotKey tipsItemHotkey = this.TipsItemHotkey;
		if (tipsItemHotkey == null)
		{
			return;
		}
		tipsItemHotkey.SetUiActive(false);
	}

	// Token: 0x0600C613 RID: 50707 RVA: 0x003AFC28 File Offset: 0x003ADE28
	public void SetSellMode(bool active)
	{
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem != null)
		{
			captionItem.SetCloseBtnActive(!active);
		}
		PopupCaptionItem captionItem2 = this.CaptionItem;
		if (captionItem2 != null)
		{
			captionItem2.SetHelpBtnActive(!active);
		}
		PopupCaptionItem captionItem3 = this.CaptionItem;
		if (captionItem3 != null)
		{
			captionItem3.SetHomeBtnShowState(!active);
		}
		if (active)
		{
			this.HideTipsDetail();
		}
		UiNavigationNewController.Instance.SetLockUseDragState(active);
	}

	// Token: 0x0600C614 RID: 50708 RVA: 0x003AFC88 File Offset: 0x003ADE88
	private void OnClickCloseButton()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600C615 RID: 50709 RVA: 0x003AFC91 File Offset: 0x003ADE91
	[NullableContext(2)]
	private void OnEnterItem(HonamiStoryItemGridItem item, EHonamiStoryBackpackType type)
	{
		this.ShowTipsDetail(item, type);
	}

	// Token: 0x0600C616 RID: 50710 RVA: 0x003AFC9B File Offset: 0x003ADE9B
	private void OnExitItem()
	{
		this.HideTipsDetail();
	}

	// Token: 0x0600C617 RID: 50711 RVA: 0x003AFCA3 File Offset: 0x003ADEA3
	private void OnCheckAttrItem([Nullable(2)] HonamiStoryEquipGridItem item, HonamiStoryInteractOperateAgent operateAgent)
	{
		this.ShowTipsAttrChange(item, operateAgent);
	}

	// Token: 0x0600C618 RID: 50712 RVA: 0x003AFCAD File Offset: 0x003ADEAD
	private void OnClickItem([Nullable(2)] HonamiStoryItemGridItem item, Vector2D loc, Vector2D size, EHonamiStoryBackpackType type)
	{
		this.HideTipsDetail();
		this.ShowTips(item, loc, size, type);
	}

	// Token: 0x0600C619 RID: 50713 RVA: 0x003AFCC0 File Offset: 0x003ADEC0
	private void OnClickMask()
	{
		Action onTipsClickCb = this.OnTipsClickCb;
		if (onTipsClickCb == null)
		{
			return;
		}
		onTipsClickCb();
	}

	// Token: 0x0600C61A RID: 50714 RVA: 0x003AFCD2 File Offset: 0x003ADED2
	private void OnInputControllerMainTypeChange(EInputControllerMainType last, EInputControllerMainType now)
	{
		if (last == EInputControllerMainType.Gamepad)
		{
			HonamiStoryModel.Instance.GetGamepadLogic().SwitchToKeyboardState();
			return;
		}
		if (now == EInputControllerMainType.Gamepad)
		{
			HonamiStoryModel.Instance.GetGamepadLogic().SwitchToGamepadState(false);
		}
	}

	// Token: 0x0600C61B RID: 50715 RVA: 0x003AFCFC File Offset: 0x003ADEFC
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length == 0)
		{
			return null;
		}
		string a = configParams[0];
		if (a == "RolePanel" || a == "Equips" || a == "AddBtn" || a == "UpdateBtn" || a == "Capybara" || a == "SuitDesc")
		{
			HonamiStoryEquipBackpackPanel equipPanel = this.EquipPanel;
			if (equipPanel == null)
			{
				return null;
			}
			return equipPanel.GetGuideUiItemAndUiItemForShowEx(configParams);
		}
		else if (a == "BtnSell" || a == "ToggleSelect" || a == "BtnReset" || a == "Item")
		{
			HonamiStoryBackpackPanel backpackPanel = this.BackpackPanel;
			if (backpackPanel == null)
			{
				return null;
			}
			return backpackPanel.GetGuideUiItemAndUiItemForShowEx(configParams);
		}
		else
		{
			if (!(a == "SkillRoleText"))
			{
				if (a == "Plugin")
				{
					HonamiStoryEquipBackpackPanel equipPanel2 = this.EquipPanel;
					UUIItem[] array = (equipPanel2 != null) ? equipPanel2.GetGuideUiItemAndUiItemForShowEx(configParams) : null;
					if (array != null && array.Length != 0)
					{
						return array;
					}
					HonamiStoryBackpackPanel backpackPanel2 = this.BackpackPanel;
					UUIItem[] array2 = (backpackPanel2 != null) ? backpackPanel2.GetGuideUiItemAndUiItemForShowEx(configParams) : null;
					if (array2 != null && array2.Length != 0)
					{
						return array2;
					}
				}
				return null;
			}
			HonamiStoryItemTipsBase tipsItem = this.TipsItem;
			if (tipsItem == null)
			{
				return null;
			}
			return tipsItem.GetGuideUiItemAndUiItemForShowEx(configParams);
		}
	}

	// Token: 0x040070A8 RID: 28840
	private HonamiStoryEquipBackpackPanel EquipPanel;

	// Token: 0x040070A9 RID: 28841
	private HonamiStoryBackpackPanel BackpackPanel;

	// Token: 0x040070AA RID: 28842
	private HonamiStoryDiscardBackpackPanel DiscardPanel;

	// Token: 0x040070AB RID: 28843
	private readonly HonamiStoryInteractController DragController = new HonamiStoryInteractController();

	// Token: 0x040070AC RID: 28844
	private readonly HonamiStoryBackpackLogicController BackpackLogicController = new HonamiStoryBackpackLogicController();

	// Token: 0x040070AD RID: 28845
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x040070AE RID: 28846
	[Nullable(2)]
	private HonamiStoryItemTipsBase TipsItem;

	// Token: 0x040070AF RID: 28847
	[Nullable(2)]
	private HonamiStoryItemTipsDetail TipsItemDetail;

	// Token: 0x040070B0 RID: 28848
	[Nullable(2)]
	private HonamiStoryItemTipsAttrChange TipsAttrChange;

	// Token: 0x040070B1 RID: 28849
	[Nullable(2)]
	private HonamiStoryItemTipsHotKey TipsItemHotkey;

	// Token: 0x040070B2 RID: 28850
	[Nullable(2)]
	private Action OnTipsClickCb;

	// Token: 0x040070B3 RID: 28851
	private float BasePanelHeight;

	// Token: 0x040070B4 RID: 28852
	[Nullable(2)]
	private HonamiStorySkillDescToggle DescToggleItem;

	// Token: 0x0200761B RID: 30235
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040265B0 RID: 157104
		EquipPanel,
		// Token: 0x040265B1 RID: 157105
		BackpackPanel,
		// Token: 0x040265B2 RID: 157106
		AttachPanel,
		// Token: 0x040265B3 RID: 157107
		DeletePanel,
		// Token: 0x040265B4 RID: 157108
		CaptionItem,
		// Token: 0x040265B5 RID: 157109
		PanelTips,
		// Token: 0x040265B6 RID: 157110
		BtnMask,
		// Token: 0x040265B7 RID: 157111
		DescToggleItem
	}
}

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

// Token: 0x02001EB8 RID: 7864
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryBackpackView : UiViewBase
{
	// Token: 0x0600F1DD RID: 61917 RVA: 0x003A39FC File Offset: 0x003A1BFC
	public HonamiStoryBackpackView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600F1DE RID: 61918 RVA: 0x003A3A1C File Offset: 0x003A1C1C
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

	// Token: 0x0600F1DF RID: 61919 RVA: 0x003A3B88 File Offset: 0x003A1D88
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryBackpackView.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryBackpackView.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F1E0 RID: 61920 RVA: 0x003A3BCB File Offset: 0x003A1DCB
	protected override void OnStart()
	{
		this.InitTipsItem();
	}

	// Token: 0x0600F1E1 RID: 61921 RVA: 0x003A3BD4 File Offset: 0x003A1DD4
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

	// Token: 0x0600F1E2 RID: 61922 RVA: 0x003A3C28 File Offset: 0x003A1E28
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

	// Token: 0x0600F1E3 RID: 61923 RVA: 0x003A3C70 File Offset: 0x003A1E70
	private UniTask InitPlayerBackpackPanel()
	{
		HonamiStoryBackpackView.<InitPlayerBackpackPanel>d__20 <InitPlayerBackpackPanel>d__;
		<InitPlayerBackpackPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitPlayerBackpackPanel>d__.<>4__this = this;
		<InitPlayerBackpackPanel>d__.<>1__state = -1;
		<InitPlayerBackpackPanel>d__.<>t__builder.Start<HonamiStoryBackpackView.<InitPlayerBackpackPanel>d__20>(ref <InitPlayerBackpackPanel>d__);
		return <InitPlayerBackpackPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600F1E4 RID: 61924 RVA: 0x003A3CB4 File Offset: 0x003A1EB4
	private UniTask InitBackpackPanel()
	{
		HonamiStoryBackpackView.<InitBackpackPanel>d__21 <InitBackpackPanel>d__;
		<InitBackpackPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitBackpackPanel>d__.<>4__this = this;
		<InitBackpackPanel>d__.<>1__state = -1;
		<InitBackpackPanel>d__.<>t__builder.Start<HonamiStoryBackpackView.<InitBackpackPanel>d__21>(ref <InitBackpackPanel>d__);
		return <InitBackpackPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600F1E5 RID: 61925 RVA: 0x003A3CF8 File Offset: 0x003A1EF8
	private UniTask InitDiscardBackpackPanel()
	{
		HonamiStoryBackpackView.<InitDiscardBackpackPanel>d__22 <InitDiscardBackpackPanel>d__;
		<InitDiscardBackpackPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitDiscardBackpackPanel>d__.<>4__this = this;
		<InitDiscardBackpackPanel>d__.<>1__state = -1;
		<InitDiscardBackpackPanel>d__.<>t__builder.Start<HonamiStoryBackpackView.<InitDiscardBackpackPanel>d__22>(ref <InitDiscardBackpackPanel>d__);
		return <InitDiscardBackpackPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600F1E6 RID: 61926 RVA: 0x003A3D3C File Offset: 0x003A1F3C
	private UniTask InitTipsItem()
	{
		HonamiStoryBackpackView.<InitTipsItem>d__23 <InitTipsItem>d__;
		<InitTipsItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitTipsItem>d__.<>4__this = this;
		<InitTipsItem>d__.<>1__state = -1;
		<InitTipsItem>d__.<>t__builder.Start<HonamiStoryBackpackView.<InitTipsItem>d__23>(ref <InitTipsItem>d__);
		return <InitTipsItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600F1E7 RID: 61927 RVA: 0x003A3D7F File Offset: 0x003A1F7F
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

	// Token: 0x0600F1E8 RID: 61928 RVA: 0x003A3D9C File Offset: 0x003A1F9C
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<EInputControllerMainType, EInputControllerMainType>(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
	}

	// Token: 0x0600F1E9 RID: 61929 RVA: 0x003A3DBA File Offset: 0x003A1FBA
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
	}

	// Token: 0x0600F1EA RID: 61930 RVA: 0x003A3DD8 File Offset: 0x003A1FD8
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

	// Token: 0x0600F1EB RID: 61931 RVA: 0x003A3E38 File Offset: 0x003A2038
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

	// Token: 0x0600F1EC RID: 61932 RVA: 0x003A3E97 File Offset: 0x003A2097
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

	// Token: 0x0600F1ED RID: 61933 RVA: 0x003A3ED4 File Offset: 0x003A20D4
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

	// Token: 0x0600F1EE RID: 61934 RVA: 0x003A3F88 File Offset: 0x003A2188
	private void HideTipsDetail()
	{
		this.TipsItemDetail.SetUiActive(false);
	}

	// Token: 0x0600F1EF RID: 61935 RVA: 0x003A3F98 File Offset: 0x003A2198
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

	// Token: 0x0600F1F0 RID: 61936 RVA: 0x003A4064 File Offset: 0x003A2264
	public void OnEnterGamepadMask()
	{
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence == null)
		{
			return;
		}
		uiViewSequence.PlaySequence("Drag_Hide", false, null);
	}

	// Token: 0x0600F1F1 RID: 61937 RVA: 0x003A4090 File Offset: 0x003A2290
	public void OnExitGamepadMask()
	{
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence == null)
		{
			return;
		}
		uiViewSequence.PlaySequence("Drag_Show", false, null);
	}

	// Token: 0x0600F1F2 RID: 61938 RVA: 0x003A40BC File Offset: 0x003A22BC
	public void OnDragBegin()
	{
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence == null)
		{
			return;
		}
		uiViewSequence.PlaySequence("Drag_Hide", false, null);
	}

	// Token: 0x0600F1F3 RID: 61939 RVA: 0x003A40E8 File Offset: 0x003A22E8
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

	// Token: 0x0600F1F4 RID: 61940 RVA: 0x003A4128 File Offset: 0x003A2328
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

	// Token: 0x0600F1F5 RID: 61941 RVA: 0x003A4188 File Offset: 0x003A2388
	private void OnClickCloseButton()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600F1F6 RID: 61942 RVA: 0x003A4191 File Offset: 0x003A2391
	[NullableContext(2)]
	private void OnEnterItem(HonamiStoryItemGridItem item, EHonamiStoryBackpackType type)
	{
		this.ShowTipsDetail(item, type);
	}

	// Token: 0x0600F1F7 RID: 61943 RVA: 0x003A419B File Offset: 0x003A239B
	private void OnExitItem()
	{
		this.HideTipsDetail();
	}

	// Token: 0x0600F1F8 RID: 61944 RVA: 0x003A41A3 File Offset: 0x003A23A3
	private void OnCheckAttrItem([Nullable(2)] HonamiStoryEquipGridItem item, HonamiStoryInteractOperateAgent operateAgent)
	{
		this.ShowTipsAttrChange(item, operateAgent);
	}

	// Token: 0x0600F1F9 RID: 61945 RVA: 0x003A41AD File Offset: 0x003A23AD
	private void OnClickItem([Nullable(2)] HonamiStoryItemGridItem item, Vector2D loc, Vector2D size, EHonamiStoryBackpackType type)
	{
		this.HideTipsDetail();
		this.ShowTips(item, loc, size, type);
	}

	// Token: 0x0600F1FA RID: 61946 RVA: 0x003A41C0 File Offset: 0x003A23C0
	private void OnClickMask()
	{
		Action onTipsClickCb = this.OnTipsClickCb;
		if (onTipsClickCb == null)
		{
			return;
		}
		onTipsClickCb();
	}

	// Token: 0x0600F1FB RID: 61947 RVA: 0x003A41D2 File Offset: 0x003A23D2
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

	// Token: 0x0600F1FC RID: 61948 RVA: 0x003A41FC File Offset: 0x003A23FC
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

	// Token: 0x04006FC7 RID: 28615
	private HonamiStoryEquipBackpackPanel EquipPanel;

	// Token: 0x04006FC8 RID: 28616
	private HonamiStoryBackpackPanel BackpackPanel;

	// Token: 0x04006FC9 RID: 28617
	private HonamiStoryDiscardBackpackPanel DiscardPanel;

	// Token: 0x04006FCA RID: 28618
	private readonly HonamiStoryInteractController DragController = new HonamiStoryInteractController();

	// Token: 0x04006FCB RID: 28619
	private readonly HonamiStoryBackpackLogicController BackpackLogicController = new HonamiStoryBackpackLogicController();

	// Token: 0x04006FCC RID: 28620
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04006FCD RID: 28621
	[Nullable(2)]
	private HonamiStoryItemTipsBase TipsItem;

	// Token: 0x04006FCE RID: 28622
	[Nullable(2)]
	private HonamiStoryItemTipsDetail TipsItemDetail;

	// Token: 0x04006FCF RID: 28623
	[Nullable(2)]
	private HonamiStoryItemTipsAttrChange TipsAttrChange;

	// Token: 0x04006FD0 RID: 28624
	[Nullable(2)]
	private HonamiStoryItemTipsHotKey TipsItemHotkey;

	// Token: 0x04006FD1 RID: 28625
	[Nullable(2)]
	private Action OnTipsClickCb;

	// Token: 0x04006FD2 RID: 28626
	private float BasePanelHeight;

	// Token: 0x04006FD3 RID: 28627
	[Nullable(2)]
	private HonamiStorySkillDescToggle DescToggleItem;

	// Token: 0x02008496 RID: 33942
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402B28C RID: 176780
		EquipPanel,
		// Token: 0x0402B28D RID: 176781
		BackpackPanel,
		// Token: 0x0402B28E RID: 176782
		AttachPanel,
		// Token: 0x0402B28F RID: 176783
		DeletePanel,
		// Token: 0x0402B290 RID: 176784
		CaptionItem,
		// Token: 0x0402B291 RID: 176785
		PanelTips,
		// Token: 0x0402B292 RID: 176786
		BtnMask,
		// Token: 0x0402B293 RID: 176787
		DescToggleItem
	}
}

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

// Token: 0x02001EE1 RID: 7905
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryPickUpBackpackView : UiViewBase
{
	// Token: 0x0600F341 RID: 62273 RVA: 0x003AA517 File Offset: 0x003A8717
	public HonamiStoryPickUpBackpackView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600F342 RID: 62274 RVA: 0x003AA538 File Offset: 0x003A8738
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
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
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickMask));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600F343 RID: 62275 RVA: 0x003AA6C8 File Offset: 0x003A88C8
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryPickUpBackpackView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryPickUpBackpackView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F344 RID: 62276 RVA: 0x003AA70B File Offset: 0x003A890B
	protected override void OnStart()
	{
		this.InitTipsItem();
	}

	// Token: 0x0600F345 RID: 62277 RVA: 0x003AA714 File Offset: 0x003A8914
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

	// Token: 0x0600F346 RID: 62278 RVA: 0x003AA766 File Offset: 0x003A8966
	protected override void OnBeforeDestroy()
	{
		HonamiStoryModel.Instance.SetGamepadLogic(null);
		HonamiStoryModel.Instance.SetBackpackLogic(null);
	}

	// Token: 0x0600F347 RID: 62279 RVA: 0x003AA780 File Offset: 0x003A8980
	private UniTask InitPlayerBackpackPanel()
	{
		HonamiStoryPickUpBackpackView.<InitPlayerBackpackPanel>d__21 <InitPlayerBackpackPanel>d__;
		<InitPlayerBackpackPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitPlayerBackpackPanel>d__.<>4__this = this;
		<InitPlayerBackpackPanel>d__.<>1__state = -1;
		<InitPlayerBackpackPanel>d__.<>t__builder.Start<HonamiStoryPickUpBackpackView.<InitPlayerBackpackPanel>d__21>(ref <InitPlayerBackpackPanel>d__);
		return <InitPlayerBackpackPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600F348 RID: 62280 RVA: 0x003AA7C4 File Offset: 0x003A89C4
	private UniTask InitBackpackPanel()
	{
		HonamiStoryPickUpBackpackView.<InitBackpackPanel>d__22 <InitBackpackPanel>d__;
		<InitBackpackPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitBackpackPanel>d__.<>4__this = this;
		<InitBackpackPanel>d__.<>1__state = -1;
		<InitBackpackPanel>d__.<>t__builder.Start<HonamiStoryPickUpBackpackView.<InitBackpackPanel>d__22>(ref <InitBackpackPanel>d__);
		return <InitBackpackPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600F349 RID: 62281 RVA: 0x003AA808 File Offset: 0x003A8A08
	private UniTask InitDiscardBackpackPanel()
	{
		HonamiStoryPickUpBackpackView.<InitDiscardBackpackPanel>d__23 <InitDiscardBackpackPanel>d__;
		<InitDiscardBackpackPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitDiscardBackpackPanel>d__.<>4__this = this;
		<InitDiscardBackpackPanel>d__.<>1__state = -1;
		<InitDiscardBackpackPanel>d__.<>t__builder.Start<HonamiStoryPickUpBackpackView.<InitDiscardBackpackPanel>d__23>(ref <InitDiscardBackpackPanel>d__);
		return <InitDiscardBackpackPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600F34A RID: 62282 RVA: 0x003AA84C File Offset: 0x003A8A4C
	private UniTask InitTipsItem()
	{
		HonamiStoryPickUpBackpackView.<InitTipsItem>d__24 <InitTipsItem>d__;
		<InitTipsItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitTipsItem>d__.<>4__this = this;
		<InitTipsItem>d__.<>1__state = -1;
		<InitTipsItem>d__.<>t__builder.Start<HonamiStoryPickUpBackpackView.<InitTipsItem>d__24>(ref <InitTipsItem>d__);
		return <InitTipsItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600F34B RID: 62283 RVA: 0x003AA890 File Offset: 0x003A8A90
	private UniTask InitPickUpPanel()
	{
		HonamiStoryPickUpBackpackView.<InitPickUpPanel>d__25 <InitPickUpPanel>d__;
		<InitPickUpPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitPickUpPanel>d__.<>4__this = this;
		<InitPickUpPanel>d__.<>1__state = -1;
		<InitPickUpPanel>d__.<>t__builder.Start<HonamiStoryPickUpBackpackView.<InitPickUpPanel>d__25>(ref <InitPickUpPanel>d__);
		return <InitPickUpPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600F34C RID: 62284 RVA: 0x003AA8D4 File Offset: 0x003A8AD4
	private void ShowTips([Nullable(2)] HonamiStoryItemGridItem item, Vector2D loc, Vector2D size, EHonamiStoryBackpackType packType)
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
		tipsItem.Refresh(data, packType, data.GetPosition(), new Action(item.OnHideCallback), loc, size);
	}

	// Token: 0x0600F34D RID: 62285 RVA: 0x003AA934 File Offset: 0x003A8B34
	public void ShowTipsHotKeyOnly(HonamiStoryGridItemBase item)
	{
		if (HonamiStoryModel.Instance.GetGamepadLogic() != null)
		{
			this.TipsItemHotkey.GetRootItem().SetUIParent(base.GetItem(5), false);
			this.TipsItemHotkey.SetAutoLocation(item.GetRootItem());
			this.TipsItemHotkey.SetUiActive(true);
		}
	}

	// Token: 0x0600F34E RID: 62286 RVA: 0x003AA982 File Offset: 0x003A8B82
	public void HideAllTips()
	{
		HonamiStoryItemTipsBase tipsItem = this.TipsItem;
		if (tipsItem != null)
		{
			tipsItem.SetUiActive(false);
		}
		this.TipsItemDetail.SetUiActive(false);
		this.TipsAttrChange.SetUiActive(false);
		this.TipsItemHotkey.SetUiActive(false);
	}

	// Token: 0x0600F34F RID: 62287 RVA: 0x003AA9BC File Offset: 0x003A8BBC
	[NullableContext(2)]
	private void ShowTipsDetail(HonamiStoryItemGridItem item, EHonamiStoryBackpackType type)
	{
		bool flag = HonamiStoryModel.Instance.GetBackpackLogicState() == EHonamiStoryBackpackLogicState.Sell;
		bool active = this.TipsItem.GetActive();
		if (item == null || item.GetData() == null || flag || active)
		{
			return;
		}
		HonamiStoryItemDataBase data = item.GetData();
		HonamiStoryModel.Instance.GetGamepadLogic().SetCurItem(item);
		this.TipsItemDetail.Refresh(data, type);
		if (Info.Instance.IsInGamepad())
		{
			this.TipsItemDetail.AddHotKey(this.TipsItemHotkey.GetRootItem());
		}
		this.TipsItemDetail.SetAutoLocation(item.GetRootItem());
		this.TipsItemDetail.SetUiActive(true);
	}

	// Token: 0x0600F350 RID: 62288 RVA: 0x003AAA5C File Offset: 0x003A8C5C
	private void HideTipsDetail()
	{
		this.TipsItemDetail.SetUiActive(false);
	}

	// Token: 0x0600F351 RID: 62289 RVA: 0x003AAA6C File Offset: 0x003A8C6C
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
		HonamiStoryEquipItemData honamiStoryEquipItemData = (HonamiStoryEquipItemData)HonamiStoryModel.Instance.GetItemData(data.GetIncId());
		HonamiStoryEquipItemData newData = (HonamiStoryEquipItemData)HonamiStoryModel.Instance.GetItemData(operateAgent.OperateData.GetIncId());
		if (honamiStoryEquipItemData == null)
		{
			return;
		}
		this.TipsAttrChange.SetUiActive(true);
		if (Info.Instance.IsInGamepad())
		{
			this.TipsAttrChange.Refresh(honamiStoryEquipItemData, newData, delegate
			{
				this.TipsAttrChange.GetRootItem().SetUIParent(this.DragController.GetDragTipsRoot(), false);
				this.TipsAttrChange.AddHotKey(this.TipsItemHotkey.GetRootItem());
			});
			return;
		}
		this.TipsAttrChange.Refresh(honamiStoryEquipItemData, newData, delegate
		{
			this.TipsAttrChange.GetRootItem().SetUIParent(this.DragController.GetDragTipsRoot(), false);
		});
	}

	// Token: 0x0600F352 RID: 62290 RVA: 0x003AAB36 File Offset: 0x003A8D36
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

	// Token: 0x0600F353 RID: 62291 RVA: 0x003AAB53 File Offset: 0x003A8D53
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
	}

	// Token: 0x0600F354 RID: 62292 RVA: 0x003AAB71 File Offset: 0x003A8D71
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
	}

	// Token: 0x0600F355 RID: 62293 RVA: 0x003AAB90 File Offset: 0x003A8D90
	public void OnEnterGamepadMask()
	{
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence == null)
		{
			return;
		}
		uiViewSequence.PlaySequence("Drag_Hide", false, null);
	}

	// Token: 0x0600F356 RID: 62294 RVA: 0x003AABBC File Offset: 0x003A8DBC
	public void OnExitGamepadMask()
	{
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence == null)
		{
			return;
		}
		uiViewSequence.PlaySequence("Drag_Show", false, null);
	}

	// Token: 0x0600F357 RID: 62295 RVA: 0x003AABE8 File Offset: 0x003A8DE8
	public void OnDragBegin()
	{
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence == null)
		{
			return;
		}
		uiViewSequence.PlaySequence("Drag_Hide", false, null);
	}

	// Token: 0x0600F358 RID: 62296 RVA: 0x003AAC14 File Offset: 0x003A8E14
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

	// Token: 0x0600F359 RID: 62297 RVA: 0x003AAC52 File Offset: 0x003A8E52
	private void OnClickCloseButton()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600F35A RID: 62298 RVA: 0x003AAC5B File Offset: 0x003A8E5B
	[NullableContext(2)]
	private void OnEnterItem(HonamiStoryItemGridItem item, EHonamiStoryBackpackType type)
	{
		this.ShowTipsDetail(item, type);
	}

	// Token: 0x0600F35B RID: 62299 RVA: 0x003AAC65 File Offset: 0x003A8E65
	private void OnExitItem()
	{
		this.HideTipsDetail();
	}

	// Token: 0x0600F35C RID: 62300 RVA: 0x003AAC6D File Offset: 0x003A8E6D
	private void OnCheckAttrItem([Nullable(2)] HonamiStoryEquipGridItem item, HonamiStoryInteractOperateAgent operateAgent)
	{
		this.ShowTipsAttrChange(item, operateAgent);
	}

	// Token: 0x0600F35D RID: 62301 RVA: 0x003AAC77 File Offset: 0x003A8E77
	private void OnClickItem([Nullable(2)] HonamiStoryItemGridItem data, Vector2D loc, Vector2D size, EHonamiStoryBackpackType packType)
	{
		this.HideTipsDetail();
		this.ShowTips(data, loc, size, packType);
	}

	// Token: 0x0600F35E RID: 62302 RVA: 0x003AAC8A File Offset: 0x003A8E8A
	private void OnClickMask()
	{
		Action onTipsClickCb = this.OnTipsClickCb;
		if (onTipsClickCb == null)
		{
			return;
		}
		onTipsClickCb();
	}

	// Token: 0x0600F35F RID: 62303 RVA: 0x003AAC9C File Offset: 0x003A8E9C
	private void OnInputControllerMainTypeChange(EInputControllerMainType last, EInputControllerMainType now)
	{
		if (last == EInputControllerMainType.Gamepad)
		{
			HonamiStoryModel.Instance.GetGamepadLogic().SwitchToKeyboardState();
			return;
		}
		if (now == EInputControllerMainType.Gamepad)
		{
			HonamiStoryModel.Instance.GetGamepadLogic().SwitchToGamepadState(true);
		}
	}

	// Token: 0x0600F360 RID: 62304 RVA: 0x003AACC8 File Offset: 0x003A8EC8
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
		if (a == "RolePanel" || a == "Equips" || a == "AddBtn" || a == "UpdateBtn")
		{
			HonamiStoryEquipBackpackPanel equipPanel = this.EquipPanel;
			if (equipPanel == null)
			{
				return null;
			}
			return equipPanel.GetGuideUiItemAndUiItemForShowEx(configParams);
		}
		else
		{
			if (!(a == "BtnSell") && !(a == "ToggleSelect") && !(a == "BtnReset"))
			{
				return null;
			}
			HonamiStoryBackpackPanel backpackPanel = this.BackpackPanel;
			if (backpackPanel == null)
			{
				return null;
			}
			return backpackPanel.GetGuideUiItemAndUiItemForShowEx(configParams);
		}
	}

	// Token: 0x040070AB RID: 28843
	private HonamiStoryEquipBackpackPanel EquipPanel;

	// Token: 0x040070AC RID: 28844
	private HonamiStoryBackpackPanel BackpackPanel;

	// Token: 0x040070AD RID: 28845
	private HonamiStoryBackpackPanel PickUpPanel;

	// Token: 0x040070AE RID: 28846
	private HonamiStoryDiscardBackpackPanel DiscardPanel;

	// Token: 0x040070AF RID: 28847
	private readonly HonamiStoryInteractController DragController = new HonamiStoryInteractController();

	// Token: 0x040070B0 RID: 28848
	private readonly HonamiStoryBackpackLogicController BackpackLogicController = new HonamiStoryBackpackLogicController();

	// Token: 0x040070B1 RID: 28849
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x040070B2 RID: 28850
	[Nullable(2)]
	private HonamiStoryItemTipsBase TipsItem;

	// Token: 0x040070B3 RID: 28851
	[Nullable(2)]
	private HonamiStoryItemTipsDetail TipsItemDetail;

	// Token: 0x040070B4 RID: 28852
	[Nullable(2)]
	private HonamiStoryItemTipsAttrChange TipsAttrChange;

	// Token: 0x040070B5 RID: 28853
	[Nullable(2)]
	private HonamiStoryItemTipsHotKey TipsItemHotkey;

	// Token: 0x040070B6 RID: 28854
	[Nullable(2)]
	private HonamiStorySkillDescToggle DescToggleItem;

	// Token: 0x040070B7 RID: 28855
	private float BasePanelHeight;

	// Token: 0x040070B8 RID: 28856
	[Nullable(2)]
	private Action OnTipsClickCb;

	// Token: 0x020084CD RID: 33997
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402B37D RID: 177021
		EquipPanel,
		// Token: 0x0402B37E RID: 177022
		BackpackPanel,
		// Token: 0x0402B37F RID: 177023
		PickUpPanel,
		// Token: 0x0402B380 RID: 177024
		AttachPanel,
		// Token: 0x0402B381 RID: 177025
		CaptionItem,
		// Token: 0x0402B382 RID: 177026
		PanelTips,
		// Token: 0x0402B383 RID: 177027
		BtnMask,
		// Token: 0x0402B384 RID: 177028
		DescToggleItem,
		// Token: 0x0402B385 RID: 177029
		DeletePanel
	}
}

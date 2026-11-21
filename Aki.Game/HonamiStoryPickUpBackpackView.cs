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

// Token: 0x020013A3 RID: 5027
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryPickUpBackpackView : UiViewBase
{
	// Token: 0x0600C760 RID: 51040 RVA: 0x003B6013 File Offset: 0x003B4213
	public HonamiStoryPickUpBackpackView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C761 RID: 51041 RVA: 0x003B6034 File Offset: 0x003B4234
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

	// Token: 0x0600C762 RID: 51042 RVA: 0x003B61C4 File Offset: 0x003B43C4
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryPickUpBackpackView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryPickUpBackpackView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C763 RID: 51043 RVA: 0x003B6207 File Offset: 0x003B4407
	protected override void OnStart()
	{
		this.InitTipsItem();
	}

	// Token: 0x0600C764 RID: 51044 RVA: 0x003B6210 File Offset: 0x003B4410
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

	// Token: 0x0600C765 RID: 51045 RVA: 0x003B6262 File Offset: 0x003B4462
	protected override void OnBeforeDestroy()
	{
		HonamiStoryModel.Instance.SetGamepadLogic(null);
		HonamiStoryModel.Instance.SetBackpackLogic(null);
	}

	// Token: 0x0600C766 RID: 51046 RVA: 0x003B627C File Offset: 0x003B447C
	private UniTask InitPlayerBackpackPanel()
	{
		HonamiStoryPickUpBackpackView.<InitPlayerBackpackPanel>d__21 <InitPlayerBackpackPanel>d__;
		<InitPlayerBackpackPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitPlayerBackpackPanel>d__.<>4__this = this;
		<InitPlayerBackpackPanel>d__.<>1__state = -1;
		<InitPlayerBackpackPanel>d__.<>t__builder.Start<HonamiStoryPickUpBackpackView.<InitPlayerBackpackPanel>d__21>(ref <InitPlayerBackpackPanel>d__);
		return <InitPlayerBackpackPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600C767 RID: 51047 RVA: 0x003B62C0 File Offset: 0x003B44C0
	private UniTask InitBackpackPanel()
	{
		HonamiStoryPickUpBackpackView.<InitBackpackPanel>d__22 <InitBackpackPanel>d__;
		<InitBackpackPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitBackpackPanel>d__.<>4__this = this;
		<InitBackpackPanel>d__.<>1__state = -1;
		<InitBackpackPanel>d__.<>t__builder.Start<HonamiStoryPickUpBackpackView.<InitBackpackPanel>d__22>(ref <InitBackpackPanel>d__);
		return <InitBackpackPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600C768 RID: 51048 RVA: 0x003B6304 File Offset: 0x003B4504
	private UniTask InitDiscardBackpackPanel()
	{
		HonamiStoryPickUpBackpackView.<InitDiscardBackpackPanel>d__23 <InitDiscardBackpackPanel>d__;
		<InitDiscardBackpackPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitDiscardBackpackPanel>d__.<>4__this = this;
		<InitDiscardBackpackPanel>d__.<>1__state = -1;
		<InitDiscardBackpackPanel>d__.<>t__builder.Start<HonamiStoryPickUpBackpackView.<InitDiscardBackpackPanel>d__23>(ref <InitDiscardBackpackPanel>d__);
		return <InitDiscardBackpackPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600C769 RID: 51049 RVA: 0x003B6348 File Offset: 0x003B4548
	private UniTask InitTipsItem()
	{
		HonamiStoryPickUpBackpackView.<InitTipsItem>d__24 <InitTipsItem>d__;
		<InitTipsItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitTipsItem>d__.<>4__this = this;
		<InitTipsItem>d__.<>1__state = -1;
		<InitTipsItem>d__.<>t__builder.Start<HonamiStoryPickUpBackpackView.<InitTipsItem>d__24>(ref <InitTipsItem>d__);
		return <InitTipsItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600C76A RID: 51050 RVA: 0x003B638C File Offset: 0x003B458C
	private UniTask InitPickUpPanel()
	{
		HonamiStoryPickUpBackpackView.<InitPickUpPanel>d__25 <InitPickUpPanel>d__;
		<InitPickUpPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitPickUpPanel>d__.<>4__this = this;
		<InitPickUpPanel>d__.<>1__state = -1;
		<InitPickUpPanel>d__.<>t__builder.Start<HonamiStoryPickUpBackpackView.<InitPickUpPanel>d__25>(ref <InitPickUpPanel>d__);
		return <InitPickUpPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600C76B RID: 51051 RVA: 0x003B63D0 File Offset: 0x003B45D0
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

	// Token: 0x0600C76C RID: 51052 RVA: 0x003B6430 File Offset: 0x003B4630
	public void ShowTipsHotKeyOnly(HonamiStoryGridItemBase item)
	{
		if (HonamiStoryModel.Instance.GetGamepadLogic() != null)
		{
			this.TipsItemHotkey.GetRootItem().SetUIParent(base.GetItem(5), false);
			this.TipsItemHotkey.SetAutoLocation(item.GetRootItem());
			this.TipsItemHotkey.SetUiActive(true);
		}
	}

	// Token: 0x0600C76D RID: 51053 RVA: 0x003B647E File Offset: 0x003B467E
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

	// Token: 0x0600C76E RID: 51054 RVA: 0x003B64B8 File Offset: 0x003B46B8
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

	// Token: 0x0600C76F RID: 51055 RVA: 0x003B6558 File Offset: 0x003B4758
	private void HideTipsDetail()
	{
		this.TipsItemDetail.SetUiActive(false);
	}

	// Token: 0x0600C770 RID: 51056 RVA: 0x003B6568 File Offset: 0x003B4768
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

	// Token: 0x0600C771 RID: 51057 RVA: 0x003B6632 File Offset: 0x003B4832
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

	// Token: 0x0600C772 RID: 51058 RVA: 0x003B664F File Offset: 0x003B484F
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
	}

	// Token: 0x0600C773 RID: 51059 RVA: 0x003B666D File Offset: 0x003B486D
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
	}

	// Token: 0x0600C774 RID: 51060 RVA: 0x003B668C File Offset: 0x003B488C
	public void OnEnterGamepadMask()
	{
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence == null)
		{
			return;
		}
		uiViewSequence.PlaySequence("Drag_Hide", false, null);
	}

	// Token: 0x0600C775 RID: 51061 RVA: 0x003B66B8 File Offset: 0x003B48B8
	public void OnExitGamepadMask()
	{
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence == null)
		{
			return;
		}
		uiViewSequence.PlaySequence("Drag_Show", false, null);
	}

	// Token: 0x0600C776 RID: 51062 RVA: 0x003B66E4 File Offset: 0x003B48E4
	public void OnDragBegin()
	{
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence == null)
		{
			return;
		}
		uiViewSequence.PlaySequence("Drag_Hide", false, null);
	}

	// Token: 0x0600C777 RID: 51063 RVA: 0x003B6710 File Offset: 0x003B4910
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

	// Token: 0x0600C778 RID: 51064 RVA: 0x003B674E File Offset: 0x003B494E
	private void OnClickCloseButton()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600C779 RID: 51065 RVA: 0x003B6757 File Offset: 0x003B4957
	[NullableContext(2)]
	private void OnEnterItem(HonamiStoryItemGridItem item, EHonamiStoryBackpackType type)
	{
		this.ShowTipsDetail(item, type);
	}

	// Token: 0x0600C77A RID: 51066 RVA: 0x003B6761 File Offset: 0x003B4961
	private void OnExitItem()
	{
		this.HideTipsDetail();
	}

	// Token: 0x0600C77B RID: 51067 RVA: 0x003B6769 File Offset: 0x003B4969
	private void OnCheckAttrItem([Nullable(2)] HonamiStoryEquipGridItem item, HonamiStoryInteractOperateAgent operateAgent)
	{
		this.ShowTipsAttrChange(item, operateAgent);
	}

	// Token: 0x0600C77C RID: 51068 RVA: 0x003B6773 File Offset: 0x003B4973
	private void OnClickItem([Nullable(2)] HonamiStoryItemGridItem data, Vector2D loc, Vector2D size, EHonamiStoryBackpackType packType)
	{
		this.HideTipsDetail();
		this.ShowTips(data, loc, size, packType);
	}

	// Token: 0x0600C77D RID: 51069 RVA: 0x003B6786 File Offset: 0x003B4986
	private void OnClickMask()
	{
		Action onTipsClickCb = this.OnTipsClickCb;
		if (onTipsClickCb == null)
		{
			return;
		}
		onTipsClickCb();
	}

	// Token: 0x0600C77E RID: 51070 RVA: 0x003B6798 File Offset: 0x003B4998
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

	// Token: 0x0600C77F RID: 51071 RVA: 0x003B67C4 File Offset: 0x003B49C4
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

	// Token: 0x0400718C RID: 29068
	private HonamiStoryEquipBackpackPanel EquipPanel;

	// Token: 0x0400718D RID: 29069
	private HonamiStoryBackpackPanel BackpackPanel;

	// Token: 0x0400718E RID: 29070
	private HonamiStoryBackpackPanel PickUpPanel;

	// Token: 0x0400718F RID: 29071
	private HonamiStoryDiscardBackpackPanel DiscardPanel;

	// Token: 0x04007190 RID: 29072
	private readonly HonamiStoryInteractController DragController = new HonamiStoryInteractController();

	// Token: 0x04007191 RID: 29073
	private readonly HonamiStoryBackpackLogicController BackpackLogicController = new HonamiStoryBackpackLogicController();

	// Token: 0x04007192 RID: 29074
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04007193 RID: 29075
	[Nullable(2)]
	private HonamiStoryItemTipsBase TipsItem;

	// Token: 0x04007194 RID: 29076
	[Nullable(2)]
	private HonamiStoryItemTipsDetail TipsItemDetail;

	// Token: 0x04007195 RID: 29077
	[Nullable(2)]
	private HonamiStoryItemTipsAttrChange TipsAttrChange;

	// Token: 0x04007196 RID: 29078
	[Nullable(2)]
	private HonamiStoryItemTipsHotKey TipsItemHotkey;

	// Token: 0x04007197 RID: 29079
	[Nullable(2)]
	private HonamiStorySkillDescToggle DescToggleItem;

	// Token: 0x04007198 RID: 29080
	private float BasePanelHeight;

	// Token: 0x04007199 RID: 29081
	[Nullable(2)]
	private Action OnTipsClickCb;

	// Token: 0x02007652 RID: 30290
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040266A1 RID: 157345
		EquipPanel,
		// Token: 0x040266A2 RID: 157346
		BackpackPanel,
		// Token: 0x040266A3 RID: 157347
		PickUpPanel,
		// Token: 0x040266A4 RID: 157348
		AttachPanel,
		// Token: 0x040266A5 RID: 157349
		CaptionItem,
		// Token: 0x040266A6 RID: 157350
		PanelTips,
		// Token: 0x040266A7 RID: 157351
		BtnMask,
		// Token: 0x040266A8 RID: 157352
		DescToggleItem,
		// Token: 0x040266A9 RID: 157353
		DeletePanel
	}
}

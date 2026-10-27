using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001EE2 RID: 7906
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryPickUpMobileView : UiViewBase
{
	// Token: 0x0600F365 RID: 62309 RVA: 0x003AADCF File Offset: 0x003A8FCF
	public HonamiStoryPickUpMobileView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600F366 RID: 62310 RVA: 0x003AADF0 File Offset: 0x003A8FF0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 12;
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
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 3;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickMask));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action<EToggleState>(this.OnClickPlayerToggle));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(7, new Action<EToggleState>(this.OnClickBackpackToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600F367 RID: 62311 RVA: 0x003AB02C File Offset: 0x003A922C
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryPickUpMobileView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryPickUpMobileView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F368 RID: 62312 RVA: 0x003AB06F File Offset: 0x003A926F
	protected override void OnStart()
	{
		base.GetItem(8).SetUIActive(false);
		base.GetItem(9).SetUIActive(false);
		this.InitTipsItem();
	}

	// Token: 0x0600F369 RID: 62313 RVA: 0x003AB094 File Offset: 0x003A9294
	private UniTask InitPickUpPanel()
	{
		HonamiStoryPickUpMobileView.<InitPickUpPanel>d__16 <InitPickUpPanel>d__;
		<InitPickUpPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitPickUpPanel>d__.<>4__this = this;
		<InitPickUpPanel>d__.<>1__state = -1;
		<InitPickUpPanel>d__.<>t__builder.Start<HonamiStoryPickUpMobileView.<InitPickUpPanel>d__16>(ref <InitPickUpPanel>d__);
		return <InitPickUpPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600F36A RID: 62314 RVA: 0x003AB0D8 File Offset: 0x003A92D8
	private UniTask InitEquipBackpackPanel()
	{
		HonamiStoryPickUpMobileView.<InitEquipBackpackPanel>d__17 <InitEquipBackpackPanel>d__;
		<InitEquipBackpackPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitEquipBackpackPanel>d__.<>4__this = this;
		<InitEquipBackpackPanel>d__.<>1__state = -1;
		<InitEquipBackpackPanel>d__.<>t__builder.Start<HonamiStoryPickUpMobileView.<InitEquipBackpackPanel>d__17>(ref <InitEquipBackpackPanel>d__);
		return <InitEquipBackpackPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600F36B RID: 62315 RVA: 0x003AB11C File Offset: 0x003A931C
	private UniTask InitDiscardBackpackPanel()
	{
		HonamiStoryPickUpMobileView.<InitDiscardBackpackPanel>d__18 <InitDiscardBackpackPanel>d__;
		<InitDiscardBackpackPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitDiscardBackpackPanel>d__.<>4__this = this;
		<InitDiscardBackpackPanel>d__.<>1__state = -1;
		<InitDiscardBackpackPanel>d__.<>t__builder.Start<HonamiStoryPickUpMobileView.<InitDiscardBackpackPanel>d__18>(ref <InitDiscardBackpackPanel>d__);
		return <InitDiscardBackpackPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600F36C RID: 62316 RVA: 0x003AB160 File Offset: 0x003A9360
	private UniTask InitTipsItem()
	{
		HonamiStoryPickUpMobileView.<InitTipsItem>d__19 <InitTipsItem>d__;
		<InitTipsItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitTipsItem>d__.<>4__this = this;
		<InitTipsItem>d__.<>1__state = -1;
		<InitTipsItem>d__.<>t__builder.Start<HonamiStoryPickUpMobileView.<InitTipsItem>d__19>(ref <InitTipsItem>d__);
		return <InitTipsItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600F36D RID: 62317 RVA: 0x003AB1A4 File Offset: 0x003A93A4
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

	// Token: 0x0600F36E RID: 62318 RVA: 0x003AB204 File Offset: 0x003A9404
	protected void ShowTipsAttrChange([Nullable(2)] HonamiStoryEquipGridItem item, HonamiStoryInteractOperateAgent operateAgent)
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
		this.TipsAttrChange.Refresh(honamiStoryEquipItemData, newData, delegate
		{
			this.TipsAttrChange.GetRootItem().SetUIParent(this.DragController.GetDragTipsRoot(), false);
		});
	}

	// Token: 0x0600F36F RID: 62319 RVA: 0x003AB2A8 File Offset: 0x003A94A8
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

	// Token: 0x0600F370 RID: 62320 RVA: 0x003AB2C5 File Offset: 0x003A94C5
	private void HideTipsDetail()
	{
		this.TipsItemDetail.SetUiActive(false);
	}

	// Token: 0x0600F371 RID: 62321 RVA: 0x003AB2D4 File Offset: 0x003A94D4
	[NullableContext(2)]
	private void ShowTipsDetail(HonamiStoryItemGridItem item, EHonamiStoryBackpackType type)
	{
		bool flag = HonamiStoryModel.Instance.GetBackpackLogicState() == EHonamiStoryBackpackLogicState.Sell;
		HonamiStoryItemTipsBase tipsItem = this.TipsItem;
		bool flag2 = tipsItem != null && tipsItem.GetActive();
		bool flag3 = HonamiStoryUtil.IsMobileView();
		if (item == null || item.GetData() == null || flag || flag2 || flag3)
		{
			return;
		}
		HonamiStoryItemDataBase data = item.GetData();
		this.TipsItemDetail.Refresh(data, type);
		this.TipsItemDetail.SetAutoLocation(item.GetRootItem());
		this.TipsItemDetail.SetUiActive(true);
	}

	// Token: 0x0600F372 RID: 62322 RVA: 0x003AB351 File Offset: 0x003A9551
	private void OnClickMask()
	{
		if (this.OnTipsClickCb != null)
		{
			this.OnTipsClickCb();
		}
	}

	// Token: 0x0600F373 RID: 62323 RVA: 0x003AB366 File Offset: 0x003A9566
	private void OnClickCloseButton()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600F374 RID: 62324 RVA: 0x003AB36F File Offset: 0x003A956F
	private void OnClickPlayerToggle(EToggleState toggleState)
	{
		this.EquipBackpackPanel.OnClickedEquipToggle();
	}

	// Token: 0x0600F375 RID: 62325 RVA: 0x003AB37C File Offset: 0x003A957C
	private void OnClickBackpackToggle(EToggleState toggleState)
	{
		this.EquipBackpackPanel.OnClickedBackpackToggle();
	}

	// Token: 0x0600F376 RID: 62326 RVA: 0x003AB389 File Offset: 0x003A9589
	[NullableContext(2)]
	private void OnEnterItem(HonamiStoryItemGridItem item, EHonamiStoryBackpackType type)
	{
		this.ShowTipsDetail(item, type);
	}

	// Token: 0x0600F377 RID: 62327 RVA: 0x003AB393 File Offset: 0x003A9593
	private void OnExitItem()
	{
		this.HideTipsDetail();
	}

	// Token: 0x0600F378 RID: 62328 RVA: 0x003AB39B File Offset: 0x003A959B
	private void OnClickItem([Nullable(2)] HonamiStoryItemGridItem data, Vector2D loc, Vector2D size, EHonamiStoryBackpackType packType)
	{
		this.HideTipsDetail();
		this.ShowTips(data, loc, size, packType);
	}

	// Token: 0x040070B9 RID: 28857
	private HonamiStoryMobileEquipPanel EquipBackpackPanel;

	// Token: 0x040070BA RID: 28858
	private HonamiStoryBackpackPanel PickUpPanel;

	// Token: 0x040070BB RID: 28859
	private HonamiStoryDiscardBackpackPanel DiscardPanel;

	// Token: 0x040070BC RID: 28860
	private readonly HonamiStoryInteractController DragController = new HonamiStoryInteractController();

	// Token: 0x040070BD RID: 28861
	private readonly HonamiStoryBackpackLogicController BackpackLogicController = new HonamiStoryBackpackLogicController();

	// Token: 0x040070BE RID: 28862
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x040070BF RID: 28863
	[Nullable(2)]
	private HonamiStoryItemTipsBase TipsItem;

	// Token: 0x040070C0 RID: 28864
	[Nullable(2)]
	private HonamiStoryItemTipsDetail TipsItemDetail;

	// Token: 0x040070C1 RID: 28865
	[Nullable(2)]
	private HonamiStoryItemTipsAttrChange TipsAttrChange;

	// Token: 0x040070C2 RID: 28866
	[Nullable(2)]
	private HonamiStorySkillDescToggle DescToggleItem;

	// Token: 0x040070C3 RID: 28867
	[Nullable(2)]
	private Action OnTipsClickCb;

	// Token: 0x020084D5 RID: 34005
	[NullableContext(0)]
	private enum EDefine
	{
		// Token: 0x0402B3A4 RID: 177060
		PanelLeft,
		// Token: 0x0402B3A5 RID: 177061
		PanelPickupBox,
		// Token: 0x0402B3A6 RID: 177062
		AttachPanel,
		// Token: 0x0402B3A7 RID: 177063
		CaptionItem,
		// Token: 0x0402B3A8 RID: 177064
		PanelTips,
		// Token: 0x0402B3A9 RID: 177065
		BtnMask,
		// Token: 0x0402B3AA RID: 177066
		TogTabA,
		// Token: 0x0402B3AB RID: 177067
		TogTabB,
		// Token: 0x0402B3AC RID: 177068
		MoveUp,
		// Token: 0x0402B3AD RID: 177069
		MoveDown,
		// Token: 0x0402B3AE RID: 177070
		DescToggleItem,
		// Token: 0x0402B3AF RID: 177071
		DeletePanel
	}
}

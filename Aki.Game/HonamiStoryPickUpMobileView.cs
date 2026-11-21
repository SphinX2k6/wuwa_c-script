using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020013A4 RID: 5028
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryPickUpMobileView : UiViewBase
{
	// Token: 0x0600C784 RID: 51076 RVA: 0x003B68CB File Offset: 0x003B4ACB
	public HonamiStoryPickUpMobileView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C785 RID: 51077 RVA: 0x003B68EC File Offset: 0x003B4AEC
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

	// Token: 0x0600C786 RID: 51078 RVA: 0x003B6B28 File Offset: 0x003B4D28
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryPickUpMobileView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryPickUpMobileView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C787 RID: 51079 RVA: 0x003B6B6B File Offset: 0x003B4D6B
	protected override void OnStart()
	{
		base.GetItem(8).SetUIActive(false);
		base.GetItem(9).SetUIActive(false);
		this.InitTipsItem();
	}

	// Token: 0x0600C788 RID: 51080 RVA: 0x003B6B90 File Offset: 0x003B4D90
	private UniTask InitPickUpPanel()
	{
		HonamiStoryPickUpMobileView.<InitPickUpPanel>d__16 <InitPickUpPanel>d__;
		<InitPickUpPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitPickUpPanel>d__.<>4__this = this;
		<InitPickUpPanel>d__.<>1__state = -1;
		<InitPickUpPanel>d__.<>t__builder.Start<HonamiStoryPickUpMobileView.<InitPickUpPanel>d__16>(ref <InitPickUpPanel>d__);
		return <InitPickUpPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600C789 RID: 51081 RVA: 0x003B6BD4 File Offset: 0x003B4DD4
	private UniTask InitEquipBackpackPanel()
	{
		HonamiStoryPickUpMobileView.<InitEquipBackpackPanel>d__17 <InitEquipBackpackPanel>d__;
		<InitEquipBackpackPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitEquipBackpackPanel>d__.<>4__this = this;
		<InitEquipBackpackPanel>d__.<>1__state = -1;
		<InitEquipBackpackPanel>d__.<>t__builder.Start<HonamiStoryPickUpMobileView.<InitEquipBackpackPanel>d__17>(ref <InitEquipBackpackPanel>d__);
		return <InitEquipBackpackPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600C78A RID: 51082 RVA: 0x003B6C18 File Offset: 0x003B4E18
	private UniTask InitDiscardBackpackPanel()
	{
		HonamiStoryPickUpMobileView.<InitDiscardBackpackPanel>d__18 <InitDiscardBackpackPanel>d__;
		<InitDiscardBackpackPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitDiscardBackpackPanel>d__.<>4__this = this;
		<InitDiscardBackpackPanel>d__.<>1__state = -1;
		<InitDiscardBackpackPanel>d__.<>t__builder.Start<HonamiStoryPickUpMobileView.<InitDiscardBackpackPanel>d__18>(ref <InitDiscardBackpackPanel>d__);
		return <InitDiscardBackpackPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600C78B RID: 51083 RVA: 0x003B6C5C File Offset: 0x003B4E5C
	private UniTask InitTipsItem()
	{
		HonamiStoryPickUpMobileView.<InitTipsItem>d__19 <InitTipsItem>d__;
		<InitTipsItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitTipsItem>d__.<>4__this = this;
		<InitTipsItem>d__.<>1__state = -1;
		<InitTipsItem>d__.<>t__builder.Start<HonamiStoryPickUpMobileView.<InitTipsItem>d__19>(ref <InitTipsItem>d__);
		return <InitTipsItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600C78C RID: 51084 RVA: 0x003B6CA0 File Offset: 0x003B4EA0
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

	// Token: 0x0600C78D RID: 51085 RVA: 0x003B6D00 File Offset: 0x003B4F00
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

	// Token: 0x0600C78E RID: 51086 RVA: 0x003B6DA4 File Offset: 0x003B4FA4
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

	// Token: 0x0600C78F RID: 51087 RVA: 0x003B6DC1 File Offset: 0x003B4FC1
	private void HideTipsDetail()
	{
		this.TipsItemDetail.SetUiActive(false);
	}

	// Token: 0x0600C790 RID: 51088 RVA: 0x003B6DD0 File Offset: 0x003B4FD0
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

	// Token: 0x0600C791 RID: 51089 RVA: 0x003B6E4D File Offset: 0x003B504D
	private void OnClickMask()
	{
		if (this.OnTipsClickCb != null)
		{
			this.OnTipsClickCb();
		}
	}

	// Token: 0x0600C792 RID: 51090 RVA: 0x003B6E62 File Offset: 0x003B5062
	private void OnClickCloseButton()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600C793 RID: 51091 RVA: 0x003B6E6B File Offset: 0x003B506B
	private void OnClickPlayerToggle(EToggleState toggleState)
	{
		this.EquipBackpackPanel.OnClickedEquipToggle();
	}

	// Token: 0x0600C794 RID: 51092 RVA: 0x003B6E78 File Offset: 0x003B5078
	private void OnClickBackpackToggle(EToggleState toggleState)
	{
		this.EquipBackpackPanel.OnClickedBackpackToggle();
	}

	// Token: 0x0600C795 RID: 51093 RVA: 0x003B6E85 File Offset: 0x003B5085
	[NullableContext(2)]
	private void OnEnterItem(HonamiStoryItemGridItem item, EHonamiStoryBackpackType type)
	{
		this.ShowTipsDetail(item, type);
	}

	// Token: 0x0600C796 RID: 51094 RVA: 0x003B6E8F File Offset: 0x003B508F
	private void OnExitItem()
	{
		this.HideTipsDetail();
	}

	// Token: 0x0600C797 RID: 51095 RVA: 0x003B6E97 File Offset: 0x003B5097
	private void OnClickItem([Nullable(2)] HonamiStoryItemGridItem data, Vector2D loc, Vector2D size, EHonamiStoryBackpackType packType)
	{
		this.HideTipsDetail();
		this.ShowTips(data, loc, size, packType);
	}

	// Token: 0x0400719A RID: 29082
	private HonamiStoryMobileEquipPanel EquipBackpackPanel;

	// Token: 0x0400719B RID: 29083
	private HonamiStoryBackpackPanel PickUpPanel;

	// Token: 0x0400719C RID: 29084
	private HonamiStoryDiscardBackpackPanel DiscardPanel;

	// Token: 0x0400719D RID: 29085
	private readonly HonamiStoryInteractController DragController = new HonamiStoryInteractController();

	// Token: 0x0400719E RID: 29086
	private readonly HonamiStoryBackpackLogicController BackpackLogicController = new HonamiStoryBackpackLogicController();

	// Token: 0x0400719F RID: 29087
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x040071A0 RID: 29088
	[Nullable(2)]
	private HonamiStoryItemTipsBase TipsItem;

	// Token: 0x040071A1 RID: 29089
	[Nullable(2)]
	private HonamiStoryItemTipsDetail TipsItemDetail;

	// Token: 0x040071A2 RID: 29090
	[Nullable(2)]
	private HonamiStoryItemTipsAttrChange TipsAttrChange;

	// Token: 0x040071A3 RID: 29091
	[Nullable(2)]
	private HonamiStorySkillDescToggle DescToggleItem;

	// Token: 0x040071A4 RID: 29092
	[Nullable(2)]
	private Action OnTipsClickCb;

	// Token: 0x0200765A RID: 30298
	[NullableContext(0)]
	private enum EDefine
	{
		// Token: 0x040266C8 RID: 157384
		PanelLeft,
		// Token: 0x040266C9 RID: 157385
		PanelPickupBox,
		// Token: 0x040266CA RID: 157386
		AttachPanel,
		// Token: 0x040266CB RID: 157387
		CaptionItem,
		// Token: 0x040266CC RID: 157388
		PanelTips,
		// Token: 0x040266CD RID: 157389
		BtnMask,
		// Token: 0x040266CE RID: 157390
		TogTabA,
		// Token: 0x040266CF RID: 157391
		TogTabB,
		// Token: 0x040266D0 RID: 157392
		MoveUp,
		// Token: 0x040266D1 RID: 157393
		MoveDown,
		// Token: 0x040266D2 RID: 157394
		DescToggleItem,
		// Token: 0x040266D3 RID: 157395
		DeletePanel
	}
}

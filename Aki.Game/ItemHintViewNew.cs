using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020014D7 RID: 5335
[NullableContext(1)]
[Nullable(0)]
public class ItemHintViewNew : UiTickViewBase
{
	// Token: 0x0600D596 RID: 54678 RVA: 0x003F6D33 File Offset: 0x003F4F33
	public ItemHintViewNew(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600D597 RID: 54679 RVA: 0x003F6D3C File Offset: 0x003F4F3C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText))
		};
	}

	// Token: 0x0600D598 RID: 54680 RVA: 0x003F6DAC File Offset: 0x003F4FAC
	protected override void OnBeforeCreate()
	{
		base.OnBeforeCreate();
		this.Data = (this.OpenParam as ItemHintViewNewData);
	}

	// Token: 0x0600D599 RID: 54681 RVA: 0x003F6DC5 File Offset: 0x003F4FC5
	protected override void OnBeforeDestroy()
	{
		if (this.ListSlideControl != null)
		{
			this.ListSlideControl.DestroyMe();
			this.ListSlideControl = null;
		}
		if (this.ListPriorSlideControl != null)
		{
			this.ListPriorSlideControl.DestroyMe();
			this.ListPriorSlideControl = null;
		}
	}

	// Token: 0x0600D59A RID: 54682 RVA: 0x003F6DFC File Offset: 0x003F4FFC
	protected override void OnStart()
	{
		if (!this.CheckNext() && !this.CheckPriorNext())
		{
			Log.Instance.Warn(ELogModule.ItemHint, ELogAuthor.ZJC, "进包列表为空, 但打开了界面!", default(ReadOnlySpan<ValueTuple<string, object>>));
			base.CloseMe(null);
			return;
		}
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			ItemHintViewNewData data = this.Data;
			item.SetUIActive(((data != null) ? data.TitleTextId : null) != null);
		}
		if (item != null && item.IsUIActiveSelf())
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), this.Data.TitleTextId, Array.Empty<object>());
		}
		UUIItem item2 = base.GetItem(1);
		UUIItem item3 = base.GetItem(0);
		item2.SetUIActive(false);
		item3.SetUIActive(false);
		if (this.CheckNext())
		{
			ListSliderControlData<ItemHintItem> listSliderControlData = new ListSliderControlData<ItemHintItem>(item2.GetParentAsUIItem(), new Func<ItemHintItem>(this.CreateItemProxy), new Func<bool>(this.CheckNext));
			ListSliderControlData<ItemHintItem> listSliderControlData2 = listSliderControlData;
			ItemHintViewNewData data2 = this.Data;
			listSliderControlData2.MaxShowCount = ((data2 != null) ? data2.MaxShowCount : null);
			ListSliderControlData<ItemHintItem> listSliderControlData3 = listSliderControlData;
			ItemHintViewNewData data3 = this.Data;
			int? num = (data3 != null) ? data3.AddItemTime : null;
			listSliderControlData3.AddItemTime = ((num != null) ? new float?((float)num.GetValueOrDefault()) : null);
			ListSliderControlData<ItemHintItem> listSliderControlData4 = listSliderControlData;
			ItemHintViewNewData data4 = this.Data;
			num = ((data4 != null) ? data4.ItemSliderTime : null);
			listSliderControlData4.ItemSliderTime = ((num != null) ? new float?((float)num.GetValueOrDefault()) : null);
			ListSliderControlData<ItemHintItem> listSliderControlData5 = listSliderControlData;
			ItemHintViewNewData data5 = this.Data;
			num = ((data5 != null) ? data5.ItemShowTime : null);
			listSliderControlData5.ItemShowTime = ((num != null) ? new float?((float)num.GetValueOrDefault()) : null);
			listSliderControlData.FinishCallback = new Action(this.FinishCallback);
			listSliderControlData.SliderMode = new ESliderMode?(ESliderMode.SliderWhenPlayEnd);
			ListSliderControlData<ItemHintItem> listSliderControlData6 = listSliderControlData;
			ItemHintViewNewData data6 = this.Data;
			listSliderControlData6.ChildResourceId = (((data6 != null) ? data6.SlotResourceId : null) ?? "UiItem_ItemListB");
			this.ListSlideControl = new ListSliderControl<ItemHintItem>(listSliderControlData);
			this.ListSlideControl.DisEnableParentLayout();
		}
		if (this.CheckPriorNext())
		{
			ListSliderControlData<ItemPriorHintItem> listSliderControlData7 = new ListSliderControlData<ItemPriorHintItem>(item3.GetParentAsUIItem(), new Func<ItemPriorHintItem>(this.CreatePriorItemProxy), new Func<bool>(this.CheckPriorNext));
			ListSliderControlData<ItemPriorHintItem> listSliderControlData8 = listSliderControlData7;
			ItemHintViewNewData data7 = this.Data;
			listSliderControlData8.MaxShowCount = ((data7 != null) ? data7.PriorMaxShowCount : null);
			ListSliderControlData<ItemPriorHintItem> listSliderControlData9 = listSliderControlData7;
			ItemHintViewNewData data8 = this.Data;
			int? num = (data8 != null) ? data8.AddPriorItemTime : null;
			listSliderControlData9.AddItemTime = ((num != null) ? new float?((float)num.GetValueOrDefault()) : null);
			ListSliderControlData<ItemPriorHintItem> listSliderControlData10 = listSliderControlData7;
			ItemHintViewNewData data9 = this.Data;
			num = ((data9 != null) ? data9.PriorItemSliderTime : null);
			listSliderControlData10.ItemSliderTime = ((num != null) ? new float?((float)num.GetValueOrDefault()) : null);
			ListSliderControlData<ItemPriorHintItem> listSliderControlData11 = listSliderControlData7;
			ItemHintViewNewData data10 = this.Data;
			num = ((data10 != null) ? data10.PriorItemShowTime : null);
			listSliderControlData11.ItemShowTime = ((num != null) ? new float?((float)num.GetValueOrDefault()) : null);
			listSliderControlData7.FinishCallback = new Action(this.FinishCallback);
			listSliderControlData7.SliderMode = new ESliderMode?(ESliderMode.SliderWhenPlayEnd);
			ListSliderControlData<ItemPriorHintItem> listSliderControlData12 = listSliderControlData7;
			ItemHintViewNewData data11 = this.Data;
			listSliderControlData12.ChildResourceId = (((data11 != null) ? data11.PriorSlotResourceId : null) ?? "UiItem_ItemListA");
			this.ListPriorSlideControl = new ListSliderControl<ItemPriorHintItem>(listSliderControlData7);
			this.ListPriorSlideControl.DisEnableParentLayout();
		}
	}

	// Token: 0x0600D59B RID: 54683 RVA: 0x003F71A4 File Offset: 0x003F53A4
	protected override void OnTick(float delta)
	{
		if (this.ListPriorSlideControl != null)
		{
			this.ListPriorSlideControl.Tick(delta);
		}
		if (this.ListSlideControl != null)
		{
			this.ListSlideControl.Tick(delta);
		}
	}

	// Token: 0x0600D59C RID: 54684 RVA: 0x003F71CE File Offset: 0x003F53CE
	private ItemHintItem CreateItemProxy()
	{
		ItemHintItem itemHintItem = new ItemHintItem();
		itemHintItem.SetShiftData(new Func<ItemRewardInfo>(this.ShiftItem));
		return itemHintItem;
	}

	// Token: 0x0600D59D RID: 54685 RVA: 0x003F71E7 File Offset: 0x003F53E7
	private ItemPriorHintItem CreatePriorItemProxy()
	{
		ItemPriorHintItem itemPriorHintItem = new ItemPriorHintItem();
		itemPriorHintItem.SetShiftData(new Func<ItemRewardInfo>(this.ShiftPriorItem));
		return itemPriorHintItem;
	}

	// Token: 0x0600D59E RID: 54686 RVA: 0x003F7200 File Offset: 0x003F5400
	private void FinishCallback()
	{
		if (this.ListPriorSlideControl != null)
		{
			ListSliderControl<ItemPriorHintItem> listPriorSlideControl = this.ListPriorSlideControl;
			if (listPriorSlideControl == null || !listPriorSlideControl.IsFinish)
			{
				return;
			}
		}
		if (this.ListSlideControl != null)
		{
			ListSliderControl<ItemHintItem> listSlideControl = this.ListSlideControl;
			if (listSlideControl == null || !listSlideControl.IsFinish)
			{
				return;
			}
		}
		base.CloseMe(null);
	}

	// Token: 0x0600D59F RID: 54687 RVA: 0x003F724C File Offset: 0x003F544C
	private bool CheckNext()
	{
		ItemHintViewNewData data = this.Data;
		bool? flag;
		if (data == null)
		{
			flag = null;
		}
		else
		{
			Func<bool> checkNext = data.CheckNext;
			flag = ((checkNext != null) ? new bool?(checkNext()) : null);
		}
		bool? flag2 = flag;
		return flag2.GetValueOrDefault();
	}

	// Token: 0x0600D5A0 RID: 54688 RVA: 0x003F7294 File Offset: 0x003F5494
	[NullableContext(2)]
	private ItemRewardInfo ShiftItem()
	{
		ItemHintViewNewData data = this.Data;
		if (data == null)
		{
			return null;
		}
		Func<ItemRewardInfo> shiftItem = data.ShiftItem;
		if (shiftItem == null)
		{
			return null;
		}
		return shiftItem();
	}

	// Token: 0x0600D5A1 RID: 54689 RVA: 0x003F72B4 File Offset: 0x003F54B4
	private bool CheckPriorNext()
	{
		ItemHintViewNewData data = this.Data;
		bool? flag;
		if (data == null)
		{
			flag = null;
		}
		else
		{
			Func<bool> checkPriorNext = data.CheckPriorNext;
			flag = ((checkPriorNext != null) ? new bool?(checkPriorNext()) : null);
		}
		bool? flag2 = flag;
		return flag2.GetValueOrDefault();
	}

	// Token: 0x0600D5A2 RID: 54690 RVA: 0x003F72FC File Offset: 0x003F54FC
	[NullableContext(2)]
	private ItemRewardInfo ShiftPriorItem()
	{
		ItemHintViewNewData data = this.Data;
		if (data == null)
		{
			return null;
		}
		Func<ItemRewardInfo> shiftPriorItem = data.ShiftPriorItem;
		if (shiftPriorItem == null)
		{
			return null;
		}
		return shiftPriorItem();
	}

	// Token: 0x040077CD RID: 30669
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ListSliderControl<ItemHintItem> ListSlideControl;

	// Token: 0x040077CE RID: 30670
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ListSliderControl<ItemPriorHintItem> ListPriorSlideControl;

	// Token: 0x040077CF RID: 30671
	[Nullable(2)]
	private ItemHintViewNewData Data;

	// Token: 0x02007792 RID: 30610
	[NullableContext(0)]
	private enum EItemHintViewCom
	{
		// Token: 0x04026D0F RID: 158991
		ItemPriorHintItem,
		// Token: 0x04026D10 RID: 158992
		ItemHintItem,
		// Token: 0x04026D11 RID: 158993
		TitleRoot,
		// Token: 0x04026D12 RID: 158994
		TextTitle
	}
}

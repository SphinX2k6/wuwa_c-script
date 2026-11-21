using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020014D4 RID: 5332
public class ItemHintPanel<T, [Nullable(2)] TData> : UiPanelBase where T : ItemHintItemBase<TData>
{
	// Token: 0x0600D580 RID: 54656 RVA: 0x003F66DC File Offset: 0x003F48DC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x0600D581 RID: 54657 RVA: 0x003F6736 File Offset: 0x003F4936
	[NullableContext(1)]
	public ItemHintPanel(IItemHintPanelData<T, TData> data)
	{
		this.Data = data;
	}

	// Token: 0x0600D582 RID: 54658 RVA: 0x003F6745 File Offset: 0x003F4945
	protected override void OnBeforeDestroy()
	{
		if (this.ListSlideControl != null)
		{
			this.ListSlideControl.DestroyMe();
			this.ListSlideControl = null;
		}
	}

	// Token: 0x0600D583 RID: 54659 RVA: 0x003F6764 File Offset: 0x003F4964
	protected override void OnStart()
	{
		if (!this.CheckNext())
		{
			Log.Instance.Warn(ELogModule.ItemHint, ELogAuthor.ZJC, "进包列表为空, 但打开了界面!", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		UUIItem item = base.GetItem(0);
		if (item != null)
		{
			IItemHintPanelData<T, TData> data = this.Data;
			item.SetUIActive(((data != null) ? data.TitleTextId : null) != null);
		}
		if (item != null && item.IsUIActiveSelf())
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), this.Data.TitleTextId, Array.Empty<object>());
		}
		ListSliderControlData<T> listSliderControlData = new ListSliderControlData<T>(base.GetItem(2), new Func<T>(this.CreateProxyFunction), new Func<bool>(this.CheckNext));
		ListSliderControlData<T> listSliderControlData2 = listSliderControlData;
		IItemHintPanelData<T, TData> data2 = this.Data;
		listSliderControlData2.ChildTemplate = ((data2 != null) ? data2.ChildTemplate : null);
		ListSliderControlData<T> listSliderControlData3 = listSliderControlData;
		IItemHintPanelData<T, TData> data3 = this.Data;
		listSliderControlData3.ChildResourceId = ((data3 != null) ? data3.ChildResourceId : null);
		ListSliderControlData<T> listSliderControlData4 = listSliderControlData;
		IItemHintPanelData<T, TData> data4 = this.Data;
		listSliderControlData4.MaxShowCount = ((data4 != null) ? data4.MaxShowCount : null);
		ListSliderControlData<T> listSliderControlData5 = listSliderControlData;
		IItemHintPanelData<T, TData> data5 = this.Data;
		int? num = (data5 != null) ? data5.AddItemTime : null;
		listSliderControlData5.AddItemTime = ((num != null) ? new float?((float)num.GetValueOrDefault()) : null);
		ListSliderControlData<T> listSliderControlData6 = listSliderControlData;
		IItemHintPanelData<T, TData> data6 = this.Data;
		num = ((data6 != null) ? data6.ItemSliderTime : null);
		listSliderControlData6.ItemSliderTime = ((num != null) ? new float?((float)num.GetValueOrDefault()) : null);
		ListSliderControlData<T> listSliderControlData7 = listSliderControlData;
		IItemHintPanelData<T, TData> data7 = this.Data;
		num = ((data7 != null) ? data7.ItemShowTime : null);
		listSliderControlData7.ItemShowTime = ((num != null) ? new float?((float)num.GetValueOrDefault()) : null);
		ListSliderControlData<T> listSliderControlData8 = listSliderControlData;
		IItemHintPanelData<T, TData> data8 = this.Data;
		listSliderControlData8.SliderMode = ((data8 != null) ? data8.SliderMode : null);
		ListSliderControlData<T> listSliderControlData9 = listSliderControlData;
		IItemHintPanelData<T, TData> data9 = this.Data;
		listSliderControlData9.TickMode = ((data9 != null) ? data9.TickMode : null);
		ListSliderControlData<T> listSliderControlData10 = listSliderControlData;
		IItemHintPanelData<T, TData> data10 = this.Data;
		listSliderControlData10.FinishCallback = ((data10 != null) ? data10.FinishCallback : null);
		this.ListSlideControl = new ListSliderControl<T>(listSliderControlData);
		this.ListSlideControl.DisEnableParentLayout();
	}

	// Token: 0x0600D584 RID: 54660 RVA: 0x003F699B File Offset: 0x003F4B9B
	public void OnTick(float delta)
	{
		if (this.ListSlideControl != null)
		{
			this.ListSlideControl.Tick(delta);
		}
	}

	// Token: 0x0600D585 RID: 54661 RVA: 0x003F69B1 File Offset: 0x003F4BB1
	[NullableContext(1)]
	private T CreateProxyFunction()
	{
		T t = this.Data.CreateProxyFunction();
		t.SetShiftData(new Func<TData>(this.ShiftItem));
		return t;
	}

	// Token: 0x0600D586 RID: 54662 RVA: 0x003F69DC File Offset: 0x003F4BDC
	private bool CheckNext()
	{
		IItemHintPanelData<T, TData> data = this.Data;
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

	// Token: 0x0600D587 RID: 54663 RVA: 0x003F6A24 File Offset: 0x003F4C24
	[NullableContext(2)]
	private TData ShiftItem()
	{
		if (this.Data == null)
		{
			return default(TData);
		}
		return this.Data.ShiftItem();
	}

	// Token: 0x040077BA RID: 30650
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private readonly IItemHintPanelData<T, TData> Data;

	// Token: 0x040077BB RID: 30651
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ListSliderControl<T> ListSlideControl;

	// Token: 0x02007790 RID: 30608
	private enum EItemHintViewCom
	{
		// Token: 0x04026D08 RID: 158984
		TitleRoot,
		// Token: 0x04026D09 RID: 158985
		TextTitle,
		// Token: 0x04026D0A RID: 158986
		ItemLayout
	}
}

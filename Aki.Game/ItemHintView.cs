using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002002 RID: 8194
[NullableContext(1)]
[Nullable(0)]
public class ItemHintView : UiTickViewBase
{
	// Token: 0x06010120 RID: 65824 RVA: 0x003EA45B File Offset: 0x003E865B
	public ItemHintView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06010121 RID: 65825 RVA: 0x003EA464 File Offset: 0x003E8664
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(0, typeof(UUIItem))
		};
	}

	// Token: 0x06010122 RID: 65826 RVA: 0x003EA49D File Offset: 0x003E869D
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

	// Token: 0x06010123 RID: 65827 RVA: 0x003EA4D4 File Offset: 0x003E86D4
	protected override void OnStart()
	{
		if (!this.CheckNext() && !this.CheckPriorNext())
		{
			Log.Instance.Warn(ELogModule.ItemHint, ELogAuthor.ZJC, "进包列表为空, 但打开了界面!", default(ReadOnlySpan<ValueTuple<string, object>>));
			base.CloseMe(null);
			return;
		}
		UUIItem item = base.GetItem(1);
		UUIItem item2 = base.GetItem(0);
		item.SetUIActive(false);
		item2.SetUIActive(false);
		this.ListSlideControl = new ListSliderControl<ItemHintItem>(new ListSliderControlData<ItemHintItem>(item.GetParentAsUIItem(), new Func<ItemHintItem>(this.CreateItemProxy), new Func<bool>(this.CheckNext))
		{
			MaxShowCount = new int?(this.GetIntoBagMaxCount()),
			AddItemTime = new float?((float)this.AddItemTime()),
			ItemSliderTime = new float?((float)RewardConfig.Instance.GetSliderTime()),
			ItemShowTime = new float?((float)RewardConfig.Instance.GetShowTime()),
			FinishCallback = new Action(this.FinishCallback),
			SliderMode = new ESliderMode?(ESliderMode.SliderWhenPlayEnd),
			ChildResourceId = "UiItem_ItemListB"
		});
		this.ListSlideControl.DisEnableParentLayout();
		this.ListPriorSlideControl = new ListSliderControl<ItemPriorHintItem>(new ListSliderControlData<ItemPriorHintItem>(item2.GetParentAsUIItem(), new Func<ItemPriorHintItem>(this.CreatePriorItemProxy), new Func<bool>(this.CheckPriorNext))
		{
			MaxShowCount = new int?(this.GetPriorIntoBagMaxCount()),
			AddItemTime = new float?((float)this.AddItemTime()),
			ItemSliderTime = new float?((float)RewardConfig.Instance.GetSliderTime()),
			ItemShowTime = new float?((float)RewardConfig.Instance.GetShowTime()),
			FinishCallback = new Action(this.FinishCallback),
			SliderMode = new ESliderMode?(ESliderMode.SliderWhenPlayEnd),
			ChildResourceId = "UiItem_ItemListA"
		});
		this.ListPriorSlideControl.DisEnableParentLayout();
	}

	// Token: 0x06010124 RID: 65828 RVA: 0x003EA696 File Offset: 0x003E8896
	private ItemHintItem CreateItemProxy()
	{
		return new ItemHintItem();
	}

	// Token: 0x06010125 RID: 65829 RVA: 0x003EA69D File Offset: 0x003E889D
	private ItemPriorHintItem CreatePriorItemProxy()
	{
		return new ItemPriorHintItem();
	}

	// Token: 0x06010126 RID: 65830 RVA: 0x003EA6A4 File Offset: 0x003E88A4
	private int GetIntoBagMaxCount()
	{
		return ItemConfig.Instance.GetItemListMaxSize();
	}

	// Token: 0x06010127 RID: 65831 RVA: 0x003EA6B0 File Offset: 0x003E88B0
	private int GetPriorIntoBagMaxCount()
	{
		return ItemConfig.Instance.GetPriorItemListMaxSize();
	}

	// Token: 0x06010128 RID: 65832 RVA: 0x003EA6BC File Offset: 0x003E88BC
	private bool CheckNext()
	{
		return !ItemHintModel.Instance.IsMainInterfaceDataEmpty;
	}

	// Token: 0x06010129 RID: 65833 RVA: 0x003EA6CB File Offset: 0x003E88CB
	private bool CheckPriorNext()
	{
		return !ItemHintModel.Instance.IsPriorInterfaceDataEmpty;
	}

	// Token: 0x0601012A RID: 65834 RVA: 0x003EA6DA File Offset: 0x003E88DA
	private int AddItemTime()
	{
		return RewardConfig.Instance.GetNextItemTime();
	}

	// Token: 0x0601012B RID: 65835 RVA: 0x003EA6E6 File Offset: 0x003E88E6
	private void FinishCallback()
	{
		if (this.ListPriorSlideControl.IsFinish && this.ListSlideControl.IsFinish)
		{
			base.CloseMe(null);
		}
	}

	// Token: 0x0601012C RID: 65836 RVA: 0x003EA709 File Offset: 0x003E8909
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

	// Token: 0x040076D3 RID: 30419
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ListSliderControl<ItemHintItem> ListSlideControl;

	// Token: 0x040076D4 RID: 30420
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ListSliderControl<ItemPriorHintItem> ListPriorSlideControl;

	// Token: 0x0200860A RID: 34314
	[NullableContext(0)]
	private enum EItemHintViewCom
	{
		// Token: 0x0402B9FD RID: 178685
		ItemPriorHintItem,
		// Token: 0x0402B9FE RID: 178686
		ItemHintItem
	}
}

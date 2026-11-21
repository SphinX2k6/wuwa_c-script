using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020014D5 RID: 5333
[NullableContext(1)]
[Nullable(0)]
public class ItemHintView : UiTickViewBase
{
	// Token: 0x0600D588 RID: 54664 RVA: 0x003F6A53 File Offset: 0x003F4C53
	public ItemHintView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600D589 RID: 54665 RVA: 0x003F6A5C File Offset: 0x003F4C5C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(0, typeof(UUIItem))
		};
	}

	// Token: 0x0600D58A RID: 54666 RVA: 0x003F6A95 File Offset: 0x003F4C95
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

	// Token: 0x0600D58B RID: 54667 RVA: 0x003F6ACC File Offset: 0x003F4CCC
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

	// Token: 0x0600D58C RID: 54668 RVA: 0x003F6C8E File Offset: 0x003F4E8E
	private ItemHintItem CreateItemProxy()
	{
		return new ItemHintItem();
	}

	// Token: 0x0600D58D RID: 54669 RVA: 0x003F6C95 File Offset: 0x003F4E95
	private ItemPriorHintItem CreatePriorItemProxy()
	{
		return new ItemPriorHintItem();
	}

	// Token: 0x0600D58E RID: 54670 RVA: 0x003F6C9C File Offset: 0x003F4E9C
	private int GetIntoBagMaxCount()
	{
		return ItemConfig.Instance.GetItemListMaxSize();
	}

	// Token: 0x0600D58F RID: 54671 RVA: 0x003F6CA8 File Offset: 0x003F4EA8
	private int GetPriorIntoBagMaxCount()
	{
		return ItemConfig.Instance.GetPriorItemListMaxSize();
	}

	// Token: 0x0600D590 RID: 54672 RVA: 0x003F6CB4 File Offset: 0x003F4EB4
	private bool CheckNext()
	{
		return !ItemHintModel.Instance.IsMainInterfaceDataEmpty;
	}

	// Token: 0x0600D591 RID: 54673 RVA: 0x003F6CC3 File Offset: 0x003F4EC3
	private bool CheckPriorNext()
	{
		return !ItemHintModel.Instance.IsPriorInterfaceDataEmpty;
	}

	// Token: 0x0600D592 RID: 54674 RVA: 0x003F6CD2 File Offset: 0x003F4ED2
	private int AddItemTime()
	{
		return RewardConfig.Instance.GetNextItemTime();
	}

	// Token: 0x0600D593 RID: 54675 RVA: 0x003F6CDE File Offset: 0x003F4EDE
	private void FinishCallback()
	{
		if (this.ListPriorSlideControl.IsFinish && this.ListSlideControl.IsFinish)
		{
			base.CloseMe(null);
		}
	}

	// Token: 0x0600D594 RID: 54676 RVA: 0x003F6D01 File Offset: 0x003F4F01
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

	// Token: 0x040077BC RID: 30652
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ListSliderControl<ItemHintItem> ListSlideControl;

	// Token: 0x040077BD RID: 30653
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ListSliderControl<ItemPriorHintItem> ListPriorSlideControl;

	// Token: 0x02007791 RID: 30609
	[NullableContext(0)]
	private enum EItemHintViewCom
	{
		// Token: 0x04026D0C RID: 158988
		ItemPriorHintItem,
		// Token: 0x04026D0D RID: 158989
		ItemHintItem
	}
}

using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002881 RID: 10369
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleLevelUpCostItem : GridProxyAbstract<ISelectedData>
{
	// Token: 0x0601556D RID: 87405 RVA: 0x00563023 File Offset: 0x00561223
	private int GetConfigId()
	{
		return this.ItemGridVariantSelect.GetConfigId();
	}

	// Token: 0x0601556E RID: 87406 RVA: 0x00563030 File Offset: 0x00561230
	[NullableContext(1)]
	public override void Refresh(ISelectedData data, bool isSelected, int gridIndex)
	{
		this.RefreshBySelectedData(data);
	}

	// Token: 0x0601556F RID: 87407 RVA: 0x00563039 File Offset: 0x00561239
	public RoleLevelUpCostItem(UUIItem uiItem = null, Action<int> onItemClickCallBack = null, Action<int> onItemReduceCallBack = null, Func<int, bool> canItemLongPress = null, Func<int, bool> canItemReduceLongPress = null, EUiViewName? belongView = null)
	{
		this.OnItemClickCallBack = onItemClickCallBack;
		this.OnItemReduceCallBack = onItemReduceCallBack;
		this.CanItemLongPress = canItemLongPress;
		this.CanItemReduceLongPress = canItemReduceLongPress;
		this.BelongView = belongView;
		if (uiItem != null)
		{
			this.CreateThenShowByActor(uiItem.GetOwner());
		}
	}

	// Token: 0x06015570 RID: 87408 RVA: 0x00563078 File Offset: 0x00561278
	protected override void OnStart()
	{
		this.ItemGridVariantSelect = new ItemGridVariantSelect(this.RootItem.GetOwner(), null, this.BelongView);
		Action<bool> pointClickAction = delegate(bool _)
		{
			Action<int> onItemClickCallBack = this.OnItemClickCallBack;
			if (onItemClickCallBack == null)
			{
				return;
			}
			onItemClickCallBack(this.GetConfigId());
		};
		Func<bool> tickConditionDelegate = delegate()
		{
			Func<int, bool> canItemLongPress = this.CanItemLongPress;
			return canItemLongPress != null && canItemLongPress(this.GetConfigId());
		};
		this.ItemLongPressButton = new LongPressButtonItem(new OneOf<UUIButtonComponent, UUIExtendToggle>?(this.ItemGridVariantSelect.GetClickToggle()), new LongPressButtonItem.ELongPressConfigId?(LongPressButtonItem.ELongPressConfigId.LongPressOne), pointClickAction);
		this.ItemLongPressButton.SetTickConditionDelegate(tickConditionDelegate);
		Action<bool> pointClickAction2 = delegate(bool _)
		{
			Action<int> onItemReduceCallBack = this.OnItemReduceCallBack;
			if (onItemReduceCallBack == null)
			{
				return;
			}
			onItemReduceCallBack(this.GetConfigId());
		};
		Func<bool> tickConditionDelegate2 = delegate()
		{
			Func<int, bool> canItemReduceLongPress = this.CanItemReduceLongPress;
			return canItemReduceLongPress != null && canItemReduceLongPress(this.GetConfigId());
		};
		this.ReduceLongPressButton = new LongPressButtonItem(new OneOf<UUIButtonComponent, UUIExtendToggle>?(this.ItemGridVariantSelect.GetReduceButton()), new LongPressButtonItem.ELongPressConfigId?(LongPressButtonItem.ELongPressConfigId.LongPressOne), pointClickAction2);
		this.ReduceLongPressButton.SetTickConditionDelegate(tickConditionDelegate2);
		Action<int, ItemConfig> toggleClickEvent = delegate(int itemId, ItemConfig itemConfigId)
		{
			UUIExtendToggle clickToggle = this.ItemGridVariantSelect.GetClickToggle();
			if (clickToggle == null)
			{
				return;
			}
			clickToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		};
		this.ItemGridVariantSelect.SetToggleClickEvent(toggleClickEvent);
		this.ItemGridVariantSelect.GetAddButton().RootUIComp.Get().SetUIActive(false);
		this.ItemGridVariantSelect.RefreshItemShowState(true);
	}

	// Token: 0x06015571 RID: 87409 RVA: 0x00563182 File Offset: 0x00561382
	[NullableContext(1)]
	public void RefreshBySelectedData(ISelectedData data)
	{
		this.ItemGridVariantSelect.RefreshByItemId(data.ItemId);
		this.RefreshCountBySelectedData(data);
	}

	// Token: 0x06015572 RID: 87410 RVA: 0x0056319C File Offset: 0x0056139C
	[NullableContext(1)]
	public void RefreshCountBySelectedData(ISelectedData data)
	{
		int selectedCount = data.SelectedCount;
		int count = data.Count;
		ItemGridVariantSelect itemGridVariantSelect = this.ItemGridVariantSelect;
		bool showState = true;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(selectedCount);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(count);
		itemGridVariantSelect.RefreshTextDown(showState, defaultInterpolatedStringHandler.ToStringAndClear());
		this.ItemGridVariantSelect.GetReduceButton().RootUIComp.Get().SetUIActive(selectedCount > 0);
	}

	// Token: 0x06015573 RID: 87411 RVA: 0x00563210 File Offset: 0x00561410
	protected override void OnBeforeDestroy()
	{
		this.ItemLongPressButton.Clear();
		this.ReduceLongPressButton.Clear();
	}

	// Token: 0x06015574 RID: 87412 RVA: 0x00563228 File Offset: 0x00561428
	[NullableContext(1)]
	public UUIItem GetUiItemForGuide()
	{
		ItemGridVariantSelect itemGridVariantSelect = this.ItemGridVariantSelect;
		object obj;
		if (itemGridVariantSelect == null)
		{
			obj = null;
		}
		else
		{
			UUIExtendToggle clickToggle = itemGridVariantSelect.GetClickToggle();
			obj = ((clickToggle != null) ? clickToggle.GetOwner().GetComponentByClass(UUIItem.StaticClass()) : null);
		}
		return obj as UUIItem;
	}

	// Token: 0x04009F85 RID: 40837
	private ItemGridVariantSelect ItemGridVariantSelect;

	// Token: 0x04009F86 RID: 40838
	private LongPressButtonItem ItemLongPressButton;

	// Token: 0x04009F87 RID: 40839
	private LongPressButtonItem ReduceLongPressButton;

	// Token: 0x04009F88 RID: 40840
	private readonly Action<int> OnItemClickCallBack;

	// Token: 0x04009F89 RID: 40841
	private readonly Action<int> OnItemReduceCallBack;

	// Token: 0x04009F8A RID: 40842
	private readonly Func<int, bool> CanItemLongPress;

	// Token: 0x04009F8B RID: 40843
	private readonly Func<int, bool> CanItemReduceLongPress;

	// Token: 0x04009F8C RID: 40844
	public EUiViewName? BelongView;
}

using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001DFC RID: 7676
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleLevelUpCostItem : GridProxyAbstract<ISelectedData>
{
	// Token: 0x06012F6B RID: 77675 RVA: 0x0058DD7F File Offset: 0x0058BF7F
	private int GetConfigId()
	{
		return this.ItemGridVariantSelect.GetConfigId();
	}

	// Token: 0x06012F6C RID: 77676 RVA: 0x0058DD8C File Offset: 0x0058BF8C
	[NullableContext(1)]
	public override void Refresh(ISelectedData data, bool isSelected, int gridIndex)
	{
		this.RefreshBySelectedData(data);
	}

	// Token: 0x06012F6D RID: 77677 RVA: 0x0058DD95 File Offset: 0x0058BF95
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

	// Token: 0x06012F6E RID: 77678 RVA: 0x0058DDD4 File Offset: 0x0058BFD4
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

	// Token: 0x06012F6F RID: 77679 RVA: 0x0058DEDE File Offset: 0x0058C0DE
	[NullableContext(1)]
	public void RefreshBySelectedData(ISelectedData data)
	{
		this.ItemGridVariantSelect.RefreshByItemId(data.ItemId);
		this.RefreshCountBySelectedData(data);
	}

	// Token: 0x06012F70 RID: 77680 RVA: 0x0058DEF8 File Offset: 0x0058C0F8
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

	// Token: 0x06012F71 RID: 77681 RVA: 0x0058DF6C File Offset: 0x0058C16C
	protected override void OnBeforeDestroy()
	{
		this.ItemLongPressButton.Clear();
		this.ReduceLongPressButton.Clear();
	}

	// Token: 0x06012F72 RID: 77682 RVA: 0x0058DF84 File Offset: 0x0058C184
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

	// Token: 0x0400A36E RID: 41838
	private ItemGridVariantSelect ItemGridVariantSelect;

	// Token: 0x0400A36F RID: 41839
	private LongPressButtonItem ItemLongPressButton;

	// Token: 0x0400A370 RID: 41840
	private LongPressButtonItem ReduceLongPressButton;

	// Token: 0x0400A371 RID: 41841
	private readonly Action<int> OnItemClickCallBack;

	// Token: 0x0400A372 RID: 41842
	private readonly Action<int> OnItemReduceCallBack;

	// Token: 0x0400A373 RID: 41843
	private readonly Func<int, bool> CanItemLongPress;

	// Token: 0x0400A374 RID: 41844
	private readonly Func<int, bool> CanItemReduceLongPress;

	// Token: 0x0400A375 RID: 41845
	public EUiViewName? BelongView;
}

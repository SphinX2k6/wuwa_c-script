using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Common.NumberSelect;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001FE5 RID: 8165
[NullableContext(2)]
[Nullable(0)]
public class PhantomStackCountPopupView : UiViewBase
{
	// Token: 0x0600FFDF RID: 65503 RVA: 0x003E52E8 File Offset: 0x003E34E8
	[NullableContext(1)]
	public PhantomStackCountPopupView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600FFE0 RID: 65504 RVA: 0x003E52F4 File Offset: 0x003E34F4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600FFE1 RID: 65505 RVA: 0x003E5424 File Offset: 0x003E3624
	protected override UniTask OnBeforeStartAsync()
	{
		PhantomStackCountPopupView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomStackCountPopupView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600FFE2 RID: 65506 RVA: 0x003E5468 File Offset: 0x003E3668
	protected override void OnStart()
	{
		this.ViewData = (this.OpenParam as PhantomStackCountPopupData);
		if (this.ViewData == null)
		{
			return;
		}
		if (!string.IsNullOrEmpty(this.ViewData.FrameTitleText))
		{
			IUiPopFrameInterface childPopView = this.ChildPopView;
			if (childPopView != null)
			{
				childPopView.SetTitleByTextIdAndArg(this.ViewData.FrameTitleText, Array.Empty<object>());
			}
		}
		if (!string.IsNullOrEmpty(this.ViewData.TitleText))
		{
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.ShowTextNew(this.ViewData.TitleText);
			}
		}
		this.CancelButton.SetFunction(new Action<int>(this.OnClickCancel));
		this.ConfirmButton.SetFunction(new Action<int>(this.OnClickConfirm));
		this.ItemGrid.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
		this.ItemGrid.BindOnExtendToggleClicked(delegate(MediumItemGridExtendCallback _)
		{
			this.OnClickItemGrid();
		});
		if (!string.IsNullOrEmpty(this.ViewData.CancelText))
		{
			this.CancelButton.SetShowText(this.ViewData.CancelText);
		}
		if (!string.IsNullOrEmpty(this.ViewData.ConfirmText))
		{
			this.ConfirmButton.SetShowText(this.ViewData.ConfirmText);
		}
		bool flag = !string.IsNullOrEmpty(this.ViewData.TipsText);
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		if (flag)
		{
			UUIText text2 = base.GetText(5);
			if (text2 != null)
			{
				text2.ShowTextNew(this.ViewData.TipsText);
			}
		}
		this.NumberSelect = new NumberSelectComponent(base.GetItem(3));
		this.NumberSelect.SetMinValue(this.ViewData.MinCount);
		this.NumberSelect.EnableUseCustomMinValue(true);
		NumberSelectComponent numberSelect = this.NumberSelect;
		INumberSelectData numberSelectData = new INumberSelectData();
		numberSelectData.MaxNumber = this.ViewData.MaxCount;
		Func<int, TableTextArgNew> getExchangeTableText;
		if ((getExchangeTableText = this.ViewData.GetCountText) == null && (getExchangeTableText = PhantomStackCountPopupView.<>c.<>9__11_2) == null)
		{
			getExchangeTableText = (PhantomStackCountPopupView.<>c.<>9__11_2 = ((int count) => new TableTextArgNew("PhantomStack_AmountPickedTips", new <>z__ReadOnlySingleElementList<object>(count))));
		}
		numberSelectData.GetExchangeTableText = getExchangeTableText;
		numberSelectData.ValueChangeFunction = new Action<int>(this.OnSelectCountChange);
		numberSelect.Init(numberSelectData);
		int num = MathUtils.Instance.Clamp(this.ViewData.InitCount, this.ViewData.MinCount, this.ViewData.MaxCount);
		UUIItem item2 = base.GetItem(7);
		if (item2 != null)
		{
			item2.SetUIActive(false);
		}
		this.RefreshItemGrid(num);
		this.NumberSelect.ChangeValue(num, true);
	}

	// Token: 0x0600FFE3 RID: 65507 RVA: 0x003E56E5 File Offset: 0x003E38E5
	protected override void OnBeforeDestroy()
	{
		NumberSelectComponent numberSelect = this.NumberSelect;
		if (numberSelect == null)
		{
			return;
		}
		numberSelect.Destroy(null);
	}

	// Token: 0x0600FFE4 RID: 65508 RVA: 0x003E56F8 File Offset: 0x003E38F8
	private void RefreshItemGrid(int initSelectedCount)
	{
		PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomDataBase(this.ViewData.IncId) as PhantomBattleData;
		PhantomItemData phantomItemData = InventoryModel.Instance.GetPhantomItemData(this.ViewData.IncId);
		if (phantomBattleData == null || phantomItemData == null)
		{
			return;
		}
		int quality = phantomBattleData.GetQuality();
		this.StackCount = phantomItemData.GetStackCount();
		this.CanStack = PhantomStackUtil.CanStackWithSameSpec(phantomBattleData);
		this.ItemGrid.Apply<PhantomMediumItemGrid>(new PhantomMediumItemGrid
		{
			Data = phantomBattleData,
			ItemConfigId = new int?(phantomBattleData.GetConfigId(true)),
			BottomText = "+" + phantomBattleData.GetPhantomLevel().ToString(),
			StarLevel = new int?(quality),
			QualityId = new int?(quality),
			Level = new int?(phantomBattleData.GetCost()),
			IsLevelTextUseChangeColor = new bool?(true),
			FetterGroupId = new int?(phantomBattleData.GetFetterGroupId()),
			IsLockVisible = new bool?(phantomItemData.GetIsLock()),
			IsDeprecate = new bool?(phantomItemData.GetIsDeprecated()),
			StackDisplayInfo = new PhantomStackDisplay
			{
				StackCount = this.StackCount,
				SelectedCount = initSelectedCount,
				AlwaysShowSelected = true,
				CanStack = this.CanStack
			}
		});
	}

	// Token: 0x0600FFE5 RID: 65509 RVA: 0x003E583C File Offset: 0x003E3A3C
	private void RefreshStackDisplay(int selectedCount)
	{
		MediumItemGrid itemGrid = this.ItemGrid;
		if (itemGrid == null)
		{
			return;
		}
		itemGrid.SetPhantomStackDisplay(new PhantomStackDisplay
		{
			StackCount = this.StackCount,
			SelectedCount = selectedCount,
			AlwaysShowSelected = true,
			CanStack = this.CanStack
		});
	}

	// Token: 0x0600FFE6 RID: 65510 RVA: 0x003E587C File Offset: 0x003E3A7C
	private void OnClickItemGrid()
	{
		if (this.ViewData == null)
		{
			return;
		}
		PhantomItemData phantomItemData = InventoryModel.Instance.GetPhantomItemData(this.ViewData.IncId);
		if (phantomItemData == null)
		{
			return;
		}
		ItemController.Instance.OpenItemTipsByItemUid(this.ViewData.IncId, phantomItemData.GetConfigId(), true, null);
	}

	// Token: 0x0600FFE7 RID: 65511 RVA: 0x003E58C9 File Offset: 0x003E3AC9
	private void OnSelectCountChange(int count)
	{
		this.RefreshStackDisplay(count);
	}

	// Token: 0x0600FFE8 RID: 65512 RVA: 0x003E58D2 File Offset: 0x003E3AD2
	private void OnClickCancel(int _)
	{
		PhantomStackCountPopupData viewData = this.ViewData;
		if (viewData != null)
		{
			Action onCancel = viewData.OnCancel;
			if (onCancel != null)
			{
				onCancel();
			}
		}
		base.CloseMe(null);
	}

	// Token: 0x0600FFE9 RID: 65513 RVA: 0x003E58F8 File Offset: 0x003E3AF8
	private void OnClickConfirm(int _)
	{
		int selectNumber = this.NumberSelect.GetSelectNumber();
		PhantomStackCountPopupData viewData = this.ViewData;
		if (viewData != null)
		{
			Action<int> onConfirm = viewData.OnConfirm;
			if (onConfirm != null)
			{
				onConfirm(selectNumber);
			}
		}
		base.CloseMe(null);
	}

	// Token: 0x0400766B RID: 30315
	private PhantomStackCountPopupData ViewData;

	// Token: 0x0400766C RID: 30316
	private ButtonItem CancelButton;

	// Token: 0x0400766D RID: 30317
	private ButtonItem ConfirmButton;

	// Token: 0x0400766E RID: 30318
	private NumberSelectComponent NumberSelect;

	// Token: 0x0400766F RID: 30319
	private MediumItemGrid ItemGrid;

	// Token: 0x04007670 RID: 30320
	private int StackCount;

	// Token: 0x04007671 RID: 30321
	private bool CanStack;

	// Token: 0x020085F8 RID: 34296
	[NullableContext(0)]
	private class EComp
	{
		// Token: 0x0402B9A8 RID: 178600
		public const int TxtTitle = 0;

		// Token: 0x0402B9A9 RID: 178601
		public const int BtnCancel = 1;

		// Token: 0x0402B9AA RID: 178602
		public const int BtnConfirm = 2;

		// Token: 0x0402B9AB RID: 178603
		public const int NumControl = 3;

		// Token: 0x0402B9AC RID: 178604
		public const int PnlTips = 4;

		// Token: 0x0402B9AD RID: 178605
		public const int TxtTips = 5;

		// Token: 0x0402B9AE RID: 178606
		public const int ItemGrid = 6;

		// Token: 0x0402B9AF RID: 178607
		public const int PnlEchoStack = 7;
	}
}

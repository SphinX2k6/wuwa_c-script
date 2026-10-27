using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.DeadRevive
{
	// Token: 0x02005ACA RID: 23242
	[NullableContext(1)]
	[Nullable(0)]
	public class ReviveItemView : UiViewBase
	{
		// Token: 0x0603ADCB RID: 241099 RVA: 0x00E07FC5 File Offset: 0x00E061C5
		public ReviveItemView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603ADCC RID: 241100 RVA: 0x00E07FDC File Offset: 0x00E061DC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.ButtonOnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603ADCD RID: 241101 RVA: 0x00E080A3 File Offset: 0x00E062A3
		private void OnClose()
		{
			this.ConfirmBoxButtonClick();
		}

		// Token: 0x0603ADCE RID: 241102 RVA: 0x00E080AC File Offset: 0x00E062AC
		protected override void OnStart()
		{
			IUiPopFrameInterface childPopView = this.ChildPopView;
			if (childPopView != null)
			{
				childPopView.PopItem.OverrideBackBtnCallBack(new Action(this.OnClose));
			}
			ReviveItemData reviveItemData = this.OpenParam as ReviveItemData;
			this.RoleId = reviveItemData.PlayerId;
			this.SelectedItemId = reviveItemData.ChoseId;
			this.ItemIdMap = new Dictionary<int, int>();
			foreach (int num in reviveItemData.ItemIdList)
			{
				int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(num, 0);
				if (itemCountByConfigId > 0)
				{
					this.ItemIdMap.Add(num, itemCountByConfigId);
				}
			}
			this.PropScrollView = new GenericScrollView<ReviveSmallItemGrid>(base.GetScrollViewWithScrollbar(2), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<ReviveSmallItemGrid>(this.CreatePropItem), null);
			this.InitPropItem();
		}

		// Token: 0x0603ADCF RID: 241103 RVA: 0x00E08188 File Offset: 0x00E06388
		protected void InitPropItem()
		{
			ULGUIBehaviour scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(2);
			int count = this.ItemIdMap.Count;
			scrollViewWithScrollbar.RootUIComp.Get().SetUIActive(count > 0);
			if (count == 0)
			{
				return;
			}
			List<ValueTuple<int, int>> list = new List<ValueTuple<int, int>>();
			int index = 0;
			foreach (KeyValuePair<int, int> keyValuePair in this.ItemIdMap)
			{
				int key = keyValuePair.Key;
				int value = keyValuePair.Value;
				list.Add(new ValueTuple<int, int>(key, value));
				if (this.SelectedItemId == key)
				{
					index = list.Count - 1;
				}
			}
			this.PropScrollView.RefreshByData<ValueTuple<int, int>>(list, null);
			ReviveSmallItemGrid reviveSmallItemGrid = this.PropScrollView.GetScrollItemList()[index];
			reviveSmallItemGrid.SetSelected(true, false);
			this.SetSelectedItemGrid(reviveSmallItemGrid);
		}

		// Token: 0x0603ADD0 RID: 241104 RVA: 0x00E08278 File Offset: 0x00E06478
		private ILayoutItem<ReviveSmallItemGrid> CreatePropItem(object tempData, UUIItem uiItem, int index)
		{
			ValueTuple<int, int>? valueTuple = tempData as ValueTuple<int, int>?;
			ReviveSmallItemGrid reviveSmallItemGrid = new ReviveSmallItemGrid();
			reviveSmallItemGrid.Initialize(uiItem.GetOwner());
			reviveSmallItemGrid.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnItemExtendToggleStateChanged));
			reviveSmallItemGrid.Refresh(valueTuple.Value.Item1, valueTuple.Value.Item2);
			return new LayoutItem<ReviveSmallItemGrid>
			{
				Key = index,
				Value = reviveSmallItemGrid
			};
		}

		// Token: 0x0603ADD1 RID: 241105 RVA: 0x00E082EB File Offset: 0x00E064EB
		protected override void OnBeforeDestroy()
		{
			if (this.ItemIdMap != null)
			{
				this.ItemIdMap.Clear();
			}
			this.SelectedItemId = -1;
			this.RoleId = -1;
			this.PropScrollView.ClearChildren();
		}

		// Token: 0x0603ADD2 RID: 241106 RVA: 0x00E08319 File Offset: 0x00E06519
		protected void ConfirmBoxButtonClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603ADD3 RID: 241107 RVA: 0x00E08324 File Offset: 0x00E06524
		private void OnItemExtendToggleStateChanged(MediumItemGridExtendCallback callbackParameter)
		{
			ReviveSmallItemGrid selectedItemGrid = callbackParameter.MediumItemGrid as ReviveSmallItemGrid;
			this.SetSelectedItemGrid(selectedItemGrid);
		}

		// Token: 0x0603ADD4 RID: 241108 RVA: 0x00E08344 File Offset: 0x00E06544
		private void SetSelectedItemGrid(ReviveSmallItemGrid itemGrid)
		{
			if (itemGrid == null)
			{
				return;
			}
			ReviveSmallItemGrid selectedItemGrid = this.SelectedItemGrid;
			if (selectedItemGrid != null)
			{
				selectedItemGrid.SetSelected(false, false);
			}
			this.SelectedItemGrid = itemGrid;
			this.SelectedItemId = itemGrid.ItemId.Value;
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(this.SelectedItemId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), itemConfigData.AttributesDescription, Array.Empty<object>());
		}

		// Token: 0x0603ADD5 RID: 241109 RVA: 0x00E083AD File Offset: 0x00E065AD
		private void ButtonOnClick()
		{
			if (this.SelectedItemId == -1)
			{
				ScrollingTipsController.Instance.ShowTipsById("ReviveItemNotClick", Array.Empty<object>());
				return;
			}
			BuffItemControl.Instance.RequestUseBuffItem(this.SelectedItemId, 1, this.RoleId);
			base.CloseMe(null);
		}

		// Token: 0x0401EB7C RID: 125820
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected GenericScrollView<ReviveSmallItemGrid> PropScrollView;

		// Token: 0x0401EB7D RID: 125821
		[Nullable(2)]
		protected Dictionary<int, int> ItemIdMap;

		// Token: 0x0401EB7E RID: 125822
		protected int SelectedItemId = -1;

		// Token: 0x0401EB7F RID: 125823
		private int RoleId = -1;

		// Token: 0x0401EB80 RID: 125824
		[Nullable(2)]
		private ReviveSmallItemGrid SelectedItemGrid;

		// Token: 0x0200BD1C RID: 48412
		[NullableContext(0)]
		private class EConfirmBoxViewDefine
		{
			// Token: 0x04039094 RID: 233620
			public const int SecondaryContentText = 0;

			// Token: 0x04039095 RID: 233621
			public const int ConfirmButton = 1;

			// Token: 0x04039096 RID: 233622
			public const int PropScrollView = 2;
		}
	}
}

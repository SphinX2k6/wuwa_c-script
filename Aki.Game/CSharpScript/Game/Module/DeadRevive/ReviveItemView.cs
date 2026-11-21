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
	// Token: 0x02004AAB RID: 19115
	[NullableContext(1)]
	[Nullable(0)]
	public class ReviveItemView : UiViewBase
	{
		// Token: 0x0602FD3D RID: 195901 RVA: 0x00D58CA5 File Offset: 0x00D56EA5
		public ReviveItemView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602FD3E RID: 195902 RVA: 0x00D58CBC File Offset: 0x00D56EBC
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

		// Token: 0x0602FD3F RID: 195903 RVA: 0x00D58D83 File Offset: 0x00D56F83
		private void OnClose()
		{
			this.ConfirmBoxButtonClick();
		}

		// Token: 0x0602FD40 RID: 195904 RVA: 0x00D58D8C File Offset: 0x00D56F8C
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

		// Token: 0x0602FD41 RID: 195905 RVA: 0x00D58E68 File Offset: 0x00D57068
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

		// Token: 0x0602FD42 RID: 195906 RVA: 0x00D58F58 File Offset: 0x00D57158
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

		// Token: 0x0602FD43 RID: 195907 RVA: 0x00D58FCB File Offset: 0x00D571CB
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

		// Token: 0x0602FD44 RID: 195908 RVA: 0x00D58FF9 File Offset: 0x00D571F9
		protected void ConfirmBoxButtonClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602FD45 RID: 195909 RVA: 0x00D59004 File Offset: 0x00D57204
		private void OnItemExtendToggleStateChanged(MediumItemGridExtendCallback callbackParameter)
		{
			ReviveSmallItemGrid selectedItemGrid = callbackParameter.MediumItemGrid as ReviveSmallItemGrid;
			this.SetSelectedItemGrid(selectedItemGrid);
		}

		// Token: 0x0602FD46 RID: 195910 RVA: 0x00D59024 File Offset: 0x00D57224
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

		// Token: 0x0602FD47 RID: 195911 RVA: 0x00D5908D File Offset: 0x00D5728D
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

		// Token: 0x04019638 RID: 103992
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected GenericScrollView<ReviveSmallItemGrid> PropScrollView;

		// Token: 0x04019639 RID: 103993
		[Nullable(2)]
		protected Dictionary<int, int> ItemIdMap;

		// Token: 0x0401963A RID: 103994
		protected int SelectedItemId = -1;

		// Token: 0x0401963B RID: 103995
		private int RoleId = -1;

		// Token: 0x0401963C RID: 103996
		[Nullable(2)]
		private ReviveSmallItemGrid SelectedItemGrid;

		// Token: 0x0200A724 RID: 42788
		[NullableContext(0)]
		private class EConfirmBoxViewDefine
		{
			// Token: 0x04033A5E RID: 211550
			public const int SecondaryContentText = 0;

			// Token: 0x04033A5F RID: 211551
			public const int ConfirmButton = 1;

			// Token: 0x04033A60 RID: 211552
			public const int PropScrollView = 2;
		}
	}
}

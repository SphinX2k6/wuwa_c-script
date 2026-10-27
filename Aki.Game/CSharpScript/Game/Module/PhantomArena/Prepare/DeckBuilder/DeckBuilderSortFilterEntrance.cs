using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x020051A3 RID: 20899
	public class DeckBuilderSortFilterEntrance : UiPanelBase
	{
		// Token: 0x06035789 RID: 219017 RVA: 0x00CA8751 File Offset: 0x00CA6951
		public DeckBuilderSortFilterEntrance(bool isFilterOrSort)
		{
			this.IsFilterOrSort = isFilterOrSort;
		}

		// Token: 0x0603578A RID: 219018 RVA: 0x00CA8778 File Offset: 0x00CA6978
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(4, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.HandleSortShow)),
				new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.OnSortToggleClick))
			};
		}

		// Token: 0x0603578B RID: 219019 RVA: 0x00CA883C File Offset: 0x00CA6A3C
		protected override UniTask OnBeforeStartAsync()
		{
			DeckBuilderSortFilterEntrance.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DeckBuilderSortFilterEntrance.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603578C RID: 219020 RVA: 0x00CA887F File Offset: 0x00CA6A7F
		[NullableContext(1)]
		public void UpdateDataList(IDeckBuilderSortFilterItemData[] dataList)
		{
			this.DataList = dataList;
			GenericScrollViewNew<DeckBuilderSortFilterItem, IDeckBuilderSortFilterItemData> scroll = this.Scroll;
			if (scroll == null)
			{
				return;
			}
			scroll.RefreshByData(this.DataList.ToList<IDeckBuilderSortFilterItemData>(), null, false);
		}

		// Token: 0x0603578D RID: 219021 RVA: 0x00CA88A8 File Offset: 0x00CA6AA8
		private void HandleSortShow(EToggleState toggleState)
		{
			bool bIsUIActive = base.GetScrollViewWithScrollbar(3).RootUIComp.Get().bIsUIActive;
			this.ChangeScrollActive(!bIsUIActive);
		}

		// Token: 0x0603578E RID: 219022 RVA: 0x00CA88DC File Offset: 0x00CA6ADC
		public void SelectItemByIndex(int gridIndex, bool bTriggerCallBack)
		{
			if (this.DataList == null || this.DataList.Length == 0 || gridIndex < 0 || gridIndex >= this.DataList.Length || this.DataList[gridIndex] == null)
			{
				return;
			}
			this.SelectedGridIndex = gridIndex;
			IDeckBuilderSortFilterItemData deckBuilderSortFilterItemData = this.DataList[gridIndex];
			this.ChangeScrollActive(false);
			GenericScrollViewNew<DeckBuilderSortFilterItem, IDeckBuilderSortFilterItemData> scroll = this.Scroll;
			if (scroll != null)
			{
				scroll.SelectGridProxy(gridIndex, false);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), deckBuilderSortFilterItemData.Name, Array.Empty<object>());
			if (bTriggerCallBack)
			{
				Action<int, bool> onResultCallBack = this.OnResultCallBack;
				if (onResultCallBack == null)
				{
					return;
				}
				onResultCallBack(deckBuilderSortFilterItemData.ConfigId, this.IsAscending);
			}
		}

		// Token: 0x0603578F RID: 219023 RVA: 0x00CA8979 File Offset: 0x00CA6B79
		private void ChangeScrollActive(bool value)
		{
			this.Scroll.SetActive(value);
			if (value)
			{
				this.ShowMaskButton();
				return;
			}
			this.HideMaskButton();
		}

		// Token: 0x06035790 RID: 219024 RVA: 0x00CA8997 File Offset: 0x00CA6B97
		private void ShowMaskButton()
		{
			this.MaskButton.SetAttachChildItem(this.RootItem);
			this.MaskButton.SetActive(true);
		}

		// Token: 0x06035791 RID: 219025 RVA: 0x00CA89B6 File Offset: 0x00CA6BB6
		private void HideMaskButton()
		{
			this.MaskButton.ResetItemParent();
			this.MaskButton.SetActive(false);
		}

		// Token: 0x06035792 RID: 219026 RVA: 0x00CA89CF File Offset: 0x00CA6BCF
		[NullableContext(1)]
		private DeckBuilderSortFilterItem InitItem()
		{
			return new DeckBuilderSortFilterItem
			{
				OnToggleSelect = new Action<int>(this.OnItemClick)
			};
		}

		// Token: 0x06035793 RID: 219027 RVA: 0x00CA89E8 File Offset: 0x00CA6BE8
		private void OnItemClick(int gridIndex)
		{
			this.SelectItemByIndex(gridIndex, true);
		}

		// Token: 0x06035794 RID: 219028 RVA: 0x00CA89F4 File Offset: 0x00CA6BF4
		private void OnSortToggleClick(EToggleState toggleState)
		{
			bool isAscending = base.GetExtendToggle(2).GetToggleState() == EToggleState.ETT_Checked;
			this.ChangeSortAscending(isAscending, false, true);
		}

		// Token: 0x06035795 RID: 219029 RVA: 0x00CA8A1A File Offset: 0x00CA6C1A
		private void HideScroll()
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, true, false, false);
		}

		// Token: 0x06035796 RID: 219030 RVA: 0x00CA8A30 File Offset: 0x00CA6C30
		public void ChangeSortAscending(bool isAscending, bool bRefreshToggle, bool bTriggerCallBack)
		{
			this.IsAscending = isAscending;
			if (bRefreshToggle)
			{
				base.GetExtendToggle(2).SetToggleState(isAscending ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			}
			if (!bTriggerCallBack)
			{
				return;
			}
			if (this.DataList == null || this.DataList.Length == 0)
			{
				return;
			}
			IDeckBuilderSortFilterItemData deckBuilderSortFilterItemData = this.DataList[this.SelectedGridIndex];
			if (deckBuilderSortFilterItemData != null)
			{
				Action<int, bool> onResultCallBack = this.OnResultCallBack;
				if (onResultCallBack == null)
				{
					return;
				}
				onResultCallBack(deckBuilderSortFilterItemData.ConfigId, this.IsAscending);
			}
		}

		// Token: 0x06035797 RID: 219031 RVA: 0x00CA8AA1 File Offset: 0x00CA6CA1
		protected override void OnBeforeDestroy()
		{
			DynamicMaskButton maskButton = this.MaskButton;
			if (maskButton == null)
			{
				return;
			}
			maskButton.Destroy(null);
		}

		// Token: 0x0401C66E RID: 116334
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private IDeckBuilderSortFilterItemData[] DataList;

		// Token: 0x0401C66F RID: 116335
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<DeckBuilderSortFilterItem, IDeckBuilderSortFilterItemData> Scroll;

		// Token: 0x0401C670 RID: 116336
		[Nullable(2)]
		private DynamicMaskButton MaskButton;

		// Token: 0x0401C671 RID: 116337
		public bool IsFilterOrSort = true;

		// Token: 0x0401C672 RID: 116338
		private bool IsAscending = true;

		// Token: 0x0401C673 RID: 116339
		private int SelectedGridIndex = -1;

		// Token: 0x0401C674 RID: 116340
		[Nullable(2)]
		public Action<int, bool> OnResultCallBack;

		// Token: 0x0200B313 RID: 45843
		private static class EComponents
		{
			// Token: 0x04036462 RID: 222306
			public const int Toggle = 0;

			// Token: 0x04036463 RID: 222307
			public const int Name = 1;

			// Token: 0x04036464 RID: 222308
			public const int SortToggle = 2;

			// Token: 0x04036465 RID: 222309
			public const int ItemScroll = 3;

			// Token: 0x04036466 RID: 222310
			public const int TemplateItem = 4;
		}
	}
}

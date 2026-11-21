using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x02004173 RID: 16755
	public class DeckBuilderSortFilterEntrance : UiPanelBase
	{
		// Token: 0x0602A684 RID: 173700 RVA: 0x00BF5D91 File Offset: 0x00BF3F91
		public DeckBuilderSortFilterEntrance(bool isFilterOrSort)
		{
			this.IsFilterOrSort = isFilterOrSort;
		}

		// Token: 0x0602A685 RID: 173701 RVA: 0x00BF5DB8 File Offset: 0x00BF3FB8
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

		// Token: 0x0602A686 RID: 173702 RVA: 0x00BF5E7C File Offset: 0x00BF407C
		protected override UniTask OnBeforeStartAsync()
		{
			DeckBuilderSortFilterEntrance.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DeckBuilderSortFilterEntrance.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A687 RID: 173703 RVA: 0x00BF5EBF File Offset: 0x00BF40BF
		[NullableContext(1)]
		public void UpdateDataList(IDeckBuilderSortFilterItemData[] dataList)
		{
			this.DataList = dataList;
			GenericScrollViewNew<DeckBuilderSortFilterItem, IDeckBuilderSortFilterItemData> scroll = this.Scroll;
			if (scroll == null)
			{
				return;
			}
			scroll.RefreshByData(this.DataList, null, false);
		}

		// Token: 0x0602A688 RID: 173704 RVA: 0x00BF5EE0 File Offset: 0x00BF40E0
		private void HandleSortShow(EToggleState toggleState)
		{
			bool bIsUIActive = base.GetScrollViewWithScrollbar(3).RootUIComp.Get().bIsUIActive;
			this.ChangeScrollActive(!bIsUIActive);
		}

		// Token: 0x0602A689 RID: 173705 RVA: 0x00BF5F14 File Offset: 0x00BF4114
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

		// Token: 0x0602A68A RID: 173706 RVA: 0x00BF5FB1 File Offset: 0x00BF41B1
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

		// Token: 0x0602A68B RID: 173707 RVA: 0x00BF5FCF File Offset: 0x00BF41CF
		private void ShowMaskButton()
		{
			this.MaskButton.SetAttachChildItem(this.RootItem);
			this.MaskButton.SetActive(true);
		}

		// Token: 0x0602A68C RID: 173708 RVA: 0x00BF5FEE File Offset: 0x00BF41EE
		private void HideMaskButton()
		{
			this.MaskButton.ResetItemParent();
			this.MaskButton.SetActive(false);
		}

		// Token: 0x0602A68D RID: 173709 RVA: 0x00BF6007 File Offset: 0x00BF4207
		[NullableContext(1)]
		private DeckBuilderSortFilterItem InitItem()
		{
			return new DeckBuilderSortFilterItem
			{
				OnToggleSelect = new Action<int>(this.OnItemClick)
			};
		}

		// Token: 0x0602A68E RID: 173710 RVA: 0x00BF6020 File Offset: 0x00BF4220
		private void OnItemClick(int gridIndex)
		{
			this.SelectItemByIndex(gridIndex, true);
		}

		// Token: 0x0602A68F RID: 173711 RVA: 0x00BF602C File Offset: 0x00BF422C
		private void OnSortToggleClick(EToggleState toggleState)
		{
			bool isAscending = base.GetExtendToggle(2).GetToggleState() == EToggleState.ETT_Checked;
			this.ChangeSortAscending(isAscending, false, true);
		}

		// Token: 0x0602A690 RID: 173712 RVA: 0x00BF6052 File Offset: 0x00BF4252
		private void HideScroll()
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, true, false, false);
		}

		// Token: 0x0602A691 RID: 173713 RVA: 0x00BF6068 File Offset: 0x00BF4268
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

		// Token: 0x0602A692 RID: 173714 RVA: 0x00BF60D9 File Offset: 0x00BF42D9
		protected override void OnBeforeDestroy()
		{
			DynamicMaskButton maskButton = this.MaskButton;
			if (maskButton == null)
			{
				return;
			}
			maskButton.Destroy(null);
		}

		// Token: 0x040170A3 RID: 94371
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private IDeckBuilderSortFilterItemData[] DataList;

		// Token: 0x040170A4 RID: 94372
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<DeckBuilderSortFilterItem, IDeckBuilderSortFilterItemData> Scroll;

		// Token: 0x040170A5 RID: 94373
		[Nullable(2)]
		private DynamicMaskButton MaskButton;

		// Token: 0x040170A6 RID: 94374
		public bool IsFilterOrSort = true;

		// Token: 0x040170A7 RID: 94375
		private bool IsAscending = true;

		// Token: 0x040170A8 RID: 94376
		private int SelectedGridIndex = -1;

		// Token: 0x040170A9 RID: 94377
		[Nullable(2)]
		public Action<int, bool> OnResultCallBack;

		// Token: 0x02009D4B RID: 40267
		private static class EComponents
		{
			// Token: 0x04030EB5 RID: 200373
			public const int Toggle = 0;

			// Token: 0x04030EB6 RID: 200374
			public const int Name = 1;

			// Token: 0x04030EB7 RID: 200375
			public const int SortToggle = 2;

			// Token: 0x04030EB8 RID: 200376
			public const int ItemScroll = 3;

			// Token: 0x04030EB9 RID: 200377
			public const int TemplateItem = 4;
		}
	}
}

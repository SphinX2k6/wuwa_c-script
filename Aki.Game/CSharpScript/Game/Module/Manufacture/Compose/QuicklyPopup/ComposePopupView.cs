using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Compose.QuicklyPopup
{
	// Token: 0x02004659 RID: 18009
	[NullableContext(1)]
	[Nullable(0)]
	public class ComposePopupView : UiViewBase
	{
		// Token: 0x0602D4A8 RID: 185512 RVA: 0x00CAEAC1 File Offset: 0x00CACCC1
		public ComposePopupView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602D4A9 RID: 185513 RVA: 0x00CAEACC File Offset: 0x00CACCCC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action<EToggleState>(this.OnToggleClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602D4AA RID: 185514 RVA: 0x00CAEC5A File Offset: 0x00CACE5A
		private void OnToggleClick(EToggleState state)
		{
			this.CachedUseGift = (state == EToggleState.ETT_Checked);
			this.RefreshView();
		}

		// Token: 0x0602D4AB RID: 185515 RVA: 0x00CAEC6C File Offset: 0x00CACE6C
		protected override UniTask OnBeforeStartAsync()
		{
			ComposePopupView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ComposePopupView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602D4AC RID: 185516 RVA: 0x00CAECB0 File Offset: 0x00CACEB0
		protected override void OnStart()
		{
			this.ItemScrollView = new GenericScrollViewNew<ComposePopupGridItem, IComposePopupGridItemData>(base.GetScrollViewWithScrollbar(2), new Func<ComposePopupGridItem>(this.InitRewardItem), null, false, null);
			ButtonItem cancelButton = this.CancelButton;
			if (cancelButton != null)
			{
				cancelButton.SetFunction(new Action<int>(this.OnClickCancel));
			}
			ButtonItem confirmButton = this.ConfirmButton;
			if (confirmButton != null)
			{
				confirmButton.SetFunction(new Action<int>(this.OnClickConfirm));
			}
			IComposePopupViewData composePopupViewData = this.OpenParam as IComposePopupViewData;
			if (composePopupViewData == null)
			{
				return;
			}
			List<ISelectedData> selectedDataList = ComposePopupModel.Instance.MergeDuplicateSelectedData(composePopupViewData.SelectedItemList);
			this.CachedSelectedItemList = this.SortSelectedDataList(selectedDataList);
			this.ClickConfirm = composePopupViewData.ClickConfirm;
			this.BeforeCompose = composePopupViewData.BeforeCompose;
			this.CachedBelongView = composePopupViewData.BelongView;
			ValueTuple<EDefaultCheckResult, List<IComposePopupGridItemData>> valueTuple = this.CheckDefaultComposeResult(this.CachedSelectedItemList);
			this.CachedUseGift = (valueTuple.Item1 > EDefaultCheckResult.OnlyMaterial);
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.ShowTextNew((valueTuple.Item1 == EDefaultCheckResult.OnlyMaterial) ? "AutoSynthesis_MaterialEnough_Title" : "AutoSynthesis_MaterialMissing_Title");
			}
			base.GetExtendToggle(5).SetToggleStateForce(this.CachedUseGift ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0602D4AD RID: 185517 RVA: 0x00CAEDC7 File Offset: 0x00CACFC7
		protected override void OnBeforeShow()
		{
			this.RefreshView();
		}

		// Token: 0x0602D4AE RID: 185518 RVA: 0x00CAEDD0 File Offset: 0x00CACFD0
		protected override void OnAfterHide()
		{
			GenericScrollViewNew<ComposePopupGridItem, IComposePopupGridItemData> itemScrollView = this.ItemScrollView;
			List<ComposePopupGridItem> list = (itemScrollView != null) ? itemScrollView.GetScrollItemList() : null;
			if (list != null)
			{
				foreach (ComposePopupGridItem composePopupGridItem in list)
				{
					composePopupGridItem.StopNiagara();
				}
			}
		}

		// Token: 0x0602D4AF RID: 185519 RVA: 0x00CAEE34 File Offset: 0x00CAD034
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnItemCountChanged));
		}

		// Token: 0x0602D4B0 RID: 185520 RVA: 0x00CAEE52 File Offset: 0x00CAD052
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnItemCountChanged));
		}

		// Token: 0x0602D4B1 RID: 185521 RVA: 0x00CAEE70 File Offset: 0x00CAD070
		private void OnItemCountChanged(int i, int i1)
		{
			if (this.IgnoreEvent)
			{
				return;
			}
			this.RefreshView();
		}

		// Token: 0x0602D4B2 RID: 185522 RVA: 0x00CAEE84 File Offset: 0x00CAD084
		private void RefreshView()
		{
			foreach (ISelectedData selectedData in this.CachedSelectedItemList)
			{
				selectedData.SelectedCount = InventoryModel.Instance.GetItemCountByConfigId(selectedData.ItemId, 0);
			}
			ValueTuple<EComposeCheckResult, List<IComposePopupGridItemData>> valueTuple = ComposePopupModel.Instance.CheckComposeResult(this.CachedSelectedItemList, this.CachedUseGift, false);
			this.RefreshScrollView(valueTuple.Item2);
			this.RefreshConfirmButton(valueTuple.Item1 == EComposeCheckResult.CanComposeAll);
			this.RefreshGiftToggleVisible();
		}

		// Token: 0x0602D4B3 RID: 185523 RVA: 0x00CAEF20 File Offset: 0x00CAD120
		private void RefreshScrollView(List<IComposePopupGridItemData> gridDataList)
		{
			List<IComposePopupGridItemData> list = this.SortGridDataList(gridDataList);
			this.CachedGridDataList = list;
			GenericScrollViewNew<ComposePopupGridItem, IComposePopupGridItemData> itemScrollView = this.ItemScrollView;
			if (itemScrollView == null)
			{
				return;
			}
			itemScrollView.RefreshByData(list, null, false);
		}

		// Token: 0x0602D4B4 RID: 185524 RVA: 0x00CAEF4F File Offset: 0x00CAD14F
		private void RefreshConfirmButton(bool isEnough)
		{
			ButtonItem confirmButton = this.ConfirmButton;
			if (confirmButton != null)
			{
				confirmButton.SetEnableClick(isEnough);
			}
			ButtonItem confirmButton2 = this.ConfirmButton;
			if (confirmButton2 == null)
			{
				return;
			}
			confirmButton2.SetShowText(isEnough ? "AutoSynthesis_LevelUpBtn_Text" : "AutoSynthesis_MaterialMissingBtn_Text");
		}

		// Token: 0x0602D4B5 RID: 185525 RVA: 0x00CAEF84 File Offset: 0x00CAD184
		private void RefreshGiftToggleVisible()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(5);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.RootUIComp.Get().SetUIActive(ComposePopupModel.Instance.IsComposeGiftShouldShow(this.CachedSelectedItemList));
		}

		// Token: 0x0602D4B6 RID: 185526 RVA: 0x00CAEFBF File Offset: 0x00CAD1BF
		private ComposePopupGridItem InitRewardItem()
		{
			return new ComposePopupGridItem
			{
				BelongView = this.CachedBelongView
			};
		}

		// Token: 0x0602D4B7 RID: 185527 RVA: 0x00CAEFD4 File Offset: 0x00CAD1D4
		private void OnClickConfirm(int _)
		{
			if (this.CachedGridDataList == null)
			{
				return;
			}
			int num = 0;
			foreach (IComposePopupGridItemData composePopupGridItemData in this.CachedGridDataList)
			{
				if (composePopupGridItemData.Item.ItemId == 2)
				{
					int num2 = composePopupGridItemData.Item.Count - composePopupGridItemData.Item.SelectedCount;
					if (num2 <= 0)
					{
						break;
					}
					int num3 = 0;
					if (composePopupGridItemData.ComposeList != null)
					{
						foreach (ISelectedData selectedData in composePopupGridItemData.ComposeList)
						{
							int giftInnerCount = ComposePopupModel.Instance.GetGiftInnerCount(selectedData.ItemId, 2);
							num3 += giftInnerCount * selectedData.Count;
						}
					}
					num = num3 - num2;
					break;
				}
			}
			if (num > 0)
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.AutoSynthesisOverFlowPop);
				confirmBoxDataNew.ItemIdMap = new Dictionary<int, int>
				{
					{
						2,
						num
					}
				};
				confirmBoxDataNew.FunctionMap[2] = new Action(this.SynthesisItemBatchRequest);
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			this.SynthesisItemBatchRequest();
		}

		// Token: 0x0602D4B8 RID: 185528 RVA: 0x00CAF128 File Offset: 0x00CAD328
		private void SynthesisItemBatchRequest()
		{
			ButtonItem confirmButton = this.ConfirmButton;
			if (confirmButton != null)
			{
				confirmButton.SetEnableClick(false);
			}
			Action beforeCompose = this.BeforeCompose;
			if (beforeCompose != null)
			{
				beforeCompose();
			}
			this.SynthesisItemBatchRequestAsync().Forget();
		}

		// Token: 0x0602D4B9 RID: 185529 RVA: 0x00CAF158 File Offset: 0x00CAD358
		private UniTask SynthesisItemBatchRequestAsync()
		{
			ComposePopupView.<SynthesisItemBatchRequestAsync>d__28 <SynthesisItemBatchRequestAsync>d__;
			<SynthesisItemBatchRequestAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SynthesisItemBatchRequestAsync>d__.<>4__this = this;
			<SynthesisItemBatchRequestAsync>d__.<>1__state = -1;
			<SynthesisItemBatchRequestAsync>d__.<>t__builder.Start<ComposePopupView.<SynthesisItemBatchRequestAsync>d__28>(ref <SynthesisItemBatchRequestAsync>d__);
			return <SynthesisItemBatchRequestAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602D4BA RID: 185530 RVA: 0x00CAF19B File Offset: 0x00CAD39B
		private void OnClickCancel(int _)
		{
			base.CloseMe(null);
		}

		// Token: 0x0602D4BB RID: 185531 RVA: 0x00CAF1A4 File Offset: 0x00CAD3A4
		[return: TupleElementNames(new string[]
		{
			"Result",
			"GridDataList"
		})]
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		private ValueTuple<EDefaultCheckResult, List<IComposePopupGridItemData>> CheckDefaultComposeResult(List<ISelectedData> selectedDataList)
		{
			ValueTuple<EComposeCheckResult, List<IComposePopupGridItemData>> valueTuple = ComposePopupModel.Instance.CheckComposeResult(selectedDataList, false, false);
			if (valueTuple.Item1 == EComposeCheckResult.CanComposeAll)
			{
				return new ValueTuple<EDefaultCheckResult, List<IComposePopupGridItemData>>(EDefaultCheckResult.OnlyMaterial, valueTuple.Item2);
			}
			ValueTuple<EComposeCheckResult, List<IComposePopupGridItemData>> valueTuple2 = ComposePopupModel.Instance.CheckComposeResult(selectedDataList, true, false);
			if (valueTuple2.Item1 == EComposeCheckResult.CanComposeAll)
			{
				return new ValueTuple<EDefaultCheckResult, List<IComposePopupGridItemData>>(EDefaultCheckResult.MaterialAndGift, valueTuple2.Item2);
			}
			return new ValueTuple<EDefaultCheckResult, List<IComposePopupGridItemData>>(EDefaultCheckResult.CannotComposeAll, valueTuple2.Item2);
		}

		// Token: 0x0602D4BC RID: 185532 RVA: 0x00CAF203 File Offset: 0x00CAD403
		private List<ISelectedData> SortSelectedDataList(List<ISelectedData> selectedDataList)
		{
			selectedDataList.Sort(delegate(ISelectedData a, ISelectedData b)
			{
				bool flag = a.SelectedCount - a.Count >= 0;
				bool flag2 = b.SelectedCount - b.Count >= 0;
				if (flag && !flag2)
				{
					return 1;
				}
				if (!flag && flag2)
				{
					return -1;
				}
				return 0;
			});
			return selectedDataList;
		}

		// Token: 0x0602D4BD RID: 185533 RVA: 0x00CAF22C File Offset: 0x00CAD42C
		private List<IComposePopupGridItemData> SortGridDataList(List<IComposePopupGridItemData> gridDataList)
		{
			List<IComposePopupGridItemData> list = new List<IComposePopupGridItemData>();
			List<IComposePopupGridItemData> list2 = new List<IComposePopupGridItemData>();
			foreach (IComposePopupGridItemData composePopupGridItemData in gridDataList)
			{
				if (composePopupGridItemData.State == EGridState.Exchange)
				{
					list.Add(composePopupGridItemData);
				}
				else
				{
					list2.Add(composePopupGridItemData);
				}
			}
			list.Sort(delegate(IComposePopupGridItemData a, IComposePopupGridItemData b)
			{
				InventoryConfig instance = InventoryConfig.Instance;
				int? num3;
				if (instance == null)
				{
					num3 = null;
				}
				else
				{
					ItemConfig itemConfigData = instance.GetItemConfigData(a.Item.ItemId);
					num3 = ((itemConfigData != null) ? new int?(itemConfigData.QualityId) : null);
				}
				int? num4 = num3;
				int valueOrDefault = num4.GetValueOrDefault();
				InventoryConfig instance2 = InventoryConfig.Instance;
				int? num5;
				if (instance2 == null)
				{
					num5 = null;
				}
				else
				{
					ItemConfig itemConfigData2 = instance2.GetItemConfigData(b.Item.ItemId);
					num5 = ((itemConfigData2 != null) ? new int?(itemConfigData2.QualityId) : null);
				}
				num4 = num5;
				return num4.GetValueOrDefault() - valueOrDefault;
			});
			List<IComposePopupGridItemData> list3 = list;
			List<IComposePopupGridItemData> list4 = list2;
			int num = list3.Count + list4.Count;
			List<IComposePopupGridItemData> list5 = new List<IComposePopupGridItemData>(num);
			CollectionsMarshal.SetCount<IComposePopupGridItemData>(list5, num);
			Span<IComposePopupGridItemData> span = CollectionsMarshal.AsSpan<IComposePopupGridItemData>(list5);
			int num2 = 0;
			Span<IComposePopupGridItemData> span2 = CollectionsMarshal.AsSpan<IComposePopupGridItemData>(list3);
			span2.CopyTo(span.Slice(num2, span2.Length));
			num2 += span2.Length;
			Span<IComposePopupGridItemData> span3 = CollectionsMarshal.AsSpan<IComposePopupGridItemData>(list4);
			span3.CopyTo(span.Slice(num2, span3.Length));
			num2 += span3.Length;
			return list5;
		}

		// Token: 0x04018464 RID: 99428
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<ComposePopupGridItem, IComposePopupGridItemData> ItemScrollView;

		// Token: 0x04018465 RID: 99429
		[Nullable(2)]
		private ButtonItem CancelButton;

		// Token: 0x04018466 RID: 99430
		[Nullable(2)]
		private ButtonItem ConfirmButton;

		// Token: 0x04018467 RID: 99431
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ISelectedData> CachedSelectedItemList;

		// Token: 0x04018468 RID: 99432
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IComposePopupGridItemData> CachedGridDataList;

		// Token: 0x04018469 RID: 99433
		private bool CachedUseGift;

		// Token: 0x0401846A RID: 99434
		[Nullable(2)]
		private Action ClickConfirm;

		// Token: 0x0401846B RID: 99435
		[Nullable(2)]
		private Action BeforeCompose;

		// Token: 0x0401846C RID: 99436
		private EUiViewName? CachedBelongView;

		// Token: 0x0401846D RID: 99437
		private bool IgnoreEvent;

		// Token: 0x0200A273 RID: 41587
		[NullableContext(0)]
		public class EComp
		{
			// Token: 0x0403269B RID: 206491
			public const int TxtTitle = 0;

			// Token: 0x0403269C RID: 206492
			public const int TxtTips = 1;

			// Token: 0x0403269D RID: 206493
			public const int ItemScroll = 2;

			// Token: 0x0403269E RID: 206494
			public const int Content = 3;

			// Token: 0x0403269F RID: 206495
			public const int SynthesisItem = 4;

			// Token: 0x040326A0 RID: 206496
			public const int TogConsent = 5;

			// Token: 0x040326A1 RID: 206497
			public const int TxtConsent = 6;

			// Token: 0x040326A2 RID: 206498
			public const int BtnConfirmL = 7;

			// Token: 0x040326A3 RID: 206499
			public const int BtnConfirmR = 8;
		}
	}
}

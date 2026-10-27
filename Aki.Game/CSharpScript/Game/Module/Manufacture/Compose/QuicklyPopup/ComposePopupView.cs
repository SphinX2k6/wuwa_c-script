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
	// Token: 0x02005683 RID: 22147
	[NullableContext(1)]
	[Nullable(0)]
	public class ComposePopupView : UiViewBase
	{
		// Token: 0x060385AB RID: 230827 RVA: 0x00D60971 File Offset: 0x00D5EB71
		public ComposePopupView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060385AC RID: 230828 RVA: 0x00D6097C File Offset: 0x00D5EB7C
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

		// Token: 0x060385AD RID: 230829 RVA: 0x00D60B0A File Offset: 0x00D5ED0A
		private void OnToggleClick(EToggleState state)
		{
			this.CachedUseGift = (state == EToggleState.ETT_Checked);
			this.RefreshView();
		}

		// Token: 0x060385AE RID: 230830 RVA: 0x00D60B1C File Offset: 0x00D5ED1C
		protected override UniTask OnBeforeStartAsync()
		{
			ComposePopupView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ComposePopupView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060385AF RID: 230831 RVA: 0x00D60B60 File Offset: 0x00D5ED60
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

		// Token: 0x060385B0 RID: 230832 RVA: 0x00D60C77 File Offset: 0x00D5EE77
		protected override void OnBeforeShow()
		{
			this.RefreshView();
		}

		// Token: 0x060385B1 RID: 230833 RVA: 0x00D60C80 File Offset: 0x00D5EE80
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

		// Token: 0x060385B2 RID: 230834 RVA: 0x00D60CE4 File Offset: 0x00D5EEE4
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnItemCountChanged));
		}

		// Token: 0x060385B3 RID: 230835 RVA: 0x00D60D02 File Offset: 0x00D5EF02
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnItemCountChanged));
		}

		// Token: 0x060385B4 RID: 230836 RVA: 0x00D60D20 File Offset: 0x00D5EF20
		private void OnItemCountChanged(int i, int i1)
		{
			if (this.IgnoreEvent)
			{
				return;
			}
			this.RefreshView();
		}

		// Token: 0x060385B5 RID: 230837 RVA: 0x00D60D34 File Offset: 0x00D5EF34
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

		// Token: 0x060385B6 RID: 230838 RVA: 0x00D60DD0 File Offset: 0x00D5EFD0
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

		// Token: 0x060385B7 RID: 230839 RVA: 0x00D60DFF File Offset: 0x00D5EFFF
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

		// Token: 0x060385B8 RID: 230840 RVA: 0x00D60E34 File Offset: 0x00D5F034
		private void RefreshGiftToggleVisible()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(5);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.RootUIComp.Get().SetUIActive(ComposePopupModel.Instance.IsComposeGiftShouldShow(this.CachedSelectedItemList));
		}

		// Token: 0x060385B9 RID: 230841 RVA: 0x00D60E6F File Offset: 0x00D5F06F
		private ComposePopupGridItem InitRewardItem()
		{
			return new ComposePopupGridItem
			{
				BelongView = this.CachedBelongView
			};
		}

		// Token: 0x060385BA RID: 230842 RVA: 0x00D60E84 File Offset: 0x00D5F084
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

		// Token: 0x060385BB RID: 230843 RVA: 0x00D60FD8 File Offset: 0x00D5F1D8
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

		// Token: 0x060385BC RID: 230844 RVA: 0x00D61008 File Offset: 0x00D5F208
		private UniTask SynthesisItemBatchRequestAsync()
		{
			ComposePopupView.<SynthesisItemBatchRequestAsync>d__28 <SynthesisItemBatchRequestAsync>d__;
			<SynthesisItemBatchRequestAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SynthesisItemBatchRequestAsync>d__.<>4__this = this;
			<SynthesisItemBatchRequestAsync>d__.<>1__state = -1;
			<SynthesisItemBatchRequestAsync>d__.<>t__builder.Start<ComposePopupView.<SynthesisItemBatchRequestAsync>d__28>(ref <SynthesisItemBatchRequestAsync>d__);
			return <SynthesisItemBatchRequestAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060385BD RID: 230845 RVA: 0x00D6104B File Offset: 0x00D5F24B
		private void OnClickCancel(int _)
		{
			base.CloseMe(null);
		}

		// Token: 0x060385BE RID: 230846 RVA: 0x00D61054 File Offset: 0x00D5F254
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

		// Token: 0x060385BF RID: 230847 RVA: 0x00D610B3 File Offset: 0x00D5F2B3
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

		// Token: 0x060385C0 RID: 230848 RVA: 0x00D610DC File Offset: 0x00D5F2DC
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

		// Token: 0x0401D9D9 RID: 121305
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<ComposePopupGridItem, IComposePopupGridItemData> ItemScrollView;

		// Token: 0x0401D9DA RID: 121306
		[Nullable(2)]
		private ButtonItem CancelButton;

		// Token: 0x0401D9DB RID: 121307
		[Nullable(2)]
		private ButtonItem ConfirmButton;

		// Token: 0x0401D9DC RID: 121308
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ISelectedData> CachedSelectedItemList;

		// Token: 0x0401D9DD RID: 121309
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IComposePopupGridItemData> CachedGridDataList;

		// Token: 0x0401D9DE RID: 121310
		private bool CachedUseGift;

		// Token: 0x0401D9DF RID: 121311
		[Nullable(2)]
		private Action ClickConfirm;

		// Token: 0x0401D9E0 RID: 121312
		[Nullable(2)]
		private Action BeforeCompose;

		// Token: 0x0401D9E1 RID: 121313
		private EUiViewName? CachedBelongView;

		// Token: 0x0401D9E2 RID: 121314
		private bool IgnoreEvent;

		// Token: 0x0200B84B RID: 47179
		[NullableContext(0)]
		public class EComp
		{
			// Token: 0x04037C7E RID: 228478
			public const int TxtTitle = 0;

			// Token: 0x04037C7F RID: 228479
			public const int TxtTips = 1;

			// Token: 0x04037C80 RID: 228480
			public const int ItemScroll = 2;

			// Token: 0x04037C81 RID: 228481
			public const int Content = 3;

			// Token: 0x04037C82 RID: 228482
			public const int SynthesisItem = 4;

			// Token: 0x04037C83 RID: 228483
			public const int TogConsent = 5;

			// Token: 0x04037C84 RID: 228484
			public const int TxtConsent = 6;

			// Token: 0x04037C85 RID: 228485
			public const int BtnConfirmL = 7;

			// Token: 0x04037C86 RID: 228486
			public const int BtnConfirmR = 8;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DEB RID: 15851
	[NullableContext(2)]
	[Nullable(0)]
	public class RoguelikeSelectSpecialView : RogueSelectBaseView
	{
		// Token: 0x060287C7 RID: 165831 RVA: 0x00B599BB File Offset: 0x00B57BBB
		[NullableContext(1)]
		public RoguelikeSelectSpecialView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060287C8 RID: 165832 RVA: 0x00B599C4 File Offset: 0x00B57BC4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickRefreshButton));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickConfirmButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060287C9 RID: 165833 RVA: 0x00B59B54 File Offset: 0x00B57D54
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeSelectSpecialView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeSelectSpecialView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060287CA RID: 165834 RVA: 0x00B59B98 File Offset: 0x00B57D98
		protected override void OnStart()
		{
			this.RoguelikeChooseData = (this.OpenParam as RoguelikeChooseData);
			if (this.RoguelikeChooseData == null)
			{
				Log.Instance.Error(ELogModule.Roguelike, ELogAuthor.BB, "RoguelikeSelectSpecialView无效输入", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.SpecialItemLayout = new GenericLayout<RoguelikeSelectSpecialItem, RogueGainEntry>(base.GetHorizontalLayout(2), new Func<RoguelikeSelectSpecialItem>(this.CreateSpecialItem), null, false, true);
			RoguelikeModel.Instance.CurrentRogueGainEntry = null;
			this.TopPanel.CloseCallback = new Action(base.CloseMySelf);
			this.RefreshUi();
		}

		// Token: 0x060287CB RID: 165835 RVA: 0x00B59C27 File Offset: 0x00B57E27
		private void RefreshUi()
		{
			this.RefreshElementPanel();
			this.RefreshSpecialItemLayout();
			this.RefreshBottomPanel();
		}

		// Token: 0x060287CC RID: 165836 RVA: 0x00B59C3C File Offset: 0x00B57E3C
		private void RefreshSpecialItemLayout()
		{
			List<RogueGainEntry> rogueGainEntryList = this.RoguelikeChooseData.RogueGainEntryList;
			this.SpecialItemLayout.RefreshByData(rogueGainEntryList, null, true);
		}

		// Token: 0x060287CD RID: 165837 RVA: 0x00B59C63 File Offset: 0x00B57E63
		private void RefreshElementPanel()
		{
			this.ElementPanel.Refresh(null);
		}

		// Token: 0x060287CE RID: 165838 RVA: 0x00B59C74 File Offset: 0x00B57E74
		private void RefreshBottomPanel()
		{
			int value = this.RoguelikeChooseData.MaxTime.Value;
			int num = value - this.RoguelikeChooseData.UseTime.Value;
			UUIText text = base.GetText(7);
			if (num <= 0)
			{
				LguiUtil.Instance.SetLocalTextNew(text, "RoguelikeView_29_Text", new <>z__ReadOnlyArray<object>(new object[]
				{
					num,
					value
				}));
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(text, "RoguelikeView_28_Text", new <>z__ReadOnlyArray<object>(new object[]
				{
					num,
					value
				}));
			}
			base.GetButton(3).RootUIComp.Get().SetUIActive(value > 0);
			base.GetButton(4).SetSelfInteractive(this.CurRogueGainEntry != null);
			IReadOnlyList<NumItem> costCurrency = this.RoguelikeChooseData.CostCurrency;
			if (costCurrency.Count > 0)
			{
				NumItem numItem = costCurrency[0];
				bool flag = InventoryModel.Instance.GetItemCountByConfigId(numItem.Id, 0) >= numItem.Count;
				string textStringId = flag ? "RogueSpecialRefreshCost" : "RogueSpecialRefreshCost_Not";
				LguiUtil.Instance.SetLocalTextNew(base.GetText(6), textStringId, new <>z__ReadOnlySingleElementList<object>(numItem.Count));
				base.SetTextureByPath(RoguelikeConfig.Instance.GetRogueCurrencyConfig(numItem.Id).Value.IconSmall, base.GetTexture(5), null, null);
				base.GetButton(3).SetSelfInteractive(num > 0 && flag);
			}
		}

		// Token: 0x060287CF RID: 165839 RVA: 0x00B59E05 File Offset: 0x00B58005
		protected override void OnDescModelChange()
		{
			this.RefreshSpecialItemLayout();
		}

		// Token: 0x060287D0 RID: 165840 RVA: 0x00B59E0D File Offset: 0x00B5800D
		[NullableContext(1)]
		private RoguelikeSelectSpecialItem CreateSpecialItem()
		{
			return new RoguelikeSelectSpecialItem(new Action<RoguelikeSelectSpecialItem, RogueGainEntry>(this.OnClickRoguelikeSpecialItem));
		}

		// Token: 0x060287D1 RID: 165841 RVA: 0x00B59E20 File Offset: 0x00B58020
		private void OnClickRefreshButton()
		{
			if (this.RoguelikeChooseData.UseTime.Value >= this.RoguelikeChooseData.MaxTime.Value)
			{
				return;
			}
			RoguelikeController.Instance.RoguelikeRefreshGainRequest(this.RoguelikeChooseData.Index);
		}

		// Token: 0x060287D2 RID: 165842 RVA: 0x00B59E5A File Offset: 0x00B5805A
		private void OnClickConfirmButton()
		{
			RoguelikeModel.Instance.CurrentRogueGainEntry = this.CurRogueGainEntry;
			RoguelikeController.Instance.RogueChooseDataResultRequest(EPerkType.Special);
		}

		// Token: 0x060287D3 RID: 165843 RVA: 0x00B59E78 File Offset: 0x00B58078
		[NullableContext(1)]
		private void OnClickRoguelikeSpecialItem(RoguelikeSelectSpecialItem item, RogueGainEntry data)
		{
			if (this.CurChooseSpecialItem == item)
			{
				this.CurChooseSpecialItem = null;
				item.SetSelect(false);
				this.CurRogueGainEntry = null;
				RogueGainEntry rogueGainEntry = null;
				this.ElementPanel.Refresh(rogueGainEntry);
				this.RefreshBottomPanel();
				return;
			}
			if (this.CurChooseSpecialItem != null)
			{
				this.CurChooseSpecialItem.SetSelect(false);
			}
			this.CurChooseSpecialItem = item;
			item.SetSelect(true);
			this.CurRogueGainEntry = data;
			this.ElementPanel.Refresh(data);
			this.RefreshBottomPanel();
		}

		// Token: 0x060287D4 RID: 165844 RVA: 0x00B59EF4 File Offset: 0x00B580F4
		[NullableContext(1)]
		protected override void RoguelikeChooseDataResult(RogueGainEntry newRogueGainEntry, RogueGainEntry oldRogueGainEntry, bool isSuccess, int bindId, RoguelikeChooseDataResultResponse response)
		{
			if (isSuccess)
			{
				RoguelikeChooseData roguelikeChooseData = this.RoguelikeChooseData;
				int? num = (roguelikeChooseData != null) ? new int?(roguelikeChooseData.Index) : null;
				if (bindId == num.GetValueOrDefault() & num != null)
				{
					UiManager.Instance.CloseAndOpenView(this.ViewInfo.Name, EUiViewName.RoguelikeSpecialDetailView, new object[]
					{
						newRogueGainEntry,
						RoguelikeController.Instance.CreateCloseViewCallBack(response, delegate(bool? _)
						{
							RogueSelectResult rogueSelectResult = new RogueSelectResult(RoguelikeModel.Instance.RogueInfo.PhantomEntry, oldRogueGainEntry, null, false);
							if (rogueSelectResult.GetNewUnlockAffixEntry().Count <= 0)
							{
								return;
							}
							UiManager.Instance.OpenView(EUiViewName.CommonSelectResultView, rogueSelectResult, null);
						})
					}, null, true);
					return;
				}
			}
		}

		// Token: 0x060287D5 RID: 165845 RVA: 0x00B59F88 File Offset: 0x00B58188
		protected override void RoguelikeRefreshGain(int index)
		{
			RoguelikeModel.Instance.CurrentRogueGainEntry = null;
			RoguelikeChooseData roguelikeChooseDataById = RoguelikeModel.Instance.GetRoguelikeChooseDataById(index);
			this.RoguelikeChooseData = roguelikeChooseDataById;
			this.CurChooseSpecialItem = null;
			this.CurRogueGainEntry = null;
			this.RefreshUi();
		}

		// Token: 0x04015F9E RID: 90014
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoguelikeSelectSpecialItem, RogueGainEntry> SpecialItemLayout;

		// Token: 0x04015F9F RID: 90015
		private RoguelikeSelectSpecialItem CurChooseSpecialItem;

		// Token: 0x04015FA0 RID: 90016
		private RogueGainEntry CurRogueGainEntry;

		// Token: 0x04015FA1 RID: 90017
		private RoguelikeChooseData RoguelikeChooseData;

		// Token: 0x04015FA2 RID: 90018
		private TopPanel TopPanel;

		// Token: 0x04015FA3 RID: 90019
		private ElementPanel ElementPanel;

		// Token: 0x020099F6 RID: 39414
		[NullableContext(0)]
		private static class EComponent
		{
			// Token: 0x0402FFEA RID: 196586
			public const int TopPanelItem = 0;

			// Token: 0x0402FFEB RID: 196587
			public const int ElementPanelItem = 1;

			// Token: 0x0402FFEC RID: 196588
			public const int SpecialItemLayout = 2;

			// Token: 0x0402FFED RID: 196589
			public const int RefreshButton = 3;

			// Token: 0x0402FFEE RID: 196590
			public const int ConfirmButton = 4;

			// Token: 0x0402FFEF RID: 196591
			public const int RefreshCostTexture = 5;

			// Token: 0x0402FFF0 RID: 196592
			public const int RefreshCostText = 6;

			// Token: 0x0402FFF1 RID: 196593
			public const int RefreshTimeText = 7;
		}
	}
}

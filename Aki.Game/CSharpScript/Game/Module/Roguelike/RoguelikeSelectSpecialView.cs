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
	// Token: 0x02004E22 RID: 20002
	[NullableContext(2)]
	[Nullable(0)]
	public class RoguelikeSelectSpecialView : RogueSelectBaseView
	{
		// Token: 0x0603395C RID: 211292 RVA: 0x00C10487 File Offset: 0x00C0E687
		[NullableContext(1)]
		public RoguelikeSelectSpecialView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603395D RID: 211293 RVA: 0x00C10490 File Offset: 0x00C0E690
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

		// Token: 0x0603395E RID: 211294 RVA: 0x00C10620 File Offset: 0x00C0E820
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeSelectSpecialView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeSelectSpecialView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603395F RID: 211295 RVA: 0x00C10664 File Offset: 0x00C0E864
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

		// Token: 0x06033960 RID: 211296 RVA: 0x00C106F3 File Offset: 0x00C0E8F3
		private void RefreshUi()
		{
			this.RefreshElementPanel();
			this.RefreshSpecialItemLayout();
			this.RefreshBottomPanel();
		}

		// Token: 0x06033961 RID: 211297 RVA: 0x00C10708 File Offset: 0x00C0E908
		private void RefreshSpecialItemLayout()
		{
			List<RogueGainEntry> rogueGainEntryList = this.RoguelikeChooseData.RogueGainEntryList;
			this.SpecialItemLayout.RefreshByData(rogueGainEntryList, null, true);
		}

		// Token: 0x06033962 RID: 211298 RVA: 0x00C1072F File Offset: 0x00C0E92F
		private void RefreshElementPanel()
		{
			this.ElementPanel.Refresh(null);
		}

		// Token: 0x06033963 RID: 211299 RVA: 0x00C10740 File Offset: 0x00C0E940
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

		// Token: 0x06033964 RID: 211300 RVA: 0x00C108D1 File Offset: 0x00C0EAD1
		protected override void OnDescModelChange()
		{
			this.RefreshSpecialItemLayout();
		}

		// Token: 0x06033965 RID: 211301 RVA: 0x00C108D9 File Offset: 0x00C0EAD9
		[NullableContext(1)]
		private RoguelikeSelectSpecialItem CreateSpecialItem()
		{
			return new RoguelikeSelectSpecialItem(new Action<RoguelikeSelectSpecialItem, RogueGainEntry>(this.OnClickRoguelikeSpecialItem));
		}

		// Token: 0x06033966 RID: 211302 RVA: 0x00C108EC File Offset: 0x00C0EAEC
		private void OnClickRefreshButton()
		{
			if (this.RoguelikeChooseData.UseTime.Value >= this.RoguelikeChooseData.MaxTime.Value)
			{
				return;
			}
			RoguelikeController.Instance.RoguelikeRefreshGainRequest(this.RoguelikeChooseData.Index);
		}

		// Token: 0x06033967 RID: 211303 RVA: 0x00C10926 File Offset: 0x00C0EB26
		private void OnClickConfirmButton()
		{
			RoguelikeModel.Instance.CurrentRogueGainEntry = this.CurRogueGainEntry;
			RoguelikeController.Instance.RogueChooseDataResultRequest(EPerkType.Special);
		}

		// Token: 0x06033968 RID: 211304 RVA: 0x00C10944 File Offset: 0x00C0EB44
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

		// Token: 0x06033969 RID: 211305 RVA: 0x00C109C0 File Offset: 0x00C0EBC0
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

		// Token: 0x0603396A RID: 211306 RVA: 0x00C10A54 File Offset: 0x00C0EC54
		protected override void RoguelikeRefreshGain(int index)
		{
			RoguelikeModel.Instance.CurrentRogueGainEntry = null;
			RoguelikeChooseData roguelikeChooseDataById = RoguelikeModel.Instance.GetRoguelikeChooseDataById(index);
			this.RoguelikeChooseData = roguelikeChooseDataById;
			this.CurChooseSpecialItem = null;
			this.CurRogueGainEntry = null;
			this.RefreshUi();
		}

		// Token: 0x0401B5CB RID: 112075
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoguelikeSelectSpecialItem, RogueGainEntry> SpecialItemLayout;

		// Token: 0x0401B5CC RID: 112076
		private RoguelikeSelectSpecialItem CurChooseSpecialItem;

		// Token: 0x0401B5CD RID: 112077
		private RogueGainEntry CurRogueGainEntry;

		// Token: 0x0401B5CE RID: 112078
		private RoguelikeChooseData RoguelikeChooseData;

		// Token: 0x0401B5CF RID: 112079
		private TopPanel TopPanel;

		// Token: 0x0401B5D0 RID: 112080
		private ElementPanel ElementPanel;

		// Token: 0x0200AFC4 RID: 44996
		[NullableContext(0)]
		private static class EComponent
		{
			// Token: 0x040355BA RID: 218554
			public const int TopPanelItem = 0;

			// Token: 0x040355BB RID: 218555
			public const int ElementPanelItem = 1;

			// Token: 0x040355BC RID: 218556
			public const int SpecialItemLayout = 2;

			// Token: 0x040355BD RID: 218557
			public const int RefreshButton = 3;

			// Token: 0x040355BE RID: 218558
			public const int ConfirmButton = 4;

			// Token: 0x040355BF RID: 218559
			public const int RefreshCostTexture = 5;

			// Token: 0x040355C0 RID: 218560
			public const int RefreshCostText = 6;

			// Token: 0x040355C1 RID: 218561
			public const int RefreshTimeText = 7;
		}
	}
}

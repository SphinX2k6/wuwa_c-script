using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E27 RID: 20007
	[NullableContext(2)]
	[Nullable(0)]
	public class RoguelikeShop : UiViewBase
	{
		// Token: 0x06033980 RID: 211328 RVA: 0x00C11BF7 File Offset: 0x00C0FDF7
		[NullableContext(1)]
		public RoguelikeShop(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06033981 RID: 211329 RVA: 0x00C11C00 File Offset: 0x00C0FE00
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnBtnRefresh));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.OnBtnInfo));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06033982 RID: 211330 RVA: 0x00C11DD4 File Offset: 0x00C0FFD4
		protected override void OnAfterShow()
		{
			this.LevelSequencePlayer.PlayLevelSequenceByName("Show", false, null, false);
			this.UpdateData(this.ShopIndex);
		}

		// Token: 0x06033983 RID: 211331 RVA: 0x00C11E08 File Offset: 0x00C10008
		private void OnBtnRefresh()
		{
			IReadOnlyList<NumItem> costCurrency = this.Data.CostCurrency;
			if (costCurrency.Count > 0)
			{
				NumItem numItem = costCurrency[0];
				if (InventoryModel.Instance.GetItemCountByConfigId(numItem.Id, 0) < numItem.Count)
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("RogueSpecialRefreshCost_NotEnough", Array.Empty<object>());
					return;
				}
			}
			RoguelikeController.Instance.RoguelikeRefreshGainRequest(-1);
		}

		// Token: 0x06033984 RID: 211332 RVA: 0x00C11E70 File Offset: 0x00C10070
		private void OnBtnInfo()
		{
			RoguelikeController.Instance.OpenRogueInfoView(null, true, true, ERogueInfoViewPage.Overview);
		}

		// Token: 0x06033985 RID: 211333 RVA: 0x00C11E80 File Offset: 0x00C10080
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeShop.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeShop.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033986 RID: 211334 RVA: 0x00C11EC4 File Offset: 0x00C100C4
		protected override void OnStart()
		{
			this.ElementPanel.Refresh(null);
			this.LoopScrollView = new LoopScrollView<RogueInfoViewTokenDetailGrid, RogueGainEntry>(base.GetLoopScrollViewComponent(5), (AUIBaseActor)base.GetItem(6).GetOwner(), new Func<RogueInfoViewTokenDetailGrid>(this.OnCreateGrid), false);
			this.Data = (RoguelikeChooseData)this.OpenParam;
			this.ShopIndex = this.Data.Index;
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
			this.UpdateItemList();
			this.UpdateRefreshButton();
		}

		// Token: 0x06033987 RID: 211335 RVA: 0x00C11F4C File Offset: 0x00C1014C
		public void UpdateItemList()
		{
			List<RogueGainEntry> rogueGainEntryList = this.Data.RogueGainEntryList;
			rogueGainEntryList.Sort(delegate(RogueGainEntry a, RogueGainEntry b)
			{
				bool? isSell = a.IsSell;
				bool? isSell2 = b.IsSell;
				if (!(isSell.GetValueOrDefault() == isSell2.GetValueOrDefault() & isSell != null == (isSell2 != null)))
				{
					if (!a.IsSell.GetValueOrDefault())
					{
						return -1;
					}
					return 1;
				}
				else if (a.IsDiscounted() != b.IsDiscounted())
				{
					if (!a.IsDiscounted())
					{
						return 1;
					}
					return -1;
				}
				else
				{
					if (a.IsDiscounted() && b.IsDiscounted())
					{
						return a.CurrentPrice.Value - b.CurrentPrice.Value;
					}
					if (!a.IsDiscounted() && !b.IsDiscounted())
					{
						return a.OriginalPrice - b.OriginalPrice;
					}
					return a.Index.Value - b.Index.Value;
				}
			});
			this.LoopScrollView.RefreshByData(rogueGainEntryList, false, null, false);
			if (this.Data.RogueGainEntryList.Count > 0)
			{
				RogueGainEntry rogueGainEntry = this.Data.RogueGainEntryList[0];
				RoguelikeModel.Instance.CurrentRogueGainEntry = rogueGainEntry;
				this.LoopScrollView.SelectGridProxy(0, false);
				this.ShopDetailPanel.Refresh(rogueGainEntry);
				bool flag = InventoryModel.Instance.GetItemCountByConfigId(rogueGainEntry.ShopItemCoinId, 0) >= rogueGainEntry.CurrentPrice.Value;
				if (!rogueGainEntry.IsSell.GetValueOrDefault() && flag)
				{
					this.ElementPanel.Refresh(rogueGainEntry);
					return;
				}
				this.ElementPanel.Refresh(null);
			}
		}

		// Token: 0x06033988 RID: 211336 RVA: 0x00C12034 File Offset: 0x00C10234
		private void UpdateRefreshButton()
		{
			int value = this.Data.UseTime.Value;
			int value2 = this.Data.MaxTime.Value;
			base.GetButton(3).RootUIComp.Get().SetUIActive(value2 > 0);
			int num = value2 - value;
			UUIText text = base.GetText(4);
			if (num <= 0)
			{
				LguiUtil.Instance.SetLocalTextNew(text, "RoguelikeView_29_Text", new <>z__ReadOnlyArray<object>(new object[]
				{
					num,
					value2
				}));
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(text, "RoguelikeView_28_Text", new <>z__ReadOnlyArray<object>(new object[]
				{
					num,
					value2
				}));
			}
			IReadOnlyList<NumItem> costCurrency = this.Data.CostCurrency;
			if (costCurrency.Count > 0)
			{
				NumItem numItem = costCurrency[0];
				string textStringId = (InventoryModel.Instance.GetItemCountByConfigId(numItem.Id, 0) >= numItem.Count) ? "RogueSpecialRefreshCost" : "RogueSpecialRefreshCost_Not";
				LguiUtil.Instance.SetLocalTextNew(base.GetText(8), textStringId, new <>z__ReadOnlySingleElementList<object>(numItem.Count));
				base.SetTextureByPath(RoguelikeConfig.Instance.GetRogueCurrencyConfig(numItem.Id).Value.IconSmall, base.GetTexture(7), null, null);
			}
		}

		// Token: 0x06033989 RID: 211337 RVA: 0x00C121A0 File Offset: 0x00C103A0
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<RogueGainEntry, int>(EEventName.RoguelikeInfoSelectedToken, new Action<RogueGainEntry, int>(this.OnSelectedToken));
			EventSystem.Instance.Add<int>(EEventName.RoguelikeRefreshGain, new Action<int>(this.UpdateData));
			EventSystem.Instance.Add<RogueGainEntry, RogueGainEntry, bool, int, RoguelikeChooseDataResultResponse>(EEventName.RoguelikeChooseDataResult, new Action<RogueGainEntry, RogueGainEntry, bool, int, RoguelikeChooseDataResultResponse>(this.OnChooseData));
		}

		// Token: 0x0603398A RID: 211338 RVA: 0x00C12204 File Offset: 0x00C10404
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RoguelikeInfoSelectedToken, new Action<RogueGainEntry, int>(this.OnSelectedToken));
			EventSystem.Instance.Remove(EEventName.RoguelikeRefreshGain, new Action<int>(this.UpdateData));
			EventSystem.Instance.Remove(EEventName.RoguelikeChooseDataResult, new Action<RogueGainEntry, RogueGainEntry, bool, int, RoguelikeChooseDataResultResponse>(this.OnChooseData));
		}

		// Token: 0x0603398B RID: 211339 RVA: 0x00C12268 File Offset: 0x00C10468
		[NullableContext(1)]
		private void OnChooseData(RogueGainEntry buyToken, RogueGainEntry oldData, bool isSuccess, int index, RoguelikeChooseDataResultResponse response)
		{
			this.UpdateData(this.ShopIndex);
			PopupCaptionItem captionItem = this.CaptionItem;
			if (captionItem != null)
			{
				captionItem.SetCurrencyItemList(new int[]
				{
					80100000
				});
			}
			UiManager.Instance.OpenView(EUiViewName.CommonSelectResultView, new RogueSelectResult(RoguelikeModel.Instance.RogueInfo.PhantomEntry, oldData, buyToken, true), null);
		}

		// Token: 0x0603398C RID: 211340 RVA: 0x00C122C8 File Offset: 0x00C104C8
		[NullableContext(1)]
		private void OnSelectedToken(RogueGainEntry token, int index)
		{
			RoguelikeModel.Instance.CurrentRogueGainEntry = token;
			this.LoopScrollView.SelectGridProxy(index, false);
			this.ShopDetailPanel.Refresh(token);
			bool flag = InventoryModel.Instance.GetItemCountByConfigId(token.ShopItemCoinId, 0) >= token.CurrentPrice.Value;
			if (!token.IsSell.GetValueOrDefault() && flag)
			{
				this.ElementPanel.Refresh(token);
				return;
			}
			this.ElementPanel.Refresh(null);
		}

		// Token: 0x0603398D RID: 211341 RVA: 0x00C12348 File Offset: 0x00C10548
		protected override void OnBeforeHide()
		{
			this.LevelSequencePlayer.PlayLevelSequenceByName("Hide", false, null, false);
		}

		// Token: 0x0603398E RID: 211342 RVA: 0x00C12370 File Offset: 0x00C10570
		private void UpdateData(int index)
		{
			this.ShopIndex = index;
			this.Data = RoguelikeModel.Instance.GetRoguelikeChooseDataById(index);
			this.UpdateItemList();
			this.UpdateRefreshButton();
		}

		// Token: 0x0603398F RID: 211343 RVA: 0x00C12396 File Offset: 0x00C10596
		[NullableContext(1)]
		private RogueInfoViewTokenDetailGrid OnCreateGrid()
		{
			return new RogueInfoViewTokenDetailGrid();
		}

		// Token: 0x0401B5E1 RID: 112097
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public LoopScrollView<RogueInfoViewTokenDetailGrid, RogueGainEntry> LoopScrollView;

		// Token: 0x0401B5E2 RID: 112098
		public ElementPanel ElementPanel;

		// Token: 0x0401B5E3 RID: 112099
		public RoguelikeShopDetail ShopDetailPanel;

		// Token: 0x0401B5E4 RID: 112100
		public RoguelikeChooseData Data;

		// Token: 0x0401B5E5 RID: 112101
		public int ShopIndex;

		// Token: 0x0401B5E6 RID: 112102
		public LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401B5E7 RID: 112103
		public PopupCaptionItem CaptionItem;

		// Token: 0x0200AFD0 RID: 45008
		[NullableContext(0)]
		public class ERoguelikeShopDefine
		{
			// Token: 0x040355FB RID: 218619
			public const int CaptionItem = 0;

			// Token: 0x040355FC RID: 218620
			public const int PanelInfo = 1;

			// Token: 0x040355FD RID: 218621
			public const int ElementPanel = 2;

			// Token: 0x040355FE RID: 218622
			public const int BtnRefresh = 3;

			// Token: 0x040355FF RID: 218623
			public const int TxtRefresh = 4;

			// Token: 0x04035600 RID: 218624
			public const int LoopView = 5;

			// Token: 0x04035601 RID: 218625
			public const int LoopViewItem = 6;

			// Token: 0x04035602 RID: 218626
			public const int RefreshItemIcon = 7;

			// Token: 0x04035603 RID: 218627
			public const int RefreshText = 8;

			// Token: 0x04035604 RID: 218628
			public const int BtnInfo = 9;
		}
	}
}

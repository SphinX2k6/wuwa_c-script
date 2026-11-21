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
	// Token: 0x02003DF0 RID: 15856
	[NullableContext(2)]
	[Nullable(0)]
	public class RoguelikeShop : UiViewBase
	{
		// Token: 0x060287EB RID: 165867 RVA: 0x00B5B12B File Offset: 0x00B5932B
		[NullableContext(1)]
		public RoguelikeShop(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060287EC RID: 165868 RVA: 0x00B5B134 File Offset: 0x00B59334
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

		// Token: 0x060287ED RID: 165869 RVA: 0x00B5B308 File Offset: 0x00B59508
		protected override void OnAfterShow()
		{
			this.LevelSequencePlayer.PlayLevelSequenceByName("Show", false, null, false);
			this.UpdateData(this.ShopIndex);
		}

		// Token: 0x060287EE RID: 165870 RVA: 0x00B5B33C File Offset: 0x00B5953C
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

		// Token: 0x060287EF RID: 165871 RVA: 0x00B5B3A4 File Offset: 0x00B595A4
		private void OnBtnInfo()
		{
			RoguelikeController.Instance.OpenRogueInfoView(null, true, true, ERogueInfoViewPage.Overview);
		}

		// Token: 0x060287F0 RID: 165872 RVA: 0x00B5B3B4 File Offset: 0x00B595B4
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeShop.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeShop.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060287F1 RID: 165873 RVA: 0x00B5B3F8 File Offset: 0x00B595F8
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

		// Token: 0x060287F2 RID: 165874 RVA: 0x00B5B480 File Offset: 0x00B59680
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

		// Token: 0x060287F3 RID: 165875 RVA: 0x00B5B568 File Offset: 0x00B59768
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

		// Token: 0x060287F4 RID: 165876 RVA: 0x00B5B6D4 File Offset: 0x00B598D4
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<RogueGainEntry, int>(EEventName.RoguelikeInfoSelectedToken, new Action<RogueGainEntry, int>(this.OnSelectedToken));
			EventSystem.Instance.Add<int>(EEventName.RoguelikeRefreshGain, new Action<int>(this.UpdateData));
			EventSystem.Instance.Add<RogueGainEntry, RogueGainEntry, bool, int, RoguelikeChooseDataResultResponse>(EEventName.RoguelikeChooseDataResult, new Action<RogueGainEntry, RogueGainEntry, bool, int, RoguelikeChooseDataResultResponse>(this.OnChooseData));
		}

		// Token: 0x060287F5 RID: 165877 RVA: 0x00B5B738 File Offset: 0x00B59938
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RoguelikeInfoSelectedToken, new Action<RogueGainEntry, int>(this.OnSelectedToken));
			EventSystem.Instance.Remove(EEventName.RoguelikeRefreshGain, new Action<int>(this.UpdateData));
			EventSystem.Instance.Remove(EEventName.RoguelikeChooseDataResult, new Action<RogueGainEntry, RogueGainEntry, bool, int, RoguelikeChooseDataResultResponse>(this.OnChooseData));
		}

		// Token: 0x060287F6 RID: 165878 RVA: 0x00B5B79C File Offset: 0x00B5999C
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

		// Token: 0x060287F7 RID: 165879 RVA: 0x00B5B7FC File Offset: 0x00B599FC
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

		// Token: 0x060287F8 RID: 165880 RVA: 0x00B5B87C File Offset: 0x00B59A7C
		protected override void OnBeforeHide()
		{
			this.LevelSequencePlayer.PlayLevelSequenceByName("Hide", false, null, false);
		}

		// Token: 0x060287F9 RID: 165881 RVA: 0x00B5B8A4 File Offset: 0x00B59AA4
		private void UpdateData(int index)
		{
			this.ShopIndex = index;
			this.Data = RoguelikeModel.Instance.GetRoguelikeChooseDataById(index);
			this.UpdateItemList();
			this.UpdateRefreshButton();
		}

		// Token: 0x060287FA RID: 165882 RVA: 0x00B5B8CA File Offset: 0x00B59ACA
		[NullableContext(1)]
		private RogueInfoViewTokenDetailGrid OnCreateGrid()
		{
			return new RogueInfoViewTokenDetailGrid();
		}

		// Token: 0x04015FB4 RID: 90036
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public LoopScrollView<RogueInfoViewTokenDetailGrid, RogueGainEntry> LoopScrollView;

		// Token: 0x04015FB5 RID: 90037
		public ElementPanel ElementPanel;

		// Token: 0x04015FB6 RID: 90038
		public RoguelikeShopDetail ShopDetailPanel;

		// Token: 0x04015FB7 RID: 90039
		public RoguelikeChooseData Data;

		// Token: 0x04015FB8 RID: 90040
		public int ShopIndex;

		// Token: 0x04015FB9 RID: 90041
		public LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04015FBA RID: 90042
		public PopupCaptionItem CaptionItem;

		// Token: 0x02009A02 RID: 39426
		[NullableContext(0)]
		public class ERoguelikeShopDefine
		{
			// Token: 0x0403002B RID: 196651
			public const int CaptionItem = 0;

			// Token: 0x0403002C RID: 196652
			public const int PanelInfo = 1;

			// Token: 0x0403002D RID: 196653
			public const int ElementPanel = 2;

			// Token: 0x0403002E RID: 196654
			public const int BtnRefresh = 3;

			// Token: 0x0403002F RID: 196655
			public const int TxtRefresh = 4;

			// Token: 0x04030030 RID: 196656
			public const int LoopView = 5;

			// Token: 0x04030031 RID: 196657
			public const int LoopViewItem = 6;

			// Token: 0x04030032 RID: 196658
			public const int RefreshItemIcon = 7;

			// Token: 0x04030033 RID: 196659
			public const int RefreshText = 8;

			// Token: 0x04030034 RID: 196660
			public const int BtnInfo = 9;
		}
	}
}

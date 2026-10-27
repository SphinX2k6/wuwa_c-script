using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf.Collections;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200615D RID: 24925
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeGameShopView : RoverlikeActionViewBase
	{
		// Token: 0x0603EFEF RID: 258031 RVA: 0x00F37B07 File Offset: 0x00F35D07
		public RoverlikeGameShopView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603EFF0 RID: 258032 RVA: 0x00F37B10 File Offset: 0x00F35D10
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickBtnFunctionTitle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603EFF1 RID: 258033 RVA: 0x00F37C3C File Offset: 0x00F35E3C
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeGameShopView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeGameShopView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603EFF2 RID: 258034 RVA: 0x00F37C80 File Offset: 0x00F35E80
		protected override void OnStart()
		{
			RoverRogueShopSnapshot roverRogueShopSnapshot = this.OpenParam as RoverRogueShopSnapshot;
			if (roverRogueShopSnapshot == null)
			{
				return;
			}
			this.RefreshBySnapshot(roverRogueShopSnapshot);
			EventSystem.Instance.Add<RoverRogueShopSnapshot>(EEventName.RoverlikeShopInfoUpdate, new Action<RoverRogueShopSnapshot>(this.OnShopInfoUpdate));
			EventSystem.Instance.Add<int>(EEventName.OnPlayerCurrencyChange, new Action<int>(this.OnCurrencyChange));
		}

		// Token: 0x0603EFF3 RID: 258035 RVA: 0x00F37CDC File Offset: 0x00F35EDC
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove<RoverRogueShopSnapshot>(EEventName.RoverlikeShopInfoUpdate, new Action<RoverRogueShopSnapshot>(this.OnShopInfoUpdate));
			EventSystem.Instance.Remove<int>(EEventName.OnPlayerCurrencyChange, new Action<int>(this.OnCurrencyChange));
			this.CurrentSnapshot = null;
			this.SelectedIncId = 0;
			this.SelectedGroupType = null;
		}

		// Token: 0x0603EFF4 RID: 258036 RVA: 0x00F37D3B File Offset: 0x00F35F3B
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603EFF5 RID: 258037 RVA: 0x00F37D44 File Offset: 0x00F35F44
		private void OnCurrencyChange(int itemId)
		{
			if (itemId != this.InsideCurrencyItemId)
			{
				return;
			}
			if (this.CurrentSnapshot != null)
			{
				this.RefreshBySnapshot(this.CurrentSnapshot);
			}
		}

		// Token: 0x0603EFF6 RID: 258038 RVA: 0x00F37D64 File Offset: 0x00F35F64
		private void OnShopInfoUpdate(RoverRogueShopSnapshot snapshot)
		{
			this.RefreshBySnapshot(snapshot);
			ScrollingTipsController.Instance.ShowTipsByTextId("RoverRogue_RefreshSuccess", Array.Empty<object>());
		}

		// Token: 0x0603EFF7 RID: 258039 RVA: 0x00F37D84 File Offset: 0x00F35F84
		private void OnClickBtnFunctionTitle()
		{
			RoverlikeController.Instance.OpenGameInfoView(null);
		}

		// Token: 0x0603EFF8 RID: 258040 RVA: 0x00F37DA4 File Offset: 0x00F35FA4
		private void OnGridSelected(IRoverlikeGameShopGridData data)
		{
			if (this.SelectedIncId == data.IncId)
			{
				RoverlikeGameShopInfoItem infoPanel = this.InfoPanel;
				if (infoPanel == null)
				{
					return;
				}
				infoPanel.Refresh(data);
				return;
			}
			else
			{
				if (this.SelectedGroupType != null && this.SelectedIncId != 0)
				{
					GenericScrollViewNew<RoverlikeGameShopGroupItem, IRoverlikeGameShopGroupData> shopScrollView = this.ShopScrollView;
					if (shopScrollView != null)
					{
						RoverlikeGameShopGroupItem scrollItemByKey = shopScrollView.GetScrollItemByKey(this.SelectedGroupType.Value);
						if (scrollItemByKey != null)
						{
							scrollItemByKey.SetGridSelected(this.SelectedIncId, false);
						}
					}
				}
				this.SelectedIncId = data.IncId;
				this.SelectedGroupType = new ERoverlikeGameShopItemType?(data.Type);
				RoverlikeGameShopInfoItem infoPanel2 = this.InfoPanel;
				if (infoPanel2 == null)
				{
					return;
				}
				infoPanel2.Refresh(data);
				return;
			}
		}

		// Token: 0x0603EFF9 RID: 258041 RVA: 0x00F37E47 File Offset: 0x00F36047
		private void OnConfirmBuy()
		{
			base.TryInteractAction(delegate
			{
				if (this.SelectedIncId == 0)
				{
					return;
				}
				RoverlikeActivityData currentActivityData = RoverlikeActivityController.Instance.GetCurrentActivityData();
				if (currentActivityData == null)
				{
					return;
				}
				int buyIncId = this.SelectedIncId;
				int currentCurrencyCount = this.GetCurrentCurrencyCount();
				int? num = null;
				int? num2 = null;
				RoverRogueShopSnapshot currentSnapshot = this.CurrentSnapshot;
				foreach (RoverRogueShopGood roverRogueShopGood in (((currentSnapshot != null) ? currentSnapshot.Goods : null) ?? new RepeatedField<RoverRogueShopGood>()))
				{
					if (roverRogueShopGood.IncId == buyIncId)
					{
						num = new int?(roverRogueShopGood.FinalPrice);
						num2 = new int?(roverRogueShopGood.ShowItemId);
						break;
					}
				}
				if (num != null && num2 != null)
				{
					int? num3 = num;
					int num4 = currentCurrencyCount;
					if (!(num3.GetValueOrDefault() > num4 & num3 != null))
					{
						int obtainShowItemId = num2.Value;
						RoverlikeController.Instance.RoverRogueShopBuyRequest(currentActivityData.Id, buyIncId, delegate(bool success)
						{
							if (!success)
							{
								return;
							}
							this.ApplyBuyLocally(buyIncId);
							RoverRogueItem? itemConfig = RoverlikeConfig.Instance.GetItemConfig(obtainShowItemId);
							if (itemConfig == null)
							{
								return;
							}
							if (itemConfig.Value.Classify != 2)
							{
								return;
							}
							if (!itemConfig.Value.ShowObtain)
							{
								return;
							}
							RoverlikeInstanceData instanceData = RoverlikeModel.Instance.InstanceData;
							RoverlikeGainEntry roverlikeGainEntry = (instanceData != null) ? instanceData.GetGainByIncId(buyIncId) : null;
							if (roverlikeGainEntry == null)
							{
								return;
							}
							IRoverlikeGeneralObtainParam param = new RoverlikeGeneralObtainParam
							{
								Entries = new List<RoverlikeGainEntry>
								{
									roverlikeGainEntry
								},
								IsLose = false
							};
							RoverlikeController.Instance.OpenRoverlikeGeneralObtainView(param);
						});
						return;
					}
				}
				ScrollingTipsController.Instance.ShowTipsByTextId("RoverRogue_InsufficientFund", Array.Empty<object>());
			});
		}

		// Token: 0x0603EFFA RID: 258042 RVA: 0x00F37E5C File Offset: 0x00F3605C
		private void OnRefreshShop()
		{
			base.TryInteractAction(delegate
			{
				RoverlikeActivityData currentActivityData = RoverlikeActivityController.Instance.GetCurrentActivityData();
				if (currentActivityData == null)
				{
					return;
				}
				if (this.CurrentSnapshot == null)
				{
					return;
				}
				int currentCurrencyCount = this.GetCurrentCurrencyCount();
				if (this.CurrentSnapshot.MaxRefreshCount <= 0 || this.CurrentSnapshot.NextRefreshCost > currentCurrencyCount)
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("RoverRogue_InsufficientFund", Array.Empty<object>());
					return;
				}
				RoverlikeController.Instance.RoverRogueShopRefreshRequest(currentActivityData.Id, delegate(RoverRogueShopSnapshot snapshot)
				{
					if (snapshot == null)
					{
						return;
					}
					this.RefreshBySnapshot(snapshot);
				});
			});
		}

		// Token: 0x0603EFFB RID: 258043 RVA: 0x00F37E71 File Offset: 0x00F36071
		private RoverlikeGameShopGroupItem CreateShopGroupItem()
		{
			RoverlikeGameShopGroupItem roverlikeGameShopGroupItem = new RoverlikeGameShopGroupItem();
			roverlikeGameShopGroupItem.BindOnGridSelect(new Action<IRoverlikeGameShopGridData>(this.OnGridSelected));
			roverlikeGameShopGroupItem.BindOnGridsRefreshed(new Action<ERoverlikeGameShopItemType>(this.OnGroupGridsRefreshed));
			return roverlikeGameShopGroupItem;
		}

		// Token: 0x0603EFFC RID: 258044 RVA: 0x00F37E9C File Offset: 0x00F3609C
		private void OnGroupGridsRefreshed(ERoverlikeGameShopItemType groupType)
		{
			if (this.SelectedIncId != 0)
			{
				ERoverlikeGameShopItemType? selectedGroupType = this.SelectedGroupType;
				if (selectedGroupType.GetValueOrDefault() == groupType & selectedGroupType != null)
				{
					GenericScrollViewNew<RoverlikeGameShopGroupItem, IRoverlikeGameShopGroupData> shopScrollView = this.ShopScrollView;
					UUIItem uuiitem;
					if (shopScrollView == null)
					{
						uuiitem = null;
					}
					else
					{
						RoverlikeGameShopGroupItem scrollItemByKey = shopScrollView.GetScrollItemByKey(groupType);
						uuiitem = ((scrollItemByKey != null) ? scrollItemByKey.GetGridNavigationItem(this.SelectedIncId) : null);
					}
					UUIItem uuiitem2 = uuiitem;
					if (uuiitem2 == null)
					{
						return;
					}
					UiNavigationNewController.Instance.SetNavigationFocusForView(uuiitem2, true, false, false);
					return;
				}
			}
		}

		// Token: 0x0603EFFD RID: 258045 RVA: 0x00F37F10 File Offset: 0x00F36110
		private void RefreshBySnapshot(RoverRogueShopSnapshot snapshot)
		{
			this.CurrentSnapshot = snapshot;
			List<IRoverlikeGameShopGroupData> list = this.BuildGroupDataList(snapshot);
			this.FallbackSelection(list);
			this.StampSelection(list);
			this.ShopScrollView.RefreshByData(list, null, false);
			RoverlikeGameShopInfoItem infoPanel = this.InfoPanel;
			if (infoPanel != null)
			{
				infoPanel.Refresh(this.GetSelectedGridData(list));
			}
			int currentCurrencyCount = this.GetCurrentCurrencyCount();
			bool flag = snapshot.MaxRefreshCount > 0;
			RoverlikeGameShopRefreshItem refreshBtn = this.RefreshBtn;
			if (refreshBtn != null)
			{
				refreshBtn.SetUiActive(flag);
			}
			if (flag)
			{
				RoverlikeGameShopRefreshItem refreshBtn2 = this.RefreshBtn;
				if (refreshBtn2 == null)
				{
					return;
				}
				refreshBtn2.Refresh(snapshot.NextRefreshCost, snapshot.RefreshCount, snapshot.MaxRefreshCount, this.InsideCurrencyItemId, currentCurrencyCount);
			}
		}

		// Token: 0x0603EFFE RID: 258046 RVA: 0x00F37FB0 File Offset: 0x00F361B0
		private void StampSelection(List<IRoverlikeGameShopGroupData> groups)
		{
			foreach (IRoverlikeGameShopGroupData roverlikeGameShopGroupData in groups)
			{
				foreach (IRoverlikeGameShopGridData roverlikeGameShopGridData in roverlikeGameShopGroupData.Grids)
				{
					roverlikeGameShopGridData.IsSelected = (roverlikeGameShopGridData.IncId == this.SelectedIncId);
				}
			}
		}

		// Token: 0x0603EFFF RID: 258047 RVA: 0x00F38044 File Offset: 0x00F36244
		private List<IRoverlikeGameShopGroupData> BuildGroupDataList(RoverRogueShopSnapshot snapshot)
		{
			List<IShopGridSortInfo> list = new List<IShopGridSortInfo>();
			List<IShopGridSortInfo> list2 = new List<IShopGridSortInfo>();
			RepeatedField<RoverRogueShopGood> repeatedField = snapshot.Goods ?? new RepeatedField<RoverRogueShopGood>();
			int num = 0;
			foreach (RoverRogueShopGood roverRogueShopGood in repeatedField)
			{
				RoverRogueItem? itemConfig = RoverlikeConfig.Instance.GetItemConfig(roverRogueShopGood.ShowItemId);
				if (itemConfig != null)
				{
					int classify = itemConfig.Value.Classify;
					IRoverlikeGameShopGridData data = new RoverlikeGameShopGridData
					{
						IncId = roverRogueShopGood.IncId,
						ShowItemId = roverRogueShopGood.ShowItemId,
						Type = (ERoverlikeGameShopItemType)classify,
						FinalPrice = roverRogueShopGood.FinalPrice,
						OriginalPrice = roverRogueShopGood.Price,
						IsBought = roverRogueShopGood.IsBought,
						IsSelected = false
					};
					IShopGridSortInfo item = new ShopGridSortInfo
					{
						Data = data,
						OriginalIndex = num
					};
					if (classify == 2)
					{
						list2.Add(item);
					}
					else
					{
						list.Add(item);
					}
					num++;
				}
			}
			List<IRoverlikeGameShopGridData> list3 = this.SortGroupGrids(list);
			List<IRoverlikeGameShopGridData> list4 = this.SortGroupGrids(list2);
			List<IRoverlikeGameShopGroupData> list5 = new List<IRoverlikeGameShopGroupData>();
			if (list3.Count > 0)
			{
				IRoverlikeGameShopGroupData item2 = new RoverlikeGameShopGroupData
				{
					GroupType = ERoverlikeGameShopItemType.Preview,
					TitleTextKey = "RoverRogue_BlessingWithEnhance",
					Grids = list3
				};
				list5.Add(item2);
			}
			if (list4.Count > 0)
			{
				IRoverlikeGameShopGroupData item3 = new RoverlikeGameShopGroupData
				{
					GroupType = ERoverlikeGameShopItemType.Item,
					TitleTextKey = "RoverRogue_ShopItem",
					Grids = list4
				};
				list5.Add(item3);
			}
			return list5;
		}

		// Token: 0x0603F000 RID: 258048 RVA: 0x00F381E8 File Offset: 0x00F363E8
		private List<IRoverlikeGameShopGridData> SortGroupGrids(List<IShopGridSortInfo> list)
		{
			List<IShopGridSortInfo> list2 = new List<IShopGridSortInfo>(list);
			list2.Sort(delegate(IShopGridSortInfo a, IShopGridSortInfo b)
			{
				if (a.Data.IsBought != b.Data.IsBought)
				{
					if (!a.Data.IsBought)
					{
						return -1;
					}
					return 1;
				}
				else
				{
					bool flag = a.Data.OriginalPrice != a.Data.FinalPrice;
					bool flag2 = b.Data.OriginalPrice != b.Data.FinalPrice;
					if (flag == flag2)
					{
						if (flag && flag2)
						{
							if (a.Data.FinalPrice != b.Data.FinalPrice)
							{
								return a.Data.FinalPrice - b.Data.FinalPrice;
							}
						}
						else if (a.Data.OriginalPrice != b.Data.OriginalPrice)
						{
							return a.Data.OriginalPrice - b.Data.OriginalPrice;
						}
						return a.OriginalIndex - b.OriginalIndex;
					}
					if (!flag)
					{
						return 1;
					}
					return -1;
				}
			});
			List<IRoverlikeGameShopGridData> list3 = new List<IRoverlikeGameShopGridData>();
			foreach (IShopGridSortInfo shopGridSortInfo in list2)
			{
				list3.Add(shopGridSortInfo.Data);
			}
			return list3;
		}

		// Token: 0x0603F001 RID: 258049 RVA: 0x00F3826C File Offset: 0x00F3646C
		private void FallbackSelection(List<IRoverlikeGameShopGroupData> groups)
		{
			List<IRoverlikeGameShopGridData> list = new List<IRoverlikeGameShopGridData>();
			foreach (IRoverlikeGameShopGroupData roverlikeGameShopGroupData in groups)
			{
				foreach (IRoverlikeGameShopGridData item in roverlikeGameShopGroupData.Grids)
				{
					list.Add(item);
				}
			}
			if (list.Count == 0)
			{
				this.SelectedIncId = 0;
				this.SelectedGroupType = null;
				return;
			}
			if (this.SelectedIncId != 0)
			{
				foreach (IRoverlikeGameShopGridData roverlikeGameShopGridData in list)
				{
					if (roverlikeGameShopGridData.IncId == this.SelectedIncId && !roverlikeGameShopGridData.IsBought)
					{
						this.SelectedGroupType = new ERoverlikeGameShopItemType?(roverlikeGameShopGridData.Type);
						return;
					}
				}
			}
			foreach (IRoverlikeGameShopGridData roverlikeGameShopGridData2 in list)
			{
				if (!roverlikeGameShopGridData2.IsBought)
				{
					this.SelectedIncId = roverlikeGameShopGridData2.IncId;
					this.SelectedGroupType = new ERoverlikeGameShopItemType?(roverlikeGameShopGridData2.Type);
					return;
				}
			}
			IRoverlikeGameShopGridData roverlikeGameShopGridData3 = list[0];
			this.SelectedIncId = roverlikeGameShopGridData3.IncId;
			this.SelectedGroupType = new ERoverlikeGameShopItemType?(roverlikeGameShopGridData3.Type);
		}

		// Token: 0x0603F002 RID: 258050 RVA: 0x00F3840C File Offset: 0x00F3660C
		[return: Nullable(2)]
		private IRoverlikeGameShopGridData GetSelectedGridData(List<IRoverlikeGameShopGroupData> groups)
		{
			if (this.SelectedIncId == 0)
			{
				return null;
			}
			foreach (IRoverlikeGameShopGroupData roverlikeGameShopGroupData in groups)
			{
				foreach (IRoverlikeGameShopGridData roverlikeGameShopGridData in roverlikeGameShopGroupData.Grids)
				{
					if (roverlikeGameShopGridData.IncId == this.SelectedIncId)
					{
						return roverlikeGameShopGridData;
					}
				}
			}
			return null;
		}

		// Token: 0x0603F003 RID: 258051 RVA: 0x00F384AC File Offset: 0x00F366AC
		private void ApplyBuyLocally(int incId)
		{
			RoverRogueShopSnapshot currentSnapshot = this.CurrentSnapshot;
			if (currentSnapshot == null)
			{
				return;
			}
			foreach (RoverRogueShopGood roverRogueShopGood in (currentSnapshot.Goods ?? new RepeatedField<RoverRogueShopGood>()))
			{
				if (roverRogueShopGood.IncId == incId)
				{
					roverRogueShopGood.IsBought = true;
					break;
				}
			}
			RepeatedField<int> repeatedField = currentSnapshot.BoughtIncIds ?? new RepeatedField<int>();
			bool flag = false;
			using (IEnumerator<int> enumerator2 = repeatedField.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					if (enumerator2.Current == incId)
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				repeatedField.Add(incId);
			}
			this.RefreshBySnapshot(currentSnapshot);
		}

		// Token: 0x0603F004 RID: 258052 RVA: 0x00F3857C File Offset: 0x00F3677C
		private int GetCurrentCurrencyCount()
		{
			return RoverlikeModel.Instance.Gold;
		}

		// Token: 0x04020DEA RID: 134634
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04020DEB RID: 134635
		[Nullable(2)]
		private RoverlikeGameShopInfoItem InfoPanel;

		// Token: 0x04020DEC RID: 134636
		[Nullable(2)]
		private RoverlikeGameShopRefreshItem RefreshBtn;

		// Token: 0x04020DED RID: 134637
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<RoverlikeGameShopGroupItem, IRoverlikeGameShopGroupData> ShopScrollView;

		// Token: 0x04020DEE RID: 134638
		[Nullable(2)]
		private RoverRogueShopSnapshot CurrentSnapshot;

		// Token: 0x04020DEF RID: 134639
		private int SelectedIncId;

		// Token: 0x04020DF0 RID: 134640
		private ERoverlikeGameShopItemType? SelectedGroupType;

		// Token: 0x04020DF1 RID: 134641
		private int InsideCurrencyItemId;

		// Token: 0x0200C3BA RID: 50106
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403B0FC RID: 241916
			public const int ItemCaption = 0;

			// Token: 0x0403B0FD RID: 241917
			public const int BtnFunctionTitle = 1;

			// Token: 0x0403B0FE RID: 241918
			public const int ItemInfo = 2;

			// Token: 0x0403B0FF RID: 241919
			public const int ShopScrollView = 3;

			// Token: 0x0403B100 RID: 241920
			public const int ItemShopGroup = 4;

			// Token: 0x0403B101 RID: 241921
			public const int ItemRefresh = 5;
		}
	}
}

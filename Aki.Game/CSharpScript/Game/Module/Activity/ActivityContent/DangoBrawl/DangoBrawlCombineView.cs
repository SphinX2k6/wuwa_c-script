using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf.Collections;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067EC RID: 26604
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlCombineView : UiViewBase
	{
		// Token: 0x0604247F RID: 271487 RVA: 0x01016E68 File Offset: 0x01015068
		[NullableContext(1)]
		public DangoBrawlCombineView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06042480 RID: 271488 RVA: 0x01016EB8 File Offset: 0x010150B8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBtnClickClose));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06042481 RID: 271489 RVA: 0x01016FC4 File Offset: 0x010151C4
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlCombineView.<OnBeforeStartAsync>d__25 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlCombineView.<OnBeforeStartAsync>d__25>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042482 RID: 271490 RVA: 0x01017007 File Offset: 0x01015207
		private void OnBtnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x06042483 RID: 271491 RVA: 0x01017010 File Offset: 0x01015210
		private UniTask CreateOutBackpackPreview(int configId)
		{
			DangoBrawlCombineView.<CreateOutBackpackPreview>d__27 <CreateOutBackpackPreview>d__;
			<CreateOutBackpackPreview>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateOutBackpackPreview>d__.<>4__this = this;
			<CreateOutBackpackPreview>d__.configId = configId;
			<CreateOutBackpackPreview>d__.<>1__state = -1;
			<CreateOutBackpackPreview>d__.<>t__builder.Start<DangoBrawlCombineView.<CreateOutBackpackPreview>d__27>(ref <CreateOutBackpackPreview>d__);
			return <CreateOutBackpackPreview>d__.<>t__builder.Task;
		}

		// Token: 0x06042484 RID: 271492 RVA: 0x0101705C File Offset: 0x0101525C
		private UniTask RefreshOutBackpackPreviewAsync(int configId)
		{
			DangoBrawlCombineView.<RefreshOutBackpackPreviewAsync>d__28 <RefreshOutBackpackPreviewAsync>d__;
			<RefreshOutBackpackPreviewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshOutBackpackPreviewAsync>d__.<>4__this = this;
			<RefreshOutBackpackPreviewAsync>d__.configId = configId;
			<RefreshOutBackpackPreviewAsync>d__.<>1__state = -1;
			<RefreshOutBackpackPreviewAsync>d__.<>t__builder.Start<DangoBrawlCombineView.<RefreshOutBackpackPreviewAsync>d__28>(ref <RefreshOutBackpackPreviewAsync>d__);
			return <RefreshOutBackpackPreviewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042485 RID: 271493 RVA: 0x010170A8 File Offset: 0x010152A8
		[NullableContext(1)]
		private void ApplyPreviewScale(DangoBrawlOutBackpackItemBase panel, int configId)
		{
			DangoBrawlItem? dangoBrawlItemById = DangoBrawlConfig.Instance.GetDangoBrawlItemById(configId);
			float num = (dangoBrawlItemById != null) ? dangoBrawlItemById.GetValueOrDefault().IconCombineScale : 1f;
			UUIItem rootItem = panel.GetRootItem();
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetRelativeScale3D(new FVector(num, num, num));
		}

		// Token: 0x06042486 RID: 271494 RVA: 0x010170FC File Offset: 0x010152FC
		private UniTask CreateItemTips()
		{
			DangoBrawlCombineView.<CreateItemTips>d__30 <CreateItemTips>d__;
			<CreateItemTips>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateItemTips>d__.<>4__this = this;
			<CreateItemTips>d__.<>1__state = -1;
			<CreateItemTips>d__.<>t__builder.Start<DangoBrawlCombineView.<CreateItemTips>d__30>(ref <CreateItemTips>d__);
			return <CreateItemTips>d__.<>t__builder.Task;
		}

		// Token: 0x06042487 RID: 271495 RVA: 0x01017140 File Offset: 0x01015340
		private void RefreshItemTips(int itemId)
		{
			if (this.ItemTips == null)
			{
				return;
			}
			this.ItemTips.RefreshAndShow(new DangoBrawlItemTipsData
			{
				ItemId = itemId,
				From = EDangoBrawlItemTipsFrom.Fixed,
				ShowCombine = new bool?(itemId != this.FocusItemId && DangoBrawlCombineUtil.HasCombineInfo(itemId)),
				OperationMode = EDangoBrawlTipsOperationMode.None
			}).Forget();
		}

		// Token: 0x06042488 RID: 271496 RVA: 0x010171A0 File Offset: 0x010153A0
		private void SwitchCombineFocus(int itemId)
		{
			if (itemId <= 0 || itemId == this.FocusItemId)
			{
				return;
			}
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null)
			{
				uiViewSequence.PlayOrReplaySequenceByName("Switch02", false, null);
			}
			this.FocusItemId = itemId;
			this.FocusUid = 0;
			this.SelectedItemId = itemId;
			this.ShowIntoSelf = true;
			this.ShowSelfIntoOther = true;
			this.InitAllTitleDataList();
			this.RefreshTitleItemsAsync().Forget();
			this.RefreshItemTips(itemId);
			this.RefreshOutBackpackPreviewAsync(itemId).Forget();
		}

		// Token: 0x06042489 RID: 271497 RVA: 0x01017224 File Offset: 0x01015424
		private void InitAllTitleDataList()
		{
			List<DangoBrawlCombineRowData> list = new List<DangoBrawlCombineRowData>();
			List<DangoBrawlCombineRowData> list2 = new List<DangoBrawlCombineRowData>();
			foreach (DangoBrawlCombineRowData dangoBrawlCombineRowData in this.BuildAllCombineRows())
			{
				if (dangoBrawlCombineRowData.ResultItemId == this.FocusItemId)
				{
					list.Add(dangoBrawlCombineRowData);
				}
				else
				{
					list2.Add(dangoBrawlCombineRowData);
				}
			}
			List<DangoBrawlCombineRowData> list3 = list;
			Comparison<DangoBrawlCombineRowData> comparison;
			if ((comparison = DangoBrawlCombineView.<>O.<0>__CompareCombineRows) == null)
			{
				comparison = (DangoBrawlCombineView.<>O.<0>__CompareCombineRows = new Comparison<DangoBrawlCombineRowData>(DangoBrawlCombineView.CompareCombineRows));
			}
			list3.Sort(comparison);
			List<DangoBrawlCombineRowData> list4 = list2;
			Comparison<DangoBrawlCombineRowData> comparison2;
			if ((comparison2 = DangoBrawlCombineView.<>O.<0>__CompareCombineRows) == null)
			{
				comparison2 = (DangoBrawlCombineView.<>O.<0>__CompareCombineRows = new Comparison<DangoBrawlCombineRowData>(DangoBrawlCombineView.CompareCombineRows));
			}
			list4.Sort(comparison2);
			DangoBrawlCombineViewTitleData firstTitleData = null;
			DangoBrawlCombineViewTitleData secondTitleData = null;
			if (this.ShowIntoSelf && list.Count > 0)
			{
				bool flag = this.UseIntoSelfTitleQuick && this.FocusItemId == this.InitialFocusItemId;
				firstTitleData = new DangoBrawlCombineViewTitleData
				{
					Title = (flag ? "DangoBrawlGeneral_1015" : "DangoBrawlGeneral_1027"),
					RowDataList = this.ToListItemDataList(list),
					LoopLimitNum = this.FirstTitleLimitLoopNum,
					LoopMaxHeight = this.FirstTitleLimitLoopMaxHeight,
					LoopItemInterval = this.TitleItemInterval
				};
			}
			if (this.ShowSelfIntoOther && list2.Count > 0)
			{
				secondTitleData = new DangoBrawlCombineViewTitleData
				{
					Title = "DangoBrawlGeneral_1016",
					RowDataList = this.ToListItemDataList(list2),
					LoopLimitNum = this.SecondTitleLimitLoopNum,
					LoopMaxHeight = this.SecondTitleLimitLoopMaxHeight,
					LoopItemInterval = this.TitleItemInterval
				};
			}
			this.FirstTitleData = firstTitleData;
			this.SecondTitleData = secondTitleData;
		}

		// Token: 0x0604248A RID: 271498 RVA: 0x010173C0 File Offset: 0x010155C0
		private static int CompareCombineRows(DangoBrawlCombineRowData a, DangoBrawlCombineRowData b)
		{
			int num = a.SortTier.CompareTo(b.SortTier);
			if (num != 0)
			{
				return num;
			}
			num = b.ResultQuality.CompareTo(a.ResultQuality);
			if (num != 0)
			{
				return num;
			}
			return a.ResultItemId.CompareTo(b.ResultItemId);
		}

		// Token: 0x0604248B RID: 271499 RVA: 0x0101740F File Offset: 0x0101560F
		[NullableContext(1)]
		private List<DangoBrawlCombineViewListItemData> ToListItemDataList(List<DangoBrawlCombineRowData> rows)
		{
			return (from row in rows
			select new DangoBrawlCombineViewListItemData
			{
				RowData = row,
				AllowCombine = this.AllowCombine
			}).ToList<DangoBrawlCombineViewListItemData>();
		}

		// Token: 0x0604248C RID: 271500 RVA: 0x01017428 File Offset: 0x01015628
		[NullableContext(1)]
		private List<DangoBrawlCombineRowData> BuildAllCombineRows()
		{
			if (this.FocusItemId <= 0)
			{
				return new List<DangoBrawlCombineRowData>();
			}
			if (this.UseActData && this.ActData != null)
			{
				return this.BuildCombineRowsWithInventory(this.FocusItemId, this.FocusUid, this.ActData, this.AllowCombine);
			}
			return this.BuildCombineRowsConfigOnly(this.FocusItemId);
		}

		// Token: 0x0604248D RID: 271501 RVA: 0x01017480 File Offset: 0x01015680
		[NullableContext(1)]
		private List<DangoBrawlCombineRowData> BuildCombineRowsWithInventory(int focusConfigId, int focusUid, ActivityDangoBrawlData actData, bool allowCombine)
		{
			List<DangoBrawlCombineRowData> list = new List<DangoBrawlCombineRowData>();
			IReadOnlyList<DangoBrawlItemCompose> dangoBrawlAllCompose = DangoBrawlConfig.Instance.GetDangoBrawlAllCompose();
			if (dangoBrawlAllCompose == null)
			{
				return list;
			}
			List<ValueTuple<int, int, EDragSourceKind>> candidates = this.CollectCombineCandidates(actData);
			foreach (DangoBrawlItemCompose config in dangoBrawlAllCompose)
			{
				int[] needItemsArray = config.GetNeedItemsArray();
				if (needItemsArray.Length != 0 && (needItemsArray.Contains(focusConfigId) || config.ResultItemId == focusConfigId))
				{
					DangoBrawlCombineRowData dangoBrawlCombineRowData = this.BuildCombineRowData(config, needItemsArray, focusUid, candidates, allowCombine);
					dangoBrawlCombineRowData.IsLock = DangoBrawlCombineUtil.IsBlockedByUniqueWeapon(actData, dangoBrawlCombineRowData);
					list.Add(dangoBrawlCombineRowData);
				}
			}
			return list;
		}

		// Token: 0x0604248E RID: 271502 RVA: 0x0101752C File Offset: 0x0101572C
		[NullableContext(1)]
		private List<DangoBrawlCombineRowData> BuildCombineRowsConfigOnly(int focusConfigId)
		{
			List<DangoBrawlCombineRowData> list = new List<DangoBrawlCombineRowData>();
			IReadOnlyList<DangoBrawlItemCompose> dangoBrawlAllCompose = DangoBrawlConfig.Instance.GetDangoBrawlAllCompose();
			if (dangoBrawlAllCompose == null)
			{
				return list;
			}
			foreach (DangoBrawlItemCompose dangoBrawlItemCompose in dangoBrawlAllCompose)
			{
				int[] needItemsArray = dangoBrawlItemCompose.GetNeedItemsArray();
				if (needItemsArray.Length != 0 && (needItemsArray.Contains(focusConfigId) || dangoBrawlItemCompose.ResultItemId == focusConfigId))
				{
					CombineItem[] array = new CombineItem[needItemsArray.Length];
					for (int i = 0; i < needItemsArray.Length; i++)
					{
						array[i] = new CombineItem
						{
							Uid = 0,
							Source = EDragSourceKind.Bag
						};
					}
					DangoBrawlItem? dangoBrawlItem;
					list.Add(new DangoBrawlCombineRowData
					{
						ComposeId = dangoBrawlItemCompose.Id,
						ResultItemId = dangoBrawlItemCompose.ResultItemId,
						SourceItems = array,
						CanCombine = false,
						SortTier = 2,
						ResultQuality = ((DangoBrawlConfig.Instance.GetItemConfigById(dangoBrawlItemCompose.ResultItemId) != null) ? dangoBrawlItem.GetValueOrDefault().Quality : 0)
					});
				}
			}
			return list;
		}

		// Token: 0x0604248F RID: 271503 RVA: 0x01017670 File Offset: 0x01015870
		[NullableContext(1)]
		[return: TupleElementNames(new string[]
		{
			"Uid",
			"ConfigId",
			"Source"
		})]
		[return: Nullable(new byte[]
		{
			1,
			0
		})]
		private List<ValueTuple<int, int, EDragSourceKind>> CollectCombineCandidates(ActivityDangoBrawlData actData)
		{
			List<ValueTuple<int, int, EDragSourceKind>> list = new List<ValueTuple<int, int, EDragSourceKind>>();
			if (actData.BagpackData != null)
			{
				foreach (DangoBrawlBackpackItemData dangoBrawlBackpackItemData in actData.BagpackData.GetItemList())
				{
					list.Add(new ValueTuple<int, int, EDragSourceKind>(dangoBrawlBackpackItemData.MyUid, dangoBrawlBackpackItemData.MyConfigId, EDragSourceKind.Bag));
				}
			}
			if (actData.BenchData != null)
			{
				foreach (DangoBrawlBenchItemData dangoBrawlBenchItemData in actData.BenchData.GetItemList())
				{
					list.Add(new ValueTuple<int, int, EDragSourceKind>(dangoBrawlBenchItemData.MyUid, dangoBrawlBenchItemData.MyConfigId, EDragSourceKind.Bench));
				}
			}
			DangoBrawlShopServerData shopServerData = actData.ShopServerData;
			RepeatedField<DangoBrawlShopSlotInfo> repeatedField;
			if (shopServerData == null)
			{
				repeatedField = null;
			}
			else
			{
				DangoBrawlShopInfo myShopInfo = shopServerData.MyShopInfo;
				repeatedField = ((myShopInfo != null) ? myShopInfo.Slots : null);
			}
			RepeatedField<DangoBrawlShopSlotInfo> repeatedField2 = repeatedField;
			if (repeatedField2 != null)
			{
				foreach (DangoBrawlShopSlotInfo dangoBrawlShopSlotInfo in repeatedField2)
				{
					DangoBrawlBaseItemInfo dangoBrawlBaseItemInfo = (dangoBrawlShopSlotInfo != null) ? dangoBrawlShopSlotInfo.Item : null;
					if (dangoBrawlBaseItemInfo != null && dangoBrawlBaseItemInfo.ConfigId > 0)
					{
						list.Add(new ValueTuple<int, int, EDragSourceKind>(dangoBrawlBaseItemInfo.Uid, dangoBrawlBaseItemInfo.ConfigId, EDragSourceKind.Shop));
					}
				}
			}
			return list;
		}

		// Token: 0x06042490 RID: 271504 RVA: 0x010177D8 File Offset: 0x010159D8
		[NullableContext(1)]
		private DangoBrawlCombineRowData BuildCombineRowData(DangoBrawlItemCompose config, int[] needItems, int focusUid, [TupleElementNames(new string[]
		{
			"Uid",
			"ConfigId",
			"Source"
		})] [Nullable(new byte[]
		{
			1,
			0
		})] List<ValueTuple<int, int, EDragSourceKind>> candidates, bool allowCombine)
		{
			HashSet<int> hashSet = new HashSet<int>();
			List<CombineItem> list = new List<CombineItem>(needItems.Length);
			bool flag = true;
			bool flag2 = false;
			foreach (int needConfigId in needItems)
			{
				ValueTuple<int, int, EDragSourceKind>? valueTuple = this.FindCombineCandidate(needConfigId, focusUid, hashSet, candidates);
				if (valueTuple == null)
				{
					flag = false;
					list.Add(new CombineItem
					{
						Uid = 0,
						Source = EDragSourceKind.Bag
					});
				}
				else
				{
					hashSet.Add(valueTuple.Value.Item1);
					list.Add(new CombineItem
					{
						Uid = valueTuple.Value.Item1,
						Source = valueTuple.Value.Item3
					});
					if (valueTuple.Value.Item3 == EDragSourceKind.Shop)
					{
						flag2 = true;
					}
				}
			}
			DangoBrawlCombineView.ECombineSortTier ecombineSortTier;
			if (!flag)
			{
				ecombineSortTier = DangoBrawlCombineView.ECombineSortTier.NotReady;
			}
			else if (flag2)
			{
				ecombineSortTier = DangoBrawlCombineView.ECombineSortTier.NeedsShop;
			}
			else
			{
				ecombineSortTier = DangoBrawlCombineView.ECombineSortTier.Ready;
			}
			DangoBrawlItem? dangoBrawlItem;
			return new DangoBrawlCombineRowData
			{
				ComposeId = config.Id,
				ResultItemId = config.ResultItemId,
				SourceItems = list.ToArray(),
				CanCombine = (ecombineSortTier == DangoBrawlCombineView.ECombineSortTier.Ready && allowCombine),
				SortTier = (int)ecombineSortTier,
				ResultQuality = ((DangoBrawlConfig.Instance.GetItemConfigById(config.ResultItemId) != null) ? dangoBrawlItem.GetValueOrDefault().Quality : 0)
			};
		}

		// Token: 0x06042491 RID: 271505 RVA: 0x01017944 File Offset: 0x01015B44
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"Uid",
			"ConfigId",
			"Source"
		})]
		private ValueTuple<int, int, EDragSourceKind>? FindCombineCandidate(int needConfigId, int focusUid, [Nullable(1)] HashSet<int> usedUids, [TupleElementNames(new string[]
		{
			"Uid",
			"ConfigId",
			"Source"
		})] [Nullable(new byte[]
		{
			1,
			0
		})] List<ValueTuple<int, int, EDragSourceKind>> candidates)
		{
			if (focusUid > 0)
			{
				foreach (ValueTuple<int, int, EDragSourceKind> valueTuple in candidates)
				{
					if (valueTuple.Item2 == needConfigId && valueTuple.Item1 == focusUid && !usedUids.Contains(valueTuple.Item1))
					{
						return new ValueTuple<int, int, EDragSourceKind>?(valueTuple);
					}
				}
			}
			foreach (ValueTuple<int, int, EDragSourceKind> valueTuple2 in candidates)
			{
				if (valueTuple2.Item2 == needConfigId && !usedUids.Contains(valueTuple2.Item1))
				{
					return new ValueTuple<int, int, EDragSourceKind>?(valueTuple2);
				}
			}
			return null;
		}

		// Token: 0x06042492 RID: 271506 RVA: 0x01017A1C File Offset: 0x01015C1C
		private UniTask CreateTitleItems()
		{
			DangoBrawlCombineView.<CreateTitleItems>d__42 <CreateTitleItems>d__;
			<CreateTitleItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateTitleItems>d__.<>4__this = this;
			<CreateTitleItems>d__.<>1__state = -1;
			<CreateTitleItems>d__.<>t__builder.Start<DangoBrawlCombineView.<CreateTitleItems>d__42>(ref <CreateTitleItems>d__);
			return <CreateTitleItems>d__.<>t__builder.Task;
		}

		// Token: 0x06042493 RID: 271507 RVA: 0x01017A5F File Offset: 0x01015C5F
		[NullableContext(1)]
		private DangoBrawlCombineViewTitleItem CreateTitleItem()
		{
			return new DangoBrawlCombineViewTitleItem
			{
				OnCombineClick = new Action<DangoBrawlCombineRowData>(this.OnListItemClickCombine),
				OnGridClick = new Action<int, UUIItem>(this.OnGridClickSelectItem),
				IsGridSelected = new Func<int, bool>(this.IsGridSelected)
			};
		}

		// Token: 0x06042494 RID: 271508 RVA: 0x01017A9C File Offset: 0x01015C9C
		private UniTask RefreshTitleItemsAsync()
		{
			DangoBrawlCombineView.<RefreshTitleItemsAsync>d__44 <RefreshTitleItemsAsync>d__;
			<RefreshTitleItemsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshTitleItemsAsync>d__.<>4__this = this;
			<RefreshTitleItemsAsync>d__.<>1__state = -1;
			<RefreshTitleItemsAsync>d__.<>t__builder.Start<DangoBrawlCombineView.<RefreshTitleItemsAsync>d__44>(ref <RefreshTitleItemsAsync>d__);
			return <RefreshTitleItemsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042495 RID: 271509 RVA: 0x01017AE0 File Offset: 0x01015CE0
		private UniTask RefreshOneTitleItemAsync(DangoBrawlCombineViewTitleItem titleItem, DangoBrawlCombineViewTitleData titleData)
		{
			DangoBrawlCombineView.<RefreshOneTitleItemAsync>d__45 <RefreshOneTitleItemAsync>d__;
			<RefreshOneTitleItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshOneTitleItemAsync>d__.titleItem = titleItem;
			<RefreshOneTitleItemAsync>d__.titleData = titleData;
			<RefreshOneTitleItemAsync>d__.<>1__state = -1;
			<RefreshOneTitleItemAsync>d__.<>t__builder.Start<DangoBrawlCombineView.<RefreshOneTitleItemAsync>d__45>(ref <RefreshOneTitleItemAsync>d__);
			return <RefreshOneTitleItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042496 RID: 271510 RVA: 0x01017B2C File Offset: 0x01015D2C
		private void TryFocusGamepadCombinePath()
		{
			if (base.IsDestroyOrDestroying || !Info.Instance.IsInGamepad())
			{
				return;
			}
			UUIItem preferredCombineNavigationItem = this.GetPreferredCombineNavigationItem();
			if (preferredCombineNavigationItem == null)
			{
				return;
			}
			UiNavigationNewController.Instance.SetNavigationFocusForView(preferredCombineNavigationItem, true, true, true);
		}

		// Token: 0x06042497 RID: 271511 RVA: 0x01017B68 File Offset: 0x01015D68
		private UUIItem GetPreferredCombineNavigationItem()
		{
			DangoBrawlCombineViewTitleData dangoBrawlCombineViewTitleData = this.FirstTitleData;
			if (dangoBrawlCombineViewTitleData != null)
			{
				List<DangoBrawlCombineViewListItemData> rowDataList = dangoBrawlCombineViewTitleData.RowDataList;
				if (rowDataList != null && rowDataList.Count > 0)
				{
					DangoBrawlCombineViewTitleItem firstTitleItem = this.FirstTitleItem;
					UUIItem uuiitem = (firstTitleItem != null) ? firstTitleItem.GetFirstNavigationItem() : null;
					if (uuiitem != null)
					{
						return uuiitem;
					}
				}
			}
			dangoBrawlCombineViewTitleData = this.SecondTitleData;
			if (dangoBrawlCombineViewTitleData != null)
			{
				List<DangoBrawlCombineViewListItemData> rowDataList = dangoBrawlCombineViewTitleData.RowDataList;
				if (rowDataList != null && rowDataList.Count > 0)
				{
					DangoBrawlCombineViewTitleItem secondTitleItem = this.SecondTitleItem;
					if (secondTitleItem == null)
					{
						return null;
					}
					return secondTitleItem.GetFirstNavigationItem();
				}
			}
			return null;
		}

		// Token: 0x06042498 RID: 271512 RVA: 0x01017BDA File Offset: 0x01015DDA
		private void RefreshAllGridSelection()
		{
			DangoBrawlCombineViewTitleItem firstTitleItem = this.FirstTitleItem;
			if (firstTitleItem != null)
			{
				firstTitleItem.RefreshGridSelection();
			}
			DangoBrawlCombineViewTitleItem secondTitleItem = this.SecondTitleItem;
			if (secondTitleItem == null)
			{
				return;
			}
			secondTitleItem.RefreshGridSelection();
		}

		// Token: 0x06042499 RID: 271513 RVA: 0x01017BFD File Offset: 0x01015DFD
		private bool IsGridSelected(int itemId)
		{
			return itemId > 0 && itemId == this.SelectedItemId;
		}

		// Token: 0x0604249A RID: 271514 RVA: 0x01017C0E File Offset: 0x01015E0E
		private void OnListItemClickCombine(DangoBrawlCombineRowData data)
		{
			if (!this.AllowCombine || !data.CanCombine)
			{
				return;
			}
			this.OnListItemClickCombineAsync(data).Forget();
		}

		// Token: 0x0604249B RID: 271515 RVA: 0x01017C30 File Offset: 0x01015E30
		private UniTask OnListItemClickCombineAsync(DangoBrawlCombineRowData data)
		{
			DangoBrawlCombineView.<OnListItemClickCombineAsync>d__51 <OnListItemClickCombineAsync>d__;
			<OnListItemClickCombineAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnListItemClickCombineAsync>d__.<>4__this = this;
			<OnListItemClickCombineAsync>d__.data = data;
			<OnListItemClickCombineAsync>d__.<>1__state = -1;
			<OnListItemClickCombineAsync>d__.<>t__builder.Start<DangoBrawlCombineView.<OnListItemClickCombineAsync>d__51>(ref <OnListItemClickCombineAsync>d__);
			return <OnListItemClickCombineAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604249C RID: 271516 RVA: 0x01017C7C File Offset: 0x01015E7C
		private void OnGridClickSelectItem(int itemId, UUIItem navigationItem)
		{
			if (itemId <= 0)
			{
				return;
			}
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null)
			{
				uiViewSequence.PlayOrReplaySequenceByName("Switch01", false, null);
			}
			this.SelectedItemId = itemId;
			this.RefreshAllGridSelection();
			this.RefreshItemTips(itemId);
			this.RefreshOutBackpackPreviewAsync(itemId).Forget();
			this.KeepGamepadFocusInSameGroup(navigationItem);
		}

		// Token: 0x0604249D RID: 271517 RVA: 0x01017CD5 File Offset: 0x01015ED5
		private void KeepGamepadFocusInSameGroup(UUIItem navigationItem)
		{
			if (navigationItem == null || !navigationItem.IsValid() || !Info.Instance.IsInGamepad())
			{
				return;
			}
			UiNavigationNewController.Instance.SetNavigationFocusForViewSameGroup(navigationItem);
		}

		// Token: 0x04022946 RID: 141638
		private ActivityDangoBrawlData ActData;

		// Token: 0x04022947 RID: 141639
		private int FocusItemId;

		// Token: 0x04022948 RID: 141640
		private int FocusUid;

		// Token: 0x04022949 RID: 141641
		private bool AllowCombine;

		// Token: 0x0402294A RID: 141642
		private bool UseActData;

		// Token: 0x0402294B RID: 141643
		private bool ShowIntoSelf = true;

		// Token: 0x0402294C RID: 141644
		private bool ShowSelfIntoOther = true;

		// Token: 0x0402294D RID: 141645
		private bool UseIntoSelfTitleQuick;

		// Token: 0x0402294E RID: 141646
		private int InitialFocusItemId;

		// Token: 0x0402294F RID: 141647
		private int SelectedItemId;

		// Token: 0x04022950 RID: 141648
		private DangoBrawlItemTipsBase ItemTips;

		// Token: 0x04022951 RID: 141649
		private DangoBrawlOutBackpackItemBase PreviewPanel;

		// Token: 0x04022952 RID: 141650
		private DangoBrawlCombineViewTitleItem FirstTitleItem;

		// Token: 0x04022953 RID: 141651
		private DangoBrawlCombineViewTitleItem SecondTitleItem;

		// Token: 0x04022954 RID: 141652
		private DangoBrawlCombineViewTitleData FirstTitleData;

		// Token: 0x04022955 RID: 141653
		private DangoBrawlCombineViewTitleData SecondTitleData;

		// Token: 0x04022956 RID: 141654
		private readonly int FirstTitleLimitLoopNum = 1;

		// Token: 0x04022957 RID: 141655
		private readonly int SecondTitleLimitLoopNum = 3;

		// Token: 0x04022958 RID: 141656
		private readonly int FirstTitleLimitLoopMaxHeight = 304;

		// Token: 0x04022959 RID: 141657
		private readonly int SecondTitleLimitLoopMaxHeight = 720;

		// Token: 0x0402295A RID: 141658
		private readonly int TitleItemInterval = 10;

		// Token: 0x0200C91D RID: 51485
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0403CB81 RID: 248705
			BtnClose,
			// Token: 0x0403CB82 RID: 248706
			BackpackItem,
			// Token: 0x0403CB83 RID: 248707
			BackpackTips,
			// Token: 0x0403CB84 RID: 248708
			SecondCombineTitleItem,
			// Token: 0x0403CB85 RID: 248709
			FirstCombineTitleItem
		}

		// Token: 0x0200C91E RID: 51486
		[NullableContext(0)]
		private enum ECombineSortTier
		{
			// Token: 0x0403CB87 RID: 248711
			Ready,
			// Token: 0x0403CB88 RID: 248712
			NeedsShop,
			// Token: 0x0403CB89 RID: 248713
			NotReady
		}

		// Token: 0x0200C91F RID: 51487
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403CB8A RID: 248714
			[Nullable(0)]
			public static Comparison<DangoBrawlCombineRowData> <0>__CompareCombineRows;
		}
	}
}

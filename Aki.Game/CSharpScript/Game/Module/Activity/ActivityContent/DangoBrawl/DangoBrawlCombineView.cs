using System;
using System.Collections.Generic;
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
	// Token: 0x0200573C RID: 22332
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlCombineView : UiViewBase
	{
		// Token: 0x06036FD5 RID: 225237 RVA: 0x00F58300 File Offset: 0x00F56500
		[NullableContext(1)]
		public DangoBrawlCombineView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06036FD6 RID: 225238 RVA: 0x00F58350 File Offset: 0x00F56550
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

		// Token: 0x06036FD7 RID: 225239 RVA: 0x00F5845C File Offset: 0x00F5665C
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlCombineView.<OnBeforeStartAsync>d__25 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlCombineView.<OnBeforeStartAsync>d__25>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036FD8 RID: 225240 RVA: 0x00F5849F File Offset: 0x00F5669F
		private void OnBtnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x06036FD9 RID: 225241 RVA: 0x00F584A8 File Offset: 0x00F566A8
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

		// Token: 0x06036FDA RID: 225242 RVA: 0x00F584F4 File Offset: 0x00F566F4
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

		// Token: 0x06036FDB RID: 225243 RVA: 0x00F58540 File Offset: 0x00F56740
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

		// Token: 0x06036FDC RID: 225244 RVA: 0x00F58594 File Offset: 0x00F56794
		private UniTask CreateItemTips()
		{
			DangoBrawlCombineView.<CreateItemTips>d__30 <CreateItemTips>d__;
			<CreateItemTips>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateItemTips>d__.<>4__this = this;
			<CreateItemTips>d__.<>1__state = -1;
			<CreateItemTips>d__.<>t__builder.Start<DangoBrawlCombineView.<CreateItemTips>d__30>(ref <CreateItemTips>d__);
			return <CreateItemTips>d__.<>t__builder.Task;
		}

		// Token: 0x06036FDD RID: 225245 RVA: 0x00F585D8 File Offset: 0x00F567D8
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

		// Token: 0x06036FDE RID: 225246 RVA: 0x00F58638 File Offset: 0x00F56838
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

		// Token: 0x06036FDF RID: 225247 RVA: 0x00F586BC File Offset: 0x00F568BC
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

		// Token: 0x06036FE0 RID: 225248 RVA: 0x00F58858 File Offset: 0x00F56A58
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

		// Token: 0x06036FE1 RID: 225249 RVA: 0x00F588A8 File Offset: 0x00F56AA8
		[NullableContext(1)]
		private List<DangoBrawlCombineViewListItemData> ToListItemDataList(List<DangoBrawlCombineRowData> rows)
		{
			List<DangoBrawlCombineViewListItemData> list = new List<DangoBrawlCombineViewListItemData>(rows.Count);
			for (int i = 0; i < rows.Count; i++)
			{
				list.Add(new DangoBrawlCombineViewListItemData
				{
					RowData = rows[i],
					AllowCombine = this.AllowCombine
				});
			}
			return list;
		}

		// Token: 0x06036FE2 RID: 225250 RVA: 0x00F588F8 File Offset: 0x00F56AF8
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

		// Token: 0x06036FE3 RID: 225251 RVA: 0x00F58950 File Offset: 0x00F56B50
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
				if (needItemsArray.Length != 0 && (Array.IndexOf<int>(needItemsArray, focusConfigId) >= 0 || config.ResultItemId == focusConfigId))
				{
					DangoBrawlCombineRowData dangoBrawlCombineRowData = this.BuildCombineRowData(config, needItemsArray, focusUid, candidates, allowCombine);
					dangoBrawlCombineRowData.IsLock = DangoBrawlCombineUtil.IsBlockedByUniqueWeapon(actData, dangoBrawlCombineRowData);
					list.Add(dangoBrawlCombineRowData);
				}
			}
			return list;
		}

		// Token: 0x06036FE4 RID: 225252 RVA: 0x00F589FC File Offset: 0x00F56BFC
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
				if (needItemsArray.Length != 0 && (Array.IndexOf<int>(needItemsArray, focusConfigId) >= 0 || dangoBrawlItemCompose.ResultItemId == focusConfigId))
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

		// Token: 0x06036FE5 RID: 225253 RVA: 0x00F58B40 File Offset: 0x00F56D40
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

		// Token: 0x06036FE6 RID: 225254 RVA: 0x00F58CA8 File Offset: 0x00F56EA8
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

		// Token: 0x06036FE7 RID: 225255 RVA: 0x00F58E14 File Offset: 0x00F57014
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

		// Token: 0x06036FE8 RID: 225256 RVA: 0x00F58EEC File Offset: 0x00F570EC
		private UniTask CreateTitleItems()
		{
			DangoBrawlCombineView.<CreateTitleItems>d__42 <CreateTitleItems>d__;
			<CreateTitleItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateTitleItems>d__.<>4__this = this;
			<CreateTitleItems>d__.<>1__state = -1;
			<CreateTitleItems>d__.<>t__builder.Start<DangoBrawlCombineView.<CreateTitleItems>d__42>(ref <CreateTitleItems>d__);
			return <CreateTitleItems>d__.<>t__builder.Task;
		}

		// Token: 0x06036FE9 RID: 225257 RVA: 0x00F58F2F File Offset: 0x00F5712F
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

		// Token: 0x06036FEA RID: 225258 RVA: 0x00F58F6C File Offset: 0x00F5716C
		private UniTask RefreshTitleItemsAsync()
		{
			DangoBrawlCombineView.<RefreshTitleItemsAsync>d__44 <RefreshTitleItemsAsync>d__;
			<RefreshTitleItemsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshTitleItemsAsync>d__.<>4__this = this;
			<RefreshTitleItemsAsync>d__.<>1__state = -1;
			<RefreshTitleItemsAsync>d__.<>t__builder.Start<DangoBrawlCombineView.<RefreshTitleItemsAsync>d__44>(ref <RefreshTitleItemsAsync>d__);
			return <RefreshTitleItemsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036FEB RID: 225259 RVA: 0x00F58FB0 File Offset: 0x00F571B0
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

		// Token: 0x06036FEC RID: 225260 RVA: 0x00F58FFC File Offset: 0x00F571FC
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

		// Token: 0x06036FED RID: 225261 RVA: 0x00F59038 File Offset: 0x00F57238
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

		// Token: 0x06036FEE RID: 225262 RVA: 0x00F590AA File Offset: 0x00F572AA
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

		// Token: 0x06036FEF RID: 225263 RVA: 0x00F590CD File Offset: 0x00F572CD
		private bool IsGridSelected(int itemId)
		{
			return itemId > 0 && itemId == this.SelectedItemId;
		}

		// Token: 0x06036FF0 RID: 225264 RVA: 0x00F590DE File Offset: 0x00F572DE
		private void OnListItemClickCombine(DangoBrawlCombineRowData data)
		{
			if (!this.AllowCombine || !data.CanCombine)
			{
				return;
			}
			this.OnListItemClickCombineAsync(data).Forget();
		}

		// Token: 0x06036FF1 RID: 225265 RVA: 0x00F59100 File Offset: 0x00F57300
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

		// Token: 0x06036FF2 RID: 225266 RVA: 0x00F5914C File Offset: 0x00F5734C
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

		// Token: 0x06036FF3 RID: 225267 RVA: 0x00F591A5 File Offset: 0x00F573A5
		private void KeepGamepadFocusInSameGroup(UUIItem navigationItem)
		{
			if (navigationItem == null || !navigationItem.IsValid() || !Info.Instance.IsInGamepad())
			{
				return;
			}
			UiNavigationNewController.Instance.SetNavigationFocusForViewSameGroup(navigationItem);
		}

		// Token: 0x0401D1A3 RID: 119203
		private ActivityDangoBrawlData ActData;

		// Token: 0x0401D1A4 RID: 119204
		private int FocusItemId;

		// Token: 0x0401D1A5 RID: 119205
		private int FocusUid;

		// Token: 0x0401D1A6 RID: 119206
		private bool AllowCombine;

		// Token: 0x0401D1A7 RID: 119207
		private bool UseActData;

		// Token: 0x0401D1A8 RID: 119208
		private bool ShowIntoSelf = true;

		// Token: 0x0401D1A9 RID: 119209
		private bool ShowSelfIntoOther = true;

		// Token: 0x0401D1AA RID: 119210
		private bool UseIntoSelfTitleQuick;

		// Token: 0x0401D1AB RID: 119211
		private int InitialFocusItemId;

		// Token: 0x0401D1AC RID: 119212
		private int SelectedItemId;

		// Token: 0x0401D1AD RID: 119213
		private DangoBrawlItemTipsBase ItemTips;

		// Token: 0x0401D1AE RID: 119214
		private DangoBrawlOutBackpackItemBase PreviewPanel;

		// Token: 0x0401D1AF RID: 119215
		private DangoBrawlCombineViewTitleItem FirstTitleItem;

		// Token: 0x0401D1B0 RID: 119216
		private DangoBrawlCombineViewTitleItem SecondTitleItem;

		// Token: 0x0401D1B1 RID: 119217
		private DangoBrawlCombineViewTitleData FirstTitleData;

		// Token: 0x0401D1B2 RID: 119218
		private DangoBrawlCombineViewTitleData SecondTitleData;

		// Token: 0x0401D1B3 RID: 119219
		private readonly int FirstTitleLimitLoopNum = 1;

		// Token: 0x0401D1B4 RID: 119220
		private readonly int SecondTitleLimitLoopNum = 3;

		// Token: 0x0401D1B5 RID: 119221
		private readonly int FirstTitleLimitLoopMaxHeight = 304;

		// Token: 0x0401D1B6 RID: 119222
		private readonly int SecondTitleLimitLoopMaxHeight = 720;

		// Token: 0x0401D1B7 RID: 119223
		private readonly int TitleItemInterval = 10;

		// Token: 0x0200B2EB RID: 45803
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04037472 RID: 226418
			BtnClose,
			// Token: 0x04037473 RID: 226419
			BackpackItem,
			// Token: 0x04037474 RID: 226420
			BackpackTips,
			// Token: 0x04037475 RID: 226421
			SecondCombineTitleItem,
			// Token: 0x04037476 RID: 226422
			FirstCombineTitleItem
		}

		// Token: 0x0200B2EC RID: 45804
		[NullableContext(0)]
		private enum ECombineSortTier
		{
			// Token: 0x04037478 RID: 226424
			Ready,
			// Token: 0x04037479 RID: 226425
			NeedsShop,
			// Token: 0x0403747A RID: 226426
			NotReady
		}

		// Token: 0x0200B2ED RID: 45805
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403747B RID: 226427
			[Nullable(0)]
			public static Comparison<DangoBrawlCombineRowData> <0>__CompareCombineRows;
		}
	}
}

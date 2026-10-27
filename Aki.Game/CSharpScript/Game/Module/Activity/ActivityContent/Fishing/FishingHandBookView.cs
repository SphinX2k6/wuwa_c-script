using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02006617 RID: 26135
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingHandBookView : UiViewBase
	{
		// Token: 0x060417DB RID: 268251 RVA: 0x00FDD24E File Offset: 0x00FDB44E
		public FishingHandBookView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060417DC RID: 268252 RVA: 0x00FDD264 File Offset: 0x00FDB464
		protected unsafe override void OnRegisterComponent()
		{
			int num = 21;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(16, new Action(this.OnClickTraceBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060417DD RID: 268253 RVA: 0x00FDD58C File Offset: 0x00FDB78C
		protected override UniTask OnBeforeStartAsync()
		{
			FishingHandBookView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FishingHandBookView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060417DE RID: 268254 RVA: 0x00FDD5D0 File Offset: 0x00FDB7D0
		protected override void OnStart()
		{
			List<IFishingHandBookItemData> fishingItemList = FishingModel.Instance.GetFishingItemList();
			FilterSortEntrance<IFishingHandBookItemData> filterSortBtn = this.FilterSortBtn;
			if (filterSortBtn != null)
			{
				filterSortBtn.UpdateData(EFilterSortGroupId.FishingItem, fishingItemList, Array.Empty<object>());
			}
			UUIText text = base.GetText(3);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(FishingModel.Instance.UnLockFishingItemCount);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(FishingModel.Instance.AllFishingItemCount);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x060417DF RID: 268255 RVA: 0x00FDD64C File Offset: 0x00FDB84C
		private void RefreshView(int itemId)
		{
			this.ItemId = itemId;
			FishingItem? fishingItemConfig = FishingConfig.Instance.GetFishingItemConfig(itemId);
			if (fishingItemConfig.Value.TechLength > 0)
			{
				GenericLayout<FishingHandBookTagItem, int> tagItemLayout = this.TagItemLayout;
				if (tagItemLayout != null)
				{
					tagItemLayout.RefreshByData(fishingItemConfig.Value.Tech().ToList<int>(), null, false);
				}
				base.GetItem(12).SetUIActive(true);
			}
			else
			{
				base.GetItem(12).SetUIActive(false);
			}
			this.RelationItemId = 0;
			if (fishingItemConfig.Value.Relation > 0)
			{
				this.RelationItemId = fishingItemConfig.Value.Relation;
				LguiUtil.Instance.SetLocalTextNew(base.GetText(20), "FishingRelationText", Array.Empty<object>());
				FishingHandBookItem relationItem = this.RelationItem;
				if (relationItem != null)
				{
					relationItem.Refresh(this.RelationItemId, false, 0);
				}
			}
			else if (fishingItemConfig.Value.ChildRelation > 0)
			{
				this.RelationItemId = fishingItemConfig.Value.ChildRelation;
				LguiUtil.Instance.SetLocalTextNew(base.GetText(20), "FishingChildRelationText", Array.Empty<object>());
				FishingHandBookItem relationItem2 = this.RelationItem;
				if (relationItem2 != null)
				{
					relationItem2.Refresh(this.RelationItemId, false, 0);
				}
			}
			base.GetItem(10).SetUIActive(this.RelationItemId > 0);
			IFishingHandBook fishingHandBook;
			bool flag = !FishingModel.Instance.FishingItemHandBookDataMap.TryGetValue(itemId, out fishingHandBook);
			string text = flag ? ConfigMultiTextLang.GetLocalTextNew("FishingLockItemName", null) : ConfigMultiTextLang.GetLocalTextNew(fishingItemConfig.Value.Name, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(11), "Fishing_ArchiveTitle", new <>z__ReadOnlyArray<object>(new object[]
			{
				fishingItemConfig.Value.IllustratedNum.ToString(),
				text
			}));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(8), flag ? "FishingLockItemName" : fishingItemConfig.Value.Desc, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), flag ? "FishingItemLockState" : "FishingItemUnlockState", Array.Empty<object>());
			FishingQuestShapePanel fishingShapePanel = this.FishingShapePanel;
			if (fishingShapePanel != null)
			{
				fishingShapePanel.RefreshPanel(itemId, !flag);
			}
			this.RefreshDesLayout(itemId);
			bool flag2 = FishingModel.Instance.FishingItemHandBookUnlockTraceList.Contains(this.ItemId);
			UUIButtonComponent button = base.GetButton(16);
			if (!flag)
			{
				button.RootUIComp.Get().SetUIActive(true);
				button.SetSelfInteractive(true);
				base.GetItem(17).SetUIActive(false);
			}
			else if (flag2)
			{
				button.RootUIComp.Get().SetUIActive(true);
				button.SetSelfInteractive(true);
				base.GetItem(17).SetUIActive(false);
			}
			else if (fishingItemConfig.Value.DetectionUnlockCondition > 0)
			{
				button.RootUIComp.Get().SetUIActive(false);
				base.GetItem(17).SetUIActive(true);
				ConditionGroup? conditionGroupConfig = ConditionConfig.Instance.GetConditionGroupConfig(fishingItemConfig.Value.DetectionUnlockCondition);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(18), conditionGroupConfig.Value.HintText, Array.Empty<object>());
			}
			else
			{
				button.RootUIComp.Get().SetUIActive(true);
				button.SetSelfInteractive(false);
				button.SetCanClickWhenDisable(true);
				base.GetItem(17).SetUIActive(false);
			}
			this.ReadItemNewFlag();
		}

		// Token: 0x060417E0 RID: 268256 RVA: 0x00FDD9D0 File Offset: 0x00FDBBD0
		private void RefreshDesLayout(int itemId)
		{
			FishingItem? fishingItemConfig = FishingConfig.Instance.GetFishingItemConfig(itemId);
			List<IFishingHandBookDesData> list = new List<IFishingHandBookDesData>();
			if (fishingItemConfig.Value.AreaLength > 0)
			{
				int areaId = fishingItemConfig.Value.Area(0);
				Area? areaInfo = AreaConfig.Instance.GetAreaInfo(areaId);
				string areaLocalName = AreaConfig.Instance.GetAreaLocalName(areaInfo.Value.Title);
				FishingHandBookDesData item = new FishingHandBookDesData
				{
					DesText = "Fishing_Area",
					DataText = areaLocalName
				};
				list.Add(item);
			}
			if (fishingItemConfig.Value.Time > 0)
			{
				string dataText = ConfigMultiTextLang.GetLocalTextNew(FishingDefine.fishingItemTimeText[fishingItemConfig.Value.Time], null) ?? "";
				FishingHandBookDesData item2 = new FishingHandBookDesData
				{
					DesText = "Fishing_Time",
					DataText = dataText
				};
				list.Add(item2);
			}
			if (fishingItemConfig.Value.SizeWeightLength > 0)
			{
				IFishingHandBook fishingHandBook2;
				IFishingHandBook fishingHandBook = FishingModel.Instance.FishingItemHandBookDataMap.TryGetValue(itemId, out fishingHandBook2) ? fishingHandBook2 : null;
				if (fishingHandBook == null)
				{
					string dataText2 = ConfigMultiTextLang.GetLocalTextNew("FishingLockItemName", null) ?? "";
					FishingHandBookDesData item3 = new FishingHandBookDesData
					{
						DesText = "Fishing_MinSize",
						DataText = dataText2
					};
					FishingHandBookDesData item4 = new FishingHandBookDesData
					{
						DesText = "Fishing_MaxSize",
						DataText = dataText2
					};
					list.Add(item3);
					list.Add(item4);
				}
				else
				{
					string str = ConfigMultiTextLang.GetLocalTextNew("Fishing_SizeDes", null) ?? "";
					int minSize = fishingHandBook.MinSize;
					List<EFishingSize> sizeIsGoldSize = FishingModel.Instance.GetSizeIsGoldSize(itemId);
					bool value = sizeIsGoldSize.Contains(EFishingSize.Silver);
					FishingHandBookDesData item5 = new FishingHandBookDesData
					{
						DesText = "Fishing_MinSize",
						DataText = minSize.ToString() + str,
						IsSliver = new bool?(value)
					};
					int maxSize = fishingHandBook.MaxSize;
					bool value2 = sizeIsGoldSize.Contains(EFishingSize.Golden);
					FishingHandBookDesData item6 = new FishingHandBookDesData
					{
						DesText = "Fishing_MaxSize",
						DataText = maxSize.ToString() + str,
						IsGolden = new bool?(value2)
					};
					list.Add(item5);
					list.Add(item6);
				}
			}
			if (fishingItemConfig.Value.Reputation > 0)
			{
				FishingHandBookDesData item7 = new FishingHandBookDesData
				{
					DesText = "Fishing_AddCount",
					DataText = "+" + fishingItemConfig.Value.Reputation.ToString()
				};
				list.Add(item7);
			}
			base.GetVerticalLayout(15).RootUIComp.Get().SetUIActive(list.Count > 0);
			GenericLayout<FishingHandBookDesItem, IFishingHandBookDesData> desLayout = this.DesLayout;
			if (desLayout == null)
			{
				return;
			}
			desLayout.RefreshByData(list, null, false);
		}

		// Token: 0x060417E1 RID: 268257 RVA: 0x00FDDC96 File Offset: 0x00FDBE96
		private FishingHandBookItem InitLoopScrollItem()
		{
			return new FishingHandBookItem
			{
				OnClickToggleCallBack = new Action<int, UUIExtendToggle, int>(this.OnClickHandBookItem)
			};
		}

		// Token: 0x060417E2 RID: 268258 RVA: 0x00FDDCAF File Offset: 0x00FDBEAF
		private FishingHandBookTagItem InitTagLayoutItem()
		{
			return new FishingHandBookTagItem();
		}

		// Token: 0x060417E3 RID: 268259 RVA: 0x00FDDCB6 File Offset: 0x00FDBEB6
		private FishingHandBookDesItem InitDesLayoutItem()
		{
			return new FishingHandBookDesItem();
		}

		// Token: 0x060417E4 RID: 268260 RVA: 0x00FDDCC0 File Offset: 0x00FDBEC0
		private void OnClickTraceBtn()
		{
			IFishingHandBook fishingHandBook;
			if (FishingModel.Instance.FishingItemHandBookDataMap.TryGetValue(this.ItemId, out fishingHandBook) || FishingModel.Instance.FishingItemHandBookUnlockTraceList.Contains(this.ItemId))
			{
				int[] array = FishingConfig.Instance.GetFishingItemConfig(this.ItemId).Value.Tech();
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] == 6)
					{
						ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_CageDetect", Array.Empty<object>());
						return;
					}
				}
				int relation = FishingConfig.Instance.GetFishingItemConfig(this.ItemId).Value.Relation;
				int item = (relation > 0) ? relation : this.ItemId;
				FishingQuestModel.Instance.TraceItem(item);
				return;
			}
			if (this.RelationItemId > 0)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_VariationItemCannotTrace", Array.Empty<object>());
				return;
			}
			ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_NormalItemCannotTrace", Array.Empty<object>());
		}

		// Token: 0x060417E5 RID: 268261 RVA: 0x00FDDDC4 File Offset: 0x00FDBFC4
		private void OnClickHandBookItem(int itemId, UUIExtendToggle toggle, int index)
		{
			UUIExtendToggle currentToggle = this.CurrentToggle;
			if (currentToggle != null)
			{
				currentToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
			this.CurrentToggle = toggle;
			this.RefreshView(itemId);
			this.HandBookLoopScrollView.SelectGridProxy(index, false);
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayLevelSequenceByName("Switch", false, null, false);
		}

		// Token: 0x060417E6 RID: 268262 RVA: 0x00FDDE24 File Offset: 0x00FDC024
		private void OnClickRelationItem(int itemId, UUIExtendToggle toggle, int _)
		{
			int num = 0;
			using (List<IFishingHandBookItemData>.Enumerator enumerator = this.ItemDataList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Id == itemId)
					{
						break;
					}
					num++;
				}
			}
			this.HandBookLoopScrollView.ScrollToGridIndex(num, true);
			this.HandBookLoopScrollView.SelectGridProxy(num, true);
		}

		// Token: 0x060417E7 RID: 268263 RVA: 0x00FDDE9C File Offset: 0x00FDC09C
		private void OnFilterUpdate(List<IFishingHandBookItemData> list, bool isOutSideChange, EFilterSortType sortType)
		{
			List<int> filteredArr = new List<int>();
			this.ItemDataList = list;
			foreach (IFishingHandBookItemData fishingHandBookItemData in list)
			{
				filteredArr.Add(fishingHandBookItemData.Id);
			}
			if (filteredArr.Count > 0)
			{
				LoopScrollView<FishingHandBookItem, int> handBookLoopScrollView = this.HandBookLoopScrollView;
				if (handBookLoopScrollView != null)
				{
					handBookLoopScrollView.RefreshByData(filteredArr, false, delegate
					{
						LoopScrollView<FishingHandBookItem, int> handBookLoopScrollView2 = this.HandBookLoopScrollView;
						if (handBookLoopScrollView2 != null)
						{
							handBookLoopScrollView2.SelectGridProxy(0, true);
						}
						this.RefreshView(filteredArr[0]);
					}, false);
				}
				base.GetItem(4).SetUIActive(false);
				base.GetLoopScrollViewComponent(1).RootUIComp.Get().SetUIActive(true);
				base.GetItem(19).SetUIActive(true);
				return;
			}
			base.GetItem(4).SetUIActive(true);
			base.GetLoopScrollViewComponent(1).RootUIComp.Get().SetUIActive(false);
			base.GetItem(19).SetUIActive(false);
		}

		// Token: 0x060417E8 RID: 268264 RVA: 0x00FDDFB4 File Offset: 0x00FDC1B4
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length == 0)
			{
				return null;
			}
			if (configParams[0] == "FishingHandBookItem")
			{
				if (configParams.Length != 2)
				{
					return null;
				}
				int num;
				if (int.TryParse(configParams[1], out num) && num >= 0 && num < this.ItemDataList.Count)
				{
					LoopScrollView<FishingHandBookItem, int> handBookLoopScrollView = this.HandBookLoopScrollView;
					UUIItem uuiitem = (handBookLoopScrollView != null) ? handBookLoopScrollView.GetGridByDisplayIndex(num) : null;
					if (uuiitem == null)
					{
						return null;
					}
					return new UUIItem[]
					{
						uuiitem,
						uuiitem
					};
				}
			}
			return null;
		}

		// Token: 0x060417E9 RID: 268265 RVA: 0x00FDE028 File Offset: 0x00FDC228
		private void ReadItemNewFlag()
		{
			IFishingHandBook fishingHandBook;
			if (!FishingModel.Instance.FishingItemHandBookDataMap.TryGetValue(this.ItemId, out fishingHandBook))
			{
				return;
			}
			NewFlagModel.Instance.AddNewFlag(ELocalStoragePlayerKey.FishingHandBookItemRecord, this.ItemId);
			NewFlagModel.Instance.SaveNewFlagConfig(ELocalStoragePlayerKey.FishingHandBookItemRecord);
		}

		// Token: 0x04022144 RID: 139588
		private int ItemId;

		// Token: 0x04022145 RID: 139589
		private List<IFishingHandBookItemData> ItemDataList = new List<IFishingHandBookItemData>();

		// Token: 0x04022146 RID: 139590
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04022147 RID: 139591
		[Nullable(2)]
		private FishingQuestShapePanel FishingShapePanel;

		// Token: 0x04022148 RID: 139592
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoopScrollView<FishingHandBookItem, int> HandBookLoopScrollView;

		// Token: 0x04022149 RID: 139593
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<FishingHandBookTagItem, int> TagItemLayout;

		// Token: 0x0402214A RID: 139594
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<FishingHandBookDesItem, IFishingHandBookDesData> DesLayout;

		// Token: 0x0402214B RID: 139595
		[Nullable(2)]
		private UUIExtendToggle CurrentToggle;

		// Token: 0x0402214C RID: 139596
		[Nullable(2)]
		private FishingHandBookItem RelationItem;

		// Token: 0x0402214D RID: 139597
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FilterSortEntrance<IFishingHandBookItemData> FilterSortBtn;

		// Token: 0x0402214E RID: 139598
		private int RelationItemId;

		// Token: 0x0402214F RID: 139599
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200C829 RID: 51241
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403C732 RID: 247602
			public const int CaptionItem = 0;

			// Token: 0x0403C733 RID: 247603
			public const int ItemLoopScrollView = 1;

			// Token: 0x0403C734 RID: 247604
			public const int ItemLoopScrollItem = 2;

			// Token: 0x0403C735 RID: 247605
			public const int CollectCountText = 3;

			// Token: 0x0403C736 RID: 247606
			public const int EmptyItem = 4;

			// Token: 0x0403C737 RID: 247607
			public const int FilterSortItem = 5;

			// Token: 0x0403C738 RID: 247608
			public const int ShapePanelItem = 6;

			// Token: 0x0403C739 RID: 247609
			public const int ItemStateText = 7;

			// Token: 0x0403C73A RID: 247610
			public const int ItemDesText = 8;

			// Token: 0x0403C73B RID: 247611
			public const int VariationItem = 9;

			// Token: 0x0403C73C RID: 247612
			public const int VariationPanelItem = 10;

			// Token: 0x0403C73D RID: 247613
			public const int NumberAndNameText = 11;

			// Token: 0x0403C73E RID: 247614
			public const int AreaItem = 12;

			// Token: 0x0403C73F RID: 247615
			public const int PositionText = 13;

			// Token: 0x0403C740 RID: 247616
			public const int TagLayout = 14;

			// Token: 0x0403C741 RID: 247617
			public const int DesVerticalLayout = 15;

			// Token: 0x0403C742 RID: 247618
			public const int TraceBtn = 16;

			// Token: 0x0403C743 RID: 247619
			public const int LockItem = 17;

			// Token: 0x0403C744 RID: 247620
			public const int LockText = 18;

			// Token: 0x0403C745 RID: 247621
			public const int NotEmptyItem = 19;

			// Token: 0x0403C746 RID: 247622
			public const int VariationText = 20;
		}
	}
}

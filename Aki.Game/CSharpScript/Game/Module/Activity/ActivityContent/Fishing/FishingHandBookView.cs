using System;
using System.Collections.Generic;
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
	// Token: 0x02005595 RID: 21909
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingHandBookView : UiViewBase
	{
		// Token: 0x060364A0 RID: 222368 RVA: 0x00F242E6 File Offset: 0x00F224E6
		public FishingHandBookView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060364A1 RID: 222369 RVA: 0x00F242FC File Offset: 0x00F224FC
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

		// Token: 0x060364A2 RID: 222370 RVA: 0x00F24624 File Offset: 0x00F22824
		protected override UniTask OnBeforeStartAsync()
		{
			FishingHandBookView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FishingHandBookView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060364A3 RID: 222371 RVA: 0x00F24668 File Offset: 0x00F22868
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

		// Token: 0x060364A4 RID: 222372 RVA: 0x00F246E4 File Offset: 0x00F228E4
		private void RefreshView(int itemId)
		{
			this.ItemId = itemId;
			FishingItem? fishingItemConfig = FishingConfig.Instance.GetFishingItemConfig(itemId);
			if (fishingItemConfig.Value.TechLength > 0)
			{
				GenericLayout<FishingHandBookTagItem, int> tagItemLayout = this.TagItemLayout;
				if (tagItemLayout != null)
				{
					tagItemLayout.RefreshByData(fishingItemConfig.Value.Tech(), null, false);
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

		// Token: 0x060364A5 RID: 222373 RVA: 0x00F24A64 File Offset: 0x00F22C64
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

		// Token: 0x060364A6 RID: 222374 RVA: 0x00F24D2A File Offset: 0x00F22F2A
		private FishingHandBookItem InitLoopScrollItem()
		{
			return new FishingHandBookItem
			{
				OnClickToggleCallBack = new Action<int, UUIExtendToggle, int>(this.OnClickHandBookItem)
			};
		}

		// Token: 0x060364A7 RID: 222375 RVA: 0x00F24D43 File Offset: 0x00F22F43
		private FishingHandBookTagItem InitTagLayoutItem()
		{
			return new FishingHandBookTagItem();
		}

		// Token: 0x060364A8 RID: 222376 RVA: 0x00F24D4A File Offset: 0x00F22F4A
		private FishingHandBookDesItem InitDesLayoutItem()
		{
			return new FishingHandBookDesItem();
		}

		// Token: 0x060364A9 RID: 222377 RVA: 0x00F24D54 File Offset: 0x00F22F54
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

		// Token: 0x060364AA RID: 222378 RVA: 0x00F24E58 File Offset: 0x00F23058
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

		// Token: 0x060364AB RID: 222379 RVA: 0x00F24EB8 File Offset: 0x00F230B8
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

		// Token: 0x060364AC RID: 222380 RVA: 0x00F24F30 File Offset: 0x00F23130
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

		// Token: 0x060364AD RID: 222381 RVA: 0x00F25048 File Offset: 0x00F23248
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

		// Token: 0x060364AE RID: 222382 RVA: 0x00F250BC File Offset: 0x00F232BC
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

		// Token: 0x0401CA75 RID: 117365
		private int ItemId;

		// Token: 0x0401CA76 RID: 117366
		private List<IFishingHandBookItemData> ItemDataList = new List<IFishingHandBookItemData>();

		// Token: 0x0401CA77 RID: 117367
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401CA78 RID: 117368
		[Nullable(2)]
		private FishingQuestShapePanel FishingShapePanel;

		// Token: 0x0401CA79 RID: 117369
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoopScrollView<FishingHandBookItem, int> HandBookLoopScrollView;

		// Token: 0x0401CA7A RID: 117370
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<FishingHandBookTagItem, int> TagItemLayout;

		// Token: 0x0401CA7B RID: 117371
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<FishingHandBookDesItem, IFishingHandBookDesData> DesLayout;

		// Token: 0x0401CA7C RID: 117372
		[Nullable(2)]
		private UUIExtendToggle CurrentToggle;

		// Token: 0x0401CA7D RID: 117373
		[Nullable(2)]
		private FishingHandBookItem RelationItem;

		// Token: 0x0401CA7E RID: 117374
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FilterSortEntrance<IFishingHandBookItemData> FilterSortBtn;

		// Token: 0x0401CA7F RID: 117375
		private int RelationItemId;

		// Token: 0x0401CA80 RID: 117376
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200B20B RID: 45579
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04037077 RID: 225399
			public const int CaptionItem = 0;

			// Token: 0x04037078 RID: 225400
			public const int ItemLoopScrollView = 1;

			// Token: 0x04037079 RID: 225401
			public const int ItemLoopScrollItem = 2;

			// Token: 0x0403707A RID: 225402
			public const int CollectCountText = 3;

			// Token: 0x0403707B RID: 225403
			public const int EmptyItem = 4;

			// Token: 0x0403707C RID: 225404
			public const int FilterSortItem = 5;

			// Token: 0x0403707D RID: 225405
			public const int ShapePanelItem = 6;

			// Token: 0x0403707E RID: 225406
			public const int ItemStateText = 7;

			// Token: 0x0403707F RID: 225407
			public const int ItemDesText = 8;

			// Token: 0x04037080 RID: 225408
			public const int VariationItem = 9;

			// Token: 0x04037081 RID: 225409
			public const int VariationPanelItem = 10;

			// Token: 0x04037082 RID: 225410
			public const int NumberAndNameText = 11;

			// Token: 0x04037083 RID: 225411
			public const int AreaItem = 12;

			// Token: 0x04037084 RID: 225412
			public const int PositionText = 13;

			// Token: 0x04037085 RID: 225413
			public const int TagLayout = 14;

			// Token: 0x04037086 RID: 225414
			public const int DesVerticalLayout = 15;

			// Token: 0x04037087 RID: 225415
			public const int TraceBtn = 16;

			// Token: 0x04037088 RID: 225416
			public const int LockItem = 17;

			// Token: 0x04037089 RID: 225417
			public const int LockText = 18;

			// Token: 0x0403708A RID: 225418
			public const int NotEmptyItem = 19;

			// Token: 0x0403708B RID: 225419
			public const int VariationText = 20;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067DC RID: 26588
	[NullableContext(1)]
	[Nullable(0)]
	public static class DangoBrawlPlaceUtil
	{
		// Token: 0x06042356 RID: 271190 RVA: 0x0100F11C File Offset: 0x0100D31C
		public static EDangoBrawlPlaceMode EvaluateMode(DangoBrawlBackpackData bag, IDragVisual visual, PanelPos leftTop, EDangoBrawlRotate rotate)
		{
			DangoBrawlPlacementResult dangoBrawlPlacementResult;
			return DangoBrawlPlaceUtil.EvaluateCore(bag, visual, leftTop, rotate, false, out dangoBrawlPlacementResult, false, false);
		}

		// Token: 0x06042357 RID: 271191 RVA: 0x0100F138 File Offset: 0x0100D338
		public static DangoBrawlPlacementResult EvaluatePlan(DangoBrawlBackpackData bag, IDragVisual visual, PanelPos leftTop, EDangoBrawlRotate rotate, bool followerBestEffort = false, bool skipFollowers = false)
		{
			DangoBrawlPlacementResult result;
			DangoBrawlPlaceUtil.EvaluateCore(bag, visual, leftTop, rotate, true, out result, skipFollowers, followerBestEffort);
			return result;
		}

		// Token: 0x06042358 RID: 271192 RVA: 0x0100F158 File Offset: 0x0100D358
		public static EDangoBrawlPlaceMode EvaluatePrimaryMode(DangoBrawlBackpackData bag, IDragVisual visual, PanelPos leftTop, EDangoBrawlRotate rotate)
		{
			DangoBrawlPlacementResult dangoBrawlPlacementResult;
			return DangoBrawlPlaceUtil.EvaluateCore(bag, visual, leftTop, rotate, false, out dangoBrawlPlacementResult, true, false);
		}

		// Token: 0x06042359 RID: 271193 RVA: 0x0100F174 File Offset: 0x0100D374
		private static EDangoBrawlPlaceMode EvaluateCore(DangoBrawlBackpackData bag, IDragVisual visual, PanelPos leftTop, EDangoBrawlRotate rotate, bool collectDetail, [Nullable(2)] out DangoBrawlPlacementResult result, bool skipFollowers = false, bool followerBestEffort = false)
		{
			result = (collectDetail ? new DangoBrawlPlacementResult() : null);
			DangoBrawlBackpackItemData dangoBrawlBackpackItemData;
			if ((dangoBrawlBackpackItemData = bag.GetItem(visual.SourceUid)) == null)
			{
				IDangoBrawlDraggableView draggableItem = visual.DraggableItem;
				dangoBrawlBackpackItemData = (((draggableItem != null) ? draggableItem.MyItemData : null) as DangoBrawlBackpackItemData);
			}
			DangoBrawlBackpackItemData dangoBrawlBackpackItemData2 = dangoBrawlBackpackItemData;
			PanelPos[] primaryPanelPosList = DangoBrawlPlaceUtil.GetPrimaryPanelPosList(visual, rotate, dangoBrawlBackpackItemData2);
			if (primaryPanelPosList == null)
			{
				return DangoBrawlPlaceUtil.FinishMode(result, EDangoBrawlPlaceMode.Cannot);
			}
			List<int> list = DangoBrawlPlaceUtil.CollectExcludeUids(visual);
			if (collectDetail)
			{
				result.PrimaryLeftTop = leftTop;
				result.PrimaryRotate = rotate;
				result.PrimaryDraggingPos = primaryPanelPosList;
				result.PlacedCells = DangoBrawlPlaceUtil.CollectPlacedCells(bag, visual, leftTop, rotate, primaryPanelPosList, dangoBrawlBackpackItemData2);
			}
			List<DangoBrawlBackpackItemData> overlapItems = bag.GetOverlapItems(leftTop, primaryPanelPosList, visual.TemplateType, list.ToArray());
			if (overlapItems == null)
			{
				return DangoBrawlPlaceUtil.FinishMode(result, EDangoBrawlPlaceMode.Cannot);
			}
			if (overlapItems.Count == 0)
			{
				if (!bag.CanPlaceItem(leftTop, primaryPanelPosList, visual.TemplateType, list))
				{
					return DangoBrawlPlaceUtil.FinishMode(result, EDangoBrawlPlaceMode.Cannot);
				}
			}
			else if (visual.TemplateType != EDangoBrawlTemplateType.Bag && !bag.AreAllCellsHaveBag(leftTop, primaryPanelPosList))
			{
				return DangoBrawlPlaceUtil.FinishMode(result, EDangoBrawlPlaceMode.Cannot);
			}
			HashSet<ValueTuple<int, int>> hashSet = (visual.TemplateType == EDangoBrawlTemplateType.Bag) ? DangoBrawlPlaceUtil.BuildAbsCellSet(leftTop, primaryPanelPosList) : null;
			DangoBrawlPlaceUtil.<>c__DisplayClass3_0 CS$<>8__locals1;
			CS$<>8__locals1.seenUids = new HashSet<int>();
			CS$<>8__locals1.evictions = new List<DangoBrawlBackpackItemData>();
			List<int> list2 = new List<int>();
			foreach (DangoBrawlBackpackItemData dangoBrawlBackpackItemData3 in overlapItems)
			{
				DangoBrawlPlaceUtil.<EvaluateCore>g__TryPush|3_0(dangoBrawlBackpackItemData3, ref CS$<>8__locals1);
				if (visual.TemplateType == EDangoBrawlTemplateType.Bag)
				{
					list2.Add(dangoBrawlBackpackItemData3.MyUid);
					HashSet<ValueTuple<int, int>> hashSet2 = DangoBrawlPlaceUtil.BuildAbsCellSet(dangoBrawlBackpackItemData3.MyLeftTopPos, dangoBrawlBackpackItemData3.MyPanelPosList);
					foreach (DangoBrawlBackpackItemData dangoBrawlBackpackItemData4 in bag.GetBagFollowerItems(dangoBrawlBackpackItemData3.MyUid))
					{
						if (!list.Contains(dangoBrawlBackpackItemData4.MyUid))
						{
							bool flag = true;
							if (hashSet != null)
							{
								foreach (PanelPos panelPos in dangoBrawlBackpackItemData4.MyPanelPosList)
								{
									ValueTuple<int, int> item = new ValueTuple<int, int>(dangoBrawlBackpackItemData4.MyLeftTopPos.RowIndex + panelPos.RowIndex, dangoBrawlBackpackItemData4.MyLeftTopPos.ColIndex + panelPos.ColIndex);
									if (hashSet2.Contains(item) && !hashSet.Contains(item))
									{
										flag = false;
										break;
									}
								}
							}
							else
							{
								flag = false;
							}
							if (!flag)
							{
								DangoBrawlPlaceUtil.<EvaluateCore>g__TryPush|3_0(dangoBrawlBackpackItemData4, ref CS$<>8__locals1);
							}
						}
					}
				}
			}
			EDangoBrawlPlaceMode primaryMode = (CS$<>8__locals1.evictions.Count == 0) ? EDangoBrawlPlaceMode.Direct : EDangoBrawlPlaceMode.ByReplace;
			if (collectDetail)
			{
				result.PrimaryMode = primaryMode;
			}
			if (!skipFollowers)
			{
				List<DangoBrawlFollowerVerdict> list3 = collectDetail ? new List<DangoBrawlFollowerVerdict>() : null;
				List<DangoBrawlBackpackItemData> list4 = DangoBrawlPlaceUtil.TryCollectFollowerEvictions(bag, visual, leftTop, rotate, primaryPanelPosList, list, list2, followerBestEffort, list3);
				if (collectDetail)
				{
					result.FollowerVerdicts = list3.ToArray();
				}
				if (list4 == null)
				{
					if (result != null)
					{
						result.Mode = EDangoBrawlPlaceMode.Cannot;
					}
					return EDangoBrawlPlaceMode.Cannot;
				}
				foreach (DangoBrawlBackpackItemData it in list4)
				{
					DangoBrawlPlaceUtil.<EvaluateCore>g__TryPush|3_0(it, ref CS$<>8__locals1);
				}
			}
			EDangoBrawlPlaceMode edangoBrawlPlaceMode = (CS$<>8__locals1.evictions.Count == 0) ? EDangoBrawlPlaceMode.Direct : EDangoBrawlPlaceMode.ByReplace;
			if (!collectDetail)
			{
				return edangoBrawlPlaceMode;
			}
			result.Mode = edangoBrawlPlaceMode;
			result.ItemsToReplace = DangoBrawlPlaceUtil.BuildReplacedItems(CS$<>8__locals1.evictions);
			return edangoBrawlPlaceMode;
		}

		// Token: 0x0604235A RID: 271194 RVA: 0x0100F508 File Offset: 0x0100D708
		[NullableContext(2)]
		private static EDangoBrawlPlaceMode FinishMode(DangoBrawlPlacementResult result, EDangoBrawlPlaceMode mode)
		{
			if (result != null)
			{
				result.Mode = mode;
				result.PrimaryMode = mode;
			}
			return mode;
		}

		// Token: 0x0604235B RID: 271195 RVA: 0x0100F51C File Offset: 0x0100D71C
		private static DangoBrawlReplacedItem[] BuildReplacedItems(List<DangoBrawlBackpackItemData> evictions)
		{
			if (evictions.Count == 0)
			{
				return Array.Empty<DangoBrawlReplacedItem>();
			}
			DangoBrawlReplacedItem[] array = new DangoBrawlReplacedItem[evictions.Count];
			for (int i = 0; i < evictions.Count; i++)
			{
				DangoBrawlBackpackItemData dangoBrawlBackpackItemData = evictions[i];
				array[i] = new DangoBrawlReplacedItem
				{
					Item = dangoBrawlBackpackItemData,
					OwnerUid = dangoBrawlBackpackItemData.MyUid,
					OccupiedCells = DangoBrawlPlaceUtil.AbsCells(dangoBrawlBackpackItemData.MyLeftTopPos, dangoBrawlBackpackItemData.MyPanelPosList)
				};
			}
			return array;
		}

		// Token: 0x0604235C RID: 271196 RVA: 0x0100F59C File Offset: 0x0100D79C
		private static DangoBrawlPlacedCell[] CollectPlacedCells(DangoBrawlBackpackData bag, IDragVisual visual, PanelPos leftTop, EDangoBrawlRotate rotate, PanelPos[] draggingPos, [Nullable(2)] DangoBrawlBackpackItemData primaryItem)
		{
			List<DangoBrawlPlacedCell> list = new List<DangoBrawlPlacedCell>();
			int ownerUid = (visual.SourceUid > 0) ? visual.SourceUid : ((primaryItem != null) ? primaryItem.MyUid : -1);
			foreach (PanelPos panelPos in draggingPos)
			{
				list.Add(new DangoBrawlPlacedCell
				{
					Pos = new PanelPos(leftTop.RowIndex + panelPos.RowIndex, leftTop.ColIndex + panelPos.ColIndex),
					OwnerUid = ownerUid
				});
			}
			List<ValueTuple<DangoBrawlBackpackItemData, PanelPos, PanelPos[]>> list2 = DangoBrawlPlaceUtil.CollectFollowerPlacements(bag, visual, leftTop, rotate);
			if (list2 != null)
			{
				foreach (ValueTuple<DangoBrawlBackpackItemData, PanelPos, PanelPos[]> valueTuple in list2)
				{
					DangoBrawlBackpackItemData item = valueTuple.Item1;
					PanelPos item2 = valueTuple.Item2;
					foreach (PanelPos panelPos2 in valueTuple.Item3)
					{
						list.Add(new DangoBrawlPlacedCell
						{
							Pos = new PanelPos(item2.RowIndex + panelPos2.RowIndex, item2.ColIndex + panelPos2.ColIndex),
							OwnerUid = item.MyUid
						});
					}
				}
			}
			return list.ToArray();
		}

		// Token: 0x0604235D RID: 271197 RVA: 0x0100F700 File Offset: 0x0100D900
		private static PanelPos[] AbsCells(PanelPos leftTop, PanelPos[] rels)
		{
			PanelPos[] array = new PanelPos[rels.Length];
			for (int i = 0; i < rels.Length; i++)
			{
				array[i] = new PanelPos(leftTop.RowIndex + rels[i].RowIndex, leftTop.ColIndex + rels[i].ColIndex);
			}
			return array;
		}

		// Token: 0x0604235E RID: 271198 RVA: 0x0100F758 File Offset: 0x0100D958
		private static List<int> CollectExcludeUids(IDragVisual visual)
		{
			List<int> list = new List<int>();
			if (visual.Source == EDragSourceKind.Bag || visual.Source == EDragSourceKind.Bench)
			{
				list.Add(visual.SourceUid);
			}
			DragPayloadFollower[] followers = visual.Followers;
			for (int i = 0; i < followers.Length; i++)
			{
				DangoBrawlItemBase myItemData = followers[i].View.MyItemData;
				int? num = (myItemData != null) ? new int?(myItemData.MyUid) : null;
				if (num != null && num.Value > 0)
				{
					list.Add(num.Value);
				}
			}
			return list;
		}

		// Token: 0x0604235F RID: 271199 RVA: 0x0100F7E8 File Offset: 0x0100D9E8
		[return: TupleElementNames(new string[]
		{
			"Row",
			"Col"
		})]
		[return: Nullable(new byte[]
		{
			1,
			0
		})]
		private static HashSet<ValueTuple<int, int>> BuildAbsCellSet(PanelPos leftTop, PanelPos[] relPositions)
		{
			HashSet<ValueTuple<int, int>> hashSet = new HashSet<ValueTuple<int, int>>(relPositions.Length);
			foreach (PanelPos panelPos in relPositions)
			{
				hashSet.Add(new ValueTuple<int, int>(leftTop.RowIndex + panelPos.RowIndex, leftTop.ColIndex + panelPos.ColIndex));
			}
			return hashSet;
		}

		// Token: 0x06042360 RID: 271200 RVA: 0x0100F840 File Offset: 0x0100DA40
		[NullableContext(2)]
		private static PanelPos[] GetPrimaryPanelPosList([Nullable(1)] IDragVisual visual, EDangoBrawlRotate rotate, DangoBrawlBackpackItemData item)
		{
			if (visual.ConfigId <= 0)
			{
				return null;
			}
			if (item != null && visual.TemplateType == EDangoBrawlTemplateType.Bag && item.MyRotation == rotate)
			{
				return item.MyPanelPosList;
			}
			return DangoBrawlUtil.RotatePanelPosList(visual.ConfigId, rotate);
		}

		// Token: 0x06042361 RID: 271201 RVA: 0x0100F884 File Offset: 0x0100DA84
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public static List<DangoBrawlBackpackItemData> TryCollectFollowerEvictions(DangoBrawlBackpackData bag, IDragVisual visual, PanelPos targetLT, EDangoBrawlRotate targetRotate, PanelPos[] primaryDraggingPos, IReadOnlyCollection<int> excludeUids, [Nullable(2)] IReadOnlyCollection<int> removedBagUids = null, bool followerBestEffort = false, [Nullable(2)] List<DangoBrawlFollowerVerdict> verdictsOut = null)
		{
			List<DangoBrawlBackpackItemData> list = new List<DangoBrawlBackpackItemData>();
			List<ValueTuple<DangoBrawlBackpackItemData, PanelPos, PanelPos[]>> list2 = DangoBrawlPlaceUtil.CollectFollowerPlacements(bag, visual, targetLT, targetRotate);
			if (list2 == null)
			{
				return null;
			}
			if (list2.Count == 0)
			{
				return list;
			}
			PanelPos[][] panelPosDoublyList = bag.GetPanelPosDoublyList();
			int num = panelPosDoublyList.Length;
			int num2 = (num > 0) ? panelPosDoublyList[0].Length : 0;
			HashSet<ValueTuple<int, int>> hashSet = DangoBrawlPlaceUtil.BuildAbsCellSet(targetLT, primaryDraggingPos);
			HashSet<int> hashSet2 = new HashSet<int>(excludeUids);
			HashSet<int> hashSet3 = (removedBagUids != null) ? new HashSet<int>(removedBagUids) : null;
			HashSet<int> hashSet4 = new HashSet<int>();
			foreach (ValueTuple<DangoBrawlBackpackItemData, PanelPos, PanelPos[]> valueTuple in list2)
			{
				DangoBrawlBackpackItemData item = valueTuple.Item1;
				PanelPos item2 = valueTuple.Item2;
				PanelPos[] item3 = valueTuple.Item3;
				bool flag = true;
				List<DangoBrawlBackpackItemData> list3 = new List<DangoBrawlBackpackItemData>();
				foreach (PanelPos panelPos in item3)
				{
					int num3 = item2.RowIndex + panelPos.RowIndex;
					int num4 = item2.ColIndex + panelPos.ColIndex;
					if (num3 < 0 || num3 >= num || num4 < 0 || num4 >= num2)
					{
						flag = false;
						break;
					}
					PanelPos val = panelPosDoublyList[num3][num4];
					if (!hashSet.Contains(new ValueTuple<int, int>(num3, num4)))
					{
						int bagIdAt = bag.GetBagIdAt(val);
						if (bagIdAt == -1 || hashSet2.Contains(bagIdAt) || (hashSet3 != null && hashSet3.Contains(bagIdAt)))
						{
							flag = false;
							break;
						}
					}
					int bagItemIdAt = bag.GetBagItemIdAt(val);
					if (bagItemIdAt != -1 && !hashSet2.Contains(bagItemIdAt))
					{
						DangoBrawlBackpackItemData item4 = bag.GetItem(bagItemIdAt);
						if (item4 != null)
						{
							list3.Add(item4);
						}
					}
				}
				if (verdictsOut != null)
				{
					verdictsOut.Add(new DangoBrawlFollowerVerdict
					{
						Uid = item.MyUid,
						Mode = ((!flag) ? EDangoBrawlPlaceMode.Cannot : ((list3.Count > 0) ? EDangoBrawlPlaceMode.ByReplace : EDangoBrawlPlaceMode.Direct))
					});
				}
				if (flag)
				{
					using (List<DangoBrawlBackpackItemData>.Enumerator enumerator2 = list3.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							DangoBrawlBackpackItemData dangoBrawlBackpackItemData = enumerator2.Current;
							if (hashSet4.Add(dangoBrawlBackpackItemData.MyUid))
							{
								list.Add(dangoBrawlBackpackItemData);
							}
						}
						continue;
					}
				}
				if (!followerBestEffort)
				{
					return null;
				}
			}
			return list;
		}

		// Token: 0x06042362 RID: 271202 RVA: 0x0100FAF0 File Offset: 0x0100DCF0
		[return: TupleElementNames(new string[]
		{
			"Item",
			"NewLeftTop",
			"PanelPosList"
		})]
		[return: Nullable(new byte[]
		{
			2,
			0,
			1,
			1
		})]
		private static List<ValueTuple<DangoBrawlBackpackItemData, PanelPos, PanelPos[]>> CollectFollowerPlacements(DangoBrawlBackpackData bag, IDragVisual visual, PanelPos targetLT, EDangoBrawlRotate targetRotate)
		{
			List<ValueTuple<DangoBrawlBackpackItemData, PanelPos, PanelPos[]>> list = new List<ValueTuple<DangoBrawlBackpackItemData, PanelPos, PanelPos[]>>();
			if (visual.TemplateType != EDangoBrawlTemplateType.Bag || visual.Followers.Length == 0)
			{
				return list;
			}
			DangoBrawlBackpackItemData dangoBrawlBackpackItemData;
			if ((dangoBrawlBackpackItemData = bag.GetItem(visual.SourceUid)) == null)
			{
				IDangoBrawlDraggableView draggableItem = visual.DraggableItem;
				dangoBrawlBackpackItemData = (((draggableItem != null) ? draggableItem.MyItemData : null) as DangoBrawlBackpackItemData);
			}
			DangoBrawlBackpackItemData dangoBrawlBackpackItemData2 = dangoBrawlBackpackItemData;
			if (dangoBrawlBackpackItemData2 == null)
			{
				return list;
			}
			bool flag = dangoBrawlBackpackItemData2.MyRotation != targetRotate;
			PanelPos rotatedLeftTopPos = DangoBrawlUtil.GetRotatedLeftTopPos(dangoBrawlBackpackItemData2.MyLeftTopPos, dangoBrawlBackpackItemData2.MyRotation, targetRotate, dangoBrawlBackpackItemData2.MyConfigId);
			int num = targetLT.RowIndex - rotatedLeftTopPos.RowIndex;
			int num2 = targetLT.ColIndex - rotatedLeftTopPos.ColIndex;
			foreach (DragPayloadFollower dragPayloadFollower in visual.Followers)
			{
				DangoBrawlItemBase myItemData = dragPayloadFollower.View.MyItemData;
				int? num3 = (myItemData != null) ? new int?(myItemData.MyUid) : null;
				if (num3 != null && num3.Value > 0)
				{
					DangoBrawlBackpackItemData dangoBrawlBackpackItemData3 = bag.GetItem(num3.Value) ?? (dragPayloadFollower.View.MyItemData as DangoBrawlBackpackItemData);
					if (dangoBrawlBackpackItemData3 != null)
					{
						PanelPos item3;
						PanelPos[] array;
						if (flag)
						{
							ValueTuple<PanelPos, EDangoBrawlRotate> valueTuple = DangoBrawlUtil.RotateFollower(dangoBrawlBackpackItemData3, dangoBrawlBackpackItemData2.MyLeftTopPos, dangoBrawlBackpackItemData2.MyConfigId, dangoBrawlBackpackItemData2.MyRotation, targetRotate, num, num2);
							PanelPos item = valueTuple.Item1;
							EDangoBrawlRotate item2 = valueTuple.Item2;
							item3 = item;
							array = DangoBrawlUtil.RotatePanelPosList(dangoBrawlBackpackItemData3.MyConfigId, item2);
							if (array == null)
							{
								return null;
							}
						}
						else
						{
							item3 = new PanelPos(dangoBrawlBackpackItemData3.MyLeftTopPos.RowIndex + num, dangoBrawlBackpackItemData3.MyLeftTopPos.ColIndex + num2);
							array = dangoBrawlBackpackItemData3.MyPanelPosList;
						}
						list.Add(new ValueTuple<DangoBrawlBackpackItemData, PanelPos, PanelPos[]>(dangoBrawlBackpackItemData3, item3, array));
					}
				}
			}
			return list;
		}

		// Token: 0x06042363 RID: 271203 RVA: 0x0100FCA5 File Offset: 0x0100DEA5
		[CompilerGenerated]
		internal static void <EvaluateCore>g__TryPush|3_0(DangoBrawlBackpackItemData it, ref DangoBrawlPlaceUtil.<>c__DisplayClass3_0 A_1)
		{
			if (A_1.seenUids.Add(it.MyUid))
			{
				A_1.evictions.Add(it);
			}
		}
	}
}

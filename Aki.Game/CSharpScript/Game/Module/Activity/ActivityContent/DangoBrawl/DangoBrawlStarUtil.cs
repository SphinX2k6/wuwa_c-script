using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200572E RID: 22318
	[NullableContext(1)]
	[Nullable(0)]
	public static class DangoBrawlStarUtil
	{
		// Token: 0x06036EBF RID: 224959 RVA: 0x00F51308 File Offset: 0x00F4F508
		[NullableContext(2)]
		public static void RefreshStarFillByWorldPos([Nullable(1)] IReadOnlyList<DangoBrawlGeneralStar> stars, IDangoBrawlBagDropZoneExtra bagExtra, ActivityDangoBrawlData actData, int selfUid)
		{
			UUIItem uuiitem = (bagExtra != null) ? bagExtra.GetGridContainer() : null;
			if (uuiitem == null || !uuiitem.IsValid() || ((actData != null) ? actData.BagpackData : null) == null)
			{
				foreach (DangoBrawlGeneralStar dangoBrawlGeneralStar in stars)
				{
					dangoBrawlGeneralStar.SetStarVisible(false);
				}
				return;
			}
			HashSet<int> hashSet = new HashSet<int>();
			bool flag = false;
			DangoBrawlBackpackItemData dangoBrawlBackpackItemData;
			if ((dangoBrawlBackpackItemData = actData.BagpackData.GetItem(selfUid)) == null)
			{
				DangoBrawlBenchData benchData = actData.BenchData;
				dangoBrawlBackpackItemData = ((benchData != null) ? benchData.GetItem(selfUid) : null);
			}
			DangoBrawlItemBase dangoBrawlItemBase = dangoBrawlBackpackItemData;
			if (dangoBrawlItemBase != null)
			{
				DangoBrawlItem? dangoBrawlItemById = DangoBrawlConfig.Instance.GetDangoBrawlItemById(dangoBrawlItemBase.MyConfigId);
				if (dangoBrawlItemById != null)
				{
					flag = dangoBrawlItemById.Value.EffectNoSameItem;
					for (int i = 0; i < dangoBrawlItemById.Value.EffectItemTagLength; i++)
					{
						hashSet.Add(dangoBrawlItemById.Value.EffectItemTag(i));
					}
				}
			}
			FVector lguispaceAbsolutePosition = uuiitem.GetLGUISpaceAbsolutePosition();
			int num = 136;
			List<ValueTuple<int, PanelPos, int>> list = new List<ValueTuple<int, PanelPos, int>>(stars.Count);
			for (int j = 0; j < stars.Count; j++)
			{
				UUIItem rootItem = stars[j].GetRootItem();
				if (rootItem != null && rootItem.IsValid())
				{
					FVector lguispaceAbsolutePosition2 = rootItem.GetLGUISpaceAbsolutePosition();
					float num2 = (lguispaceAbsolutePosition2.X - lguispaceAbsolutePosition.X) / (float)num;
					double num3 = (double)((lguispaceAbsolutePosition.Y - lguispaceAbsolutePosition2.Y) / (float)num);
					int colIndex = (int)Math.Round((double)num2);
					int rowIndex = (int)Math.Round(num3);
					PanelPos panelPos = new PanelPos(rowIndex, colIndex);
					int bagItemIdAt = actData.BagpackData.GetBagItemIdAt(panelPos);
					list.Add(new ValueTuple<int, PanelPos, int>(j, panelPos, bagItemIdAt));
				}
			}
			HashSet<int> hashSet2 = new HashSet<int>();
			HashSet<int> hashSet3 = new HashSet<int>();
			HashSet<int> hashSet4 = new HashSet<int>();
			List<ValueTuple<int, PanelPos, int>> list2 = new List<ValueTuple<int, PanelPos, int>>(list);
			list2.Sort(delegate([TupleElementNames(new string[]
			{
				"Idx",
				"Pos",
				"Uid"
			})] ValueTuple<int, PanelPos, int> a, [TupleElementNames(new string[]
			{
				"Idx",
				"Pos",
				"Uid"
			})] ValueTuple<int, PanelPos, int> b)
			{
				int num4 = a.Item2.RowIndex.CompareTo(b.Item2.RowIndex);
				if (num4 != 0)
				{
					return num4;
				}
				num4 = a.Item2.ColIndex.CompareTo(b.Item2.ColIndex);
				if (num4 == 0)
				{
					return a.Item1.CompareTo(b.Item1);
				}
				return num4;
			});
			foreach (ValueTuple<int, PanelPos, int> valueTuple in list2)
			{
				if (valueTuple.Item3 != -1 && valueTuple.Item3 != selfUid && hashSet3.Add(valueTuple.Item3))
				{
					DangoBrawlBackpackItemData item = actData.BagpackData.GetItem(valueTuple.Item3);
					if (item != null)
					{
						DangoBrawlItem? dangoBrawlItemById2 = DangoBrawlConfig.Instance.GetDangoBrawlItemById(item.MyConfigId);
						if (dangoBrawlItemById2 != null)
						{
							bool flag2 = false;
							for (int k = 0; k < dangoBrawlItemById2.Value.ItemTagsLength; k++)
							{
								if (hashSet.Contains(dangoBrawlItemById2.Value.ItemTags(k)))
								{
									flag2 = true;
									break;
								}
							}
							if (flag2 && (!flag || hashSet4.Add(item.MyConfigId)))
							{
								hashSet2.Add(valueTuple.Item1);
							}
						}
					}
				}
			}
			for (int l = 0; l < stars.Count; l++)
			{
				stars[l].SetStarVisible(hashSet2.Contains(l));
			}
		}

		// Token: 0x06036EC0 RID: 224960 RVA: 0x00F51648 File Offset: 0x00F4F848
		public static void RefreshStarFillByOutLayout(IReadOnlyList<DangoBrawlGeneralStar> stars, IReadOnlyList<PanelPos> starAbsPosList, DangoBrawlOutBackpackItemData selfItem, IReadOnlyList<DangoBrawlOutBackpackItemData> allItems)
		{
			if (stars.Count == 0 || starAbsPosList.Count == 0)
			{
				foreach (DangoBrawlGeneralStar dangoBrawlGeneralStar in stars)
				{
					dangoBrawlGeneralStar.SetStarVisible(false);
				}
				return;
			}
			HashSet<int> hashSet = new HashSet<int>();
			bool flag = false;
			DangoBrawlItem? dangoBrawlItemById = DangoBrawlConfig.Instance.GetDangoBrawlItemById(selfItem.MyConfigId);
			if (dangoBrawlItemById != null)
			{
				flag = dangoBrawlItemById.Value.EffectNoSameItem;
				for (int i = 0; i < dangoBrawlItemById.Value.EffectItemTagLength; i++)
				{
					hashSet.Add(dangoBrawlItemById.Value.EffectItemTag(i));
				}
			}
			int num = DangoBrawlStarUtil.FindOutItemIndex(allItems, selfItem);
			Dictionary<ValueTuple<int, int>, int> dictionary = new Dictionary<ValueTuple<int, int>, int>();
			for (int j = 0; j < allItems.Count; j++)
			{
				DangoBrawlOutBackpackItemData dangoBrawlOutBackpackItemData = allItems[j];
				if (dangoBrawlOutBackpackItemData.MyTemplateType == EDangoBrawlTemplateType.Item)
				{
					PanelPos leftTopPos = dangoBrawlOutBackpackItemData.LeftTopPos;
					foreach (PanelPos panelPos in dangoBrawlOutBackpackItemData.PanelPosList)
					{
						dictionary[new ValueTuple<int, int>(leftTopPos.RowIndex + panelPos.RowIndex, leftTopPos.ColIndex + panelPos.ColIndex)] = j;
					}
				}
			}
			List<ValueTuple<int, PanelPos, int>> list = new List<ValueTuple<int, PanelPos, int>>(starAbsPosList.Count);
			for (int l = 0; l < starAbsPosList.Count; l++)
			{
				PanelPos panelPos2 = starAbsPosList[l];
				int num2;
				int item = dictionary.TryGetValue(new ValueTuple<int, int>(panelPos2.RowIndex, panelPos2.ColIndex), out num2) ? num2 : -1;
				list.Add(new ValueTuple<int, PanelPos, int>(l, panelPos2, item));
			}
			HashSet<int> hashSet2 = new HashSet<int>();
			HashSet<int> hashSet3 = new HashSet<int>();
			HashSet<int> hashSet4 = new HashSet<int>();
			List<ValueTuple<int, PanelPos, int>> list2 = new List<ValueTuple<int, PanelPos, int>>(list);
			list2.Sort(delegate([TupleElementNames(new string[]
			{
				"Idx",
				"Pos",
				"ItemIdx"
			})] ValueTuple<int, PanelPos, int> a, [TupleElementNames(new string[]
			{
				"Idx",
				"Pos",
				"ItemIdx"
			})] ValueTuple<int, PanelPos, int> b)
			{
				int num3 = a.Item2.RowIndex.CompareTo(b.Item2.RowIndex);
				if (num3 != 0)
				{
					return num3;
				}
				num3 = a.Item2.ColIndex.CompareTo(b.Item2.ColIndex);
				if (num3 == 0)
				{
					return a.Item1.CompareTo(b.Item1);
				}
				return num3;
			});
			foreach (ValueTuple<int, PanelPos, int> valueTuple in list2)
			{
				if (valueTuple.Item3 >= 0 && valueTuple.Item3 != num && hashSet3.Add(valueTuple.Item3))
				{
					DangoBrawlOutBackpackItemData dangoBrawlOutBackpackItemData2 = allItems[valueTuple.Item3];
					DangoBrawlItem? dangoBrawlItemById2 = DangoBrawlConfig.Instance.GetDangoBrawlItemById(dangoBrawlOutBackpackItemData2.MyConfigId);
					if (dangoBrawlItemById2 != null)
					{
						bool flag2 = false;
						for (int m = 0; m < dangoBrawlItemById2.Value.ItemTagsLength; m++)
						{
							if (hashSet.Contains(dangoBrawlItemById2.Value.ItemTags(m)))
							{
								flag2 = true;
								break;
							}
						}
						if (flag2 && (!flag || hashSet4.Add(dangoBrawlOutBackpackItemData2.MyConfigId)))
						{
							hashSet2.Add(valueTuple.Item1);
						}
					}
				}
			}
			for (int n = 0; n < stars.Count; n++)
			{
				stars[n].SetStarVisible(hashSet2.Contains(n));
			}
		}

		// Token: 0x06036EC1 RID: 224961 RVA: 0x00F51970 File Offset: 0x00F4FB70
		private static int FindOutItemIndex(IReadOnlyList<DangoBrawlOutBackpackItemData> allItems, DangoBrawlOutBackpackItemData selfItem)
		{
			for (int i = 0; i < allItems.Count; i++)
			{
				DangoBrawlOutBackpackItemData dangoBrawlOutBackpackItemData = allItems[i];
				if (dangoBrawlOutBackpackItemData == selfItem)
				{
					return i;
				}
				if (dangoBrawlOutBackpackItemData.MyConfigId == selfItem.MyConfigId && dangoBrawlOutBackpackItemData.LeftTopPos.RowIndex == selfItem.LeftTopPos.RowIndex && dangoBrawlOutBackpackItemData.LeftTopPos.ColIndex == selfItem.LeftTopPos.ColIndex)
				{
					return i;
				}
			}
			return -1;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067DE RID: 26590
	[NullableContext(1)]
	[Nullable(0)]
	public static class DangoBrawlStarUtil
	{
		// Token: 0x06042369 RID: 271209 RVA: 0x0100FE38 File Offset: 0x0100E038
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
			foreach (ValueTuple<int, PanelPos, int> valueTuple in from s in list
			orderby s.Item2.RowIndex, s.Item2.ColIndex
			select s)
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

		// Token: 0x0604236A RID: 271210 RVA: 0x01010194 File Offset: 0x0100E394
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
			foreach (ValueTuple<int, PanelPos, int> valueTuple in from s in list
			orderby s.Item2.RowIndex, s.Item2.ColIndex
			select s)
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

		// Token: 0x0604236B RID: 271211 RVA: 0x010104D8 File Offset: 0x0100E6D8
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

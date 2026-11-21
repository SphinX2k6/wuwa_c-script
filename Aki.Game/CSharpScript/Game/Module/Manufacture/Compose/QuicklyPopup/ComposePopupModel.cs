using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Item.Data;
using CSharpScript.Game.Module.Manufacture.Common;

namespace CSharpScript.Game.Module.Manufacture.Compose.QuicklyPopup
{
	// Token: 0x02004655 RID: 18005
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class ComposePopupModel : ModelBase
	{
		// Token: 0x0602D477 RID: 185463 RVA: 0x00CAD05C File Offset: 0x00CAB25C
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IComposeItemData> GetComposeMaterialList(int itemId)
		{
			SynthesisFormula? synthesisFormulaByItemId = ComposeConfig.Instance.GetSynthesisFormulaByItemId(itemId);
			if (synthesisFormulaByItemId == null)
			{
				return null;
			}
			List<IComposeItemData> list = new List<IComposeItemData>();
			for (int i = 0; i < synthesisFormulaByItemId.Value.ConsumeItemsLength; i++)
			{
				OneItemConfig? oneItemConfig = synthesisFormulaByItemId.Value.ConsumeItems(i);
				if (oneItemConfig != null)
				{
					list.Add(new IComposeItemData
					{
						ItemId = oneItemConfig.Value.ItemId,
						RequiredNum = oneItemConfig.Value.Count
					});
				}
			}
			return list;
		}

		// Token: 0x0602D478 RID: 185464 RVA: 0x00CAD0F4 File Offset: 0x00CAB2F4
		[NullableContext(2)]
		public int GetMaxCreateCountNormal(int itemId, bool useGift, Dictionary<int, int> usedItemMap = null)
		{
			List<IComposeItemData> composeMaterialList = this.GetComposeMaterialList(itemId);
			int num = useGift ? this.GetMaxGiftExchangeCount(itemId, usedItemMap) : 0;
			if (composeMaterialList == null)
			{
				return num;
			}
			int num2 = int.MaxValue;
			foreach (IComposeItemData composeItemData in composeMaterialList)
			{
				int num3 = InventoryModel.Instance.GetItemCountByConfigId(composeItemData.ItemId, 0) - ((usedItemMap != null) ? usedItemMap.GetValueOrDefault(composeItemData.ItemId, 0) : 0);
				if (useGift)
				{
					num3 += this.GetMaxGiftExchangeCount(composeItemData.ItemId, usedItemMap);
				}
				int val = num3 / composeItemData.RequiredNum;
				num2 = Math.Min(num2, val);
			}
			if (num2 == 2147483647)
			{
				return num;
			}
			return num2 + num;
		}

		// Token: 0x0602D479 RID: 185465 RVA: 0x00CAD1C0 File Offset: 0x00CAB3C0
		[NullableContext(2)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IComposeItemData> CalcMaterialListNormal(int itemId, int count, bool useGift, Dictionary<int, int> usedItemMap = null)
		{
			SynthesisFormula? synthesisFormulaByItemId = ComposeConfig.Instance.GetSynthesisFormulaByItemId(itemId);
			if (synthesisFormulaByItemId == null)
			{
				return null;
			}
			if (count <= 0)
			{
				return new List<IComposeItemData>();
			}
			Dictionary<int, int> dictionary = new Dictionary<int, int>(usedItemMap ?? new Dictionary<int, int>());
			List<IComposeItemData> list = new List<IComposeItemData>();
			int maxCreateCountNormal = this.GetMaxCreateCountNormal(itemId, false, dictionary);
			if (maxCreateCountNormal >= count)
			{
				useGift = false;
			}
			ValueTuple<int, List<IComposeItemData>> valueTuple = this.TryExchangeByGift(itemId, useGift, count, maxCreateCountNormal, dictionary);
			int item = valueTuple.Item1;
			List<IComposeItemData> item2 = valueTuple.Item2;
			this.AccumulateUsedMap(dictionary, item2);
			if (item <= 0)
			{
				return this.MergeDuplicateItems(item2);
			}
			for (int i = 0; i < synthesisFormulaByItemId.Value.ConsumeItemsLength; i++)
			{
				OneItemConfig? oneItemConfig = synthesisFormulaByItemId.Value.ConsumeItems(i);
				if (oneItemConfig != null)
				{
					OneItemConfig value = oneItemConfig.Value;
					int num = value.Count * item;
					int num2 = Math.Min(InventoryModel.Instance.GetItemCountByConfigId(value.ItemId, 0) - dictionary.GetValueOrDefault(value.ItemId, 0), num);
					list.Add(new IComposeItemData
					{
						ItemId = value.ItemId,
						RequiredNum = num2
					});
					dictionary[value.ItemId] = dictionary.GetValueOrDefault(value.ItemId, 0) + num2;
					num -= num2;
					if (useGift && num > 0)
					{
						List<IComposeItemData> list2 = this.CalcGiftExchangeList(value.ItemId, num, null, dictionary);
						if (list2 != null)
						{
							item2.AddRange(list2);
							this.AccumulateUsedMap(dictionary, list2);
							num = 0;
						}
					}
					if (num > 0)
					{
						return null;
					}
				}
			}
			List<IComposeItemData> list3 = list;
			List<IComposeItemData> list4 = item2;
			int num3 = list3.Count + list4.Count;
			List<IComposeItemData> list5 = new List<IComposeItemData>(num3);
			CollectionsMarshal.SetCount<IComposeItemData>(list5, num3);
			Span<IComposeItemData> span = CollectionsMarshal.AsSpan<IComposeItemData>(list5);
			int num4 = 0;
			Span<IComposeItemData> span2 = CollectionsMarshal.AsSpan<IComposeItemData>(list3);
			span2.CopyTo(span.Slice(num4, span2.Length));
			num4 += span2.Length;
			Span<IComposeItemData> span3 = CollectionsMarshal.AsSpan<IComposeItemData>(list4);
			span3.CopyTo(span.Slice(num4, span3.Length));
			num4 += span3.Length;
			return this.MergeDuplicateItems(list5);
		}

		// Token: 0x0602D47A RID: 185466 RVA: 0x00CAD3E8 File Offset: 0x00CAB5E8
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IComposeItemData> GetComposeMaterialListPurification(int itemId)
		{
			SynthesisFormula? synthesisFormulaByItemId = ComposeConfig.Instance.GetSynthesisFormulaByItemId(itemId);
			if (synthesisFormulaByItemId == null)
			{
				return null;
			}
			List<IComposeItemData> list = new List<IComposeItemData>();
			Queue<IComposeItemData> queue = new Queue<IComposeItemData>(4);
			HashSet<int> hashSet = new HashSet<int>();
			for (int i = 0; i < synthesisFormulaByItemId.Value.ConsumeItemsLength; i++)
			{
				OneItemConfig? oneItemConfig = synthesisFormulaByItemId.Value.ConsumeItems(i);
				if (oneItemConfig != null)
				{
					OneItemConfig value = oneItemConfig.Value;
					queue.Push(new IComposeItemData
					{
						ItemId = value.ItemId,
						RequiredNum = value.Count
					});
					hashSet.Add(value.ItemId);
				}
			}
			while (queue.Size > 0)
			{
				IComposeItemData composeItemData = queue.Pop();
				list.Add(composeItemData);
				SynthesisFormula? synthesisFormulaByItemId2 = ComposeConfig.Instance.GetSynthesisFormulaByItemId(composeItemData.ItemId);
				if (synthesisFormulaByItemId2 != null)
				{
					for (int j = 0; j < synthesisFormulaByItemId2.Value.ConsumeItemsLength; j++)
					{
						OneItemConfig? oneItemConfig2 = synthesisFormulaByItemId2.Value.ConsumeItems(j);
						if (oneItemConfig2 != null)
						{
							OneItemConfig value2 = oneItemConfig2.Value;
							int itemId2 = value2.ItemId;
							if (hashSet.Contains(itemId2))
							{
								Log instance = Log.Instance;
								ELogModule module = ELogModule.Compose;
								ELogAuthor author = ELogAuthor.LJ;
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(43, 1);
								defaultInterpolatedStringHandler.AppendLiteral("[ComposePopupModel] 检测到配方合成链条上存在重复的itemId: ");
								defaultInterpolatedStringHandler.AppendFormatted<int>(itemId2);
								instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
								break;
							}
							hashSet.Add(itemId2);
							queue.Push(new IComposeItemData
							{
								ItemId = itemId2,
								RequiredNum = value2.Count * composeItemData.RequiredNum
							});
						}
					}
				}
			}
			return list;
		}

		// Token: 0x0602D47B RID: 185467 RVA: 0x00CAD5B0 File Offset: 0x00CAB7B0
		[NullableContext(2)]
		public Dictionary<int, int> GetLowestLevelExchangeMap(int itemId)
		{
			SynthesisFormula? synthesisFormulaByItemId = ComposeConfig.Instance.GetSynthesisFormulaByItemId(itemId);
			if (synthesisFormulaByItemId == null)
			{
				return null;
			}
			Dictionary<int, ValueTuple<int, int>> dictionary = new Dictionary<int, ValueTuple<int, int>>();
			int? num = null;
			Queue<int> queue = new Queue<int>(4);
			if (synthesisFormulaByItemId.Value.ConsumeItemsLength == 0)
			{
				return null;
			}
			OneItemConfig? oneItemConfig = synthesisFormulaByItemId.Value.ConsumeItems(0);
			if (oneItemConfig != null)
			{
				OneItemConfig value = oneItemConfig.Value;
				queue.Push(value.ItemId);
				dictionary[value.ItemId] = new ValueTuple<int, int>(itemId, value.Count);
				num = new int?(value.ItemId);
			}
			while (queue.Size > 0)
			{
				int num2 = queue.Pop();
				SynthesisFormula? synthesisFormulaByItemId2 = ComposeConfig.Instance.GetSynthesisFormulaByItemId(num2);
				if (synthesisFormulaByItemId2 != null && synthesisFormulaByItemId2.Value.ConsumeItemsLength != 0)
				{
					OneItemConfig? oneItemConfig2 = synthesisFormulaByItemId2.Value.ConsumeItems(0);
					if (oneItemConfig2 != null)
					{
						OneItemConfig value2 = oneItemConfig2.Value;
						if (dictionary.ContainsKey(value2.ItemId))
						{
							Log instance = Log.Instance;
							ELogModule module = ELogModule.Compose;
							ELogAuthor author = ELogAuthor.LJ;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(43, 1);
							defaultInterpolatedStringHandler.AppendLiteral("[ComposePopupModel] 检测到配方合成链条上存在重复的itemId: ");
							defaultInterpolatedStringHandler.AppendFormatted<int>(value2.ItemId);
							instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
						}
						else
						{
							queue.Push(value2.ItemId);
							dictionary[value2.ItemId] = new ValueTuple<int, int>(num2, value2.Count);
							num = new int?(value2.ItemId);
						}
					}
				}
			}
			Dictionary<int, int> dictionary2 = new Dictionary<int, int>();
			dictionary2[num.Value] = 1;
			while (dictionary.ContainsKey(num.Value))
			{
				ValueTuple<int, int> valueTuple = dictionary[num.Value];
				dictionary2[valueTuple.Item1] = dictionary2[num.Value] * valueTuple.Item2;
				num = new int?(valueTuple.Item1);
			}
			return dictionary2;
		}

		// Token: 0x0602D47C RID: 185468 RVA: 0x00CAD7C4 File Offset: 0x00CAB9C4
		[NullableContext(2)]
		public int GetMaxCreateCountPurification(int itemId, bool useGift, Dictionary<int, int> usedItemMap = null)
		{
			bool composeMaterialListPurification = this.GetComposeMaterialListPurification(itemId) != null;
			int num = useGift ? this.GetMaxGiftExchangeCount(itemId, usedItemMap) : 0;
			if (!composeMaterialListPurification)
			{
				return num;
			}
			Dictionary<int, int> lowestLevelExchangeMap = this.GetLowestLevelExchangeMap(itemId);
			int num2 = 0;
			foreach (IComposeItemData composeItemData in this.GetComposeMaterialListPurification(itemId))
			{
				int itemId2 = composeItemData.ItemId;
				int num3 = InventoryModel.Instance.GetItemCountByConfigId(itemId2, 0) - ((usedItemMap != null) ? usedItemMap.GetValueOrDefault(itemId2, 0) : 0);
				num2 += num3 * lowestLevelExchangeMap[itemId2];
				if (useGift)
				{
					int maxGiftExchangeCount = this.GetMaxGiftExchangeCount(itemId2, usedItemMap);
					num2 += maxGiftExchangeCount * lowestLevelExchangeMap[itemId2];
				}
			}
			return num2 / lowestLevelExchangeMap[itemId] + num;
		}

		// Token: 0x0602D47D RID: 185469 RVA: 0x00CAD890 File Offset: 0x00CABA90
		[NullableContext(2)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IComposeItemData> CalcMaterialListPurification(int itemId, int count, bool useGift, Dictionary<int, int> usedItemMap = null)
		{
			if (ComposeConfig.Instance.GetSynthesisFormulaByItemId(itemId) == null)
			{
				if (!useGift)
				{
					return null;
				}
				return this.CalcGiftExchangeList(itemId, count, null, usedItemMap);
			}
			else
			{
				Dictionary<int, int> dictionary = new Dictionary<int, int>(usedItemMap ?? new Dictionary<int, int>());
				List<IComposeItemData> list = new List<IComposeItemData>();
				int maxCreateCountPurification = this.GetMaxCreateCountPurification(itemId, false, dictionary);
				if (maxCreateCountPurification >= count)
				{
					useGift = false;
				}
				ValueTuple<int, List<IComposeItemData>> valueTuple = this.TryExchangeByGift(itemId, useGift, count, maxCreateCountPurification, dictionary);
				int item = valueTuple.Item1;
				List<IComposeItemData> item2 = valueTuple.Item2;
				this.AccumulateUsedMap(dictionary, item2);
				if (item <= 0)
				{
					return this.MergeDuplicateItems(item2);
				}
				Dictionary<int, int> lowestLevelExchangeMap = this.GetLowestLevelExchangeMap(itemId);
				int num = lowestLevelExchangeMap[itemId] * item;
				foreach (IComposeItemData composeItemData in this.GetComposeMaterialListPurification(itemId))
				{
					int itemId2 = composeItemData.ItemId;
					int num2 = lowestLevelExchangeMap[itemId2];
					int num3 = InventoryModel.Instance.GetItemCountByConfigId(itemId2, 0) - dictionary.GetValueOrDefault(itemId2, 0);
					if (num3 > 0)
					{
						int num4 = Math.Min(num3, num / num2);
						list.Add(new IComposeItemData
						{
							ItemId = itemId2,
							RequiredNum = num4
						});
						dictionary[itemId2] = dictionary.GetValueOrDefault(itemId2, 0) + num4;
						num -= num4 * num2;
					}
					if (useGift && num > 0)
					{
						int maxGiftExchangeCount = this.GetMaxGiftExchangeCount(itemId2, dictionary);
						if (maxGiftExchangeCount > 0)
						{
							int num5 = Math.Min(maxGiftExchangeCount, num / num2);
							List<IComposeItemData> list2 = this.CalcGiftExchangeList(itemId2, num5, null, dictionary);
							item2.AddRange(list2);
							this.AccumulateUsedMap(dictionary, list2);
							num -= num5 * num2;
						}
					}
					if (num <= 0)
					{
						break;
					}
				}
				if (num > 0)
				{
					return null;
				}
				List<IComposeItemData> list3 = list;
				List<IComposeItemData> list4 = item2;
				int num6 = list3.Count + list4.Count;
				List<IComposeItemData> list5 = new List<IComposeItemData>(num6);
				CollectionsMarshal.SetCount<IComposeItemData>(list5, num6);
				Span<IComposeItemData> span = CollectionsMarshal.AsSpan<IComposeItemData>(list5);
				int num7 = 0;
				Span<IComposeItemData> span2 = CollectionsMarshal.AsSpan<IComposeItemData>(list3);
				span2.CopyTo(span.Slice(num7, span2.Length));
				num7 += span2.Length;
				Span<IComposeItemData> span3 = CollectionsMarshal.AsSpan<IComposeItemData>(list4);
				span3.CopyTo(span.Slice(num7, span3.Length));
				num7 += span3.Length;
				return this.MergeDuplicateItems(list5);
			}
		}

		// Token: 0x0602D47E RID: 185470 RVA: 0x00CADAF0 File Offset: 0x00CABCF0
		[NullableContext(2)]
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		private ValueTuple<int, List<IComposeItemData>> TryExchangeByGift(int itemId, bool useGift, int count, int maxMakeCount, Dictionary<int, int> usedItemMap = null)
		{
			if (useGift && maxMakeCount < count)
			{
				int num = Math.Min(this.GetMaxGiftExchangeCount(itemId, usedItemMap), count);
				List<IComposeItemData> list = this.CalcGiftExchangeList(itemId, num, null, usedItemMap);
				if (num > 0 && list != null)
				{
					return new ValueTuple<int, List<IComposeItemData>>(count - num, list);
				}
			}
			return new ValueTuple<int, List<IComposeItemData>>(count, new List<IComposeItemData>());
		}

		// Token: 0x0602D47F RID: 185471 RVA: 0x00CADB48 File Offset: 0x00CABD48
		[NullableContext(2)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ISelectedData> GetExchangeItemDataList(int itemId, int count, Dictionary<int, int> usedItemMap = null)
		{
			IReadOnlyList<MaterialReplace> exchangeList = ComposeConfig.Instance.GetExchangeList();
			if (exchangeList == null)
			{
				return null;
			}
			MaterialReplace? materialReplace = null;
			foreach (MaterialReplace value in exchangeList)
			{
				if (value.ItemId == itemId)
				{
					materialReplace = new MaterialReplace?(value);
					break;
				}
			}
			if (materialReplace == null)
			{
				return null;
			}
			List<ISingleItemInfo> list = ComposeModel.Instance.GetExchangeMaterialListByGroupId(materialReplace.Value.GroupId).FindAll((ISingleItemInfo item) => item.Proto_ItemId != itemId && this.CanUseAsExchangeMaterial(item.Proto_ItemId, itemId));
			int exchangeCountByData = ComposeModel.Instance.GetExchangeCountByData(ComposeModel.Instance.GetExchangeDataById(itemId));
			if (list == null || list.Count == 0)
			{
				return null;
			}
			Dictionary<int, int> availableMap = new Dictionary<int, int>();
			foreach (ISingleItemInfo singleItemInfo in list)
			{
				int num = (usedItemMap != null) ? usedItemMap.GetValueOrDefault(singleItemInfo.Proto_ItemId, 0) : 0;
				availableMap[singleItemInfo.Proto_ItemId] = Math.Max(0, singleItemInfo.Proto_ItemNum - num);
			}
			list.Sort(delegate(ISingleItemInfo a, ISingleItemInfo b)
			{
				int num6 = availableMap[a.Proto_ItemId];
				int num7 = availableMap[b.Proto_ItemId];
				if (num6 != num7)
				{
					return num7 - num6;
				}
				return a.Proto_ItemId - b.Proto_ItemId;
			});
			int num2 = 0;
			foreach (ISingleItemInfo singleItemInfo2 in list)
			{
				num2 += availableMap[singleItemInfo2.Proto_ItemId] / exchangeCountByData;
			}
			if (num2 < count)
			{
				return null;
			}
			List<ISelectedData> list2 = new List<ISelectedData>();
			int num3 = count;
			foreach (ISingleItemInfo singleItemInfo3 in list)
			{
				if (num3 <= 0)
				{
					break;
				}
				int num4 = availableMap[singleItemInfo3.Proto_ItemId] / exchangeCountByData;
				if (num4 > 0)
				{
					int num5 = Math.Min(num4, num3);
					list2.Add(new SelectedData
					{
						ItemId = singleItemInfo3.Proto_ItemId,
						IncId = 0,
						Count = num5 * exchangeCountByData,
						SelectedCount = singleItemInfo3.Proto_ItemNum
					});
					num3 -= num5;
				}
			}
			return list2;
		}

		// Token: 0x0602D480 RID: 185472 RVA: 0x00CADDD4 File Offset: 0x00CABFD4
		private bool CanUseAsExchangeMaterial(int materialItemId, int targetItemId)
		{
			IReadOnlyList<MaterialReplace> exchangeList = ComposeConfig.Instance.GetExchangeList();
			if (exchangeList == null)
			{
				return true;
			}
			MaterialReplace? materialReplace = null;
			foreach (MaterialReplace value in exchangeList)
			{
				if (value.ItemId == materialItemId)
				{
					materialReplace = new MaterialReplace?(value);
					break;
				}
			}
			if (materialReplace == null)
			{
				return true;
			}
			ExchangeParam? exchangeParamById = ComposeConfig.Instance.GetExchangeParamById(materialReplace.Value.ExchangeParam);
			if (exchangeParamById == null)
			{
				return true;
			}
			if (!exchangeParamById.Value.IsSingleDirection)
			{
				return true;
			}
			IntPair? target = exchangeParamById.Value.Target;
			return target != null && target.Value.Item1 == targetItemId;
		}

		// Token: 0x0602D481 RID: 185473 RVA: 0x00CADEBC File Offset: 0x00CAC0BC
		[NullableContext(2)]
		public int GetMaxGiftExchangeCount(int itemId, Dictionary<int, int> usedItemMap = null)
		{
			int num = 0;
			foreach (int num2 in ItemAccessedFromGiftPathConfig.Instance.GetGiftItemGroupById(itemId, true))
			{
				int num3 = InventoryModel.Instance.GetItemCountByConfigId(num2, 0) - ((usedItemMap != null) ? usedItemMap.GetValueOrDefault(num2, 0) : 0);
				if (num3 > 0)
				{
					int giftInnerCount = this.GetGiftInnerCount(num2, itemId);
					num += giftInnerCount * num3;
				}
			}
			return num;
		}

		// Token: 0x0602D482 RID: 185474 RVA: 0x00CADF44 File Offset: 0x00CAC144
		[NullableContext(2)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IComposeItemData> CalcGiftExchangeList(int itemId, int count, bool? sortLowToHigh = null, Dictionary<int, int> usedItemMap = null)
		{
			int maxGiftExchangeCount = this.GetMaxGiftExchangeCount(itemId, usedItemMap);
			if (count > maxGiftExchangeCount)
			{
				return null;
			}
			List<IComposeItemData> list = new List<IComposeItemData>();
			List<int> giftItemGroupById = ItemAccessedFromGiftPathConfig.Instance.GetGiftItemGroupById(itemId, true);
			if (sortLowToHigh != null)
			{
				giftItemGroupById.Sort(delegate(int a, int b)
				{
					ItemInfo? config = ItemConfig.Instance.GetConfig(a);
					ItemInfo? config2 = ItemConfig.Instance.GetConfig(b);
					if (!sortLowToHigh.Value)
					{
						return config2.Value.QualityId - config.Value.QualityId;
					}
					return config.Value.QualityId - config2.Value.QualityId;
				});
			}
			foreach (int num in giftItemGroupById)
			{
				int num2 = InventoryModel.Instance.GetItemCountByConfigId(num, 0) - ((usedItemMap != null) ? usedItemMap.GetValueOrDefault(num, 0) : 0);
				if (num2 > 0)
				{
					int giftInnerCount = this.GetGiftInnerCount(num, itemId);
					int num3 = (int)Math.Ceiling((double)count / (double)giftInnerCount);
					num3 = Math.Min(num3, num2);
					list.Add(new IComposeItemData
					{
						ItemId = num,
						RequiredNum = num3
					});
					count -= num3 * giftInnerCount;
					if (count <= 0)
					{
						return list;
					}
				}
			}
			return list;
		}

		// Token: 0x0602D483 RID: 185475 RVA: 0x00CAE060 File Offset: 0x00CAC260
		public int GetGiftInnerCount(int giftItemId, int targetItemId)
		{
			GiftPackage? giftPackageConfig = GiftPackageConfig.Instance.GetGiftPackageConfig(ItemConfig.Instance.GetConfig(giftItemId).Value.Parameters(0).Value.Value);
			return ((giftPackageConfig != null) ? giftPackageConfig.GetValueOrDefault().GetContent(targetItemId) : null).GetValueOrDefault();
		}

		// Token: 0x0602D484 RID: 185476 RVA: 0x00CAE0D4 File Offset: 0x00CAC2D4
		public int GetMaxCreateCount(int itemId, bool useGift)
		{
			SynthesisFormula? synthesisFormulaByItemId = ComposeConfig.Instance.GetSynthesisFormulaByItemId(itemId);
			if (synthesisFormulaByItemId == null)
			{
				if (!useGift)
				{
					return 0;
				}
				return this.GetMaxGiftExchangeCount(itemId, null);
			}
			else
			{
				if (synthesisFormulaByItemId.Value.FormulaType == 3)
				{
					return this.GetMaxCreateCountPurification(itemId, useGift, null);
				}
				return this.GetMaxCreateCountNormal(itemId, useGift, null);
			}
		}

		// Token: 0x0602D485 RID: 185477 RVA: 0x00CAE12C File Offset: 0x00CAC32C
		[NullableContext(2)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IComposeItemData> CalcComposeList(int itemId, int count, bool useGift, Dictionary<int, int> usedItemMap = null)
		{
			SynthesisFormula? synthesisFormulaByItemId = ComposeConfig.Instance.GetSynthesisFormulaByItemId(itemId);
			if (synthesisFormulaByItemId == null)
			{
				if (!useGift)
				{
					return null;
				}
				return this.CalcGiftExchangeList(itemId, count, null, usedItemMap);
			}
			else
			{
				if (synthesisFormulaByItemId.Value.FormulaType == 3)
				{
					return this.CalcMaterialListPurification(itemId, count, useGift, usedItemMap);
				}
				return this.CalcMaterialListNormal(itemId, count, useGift, usedItemMap);
			}
		}

		// Token: 0x0602D486 RID: 185478 RVA: 0x00CAE190 File Offset: 0x00CAC390
		public List<IComposePopupGridItemData> CalcComposeListAll(List<ISelectedData> selectedItemList, bool useGift)
		{
			List<IComposePopupGridItemData> list = new List<IComposePopupGridItemData>(selectedItemList.Count);
			for (int i = 0; i < selectedItemList.Count; i++)
			{
				list.Add(null);
			}
			Dictionary<int, int> usedItemMap = new Dictionary<int, int>();
			List<int> list2 = new List<int>();
			for (int j = 0; j < selectedItemList.Count; j++)
			{
				list2.Add(j);
			}
			list2.Sort(delegate(int a, int b)
			{
				ItemInfo? config = ItemConfig.Instance.GetConfig(selectedItemList[a].ItemId);
				int num2 = (config != null) ? config.GetValueOrDefault().QualityId : 0;
				config = ItemConfig.Instance.GetConfig(selectedItemList[b].ItemId);
				int num3 = (config != null) ? config.GetValueOrDefault().QualityId : 0;
				return num2 - num3;
			});
			Action<ISelectedData> <>9__1;
			foreach (int index in list2)
			{
				ISelectedData selectedData = selectedItemList[index];
				int valueOrDefault = usedItemMap.GetValueOrDefault(selectedData.ItemId, 0);
				IComposePopupGridItemData composePopupGridItemData;
				if (selectedData.Count - selectedData.SelectedCount + valueOrDefault <= 0)
				{
					composePopupGridItemData = new IComposePopupGridItemData
					{
						Item = selectedData,
						State = EGridState.Enough
					};
				}
				else if (ComposeConfig.Instance.GetSynthesisFormulaByItemId(selectedData.ItemId) == null)
				{
					composePopupGridItemData = this.HandleNonFormulaMaterial(selectedData, useGift, usedItemMap);
				}
				else
				{
					composePopupGridItemData = this.HandleFormulaMaterial(selectedData, useGift, usedItemMap);
				}
				composePopupGridItemData.UsedCount = new int?(valueOrDefault);
				list[index] = composePopupGridItemData;
				if (composePopupGridItemData.State != EGridState.NotEnough)
				{
					int num = Math.Min(selectedData.Count, Math.Max(0, selectedData.SelectedCount - valueOrDefault));
					if (num > 0)
					{
						int valueOrDefault2 = usedItemMap.GetValueOrDefault(selectedData.ItemId, 0);
						usedItemMap[selectedData.ItemId] = valueOrDefault2 + num;
					}
					List<ISelectedData> composeList = composePopupGridItemData.ComposeList;
					if (composeList != null)
					{
						Action<ISelectedData> action;
						if ((action = <>9__1) == null)
						{
							action = (<>9__1 = delegate(ISelectedData item)
							{
								int valueOrDefault3 = usedItemMap.GetValueOrDefault(item.ItemId, 0);
								usedItemMap[item.ItemId] = valueOrDefault3 + item.Count;
							});
						}
						composeList.ForEach(action);
					}
				}
			}
			return list;
		}

		// Token: 0x0602D487 RID: 185479 RVA: 0x00CAE3A8 File Offset: 0x00CAC5A8
		private IComposePopupGridItemData HandleFormulaMaterial(ISelectedData selectedItem, bool useGift, [Nullable(2)] Dictionary<int, int> usedItemMap = null)
		{
			int num = (usedItemMap != null) ? usedItemMap.GetValueOrDefault(selectedItem.ItemId, 0) : 0;
			int num2 = selectedItem.Count - selectedItem.SelectedCount + num;
			if (num2 <= 0)
			{
				return new IComposePopupGridItemData
				{
					Item = selectedItem,
					State = EGridState.Enough,
					UsedCount = new int?(num)
				};
			}
			if (useGift)
			{
				List<IComposeItemData> list = this.CalcComposeList(selectedItem.ItemId, num2, true, usedItemMap);
				if (list != null && list.Count > 0)
				{
					return new IComposePopupGridItemData
					{
						Item = selectedItem,
						State = EGridState.Purification,
						ComposeList = this.ConvertToSelectedData(list)
					};
				}
			}
			List<IComposeItemData> list2 = this.CalcComposeList(selectedItem.ItemId, num2, false, usedItemMap);
			if (list2 != null && list2.Count > 0)
			{
				return new IComposePopupGridItemData
				{
					Item = selectedItem,
					State = EGridState.Purification,
					ComposeList = this.ConvertToSelectedData(list2)
				};
			}
			List<ISelectedData> exchangeItemDataList = this.GetExchangeItemDataList(selectedItem.ItemId, num2, usedItemMap);
			if (exchangeItemDataList != null)
			{
				return new IComposePopupGridItemData
				{
					Item = selectedItem,
					State = EGridState.Exchange,
					ComposeList = exchangeItemDataList
				};
			}
			return new IComposePopupGridItemData
			{
				Item = selectedItem,
				State = EGridState.NotEnough
			};
		}

		// Token: 0x0602D488 RID: 185480 RVA: 0x00CAE4C0 File Offset: 0x00CAC6C0
		private IComposePopupGridItemData HandleNonFormulaMaterial(ISelectedData selectedItem, bool useGift, [Nullable(2)] Dictionary<int, int> usedItemMap = null)
		{
			int num = (usedItemMap != null) ? usedItemMap.GetValueOrDefault(selectedItem.ItemId, 0) : 0;
			int num2 = selectedItem.Count - selectedItem.SelectedCount + num;
			if (useGift)
			{
				int maxGiftExchangeCount = this.GetMaxGiftExchangeCount(selectedItem.ItemId, usedItemMap);
				List<IComposeItemData> list;
				if (selectedItem.ItemId == 2)
				{
					list = this.CalcGiftExchangeList(selectedItem.ItemId, num2, new bool?(true), usedItemMap);
				}
				else
				{
					list = this.CalcGiftExchangeList(selectedItem.ItemId, num2, null, usedItemMap);
				}
				if (list != null && list.Count > 0 && maxGiftExchangeCount >= num2)
				{
					return new IComposePopupGridItemData
					{
						Item = selectedItem,
						State = EGridState.Purification,
						ComposeList = this.ConvertToSelectedData(list)
					};
				}
			}
			List<ISelectedData> exchangeItemDataList = this.GetExchangeItemDataList(selectedItem.ItemId, num2, usedItemMap);
			if (exchangeItemDataList != null)
			{
				return new IComposePopupGridItemData
				{
					Item = selectedItem,
					State = EGridState.Exchange,
					ComposeList = exchangeItemDataList
				};
			}
			return new IComposePopupGridItemData
			{
				Item = selectedItem,
				State = EGridState.NotEnough
			};
		}

		// Token: 0x0602D489 RID: 185481 RVA: 0x00CAE5B8 File Offset: 0x00CAC7B8
		[return: TupleElementNames(new string[]
		{
			"Result",
			"GridDataList"
		})]
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public ValueTuple<EComposeCheckResult, List<IComposePopupGridItemData>> CheckComposeResult(List<ISelectedData> selectedItemList, bool useGift, bool ignoreEnough = false)
		{
			List<IComposePopupGridItemData> list = this.CalcComposeListAll(selectedItemList, useGift);
			bool flag = true;
			bool flag2 = false;
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			foreach (IComposePopupGridItemData composePopupGridItemData in list)
			{
				switch (composePopupGridItemData.State)
				{
				case EGridState.Purification:
					flag2 = true;
					break;
				case EGridState.Exchange:
					flag2 = true;
					flag = false;
					break;
				case EGridState.Enough:
					if (!ignoreEnough)
					{
						flag2 = true;
					}
					break;
				case EGridState.NotEnough:
					flag = false;
					break;
				}
				if (composePopupGridItemData.ComposeList != null)
				{
					foreach (ISelectedData selectedData in composePopupGridItemData.ComposeList)
					{
						int valueOrDefault = dictionary.GetValueOrDefault(selectedData.ItemId, 0);
						dictionary[selectedData.ItemId] = valueOrDefault + selectedData.Count;
					}
				}
			}
			EComposeCheckResult? ecomposeCheckResult = null;
			if (!flag2)
			{
				ecomposeCheckResult = new EComposeCheckResult?(EComposeCheckResult.CannotCompose);
			}
			else
			{
				bool flag3 = true;
				foreach (KeyValuePair<int, int> keyValuePair in dictionary)
				{
					int num;
					int num2;
					keyValuePair.Deconstruct(out num, out num2);
					int itemConfigId = num;
					int num3 = num2;
					if (InventoryModel.Instance.GetItemCountByConfigId(itemConfigId, 0) < num3)
					{
						flag3 = false;
						break;
					}
				}
				if (flag3 && flag)
				{
					ecomposeCheckResult = new EComposeCheckResult?(EComposeCheckResult.CanComposeAll);
				}
				else
				{
					ecomposeCheckResult = new EComposeCheckResult?(EComposeCheckResult.CanComposePartial);
				}
			}
			return new ValueTuple<EComposeCheckResult, List<IComposePopupGridItemData>>(ecomposeCheckResult.Value, list);
		}

		// Token: 0x0602D48A RID: 185482 RVA: 0x00CAE75C File Offset: 0x00CAC95C
		public bool CheckOpenResult(List<ISelectedData> selectedData)
		{
			return this.CheckComposeResult(selectedData, true, true).Item1 != EComposeCheckResult.CannotCompose;
		}

		// Token: 0x0602D48B RID: 185483 RVA: 0x00CAE774 File Offset: 0x00CAC974
		public bool IsComposeGiftShouldShow(List<ISelectedData> selectedData)
		{
			List<IComposePopupGridItemData> list = this.CalcComposeListAll(selectedData, false);
			List<IComposePopupGridItemData> list2 = this.CalcComposeListAll(selectedData, true);
			int num = Math.Min(list.Count, list2.Count);
			for (int i = 0; i < num; i++)
			{
				EGridState state = list[i].State;
				EGridState state2 = list2[i].State;
				bool flag = state == EGridState.NotEnough || state == EGridState.Exchange;
				bool flag2 = state2 == EGridState.Purification || state2 == EGridState.Enough;
				if (flag && flag2)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602D48C RID: 185484 RVA: 0x00CAE7F0 File Offset: 0x00CAC9F0
		private void AccumulateUsedMap(Dictionary<int, int> map, List<IComposeItemData> items)
		{
			foreach (IComposeItemData composeItemData in items)
			{
				map[composeItemData.ItemId] = map.GetValueOrDefault(composeItemData.ItemId, 0) + composeItemData.RequiredNum;
			}
		}

		// Token: 0x0602D48D RID: 185485 RVA: 0x00CAE858 File Offset: 0x00CACA58
		private List<IComposeItemData> MergeDuplicateItems(List<IComposeItemData> items)
		{
			Dictionary<int, IComposeItemData> dictionary = new Dictionary<int, IComposeItemData>();
			List<IComposeItemData> list = new List<IComposeItemData>();
			foreach (IComposeItemData composeItemData in items)
			{
				IComposeItemData composeItemData2;
				if (dictionary.TryGetValue(composeItemData.ItemId, out composeItemData2))
				{
					composeItemData2.RequiredNum += composeItemData.RequiredNum;
				}
				else
				{
					dictionary[composeItemData.ItemId] = composeItemData;
					list.Add(composeItemData);
				}
			}
			return list;
		}

		// Token: 0x0602D48E RID: 185486 RVA: 0x00CAE8E8 File Offset: 0x00CACAE8
		public List<ISelectedData> MergeDuplicateSelectedData(List<ISelectedData> items)
		{
			Dictionary<int, ISelectedData> dictionary = new Dictionary<int, ISelectedData>();
			List<ISelectedData> list = new List<ISelectedData>();
			foreach (ISelectedData selectedData in items)
			{
				ISelectedData selectedData2;
				if (dictionary.TryGetValue(selectedData.ItemId, out selectedData2))
				{
					selectedData2.Count += selectedData.Count;
				}
				else
				{
					dictionary[selectedData.ItemId] = selectedData;
					list.Add(selectedData);
				}
			}
			return list;
		}

		// Token: 0x0602D48F RID: 185487 RVA: 0x00CAE978 File Offset: 0x00CACB78
		public List<ISelectedData> ConvertToSelectedData(List<IComposeItemData> data)
		{
			List<ISelectedData> list = new List<ISelectedData>();
			foreach (IComposeItemData composeItemData in data)
			{
				list.Add(new SelectedData
				{
					ItemId = composeItemData.ItemId,
					IncId = 0,
					Count = composeItemData.RequiredNum,
					SelectedCount = InventoryModel.Instance.GetItemCountByConfigId(composeItemData.ItemId, 0)
				});
			}
			return list;
		}

		// Token: 0x17005B38 RID: 23352
		// (get) Token: 0x0602D490 RID: 185488 RVA: 0x00CAEA08 File Offset: 0x00CACC08
		public static ComposePopupModel Instance
		{
			get
			{
				return ComposePopupModel._Instance;
			}
		}

		// Token: 0x0602D491 RID: 185489 RVA: 0x00CAEA0F File Offset: 0x00CACC0F
		public static ComposePopupModel GetOrCreateInstance()
		{
			if (ComposePopupModel._Instance == null)
			{
				ComposePopupModel.CreateInstance();
			}
			return ComposePopupModel._Instance;
		}

		// Token: 0x0602D492 RID: 185490 RVA: 0x00CAEA23 File Offset: 0x00CACC23
		public static bool CreateInstance()
		{
			if (ComposePopupModel._Instance != null)
			{
				return true;
			}
			ComposePopupModel._Instance = new ComposePopupModel();
			return true;
		}

		// Token: 0x0602D493 RID: 185491 RVA: 0x00CAEA39 File Offset: 0x00CACC39
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602D494 RID: 185492 RVA: 0x00CAEA3B File Offset: 0x00CACC3B
		public static void ResetStaticDefaultValue()
		{
			ComposePopupModel._Instance = null;
		}

		// Token: 0x0602D495 RID: 185493 RVA: 0x00CAEA43 File Offset: 0x00CACC43
		static ComposePopupModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ComposePopupModel.CreateStaticDefaultValue), new Action(ComposePopupModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401845B RID: 99419
		[Nullable(2)]
		private static ComposePopupModel _Instance;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005718 RID: 22296
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlBackpackData
	{
		// Token: 0x170069FD RID: 27133
		// (get) Token: 0x06036DED RID: 224749 RVA: 0x00F4C6A9 File Offset: 0x00F4A8A9
		public int MyActivityId
		{
			get
			{
				return this.ActivityId;
			}
		}

		// Token: 0x06036DEE RID: 224750 RVA: 0x00F4C6B1 File Offset: 0x00F4A8B1
		public void Init(int activityId, DangoBrawlBackPackServerData serverData)
		{
			this.ActivityId = activityId;
			this.InitPanelPosDoublyList();
			this.InitGridDataMap();
			this.InitItemBlockDataMap(serverData);
		}

		// Token: 0x06036DEF RID: 224751 RVA: 0x00F4C6D0 File Offset: 0x00F4A8D0
		private void InitPanelPosDoublyList()
		{
			DangoBrawlGridSize panelSizeById = DangoBrawlConfig.Instance.GetPanelSizeById(this.ActivityId);
			this.PanelPosDoublyList = new PanelPos[panelSizeById.Height][];
			for (int i = 0; i < panelSizeById.Height; i++)
			{
				this.PanelPosDoublyList[i] = new PanelPos[panelSizeById.Width];
				for (int j = 0; j < panelSizeById.Width; j++)
				{
					this.PanelPosDoublyList[i][j] = new PanelPos(i, j);
				}
			}
		}

		// Token: 0x06036DF0 RID: 224752 RVA: 0x00F4C74C File Offset: 0x00F4A94C
		private void InitGridDataMap()
		{
			this.GridDataMap.Clear();
			DangoBrawlGridSize panelSizeById = DangoBrawlConfig.Instance.GetPanelSizeById(this.ActivityId);
			for (int i = 0; i < panelSizeById.Height; i++)
			{
				for (int j = 0; j < panelSizeById.Width; j++)
				{
					PanelPos panelPos = this.PanelPosDoublyList[i][j];
					DangoBrawlBackpackGridData value = new DangoBrawlBackpackGridData(panelPos);
					this.GridDataMap[panelPos] = value;
				}
			}
		}

		// Token: 0x06036DF1 RID: 224753 RVA: 0x00F4C7BC File Offset: 0x00F4A9BC
		private void InitItemBlockDataMap(DangoBrawlBackPackServerData serverData)
		{
			this.ItemDataMap.Clear();
			List<DangoBrawlBackPackItemServerData> itemList = serverData.GetItemList();
			List<DangoBrawlBackpackItemData> list = new List<DangoBrawlBackpackItemData>(itemList.Count);
			List<DangoBrawlBackpackItemData> list2 = new List<DangoBrawlBackpackItemData>();
			for (int i = 0; i < itemList.Count; i++)
			{
				DangoBrawlBackpackItemData dangoBrawlBackpackItemData = new DangoBrawlBackpackItemData(itemList[i]);
				if (dangoBrawlBackpackItemData.MyTemplateType == EDangoBrawlTemplateType.Bag)
				{
					list.Add(dangoBrawlBackpackItemData);
				}
				else
				{
					list2.Add(dangoBrawlBackpackItemData);
				}
			}
			list.AddRange(list2);
			foreach (DangoBrawlBackpackItemData data in list)
			{
				this.AddItemData(data, false);
			}
		}

		// Token: 0x06036DF2 RID: 224754 RVA: 0x00F4C874 File Offset: 0x00F4AA74
		public bool AddItemData(DangoBrawlBackpackItemData data, bool emitEvent = true)
		{
			List<DangoBrawlBackpackGridData> occupyGridList = this.GetOccupyGridList(data);
			if (occupyGridList == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DangoBrawl;
				ELogAuthor author = ELogAuthor.LSH;
				string message = "[AddItemData] : 物品占位格越级！";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("data", data);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			using (List<DangoBrawlBackpackGridData>.Enumerator enumerator = occupyGridList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!enumerator.Current.IsCanEquipBagPackItem(data.MyTemplateType))
					{
						Log instance2 = Log.Instance;
						ELogModule module2 = ELogModule.DangoBrawl;
						ELogAuthor author2 = ELogAuthor.LSH;
						string message2 = "[AddItemData] : 物品校验不规范！";
						ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("data", data);
						instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
						return false;
					}
				}
			}
			this.ItemDataMap[data.MyUid] = data;
			foreach (DangoBrawlBackpackGridData dangoBrawlBackpackGridData in occupyGridList)
			{
				dangoBrawlBackpackGridData.EquipBagPackItem(data.MyUid, data.MyTemplateType);
			}
			data.MyLastAnchor = new ItemSucAnchor
			{
				SourceKind = EDragSourceKind.Bag,
				BagPos = new ValueTuple<PanelPos, EDangoBrawlRotate>?(new ValueTuple<PanelPos, EDangoBrawlRotate>(new PanelPos(data.MyLeftTopPos.RowIndex, data.MyLeftTopPos.ColIndex), data.MyRotation))
			};
			if (emitEvent)
			{
				EventSystem.Instance.Emit<EDangoBrawlModifyType, int>(EEventName.OnDangoBrawlBackpackModified, EDangoBrawlModifyType.Add, data.MyUid);
			}
			return true;
		}

		// Token: 0x06036DF3 RID: 224755 RVA: 0x00F4C9EC File Offset: 0x00F4ABEC
		public bool RemoveItemData(int uid, bool emitEvent = true)
		{
			DangoBrawlBackpackItemData dangoBrawlBackpackItemData;
			if (!this.ItemDataMap.TryGetValue(uid, out dangoBrawlBackpackItemData))
			{
				return false;
			}
			List<DangoBrawlBackpackGridData> occupyGridList = this.GetOccupyGridList(dangoBrawlBackpackItemData);
			if (occupyGridList != null)
			{
				foreach (DangoBrawlBackpackGridData dangoBrawlBackpackGridData in occupyGridList)
				{
					if (((dangoBrawlBackpackItemData.MyTemplateType == EDangoBrawlTemplateType.Bag) ? dangoBrawlBackpackGridData.GridEquipBagId : dangoBrawlBackpackGridData.GridEquipBagItemId) == uid)
					{
						dangoBrawlBackpackGridData.UnEquipBagPackItem(dangoBrawlBackpackItemData.MyTemplateType);
					}
				}
			}
			this.ItemDataMap.Remove(uid);
			if (emitEvent)
			{
				EventSystem.Instance.Emit<EDangoBrawlModifyType, int>(EEventName.OnDangoBrawlBackpackModified, EDangoBrawlModifyType.Remove, uid);
			}
			return true;
		}

		// Token: 0x06036DF4 RID: 224756 RVA: 0x00F4CA9C File Offset: 0x00F4AC9C
		public bool ModifyItem(int uid, PanelPos leftTopPos, EDangoBrawlRotate rotate, bool emitEvent = true)
		{
			DangoBrawlBackpackItemData dangoBrawlBackpackItemData;
			if (!this.ItemDataMap.TryGetValue(uid, out dangoBrawlBackpackItemData))
			{
				return false;
			}
			dangoBrawlBackpackItemData.MyLeftTopPos = leftTopPos;
			dangoBrawlBackpackItemData.MyRotation = rotate;
			if (emitEvent)
			{
				EventSystem.Instance.Emit<EDangoBrawlModifyType, int>(EEventName.OnDangoBrawlBackpackModified, EDangoBrawlModifyType.Modify, uid);
			}
			return true;
		}

		// Token: 0x06036DF5 RID: 224757 RVA: 0x00F4CAE0 File Offset: 0x00F4ACE0
		private List<PanelPos> GetAbsoluteOccupyPosList(PanelPos itemPos, PanelPos[] panelPosList)
		{
			List<PanelPos> list = new List<PanelPos>(panelPosList.Length);
			foreach (PanelPos panelPos in panelPosList)
			{
				list.Add(new PanelPos(itemPos.RowIndex + panelPos.RowIndex, itemPos.ColIndex + panelPos.ColIndex));
			}
			return list;
		}

		// Token: 0x06036DF6 RID: 224758 RVA: 0x00F4CB34 File Offset: 0x00F4AD34
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private List<DangoBrawlBackpackGridData> GetOccupyGridList(DangoBrawlBackpackItemData data)
		{
			List<PanelPos> absoluteOccupyPosList = this.GetAbsoluteOccupyPosList(data.MyLeftTopPos, data.MyPanelPosList);
			int num = this.PanelPosDoublyList.Length;
			int num2 = (num > 0) ? this.PanelPosDoublyList[0].Length : 0;
			List<DangoBrawlBackpackGridData> list = new List<DangoBrawlBackpackGridData>();
			foreach (PanelPos panelPos in absoluteOccupyPosList)
			{
				int rowIndex = panelPos.RowIndex;
				int colIndex = panelPos.ColIndex;
				if (rowIndex < 0 || rowIndex >= num || colIndex < 0 || colIndex >= num2)
				{
					return null;
				}
				PanelPos key = this.PanelPosDoublyList[rowIndex][colIndex];
				DangoBrawlBackpackGridData item;
				if (!this.GridDataMap.TryGetValue(key, out item))
				{
					return null;
				}
				list.Add(item);
			}
			return list;
		}

		// Token: 0x06036DF7 RID: 224759 RVA: 0x00F4CC08 File Offset: 0x00F4AE08
		[NullableContext(2)]
		public DangoBrawlBackpackItemData GetItem(int uid)
		{
			DangoBrawlBackpackItemData result;
			if (!this.ItemDataMap.TryGetValue(uid, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06036DF8 RID: 224760 RVA: 0x00F4CC28 File Offset: 0x00F4AE28
		public List<DangoBrawlBackpackItemData> GetItemList()
		{
			return new List<DangoBrawlBackpackItemData>(this.ItemDataMap.Values);
		}

		// Token: 0x06036DF9 RID: 224761 RVA: 0x00F4CC3C File Offset: 0x00F4AE3C
		public int GetCurrentWeight()
		{
			int num = 0;
			foreach (DangoBrawlBackpackItemData dangoBrawlBackpackItemData in this.ItemDataMap.Values)
			{
				DangoBrawlItem? dangoBrawlItemById = DangoBrawlConfig.Instance.GetDangoBrawlItemById(dangoBrawlBackpackItemData.MyConfigId);
				num += ((dangoBrawlItemById != null) ? dangoBrawlItemById.GetValueOrDefault().Cost : 0);
			}
			return num;
		}

		// Token: 0x06036DFA RID: 224762 RVA: 0x00F4CCC0 File Offset: 0x00F4AEC0
		public PanelPos[][] GetPanelPosDoublyList()
		{
			return this.PanelPosDoublyList;
		}

		// Token: 0x06036DFB RID: 224763 RVA: 0x00F4CCC8 File Offset: 0x00F4AEC8
		public bool HasBagItemAt(PanelPos val)
		{
			DangoBrawlBackpackGridData dangoBrawlBackpackGridData;
			return this.GridDataMap.TryGetValue(val, out dangoBrawlBackpackGridData) && dangoBrawlBackpackGridData.GridEquipBagItemId != -1;
		}

		// Token: 0x06036DFC RID: 224764 RVA: 0x00F4CCF4 File Offset: 0x00F4AEF4
		public int GetBagItemIdAt(PanelPos val)
		{
			DangoBrawlBackpackGridData dangoBrawlBackpackGridData;
			if (!this.GridDataMap.TryGetValue(val, out dangoBrawlBackpackGridData))
			{
				return -1;
			}
			return dangoBrawlBackpackGridData.GridEquipBagItemId;
		}

		// Token: 0x06036DFD RID: 224765 RVA: 0x00F4CD1C File Offset: 0x00F4AF1C
		public int GetBagIdAt(PanelPos val)
		{
			DangoBrawlBackpackGridData dangoBrawlBackpackGridData;
			if (!this.GridDataMap.TryGetValue(val, out dangoBrawlBackpackGridData))
			{
				return -1;
			}
			return dangoBrawlBackpackGridData.GridEquipBagId;
		}

		// Token: 0x06036DFE RID: 224766 RVA: 0x00F4CD44 File Offset: 0x00F4AF44
		public bool CanPlaceItem(PanelPos leftTopPos, PanelPos[] panelPosList, EDangoBrawlTemplateType type, int excludeUid = -1)
		{
			int num = this.PanelPosDoublyList.Length;
			int num2 = (num > 0) ? this.PanelPosDoublyList[0].Length : 0;
			DangoBrawlBackpackItemData dangoBrawlBackpackItemData = (excludeUid != -1) ? this.GetItem(excludeUid) : null;
			HashSet<DangoBrawlBackpackGridData> hashSet = (dangoBrawlBackpackItemData != null) ? new HashSet<DangoBrawlBackpackGridData>(this.GetOccupyGridList(dangoBrawlBackpackItemData) ?? new List<DangoBrawlBackpackGridData>()) : null;
			foreach (PanelPos panelPos in panelPosList)
			{
				int num3 = leftTopPos.RowIndex + panelPos.RowIndex;
				int num4 = leftTopPos.ColIndex + panelPos.ColIndex;
				if (num3 < 0 || num3 >= num || num4 < 0 || num4 >= num2)
				{
					return false;
				}
				PanelPos key = this.PanelPosDoublyList[num3][num4];
				DangoBrawlBackpackGridData dangoBrawlBackpackGridData;
				if (!this.GridDataMap.TryGetValue(key, out dangoBrawlBackpackGridData))
				{
					return false;
				}
				if ((hashSet == null || !hashSet.Contains(dangoBrawlBackpackGridData)) && !dangoBrawlBackpackGridData.IsCanEquipBagPackItem(type))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06036DFF RID: 224767 RVA: 0x00F4CE38 File Offset: 0x00F4B038
		public bool CanPlaceItem(PanelPos leftTopPos, PanelPos[] panelPosList, EDangoBrawlTemplateType type, IReadOnlyCollection<int> excludeUids)
		{
			int num = this.PanelPosDoublyList.Length;
			int num2 = (num > 0) ? this.PanelPosDoublyList[0].Length : 0;
			HashSet<DangoBrawlBackpackGridData> hashSet = new HashSet<DangoBrawlBackpackGridData>();
			foreach (int num3 in excludeUids)
			{
				if (num3 != -1)
				{
					DangoBrawlBackpackItemData item = this.GetItem(num3);
					if (item != null)
					{
						List<DangoBrawlBackpackGridData> occupyGridList = this.GetOccupyGridList(item);
						if (occupyGridList != null)
						{
							foreach (DangoBrawlBackpackGridData item2 in occupyGridList)
							{
								hashSet.Add(item2);
							}
						}
					}
				}
			}
			foreach (PanelPos panelPos in panelPosList)
			{
				int num4 = leftTopPos.RowIndex + panelPos.RowIndex;
				int num5 = leftTopPos.ColIndex + panelPos.ColIndex;
				if (num4 < 0 || num4 >= num || num5 < 0 || num5 >= num2)
				{
					return false;
				}
				PanelPos key = this.PanelPosDoublyList[num4][num5];
				DangoBrawlBackpackGridData dangoBrawlBackpackGridData;
				if (!this.GridDataMap.TryGetValue(key, out dangoBrawlBackpackGridData))
				{
					return false;
				}
				if (!hashSet.Contains(dangoBrawlBackpackGridData) && !dangoBrawlBackpackGridData.IsCanEquipBagPackItem(type))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06036E00 RID: 224768 RVA: 0x00F4CF98 File Offset: 0x00F4B198
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<DangoBrawlBackpackItemData> GetOverlapItems(PanelPos leftTopPos, PanelPos[] panelPosList, EDangoBrawlTemplateType type, [Nullable(2)] int[] excludeUids = null)
		{
			int num = this.PanelPosDoublyList.Length;
			int num2 = (num > 0) ? this.PanelPosDoublyList[0].Length : 0;
			HashSet<int> hashSet = new HashSet<int>();
			if (excludeUids != null)
			{
				foreach (int num3 in excludeUids)
				{
					if (num3 != -1)
					{
						hashSet.Add(num3);
					}
				}
			}
			HashSet<int> hashSet2 = new HashSet<int>();
			foreach (PanelPos panelPos in panelPosList)
			{
				int num4 = leftTopPos.RowIndex + panelPos.RowIndex;
				int num5 = leftTopPos.ColIndex + panelPos.ColIndex;
				if (num4 < 0 || num4 >= num || num5 < 0 || num5 >= num2)
				{
					return null;
				}
				PanelPos key = this.PanelPosDoublyList[num4][num5];
				DangoBrawlBackpackGridData dangoBrawlBackpackGridData;
				if (!this.GridDataMap.TryGetValue(key, out dangoBrawlBackpackGridData))
				{
					return null;
				}
				int num6 = (type == EDangoBrawlTemplateType.Bag) ? dangoBrawlBackpackGridData.GridEquipBagId : dangoBrawlBackpackGridData.GridEquipBagItemId;
				if (num6 != -1 && !hashSet.Contains(num6))
				{
					hashSet2.Add(num6);
				}
			}
			List<DangoBrawlBackpackItemData> list = new List<DangoBrawlBackpackItemData>();
			foreach (int key2 in hashSet2)
			{
				DangoBrawlBackpackItemData dangoBrawlBackpackItemData;
				if (!this.ItemDataMap.TryGetValue(key2, out dangoBrawlBackpackItemData))
				{
					return null;
				}
				if (dangoBrawlBackpackItemData.MyTemplateType != type)
				{
					return null;
				}
				list.Add(dangoBrawlBackpackItemData);
			}
			return list;
		}

		// Token: 0x06036E01 RID: 224769 RVA: 0x00F4D124 File Offset: 0x00F4B324
		public List<DangoBrawlBackpackItemData> GetBagFollowerItems(int bagUid)
		{
			DangoBrawlBackpackItemData dangoBrawlBackpackItemData;
			if (!this.ItemDataMap.TryGetValue(bagUid, out dangoBrawlBackpackItemData) || dangoBrawlBackpackItemData.MyTemplateType != EDangoBrawlTemplateType.Bag)
			{
				return new List<DangoBrawlBackpackItemData>();
			}
			HashSet<string> hashSet = new HashSet<string>();
			foreach (PanelPos panelPos in dangoBrawlBackpackItemData.MyPanelPosList)
			{
				HashSet<string> hashSet2 = hashSet;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(dangoBrawlBackpackItemData.MyLeftTopPos.RowIndex + panelPos.RowIndex);
				defaultInterpolatedStringHandler.AppendLiteral(",");
				defaultInterpolatedStringHandler.AppendFormatted<int>(dangoBrawlBackpackItemData.MyLeftTopPos.ColIndex + panelPos.ColIndex);
				hashSet2.Add(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			List<DangoBrawlBackpackItemData> list = new List<DangoBrawlBackpackItemData>();
			foreach (DangoBrawlBackpackItemData dangoBrawlBackpackItemData2 in this.ItemDataMap.Values)
			{
				if (dangoBrawlBackpackItemData2.MyTemplateType != EDangoBrawlTemplateType.Bag)
				{
					foreach (PanelPos panelPos2 in dangoBrawlBackpackItemData2.MyPanelPosList)
					{
						HashSet<string> hashSet3 = hashSet;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
						defaultInterpolatedStringHandler.AppendFormatted<int>(dangoBrawlBackpackItemData2.MyLeftTopPos.RowIndex + panelPos2.RowIndex);
						defaultInterpolatedStringHandler.AppendLiteral(",");
						defaultInterpolatedStringHandler.AppendFormatted<int>(dangoBrawlBackpackItemData2.MyLeftTopPos.ColIndex + panelPos2.ColIndex);
						if (hashSet3.Contains(defaultInterpolatedStringHandler.ToStringAndClear()))
						{
							list.Add(dangoBrawlBackpackItemData2);
							break;
						}
					}
				}
			}
			return list;
		}

		// Token: 0x06036E02 RID: 224770 RVA: 0x00F4D2B8 File Offset: 0x00F4B4B8
		public List<StarMatch> CollectStarMatches()
		{
			List<StarMatch> list = new List<StarMatch>();
			foreach (DangoBrawlBackpackItemData dangoBrawlBackpackItemData in this.ItemDataMap.Values)
			{
				PanelPos[] myStarPanelPosList = dangoBrawlBackpackItemData.MyStarPanelPosList;
				if (myStarPanelPosList.Length != 0)
				{
					DangoBrawlItem? dangoBrawlItemById = DangoBrawlConfig.Instance.GetDangoBrawlItemById(dangoBrawlBackpackItemData.MyConfigId);
					if (dangoBrawlItemById != null)
					{
						HashSet<int> hashSet = new HashSet<int>();
						for (int i = 0; i < dangoBrawlItemById.Value.EffectItemTagLength; i++)
						{
							hashSet.Add(dangoBrawlItemById.Value.EffectItemTag(i));
						}
						if (hashSet.Count != 0)
						{
							bool effectNoSameItem = dangoBrawlItemById.Value.EffectNoSameItem;
							List<ValueTuple<int, PanelPos, int>> list2 = new List<ValueTuple<int, PanelPos, int>>(myStarPanelPosList.Length);
							for (int j = 0; j < myStarPanelPosList.Length; j++)
							{
								PanelPos panelPos = new PanelPos(dangoBrawlBackpackItemData.MyLeftTopPos.RowIndex + myStarPanelPosList[j].RowIndex, dangoBrawlBackpackItemData.MyLeftTopPos.ColIndex + myStarPanelPosList[j].ColIndex);
								list2.Add(new ValueTuple<int, PanelPos, int>(j, panelPos, this.GetBagItemIdAt(panelPos)));
							}
							HashSet<int> hashSet2 = new HashSet<int>();
							HashSet<int> hashSet3 = new HashSet<int>();
							NoLinq.SortStable<ValueTuple<int, PanelPos, int>>(list2, delegate([TupleElementNames(new string[]
							{
								"Idx",
								"Pos",
								"Uid"
							})] ValueTuple<int, PanelPos, int> left, [TupleElementNames(new string[]
							{
								"Idx",
								"Pos",
								"Uid"
							})] ValueTuple<int, PanelPos, int> right)
							{
								int num = left.Item2.RowIndex.CompareTo(right.Item2.RowIndex);
								if (num == 0)
								{
									return left.Item2.ColIndex.CompareTo(right.Item2.ColIndex);
								}
								return num;
							});
							foreach (ValueTuple<int, PanelPos, int> valueTuple in list2)
							{
								if (valueTuple.Item3 != -1 && valueTuple.Item3 != dangoBrawlBackpackItemData.MyUid && hashSet2.Add(valueTuple.Item3))
								{
									DangoBrawlBackpackItemData item = this.GetItem(valueTuple.Item3);
									if (item != null)
									{
										DangoBrawlItem? dangoBrawlItemById2 = DangoBrawlConfig.Instance.GetDangoBrawlItemById(item.MyConfigId);
										if (dangoBrawlItemById2 != null)
										{
											bool flag = false;
											for (int k = 0; k < dangoBrawlItemById2.Value.ItemTagsLength; k++)
											{
												if (hashSet.Contains(dangoBrawlItemById2.Value.ItemTags(k)))
												{
													flag = true;
													break;
												}
											}
											if (flag && (!effectNoSameItem || hashSet3.Add(item.MyConfigId)))
											{
												list.Add(new StarMatch(dangoBrawlBackpackItemData.MyUid, valueTuple.Item1, valueTuple.Item3));
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return list;
		}

		// Token: 0x06036E03 RID: 224771 RVA: 0x00F4D578 File Offset: 0x00F4B778
		public bool AreAllCellsHaveBag(PanelPos leftTopPos, PanelPos[] panelPosList)
		{
			int num = this.PanelPosDoublyList.Length;
			int num2 = (num > 0) ? this.PanelPosDoublyList[0].Length : 0;
			foreach (PanelPos panelPos in panelPosList)
			{
				int num3 = leftTopPos.RowIndex + panelPos.RowIndex;
				int num4 = leftTopPos.ColIndex + panelPos.ColIndex;
				if (num3 < 0 || num3 >= num || num4 < 0 || num4 >= num2)
				{
					return false;
				}
				PanelPos key = this.PanelPosDoublyList[num3][num4];
				DangoBrawlBackpackGridData dangoBrawlBackpackGridData;
				if (!this.GridDataMap.TryGetValue(key, out dangoBrawlBackpackGridData))
				{
					return false;
				}
				if ((dangoBrawlBackpackGridData.GridState & EDangoBrawlGridEquipState.Bag) == EDangoBrawlGridEquipState.Empty)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0401D108 RID: 119048
		private int ActivityId;

		// Token: 0x0401D109 RID: 119049
		private PanelPos[][] PanelPosDoublyList = Array.Empty<PanelPos[]>();

		// Token: 0x0401D10A RID: 119050
		private readonly Dictionary<PanelPos, DangoBrawlBackpackGridData> GridDataMap = new Dictionary<PanelPos, DangoBrawlBackpackGridData>();

		// Token: 0x0401D10B RID: 119051
		private readonly Dictionary<int, DangoBrawlBackpackItemData> ItemDataMap = new Dictionary<int, DangoBrawlBackpackItemData>();
	}
}

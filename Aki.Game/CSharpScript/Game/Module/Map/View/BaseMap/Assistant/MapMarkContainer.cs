using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Mark.Component;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.Misc;
using CSharpScript.Game.Module.Map.View.BaseMap.Assistant.MapFrameTaskQueue;
using CSharpScript.Game.Module.WorldMap;

namespace CSharpScript.Game.Module.Map.View.BaseMap.Assistant
{
	// Token: 0x02005491 RID: 21649
	[NullableContext(1)]
	[Nullable(0)]
	public class MapMarkContainer
	{
		// Token: 0x060374C8 RID: 226504 RVA: 0x00D1F4C3 File Offset: 0x00D1D6C3
		public void Tick()
		{
			this.MapMarkPreemptiveFrameQueue.Process();
		}

		// Token: 0x060374C9 RID: 226505 RVA: 0x00D1F4D0 File Offset: 0x00D1D6D0
		public void ClearMarkItems(EMarkType? type, bool? recycleToPoolImmediately)
		{
			if (type != null && type.Value != EMarkType.None)
			{
				Dictionary<int, MarkItem> dictionary;
				if (this.MarkItems.TryGetValue(type.Value, out dictionary))
				{
					foreach (MarkItem markItem in dictionary.Values.ToList<MarkItem>())
					{
						markItem.Destroy(recycleToPoolImmediately.GetValueOrDefault(true));
						this.DeleteItemInGrid(markItem);
					}
					dictionary.Clear();
				}
				Dictionary<int, MarkItem> dictionary2;
				if (this.DiffMapMarkItems.TryGetValue(type.Value, out dictionary2))
				{
					foreach (MarkItem markItem2 in dictionary2.Values.ToList<MarkItem>())
					{
						markItem2.Destroy(recycleToPoolImmediately.GetValueOrDefault(true));
					}
					dictionary2.Clear();
				}
				this.MapMarkPreemptiveFrameQueue.CancelMapTaskByType(type.Value);
				return;
			}
			this.RemoveMarkItems(this.MarkItems, recycleToPoolImmediately);
			this.RemoveMarkItems(this.DiffMapMarkItems, recycleToPoolImmediately);
			this.MarkItemTracking.Clear();
			this.TrackDeleteItems.Clear();
			this.CurrentUpdateSet.Clear();
			this.LastUpdateSet.Clear();
			this.MarkItems.Clear();
			this.DiffMapMarkItems.Clear();
			this.MarkItemInGrid.Clear();
			this.MapMarkPreemptiveFrameQueue.Dispose();
		}

		// Token: 0x060374CA RID: 226506 RVA: 0x00D1F658 File Offset: 0x00D1D858
		public unsafe void AddMarkItem(EMarkType markType, MarkItem markItem)
		{
			if (markItem == null)
			{
				return;
			}
			if (markItem.IsTracked && markItem.MarkType != EMarkType.Quest)
			{
				TrackMapMarkParams trackMapMarkParams = new TrackMapMarkParams
				{
					MarkType = markItem.MarkType,
					MarkId = markItem.MarkId,
					Track = true
				};
				if (!MapModel.Instance.IsEqualToCurTrack(trackMapMarkParams))
				{
					MapModel.Instance.SetCurTrackMark(trackMapMarkParams);
				}
				this.MarkItemTracking.Add(markItem);
			}
			if (markItem.IsInConsistentDistrict(false))
			{
				ELogAuthor author = ELogAuthor.LYX;
				string message = "标记系统->MapMarkContainer.AddMarkItem, 被添加到跨地图列表，将不会显示在地图上";
				<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("markType", markType);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("markId", markItem.MarkId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("MapType", markItem.MapType);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("InstanceDungeonId", markItem.InstanceDungeonId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("MapId", markItem.MapId);
				MapLogger.Debug(author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
				this.AddDiffMapMarkItem(markType, markItem);
				return;
			}
			Dictionary<int, MarkItem> dictionary;
			if (!this.MarkItems.TryGetValue(markType, out dictionary))
			{
				dictionary = new Dictionary<int, MarkItem>();
				this.MarkItems[markType] = dictionary;
			}
			if (dictionary.TryAdd(markItem.MarkId, markItem))
			{
				this.AddItemInGrid(markItem);
				ELogAuthor author2 = ELogAuthor.LYX;
				string message2 = "标记系统->MapMarkContainer.AddMarkItem";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("markType", markType);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("markId", markItem.MarkId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("MapType", markItem.MapType);
				MapLogger.Debug(author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				EventSystem.Instance.Emit<MarkItem>(EEventName.AddMapMark, markItem);
				return;
			}
			if (WorldMapModel.Instance.EnableDebug)
			{
				object key = markItem.MarkId;
				ELogAuthor author3 = ELogAuthor.LYX;
				string message3 = "重复添加标记_MarkMgr";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MarkId", markItem.MarkId);
				MapLogger.ErrorOnce(key, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x060374CB RID: 226507 RVA: 0x00D1F8AC File Offset: 0x00D1DAAC
		private void AddDiffMapMarkItem(EMarkType markType, MarkItem markItem)
		{
			Dictionary<int, MarkItem> dictionary;
			if (!this.DiffMapMarkItems.TryGetValue(markType, out dictionary))
			{
				dictionary = new Dictionary<int, MarkItem>();
				this.DiffMapMarkItems[markType] = dictionary;
			}
			dictionary[markItem.MarkId] = markItem;
		}

		// Token: 0x060374CC RID: 226508 RVA: 0x00D1F8EC File Offset: 0x00D1DAEC
		[NullableContext(2)]
		public unsafe MarkItem RemoveMarkItem(EMarkType markType, int markId)
		{
			this.MapMarkPreemptiveFrameQueue.CancelMapTask(markType, markId);
			Dictionary<int, MarkItem> dictionary;
			if (!this.MarkItems.TryGetValue(markType, out dictionary) || dictionary.Count == 0)
			{
				return null;
			}
			MarkItem markItem;
			if (!dictionary.Remove(markId, out markItem))
			{
				return null;
			}
			this.DeleteItemInGrid(markItem);
			ELogAuthor author = ELogAuthor.LYX;
			string message = "标记系统->MapMarkContainer.RemoveMarkItem";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("markType", markType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("markId", markId);
			MapLogger.Debug(author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return markItem;
		}

		// Token: 0x060374CD RID: 226509 RVA: 0x00D1F98C File Offset: 0x00D1DB8C
		private void RemoveMarkItems(Dictionary<EMarkType, Dictionary<int, MarkItem>> markItemMap, bool? recycleToPoolImmediately)
		{
			foreach (Dictionary<int, MarkItem> dictionary in markItemMap.Values)
			{
				foreach (MarkItem markItem in dictionary.Values.ToList<MarkItem>())
				{
					markItem.Destroy(recycleToPoolImmediately.GetValueOrDefault(true));
				}
			}
		}

		// Token: 0x060374CE RID: 226510 RVA: 0x00D1FA24 File Offset: 0x00D1DC24
		private void AddItemInGrid(MarkItem mark)
		{
			int num = MapUtil.ConvertWorldPositionToIndex(mark.WorldPosition);
			HashSet<MarkItem> markSet;
			if (!this.MarkItemInGrid.TryGetValue(num, out markSet))
			{
				HashSet<MarkItem> value = new HashSet<MarkItem>
				{
					mark
				};
				this.MarkItemInGrid[num] = value;
			}
			else
			{
				this.ApplyAddItemToGridSet(markSet, mark);
			}
			mark.GridId = num;
		}

		// Token: 0x060374CF RID: 226511 RVA: 0x00D1FA7C File Offset: 0x00D1DC7C
		private void ApplyAddItemToGridSet(HashSet<MarkItem> markSet, MarkItem mark)
		{
			if (!markSet.Add(mark))
			{
				object key = mark.MarkId;
				ELogAuthor author = ELogAuthor.LYX;
				string message = "重复添加标记到格子集合中_MarkMarkContainer";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MarkId", mark.MarkId);
				MapLogger.ErrorOnce(key, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x060374D0 RID: 226512 RVA: 0x00D1FAC8 File Offset: 0x00D1DCC8
		private void DeleteItemInGrid(MarkItem mark)
		{
			int gridId = mark.GridId;
			HashSet<MarkItem> hashSet;
			if (this.MarkItemInGrid.TryGetValue(gridId, out hashSet))
			{
				hashSet.Remove(mark);
			}
		}

		// Token: 0x060374D1 RID: 226513 RVA: 0x00D1FAF4 File Offset: 0x00D1DCF4
		public bool ExistMarkItem(EMarkType markType, int markId)
		{
			return this.GetMarkItemPurely(markType, markId) != null;
		}

		// Token: 0x060374D2 RID: 226514 RVA: 0x00D1FB01 File Offset: 0x00D1DD01
		public bool ExistMarkItemTask(EMarkType markType, int markId)
		{
			return this.MapMarkPreemptiveFrameQueue.HasTask(markType, markId);
		}

		// Token: 0x060374D3 RID: 226515 RVA: 0x00D1FB10 File Offset: 0x00D1DD10
		[NullableContext(2)]
		public MarkItem GetMarkItem(EMarkType markType, int markId)
		{
			this.MapMarkPreemptiveFrameQueue.ForceExecuteTask(markType, markId);
			return this.GetMarkItemPurely(markType, markId);
		}

		// Token: 0x060374D4 RID: 226516 RVA: 0x00D1FB28 File Offset: 0x00D1DD28
		[NullableContext(2)]
		public MarkItem GetMarkItemPurely(EMarkType markType, int markId)
		{
			if (markType == EMarkType.None)
			{
				return this.GetMarkItemById(markId, false);
			}
			Dictionary<int, MarkItem> markItemsByType = this.GetMarkItemsByType(markType, true);
			if (markItemsByType == null)
			{
				return null;
			}
			MarkItem result;
			if (markItemsByType.TryGetValue(markId, out result))
			{
				return result;
			}
			return this.GetDifferMapMarkItem(markType, markId);
		}

		// Token: 0x060374D5 RID: 226517 RVA: 0x00D1FB64 File Offset: 0x00D1DD64
		[NullableContext(2)]
		public MarkItem GetMarkItemById(int markId, bool withCrossMap = false)
		{
			MapMarkContainer.<>c__DisplayClass22_0 CS$<>8__locals1;
			CS$<>8__locals1.markId = markId;
			MarkItem markItem = MapMarkContainer.<GetMarkItemById>g__FindMarkItemFunc|22_0(this.MarkItems, ref CS$<>8__locals1);
			if (markItem == null && withCrossMap)
			{
				markItem = MapMarkContainer.<GetMarkItemById>g__FindMarkItemFunc|22_0(this.DiffMapMarkItems, ref CS$<>8__locals1);
			}
			return markItem;
		}

		// Token: 0x060374D6 RID: 226518 RVA: 0x00D1FBA0 File Offset: 0x00D1DDA0
		[NullableContext(2)]
		public MarkItem GetDifferMapMarkItem(EMarkType markType, int markId)
		{
			Dictionary<int, MarkItem> dictionary;
			if (this.DiffMapMarkItems.TryGetValue(markType, out dictionary))
			{
				MarkItem result;
				dictionary.TryGetValue(markId, out result);
				return result;
			}
			return null;
		}

		// Token: 0x060374D7 RID: 226519 RVA: 0x00D1FBCC File Offset: 0x00D1DDCC
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<int, MarkItem> GetMarkItemsByType(EMarkType markType, bool withCrossMap = true)
		{
			Dictionary<int, MarkItem> dictionary;
			this.MarkItems.TryGetValue(markType, out dictionary);
			if ((dictionary == null || dictionary.Count <= 0) && withCrossMap)
			{
				return this.GetDifferMapMarkItemsByType(markType);
			}
			return dictionary;
		}

		// Token: 0x060374D8 RID: 226520 RVA: 0x00D1FC08 File Offset: 0x00D1DE08
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<int, MarkItem> GetDifferMapMarkItemsByType(EMarkType markType)
		{
			Dictionary<int, MarkItem> result;
			this.DiffMapMarkItems.TryGetValue(markType, out result);
			return result;
		}

		// Token: 0x060374D9 RID: 226521 RVA: 0x00D1FC25 File Offset: 0x00D1DE25
		public Dictionary<EMarkType, Dictionary<int, MarkItem>> GetAllMarkItems()
		{
			return this.MarkItems;
		}

		// Token: 0x060374DA RID: 226522 RVA: 0x00D1FC2D File Offset: 0x00D1DE2D
		public Dictionary<EMarkType, Dictionary<int, MarkItem>> GetAllDiffMapMarkItems()
		{
			return this.DiffMapMarkItems;
		}

		// Token: 0x060374DB RID: 226523 RVA: 0x00D1FC38 File Offset: 0x00D1DE38
		public List<MarkItem> GetMarkItemsByClickPosition(global::Vector position, int cellRadius = 1)
		{
			HashSet<int> aroundIndexByCellRadius = MapUtil.GetAroundIndexByCellRadius(MapUtil.ConvertWorldPositionToIndex(MapUtil.UiPosition2WorldPosition(position, null)), cellRadius);
			List<MarkItem> list = new List<MarkItem>();
			foreach (int key in aroundIndexByCellRadius)
			{
				HashSet<MarkItem> collection;
				if (this.MarkItemInGrid.TryGetValue(key, out collection))
				{
					list.AddRange(collection);
				}
			}
			return list;
		}

		// Token: 0x060374DC RID: 226524 RVA: 0x00D1FCB0 File Offset: 0x00D1DEB0
		public void UpdateNearbyMarkItem(global::Vector center, Action<MarkItem> updateFunction, Action<MarkItem> onExitFunction)
		{
			this.MapMarkPreemptiveFrameQueue.Flush();
			HashSet<int> updateAroundIndex = MapUtil.GetUpdateAroundIndex(MapUtil.ConvertWorldPositionToIndex(center));
			this.CurrentUpdateSet.Clear();
			foreach (int key in updateAroundIndex)
			{
				HashSet<MarkItem> other;
				if (this.MarkItemInGrid.TryGetValue(key, out other))
				{
					this.CurrentUpdateSet.UnionWith(other);
				}
			}
			foreach (EMarkType markType in MarkDefine.PermanentUpdateTypeSet)
			{
				Dictionary<int, MarkItem> markItemsByType = this.GetMarkItemsByType(markType, true);
				if (markItemsByType != null)
				{
					this.CurrentUpdateSet.UnionWith(markItemsByType.Values);
				}
			}
			this.CurrentUpdateSet.UnionWith(this.MarkItemTracking);
			this.TempDeleteList.Clear();
			foreach (MarkItem markItem in this.LastUpdateSet)
			{
				if (!this.CurrentUpdateSet.Contains(markItem) && !markItem.IsDestroy)
				{
					this.TempDeleteList.Add(markItem);
				}
			}
			foreach (MarkItem markItem2 in this.TrackDeleteItems)
			{
				if (!this.CurrentUpdateSet.Contains(markItem2) && !this.LastUpdateSet.Contains(markItem2) && !markItem2.IsDestroy)
				{
					this.TempDeleteList.Add(markItem2);
				}
			}
			this.TrackDeleteItems.Clear();
			this.LastUpdateSet.Clear();
			this.LastUpdateSet.UnionWith(this.CurrentUpdateSet);
			foreach (MarkItem obj in this.TempDeleteList)
			{
				onExitFunction(obj);
			}
			foreach (MarkItem obj2 in this.CurrentUpdateSet)
			{
				updateFunction(obj2);
			}
		}

		// Token: 0x060374DD RID: 226525 RVA: 0x00D1FF30 File Offset: 0x00D1E130
		[return: Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public List<ValueTuple<MarkItem, double>> FindNearbyMarkItems(MarkItem markItem, float searchRadius, [Nullable(2)] TFilterMarkFunction filterFunction = null)
		{
			this.MapMarkPreemptiveFrameQueue.Flush();
			HashSet<int> queryNearestIndexSet = MapUtil.GetQueryNearestIndexSet(markItem.WorldPosition, searchRadius);
			List<ValueTuple<MarkItem, double>> list = new List<ValueTuple<MarkItem, double>>();
			float num = searchRadius * searchRadius;
			foreach (int key in queryNearestIndexSet)
			{
				HashSet<MarkItem> hashSet;
				if (this.MarkItemInGrid.TryGetValue(key, out hashSet))
				{
					foreach (MarkItem markItem2 in hashSet)
					{
						if (filterFunction == null || filterFunction(markItem2))
						{
							double num2;
							if ((markItem.MarkType == EMarkType.Custom || markItem.MarkType == EMarkType.EnrichmentArea) && MathUtils.Instance.IsNearlyZero(markItem.WorldPosition.Z, null))
							{
								Vector2D a2 = Vector2D.Create(markItem2.WorldPosition.X, markItem2.WorldPosition.Y);
								Vector2D b2 = Vector2D.Create(markItem.WorldPosition.X, markItem.WorldPosition.Y);
								num2 = Vector2D.DistSquared(a2, b2);
							}
							else
							{
								num2 = global::Vector.DistSquared(markItem2.WorldPosition, markItem.WorldPosition);
							}
							if (num2 <= (double)num)
							{
								list.Add(new ValueTuple<MarkItem, double>(markItem2, num2));
							}
						}
					}
				}
			}
			if (list.Count > 0)
			{
				list.Sort(([Nullable(new byte[]
				{
					0,
					1
				})] ValueTuple<MarkItem, double> a, [Nullable(new byte[]
				{
					0,
					1
				})] ValueTuple<MarkItem, double> b) => a.Item2.CompareTo(b.Item2));
			}
			return list;
		}

		// Token: 0x060374DE RID: 226526 RVA: 0x00D200EC File Offset: 0x00D1E2EC
		public void RemoveDynamicMark(EMarkType markType, int markId)
		{
			MarkItem markItem = this.GetMarkItem(markType, markId);
			if (markItem == null)
			{
				return;
			}
			this.TrackMapMark(markType, markItem.MarkId, false, false);
			MarkItem markItem2 = this.RemoveMarkItem(markType, markId);
			if (markItem2 != null)
			{
				markItem2.Destroy(true);
			}
		}

		// Token: 0x060374DF RID: 226527 RVA: 0x00D20128 File Offset: 0x00D1E328
		public void TrackMapMark(EMarkType markType, int markId, bool isTrack, bool forceTrack = false)
		{
			ITrackData trackData = TrackModel.Instance.GetTrackData(ETrackSource.MapMark, markId);
			MarkItem markItem = this.GetMarkItem(markType, markId);
			if (markItem == null && trackData == null)
			{
				return;
			}
			ETrackSource type = ETrackSource.None;
			if (trackData != null)
			{
				type = trackData.TrackSource;
				trackData.IconPath = (((markItem != null) ? markItem.IconPath : null) ?? trackData.IconPath);
			}
			if (markItem != null)
			{
				type = markItem.TrackSource;
			}
			bool flag = TrackModel.Instance.IsTracking(type, markId);
			if (!forceTrack && flag == isTrack)
			{
				if (markItem != null)
				{
					EventSystem.Instance.Emit<MarkItem>(EEventName.OnMarkItemTrackStateChange, markItem);
				}
				return;
			}
			if (isTrack)
			{
				if (markItem != null)
				{
					MarkConfigComponent component = markItem.MarkItemEntity.GetComponent<MarkConfigComponent>(EMapComponent.MarkConfig);
					OneOf<MapMark, DynamicMapMark, TreasureBoxDetectorMark>? oneOf = (component != null) ? new OneOf<MapMark, DynamicMapMark, TreasureBoxDetectorMark>?(component.Config) : null;
					if (markItem.MarkType == EMarkType.HonamiScanItem)
					{
						HonamiScanItemMarkItem honamiScanItemMarkItem = markItem as HonamiScanItemMarkItem;
						MapMark? configMark = MapConfig.Instance.GetConfigMark(honamiScanItemMarkItem.ConfigId);
						oneOf = ((configMark != null) ? new OneOf<MapMark, DynamicMapMark, TreasureBoxDetectorMark>?(configMark.GetValueOrDefault()) : null);
					}
					TrackController.Instance.StartTrack(new TrackData
					{
						TrackSource = markItem.TrackSource,
						Id = markId,
						MarkType = new EMarkType?(markType),
						IconPath = markItem.IconPath,
						TrackTarget = markItem.TrackTarget,
						TrackInstanceId = markItem.RelativeInstanceDungeonId,
						TrackHudEnable = new bool?(oneOf != null && oneOf.GetValueOrDefault().TrackHudEnable().GetValueOrDefault() == 1),
						TrackAutoCancelDistance = ((oneOf != null) ? oneOf.GetValueOrDefault().TrackAutoCancelDistance() : null)
					}, true);
					this.MarkItemTracking.Add(markItem);
					EventSystem.Instance.Emit<MarkItem>(EEventName.OnMarkItemTrackStateChange, markItem);
					return;
				}
			}
			else
			{
				TrackController.Instance.EndTrack(type, markId);
				if (markItem != null)
				{
					this.TrackDeleteItems.Add(markItem);
					this.MarkItemTracking.Remove(markItem);
					EventSystem.Instance.Emit<MarkItem>(EEventName.OnMarkItemTrackStateChange, markItem);
				}
			}
		}

		// Token: 0x060374E0 RID: 226528 RVA: 0x00D20334 File Offset: 0x00D1E534
		public void TrackMark(ITrackData trackData)
		{
			MarkItem markItem = this.GetMarkItem(trackData.MarkType.GetValueOrDefault(), trackData.Id);
			if (markItem != null && !markItem.IsTracked)
			{
				markItem.LogicUpdate(GeneralLogicTreeUtil.Instance.GetPlayerLocation());
			}
			if (((markItem != null) ? markItem.View : null) != null || (markItem != null && markItem.IsTracked))
			{
				this.MarkItemTracking.Add(markItem);
			}
		}

		// Token: 0x060374E1 RID: 226529 RVA: 0x00D203A0 File Offset: 0x00D1E5A0
		public void UnTrackMark(ITrackData trackData)
		{
			MarkItem markItem = this.GetMarkItem(trackData.MarkType.GetValueOrDefault(), trackData.Id);
			if (markItem != null)
			{
				this.MarkItemTracking.Remove(markItem);
				this.TrackDeleteItems.Add(markItem);
			}
		}

		// Token: 0x060374E2 RID: 226530 RVA: 0x00D203E8 File Offset: 0x00D1E5E8
		public void ClearTrackMark()
		{
			foreach (MarkItem markItem in this.MarkItemTracking.ToList<MarkItem>())
			{
				if (((markItem != null) ? markItem.View : null) != null)
				{
					this.TrackDeleteItems.Add(markItem);
				}
			}
			this.MarkItemTracking.Clear();
		}

		// Token: 0x060374E3 RID: 226531 RVA: 0x00D20460 File Offset: 0x00D1E660
		public List<MarkItem> GetTrackMenuMarkList()
		{
			List<MarkItem> list = new List<MarkItem>();
			Dictionary<int, MarkItem> markItemsByType = this.GetMarkItemsByType(EMarkType.OtherPlayers, false);
			if (markItemsByType != null)
			{
				list.AddRange(markItemsByType.Values);
			}
			Dictionary<int, MarkItem> markItemsByType2 = this.GetMarkItemsByType(EMarkType.Quest, false);
			if (markItemsByType2 != null)
			{
				foreach (MarkItem item in from m in markItemsByType2.Values
				where m.IsTracked
				select m)
				{
					list.Add(item);
				}
			}
			foreach (MarkItem item2 in from m in this.MarkItemTracking
			where m.IsTracked && !m.IsInConsistentDistrict(false)
			select m)
			{
				list.Add(item2);
			}
			return list;
		}

		// Token: 0x060374E4 RID: 226532 RVA: 0x00D20564 File Offset: 0x00D1E764
		public List<MarkItem> GetNavigateMarkList()
		{
			List<MarkItem> list = new List<MarkItem>();
			int currentWorldMapConfigId = WorldMapModel.Instance.CurrentWorldMapConfigId;
			Dictionary<int, MarkItem> markItemsByType = this.GetMarkItemsByType(EMarkType.OtherPlayers, false);
			int? num2;
			if (markItemsByType != null)
			{
				foreach (MarkItem markItem in markItemsByType.Values)
				{
					int? dungeonLocateWorldMapId = MapModel.Instance.GetDungeonLocateWorldMapId(markItem.InstanceDungeonOrMapConfigId);
					int num = currentWorldMapConfigId;
					num2 = dungeonLocateWorldMapId;
					if (num == num2.GetValueOrDefault() & num2 != null)
					{
						list.Add(markItem);
					}
				}
			}
			Dictionary<int, MarkItem> differMapMarkItemsByType = this.GetDifferMapMarkItemsByType(EMarkType.OtherPlayers);
			if (differMapMarkItemsByType != null)
			{
				foreach (MarkItem markItem2 in differMapMarkItemsByType.Values)
				{
					int? dungeonLocateWorldMapId2 = MapModel.Instance.GetDungeonLocateWorldMapId(markItem2.InstanceDungeonOrMapConfigId);
					if (WorldMapConfig.Instance.IsMapInWorld(dungeonLocateWorldMapId2 ?? markItem2.MapId))
					{
						list.Add(markItem2);
					}
				}
			}
			global::Quest curTrackedQuest = QuestNewModel.Instance.GetCurTrackedQuest();
			int? num3;
			if (curTrackedQuest == null)
			{
				num3 = null;
			}
			else
			{
				BehaviorNodeBase currentActiveChildQuestNode = curTrackedQuest.GetCurrentActiveChildQuestNode();
				num3 = ((currentActiveChildQuestNode != null) ? new int?(currentActiveChildQuestNode.NodeId) : null);
			}
			num2 = num3;
			int valueOrDefault = num2.GetValueOrDefault();
			int valueOrDefault2 = ((curTrackedQuest != null) ? curTrackedQuest.GetDefaultMark(valueOrDefault) : null).GetValueOrDefault();
			MarkItem markItem3 = this.GetMarkItem(EMarkType.Quest, valueOrDefault2);
			TaskMarkItem taskMarkItem = markItem3 as TaskMarkItem;
			if (taskMarkItem != null && taskMarkItem.IsBtTypeQuest())
			{
				list.Add(markItem3);
			}
			return list;
		}

		// Token: 0x060374E5 RID: 226533 RVA: 0x00D20724 File Offset: 0x00D1E924
		public void AddCreateMarkTask(bool inMap, EMarkType markType, int markId, TPreemptiveExecuteMethod executeMethod)
		{
			int priority = (!inMap) ? 1 : 0;
			MapMarkPreemptiveFrameTask task = new MapMarkPreemptiveFrameTask
			{
				Priority = priority,
				MarkType = markType,
				MarkId = markId,
				Execute = executeMethod
			};
			this.MapMarkPreemptiveFrameQueue.AddTask(task);
		}

		// Token: 0x060374E6 RID: 226534 RVA: 0x00D20768 File Offset: 0x00D1E968
		[return: Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public List<ValueTuple<MarkItem, double>> FindNearbyMarkItemsByPosition(global::Vector position, float searchRadius, [Nullable(new byte[]
		{
			2,
			1
		})] Func<MarkItem, bool> filterFunction = null)
		{
			this.MapMarkPreemptiveFrameQueue.Flush();
			HashSet<int> queryNearestIndexSet = MapUtil.GetQueryNearestIndexSet(position, searchRadius);
			List<ValueTuple<MarkItem, double>> list = new List<ValueTuple<MarkItem, double>>();
			double num = (double)searchRadius * (double)searchRadius;
			foreach (int key in queryNearestIndexSet)
			{
				HashSet<MarkItem> hashSet;
				if (this.MarkItemInGrid.TryGetValue(key, out hashSet))
				{
					foreach (MarkItem markItem in hashSet)
					{
						if (filterFunction == null || filterFunction(markItem))
						{
							double num2 = global::Vector.DistSquared(markItem.WorldPosition, position);
							if (num2 <= num)
							{
								list.Add(new ValueTuple<MarkItem, double>(markItem, num2));
							}
						}
					}
				}
			}
			if (list.Count > 0)
			{
				list.Sort(([Nullable(new byte[]
				{
					0,
					1
				})] ValueTuple<MarkItem, double> a, [Nullable(new byte[]
				{
					0,
					1
				})] ValueTuple<MarkItem, double> b) => a.Item2.CompareTo(b.Item2));
			}
			return list;
		}

		// Token: 0x060374E8 RID: 226536 RVA: 0x00D208F8 File Offset: 0x00D1EAF8
		[CompilerGenerated]
		[return: Nullable(2)]
		internal static MarkItem <GetMarkItemById>g__FindMarkItemFunc|22_0(Dictionary<EMarkType, Dictionary<int, MarkItem>> allMarkItemMap, ref MapMarkContainer.<>c__DisplayClass22_0 A_1)
		{
			using (Dictionary<EMarkType, Dictionary<int, MarkItem>>.ValueCollection.Enumerator enumerator = allMarkItemMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					MarkItem result;
					if (enumerator.Current.TryGetValue(A_1.markId, out result))
					{
						return result;
					}
				}
			}
			return null;
		}

		// Token: 0x0401D22E RID: 119342
		private readonly MapMarkPreemptiveFrameQueue MapMarkPreemptiveFrameQueue = new MapMarkPreemptiveFrameQueue(50, 0);

		// Token: 0x0401D22F RID: 119343
		private readonly Dictionary<EMarkType, Dictionary<int, MarkItem>> MarkItems = new Dictionary<EMarkType, Dictionary<int, MarkItem>>();

		// Token: 0x0401D230 RID: 119344
		private readonly Dictionary<EMarkType, Dictionary<int, MarkItem>> DiffMapMarkItems = new Dictionary<EMarkType, Dictionary<int, MarkItem>>();

		// Token: 0x0401D231 RID: 119345
		private readonly Dictionary<int, HashSet<MarkItem>> MarkItemInGrid = new Dictionary<int, HashSet<MarkItem>>();

		// Token: 0x0401D232 RID: 119346
		private readonly HashSet<MarkItem> MarkItemTracking = new HashSet<MarkItem>();

		// Token: 0x0401D233 RID: 119347
		private readonly HashSet<MarkItem> TrackDeleteItems = new HashSet<MarkItem>();

		// Token: 0x0401D234 RID: 119348
		private readonly HashSet<MarkItem> CurrentUpdateSet = new HashSet<MarkItem>();

		// Token: 0x0401D235 RID: 119349
		private readonly HashSet<MarkItem> LastUpdateSet = new HashSet<MarkItem>();

		// Token: 0x0401D236 RID: 119350
		private readonly List<MarkItem> TempDeleteList = new List<MarkItem>();
	}
}

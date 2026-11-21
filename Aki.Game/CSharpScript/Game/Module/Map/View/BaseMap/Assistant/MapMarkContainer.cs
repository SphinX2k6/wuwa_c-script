using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using CSharpScript.Game.Module.Map.Misc;
using CSharpScript.Game.Module.Map.View.BaseMap.Assistant.MapFrameTaskQueue;
using CSharpScript.Game.Module.WorldMap;

namespace CSharpScript.Game.Module.Map.View.BaseMap.Assistant
{
	// Token: 0x02004474 RID: 17524
	[NullableContext(1)]
	[Nullable(0)]
	public class MapMarkContainer
	{
		// Token: 0x0602C416 RID: 181270 RVA: 0x00C6ECAF File Offset: 0x00C6CEAF
		public void Tick()
		{
			this.MapMarkPreemptiveFrameQueue.Process();
		}

		// Token: 0x0602C417 RID: 181271 RVA: 0x00C6ECBC File Offset: 0x00C6CEBC
		public void ClearMarkItems(EMarkType? type, bool? recycleToPoolImmediately)
		{
			if (type != null && type.Value != EMarkType.None)
			{
				Dictionary<int, MarkItem> dictionary;
				if (this.MarkItems.TryGetValue(type.Value, out dictionary))
				{
					foreach (MarkItem markItem in dictionary.Values)
					{
						markItem.Destroy(recycleToPoolImmediately.GetValueOrDefault(true));
						this.DeleteItemInGrid(markItem);
					}
					dictionary.Clear();
				}
				Dictionary<int, MarkItem> dictionary2;
				if (this.DiffMapMarkItems.TryGetValue(type.Value, out dictionary2))
				{
					foreach (MarkItem markItem2 in dictionary2.Values)
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

		// Token: 0x0602C418 RID: 181272 RVA: 0x00C6EE3C File Offset: 0x00C6D03C
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

		// Token: 0x0602C419 RID: 181273 RVA: 0x00C6F090 File Offset: 0x00C6D290
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

		// Token: 0x0602C41A RID: 181274 RVA: 0x00C6F0D0 File Offset: 0x00C6D2D0
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
			if (dictionary.Remove(markId, out markItem))
			{
				this.DeleteItemInGrid(markItem);
				ELogAuthor author = ELogAuthor.LYX;
				string message = "标记系统->MapMarkContainer.RemoveMarkItem";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("markType", markType);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("markId", markId);
				MapLogger.Debug(author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return markItem;
			}
			return null;
		}

		// Token: 0x0602C41B RID: 181275 RVA: 0x00C6F16F File Offset: 0x00C6D36F
		public void CollectViews(List<MarkPanelBase> result)
		{
			MapMarkContainer.CollectViewsFrom(this.MarkItems, result);
			MapMarkContainer.CollectViewsFrom(this.DiffMapMarkItems, result);
		}

		// Token: 0x0602C41C RID: 181276 RVA: 0x00C6F18C File Offset: 0x00C6D38C
		private static void CollectViewsFrom(Dictionary<EMarkType, Dictionary<int, MarkItem>> markItemMap, List<MarkPanelBase> result)
		{
			foreach (Dictionary<int, MarkItem> dictionary in markItemMap.Values)
			{
				foreach (MarkItem markItem in dictionary.Values)
				{
					if (markItem.View != null)
					{
						result.Add(markItem.View);
					}
				}
			}
		}

		// Token: 0x0602C41D RID: 181277 RVA: 0x00C6F228 File Offset: 0x00C6D428
		private void RemoveMarkItems(Dictionary<EMarkType, Dictionary<int, MarkItem>> markItemMap, bool? recycleToPoolImmediately)
		{
			foreach (Dictionary<int, MarkItem> dictionary in markItemMap.Values)
			{
				foreach (MarkItem markItem in dictionary.Values)
				{
					markItem.Destroy(recycleToPoolImmediately.GetValueOrDefault(true));
				}
			}
		}

		// Token: 0x0602C41E RID: 181278 RVA: 0x00C6F2BC File Offset: 0x00C6D4BC
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

		// Token: 0x0602C41F RID: 181279 RVA: 0x00C6F314 File Offset: 0x00C6D514
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

		// Token: 0x0602C420 RID: 181280 RVA: 0x00C6F360 File Offset: 0x00C6D560
		private void DeleteItemInGrid(MarkItem mark)
		{
			int gridId = mark.GridId;
			HashSet<MarkItem> hashSet;
			if (this.MarkItemInGrid.TryGetValue(gridId, out hashSet))
			{
				hashSet.Remove(mark);
			}
		}

		// Token: 0x0602C421 RID: 181281 RVA: 0x00C6F38C File Offset: 0x00C6D58C
		public bool ExistMarkItem(EMarkType markType, int markId)
		{
			return this.GetMarkItemPurely(markType, markId) != null;
		}

		// Token: 0x0602C422 RID: 181282 RVA: 0x00C6F399 File Offset: 0x00C6D599
		public bool ExistMarkItemTask(EMarkType markType, int markId)
		{
			return this.MapMarkPreemptiveFrameQueue.HasTask(markType, markId);
		}

		// Token: 0x0602C423 RID: 181283 RVA: 0x00C6F3A8 File Offset: 0x00C6D5A8
		[NullableContext(2)]
		public MarkItem GetMarkItem(EMarkType markType, int markId)
		{
			this.MapMarkPreemptiveFrameQueue.ForceExecuteTask(markType, markId);
			return this.GetMarkItemPurely(markType, markId);
		}

		// Token: 0x0602C424 RID: 181284 RVA: 0x00C6F3C0 File Offset: 0x00C6D5C0
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

		// Token: 0x0602C425 RID: 181285 RVA: 0x00C6F3FC File Offset: 0x00C6D5FC
		[NullableContext(2)]
		public MarkItem GetMarkItemById(int markId, bool withCrossMap = false)
		{
			MapMarkContainer.<>c__DisplayClass24_0 CS$<>8__locals1;
			CS$<>8__locals1.markId = markId;
			MarkItem markItem = MapMarkContainer.<GetMarkItemById>g__FindMarkItemFunc|24_0(this.MarkItems, ref CS$<>8__locals1);
			if (markItem == null && withCrossMap)
			{
				markItem = MapMarkContainer.<GetMarkItemById>g__FindMarkItemFunc|24_0(this.DiffMapMarkItems, ref CS$<>8__locals1);
			}
			return markItem;
		}

		// Token: 0x0602C426 RID: 181286 RVA: 0x00C6F438 File Offset: 0x00C6D638
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

		// Token: 0x0602C427 RID: 181287 RVA: 0x00C6F464 File Offset: 0x00C6D664
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

		// Token: 0x0602C428 RID: 181288 RVA: 0x00C6F4A0 File Offset: 0x00C6D6A0
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

		// Token: 0x0602C429 RID: 181289 RVA: 0x00C6F4BD File Offset: 0x00C6D6BD
		public Dictionary<EMarkType, Dictionary<int, MarkItem>> GetAllMarkItems()
		{
			return this.MarkItems;
		}

		// Token: 0x0602C42A RID: 181290 RVA: 0x00C6F4C5 File Offset: 0x00C6D6C5
		public Dictionary<EMarkType, Dictionary<int, MarkItem>> GetAllDiffMapMarkItems()
		{
			return this.DiffMapMarkItems;
		}

		// Token: 0x0602C42B RID: 181291 RVA: 0x00C6F4D0 File Offset: 0x00C6D6D0
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

		// Token: 0x0602C42C RID: 181292 RVA: 0x00C6F548 File Offset: 0x00C6D748
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

		// Token: 0x0602C42D RID: 181293 RVA: 0x00C6F7C8 File Offset: 0x00C6D9C8
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

		// Token: 0x0602C42E RID: 181294 RVA: 0x00C6F984 File Offset: 0x00C6DB84
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

		// Token: 0x0602C42F RID: 181295 RVA: 0x00C6F9C0 File Offset: 0x00C6DBC0
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
				if (markItem == null)
				{
					return;
				}
				IMarkConfig markConfig = markItem.Config;
				if (markItem.MarkType == EMarkType.HonamiScanItem)
				{
					HonamiScanItemMarkItem honamiScanItemMarkItem = markItem as HonamiScanItemMarkItem;
					MapMark? configMark = MapConfig.Instance.GetConfigMark(honamiScanItemMarkItem.ConfigId);
					markConfig = ((configMark != null) ? new MapMarkConfig(configMark.Value) : null);
				}
				TrackController.Instance.StartTrack(new TrackData
				{
					TrackSource = markItem.TrackSource,
					Id = markId,
					MarkType = new EMarkType?(markType),
					IconPath = markItem.IconPath,
					TrackTarget = markItem.TrackTarget,
					TrackInstanceId = markItem.RelativeInstanceDungeonId,
					TrackHudEnable = new bool?(markConfig != null && markConfig.TrackHudEnable == 1),
					TrackAutoCancelDistance = ((markConfig != null) ? new float?(markConfig.TrackAutoCancelDistance) : null)
				}, true);
				this.MarkItemTracking.Add(markItem);
			}
			else
			{
				TrackController.Instance.EndTrack(type, markId);
				if (markItem == null)
				{
					return;
				}
				this.TrackDeleteItems.Add(markItem);
				this.MarkItemTracking.Remove(markItem);
			}
			EventSystem.Instance.Emit<MarkItem>(EEventName.OnMarkItemTrackStateChange, markItem);
		}

		// Token: 0x0602C430 RID: 181296 RVA: 0x00C6FB74 File Offset: 0x00C6DD74
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

		// Token: 0x0602C431 RID: 181297 RVA: 0x00C6FBE0 File Offset: 0x00C6DDE0
		public void UnTrackMark(ITrackData trackData)
		{
			MarkItem markItem = this.GetMarkItem(trackData.MarkType.GetValueOrDefault(), trackData.Id);
			if (markItem != null)
			{
				this.MarkItemTracking.Remove(markItem);
				this.TrackDeleteItems.Add(markItem);
			}
		}

		// Token: 0x0602C432 RID: 181298 RVA: 0x00C6FC28 File Offset: 0x00C6DE28
		public void ClearTrackMark()
		{
			foreach (MarkItem markItem in this.MarkItemTracking)
			{
				if (markItem.View != null)
				{
					this.TrackDeleteItems.Add(markItem);
				}
			}
			this.MarkItemTracking.Clear();
		}

		// Token: 0x0602C433 RID: 181299 RVA: 0x00C6FC94 File Offset: 0x00C6DE94
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
				foreach (MarkItem markItem in markItemsByType2.Values)
				{
					if (markItem.IsTracked)
					{
						list.Add(markItem);
					}
				}
			}
			foreach (MarkItem markItem2 in this.MarkItemTracking)
			{
				if (markItem2.IsTracked && !markItem2.IsInConsistentDistrict(false))
				{
					list.Add(markItem2);
				}
			}
			return list;
		}

		// Token: 0x0602C434 RID: 181300 RVA: 0x00C6FD78 File Offset: 0x00C6DF78
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

		// Token: 0x0602C435 RID: 181301 RVA: 0x00C6FF38 File Offset: 0x00C6E138
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

		// Token: 0x0602C436 RID: 181302 RVA: 0x00C6FF7C File Offset: 0x00C6E17C
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

		// Token: 0x0602C438 RID: 181304 RVA: 0x00C7010C File Offset: 0x00C6E30C
		[CompilerGenerated]
		[return: Nullable(2)]
		internal static MarkItem <GetMarkItemById>g__FindMarkItemFunc|24_0(Dictionary<EMarkType, Dictionary<int, MarkItem>> allMarkItemMap, ref MapMarkContainer.<>c__DisplayClass24_0 A_1)
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

		// Token: 0x04017CCA RID: 97482
		private readonly MapMarkPreemptiveFrameQueue MapMarkPreemptiveFrameQueue = new MapMarkPreemptiveFrameQueue(50, 0);

		// Token: 0x04017CCB RID: 97483
		private readonly Dictionary<EMarkType, Dictionary<int, MarkItem>> MarkItems = new Dictionary<EMarkType, Dictionary<int, MarkItem>>();

		// Token: 0x04017CCC RID: 97484
		private readonly Dictionary<EMarkType, Dictionary<int, MarkItem>> DiffMapMarkItems = new Dictionary<EMarkType, Dictionary<int, MarkItem>>();

		// Token: 0x04017CCD RID: 97485
		private readonly Dictionary<int, HashSet<MarkItem>> MarkItemInGrid = new Dictionary<int, HashSet<MarkItem>>();

		// Token: 0x04017CCE RID: 97486
		private readonly HashSet<MarkItem> MarkItemTracking = new HashSet<MarkItem>();

		// Token: 0x04017CCF RID: 97487
		private readonly HashSet<MarkItem> TrackDeleteItems = new HashSet<MarkItem>();

		// Token: 0x04017CD0 RID: 97488
		private readonly HashSet<MarkItem> CurrentUpdateSet = new HashSet<MarkItem>();

		// Token: 0x04017CD1 RID: 97489
		private readonly HashSet<MarkItem> LastUpdateSet = new HashSet<MarkItem>();

		// Token: 0x04017CD2 RID: 97490
		private readonly List<MarkItem> TempDeleteList = new List<MarkItem>();
	}
}

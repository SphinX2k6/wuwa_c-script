using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain.MainActivity
{
	// Token: 0x02006750 RID: 26448
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class DirectTrainModel : ModelBase
	{
		// Token: 0x06042015 RID: 270357 RVA: 0x01002CEE File Offset: 0x01000EEE
		public IReadOnlyList<int> GetMainSubActivityIds()
		{
			return this.MainSubActivityIds;
		}

		// Token: 0x06042016 RID: 270358 RVA: 0x01002CF6 File Offset: 0x01000EF6
		public IReadOnlyList<int> GetProSubActivityIds()
		{
			return this.ProSubActivityIds;
		}

		// Token: 0x06042017 RID: 270359 RVA: 0x01002CFE File Offset: 0x01000EFE
		[NullableContext(2)]
		public void SetMainSubActivityIds(IReadOnlyList<int> ids)
		{
			this.MainSubActivityIds.Clear();
			if (ids != null)
			{
				this.MainSubActivityIds.AddRange(ids);
			}
		}

		// Token: 0x06042018 RID: 270360 RVA: 0x01002D1A File Offset: 0x01000F1A
		public int GetProMainActivityId()
		{
			return this.ProMainActivityId;
		}

		// Token: 0x06042019 RID: 270361 RVA: 0x01002D24 File Offset: 0x01000F24
		public int GetProMainActivityHelpId()
		{
			if (this.ProMainActivityId == 0)
			{
				return 0;
			}
			Activity? activityConfig = ActivityConfig.Instance.GetActivityConfig(this.ProMainActivityId);
			if (activityConfig == null)
			{
				return 0;
			}
			return activityConfig.Value.HelpId;
		}

		// Token: 0x0604201A RID: 270362 RVA: 0x01002D68 File Offset: 0x01000F68
		[NullableContext(2)]
		public IDirectTrainSubActivityCache GetSubActivityCache(int subActivityId)
		{
			IDirectTrainSubActivityCache result;
			if (!this.SubActivityCacheMap.TryGetValue(subActivityId, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0604201B RID: 270363 RVA: 0x01002D88 File Offset: 0x01000F88
		public IReadOnlyDictionary<int, IDirectTrainSubActivityCache> GetAllSubActivityCaches()
		{
			return this.SubActivityCacheMap;
		}

		// Token: 0x0604201C RID: 270364 RVA: 0x01002D90 File Offset: 0x01000F90
		public IReadOnlyDictionary<int, IDirectTrainSubActivityCache> GetAllProSubActivityCaches()
		{
			return this.ProSubActivityCacheMap;
		}

		// Token: 0x0604201D RID: 270365 RVA: 0x01002D98 File Offset: 0x01000F98
		[NullableContext(2)]
		public DirectTrainSubActivityViewModel BuildSubActivityViewModel(int subActivityId)
		{
			IDirectTrainSubActivityCache cache;
			if (!this.SubActivityCacheMap.TryGetValue(subActivityId, out cache) && !this.ProSubActivityCacheMap.TryGetValue(subActivityId, out cache))
			{
				return null;
			}
			DirectTrainSubActivityViewModel directTrainSubActivityViewModel = new DirectTrainSubActivityViewModel();
			directTrainSubActivityViewModel.LoadConfig(cache);
			return directTrainSubActivityViewModel;
		}

		// Token: 0x0604201E RID: 270366 RVA: 0x01002DD4 File Offset: 0x01000FD4
		public IReadOnlyList<DirectTrainSubActivityViewModel> BuildSubActivityViewModels(IReadOnlyList<int> subActivityIdOrder, IReadOnlyDictionary<int, IDirectTrainSubActivityCache> cacheSource, int mainActivityId)
		{
			Dictionary<int, int> orderIndex = new Dictionary<int, int>();
			List<DirectTrainSubActivityViewModel> list = new List<DirectTrainSubActivityViewModel>();
			for (int i = 0; i < subActivityIdOrder.Count; i++)
			{
				int key = subActivityIdOrder[i];
				orderIndex[key] = i;
				IDirectTrainSubActivityCache cache;
				if (cacheSource.TryGetValue(key, out cache))
				{
					DirectTrainSubActivityViewModel directTrainSubActivityViewModel = new DirectTrainSubActivityViewModel();
					directTrainSubActivityViewModel.LoadConfig(cache);
					directTrainSubActivityViewModel.MainActivityId = mainActivityId;
					list.Add(directTrainSubActivityViewModel);
				}
			}
			list.Sort(delegate(DirectTrainSubActivityViewModel a, DirectTrainSubActivityViewModel b)
			{
				if (a.IsFinish == b.IsFinish)
				{
					int num2;
					int num = orderIndex.TryGetValue(a.SubActivityId, out num2) ? num2 : int.MaxValue;
					int num4;
					int num3 = orderIndex.TryGetValue(b.SubActivityId, out num4) ? num4 : int.MaxValue;
					return num - num3;
				}
				if (!a.IsFinish)
				{
					return -1;
				}
				return 1;
			});
			return list;
		}

		// Token: 0x0604201F RID: 270367 RVA: 0x01002E5C File Offset: 0x0100105C
		public void RefreshSubActivityCache(int subActivityId)
		{
			ActivityModel instance = ActivityModel.Instance;
			ActivityBaseData activityBaseData = (instance != null) ? instance.GetActivityById(subActivityId) : null;
			if (activityBaseData == null)
			{
				return;
			}
			IDirectTrainSubActivityCache value = new IDirectTrainSubActivityCache
			{
				Id = subActivityId,
				IsUnLock = activityBaseData.IsUnLock(),
				IsFinish = activityBaseData.FinishShowState,
				InShowTime = activityBaseData.CheckIfInShowTime()
			};
			this.SubActivityCacheMap[subActivityId] = value;
		}

		// Token: 0x06042020 RID: 270368 RVA: 0x01002EC0 File Offset: 0x010010C0
		public void RefreshProSubActivityCache(int subActivityId)
		{
			ActivityDirectTrainModel instance = ActivityDirectTrainModel.Instance;
			ActivityDirectTrainData activityDirectTrainData = (instance != null) ? instance.GetActivityById(subActivityId) : null;
			if (activityDirectTrainData == null)
			{
				return;
			}
			IDirectTrainSubActivityCache directTrainSubActivityCache;
			if (this.ProSubActivityCacheMap.TryGetValue(subActivityId, out directTrainSubActivityCache))
			{
				directTrainSubActivityCache.IsUnLock = activityDirectTrainData.IsUnLock();
				directTrainSubActivityCache.IsFinish = activityDirectTrainData.FinishShowState;
				directTrainSubActivityCache.InShowTime = activityDirectTrainData.CheckIfInShowTime();
				return;
			}
			if (!this.ProSubActivityIds.Contains(subActivityId))
			{
				return;
			}
			this.ProSubActivityCacheMap[subActivityId] = new IDirectTrainSubActivityCache
			{
				Id = subActivityId,
				IsUnLock = activityDirectTrainData.IsUnLock(),
				IsFinish = activityDirectTrainData.FinishShowState,
				InShowTime = activityDirectTrainData.CheckIfInShowTime()
			};
		}

		// Token: 0x06042021 RID: 270369 RVA: 0x01002F64 File Offset: 0x01001164
		[NullableContext(2)]
		public void LoadFromProInfoProto(DirectTrainInfoResponse proto)
		{
			this.ProSubActivityCacheMap.Clear();
			this.ProMainActivityId = 0;
			this.ProSubActivityIds.Clear();
			if (proto == null)
			{
				return;
			}
			ActivityData mainActivity = proto.MainActivity;
			this.ProMainActivityId = ((mainActivity != null) ? mainActivity.Id : 0);
			ActivityData mainActivity2 = proto.MainActivity;
			RepeatedField<int> repeatedField;
			if (mainActivity2 == null)
			{
				repeatedField = null;
			}
			else
			{
				ThroughTrainSummaryActivityData throughTrainSummaryActivityData = mainActivity2.ThroughTrainSummaryActivityData;
				repeatedField = ((throughTrainSummaryActivityData != null) ? throughTrainSummaryActivityData.ActivityIds : null);
			}
			RepeatedField<int> repeatedField2 = repeatedField;
			if (repeatedField2 != null)
			{
				this.ProSubActivityIds.AddRange(repeatedField2);
			}
			RepeatedField<ActivityData> repeatedField3 = proto.Activitys ?? new RepeatedField<ActivityData>();
			if (repeatedField3.Count <= 0)
			{
				return;
			}
			List<string> list = new List<string>();
			foreach (ActivityData activityData in repeatedField3)
			{
				int id = activityData.Id;
				ActivityDirectTrainModel instance = ActivityDirectTrainModel.Instance;
				ActivityDirectTrainData activityDirectTrainData = (instance != null) ? instance.GetActivityById(id) : null;
				IDirectTrainSubActivityCache directTrainSubActivityCache = new IDirectTrainSubActivityCache
				{
					Id = id,
					IsUnLock = (activityDirectTrainData != null && activityDirectTrainData.IsUnLock()),
					IsFinish = (activityDirectTrainData != null && activityDirectTrainData.FinishShowState),
					InShowTime = (activityDirectTrainData != null && activityDirectTrainData.CheckIfInShowTime())
				};
				this.ProSubActivityCacheMap[id] = directTrainSubActivityCache;
				List<string> list2 = list;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 4);
				defaultInterpolatedStringHandler.AppendLiteral("子活动");
				defaultInterpolatedStringHandler.AppendFormatted<int>(id);
				defaultInterpolatedStringHandler.AppendLiteral(": 解锁=");
				defaultInterpolatedStringHandler.AppendFormatted<bool>(directTrainSubActivityCache.IsUnLock);
				defaultInterpolatedStringHandler.AppendLiteral(", 完成=");
				defaultInterpolatedStringHandler.AppendFormatted<bool>(directTrainSubActivityCache.IsFinish);
				defaultInterpolatedStringHandler.AppendLiteral(", 展示中=");
				defaultInterpolatedStringHandler.AppendFormatted<bool>(directTrainSubActivityCache.InShowTime);
				list2.Add(defaultInterpolatedStringHandler.ToStringAndClear());
			}
		}

		// Token: 0x06042022 RID: 270370 RVA: 0x01003130 File Offset: 0x01001330
		[NullableContext(2)]
		private ServerStorageSet GetFirstCheckSet()
		{
			return ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ThroughTrainFirstCheck) as ServerStorageSet;
		}

		// Token: 0x06042023 RID: 270371 RVA: 0x01003144 File Offset: 0x01001344
		public bool HasUnReadSubActivity()
		{
			foreach (int subActivityId in this.SubActivityCacheMap.Keys)
			{
				if (this.IsSubActivityRedDotOn(subActivityId))
				{
					return true;
				}
			}
			foreach (int subActivityId2 in this.ProSubActivityCacheMap.Keys)
			{
				if (this.IsSubActivityRedDotOn(subActivityId2))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06042024 RID: 270372 RVA: 0x010031F4 File Offset: 0x010013F4
		public bool IsSubActivityUnRead(int subActivityId)
		{
			ServerStorageSet firstCheckSet = this.GetFirstCheckSet();
			return firstCheckSet != null && !firstCheckSet.Has(subActivityId);
		}

		// Token: 0x06042025 RID: 270373 RVA: 0x01003218 File Offset: 0x01001418
		public bool IsSubActivityRedDotOn(int subActivityId)
		{
			IDirectTrainSubActivityCache directTrainSubActivityCache;
			return (this.SubActivityCacheMap.TryGetValue(subActivityId, out directTrainSubActivityCache) || this.ProSubActivityCacheMap.TryGetValue(subActivityId, out directTrainSubActivityCache)) && !directTrainSubActivityCache.IsFinish && directTrainSubActivityCache.IsUnLock && this.IsSubActivityUnRead(subActivityId);
		}

		// Token: 0x06042026 RID: 270374 RVA: 0x01003260 File Offset: 0x01001460
		public void MarkSubActivityAsRead(int subActivityId)
		{
			IDirectTrainSubActivityCache directTrainSubActivityCache;
			if ((!this.SubActivityCacheMap.TryGetValue(subActivityId, out directTrainSubActivityCache) && !this.ProSubActivityCacheMap.TryGetValue(subActivityId, out directTrainSubActivityCache)) || !directTrainSubActivityCache.IsUnLock)
			{
				return;
			}
			ServerStorageSet firstCheckSet = this.GetFirstCheckSet();
			if (firstCheckSet == null)
			{
				return;
			}
			if (firstCheckSet.Has(subActivityId))
			{
				return;
			}
			firstCheckSet.Add(subActivityId);
			EventSystem.Instance.Emit<int>(EEventName.ActivityDirectTrainRedDotUpdate, 0);
		}

		// Token: 0x17009665 RID: 38501
		// (get) Token: 0x06042027 RID: 270375 RVA: 0x010032C3 File Offset: 0x010014C3
		public static DirectTrainModel Instance
		{
			get
			{
				return DirectTrainModel._Instance;
			}
		}

		// Token: 0x06042028 RID: 270376 RVA: 0x010032CA File Offset: 0x010014CA
		public static DirectTrainModel GetOrCreateInstance()
		{
			if (DirectTrainModel._Instance == null)
			{
				DirectTrainModel.CreateInstance();
			}
			return DirectTrainModel._Instance;
		}

		// Token: 0x06042029 RID: 270377 RVA: 0x010032DE File Offset: 0x010014DE
		public static bool CreateInstance()
		{
			if (DirectTrainModel._Instance != null)
			{
				return true;
			}
			DirectTrainModel._Instance = new DirectTrainModel();
			return true;
		}

		// Token: 0x0604202A RID: 270378 RVA: 0x010032F4 File Offset: 0x010014F4
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0604202B RID: 270379 RVA: 0x010032F6 File Offset: 0x010014F6
		public static void ResetStaticDefaultValue()
		{
			DirectTrainModel._Instance = null;
		}

		// Token: 0x0604202C RID: 270380 RVA: 0x010032FE File Offset: 0x010014FE
		static DirectTrainModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DirectTrainModel.CreateStaticDefaultValue), new Action(DirectTrainModel.ResetStaticDefaultValue));
		}

		// Token: 0x04022617 RID: 140823
		private readonly Dictionary<int, IDirectTrainSubActivityCache> SubActivityCacheMap = new Dictionary<int, IDirectTrainSubActivityCache>();

		// Token: 0x04022618 RID: 140824
		private readonly Dictionary<int, IDirectTrainSubActivityCache> ProSubActivityCacheMap = new Dictionary<int, IDirectTrainSubActivityCache>();

		// Token: 0x04022619 RID: 140825
		private int ProMainActivityId;

		// Token: 0x0402261A RID: 140826
		private readonly List<int> MainSubActivityIds = new List<int>();

		// Token: 0x0402261B RID: 140827
		private readonly List<int> ProSubActivityIds = new List<int>();

		// Token: 0x0402261C RID: 140828
		[Nullable(2)]
		private static DirectTrainModel _Instance;
	}
}

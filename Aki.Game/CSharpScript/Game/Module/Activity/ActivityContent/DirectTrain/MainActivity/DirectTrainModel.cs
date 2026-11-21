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
	// Token: 0x020056A0 RID: 22176
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class DirectTrainModel : ModelBase
	{
		// Token: 0x06036B67 RID: 224103 RVA: 0x00F44129 File Offset: 0x00F42329
		public IReadOnlyList<int> GetMainSubActivityIds()
		{
			return this.MainSubActivityIds;
		}

		// Token: 0x06036B68 RID: 224104 RVA: 0x00F44131 File Offset: 0x00F42331
		public IReadOnlyList<int> GetProSubActivityIds()
		{
			return this.ProSubActivityIds;
		}

		// Token: 0x06036B69 RID: 224105 RVA: 0x00F44139 File Offset: 0x00F42339
		[NullableContext(2)]
		public void SetMainSubActivityIds(IReadOnlyList<int> ids)
		{
			this.MainSubActivityIds.Clear();
			if (ids != null)
			{
				this.MainSubActivityIds.AddRange(ids);
			}
		}

		// Token: 0x06036B6A RID: 224106 RVA: 0x00F44155 File Offset: 0x00F42355
		public int GetProMainActivityId()
		{
			return this.ProMainActivityId;
		}

		// Token: 0x06036B6B RID: 224107 RVA: 0x00F44160 File Offset: 0x00F42360
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

		// Token: 0x06036B6C RID: 224108 RVA: 0x00F441A4 File Offset: 0x00F423A4
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

		// Token: 0x06036B6D RID: 224109 RVA: 0x00F441C4 File Offset: 0x00F423C4
		public IReadOnlyDictionary<int, IDirectTrainSubActivityCache> GetAllSubActivityCaches()
		{
			return this.SubActivityCacheMap;
		}

		// Token: 0x06036B6E RID: 224110 RVA: 0x00F441CC File Offset: 0x00F423CC
		public IReadOnlyDictionary<int, IDirectTrainSubActivityCache> GetAllProSubActivityCaches()
		{
			return this.ProSubActivityCacheMap;
		}

		// Token: 0x06036B6F RID: 224111 RVA: 0x00F441D4 File Offset: 0x00F423D4
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

		// Token: 0x06036B70 RID: 224112 RVA: 0x00F44210 File Offset: 0x00F42410
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

		// Token: 0x06036B71 RID: 224113 RVA: 0x00F44298 File Offset: 0x00F42498
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

		// Token: 0x06036B72 RID: 224114 RVA: 0x00F442FC File Offset: 0x00F424FC
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

		// Token: 0x06036B73 RID: 224115 RVA: 0x00F443A0 File Offset: 0x00F425A0
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

		// Token: 0x06036B74 RID: 224116 RVA: 0x00F4456C File Offset: 0x00F4276C
		[NullableContext(2)]
		private ServerStorageSet GetFirstCheckSet()
		{
			return ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ThroughTrainFirstCheck) as ServerStorageSet;
		}

		// Token: 0x06036B75 RID: 224117 RVA: 0x00F44580 File Offset: 0x00F42780
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

		// Token: 0x06036B76 RID: 224118 RVA: 0x00F44630 File Offset: 0x00F42830
		public bool IsSubActivityUnRead(int subActivityId)
		{
			ServerStorageSet firstCheckSet = this.GetFirstCheckSet();
			return firstCheckSet != null && !firstCheckSet.Has(subActivityId);
		}

		// Token: 0x06036B77 RID: 224119 RVA: 0x00F44654 File Offset: 0x00F42854
		public bool IsSubActivityRedDotOn(int subActivityId)
		{
			IDirectTrainSubActivityCache directTrainSubActivityCache;
			return (this.SubActivityCacheMap.TryGetValue(subActivityId, out directTrainSubActivityCache) || this.ProSubActivityCacheMap.TryGetValue(subActivityId, out directTrainSubActivityCache)) && !directTrainSubActivityCache.IsFinish && directTrainSubActivityCache.IsUnLock && this.IsSubActivityUnRead(subActivityId);
		}

		// Token: 0x06036B78 RID: 224120 RVA: 0x00F4469C File Offset: 0x00F4289C
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

		// Token: 0x170069A4 RID: 27044
		// (get) Token: 0x06036B79 RID: 224121 RVA: 0x00F446FF File Offset: 0x00F428FF
		public static DirectTrainModel Instance
		{
			get
			{
				return DirectTrainModel._Instance;
			}
		}

		// Token: 0x06036B7A RID: 224122 RVA: 0x00F44706 File Offset: 0x00F42906
		public static DirectTrainModel GetOrCreateInstance()
		{
			if (DirectTrainModel._Instance == null)
			{
				DirectTrainModel.CreateInstance();
			}
			return DirectTrainModel._Instance;
		}

		// Token: 0x06036B7B RID: 224123 RVA: 0x00F4471A File Offset: 0x00F4291A
		public static bool CreateInstance()
		{
			if (DirectTrainModel._Instance != null)
			{
				return true;
			}
			DirectTrainModel._Instance = new DirectTrainModel();
			return true;
		}

		// Token: 0x06036B7C RID: 224124 RVA: 0x00F44730 File Offset: 0x00F42930
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06036B7D RID: 224125 RVA: 0x00F44732 File Offset: 0x00F42932
		public static void ResetStaticDefaultValue()
		{
			DirectTrainModel._Instance = null;
		}

		// Token: 0x06036B7E RID: 224126 RVA: 0x00F4473A File Offset: 0x00F4293A
		static DirectTrainModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DirectTrainModel.CreateStaticDefaultValue), new Action(DirectTrainModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401CE70 RID: 118384
		private readonly Dictionary<int, IDirectTrainSubActivityCache> SubActivityCacheMap = new Dictionary<int, IDirectTrainSubActivityCache>();

		// Token: 0x0401CE71 RID: 118385
		private readonly Dictionary<int, IDirectTrainSubActivityCache> ProSubActivityCacheMap = new Dictionary<int, IDirectTrainSubActivityCache>();

		// Token: 0x0401CE72 RID: 118386
		private int ProMainActivityId;

		// Token: 0x0401CE73 RID: 118387
		private readonly List<int> MainSubActivityIds = new List<int>();

		// Token: 0x0401CE74 RID: 118388
		private readonly List<int> ProSubActivityIds = new List<int>();

		// Token: 0x0401CE75 RID: 118389
		[Nullable(2)]
		private static DirectTrainModel _Instance;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A2C RID: 18988
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class TrapDefenseLevelModeDataBase : ITrapDefenseLevelModeData<TrapDefenseLevelModeDataBase>
	{
		// Token: 0x17007A31 RID: 31281
		// (get) Token: 0x060314C9 RID: 201929 RVA: 0x00B6F67C File Offset: 0x00B6D87C
		// (set) Token: 0x060314CA RID: 201930 RVA: 0x00B6F684 File Offset: 0x00B6D884
		public int ActivityId { get; set; }

		// Token: 0x060314CB RID: 201931
		protected abstract void Init();

		// Token: 0x060314CC RID: 201932 RVA: 0x00B6F68D File Offset: 0x00B6D88D
		public static T Create<[Nullable(0)] T>(int activityId) where T : TrapDefenseLevelModeDataBase, new()
		{
			T t = Activator.CreateInstance<T>();
			t.ActivityId = activityId;
			t.Init();
			t.InitLocalData();
			return t;
		}

		// Token: 0x060314CD RID: 201933 RVA: 0x00B6F6B6 File Offset: 0x00B6D8B6
		public virtual void InitLocalData()
		{
			this.CacheReachOpenTimeLevels = (LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.TrapDefenseLevelReachOpenTime, null) ?? new HashSet<int>());
		}

		// Token: 0x060314CE RID: 201934 RVA: 0x00B6F6D2 File Offset: 0x00B6D8D2
		public void SaveCacheReachOpenTimeLevels()
		{
			if (this.IsChangeCacheLevels)
			{
				LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.TrapDefenseLevelReachOpenTime, this.CacheReachOpenTimeLevels);
				this.IsChangeCacheLevels = false;
			}
		}

		// Token: 0x060314CF RID: 201935 RVA: 0x00B6F6F4 File Offset: 0x00B6D8F4
		public TrapDefenseLevelData AddLevelConfig(TrapDefenseActivity config)
		{
			TrapDefenseLevelData trapDefenseLevelData = TrapDefenseLevelData.Create(config);
			this.LevelDataList.Add(trapDefenseLevelData);
			return trapDefenseLevelData;
		}

		// Token: 0x060314D0 RID: 201936 RVA: 0x00B6F718 File Offset: 0x00B6D918
		public void SortLevelDataList()
		{
			this.LevelDataList.Sort(delegate(TrapDefenseLevelData a, TrapDefenseLevelData b)
			{
				int nextId = a.Config.NextId;
				int nextId2 = b.Config.NextId;
				if (nextId == nextId2)
				{
					return a.Id - b.Id;
				}
				if (nextId == 0)
				{
					return 1;
				}
				if (nextId2 == 0)
				{
					return -1;
				}
				return nextId - nextId2;
			});
			for (int i = 0; i < this.LevelDataList.Count; i++)
			{
				this.LevelDataList[i].SetPosition(i + 1);
			}
		}

		// Token: 0x060314D1 RID: 201937 RVA: 0x00B6F779 File Offset: 0x00B6D979
		[NullableContext(0)]
		public ValueTuple<int, int> GetModeStarProgress()
		{
			return new ValueTuple<int, int>(this.GetModeAllGetStarNum(), this.GetModeTotalStar());
		}

		// Token: 0x060314D2 RID: 201938 RVA: 0x00B6F78C File Offset: 0x00B6D98C
		public int GetModeAllGetStarNum()
		{
			int num = 0;
			foreach (TrapDefenseLevelData trapDefenseLevelData in this.LevelDataList)
			{
				num += trapDefenseLevelData.ReachTargetIndexList.Count;
			}
			return num;
		}

		// Token: 0x060314D3 RID: 201939 RVA: 0x00B6F7EC File Offset: 0x00B6D9EC
		public int GetModeTotalStar()
		{
			int num = 0;
			foreach (TrapDefenseLevelData trapDefenseLevelData in this.LevelDataList)
			{
				num += trapDefenseLevelData.Config.StarRatingConditionsLength;
			}
			return num;
		}

		// Token: 0x060314D4 RID: 201940 RVA: 0x00B6F84C File Offset: 0x00B6DA4C
		public TrapDefenseLevelData GetNextChallengeData()
		{
			int num = this.LevelDataList.FindIndex((TrapDefenseLevelData data) => !data.IsUnlock);
			if (num < 0)
			{
				if (this.LevelDataList.Count <= 0)
				{
					return null;
				}
				return this.LevelDataList[this.LevelDataList.Count - 1];
			}
			else
			{
				if (num != 0)
				{
					return this.LevelDataList[num - 1];
				}
				return this.LevelDataList[0];
			}
		}

		// Token: 0x060314D5 RID: 201941 RVA: 0x00B6F8D0 File Offset: 0x00B6DAD0
		public bool RedDotLevelReachOpenTime()
		{
			foreach (TrapDefenseLevelData trapDefenseLevelData in this.LevelDataList)
			{
				if (!this.CacheReachOpenTimeLevels.Contains(trapDefenseLevelData.Id) && trapDefenseLevelData.IsReachOpenTimeIgnoreZero())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060314D6 RID: 201942 RVA: 0x00B6F940 File Offset: 0x00B6DB40
		public bool CheckLevelReachOpenTimeRedDotState(TrapDefenseLevelData data)
		{
			if (!this.GetLevelReachOpenTimeRedDotState(data))
			{
				return false;
			}
			this.IsChangeCacheLevels = true;
			this.CacheReachOpenTimeLevels.Add(data.Id);
			EventSystem.Instance.Emit<int>(this.GetLevelReachOpenTimeRedDotEventName(), data.Id);
			ActivityTrapDefenseController instance = ActivityTrapDefenseController.Instance;
			if (instance != null)
			{
				instance.RefreshActivityRedDot();
			}
			return true;
		}

		// Token: 0x060314D7 RID: 201943 RVA: 0x00B6F999 File Offset: 0x00B6DB99
		public bool GetLevelReachOpenTimeRedDotState(TrapDefenseLevelData data)
		{
			return !this.CacheReachOpenTimeLevels.Contains(data.Id) && data.IsReachOpenTimeIgnoreZero();
		}

		// Token: 0x060314D8 RID: 201944 RVA: 0x00B6F9B6 File Offset: 0x00B6DBB6
		protected virtual EEventName GetLevelReachOpenTimeRedDotEventName()
		{
			return EEventName.RedDotUpdateTrapDefenseLevelModeLevelReachOpenTime;
		}

		// Token: 0x0401A5A0 RID: 107936
		public readonly List<TrapDefenseLevelData> LevelDataList = new List<TrapDefenseLevelData>();

		// Token: 0x0401A5A1 RID: 107937
		public HashSet<int> CacheReachOpenTimeLevels = new HashSet<int>();

		// Token: 0x0401A5A2 RID: 107938
		public bool IsChangeCacheLevels;
	}
}

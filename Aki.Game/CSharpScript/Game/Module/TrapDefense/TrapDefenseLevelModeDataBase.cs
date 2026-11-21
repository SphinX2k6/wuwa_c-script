using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039D4 RID: 14804
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class TrapDefenseLevelModeDataBase : ITrapDefenseLevelModeData<TrapDefenseLevelModeDataBase>
	{
		// Token: 0x17004DDE RID: 19934
		// (get) Token: 0x06026259 RID: 156249 RVA: 0x00AB3620 File Offset: 0x00AB1820
		// (set) Token: 0x0602625A RID: 156250 RVA: 0x00AB3628 File Offset: 0x00AB1828
		public int ActivityId { get; set; }

		// Token: 0x0602625B RID: 156251
		protected abstract void Init();

		// Token: 0x0602625C RID: 156252 RVA: 0x00AB3631 File Offset: 0x00AB1831
		public static T Create<[Nullable(0)] T>(int activityId) where T : TrapDefenseLevelModeDataBase, new()
		{
			T t = Activator.CreateInstance<T>();
			t.ActivityId = activityId;
			t.Init();
			t.InitLocalData();
			return t;
		}

		// Token: 0x0602625D RID: 156253 RVA: 0x00AB365A File Offset: 0x00AB185A
		public virtual void InitLocalData()
		{
			ServerStorageUtil.OverrideLocalSetToServerSet(ELocalStoragePlayerKey.TrapDefenseLevelReachOpenTime, EClientStorageSystemIdType.TrapDefenseLevelReachOpenTime, true);
		}

		// Token: 0x0602625E RID: 156254 RVA: 0x00AB366A File Offset: 0x00AB186A
		public void SaveCacheReachOpenTimeLevels()
		{
		}

		// Token: 0x0602625F RID: 156255 RVA: 0x00AB366C File Offset: 0x00AB186C
		public TrapDefenseLevelData AddLevelConfig(TrapDefenseActivity config)
		{
			TrapDefenseLevelData trapDefenseLevelData = TrapDefenseLevelData.Create(config);
			this.LevelDataList.Add(trapDefenseLevelData);
			return trapDefenseLevelData;
		}

		// Token: 0x06026260 RID: 156256 RVA: 0x00AB3690 File Offset: 0x00AB1890
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

		// Token: 0x06026261 RID: 156257 RVA: 0x00AB36F1 File Offset: 0x00AB18F1
		[NullableContext(0)]
		public ValueTuple<int, int> GetModeStarProgress()
		{
			return new ValueTuple<int, int>(this.GetModeAllGetStarNum(), this.GetModeTotalStar());
		}

		// Token: 0x06026262 RID: 156258 RVA: 0x00AB3704 File Offset: 0x00AB1904
		public int GetModeAllGetStarNum()
		{
			int num = 0;
			foreach (TrapDefenseLevelData trapDefenseLevelData in this.LevelDataList)
			{
				num += trapDefenseLevelData.ReachTargetIndexList.Count;
			}
			return num;
		}

		// Token: 0x06026263 RID: 156259 RVA: 0x00AB3764 File Offset: 0x00AB1964
		public int GetModeTotalStar()
		{
			int num = 0;
			foreach (TrapDefenseLevelData trapDefenseLevelData in this.LevelDataList)
			{
				num += trapDefenseLevelData.Config.StarRatingConditionsLength;
			}
			return num;
		}

		// Token: 0x06026264 RID: 156260 RVA: 0x00AB37C4 File Offset: 0x00AB19C4
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

		// Token: 0x06026265 RID: 156261 RVA: 0x00AB3848 File Offset: 0x00AB1A48
		public bool RedDotLevelReachOpenTime()
		{
			ServerStorageSet serverStorageSet = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.TrapDefenseLevelReachOpenTime) as ServerStorageSet;
			foreach (TrapDefenseLevelData trapDefenseLevelData in this.LevelDataList)
			{
				if (!serverStorageSet.Has(trapDefenseLevelData.Id) && trapDefenseLevelData.IsReachOpenTimeIgnoreZero())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06026266 RID: 156262 RVA: 0x00AB38C4 File Offset: 0x00AB1AC4
		public bool CheckLevelReachOpenTimeRedDotState(TrapDefenseLevelData data)
		{
			if (!this.GetLevelReachOpenTimeRedDotState(data))
			{
				return false;
			}
			(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.TrapDefenseLevelReachOpenTime) as ServerStorageSet).Add(data.Id);
			EventSystem.Instance.Emit<int>(this.GetLevelReachOpenTimeRedDotEventName(), data.Id);
			ActivityTrapDefenseController instance = ActivityTrapDefenseController.Instance;
			if (instance != null)
			{
				instance.RefreshActivityRedDot();
			}
			return true;
		}

		// Token: 0x06026267 RID: 156263 RVA: 0x00AB3920 File Offset: 0x00AB1B20
		public bool GetLevelReachOpenTimeRedDotState(TrapDefenseLevelData data)
		{
			return !(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.TrapDefenseLevelReachOpenTime) as ServerStorageSet).Has(data.Id) && data.IsReachOpenTimeIgnoreZero();
		}

		// Token: 0x06026268 RID: 156264 RVA: 0x00AB3948 File Offset: 0x00AB1B48
		protected virtual EEventName GetLevelReachOpenTimeRedDotEventName()
		{
			return EEventName.RedDotUpdateTrapDefenseLevelModeLevelReachOpenTime;
		}

		// Token: 0x04014EF7 RID: 85751
		public readonly List<TrapDefenseLevelData> LevelDataList = new List<TrapDefenseLevelData>();
	}
}

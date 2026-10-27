using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A30 RID: 18992
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseRougeModeData : TrapDefenseLevelModeDataBase, ITrapDefenseLevelModeData<TrapDefenseRougeModeData>
	{
		// Token: 0x060314FB RID: 201979 RVA: 0x00B70594 File Offset: 0x00B6E794
		protected override void Init()
		{
			this.InitBdData();
		}

		// Token: 0x060314FC RID: 201980 RVA: 0x00B7059C File Offset: 0x00B6E79C
		private void InitBdData()
		{
			foreach (TrapDefenseBd config in TrapDefenseConfig.Instance.GetAllBdList())
			{
				TrapDefenseBdData trapDefenseBdData = TrapDefenseBdData.Create(config);
				this.BdDataList.Add(trapDefenseBdData);
				this.BdDataMap.Add(trapDefenseBdData.Id, trapDefenseBdData);
				foreach (TrapDefenseBdBuffData trapDefenseBdBuffData in trapDefenseBdData.BdBuffDataList)
				{
					this.BdBuffDataMap.Add(trapDefenseBdBuffData.Id, trapDefenseBdBuffData);
					this.BdBuffDataList.Add(trapDefenseBdBuffData);
				}
				if (!trapDefenseBdData.IsZeroBdType())
				{
					this.BdDataListIgnoreZero.Add(trapDefenseBdData);
				}
			}
			this.BdDataList.Sort((TrapDefenseBdData a, TrapDefenseBdData b) => a.Id - b.Id);
			this.BdDataListIgnoreZero.Sort((TrapDefenseBdData a, TrapDefenseBdData b) => a.Id - b.Id);
		}

		// Token: 0x060314FD RID: 201981 RVA: 0x00B706D0 File Offset: 0x00B6E8D0
		public override void InitLocalData()
		{
			base.InitLocalData();
			bool player = LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.TrapDefenseRougeModeOpen, false);
			bool player2 = LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.TrapDefenseRougeModeOpen, true);
			this.CacheIsOpenMode = ((player == player2) ? new bool?(player) : null);
			this.CacheUnlockBdBuffs = (LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.TrapDefenseBdBuffUnlock, null) ?? new HashSet<int>());
		}

		// Token: 0x060314FE RID: 201982 RVA: 0x00B70730 File Offset: 0x00B6E930
		public void SaveCacheUnlockBdBuffs()
		{
			if (this.IsChangeCacheBdBuffs)
			{
				LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.TrapDefenseBdBuffUnlock, this.CacheUnlockBdBuffs);
				this.IsChangeCacheBdBuffs = false;
			}
		}

		// Token: 0x060314FF RID: 201983 RVA: 0x00B70754 File Offset: 0x00B6E954
		public List<TrapDefenseBdData> GetBdDataListIsActive()
		{
			List<TrapDefenseBdData> list = new List<TrapDefenseBdData>();
			foreach (TrapDefenseBdData trapDefenseBdData in this.BdDataList)
			{
				if (trapDefenseBdData.IsActive())
				{
					list.Add(trapDefenseBdData);
				}
			}
			return list;
		}

		// Token: 0x06031500 RID: 201984 RVA: 0x00B707B8 File Offset: 0x00B6E9B8
		public void SetLastGetBdBuffData(TrapDefenseBdBuffData buff)
		{
			this.LastGetBdBuffData = buff;
		}

		// Token: 0x06031501 RID: 201985 RVA: 0x00B707C1 File Offset: 0x00B6E9C1
		public void SetIsCheckBdProgress(bool isCheck)
		{
			this.IsCheckBdProgress = isCheck;
		}

		// Token: 0x06031502 RID: 201986 RVA: 0x00B707CC File Offset: 0x00B6E9CC
		public int GetEndlessPassedMaxWaveTimes()
		{
			int num = 0;
			foreach (TrapDefenseLevelData trapDefenseLevelData in this.LevelDataList)
			{
				if (trapDefenseLevelData.IsEndless && trapDefenseLevelData.MaxFinishWaveTimes > num)
				{
					num = trapDefenseLevelData.MaxFinishWaveTimes;
				}
			}
			return num;
		}

		// Token: 0x06031503 RID: 201987 RVA: 0x00B70834 File Offset: 0x00B6EA34
		public double GetUnlockTime()
		{
			double num = double.PositiveInfinity;
			foreach (TrapDefenseLevelData trapDefenseLevelData in this.LevelDataList)
			{
				num = Math.Min(num, trapDefenseLevelData.UnlockTime);
			}
			return num;
		}

		// Token: 0x06031504 RID: 201988 RVA: 0x00B70898 File Offset: 0x00B6EA98
		public double GetUnlockRemainTime()
		{
			double unlockTime = this.GetUnlockTime();
			if (unlockTime == 0.0)
			{
				return 0.0;
			}
			double serverTime = TimeUtil.Instance.GetServerTime();
			return Math.Max(0.0, unlockTime - serverTime);
		}

		// Token: 0x06031505 RID: 201989 RVA: 0x00B708E0 File Offset: 0x00B6EAE0
		public bool CanEnterRougeMode()
		{
			if (!this.ModeIsOpen())
			{
				return false;
			}
			using (List<TrapDefenseLevelData>.Enumerator enumerator = this.LevelDataList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsUnlockCondition)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06031506 RID: 201990 RVA: 0x00B70944 File Offset: 0x00B6EB44
		public bool ModeIsOpen()
		{
			using (List<TrapDefenseLevelData>.Enumerator enumerator = this.LevelDataList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsReachOpenTime())
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06031507 RID: 201991 RVA: 0x00B709A0 File Offset: 0x00B6EBA0
		public bool RedDotModeOpen()
		{
			if (this.CacheIsOpenMode != null)
			{
				return this.CacheIsOpenMode.Value;
			}
			if (this.ModeIsOpen())
			{
				LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.TrapDefenseRougeModeOpen, true);
				LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.TrapDefenseRougeModeOpenSub, true);
				this.CacheIsOpenMode = new bool?(true);
				return true;
			}
			return false;
		}

		// Token: 0x06031508 RID: 201992 RVA: 0x00B709F8 File Offset: 0x00B6EBF8
		public bool CheckModeOpenRedDotState()
		{
			if (!this.CacheIsOpenMode.GetValueOrDefault())
			{
				return false;
			}
			this.CacheIsOpenMode = new bool?(false);
			LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.TrapDefenseRougeModeOpen, false);
			EventSystem.Instance.Emit(EEventName.RedDotUpdateTrapDefenseRougeModeOpen);
			ActivityTrapDefenseController instance = ActivityTrapDefenseController.Instance;
			if (instance != null)
			{
				instance.RefreshActivityRedDot();
			}
			return true;
		}

		// Token: 0x06031509 RID: 201993 RVA: 0x00B70A4D File Offset: 0x00B6EC4D
		protected override EEventName GetLevelReachOpenTimeRedDotEventName()
		{
			return EEventName.RedDotUpdateTrapDefenseRougeModeLevelReachOpenTime;
		}

		// Token: 0x0603150A RID: 201994 RVA: 0x00B70A54 File Offset: 0x00B6EC54
		public bool RedDotNewUnlockBdBuff()
		{
			foreach (TrapDefenseBdBuffData trapDefenseBdBuffData in this.BdBuffDataList)
			{
				if (trapDefenseBdBuffData.IsUnlock && !this.CacheUnlockBdBuffs.Contains(trapDefenseBdBuffData.Id))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603150B RID: 201995 RVA: 0x00B70AC4 File Offset: 0x00B6ECC4
		public bool CheckBdBuffUnlockRedDotState(TrapDefenseBdBuffData data)
		{
			if (!this.GetBdBuffNewTagState(data))
			{
				return false;
			}
			this.IsChangeCacheBdBuffs = true;
			this.CacheUnlockBdBuffs.Add(data.Id);
			EventSystem.Instance.Emit(EEventName.RedDotUpdateTrapDefenseBdBuffNewUnlock);
			ActivityTrapDefenseController instance = ActivityTrapDefenseController.Instance;
			if (instance != null)
			{
				instance.RefreshActivityRedDot();
			}
			return true;
		}

		// Token: 0x0603150C RID: 201996 RVA: 0x00B70B16 File Offset: 0x00B6ED16
		public bool GetBdBuffNewTagState(TrapDefenseBdBuffData data)
		{
			return data.IsUnlock && !TrapDefenseModel.Instance.ViewModelBdSum.IsInstance && !this.CacheUnlockBdBuffs.Contains(data.Id);
		}

		// Token: 0x0603150D RID: 201997 RVA: 0x00B70B49 File Offset: 0x00B6ED49
		public bool IsShowRougeModeTipsToActivity()
		{
			return this.CacheIsOpenMode.GetValueOrDefault() && LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.TrapDefenseRougeModeOpenSub, false);
		}

		// Token: 0x0603150E RID: 201998 RVA: 0x00B70B68 File Offset: 0x00B6ED68
		public bool CheckModeOpenSubState()
		{
			if (!this.CacheIsOpenMode.GetValueOrDefault())
			{
				return false;
			}
			LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.TrapDefenseRougeModeOpenSub, false);
			int activityId = TrapDefenseModel.Instance.GetActivityId();
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityId);
			return true;
		}

		// Token: 0x0603150F RID: 201999 RVA: 0x00B70BB0 File Offset: 0x00B6EDB0
		public int GetUnlockBdBuffSum()
		{
			int num = 0;
			using (List<TrapDefenseBdBuffData>.Enumerator enumerator = this.BdBuffDataList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsUnlock)
					{
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x06031510 RID: 202000 RVA: 0x00B70C0C File Offset: 0x00B6EE0C
		public void CheckBdBuffGetUpdate(int id, int lv)
		{
			TrapDefenseBdBuffData trapDefenseBdBuffData;
			if (!this.BdBuffDataMap.TryGetValue(id, out trapDefenseBdBuffData))
			{
				return;
			}
			trapDefenseBdBuffData.SetActive(true);
			trapDefenseBdBuffData.SetLevel(lv);
			if (trapDefenseBdBuffData.IsStrengthenFinish())
			{
				TrapDefenseModel instance = TrapDefenseModel.Instance;
				if (instance == null)
				{
					return;
				}
				instance.OpenViewBdBuffStrengthen(id, true);
				return;
			}
			else
			{
				TrapDefenseModel instance2 = TrapDefenseModel.Instance;
				if (instance2 == null)
				{
					return;
				}
				instance2.OpenViewBdBuffNewGet(id, true);
				return;
			}
		}

		// Token: 0x0401A5B5 RID: 107957
		public List<TrapDefenseBdData> BdDataList = new List<TrapDefenseBdData>();

		// Token: 0x0401A5B6 RID: 107958
		public List<TrapDefenseBdData> BdDataListIgnoreZero = new List<TrapDefenseBdData>();

		// Token: 0x0401A5B7 RID: 107959
		public Dictionary<int, TrapDefenseBdData> BdDataMap = new Dictionary<int, TrapDefenseBdData>();

		// Token: 0x0401A5B8 RID: 107960
		public Dictionary<int, TrapDefenseBdBuffData> BdBuffDataMap = new Dictionary<int, TrapDefenseBdBuffData>();

		// Token: 0x0401A5B9 RID: 107961
		public List<TrapDefenseBdBuffData> BdBuffDataList = new List<TrapDefenseBdBuffData>();

		// Token: 0x0401A5BA RID: 107962
		[Nullable(2)]
		public TrapDefenseBdBuffData LastGetBdBuffData;

		// Token: 0x0401A5BB RID: 107963
		public bool IsCheckBdProgress;

		// Token: 0x0401A5BC RID: 107964
		public bool? CacheIsOpenMode;

		// Token: 0x0401A5BD RID: 107965
		public HashSet<int> CacheUnlockBdBuffs = new HashSet<int>();

		// Token: 0x0401A5BE RID: 107966
		public bool IsChangeCacheBdBuffs;
	}
}

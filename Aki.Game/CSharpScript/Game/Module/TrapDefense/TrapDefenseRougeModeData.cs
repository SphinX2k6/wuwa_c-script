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
	// Token: 0x020039D8 RID: 14808
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseRougeModeData : TrapDefenseLevelModeDataBase, ITrapDefenseLevelModeData<TrapDefenseRougeModeData>
	{
		// Token: 0x0602628B RID: 156299 RVA: 0x00AB44E4 File Offset: 0x00AB26E4
		protected override void Init()
		{
			this.InitBdData();
		}

		// Token: 0x0602628C RID: 156300 RVA: 0x00AB44EC File Offset: 0x00AB26EC
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

		// Token: 0x0602628D RID: 156301 RVA: 0x00AB4620 File Offset: 0x00AB2820
		public override void InitLocalData()
		{
			base.InitLocalData();
			ServerStorageUtil.OverrideLocalBooleanToServerBoolean(ELocalStoragePlayerKey.TrapDefenseRougeModeOpen, EClientStorageSystemIdType.TrapDefenseRougeModeOpen, true);
			ServerStorageUtil.OverrideLocalBooleanToServerBoolean(ELocalStoragePlayerKey.TrapDefenseRougeModeOpenSub, EClientStorageSystemIdType.TrapDefenseRougeModeOpenSub, true);
			ServerStorageUtil.OverrideLocalSetToServerSet(ELocalStoragePlayerKey.TrapDefenseBdBuffUnlock, EClientStorageSystemIdType.TrapDefenseBdBuffUnlock, true);
		}

		// Token: 0x0602628E RID: 156302 RVA: 0x00AB4652 File Offset: 0x00AB2852
		public void SaveCacheUnlockBdBuffs()
		{
		}

		// Token: 0x0602628F RID: 156303 RVA: 0x00AB4654 File Offset: 0x00AB2854
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

		// Token: 0x06026290 RID: 156304 RVA: 0x00AB46B8 File Offset: 0x00AB28B8
		public void SetLastGetBdBuffData(TrapDefenseBdBuffData buff)
		{
			this.LastGetBdBuffData = buff;
		}

		// Token: 0x06026291 RID: 156305 RVA: 0x00AB46C1 File Offset: 0x00AB28C1
		public void SetIsCheckBdProgress(bool isCheck)
		{
			this.IsCheckBdProgress = isCheck;
		}

		// Token: 0x06026292 RID: 156306 RVA: 0x00AB46CC File Offset: 0x00AB28CC
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

		// Token: 0x06026293 RID: 156307 RVA: 0x00AB4734 File Offset: 0x00AB2934
		public double GetUnlockTime()
		{
			double num = double.PositiveInfinity;
			foreach (TrapDefenseLevelData trapDefenseLevelData in this.LevelDataList)
			{
				num = Math.Min(num, trapDefenseLevelData.UnlockTime);
			}
			return num;
		}

		// Token: 0x06026294 RID: 156308 RVA: 0x00AB4798 File Offset: 0x00AB2998
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

		// Token: 0x06026295 RID: 156309 RVA: 0x00AB47E0 File Offset: 0x00AB29E0
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

		// Token: 0x06026296 RID: 156310 RVA: 0x00AB4844 File Offset: 0x00AB2A44
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

		// Token: 0x06026297 RID: 156311 RVA: 0x00AB48A0 File Offset: 0x00AB2AA0
		public bool RedDotModeOpen()
		{
			ServerStorageBoolean serverStorageBoolean = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.TrapDefenseRougeModeOpen) as ServerStorageBoolean;
			bool? flag = serverStorageBoolean.Get();
			if (flag != null)
			{
				return flag.Value;
			}
			if (this.ModeIsOpen())
			{
				serverStorageBoolean.Set(new bool?(true));
				(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.TrapDefenseRougeModeOpenSub) as ServerStorageBoolean).Set(new bool?(true));
				return true;
			}
			return false;
		}

		// Token: 0x06026298 RID: 156312 RVA: 0x00AB490C File Offset: 0x00AB2B0C
		public bool CheckModeOpenRedDotState()
		{
			ServerStorageBoolean serverStorageBoolean = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.TrapDefenseRougeModeOpen) as ServerStorageBoolean;
			if (!serverStorageBoolean.Get().GetValueOrDefault())
			{
				return false;
			}
			serverStorageBoolean.Set(new bool?(false));
			EventSystem.Instance.Emit(EEventName.RedDotUpdateTrapDefenseRougeModeOpen);
			ActivityTrapDefenseController instance = ActivityTrapDefenseController.Instance;
			if (instance != null)
			{
				instance.RefreshActivityRedDot();
			}
			return true;
		}

		// Token: 0x06026299 RID: 156313 RVA: 0x00AB496A File Offset: 0x00AB2B6A
		protected override EEventName GetLevelReachOpenTimeRedDotEventName()
		{
			return EEventName.RedDotUpdateTrapDefenseRougeModeLevelReachOpenTime;
		}

		// Token: 0x0602629A RID: 156314 RVA: 0x00AB4974 File Offset: 0x00AB2B74
		public bool RedDotNewUnlockBdBuff()
		{
			ServerStorageSet serverStorageSet = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.TrapDefenseBdBuffUnlock) as ServerStorageSet;
			foreach (TrapDefenseBdBuffData trapDefenseBdBuffData in this.BdBuffDataList)
			{
				if (trapDefenseBdBuffData.IsUnlock && !serverStorageSet.Has(trapDefenseBdBuffData.Id))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602629B RID: 156315 RVA: 0x00AB49F0 File Offset: 0x00AB2BF0
		public bool CheckBdBuffUnlockRedDotState(TrapDefenseBdBuffData data)
		{
			if (!this.GetBdBuffNewTagState(data))
			{
				return false;
			}
			(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.TrapDefenseBdBuffUnlock) as ServerStorageSet).Add(data.Id);
			EventSystem.Instance.Emit(EEventName.RedDotUpdateTrapDefenseBdBuffNewUnlock);
			ActivityTrapDefenseController instance = ActivityTrapDefenseController.Instance;
			if (instance != null)
			{
				instance.RefreshActivityRedDot();
			}
			return true;
		}

		// Token: 0x0602629C RID: 156316 RVA: 0x00AB4A45 File Offset: 0x00AB2C45
		public bool GetBdBuffNewTagState(TrapDefenseBdBuffData data)
		{
			return data.IsUnlock && !TrapDefenseModel.Instance.ViewModelBdSum.IsInstance && !(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.TrapDefenseBdBuffUnlock) as ServerStorageSet).Has(data.Id);
		}

		// Token: 0x0602629D RID: 156317 RVA: 0x00AB4A84 File Offset: 0x00AB2C84
		public bool IsShowRougeModeTipsToActivity()
		{
			return (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.TrapDefenseRougeModeOpen) as ServerStorageBoolean).Get().GetValueOrDefault() && (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.TrapDefenseRougeModeOpenSub) as ServerStorageBoolean).Get().GetValueOrDefault();
		}

		// Token: 0x0602629E RID: 156318 RVA: 0x00AB4AD4 File Offset: 0x00AB2CD4
		public bool CheckModeOpenSubState()
		{
			if (!(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.TrapDefenseRougeModeOpen) as ServerStorageBoolean).Get().GetValueOrDefault())
			{
				return false;
			}
			(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.TrapDefenseRougeModeOpenSub) as ServerStorageBoolean).Set(new bool?(false));
			int activityId = TrapDefenseModel.Instance.GetActivityId();
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityId);
			return true;
		}

		// Token: 0x0602629F RID: 156319 RVA: 0x00AB4B3C File Offset: 0x00AB2D3C
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

		// Token: 0x060262A0 RID: 156320 RVA: 0x00AB4B98 File Offset: 0x00AB2D98
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

		// Token: 0x04014F0A RID: 85770
		public List<TrapDefenseBdData> BdDataList = new List<TrapDefenseBdData>();

		// Token: 0x04014F0B RID: 85771
		public List<TrapDefenseBdData> BdDataListIgnoreZero = new List<TrapDefenseBdData>();

		// Token: 0x04014F0C RID: 85772
		public Dictionary<int, TrapDefenseBdData> BdDataMap = new Dictionary<int, TrapDefenseBdData>();

		// Token: 0x04014F0D RID: 85773
		public Dictionary<int, TrapDefenseBdBuffData> BdBuffDataMap = new Dictionary<int, TrapDefenseBdBuffData>();

		// Token: 0x04014F0E RID: 85774
		public List<TrapDefenseBdBuffData> BdBuffDataList = new List<TrapDefenseBdBuffData>();

		// Token: 0x04014F0F RID: 85775
		[Nullable(2)]
		public TrapDefenseBdBuffData LastGetBdBuffData;

		// Token: 0x04014F10 RID: 85776
		public bool IsCheckBdProgress;
	}
}

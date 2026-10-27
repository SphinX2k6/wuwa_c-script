using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Anniversary
{
	// Token: 0x02006913 RID: 26899
	[NullableContext(1)]
	[Nullable(0)]
	public class AnniversaryActivityData : ActivityBaseData
	{
		// Token: 0x06043143 RID: 274755 RVA: 0x01057C40 File Offset: 0x01055E40
		protected override void PhraseEx(ActivityData data)
		{
			if (data != null && data.ThemeCelebration != null)
			{
				this.PersonalRewardIds = new List<int>();
				foreach (int item in data.ThemeCelebration.PersonalRewardIds)
				{
					this.PersonalRewardIds.Add(item);
				}
				this.WorldRewardIds = new List<int>();
				foreach (int item2 in data.ThemeCelebration.WorldRewardIds)
				{
					this.WorldRewardIds.Add(item2);
				}
			}
			this.InitSubActivityData();
			RepeatedField<SubActivityBeginTime> repeatedField;
			if (data == null)
			{
				repeatedField = null;
			}
			else
			{
				ThemeCelebration themeCelebration = data.ThemeCelebration;
				repeatedField = ((themeCelebration != null) ? themeCelebration.SubActivityTimes : null);
			}
			RepeatedField<SubActivityBeginTime> repeatedField2 = repeatedField;
			List<SubActivityBeginTime> list = new List<SubActivityBeginTime>();
			if (repeatedField2 != null)
			{
				foreach (SubActivityBeginTime item3 in repeatedField2)
				{
					list.Add(item3);
				}
			}
			this.InitSubActivityUnlockTimeMap(list);
			TimerSystem.Instance.Delay(delegate(float _)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
			}, 20f, null, null, true, 1f);
		}

		// Token: 0x06043144 RID: 274756 RVA: 0x01057D98 File Offset: 0x01055F98
		private void InitSubActivityUnlockTimeMap(IReadOnlyList<SubActivityBeginTime> times)
		{
			if (times == null || times.Count == 0)
			{
				return;
			}
			foreach (SubActivityBeginTime subActivityBeginTime in times)
			{
				EAnniversarySubId id = (EAnniversarySubId)subActivityBeginTime.Id;
				AnniversarySubActivityDataBase targetSubActivityData = this.GetTargetSubActivityData(id);
				if (targetSubActivityData != null)
				{
					long unlockTime = MathUtils.Instance.LongToBigInt(subActivityBeginTime.BeginTime);
					targetSubActivityData.SetUnlockTime(unlockTime);
				}
			}
		}

		// Token: 0x06043145 RID: 274757 RVA: 0x01057E14 File Offset: 0x01056014
		private void InitSubActivityData()
		{
			this.SubActivityDataMap.Clear();
			IReadOnlyList<AnniversaryEntrance> anniversaryEntranceAll = AnniversaryActivityConfig.Instance.GetAnniversaryEntranceAll();
			if (anniversaryEntranceAll == null)
			{
				return;
			}
			foreach (AnniversaryEntrance anniversaryEntrance in anniversaryEntranceAll)
			{
				EAnniversarySubId id = (EAnniversarySubId)anniversaryEntrance.Id;
				AnniversarySubActivityDataBase anniversarySubActivityDataBase = null;
				switch (id)
				{
				case EAnniversarySubId.AnniversaryGift:
					anniversarySubActivityDataBase = new AnniversarySubActivityAnniversaryGift((int)id);
					break;
				case EAnniversarySubId.Pinball:
					anniversarySubActivityDataBase = new AnniversarySubActivityPinball((int)id);
					break;
				case EAnniversarySubId.WuWuPack:
					anniversarySubActivityDataBase = new AnniversarySubActivityWuWuPack((int)id);
					break;
				case EAnniversarySubId.DangoRun:
					anniversarySubActivityDataBase = new AnniversarySubActivityDangoRun((int)id);
					break;
				}
				if (anniversarySubActivityDataBase != null)
				{
					this.SubActivityDataMap[id] = anniversarySubActivityDataBase;
				}
			}
			this.RebuildRelativeActivityIds();
		}

		// Token: 0x06043146 RID: 274758 RVA: 0x01057ED4 File Offset: 0x010560D4
		[NullableContext(2)]
		public AnniversarySubActivityDataBase GetTargetSubActivityData(EAnniversarySubId id)
		{
			AnniversarySubActivityDataBase result;
			if (this.SubActivityDataMap.TryGetValue(id, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x06043147 RID: 274759 RVA: 0x01057EF4 File Offset: 0x010560F4
		private void RebuildRelativeActivityIds()
		{
			this.RelativeActivityIds.Clear();
			foreach (AnniversarySubActivityDataBase anniversarySubActivityDataBase in this.SubActivityDataMap.Values)
			{
				int activityId = anniversarySubActivityDataBase.GetActivityId();
				if (activityId > 0)
				{
					this.RelativeActivityIds.Add(activityId);
				}
			}
			IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("AnniversaryRedDotRelativeActivityList");
			if (intArrayConfig != null)
			{
				foreach (int num in intArrayConfig)
				{
					if (num > 0)
					{
						this.RelativeActivityIds.Add(num);
					}
				}
			}
		}

		// Token: 0x06043148 RID: 274760 RVA: 0x01057FB8 File Offset: 0x010561B8
		public bool IsRelativeActivityId(int activityId)
		{
			return this.RelativeActivityIds.Contains(activityId);
		}

		// Token: 0x06043149 RID: 274761 RVA: 0x01057FC8 File Offset: 0x010561C8
		public void UpdatePersonalRewardIds(List<int> rewardIds)
		{
			foreach (int item in rewardIds)
			{
				if (!this.PersonalRewardIds.Contains(item))
				{
					this.PersonalRewardIds.Add(item);
				}
			}
		}

		// Token: 0x0604314A RID: 274762 RVA: 0x0105802C File Offset: 0x0105622C
		public void UpdateWorldRewardIds(List<int> rewardIds)
		{
			foreach (int item in rewardIds)
			{
				if (!this.WorldRewardIds.Contains(item))
				{
					this.WorldRewardIds.Add(item);
				}
			}
		}

		// Token: 0x0604314B RID: 274763 RVA: 0x01058090 File Offset: 0x01056290
		public List<int> GetWorldRewardIds()
		{
			return this.WorldRewardIds;
		}

		// Token: 0x0604314C RID: 274764 RVA: 0x01058098 File Offset: 0x01056298
		public List<int> GetPersonalRewardIds()
		{
			return this.PersonalRewardIds;
		}

		// Token: 0x0604314D RID: 274765 RVA: 0x010580A0 File Offset: 0x010562A0
		public int GetPersonalCurProgress()
		{
			return InventoryModel.Instance.GetItemCountByConfigId(74, 0);
		}

		// Token: 0x0604314E RID: 274766 RVA: 0x010580B0 File Offset: 0x010562B0
		public bool NeedPlayWorldProgressNumberTweenToday()
		{
			int num = (int)(TimeUtil.Instance.GetCurrentCrossDayStamp() / (double)TimeUtil.Instance.InverseMillisecond);
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 10, 0, 0) != num;
		}

		// Token: 0x0604314F RID: 274767 RVA: 0x010580F0 File Offset: 0x010562F0
		public void MarkWorldProgressNumberTweenPlayedToday()
		{
			int value = (int)(TimeUtil.Instance.GetCurrentCrossDayStamp() / (double)TimeUtil.Instance.InverseMillisecond);
			ActivityModel.Instance.SaveActivityData(base.Id, 10, 0, 0, value);
		}

		// Token: 0x06043150 RID: 274768 RVA: 0x0105812C File Offset: 0x0105632C
		public int GetWorldCurProgressIdForActivityDay(int realValidDay)
		{
			IReadOnlyList<WorldProgressCurve> worldProgressCurveAll = AnniversaryActivityConfig.Instance.GetWorldProgressCurveAll();
			if (worldProgressCurveAll == null || worldProgressCurveAll.Count == 0)
			{
				return 0;
			}
			int personalCurProgress = this.GetPersonalCurProgress();
			int result = 0;
			for (int i = worldProgressCurveAll.Count - 1; i >= 0; i--)
			{
				WorldProgressCurve worldProgressCurve = worldProgressCurveAll[i];
				if (worldProgressCurve.OpenDay <= realValidDay && personalCurProgress >= worldProgressCurve.PersonalScore)
				{
					result = worldProgressCurve.Id;
					break;
				}
			}
			return result;
		}

		// Token: 0x06043151 RID: 274769 RVA: 0x01058198 File Offset: 0x01056398
		public int GetWorldCurProgressId()
		{
			long beginOpenTime = base.BeginOpenTime;
			if (beginOpenTime <= 0L)
			{
				return 0;
			}
			double serverTime = TimeUtil.Instance.GetServerTime();
			if (serverTime <= (double)beginOpenTime)
			{
				return 0;
			}
			int realValidDay = (int)Math.Floor((serverTime - (double)beginOpenTime) / (double)TimeUtil.Instance.OneDaySeconds);
			return this.GetWorldCurProgressIdForActivityDay(realValidDay);
		}

		// Token: 0x06043152 RID: 274770 RVA: 0x010581E4 File Offset: 0x010563E4
		public bool IsPreviousProgressFull()
		{
			long beginOpenTime = base.BeginOpenTime;
			if (beginOpenTime <= 0L)
			{
				return false;
			}
			double serverTime = TimeUtil.Instance.GetServerTime();
			if (serverTime <= (double)beginOpenTime)
			{
				return false;
			}
			IReadOnlyList<WorldProgressCurve> worldProgressCurveAll = AnniversaryActivityConfig.Instance.GetWorldProgressCurveAll();
			if (worldProgressCurveAll == null || worldProgressCurveAll.Count == 0)
			{
				return false;
			}
			int num = 0;
			foreach (WorldProgressCurve worldProgressCurve in worldProgressCurveAll)
			{
				if (worldProgressCurve.Percent > num)
				{
					num = worldProgressCurve.Percent;
				}
			}
			int num2 = (int)Math.Floor((serverTime - (double)beginOpenTime) / (double)TimeUtil.Instance.OneDaySeconds) - 1;
			if (num2 < 0)
			{
				return false;
			}
			int worldCurProgressIdForActivityDay = this.GetWorldCurProgressIdForActivityDay(num2);
			WorldProgressCurve? worldProgressCurveById = AnniversaryActivityConfig.Instance.GetWorldProgressCurveById(worldCurProgressIdForActivityDay);
			return ((worldProgressCurveById != null) ? worldProgressCurveById.Value.Percent : 0) >= num;
		}

		// Token: 0x06043153 RID: 274771 RVA: 0x010582D4 File Offset: 0x010564D4
		public bool IsCurrentProgressFull()
		{
			IReadOnlyList<WorldProgressCurve> worldProgressCurveAll = AnniversaryActivityConfig.Instance.GetWorldProgressCurveAll();
			if (worldProgressCurveAll == null || worldProgressCurveAll.Count == 0)
			{
				return false;
			}
			int num = 0;
			foreach (WorldProgressCurve worldProgressCurve in worldProgressCurveAll)
			{
				if (worldProgressCurve.Percent > num)
				{
					num = worldProgressCurve.Percent;
				}
			}
			int worldCurProgressId = this.GetWorldCurProgressId();
			WorldProgressCurve? worldProgressCurveById = AnniversaryActivityConfig.Instance.GetWorldProgressCurveById(worldCurProgressId);
			return ((worldProgressCurveById != null) ? worldProgressCurveById.Value.Percent : 0) >= num;
		}

		// Token: 0x06043154 RID: 274772 RVA: 0x0105837C File Offset: 0x0105657C
		[NullableContext(2)]
		public List<int> GetWorldCanReceiveRewardIds()
		{
			IReadOnlyList<WorldProgressCurve> worldProgressCurveHadReward = AnniversaryActivityConfig.Instance.GetWorldProgressCurveHadReward();
			List<int> list = new List<int>();
			int worldCurProgressId = this.GetWorldCurProgressId();
			if (worldProgressCurveHadReward != null)
			{
				foreach (WorldProgressCurve worldProgressCurve in worldProgressCurveHadReward)
				{
					if (worldCurProgressId >= worldProgressCurve.Id && !this.WorldRewardIds.Contains(worldProgressCurve.Id))
					{
						list.Add(worldProgressCurve.Id);
					}
				}
			}
			return list;
		}

		// Token: 0x06043155 RID: 274773 RVA: 0x01058408 File Offset: 0x01056608
		[NullableContext(2)]
		public List<int> GetPersonalCanReceiveRewardIds()
		{
			IReadOnlyList<PersonProgressCurve> personProgressCurveAll = AnniversaryActivityConfig.Instance.GetPersonProgressCurveAll();
			List<int> list = new List<int>();
			if (personProgressCurveAll != null)
			{
				foreach (PersonProgressCurve personProgressCurve in personProgressCurveAll)
				{
					if (this.TargetPersonalCanReceive(personProgressCurve.Id))
					{
						list.Add(personProgressCurve.Id);
					}
				}
			}
			return list;
		}

		// Token: 0x06043156 RID: 274774 RVA: 0x0105847C File Offset: 0x0105667C
		public bool TargetPersonalCanReceive(int cfgId)
		{
			PersonProgressCurve? personProgressCurveById = AnniversaryActivityConfig.Instance.GetPersonProgressCurveById(cfgId);
			if (personProgressCurveById == null)
			{
				return false;
			}
			int personalCurProgress = this.GetPersonalCurProgress();
			return personProgressCurveById.Value.DropId > 0 && personalCurProgress >= personProgressCurveById.Value.Progress && !this.PersonalRewardIds.Contains(personProgressCurveById.Value.Id);
		}

		// Token: 0x06043157 RID: 274775 RVA: 0x010584EC File Offset: 0x010566EC
		public override bool GetExDataRedPointShowState()
		{
			IReadOnlyList<WorldProgressCurve> worldProgressCurveHadReward = AnniversaryActivityConfig.Instance.GetWorldProgressCurveHadReward();
			int worldCurProgressId = this.GetWorldCurProgressId();
			if (worldProgressCurveHadReward != null)
			{
				foreach (WorldProgressCurve worldProgressCurve in worldProgressCurveHadReward)
				{
					if (worldCurProgressId >= worldProgressCurve.Id && !this.WorldRewardIds.Contains(worldProgressCurve.Id))
					{
						return true;
					}
				}
			}
			IReadOnlyList<PersonProgressCurve> personProgressCurveAll = AnniversaryActivityConfig.Instance.GetPersonProgressCurveAll();
			if (personProgressCurveAll != null)
			{
				foreach (PersonProgressCurve personProgressCurve in personProgressCurveAll)
				{
					if (this.TargetPersonalCanReceive(personProgressCurve.Id))
					{
						return true;
					}
				}
			}
			foreach (int id in this.RelativeActivityIds)
			{
				ActivityBaseData activityById = ActivityModel.Instance.GetActivityById(id);
				if (activityById != null && activityById.RedPointShowState)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06043158 RID: 274776 RVA: 0x01058628 File Offset: 0x01056828
		protected override bool GetExDataFinishShowState()
		{
			if (this.SubActivityDataMap.Count == 0)
			{
				return false;
			}
			using (Dictionary<EAnniversarySubId, AnniversarySubActivityDataBase>.ValueCollection.Enumerator enumerator = this.SubActivityDataMap.Values.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					ActivityBaseData activityData = enumerator.Current.GetActivityData();
					if (activityData != null && !activityData.FinishSinkState)
					{
						return false;
					}
					return true;
				}
			}
			return true;
		}

		// Token: 0x04022E98 RID: 143000
		private readonly Dictionary<EAnniversarySubId, AnniversarySubActivityDataBase> SubActivityDataMap = new Dictionary<EAnniversarySubId, AnniversarySubActivityDataBase>();

		// Token: 0x04022E99 RID: 143001
		private List<int> PersonalRewardIds = new List<int>();

		// Token: 0x04022E9A RID: 143002
		private List<int> WorldRewardIds = new List<int>();

		// Token: 0x04022E9B RID: 143003
		private readonly HashSet<int> RelativeActivityIds = new HashSet<int>();
	}
}

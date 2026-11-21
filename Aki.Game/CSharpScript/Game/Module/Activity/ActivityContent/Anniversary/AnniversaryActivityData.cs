using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Anniversary
{
	// Token: 0x02005863 RID: 22627
	[NullableContext(1)]
	[Nullable(0)]
	public class AnniversaryActivityData : ActivityBaseData
	{
		// Token: 0x06037C9B RID: 228507 RVA: 0x00F9926C File Offset: 0x00F9746C
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

		// Token: 0x06037C9C RID: 228508 RVA: 0x00F993C4 File Offset: 0x00F975C4
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

		// Token: 0x06037C9D RID: 228509 RVA: 0x00F99440 File Offset: 0x00F97640
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

		// Token: 0x06037C9E RID: 228510 RVA: 0x00F99500 File Offset: 0x00F97700
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

		// Token: 0x06037C9F RID: 228511 RVA: 0x00F99520 File Offset: 0x00F97720
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

		// Token: 0x06037CA0 RID: 228512 RVA: 0x00F995E4 File Offset: 0x00F977E4
		public bool IsRelativeActivityId(int activityId)
		{
			return this.RelativeActivityIds.Contains(activityId);
		}

		// Token: 0x06037CA1 RID: 228513 RVA: 0x00F995F4 File Offset: 0x00F977F4
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

		// Token: 0x06037CA2 RID: 228514 RVA: 0x00F99658 File Offset: 0x00F97858
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

		// Token: 0x06037CA3 RID: 228515 RVA: 0x00F996BC File Offset: 0x00F978BC
		public List<int> GetWorldRewardIds()
		{
			return this.WorldRewardIds;
		}

		// Token: 0x06037CA4 RID: 228516 RVA: 0x00F996C4 File Offset: 0x00F978C4
		public List<int> GetPersonalRewardIds()
		{
			return this.PersonalRewardIds;
		}

		// Token: 0x06037CA5 RID: 228517 RVA: 0x00F996CC File Offset: 0x00F978CC
		public int GetPersonalCurProgress()
		{
			return InventoryModel.Instance.GetItemCountByConfigId(74, 0);
		}

		// Token: 0x06037CA6 RID: 228518 RVA: 0x00F996DC File Offset: 0x00F978DC
		public bool NeedPlayWorldProgressNumberTweenToday()
		{
			int num = (int)(TimeUtil.Instance.GetCurrentCrossDayStamp() / (double)TimeUtil.Instance.InverseMillisecond);
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 10, 0, 0) != num;
		}

		// Token: 0x06037CA7 RID: 228519 RVA: 0x00F9971C File Offset: 0x00F9791C
		public void MarkWorldProgressNumberTweenPlayedToday()
		{
			int value = (int)(TimeUtil.Instance.GetCurrentCrossDayStamp() / (double)TimeUtil.Instance.InverseMillisecond);
			ActivityModel.Instance.SaveActivityData(base.Id, 10, 0, 0, value);
		}

		// Token: 0x06037CA8 RID: 228520 RVA: 0x00F99758 File Offset: 0x00F97958
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

		// Token: 0x06037CA9 RID: 228521 RVA: 0x00F997C4 File Offset: 0x00F979C4
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

		// Token: 0x06037CAA RID: 228522 RVA: 0x00F99810 File Offset: 0x00F97A10
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

		// Token: 0x06037CAB RID: 228523 RVA: 0x00F99900 File Offset: 0x00F97B00
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

		// Token: 0x06037CAC RID: 228524 RVA: 0x00F999A8 File Offset: 0x00F97BA8
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

		// Token: 0x06037CAD RID: 228525 RVA: 0x00F99A34 File Offset: 0x00F97C34
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

		// Token: 0x06037CAE RID: 228526 RVA: 0x00F99AA8 File Offset: 0x00F97CA8
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

		// Token: 0x06037CAF RID: 228527 RVA: 0x00F99B18 File Offset: 0x00F97D18
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

		// Token: 0x06037CB0 RID: 228528 RVA: 0x00F99C54 File Offset: 0x00F97E54
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

		// Token: 0x0401D6F4 RID: 120564
		private readonly Dictionary<EAnniversarySubId, AnniversarySubActivityDataBase> SubActivityDataMap = new Dictionary<EAnniversarySubId, AnniversarySubActivityDataBase>();

		// Token: 0x0401D6F5 RID: 120565
		private List<int> PersonalRewardIds = new List<int>();

		// Token: 0x0401D6F6 RID: 120566
		private List<int> WorldRewardIds = new List<int>();

		// Token: 0x0401D6F7 RID: 120567
		private readonly HashSet<int> RelativeActivityIds = new HashSet<int>();
	}
}

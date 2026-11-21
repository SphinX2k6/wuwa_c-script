using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x020048D7 RID: 18647
	[NullableContext(1)]
	[Nullable(0)]
	public class InfrastructureActivityData : ActivityBaseData
	{
		// Token: 0x0602EC6E RID: 191598 RVA: 0x00D0B6D8 File Offset: 0x00D098D8
		protected override void OnInit(ActivityData data)
		{
			InfrThemeActivityPb infrThemeActivityPb = data.InfrThemeActivityPb;
			if (infrThemeActivityPb == null)
			{
				Log.Instance.Error(ELogModule.Infrastructure, ELogAuthor.LYX, "InfrastructureActivityData初始化 无效activityInfo", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.UpdateActivityAllTaskData(infrThemeActivityPb.ActivityTaskData);
		}

		// Token: 0x0602EC6F RID: 191599 RVA: 0x00D0B71C File Offset: 0x00D0991C
		protected override void PhraseEx(ActivityData data)
		{
			InfrThemeActivityPb infrThemeActivityPb = data.InfrThemeActivityPb;
			if (infrThemeActivityPb == null)
			{
				Log.Instance.Error(ELogModule.Infrastructure, ELogAuthor.LYX, "InfrastructureActivityDataPhrase 无效activityInfo", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.UpdateActivityAllTaskData(infrThemeActivityPb.ActivityTaskData);
		}

		// Token: 0x0602EC70 RID: 191600 RVA: 0x00D0B75F File Offset: 0x00D0995F
		public override bool GetExDataRedPointShowState()
		{
			return this.CheckRedDot();
		}

		// Token: 0x0602EC71 RID: 191601 RVA: 0x00D0B767 File Offset: 0x00D09967
		public bool CheckRedDot()
		{
			return base.IsUnLock() && (this.GetLimitedTaskReadDot() || this.GetShopHasNewRedDot() || InfrastructureModel.Instance.GetArchiveRedDot());
		}

		// Token: 0x0602EC72 RID: 191602 RVA: 0x00D0B790 File Offset: 0x00D09990
		public bool GetLimitedTaskReadDot()
		{
			using (Dictionary<int, InfrastructureLimitTaskData>.ValueCollection.Enumerator enumerator = this.ActivityTaskDataMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Status == ActivityTaskState.ActivityTaskFinish)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0602EC73 RID: 191603 RVA: 0x00D0B7F0 File Offset: 0x00D099F0
		public bool GetShopHasNewRedDot()
		{
			InfrastructureModel instance = InfrastructureModel.Instance;
			int infrRecordObservatoryLevel = instance.GetInfrRecordObservatoryLevel();
			return instance.FireLevel > infrRecordObservatoryLevel;
		}

		// Token: 0x0602EC74 RID: 191604 RVA: 0x00D0B814 File Offset: 0x00D09A14
		public bool GetQuestRedDot()
		{
			int currentQuestId = InfrastructureModel.Instance.GetCurrentQuestId();
			return currentQuestId != 0 && QuestNewModel.Instance.CheckQuestRedDotDataState(currentQuestId).GetValueOrDefault();
		}

		// Token: 0x0602EC75 RID: 191605 RVA: 0x00D0B844 File Offset: 0x00D09A44
		public CommonDefine.ICountDown GetActivityCountDownData()
		{
			double num = (base.EndOpenTime > 0L) ? ((double)base.EndOpenTime - TimeUtil.Instance.GetServerTime()) : 0.0;
			if (num <= 1.0)
			{
				num = 1.0;
			}
			CommonDefine.ETimeType value = (num >= 86400.0) ? CommonDefine.ETimeType.Day : ((num >= 3600.0) ? CommonDefine.ETimeType.Hour : CommonDefine.ETimeType.Minute);
			CommonDefine.ETimeType value2 = (num >= 86400.0) ? CommonDefine.ETimeType.Hour : ((num >= 3600.0) ? CommonDefine.ETimeType.Minute : CommonDefine.ETimeType.Second);
			return TimeUtil.Instance.GetCountDownDataFormat2(num, new CommonDefine.ETimeType?(value), new CommonDefine.ETimeType?(value2));
		}

		// Token: 0x0602EC76 RID: 191606 RVA: 0x00D0B8E8 File Offset: 0x00D09AE8
		[NullableContext(2)]
		private void UpdateActivityAllTaskData(Aki.Protocol.ActivityTaskData data)
		{
			this.ActivityTaskDataMap.Clear();
			foreach (ActivityTask activityTask in (((data != null) ? data.ActivityTasks : null) ?? new RepeatedField<ActivityTask>()))
			{
				InfrastructureLimitTaskData infrastructureLimitTaskData = new InfrastructureLimitTaskData(activityTask.Id);
				infrastructureLimitTaskData.UpdateData(activityTask);
				this.ActivityTaskDataMap[activityTask.Id] = infrastructureLimitTaskData;
			}
			EventSystem.Instance.Emit(EEventName.InfrastructureActivityTaskDataUpdate);
		}

		// Token: 0x0602EC77 RID: 191607 RVA: 0x00D0B980 File Offset: 0x00D09B80
		public void UpdateActivityTaskData(ActivityTask data)
		{
			InfrastructureLimitTaskData infrastructureLimitTaskData;
			if (this.ActivityTaskDataMap.TryGetValue(data.Id, out infrastructureLimitTaskData))
			{
				infrastructureLimitTaskData.UpdateData(data);
				EventSystem.Instance.Emit(EEventName.InfrastructureActivityTaskDataUpdate);
			}
		}

		// Token: 0x0602EC78 RID: 191608 RVA: 0x00D0B9BC File Offset: 0x00D09BBC
		public List<InfrastructureLimitTaskData> GetActivityTaskDataList()
		{
			List<InfrastructureLimitTaskData> list = new List<InfrastructureLimitTaskData>(this.ActivityTaskDataMap.Values);
			list.Sort(delegate(InfrastructureLimitTaskData a, InfrastructureLimitTaskData b)
			{
				if (a.Status != b.Status)
				{
					return this.GetStatusPriority(a.Status) - this.GetStatusPriority(b.Status);
				}
				return a.ConfigId - b.ConfigId;
			});
			for (int i = 0; i < list.Count; i++)
			{
				list[i].Index = i + 1;
			}
			return list;
		}

		// Token: 0x0602EC79 RID: 191609 RVA: 0x00D0BA0D File Offset: 0x00D09C0D
		private int GetStatusPriority(ActivityTaskState status)
		{
			switch (status)
			{
			case ActivityTaskState.ActivityTaskRunning:
				return 2;
			case ActivityTaskState.ActivityTaskFinish:
				return 1;
			case ActivityTaskState.ActivityTaskTaken:
				return 3;
			default:
				return 0;
			}
		}

		// Token: 0x0602EC7A RID: 191610 RVA: 0x00D0BA2C File Offset: 0x00D09C2C
		[NullableContext(2)]
		public InfrastructureLimitTaskData GetActivityTaskDataById(int taskId)
		{
			InfrastructureLimitTaskData result;
			this.ActivityTaskDataMap.TryGetValue(taskId, out result);
			return result;
		}

		// Token: 0x0602EC7B RID: 191611 RVA: 0x00D0BA4C File Offset: 0x00D09C4C
		public List<InfrastructureLimitTaskData> GetActivityTaskDataListByStatus(ActivityTaskState status)
		{
			List<InfrastructureLimitTaskData> list = new List<InfrastructureLimitTaskData>();
			foreach (InfrastructureLimitTaskData infrastructureLimitTaskData in this.ActivityTaskDataMap.Values)
			{
				if (infrastructureLimitTaskData.Status == status)
				{
					list.Add(infrastructureLimitTaskData);
				}
			}
			return list;
		}

		// Token: 0x0602EC7C RID: 191612 RVA: 0x00D0BAB4 File Offset: 0x00D09CB4
		protected override bool GetExDataFinishShowState()
		{
			using (Dictionary<int, InfrastructureLimitTaskData>.ValueCollection.Enumerator enumerator = this.ActivityTaskDataMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Status != ActivityTaskState.ActivityTaskTaken)
					{
						return false;
					}
				}
			}
			InfrastructureModel instance = InfrastructureModel.Instance;
			using (List<InfrastructureDefine.IInfrLibraryTaskData>.Enumerator enumerator2 = instance.GetLibraryTaskData().GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					if (enumerator2.Current.Status != InfrTaskStatusPb.InfrTaskTaken)
					{
						return false;
					}
				}
			}
			using (List<InfrastructureDefine.IInfrLibraryTaskData>.Enumerator enumerator2 = instance.GetPhoneTaskData().GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					if (enumerator2.Current.Status != InfrTaskStatusPb.InfrTaskTaken)
					{
						return false;
					}
				}
			}
			return (long)instance.GetAllShopCurrencyNum() == instance.MoneyHistorySpent;
		}

		// Token: 0x04018D77 RID: 101751
		private readonly Dictionary<int, InfrastructureLimitTaskData> ActivityTaskDataMap = new Dictionary<int, InfrastructureLimitTaskData>();
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x020058FE RID: 22782
	[NullableContext(1)]
	[Nullable(0)]
	public class InfrastructureActivityData : ActivityBaseData
	{
		// Token: 0x06039D48 RID: 236872 RVA: 0x00DBC70C File Offset: 0x00DBA90C
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

		// Token: 0x06039D49 RID: 236873 RVA: 0x00DBC750 File Offset: 0x00DBA950
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

		// Token: 0x06039D4A RID: 236874 RVA: 0x00DBC793 File Offset: 0x00DBA993
		public override bool GetExDataRedPointShowState()
		{
			return this.CheckRedDot();
		}

		// Token: 0x06039D4B RID: 236875 RVA: 0x00DBC79B File Offset: 0x00DBA99B
		public bool CheckRedDot()
		{
			return base.IsUnLock() && (this.GetLimitedTaskReadDot() || this.GetShopHasNewRedDot() || InfrastructureModel.Instance.GetArchiveRedDot());
		}

		// Token: 0x06039D4C RID: 236876 RVA: 0x00DBC7C4 File Offset: 0x00DBA9C4
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

		// Token: 0x06039D4D RID: 236877 RVA: 0x00DBC824 File Offset: 0x00DBAA24
		public bool GetShopHasNewRedDot()
		{
			InfrastructureModel instance = InfrastructureModel.Instance;
			int infrRecordObservatoryLevel = instance.GetInfrRecordObservatoryLevel();
			return instance.FireLevel > infrRecordObservatoryLevel;
		}

		// Token: 0x06039D4E RID: 236878 RVA: 0x00DBC848 File Offset: 0x00DBAA48
		public bool GetQuestRedDot()
		{
			int currentQuestId = InfrastructureModel.Instance.GetCurrentQuestId();
			return currentQuestId != 0 && QuestNewModel.Instance.CheckQuestRedDotDataState(currentQuestId).GetValueOrDefault();
		}

		// Token: 0x06039D4F RID: 236879 RVA: 0x00DBC878 File Offset: 0x00DBAA78
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

		// Token: 0x06039D50 RID: 236880 RVA: 0x00DBC91C File Offset: 0x00DBAB1C
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

		// Token: 0x06039D51 RID: 236881 RVA: 0x00DBC9B4 File Offset: 0x00DBABB4
		public void UpdateActivityTaskData(ActivityTask data)
		{
			InfrastructureLimitTaskData infrastructureLimitTaskData;
			if (this.ActivityTaskDataMap.TryGetValue(data.Id, out infrastructureLimitTaskData))
			{
				infrastructureLimitTaskData.UpdateData(data);
				EventSystem.Instance.Emit(EEventName.InfrastructureActivityTaskDataUpdate);
			}
		}

		// Token: 0x06039D52 RID: 236882 RVA: 0x00DBC9F0 File Offset: 0x00DBABF0
		public List<InfrastructureLimitTaskData> GetActivityTaskDataList()
		{
			List<InfrastructureLimitTaskData> list = this.ActivityTaskDataMap.Values.ToList<InfrastructureLimitTaskData>();
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

		// Token: 0x06039D53 RID: 236883 RVA: 0x00DBCA41 File Offset: 0x00DBAC41
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

		// Token: 0x06039D54 RID: 236884 RVA: 0x00DBCA60 File Offset: 0x00DBAC60
		[NullableContext(2)]
		public InfrastructureLimitTaskData GetActivityTaskDataById(int taskId)
		{
			InfrastructureLimitTaskData result;
			this.ActivityTaskDataMap.TryGetValue(taskId, out result);
			return result;
		}

		// Token: 0x06039D55 RID: 236885 RVA: 0x00DBCA80 File Offset: 0x00DBAC80
		public List<InfrastructureLimitTaskData> GetActivityTaskDataListByStatus(ActivityTaskState status)
		{
			return (from taskData in this.ActivityTaskDataMap.Values
			where taskData.Status == status
			select taskData).ToList<InfrastructureLimitTaskData>();
		}

		// Token: 0x06039D56 RID: 236886 RVA: 0x00DBCABC File Offset: 0x00DBACBC
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

		// Token: 0x0401E2DA RID: 123610
		private readonly Dictionary<int, InfrastructureLimitTaskData> ActivityTaskDataMap = new Dictionary<int, InfrastructureLimitTaskData>();
	}
}

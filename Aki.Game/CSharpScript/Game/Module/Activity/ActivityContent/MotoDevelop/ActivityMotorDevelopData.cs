using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotoDevelop
{
	// Token: 0x02006458 RID: 25688
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityMotorDevelopData : ActivityBaseData
	{
		// Token: 0x060408FC RID: 264444 RVA: 0x00FA04A8 File Offset: 0x00F9E6A8
		protected override void PhraseEx(ActivityData data)
		{
			MotorDevelopActivityData motorDevelopActivityData = data.MotorDevelopActivityData;
			RepeatedField<ConditionTask> repeatedField = (motorDevelopActivityData != null) ? motorDevelopActivityData.Task : null;
			if (repeatedField == null)
			{
				return;
			}
			this.InitMotorDevelopTask(repeatedField);
		}

		// Token: 0x060408FD RID: 264445 RVA: 0x00FA04D4 File Offset: 0x00F9E6D4
		public void InitMotorDevelopTask(IReadOnlyList<ConditionTask> tasks)
		{
			this.TaskMap.Clear();
			foreach (ConditionTask conditionTask in tasks)
			{
				this.TaskMap[conditionTask.Id] = conditionTask;
			}
		}

		// Token: 0x060408FE RID: 264446 RVA: 0x00FA0534 File Offset: 0x00F9E734
		public void UpdateMotorDevelopTask(IReadOnlyList<ConditionTask> tasks)
		{
			foreach (ConditionTask conditionTask in tasks)
			{
				this.TaskMap[conditionTask.Id] = conditionTask;
			}
		}

		// Token: 0x060408FF RID: 264447 RVA: 0x00FA0588 File Offset: 0x00F9E788
		public List<ConditionTask> GetMotorDevelopTaskList()
		{
			return new List<ConditionTask>(this.TaskMap.Values);
		}

		// Token: 0x06040900 RID: 264448 RVA: 0x00FA059A File Offset: 0x00F9E79A
		public void SetActivityFirstUnlockUnReadFlag(int flagId)
		{
			ActivityModel instance = ActivityModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.SaveActivityData(base.Id, 2, 0, 0, flagId);
		}

		// Token: 0x06040901 RID: 264449 RVA: 0x00FA05B5 File Offset: 0x00F9E7B5
		public void CheckAndCloseFirstUnlockReadFlag()
		{
			if (base.IsUnLock())
			{
				this.SetActivityFirstUnlockUnReadFlag(0);
			}
		}

		// Token: 0x06040902 RID: 264450 RVA: 0x00FA05C8 File Offset: 0x00F9E7C8
		public override bool GetExDataRedPointShowState()
		{
			ActivityModel instance = ActivityModel.Instance;
			int? num = (instance != null) ? new int?(instance.GetActivityCacheData(base.Id, 0, 1, 0, 0)) : null;
			if (num != null)
			{
				int? num2 = num;
				int num3 = 0;
				if (!(num2.GetValueOrDefault() == num3 & num2 != null))
				{
					return true;
				}
			}
			ActivityModel instance2 = ActivityModel.Instance;
			int? num4 = (instance2 != null) ? new int?(instance2.GetActivityCacheData(base.Id, 0, 2, 0, 0)) : null;
			if (num4 != null)
			{
				int? num2 = num4;
				int num3 = 0;
				if (!(num2.GetValueOrDefault() == num3 & num2 != null))
				{
					return true;
				}
			}
			using (List<ConditionTask>.Enumerator enumerator = new List<ConditionTask>(this.TaskMap.Values).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Status == ConditionTaskState.ConditionTaskFinish)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06040903 RID: 264451 RVA: 0x00FA06C8 File Offset: 0x00F9E8C8
		protected override bool GetExDataFinishShowState()
		{
			using (List<ConditionTask>.Enumerator enumerator = new List<ConditionTask>(this.TaskMap.Values).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Status != ConditionTaskState.ConditionTaskTaken)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x04021929 RID: 137513
		private const int FIRSTOPEN = 1;

		// Token: 0x0402192A RID: 137514
		private const int FIRSTUNLOCK = 2;

		// Token: 0x0402192B RID: 137515
		private readonly Dictionary<int, ConditionTask> TaskMap = new Dictionary<int, ConditionTask>();
	}
}

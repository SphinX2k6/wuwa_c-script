using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotoDevelop
{
	// Token: 0x020053D6 RID: 21462
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityMotorDevelopData : ActivityBaseData
	{
		// Token: 0x060355BD RID: 218557 RVA: 0x00EE7424 File Offset: 0x00EE5624
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

		// Token: 0x060355BE RID: 218558 RVA: 0x00EE7450 File Offset: 0x00EE5650
		public void InitMotorDevelopTask(IReadOnlyList<ConditionTask> tasks)
		{
			this.TaskMap.Clear();
			foreach (ConditionTask conditionTask in tasks)
			{
				this.TaskMap[conditionTask.Id] = conditionTask;
			}
		}

		// Token: 0x060355BF RID: 218559 RVA: 0x00EE74B0 File Offset: 0x00EE56B0
		public void UpdateMotorDevelopTask(IReadOnlyList<ConditionTask> tasks)
		{
			foreach (ConditionTask conditionTask in tasks)
			{
				this.TaskMap[conditionTask.Id] = conditionTask;
			}
		}

		// Token: 0x060355C0 RID: 218560 RVA: 0x00EE7504 File Offset: 0x00EE5704
		public List<ConditionTask> GetMotorDevelopTaskList()
		{
			return new List<ConditionTask>(this.TaskMap.Values);
		}

		// Token: 0x060355C1 RID: 218561 RVA: 0x00EE7516 File Offset: 0x00EE5716
		public void SetActivityFirstUnlockUnReadFlag(int flagId)
		{
			ActivityModel instance = ActivityModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.SaveActivityData(base.Id, 2, 0, 0, flagId);
		}

		// Token: 0x060355C2 RID: 218562 RVA: 0x00EE7531 File Offset: 0x00EE5731
		public void CheckAndCloseFirstUnlockReadFlag()
		{
			if (base.IsUnLock())
			{
				this.SetActivityFirstUnlockUnReadFlag(0);
			}
		}

		// Token: 0x060355C3 RID: 218563 RVA: 0x00EE7544 File Offset: 0x00EE5744
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

		// Token: 0x060355C4 RID: 218564 RVA: 0x00EE7644 File Offset: 0x00EE5844
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

		// Token: 0x0401C258 RID: 115288
		private const int FIRSTOPEN = 1;

		// Token: 0x0401C259 RID: 115289
		private const int FIRSTUNLOCK = 2;

		// Token: 0x0401C25A RID: 115290
		private readonly Dictionary<int, ConditionTask> TaskMap = new Dictionary<int, ConditionTask>();
	}
}

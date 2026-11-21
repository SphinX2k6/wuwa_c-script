using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200505E RID: 20574
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeQuestData
	{
		// Token: 0x060337EB RID: 210923 RVA: 0x00E6BB8B File Offset: 0x00E69D8B
		public void Reset()
		{
			this.ActivityId = 0;
			this.TaskById.Clear();
		}

		// Token: 0x060337EC RID: 210924 RVA: 0x00E6BB9F File Offset: 0x00E69D9F
		public void PhraseEx(int activityId, RoverRogueActivityData roverData)
		{
			this.ActivityId = activityId;
			this.TaskById.Clear();
			this.UpdateTasks(roverData.ConditionTasks);
		}

		// Token: 0x060337ED RID: 210925 RVA: 0x00E6BBC0 File Offset: 0x00E69DC0
		public void UpdateTasks(IReadOnlyList<ConditionTask> tasks)
		{
			foreach (ConditionTask conditionTask in tasks)
			{
				this.TaskById[conditionTask.Id] = conditionTask;
			}
		}

		// Token: 0x060337EE RID: 210926 RVA: 0x00E6BC14 File Offset: 0x00E69E14
		[NullableContext(2)]
		public ConditionTask GetTask(int taskId)
		{
			ConditionTask result;
			if (!this.TaskById.TryGetValue(taskId, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060337EF RID: 210927 RVA: 0x00E6BC34 File Offset: 0x00E69E34
		public List<int> GetAllTakeableTaskIds()
		{
			List<int> list = new List<int>();
			foreach (ConditionTask conditionTask in this.TaskById.Values)
			{
				if (conditionTask.Status == ConditionTaskState.ConditionTaskFinish)
				{
					list.Add(conditionTask.Id);
				}
			}
			return list;
		}

		// Token: 0x060337F0 RID: 210928 RVA: 0x00E6BCA4 File Offset: 0x00E69EA4
		public void MarkTaken(int taskId)
		{
			ConditionTask conditionTask;
			if (this.TaskById.TryGetValue(taskId, out conditionTask))
			{
				conditionTask.Status = ConditionTaskState.ConditionTaskTaken;
			}
		}

		// Token: 0x060337F1 RID: 210929 RVA: 0x00E6BCC8 File Offset: 0x00E69EC8
		public List<int> GetSortedTaskIdList()
		{
			List<int> list = new List<int>(this.TaskById.Keys);
			list.Sort(delegate(int a, int b)
			{
				int statusSortWeight = this.GetStatusSortWeight(a);
				int statusSortWeight2 = this.GetStatusSortWeight(b);
				if (statusSortWeight != statusSortWeight2)
				{
					return statusSortWeight - statusSortWeight2;
				}
				return a - b;
			});
			return list;
		}

		// Token: 0x060337F2 RID: 210930 RVA: 0x00E6BCEC File Offset: 0x00E69EEC
		public int GetTakenCount()
		{
			int num = 0;
			using (Dictionary<int, ConditionTask>.ValueCollection.Enumerator enumerator = this.TaskById.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Status == ConditionTaskState.ConditionTaskTaken)
					{
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x060337F3 RID: 210931 RVA: 0x00E6BD4C File Offset: 0x00E69F4C
		public int GetTotalCount()
		{
			return this.TaskById.Count;
		}

		// Token: 0x060337F4 RID: 210932 RVA: 0x00E6BD5C File Offset: 0x00E69F5C
		public bool IsAllTaken()
		{
			if (this.TaskById.Count <= 0)
			{
				return false;
			}
			using (Dictionary<int, ConditionTask>.ValueCollection.Enumerator enumerator = this.TaskById.Values.GetEnumerator())
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

		// Token: 0x060337F5 RID: 210933 RVA: 0x00E6BDCC File Offset: 0x00E69FCC
		public bool HasRedDot()
		{
			using (Dictionary<int, ConditionTask>.ValueCollection.Enumerator enumerator = this.TaskById.Values.GetEnumerator())
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

		// Token: 0x060337F6 RID: 210934 RVA: 0x00E6BE2C File Offset: 0x00E6A02C
		private int GetStatusSortWeight(int taskId)
		{
			ConditionTask conditionTask;
			ConditionTaskState? conditionTaskState = this.TaskById.TryGetValue(taskId, out conditionTask) ? new ConditionTaskState?(conditionTask.Status) : null;
			if (conditionTaskState.GetValueOrDefault() == ConditionTaskState.ConditionTaskFinish)
			{
				return 0;
			}
			if (conditionTaskState.GetValueOrDefault() == ConditionTaskState.ConditionTaskTaken)
			{
				return 2;
			}
			return 1;
		}

		// Token: 0x0401B59C RID: 112028
		public int ActivityId;

		// Token: 0x0401B59D RID: 112029
		private readonly Dictionary<int, ConditionTask> TaskById = new Dictionary<int, ConditionTask>();
	}
}

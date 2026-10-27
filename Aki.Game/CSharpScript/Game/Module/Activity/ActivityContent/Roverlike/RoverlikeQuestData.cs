using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020060E0 RID: 24800
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeQuestData
	{
		// Token: 0x0603EB29 RID: 256809 RVA: 0x00F24D33 File Offset: 0x00F22F33
		public void Reset()
		{
			this.ActivityId = 0;
			this.TaskById.Clear();
		}

		// Token: 0x0603EB2A RID: 256810 RVA: 0x00F24D47 File Offset: 0x00F22F47
		public void PhraseEx(int activityId, RoverRogueActivityData roverData)
		{
			this.ActivityId = activityId;
			this.TaskById.Clear();
			this.UpdateTasks(roverData.ConditionTasks);
		}

		// Token: 0x0603EB2B RID: 256811 RVA: 0x00F24D68 File Offset: 0x00F22F68
		public void UpdateTasks(IReadOnlyList<ConditionTask> tasks)
		{
			foreach (ConditionTask conditionTask in tasks)
			{
				this.TaskById[conditionTask.Id] = conditionTask;
			}
		}

		// Token: 0x0603EB2C RID: 256812 RVA: 0x00F24DBC File Offset: 0x00F22FBC
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

		// Token: 0x0603EB2D RID: 256813 RVA: 0x00F24DDC File Offset: 0x00F22FDC
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

		// Token: 0x0603EB2E RID: 256814 RVA: 0x00F24E4C File Offset: 0x00F2304C
		public void MarkTaken(int taskId)
		{
			ConditionTask conditionTask;
			if (this.TaskById.TryGetValue(taskId, out conditionTask))
			{
				conditionTask.Status = ConditionTaskState.ConditionTaskTaken;
			}
		}

		// Token: 0x0603EB2F RID: 256815 RVA: 0x00F24E70 File Offset: 0x00F23070
		public List<int> GetSortedTaskIdList()
		{
			List<int> list = this.TaskById.Keys.ToList<int>();
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

		// Token: 0x0603EB30 RID: 256816 RVA: 0x00F24E94 File Offset: 0x00F23094
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

		// Token: 0x0603EB31 RID: 256817 RVA: 0x00F24EF4 File Offset: 0x00F230F4
		public int GetTotalCount()
		{
			return this.TaskById.Count;
		}

		// Token: 0x0603EB32 RID: 256818 RVA: 0x00F24F04 File Offset: 0x00F23104
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

		// Token: 0x0603EB33 RID: 256819 RVA: 0x00F24F74 File Offset: 0x00F23174
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

		// Token: 0x0603EB34 RID: 256820 RVA: 0x00F24FD4 File Offset: 0x00F231D4
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

		// Token: 0x04020C6F RID: 134255
		public int ActivityId;

		// Token: 0x04020C70 RID: 134256
		private readonly Dictionary<int, ConditionTask> TaskById = new Dictionary<int, ConditionTask>();
	}
}

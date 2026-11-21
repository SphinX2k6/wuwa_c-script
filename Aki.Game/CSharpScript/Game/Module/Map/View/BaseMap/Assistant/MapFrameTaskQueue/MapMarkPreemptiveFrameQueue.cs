using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Misc.PreemptiveFrameQueue;

namespace CSharpScript.Game.Module.Map.View.BaseMap.Assistant.MapFrameTaskQueue
{
	// Token: 0x02004489 RID: 17545
	[NullableContext(1)]
	[Nullable(0)]
	public class MapMarkPreemptiveFrameQueue : SimplePreemptiveFrameQueue
	{
		// Token: 0x0602C535 RID: 181557 RVA: 0x00C770F7 File Offset: 0x00C752F7
		public MapMarkPreemptiveFrameQueue(int perFrameTaskLimit, int executeFrameInterval = 0) : base(perFrameTaskLimit, executeFrameInterval)
		{
		}

		// Token: 0x0602C536 RID: 181558 RVA: 0x00C7710C File Offset: 0x00C7530C
		public override void AddTask(IPreemptiveFrameTask task)
		{
			base.AddTask(task);
			IMapMarkPreemptiveFrameTask mapMarkPreemptiveFrameTask = (IMapMarkPreemptiveFrameTask)task;
			Dictionary<int, IMapMarkPreemptiveFrameTask> dictionary;
			if (!this.MarkTaskMap.TryGetValue(mapMarkPreemptiveFrameTask.MarkType, out dictionary))
			{
				dictionary = new Dictionary<int, IMapMarkPreemptiveFrameTask>();
				this.MarkTaskMap[mapMarkPreemptiveFrameTask.MarkType] = dictionary;
			}
			dictionary[mapMarkPreemptiveFrameTask.MarkId] = mapMarkPreemptiveFrameTask;
		}

		// Token: 0x0602C537 RID: 181559 RVA: 0x00C77164 File Offset: 0x00C75364
		public void ForceExecuteTask(EMarkType markType, int markId)
		{
			IMapMarkPreemptiveFrameTask task = this.GetTask(markType, markId);
			if (task != null)
			{
				task.Execute();
				this.CancelMapTask(markType, markId);
			}
		}

		// Token: 0x0602C538 RID: 181560 RVA: 0x00C77190 File Offset: 0x00C75390
		public void Flush()
		{
			this.EnableFlush = true;
			base.Process();
			this.EnableFlush = false;
		}

		// Token: 0x0602C539 RID: 181561 RVA: 0x00C771A8 File Offset: 0x00C753A8
		public void CancelMapTask(EMarkType markType, int markId)
		{
			IMapMarkPreemptiveFrameTask task = this.GetTask(markType, markId);
			if (task != null)
			{
				base.CancelTask(task);
				this.RemoveTaskCache(task);
			}
		}

		// Token: 0x0602C53A RID: 181562 RVA: 0x00C771D0 File Offset: 0x00C753D0
		private void RemoveTaskCache(IMapMarkPreemptiveFrameTask task)
		{
			Dictionary<int, IMapMarkPreemptiveFrameTask> dictionary;
			if (this.MarkTaskMap.TryGetValue(task.MarkType, out dictionary))
			{
				dictionary.Remove(task.MarkId);
			}
		}

		// Token: 0x0602C53B RID: 181563 RVA: 0x00C771FF File Offset: 0x00C753FF
		public bool HasTask(EMarkType markType, int markId)
		{
			return this.GetTask(markType, markId) != null;
		}

		// Token: 0x0602C53C RID: 181564 RVA: 0x00C7720C File Offset: 0x00C7540C
		[NullableContext(2)]
		private IMapMarkPreemptiveFrameTask GetTask(EMarkType markType, int markId)
		{
			if (markType == EMarkType.None)
			{
				using (Dictionary<EMarkType, Dictionary<int, IMapMarkPreemptiveFrameTask>>.ValueCollection.Enumerator enumerator = this.MarkTaskMap.Values.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						IMapMarkPreemptiveFrameTask result;
						if (enumerator.Current.TryGetValue(markId, out result))
						{
							return result;
						}
					}
				}
				return null;
			}
			Dictionary<int, IMapMarkPreemptiveFrameTask> dictionary;
			if (this.MarkTaskMap.TryGetValue(markType, out dictionary))
			{
				IMapMarkPreemptiveFrameTask result2;
				dictionary.TryGetValue(markId, out result2);
				return result2;
			}
			return null;
		}

		// Token: 0x0602C53D RID: 181565 RVA: 0x00C77290 File Offset: 0x00C75490
		public void CancelMapTaskByType(EMarkType markType)
		{
			Dictionary<int, IMapMarkPreemptiveFrameTask> dictionary;
			if (this.MarkTaskMap.TryGetValue(markType, out dictionary))
			{
				foreach (IMapMarkPreemptiveFrameTask task in dictionary.Values)
				{
					base.CancelTask(task);
					this.RemoveTaskCache(task);
				}
			}
		}

		// Token: 0x0602C53E RID: 181566 RVA: 0x00C772FC File Offset: 0x00C754FC
		protected override void OnTaskComplete(IPreemptiveFrameTask task)
		{
			base.OnTaskComplete(task);
			IMapMarkPreemptiveFrameTask mapMarkPreemptiveFrameTask = (IMapMarkPreemptiveFrameTask)task;
			this.RemoveTaskCache(mapMarkPreemptiveFrameTask);
			EventSystem.Instance.Emit<EMarkType, int>(EEventName.OnMapMarkTaskComplete, mapMarkPreemptiveFrameTask.MarkType, mapMarkPreemptiveFrameTask.MarkId);
		}

		// Token: 0x04017D50 RID: 97616
		private readonly Dictionary<EMarkType, Dictionary<int, IMapMarkPreemptiveFrameTask>> MarkTaskMap = new Dictionary<EMarkType, Dictionary<int, IMapMarkPreemptiveFrameTask>>();
	}
}

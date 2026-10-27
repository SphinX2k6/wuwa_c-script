using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Misc.PreemptiveFrameQueue;

namespace CSharpScript.Game.Module.Map.View.BaseMap.Assistant.MapFrameTaskQueue
{
	// Token: 0x020054A6 RID: 21670
	[NullableContext(1)]
	[Nullable(0)]
	public class MapMarkPreemptiveFrameQueue : SimplePreemptiveFrameQueue
	{
		// Token: 0x060375DF RID: 226783 RVA: 0x00D27377 File Offset: 0x00D25577
		public MapMarkPreemptiveFrameQueue(int perFrameTaskLimit, int executeFrameInterval = 0) : base(perFrameTaskLimit, executeFrameInterval)
		{
		}

		// Token: 0x060375E0 RID: 226784 RVA: 0x00D2738C File Offset: 0x00D2558C
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

		// Token: 0x060375E1 RID: 226785 RVA: 0x00D273E4 File Offset: 0x00D255E4
		public void ForceExecuteTask(EMarkType markType, int markId)
		{
			IMapMarkPreemptiveFrameTask task = this.GetTask(markType, markId);
			if (task != null)
			{
				task.Execute();
				this.CancelMapTask(markType, markId);
			}
		}

		// Token: 0x060375E2 RID: 226786 RVA: 0x00D27410 File Offset: 0x00D25610
		public void Flush()
		{
			this.EnableFlush = true;
			base.Process();
			this.EnableFlush = false;
		}

		// Token: 0x060375E3 RID: 226787 RVA: 0x00D27428 File Offset: 0x00D25628
		public void CancelMapTask(EMarkType markType, int markId)
		{
			IMapMarkPreemptiveFrameTask task = this.GetTask(markType, markId);
			if (task != null)
			{
				base.CancelTask(task);
				this.RemoveTaskCache(task);
			}
		}

		// Token: 0x060375E4 RID: 226788 RVA: 0x00D27450 File Offset: 0x00D25650
		private void RemoveTaskCache(IMapMarkPreemptiveFrameTask task)
		{
			Dictionary<int, IMapMarkPreemptiveFrameTask> dictionary;
			if (this.MarkTaskMap.TryGetValue(task.MarkType, out dictionary))
			{
				dictionary.Remove(task.MarkId);
			}
		}

		// Token: 0x060375E5 RID: 226789 RVA: 0x00D2747F File Offset: 0x00D2567F
		public bool HasTask(EMarkType markType, int markId)
		{
			return this.GetTask(markType, markId) != null;
		}

		// Token: 0x060375E6 RID: 226790 RVA: 0x00D2748C File Offset: 0x00D2568C
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

		// Token: 0x060375E7 RID: 226791 RVA: 0x00D27510 File Offset: 0x00D25710
		public void CancelMapTaskByType(EMarkType markType)
		{
			Dictionary<int, IMapMarkPreemptiveFrameTask> dictionary;
			if (this.MarkTaskMap.TryGetValue(markType, out dictionary))
			{
				foreach (IMapMarkPreemptiveFrameTask task in dictionary.Values.ToList<IMapMarkPreemptiveFrameTask>())
				{
					base.CancelTask(task);
					this.RemoveTaskCache(task);
				}
			}
		}

		// Token: 0x060375E8 RID: 226792 RVA: 0x00D27580 File Offset: 0x00D25780
		protected override void OnTaskComplete(IPreemptiveFrameTask task)
		{
			base.OnTaskComplete(task);
			IMapMarkPreemptiveFrameTask mapMarkPreemptiveFrameTask = (IMapMarkPreemptiveFrameTask)task;
			this.RemoveTaskCache(mapMarkPreemptiveFrameTask);
			EventSystem.Instance.Emit<EMarkType, int>(EEventName.OnMapMarkTaskComplete, mapMarkPreemptiveFrameTask.MarkType, mapMarkPreemptiveFrameTask.MarkId);
		}

		// Token: 0x0401D2B4 RID: 119476
		private readonly Dictionary<EMarkType, Dictionary<int, IMapMarkPreemptiveFrameTask>> MarkTaskMap = new Dictionary<EMarkType, Dictionary<int, IMapMarkPreemptiveFrameTask>>();
	}
}

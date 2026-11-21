using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Misc.PreemptiveFrameQueue;

namespace CSharpScript.Game.Module.Map.View.BaseMap.Assistant.MapFrameTaskQueue
{
	// Token: 0x0200448E RID: 17550
	[NullableContext(1)]
	[Nullable(0)]
	public class MapUpdateTaskPreemptiveFrameQueue : SimplePreemptiveFrameQueue
	{
		// Token: 0x0602C56D RID: 181613 RVA: 0x00C7746B File Offset: 0x00C7566B
		public MapUpdateTaskPreemptiveFrameQueue(int perFrameTaskLimit, int executeFrameInterval = 0) : base(perFrameTaskLimit, executeFrameInterval)
		{
		}

		// Token: 0x0602C56E RID: 181614 RVA: 0x00C77480 File Offset: 0x00C75680
		public override void AddTask(IPreemptiveFrameTask task)
		{
			IMapMarkPreemptiveFrameTask mapMarkPreemptiveFrameTask = task as IMapMarkPreemptiveFrameTask;
			if (mapMarkPreemptiveFrameTask == null)
			{
				return;
			}
			if (this.MarkTaskMap.ContainsKey(mapMarkPreemptiveFrameTask.MarkId))
			{
				return;
			}
			this.MarkTaskMap[mapMarkPreemptiveFrameTask.MarkId] = mapMarkPreemptiveFrameTask;
			base.AddTask(mapMarkPreemptiveFrameTask);
		}

		// Token: 0x0602C56F RID: 181615 RVA: 0x00C774C8 File Offset: 0x00C756C8
		protected override void OnTaskComplete(IPreemptiveFrameTask task)
		{
			IMapMarkPreemptiveFrameTask mapMarkPreemptiveFrameTask = task as IMapMarkPreemptiveFrameTask;
			if (mapMarkPreemptiveFrameTask != null)
			{
				this.MarkTaskMap.Remove(mapMarkPreemptiveFrameTask.MarkId);
			}
		}

		// Token: 0x0602C570 RID: 181616 RVA: 0x00C774F1 File Offset: 0x00C756F1
		public override void Dispose()
		{
			base.Dispose();
			this.MarkTaskMap.Clear();
		}

		// Token: 0x04017D62 RID: 97634
		private readonly Dictionary<int, IMapMarkPreemptiveFrameTask> MarkTaskMap = new Dictionary<int, IMapMarkPreemptiveFrameTask>();
	}
}

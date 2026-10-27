using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Misc.PreemptiveFrameQueue;

namespace CSharpScript.Game.Module.Map.View.BaseMap.Assistant.MapFrameTaskQueue
{
	// Token: 0x020054AB RID: 21675
	[NullableContext(1)]
	[Nullable(0)]
	public class MapUpdateTaskPreemptiveFrameQueue : SimplePreemptiveFrameQueue
	{
		// Token: 0x06037617 RID: 226839 RVA: 0x00D276EF File Offset: 0x00D258EF
		public MapUpdateTaskPreemptiveFrameQueue(int perFrameTaskLimit, int executeFrameInterval = 0) : base(perFrameTaskLimit, executeFrameInterval)
		{
		}

		// Token: 0x06037618 RID: 226840 RVA: 0x00D27704 File Offset: 0x00D25904
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

		// Token: 0x06037619 RID: 226841 RVA: 0x00D2774C File Offset: 0x00D2594C
		protected override void OnTaskComplete(IPreemptiveFrameTask task)
		{
			IMapMarkPreemptiveFrameTask mapMarkPreemptiveFrameTask = task as IMapMarkPreemptiveFrameTask;
			if (mapMarkPreemptiveFrameTask != null)
			{
				this.MarkTaskMap.Remove(mapMarkPreemptiveFrameTask.MarkId);
			}
		}

		// Token: 0x0603761A RID: 226842 RVA: 0x00D27775 File Offset: 0x00D25975
		public override void Dispose()
		{
			base.Dispose();
			this.MarkTaskMap.Clear();
		}

		// Token: 0x0401D2C6 RID: 119494
		private readonly Dictionary<int, IMapMarkPreemptiveFrameTask> MarkTaskMap = new Dictionary<int, IMapMarkPreemptiveFrameTask>();
	}
}

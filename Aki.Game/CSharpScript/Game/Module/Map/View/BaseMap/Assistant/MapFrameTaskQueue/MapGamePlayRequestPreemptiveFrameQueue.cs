using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Map.Misc.PreemptiveFrameQueue;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Map.View.BaseMap.Assistant.MapFrameTaskQueue
{
	// Token: 0x020054A5 RID: 21669
	[NullableContext(1)]
	[Nullable(0)]
	public class MapGamePlayRequestPreemptiveFrameQueue : SimplePreemptiveFrameQueue
	{
		// Token: 0x060375DC RID: 226780 RVA: 0x00D272A1 File Offset: 0x00D254A1
		public MapGamePlayRequestPreemptiveFrameQueue(int perFrameTaskLimit, int executeFrameInterval = 0) : base(perFrameTaskLimit, executeFrameInterval)
		{
		}

		// Token: 0x060375DD RID: 226781 RVA: 0x00D272B8 File Offset: 0x00D254B8
		protected override void OnTaskComplete(IPreemptiveFrameTask rawTask)
		{
			IMapGamePlayRequestPreemptiveFrameTask mapGamePlayRequestPreemptiveFrameTask = rawTask as IMapGamePlayRequestPreemptiveFrameTask;
			base.OnTaskComplete(mapGamePlayRequestPreemptiveFrameTask);
			InstLevelPlayStateReq instLevelPlayStateReq;
			if (!this.RequestMap.TryGetValue(mapGamePlayRequestPreemptiveFrameTask.InstId, out instLevelPlayStateReq))
			{
				instLevelPlayStateReq = new InstLevelPlayStateReq();
				instLevelPlayStateReq.InstId = mapGamePlayRequestPreemptiveFrameTask.InstId;
				this.RequestMap[mapGamePlayRequestPreemptiveFrameTask.InstId] = instLevelPlayStateReq;
			}
			int gamePlayId = mapGamePlayRequestPreemptiveFrameTask.GamePlayId;
			if (!instLevelPlayStateReq.LevelPlayIds.Contains(gamePlayId))
			{
				instLevelPlayStateReq.LevelPlayIds.Add(gamePlayId);
			}
		}

		// Token: 0x060375DE RID: 226782 RVA: 0x00D27330 File Offset: 0x00D25530
		protected override void OnLateExecuteTasksFrame()
		{
			if (this.RequestMap.Count > 0)
			{
				List<InstLevelPlayStateReq> requestList = this.RequestMap.Values.ToList<InstLevelPlayStateReq>();
				LevelPlayReportController.Instance.RequestLevelPlayStateListAsync(requestList).Forget();
				this.RequestMap.Clear();
			}
		}

		// Token: 0x0401D2B3 RID: 119475
		private readonly Dictionary<int, InstLevelPlayStateReq> RequestMap = new Dictionary<int, InstLevelPlayStateReq>();
	}
}

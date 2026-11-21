using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.Misc.PreemptiveFrameQueue;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Map.View.BaseMap.Assistant.MapFrameTaskQueue
{
	// Token: 0x02004488 RID: 17544
	[NullableContext(1)]
	[Nullable(0)]
	public class MapGamePlayRequestPreemptiveFrameQueue : SimplePreemptiveFrameQueue
	{
		// Token: 0x0602C530 RID: 181552 RVA: 0x00C76EF9 File Offset: 0x00C750F9
		public MapGamePlayRequestPreemptiveFrameQueue(int perFrameTaskLimit, int executeFrameInterval = 0) : base(perFrameTaskLimit, executeFrameInterval)
		{
		}

		// Token: 0x0602C531 RID: 181553 RVA: 0x00C76F10 File Offset: 0x00C75110
		public void TryAddMarkTask(MarkItem markItem, bool skipIfCached = false)
		{
			if (markItem == null || markItem.HasRequestGamePlay || !markItem.IsRelativeLevelPlay || markItem.RelativeGamePlayId == 0)
			{
				return;
			}
			int? relativeInstanceDungeonId = markItem.RelativeInstanceDungeonId;
			if (relativeInstanceDungeonId == null)
			{
				return;
			}
			this.AddGamePlayTask(markItem.MarkId, markItem.RelativeGamePlayId, relativeInstanceDungeonId.Value, skipIfCached);
			IMarkConfig config = markItem.Config;
			for (int i = 0; i < config.AssociatedGameplayMarksLength; i++)
			{
				MapMark? configMark = MapConfig.Instance.GetConfigMark(config.AssociatedGameplayMarks(i));
				if (configMark != null)
				{
					this.AddGamePlayTask(markItem.MarkId, configMark.Value.RelativeId, configMark.Value.RelativeDungeonId, skipIfCached);
				}
			}
			markItem.HasRequestGamePlay = true;
		}

		// Token: 0x0602C532 RID: 181554 RVA: 0x00C76FCC File Offset: 0x00C751CC
		private void AddGamePlayTask(int markId, int gamePlayId, int instId, bool skipIfCached)
		{
			if (skipIfCached && LevelPlayReportModel.Instance.HasLevelPlayState(instId, gamePlayId))
			{
				return;
			}
			MapGamePlayRequestPreemptiveFrameTask mapGamePlayRequestPreemptiveFrameTask = new MapGamePlayRequestPreemptiveFrameTask();
			mapGamePlayRequestPreemptiveFrameTask.Priority = 0;
			mapGamePlayRequestPreemptiveFrameTask.Execute = delegate()
			{
			};
			mapGamePlayRequestPreemptiveFrameTask.MarkId = markId;
			mapGamePlayRequestPreemptiveFrameTask.GamePlayId = gamePlayId;
			mapGamePlayRequestPreemptiveFrameTask.InstId = instId;
			this.AddTask(mapGamePlayRequestPreemptiveFrameTask);
		}

		// Token: 0x0602C533 RID: 181555 RVA: 0x00C77038 File Offset: 0x00C75238
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

		// Token: 0x0602C534 RID: 181556 RVA: 0x00C770B0 File Offset: 0x00C752B0
		protected override void OnLateExecuteTasksFrame()
		{
			if (this.RequestMap.Count > 0)
			{
				List<InstLevelPlayStateReq> requestList = new List<InstLevelPlayStateReq>(this.RequestMap.Values);
				LevelPlayReportController.Instance.RequestLevelPlayStateListAsync(requestList).Forget();
				this.RequestMap.Clear();
			}
		}

		// Token: 0x04017D4F RID: 97615
		private readonly Dictionary<int, InstLevelPlayStateReq> RequestMap = new Dictionary<int, InstLevelPlayStateReq>();
	}
}

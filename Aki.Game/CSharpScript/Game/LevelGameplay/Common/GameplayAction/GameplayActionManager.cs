using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.Common.GameplayAction
{
	// Token: 0x020060A7 RID: 24743
	[NullableContext(1)]
	[Nullable(0)]
	public class GameplayActionManager
	{
		// Token: 0x0603B576 RID: 243062 RVA: 0x010CBE73 File Offset: 0x010CA073
		public void Init(GameplayActionTicker actionTicker)
		{
			this.ActionTicker = actionTicker;
		}

		// Token: 0x0603B577 RID: 243063 RVA: 0x010CBE7C File Offset: 0x010CA07C
		public virtual void Clear()
		{
			this.Interrupt();
			this.ActionTicker = null;
		}

		// Token: 0x0603B578 RID: 243064 RVA: 0x010CBE8C File Offset: 0x010CA08C
		public void Interrupt()
		{
			GameplayActionTicker actionTicker = this.ActionTicker;
			if (actionTicker != null)
			{
				actionTicker.Clear();
			}
			foreach (KeyValuePair<int, ActionGroupQueue> keyValuePair in this.ActionGroupQueueMap)
			{
				Queue<GameplayActionGroup> queue = keyValuePair.Value.Queue;
				while (queue.Size > 0)
				{
					queue.Pop().InterruptActionGroup();
				}
			}
			this.ActionGroupQueueMap.Clear();
		}

		// Token: 0x0603B579 RID: 243065 RVA: 0x010CBF18 File Offset: 0x010CA118
		protected void ExecuteActionGroups(List<GameplayActionGroup> actionGroups, [Nullable(2)] Action onAllFinish = null)
		{
			if (actionGroups.Count <= 0)
			{
				if (onAllFinish != null)
				{
					onAllFinish();
				}
				return;
			}
			int num = this.QueueId + 1;
			this.QueueId = num;
			int num2 = num;
			ActionGroupQueue actionGroupQueue = new ActionGroupQueue();
			actionGroupQueue.OnFinish = onAllFinish;
			this.ActionGroupQueueMap[num2] = actionGroupQueue;
			foreach (GameplayActionGroup gameplayActionGroup in actionGroups)
			{
				gameplayActionGroup.OwnerId = num2;
				actionGroupQueue.Queue.Push(gameplayActionGroup);
			}
			actionGroupQueue.Queue.Front.ExecuteActionGroup(this.ActionTicker, new Action<int>(this.OnActionGroupFinish));
		}

		// Token: 0x0603B57A RID: 243066 RVA: 0x010CBFD8 File Offset: 0x010CA1D8
		private void OnActionGroupFinish(int ownerId)
		{
			ActionGroupQueue actionGroupQueue;
			if (!this.ActionGroupQueueMap.TryGetValue(ownerId, out actionGroupQueue))
			{
				return;
			}
			Queue<GameplayActionGroup> queue = actionGroupQueue.Queue;
			queue.Pop();
			if (queue.Size > 0)
			{
				queue.Front.ExecuteActionGroup(this.ActionTicker, new Action<int>(this.OnActionGroupFinish));
				return;
			}
			ActionGroupQueue actionGroupQueue2;
			if (this.ActionGroupQueueMap.TryGetValue(ownerId, out actionGroupQueue2))
			{
				Action onFinish = actionGroupQueue2.OnFinish;
				if (onFinish != null)
				{
					onFinish();
				}
			}
			this.ActionGroupQueueMap.Remove(ownerId);
		}

		// Token: 0x0401F44B RID: 128075
		private int QueueId;

		// Token: 0x0401F44C RID: 128076
		private readonly Dictionary<int, ActionGroupQueue> ActionGroupQueueMap = new Dictionary<int, ActionGroupQueue>();

		// Token: 0x0401F44D RID: 128077
		[Nullable(2)]
		private GameplayActionTicker ActionTicker;
	}
}

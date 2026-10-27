using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.Common.GameplayAction
{
	// Token: 0x02006F26 RID: 28454
	[NullableContext(1)]
	[Nullable(0)]
	public class GameplayActionManager
	{
		// Token: 0x060453C8 RID: 283592 RVA: 0x01121EC7 File Offset: 0x011200C7
		public void Init(GameplayActionTicker actionTicker)
		{
			this.ActionTicker = actionTicker;
		}

		// Token: 0x060453C9 RID: 283593 RVA: 0x01121ED0 File Offset: 0x011200D0
		public virtual void Clear()
		{
			this.Interrupt();
			this.ActionTicker = null;
		}

		// Token: 0x060453CA RID: 283594 RVA: 0x01121EE0 File Offset: 0x011200E0
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

		// Token: 0x060453CB RID: 283595 RVA: 0x01121F6C File Offset: 0x0112016C
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

		// Token: 0x060453CC RID: 283596 RVA: 0x0112202C File Offset: 0x0112022C
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

		// Token: 0x04024196 RID: 147862
		private int QueueId;

		// Token: 0x04024197 RID: 147863
		private readonly Dictionary<int, ActionGroupQueue> ActionGroupQueueMap = new Dictionary<int, ActionGroupQueue>();

		// Token: 0x04024198 RID: 147864
		[Nullable(2)]
		private GameplayActionTicker ActionTicker;
	}
}

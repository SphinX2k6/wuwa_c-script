using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.Common.GameplayAction
{
	// Token: 0x020060A5 RID: 24741
	[NullableContext(1)]
	[Nullable(0)]
	public class GameplayActionGroup
	{
		// Token: 0x0603B56F RID: 243055 RVA: 0x010CBC96 File Offset: 0x010C9E96
		public void PushAction(GameplayAction task)
		{
			this.ActionList.Add(task);
		}

		// Token: 0x0603B570 RID: 243056 RVA: 0x010CBCA4 File Offset: 0x010C9EA4
		[NullableContext(2)]
		public void ExecuteActionGroup(GameplayActionTicker ticker = null, Action<int> onFinish = null)
		{
			this.State = EActionGroupState.Executing;
			foreach (GameplayAction gameplayAction in this.ActionList)
			{
				gameplayAction.ExecuteAction(new Action(this.CheckGroupFinish));
				if (gameplayAction.NeedTick() && ticker != null)
				{
					ticker.PushAction(gameplayAction);
				}
			}
			this.OnActionGroupFinish = onFinish;
			this.CheckGroupFinish();
		}

		// Token: 0x0603B571 RID: 243057 RVA: 0x010CBD28 File Offset: 0x010C9F28
		public void InterruptActionGroup()
		{
			foreach (GameplayAction gameplayAction in this.ActionList)
			{
				gameplayAction.InterruptAction();
			}
			this.State = EActionGroupState.Finish;
		}

		// Token: 0x0603B572 RID: 243058 RVA: 0x010CBD80 File Offset: 0x010C9F80
		public EActionGroupState GetState()
		{
			return this.State;
		}

		// Token: 0x0603B573 RID: 243059 RVA: 0x010CBD88 File Offset: 0x010C9F88
		private void CheckGroupFinish()
		{
			foreach (GameplayAction gameplayAction in this.ActionList)
			{
				if (!gameplayAction.IsLoop() && !gameplayAction.IsFinish())
				{
					return;
				}
			}
			foreach (GameplayAction gameplayAction2 in this.ActionList)
			{
				if (!gameplayAction2.IsFinish())
				{
					gameplayAction2.InterruptAction();
				}
			}
			this.State = EActionGroupState.Finish;
			Action<int> onActionGroupFinish = this.OnActionGroupFinish;
			if (onActionGroupFinish == null)
			{
				return;
			}
			onActionGroupFinish(this.OwnerId);
		}

		// Token: 0x0401F445 RID: 128069
		public int OwnerId;

		// Token: 0x0401F446 RID: 128070
		private readonly List<GameplayAction> ActionList = new List<GameplayAction>();

		// Token: 0x0401F447 RID: 128071
		private EActionGroupState State;

		// Token: 0x0401F448 RID: 128072
		[Nullable(2)]
		private Action<int> OnActionGroupFinish;
	}
}

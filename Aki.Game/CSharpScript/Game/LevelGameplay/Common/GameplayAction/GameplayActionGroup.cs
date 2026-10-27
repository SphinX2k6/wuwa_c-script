using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.Common.GameplayAction
{
	// Token: 0x02006F24 RID: 28452
	[NullableContext(1)]
	[Nullable(0)]
	public class GameplayActionGroup
	{
		// Token: 0x060453C1 RID: 283585 RVA: 0x01121CEA File Offset: 0x0111FEEA
		public void PushAction(GameplayAction task)
		{
			this.ActionList.Add(task);
		}

		// Token: 0x060453C2 RID: 283586 RVA: 0x01121CF8 File Offset: 0x0111FEF8
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

		// Token: 0x060453C3 RID: 283587 RVA: 0x01121D7C File Offset: 0x0111FF7C
		public void InterruptActionGroup()
		{
			foreach (GameplayAction gameplayAction in this.ActionList)
			{
				gameplayAction.InterruptAction();
			}
			this.State = EActionGroupState.Finish;
		}

		// Token: 0x060453C4 RID: 283588 RVA: 0x01121DD4 File Offset: 0x0111FFD4
		public EActionGroupState GetState()
		{
			return this.State;
		}

		// Token: 0x060453C5 RID: 283589 RVA: 0x01121DDC File Offset: 0x0111FFDC
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

		// Token: 0x04024190 RID: 147856
		public int OwnerId;

		// Token: 0x04024191 RID: 147857
		private readonly List<GameplayAction> ActionList = new List<GameplayAction>();

		// Token: 0x04024192 RID: 147858
		private EActionGroupState State;

		// Token: 0x04024193 RID: 147859
		[Nullable(2)]
		private Action<int> OnActionGroupFinish;
	}
}

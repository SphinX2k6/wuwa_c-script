using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.Common.GameplayAction
{
	// Token: 0x02006F27 RID: 28455
	[NullableContext(1)]
	[Nullable(0)]
	public class GameplayActionTicker
	{
		// Token: 0x060453CE RID: 283598 RVA: 0x011220C0 File Offset: 0x011202C0
		public virtual void PushAction(GameplayAction action)
		{
			this.ActionList.Add(action);
		}

		// Token: 0x060453CF RID: 283599 RVA: 0x011220D0 File Offset: 0x011202D0
		public virtual void TickAction(float delta)
		{
			int i = 0;
			while (i < this.ActionList.Count)
			{
				GameplayAction gameplayAction = this.ActionList[i];
				if (gameplayAction.IsFinish())
				{
					this.ActionList.RemoveAt(i);
				}
				else
				{
					gameplayAction.TickAction(delta);
					i++;
				}
			}
		}

		// Token: 0x060453D0 RID: 283600 RVA: 0x0112211D File Offset: 0x0112031D
		public virtual void Clear()
		{
			this.ActionList.Clear();
		}

		// Token: 0x04024199 RID: 147865
		protected readonly List<GameplayAction> ActionList = new List<GameplayAction>();
	}
}

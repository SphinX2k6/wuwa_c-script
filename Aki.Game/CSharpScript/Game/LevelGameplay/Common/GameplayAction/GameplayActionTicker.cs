using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.Common.GameplayAction
{
	// Token: 0x020060A8 RID: 24744
	[NullableContext(1)]
	[Nullable(0)]
	public class GameplayActionTicker
	{
		// Token: 0x0603B57C RID: 243068 RVA: 0x010CC06C File Offset: 0x010CA26C
		public virtual void PushAction(GameplayAction action)
		{
			this.ActionList.Add(action);
		}

		// Token: 0x0603B57D RID: 243069 RVA: 0x010CC07C File Offset: 0x010CA27C
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

		// Token: 0x0603B57E RID: 243070 RVA: 0x010CC0C9 File Offset: 0x010CA2C9
		public virtual void Clear()
		{
			this.ActionList.Clear();
		}

		// Token: 0x0401F44E RID: 128078
		protected readonly List<GameplayAction> ActionList = new List<GameplayAction>();
	}
}

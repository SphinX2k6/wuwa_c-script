using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.Common.GameplayAction
{
	// Token: 0x02006F25 RID: 28453
	public class ActionGroupQueue
	{
		// Token: 0x04024194 RID: 147860
		[Nullable(1)]
		public Queue<GameplayActionGroup> Queue = new Queue<GameplayActionGroup>(4);

		// Token: 0x04024195 RID: 147861
		[Nullable(2)]
		public Action OnFinish;
	}
}

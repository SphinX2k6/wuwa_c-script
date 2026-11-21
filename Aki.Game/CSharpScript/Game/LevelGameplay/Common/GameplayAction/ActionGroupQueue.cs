using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.Common.GameplayAction
{
	// Token: 0x020060A6 RID: 24742
	public class ActionGroupQueue
	{
		// Token: 0x0401F449 RID: 128073
		[Nullable(1)]
		public Queue<GameplayActionGroup> Queue = new Queue<GameplayActionGroup>(4);

		// Token: 0x0401F44A RID: 128074
		[Nullable(2)]
		public Action OnFinish;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelAi
{
	// Token: 0x02006DAE RID: 28078
	public class SubNodesInfo
	{
		// Token: 0x04023A10 RID: 145936
		[Nullable(1)]
		public List<LevelAiDecorator> SubDecorators = new List<LevelAiDecorator>();

		// Token: 0x04023A11 RID: 145937
		public int LastFrameSubNodesTicked = -1;

		// Token: 0x04023A12 RID: 145938
		public bool SubNodesExecuting;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelAi
{
	// Token: 0x02005F2D RID: 24365
	public class SubNodesInfo
	{
		// Token: 0x0401ECB2 RID: 126130
		[Nullable(1)]
		public List<LevelAiDecorator> SubDecorators = new List<LevelAiDecorator>();

		// Token: 0x0401ECB3 RID: 126131
		public int LastFrameSubNodesTicked = -1;

		// Token: 0x0401ECB4 RID: 126132
		public bool SubNodesExecuting;
	}
}

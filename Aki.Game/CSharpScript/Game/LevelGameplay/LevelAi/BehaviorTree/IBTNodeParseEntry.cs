using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelAi.BehaviorTree
{
	// Token: 0x02005F5A RID: 24410
	public class IBTNodeParseEntry
	{
		// Token: 0x0401ED6E RID: 126318
		[Nullable(1)]
		public string classPath;

		// Token: 0x0401ED6F RID: 126319
		public EBTNodeType nodeType;

		// Token: 0x0401ED70 RID: 126320
		[Nullable(new byte[]
		{
			1,
			1,
			1,
			2,
			2,
			1,
			2
		})]
		public Func<object, IParserContext, IMontageConfigProvider, Dictionary<string, object>> parse;
	}
}

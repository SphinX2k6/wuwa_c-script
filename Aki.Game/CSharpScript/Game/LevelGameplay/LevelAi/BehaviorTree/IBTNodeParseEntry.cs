using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelAi.BehaviorTree
{
	// Token: 0x02006DDB RID: 28123
	public class IBTNodeParseEntry
	{
		// Token: 0x04023ACC RID: 146124
		[Nullable(1)]
		public string classPath;

		// Token: 0x04023ACD RID: 146125
		public EBTNodeType nodeType;

		// Token: 0x04023ACE RID: 146126
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

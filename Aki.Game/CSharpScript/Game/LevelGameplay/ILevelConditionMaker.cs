using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005AEE RID: 23278
	[NullableContext(1)]
	public interface ILevelConditionMaker
	{
		// Token: 0x17006D2A RID: 27946
		// (get) Token: 0x06039451 RID: 234577
		// (set) Token: 0x06039452 RID: 234578
		LevelConditionBase LevelCondition { get; set; }

		// Token: 0x17006D2B RID: 27947
		// (get) Token: 0x06039453 RID: 234579
		// (set) Token: 0x06039454 RID: 234580
		List<EEventName> EventNames { get; set; }
	}
}

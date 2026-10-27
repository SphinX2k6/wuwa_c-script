using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02006992 RID: 27026
	[NullableContext(1)]
	public interface ILevelConditionMaker
	{
		// Token: 0x1700984A RID: 38986
		// (get) Token: 0x06043419 RID: 275481
		// (set) Token: 0x0604341A RID: 275482
		LevelConditionBase LevelCondition { get; set; }

		// Token: 0x1700984B RID: 38987
		// (get) Token: 0x0604341B RID: 275483
		// (set) Token: 0x0604341C RID: 275484
		List<EEventName> EventNames { get; set; }
	}
}

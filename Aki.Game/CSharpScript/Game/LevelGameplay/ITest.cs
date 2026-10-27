using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x020069A8 RID: 27048
	[NullableContext(1)]
	public interface ITest
	{
		// Token: 0x17009854 RID: 38996
		// (get) Token: 0x06043467 RID: 275559
		// (set) Token: 0x06043468 RID: 275560
		int TestSameType { get; set; }

		// Token: 0x17009855 RID: 38997
		// (get) Token: 0x06043469 RID: 275561
		// (set) Token: 0x0604346A RID: 275562
		string TestDifferentType { get; set; }
	}
}

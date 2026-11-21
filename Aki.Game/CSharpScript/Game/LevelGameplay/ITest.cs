using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005B04 RID: 23300
	[NullableContext(1)]
	public interface ITest
	{
		// Token: 0x17006D34 RID: 27956
		// (get) Token: 0x0603949F RID: 234655
		// (set) Token: 0x060394A0 RID: 234656
		int TestSameType { get; set; }

		// Token: 0x17006D35 RID: 27957
		// (get) Token: 0x060394A1 RID: 234657
		// (set) Token: 0x060394A2 RID: 234658
		string TestDifferentType { get; set; }
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039ED RID: 14829
	[NullableContext(1)]
	public interface ITrapDefenseTab<[Nullable(2)] T>
	{
		// Token: 0x17004DF9 RID: 19961
		// (get) Token: 0x0602631E RID: 156446
		// (set) Token: 0x0602631F RID: 156447
		T TabType { get; set; }

		// Token: 0x17004DFA RID: 19962
		// (get) Token: 0x06026320 RID: 156448
		// (set) Token: 0x06026321 RID: 156449
		string TabNameKey { get; set; }
	}
}

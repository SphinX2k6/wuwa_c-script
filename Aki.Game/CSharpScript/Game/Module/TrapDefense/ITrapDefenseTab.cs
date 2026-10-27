using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A45 RID: 19013
	[NullableContext(1)]
	public interface ITrapDefenseTab<[Nullable(2)] T>
	{
		// Token: 0x17007A4C RID: 31308
		// (get) Token: 0x0603158E RID: 202126
		// (set) Token: 0x0603158F RID: 202127
		T TabType { get; set; }

		// Token: 0x17007A4D RID: 31309
		// (get) Token: 0x06031590 RID: 202128
		// (set) Token: 0x06031591 RID: 202129
		string TabNameKey { get; set; }
	}
}

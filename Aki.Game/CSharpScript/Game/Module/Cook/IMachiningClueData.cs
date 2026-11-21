using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Cook
{
	// Token: 0x02004AE4 RID: 19172
	[NullableContext(1)]
	public interface IMachiningClueData
	{
		// Token: 0x17006045 RID: 24645
		// (get) Token: 0x0602FF68 RID: 196456
		// (set) Token: 0x0602FF69 RID: 196457
		bool IsUnlock { get; set; }

		// Token: 0x17006046 RID: 24646
		// (get) Token: 0x0602FF6A RID: 196458
		// (set) Token: 0x0602FF6B RID: 196459
		string ContentText { get; set; }
	}
}

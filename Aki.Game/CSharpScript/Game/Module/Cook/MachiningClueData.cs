using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Cook
{
	// Token: 0x02004AE5 RID: 19173
	[NullableContext(1)]
	[Nullable(0)]
	public class MachiningClueData : IMachiningClueData
	{
		// Token: 0x17006047 RID: 24647
		// (get) Token: 0x0602FF6C RID: 196460 RVA: 0x00D61DE9 File Offset: 0x00D5FFE9
		// (set) Token: 0x0602FF6D RID: 196461 RVA: 0x00D61DF1 File Offset: 0x00D5FFF1
		public bool IsUnlock { get; set; }

		// Token: 0x17006048 RID: 24648
		// (get) Token: 0x0602FF6E RID: 196462 RVA: 0x00D61DFA File Offset: 0x00D5FFFA
		// (set) Token: 0x0602FF6F RID: 196463 RVA: 0x00D61E02 File Offset: 0x00D60002
		public string ContentText { get; set; }
	}
}

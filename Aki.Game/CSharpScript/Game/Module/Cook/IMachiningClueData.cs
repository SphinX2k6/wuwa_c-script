using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Cook
{
	// Token: 0x02005B03 RID: 23299
	[NullableContext(1)]
	public interface IMachiningClueData
	{
		// Token: 0x17008C6B RID: 35947
		// (get) Token: 0x0603AFF6 RID: 241654
		// (set) Token: 0x0603AFF7 RID: 241655
		bool IsUnlock { get; set; }

		// Token: 0x17008C6C RID: 35948
		// (get) Token: 0x0603AFF8 RID: 241656
		// (set) Token: 0x0603AFF9 RID: 241657
		string ContentText { get; set; }
	}
}

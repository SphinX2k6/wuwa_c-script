using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Flow
{
	// Token: 0x020063CC RID: 25548
	[NullableContext(1)]
	public interface ITalkOption
	{
		// Token: 0x170075B7 RID: 30135
		// (get) Token: 0x0603DF5A RID: 253786
		// (set) Token: 0x0603DF5B RID: 253787
		int TextId { get; set; }

		// Token: 0x170075B8 RID: 30136
		// (get) Token: 0x0603DF5C RID: 253788
		// (set) Token: 0x0603DF5D RID: 253789
		IActionInfo[] Actions { get; set; }
	}
}

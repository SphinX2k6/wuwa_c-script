using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Flow
{
	// Token: 0x0200724D RID: 29261
	[NullableContext(1)]
	public interface ITalkOption
	{
		// Token: 0x17009E5F RID: 40543
		// (get) Token: 0x06047BA2 RID: 293794
		// (set) Token: 0x06047BA3 RID: 293795
		int TextId { get; set; }

		// Token: 0x17009E60 RID: 40544
		// (get) Token: 0x06047BA4 RID: 293796
		// (set) Token: 0x06047BA5 RID: 293797
		IActionInfo[] Actions { get; set; }
	}
}

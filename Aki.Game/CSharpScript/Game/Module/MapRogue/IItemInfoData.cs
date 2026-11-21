using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02004605 RID: 17925
	[NullableContext(1)]
	public interface IItemInfoData
	{
		// Token: 0x17005AF5 RID: 23285
		// (get) Token: 0x0602D0D6 RID: 184534
		// (set) Token: 0x0602D0D7 RID: 184535
		string TitleId { get; set; }

		// Token: 0x17005AF6 RID: 23286
		// (get) Token: 0x0602D0D8 RID: 184536
		// (set) Token: 0x0602D0D9 RID: 184537
		string Value { get; set; }

		// Token: 0x17005AF7 RID: 23287
		// (get) Token: 0x0602D0DA RID: 184538
		// (set) Token: 0x0602D0DB RID: 184539
		bool ValueChangeColor { get; set; }
	}
}

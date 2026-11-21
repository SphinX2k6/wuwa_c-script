using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02004A8C RID: 19084
	[NullableContext(1)]
	public interface IDreamLinkReachedData
	{
		// Token: 0x17005FE4 RID: 24548
		// (get) Token: 0x0602FC3A RID: 195642
		// (set) Token: 0x0602FC3B RID: 195643
		string Title { get; set; }

		// Token: 0x17005FE5 RID: 24549
		// (get) Token: 0x0602FC3C RID: 195644
		// (set) Token: 0x0602FC3D RID: 195645
		string Score { get; set; }

		// Token: 0x17005FE6 RID: 24550
		// (get) Token: 0x0602FC3E RID: 195646
		// (set) Token: 0x0602FC3F RID: 195647
		bool IsReached { get; set; }
	}
}

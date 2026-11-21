using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Flow
{
	// Token: 0x020063DB RID: 25563
	[NullableContext(1)]
	public interface IPlayCustomSequence
	{
		// Token: 0x170075CF RID: 30159
		// (get) Token: 0x0603DF90 RID: 253840
		// (set) Token: 0x0603DF91 RID: 253841
		int CustomSeqId { get; set; }

		// Token: 0x170075D0 RID: 30160
		// (get) Token: 0x0603DF92 RID: 253842
		// (set) Token: 0x0603DF93 RID: 253843
		int[] WhoIds { get; set; }

		// Token: 0x170075D1 RID: 30161
		// (get) Token: 0x0603DF94 RID: 253844
		// (set) Token: 0x0603DF95 RID: 253845
		bool? ResetCamera { get; set; }
	}
}

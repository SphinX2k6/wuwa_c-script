using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.View
{
	// Token: 0x02006070 RID: 24688
	[NullableContext(1)]
	public interface IDollDescriptionItemData
	{
		// Token: 0x17007030 RID: 28720
		// (get) Token: 0x0603B431 RID: 242737
		// (set) Token: 0x0603B432 RID: 242738
		string IconPath { get; set; }

		// Token: 0x17007031 RID: 28721
		// (get) Token: 0x0603B433 RID: 242739
		// (set) Token: 0x0603B434 RID: 242740
		string TextTitle { get; set; }

		// Token: 0x17007032 RID: 28722
		// (get) Token: 0x0603B435 RID: 242741
		// (set) Token: 0x0603B436 RID: 242742
		string TextContent { get; set; }
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.View
{
	// Token: 0x02006EF0 RID: 28400
	[NullableContext(1)]
	public interface IDollDescriptionItemData
	{
		// Token: 0x17009AF1 RID: 39665
		// (get) Token: 0x06045288 RID: 283272
		// (set) Token: 0x06045289 RID: 283273
		string IconPath { get; set; }

		// Token: 0x17009AF2 RID: 39666
		// (get) Token: 0x0604528A RID: 283274
		// (set) Token: 0x0604528B RID: 283275
		string TextTitle { get; set; }

		// Token: 0x17009AF3 RID: 39667
		// (get) Token: 0x0604528C RID: 283276
		// (set) Token: 0x0604528D RID: 283277
		string TextContent { get; set; }
	}
}

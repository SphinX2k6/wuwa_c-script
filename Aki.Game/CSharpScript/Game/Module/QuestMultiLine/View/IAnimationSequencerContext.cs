using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.QuestMultiLine.View.Items;

namespace CSharpScript.Game.Module.QuestMultiLine.View
{
	// Token: 0x02003F73 RID: 16243
	[NullableContext(1)]
	public interface IAnimationSequencerContext
	{
		// Token: 0x17005328 RID: 21288
		// (get) Token: 0x060291C0 RID: 168384
		// (set) Token: 0x060291C1 RID: 168385
		QuestMultiLineMapPanel MapPanel { get; set; }

		// Token: 0x17005329 RID: 21289
		// (get) Token: 0x060291C2 RID: 168386
		// (set) Token: 0x060291C3 RID: 168387
		QuestMultiLineTimeLinePanel TimeLinePanel { get; set; }

		// Token: 0x1700532A RID: 21290
		// (get) Token: 0x060291C4 RID: 168388
		// (set) Token: 0x060291C5 RID: 168389
		QuestMultiLineView View { get; set; }
	}
}

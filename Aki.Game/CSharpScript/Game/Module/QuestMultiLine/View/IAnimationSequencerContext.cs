using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.QuestMultiLine.View.Items;

namespace CSharpScript.Game.Module.QuestMultiLine.View
{
	// Token: 0x02004FAA RID: 20394
	[NullableContext(1)]
	public interface IAnimationSequencerContext
	{
		// Token: 0x17007F78 RID: 32632
		// (get) Token: 0x06034352 RID: 213842
		// (set) Token: 0x06034353 RID: 213843
		QuestMultiLineMapPanel MapPanel { get; set; }

		// Token: 0x17007F79 RID: 32633
		// (get) Token: 0x06034354 RID: 213844
		// (set) Token: 0x06034355 RID: 213845
		QuestMultiLineTimeLinePanel TimeLinePanel { get; set; }

		// Token: 0x17007F7A RID: 32634
		// (get) Token: 0x06034356 RID: 213846
		// (set) Token: 0x06034357 RID: 213847
		QuestMultiLineView View { get; set; }
	}
}

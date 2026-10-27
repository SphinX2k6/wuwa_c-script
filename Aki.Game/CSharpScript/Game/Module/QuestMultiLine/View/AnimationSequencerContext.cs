using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.QuestMultiLine.View.Items;

namespace CSharpScript.Game.Module.QuestMultiLine.View
{
	// Token: 0x02004FAB RID: 20395
	[NullableContext(1)]
	[Nullable(0)]
	public class AnimationSequencerContext : IAnimationSequencerContext
	{
		// Token: 0x17007F7B RID: 32635
		// (get) Token: 0x06034358 RID: 213848 RVA: 0x00C41626 File Offset: 0x00C3F826
		// (set) Token: 0x06034359 RID: 213849 RVA: 0x00C4162E File Offset: 0x00C3F82E
		public QuestMultiLineMapPanel MapPanel { get; set; }

		// Token: 0x17007F7C RID: 32636
		// (get) Token: 0x0603435A RID: 213850 RVA: 0x00C41637 File Offset: 0x00C3F837
		// (set) Token: 0x0603435B RID: 213851 RVA: 0x00C4163F File Offset: 0x00C3F83F
		public QuestMultiLineTimeLinePanel TimeLinePanel { get; set; }

		// Token: 0x17007F7D RID: 32637
		// (get) Token: 0x0603435C RID: 213852 RVA: 0x00C41648 File Offset: 0x00C3F848
		// (set) Token: 0x0603435D RID: 213853 RVA: 0x00C41650 File Offset: 0x00C3F850
		public QuestMultiLineView View { get; set; }
	}
}

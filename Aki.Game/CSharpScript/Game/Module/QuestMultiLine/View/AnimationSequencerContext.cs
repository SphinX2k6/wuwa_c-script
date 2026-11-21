using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.QuestMultiLine.View.Items;

namespace CSharpScript.Game.Module.QuestMultiLine.View
{
	// Token: 0x02003F74 RID: 16244
	[NullableContext(1)]
	[Nullable(0)]
	public class AnimationSequencerContext : IAnimationSequencerContext
	{
		// Token: 0x1700532B RID: 21291
		// (get) Token: 0x060291C6 RID: 168390 RVA: 0x00B8ADD2 File Offset: 0x00B88FD2
		// (set) Token: 0x060291C7 RID: 168391 RVA: 0x00B8ADDA File Offset: 0x00B88FDA
		public QuestMultiLineMapPanel MapPanel { get; set; }

		// Token: 0x1700532C RID: 21292
		// (get) Token: 0x060291C8 RID: 168392 RVA: 0x00B8ADE3 File Offset: 0x00B88FE3
		// (set) Token: 0x060291C9 RID: 168393 RVA: 0x00B8ADEB File Offset: 0x00B88FEB
		public QuestMultiLineTimeLinePanel TimeLinePanel { get; set; }

		// Token: 0x1700532D RID: 21293
		// (get) Token: 0x060291CA RID: 168394 RVA: 0x00B8ADF4 File Offset: 0x00B88FF4
		// (set) Token: 0x060291CB RID: 168395 RVA: 0x00B8ADFC File Offset: 0x00B88FFC
		public QuestMultiLineView View { get; set; }
	}
}

using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058E9 RID: 22761
	public class ISceneTextSubtitleWithVoiceT
	{
		// Token: 0x1700AA89 RID: 43657
		// (get) Token: 0x06026718 RID: 157464 RVA: 0x0054C383 File Offset: 0x0054A583
		// (set) Token: 0x06026719 RID: 157465 RVA: 0x0054C38B File Offset: 0x0054A58B
		public ESceneTextType Type { get; set; }

		// Token: 0x1700AA8A RID: 43658
		// (get) Token: 0x0602671A RID: 157466 RVA: 0x0054C394 File Offset: 0x0054A594
		// (set) Token: 0x0602671B RID: 157467 RVA: 0x0054C39C File Offset: 0x0054A59C
		public IPlayFlowT Content { get; set; }

		// Token: 0x1700AA8B RID: 43659
		// (get) Token: 0x0602671C RID: 157468 RVA: 0x0054C3A5 File Offset: 0x0054A5A5
		// (set) Token: 0x0602671D RID: 157469 RVA: 0x0054C3AD File Offset: 0x0054A5AD
		public int FontSize { get; set; }

		// Token: 0x1700AA8C RID: 43660
		// (get) Token: 0x0602671E RID: 157470 RVA: 0x0054C3B6 File Offset: 0x0054A5B6
		// (set) Token: 0x0602671F RID: 157471 RVA: 0x0054C3BE File Offset: 0x0054A5BE
		public float BoxWidth { get; set; }

		// Token: 0x1700AA8D RID: 43661
		// (get) Token: 0x06026720 RID: 157472 RVA: 0x0054C3C7 File Offset: 0x0054A5C7
		// (set) Token: 0x06026721 RID: 157473 RVA: 0x0054C3CF File Offset: 0x0054A5CF
		public float BoxHeight { get; set; }

		// Token: 0x1700AA8E RID: 43662
		// (get) Token: 0x06026722 RID: 157474 RVA: 0x0054C3D8 File Offset: 0x0054A5D8
		// (set) Token: 0x06026723 RID: 157475 RVA: 0x0054C3E0 File Offset: 0x0054A5E0
		public float Duration { get; set; }

		// Token: 0x1700AA8F RID: 43663
		// (get) Token: 0x06026724 RID: 157476 RVA: 0x0054C3E9 File Offset: 0x0054A5E9
		// (set) Token: 0x06026725 RID: 157477 RVA: 0x0054C3F1 File Offset: 0x0054A5F1
		public bool AutoHide { get; set; }

		// Token: 0x1700AA90 RID: 43664
		// (get) Token: 0x06026726 RID: 157478 RVA: 0x0054C3FA File Offset: 0x0054A5FA
		// (set) Token: 0x06026727 RID: 157479 RVA: 0x0054C402 File Offset: 0x0054A602
		public byte NullMask { get; set; }

		// Token: 0x06026728 RID: 157480 RVA: 0x0054C40C File Offset: 0x0054A60C
		public ISceneTextSubtitleWithVoiceT()
		{
			this.Type = ESceneTextType.SubtitleWithVoice;
			this.Content = null;
			this.FontSize = 0;
			this.BoxWidth = 0f;
			this.BoxHeight = 0f;
			this.Duration = 0f;
			this.AutoHide = false;
			this.NullMask = 0;
		}
	}
}

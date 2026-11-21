using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EF6 RID: 24310
	public class ISceneTextSubtitleWithVoiceT
	{
		// Token: 0x1700B3BB RID: 46011
		// (get) Token: 0x06028C7E RID: 167038 RVA: 0x00592F9B File Offset: 0x0059119B
		// (set) Token: 0x06028C7F RID: 167039 RVA: 0x00592FA3 File Offset: 0x005911A3
		public ESceneTextType Type { get; set; }

		// Token: 0x1700B3BC RID: 46012
		// (get) Token: 0x06028C80 RID: 167040 RVA: 0x00592FAC File Offset: 0x005911AC
		// (set) Token: 0x06028C81 RID: 167041 RVA: 0x00592FB4 File Offset: 0x005911B4
		public IPlayFlowT Content { get; set; }

		// Token: 0x1700B3BD RID: 46013
		// (get) Token: 0x06028C82 RID: 167042 RVA: 0x00592FBD File Offset: 0x005911BD
		// (set) Token: 0x06028C83 RID: 167043 RVA: 0x00592FC5 File Offset: 0x005911C5
		public int FontSize { get; set; }

		// Token: 0x1700B3BE RID: 46014
		// (get) Token: 0x06028C84 RID: 167044 RVA: 0x00592FCE File Offset: 0x005911CE
		// (set) Token: 0x06028C85 RID: 167045 RVA: 0x00592FD6 File Offset: 0x005911D6
		public float BoxWidth { get; set; }

		// Token: 0x1700B3BF RID: 46015
		// (get) Token: 0x06028C86 RID: 167046 RVA: 0x00592FDF File Offset: 0x005911DF
		// (set) Token: 0x06028C87 RID: 167047 RVA: 0x00592FE7 File Offset: 0x005911E7
		public float BoxHeight { get; set; }

		// Token: 0x1700B3C0 RID: 46016
		// (get) Token: 0x06028C88 RID: 167048 RVA: 0x00592FF0 File Offset: 0x005911F0
		// (set) Token: 0x06028C89 RID: 167049 RVA: 0x00592FF8 File Offset: 0x005911F8
		public float Duration { get; set; }

		// Token: 0x1700B3C1 RID: 46017
		// (get) Token: 0x06028C8A RID: 167050 RVA: 0x00593001 File Offset: 0x00591201
		// (set) Token: 0x06028C8B RID: 167051 RVA: 0x00593009 File Offset: 0x00591209
		public bool AutoHide { get; set; }

		// Token: 0x1700B3C2 RID: 46018
		// (get) Token: 0x06028C8C RID: 167052 RVA: 0x00593012 File Offset: 0x00591212
		// (set) Token: 0x06028C8D RID: 167053 RVA: 0x0059301A File Offset: 0x0059121A
		public ESceneTextFadeInEffect FadeInEffect { get; set; }

		// Token: 0x1700B3C3 RID: 46019
		// (get) Token: 0x06028C8E RID: 167054 RVA: 0x00593023 File Offset: 0x00591223
		// (set) Token: 0x06028C8F RID: 167055 RVA: 0x0059302B File Offset: 0x0059122B
		public ESceneTextFadeOutEffect FadeOutEffect { get; set; }

		// Token: 0x1700B3C4 RID: 46020
		// (get) Token: 0x06028C90 RID: 167056 RVA: 0x00593034 File Offset: 0x00591234
		// (set) Token: 0x06028C91 RID: 167057 RVA: 0x0059303C File Offset: 0x0059123C
		public byte NullMask { get; set; }

		// Token: 0x06028C92 RID: 167058 RVA: 0x00593048 File Offset: 0x00591248
		public ISceneTextSubtitleWithVoiceT()
		{
			this.Type = ESceneTextType.SubtitleWithVoice;
			this.Content = null;
			this.FontSize = 0;
			this.BoxWidth = 0f;
			this.BoxHeight = 0f;
			this.Duration = 0f;
			this.AutoHide = false;
			this.FadeInEffect = ESceneTextFadeInEffect.None;
			this.FadeOutEffect = ESceneTextFadeOutEffect.None;
			this.NullMask = 0;
		}
	}
}

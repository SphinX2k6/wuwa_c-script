using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007494 RID: 29844
	public class ITuningStandT
	{
		// Token: 0x1700E298 RID: 58008
		// (get) Token: 0x060363F2 RID: 222194 RVA: 0x0075FEFC File Offset: 0x0075E0FC
		// (set) Token: 0x060363F3 RID: 222195 RVA: 0x0075FF04 File Offset: 0x0075E104
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700E299 RID: 58009
		// (get) Token: 0x060363F4 RID: 222196 RVA: 0x0075FF0D File Offset: 0x0075E10D
		// (set) Token: 0x060363F5 RID: 222197 RVA: 0x0075FF15 File Offset: 0x0075E115
		public ETuningStandVisualType VisualType { get; set; }

		// Token: 0x1700E29A RID: 58010
		// (get) Token: 0x060363F6 RID: 222198 RVA: 0x0075FF1E File Offset: 0x0075E11E
		// (set) Token: 0x060363F7 RID: 222199 RVA: 0x0075FF26 File Offset: 0x0075E126
		public List<ITuningStandBubbleConfigT> BubbleConfig { get; set; }

		// Token: 0x1700E29B RID: 58011
		// (get) Token: 0x060363F8 RID: 222200 RVA: 0x0075FF2F File Offset: 0x0075E12F
		// (set) Token: 0x060363F9 RID: 222201 RVA: 0x0075FF37 File Offset: 0x0075E137
		public string GuidancePath { get; set; }

		// Token: 0x1700E29C RID: 58012
		// (get) Token: 0x060363FA RID: 222202 RVA: 0x0075FF40 File Offset: 0x0075E140
		// (set) Token: 0x060363FB RID: 222203 RVA: 0x0075FF48 File Offset: 0x0075E148
		public string MusicScorePath { get; set; }

		// Token: 0x1700E29D RID: 58013
		// (get) Token: 0x060363FC RID: 222204 RVA: 0x0075FF51 File Offset: 0x0075E151
		// (set) Token: 0x060363FD RID: 222205 RVA: 0x0075FF59 File Offset: 0x0075E159
		public string NoteSequence { get; set; }

		// Token: 0x1700E29E RID: 58014
		// (get) Token: 0x060363FE RID: 222206 RVA: 0x0075FF62 File Offset: 0x0075E162
		// (set) Token: 0x060363FF RID: 222207 RVA: 0x0075FF6A File Offset: 0x0075E16A
		public string CompleteMusic { get; set; }

		// Token: 0x1700E29F RID: 58015
		// (get) Token: 0x06036400 RID: 222208 RVA: 0x0075FF73 File Offset: 0x0075E173
		// (set) Token: 0x06036401 RID: 222209 RVA: 0x0075FF7B File Offset: 0x0075E17B
		public ITuningStandGridBoardT BoardConfig { get; set; }

		// Token: 0x1700E2A0 RID: 58016
		// (get) Token: 0x06036402 RID: 222210 RVA: 0x0075FF84 File Offset: 0x0075E184
		// (set) Token: 0x06036403 RID: 222211 RVA: 0x0075FF8C File Offset: 0x0075E18C
		public byte NullMask { get; set; }

		// Token: 0x06036404 RID: 222212 RVA: 0x0075FF98 File Offset: 0x0075E198
		public ITuningStandT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.VisualType = ETuningStandVisualType.Tuning;
			this.BubbleConfig = null;
			this.GuidancePath = null;
			this.MusicScorePath = null;
			this.NoteSequence = null;
			this.CompleteMusic = null;
			this.BoardConfig = null;
			this.NullMask = 0;
		}
	}
}

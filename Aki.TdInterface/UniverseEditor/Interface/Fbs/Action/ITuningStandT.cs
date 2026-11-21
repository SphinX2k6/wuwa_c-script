using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C87 RID: 31879
	public class ITuningStandT
	{
		// Token: 0x1700EEB7 RID: 61111
		// (get) Token: 0x060397DF RID: 235487 RVA: 0x007C2CB8 File Offset: 0x007C0EB8
		// (set) Token: 0x060397E0 RID: 235488 RVA: 0x007C2CC0 File Offset: 0x007C0EC0
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700EEB8 RID: 61112
		// (get) Token: 0x060397E1 RID: 235489 RVA: 0x007C2CC9 File Offset: 0x007C0EC9
		// (set) Token: 0x060397E2 RID: 235490 RVA: 0x007C2CD1 File Offset: 0x007C0ED1
		public ETuningStandVisualType VisualType { get; set; }

		// Token: 0x1700EEB9 RID: 61113
		// (get) Token: 0x060397E3 RID: 235491 RVA: 0x007C2CDA File Offset: 0x007C0EDA
		// (set) Token: 0x060397E4 RID: 235492 RVA: 0x007C2CE2 File Offset: 0x007C0EE2
		public List<ITuningStandBubbleConfigT> BubbleConfig { get; set; }

		// Token: 0x1700EEBA RID: 61114
		// (get) Token: 0x060397E5 RID: 235493 RVA: 0x007C2CEB File Offset: 0x007C0EEB
		// (set) Token: 0x060397E6 RID: 235494 RVA: 0x007C2CF3 File Offset: 0x007C0EF3
		public string GuidancePath { get; set; }

		// Token: 0x1700EEBB RID: 61115
		// (get) Token: 0x060397E7 RID: 235495 RVA: 0x007C2CFC File Offset: 0x007C0EFC
		// (set) Token: 0x060397E8 RID: 235496 RVA: 0x007C2D04 File Offset: 0x007C0F04
		public string MusicScorePath { get; set; }

		// Token: 0x1700EEBC RID: 61116
		// (get) Token: 0x060397E9 RID: 235497 RVA: 0x007C2D0D File Offset: 0x007C0F0D
		// (set) Token: 0x060397EA RID: 235498 RVA: 0x007C2D15 File Offset: 0x007C0F15
		public string NoteSequence { get; set; }

		// Token: 0x1700EEBD RID: 61117
		// (get) Token: 0x060397EB RID: 235499 RVA: 0x007C2D1E File Offset: 0x007C0F1E
		// (set) Token: 0x060397EC RID: 235500 RVA: 0x007C2D26 File Offset: 0x007C0F26
		public string CompleteMusic { get; set; }

		// Token: 0x1700EEBE RID: 61118
		// (get) Token: 0x060397ED RID: 235501 RVA: 0x007C2D2F File Offset: 0x007C0F2F
		// (set) Token: 0x060397EE RID: 235502 RVA: 0x007C2D37 File Offset: 0x007C0F37
		public ITuningStandGridBoardT BoardConfig { get; set; }

		// Token: 0x1700EEBF RID: 61119
		// (get) Token: 0x060397EF RID: 235503 RVA: 0x007C2D40 File Offset: 0x007C0F40
		// (set) Token: 0x060397F0 RID: 235504 RVA: 0x007C2D48 File Offset: 0x007C0F48
		public byte NullMask { get; set; }

		// Token: 0x060397F1 RID: 235505 RVA: 0x007C2D54 File Offset: 0x007C0F54
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

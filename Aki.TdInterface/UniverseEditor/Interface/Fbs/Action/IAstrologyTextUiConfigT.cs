using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061AA RID: 25002
	public class IAstrologyTextUiConfigT
	{
		// Token: 0x1700BA61 RID: 47713
		// (get) Token: 0x0602B12C RID: 176428 RVA: 0x005F0AE8 File Offset: 0x005EECE8
		// (set) Token: 0x0602B12D RID: 176429 RVA: 0x005F0AF0 File Offset: 0x005EECF0
		public ETextUiType Type { get; set; }

		// Token: 0x1700BA62 RID: 47714
		// (get) Token: 0x0602B12E RID: 176430 RVA: 0x005F0AF9 File Offset: 0x005EECF9
		// (set) Token: 0x0602B12F RID: 176431 RVA: 0x005F0B01 File Offset: 0x005EED01
		public string InitTipText { get; set; }

		// Token: 0x1700BA63 RID: 47715
		// (get) Token: 0x0602B130 RID: 176432 RVA: 0x005F0B0A File Offset: 0x005EED0A
		// (set) Token: 0x0602B131 RID: 176433 RVA: 0x005F0B12 File Offset: 0x005EED12
		public string ProgressTipText { get; set; }

		// Token: 0x1700BA64 RID: 47716
		// (get) Token: 0x0602B132 RID: 176434 RVA: 0x005F0B1B File Offset: 0x005EED1B
		// (set) Token: 0x0602B133 RID: 176435 RVA: 0x005F0B23 File Offset: 0x005EED23
		public string SkipText { get; set; }

		// Token: 0x1700BA65 RID: 47717
		// (get) Token: 0x0602B134 RID: 176436 RVA: 0x005F0B2C File Offset: 0x005EED2C
		// (set) Token: 0x0602B135 RID: 176437 RVA: 0x005F0B34 File Offset: 0x005EED34
		public string FinishText { get; set; }

		// Token: 0x1700BA66 RID: 47718
		// (get) Token: 0x0602B136 RID: 176438 RVA: 0x005F0B3D File Offset: 0x005EED3D
		// (set) Token: 0x0602B137 RID: 176439 RVA: 0x005F0B45 File Offset: 0x005EED45
		public List<string> InitDialogues { get; set; }

		// Token: 0x1700BA67 RID: 47719
		// (get) Token: 0x0602B138 RID: 176440 RVA: 0x005F0B4E File Offset: 0x005EED4E
		// (set) Token: 0x0602B139 RID: 176441 RVA: 0x005F0B56 File Offset: 0x005EED56
		public int SkipConfirmBoxId { get; set; }

		// Token: 0x1700BA68 RID: 47720
		// (get) Token: 0x0602B13A RID: 176442 RVA: 0x005F0B5F File Offset: 0x005EED5F
		// (set) Token: 0x0602B13B RID: 176443 RVA: 0x005F0B67 File Offset: 0x005EED67
		public string LoopAudioEvent { get; set; }

		// Token: 0x1700BA69 RID: 47721
		// (get) Token: 0x0602B13C RID: 176444 RVA: 0x005F0B70 File Offset: 0x005EED70
		// (set) Token: 0x0602B13D RID: 176445 RVA: 0x005F0B78 File Offset: 0x005EED78
		public byte NullMask { get; set; }

		// Token: 0x0602B13E RID: 176446 RVA: 0x005F0B84 File Offset: 0x005EED84
		public IAstrologyTextUiConfigT()
		{
			this.Type = ETextUiType.Astrology;
			this.InitTipText = null;
			this.ProgressTipText = null;
			this.SkipText = null;
			this.FinishText = null;
			this.InitDialogues = null;
			this.SkipConfirmBoxId = 0;
			this.LoopAudioEvent = null;
			this.NullMask = 0;
		}
	}
}

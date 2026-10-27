using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064A2 RID: 25762
	public class ICommonTipMissionCompleteT
	{
		// Token: 0x1700BFB6 RID: 49078
		// (get) Token: 0x0602CA72 RID: 182898 RVA: 0x006214EC File Offset: 0x0061F6EC
		// (set) Token: 0x0602CA73 RID: 182899 RVA: 0x006214F4 File Offset: 0x0061F6F4
		public ECommonTipType Type { get; set; }

		// Token: 0x1700BFB7 RID: 49079
		// (get) Token: 0x0602CA74 RID: 182900 RVA: 0x006214FD File Offset: 0x0061F6FD
		// (set) Token: 0x0602CA75 RID: 182901 RVA: 0x00621505 File Offset: 0x0061F705
		public string TidMainText { get; set; }

		// Token: 0x1700BFB8 RID: 49080
		// (get) Token: 0x0602CA76 RID: 182902 RVA: 0x0062150E File Offset: 0x0061F70E
		// (set) Token: 0x0602CA77 RID: 182903 RVA: 0x00621516 File Offset: 0x0061F716
		public string TidSubText { get; set; }

		// Token: 0x0602CA78 RID: 182904 RVA: 0x0062151F File Offset: 0x0061F71F
		public ICommonTipMissionCompleteT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.TidMainText = null;
			this.TidSubText = null;
		}
	}
}

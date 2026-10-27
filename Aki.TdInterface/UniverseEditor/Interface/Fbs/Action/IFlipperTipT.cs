using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067E4 RID: 26596
	public class IFlipperTipT
	{
		// Token: 0x1700C564 RID: 50532
		// (get) Token: 0x0602E4D5 RID: 189653 RVA: 0x00652574 File Offset: 0x00650774
		// (set) Token: 0x0602E4D6 RID: 189654 RVA: 0x0065257C File Offset: 0x0065077C
		public ECommonTipType Type { get; set; }

		// Token: 0x1700C565 RID: 50533
		// (get) Token: 0x0602E4D7 RID: 189655 RVA: 0x00652585 File Offset: 0x00650785
		// (set) Token: 0x0602E4D8 RID: 189656 RVA: 0x0065258D File Offset: 0x0065078D
		public string TidMainText { get; set; }

		// Token: 0x1700C566 RID: 50534
		// (get) Token: 0x0602E4D9 RID: 189657 RVA: 0x00652596 File Offset: 0x00650796
		// (set) Token: 0x0602E4DA RID: 189658 RVA: 0x0065259E File Offset: 0x0065079E
		public string TidSubText { get; set; }

		// Token: 0x0602E4DB RID: 189659 RVA: 0x006525A7 File Offset: 0x006507A7
		public IFlipperTipT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.TidMainText = null;
			this.TidSubText = null;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C7E RID: 27774
	public class IDreamlessWarningT
	{
		// Token: 0x1700CBBB RID: 52155
		// (get) Token: 0x0602FDA2 RID: 196002 RVA: 0x00684243 File Offset: 0x00682443
		// (set) Token: 0x0602FDA3 RID: 196003 RVA: 0x0068424B File Offset: 0x0068244B
		public ECommonTipType Type { get; set; }

		// Token: 0x1700CBBC RID: 52156
		// (get) Token: 0x0602FDA4 RID: 196004 RVA: 0x00684254 File Offset: 0x00682454
		// (set) Token: 0x0602FDA5 RID: 196005 RVA: 0x0068425C File Offset: 0x0068245C
		public string WarningText { get; set; }

		// Token: 0x0602FDA6 RID: 196006 RVA: 0x00684265 File Offset: 0x00682465
		public IDreamlessWarningT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.WarningText = null;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006234 RID: 25140
	public class IBubbleRangeCylinderConfigT
	{
		// Token: 0x1700BB55 RID: 47957
		// (get) Token: 0x0602B56A RID: 177514 RVA: 0x005F7A2A File Offset: 0x005F5C2A
		// (set) Token: 0x0602B56B RID: 177515 RVA: 0x005F7A32 File Offset: 0x005F5C32
		public IBubbleCylinderConfigT InnerConfig { get; set; }

		// Token: 0x1700BB56 RID: 47958
		// (get) Token: 0x0602B56C RID: 177516 RVA: 0x005F7A3B File Offset: 0x005F5C3B
		// (set) Token: 0x0602B56D RID: 177517 RVA: 0x005F7A43 File Offset: 0x005F5C43
		public IBubbleCylinderConfigT OuterConfig { get; set; }

		// Token: 0x0602B56E RID: 177518 RVA: 0x005F7A4C File Offset: 0x005F5C4C
		public IBubbleRangeCylinderConfigT()
		{
			this.InnerConfig = null;
			this.OuterConfig = null;
		}
	}
}

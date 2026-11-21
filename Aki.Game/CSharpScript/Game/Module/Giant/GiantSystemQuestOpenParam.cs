using System;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Giant
{
	// Token: 0x02004942 RID: 18754
	public class GiantSystemQuestOpenParam : IGiantSystemQuestOpenParam
	{
		// Token: 0x17005EFD RID: 24317
		// (get) Token: 0x0602F04C RID: 192588 RVA: 0x00D1CACA File Offset: 0x00D1ACCA
		// (set) Token: 0x0602F04D RID: 192589 RVA: 0x00D1CAD2 File Offset: 0x00D1ACD2
		public GiantEcoNetType EcoType { get; set; }

		// Token: 0x17005EFE RID: 24318
		// (get) Token: 0x0602F04E RID: 192590 RVA: 0x00D1CADB File Offset: 0x00D1ACDB
		// (set) Token: 0x0602F04F RID: 192591 RVA: 0x00D1CAE3 File Offset: 0x00D1ACE3
		public bool? GuideOnly { get; set; }
	}
}

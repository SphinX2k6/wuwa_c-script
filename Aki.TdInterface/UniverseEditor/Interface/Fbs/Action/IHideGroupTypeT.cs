using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F99 RID: 28569
	public class IHideGroupTypeT
	{
		// Token: 0x1700D144 RID: 53572
		// (get) Token: 0x0603175D RID: 202589 RVA: 0x006B48A6 File Offset: 0x006B2AA6
		// (set) Token: 0x0603175E RID: 202590 RVA: 0x006B48AE File Offset: 0x006B2AAE
		public EHideType Type { get; set; }

		// Token: 0x0603175F RID: 202591 RVA: 0x006B48B7 File Offset: 0x006B2AB7
		public IHideGroupTypeT()
		{
			this.Type = EHideType.WorldMonsterAndMonsterTreasure;
		}
	}
}

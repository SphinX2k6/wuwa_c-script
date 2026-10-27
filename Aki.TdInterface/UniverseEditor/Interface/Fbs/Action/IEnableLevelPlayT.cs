using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006670 RID: 26224
	public class IEnableLevelPlayT
	{
		// Token: 0x1700C2D0 RID: 49872
		// (get) Token: 0x0602D8F7 RID: 186615 RVA: 0x0063CE01 File Offset: 0x0063B001
		// (set) Token: 0x0602D8F8 RID: 186616 RVA: 0x0063CE09 File Offset: 0x0063B009
		public List<IEnableLevelPlayConfigT> Configs { get; set; }

		// Token: 0x1700C2D1 RID: 49873
		// (get) Token: 0x0602D8F9 RID: 186617 RVA: 0x0063CE12 File Offset: 0x0063B012
		// (set) Token: 0x0602D8FA RID: 186618 RVA: 0x0063CE1A File Offset: 0x0063B01A
		public EPlayerType TargetPlayer { get; set; }

		// Token: 0x1700C2D2 RID: 49874
		// (get) Token: 0x0602D8FB RID: 186619 RVA: 0x0063CE23 File Offset: 0x0063B023
		// (set) Token: 0x0602D8FC RID: 186620 RVA: 0x0063CE2B File Offset: 0x0063B02B
		public byte NullMask { get; set; }

		// Token: 0x0602D8FD RID: 186621 RVA: 0x0063CE34 File Offset: 0x0063B034
		public IEnableLevelPlayT()
		{
			this.Configs = null;
			this.TargetPlayer = EPlayerType.P1;
			this.NullMask = 0;
		}
	}
}

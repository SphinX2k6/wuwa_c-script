using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FC0 RID: 28608
	public class IHideWorldEntityAndLevelPlayT
	{
		// Token: 0x1700D18B RID: 53643
		// (get) Token: 0x060318C0 RID: 202944 RVA: 0x006B6F55 File Offset: 0x006B5155
		// (set) Token: 0x060318C1 RID: 202945 RVA: 0x006B6F5D File Offset: 0x006B515D
		public EHideType Type { get; set; }

		// Token: 0x1700D18C RID: 53644
		// (get) Token: 0x060318C2 RID: 202946 RVA: 0x006B6F66 File Offset: 0x006B5166
		// (set) Token: 0x060318C3 RID: 202947 RVA: 0x006B6F6E File Offset: 0x006B516E
		public List<int> ExcludeEntities { get; set; }

		// Token: 0x1700D18D RID: 53645
		// (get) Token: 0x060318C4 RID: 202948 RVA: 0x006B6F77 File Offset: 0x006B5177
		// (set) Token: 0x060318C5 RID: 202949 RVA: 0x006B6F7F File Offset: 0x006B517F
		public byte NullMask { get; set; }

		// Token: 0x060318C6 RID: 202950 RVA: 0x006B6F88 File Offset: 0x006B5188
		public IHideWorldEntityAndLevelPlayT()
		{
			this.Type = EHideType.WorldMonsterAndMonsterTreasure;
			this.ExcludeEntities = null;
			this.NullMask = 0;
		}
	}
}

using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007852 RID: 30802
	public class ISetTargetElementalAbilityT
	{
		// Token: 0x1700E1F4 RID: 57844
		// (get) Token: 0x060362C3 RID: 221891 RVA: 0x00741D8F File Offset: 0x0073FF8F
		// (set) Token: 0x060362C4 RID: 221892 RVA: 0x00741D97 File Offset: 0x0073FF97
		public TTargetEntityUnion Target { get; set; }

		// Token: 0x1700E1F5 RID: 57845
		// (get) Token: 0x060362C5 RID: 221893 RVA: 0x00741DA0 File Offset: 0x0073FFA0
		// (set) Token: 0x060362C6 RID: 221894 RVA: 0x00741DA8 File Offset: 0x0073FFA8
		public EElementalType ElementalType { get; set; }

		// Token: 0x1700E1F6 RID: 57846
		// (get) Token: 0x060362C7 RID: 221895 RVA: 0x00741DB1 File Offset: 0x0073FFB1
		// (set) Token: 0x060362C8 RID: 221896 RVA: 0x00741DB9 File Offset: 0x0073FFB9
		public EElementalOpType OpType { get; set; }

		// Token: 0x1700E1F7 RID: 57847
		// (get) Token: 0x060362C9 RID: 221897 RVA: 0x00741DC2 File Offset: 0x0073FFC2
		// (set) Token: 0x060362CA RID: 221898 RVA: 0x00741DCA File Offset: 0x0073FFCA
		public int Priority { get; set; }

		// Token: 0x060362CB RID: 221899 RVA: 0x00741DD3 File Offset: 0x0073FFD3
		public ISetTargetElementalAbilityT()
		{
			this.Target = null;
			this.ElementalType = EElementalType.Fire;
			this.OpType = EElementalOpType.Grant;
			this.Priority = 0;
		}
	}
}

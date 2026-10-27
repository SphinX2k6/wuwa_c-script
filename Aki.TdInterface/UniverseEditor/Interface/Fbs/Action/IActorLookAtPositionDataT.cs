using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060EA RID: 24810
	public class IActorLookAtPositionDataT
	{
		// Token: 0x1700B6DE RID: 46814
		// (get) Token: 0x0602A626 RID: 173606 RVA: 0x005D726F File Offset: 0x005D546F
		// (set) Token: 0x0602A627 RID: 173607 RVA: 0x005D7277 File Offset: 0x005D5477
		public EActorLookAtMode Type { get; set; }

		// Token: 0x1700B6DF RID: 46815
		// (get) Token: 0x0602A628 RID: 173608 RVA: 0x005D7280 File Offset: 0x005D5480
		// (set) Token: 0x0602A629 RID: 173609 RVA: 0x005D7288 File Offset: 0x005D5488
		public bool Lock { get; set; }

		// Token: 0x1700B6E0 RID: 46816
		// (get) Token: 0x0602A62A RID: 173610 RVA: 0x005D7291 File Offset: 0x005D5491
		// (set) Token: 0x0602A62B RID: 173611 RVA: 0x005D7299 File Offset: 0x005D5499
		public IVectorInfoT Pos { get; set; }

		// Token: 0x1700B6E1 RID: 46817
		// (get) Token: 0x0602A62C RID: 173612 RVA: 0x005D72A2 File Offset: 0x005D54A2
		// (set) Token: 0x0602A62D RID: 173613 RVA: 0x005D72AA File Offset: 0x005D54AA
		public byte NullMask { get; set; }

		// Token: 0x0602A62E RID: 173614 RVA: 0x005D72B3 File Offset: 0x005D54B3
		public IActorLookAtPositionDataT()
		{
			this.Type = EActorLookAtMode.Talker;
			this.Lock = false;
			this.Pos = null;
			this.NullMask = 0;
		}
	}
}

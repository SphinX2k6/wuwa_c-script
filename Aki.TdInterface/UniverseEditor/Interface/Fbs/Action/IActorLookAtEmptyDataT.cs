using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060DB RID: 24795
	public class IActorLookAtEmptyDataT
	{
		// Token: 0x1700B6B6 RID: 46774
		// (get) Token: 0x0602A59A RID: 173466 RVA: 0x005D63AA File Offset: 0x005D45AA
		// (set) Token: 0x0602A59B RID: 173467 RVA: 0x005D63B2 File Offset: 0x005D45B2
		public EActorLookAtMode Type { get; set; }

		// Token: 0x1700B6B7 RID: 46775
		// (get) Token: 0x0602A59C RID: 173468 RVA: 0x005D63BB File Offset: 0x005D45BB
		// (set) Token: 0x0602A59D RID: 173469 RVA: 0x005D63C3 File Offset: 0x005D45C3
		public bool Lock { get; set; }

		// Token: 0x1700B6B8 RID: 46776
		// (get) Token: 0x0602A59E RID: 173470 RVA: 0x005D63CC File Offset: 0x005D45CC
		// (set) Token: 0x0602A59F RID: 173471 RVA: 0x005D63D4 File Offset: 0x005D45D4
		public byte NullMask { get; set; }

		// Token: 0x0602A5A0 RID: 173472 RVA: 0x005D63DD File Offset: 0x005D45DD
		public IActorLookAtEmptyDataT()
		{
			this.Type = EActorLookAtMode.Talker;
			this.Lock = false;
			this.NullMask = 0;
		}
	}
}

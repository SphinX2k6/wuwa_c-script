using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052B3 RID: 21171
	public class IFollowTrackToFoundationT
	{
		// Token: 0x17009B3F RID: 39743
		// (get) Token: 0x06022849 RID: 141385 RVA: 0x004C8DF9 File Offset: 0x004C6FF9
		// (set) Token: 0x0602284A RID: 141386 RVA: 0x004C8E01 File Offset: 0x004C7001
		public EFollowTrackEndType Type { get; set; }

		// Token: 0x17009B40 RID: 39744
		// (get) Token: 0x0602284B RID: 141387 RVA: 0x004C8E0A File Offset: 0x004C700A
		// (set) Token: 0x0602284C RID: 141388 RVA: 0x004C8E12 File Offset: 0x004C7012
		public int FoundationId { get; set; }

		// Token: 0x17009B41 RID: 39745
		// (get) Token: 0x0602284D RID: 141389 RVA: 0x004C8E1B File Offset: 0x004C701B
		// (set) Token: 0x0602284E RID: 141390 RVA: 0x004C8E23 File Offset: 0x004C7023
		public IVectorInfoT FinalOffset { get; set; }

		// Token: 0x0602284F RID: 141391 RVA: 0x004C8E2C File Offset: 0x004C702C
		public IFollowTrackToFoundationT()
		{
			this.Type = EFollowTrackEndType.ToStart;
			this.FoundationId = 0;
			this.FinalOffset = null;
		}
	}
}

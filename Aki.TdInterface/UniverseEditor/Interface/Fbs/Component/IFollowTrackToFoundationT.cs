using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200581E RID: 22558
	public class IFollowTrackToFoundationT
	{
		// Token: 0x1700A348 RID: 41800
		// (get) Token: 0x0602480D RID: 149517 RVA: 0x00503EF5 File Offset: 0x005020F5
		// (set) Token: 0x0602480E RID: 149518 RVA: 0x00503EFD File Offset: 0x005020FD
		public EFollowTrackEndType Type { get; set; }

		// Token: 0x1700A349 RID: 41801
		// (get) Token: 0x0602480F RID: 149519 RVA: 0x00503F06 File Offset: 0x00502106
		// (set) Token: 0x06024810 RID: 149520 RVA: 0x00503F0E File Offset: 0x0050210E
		public int FoundationId { get; set; }

		// Token: 0x1700A34A RID: 41802
		// (get) Token: 0x06024811 RID: 149521 RVA: 0x00503F17 File Offset: 0x00502117
		// (set) Token: 0x06024812 RID: 149522 RVA: 0x00503F1F File Offset: 0x0050211F
		public IVectorInfoT FinalOffset { get; set; }

		// Token: 0x06024813 RID: 149523 RVA: 0x00503F28 File Offset: 0x00502128
		public IFollowTrackToFoundationT()
		{
			this.Type = EFollowTrackEndType.ToStart;
			this.FoundationId = 0;
			this.FinalOffset = null;
		}
	}
}

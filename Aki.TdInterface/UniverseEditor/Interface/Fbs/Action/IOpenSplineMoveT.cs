using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C34 RID: 27700
	public class IOpenSplineMoveT
	{
		// Token: 0x1700CE15 RID: 52757
		// (get) Token: 0x06030BF9 RID: 199673 RVA: 0x0069ED37 File Offset: 0x0069CF37
		// (set) Token: 0x06030BFA RID: 199674 RVA: 0x0069ED3F File Offset: 0x0069CF3F
		public ESplineMoveConfigType Type { get; set; }

		// Token: 0x1700CE16 RID: 52758
		// (get) Token: 0x06030BFB RID: 199675 RVA: 0x0069ED48 File Offset: 0x0069CF48
		// (set) Token: 0x06030BFC RID: 199676 RVA: 0x0069ED50 File Offset: 0x0069CF50
		public TTargetEntityUnion Target { get; set; }

		// Token: 0x1700CE17 RID: 52759
		// (get) Token: 0x06030BFD RID: 199677 RVA: 0x0069ED59 File Offset: 0x0069CF59
		// (set) Token: 0x06030BFE RID: 199678 RVA: 0x0069ED61 File Offset: 0x0069CF61
		public int SplineEntityId { get; set; }

		// Token: 0x1700CE18 RID: 52760
		// (get) Token: 0x06030BFF RID: 199679 RVA: 0x0069ED6A File Offset: 0x0069CF6A
		// (set) Token: 0x06030C00 RID: 199680 RVA: 0x0069ED72 File Offset: 0x0069CF72
		public TSplineMovePatternUnion Pattern { get; set; }

		// Token: 0x06030C01 RID: 199681 RVA: 0x0069ED7B File Offset: 0x0069CF7B
		public IOpenSplineMoveT()
		{
			this.Type = ESplineMoveConfigType.Open;
			this.Target = null;
			this.SplineEntityId = 0;
			this.Pattern = null;
		}
	}
}

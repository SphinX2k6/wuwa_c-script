using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073F2 RID: 29682
	public class IPerformerAiMoveToPositionT
	{
		// Token: 0x1700DA08 RID: 55816
		// (get) Token: 0x06033ECE RID: 212686 RVA: 0x00700373 File Offset: 0x006FE573
		// (set) Token: 0x06033ECF RID: 212687 RVA: 0x0070037B File Offset: 0x006FE57B
		public EPerformerAiMoveToType Type { get; set; }

		// Token: 0x1700DA09 RID: 55817
		// (get) Token: 0x06033ED0 RID: 212688 RVA: 0x00700384 File Offset: 0x006FE584
		// (set) Token: 0x06033ED1 RID: 212689 RVA: 0x0070038C File Offset: 0x006FE58C
		public IVectorInfoT Destination { get; set; }

		// Token: 0x06033ED2 RID: 212690 RVA: 0x00700395 File Offset: 0x006FE595
		public IPerformerAiMoveToPositionT()
		{
			this.Type = EPerformerAiMoveToType.Position;
			this.Destination = null;
		}
	}
}

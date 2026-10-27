using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C8B RID: 27787
	public class IPerformerAiMoveToPositionT
	{
		// Token: 0x1700CEED RID: 52973
		// (get) Token: 0x06030F73 RID: 200563 RVA: 0x006A5E73 File Offset: 0x006A4073
		// (set) Token: 0x06030F74 RID: 200564 RVA: 0x006A5E7B File Offset: 0x006A407B
		public EPerformerAiMoveToType Type { get; set; }

		// Token: 0x1700CEEE RID: 52974
		// (get) Token: 0x06030F75 RID: 200565 RVA: 0x006A5E84 File Offset: 0x006A4084
		// (set) Token: 0x06030F76 RID: 200566 RVA: 0x006A5E8C File Offset: 0x006A408C
		public IVectorInfoT Destination { get; set; }

		// Token: 0x06030F77 RID: 200567 RVA: 0x006A5E95 File Offset: 0x006A4095
		public IPerformerAiMoveToPositionT()
		{
			this.Type = EPerformerAiMoveToType.Position;
			this.Destination = null;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200735F RID: 29535
	public class ITargetEntityTypeT
	{
		// Token: 0x1700E04C RID: 57420
		// (get) Token: 0x060359BE RID: 219582 RVA: 0x0074D0AE File Offset: 0x0074B2AE
		// (set) Token: 0x060359BF RID: 219583 RVA: 0x0074D0B6 File Offset: 0x0074B2B6
		public ETargetEntityType Type { get; set; }

		// Token: 0x060359C0 RID: 219584 RVA: 0x0074D0BF File Offset: 0x0074B2BF
		public ITargetEntityTypeT()
		{
			this.Type = ETargetEntityType.Target;
		}
	}
}

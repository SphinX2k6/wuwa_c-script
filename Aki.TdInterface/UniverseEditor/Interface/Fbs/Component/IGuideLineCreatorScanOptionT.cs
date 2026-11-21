using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058E3 RID: 22755
	public class IGuideLineCreatorScanOptionT
	{
		// Token: 0x1700A506 RID: 42246
		// (get) Token: 0x06024F56 RID: 151382 RVA: 0x00512E5E File Offset: 0x0051105E
		// (set) Token: 0x06024F57 RID: 151383 RVA: 0x00512E66 File Offset: 0x00511066
		public int ResponseRange { get; set; }

		// Token: 0x06024F58 RID: 151384 RVA: 0x00512E6F File Offset: 0x0051106F
		public IGuideLineCreatorScanOptionT()
		{
			this.ResponseRange = 0;
		}
	}
}

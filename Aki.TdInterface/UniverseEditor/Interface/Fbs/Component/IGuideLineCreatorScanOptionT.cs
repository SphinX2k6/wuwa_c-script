using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200535D RID: 21341
	public class IGuideLineCreatorScanOptionT
	{
		// Token: 0x17009CCE RID: 40142
		// (get) Token: 0x06022EA2 RID: 143010 RVA: 0x004D5F8A File Offset: 0x004D418A
		// (set) Token: 0x06022EA3 RID: 143011 RVA: 0x004D5F92 File Offset: 0x004D4192
		public int ResponseRange { get; set; }

		// Token: 0x06022EA4 RID: 143012 RVA: 0x004D5F9B File Offset: 0x004D419B
		public IGuideLineCreatorScanOptionT()
		{
			this.ResponseRange = 0;
		}
	}
}

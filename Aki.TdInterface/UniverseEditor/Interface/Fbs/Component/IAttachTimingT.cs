using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EC3 RID: 20163
	public class IAttachTimingT
	{
		// Token: 0x170090A8 RID: 37032
		// (get) Token: 0x0601FC2D RID: 130093 RVA: 0x0046BD3A File Offset: 0x00469F3A
		// (set) Token: 0x0601FC2E RID: 130094 RVA: 0x0046BD42 File Offset: 0x00469F42
		public EAttachTimingType Type { get; set; }

		// Token: 0x0601FC2F RID: 130095 RVA: 0x0046BD4B File Offset: 0x00469F4B
		public IAttachTimingT()
		{
			this.Type = EAttachTimingType.Default;
		}
	}
}

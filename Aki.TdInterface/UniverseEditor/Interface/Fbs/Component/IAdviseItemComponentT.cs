using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200537D RID: 21373
	public class IAdviseItemComponentT
	{
		// Token: 0x170096F0 RID: 38640
		// (get) Token: 0x060214C3 RID: 136387 RVA: 0x00498228 File Offset: 0x00496428
		// (set) Token: 0x060214C4 RID: 136388 RVA: 0x00498230 File Offset: 0x00496430
		public bool Disabled { get; set; }

		// Token: 0x170096F1 RID: 38641
		// (get) Token: 0x060214C5 RID: 136389 RVA: 0x00498239 File Offset: 0x00496439
		// (set) Token: 0x060214C6 RID: 136390 RVA: 0x00498241 File Offset: 0x00496441
		public byte NullMask { get; set; }

		// Token: 0x060214C7 RID: 136391 RVA: 0x0049824A File Offset: 0x0049644A
		public IAdviseItemComponentT()
		{
			this.Disabled = false;
			this.NullMask = 0;
		}
	}
}

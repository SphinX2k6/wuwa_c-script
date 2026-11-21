using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077B3 RID: 30643
	public class ISetEntityVisibleT
	{
		// Token: 0x1700E093 RID: 57491
		// (get) Token: 0x06035CF8 RID: 220408 RVA: 0x007356D3 File Offset: 0x007338D3
		// (set) Token: 0x06035CF9 RID: 220409 RVA: 0x007356DB File Offset: 0x007338DB
		public List<int> EntityIds { get; set; }

		// Token: 0x1700E094 RID: 57492
		// (get) Token: 0x06035CFA RID: 220410 RVA: 0x007356E4 File Offset: 0x007338E4
		// (set) Token: 0x06035CFB RID: 220411 RVA: 0x007356EC File Offset: 0x007338EC
		public bool Visible { get; set; }

		// Token: 0x1700E095 RID: 57493
		// (get) Token: 0x06035CFC RID: 220412 RVA: 0x007356F5 File Offset: 0x007338F5
		// (set) Token: 0x06035CFD RID: 220413 RVA: 0x007356FD File Offset: 0x007338FD
		public bool PerformDestroy { get; set; }

		// Token: 0x1700E096 RID: 57494
		// (get) Token: 0x06035CFE RID: 220414 RVA: 0x00735706 File Offset: 0x00733906
		// (set) Token: 0x06035CFF RID: 220415 RVA: 0x0073570E File Offset: 0x0073390E
		public byte NullMask { get; set; }

		// Token: 0x06035D00 RID: 220416 RVA: 0x00735717 File Offset: 0x00733917
		public ISetEntityVisibleT()
		{
			this.EntityIds = null;
			this.Visible = false;
			this.PerformDestroy = false;
			this.NullMask = 0;
		}
	}
}

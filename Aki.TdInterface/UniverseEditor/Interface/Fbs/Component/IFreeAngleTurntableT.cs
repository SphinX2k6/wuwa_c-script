using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052D7 RID: 21207
	public class IFreeAngleTurntableT
	{
		// Token: 0x17009B99 RID: 39833
		// (get) Token: 0x060229B5 RID: 141749 RVA: 0x004CC06F File Offset: 0x004CA26F
		// (set) Token: 0x060229B6 RID: 141750 RVA: 0x004CC077 File Offset: 0x004CA277
		public EControllerType Type { get; set; }

		// Token: 0x17009B9A RID: 39834
		// (get) Token: 0x060229B7 RID: 141751 RVA: 0x004CC080 File Offset: 0x004CA280
		// (set) Token: 0x060229B8 RID: 141752 RVA: 0x004CC088 File Offset: 0x004CA288
		public int RotationSpeed { get; set; }

		// Token: 0x17009B9B RID: 39835
		// (get) Token: 0x060229B9 RID: 141753 RVA: 0x004CC091 File Offset: 0x004CA291
		// (set) Token: 0x060229BA RID: 141754 RVA: 0x004CC099 File Offset: 0x004CA299
		public List<IFreeAngleItemT> ItemConfig { get; set; }

		// Token: 0x17009B9C RID: 39836
		// (get) Token: 0x060229BB RID: 141755 RVA: 0x004CC0A2 File Offset: 0x004CA2A2
		// (set) Token: 0x060229BC RID: 141756 RVA: 0x004CC0AA File Offset: 0x004CA2AA
		public int IntervalAngle { get; set; }

		// Token: 0x060229BD RID: 141757 RVA: 0x004CC0B3 File Offset: 0x004CA2B3
		public IFreeAngleTurntableT()
		{
			this.Type = EControllerType.FreeAngle;
			this.RotationSpeed = 0;
			this.ItemConfig = null;
			this.IntervalAngle = 0;
		}
	}
}

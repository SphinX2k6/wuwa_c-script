using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058A8 RID: 22696
	public class IGravityFlipComponentT
	{
		// Token: 0x1700A47F RID: 42111
		// (get) Token: 0x06024D22 RID: 150818 RVA: 0x0050E5DB File Offset: 0x0050C7DB
		// (set) Token: 0x06024D23 RID: 150819 RVA: 0x0050E5E3 File Offset: 0x0050C7E3
		public bool Disabled { get; set; }

		// Token: 0x1700A480 RID: 42112
		// (get) Token: 0x06024D24 RID: 150820 RVA: 0x0050E5EC File Offset: 0x0050C7EC
		// (set) Token: 0x06024D25 RID: 150821 RVA: 0x0050E5F4 File Offset: 0x0050C7F4
		public List<IGravityFlipConfigT> Config { get; set; }

		// Token: 0x1700A481 RID: 42113
		// (get) Token: 0x06024D26 RID: 150822 RVA: 0x0050E5FD File Offset: 0x0050C7FD
		// (set) Token: 0x06024D27 RID: 150823 RVA: 0x0050E605 File Offset: 0x0050C805
		public EGravityFlipType DefaultGravity { get; set; }

		// Token: 0x1700A482 RID: 42114
		// (get) Token: 0x06024D28 RID: 150824 RVA: 0x0050E60E File Offset: 0x0050C80E
		// (set) Token: 0x06024D29 RID: 150825 RVA: 0x0050E616 File Offset: 0x0050C816
		public byte NullMask { get; set; }

		// Token: 0x06024D2A RID: 150826 RVA: 0x0050E61F File Offset: 0x0050C81F
		public IGravityFlipComponentT()
		{
			this.Disabled = false;
			this.Config = null;
			this.DefaultGravity = EGravityFlipType.None;
			this.NullMask = 0;
		}
	}
}

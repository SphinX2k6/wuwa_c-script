using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007263 RID: 29283
	public class ISwitchPermissionT
	{
		// Token: 0x1700D944 RID: 55620
		// (get) Token: 0x06033F2C RID: 212780 RVA: 0x006FC9BD File Offset: 0x006FABBD
		// (set) Token: 0x06033F2D RID: 212781 RVA: 0x006FC9C5 File Offset: 0x006FABC5
		public ESwitchSubLevelsType Type { get; set; }

		// Token: 0x1700D945 RID: 55621
		// (get) Token: 0x06033F2E RID: 212782 RVA: 0x006FC9CE File Offset: 0x006FABCE
		// (set) Token: 0x06033F2F RID: 212783 RVA: 0x006FC9D6 File Offset: 0x006FABD6
		public bool IsAllowClientSwitch { get; set; }

		// Token: 0x1700D946 RID: 55622
		// (get) Token: 0x06033F30 RID: 212784 RVA: 0x006FC9DF File Offset: 0x006FABDF
		// (set) Token: 0x06033F31 RID: 212785 RVA: 0x006FC9E7 File Offset: 0x006FABE7
		public List<string> Levels { get; set; }

		// Token: 0x06033F32 RID: 212786 RVA: 0x006FC9F0 File Offset: 0x006FABF0
		public ISwitchPermissionT()
		{
			this.Type = ESwitchSubLevelsType.Directly;
			this.IsAllowClientSwitch = false;
			this.Levels = null;
		}
	}
}

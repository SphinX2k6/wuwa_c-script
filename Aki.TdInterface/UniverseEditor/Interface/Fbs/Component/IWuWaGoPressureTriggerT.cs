using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061E4 RID: 25060
	public class IWuWaGoPressureTriggerT
	{
		// Token: 0x1700BADE RID: 47838
		// (get) Token: 0x0602AA09 RID: 174601 RVA: 0x005D00B6 File Offset: 0x005CE2B6
		// (set) Token: 0x0602AA0A RID: 174602 RVA: 0x005D00BE File Offset: 0x005CE2BE
		public EWuWaGoEntityType Type { get; set; }

		// Token: 0x1700BADF RID: 47839
		// (get) Token: 0x0602AA0B RID: 174603 RVA: 0x005D00C7 File Offset: 0x005CE2C7
		// (set) Token: 0x0602AA0C RID: 174604 RVA: 0x005D00CF File Offset: 0x005CE2CF
		public IWuWaGoGridLinkDataT LinkData { get; set; }

		// Token: 0x1700BAE0 RID: 47840
		// (get) Token: 0x0602AA0D RID: 174605 RVA: 0x005D00D8 File Offset: 0x005CE2D8
		// (set) Token: 0x0602AA0E RID: 174606 RVA: 0x005D00E0 File Offset: 0x005CE2E0
		public List<IActionInfoT> EnterActionList { get; set; }

		// Token: 0x1700BAE1 RID: 47841
		// (get) Token: 0x0602AA0F RID: 174607 RVA: 0x005D00E9 File Offset: 0x005CE2E9
		// (set) Token: 0x0602AA10 RID: 174608 RVA: 0x005D00F1 File Offset: 0x005CE2F1
		public List<IActionInfoT> ExitActionList { get; set; }

		// Token: 0x0602AA11 RID: 174609 RVA: 0x005D00FA File Offset: 0x005CE2FA
		public IWuWaGoPressureTriggerT()
		{
			this.Type = EWuWaGoEntityType.LevelCenter;
			this.LinkData = new IWuWaGoGridLinkDataT();
			this.EnterActionList = null;
			this.ExitActionList = null;
		}
	}
}

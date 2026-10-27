using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050B5 RID: 20661
	public class IDragActorPlayComponentT
	{
		// Token: 0x1700962E RID: 38446
		// (get) Token: 0x06021337 RID: 135991 RVA: 0x0049CD61 File Offset: 0x0049AF61
		// (set) Token: 0x06021338 RID: 135992 RVA: 0x0049CD69 File Offset: 0x0049AF69
		public bool Disabled { get; set; }

		// Token: 0x1700962F RID: 38447
		// (get) Token: 0x06021339 RID: 135993 RVA: 0x0049CD72 File Offset: 0x0049AF72
		// (set) Token: 0x0602133A RID: 135994 RVA: 0x0049CD7A File Offset: 0x0049AF7A
		public List<IDragActorPlayConfigT> Configs { get; set; }

		// Token: 0x17009630 RID: 38448
		// (get) Token: 0x0602133B RID: 135995 RVA: 0x0049CD83 File Offset: 0x0049AF83
		// (set) Token: 0x0602133C RID: 135996 RVA: 0x0049CD8B File Offset: 0x0049AF8B
		public string ExitSendSelfEvent { get; set; }

		// Token: 0x17009631 RID: 38449
		// (get) Token: 0x0602133D RID: 135997 RVA: 0x0049CD94 File Offset: 0x0049AF94
		// (set) Token: 0x0602133E RID: 135998 RVA: 0x0049CD9C File Offset: 0x0049AF9C
		public byte NullMask { get; set; }

		// Token: 0x0602133F RID: 135999 RVA: 0x0049CDA5 File Offset: 0x0049AFA5
		public IDragActorPlayComponentT()
		{
			this.Disabled = false;
			this.Configs = null;
			this.ExitSendSelfEvent = null;
			this.NullMask = 0;
		}
	}
}

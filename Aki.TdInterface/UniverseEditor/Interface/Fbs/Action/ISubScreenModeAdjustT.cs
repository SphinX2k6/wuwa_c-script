using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079E4 RID: 31204
	public class ISubScreenModeAdjustT
	{
		// Token: 0x1700E4C2 RID: 58562
		// (get) Token: 0x06036FB4 RID: 225204 RVA: 0x00759B93 File Offset: 0x00757D93
		// (set) Token: 0x06036FB5 RID: 225205 RVA: 0x00759B9B File Offset: 0x00757D9B
		public ESubScreenOperationType Type { get; set; }

		// Token: 0x1700E4C3 RID: 58563
		// (get) Token: 0x06036FB6 RID: 225206 RVA: 0x00759BA4 File Offset: 0x00757DA4
		// (set) Token: 0x06036FB7 RID: 225207 RVA: 0x00759BAC File Offset: 0x00757DAC
		public List<ISetSubScreenDataT> AdjustConfigs { get; set; }

		// Token: 0x06036FB8 RID: 225208 RVA: 0x00759BB5 File Offset: 0x00757DB5
		public ISubScreenModeAdjustT()
		{
			this.Type = ESubScreenOperationType.Init;
			this.AdjustConfigs = null;
		}
	}
}

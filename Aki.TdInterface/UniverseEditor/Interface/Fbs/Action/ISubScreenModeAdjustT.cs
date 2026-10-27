using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200720F RID: 29199
	public class ISubScreenModeAdjustT
	{
		// Token: 0x1700D8C9 RID: 55497
		// (get) Token: 0x06033CB2 RID: 212146 RVA: 0x006F8833 File Offset: 0x006F6A33
		// (set) Token: 0x06033CB3 RID: 212147 RVA: 0x006F883B File Offset: 0x006F6A3B
		public ESubScreenOperationType Type { get; set; }

		// Token: 0x1700D8CA RID: 55498
		// (get) Token: 0x06033CB4 RID: 212148 RVA: 0x006F8844 File Offset: 0x006F6A44
		// (set) Token: 0x06033CB5 RID: 212149 RVA: 0x006F884C File Offset: 0x006F6A4C
		public List<ISetSubScreenDataT> AdjustConfigs { get; set; }

		// Token: 0x06033CB6 RID: 212150 RVA: 0x006F8855 File Offset: 0x006F6A55
		public ISubScreenModeAdjustT()
		{
			this.Type = ESubScreenOperationType.Init;
			this.AdjustConfigs = null;
		}
	}
}

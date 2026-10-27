using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x0200470A RID: 18186
	public class IRunningQuestsT
	{
		// Token: 0x17008231 RID: 33329
		// (get) Token: 0x0601BE51 RID: 114257 RVA: 0x003F42B2 File Offset: 0x003F24B2
		// (set) Token: 0x0601BE52 RID: 114258 RVA: 0x003F42BA File Offset: 0x003F24BA
		public int TraceId { get; set; }

		// Token: 0x17008232 RID: 33330
		// (get) Token: 0x0601BE53 RID: 114259 RVA: 0x003F42C3 File Offset: 0x003F24C3
		// (set) Token: 0x0601BE54 RID: 114260 RVA: 0x003F42CB File Offset: 0x003F24CB
		public IRunningTreeT TraceTree { get; set; }

		// Token: 0x17008233 RID: 33331
		// (get) Token: 0x0601BE55 RID: 114261 RVA: 0x003F42D4 File Offset: 0x003F24D4
		// (set) Token: 0x0601BE56 RID: 114262 RVA: 0x003F42DC File Offset: 0x003F24DC
		public List<IRunningTreeT> Quests { get; set; }

		// Token: 0x0601BE57 RID: 114263 RVA: 0x003F42E5 File Offset: 0x003F24E5
		public IRunningQuestsT()
		{
			this.TraceId = 0;
			this.TraceTree = null;
			this.Quests = null;
		}
	}
}

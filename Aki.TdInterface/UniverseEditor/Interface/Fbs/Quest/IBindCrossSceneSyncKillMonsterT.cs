using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D2F RID: 15663
	public class IBindCrossSceneSyncKillMonsterT
	{
		// Token: 0x17006B75 RID: 27509
		// (get) Token: 0x06015A25 RID: 88613 RVA: 0x0031F7F5 File Offset: 0x0031D9F5
		// (set) Token: 0x06015A26 RID: 88614 RVA: 0x0031F7FD File Offset: 0x0031D9FD
		public List<int> EntityBundleIds { get; set; }

		// Token: 0x06015A27 RID: 88615 RVA: 0x0031F806 File Offset: 0x0031DA06
		public IBindCrossSceneSyncKillMonsterT()
		{
			this.EntityBundleIds = null;
		}
	}
}

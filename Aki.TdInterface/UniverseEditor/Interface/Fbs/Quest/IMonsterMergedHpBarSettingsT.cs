using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F3C RID: 16188
	public class IMonsterMergedHpBarSettingsT
	{
		// Token: 0x17007095 RID: 28821
		// (get) Token: 0x0601701F RID: 94239 RVA: 0x00351897 File Offset: 0x0034FA97
		// (set) Token: 0x06017020 RID: 94240 RVA: 0x0035189F File Offset: 0x0034FA9F
		public List<long> DisplayBuffIds { get; set; }

		// Token: 0x17007096 RID: 28822
		// (get) Token: 0x06017021 RID: 94241 RVA: 0x003518A8 File Offset: 0x0034FAA8
		// (set) Token: 0x06017022 RID: 94242 RVA: 0x003518B0 File Offset: 0x0034FAB0
		public byte NullMask { get; set; }

		// Token: 0x06017023 RID: 94243 RVA: 0x003518B9 File Offset: 0x0034FAB9
		public IMonsterMergedHpBarSettingsT()
		{
			this.DisplayBuffIds = null;
			this.NullMask = 0;
		}
	}
}

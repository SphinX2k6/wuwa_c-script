using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200437A RID: 17274
	public class IMonsterMergedHpBarSettingsT
	{
		// Token: 0x17007686 RID: 30342
		// (get) Token: 0x06018681 RID: 99969 RVA: 0x0037AD0B File Offset: 0x00378F0B
		// (set) Token: 0x06018682 RID: 99970 RVA: 0x0037AD13 File Offset: 0x00378F13
		public List<long> DisplayBuffIds { get; set; }

		// Token: 0x17007687 RID: 30343
		// (get) Token: 0x06018683 RID: 99971 RVA: 0x0037AD1C File Offset: 0x00378F1C
		// (set) Token: 0x06018684 RID: 99972 RVA: 0x0037AD24 File Offset: 0x00378F24
		public byte NullMask { get; set; }

		// Token: 0x06018685 RID: 99973 RVA: 0x0037AD2D File Offset: 0x00378F2D
		public IMonsterMergedHpBarSettingsT()
		{
			this.DisplayBuffIds = null;
			this.NullMask = 0;
		}
	}
}

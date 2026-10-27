using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005211 RID: 21009
	public class IExtraAiAlertT
	{
		// Token: 0x170099E2 RID: 39394
		// (get) Token: 0x06022240 RID: 139840 RVA: 0x004BCB8F File Offset: 0x004BAD8F
		// (set) Token: 0x06022241 RID: 139841 RVA: 0x004BCB97 File Offset: 0x004BAD97
		public int MoveAlert { get; set; }

		// Token: 0x170099E3 RID: 39395
		// (get) Token: 0x06022242 RID: 139842 RVA: 0x004BCBA0 File Offset: 0x004BADA0
		// (set) Token: 0x06022243 RID: 139843 RVA: 0x004BCBA8 File Offset: 0x004BADA8
		public int StopAlert { get; set; }

		// Token: 0x170099E4 RID: 39396
		// (get) Token: 0x06022244 RID: 139844 RVA: 0x004BCBB1 File Offset: 0x004BADB1
		// (set) Token: 0x06022245 RID: 139845 RVA: 0x004BCBB9 File Offset: 0x004BADB9
		public List<IStateAlertT> SelfStateAlert { get; set; }

		// Token: 0x170099E5 RID: 39397
		// (get) Token: 0x06022246 RID: 139846 RVA: 0x004BCBC2 File Offset: 0x004BADC2
		// (set) Token: 0x06022247 RID: 139847 RVA: 0x004BCBCA File Offset: 0x004BADCA
		public byte NullMask { get; set; }

		// Token: 0x06022248 RID: 139848 RVA: 0x004BCBD3 File Offset: 0x004BADD3
		public IExtraAiAlertT()
		{
			this.MoveAlert = 0;
			this.StopAlert = 0;
			this.SelfStateAlert = null;
			this.NullMask = 0;
		}
	}
}

using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069D0 RID: 27088
	public class IJigsawItemEntityT
	{
		// Token: 0x1700C902 RID: 51458
		// (get) Token: 0x0602F5A7 RID: 193959 RVA: 0x00672EA7 File Offset: 0x006710A7
		// (set) Token: 0x0602F5A8 RID: 193960 RVA: 0x00672EAF File Offset: 0x006710AF
		public EResetEntityType Type { get; set; }

		// Token: 0x1700C903 RID: 51459
		// (get) Token: 0x0602F5A9 RID: 193961 RVA: 0x00672EB8 File Offset: 0x006710B8
		// (set) Token: 0x0602F5AA RID: 193962 RVA: 0x00672EC0 File Offset: 0x006710C0
		public List<int> EntityIds { get; set; }

		// Token: 0x0602F5AB RID: 193963 RVA: 0x00672EC9 File Offset: 0x006710C9
		public IJigsawItemEntityT()
		{
			this.Type = EResetEntityType.TeleControl;
			this.EntityIds = null;
		}
	}
}

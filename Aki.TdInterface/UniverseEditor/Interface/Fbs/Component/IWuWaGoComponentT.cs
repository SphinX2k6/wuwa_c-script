using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B9F RID: 23455
	public class IWuWaGoComponentT
	{
		// Token: 0x1700B140 RID: 45376
		// (get) Token: 0x06028299 RID: 164505 RVA: 0x005851C0 File Offset: 0x005833C0
		// (set) Token: 0x0602829A RID: 164506 RVA: 0x005851C8 File Offset: 0x005833C8
		public bool Disabled { get; set; }

		// Token: 0x1700B141 RID: 45377
		// (get) Token: 0x0602829B RID: 164507 RVA: 0x005851D1 File Offset: 0x005833D1
		// (set) Token: 0x0602829C RID: 164508 RVA: 0x005851D9 File Offset: 0x005833D9
		public TWuWaGoEntityDataUnion WuWaGoEntity { get; set; }

		// Token: 0x1700B142 RID: 45378
		// (get) Token: 0x0602829D RID: 164509 RVA: 0x005851E2 File Offset: 0x005833E2
		// (set) Token: 0x0602829E RID: 164510 RVA: 0x005851EA File Offset: 0x005833EA
		public List<int> OpenAddClientTags { get; set; }

		// Token: 0x1700B143 RID: 45379
		// (get) Token: 0x0602829F RID: 164511 RVA: 0x005851F3 File Offset: 0x005833F3
		// (set) Token: 0x060282A0 RID: 164512 RVA: 0x005851FB File Offset: 0x005833FB
		public byte NullMask { get; set; }

		// Token: 0x060282A1 RID: 164513 RVA: 0x00585204 File Offset: 0x00583404
		public IWuWaGoComponentT()
		{
			this.Disabled = false;
			this.WuWaGoEntity = null;
			this.OpenAddClientTags = null;
			this.NullMask = 0;
		}
	}
}

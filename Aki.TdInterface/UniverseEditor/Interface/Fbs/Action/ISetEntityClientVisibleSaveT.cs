using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FE1 RID: 28641
	public class ISetEntityClientVisibleSaveT
	{
		// Token: 0x1700D4A4 RID: 54436
		// (get) Token: 0x06032A2E RID: 207406 RVA: 0x006D4E7B File Offset: 0x006D307B
		// (set) Token: 0x06032A2F RID: 207407 RVA: 0x006D4E83 File Offset: 0x006D3083
		public List<int> EntityIds { get; set; }

		// Token: 0x1700D4A5 RID: 54437
		// (get) Token: 0x06032A30 RID: 207408 RVA: 0x006D4E8C File Offset: 0x006D308C
		// (set) Token: 0x06032A31 RID: 207409 RVA: 0x006D4E94 File Offset: 0x006D3094
		public bool Visible { get; set; }

		// Token: 0x06032A32 RID: 207410 RVA: 0x006D4E9D File Offset: 0x006D309D
		public ISetEntityClientVisibleSaveT()
		{
			this.EntityIds = null;
			this.Visible = false;
		}
	}
}

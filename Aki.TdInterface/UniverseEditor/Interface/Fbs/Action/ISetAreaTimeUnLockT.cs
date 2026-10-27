using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FAF RID: 28591
	public class ISetAreaTimeUnLockT
	{
		// Token: 0x1700D450 RID: 54352
		// (get) Token: 0x06032889 RID: 206985 RVA: 0x006D1DCF File Offset: 0x006CFFCF
		// (set) Token: 0x0603288A RID: 206986 RVA: 0x006D1DD7 File Offset: 0x006CFFD7
		public ESetAreaTime Type { get; set; }

		// Token: 0x1700D451 RID: 54353
		// (get) Token: 0x0603288B RID: 206987 RVA: 0x006D1DE0 File Offset: 0x006CFFE0
		// (set) Token: 0x0603288C RID: 206988 RVA: 0x006D1DE8 File Offset: 0x006CFFE8
		public List<int> AreaIds { get; set; }

		// Token: 0x0603288D RID: 206989 RVA: 0x006D1DF1 File Offset: 0x006CFFF1
		public ISetAreaTimeUnLockT()
		{
			this.Type = ESetAreaTime.Lock;
			this.AreaIds = null;
		}
	}
}

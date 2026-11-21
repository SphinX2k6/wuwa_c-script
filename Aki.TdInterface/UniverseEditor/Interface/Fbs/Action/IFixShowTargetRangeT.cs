using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E5B RID: 28251
	public class IFixShowTargetRangeT
	{
		// Token: 0x1700CF10 RID: 53008
		// (get) Token: 0x06030CE0 RID: 199904 RVA: 0x0069F78B File Offset: 0x0069D98B
		// (set) Token: 0x06030CE1 RID: 199905 RVA: 0x0069F793 File Offset: 0x0069D993
		public List<int> RangeEntities { get; set; }

		// Token: 0x1700CF11 RID: 53009
		// (get) Token: 0x06030CE2 RID: 199906 RVA: 0x0069F79C File Offset: 0x0069D99C
		// (set) Token: 0x06030CE3 RID: 199907 RVA: 0x0069F7A4 File Offset: 0x0069D9A4
		public bool DelayShow { get; set; }

		// Token: 0x06030CE4 RID: 199908 RVA: 0x0069F7AD File Offset: 0x0069D9AD
		public IFixShowTargetRangeT()
		{
			this.RangeEntities = null;
			this.DelayShow = false;
		}
	}
}

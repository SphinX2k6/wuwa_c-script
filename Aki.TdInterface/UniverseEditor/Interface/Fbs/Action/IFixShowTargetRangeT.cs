using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067DB RID: 26587
	public class IFixShowTargetRangeT
	{
		// Token: 0x1700C55A RID: 50522
		// (get) Token: 0x0602E49A RID: 189594 RVA: 0x00652047 File Offset: 0x00650247
		// (set) Token: 0x0602E49B RID: 189595 RVA: 0x0065204F File Offset: 0x0065024F
		public List<int> RangeEntities { get; set; }

		// Token: 0x1700C55B RID: 50523
		// (get) Token: 0x0602E49C RID: 189596 RVA: 0x00652058 File Offset: 0x00650258
		// (set) Token: 0x0602E49D RID: 189597 RVA: 0x00652060 File Offset: 0x00650260
		public bool DelayShow { get; set; }

		// Token: 0x0602E49E RID: 189598 RVA: 0x00652069 File Offset: 0x00650269
		public IFixShowTargetRangeT()
		{
			this.RangeEntities = null;
			this.DelayShow = false;
		}
	}
}

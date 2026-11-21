using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CB1 RID: 27825
	public class IEnableAIT
	{
		// Token: 0x1700CC1B RID: 52251
		// (get) Token: 0x0602FF46 RID: 196422 RVA: 0x00686FDF File Offset: 0x006851DF
		// (set) Token: 0x0602FF47 RID: 196423 RVA: 0x00686FE7 File Offset: 0x006851E7
		public List<int> EntityIds { get; set; }

		// Token: 0x1700CC1C RID: 52252
		// (get) Token: 0x0602FF48 RID: 196424 RVA: 0x00686FF0 File Offset: 0x006851F0
		// (set) Token: 0x0602FF49 RID: 196425 RVA: 0x00686FF8 File Offset: 0x006851F8
		public bool IsEnable { get; set; }

		// Token: 0x0602FF4A RID: 196426 RVA: 0x00687001 File Offset: 0x00685201
		public IEnableAIT()
		{
			this.EntityIds = null;
			this.IsEnable = false;
		}
	}
}

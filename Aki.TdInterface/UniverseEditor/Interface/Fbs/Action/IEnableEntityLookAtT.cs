using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200665B RID: 26203
	public class IEnableEntityLookAtT
	{
		// Token: 0x1700C2A9 RID: 49833
		// (get) Token: 0x0602D847 RID: 186439 RVA: 0x0063BAFB File Offset: 0x00639CFB
		// (set) Token: 0x0602D848 RID: 186440 RVA: 0x0063BB03 File Offset: 0x00639D03
		public string Key { get; set; }

		// Token: 0x1700C2AA RID: 49834
		// (get) Token: 0x0602D849 RID: 186441 RVA: 0x0063BB0C File Offset: 0x00639D0C
		// (set) Token: 0x0602D84A RID: 186442 RVA: 0x0063BB14 File Offset: 0x00639D14
		public TDefaultLookAtTypeUnion DefaultLookAtType { get; set; }

		// Token: 0x1700C2AB RID: 49835
		// (get) Token: 0x0602D84B RID: 186443 RVA: 0x0063BB1D File Offset: 0x00639D1D
		// (set) Token: 0x0602D84C RID: 186444 RVA: 0x0063BB25 File Offset: 0x00639D25
		public ICheckFlowLookAtT OverrideLookAtType { get; set; }

		// Token: 0x1700C2AC RID: 49836
		// (get) Token: 0x0602D84D RID: 186445 RVA: 0x0063BB2E File Offset: 0x00639D2E
		// (set) Token: 0x0602D84E RID: 186446 RVA: 0x0063BB36 File Offset: 0x00639D36
		public List<int> EntityIds { get; set; }

		// Token: 0x0602D84F RID: 186447 RVA: 0x0063BB3F File Offset: 0x00639D3F
		public IEnableEntityLookAtT()
		{
			this.Key = null;
			this.DefaultLookAtType = null;
			this.OverrideLookAtType = null;
			this.EntityIds = null;
		}
	}
}

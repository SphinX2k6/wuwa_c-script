using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069CD RID: 27085
	public class ICheckFlowLookAtT
	{
		// Token: 0x1700C750 RID: 51024
		// (get) Token: 0x0602E77D RID: 190333 RVA: 0x0065719B File Offset: 0x0065539B
		// (set) Token: 0x0602E77E RID: 190334 RVA: 0x006571A3 File Offset: 0x006553A3
		public EOverrideLookAtType Type { get; set; }

		// Token: 0x1700C751 RID: 51025
		// (get) Token: 0x0602E77F RID: 190335 RVA: 0x006571AC File Offset: 0x006553AC
		// (set) Token: 0x0602E780 RID: 190336 RVA: 0x006571B4 File Offset: 0x006553B4
		public List<ICheckFlowLookAtConfigT> CheckFlowLookAtConfigs { get; set; }

		// Token: 0x0602E781 RID: 190337 RVA: 0x006571BD File Offset: 0x006553BD
		public ICheckFlowLookAtT()
		{
			this.Type = EOverrideLookAtType.CheckFlowLookAt;
			this.CheckFlowLookAtConfigs = null;
		}
	}
}

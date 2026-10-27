using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F17 RID: 20247
	public class IBehaviorFlowComponentT
	{
		// Token: 0x170091CD RID: 37325
		// (get) Token: 0x0602003E RID: 131134 RVA: 0x00474A01 File Offset: 0x00472C01
		// (set) Token: 0x0602003F RID: 131135 RVA: 0x00474A09 File Offset: 0x00472C09
		public bool Disabled { get; set; }

		// Token: 0x170091CE RID: 37326
		// (get) Token: 0x06020040 RID: 131136 RVA: 0x00474A12 File Offset: 0x00472C12
		// (set) Token: 0x06020041 RID: 131137 RVA: 0x00474A1A File Offset: 0x00472C1A
		public bool _Folded { get; set; }

		// Token: 0x170091CF RID: 37327
		// (get) Token: 0x06020042 RID: 131138 RVA: 0x00474A23 File Offset: 0x00472C23
		// (set) Token: 0x06020043 RID: 131139 RVA: 0x00474A2B File Offset: 0x00472C2B
		public int InitStateId { get; set; }

		// Token: 0x170091D0 RID: 37328
		// (get) Token: 0x06020044 RID: 131140 RVA: 0x00474A34 File Offset: 0x00472C34
		// (set) Token: 0x06020045 RID: 131141 RVA: 0x00474A3C File Offset: 0x00472C3C
		public IFlowInfoT FlowInfo { get; set; }

		// Token: 0x170091D1 RID: 37329
		// (get) Token: 0x06020046 RID: 131142 RVA: 0x00474A45 File Offset: 0x00472C45
		// (set) Token: 0x06020047 RID: 131143 RVA: 0x00474A4D File Offset: 0x00472C4D
		public byte NullMask { get; set; }

		// Token: 0x06020048 RID: 131144 RVA: 0x00474A56 File Offset: 0x00472C56
		public IBehaviorFlowComponentT()
		{
			this.Disabled = false;
			this._Folded = false;
			this.InitStateId = 0;
			this.FlowInfo = null;
			this.NullMask = 0;
		}
	}
}

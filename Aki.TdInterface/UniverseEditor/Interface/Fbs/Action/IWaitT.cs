using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075F6 RID: 30198
	public class IWaitT
	{
		// Token: 0x1700E56A RID: 58730
		// (get) Token: 0x0603702C RID: 225324 RVA: 0x00776D59 File Offset: 0x00774F59
		// (set) Token: 0x0603702D RID: 225325 RVA: 0x00776D61 File Offset: 0x00774F61
		public float Min { get; set; }

		// Token: 0x1700E56B RID: 58731
		// (get) Token: 0x0603702E RID: 225326 RVA: 0x00776D6A File Offset: 0x00774F6A
		// (set) Token: 0x0603702F RID: 225327 RVA: 0x00776D72 File Offset: 0x00774F72
		public float Time { get; set; }

		// Token: 0x1700E56C RID: 58732
		// (get) Token: 0x06037030 RID: 225328 RVA: 0x00776D7B File Offset: 0x00774F7B
		// (set) Token: 0x06037031 RID: 225329 RVA: 0x00776D83 File Offset: 0x00774F83
		public bool BanInput { get; set; }

		// Token: 0x1700E56D RID: 58733
		// (get) Token: 0x06037032 RID: 225330 RVA: 0x00776D8C File Offset: 0x00774F8C
		// (set) Token: 0x06037033 RID: 225331 RVA: 0x00776D94 File Offset: 0x00774F94
		public IVarIntervalT WaitInterval { get; set; }

		// Token: 0x1700E56E RID: 58734
		// (get) Token: 0x06037034 RID: 225332 RVA: 0x00776D9D File Offset: 0x00774F9D
		// (set) Token: 0x06037035 RID: 225333 RVA: 0x00776DA5 File Offset: 0x00774FA5
		public byte NullMask { get; set; }

		// Token: 0x06037036 RID: 225334 RVA: 0x00776DAE File Offset: 0x00774FAE
		public IWaitT()
		{
			this.Min = 0f;
			this.Time = 0f;
			this.BanInput = false;
			this.WaitInterval = null;
			this.NullMask = 0;
		}
	}
}

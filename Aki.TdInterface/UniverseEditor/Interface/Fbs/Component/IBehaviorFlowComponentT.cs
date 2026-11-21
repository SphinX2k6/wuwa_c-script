using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005449 RID: 21577
	public class IBehaviorFlowComponentT
	{
		// Token: 0x1700994F RID: 39247
		// (get) Token: 0x06021DAE RID: 138670 RVA: 0x004AAD95 File Offset: 0x004A8F95
		// (set) Token: 0x06021DAF RID: 138671 RVA: 0x004AAD9D File Offset: 0x004A8F9D
		public bool Disabled { get; set; }

		// Token: 0x17009950 RID: 39248
		// (get) Token: 0x06021DB0 RID: 138672 RVA: 0x004AADA6 File Offset: 0x004A8FA6
		// (set) Token: 0x06021DB1 RID: 138673 RVA: 0x004AADAE File Offset: 0x004A8FAE
		public bool _Folded { get; set; }

		// Token: 0x17009951 RID: 39249
		// (get) Token: 0x06021DB2 RID: 138674 RVA: 0x004AADB7 File Offset: 0x004A8FB7
		// (set) Token: 0x06021DB3 RID: 138675 RVA: 0x004AADBF File Offset: 0x004A8FBF
		public int InitStateId { get; set; }

		// Token: 0x17009952 RID: 39250
		// (get) Token: 0x06021DB4 RID: 138676 RVA: 0x004AADC8 File Offset: 0x004A8FC8
		// (set) Token: 0x06021DB5 RID: 138677 RVA: 0x004AADD0 File Offset: 0x004A8FD0
		public IFlowInfoT FlowInfo { get; set; }

		// Token: 0x17009953 RID: 39251
		// (get) Token: 0x06021DB6 RID: 138678 RVA: 0x004AADD9 File Offset: 0x004A8FD9
		// (set) Token: 0x06021DB7 RID: 138679 RVA: 0x004AADE1 File Offset: 0x004A8FE1
		public byte NullMask { get; set; }

		// Token: 0x06021DB8 RID: 138680 RVA: 0x004AADEA File Offset: 0x004A8FEA
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

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054CD RID: 21709
	public class IChildStateChangedConfigT
	{
		// Token: 0x17009AFE RID: 39678
		// (get) Token: 0x060223F5 RID: 140277 RVA: 0x004B87DF File Offset: 0x004B69DF
		// (set) Token: 0x060223F6 RID: 140278 RVA: 0x004B87E7 File Offset: 0x004B69E7
		public string State { get; set; }

		// Token: 0x17009AFF RID: 39679
		// (get) Token: 0x060223F7 RID: 140279 RVA: 0x004B87F0 File Offset: 0x004B69F0
		// (set) Token: 0x060223F8 RID: 140280 RVA: 0x004B87F8 File Offset: 0x004B69F8
		public IDelayChangeStateT DelayChangeState { get; set; }

		// Token: 0x060223F9 RID: 140281 RVA: 0x004B8801 File Offset: 0x004B6A01
		public IChildStateChangedConfigT()
		{
			this.State = null;
			this.DelayChangeState = null;
		}
	}
}

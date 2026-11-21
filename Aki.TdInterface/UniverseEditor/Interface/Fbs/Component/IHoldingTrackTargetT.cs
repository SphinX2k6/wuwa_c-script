using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005937 RID: 22839
	public class IHoldingTrackTargetT
	{
		// Token: 0x1700A5AB RID: 42411
		// (get) Token: 0x0602525E RID: 152158 RVA: 0x00518ED9 File Offset: 0x005170D9
		// (set) Token: 0x0602525F RID: 152159 RVA: 0x00518EE1 File Offset: 0x005170E1
		public string EffectPath { get; set; }

		// Token: 0x1700A5AC RID: 42412
		// (get) Token: 0x06025260 RID: 152160 RVA: 0x00518EEA File Offset: 0x005170EA
		// (set) Token: 0x06025261 RID: 152161 RVA: 0x00518EF2 File Offset: 0x005170F2
		public int EffectLength { get; set; }

		// Token: 0x1700A5AD RID: 42413
		// (get) Token: 0x06025262 RID: 152162 RVA: 0x00518EFB File Offset: 0x005170FB
		// (set) Token: 0x06025263 RID: 152163 RVA: 0x00518F03 File Offset: 0x00517103
		public int EntityId { get; set; }

		// Token: 0x06025264 RID: 152164 RVA: 0x00518F0C File Offset: 0x0051710C
		public IHoldingTrackTargetT()
		{
			this.EffectPath = null;
			this.EffectLength = 0;
			this.EntityId = 0;
		}
	}
}

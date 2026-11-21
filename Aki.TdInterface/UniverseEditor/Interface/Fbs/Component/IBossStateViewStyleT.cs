using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200544F RID: 21583
	public class IBossStateViewStyleT
	{
		// Token: 0x17009967 RID: 39271
		// (get) Token: 0x06021DFA RID: 138746 RVA: 0x004AB622 File Offset: 0x004A9822
		// (set) Token: 0x06021DFB RID: 138747 RVA: 0x004AB62A File Offset: 0x004A982A
		public EBossStateViewStyle Type { get; set; }

		// Token: 0x06021DFC RID: 138748 RVA: 0x004AB633 File Offset: 0x004A9833
		public IBossStateViewStyleT()
		{
			this.Type = EBossStateViewStyle.DoubleView;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E5A RID: 15962
	public class IBvbPlayerHpValueT
	{
		// Token: 0x17006BC2 RID: 27586
		// (get) Token: 0x060157F9 RID: 88057 RVA: 0x00319D12 File Offset: 0x00317F12
		// (set) Token: 0x060157FA RID: 88058 RVA: 0x00319D1A File Offset: 0x00317F1A
		public ESystemVarName Type { get; set; }

		// Token: 0x060157FB RID: 88059 RVA: 0x00319D23 File Offset: 0x00317F23
		public IBvbPlayerHpValueT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
		}
	}
}

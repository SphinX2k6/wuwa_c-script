using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040E3 RID: 16611
	public class IRoleTowerSystemConfigT
	{
		// Token: 0x17007519 RID: 29977
		// (get) Token: 0x0601834A RID: 99146 RVA: 0x0037C593 File Offset: 0x0037A793
		// (set) Token: 0x0601834B RID: 99147 RVA: 0x0037C59B File Offset: 0x0037A79B
		public EEnableSystemType Type { get; set; }

		// Token: 0x1700751A RID: 29978
		// (get) Token: 0x0601834C RID: 99148 RVA: 0x0037C5A4 File Offset: 0x0037A7A4
		// (set) Token: 0x0601834D RID: 99149 RVA: 0x0037C5AC File Offset: 0x0037A7AC
		public List<IRoleTowerSystemVarT> Vars { get; set; }

		// Token: 0x0601834E RID: 99150 RVA: 0x0037C5B5 File Offset: 0x0037A7B5
		public IRoleTowerSystemConfigT()
		{
			this.Type = EEnableSystemType.GradingSystem;
			this.Vars = null;
		}
	}
}

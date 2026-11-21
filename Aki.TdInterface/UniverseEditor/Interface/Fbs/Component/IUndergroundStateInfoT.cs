using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006116 RID: 24854
	public class IUndergroundStateInfoT
	{
		// Token: 0x1700B90B RID: 47371
		// (get) Token: 0x0602A234 RID: 172596 RVA: 0x005C045B File Offset: 0x005BE65B
		// (set) Token: 0x0602A235 RID: 172597 RVA: 0x005C0463 File Offset: 0x005BE663
		public int StateId { get; set; }

		// Token: 0x1700B90C RID: 47372
		// (get) Token: 0x0602A236 RID: 172598 RVA: 0x005C046C File Offset: 0x005BE66C
		// (set) Token: 0x0602A237 RID: 172599 RVA: 0x005C0474 File Offset: 0x005BE674
		public IVectorInfoT RestartPos { get; set; }

		// Token: 0x0602A238 RID: 172600 RVA: 0x005C047D File Offset: 0x005BE67D
		public IUndergroundStateInfoT()
		{
			this.StateId = 0;
			this.RestartPos = null;
		}
	}
}

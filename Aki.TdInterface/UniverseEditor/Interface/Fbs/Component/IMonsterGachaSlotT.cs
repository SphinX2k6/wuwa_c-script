using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B1D RID: 23325
	public class IMonsterGachaSlotT
	{
		// Token: 0x1700AA4D RID: 43597
		// (get) Token: 0x060265CE RID: 157134 RVA: 0x005416A5 File Offset: 0x0053F8A5
		// (set) Token: 0x060265CF RID: 157135 RVA: 0x005416AD File Offset: 0x0053F8AD
		public IVectorInfoT Pos { get; set; }

		// Token: 0x060265D0 RID: 157136 RVA: 0x005416B6 File Offset: 0x0053F8B6
		public IMonsterGachaSlotT()
		{
			this.Pos = null;
		}
	}
}

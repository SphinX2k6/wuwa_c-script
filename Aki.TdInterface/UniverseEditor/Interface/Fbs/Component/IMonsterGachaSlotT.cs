using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200557F RID: 21887
	public class IMonsterGachaSlotT
	{
		// Token: 0x1700A1C5 RID: 41413
		// (get) Token: 0x060243C1 RID: 148417 RVA: 0x0050112D File Offset: 0x004FF32D
		// (set) Token: 0x060243C2 RID: 148418 RVA: 0x00501135 File Offset: 0x004FF335
		public IVectorInfoT Pos { get; set; }

		// Token: 0x060243C3 RID: 148419 RVA: 0x0050113E File Offset: 0x004FF33E
		public IMonsterGachaSlotT()
		{
			this.Pos = null;
		}
	}
}

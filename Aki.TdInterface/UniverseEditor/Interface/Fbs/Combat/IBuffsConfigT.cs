using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Combat
{
	// Token: 0x0200652B RID: 25899
	public class IBuffsConfigT
	{
		// Token: 0x1700BF16 RID: 48918
		// (get) Token: 0x0602C252 RID: 180818 RVA: 0x006034C5 File Offset: 0x006016C5
		// (set) Token: 0x0602C253 RID: 180819 RVA: 0x006034CD File Offset: 0x006016CD
		public List<IBuffConfigT> Buffs { get; set; }

		// Token: 0x0602C254 RID: 180820 RVA: 0x006034D6 File Offset: 0x006016D6
		public IBuffsConfigT()
		{
			this.Buffs = null;
		}
	}
}

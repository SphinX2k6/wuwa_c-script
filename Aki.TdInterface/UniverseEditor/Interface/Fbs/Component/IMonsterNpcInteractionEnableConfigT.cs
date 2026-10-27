using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005588 RID: 21896
	public class IMonsterNpcInteractionEnableConfigT
	{
		// Token: 0x1700A1CE RID: 41422
		// (get) Token: 0x06024407 RID: 148487 RVA: 0x00501A3D File Offset: 0x004FFC3D
		// (set) Token: 0x06024408 RID: 148488 RVA: 0x00501A45 File Offset: 0x004FFC45
		public List<TMonsterNpcInteractionConfigUnion> Interactions { get; set; }

		// Token: 0x06024409 RID: 148489 RVA: 0x00501A4E File Offset: 0x004FFC4E
		public IMonsterNpcInteractionEnableConfigT()
		{
			this.Interactions = null;
		}
	}
}

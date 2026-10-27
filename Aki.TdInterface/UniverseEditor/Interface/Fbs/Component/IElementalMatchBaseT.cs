using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005133 RID: 20787
	public class IElementalMatchBaseT
	{
		// Token: 0x17009789 RID: 38793
		// (get) Token: 0x0602187C RID: 137340 RVA: 0x004A7D66 File Offset: 0x004A5F66
		// (set) Token: 0x0602187D RID: 137341 RVA: 0x004A7D6E File Offset: 0x004A5F6E
		public EElementalType Type { get; set; }

		// Token: 0x0602187E RID: 137342 RVA: 0x004A7D77 File Offset: 0x004A5F77
		public IElementalMatchBaseT()
		{
			this.Type = EElementalType.Fire;
		}
	}
}

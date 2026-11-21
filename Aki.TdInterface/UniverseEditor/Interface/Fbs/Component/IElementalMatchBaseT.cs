using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005698 RID: 22168
	public class IElementalMatchBaseT
	{
		// Token: 0x17009F76 RID: 40822
		// (get) Token: 0x060237D0 RID: 145360 RVA: 0x004E1CF2 File Offset: 0x004DFEF2
		// (set) Token: 0x060237D1 RID: 145361 RVA: 0x004E1CFA File Offset: 0x004DFEFA
		public EElementalType Type { get; set; }

		// Token: 0x060237D2 RID: 145362 RVA: 0x004E1D03 File Offset: 0x004DFF03
		public IElementalMatchBaseT()
		{
			this.Type = EElementalType.Fire;
		}
	}
}

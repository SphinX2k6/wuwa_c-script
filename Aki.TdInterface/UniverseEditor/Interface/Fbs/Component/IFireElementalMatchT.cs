using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200525F RID: 21087
	public class IFireElementalMatchT
	{
		// Token: 0x17009A74 RID: 39540
		// (get) Token: 0x060224DF RID: 140511 RVA: 0x004C1942 File Offset: 0x004BFB42
		// (set) Token: 0x060224E0 RID: 140512 RVA: 0x004C194A File Offset: 0x004BFB4A
		public EElementalType Type { get; set; }

		// Token: 0x060224E1 RID: 140513 RVA: 0x004C1953 File Offset: 0x004BFB53
		public IFireElementalMatchT()
		{
			this.Type = EElementalType.Fire;
		}
	}
}

using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B8A RID: 23434
	public class IWoodElementalMatchT
	{
		// Token: 0x1700B117 RID: 45335
		// (get) Token: 0x060281DD RID: 164317 RVA: 0x005838B2 File Offset: 0x00581AB2
		// (set) Token: 0x060281DE RID: 164318 RVA: 0x005838BA File Offset: 0x00581ABA
		public EElementalType Type { get; set; }

		// Token: 0x060281DF RID: 164319 RVA: 0x005838C3 File Offset: 0x00581AC3
		public IWoodElementalMatchT()
		{
			this.Type = EElementalType.Fire;
		}
	}
}

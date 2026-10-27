using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006066 RID: 24678
	public class IAbsolutePos2T
	{
		// Token: 0x1700B5D5 RID: 46549
		// (get) Token: 0x06029C88 RID: 171144 RVA: 0x005BBB43 File Offset: 0x005B9D43
		// (set) Token: 0x06029C89 RID: 171145 RVA: 0x005BBB4B File Offset: 0x005B9D4B
		public EPos2 Type { get; set; }

		// Token: 0x1700B5D6 RID: 46550
		// (get) Token: 0x06029C8A RID: 171146 RVA: 0x005BBB54 File Offset: 0x005B9D54
		// (set) Token: 0x06029C8B RID: 171147 RVA: 0x005BBB5C File Offset: 0x005B9D5C
		public IVectorInfoT Pos { get; set; }

		// Token: 0x06029C8C RID: 171148 RVA: 0x005BBB65 File Offset: 0x005B9D65
		public IAbsolutePos2T()
		{
			this.Type = EPos2.Player;
			this.Pos = null;
		}
	}
}

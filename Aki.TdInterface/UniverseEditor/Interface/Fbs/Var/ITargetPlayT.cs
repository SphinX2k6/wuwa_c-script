using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EE7 RID: 16103
	public class ITargetPlayT
	{
		// Token: 0x17006D0A RID: 27914
		// (get) Token: 0x06015D5A RID: 89434 RVA: 0x00324172 File Offset: 0x00322372
		// (set) Token: 0x06015D5B RID: 89435 RVA: 0x0032417A File Offset: 0x0032237A
		public ETargetType Type { get; set; }

		// Token: 0x06015D5C RID: 89436 RVA: 0x00324183 File Offset: 0x00322383
		public ITargetPlayT()
		{
			this.Type = ETargetType.Player;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EEA RID: 16106
	public class ITargetTypeT
	{
		// Token: 0x17006D0D RID: 27917
		// (get) Token: 0x06015D6C RID: 89452 RVA: 0x003242EA File Offset: 0x003224EA
		// (set) Token: 0x06015D6D RID: 89453 RVA: 0x003242F2 File Offset: 0x003224F2
		public ETargetType Type { get; set; }

		// Token: 0x06015D6E RID: 89454 RVA: 0x003242FB File Offset: 0x003224FB
		public ITargetTypeT()
		{
			this.Type = ETargetType.Player;
		}
	}
}

using System;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02004559 RID: 17753
	public class MarkShowState : IMarkShowState
	{
		// Token: 0x17005A1F RID: 23071
		// (get) Token: 0x0602CBBD RID: 183229 RVA: 0x00C871E4 File Offset: 0x00C853E4
		// (set) Token: 0x0602CBBE RID: 183230 RVA: 0x00C871EC File Offset: 0x00C853EC
		public int Id { get; set; }

		// Token: 0x17005A20 RID: 23072
		// (get) Token: 0x0602CBBF RID: 183231 RVA: 0x00C871F5 File Offset: 0x00C853F5
		// (set) Token: 0x0602CBC0 RID: 183232 RVA: 0x00C871FD File Offset: 0x00C853FD
		public bool NeedFocus { get; set; }

		// Token: 0x17005A21 RID: 23073
		// (get) Token: 0x0602CBC1 RID: 183233 RVA: 0x00C87206 File Offset: 0x00C85406
		// (set) Token: 0x0602CBC2 RID: 183234 RVA: 0x00C8720E File Offset: 0x00C8540E
		public MapMarkShowFlag ShowFlag { get; set; }
	}
}

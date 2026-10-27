using System;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02005583 RID: 21891
	public class MarkShowState : IMarkShowState
	{
		// Token: 0x17008658 RID: 34392
		// (get) Token: 0x06037CBF RID: 228543 RVA: 0x00D39504 File Offset: 0x00D37704
		// (set) Token: 0x06037CC0 RID: 228544 RVA: 0x00D3950C File Offset: 0x00D3770C
		public int Id { get; set; }

		// Token: 0x17008659 RID: 34393
		// (get) Token: 0x06037CC1 RID: 228545 RVA: 0x00D39515 File Offset: 0x00D37715
		// (set) Token: 0x06037CC2 RID: 228546 RVA: 0x00D3951D File Offset: 0x00D3771D
		public bool NeedFocus { get; set; }

		// Token: 0x1700865A RID: 34394
		// (get) Token: 0x06037CC3 RID: 228547 RVA: 0x00D39526 File Offset: 0x00D37726
		// (set) Token: 0x06037CC4 RID: 228548 RVA: 0x00D3952E File Offset: 0x00D3772E
		public MapMarkShowFlag ShowFlag { get; set; }
	}
}

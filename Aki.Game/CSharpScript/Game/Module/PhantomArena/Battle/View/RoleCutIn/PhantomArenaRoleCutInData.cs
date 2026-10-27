using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.RoleCutIn
{
	// Token: 0x02005252 RID: 21074
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaRoleCutInData : IPhantomArenaRoleCutInData
	{
		// Token: 0x17008261 RID: 33377
		// (get) Token: 0x06035D9A RID: 220570 RVA: 0x00CBE3FF File Offset: 0x00CBC5FF
		// (set) Token: 0x06035D9B RID: 220571 RVA: 0x00CBE407 File Offset: 0x00CBC607
		public int SkillId { get; set; }

		// Token: 0x17008262 RID: 33378
		// (get) Token: 0x06035D9C RID: 220572 RVA: 0x00CBE410 File Offset: 0x00CBC610
		// (set) Token: 0x06035D9D RID: 220573 RVA: 0x00CBE418 File Offset: 0x00CBC618
		public Action CloseCallback { get; set; }
	}
}

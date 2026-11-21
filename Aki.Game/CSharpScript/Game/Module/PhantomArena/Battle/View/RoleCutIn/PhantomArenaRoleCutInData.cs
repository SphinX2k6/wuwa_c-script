using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.RoleCutIn
{
	// Token: 0x02004222 RID: 16930
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaRoleCutInData : IPhantomArenaRoleCutInData
	{
		// Token: 0x17005621 RID: 22049
		// (get) Token: 0x0602AC95 RID: 175253 RVA: 0x00C0BA8F File Offset: 0x00C09C8F
		// (set) Token: 0x0602AC96 RID: 175254 RVA: 0x00C0BA97 File Offset: 0x00C09C97
		public int SkillId { get; set; }

		// Token: 0x17005622 RID: 22050
		// (get) Token: 0x0602AC97 RID: 175255 RVA: 0x00C0BAA0 File Offset: 0x00C09CA0
		// (set) Token: 0x0602AC98 RID: 175256 RVA: 0x00C0BAA8 File Offset: 0x00C09CA8
		public Action CloseCallback { get; set; }
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003EA2 RID: 16034
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleMapGridEffectInfo : IRogueBattleMapGridEffectInfo
	{
		// Token: 0x170052D9 RID: 21209
		// (get) Token: 0x06028B56 RID: 166742 RVA: 0x00B6A62C File Offset: 0x00B6882C
		// (set) Token: 0x06028B57 RID: 166743 RVA: 0x00B6A634 File Offset: 0x00B68834
		public string TagKey { get; set; } = string.Empty;

		// Token: 0x170052DA RID: 21210
		// (get) Token: 0x06028B58 RID: 166744 RVA: 0x00B6A63D File Offset: 0x00B6883D
		// (set) Token: 0x06028B59 RID: 166745 RVA: 0x00B6A645 File Offset: 0x00B68845
		public int Count { get; set; }

		// Token: 0x170052DB RID: 21211
		// (get) Token: 0x06028B5A RID: 166746 RVA: 0x00B6A64E File Offset: 0x00B6884E
		// (set) Token: 0x06028B5B RID: 166747 RVA: 0x00B6A656 File Offset: 0x00B68856
		public bool IsRatio { get; set; }

		// Token: 0x170052DC RID: 21212
		// (get) Token: 0x06028B5C RID: 166748 RVA: 0x00B6A65F File Offset: 0x00B6885F
		// (set) Token: 0x06028B5D RID: 166749 RVA: 0x00B6A667 File Offset: 0x00B68867
		public string Icon { get; set; } = string.Empty;
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004ED9 RID: 20185
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleMapGridEffectInfo : IRogueBattleMapGridEffectInfo
	{
		// Token: 0x17007F29 RID: 32553
		// (get) Token: 0x06033CEB RID: 212203 RVA: 0x00C21114 File Offset: 0x00C1F314
		// (set) Token: 0x06033CEC RID: 212204 RVA: 0x00C2111C File Offset: 0x00C1F31C
		public string TagKey { get; set; } = string.Empty;

		// Token: 0x17007F2A RID: 32554
		// (get) Token: 0x06033CED RID: 212205 RVA: 0x00C21125 File Offset: 0x00C1F325
		// (set) Token: 0x06033CEE RID: 212206 RVA: 0x00C2112D File Offset: 0x00C1F32D
		public int Count { get; set; }

		// Token: 0x17007F2B RID: 32555
		// (get) Token: 0x06033CEF RID: 212207 RVA: 0x00C21136 File Offset: 0x00C1F336
		// (set) Token: 0x06033CF0 RID: 212208 RVA: 0x00C2113E File Offset: 0x00C1F33E
		public bool IsRatio { get; set; }

		// Token: 0x17007F2C RID: 32556
		// (get) Token: 0x06033CF1 RID: 212209 RVA: 0x00C21147 File Offset: 0x00C1F347
		// (set) Token: 0x06033CF2 RID: 212210 RVA: 0x00C2114F File Offset: 0x00C1F34F
		public string Icon { get; set; } = string.Empty;
	}
}

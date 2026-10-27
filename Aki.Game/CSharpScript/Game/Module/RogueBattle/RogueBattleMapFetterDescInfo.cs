using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004ED5 RID: 20181
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleMapFetterDescInfo : IRogueBattleMapFetterDescInfo
	{
		// Token: 0x17007F1B RID: 32539
		// (get) Token: 0x06033CCD RID: 212173 RVA: 0x00C21061 File Offset: 0x00C1F261
		// (set) Token: 0x06033CCE RID: 212174 RVA: 0x00C21069 File Offset: 0x00C1F269
		public string TextId { get; set; } = string.Empty;

		// Token: 0x17007F1C RID: 32540
		// (get) Token: 0x06033CCF RID: 212175 RVA: 0x00C21072 File Offset: 0x00C1F272
		// (set) Token: 0x06033CD0 RID: 212176 RVA: 0x00C2107A File Offset: 0x00C1F27A
		[Nullable(2)]
		public string Param { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17007F1D RID: 32541
		// (get) Token: 0x06033CD1 RID: 212177 RVA: 0x00C21083 File Offset: 0x00C1F283
		// (set) Token: 0x06033CD2 RID: 212178 RVA: 0x00C2108B File Offset: 0x00C1F28B
		public bool IsReached { get; set; }

		// Token: 0x17007F1E RID: 32542
		// (get) Token: 0x06033CD3 RID: 212179 RVA: 0x00C21094 File Offset: 0x00C1F294
		// (set) Token: 0x06033CD4 RID: 212180 RVA: 0x00C2109C File Offset: 0x00C1F29C
		public ERogueResBondEffectType EffectType { get; set; }
	}
}

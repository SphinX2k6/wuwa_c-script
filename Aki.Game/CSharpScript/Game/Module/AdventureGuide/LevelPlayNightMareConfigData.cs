using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.AdventureGuide
{
	// Token: 0x02004EB1 RID: 20145
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelPlayNightMareConfigData : ILevelPlayNightMareConfigData
	{
		// Token: 0x170062AF RID: 25263
		// (get) Token: 0x06032AC9 RID: 207561 RVA: 0x00E3734D File Offset: 0x00E3554D
		// (set) Token: 0x06032ACA RID: 207562 RVA: 0x00E37355 File Offset: 0x00E35555
		public int LevelPlayId { get; set; }

		// Token: 0x170062B0 RID: 25264
		// (get) Token: 0x06032ACB RID: 207563 RVA: 0x00E3735E File Offset: 0x00E3555E
		// (set) Token: 0x06032ACC RID: 207564 RVA: 0x00E37366 File Offset: 0x00E35566
		public string[] Vars { get; set; }

		// Token: 0x170062B1 RID: 25265
		// (get) Token: 0x06032ACD RID: 207565 RVA: 0x00E3736F File Offset: 0x00E3556F
		// (set) Token: 0x06032ACE RID: 207566 RVA: 0x00E37377 File Offset: 0x00E35577
		public int[] DefaultValues { get; set; }
	}
}

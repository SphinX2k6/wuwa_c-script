using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.AdventureGuide
{
	// Token: 0x02004EB0 RID: 20144
	[NullableContext(1)]
	public interface ILevelPlayNightMareConfigData
	{
		// Token: 0x170062AC RID: 25260
		// (get) Token: 0x06032AC3 RID: 207555
		// (set) Token: 0x06032AC4 RID: 207556
		int LevelPlayId { get; set; }

		// Token: 0x170062AD RID: 25261
		// (get) Token: 0x06032AC5 RID: 207557
		// (set) Token: 0x06032AC6 RID: 207558
		string[] Vars { get; set; }

		// Token: 0x170062AE RID: 25262
		// (get) Token: 0x06032AC7 RID: 207559
		// (set) Token: 0x06032AC8 RID: 207560
		int[] DefaultValues { get; set; }
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.AdventureGuide
{
	// Token: 0x02005ECB RID: 24267
	[NullableContext(1)]
	public interface ILevelPlayNightMareConfigData
	{
		// Token: 0x17008EDA RID: 36570
		// (get) Token: 0x0603DB33 RID: 252723
		// (set) Token: 0x0603DB34 RID: 252724
		int LevelPlayId { get; set; }

		// Token: 0x17008EDB RID: 36571
		// (get) Token: 0x0603DB35 RID: 252725
		// (set) Token: 0x0603DB36 RID: 252726
		string[] Vars { get; set; }

		// Token: 0x17008EDC RID: 36572
		// (get) Token: 0x0603DB37 RID: 252727
		// (set) Token: 0x0603DB38 RID: 252728
		int[] DefaultValues { get; set; }
	}
}

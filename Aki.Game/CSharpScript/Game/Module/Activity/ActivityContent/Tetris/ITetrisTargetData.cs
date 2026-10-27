using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02005FDA RID: 24538
	[NullableContext(1)]
	public interface ITetrisTargetData
	{
		// Token: 0x17009026 RID: 36902
		// (get) Token: 0x0603E2C5 RID: 254661
		// (set) Token: 0x0603E2C6 RID: 254662
		string Icon { get; set; }

		// Token: 0x17009027 RID: 36903
		// (get) Token: 0x0603E2C7 RID: 254663
		// (set) Token: 0x0603E2C8 RID: 254664
		int Num { get; set; }

		// Token: 0x17009028 RID: 36904
		// (get) Token: 0x0603E2C9 RID: 254665
		// (set) Token: 0x0603E2CA RID: 254666
		string Tip { get; set; }
	}
}

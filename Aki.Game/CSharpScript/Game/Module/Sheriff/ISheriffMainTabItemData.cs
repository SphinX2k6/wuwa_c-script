using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02003BED RID: 15341
	[NullableContext(1)]
	public interface ISheriffMainTabItemData
	{
		// Token: 0x17005052 RID: 20562
		// (get) Token: 0x06027572 RID: 161138
		// (set) Token: 0x06027573 RID: 161139
		ESheriffMainTabType TabType { get; set; }

		// Token: 0x17005053 RID: 20563
		// (get) Token: 0x06027574 RID: 161140
		// (set) Token: 0x06027575 RID: 161141
		string TabIcon { get; set; }

		// Token: 0x17005054 RID: 20564
		// (get) Token: 0x06027576 RID: 161142
		// (set) Token: 0x06027577 RID: 161143
		string TabTxt { get; set; }

		// Token: 0x17005055 RID: 20565
		// (get) Token: 0x06027578 RID: 161144
		// (set) Token: 0x06027579 RID: 161145
		bool? IsLock { get; set; }

		// Token: 0x17005056 RID: 20566
		// (get) Token: 0x0602757A RID: 161146
		// (set) Token: 0x0602757B RID: 161147
		EFunctionType FunctionType { get; set; }
	}
}

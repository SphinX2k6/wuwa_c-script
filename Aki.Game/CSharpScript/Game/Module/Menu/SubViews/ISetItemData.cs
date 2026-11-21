using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x02004420 RID: 17440
	[NullableContext(1)]
	public interface ISetItemData
	{
		// Token: 0x17005809 RID: 22537
		// (get) Token: 0x0602C054 RID: 180308
		// (set) Token: 0x0602C055 RID: 180309
		int Index { get; set; }

		// Token: 0x1700580A RID: 22538
		// (get) Token: 0x0602C056 RID: 180310
		// (set) Token: 0x0602C057 RID: 180311
		int Value { get; set; }

		// Token: 0x1700580B RID: 22539
		// (get) Token: 0x0602C058 RID: 180312
		// (set) Token: 0x0602C059 RID: 180313
		string Name { get; set; }
	}
}

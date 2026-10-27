using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x02005400 RID: 21504
	[NullableContext(1)]
	public interface IGameQualityLoadInfo
	{
		// Token: 0x17008426 RID: 33830
		// (get) Token: 0x06036F4E RID: 225102
		// (set) Token: 0x06036F4F RID: 225103
		string Desc { get; set; }

		// Token: 0x17008427 RID: 33831
		// (get) Token: 0x06036F50 RID: 225104
		// (set) Token: 0x06036F51 RID: 225105
		int Percentage { get; set; }

		// Token: 0x17008428 RID: 33832
		// (get) Token: 0x06036F52 RID: 225106
		// (set) Token: 0x06036F53 RID: 225107
		string BarColor { get; set; }
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x020043E3 RID: 17379
	[NullableContext(1)]
	public interface IGameQualityLoadInfo
	{
		// Token: 0x170057F2 RID: 22514
		// (get) Token: 0x0602BE96 RID: 179862
		// (set) Token: 0x0602BE97 RID: 179863
		string Desc { get; set; }

		// Token: 0x170057F3 RID: 22515
		// (get) Token: 0x0602BE98 RID: 179864
		// (set) Token: 0x0602BE99 RID: 179865
		int Percentage { get; set; }

		// Token: 0x170057F4 RID: 22516
		// (get) Token: 0x0602BE9A RID: 179866
		// (set) Token: 0x0602BE9B RID: 179867
		string BarColor { get; set; }
	}
}

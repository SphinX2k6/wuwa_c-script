using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roulette.View
{
	// Token: 0x02003C45 RID: 15429
	[NullableContext(1)]
	[Nullable(0)]
	public class GridRedDotInfo
	{
		// Token: 0x170050AE RID: 20654
		// (get) Token: 0x06027867 RID: 161895 RVA: 0x00B16862 File Offset: 0x00B14A62
		// (set) Token: 0x06027868 RID: 161896 RVA: 0x00B1686A File Offset: 0x00B14A6A
		public ERouletteExploreId Id { get; set; }

		// Token: 0x170050AF RID: 20655
		// (get) Token: 0x06027869 RID: 161897 RVA: 0x00B16873 File Offset: 0x00B14A73
		// (set) Token: 0x0602786A RID: 161898 RVA: 0x00B1687B File Offset: 0x00B14A7B
		public Func<AssemblyGridData, bool> CheckFunction { get; set; }
	}
}

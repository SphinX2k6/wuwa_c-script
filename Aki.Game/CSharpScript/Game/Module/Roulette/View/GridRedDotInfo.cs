using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roulette.View
{
	// Token: 0x02004C94 RID: 19604
	[NullableContext(1)]
	[Nullable(0)]
	public class GridRedDotInfo
	{
		// Token: 0x17007D04 RID: 32004
		// (get) Token: 0x06032AB4 RID: 207540 RVA: 0x00BD1BFE File Offset: 0x00BCFDFE
		// (set) Token: 0x06032AB5 RID: 207541 RVA: 0x00BD1C06 File Offset: 0x00BCFE06
		public ERouletteExploreId Id { get; set; }

		// Token: 0x17007D05 RID: 32005
		// (get) Token: 0x06032AB6 RID: 207542 RVA: 0x00BD1C0F File Offset: 0x00BCFE0F
		// (set) Token: 0x06032AB7 RID: 207543 RVA: 0x00BD1C17 File Offset: 0x00BCFE17
		public Func<AssemblyGridData, bool> CheckFunction { get; set; }
	}
}

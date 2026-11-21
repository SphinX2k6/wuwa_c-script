using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;

namespace CSharpScript.Game.Module.PhantomArena.Battle
{
	// Token: 0x0200420E RID: 16910
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleLoadingInfo : IPhantomArenaBattleLoadingInfo
	{
		// Token: 0x17005610 RID: 22032
		// (get) Token: 0x0602AB88 RID: 174984 RVA: 0x00C075E0 File Offset: 0x00C057E0
		// (set) Token: 0x0602AB89 RID: 174985 RVA: 0x00C075E8 File Offset: 0x00C057E8
		public int Index { get; set; }

		// Token: 0x17005611 RID: 22033
		// (get) Token: 0x0602AB8A RID: 174986 RVA: 0x00C075F1 File Offset: 0x00C057F1
		// (set) Token: 0x0602AB8B RID: 174987 RVA: 0x00C075F9 File Offset: 0x00C057F9
		public bool IsMe { get; set; }

		// Token: 0x17005612 RID: 22034
		// (get) Token: 0x0602AB8C RID: 174988 RVA: 0x00C07602 File Offset: 0x00C05802
		// (set) Token: 0x0602AB8D RID: 174989 RVA: 0x00C0760A File Offset: 0x00C0580A
		public PhantomCardData CardData { get; set; }
	}
}

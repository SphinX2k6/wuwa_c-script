using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A00 RID: 14848
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseResultViewInfo : ITrapDefenseResultViewInfo
	{
		// Token: 0x17004E1F RID: 19999
		// (get) Token: 0x06026371 RID: 156529 RVA: 0x00AB6417 File Offset: 0x00AB4617
		// (set) Token: 0x06026372 RID: 156530 RVA: 0x00AB641F File Offset: 0x00AB461F
		public TrapDefenseChallengeResultNotify Notify { get; set; }

		// Token: 0x17004E20 RID: 20000
		// (get) Token: 0x06026373 RID: 156531 RVA: 0x00AB6428 File Offset: 0x00AB4628
		// (set) Token: 0x06026374 RID: 156532 RVA: 0x00AB6430 File Offset: 0x00AB4630
		public bool NeedShowViewAnim { get; set; }
	}
}

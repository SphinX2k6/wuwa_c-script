using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A58 RID: 19032
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseResultViewInfo : ITrapDefenseResultViewInfo
	{
		// Token: 0x17007A72 RID: 31346
		// (get) Token: 0x060315E1 RID: 202209 RVA: 0x00B72493 File Offset: 0x00B70693
		// (set) Token: 0x060315E2 RID: 202210 RVA: 0x00B7249B File Offset: 0x00B7069B
		public TrapDefenseChallengeResultNotify Notify { get; set; }

		// Token: 0x17007A73 RID: 31347
		// (get) Token: 0x060315E3 RID: 202211 RVA: 0x00B724A4 File Offset: 0x00B706A4
		// (set) Token: 0x060315E4 RID: 202212 RVA: 0x00B724AC File Offset: 0x00B706AC
		public bool NeedShowViewAnim { get; set; }
	}
}

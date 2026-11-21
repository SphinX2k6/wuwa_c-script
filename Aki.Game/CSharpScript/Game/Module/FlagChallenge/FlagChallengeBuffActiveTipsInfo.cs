using System;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02004A11 RID: 18961
	public class FlagChallengeBuffActiveTipsInfo : IFlagChallengeBuffActiveTipsInfo
	{
		// Token: 0x17005FB0 RID: 24496
		// (get) Token: 0x0602F8A3 RID: 194723 RVA: 0x00D4183B File Offset: 0x00D3FA3B
		// (set) Token: 0x0602F8A4 RID: 194724 RVA: 0x00D41843 File Offset: 0x00D3FA43
		public int BuffId { get; set; }

		// Token: 0x17005FB1 RID: 24497
		// (get) Token: 0x0602F8A5 RID: 194725 RVA: 0x00D4184C File Offset: 0x00D3FA4C
		// (set) Token: 0x0602F8A6 RID: 194726 RVA: 0x00D41854 File Offset: 0x00D3FA54
		public EFlagChallengeBuffStatus State { get; set; }
	}
}

using System;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02004A10 RID: 18960
	public interface IFlagChallengeBuffActiveTipsInfo
	{
		// Token: 0x17005FAE RID: 24494
		// (get) Token: 0x0602F89F RID: 194719
		// (set) Token: 0x0602F8A0 RID: 194720
		int BuffId { get; set; }

		// Token: 0x17005FAF RID: 24495
		// (get) Token: 0x0602F8A1 RID: 194721
		// (set) Token: 0x0602F8A2 RID: 194722
		EFlagChallengeBuffStatus State { get; set; }
	}
}

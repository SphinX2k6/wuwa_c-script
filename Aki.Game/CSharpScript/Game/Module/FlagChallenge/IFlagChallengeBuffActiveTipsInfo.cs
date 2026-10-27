using System;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02005A34 RID: 23092
	public interface IFlagChallengeBuffActiveTipsInfo
	{
		// Token: 0x17008BE0 RID: 35808
		// (get) Token: 0x0603A956 RID: 239958
		// (set) Token: 0x0603A957 RID: 239959
		int BuffId { get; set; }

		// Token: 0x17008BE1 RID: 35809
		// (get) Token: 0x0603A958 RID: 239960
		// (set) Token: 0x0603A959 RID: 239961
		EFlagChallengeBuffStatus State { get; set; }
	}
}

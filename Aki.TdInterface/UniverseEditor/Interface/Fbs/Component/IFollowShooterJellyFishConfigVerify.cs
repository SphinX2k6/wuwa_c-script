using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005810 RID: 22544
	public static class IFollowShooterJellyFishConfigVerify
	{
		// Token: 0x06024799 RID: 149401 RVA: 0x00503124 File Offset: 0x00501324
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFollowShooterJellyFishConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFollowShooterJellyFishConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IFollowShooterMontageVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200838A RID: 33674
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145ED RID: 83437
			public static VerifyTableAction <0>__Verify;
		}
	}
}

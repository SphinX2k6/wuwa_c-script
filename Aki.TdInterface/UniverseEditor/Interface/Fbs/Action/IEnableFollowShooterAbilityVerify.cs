using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CD0 RID: 27856
	public static class IEnableFollowShooterAbilityVerify
	{
		// Token: 0x0603003B RID: 196667 RVA: 0x00688A1C File Offset: 0x00686C1C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEnableFollowShooterAbilityVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEnableFollowShooterAbilityVerify.<>O.<0>__Verify = new VerifyTableAction(IFollowShooterJellyFishAbilityVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020085C3 RID: 34243
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014973 RID: 84339
			public static VerifyTableAction <0>__Verify;
		}
	}
}

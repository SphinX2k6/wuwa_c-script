using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200665F RID: 26207
	public static class IEnableFollowShooterAbilityVerify
	{
		// Token: 0x0602D86A RID: 186474 RVA: 0x0063BEB4 File Offset: 0x0063A0B4
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

		// Token: 0x02007D4C RID: 32076
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138C7 RID: 80071
			public static VerifyTableAction <0>__Verify;
		}
	}
}

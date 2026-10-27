using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F89 RID: 28553
	public static class ISequenceUnlockPointsVerify
	{
		// Token: 0x06032757 RID: 206679 RVA: 0x006CFAA4 File Offset: 0x006CDCA4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISequenceUnlockPointsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISequenceUnlockPointsVerify.<>O.<0>__Verify = new VerifyTableAction(ISequenceInteractStageVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E2A RID: 32298
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139E7 RID: 80359
			public static VerifyTableAction <0>__Verify;
		}
	}
}

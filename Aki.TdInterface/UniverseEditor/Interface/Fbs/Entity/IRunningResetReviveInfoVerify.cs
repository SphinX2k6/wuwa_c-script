using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C57 RID: 19543
	public static class IRunningResetReviveInfoVerify
	{
		// Token: 0x0601DFB6 RID: 122806 RVA: 0x00434194 File Offset: 0x00432394
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRunningResetReviveInfoVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRunningResetReviveInfoVerify.<>O.<0>__Verify = new VerifyTableAction(IInstEntityDataVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IRunningResetReviveInfoVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IRunningResetReviveInfoVerify.<>O.<0>__Verify = new VerifyTableAction(IInstEntityDataVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200824E RID: 33358
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401441B RID: 82971
			public static VerifyTableAction <0>__Verify;
		}
	}
}

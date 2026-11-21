using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DE1 RID: 24033
	public static class IRagDollClimbingPointVerify
	{
		// Token: 0x06028187 RID: 164231 RVA: 0x0057BBD4 File Offset: 0x00579DD4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRagDollClimbingPointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRagDollClimbingPointVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IRagDollClimbingPointVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IRagDollClimbingPointVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IRagDollClimbingPointVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (IRagDollClimbingPointVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 12;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IRagDollClimbingPointVerify.<>O.<1>__Verify) == null)
							{
								verifyAction4 = (IRagDollClimbingPointVerify.<>O.<1>__Verify = new VerifyTableAction(IClientHookActionConfigVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02008463 RID: 33891
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014760 RID: 83808
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014761 RID: 83809
			public static VerifyTableAction <1>__Verify;
		}
	}
}

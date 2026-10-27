using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057DA RID: 22490
	public static class IRagDollClimbingPointVerify
	{
		// Token: 0x06025C67 RID: 154727 RVA: 0x00535A48 File Offset: 0x00533C48
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

		// Token: 0x02007BF5 RID: 31733
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136C0 RID: 79552
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040136C1 RID: 79553
			public static VerifyTableAction <1>__Verify;
		}
	}
}

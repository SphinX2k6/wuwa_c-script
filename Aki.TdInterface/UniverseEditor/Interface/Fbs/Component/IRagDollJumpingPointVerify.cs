using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057DD RID: 22493
	public static class IRagDollJumpingPointVerify
	{
		// Token: 0x06025C9F RID: 154783 RVA: 0x00536410 File Offset: 0x00534610
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRagDollJumpingPointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRagDollJumpingPointVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IRagDollJumpingPointVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IRagDollJumpingPointVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IRagDollJumpingPointVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (IRagDollJumpingPointVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 12;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IRagDollJumpingPointVerify.<>O.<1>__Verify) == null)
							{
								verifyAction4 = (IRagDollJumpingPointVerify.<>O.<1>__Verify = new VerifyTableAction(IClientHookActionConfigVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007BF6 RID: 31734
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136C2 RID: 79554
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040136C3 RID: 79555
			public static VerifyTableAction <1>__Verify;
		}
	}
}

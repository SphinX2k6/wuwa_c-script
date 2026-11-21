using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B51 RID: 23377
	public static class IMotorEjectHookVerify
	{
		// Token: 0x0602676D RID: 157549 RVA: 0x005445F0 File Offset: 0x005427F0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMotorEjectHookVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMotorEjectHookVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IMotorEjectHookVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IMotorEjectHookVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IMotorEjectHookVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (IMotorEjectHookVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 12;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IMotorEjectHookVerify.<>O.<1>__Verify) == null)
							{
								verifyAction4 = (IMotorEjectHookVerify.<>O.<1>__Verify = new VerifyTableAction(IClientHookActionConfigVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 20, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 22, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 24, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 26, 1UL, 1UL, false))
							{
								short typeIdVOffset = 26;
								short valueVOffset = 28;
								VerifyUnionAction verifyAction5;
								if ((verifyAction5 = IMotorEjectHookVerify.<>O.<2>__Verify) == null)
								{
									verifyAction5 = (IMotorEjectHookVerify.<>O.<2>__Verify = new VerifyUnionAction(TMotorAutoEjectConfigVerify.Verify));
								}
								if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction5, false) && verifier.VerifyField(tablePos, 30, 1UL, 1UL, false))
								{
									return verifier.VerifyTableEnd(tablePos);
								}
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x020083F9 RID: 33785
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040146B3 RID: 83635
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040146B4 RID: 83636
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040146B5 RID: 83637
			public static VerifyUnionAction <2>__Verify;
		}
	}
}

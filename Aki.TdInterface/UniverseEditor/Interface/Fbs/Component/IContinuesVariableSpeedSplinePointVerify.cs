using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005585 RID: 21893
	public static class IContinuesVariableSpeedSplinePointVerify
	{
		// Token: 0x06022CEE RID: 142574 RVA: 0x004CB644 File Offset: 0x004C9844
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IContinuesVariableSpeedSplinePointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IContinuesVariableSpeedSplinePointVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IContinuesVariableSpeedSplinePointVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IContinuesVariableSpeedSplinePointVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 8;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IContinuesVariableSpeedSplinePointVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (IContinuesVariableSpeedSplinePointVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
						{
							short offsetId4 = 12;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IContinuesVariableSpeedSplinePointVerify.<>O.<0>__Verify) == null)
							{
								verifyAction4 = (IContinuesVariableSpeedSplinePointVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false))
							{
								short offsetId5 = 14;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = IContinuesVariableSpeedSplinePointVerify.<>O.<1>__Verify) == null)
								{
									verifyAction5 = (IContinuesVariableSpeedSplinePointVerify.<>O.<1>__Verify = new VerifyTableAction(ITimePathConfigVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId5, verifyAction5, false))
								{
									short offsetId6 = 16;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = IContinuesVariableSpeedSplinePointVerify.<>O.<2>__Verify) == null)
									{
										verifyAction6 = (IContinuesVariableSpeedSplinePointVerify.<>O.<2>__Verify = new VerifyTableAction(IConditionActionVerify.Verify));
									}
									if (verifier.VerifyVectorOfTables(tablePos, offsetId6, verifyAction6, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
									{
										return verifier.VerifyTableEnd(tablePos);
									}
								}
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02008323 RID: 33571
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014542 RID: 83266
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014543 RID: 83267
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04014544 RID: 83268
			public static VerifyTableAction <2>__Verify;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005715 RID: 22293
	public static class IPatrolSplinePointVerify
	{
		// Token: 0x060254BC RID: 152764 RVA: 0x0052582C File Offset: 0x00523A2C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPatrolSplinePointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPatrolSplinePointVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IPatrolSplinePointVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IPatrolSplinePointVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 8;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IPatrolSplinePointVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (IPatrolSplinePointVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
						{
							short offsetId4 = 12;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IPatrolSplinePointVerify.<>O.<0>__Verify) == null)
							{
								verifyAction4 = (IPatrolSplinePointVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 22, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false))
							{
								short offsetId5 = 26;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = IPatrolSplinePointVerify.<>O.<1>__Verify) == null)
								{
									verifyAction5 = (IPatrolSplinePointVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
								}
								if (verifier.VerifyVectorOfTables(tablePos, offsetId5, verifyAction5, false) && verifier.VerifyField(tablePos, 28, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 30, 1UL, 1UL, false))
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

		// Token: 0x02007BD2 RID: 31698
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401368C RID: 79500
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401368D RID: 79501
			public static VerifyTableAction <1>__Verify;
		}
	}
}

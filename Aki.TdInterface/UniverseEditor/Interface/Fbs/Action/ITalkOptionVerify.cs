using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AF9 RID: 31481
	public static class ITalkOptionVerify
	{
		// Token: 0x06038B14 RID: 232212 RVA: 0x007AB6E8 File Offset: 0x007A98E8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false))
			{
				short offsetId = 14;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITalkOptionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITalkOptionVerify.<>O.<0>__Verify = new VerifyTableAction(IChangeIconVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
				{
					short offsetId2 = 18;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITalkOptionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITalkOptionVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false))
					{
						short typeIdVOffset = 22;
						short valueVOffset = 24;
						VerifyUnionAction verifyAction3;
						if ((verifyAction3 = ITalkOptionVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ITalkOptionVerify.<>O.<2>__Verify = new VerifyUnionAction(TTalkOptionPreConditionVerify.Verify));
						}
						if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction3, false) && verifier.VerifyField(tablePos, 26, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 28, 1UL, 1UL, false))
						{
							short offsetId3 = 30;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = ITalkOptionVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (ITalkOptionVerify.<>O.<3>__Verify = new VerifyTableAction(IOptionLockTipVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId3, verifyAction4, false) && verifier.VerifyField(tablePos, 32, 1UL, 1UL, false))
							{
								short typeIdVOffset2 = 32;
								short valueVOffset2 = 34;
								VerifyUnionAction verifyAction5;
								if ((verifyAction5 = ITalkOptionVerify.<>O.<4>__Verify) == null)
								{
									verifyAction5 = (ITalkOptionVerify.<>O.<4>__Verify = new VerifyUnionAction(TTalkOptionParamVerify.Verify));
								}
								if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction5, false) && verifier.VerifyField(tablePos, 36, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 38, 2UL, 2UL, false))
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

		// Token: 0x0200872D RID: 34605
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CA1 RID: 85153
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014CA2 RID: 85154
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04014CA3 RID: 85155
			public static VerifyUnionAction <2>__Verify;

			// Token: 0x04014CA4 RID: 85156
			public static VerifyTableAction <3>__Verify;

			// Token: 0x04014CA5 RID: 85157
			public static VerifyUnionAction <4>__Verify;
		}
	}
}

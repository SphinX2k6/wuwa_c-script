using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060D8 RID: 24792
	public static class ITrampleComponentVerify
	{
		// Token: 0x06029FCA RID: 171978 RVA: 0x005BB324 File Offset: 0x005B9524
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITrampleComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITrampleComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITrampleComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITrampleComponentVerify.<>O.<1>__Verify = new VerifyTableAction(ITrampleRayDetectionVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ITrampleComponentVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ITrampleComponentVerify.<>O.<2>__Verify = new VerifyTableAction(IEntityMatchVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyVectorOfData(tablePos, 12, 1UL, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 20, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false))
						{
							short offsetId4 = 24;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = ITrampleComponentVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (ITrampleComponentVerify.<>O.<3>__Verify = new VerifyTableAction(IEnterLeaveRadiusVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 26, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 28, 1UL, 1UL, false))
							{
								short typeIdVOffset = 28;
								short valueVOffset = 30;
								VerifyUnionAction verifyAction5;
								if ((verifyAction5 = ITrampleComponentVerify.<>O.<4>__Verify) == null)
								{
									verifyAction5 = (ITrampleComponentVerify.<>O.<4>__Verify = new VerifyUnionAction(TTrampleTipOptionVerify.Verify));
								}
								if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction5, false))
								{
									short offsetId5 = 32;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = ITrampleComponentVerify.<>O.<5>__Verify) == null)
									{
										verifyAction6 = (ITrampleComponentVerify.<>O.<5>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
									}
									if (verifier.VerifyVectorOfTables(tablePos, offsetId5, verifyAction6, false))
									{
										short offsetId6 = 34;
										VerifyTableAction verifyAction7;
										if ((verifyAction7 = ITrampleComponentVerify.<>O.<5>__Verify) == null)
										{
											verifyAction7 = (ITrampleComponentVerify.<>O.<5>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
										}
										if (verifier.VerifyVectorOfTables(tablePos, offsetId6, verifyAction7, false) && verifier.VerifyField(tablePos, 36, 1UL, 1UL, false))
										{
											return verifier.VerifyTableEnd(tablePos);
										}
									}
								}
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x020084D9 RID: 34009
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014824 RID: 84004
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014825 RID: 84005
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04014826 RID: 84006
			public static VerifyTableAction <2>__Verify;

			// Token: 0x04014827 RID: 84007
			public static VerifyTableAction <3>__Verify;

			// Token: 0x04014828 RID: 84008
			public static VerifyUnionAction <4>__Verify;

			// Token: 0x04014829 RID: 84009
			public static VerifyTableAction <5>__Verify;
		}
	}
}

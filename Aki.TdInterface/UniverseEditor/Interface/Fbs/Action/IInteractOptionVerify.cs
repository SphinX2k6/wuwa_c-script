using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006995 RID: 27029
	public static class IInteractOptionVerify
	{
		// Token: 0x0602F38B RID: 193419 RVA: 0x0066E9B4 File Offset: 0x0066CBB4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IInteractOptionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IInteractOptionVerify.<>O.<0>__Verify = new VerifyUnionAction(TInteractOptionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 12, false))
				{
					short offsetId = 14;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IInteractOptionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IInteractOptionVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false))
					{
						short offsetId2 = 16;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IInteractOptionVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IInteractOptionVerify.<>O.<2>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId2, verifyAction3, false))
						{
							short offsetId3 = 18;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IInteractOptionVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (IInteractOptionVerify.<>O.<3>__Verify = new VerifyTableAction(IInteractOptionConfirmBoxVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId3, verifyAction4, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 24, 4UL, 4UL, false))
							{
								short offsetId4 = 26;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = IInteractOptionVerify.<>O.<4>__Verify) == null)
								{
									verifyAction5 = (IInteractOptionVerify.<>O.<4>__Verify = new VerifyTableAction(IDurationInteractVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId4, verifyAction5, false))
								{
									short offsetId5 = 28;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = IInteractOptionVerify.<>O.<5>__Verify) == null)
									{
										verifyAction6 = (IInteractOptionVerify.<>O.<5>__Verify = new VerifyTableAction(IOptionLockTipVerify.Verify));
									}
									if (verifier.VerifyTable(tablePos, offsetId5, verifyAction6, false) && verifier.VerifyVectorOfData(tablePos, 30, 1UL, false))
									{
										short offsetId6 = 32;
										VerifyTableAction verifyAction7;
										if ((verifyAction7 = IInteractOptionVerify.<>O.<6>__Verify) == null)
										{
											verifyAction7 = (IInteractOptionVerify.<>O.<6>__Verify = new VerifyTableAction(ILongPressInteractConfigVerify.Verify));
										}
										if (verifier.VerifyTable(tablePos, offsetId6, verifyAction7, false) && verifier.VerifyField(tablePos, 34, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 36, 1UL, 1UL, false))
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

		// Token: 0x02007D8F RID: 32143
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013919 RID: 80153
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x0401391A RID: 80154
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401391B RID: 80155
			public static VerifyTableAction <2>__Verify;

			// Token: 0x0401391C RID: 80156
			public static VerifyTableAction <3>__Verify;

			// Token: 0x0401391D RID: 80157
			public static VerifyTableAction <4>__Verify;

			// Token: 0x0401391E RID: 80158
			public static VerifyTableAction <5>__Verify;

			// Token: 0x0401391F RID: 80159
			public static VerifyTableAction <6>__Verify;
		}
	}
}

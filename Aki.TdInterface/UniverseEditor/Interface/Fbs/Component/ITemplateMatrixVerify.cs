using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006064 RID: 24676
	public static class ITemplateMatrixVerify
	{
		// Token: 0x06029B07 RID: 170759 RVA: 0x005B1224 File Offset: 0x005AF424
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITemplateMatrixVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITemplateMatrixVerify.<>O.<0>__Verify = new VerifyTableAction(IVector2Verify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITemplateMatrixVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITemplateMatrixVerify.<>O.<1>__Verify = new VerifyTableAction(ITemplateMatrixRowVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ITemplateMatrixVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ITemplateMatrixVerify.<>O.<2>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
						{
							short offsetId4 = 14;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = ITemplateMatrixVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (ITemplateMatrixVerify.<>O.<3>__Verify = new VerifyTableAction(IGroupDestroyListenConfigVerify.Verify));
							}
							if (verifier.VerifyVectorOfTables(tablePos, offsetId4, verifyAction4, false))
							{
								short offsetId5 = 16;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = ITemplateMatrixVerify.<>O.<4>__Verify) == null)
								{
									verifyAction5 = (ITemplateMatrixVerify.<>O.<4>__Verify = new VerifyTableAction(IChildEntityStateControlVerify.Verify));
								}
								if (verifier.VerifyVectorOfTables(tablePos, offsetId5, verifyAction5, false))
								{
									short offsetId6 = 18;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = ITemplateMatrixVerify.<>O.<5>__Verify) == null)
									{
										verifyAction6 = (ITemplateMatrixVerify.<>O.<5>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
									}
									if (verifier.VerifyVectorOfTables(tablePos, offsetId6, verifyAction6, false))
									{
										short offsetId7 = 20;
										VerifyTableAction verifyAction7;
										if ((verifyAction7 = ITemplateMatrixVerify.<>O.<6>__Verify) == null)
										{
											verifyAction7 = (ITemplateMatrixVerify.<>O.<6>__Verify = new VerifyTableAction(IChangeTemplateInstanceStateConfigVerify.Verify));
										}
										if (verifier.VerifyTable(tablePos, offsetId7, verifyAction7, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false))
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

		// Token: 0x020084C6 RID: 33990
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014803 RID: 83971
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014804 RID: 83972
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04014805 RID: 83973
			public static VerifyTableAction <2>__Verify;

			// Token: 0x04014806 RID: 83974
			public static VerifyTableAction <3>__Verify;

			// Token: 0x04014807 RID: 83975
			public static VerifyTableAction <4>__Verify;

			// Token: 0x04014808 RID: 83976
			public static VerifyTableAction <5>__Verify;

			// Token: 0x04014809 RID: 83977
			public static VerifyTableAction <6>__Verify;
		}
	}
}

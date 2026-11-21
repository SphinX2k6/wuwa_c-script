using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058B2 RID: 22706
	public static class IGravityHookVerify
	{
		// Token: 0x06024DA7 RID: 150951 RVA: 0x0050F9FC File Offset: 0x0050DBFC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGravityHookVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGravityHookVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IGravityHookVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IGravityHookVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IGravityHookVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (IGravityHookVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 12;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IGravityHookVerify.<>O.<1>__Verify) == null)
							{
								verifyAction4 = (IGravityHookVerify.<>O.<1>__Verify = new VerifyTableAction(IClientHookActionConfigVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
							{
								short typeIdVOffset = 14;
								short valueVOffset = 16;
								VerifyUnionAction verifyAction5;
								if ((verifyAction5 = IGravityHookVerify.<>O.<2>__Verify) == null)
								{
									verifyAction5 = (IGravityHookVerify.<>O.<2>__Verify = new VerifyUnionAction(TGravityDirectionVerify.Verify));
								}
								if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction5, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 20, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false))
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

		// Token: 0x020083A8 RID: 33704
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014618 RID: 83480
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014619 RID: 83481
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401461A RID: 83482
			public static VerifyUnionAction <2>__Verify;
		}
	}
}

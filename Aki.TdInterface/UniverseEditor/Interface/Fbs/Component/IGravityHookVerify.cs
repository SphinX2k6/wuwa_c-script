using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200532C RID: 21292
	public static class IGravityHookVerify
	{
		// Token: 0x06022CF3 RID: 142579 RVA: 0x004D2B28 File Offset: 0x004D0D28
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

		// Token: 0x02007B49 RID: 31561
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013593 RID: 79251
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013594 RID: 79252
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013595 RID: 79253
			public static VerifyUnionAction <2>__Verify;
		}
	}
}

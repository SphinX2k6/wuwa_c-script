using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005541 RID: 21825
	public static class IMechHookVerify
	{
		// Token: 0x06024122 RID: 147746 RVA: 0x004FBBB4 File Offset: 0x004F9DB4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMechHookVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMechHookVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IMechHookVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IMechHookVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IMechHookVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (IMechHookVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 12;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IMechHookVerify.<>O.<1>__Verify) == null)
							{
								verifyAction4 = (IMechHookVerify.<>O.<1>__Verify = new VerifyTableAction(IClientHookActionConfigVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
							{
								short typeIdVOffset = 14;
								short valueVOffset = 16;
								VerifyUnionAction verifyAction5;
								if ((verifyAction5 = IMechHookVerify.<>O.<2>__Verify) == null)
								{
									verifyAction5 = (IMechHookVerify.<>O.<2>__Verify = new VerifyUnionAction(TMechHookConfigVerify.Verify));
								}
								if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction5, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
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

		// Token: 0x02007B8D RID: 31629
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013612 RID: 79378
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013613 RID: 79379
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013614 RID: 79380
			public static VerifyUnionAction <2>__Verify;
		}
	}
}

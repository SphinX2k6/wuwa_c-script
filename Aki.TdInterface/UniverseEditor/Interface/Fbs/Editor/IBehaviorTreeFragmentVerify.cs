using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;
using Aki.UniverseEditor.Interface.Fbs.SyncBlock;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004C8D RID: 19597
	public static class IBehaviorTreeFragmentVerify
	{
		// Token: 0x0601E0BF RID: 123071 RVA: 0x004361E0 File Offset: 0x004343E0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyVectorOfStrings(tablePos, 6, false) && verifier.VerifyVectorOfStrings(tablePos, 8, false) && verifier.VerifyVectorOfStrings(tablePos, 10, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 16, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
			{
				short offsetId = 22;
				VerifyTableAction verifyAction;
				if ((verifyAction = IBehaviorTreeFragmentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBehaviorTreeFragmentVerify.<>O.<0>__Verify = new VerifyTableAction(IBehaviorTreeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false) && verifier.VerifyVectorOfStrings(tablePos, 26, false) && verifier.VerifyString(tablePos, 28, false))
				{
					short offsetId2 = 30;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IBehaviorTreeFragmentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IBehaviorTreeFragmentVerify.<>O.<1>__Verify = new VerifyTableAction(IPlaceholderVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 32, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008251 RID: 33361
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401441E RID: 82974
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401441F RID: 82975
			public static VerifyTableAction <1>__Verify;
		}
	}
}

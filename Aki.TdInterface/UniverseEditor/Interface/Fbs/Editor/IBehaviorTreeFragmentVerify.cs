using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;
using Aki.UniverseEditor.Interface.Fbs.SyncBlock;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004825 RID: 18469
	public static class IBehaviorTreeFragmentVerify
	{
		// Token: 0x0601C8C2 RID: 116930 RVA: 0x00409890 File Offset: 0x00407A90
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

		// Token: 0x02007A08 RID: 31240
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133B7 RID: 78775
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040133B8 RID: 78776
			public static VerifyTableAction <1>__Verify;
		}
	}
}

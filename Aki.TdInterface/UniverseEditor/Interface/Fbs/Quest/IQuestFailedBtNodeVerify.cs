using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004417 RID: 17431
	public static class IQuestFailedBtNodeVerify
	{
		// Token: 0x06018E6B RID: 101995 RVA: 0x0038CE5C File Offset: 0x0038B05C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 8, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IQuestFailedBtNodeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQuestFailedBtNodeVerify.<>O.<0>__Verify = new VerifyTableAction(IFixProcessorVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
				{
					short offsetId2 = 20;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IQuestFailedBtNodeVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IQuestFailedBtNodeVerify.<>O.<1>__Verify = new VerifyTableAction(IQuestFailedConditionVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 22;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IQuestFailedBtNodeVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IQuestFailedBtNodeVerify.<>O.<2>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0200816E RID: 33134
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014282 RID: 82562
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014283 RID: 82563
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04014284 RID: 82564
			public static VerifyTableAction <2>__Verify;
		}
	}
}

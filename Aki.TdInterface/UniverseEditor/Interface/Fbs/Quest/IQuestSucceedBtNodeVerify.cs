using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004063 RID: 16483
	public static class IQuestSucceedBtNodeVerify
	{
		// Token: 0x06017EB8 RID: 97976 RVA: 0x00373BD8 File Offset: 0x00371DD8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 8, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IQuestSucceedBtNodeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQuestSucceedBtNodeVerify.<>O.<0>__Verify = new VerifyTableAction(IFixProcessorVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					short offsetId2 = 16;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IQuestSucceedBtNodeVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IQuestSucceedBtNodeVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007943 RID: 31043
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401325D RID: 78429
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401325E RID: 78430
			public static VerifyTableAction <1>__Verify;
		}
	}
}

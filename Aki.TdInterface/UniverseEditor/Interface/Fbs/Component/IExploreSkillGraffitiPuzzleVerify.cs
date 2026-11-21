using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200574A RID: 22346
	public static class IExploreSkillGraffitiPuzzleVerify
	{
		// Token: 0x06023F97 RID: 147351 RVA: 0x004F1F10 File Offset: 0x004F0110
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IExploreSkillGraffitiPuzzleVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IExploreSkillGraffitiPuzzleVerify.<>O.<0>__Verify = new VerifyTableAction(IGraffitiPointPairVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 10, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false))
				{
					short offsetId2 = 14;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IExploreSkillGraffitiPuzzleVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IExploreSkillGraffitiPuzzleVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200836A RID: 33642
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145BA RID: 83386
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040145BB RID: 83387
			public static VerifyTableAction <1>__Verify;
		}
	}
}

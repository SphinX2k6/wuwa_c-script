using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075B2 RID: 30130
	public static class IVisualNovelPerformanceModifyRoleVerify
	{
		// Token: 0x06036D9B RID: 224667 RVA: 0x007721B0 File Offset: 0x007703B0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IVisualNovelPerformanceModifyRoleVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVisualNovelPerformanceModifyRoleVerify.<>O.<0>__Verify = new VerifyTableAction(IVisualNovelPortraitTransformVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IVisualNovelPerformanceModifyRoleVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IVisualNovelPerformanceModifyRoleVerify.<>O.<1>__Verify = new VerifyTableAction(IVisualNovelRoleConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007ED2 RID: 32466
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013C21 RID: 80929
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013C22 RID: 80930
			public static VerifyTableAction <1>__Verify;
		}
	}
}

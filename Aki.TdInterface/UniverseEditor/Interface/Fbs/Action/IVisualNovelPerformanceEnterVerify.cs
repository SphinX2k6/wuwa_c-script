using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D9F RID: 32159
	public static class IVisualNovelPerformanceEnterVerify
	{
		// Token: 0x0603A129 RID: 237865 RVA: 0x007D4128 File Offset: 0x007D2328
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IVisualNovelPerformanceEnterVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVisualNovelPerformanceEnterVerify.<>O.<0>__Verify = new VerifyTableAction(IVisualNovelPortraitTransformVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false))
				{
					short offsetId2 = 14;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IVisualNovelPerformanceEnterVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IVisualNovelPerformanceEnterVerify.<>O.<1>__Verify = new VerifyTableAction(IVisualNovelRoleConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008768 RID: 34664
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CF6 RID: 85238
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014CF7 RID: 85239
			public static VerifyTableAction <1>__Verify;
		}
	}
}

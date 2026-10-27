using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075A6 RID: 30118
	public static class IVisualNovelPerformanceEnterVerify
	{
		// Token: 0x06036CFB RID: 224507 RVA: 0x00770BA8 File Offset: 0x0076EDA8
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

		// Token: 0x02007ECE RID: 32462
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013C1C RID: 80924
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013C1D RID: 80925
			public static VerifyTableAction <1>__Verify;
		}
	}
}

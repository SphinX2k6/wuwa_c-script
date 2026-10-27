using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004183 RID: 16771
	public static class ITakePhoto2PhotoTargetEntityTargetVerify
	{
		// Token: 0x06018A9E RID: 101022 RVA: 0x0038D83C File Offset: 0x0038BA3C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITakePhoto2PhotoTargetEntityTargetVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITakePhoto2PhotoTargetEntityTargetVerify.<>O.<0>__Verify = new VerifyTableAction(ITakePhoto2TargetCameraDistanceConditionVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
				{
					short offsetId2 = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITakePhoto2PhotoTargetEntityTargetVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITakePhoto2PhotoTargetEntityTargetVerify.<>O.<1>__Verify = new VerifyTableAction(ITakePhoto2TargetPosByRangeConditionVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200795C RID: 31068
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040132B1 RID: 78513
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040132B2 RID: 78514
			public static VerifyTableAction <1>__Verify;
		}
	}
}

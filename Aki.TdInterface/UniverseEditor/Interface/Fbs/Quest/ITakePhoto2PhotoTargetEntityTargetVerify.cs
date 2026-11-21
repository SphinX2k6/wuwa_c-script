using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045D6 RID: 17878
	public static class ITakePhoto2PhotoTargetEntityTargetVerify
	{
		// Token: 0x0601A1D4 RID: 106964 RVA: 0x003B89D0 File Offset: 0x003B6BD0
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

		// Token: 0x020081A5 RID: 33189
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014317 RID: 82711
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014318 RID: 82712
			public static VerifyTableAction <1>__Verify;
		}
	}
}

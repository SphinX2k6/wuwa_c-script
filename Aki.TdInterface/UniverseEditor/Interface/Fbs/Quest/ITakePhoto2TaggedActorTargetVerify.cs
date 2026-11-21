using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045E5 RID: 17893
	public static class ITakePhoto2TaggedActorTargetVerify
	{
		// Token: 0x0601A246 RID: 107078 RVA: 0x003B95B8 File Offset: 0x003B77B8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITakePhoto2TaggedActorTargetVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITakePhoto2TaggedActorTargetVerify.<>O.<0>__Verify = new VerifyTableAction(ITakePhoto2TargetCameraDistanceConditionVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 10, false))
				{
					short offsetId2 = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITakePhoto2TaggedActorTargetVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITakePhoto2TaggedActorTargetVerify.<>O.<1>__Verify = new VerifyTableAction(ITakePhoto2TargetPosByRangeConditionVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020081A6 RID: 33190
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014319 RID: 82713
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401431A RID: 82714
			public static VerifyTableAction <1>__Verify;
		}
	}
}

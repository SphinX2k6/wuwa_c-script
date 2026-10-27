using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B64 RID: 19300
	public static class ICheckTrafficBlockedVerify
	{
		// Token: 0x0601E684 RID: 124548 RVA: 0x00442590 File Offset: 0x00440790
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICheckTrafficBlockedVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckTrafficBlockedVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ICheckTrafficBlockedVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ICheckTrafficBlockedVerify.<>O.<1>__Verify = new VerifyTableAction(ITrafficMatchTargetVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007A4F RID: 31311
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013416 RID: 78870
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04013417 RID: 78871
			public static VerifyTableAction <1>__Verify;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007910 RID: 30992
	public static class ISlidePerformStartVerify
	{
		// Token: 0x06036925 RID: 223525 RVA: 0x0074DD80 File Offset: 0x0074BF80
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISlidePerformStartVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISlidePerformStartVerify.<>O.<0>__Verify = new VerifyUnionAction(TCommonTargetVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
				{
					short offsetId = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ISlidePerformStartVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ISlidePerformStartVerify.<>O.<1>__Verify = new VerifyTableAction(ISlopeSlidePerformStartVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020086FA RID: 34554
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014B15 RID: 84757
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04014B16 RID: 84758
			public static VerifyTableAction <1>__Verify;
		}
	}
}

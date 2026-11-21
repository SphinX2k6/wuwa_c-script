using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007847 RID: 30791
	public static class ISetSportsStateVerify
	{
		// Token: 0x0603625C RID: 221788 RVA: 0x00740E04 File Offset: 0x0073F004
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISetSportsStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetSportsStateVerify.<>O.<0>__Verify = new VerifyUnionAction(TSportStateVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086E6 RID: 34534
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AF9 RID: 84729
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D2A RID: 23850
	public static class IBvbAiDiscardForEnergyAndActDataVerify
	{
		// Token: 0x06028C44 RID: 166980 RVA: 0x0059973C File Offset: 0x0059793C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IBvbAiDiscardForEnergyAndActDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBvbAiDiscardForEnergyAndActDataVerify.<>O.<0>__Verify = new VerifyUnionAction(TGoalActDataVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C97 RID: 31895
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137C4 RID: 79812
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

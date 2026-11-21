using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006361 RID: 25441
	public static class IBvbAiDiscardForEnergyAndActDataVerify
	{
		// Token: 0x0602B2AE RID: 176814 RVA: 0x005E21AC File Offset: 0x005E03AC
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

		// Token: 0x02008508 RID: 34056
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401486A RID: 84074
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

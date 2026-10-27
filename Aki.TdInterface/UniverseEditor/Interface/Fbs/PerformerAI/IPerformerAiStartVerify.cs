using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x0200437D RID: 17277
	public static class IPerformerAiStartVerify
	{
		// Token: 0x06019B12 RID: 105234 RVA: 0x003ADF68 File Offset: 0x003AC168
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyVectorOfData(tablePos, 10, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
			{
				short typeIdVOffset = 16;
				short valueVOffset = 18;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IPerformerAiStartVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPerformerAiStartVerify.<>O.<0>__Verify = new VerifyUnionAction(TPerformerAiNodeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007988 RID: 31112
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013306 RID: 78598
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

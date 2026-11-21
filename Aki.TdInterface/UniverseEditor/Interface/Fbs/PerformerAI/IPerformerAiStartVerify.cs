using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x020047DF RID: 18399
	public static class IPerformerAiStartVerify
	{
		// Token: 0x0601B2A0 RID: 111264 RVA: 0x003D9990 File Offset: 0x003D7B90
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

		// Token: 0x020081D1 RID: 33233
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401436D RID: 82797
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

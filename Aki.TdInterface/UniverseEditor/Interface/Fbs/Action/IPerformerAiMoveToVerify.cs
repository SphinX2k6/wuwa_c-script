using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C83 RID: 27779
	public static class IPerformerAiMoveToVerify
	{
		// Token: 0x06030F3A RID: 200506 RVA: 0x006A5888 File Offset: 0x006A3A88
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IPerformerAiMoveToVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPerformerAiMoveToVerify.<>O.<0>__Verify = new VerifyUnionAction(TPerformerAiMoveToConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007DE3 RID: 32227
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013995 RID: 80277
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

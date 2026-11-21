using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073EA RID: 29674
	public static class IPerformerAiMoveToVerify
	{
		// Token: 0x06033E95 RID: 212629 RVA: 0x006FFD88 File Offset: 0x006FDF88
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

		// Token: 0x0200866D RID: 34413
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A57 RID: 84567
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EA8 RID: 32424
	public static class TCsvTeleportTransitionDataVerify
	{
		// Token: 0x0603A8B4 RID: 239796 RVA: 0x007E115C File Offset: 0x007DF35C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = TCsvTeleportTransitionDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (TCsvTeleportTransitionDataVerify.<>O.<0>__Verify = new VerifyUnionAction(ITeleportTransitionType_UnionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200877A RID: 34682
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014D0C RID: 85260
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

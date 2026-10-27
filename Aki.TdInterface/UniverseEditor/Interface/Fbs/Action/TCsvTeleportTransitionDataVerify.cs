using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200769D RID: 30365
	public static class TCsvTeleportTransitionDataVerify
	{
		// Token: 0x06037411 RID: 226321 RVA: 0x0077D008 File Offset: 0x0077B208
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

		// Token: 0x02007EDE RID: 32478
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013C30 RID: 80944
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F71 RID: 28529
	public static class ISendClientEventVerify
	{
		// Token: 0x06032678 RID: 206456 RVA: 0x006CDDAC File Offset: 0x006CBFAC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISendClientEventVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISendClientEventVerify.<>O.<0>__Verify = new VerifyUnionAction(TClientEventVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E25 RID: 32293
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139E2 RID: 80354
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

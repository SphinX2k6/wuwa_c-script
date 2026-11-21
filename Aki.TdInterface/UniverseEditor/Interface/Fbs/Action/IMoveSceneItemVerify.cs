using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200729C RID: 29340
	public static class IMoveSceneItemVerify
	{
		// Token: 0x06033217 RID: 209431 RVA: 0x006E6350 File Offset: 0x006E4550
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IMoveSceneItemVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMoveSceneItemVerify.<>O.<0>__Verify = new VerifyUnionAction(TMoveSceneItemVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008643 RID: 34371
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A18 RID: 84504
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

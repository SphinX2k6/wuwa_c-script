using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074EB RID: 29931
	public static class IPostAkEventVerify
	{
		// Token: 0x060347B7 RID: 214967 RVA: 0x00710DF0 File Offset: 0x0070EFF0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IPostAkEventVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPostAkEventVerify.<>O.<0>__Verify = new VerifyUnionAction(TPostAkEventVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200868D RID: 34445
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A80 RID: 84608
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

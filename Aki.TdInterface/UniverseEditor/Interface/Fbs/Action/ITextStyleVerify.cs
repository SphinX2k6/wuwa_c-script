using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073D2 RID: 29650
	public static class ITextStyleVerify
	{
		// Token: 0x06035DBE RID: 220606 RVA: 0x00754C38 File Offset: 0x00752E38
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ITextStyleVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITextStyleVerify.<>O.<0>__Verify = new VerifyUnionAction(TCenterTextShowAnimVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007EA2 RID: 32418
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013BE2 RID: 80866
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

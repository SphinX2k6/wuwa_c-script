using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005332 RID: 21298
	public static class IGroupAiComponentVerify
	{
		// Token: 0x06022D42 RID: 142658 RVA: 0x004D36EC File Offset: 0x004D18EC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IGroupAiComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGroupAiComponentVerify.<>O.<0>__Verify = new VerifyUnionAction(TGroupAiOptionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyVectorOfStrings(tablePos, 12, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B4B RID: 31563
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013597 RID: 79255
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

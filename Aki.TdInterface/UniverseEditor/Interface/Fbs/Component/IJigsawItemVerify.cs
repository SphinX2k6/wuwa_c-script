using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A34 RID: 23092
	public static class IJigsawItemVerify
	{
		// Token: 0x06025BDD RID: 154589 RVA: 0x0052C6FC File Offset: 0x0052A8FC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IJigsawItemVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IJigsawItemVerify.<>O.<0>__Verify = new VerifyUnionAction(TFillConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020083D5 RID: 33749
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014674 RID: 83572
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

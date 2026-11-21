using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C3A RID: 31802
	public static class ITransitionPopupConfigVerify
	{
		// Token: 0x06039527 RID: 234791 RVA: 0x007BDA98 File Offset: 0x007BBC98
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ITransitionPopupConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITransitionPopupConfigVerify.<>O.<0>__Verify = new VerifyUnionAction(TTransitionPopupStyleVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008745 RID: 34629
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CC7 RID: 85191
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

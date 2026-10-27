using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007447 RID: 29767
	public static class ITransitionPopupConfigVerify
	{
		// Token: 0x0603613E RID: 221502 RVA: 0x0075AD6C File Offset: 0x00758F6C
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

		// Token: 0x02007EAB RID: 32427
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013BED RID: 80877
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200794F RID: 31055
	public static class ISplineMoveConfigVerify
	{
		// Token: 0x06036B1F RID: 224031 RVA: 0x0075186C File Offset: 0x0074FA6C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISplineMoveConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISplineMoveConfigVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008702 RID: 34562
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014B21 RID: 84769
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

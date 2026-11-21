using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F70 RID: 20336
	public static class ICheckIsTargetHoldElementalBoxVerify
	{
		// Token: 0x0601FA8E RID: 129678 RVA: 0x00466F10 File Offset: 0x00465110
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICheckIsTargetHoldElementalBoxVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckIsTargetHoldElementalBoxVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200828A RID: 33418
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401446C RID: 83052
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

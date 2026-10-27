using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AA1 RID: 19105
	public static class ICheckIsTargetHoldElementalBoxVerify
	{
		// Token: 0x0601DFA5 RID: 122789 RVA: 0x004356F0 File Offset: 0x004338F0
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

		// Token: 0x02007A3A RID: 31290
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133FE RID: 78846
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

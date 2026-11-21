using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C4F RID: 31823
	public static class ITrapDefensePlayerOperationConstraintVerify
	{
		// Token: 0x060395DA RID: 234970 RVA: 0x007BEDB0 File Offset: 0x007BCFB0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ITrapDefensePlayerOperationConstraintVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITrapDefensePlayerOperationConstraintVerify.<>O.<0>__Verify = new VerifyUnionAction(TTrapDefensePlayerOperationTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 10, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008747 RID: 34631
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CC9 RID: 85193
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

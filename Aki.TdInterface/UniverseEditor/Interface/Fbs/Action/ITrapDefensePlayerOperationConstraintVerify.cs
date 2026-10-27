using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200745C RID: 29788
	public static class ITrapDefensePlayerOperationConstraintVerify
	{
		// Token: 0x060361F1 RID: 221681 RVA: 0x0075C084 File Offset: 0x0075A284
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

		// Token: 0x02007EAD RID: 32429
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013BEF RID: 80879
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200624D RID: 25165
	public static class IBvbPlayerOperationConstraintVerify
	{
		// Token: 0x0602B669 RID: 177769 RVA: 0x005F9780 File Offset: 0x005F7980
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IBvbPlayerOperationConstraintVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBvbPlayerOperationConstraintVerify.<>O.<0>__Verify = new VerifyUnionAction(TBvbPlayerOperationTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007CFA RID: 31994
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013859 RID: 79961
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

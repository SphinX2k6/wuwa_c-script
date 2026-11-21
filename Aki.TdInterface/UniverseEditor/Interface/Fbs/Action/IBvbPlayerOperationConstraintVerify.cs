using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068BE RID: 26814
	public static class IBvbPlayerOperationConstraintVerify
	{
		// Token: 0x0602DDCA RID: 187850 RVA: 0x00644588 File Offset: 0x00642788
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

		// Token: 0x0200856D RID: 34157
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014901 RID: 84225
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

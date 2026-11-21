using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005036 RID: 20534
	public static class ICheckTargetEntityVerify
	{
		// Token: 0x06020150 RID: 131408 RVA: 0x00473750 File Offset: 0x00471950
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICheckTargetEntityVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckTargetEntityVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200829F RID: 33439
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014484 RID: 83076
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

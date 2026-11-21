using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FA6 RID: 20390
	public static class ICheckOnlinePlayerVerify
	{
		// Token: 0x0601FC5C RID: 130140 RVA: 0x0046A1A0 File Offset: 0x004683A0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICheckOnlinePlayerVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckOnlinePlayerVerify.<>O.<0>__Verify = new VerifyUnionAction(TOnlinePlayerConditionTargetVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008290 RID: 33424
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014472 RID: 83058
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

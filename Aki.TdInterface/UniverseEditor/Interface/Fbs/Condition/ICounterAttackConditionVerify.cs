using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BF4 RID: 19444
	public static class ICounterAttackConditionVerify
	{
		// Token: 0x0601EC8C RID: 126092 RVA: 0x0044FFB8 File Offset: 0x0044E1B8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICounterAttackConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICounterAttackConditionVerify.<>O.<0>__Verify = new VerifyUnionAction(TOnlinePlayerConditionTargetVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A5B RID: 31323
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013423 RID: 78883
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

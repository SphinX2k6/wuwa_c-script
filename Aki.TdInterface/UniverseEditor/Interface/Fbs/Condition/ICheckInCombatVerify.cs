using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A74 RID: 19060
	public static class ICheckInCombatVerify
	{
		// Token: 0x0601DDF3 RID: 122355 RVA: 0x00432354 File Offset: 0x00430554
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICheckInCombatVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckInCombatVerify.<>O.<0>__Verify = new VerifyUnionAction(TOnlinePlayerConditionTargetVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A33 RID: 31283
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133F7 RID: 78839
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

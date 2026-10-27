using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C6F RID: 19567
	public static class IPerfectDodgeConditionVerify
	{
		// Token: 0x0601F074 RID: 127092 RVA: 0x0045680C File Offset: 0x00454A0C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IPerfectDodgeConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPerfectDodgeConditionVerify.<>O.<0>__Verify = new VerifyUnionAction(TOnlinePlayerConditionTargetVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A63 RID: 31331
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401342B RID: 78891
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

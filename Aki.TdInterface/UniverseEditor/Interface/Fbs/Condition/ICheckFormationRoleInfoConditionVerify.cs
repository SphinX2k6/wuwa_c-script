using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EF5 RID: 20213
	public static class ICheckFormationRoleInfoConditionVerify
	{
		// Token: 0x0601F632 RID: 128562 RVA: 0x0045F47C File Offset: 0x0045D67C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICheckFormationRoleInfoConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckFormationRoleInfoConditionVerify.<>O.<0>__Verify = new VerifyUnionAction(TCheckFormationRoleInfoVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008280 RID: 33408
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014462 RID: 83042
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

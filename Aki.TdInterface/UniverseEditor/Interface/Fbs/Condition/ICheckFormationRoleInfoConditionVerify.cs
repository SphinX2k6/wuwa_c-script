using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A32 RID: 18994
	public static class ICheckFormationRoleInfoConditionVerify
	{
		// Token: 0x0601DBA9 RID: 121769 RVA: 0x0042E584 File Offset: 0x0042C784
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

		// Token: 0x02007A30 RID: 31280
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133F4 RID: 78836
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F3A RID: 20282
	public static class ICheckInCombatVerify
	{
		// Token: 0x0601F896 RID: 129174 RVA: 0x004634E0 File Offset: 0x004616E0
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

		// Token: 0x02008283 RID: 33411
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014465 RID: 83045
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

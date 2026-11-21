using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050E1 RID: 20705
	public static class ICounterAttackConditionVerify
	{
		// Token: 0x06020872 RID: 133234 RVA: 0x00483620 File Offset: 0x00481820
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

		// Token: 0x020082AD RID: 33453
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014493 RID: 83091
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

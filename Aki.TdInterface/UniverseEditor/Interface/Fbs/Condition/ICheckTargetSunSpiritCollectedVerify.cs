using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005039 RID: 20537
	public static class ICheckTargetSunSpiritCollectedVerify
	{
		// Token: 0x06020176 RID: 131446 RVA: 0x00473C44 File Offset: 0x00471E44
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
			{
				short typeIdVOffset = 12;
				short valueVOffset = 14;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICheckTargetSunSpiritCollectedVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckTargetSunSpiritCollectedVerify.<>O.<0>__Verify = new VerifyUnionAction(TOnlinePlayerConditionTargetVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020082A0 RID: 33440
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014485 RID: 83077
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B52 RID: 19282
	public static class ICheckTargetSunSpiritCollectedVerify
	{
		// Token: 0x0601E5E8 RID: 124392 RVA: 0x004413F8 File Offset: 0x0043F5F8
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

		// Token: 0x02007A4E RID: 31310
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013415 RID: 78869
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

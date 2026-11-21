using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FDF RID: 20447
	public static class ICheckPlayerStateRestrictionConditionVerify
	{
		// Token: 0x0601FE68 RID: 130664 RVA: 0x0046E170 File Offset: 0x0046C370
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICheckPlayerStateRestrictionConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckPlayerStateRestrictionConditionVerify.<>O.<0>__Verify = new VerifyUnionAction(TOnlinePlayerConditionTargetVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008297 RID: 33431
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401447A RID: 83066
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

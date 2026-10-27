using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006644 RID: 26180
	public static class IEnableAlertAreaVerify
	{
		// Token: 0x0602D79C RID: 186268 RVA: 0x0063A8F4 File Offset: 0x00638AF4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
			{
				short typeIdVOffset = 10;
				short valueVOffset = 12;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IEnableAlertAreaVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEnableAlertAreaVerify.<>O.<0>__Verify = new VerifyUnionAction(TDisableAlertConditionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D4A RID: 32074
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138C4 RID: 80068
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

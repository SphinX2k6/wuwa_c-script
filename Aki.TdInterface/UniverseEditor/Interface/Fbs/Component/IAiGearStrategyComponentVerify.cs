using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E7F RID: 20095
	public static class IAiGearStrategyComponentVerify
	{
		// Token: 0x0601F981 RID: 129409 RVA: 0x0046699C File Offset: 0x00464B9C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IAiGearStrategyComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAiGearStrategyComponentVerify.<>O.<0>__Verify = new VerifyUnionAction(TAiGearStrategyVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A78 RID: 31352
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013448 RID: 78920
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

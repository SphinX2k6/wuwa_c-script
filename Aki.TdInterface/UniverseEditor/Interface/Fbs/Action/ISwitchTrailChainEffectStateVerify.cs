using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A4B RID: 31307
	public static class ISwitchTrailChainEffectStateVerify
	{
		// Token: 0x060372DC RID: 226012 RVA: 0x0075F0F0 File Offset: 0x0075D2F0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISwitchTrailChainEffectStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISwitchTrailChainEffectStateVerify.<>O.<0>__Verify = new VerifyUnionAction(TPos2Verify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008713 RID: 34579
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014B37 RID: 84791
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007276 RID: 29302
	public static class ISwitchTrailChainEffectStateVerify
	{
		// Token: 0x06033FDA RID: 212954 RVA: 0x006FDD90 File Offset: 0x006FBF90
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

		// Token: 0x02007E7C RID: 32380
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A60 RID: 80480
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200725B RID: 29275
	public static class ISwitchEffectStateVerify
	{
		// Token: 0x06033EF3 RID: 212723 RVA: 0x006FC340 File Offset: 0x006FA540
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISwitchEffectStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISwitchEffectStateVerify.<>O.<0>__Verify = new VerifyUnionAction(TSwitchEffectStateEffectTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E7B RID: 32379
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A5F RID: 80479
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

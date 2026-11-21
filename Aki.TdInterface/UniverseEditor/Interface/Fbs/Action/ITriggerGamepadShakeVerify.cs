using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C76 RID: 31862
	public static class ITriggerGamepadShakeVerify
	{
		// Token: 0x06039730 RID: 235312 RVA: 0x007C16C0 File Offset: 0x007BF8C0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ITriggerGamepadShakeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITriggerGamepadShakeVerify.<>O.<0>__Verify = new VerifyUnionAction(TGamepadShakeConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200874C RID: 34636
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CD2 RID: 85202
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

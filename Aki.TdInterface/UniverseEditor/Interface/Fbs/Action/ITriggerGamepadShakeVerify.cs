using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007483 RID: 29827
	public static class ITriggerGamepadShakeVerify
	{
		// Token: 0x06036347 RID: 222023 RVA: 0x0075E994 File Offset: 0x0075CB94
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

		// Token: 0x02007EB2 RID: 32434
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013BF8 RID: 80888
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

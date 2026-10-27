using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006878 RID: 26744
	public static class IGamepadShakeOptionsVerify
	{
		// Token: 0x0602EA4C RID: 191052 RVA: 0x0065C6D4 File Offset: 0x0065A8D4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IGamepadShakeOptionsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGamepadShakeOptionsVerify.<>O.<0>__Verify = new VerifyUnionAction(TGamepadShakeConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D81 RID: 32129
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013907 RID: 80135
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

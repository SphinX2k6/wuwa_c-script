using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F19 RID: 28441
	public static class IGamepadShakeOptionsVerify
	{
		// Token: 0x06031386 RID: 201606 RVA: 0x006AB754 File Offset: 0x006A9954
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

		// Token: 0x020085FA RID: 34298
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149B6 RID: 84406
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

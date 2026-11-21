using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200610B RID: 24843
	public static class ITurntableControlComponentVerify
	{
		// Token: 0x0602A1CD RID: 172493 RVA: 0x005BF77C File Offset: 0x005BD97C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ITurntableControlComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITurntableControlComponentVerify.<>O.<0>__Verify = new VerifyUnionAction(TTurntableControllerVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020084E1 RID: 34017
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014836 RID: 84022
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

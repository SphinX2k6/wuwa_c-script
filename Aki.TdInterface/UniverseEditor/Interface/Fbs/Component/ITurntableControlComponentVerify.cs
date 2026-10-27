using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AF5 RID: 23285
	public static class ITurntableControlComponentVerify
	{
		// Token: 0x06027C09 RID: 162825 RVA: 0x00577D28 File Offset: 0x00575F28
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

		// Token: 0x02007C70 RID: 31856
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013790 RID: 79760
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

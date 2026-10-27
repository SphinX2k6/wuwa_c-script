using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200632E RID: 25390
	public static class IChangeTimerVerify
	{
		// Token: 0x0602BEBF RID: 179903 RVA: 0x00609A98 File Offset: 0x00607C98
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IChangeTimerVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IChangeTimerVerify.<>O.<0>__Verify = new VerifyUnionAction(TChangeTimerVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D11 RID: 32017
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013875 RID: 79989
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007423 RID: 29731
	public static class IPhoneSystemInteractVerify
	{
		// Token: 0x06034051 RID: 213073 RVA: 0x00702C94 File Offset: 0x00700E94
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IPhoneSystemInteractVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPhoneSystemInteractVerify.<>O.<0>__Verify = new VerifyUnionAction(TPhoneSystemInteractVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008672 RID: 34418
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A5C RID: 84572
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

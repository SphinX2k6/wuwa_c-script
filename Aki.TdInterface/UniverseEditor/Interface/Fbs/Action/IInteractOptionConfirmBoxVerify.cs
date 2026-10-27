using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006998 RID: 27032
	public static class IInteractOptionConfirmBoxVerify
	{
		// Token: 0x0602F3A2 RID: 193442 RVA: 0x0066EEA0 File Offset: 0x0066D0A0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IInteractOptionConfirmBoxVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IInteractOptionConfirmBoxVerify.<>O.<0>__Verify = new VerifyUnionAction(TInteractOptionConfirmBoxOptionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D90 RID: 32144
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013920 RID: 80160
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

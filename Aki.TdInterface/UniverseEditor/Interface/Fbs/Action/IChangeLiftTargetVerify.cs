using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006307 RID: 25351
	public static class IChangeLiftTargetVerify
	{
		// Token: 0x0602BD72 RID: 179570 RVA: 0x00607788 File Offset: 0x00605988
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IChangeLiftTargetVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IChangeLiftTargetVerify.<>O.<0>__Verify = new VerifyUnionAction(TLiftMoveTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D0E RID: 32014
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013872 RID: 79986
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

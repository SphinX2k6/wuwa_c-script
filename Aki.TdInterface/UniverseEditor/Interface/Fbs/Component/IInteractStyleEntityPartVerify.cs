using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A04 RID: 23044
	public static class IInteractStyleEntityPartVerify
	{
		// Token: 0x06025A0E RID: 154126 RVA: 0x00528A58 File Offset: 0x00526C58
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IInteractStyleEntityPartVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IInteractStyleEntityPartVerify.<>O.<0>__Verify = new VerifyUnionAction(TInteractEntityPartBindVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020083CE RID: 33742
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014664 RID: 83556
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

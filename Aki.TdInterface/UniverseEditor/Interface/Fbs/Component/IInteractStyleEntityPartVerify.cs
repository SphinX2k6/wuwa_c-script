using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200547E RID: 21630
	public static class IInteractStyleEntityPartVerify
	{
		// Token: 0x06023956 RID: 145750 RVA: 0x004EB9E4 File Offset: 0x004E9BE4
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

		// Token: 0x02007B6F RID: 31599
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040135DE RID: 79326
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

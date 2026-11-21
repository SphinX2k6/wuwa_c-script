using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A3A RID: 27194
	public static class IClientFollowShooterLeisureInteractVerify
	{
		// Token: 0x0602EA5B RID: 191067 RVA: 0x0065C0E4 File Offset: 0x0065A2E4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IClientFollowShooterLeisureInteractVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IClientFollowShooterLeisureInteractVerify.<>O.<0>__Verify = new VerifyUnionAction(TClientFollowShooterLeisureTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008593 RID: 34195
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014934 RID: 84276
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

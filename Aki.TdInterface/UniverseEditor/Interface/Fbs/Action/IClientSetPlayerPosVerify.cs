using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A6D RID: 27245
	public static class IClientSetPlayerPosVerify
	{
		// Token: 0x0602EBF0 RID: 191472 RVA: 0x0065EFE0 File Offset: 0x0065D1E0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IClientSetPlayerPosVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IClientSetPlayerPosVerify.<>O.<0>__Verify = new VerifyUnionAction(TClientTeleportConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008598 RID: 34200
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014939 RID: 84281
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

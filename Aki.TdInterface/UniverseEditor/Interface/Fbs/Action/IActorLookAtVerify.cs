using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006735 RID: 26421
	public static class IActorLookAtVerify
	{
		// Token: 0x0602CC3C RID: 183356 RVA: 0x0061FC80 File Offset: 0x0061DE80
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IActorLookAtVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IActorLookAtVerify.<>O.<0>__Verify = new VerifyUnionAction(TActorLookAtDataVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008545 RID: 34117
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040148AD RID: 84141
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

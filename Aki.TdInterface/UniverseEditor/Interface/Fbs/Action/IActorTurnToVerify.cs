using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200675C RID: 26460
	public static class IActorTurnToVerify
	{
		// Token: 0x0602CD97 RID: 183703 RVA: 0x00622318 File Offset: 0x00620518
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IActorTurnToVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IActorTurnToVerify.<>O.<0>__Verify = new VerifyUnionAction(TActorTurnToDataVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008549 RID: 34121
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040148B2 RID: 84146
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

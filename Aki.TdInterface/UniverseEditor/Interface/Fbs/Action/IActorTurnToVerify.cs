using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060FA RID: 24826
	public static class IActorTurnToVerify
	{
		// Token: 0x0602A6B6 RID: 173750 RVA: 0x005D8370 File Offset: 0x005D6570
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

		// Token: 0x02007CD8 RID: 31960
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401380C RID: 79884
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

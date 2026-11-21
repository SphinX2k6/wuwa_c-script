using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006717 RID: 26391
	public static class IActorFxEmoteStopVerify
	{
		// Token: 0x0602CB3A RID: 183098 RVA: 0x0061DBAC File Offset: 0x0061BDAC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IActorFxEmoteStopVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IActorFxEmoteStopVerify.<>O.<0>__Verify = new VerifyUnionAction(TActorFxEmoteStopSubTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008542 RID: 34114
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040148A8 RID: 84136
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

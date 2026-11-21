using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200670E RID: 26382
	public static class IActorFxEmoteVerify
	{
		// Token: 0x0602CACE RID: 182990 RVA: 0x0061CCDC File Offset: 0x0061AEDC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IActorFxEmoteVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IActorFxEmoteVerify.<>O.<0>__Verify = new VerifyUnionAction(TActorFxEmoteVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200853F RID: 34111
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040148A5 RID: 84133
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

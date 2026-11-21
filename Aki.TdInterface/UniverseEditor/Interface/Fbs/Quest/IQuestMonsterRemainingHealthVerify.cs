using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200443B RID: 17467
	public static class IQuestMonsterRemainingHealthVerify
	{
		// Token: 0x0601908D RID: 102541 RVA: 0x0039252C File Offset: 0x0039072C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IQuestMonsterRemainingHealthVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQuestMonsterRemainingHealthVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008175 RID: 33141
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401429F RID: 82591
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FF1 RID: 16369
	public static class IQuestMechaTrackScoreVerify
	{
		// Token: 0x06017941 RID: 96577 RVA: 0x00366874 File Offset: 0x00364A74
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IQuestMechaTrackScoreVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQuestMechaTrackScoreVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 12, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200792B RID: 31019
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013234 RID: 78388
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

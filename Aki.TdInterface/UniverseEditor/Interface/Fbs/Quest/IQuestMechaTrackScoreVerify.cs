using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004432 RID: 17458
	public static class IQuestMechaTrackScoreVerify
	{
		// Token: 0x06018FDA RID: 102362 RVA: 0x00390668 File Offset: 0x0038E868
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

		// Token: 0x02008172 RID: 33138
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014297 RID: 82583
			public static VerifyUnionAction <0>__Verify;
		}
	}
}

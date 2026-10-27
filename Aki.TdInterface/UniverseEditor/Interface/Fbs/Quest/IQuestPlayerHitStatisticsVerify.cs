using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004003 RID: 16387
	public static class IQuestPlayerHitStatisticsVerify
	{
		// Token: 0x06017A61 RID: 96865 RVA: 0x003695CC File Offset: 0x003677CC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IQuestPlayerHitStatisticsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQuestPlayerHitStatisticsVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 10;
					short valueVOffset2 = 12;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IQuestPlayerHitStatisticsVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IQuestPlayerHitStatisticsVerify.<>O.<1>__Verify = new VerifyUnionAction(TQuestPlayerHitStatisticsVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200792F RID: 31023
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401323D RID: 78397
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x0401323E RID: 78398
			public static VerifyUnionAction <1>__Verify;
		}
	}
}

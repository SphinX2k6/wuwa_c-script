using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004051 RID: 16465
	public static class IQuestStatisticsCollectVerify
	{
		// Token: 0x06017DCD RID: 97741 RVA: 0x003717B8 File Offset: 0x0036F9B8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IQuestStatisticsCollectVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQuestStatisticsCollectVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IQuestStatisticsCollectVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IQuestStatisticsCollectVerify.<>O.<1>__Verify = new VerifyTableAction(IStaticEntitiyMatchVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
					{
						short typeIdVOffset2 = 14;
						short valueVOffset2 = 16;
						VerifyUnionAction verifyAction3;
						if ((verifyAction3 = IQuestStatisticsCollectVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IQuestStatisticsCollectVerify.<>O.<2>__Verify = new VerifyUnionAction(TOnlinePlayerConditionTargetVerify.Verify));
						}
						if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction3, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0200793E RID: 31038
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013255 RID: 78421
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04013256 RID: 78422
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013257 RID: 78423
			public static VerifyUnionAction <2>__Verify;
		}
	}
}

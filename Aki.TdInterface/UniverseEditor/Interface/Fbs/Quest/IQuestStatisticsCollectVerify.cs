using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004492 RID: 17554
	public static class IQuestStatisticsCollectVerify
	{
		// Token: 0x06019466 RID: 103526 RVA: 0x0039B5AC File Offset: 0x003997AC
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

		// Token: 0x02008185 RID: 33157
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040142B8 RID: 82616
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x040142B9 RID: 82617
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040142BA RID: 82618
			public static VerifyUnionAction <2>__Verify;
		}
	}
}

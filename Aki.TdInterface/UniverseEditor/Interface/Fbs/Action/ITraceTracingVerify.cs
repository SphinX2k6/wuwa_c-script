using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C1F RID: 31775
	public static class ITraceTracingVerify
	{
		// Token: 0x0603945E RID: 234590 RVA: 0x007BC2C0 File Offset: 0x007BA4C0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITraceTracingVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITraceTracingVerify.<>O.<0>__Verify = new VerifyTableAction(ITraceTracingGridBoardVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
				{
					short offsetId2 = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITraceTracingVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITraceTracingVerify.<>O.<1>__Verify = new VerifyTableAction(ITraceTracingMaxStepRewardRuleItemVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008741 RID: 34625
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CC2 RID: 85186
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014CC3 RID: 85187
			public static VerifyTableAction <1>__Verify;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200742C RID: 29740
	public static class ITraceTracingVerify
	{
		// Token: 0x06036075 RID: 221301 RVA: 0x00759594 File Offset: 0x00757794
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

		// Token: 0x02007EA7 RID: 32423
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013BE8 RID: 80872
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013BE9 RID: 80873
			public static VerifyTableAction <1>__Verify;
		}
	}
}

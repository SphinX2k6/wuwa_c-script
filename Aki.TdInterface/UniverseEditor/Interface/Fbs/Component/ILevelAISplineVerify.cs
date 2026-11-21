using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A5E RID: 23134
	public static class ILevelAISplineVerify
	{
		// Token: 0x06025D8D RID: 155021 RVA: 0x0052FF34 File Offset: 0x0052E134
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILevelAISplineVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILevelAISplineVerify.<>O.<0>__Verify = new VerifyTableAction(ILevelAiCycleLooplyVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					short offsetId2 = 14;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ILevelAISplineVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ILevelAISplineVerify.<>O.<1>__Verify = new VerifyTableAction(ILevelAISplinePointVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020083DC RID: 33756
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401467F RID: 83583
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014680 RID: 83584
			public static VerifyTableAction <1>__Verify;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DF6 RID: 24054
	public static class IRandomNpcRuleVerify
	{
		// Token: 0x0602826F RID: 164463 RVA: 0x0057DC94 File Offset: 0x0057BE94
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRandomNpcRuleVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRandomNpcRuleVerify.<>O.<0>__Verify = new VerifyTableAction(IFixedDateTimeVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IRandomNpcRuleVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IRandomNpcRuleVerify.<>O.<1>__Verify = new VerifyTableAction(IProbabilityRefreshGroupVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008469 RID: 33897
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014768 RID: 83816
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014769 RID: 83817
			public static VerifyTableAction <1>__Verify;
		}
	}
}

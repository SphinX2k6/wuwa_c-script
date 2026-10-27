using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057EF RID: 22511
	public static class IRandomNpcRuleVerify
	{
		// Token: 0x06025D4F RID: 154959 RVA: 0x00537B08 File Offset: 0x00535D08
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

		// Token: 0x02007BFB RID: 31739
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136C8 RID: 79560
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040136C9 RID: 79561
			public static VerifyTableAction <1>__Verify;
		}
	}
}

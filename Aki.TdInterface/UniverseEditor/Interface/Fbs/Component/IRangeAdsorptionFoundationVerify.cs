using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DFF RID: 24063
	public static class IRangeAdsorptionFoundationVerify
	{
		// Token: 0x060282C3 RID: 164547 RVA: 0x0057E7A0 File Offset: 0x0057C9A0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRangeAdsorptionFoundationVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRangeAdsorptionFoundationVerify.<>O.<0>__Verify = new VerifyTableAction(ICategoryMatchingConditionVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IRangeAdsorptionFoundationVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IRangeAdsorptionFoundationVerify.<>O.<1>__Verify = new VerifyTableAction(IAdsorptionMatchingAnimationVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IRangeAdsorptionFoundationVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IRangeAdsorptionFoundationVerify.<>O.<2>__Verify = new VerifyTableAction(ICategoryMatchingAnimationVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 12;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IRangeAdsorptionFoundationVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (IRangeAdsorptionFoundationVerify.<>O.<3>__Verify = new VerifyTableAction(ICategoryMatchingSucceedVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0200846B RID: 33899
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401476B RID: 83819
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401476C RID: 83820
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401476D RID: 83821
			public static VerifyTableAction <2>__Verify;

			// Token: 0x0401476E RID: 83822
			public static VerifyTableAction <3>__Verify;
		}
	}
}

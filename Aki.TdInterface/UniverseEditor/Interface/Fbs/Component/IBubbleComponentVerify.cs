using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F27 RID: 20263
	public static class IBubbleComponentVerify
	{
		// Token: 0x060200FF RID: 131327 RVA: 0x00476080 File Offset: 0x00474280
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
			{
				short offsetId = 14;
				VerifyTableAction verifyAction;
				if ((verifyAction = IBubbleComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBubbleComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionBubbleDataVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
				{
					short offsetId2 = 22;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IBubbleComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IBubbleComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IBubbleRangeCylinderConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 26, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007A92 RID: 31378
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013471 RID: 78961
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013472 RID: 78962
			public static VerifyTableAction <1>__Verify;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200500E RID: 20494
	public static class IConnectorPathAdvanceInitiatorVerify
	{
		// Token: 0x06020C9C RID: 134300 RVA: 0x0048F0E8 File Offset: 0x0048D2E8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
			{
				short offsetId = 14;
				VerifyTableAction verifyAction;
				if ((verifyAction = IConnectorPathAdvanceInitiatorVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IConnectorPathAdvanceInitiatorVerify.<>O.<0>__Verify = new VerifyTableAction(IConnectorPathAdvanceVasePlantVisualVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 16;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IConnectorPathAdvanceInitiatorVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IConnectorPathAdvanceInitiatorVerify.<>O.<1>__Verify = new VerifyTableAction(IDynamicEntityMatchVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007AC5 RID: 31429
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134BB RID: 79035
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040134BC RID: 79036
			public static VerifyTableAction <1>__Verify;
		}
	}
}

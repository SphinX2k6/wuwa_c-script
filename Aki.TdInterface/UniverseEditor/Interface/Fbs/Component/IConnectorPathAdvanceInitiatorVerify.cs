using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200556D RID: 21869
	public static class IConnectorPathAdvanceInitiatorVerify
	{
		// Token: 0x06022BBC RID: 142268 RVA: 0x004C8B38 File Offset: 0x004C6D38
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

		// Token: 0x0200831F RID: 33567
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014539 RID: 83257
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401453A RID: 83258
			public static VerifyTableAction <1>__Verify;
		}
	}
}

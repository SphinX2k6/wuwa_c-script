using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200557C RID: 21884
	public static class IConnectorPointToPointPathAdvanceVerify
	{
		// Token: 0x06022C42 RID: 142402 RVA: 0x004C9B24 File Offset: 0x004C7D24
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IConnectorPointToPointPathAdvanceVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IConnectorPointToPointPathAdvanceVerify.<>O.<0>__Verify = new VerifyTableAction(IConnectorEffectConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IConnectorPointToPointPathAdvanceVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IConnectorPointToPointPathAdvanceVerify.<>O.<1>__Verify = new VerifyTableAction(IConnectorPathAdvanceInitiatorVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IConnectorPointToPointPathAdvanceVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IConnectorPointToPointPathAdvanceVerify.<>O.<2>__Verify = new VerifyTableAction(IConnectorPathAdvanceReceiverVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02008320 RID: 33568
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401453B RID: 83259
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401453C RID: 83260
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401453D RID: 83261
			public static VerifyTableAction <2>__Verify;
		}
	}
}

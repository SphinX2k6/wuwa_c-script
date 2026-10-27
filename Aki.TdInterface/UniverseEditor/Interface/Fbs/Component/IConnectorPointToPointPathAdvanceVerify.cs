using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200501D RID: 20509
	public static class IConnectorPointToPointPathAdvanceVerify
	{
		// Token: 0x06020D22 RID: 134434 RVA: 0x004900D4 File Offset: 0x0048E2D4
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

		// Token: 0x02007AC6 RID: 31430
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134BD RID: 79037
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040134BE RID: 79038
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040134BF RID: 79039
			public static VerifyTableAction <2>__Verify;
		}
	}
}

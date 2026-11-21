using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E7C RID: 24188
	public static class IRoadNetworkNavigationComponentVerify
	{
		// Token: 0x060287C9 RID: 165833 RVA: 0x00589664 File Offset: 0x00587864
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRoadNetworkNavigationComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRoadNetworkNavigationComponentVerify.<>O.<0>__Verify = new VerifyTableAction(ITrafficNavigationConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IRoadNetworkNavigationComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IRoadNetworkNavigationComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IObstacleDetectionConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008480 RID: 33920
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401478C RID: 83852
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401478D RID: 83853
			public static VerifyTableAction <1>__Verify;
		}
	}
}

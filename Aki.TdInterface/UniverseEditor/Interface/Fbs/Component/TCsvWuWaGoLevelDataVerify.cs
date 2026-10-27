using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C02 RID: 23554
	public static class TCsvWuWaGoLevelDataVerify
	{
		// Token: 0x06028694 RID: 165524 RVA: 0x00590170 File Offset: 0x0058E370
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = TCsvWuWaGoLevelDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (TCsvWuWaGoLevelDataVerify.<>O.<0>__Verify = new VerifyTableAction(IWuWaGoGridDataVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = TCsvWuWaGoLevelDataVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (TCsvWuWaGoLevelDataVerify.<>O.<1>__Verify = new VerifyTableAction(IWuWaGoRoleInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007C90 RID: 31888
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137BB RID: 79803
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040137BC RID: 79804
			public static VerifyTableAction <1>__Verify;
		}
	}
}

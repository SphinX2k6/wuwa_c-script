using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006221 RID: 25121
	public static class TCsvWuWaGoLevelDataVerify
	{
		// Token: 0x0602AC84 RID: 175236 RVA: 0x005D80B8 File Offset: 0x005D62B8
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

		// Token: 0x02008501 RID: 34049
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014861 RID: 84065
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014862 RID: 84066
			public static VerifyTableAction <1>__Verify;
		}
	}
}

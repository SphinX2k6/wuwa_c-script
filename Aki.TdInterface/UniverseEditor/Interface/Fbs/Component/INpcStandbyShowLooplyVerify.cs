using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005661 RID: 22113
	public static class INpcStandbyShowLooplyVerify
	{
		// Token: 0x06024C74 RID: 150644 RVA: 0x00513118 File Offset: 0x00511318
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = INpcStandbyShowLooplyVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INpcStandbyShowLooplyVerify.<>O.<0>__Verify = new VerifyTableAction(INpcLookAtConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 8, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = INpcStandbyShowLooplyVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (INpcStandbyShowLooplyVerify.<>O.<1>__Verify = new VerifyTableAction(IMontageIdVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false))
					{
						short offsetId3 = 14;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = INpcStandbyShowLooplyVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (INpcStandbyShowLooplyVerify.<>O.<2>__Verify = new VerifyTableAction(IIgnoreEntityIdsCollisionVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007BB2 RID: 31666
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013658 RID: 79448
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013659 RID: 79449
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401365A RID: 79450
			public static VerifyTableAction <2>__Verify;
		}
	}
}

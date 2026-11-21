using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C02 RID: 23554
	public static class INpcStandbyShowLooplyVerify
	{
		// Token: 0x06026EAD RID: 159405 RVA: 0x00553CB4 File Offset: 0x00551EB4
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

		// Token: 0x02008414 RID: 33812
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040146E7 RID: 83687
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040146E8 RID: 83688
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040146E9 RID: 83689
			public static VerifyTableAction <2>__Verify;
		}
	}
}

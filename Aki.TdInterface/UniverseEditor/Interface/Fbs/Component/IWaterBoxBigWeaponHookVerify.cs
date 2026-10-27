using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B4F RID: 23375
	public static class IWaterBoxBigWeaponHookVerify
	{
		// Token: 0x06027FAA RID: 163754 RVA: 0x0057F348 File Offset: 0x0057D548
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IWaterBoxBigWeaponHookVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWaterBoxBigWeaponHookVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IWaterBoxBigWeaponHookVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IWaterBoxBigWeaponHookVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IWaterBoxBigWeaponHookVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (IWaterBoxBigWeaponHookVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 12;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IWaterBoxBigWeaponHookVerify.<>O.<1>__Verify) == null)
							{
								verifyAction4 = (IWaterBoxBigWeaponHookVerify.<>O.<1>__Verify = new VerifyTableAction(IClientHookActionConfigVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007C78 RID: 31864
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401379C RID: 79772
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401379D RID: 79773
			public static VerifyTableAction <1>__Verify;
		}
	}
}

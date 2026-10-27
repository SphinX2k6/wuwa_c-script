using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006935 RID: 26933
	public static class IHonamiStorySetFormationVerify
	{
		// Token: 0x0602F073 RID: 192627 RVA: 0x00669488 File Offset: 0x00667688
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IHonamiStorySetFormationVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IHonamiStorySetFormationVerify.<>O.<0>__Verify = new VerifyTableAction(IHonamiStoryRoleSettingVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IHonamiStorySetFormationVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IHonamiStorySetFormationVerify.<>O.<1>__Verify = new VerifyTableAction(IHonamiStoryWeaponEquipSettingVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IHonamiStorySetFormationVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IHonamiStorySetFormationVerify.<>O.<2>__Verify = new VerifyTableAction(IHonamiStoryPluginEquipSettingVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007D89 RID: 32137
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013910 RID: 80144
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013911 RID: 80145
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013912 RID: 80146
			public static VerifyTableAction <2>__Verify;
		}
	}
}

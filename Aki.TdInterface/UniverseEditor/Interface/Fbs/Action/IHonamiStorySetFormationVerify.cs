using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FE8 RID: 28648
	public static class IHonamiStorySetFormationVerify
	{
		// Token: 0x06031A43 RID: 203331 RVA: 0x006B9970 File Offset: 0x006B7B70
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

		// Token: 0x02008604 RID: 34308
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149C1 RID: 84417
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040149C2 RID: 84418
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040149C3 RID: 84419
			public static VerifyTableAction <2>__Verify;
		}
	}
}

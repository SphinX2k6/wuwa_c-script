using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050EC RID: 20716
	public static class IDynamicPortalByBulletVerify
	{
		// Token: 0x060215B4 RID: 136628 RVA: 0x004A1D44 File Offset: 0x0049FF44
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDynamicPortalByBulletVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDynamicPortalByBulletVerify.<>O.<0>__Verify = new VerifyTableAction(IDynamicPortalConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IDynamicPortalByBulletVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IDynamicPortalByBulletVerify.<>O.<0>__Verify = new VerifyTableAction(IDynamicPortalConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
					{
						short offsetId3 = 12;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IDynamicPortalByBulletVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (IDynamicPortalByBulletVerify.<>O.<1>__Verify = new VerifyTableAction(IPortalRenderConfigVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 14;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IDynamicPortalByBulletVerify.<>O.<2>__Verify) == null)
							{
								verifyAction4 = (IDynamicPortalByBulletVerify.<>O.<2>__Verify = new VerifyTableAction(IDynamicBulletConfigVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false))
							{
								short offsetId5 = 16;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = IDynamicPortalByBulletVerify.<>O.<2>__Verify) == null)
								{
									verifyAction5 = (IDynamicPortalByBulletVerify.<>O.<2>__Verify = new VerifyTableAction(IDynamicBulletConfigVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId5, verifyAction5, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
								{
									return verifier.VerifyTableEnd(tablePos);
								}
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007AE4 RID: 31460
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134F7 RID: 79095
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040134F8 RID: 79096
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040134F9 RID: 79097
			public static VerifyTableAction <2>__Verify;
		}
	}
}

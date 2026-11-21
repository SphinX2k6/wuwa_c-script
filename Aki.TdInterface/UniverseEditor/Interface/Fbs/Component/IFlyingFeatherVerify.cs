using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057F2 RID: 22514
	public static class IFlyingFeatherVerify
	{
		// Token: 0x06024676 RID: 149110 RVA: 0x00500914 File Offset: 0x004FEB14
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFlyingFeatherVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFlyingFeatherVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IFlyingFeatherVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IFlyingFeatherVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IFlyingFeatherVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (IFlyingFeatherVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 12;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IFlyingFeatherVerify.<>O.<1>__Verify) == null)
							{
								verifyAction4 = (IFlyingFeatherVerify.<>O.<1>__Verify = new VerifyTableAction(IClientHookActionConfigVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02008384 RID: 33668
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145E4 RID: 83428
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040145E5 RID: 83429
			public static VerifyTableAction <1>__Verify;
		}
	}
}

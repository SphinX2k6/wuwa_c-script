using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200547D RID: 21629
	public static class ICableWayVerify
	{
		// Token: 0x06021FF6 RID: 139254 RVA: 0x004AFBF8 File Offset: 0x004ADDF8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICableWayVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICableWayVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ICableWayVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (ICableWayVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ICableWayVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (ICableWayVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 12;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = ICableWayVerify.<>O.<1>__Verify) == null)
							{
								verifyAction4 = (ICableWayVerify.<>O.<1>__Verify = new VerifyTableAction(IClientHookActionConfigVerify.Verify));
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

		// Token: 0x020082F0 RID: 33520
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144F1 RID: 83185
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040144F2 RID: 83186
			public static VerifyTableAction <1>__Verify;
		}
	}
}

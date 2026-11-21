using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AD3 RID: 23251
	public static class IMechHookInteractTypeVerify
	{
		// Token: 0x06026295 RID: 156309 RVA: 0x0053AA54 File Offset: 0x00538C54
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMechHookInteractTypeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMechHookInteractTypeVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IMechHookInteractTypeVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IMechHookInteractTypeVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IMechHookInteractTypeVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (IMechHookInteractTypeVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 12;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IMechHookInteractTypeVerify.<>O.<1>__Verify) == null)
							{
								verifyAction4 = (IMechHookInteractTypeVerify.<>O.<1>__Verify = new VerifyTableAction(IClientHookActionConfigVerify.Verify));
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

		// Token: 0x020083EE RID: 33774
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040146A0 RID: 83616
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040146A1 RID: 83617
			public static VerifyTableAction <1>__Verify;
		}
	}
}

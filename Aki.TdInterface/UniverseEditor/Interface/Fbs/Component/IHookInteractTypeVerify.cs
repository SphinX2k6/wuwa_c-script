using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053C4 RID: 21444
	public static class IHookInteractTypeVerify
	{
		// Token: 0x0602327B RID: 143995 RVA: 0x004DDD98 File Offset: 0x004DBF98
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IHookInteractTypeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IHookInteractTypeVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IHookInteractTypeVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IHookInteractTypeVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IHookInteractTypeVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (IHookInteractTypeVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 12;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IHookInteractTypeVerify.<>O.<1>__Verify) == null)
							{
								verifyAction4 = (IHookInteractTypeVerify.<>O.<1>__Verify = new VerifyTableAction(IClientHookActionConfigVerify.Verify));
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

		// Token: 0x02007B5D RID: 31581
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040135B5 RID: 79285
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040135B6 RID: 79286
			public static VerifyTableAction <1>__Verify;
		}
	}
}

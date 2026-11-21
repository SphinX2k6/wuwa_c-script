using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200594A RID: 22858
	public static class IHookInteractTypeVerify
	{
		// Token: 0x0602532F RID: 152367 RVA: 0x0051AC6C File Offset: 0x00518E6C
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

		// Token: 0x020083BC RID: 33724
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401463A RID: 83514
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401463B RID: 83515
			public static VerifyTableAction <1>__Verify;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052C0 RID: 21184
	public static class IFoxJumpingPointVerify
	{
		// Token: 0x060228C8 RID: 141512 RVA: 0x004C9DBC File Offset: 0x004C7FBC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFoxJumpingPointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFoxJumpingPointVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IFoxJumpingPointVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IFoxJumpingPointVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IFoxJumpingPointVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (IFoxJumpingPointVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 12;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IFoxJumpingPointVerify.<>O.<1>__Verify) == null)
							{
								verifyAction4 = (IFoxJumpingPointVerify.<>O.<1>__Verify = new VerifyTableAction(IClientHookActionConfigVerify.Verify));
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

		// Token: 0x02007B32 RID: 31538
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013570 RID: 79216
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013571 RID: 79217
			public static VerifyTableAction <1>__Verify;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057DD RID: 22493
	public static class IFixedPointHookVerify
	{
		// Token: 0x06024566 RID: 148838 RVA: 0x004FE294 File Offset: 0x004FC494
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFixedPointHookVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFixedPointHookVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IFixedPointHookVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IFixedPointHookVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IFixedPointHookVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (IFixedPointHookVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 12;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IFixedPointHookVerify.<>O.<1>__Verify) == null)
							{
								verifyAction4 = (IFixedPointHookVerify.<>O.<1>__Verify = new VerifyTableAction(IClientHookActionConfigVerify.Verify));
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

		// Token: 0x0200837F RID: 33663
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145DC RID: 83420
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040145DD RID: 83421
			public static VerifyTableAction <1>__Verify;
		}
	}
}

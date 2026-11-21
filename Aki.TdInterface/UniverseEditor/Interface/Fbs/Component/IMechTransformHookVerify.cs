using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ADC RID: 23260
	public static class IMechTransformHookVerify
	{
		// Token: 0x06026329 RID: 156457 RVA: 0x0053C248 File Offset: 0x0053A448
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMechTransformHookVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMechTransformHookVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IMechTransformHookVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IMechTransformHookVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IMechTransformHookVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (IMechTransformHookVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 12;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IMechTransformHookVerify.<>O.<1>__Verify) == null)
							{
								verifyAction4 = (IMechTransformHookVerify.<>O.<1>__Verify = new VerifyTableAction(IClientHookActionConfigVerify.Verify));
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

		// Token: 0x020083F0 RID: 33776
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040146A4 RID: 83620
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040146A5 RID: 83621
			public static VerifyTableAction <1>__Verify;
		}
	}
}

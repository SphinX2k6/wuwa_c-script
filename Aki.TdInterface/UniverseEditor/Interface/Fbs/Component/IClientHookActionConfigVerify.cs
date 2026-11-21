using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005507 RID: 21767
	public static class IClientHookActionConfigVerify
	{
		// Token: 0x06022648 RID: 140872 RVA: 0x004BD5A0 File Offset: 0x004BB7A0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IClientHookActionConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IClientHookActionConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IClientHookActionConfigVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IClientHookActionConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 8;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IClientHookActionConfigVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (IClientHookActionConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0200830C RID: 33548
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401451D RID: 83229
			public static VerifyTableAction <0>__Verify;
		}
	}
}

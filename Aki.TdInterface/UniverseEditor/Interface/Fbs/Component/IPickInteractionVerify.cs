using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200573B RID: 22331
	public static class IPickInteractionVerify
	{
		// Token: 0x06025652 RID: 153170 RVA: 0x00528F08 File Offset: 0x00527108
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPickInteractionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPickInteractionVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IPickInteractionVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IPickInteractionVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007BD8 RID: 31704
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013697 RID: 79511
			public static VerifyTableAction <0>__Verify;
		}
	}
}

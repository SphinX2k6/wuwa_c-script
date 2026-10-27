using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200629E RID: 25246
	public static class ICameraPosAndRotVerify
	{
		// Token: 0x0602B9E8 RID: 178664 RVA: 0x00601390 File Offset: 0x005FF590
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICameraPosAndRotVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICameraPosAndRotVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ICameraPosAndRotVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (ICameraPosAndRotVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007D05 RID: 32005
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013867 RID: 79975
			public static VerifyTableAction <0>__Verify;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200690F RID: 26895
	public static class ICameraPosAndRotVerify
	{
		// Token: 0x0602E149 RID: 188745 RVA: 0x0064C198 File Offset: 0x0064A398
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

		// Token: 0x02008578 RID: 34168
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401490F RID: 84239
			public static VerifyTableAction <0>__Verify;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079D9 RID: 31193
	public static class ISubScreenConfigVerify
	{
		// Token: 0x06036F5B RID: 225115 RVA: 0x00759120 File Offset: 0x00757320
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISubScreenConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISubScreenConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVector2Verify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ISubScreenConfigVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (ISubScreenConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVector2Verify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200870B RID: 34571
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014B2F RID: 84783
			public static VerifyTableAction <0>__Verify;
		}
	}
}

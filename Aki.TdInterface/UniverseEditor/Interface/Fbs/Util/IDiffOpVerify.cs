using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Util
{
	// Token: 0x02003F76 RID: 16246
	public static class IDiffOpVerify
	{
		// Token: 0x060161D4 RID: 90580 RVA: 0x0032C35C File Offset: 0x0032A55C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDiffOpVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDiffOpVerify.<>O.<0>__Verify = new VerifyTableAction(IDiffOpVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020080CC RID: 32972
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401414D RID: 82253
			public static VerifyTableAction <0>__Verify;
		}
	}
}

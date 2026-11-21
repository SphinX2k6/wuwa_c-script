using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007348 RID: 29512
	public static class INpcSitDownVerify
	{
		// Token: 0x06033789 RID: 210825 RVA: 0x006F00BC File Offset: 0x006EE2BC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = INpcSitDownVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INpcSitDownVerify.<>O.<0>__Verify = new VerifyTableAction(IMontageIdVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008655 RID: 34389
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A31 RID: 84529
			public static VerifyTableAction <0>__Verify;
		}
	}
}

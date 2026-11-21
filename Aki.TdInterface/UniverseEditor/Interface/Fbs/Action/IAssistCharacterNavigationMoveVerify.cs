using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200680D RID: 26637
	public static class IAssistCharacterNavigationMoveVerify
	{
		// Token: 0x0602D802 RID: 186370 RVA: 0x0063A82C File Offset: 0x00638A2C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAssistCharacterNavigationMoveVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAssistCharacterNavigationMoveVerify.<>O.<0>__Verify = new VerifyTableAction(IPosAVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008563 RID: 34147
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040148F7 RID: 84215
			public static VerifyTableAction <0>__Verify;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061A2 RID: 24994
	public static class IAssistCharacterNavigationMoveVerify
	{
		// Token: 0x0602B0D1 RID: 176337 RVA: 0x005EFFB8 File Offset: 0x005EE1B8
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

		// Token: 0x02007CF1 RID: 31985
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013850 RID: 79952
			public static VerifyTableAction <0>__Verify;
		}
	}
}

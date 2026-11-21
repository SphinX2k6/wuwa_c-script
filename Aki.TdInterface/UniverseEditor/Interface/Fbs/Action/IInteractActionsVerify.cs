using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007033 RID: 28723
	public static class IInteractActionsVerify
	{
		// Token: 0x06031C83 RID: 203907 RVA: 0x006BD3B4 File Offset: 0x006BB5B4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IInteractActionsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IInteractActionsVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008608 RID: 34312
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149C8 RID: 84424
			public static VerifyTableAction <0>__Verify;
		}
	}
}

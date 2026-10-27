using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006980 RID: 27008
	public static class IInteractActionsVerify
	{
		// Token: 0x0602F2B3 RID: 193203 RVA: 0x0066CECC File Offset: 0x0066B0CC
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

		// Token: 0x02007D8D RID: 32141
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013917 RID: 80151
			public static VerifyTableAction <0>__Verify;
		}
	}
}

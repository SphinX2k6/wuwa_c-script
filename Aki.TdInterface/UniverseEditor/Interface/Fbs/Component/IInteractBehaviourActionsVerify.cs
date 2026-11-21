using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059C2 RID: 22978
	public static class IInteractBehaviourActionsVerify
	{
		// Token: 0x0602578E RID: 153486 RVA: 0x005239F4 File Offset: 0x00521BF4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IInteractBehaviourActionsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IInteractBehaviourActionsVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020083C9 RID: 33737
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014654 RID: 83540
			public static VerifyTableAction <0>__Verify;
		}
	}
}

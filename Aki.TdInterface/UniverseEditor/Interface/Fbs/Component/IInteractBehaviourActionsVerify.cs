using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200543C RID: 21564
	public static class IInteractBehaviourActionsVerify
	{
		// Token: 0x060236D6 RID: 145110 RVA: 0x004E69C8 File Offset: 0x004E4BC8
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

		// Token: 0x02007B6A RID: 31594
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040135CE RID: 79310
			public static VerifyTableAction <0>__Verify;
		}
	}
}

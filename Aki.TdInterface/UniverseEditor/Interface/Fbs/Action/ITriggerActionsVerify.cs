using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C64 RID: 31844
	public static class ITriggerActionsVerify
	{
		// Token: 0x06039666 RID: 235110 RVA: 0x007BFB25 File Offset: 0x007BDD25
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITriggerActionsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITriggerActionsVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008748 RID: 34632
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CCA RID: 85194
			public static VerifyTableAction <0>__Verify;
		}
	}
}

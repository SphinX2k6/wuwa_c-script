using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007471 RID: 29809
	public static class ITriggerActionsVerify
	{
		// Token: 0x0603627D RID: 221821 RVA: 0x0075CDF9 File Offset: 0x0075AFF9
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

		// Token: 0x02007EAE RID: 32430
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013BF0 RID: 80880
			public static VerifyTableAction <0>__Verify;
		}
	}
}

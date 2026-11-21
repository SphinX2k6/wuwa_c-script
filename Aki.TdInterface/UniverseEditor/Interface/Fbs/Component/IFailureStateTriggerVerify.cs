using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005792 RID: 22418
	public static class IFailureStateTriggerVerify
	{
		// Token: 0x060242B8 RID: 148152 RVA: 0x004F9198 File Offset: 0x004F7398
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFailureStateTriggerVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFailureStateTriggerVerify.<>O.<0>__Verify = new VerifyTableAction(IOperationsAfterEntityGroupFailureVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008375 RID: 33653
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145CD RID: 83405
			public static VerifyTableAction <0>__Verify;
		}
	}
}

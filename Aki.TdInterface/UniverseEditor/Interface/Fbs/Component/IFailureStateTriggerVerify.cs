using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200522A RID: 21034
	public static class IFailureStateTriggerVerify
	{
		// Token: 0x06022322 RID: 140066 RVA: 0x004BE6D4 File Offset: 0x004BC8D4
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

		// Token: 0x02007B1A RID: 31514
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401354D RID: 79181
			public static VerifyTableAction <0>__Verify;
		}
	}
}

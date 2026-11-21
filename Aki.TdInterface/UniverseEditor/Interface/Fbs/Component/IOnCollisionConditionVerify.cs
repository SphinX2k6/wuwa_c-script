using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C38 RID: 23608
	public static class IOnCollisionConditionVerify
	{
		// Token: 0x06027216 RID: 160278 RVA: 0x0055CA64 File Offset: 0x0055AC64
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 8UL, 8UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IOnCollisionConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IOnCollisionConditionVerify.<>O.<0>__Verify = new VerifyTableAction(ITriggerCountConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008423 RID: 33827
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014701 RID: 83713
			public static VerifyTableAction <0>__Verify;
		}
	}
}

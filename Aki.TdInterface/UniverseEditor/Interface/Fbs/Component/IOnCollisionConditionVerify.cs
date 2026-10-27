using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005697 RID: 22167
	public static class IOnCollisionConditionVerify
	{
		// Token: 0x06024FDD RID: 151517 RVA: 0x0051BEC8 File Offset: 0x0051A0C8
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

		// Token: 0x02007BC1 RID: 31681
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013672 RID: 79474
			public static VerifyTableAction <0>__Verify;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200569A RID: 22170
	public static class IOnDollGrabDeliveryPerformVerify
	{
		// Token: 0x06025003 RID: 151555 RVA: 0x0051C35C File Offset: 0x0051A55C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IOnDollGrabDeliveryPerformVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IOnDollGrabDeliveryPerformVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007BC2 RID: 31682
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013673 RID: 79475
			public static VerifyTableAction <0>__Verify;
		}
	}
}

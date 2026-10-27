using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EC6 RID: 28358
	public static class IResumeSystemRewardPopupVerify
	{
		// Token: 0x060321E6 RID: 205286 RVA: 0x006C6911 File Offset: 0x006C4B11
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IResumeSystemRewardPopupVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IResumeSystemRewardPopupVerify.<>O.<0>__Verify = new VerifyTableAction(IResumeGiantDeliveryRewardPopupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E1A RID: 32282
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139D6 RID: 80342
			public static VerifyTableAction <0>__Verify;
		}
	}
}

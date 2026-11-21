using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200764A RID: 30282
	public static class IResumeSystemRewardPopupVerify
	{
		// Token: 0x06035226 RID: 217638 RVA: 0x00722645 File Offset: 0x00720845
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

		// Token: 0x020086A6 RID: 34470
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A9A RID: 84634
			public static VerifyTableAction <0>__Verify;
		}
	}
}

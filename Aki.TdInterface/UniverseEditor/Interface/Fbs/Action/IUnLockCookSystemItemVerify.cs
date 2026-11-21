using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CC1 RID: 31937
	public static class IUnLockCookSystemItemVerify
	{
		// Token: 0x060399D5 RID: 235989 RVA: 0x007C6230 File Offset: 0x007C4430
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IUnLockCookSystemItemVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IUnLockCookSystemItemVerify.<>O.<0>__Verify = new VerifyTableAction(IUnlockCookSystemCookBookVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008753 RID: 34643
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CDA RID: 85210
			public static VerifyTableAction <0>__Verify;
		}
	}
}

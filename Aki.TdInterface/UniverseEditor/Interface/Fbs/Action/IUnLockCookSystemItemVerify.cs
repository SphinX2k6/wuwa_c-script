using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074CB RID: 29899
	public static class IUnLockCookSystemItemVerify
	{
		// Token: 0x060365C0 RID: 222656 RVA: 0x00762FE0 File Offset: 0x007611E0
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

		// Token: 0x02007EB9 RID: 32441
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013C00 RID: 80896
			public static VerifyTableAction <0>__Verify;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071A3 RID: 29091
	public static class IMechEscortFlyVerify
	{
		// Token: 0x0603298E RID: 207246 RVA: 0x006D64F0 File Offset: 0x006D46F0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMechEscortFlyVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMechEscortFlyVerify.<>O.<0>__Verify = new VerifyTableAction(IMechEscortPointVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008627 RID: 34343
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149F6 RID: 84470
			public static VerifyTableAction <0>__Verify;
		}
	}
}

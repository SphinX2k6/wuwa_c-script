using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073FF RID: 29695
	public static class IPermanentRogueRandomEventVerify
	{
		// Token: 0x06033F43 RID: 212803 RVA: 0x0070107C File Offset: 0x006FF27C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPermanentRogueRandomEventVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPermanentRogueRandomEventVerify.<>O.<0>__Verify = new VerifyTableAction(ISystemOptionVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008670 RID: 34416
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A5A RID: 84570
			public static VerifyTableAction <0>__Verify;
		}
	}
}

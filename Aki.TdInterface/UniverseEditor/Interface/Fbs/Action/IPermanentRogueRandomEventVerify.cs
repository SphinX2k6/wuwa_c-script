using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C98 RID: 27800
	public static class IPermanentRogueRandomEventVerify
	{
		// Token: 0x06030FE8 RID: 200680 RVA: 0x006A6B7C File Offset: 0x006A4D7C
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

		// Token: 0x02007DE6 RID: 32230
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013998 RID: 80280
			public static VerifyTableAction <0>__Verify;
		}
	}
}

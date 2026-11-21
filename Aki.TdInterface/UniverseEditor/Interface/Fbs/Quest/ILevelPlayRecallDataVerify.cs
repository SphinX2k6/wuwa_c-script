using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004342 RID: 17218
	public static class ILevelPlayRecallDataVerify
	{
		// Token: 0x060183C2 RID: 99266 RVA: 0x00374424 File Offset: 0x00372624
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILevelPlayRecallDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILevelPlayRecallDataVerify.<>O.<0>__Verify = new VerifyTableAction(ILevelPlayRecallConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008149 RID: 33097
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014222 RID: 82466
			public static VerifyTableAction <0>__Verify;
		}
	}
}

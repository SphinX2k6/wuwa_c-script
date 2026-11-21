using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200766B RID: 30315
	public static class IRogueRandomEventOptionVerify
	{
		// Token: 0x06035304 RID: 217860 RVA: 0x00723B20 File Offset: 0x00721D20
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRogueRandomEventOptionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRogueRandomEventOptionVerify.<>O.<0>__Verify = new VerifyTableAction(ISystemOptionVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086A7 RID: 34471
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A9B RID: 84635
			public static VerifyTableAction <0>__Verify;
		}
	}
}

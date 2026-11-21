using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007239 RID: 29241
	public static class IMontageParamVerify
	{
		// Token: 0x06032E8B RID: 208523 RVA: 0x006DF934 File Offset: 0x006DDB34
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMontageParamVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMontageParamVerify.<>O.<0>__Verify = new VerifyTableAction(IMontageIdVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008637 RID: 34359
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A0C RID: 84492
			public static VerifyTableAction <0>__Verify;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006714 RID: 26388
	public static class IActorFxEmotePlayVerify
	{
		// Token: 0x0602CB18 RID: 183064 RVA: 0x0061D6E0 File Offset: 0x0061B8E0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 8UL, 8UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IActorFxEmotePlayVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IActorFxEmotePlayVerify.<>O.<0>__Verify = new VerifyTableAction(IActorFxEmoteOverrideConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008541 RID: 34113
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040148A7 RID: 84135
			public static VerifyTableAction <0>__Verify;
		}
	}
}

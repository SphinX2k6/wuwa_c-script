using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060B2 RID: 24754
	public static class IActorFxEmotePlayVerify
	{
		// Token: 0x0602A437 RID: 173111 RVA: 0x005D3738 File Offset: 0x005D1938
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

		// Token: 0x02007CD0 RID: 31952
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013801 RID: 79873
			public static VerifyTableAction <0>__Verify;
		}
	}
}

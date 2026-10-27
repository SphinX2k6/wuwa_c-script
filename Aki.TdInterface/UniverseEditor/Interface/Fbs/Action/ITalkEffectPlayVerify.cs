using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072B2 RID: 29362
	public static class ITalkEffectPlayVerify
	{
		// Token: 0x060341A2 RID: 213410 RVA: 0x00700BB8 File Offset: 0x006FEDB8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITalkEffectPlayVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITalkEffectPlayVerify.<>O.<0>__Verify = new VerifyTableAction(ITalkCommonEffectVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E80 RID: 32384
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A64 RID: 80484
			public static VerifyTableAction <0>__Verify;
		}
	}
}

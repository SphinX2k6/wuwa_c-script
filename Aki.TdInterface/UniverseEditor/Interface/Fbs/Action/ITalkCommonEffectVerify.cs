using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072A9 RID: 29353
	public static class ITalkCommonEffectVerify
	{
		// Token: 0x0603415A RID: 213338 RVA: 0x00700404 File Offset: 0x006FE604
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITalkCommonEffectVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITalkCommonEffectVerify.<>O.<0>__Verify = new VerifyTableAction(IAbsolutePos2Verify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E7F RID: 32383
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A63 RID: 80483
			public static VerifyTableAction <0>__Verify;
		}
	}
}

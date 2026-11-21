using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200544D RID: 21581
	public static class IBossStateViewConfigVerify
	{
		// Token: 0x06021DEB RID: 138731 RVA: 0x004AB43C File Offset: 0x004A963C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IBossStateViewConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBossStateViewConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IDoubleViewBossStateViewStyleVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020082E8 RID: 33512
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144E7 RID: 83175
			public static VerifyTableAction <0>__Verify;
		}
	}
}

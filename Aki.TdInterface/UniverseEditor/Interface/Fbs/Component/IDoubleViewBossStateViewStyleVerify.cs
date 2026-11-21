using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005618 RID: 22040
	public static class IDoubleViewBossStateViewStyleVerify
	{
		// Token: 0x0602326E RID: 143982 RVA: 0x004D6844 File Offset: 0x004D4A44
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDoubleViewBossStateViewStyleVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDoubleViewBossStateViewStyleVerify.<>O.<0>__Verify = new VerifyTableAction(IMarkMainStateTextTargetVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008336 RID: 33590
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014567 RID: 83303
			public static VerifyTableAction <0>__Verify;
		}
	}
}

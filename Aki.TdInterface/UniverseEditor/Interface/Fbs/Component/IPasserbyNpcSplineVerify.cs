using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056E2 RID: 22242
	public static class IPasserbyNpcSplineVerify
	{
		// Token: 0x060252A9 RID: 152233 RVA: 0x0052145C File Offset: 0x0051F65C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPasserbyNpcSplineVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPasserbyNpcSplineVerify.<>O.<0>__Verify = new VerifyTableAction(IPasserbyNpcMoveStateVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007BCA RID: 31690
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013681 RID: 79489
			public static VerifyTableAction <0>__Verify;
		}
	}
}

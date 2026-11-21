using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CCE RID: 23758
	public static class IPasserbyNpcSplineVerify
	{
		// Token: 0x060276FA RID: 161530 RVA: 0x00565C18 File Offset: 0x00563E18
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

		// Token: 0x02008436 RID: 33846
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401471D RID: 83741
			public static VerifyTableAction <0>__Verify;
		}
	}
}

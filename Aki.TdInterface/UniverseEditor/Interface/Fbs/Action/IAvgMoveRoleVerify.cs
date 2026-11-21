using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006831 RID: 26673
	public static class IAvgMoveRoleVerify
	{
		// Token: 0x0602D94E RID: 186702 RVA: 0x0063CAF0 File Offset: 0x0063ACF0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAvgMoveRoleVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAvgMoveRoleVerify.<>O.<0>__Verify = new VerifyTableAction(IEaseDataVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008564 RID: 34148
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040148F8 RID: 84216
			public static VerifyTableAction <0>__Verify;
		}
	}
}

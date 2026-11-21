using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F23 RID: 24355
	public static class ISingleBtnQteVerify
	{
		// Token: 0x06028E2D RID: 167469 RVA: 0x00596198 File Offset: 0x00594398
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISingleBtnQteVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISingleBtnQteVerify.<>O.<0>__Verify = new VerifyTableAction(IQteCallbackVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ISingleBtnQteVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (ISingleBtnQteVerify.<>O.<0>__Verify = new VerifyTableAction(IQteCallbackVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200849B RID: 33947
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147B4 RID: 83892
			public static VerifyTableAction <0>__Verify;
		}
	}
}

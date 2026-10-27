using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005916 RID: 22806
	public static class ISingleBtnQteVerify
	{
		// Token: 0x060268C3 RID: 157891 RVA: 0x0054F52C File Offset: 0x0054D72C
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

		// Token: 0x02007C2C RID: 31788
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013712 RID: 79634
			public static VerifyTableAction <0>__Verify;
		}
	}
}

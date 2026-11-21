using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E34 RID: 15924
	public static class IBvbGetBoardCardVerify
	{
		// Token: 0x060156F1 RID: 87793 RVA: 0x003180B0 File Offset: 0x003162B0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IBvbGetBoardCardVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBvbGetBoardCardVerify.<>O.<0>__Verify = new VerifyTableAction(IBvbCardFilterGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020080B3 RID: 32947
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014132 RID: 82226
			public static VerifyTableAction <0>__Verify;
		}
	}
}

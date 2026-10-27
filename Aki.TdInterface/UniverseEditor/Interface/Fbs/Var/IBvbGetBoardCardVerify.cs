using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A59 RID: 14937
	public static class IBvbGetBoardCardVerify
	{
		// Token: 0x060143D5 RID: 82901 RVA: 0x002F4EC4 File Offset: 0x002F30C4
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

		// Token: 0x02007875 RID: 30837
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040130DD RID: 78045
			public static VerifyTableAction <0>__Verify;
		}
	}
}

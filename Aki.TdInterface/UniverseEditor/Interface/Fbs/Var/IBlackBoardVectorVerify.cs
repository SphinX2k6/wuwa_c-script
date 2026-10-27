using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A20 RID: 14880
	public static class IBlackBoardVectorVerify
	{
		// Token: 0x060141F8 RID: 82424 RVA: 0x002F1A5C File Offset: 0x002EFC5C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IBlackBoardVectorVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBlackBoardVectorVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007872 RID: 30834
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040130DA RID: 78042
			public static VerifyTableAction <0>__Verify;
		}
	}
}

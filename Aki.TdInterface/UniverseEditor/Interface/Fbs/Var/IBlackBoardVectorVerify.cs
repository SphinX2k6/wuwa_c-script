using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003DFB RID: 15867
	public static class IBlackBoardVectorVerify
	{
		// Token: 0x06015514 RID: 87316 RVA: 0x00314C48 File Offset: 0x00312E48
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

		// Token: 0x020080B0 RID: 32944
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401412F RID: 82223
			public static VerifyTableAction <0>__Verify;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D3F RID: 23871
	public static class IPickInteractComponentVerify
	{
		// Token: 0x06027B48 RID: 162632 RVA: 0x0056EA50 File Offset: 0x0056CC50
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPickInteractComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPickInteractComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IChessmanPickInteractionVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008445 RID: 33861
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014736 RID: 83766
			public static VerifyTableAction <0>__Verify;
		}
	}
}

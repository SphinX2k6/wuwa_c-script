using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200685A RID: 26714
	public static class IFoxAutoJumpVerify
	{
		// Token: 0x0602E944 RID: 190788 RVA: 0x0065A9EC File Offset: 0x00658BEC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFoxAutoJumpVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFoxAutoJumpVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D7E RID: 32126
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013904 RID: 80132
			public static VerifyTableAction <0>__Verify;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078E0 RID: 30944
	public static class ISimpleMoveVerify
	{
		// Token: 0x060367C8 RID: 223176 RVA: 0x0074B7DC File Offset: 0x007499DC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISimpleMoveVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISimpleMoveVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086F6 RID: 34550
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014B11 RID: 84753
			public static VerifyTableAction <0>__Verify;
		}
	}
}

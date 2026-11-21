using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059EF RID: 23023
	public static class IInteractPointIconConfigVerify
	{
		// Token: 0x06025982 RID: 153986 RVA: 0x00527C6C File Offset: 0x00525E6C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IInteractPointIconConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IInteractPointIconConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020083CD RID: 33741
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014663 RID: 83555
			public static VerifyTableAction <0>__Verify;
		}
	}
}

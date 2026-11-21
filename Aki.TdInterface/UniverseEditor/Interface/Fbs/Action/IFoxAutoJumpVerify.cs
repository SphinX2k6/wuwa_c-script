using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EEF RID: 28399
	public static class IFoxAutoJumpVerify
	{
		// Token: 0x0603122A RID: 201258 RVA: 0x006A9258 File Offset: 0x006A7458
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

		// Token: 0x020085F6 RID: 34294
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149B2 RID: 84402
			public static VerifyTableAction <0>__Verify;
		}
	}
}

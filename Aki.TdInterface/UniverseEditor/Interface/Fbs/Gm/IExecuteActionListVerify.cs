using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AAF RID: 19119
	public static class IExecuteActionListVerify
	{
		// Token: 0x0601CBE3 RID: 117731 RVA: 0x0040D018 File Offset: 0x0040B218
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IExecuteActionListVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IExecuteActionListVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008217 RID: 33303
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143D1 RID: 82897
			public static VerifyTableAction <0>__Verify;
		}
	}
}

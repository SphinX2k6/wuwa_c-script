using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E8A RID: 28298
	public static class IResetFocusConfigVerify
	{
		// Token: 0x06032030 RID: 204848 RVA: 0x006C3BC4 File Offset: 0x006C1DC4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IResetFocusConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IResetFocusConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IBaseCurveVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E15 RID: 32277
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139D0 RID: 80336
			public static VerifyTableAction <0>__Verify;
		}
	}
}

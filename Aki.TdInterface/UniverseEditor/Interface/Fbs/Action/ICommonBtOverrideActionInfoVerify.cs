using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AD2 RID: 27346
	public static class ICommonBtOverrideActionInfoVerify
	{
		// Token: 0x0602EF1A RID: 192282 RVA: 0x00664E60 File Offset: 0x00663060
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICommonBtOverrideActionInfoVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICommonBtOverrideActionInfoVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020085A2 RID: 34210
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014947 RID: 84295
			public static VerifyTableAction <0>__Verify;
		}
	}
}

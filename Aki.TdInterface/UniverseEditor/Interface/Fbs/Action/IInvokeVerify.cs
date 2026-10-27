using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069B3 RID: 27059
	public static class IInvokeVerify
	{
		// Token: 0x0602F47E RID: 193662 RVA: 0x00670904 File Offset: 0x0066EB04
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IInvokeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IInvokeVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D93 RID: 32147
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013923 RID: 80163
			public static VerifyTableAction <0>__Verify;
		}
	}
}

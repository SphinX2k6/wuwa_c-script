using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007066 RID: 28774
	public static class IInvokeVerify
	{
		// Token: 0x06031E5A RID: 204378 RVA: 0x006C1008 File Offset: 0x006BF208
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

		// Token: 0x0200860E RID: 34318
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149D4 RID: 84436
			public static VerifyTableAction <0>__Verify;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007063 RID: 28771
	public static class IInterludeActionsVerify
	{
		// Token: 0x06031E44 RID: 204356 RVA: 0x006C0D4C File Offset: 0x006BEF4C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IInterludeActionsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IInterludeActionsVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200860D RID: 34317
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149D3 RID: 84435
			public static VerifyTableAction <0>__Verify;
		}
	}
}

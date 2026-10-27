using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069B0 RID: 27056
	public static class IInterludeActionsVerify
	{
		// Token: 0x0602F468 RID: 193640 RVA: 0x00670648 File Offset: 0x0066E848
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

		// Token: 0x02007D92 RID: 32146
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013922 RID: 80162
			public static VerifyTableAction <0>__Verify;
		}
	}
}

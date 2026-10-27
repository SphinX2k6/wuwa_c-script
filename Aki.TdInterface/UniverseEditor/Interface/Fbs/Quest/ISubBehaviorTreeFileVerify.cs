using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200414D RID: 16717
	public static class ISubBehaviorTreeFileVerify
	{
		// Token: 0x060188CB RID: 100555 RVA: 0x00389EC0 File Offset: 0x003880C0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISubBehaviorTreeFileVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISubBehaviorTreeFileVerify.<>O.<0>__Verify = new VerifyTableAction(IBehaviorTreeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyVectorOfStrings(tablePos, 10, false) && verifier.VerifyVectorOfStrings(tablePos, 12, false) && verifier.VerifyVectorOfStrings(tablePos, 14, false) && verifier.VerifyString(tablePos, 16, false) && verifier.VerifyString(tablePos, 18, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007957 RID: 31063
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040132A4 RID: 78500
			public static VerifyTableAction <0>__Verify;
		}
	}
}

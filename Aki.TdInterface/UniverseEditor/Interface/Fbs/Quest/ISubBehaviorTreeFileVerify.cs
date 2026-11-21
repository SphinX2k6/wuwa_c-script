using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004591 RID: 17809
	public static class ISubBehaviorTreeFileVerify
	{
		// Token: 0x06019F93 RID: 106387 RVA: 0x003B447C File Offset: 0x003B267C
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

		// Token: 0x0200819F RID: 33183
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014308 RID: 82696
			public static VerifyTableAction <0>__Verify;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043CC RID: 17356
	public static class IPhotographSubTargetSpecificRoleVerify
	{
		// Token: 0x06018A4C RID: 100940 RVA: 0x00383C94 File Offset: 0x00381E94
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPhotographSubTargetSpecificRoleVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPhotographSubTargetSpecificRoleVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200815E RID: 33118
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014264 RID: 82532
			public static VerifyTableAction <0>__Verify;
		}
	}
}

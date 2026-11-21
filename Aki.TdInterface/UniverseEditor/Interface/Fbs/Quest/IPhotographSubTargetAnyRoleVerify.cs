using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043C9 RID: 17353
	public static class IPhotographSubTargetAnyRoleVerify
	{
		// Token: 0x06018A2A RID: 100906 RVA: 0x00383888 File Offset: 0x00381A88
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPhotographSubTargetAnyRoleVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPhotographSubTargetAnyRoleVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200815D RID: 33117
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014263 RID: 82531
			public static VerifyTableAction <0>__Verify;
		}
	}
}

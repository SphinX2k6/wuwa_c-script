using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F88 RID: 16264
	public static class IPhotographSubTargetAnyRoleVerify
	{
		// Token: 0x0601739B RID: 95131 RVA: 0x00359C70 File Offset: 0x00357E70
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

		// Token: 0x02007916 RID: 30998
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013201 RID: 78337
			public static VerifyTableAction <0>__Verify;
		}
	}
}

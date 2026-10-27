using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F8B RID: 16267
	public static class IPhotographSubTargetSpecificRoleVerify
	{
		// Token: 0x060173BD RID: 95165 RVA: 0x0035A07C File Offset: 0x0035827C
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

		// Token: 0x02007917 RID: 30999
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013202 RID: 78338
			public static VerifyTableAction <0>__Verify;
		}
	}
}

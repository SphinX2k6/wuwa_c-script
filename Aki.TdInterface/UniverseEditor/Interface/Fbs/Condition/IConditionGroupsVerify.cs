using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050D8 RID: 20696
	public static class IConditionGroupsVerify
	{
		// Token: 0x0602081E RID: 133150 RVA: 0x00482BE4 File Offset: 0x00480DE4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IConditionGroupsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IConditionGroupsVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020082AB RID: 33451
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014491 RID: 83089
			public static VerifyTableAction <0>__Verify;
		}
	}
}

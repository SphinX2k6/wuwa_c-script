using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FE4 RID: 20452
	public static class IConditionActionVerify
	{
		// Token: 0x06020AEC RID: 133868 RVA: 0x0048B55C File Offset: 0x0048975C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IConditionActionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IConditionActionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IConditionActionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IConditionActionVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007AB9 RID: 31417
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134A7 RID: 79015
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040134A8 RID: 79016
			public static VerifyTableAction <1>__Verify;
		}
	}
}

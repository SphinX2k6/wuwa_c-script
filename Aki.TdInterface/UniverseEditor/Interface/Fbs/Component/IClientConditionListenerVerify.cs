using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FA5 RID: 20389
	public static class IClientConditionListenerVerify
	{
		// Token: 0x06020704 RID: 132868 RVA: 0x00483478 File Offset: 0x00481678
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IClientConditionListenerVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IClientConditionListenerVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IClientConditionListenerVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IClientConditionListenerVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007AB0 RID: 31408
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401349C RID: 79004
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401349D RID: 79005
			public static VerifyTableAction <1>__Verify;
		}
	}
}

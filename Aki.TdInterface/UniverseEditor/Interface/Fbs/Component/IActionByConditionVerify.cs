using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005354 RID: 21332
	public static class IActionByConditionVerify
	{
		// Token: 0x0602134A RID: 136010 RVA: 0x0049520C File Offset: 0x0049340C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IActionByConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IActionByConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IActionByConditionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IActionByConditionVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020082BD RID: 33469
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144A4 RID: 83108
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040144A5 RID: 83109
			public static VerifyTableAction <1>__Verify;
		}
	}
}

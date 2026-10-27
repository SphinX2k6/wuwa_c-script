using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E43 RID: 20035
	public static class IActionByConditionVerify
	{
		// Token: 0x0601F6FF RID: 128767 RVA: 0x004611F4 File Offset: 0x0045F3F4
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

		// Token: 0x02007A6B RID: 31339
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013434 RID: 78900
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013435 RID: 78901
			public static VerifyTableAction <1>__Verify;
		}
	}
}

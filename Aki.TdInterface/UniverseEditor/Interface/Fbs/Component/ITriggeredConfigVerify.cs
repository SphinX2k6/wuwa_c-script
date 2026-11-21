using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060F3 RID: 24819
	public static class ITriggeredConfigVerify
	{
		// Token: 0x0602A0EB RID: 172267 RVA: 0x005BDB20 File Offset: 0x005BBD20
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITriggeredConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITriggeredConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITriggeredConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITriggeredConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020084DC RID: 34012
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401482F RID: 84015
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014830 RID: 84016
			public static VerifyTableAction <1>__Verify;
		}
	}
}

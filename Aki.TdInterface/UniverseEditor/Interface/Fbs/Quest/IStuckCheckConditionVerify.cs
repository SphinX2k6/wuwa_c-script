using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200458E RID: 17806
	public static class IStuckCheckConditionVerify
	{
		// Token: 0x06019F49 RID: 106313 RVA: 0x003B39A8 File Offset: 0x003B1BA8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IStuckCheckConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IStuckCheckConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IStuckCheckConditionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IStuckCheckConditionVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200819E RID: 33182
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014306 RID: 82694
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014307 RID: 82695
			public static VerifyTableAction <1>__Verify;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005543 RID: 21827
	public static class IConditionActionVerify
	{
		// Token: 0x06022A0C RID: 141836 RVA: 0x004C4FAC File Offset: 0x004C31AC
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

		// Token: 0x02008313 RID: 33555
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014525 RID: 83237
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014526 RID: 83238
			public static VerifyTableAction <1>__Verify;
		}
	}
}

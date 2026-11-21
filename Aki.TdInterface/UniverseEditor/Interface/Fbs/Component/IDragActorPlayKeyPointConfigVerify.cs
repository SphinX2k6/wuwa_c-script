using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005621 RID: 22049
	public static class IDragActorPlayKeyPointConfigVerify
	{
		// Token: 0x06023328 RID: 144168 RVA: 0x004D832C File Offset: 0x004D652C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDragActorPlayKeyPointConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDragActorPlayKeyPointConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyString(tablePos, 14, false) && verifier.VerifyString(tablePos, 16, false))
				{
					short offsetId2 = 18;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IDragActorPlayKeyPointConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IDragActorPlayKeyPointConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 20;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IDragActorPlayKeyPointConfigVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IDragActorPlayKeyPointConfigVerify.<>O.<2>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02008339 RID: 33593
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401456C RID: 83308
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401456D RID: 83309
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401456E RID: 83310
			public static VerifyTableAction <2>__Verify;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050BC RID: 20668
	public static class IDragActorPlayKeyPointConfigVerify
	{
		// Token: 0x060213D4 RID: 136148 RVA: 0x0049E3A0 File Offset: 0x0049C5A0
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

		// Token: 0x02007ADF RID: 31455
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134EE RID: 79086
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040134EF RID: 79087
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040134F0 RID: 79088
			public static VerifyTableAction <2>__Verify;
		}
	}
}

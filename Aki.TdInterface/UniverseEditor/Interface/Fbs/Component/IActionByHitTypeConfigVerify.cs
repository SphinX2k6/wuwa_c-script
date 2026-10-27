using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E46 RID: 20038
	public static class IActionByHitTypeConfigVerify
	{
		// Token: 0x0601F72B RID: 128811 RVA: 0x004619EC File Offset: 0x0045FBEC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IActionByHitTypeConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IActionByHitTypeConfigVerify.<>O.<0>__Verify = new VerifyUnionAction(THitBulletTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IActionByHitTypeConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IActionByHitTypeConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false))
					{
						short offsetId2 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IActionByHitTypeConfigVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IActionByHitTypeConfigVerify.<>O.<2>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction3, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007A6C RID: 31340
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013436 RID: 78902
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04013437 RID: 78903
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013438 RID: 78904
			public static VerifyTableAction <2>__Verify;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200594F RID: 22863
	public static class ISpawnMonsterComponentVerify
	{
		// Token: 0x06026B13 RID: 158483 RVA: 0x00553FF0 File Offset: 0x005521F0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISpawnMonsterComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISpawnMonsterComponentVerify.<>O.<0>__Verify = new VerifyUnionAction(TSpawnMonsterStartConditionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ISpawnMonsterComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ISpawnMonsterComponentVerify.<>O.<1>__Verify = new VerifyTableAction(ISpawnMonsterConfigVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						short offsetId2 = 14;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ISpawnMonsterComponentVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ISpawnMonsterComponentVerify.<>O.<2>__Verify = new VerifyTableAction(ISpawnMonsterConstraintAnnularSectorVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId2, verifyAction3, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007C32 RID: 31794
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401371B RID: 79643
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x0401371C RID: 79644
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401371D RID: 79645
			public static VerifyTableAction <2>__Verify;
		}
	}
}

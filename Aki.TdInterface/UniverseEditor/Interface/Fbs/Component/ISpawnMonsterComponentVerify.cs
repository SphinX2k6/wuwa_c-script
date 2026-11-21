using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F5C RID: 24412
	public static class ISpawnMonsterComponentVerify
	{
		// Token: 0x0602907D RID: 168061 RVA: 0x0059AC5C File Offset: 0x00598E5C
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

		// Token: 0x020084A1 RID: 33953
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147BD RID: 83901
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x040147BE RID: 83902
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040147BF RID: 83903
			public static VerifyTableAction <2>__Verify;
		}
	}
}

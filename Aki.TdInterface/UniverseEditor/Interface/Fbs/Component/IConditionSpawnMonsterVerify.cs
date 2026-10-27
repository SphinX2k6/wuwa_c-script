using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FFC RID: 20476
	public static class IConditionSpawnMonsterVerify
	{
		// Token: 0x06020BCE RID: 134094 RVA: 0x0048D568 File Offset: 0x0048B768
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IConditionSpawnMonsterVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IConditionSpawnMonsterVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IConditionSpawnMonsterVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IConditionSpawnMonsterVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IConditionSpawnMonsterVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (IConditionSpawnMonsterVerify.<>O.<1>__Verify = new VerifyTableAction(IDynamicSpawnMonsterConfigVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007AC1 RID: 31425
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134B4 RID: 79028
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040134B5 RID: 79029
			public static VerifyTableAction <1>__Verify;
		}
	}
}

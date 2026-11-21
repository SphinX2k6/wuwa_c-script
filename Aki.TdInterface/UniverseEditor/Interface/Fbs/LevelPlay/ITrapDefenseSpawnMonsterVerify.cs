using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A24 RID: 18980
	public static class ITrapDefenseSpawnMonsterVerify
	{
		// Token: 0x0601C7E1 RID: 116705 RVA: 0x00405B9C File Offset: 0x00403D9C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITrapDefenseSpawnMonsterVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITrapDefenseSpawnMonsterVerify.<>O.<0>__Verify = new VerifyTableAction(ITrapDefenseSpawnMonsterGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITrapDefenseSpawnMonsterVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITrapDefenseSpawnMonsterVerify.<>O.<1>__Verify = new VerifyTableAction(ITrapDefenseSpawnMonsterConditionGroupVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 16, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200820E RID: 33294
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143C7 RID: 82887
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040143C8 RID: 82888
			public static VerifyTableAction <1>__Verify;
		}
	}
}

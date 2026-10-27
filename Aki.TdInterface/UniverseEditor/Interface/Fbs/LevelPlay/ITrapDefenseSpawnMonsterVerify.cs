using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045BC RID: 17852
	public static class ITrapDefenseSpawnMonsterVerify
	{
		// Token: 0x0601B00C RID: 110604 RVA: 0x003D9900 File Offset: 0x003D7B00
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

		// Token: 0x020079C5 RID: 31173
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013360 RID: 78688
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013361 RID: 78689
			public static VerifyTableAction <1>__Verify;
		}
	}
}

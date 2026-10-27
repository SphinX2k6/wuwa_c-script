using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005952 RID: 22866
	public static class ISpawnMonsterConfigVerify
	{
		// Token: 0x06026B46 RID: 158534 RVA: 0x005547F0 File Offset: 0x005529F0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 8, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
			{
				short typeIdVOffset = 10;
				short valueVOffset = 12;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISpawnMonsterConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISpawnMonsterConfigVerify.<>O.<0>__Verify = new VerifyUnionAction(TSpawnMonsterCompleteConditionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 14;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ISpawnMonsterConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ISpawnMonsterConfigVerify.<>O.<1>__Verify = new VerifyTableAction(ISpawnMonsterPreDependOnPrecedingVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007C33 RID: 31795
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401371E RID: 79646
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x0401371F RID: 79647
			public static VerifyTableAction <1>__Verify;
		}
	}
}

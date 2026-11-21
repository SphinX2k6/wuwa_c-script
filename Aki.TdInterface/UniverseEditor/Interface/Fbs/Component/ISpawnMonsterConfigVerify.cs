using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F5F RID: 24415
	public static class ISpawnMonsterConfigVerify
	{
		// Token: 0x060290B0 RID: 168112 RVA: 0x0059B45C File Offset: 0x0059965C
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

		// Token: 0x020084A2 RID: 33954
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147C0 RID: 83904
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x040147C1 RID: 83905
			public static VerifyTableAction <1>__Verify;
		}
	}
}

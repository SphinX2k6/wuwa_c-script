using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050FE RID: 20734
	public static class IDynamicSpawnMonsterConfigVerify
	{
		// Token: 0x0602166B RID: 136811 RVA: 0x004A3684 File Offset: 0x004A1884
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IDynamicSpawnMonsterConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDynamicSpawnMonsterConfigVerify.<>O.<0>__Verify = new VerifyUnionAction(TSpawnMonsterCompleteConditionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IDynamicSpawnMonsterConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IDynamicSpawnMonsterConfigVerify.<>O.<1>__Verify = new VerifyTableAction(ISpawnMonsterPreDependOnPrecedingVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false))
					{
						short offsetId2 = 16;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IDynamicSpawnMonsterConfigVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IDynamicSpawnMonsterConfigVerify.<>O.<2>__Verify = new VerifyTableAction(IRandomPoolChooseVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId2, verifyAction3, false))
						{
							short offsetId3 = 18;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IDynamicSpawnMonsterConfigVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (IDynamicSpawnMonsterConfigVerify.<>O.<3>__Verify = new VerifyTableAction(ISpawnMonsterPointVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId3, verifyAction4, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007AE8 RID: 31464
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134FE RID: 79102
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x040134FF RID: 79103
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013500 RID: 79104
			public static VerifyTableAction <2>__Verify;

			// Token: 0x04013501 RID: 79105
			public static VerifyTableAction <3>__Verify;
		}
	}
}

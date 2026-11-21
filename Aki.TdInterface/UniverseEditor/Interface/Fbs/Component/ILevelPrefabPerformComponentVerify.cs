using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A70 RID: 23152
	public static class ILevelPrefabPerformComponentVerify
	{
		// Token: 0x06025E98 RID: 155288 RVA: 0x0053291C File Offset: 0x00530B1C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILevelPrefabPerformComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILevelPrefabPerformComponentVerify.<>O.<0>__Verify = new VerifyTableAction(ITowardEntityConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ILevelPrefabPerformComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ILevelPrefabPerformComponentVerify.<>O.<1>__Verify = new VerifyTableAction(ILevelPrefabParamsConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ILevelPrefabPerformComponentVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ILevelPrefabPerformComponentVerify.<>O.<2>__Verify = new VerifyTableAction(IPrefabCompTransformVerify.Verify));
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

		// Token: 0x020083E1 RID: 33761
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014689 RID: 83593
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401468A RID: 83594
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401468B RID: 83595
			public static VerifyTableAction <2>__Verify;
		}
	}
}

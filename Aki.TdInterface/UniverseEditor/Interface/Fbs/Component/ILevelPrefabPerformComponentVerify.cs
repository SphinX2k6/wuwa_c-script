using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054EA RID: 21738
	public static class ILevelPrefabPerformComponentVerify
	{
		// Token: 0x06023DDE RID: 146910 RVA: 0x004F57F8 File Offset: 0x004F39F8
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

		// Token: 0x02007B82 RID: 31618
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013603 RID: 79363
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013604 RID: 79364
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013605 RID: 79365
			public static VerifyTableAction <2>__Verify;
		}
	}
}
